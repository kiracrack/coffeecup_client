Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmReminders
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowOpenFilters()
        ShowCloseFilters()
    End Sub
    Public Sub ShowOpenFilters()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select code, Title, Details, followupdate as 'Follow up Date', datecreated as 'Date Created'  from tblreminders where officeid='" & compOfficeid & "' and closed=0" _
                           + " order by datecreated desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"code"})
        MyDataGridView.Columns("Details").Width = 300
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        GridColumnAlignment(MyDataGridView, {"Date Created", "Follow up Date"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub ShowCloseFilters()
        MyDataGridView_close.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select code, Title, Details, followupdate as 'Follow up Date', datecreated as 'Date Created'  from tblreminders where officeid='" & compOfficeid & "' and closed=1" _
                           + " order by datecreated desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView_close.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_close, {"code"})
        MyDataGridView_close.Columns("Details").Width = 300
        MyDataGridView_close.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView_close.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        GridColumnAlignment(MyDataGridView_close, {"Date Created", "Follow up Date"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
   
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtTitle.Text = "" Or txtTitle.Text = "Select title or add new title.." Then
            MessageBox.Show("Please enter reminders title!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTitle.Focus()
            Exit Sub
        ElseIf txtContent.Text = "" Or txtContent.Text = "Content details.." Then
            MessageBox.Show("Please enter content details!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim refno As String = getGlobalid()
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblreminders set title='" & rchar(txtTitle.Text) & "',details='" & rchar(txtContent.Text) & "', followupdate='" & ConvertDate(txttodate.Value) & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblreminders set code='" & refno & "', officeid='" & compOfficeid & "', title='" & rchar(txtTitle.Text) & "',details='" & rchar(txtContent.Text) & "', datecreated=current_timestamp, createdby='" & globalfullname & "', followupdate='" & ConvertDate(txttodate.Value) & "'" : com.ExecuteNonQuery()
            End If
            txtTitle.Text = "Select title or add new title.." : txtContent.Text = "Content details.." : txttodate.Value = Now : code.Text = ""
            ShowOpenFilters()
            MessageBox.Show("Reminder successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdDownloadApprovedCopy_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            code.Text = rw.Cells("code").Value.ToString
            txtTitle.Text = rw.Cells("Title").Value.ToString
            txtContent.Text = rw.Cells("Details").Value.ToString
            txttodate.Text = rw.Cells("Follow up Date").Value.ToString
            mode.Text = "edit"
            txtContent.Focus()
            TabControl1.SelectedIndex = 0
        Next
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tabOpenReminders Then
            cmdEdit.Visible = True
            cmdDelete.Visible = True
            cmdCloseReminder.Visible = True
        ElseIf TabControl1.SelectedTab Is tabCloseReminder Then
            cmdEdit.Visible = False
            cmdDelete.Visible = False
            cmdCloseReminder.Visible = False
        End If
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If TabControl1.SelectedTab Is tabOpenReminders Then
            ShowOpenFilters()
        ElseIf TabControl1.SelectedTab Is tabCloseReminder Then
            ShowCloseFilters()
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                ' MessageBox.Show("Your file successfully exported with filename " & LCase(Me.Text) & ".xls", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MainForm.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                MainForm.NotifyIcon1.BalloonTipTitle = "Successfully Exported"
                MainForm.NotifyIcon1.BalloonTipText = "Your file successfully exported at " & f.SelectedPath & "\" & LCase(Me.Text) & ".xls"
                MainForm.NotifyIcon1.ShowBalloonTip(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtTitle_GotFocus(sender As Object, e As EventArgs) Handles txtTitle.GotFocus
        If txtTitle.Text = "Select title or add new title.." Then
            txtTitle.Text = ""
        End If
    End Sub

    Private Sub txtTitle_LostFocus(sender As Object, e As EventArgs) Handles txtTitle.LostFocus
        If txtTitle.Text = "" Then
            txtTitle.Text = "Select title or add new title.."
        End If
    End Sub

    Private Sub txtContent_GotFocus(sender As Object, e As EventArgs) Handles txtContent.GotFocus
        If txtContent.Text = "Content details.." Then
            txtContent.Text = ""
        End If
    End Sub

    Private Sub txtContent_LostFocus(sender As Object, e As EventArgs) Handles txtContent.LostFocus
        If txtContent.Text = "" Then
            txtContent.Text = "Content details.."
        End If
    End Sub

    Private Sub ReportHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdViewLogs.Click
        If TabControl1.SelectedTab Is tabOpenReminders Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                frmRemindersHistory.code.Text = rw.Cells("code").Value.ToString
                frmRemindersHistory.Text = rw.Cells("Title").Value.ToString
                frmRemindersHistory.txtContent.Enabled = True
                frmRemindersHistory.cmdset.Enabled = True
                frmRemindersHistory.ShowDialog(Me)
            Next
        ElseIf TabControl1.SelectedTab Is tabCloseReminder Then
            For Each rw As DataGridViewRow In MyDataGridView_close.SelectedRows
                frmRemindersHistory.code.Text = rw.Cells("code").Value.ToString
                frmRemindersHistory.Text = rw.Cells("Title").Value.ToString
                frmRemindersHistory.txtContent.Enabled = False
                frmRemindersHistory.cmdset.Enabled = False
                frmRemindersHistory.ShowDialog(Me)
            Next
        End If
    End Sub

    Private Sub CloseReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCloseReminder.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "UPDATE tblreminders set closed=1 where code='" & rw.Cells("code").Value.ToString & "'" : com.ExecuteNonQuery()
                ShowOpenFilters() : ShowCloseFilters()
            Next
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "DELETE FROM tblreminders where code='" & rw.Cells("code").Value.ToString & "'" : com.ExecuteNonQuery()
                ShowOpenFilters()
            Next
        End If
    End Sub
End Class