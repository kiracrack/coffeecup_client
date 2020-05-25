Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmRemindersHistory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowFilters()
    End Sub
    Public Sub ShowFilters()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select Remarks, postedby as 'Posted By',  dateposted as 'Date Posted'  from tblreminderslogs where reminderscode='" & code.Text & "'" _
                           + " order by dateposted asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        'MyDataGridView.Columns("Remarks").Width = 300
        'MyDataGridView.Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        GridColumnAlignment(MyDataGridView, {"Date Posted"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtContent.Text = "" Or txtContent.Text = "Post update.." Then
            MessageBox.Show("Please enter content!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to post? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblreminderslogs set reminderscode='" & code.Text & "', remarks='" & rchar(txtContent.Text) & "', dateposted=current_timestamp, postedby='" & globalfullname & "'" : com.ExecuteNonQuery()
            txtContent.Text = "Post update.."
            ShowFilters()
            MessageBox.Show("update successfully posted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowFilters()
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
 
    Private Sub txtContent_GotFocus(sender As Object, e As EventArgs) Handles txtContent.GotFocus
        If txtContent.Text = "Post update.." Then
            txtContent.Text = ""
        End If
    End Sub

    Private Sub txtContent_LostFocus(sender As Object, e As EventArgs) Handles txtContent.LostFocus
        If txtContent.Text = "" Then
            txtContent.Text = "Post update.."
        End If
    End Sub

    Private Sub cmdDownloadApprovedCopy_Click(sender As Object, e As EventArgs) Handles cmdDownloadApprovedCopy.Click

    End Sub
End Class