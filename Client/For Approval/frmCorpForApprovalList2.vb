Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmCorpForApprovalList2

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        If EnableModuleSales = True Then
            If Tabcontrol1.TabPages.Contains(tabDiscount) = False Then
                Tabcontrol1.TabPages.Add(tabDiscount)
                cmdSalesDiscount.Visible = True
                lineSales.Visible = True
            End If
        Else
            Tabcontrol1.TabPages.Remove(tabDiscount)
            cmdSalesDiscount.Visible = False
            lineSales.Visible = False
        End If
        If EnableModuleHotel = True Then
            If Tabcontrol1.TabPages.Contains(tabHotelDiscount) = False Then
                Tabcontrol1.TabPages.Add(tabHotelDiscount)
                cmdHotel.Visible = True
                lineHotel.Visible = True
            End If
        Else
            Tabcontrol1.TabPages.Remove(tabHotelDiscount)
            cmdHotel.Visible = False
            lineHotel.Visible = False
        End If
        FilterSelectedTab()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabcontrol1.SelectedIndexChanged
        FilterSelectedTab()
    End Sub

    Public Function FilterSelectedTab()
        If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
            ShowHotelDiscountsForApproval(txtfilter.Text)
            cmdDisapproved.Visible = True
        ElseIf Tabcontrol1.SelectedTab Is tabDiscount Then
            ShowDiscountsForApproval(txtfilter.Text)
            cmdDisapproved.Visible = False
        ElseIf Tabcontrol1.SelectedTab Is tabRequisitions Then
            ShowByRequesitions(txtfilter.Text)

        ElseIf Tabcontrol1.SelectedTab Is tabPurchaseOrder Then
            ShowByPurchaseOrder(txtfilter.Text)

        ElseIf Tabcontrol1.SelectedTab Is tabAccountsPayable Then
            ShowByAccountsPayable(txtfilter.Text)

        ElseIf Tabcontrol1.SelectedTab Is tabFFEforDisposal Then
            FFEforDisposal()

        End If
        ApplySystemTheme(ToolStrip3)
        MainForm.PendingTransactionCount()
    End Function

    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            FilterSelectedTab()
        End If
    End Sub

