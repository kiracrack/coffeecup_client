Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmClinicServices
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmClinicServices_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim reminder As Integer = countqry("tblclinicschedule as a inner join tblclinicservices as b on b.trnid = a.trnid", "b.officeid='" & compOfficeid & "' and date_format(schedule,'%Y-%m-%d') <= '" & ConvertDate(CDate(Now.AddDays(1).ToShortDateString)) & "' and a.cancelled=0 and cleared=0")
        If reminder > 0 Then
            cmdScheduleReminder.Text = "Schedule Reminder (" & reminder & ")"
            If globalFontColor = "LIGHT" Then
                cmdScheduleReminder.ForeColor = Color.Gold
            Else
                cmdScheduleReminder.ForeColor = Color.Red
            End If
            lineScheduleReminder.Visible = True
            cmdScheduleReminder.Visible = True
        Else
            cmdScheduleReminder.Visible = False
            lineScheduleReminder.Visible = False
        End If
    End Sub
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        LoadClinic()
        tabFilter()
    End Sub

    Public Sub LoadClinic()
        com.CommandText = "select * from tblclinics order by description asc" : rst = com.ExecuteReader
        While rst.Read
            txtClinic.Items.Add(rst("description").ToString())
        End While
        rst.Close()
    End Sub
    Private Sub txtClinic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClinic.SelectedIndexChanged
        clinicid.Text = qrysingledata("clinicid", "clinicid", "tblclinics where description='" & txtClinic.Text & "'")
        tabFilter()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            tabFilter()
        End If
    End Sub

    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabPending Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewPendingTransaction()
            EditSelectedToolStripMenuItem.Visible = True
            cmdStatement.Visible = True
            cmdCancel.Visible = True

        ElseIf TabControl1.SelectedTab Is tabClosed Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewClosedTransaction()
            EditSelectedToolStripMenuItem.Visible = False
            cmdStatement.Visible = False
            cmdCancel.Visible = False

        ElseIf TabControl1.SelectedTab Is tabCancelled Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            ViewCancelledransaction()
            EditSelectedToolStripMenuItem.Visible = False
            cmdStatement.Visible = False
            cmdCancel.Visible = False
        End If
    End Sub

    Public Sub ViewPendingTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trnid, servicecode as 'Service No.', (select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Client', " _
                                    + " (select telephone from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Contact No.', packagename as 'Package Name',Amount, " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cancelled=0) as 'Total Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=1 and cancelled=0) as 'Cleared Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=0 and cancelled=0) as 'Pending Session', date_format(datetrn, '%Y-%m-%d') as 'Date Created',date_format(datetrn, '%r') as 'Time Created',(select fullname from tblaccounts where accountid=tblclinicservices.trnby) as 'Transaction By' from tblclinicservices where clinicid='" & clinicid.Text & "' and closed=0 and cancelled=0 and ((select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) like '%" & txtsearch.Text & "%') order by servicecode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"trnid"})
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Service No.", "Contact No.", "Total Session", "Cleared Session", "Pending Session", "Date Created", "Time Created"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        txtfrmdate.Enabled = False
        txttodate.Enabled = False
        ckasof.Enabled = False

    End Sub

    Public Sub ViewClosedTransaction()
        Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(dateclosed,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(dateclosed,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trnid, servicecode as 'Service No.', (select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Client', " _
                                    + " (select telephone from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Contact No.', packagename as 'Package Name',Amount, " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cancelled=0) as 'Total Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=1 and cancelled=0) as 'Cleared Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=0 and cancelled=0) as 'Pending Session', " _
                                    + " date_format(datetrn, '%Y-%m-%d') as 'Date Created',date_format(datetrn, '%r') as 'Time Created', (select fullname from tblaccounts where accountid=tblclinicservices.trnby) as 'Transaction By', " _
                                    + " date_format(dateclosed, '%Y-%m-%d %r') as 'Date Closed', (select fullname from tblaccounts where accountid=tblclinicservices.closedby) as 'Closed By' " _
                                    + " from tblclinicservices where clinicid='" & clinicid.Text & "' and closed=1 and cancelled=0 and ((select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) like '%" & txtsearch.Text & "%') " & filterasof & " order by servicecode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"trnid"})
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Service No.", "Contact No.", "Total Session", "Cleared Session", "Pending Session", "Date Closed"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True
    End Sub

    Public Sub ViewCancelledransaction()
       Dim filterasof As String = ""
        If ckasof.Checked = True Then
            filterasof = " and date_format(datecancelled,'%Y-%m-%d') <= '" & ConvertDate(txttodate.Text) & "' "
        Else
            filterasof = " and date_format(datecancelled,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Text) & "'  and '" & ConvertDate(txttodate.Text) & "' "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trnid, servicecode as 'Service No.', (select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Client', " _
                                    + " (select telephone from tblclientaccounts where cifid  = tblclinicservices.clientcif) as 'Contact No.', packagename as 'Package Name',Amount, " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cancelled=0) as 'Total Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=1 and cancelled=0) as 'Cleared Session', " _
                                    + " (select count(*) from tblclinicschedule where trnid=tblclinicservices.trnid and cleared=0 and cancelled=0) as 'Pending Session', " _
                                    + " date_format(datetrn, '%Y-%m-%d') as 'Date Created',date_format(datetrn, '%r') as 'Time Created', (select fullname from tblaccounts where accountid=tblclinicservices.trnby) as 'Transaction By', " _
                                    + " date_format(datecancelled, '%Y-%m-%d %r') as 'Date Cancelled', (select fullname from tblaccounts where accountid=tblclinicservices.cancelledby) as 'Cancelled By' " _
                                    + " from tblclinicservices where clinicid='" & clinicid.Text & "' and cancelled=1 and ((select companyname from tblclientaccounts where cifid  = tblclinicservices.clientcif) like '%" & txtsearch.Text & "%') " & filterasof & " order by servicecode asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"trnid"})
        GridCurrencyColumn(MyDataGridView, {"Amount"})
        GridColumnAlignment(MyDataGridView, {"Service No.", "Contact No.", "Total Session", "Cleared Session", "Pending Session", "Date Cancelled"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Amount"}, DataGridViewContentAlignment.MiddleRight)
        txtfrmdate.Enabled = True
        txttodate.Enabled = True
        ckasof.Enabled = True
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        ViewStatementToolStripMenuItem.PerformClick()
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(txtClinic.Text & " SERVICES", TabControl1.SelectedTab.Text, If(ckasof.Checked = False, "Reports period from " & CDate(txtfrmdate.Text).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Text).ToString("MMMM, dd yyyy"), "Reports as of " & CDate(txttodate.Text).ToString("MMMM, dd yyyy")), MyDataGridView, Me)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabFilter()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdNewCheckinGuest.Click
        If txtClinic.Text = "" Then
            MsgBox("Please select clinic!", MsgBoxStyle.Exclamation, "Error Message")
            txtClinic.Focus()
            Exit Sub
        End If
        frmClinicNewPackage.clinicid.Text = clinicid.Text
        If frmClinicNewPackage.Visible = False Then
            frmClinicNewPackage.Show(Me)
        Else
            frmClinicNewPackage.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub RemoveFromInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdStatement.Click
        frmClinicPackageSchedule.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        If frmClinicPackageSchedule.Visible = False Then
            frmClinicPackageSchedule.Show(Me)
        Else
            frmClinicPackageSchedule.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CancelTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to cancel current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                com.CommandText = "update tblclinicservices set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblclinicschedule set cancelled=1, cancelledby='" & globaluserid & "', datecancelled=current_timestamp where trnid='" & MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                tabFilter()
                MsgBox("Service Successfully Cancelled!", MsgBoxStyle.Information)
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If
    End Sub

    Private Sub EditSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedToolStripMenuItem.Click
        frmClinicNewPackage.clinicid.Text = clinicid.Text
        frmClinicNewPackage.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmClinicNewPackage.mode.Text = "edit"
        If frmClinicNewPackage.Visible = False Then
            frmClinicNewPackage.Show(Me)
        Else
            frmClinicNewPackage.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ViewStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStatementToolStripMenuItem.Click
        frmClinicStatementLedger.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        If frmClinicStatementLedger.Visible = False Then
            frmClinicStatementLedger.Show(Me)
        Else
            frmClinicStatementLedger.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdScheduleReminder_Click(sender As Object, e As EventArgs) Handles cmdScheduleReminder.Click
        If frmClinicScheduleReminder.Visible = False Then
            frmClinicScheduleReminder.Show(Me)
        Else
            frmClinicScheduleReminder.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class