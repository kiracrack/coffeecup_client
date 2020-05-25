Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmAcctVoucherList
    Dim vouchercaption As String
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
        If TabControl1.SelectedTab Is tabForClearing Then
            ShowForApproval(txtfilter.Text)

        ElseIf TabControl1.SelectedTab Is tabCleared Then
            MyDataGridView.ContextMenuStrip = cms_em
            ShowClearedVoucher(txtfilter.Text)
 
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

  
#Region "FOR DISBURSEMENT"
    Public Sub ShowForApproval(ByVal SearchKey As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Voucher No.', date_format(voucherdate,'%Y-%m-%d') as 'Date', (select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                                    + " (select companyname from tblglobalvendor where vendorid=a.vendorid) as 'Claimant', " _
                                    + " case when `check`=1 then 'Check Voucher' when cash=1 then 'Cash Voucher' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + "  CheckNo as 'Check No.',date_format(CheckDate,'%Y-%m-%d') as 'Check Date',CheckAmount as 'Check Amount', " _
                                    + " Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                                    + " Cleared, date_format(datecleared,'%Y-%m-%d') as 'Date Cleared'   " _
                                    + "   from tbldisbursementvoucher as a where cleared=0 and cancelled=0", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Voucher No.", "Office", "Voucher No.", "Office", "Status", "Date", "Attachment", "Source Fund", "Check No.", "Check Date", "Check Amount", "Clasification", "Date Posted", "Date Approved", "Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Amount", "Check Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount", "Check Amount"}, DataGridViewContentAlignment.MiddleRight)

    End Sub
    '
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Public Sub ShowClearedVoucher(ByVal SearchKey As String)
        DataGridView_cleared.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Voucher No.', date_format(voucherdate,'%Y-%m-%d') as 'Date', (select officename from tblcompoffice where officeid=a.officeid) as 'Office', " _
                                    + " (select companyname from tblglobalvendor where vendorid=a.vendorid) as 'Claimant', " _
                                    + " case when `check`=1 then 'Check Voucher' when cash=1 then 'Cash Voucher' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + "  CheckNo as 'Check No.',date_format(CheckDate,'%Y-%m-%d') as 'Check Date',CheckAmount as 'Check Amount', " _
                                    + " Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=a.trnby) as 'Posted By', " _
                                    + " Cleared, date_format(datecleared,'%Y-%m-%d') as 'Date Cleared'  " _
                                    + "  from tbldisbursementvoucher as a where cleared=1 and cancelled=0", conn)

        msda.Fill(dst, 0)
        DataGridView_cleared.DataSource = dst.Tables(0)
        GridColumnAlignment(DataGridView_cleared, {"Voucher No.", "Office", "Voucher No.", "Office", "Status", "Date", "Attachment", "Source Fund", "Check No.", "Check Date", "Check Amount", "Clasification", "Date Posted", "Date Approved", "Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(DataGridView_cleared, {"Amount", "Check Amount"})
        GridColumnAlignment(DataGridView_cleared, {"Amount", "Check Amount"}, DataGridViewContentAlignment.MiddleRight)
    End Sub

    Private Sub DataGridView_cleared_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView_cleared.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.DataGridView_cleared.CurrentCell = Me.DataGridView_cleared.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
#End Region


    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        FilterSelectedTab()
    End Sub

    Private Sub RequestForPaymentApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestForPaymentApprovalToolStripMenuItem.Click
        If MyDataGridView.Item("Attachment", MyDataGridView.CurrentRow.Index).Value().ToString() = "-" Then
            MessageBox.Show("No attachment at this time! please make sure disbusement already cleared", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ViewAttachmentPackage_Database({MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString()}, "voucher") = True Then
            com.CommandText = "update tbldisbursementvoucher set downloaded=1 where voucherno='" & MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString() & "'" : com.ExecuteNonQuery()
            RecordApprovingHistory("voucher", MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString(), MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString(), "downloaded", "Voucher#" & MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString() & " Downloaded")
        End If
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        frmAcctVoucherInfo.mode.Text = "edit"
        frmAcctVoucherInfo.txtVoucherNo.Text = MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmAcctVoucherInfo.ShowDialog(Me)
    End Sub
      

    Private Sub cmdCreatePayment_Click(sender As Object, e As EventArgs) Handles cmdCreatePayment.Click
        frmAcctVoucherInfo.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmAcctVoucherInfo.mode.Text = "view"
        frmAcctVoucherInfo.txtVoucherNo.Text = MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmAcctVoucherInfo.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FilterSelectedTab()
    End Sub
End Class