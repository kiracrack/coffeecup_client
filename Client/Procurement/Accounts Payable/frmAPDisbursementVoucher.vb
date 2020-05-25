Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmAPDisbursementVoucher
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
        If TabControl1.SelectedTab Is tabForDisbursementPO Then
            MyDataGridView.Parent = tabForDisbursementPO
            ShowForApproval(txtfilter.Text)

        ElseIf TabControl1.SelectedTab Is tabPending Then
            MyDataGridView.Parent = tabPending
            MyDataGridView.ContextMenuStrip = cms_em
            ShowClearedVoucher(txtfilter.Text)


        ElseIf TabControl1.SelectedTab Is tabCashAdvance Then
            ShowUnliquidatedCashAdvance()

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

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub


#Region "FOR DISBURSEMENT"
    Public Sub ShowForApproval(ByVal SearchKey As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Voucher No.', if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status'," _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Claimant', " _
                                    + " (select itemname from tbltransactioncode where itemcode=tbldisbursementvoucher.itemcode) as 'Transaction Name', case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tbldisbursementvoucher.voucherno),'-') as 'Attachment', " _
                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By' " _
                                    + "   from tbldisbursementvoucher where cleared=0 and cancelled=0", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Voucher No.", "Status", "Date", "Attachment", "Claimant", "Source Fund", "Clasification", "Date Posted"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

    End Sub
    '

    Public Sub ShowClearedVoucher(ByVal SearchKey As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Voucher No.', if(cancelled=1,'Cancelled',if(hold=1,'Hold',if(cleared=1,'Cleared',if(verified=1,'Approved','For Approval')))) as 'Status'," _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Claimant', " _
                                    + " (select itemname from tbltransactioncode where itemcode=tbldisbursementvoucher.itemcode) as 'Transaction Name', case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tbldisbursementvoucher.voucherno),'-') as 'Attachment', " _
                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By', Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved', Cleared,date_format(datecleared,'%Y-%m-%d') as 'Date Cleared'  " _
                                    + "   from tbldisbursementvoucher where cleared=1 and cancelled=0", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Voucher No.", "Status", "Date", "Attachment", "Claimant", "Source Fund", "Clasification", "Date Posted", "Date Approved", "Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Public Sub ShowUnliquidatedCashAdvance()
        dgv_unliquidated.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select voucherno as 'Voucher No.', if(liquidated=0,'UNLIQUIDATED','LIQUIDATED')  as 'Status'," _
                                    + " date_format(voucherdate,'%Y-%m-%d') as 'Date', if(ca=1,(select fullname from tblaccounts where accountid=tbldisbursementvoucher.vendorid),(select companyname from tblglobalvendor where vendorid=tbldisbursementvoucher.vendorid)) as 'Claimant', " _
                                    + " (select itemname from tbltransactioncode where itemcode=tbldisbursementvoucher.itemcode) as 'Transaction Name', case when `check`=1 then 'Check Payment' when cash=1 then 'Cash Payment' when ca=1 then 'Cash Advance'  end as 'Clasification', Amount, " _
                                    + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tbldisbursementvoucher.voucherno),'-') as 'Attachment', " _
                                    + " (select accountname from tblbankaccounts where bankcode=tbldisbursementvoucher.sourcefund) as 'Source Fund', Note, date_format(datetrn,'%Y-%m-%d %r') as 'Date Posted', " _
                                    + " (select fullname from tblaccounts where accountid=tbldisbursementvoucher.trnby) as 'Posted By', Verified as Approved, if(Verified=1,date_format(dateverified,'%Y-%m-%d %r') ,'-') as 'Date Approved', Cleared,date_format(datecleared,'%Y-%m-%d') as 'Date Cleared'  " _
                                    + "   from tbldisbursementvoucher where cleared=1 and ca=1 and liquidated=0 and cancelled=0", conn)

        msda.Fill(dst, 0)
        dgv_unliquidated.DataSource = dst.Tables(0)
        GridColumnAlignment(dgv_unliquidated, {"Voucher No.", "Status", "Date", "Attachment", "Claimant", "Source Fund", "Clasification", "Date Posted", "Date Approved", "Date Cleared"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(dgv_unliquidated, {"Amount"})
        GridColumnAlignment(dgv_unliquidated, {"Amount"}, DataGridViewContentAlignment.MiddleRight)

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
        frmForApproval_DisbursementVoucher.mode.Text = "view"
        frmForApproval_DisbursementVoucher.voucherno.Text = MyDataGridView.Item("Voucher No.", MyDataGridView.CurrentRow.Index).Value().ToString()
        frmForApproval_DisbursementVoucher.Show(Me)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ShowUnliquidatedCashAdvance()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmLiquidationForm.voucherno.Text = dgv_unliquidated.Item("Voucher No.", dgv_unliquidated.CurrentRow.Index).Value().ToString()
        frmLiquidationForm.ShowDialog(Me)
    End Sub

End Class