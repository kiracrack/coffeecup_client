Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmBranchForApprovalList

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterSelectedTab()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        FilterSelectedTab()
    End Sub

    Public Function FilterSelectedTab()
        If TabControl1.SelectedTab Is tabTransfer Then
            ShowByTransferRequest()
        ElseIf TabControl1.SelectedTab Is tabRequisitions Then
            ShowByRequesitions(txtfilter.Text)
        ElseIf TabControl1.SelectedTab Is tabPurchaseOrder Then
            ShowByPurchaseOrder(txtfilter.Text)
        ElseIf TabControl1.SelectedTab Is tabAccountsPayable Then
            ShowByAccountsPayable(txtfilter.Text)
        ElseIf TabControl1.SelectedTab Is tabFFEforDisposal Then
            FFEforDisposal()
        End If
    End Function
    Private Sub txtfilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfilter.KeyPress
        If e.KeyChar() = Chr(13) Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            FilterSelectedTab()
        End If

    End Sub

#Region "STOCK TRASFER"
    Public Sub ShowByTransferRequest()
        MyDataGridView_Transfer.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select reqcode as 'Request No',   " _
                      + " (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) as 'Office', " _
                      + " Message, " _
                      + " (select fullname from tblaccounts where accountid = tbltransferrequest.requestby) as 'Request By' , " _
                      + " date_format(daterequest,'%Y-%m-%d %r')  as 'Date Request', " _
                      + " (select fullname from tblaccounts where accountid = tbltransferrequest.trnby) as 'Created By' , " _
                      + " if(cancelled=1,'Cancelled', case when confirmed=0 then 'Not yet Confirm' when confirmed=1 then 'Confirmed' end) as 'Status', " _
                      + " DATEDIFF(current_date,daterequest) as 'Day(s) Count' from tbltransferrequest where cleared=0 and confirmed=0 and cancelled=0 " _
                      + " and (select concat(count(*)+1) from tblapprovalhistory where referenceno=tbltransferrequest.reqcode and status='approved' and applevel<>'-' and approvaltype='stock-transfer-signatories') = (select left(applevel,1) from tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='stock-transfer-signatories') " _
                      + " and (reqcode like '%" & rchar(txtfilter.Text) & "%' or " _
                      + " Message like '%" & rchar(txtfilter.Text) & "%' or " _
                      + " (select fullname from tblaccounts where accountid = tbltransferrequest.trnby) like '%" & rchar(txtfilter.Text) & "%' or " _
                      + " (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_from) like '%" & rchar(txtfilter.Text) & "%' or " _
                      + " (select officename from tblcompoffice where officeid=tbltransferrequest.inventory_to) like '%" & rchar(txtfilter.Text) & "%') order by daterequest desc", conn)


        msda.Fill(dst, 0)
        MyDataGridView_Transfer.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView_Transfer, {"Request No", "Date Request", "Status", "Day(s) Count"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub


    Private Sub MyDataGridView_Transfer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_Transfer.CellDoubleClick
        frmForApproval_StockTransfer.batchcode.Text = MyDataGridView_Transfer.Item("Request No", MyDataGridView_Transfer.CurrentRow.Index).Value().ToString
        frmForApproval_StockTransfer.Show(Me)
    End Sub

#End Region

#Region "REQUISITIONS"
    Public Sub ShowByRequesitions(ByVal SearchKey As String)
        MyDataGridView_Requisitions.DataSource = Nothing : dst = New DataSet
        com.CommandText = "call sp_forapproval(FALSE, 'PR'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()
        msda = New MySqlDataAdapter("select * from tmpforapprovalprview", conn)

        msda.Fill(dst, "tmpforapprovalprview")
        MyDataGridView_Requisitions.DataSource = dst.Tables("tmpforapprovalprview")
        GridColumnAlignment(MyDataGridView_Requisitions, {"Request No.", "Priority", "Total Item", "Date Needed", "Date Requested", "Time Requested", "Status"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_Requisitions, {"Total Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_Requisitions, {"Total Amount"})
    End Sub
     
    Private Sub MyDataGridView_Requisitions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_Requisitions.CellDoubleClick
        If MyDataGridView_Requisitions.Item("Request No.", MyDataGridView_Requisitions.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        frmForApproval_RequisitionsBranch.pid.Text = MyDataGridView_Requisitions.Item("Request No.", MyDataGridView_Requisitions.CurrentRow.Index).Value().ToString()
        frmForApproval_RequisitionsBranch.Show(Me)
    End Sub
#End Region

#Region "PURCHASE ORDER"
    Public Sub ShowByPurchaseOrder(ByVal SearchKey As String)
        com.CommandText = "call sp_forapproval(FALSE, 'po'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()

        MyDataGridView_PurchaseOrder.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tmpforapprovalpoview", conn)

        msda.Fill(dst, "tmpforapprovalpoview")
        MyDataGridView_PurchaseOrder.DataSource = dst.Tables("tmpforapprovalpoview")
        GridHideColumn(MyDataGridView_PurchaseOrder, {"officeid", "mainofficeid", "datetrn", "currentlevel"})
        GridColumnAlignment(MyDataGridView_PurchaseOrder, {"PO Number", "Date Created", "Time Created", "Priority"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_PurchaseOrder, {"Total"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_PurchaseOrder, {"Total"})
    End Sub

    Private Sub MyDataGridView_PurchaseOrder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_PurchaseOrder.CellDoubleClick
        If MyDataGridView_PurchaseOrder.Item("PO Number", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        frmForApproval_PurchaseOrder.ponumber.Text = MyDataGridView_PurchaseOrder.Item("PO Number", MyDataGridView_PurchaseOrder.CurrentRow.Index).Value().ToString()
        frmForApproval_PurchaseOrder.Show(Me)
    End Sub
 
#End Region

#Region "ACCOUNTS PAYABLE"
    Public Sub ShowByAccountsPayable(ByVal SearchKey As String)
        MyDataGridView_AccountsPayable.DataSource = Nothing : dst = New DataSet
        com.CommandText = "call sp_forapproval(FALSE, 'ap'," & globaluserid & ",'%" & SearchKey & "%')" : com.ExecuteNonQuery()
        msda = New MySqlDataAdapter("select * from tmpforapprovaldvview", conn)

        msda.Fill(dst, "tmpforapprovaldvview")
        MyDataGridView_AccountsPayable.DataSource = dst.Tables("tmpforapprovaldvview")
        GridHideColumn(MyDataGridView_AccountsPayable, {"officeid", "mainofficeid", "datetrn", "currentlevel"})
        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Payable No.", "Date"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView_AccountsPayable, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView_AccountsPayable, {"Amount"})
    End Sub

    Private Sub MyDataGridView_PaymentConfirmation_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_AccountsPayable.CellDoubleClick
        If MyDataGridView_AccountsPayable.Item("Payable No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString() = "" Then Exit Sub
        If Globalenablebybranchvoucher = True Then
            frmForApproval_AccountsPayable.voucherno.Text = MyDataGridView_AccountsPayable.Item("Payable No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString()
            frmForApproval_AccountsPayable.Show(Me)
        Else
            frmForApproval_DisbursementVoucher.voucherno.Text = MyDataGridView_AccountsPayable.Item("Payable No.", MyDataGridView_AccountsPayable.CurrentRow.Index).Value().ToString()
            frmForApproval_DisbursementVoucher.Show(Me)
        End If
      
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
                  + " where disposalrequested=1 and disposalrequestcorporatelevel=0 and disposalapproved=0 and  " _
                  + " (select concat(count(*)+1) from tblapprovalhistory where referenceno=tblinventoryffe.ffecode and status='approved' and applevel<>'-' and approvaltype='ffe-for-disposal') = (select left(applevel,1) from tblapproverclientprocess where authcode='" & globalAuthcode & "' and apptype='ffe-for-disposal') " _
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
        frmFFEDisposalConfirmation.ffecode.Text = MyDataGridView_FFE.Item("FFE Code", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmFFEDisposalConfirmation.txtDescription.Text = MyDataGridView_FFE.Item("Particular", MyDataGridView_FFE.CurrentRow.Index).Value().ToString
        frmFFEDisposalConfirmation.Show(Me)
    End Sub

#End Region


End Class