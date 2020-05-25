Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.VisualEffects
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCorpForApprovalList

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowByRequesitions(txtfilter.Text)
        ShowByPurchaseOrder(txtfilter.Text)
        ShowByDisbursementVoucher(txtfilter.Text)
        FilterSelectedTab()
        If Globalenablebybranchvoucher = True Then
            xtabDisbursementVoucher.Text = "Accounts Payable"
        Else
            xtabDisbursementVoucher.Text = "Disbursement Voucher"
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterSelectedTab()
    End Sub
    Public Function FilterSelectedTab()
        If XtraTabControl1.SelectedTabPage Is xTabRequisition Then
            ShowByRequesitions(txtfilter.Text)
        ElseIf XtraTabControl1.SelectedTabPage Is xtabPurchaseOrder Then
            ShowByPurchaseOrder(txtfilter.Text)

        ElseIf XtraTabControl1.SelectedTabPage Is xtabDisbursementVoucher Then
            ShowByDisbursementVoucher(txtfilter.Text)
        End If

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

    '#Region "HOTEL DISCOUNTS"
    '    Public Sub ShowHotelDiscountsForApproval(ByVal SearchKey As String)
    '        DataGridView_hoteldiscount.DataSource = Nothing : dst = New DataSet
    '        msda = New MySqlDataAdapter("select id, folioid as 'Folio Number', (select fullname from tblhotelguest where guestid=tblhotelroomsdiscounttransaction.guestid) as 'Guest', noofdays as 'No. of Days', description as 'Discount Type', roomrate as 'Room Rate',discountrate as 'Discount Rate (%)', totaldiscount as 'Total Discount', subtotal as 'Sub Total',  TotalAmount as 'Total Amount',Remarks, (select fullname from tblaccounts where accountid=tblhotelroomsdiscounttransaction.trnby) as 'Request by', datetrn as 'Date Transaction' from tblhotelroomsdiscounttransaction where discountoveride=0 and disapproved=0 order by datetrn asc;", conn)
    '        msda.Fill(dst, 0)
    '        DataGridView_hoteldiscount.DataSource = dst.Tables(0)
    '        GridHideColumn(DataGridView_hoteldiscount, {"id"})
    '        GridCurrencyColumn(DataGridView_hoteldiscount, {"Sub Total", "Room Rate", "Total Discount", "Total Amount"})
    '        GridColumnAlignment(DataGridView_hoteldiscount, {"Folio Number", "No. of Days", "Discount Rate (%)"}, DataGridViewContentAlignment.MiddleCenter)
    '    End Sub
    '    Private Sub DisapproveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdDisapproved.Click
    '        If MessageBox.Show("Are you sure you want to disapprove this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '            If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
    '                For Each rw As DataGridViewRow In DataGridView_hoteldiscount.SelectedRows
    '                    com.CommandText = "update tblhotelroomsdiscounttransaction set disapproved=1,disapprovedby='" & globaluserid & "',datedisapproved=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
    '                    RecordApprovingHistory("hotel", rw.Cells("Folio Number").Value.ToString, rw.Cells("Folio Number").Value.ToString, "Disapproved", rw.Cells("Discount Type").Value.ToString & ": " & rw.Cells("Total Discount").Value.ToString & " - " & rw.Cells("Request by").Value.ToString)
    '                Next
    '            End If

    '            FilterSelectedTab()
    '            MessageBox.Show("Request successfully Disapproved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End Sub
    '#End Region

    '#Region "DISCOUNTS"

    '    Public Sub ShowDiscountsForApproval(ByVal SearchKey As String)
    '        MyDataGridView_Discounts.DataSource = Nothing : dst = New DataSet
    '        msda = New MySqlDataAdapter("select id,  batchcode as 'Batch Code',   " _
    '                                            + " productname as 'Particular' , " _
    '                                            + "  total as 'Amount', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction',(select fullname from tblaccounts where accountid=tblsalestransaction.userid) as 'Cashier' from tblsalestransaction where cancelled=0 and void=0  and total < 0 and adjoveride=0 order by datetrn asc;", conn)
    '        msda.Fill(dst, 0)
    '        MyDataGridView_Discounts.DataSource = dst.Tables(0)
    '        GridHideColumn(MyDataGridView_Discounts, {"datetrn", "id"})
    '        GridCurrencyColumn(MyDataGridView_Discounts, {"Amount"})
    '        GridColumnAlignment(MyDataGridView_Discounts, {"Batch Code"}, DataGridViewContentAlignment.MiddleCenter)
    '        GridColumnAlignment(MyDataGridView_Discounts, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
    '    End Sub

    '    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
    '        If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
    '            ShowHotelDiscountsForApproval(txtfilter.Text)
    '        Else
    '            ShowDiscountsForApproval(txtfilter.Text)
    '        End If

    '    End Sub

    '    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
    '        If MessageBox.Show("Are you sure you want to approve this request?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '            If Tabcontrol1.SelectedTab Is tabHotelDiscount Then
    '                For Each rw As DataGridViewRow In DataGridView_hoteldiscount.SelectedRows
    '                    com.CommandText = "update tblhotelroomsdiscounttransaction set discountoveride=1,discountoverideby='" & globaluserid & "',dateoveride=current_timestamp where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
    '                    RecordApprovingHistory("hotel", rw.Cells("Folio Number").Value.ToString, rw.Cells("Folio Number").Value.ToString, "Override", rw.Cells("Discount Type").Value.ToString & ": " & rw.Cells("Total Discount").Value.ToString & " - " & rw.Cells("Request by").Value.ToString)
    '                Next
    '            Else
    '                For Each rw As DataGridViewRow In MyDataGridView_Discounts.SelectedRows
    '                    com.CommandText = "update tblsalestransaction set adjoveride=1,adjoverideby='" & globaluserid & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
    '                    RecordApprovingHistory("sales", rw.Cells("Batch Code").Value.ToString, rw.Cells("Batch Code").Value.ToString, "Override", rw.Cells("Particular").Value.ToString & ": " & rw.Cells("Amount").Value.ToString & " - " & rw.Cells("Cashier").Value.ToString)
    '                Next
    '            End If

    '            FilterSelectedTab()
    '            MessageBox.Show("Request successfully approved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End Sub

    '#End Region