#Region "HOTEL DISCOUNTS"
    Public Sub ShowHotelDiscountsForApproval(ByVal SearchKey As String)
        DataGridView_hoteldiscount.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, folioid as 'Folio Number', (select fullname from tblhotelguest where guestid=tblhotelroomsdiscounttransaction.guestid) as 'Guest', noofdays as 'No. of Days', description as 'Discount Type', roomrate as 'Room Rate',discountrate as 'Discount Rate (%)', totaldiscount as 'Total Discount', subtotal as 'Sub Total',  TotalAmount as 'Total Amount',Remarks, (select fullname from tblaccounts where accountid=tblhotelroomsdiscounttransaction.trnby) as 'Request by', datetrn as 'Date Transaction' from tblhotelroomsdiscounttransaction where discountoveride=0 and disapproved=0 order by datetrn asc;", conn)
        msda.Fill(dst, 0)
        DataGridView_hoteldiscount.DataSource = dst.Tables(0)
        GridHideColumn(DataGridView_hoteldiscount, {"id"})
        GridCurrencyColumn(DataGridView_hoteldiscount, {"Sub Total", "Room Rate", "Total Discount", "Total Amount"})
        GridColumnAlignment(DataGridView_hoteldiscount, {"Folio Number", "No. of Days", "Discount Rate (%)"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub DisapproveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdDisapproved.Click
        If MessageBox.Show("Are you sure you want to disapprove this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
                For Each rw As DataGridViewRow In DataGridView_hoteldiscount.SelectedRows
                    com.CommandText = "update tblhotelroomsdiscounttransaction set disapproved=1,disapprovedby='" & globaluserid & "',datedisapproved=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                    RecordApprovingHistory("hotel", rw.Cells("Folio Number").Value.ToString, rw.Cells("Folio Number").Value.ToString, "Disapproved", rw.Cells("Discount Type").Value.ToString & ": " & rw.Cells("Total Discount").Value.ToString & " - " & rw.Cells("Request by").Value.ToString)
                Next
            End If

            FilterSelectedTab()
            MessageBox.Show("Request successfully Disapproved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "DISCOUNTS"

    Public Sub ShowDiscountsForApproval(ByVal SearchKey As String)
        MyDataGridView_Discounts.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,  batchcode as 'Batch Code',   " _
                                            + " productname as 'Particular' , " _
                                            + "  total as 'Amount', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction',(select fullname from tblaccounts where accountid=tblsalestransaction.userid) as 'Cashier' from tblsalestransaction where cancelled=0 and void=0  and total < 0 and adjoveride=0 order by datetrn asc;", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Discounts.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Discounts, {"datetrn", "id"})
        GridCurrencyColumn(MyDataGridView_Discounts, {"Amount"})
        GridColumnAlignment(MyDataGridView_Discounts, {"Batch Code"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Discounts, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
            ShowHotelDiscountsForApproval(txtfilter.Text)
        Else
            ShowDiscountsForApproval(txtfilter.Text)
        End If

    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to approve this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
                For Each rw As DataGridViewRow In DataGridView_hoteldiscount.SelectedRows
                    com.CommandText = "update tblhotelroomsdiscounttransaction set discountoveride=1,discountoverideby='" & globaluserid & "',dateoveride=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                    RecordApprovingHistory("hotel", rw.Cells("Folio Number").Value.ToString, rw.Cells("Folio Number").Value.ToString, "Override", rw.Cells("Discount Type").Value.ToString & ": " & rw.Cells("Total Discount").Value.ToString & " - " & rw.Cells("Request by").Value.ToString)
                Next
            Else
                For Each rw As DataGridViewRow In MyDataGridView_Discounts.SelectedRows
                    com.CommandText = "update tblsalestransaction set adjoveride=1,adjoverideby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                    RecordApprovingHistory("sales", rw.Cells("Batch Code").Value.ToString, rw.Cells("Batch Code").Value.ToString, "Override", rw.Cells("Particular").Value.ToString & ": " & rw.Cells("Amount").Value.ToString & " - " & rw.Cells("Cashier").Value.ToString)
                Next
            End If

            FilterSelectedTab()
            MessageBox.Show("Request successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region "REQUISITIONS"
    Public Sub ShowByRequesitions(ByVal SearchKey As String)
        MyDataGridView_Requisitions.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select pid as 'Request No', Priority, " _
                  + " (select officename from tblcompoffice where officeid = tblrequisitions.officeid) as 'Branch', " _
                  + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) as 'Request By' , " _
                  + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID) as 'Request Type', " _
                  + " (select fullname from tblhotelguest where guestid=tblrequisitions.allocatedexpense) as 'Allocated Expense', " _
                  + " ifnull((select sum(quantity) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Item', " _
                  + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) as 'Total Amount', " _
                  + " date_format(DATEREQUEST, '%Y-%m-%d') as 'Date Request', " _
                  + " date_format(DATEREQUEST, '%r') as 'Time Request', " _
                  + " (select fullname from tblaccounts where accountid = tblrequisitions.trnby) as 'Transaction By',  " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblrequisitions.pid or refnumber in (select trnid from tblrequisitionsitem where pid = tblrequisitions.pid)),'-') as 'Attachment', " _
                  + " 'For Approval' as 'Status' " _
                  + " from tblrequisitions where if((select customcorporateapproval from tblcompoffice where officeid = tblrequisitions.officeid limit 1) = true, " _
                  + " (select group_concat(authorizedid) from tblapprovermainprocess where tblrequisitions.potypeid = tblapprovermainprocess.requestcode and apptype='requisition-approving-process' and customized=1 and officeid = tblrequisitions.officeid and left(applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=tblrequisitions.pid and `status`='approved'  and applevel<>'-' and corporateapproval=1 order by dateconfirm desc limit 1),1)) , " _
                  + " (select group_concat(authorizedid) from tblapprovermainprocess where tblrequisitions.potypeid = tblapprovermainprocess.requestcode and apptype='requisition-approving-process' and customized=0 and left(applevel,1) = ifnull((select cast(count(*)+1 as UNSIGNED) from tblapprovalhistory where referenceno=tblrequisitions.pid and `status`='approved'  and applevel<>'-' and corporateapproval=1 order by dateconfirm desc limit 1),1) limit 1) " _
                  + " ) like '%" & globaluserid & "%' and corporatelevel=1 and approvedbranch=1 and approvedcorporate=0 and received=1 and cancelled=0 and disapproved=0 and hold=0 and " _
                  + " ((select officename from tblcompoffice where officeid = tblrequisitions.officeid) like '%" & SearchKey & "%' or " _
                  + " (select fullname from tblaccounts where accountid = tblrequisitions.REQUESTBY) like '%" & SearchKey & "%' or " _
                  + " (select DESCRIPTION from tblrequesttype where POTYPEID=tblrequisitions.POTYPEID)  like '%" & SearchKey & "%' or " _
                  + " ifnull((select sum(total) from tblrequisitionsitem where pid=tblrequisitions.pid),0) like '%" & SearchKey & "%' or " _
                  + " date_format(DATEREQUEST, '%Y-%m-%d') like '%" & SearchKey & "%') " _
                  + " order by daterequest desc", conn)
        'msda = New MySqlDataAdapter("select * from view_requisition_corporate where current_level in (select left(applevel,1) from tblapprovermainprocess where apptype='requisition-approving-process' and authorizedid='" & globaluserid & "') ;", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Requisitions.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Requisitions, {"Request No", "Priority", "Total Item", "Date Request", "Time Request", "Attachment", "Status"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Requisitions, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
        For i = 0 To MyDataGridView_Requisitions.RowCount - 1
            If MyDataGridView_Requisitions.Item("Priority", i).Value = "Emergency" Then
                MyDataGridView_Requisitions.Rows(i).Cells("Priority").Style.BackColor = Color.Red
                MyDataGridView_Requisitions.Rows(i).Cells("Priority").Style.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub MyDataGridView_Requisitions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_Requisitions.CellDoubleClick
        If MyDataGridView_Requisitions.Item("Request No", MyDataGridView_Requisitions.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        frmForApproval_RequisitionsCorporate.pid.Text = MyDataGridView_Requisitions.Item("Request No", MyDataGridView_Requisitions.CurrentRow.Index).Value().ToString()
        frmForApproval_RequisitionsCorporate.Show(Me)
    End Sub

    Private Sub MyDataGridView_Requisitions_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView_Requisitions.CellFormatting
        On Error Resume Next
        Dim colCurrency As Array = {"Total Amount"}
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                For Each valueArr As String In colCurrency
                    If e.ColumnIndex = MyDataGridView_Requisitions.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                Next
            End If
        End If
    End Sub
#End Region

#Region "PURCHASE ORDER"
    Public Sub ShowByPurchaseOrder(ByVal SearchKey As String)
        MyDataGridView_PurchaseOrder.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select requestref,vendorid, ponumber as 'PO Number', (select priority from tblrequisitions where pid = tblpurchaseorder.requestref) as Priority, " _
                   + " (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) as 'Office', " _
                   + " (select ucase(companyname) from tblglobalvendor where vendorid = tblpurchaseorder.vendorid) as 'Supplier', " _
                   + " (select sum(quantity) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber) as 'Total Item', " _
                   + " (select sum(total) from tblpurchaseorderitem where ponumber=tblpurchaseorder.ponumber) as 'Total', " _
                   + " (select fullname from tblaccounts where accountid = tblpurchaseorder.createby) as 'Generated By', " _
                   + " date_format(tblpurchaseorder.datetrn,'%Y-%m-%d') as 'Date Generated', " _
                   + " date_format(tblpurchaseorder.datetrn,'%r') as 'Time Generated', " _
                   + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where (refnumber = tblpurchaseorder.ponumber or refnumber = tblpurchaseorder.requestref)),'-') as 'Attachment' " _
                   + " from tblpurchaseorder " _
                   + " where verified=0 and forpo=1 and corporatelevel=1 and cancelled=0 and " _
                   + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblpurchaseorder.ponumber and status='approved' and applevel<>'-' and approvaltype='purchase-order') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='purchase-order-signatories')  " _
                   + " order by datetrn desc", conn)

        msda.Fill(dst, 0)
        MyDataGridView_PurchaseOrder.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_PurchaseOrder, {"requestref", "vendorid"})
        GridColumnAlignment(MyDataGridView_PurchaseOrder, {"PO Number", "Priority", "Total Item", "Attachment", "Date Generated", "Time Generated"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_PurchaseOrder, {"Total"}, DataGridViewContentAlignment.MiddleRight)
        For i = 0 To MyDataGridView_Requisitions.RowCount - 1
            If MyDataGridView_Requisitions.Item("Priority", i).Value = "Emergency" Then
                MyDataGridView_Requisitions.Rows(i).Cells("Priority").Style.BackColor = Color.Red
                MyDataGridView_Requisitions.Rows(i).Cells("Priority").Style.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub MyDataGridView_PurchaseOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_PurchaseOrder.CellDoubleClick
        If MyDataGridView_PurchaseOrder.Item("PO Number", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        'frmForApproval_PurchaseOrder.pid.Text = MyDataGridView_PurchaseOrder.Item("requestref", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString()
        'frmForApproval_PurchaseOrder.vendorid.Text = MyDataGridView_PurchaseOrder.Item("vendorid", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString()
        frmForApproval_PurchaseOrder.ponumber.Text = MyDataGridView_PurchaseOrder.Item("PO Number", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString()
        frmForApproval_PurchaseOrder.Show(Me)
    End Sub
    Private Sub MyDataGridView_PurchaseOrder_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MyDataGridView_PurchaseOrder.CellFormatting
        On Error Resume Next
        Dim colCurrency As Array = {"Total"}
        If Not IsNothing(e.Value) Then
            If IsNumeric(e.Value) Then
                For Each valueArr As String In colCurrency
                    If e.ColumnIndex = MyDataGridView_PurchaseOrder.Columns(valueArr).Index Then
                        e.Value = Format(CDbl(e.Value).ToString("n"), e.CellStyle.Format)
                    End If
                Next
            End If
        End If
    End Sub
#End Region

#Region "DISBURSEMENT VOUCHER"
    Public Sub ShowByAccountsPayable(ByVal SearchKey As String)
        MyDataGridView_AccountsPayable.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select  voucherno as 'Voucher No.', date_format(voucherdate,'%Y-%m-%d') as 'Date', if(directexpense=1,'Direct Exppense','Accounts Payable') as 'Disbursement Type', (select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company', (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office', if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Claimant', " _
                                    + "  case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By' from tbldisbursementvoucher " _
                   + " where cancelled=0 and corporatelevel=1 and verified=0 and hold=0 and " _
                   + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tbldisbursementvoucher.voucherno and (status='approved' or status='disbursed')  and applevel<>'-' and approvaltype='voucher') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='voucher-signatories') " _
                   + " order by voucherdate asc", conn)


        msda.Fill(dst, 0)
        MyDataGridView_AccountsPayable.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Voucher No.", "Disbursement Type", "Date", "Office", "Clasification", "Source Fund"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_AccountsPayable, {"Amount"})
    End Sub

    Private Sub MyDataGridView_PaymentConfirmation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_AccountsPayable.CellDoubleClick
        If MyDataGridView_AccountsPayable.Item("Voucher No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        frmForApproval_DisbursementVoucher.voucherno.Text = MyDataGridView_AccountsPayable.Item("Voucher No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString()
        frmForApproval_DisbursementVoucher.Show(Me)
    End Sub

#End Region

#Region "FFE FOR DISPOSAL"
    Public Sub FFEforDisposal()
        MyDataGridView_FFE.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select ffecode as 'FFE Code', officeid, " _
                  + " productid as 'Product Code', " _
                  + " productname as 'Particular', " _
                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'FFE Type', " _
                  + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
                  + " categoryname as 'Category', " _
                  + " Quantity, Unit, unitcost as 'Unit Cost', totalamount as Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
                  + " (select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as 'Supplier', " _
                  + " if(warranty=1,date_format(warrantydate,'%Y-%m-%d'),'-') as 'Date Warranty', " _
                  + " bookvalue as 'Book Value', monthlydepreciation as 'Monthly Depreciation', date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
                  + " acctableperson as 'Accountable Person', date_format(acctdateissued, '%Y-%m-%d') as 'Date Issued', " _
                  + " date_format(disposaldaterequested,'%Y-%m-%d') as 'Date Requested', " _
                  + " (select fullname from tblaccounts where accountid=tblinventoryffe.disposalrequestedby) as 'Request for Disposal By', " _
                  + " Flaged, " _
                  + " flagedreason as 'Flaged Reason' " _
                  + " from tblinventoryffe " _
                  + " where disposalrequested=1 and disposalrequestcorporatelevel=1 and disposalapproved=0 and  " _
                  + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblinventoryffe.ffecode and status='approved' and applevel<>'-' and approvaltype='ffe-for-disposal') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='ffe-for-disposal')  " _
                  + " order by disposaldaterequested desc", conn)


        msda.Fill(dst, 0)
        MyDataGridView_FFE.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_FFE, {"officeid"})
        GridColumnAlignment(MyDataGridView_FFE, {"FFE Code", "FFE Type", "Product Code", "Quantity", "Unit", "Status", "Date Purchased", "Date Warranty", "Last Depreciation Date", "Date Requested", "Date Issued"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView_FFE, {"Unit Cost", "Total", "Book Value", "Monthly Depreciation"})
    End Sub


    Private Sub MyDataGridView_FFE_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_FFE.CellDoubleClick
        cmdEdit.PerformClick()
    End Sub

    Private Sub cmdViewProfile_Click(sender As Object, e As EventArgs) Handles cmdViewProfile.Click
        frmNewInventoryEntry.mode.Text = "view"
        frmNewInventoryEntry.officeid.Text = MyDataGridView_FFE.Item("officeid", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmNewInventoryEntry.ffecode.Text = MyDataGridView_FFE.Item("FFE Code", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmNewInventoryEntry.Show(Me)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmFFEDisposalConfirmation.FFECode.Text = MyDataGridView_FFE.Item("FFE Code", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmFFEDisposalConfirmation.txtDescription.Text = MyDataGridView_FFE.Item("Particular", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmFFEDisposalConfirmation.Show(Me)
    End Sub

#End Region

    Private Sub cmdHotel_Click(sender As Object, e As EventArgs) Handles cmdHotel.Click
        Tabcontrol1.SelectedTab = tabHotelDiscount
    End Sub

    Private Sub cmdSalesDiscount_Click(sender As Object, e As EventArgs) Handles cmdSalesDiscount.Click
        Tabcontrol1.SelectedTab = tabDiscount
    End Sub

    Private Sub cmdRequisition_Click(sender As Object, e As EventArgs) Handles cmdRequisition.Click
        Tabcontrol1.SelectedTab = tabRequisitions
    End Sub

    Private Sub cmdPurchaseOrder_Click(sender As Object, e As EventArgs) Handles cmdPurchaseOrder.Click
        Tabcontrol1.SelectedTab = tabPurchaseOrder
    End Sub

    Private Sub cmdPaymentRequest_Click(sender As Object, e As EventArgs) Handles cmdPaymentRequest.Click
        Tabcontrol1.SelectedTab = tabAccountsPayable
    End Sub


    Private Sub cmdFFEDisposal_Click(sender As Object, e As EventArgs) Handles cmdFFEDisposal.Click
        Tabcontrol1.SelectedTab = tabFFEforDisposal
    End Sub


End Class