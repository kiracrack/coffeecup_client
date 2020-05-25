Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text.RegularExpressions

Public Class frmApprovalHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmForApprovalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        filterApprovalLogs()
    End Sub
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            filterApprovalLogs()
        End If
    End Sub
    Public Sub filterApprovalLogs()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(DATECONFIRM,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(DATECONFIRM,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select case when appdescription='requisition' then (select (select officename from tblcompoffice where officeid = tblrequisitions.officeid) from tblrequisitions where pid = tblapprovalhistory.referenceno)  " _
                                            + " when appdescription='purchase order' then (select (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) from tblpurchaseorder where ponumber = tblapprovalhistory.referenceno) " _
                                            + " when appdescription='voucher' then (select (select officename from tblcompoffice where officeid = tbldisbursementvoucher.officeid) from tbldisbursementvoucher where voucherno = tblapprovalhistory.referenceno) " _
                                            + " when appdescription='disposal request' then (select (select officename from tblcompoffice where officeid = tblinventoryffe.officeid) from tblinventoryffe where ffecode = tblapprovalhistory.referenceno) " _
                                            + " when appdescription='sales' then (select (select officename from tblcompoffice where officeid = tblsalesbatch.officeid) from tblsalesbatch where batchcode = tblapprovalhistory.referenceno)  end as Office, " _
                      + " appdescription as 'Transaction Type', referenceno as 'Reference Number', " _
                      + " REMARKS as 'Remarks', " _
                      + " CONCAT(UCASE(SUBSTRING(`status`, 1, 1)),LOWER(SUBSTRING(`status`, 2)))  as 'Status', " _
                      + " DATECONFIRM as 'Date Confirmed' " _
                      + " from tblapprovalhistory " _
                      + " WHERE confirmid = '" & globaluserid & "' " & filterasof & " and (`status` like '%" & rchar(txtsearch.Text) & "%' or  referenceno like '%" & rchar(txtsearch.Text) & "%' or  Remarks like '%" & rchar(txtsearch.Text) & "%' or  ifnull((select (select officename from tblcompoffice where officeid = tblrequisitions.officeid) from tblrequisitions where pid = tblapprovalhistory.referenceno),(select (select officename from tblcompoffice where officeid = tblpurchaseorder.officeid) from tblpurchaseorder where ponumber = tblapprovalhistory.referenceno))  like '%" & rchar(txtsearch.Text) & "%') order by tblapprovalhistory.DATECONFIRM asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Transaction Type", "Reference Number", "Status"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        If MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString() = "requisition" Then
            frmRequisitionsView.txtStatus.Text = UCase(MyDataGridView.Item("Status", MyDataGridView.CurrentRow.Index).Value().ToString())
            frmRequisitionsView.pid.Text = MyDataGridView.Item("Reference Number", MyDataGridView.CurrentRow.Index).Value().ToString()
            If frmRequisitionsView.Visible = True Then
                frmRequisitionsView.Focus()
            Else
                frmRequisitionsView.Show(Me)
            End If
        ElseIf MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString() = "purchase order" Then
            frmPurchaseOrderView.ponumber.Text = MyDataGridView.Item("Reference Number", MyDataGridView.CurrentRow.Index).Value().ToString()
            frmPurchaseOrderView.Show(Me)

        ElseIf MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString() = "disposal request" Then
            PrintFFeMR(MyDataGridView.Item("Reference Number", MyDataGridView.CurrentRow.Index).Value().ToString, Me)

        ElseIf MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString() = "voucher" Then
            frmForApproval_DisbursementVoucher.mode.Text = "view"
            frmForApproval_DisbursementVoucher.voucherno.Text = MyDataGridView.Item("Reference Number", MyDataGridView.CurrentRow.Index).Value().ToString()
            If frmForApproval_DisbursementVoucher.Visible = True Then
                frmForApproval_DisbursementVoucher.Focus()
            Else
                frmForApproval_DisbursementVoucher.Show(Me)
            End If

        ElseIf MyDataGridView.Item("Transaction Type", MyDataGridView.CurrentRow.Index).Value().ToString() = "accounting ticket" Then
            frmForApproval_AccountingTicket.mode.Text = "view"
            frmForApproval_AccountingTicket.ticketno.Text = MyDataGridView.Item("Reference Number", MyDataGridView.CurrentRow.Index).Value().ToString()
            If frmForApproval_AccountingTicket.Visible = True Then
                frmForApproval_AccountingTicket.Focus()
            Else
                frmForApproval_AccountingTicket.Show(Me)
            End If

        End If
    End Sub
    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        cmdView.PerformClick()
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        filterApprovalLogs()
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

  
End Class