#Region "REQUISITIONS"

    Public Sub ShowByRequesitions(ByVal SearchKey As String)
        com.CommandText = "call sp_forapproval(true, 'PR'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()
        LoadXgrid("select * from tmpforapprovalprview", "tmpforapprovalprview", Em_PR, GridView_PR)
        XgridColAlign({"Request No.", "Priority", "Total Item", "Date Needed", "Date Requested", "Time Requested", "Status"}, GridView_PR, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total Amount"}, GridView_PR)
        XgridGeneralSummaryCurrency({"Total Amount"}, GridView_PR)
        XgridColWidth({"Total Amount"}, GridView_PR, 100)
        If GridView_PR.RowCount > 0 Then
            ShowBadgeNumber(GridView_PR.RowCount, xTabRequisition, AdornerUIManager1)
        End If
    End Sub

    Private Sub GridView_PR_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_PR.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colPriority" Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Priority"))
            If status = "Emergency" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

#End Region

#Region "PURCHASE ORDER"
    Public Sub ShowByPurchaseOrder(ByVal SearchKey As String)
        com.CommandText = "call sp_forapproval(true, 'po'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()
        LoadXgrid("select * from tmpforapprovalpoview", "tmpforapprovalpoview", Em_PO, Gridview_PO)
        XgridColAlign({"PO Number", "Date Created", "Time Created", "Priority"}, Gridview_PO, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Total"}, Gridview_PO)
        XgridGeneralSummaryCurrency({"Total"}, Gridview_PO)
        XgridColWidth({"Total"}, Gridview_PO, 100)
        If Gridview_PO.RowCount > 0 Then
            ShowBadgeNumber(Gridview_PO.RowCount, xtabPurchaseOrder, AdornerUIManager1)
        End If

    End Sub

#End Region

#Region "DISBURSEMENT VOUCHER"
    Public Sub ShowByDisbursementVoucher(ByVal SearchKey As String)
        ShowBadgeNumber(0, xtabDisbursementVoucher, AdornerUIManager1)
        com.CommandText = "call sp_forapproval(true, 'dv'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()
        LoadXgrid("select * from tmpforapprovaldvview", "tmpforapprovalpoview", Em_DV, GridView_DV)

        XgridColAlign({"Payable No.", "Payable No.", "Date", "Voucher No.", "Disbursement Type", "Date", "Office", "Clasification", "Source Fund"}, GridView_DV, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount"}, GridView_DV)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_DV)
        XgridColWidth({"Amount"}, GridView_DV, 100)
        If GridView_DV.RowCount > 0 Then
            ShowBadgeNumber(GridView_DV.RowCount, xtabDisbursementVoucher, AdornerUIManager1)
        End If
    End Sub

#End Region

    '#Region "DISBURSEMENT VOUCHER"
    '    Public Sub ShowByAccountsPayable(ByVal SearchKey As String)
    '        MyDataGridView_AccountsPayable.DataSource = Nothing : dst = New DataSet
    '        msda = New MySqlDataAdapter("Select  voucherno as 'Voucher No.', date_format(voucherdate,'%Y-%m-%d') as 'Date', if(directexpense=1,'Direct Exppense','Accounts Payable') as 'Disbursement Type', (select companyname from tblcompany where code=tbldisbursementvoucher.companyid) as 'Company', (select officename from tblcompoffice where officeid=tbldisbursementvoucher.officeid) as 'Office', if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Claimant', " _
    '                                    + "  case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
    '                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
    '                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By' from tbldisbursementvoucher " _
    '                   + " where cancelled=0 and corporatelevel=1 and verified=0 and hold=0 and " _
    '                   + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tbldisbursementvoucher.voucherno and (status='approved' or status='disbursed')  and applevel<>'-' and approvaltype='voucher') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='voucher-signatories') " _
    '                   + " order by voucherdate asc", conn)


    '        msda.Fill(dst, 0)
    '        MyDataGridView_AccountsPayable.DataSource = dst.Tables(0)
    '        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Voucher No.", "Disbursement Type", "Date", "Office", "Clasification", "Source Fund"}, DataGridViewContentAlignment.MiddleCenter)
    '        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
    '        GridCurrencyColumn(MyDataGridView_AccountsPayable, {"Amount"})
    '    End Sub

    '    Private Sub MyDataGridView_PaymentConfirmation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '        If MyDataGridView_AccountsPayable.Item("Voucher No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
    '        frmForApproval_DisbursementVoucher.voucherno.Text = MyDataGridView_AccountsPayable.Item("Voucher No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString()
    '        frmForApproval_DisbursementVoucher.Show(Me)
    '    End Sub

    '#End Region

    '#Region "FFE FOR DISPOSAL"
    '    Public Sub FFEforDisposal()
    '        MyDataGridView_FFE.DataSource = Nothing : dst = New DataSet
    '        msda = New MySqlDataAdapter("Select ffecode as 'FFE Code', officeid, " _
    '                  + " productid as 'Product Code', " _
    '                  + " productname as 'Particular', " _
    '                  + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as 'FFE Type', " _
    '                  + " ifnull((select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid),'MAIN STOCK HOUSE') as 'Stock House', " _
    '                  + " categoryname as 'Category', " _
    '                  + " Quantity, Unit, unitcost as 'Unit Cost', totalamount as Total, date_format(datepurchased, '%Y-%m-%d') as 'Date Purchased', " _
    '                  + " (select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as 'Supplier', " _
    '                  + " if(warranty=1,date_format(warrantydate,'%Y-%m-%d'),'-') as 'Date Warranty', " _
    '                  + " bookvalue as 'Book Value', monthlydepreciation as 'Monthly Depreciation', date_format(lastdepreciationdate, '%Y-%m-%d') as 'Last Depreciation Date', " _
    '                  + " acctableperson as 'Accountable Person', date_format(acctdateissued, '%Y-%m-%d') as 'Date Issued', " _
    '                  + " date_format(disposaldaterequested,'%Y-%m-%d') as 'Date Requested', " _
    '                  + " (select fullname from tblaccounts where accountid=tblinventoryffe.disposalrequestedby) as 'Request for Disposal By', " _
    '                  + " Flaged, " _
    '                  + " flagedreason as 'Flaged Reason' " _
    '                  + " from tblinventoryffe " _
    '                  + " where disposalrequested=1 and disposalrequestcorporatelevel=1 and disposalapproved=0 and  " _
    '                  + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblinventoryffe.ffecode and status='approved' and applevel<>'-' and approvaltype='ffe-for-disposal') = (select left(applevel,1) from tblapprovermainprocess where  authorizedid='" & globaluserid & "' and blocked=0  and apptype='ffe-for-disposal')  " _
    '                  + " order by disposaldaterequested desc", conn)


    '        msda.Fill(dst, 0)
    '        MyDataGridView_FFE.DataSource = dst.Tables(0)
    '        GridHideColumn(MyDataGridView_FFE, {"officeid"})
    '        GridColumnAlignment(MyDataGridView_FFE, {"FFE Code", "FFE Type", "Product Code", "Quantity", "Unit", "Status", "Date Purchased", "Date Warranty", "Last Depreciation Date", "Date Requested", "Date Issued"}, DataGridViewContentAlignment.MiddleCenter)
    '        GridCurrencyColumn(MyDataGridView_FFE, {"Unit Cost", "Total", "Book Value", "Monthly Depreciation"})
    '    End Sub


    '    Private Sub MyDataGridView_FFE_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '        cmdEdit.PerformClick()
    '    End Sub

    '    Private Sub cmdViewProfile_Click(sender As Object, e As EventArgs) Handles cmdViewProfile.Click
    '        frmNewInventoryEntry.mode.Text = "view"
    '        frmNewInventoryEntry.officeid.Text = MyDataGridView_FFE.Item("officeid", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
    '        frmNewInventoryEntry.ffecode.Text = MyDataGridView_FFE.Item("FFE Code", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
    '        frmNewInventoryEntry.Show(Me)
    '    End Sub

    '    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
    '        frmFFEDisposalConfirmation.FFECode.Text = MyDataGridView_FFE.Item("FFE Code", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
    '        frmFFEDisposalConfirmation.txtDescription.Text = MyDataGridView_FFE.Item("Particular", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
    '        frmFFEDisposalConfirmation.Show(Me)
    '    End Sub

    '#End Region


    Private Sub Em_PR_DoubleClick(sender As Object, e As EventArgs) Handles Em_PR.DoubleClick
        frmForApproval_RequisitionsCorporate.pid.Text = GridView_PR.GetFocusedRowCellValue("Request No.").ToString
        frmForApproval_RequisitionsCorporate.Show(Me)
    End Sub

    Private Sub Em_PO_DoubleClick(sender As Object, e As EventArgs) Handles Em_PO.DoubleClick
        frmForApproval_PurchaseOrder.ponumber.Text = Gridview_PO.GetFocusedRowCellValue("PO Number").ToString
        frmForApproval_PurchaseOrder.Show(Me)
    End Sub

    Private Sub Em_DV_DoubleClick(sender As Object, e As EventArgs) Handles Em_DV.DoubleClick
        If Globalenablebybranchvoucher = True Then
            frmForApproval_AccountsPayable.voucherno.Text = GridView_DV.GetFocusedRowCellValue("Payable No.").ToString
            frmForApproval_AccountsPayable.Show(Me)
        Else
            frmForApproval_DisbursementVoucher.voucherno.Text = GridView_DV.GetFocusedRowCellValue("Voucher No.").ToString
            frmForApproval_DisbursementVoucher.Show(Me)
        End If
      
    End Sub
End Class