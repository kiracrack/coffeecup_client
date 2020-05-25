Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmComplaintBox
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select * from tblemployees order by fullname asc", "fullname", "fullname", txtRespondent)
        LoadToComboBoxDB("select * from tblemployees order by fullname asc", "fullname", "fullname", txtComplainant)
        LoadToComboBoxDB("select * from tblcomplaintbox order by Issue asc", "Issue", "Issue", txtIssue)
        ShowOpenFilters()
        ShowCloseFilters()
    End Sub
    Public Sub ShowOpenFilters()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select code, Issue, Respondent, Complainant,  Details,  datecreated as 'Date Created',createdby as 'Created By'  from tblcomplaintbox where closed=0 " & If(CBool(qrysingledata("corpapprover", "corpapprover", "tbluserauthority where authcode='" & globalAuthcode & "'")) = True, "", " and createdid='" & globaluserid & "' ") & " " _
                           + " order by datecreated desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"code"})
        MyDataGridView.Columns("Details").Width = 300
        MyDataGridView.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        GridColumnAlignment(MyDataGridView, {"Date Created"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub ShowCloseFilters()
        MyDataGridView_close.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select code, Issue,  Respondent, Complainant, Details, datecreated as 'Date Created',createdby as 'Created By' from tblcomplaintbox where closed=1 " & If(CBool(qrysingledata("corpapprover", "corpapprover", "tbluserauthority where authcode='" & globalAuthcode & "'")) = True, "", " and createdid='" & globaluserid & "' ") & " " _
                           + " order by datecreated desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView_close.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_close, {"code"})
        MyDataGridView_close.Columns("Details").Width = 300
        MyDataGridView_close.Columns("Details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView_close.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        GridColumnAlignment(MyDataGridView_close, {"Date Created"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtRespondent.Text = "" Then
            MessageBox.Show("Please enter respondent!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRespondent.Focus()
            Exit Sub
        ElseIf txtComplainant.Text = "" Then
            MessageBox.Show("Please enter complainant!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtComplainant.Focus()
            Exit Sub
        ElseIf txtIssue.Text = "" Or txtIssue.Text = "Select issue or add new issue.." Then
            MessageBox.Show("Please enter complaint issue!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtIssue.Focus()
            Exit Sub
        ElseIf txtContent.Text = "" Or txtContent.Text = "Content details.." Then
            MessageBox.Show("Please enter content details!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContent.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to save? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim refno As String = getGlobalid()
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblcomplaintbox set respondent='" & txtRespondent.Text & "', complainant='" & txtComplainant.Text & "', issue='" & rchar(txtIssue.Text) & "',details='" & rchar(txtContent.Text) & "' where code='" & code.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblcomplaintbox set code='" & refno & "', respondent='" & txtRespondent.Text & "', complainant='" & txtComplainant.Text & "', officeid='" & compOfficeid & "', issue='" & rchar(txtIssue.Text) & "',details='" & rchar(txtContent.Text) & "', datecreated=current_timestamp, createdby='" & globalfullname & "', createdid='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            Dim emailReceiver As String = qrysingledata("email", "group_concat(emailaddress) as email", "tblaccounts where emailaddress<>'' and coffeecupposition in (select authcode from tbluserauthority where corpapprover=1)")
            Dim EMailBody As String = "Respondent: " & txtRespondent.Text & "<br/> " _
                                    + " Complainant: " & txtComplainant.Text & "<br/>" _
                                    + " Issue: " & txtIssue.Text & " <br/> " _
                                    + " Remarks: " & txtContent.Text & ""

            InsertEmailNotification("COMPLAINT", emailReceiver, "New Complaint to " & txtRespondent.Text, EMailBody, "")
            txtRespondent.Text = "Select respondent" : txtComplainant.Text = "Select complainant" : txtIssue.Text = "Select issue or add new issue.." : txtContent.Text = "Content details.." : code.Text = ""
            ShowOpenFilters()
            MessageBox.Show("Reminder successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   

    Private Sub cmdDownloadApprovedCopy_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            code.Text = rw.Cells("code").Value.ToString
            txtIssue.Text = rw.Cells("Issue").Value.ToString
            txtRespondent.Text = rw.Cells("Respondent").Value.ToString
            txtComplainant.Text = rw.Cells("Complainant").Value.ToString
            txtContent.Text = rw.Cells("Details").Value.ToString
            mode.Text = "edit"
            txtContent.Focus()
            TabControl1.SelectedIndex = 0
        Next
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tabOpenComplaints Then
            cmdEdit.Visible = True
            cmdCloseReminder.Visible = True
        ElseIf TabControl1.SelectedTab Is tabCloseComplaints Then
            cmdEdit.Visible = False
            cmdCloseReminder.Visible = False
        End If
    End Sub
    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If TabControl1.SelectedTab Is tabOpenComplaints Then
            ShowOpenFilters()
        ElseIf TabControl1.SelectedTab Is tabCloseComplaints Then
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
                MainForm.NotifyIcon1.BalloonTipText = "Your file successfully exported at " & f.SelectedPath & "\" & LCase(Me.Text) & ".xls"
                MainForm.NotifyIcon1.ShowBalloonTip(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub txtissue_GotFocus(sender As Object, e As EventArgs) Handles txtIssue.GotFocus
        If txtIssue.Text = "Select issue or add new issue.." Then
            txtIssue.Text = ""
        End If
    End Sub

    Private Sub txtissue_LostFocus(sender As Object, e As EventArgs) Handles txtIssue.LostFocus
        If txtIssue.Text = "" Then
            txtIssue.Text = "Select issue or add new issue.."
        End If
    End Sub

    Private Sub txtRespondent_GotFocus(sender As Object, e As EventArgs) Handles txtRespondent.GotFocus
        If txtRespondent.Text = "Select respondent" Then
            txtRespondent.Text = ""
        End If
    End Sub

    Private Sub txtRespondent_LostFocus(sender As Object, e As EventArgs) Handles txtRespondent.LostFocus
        If txtRespondent.Text = "" Then
            txtRespondent.Text = "Select respondent"
        End If
    End Sub


    Private Sub txtComplainant_GotFocus(sender As Object, e As EventArgs) Handles txtComplainant.GotFocus
        If txtComplainant.Text = "Select complainant" Then
            txtComplainant.Text = ""
        End If
    End Sub

    Private Sub txtComplainant_LostFocus(sender As Object, e As EventArgs) Handles txtComplainant.LostFocus
        If txtComplainant.Text = "" Then
            txtComplainant.Text = "Select complainant"
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
        If TabControl1.SelectedTab Is tabOpenComplaints Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                frmComplaintsHistory.code.Text = rw.Cells("code").Value.ToString
                frmComplaintsHistory.Text = rw.Cells("issue").Value.ToString
                frmComplaintsHistory.txtContent.Enabled = True
                frmComplaintsHistory.cmdset.Enabled = True
                frmComplaintsHistory.ShowDialog(Me)
            Next
        ElseIf TabControl1.SelectedTab Is tabCloseComplaints Then
            For Each rw As DataGridViewRow In MyDataGridView_close.SelectedRows
                frmComplaintsHistory.code.Text = rw.Cells("code").Value.ToString
                frmComplaintsHistory.Text = rw.Cells("issue").Value.ToString
                frmComplaintsHistory.txtContent.Enabled = False
                frmComplaintsHistory.cmdset.Enabled = False
                frmComplaintsHistory.ShowDialog(Me)
            Next
        End If
    End Sub

    Private Sub CloseReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdCloseReminder.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "UPDATE tblcomplaintbox set closed=1 where code='" & rw.Cells("code").Value.ToString & "'" : com.ExecuteNonQuery()
                ShowOpenFilters() : ShowCloseFilters()
            Next
        End If
    End Sub

    'Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
    '    If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
    '            com.CommandText = "DELETE FROM tblcomplaintbox where code='" & rw.Cells("code").Value.ToString & "'" : com.ExecuteNonQuery()
    '            ShowOpenFilters()
    '        Next
    '    End If
    'End Sub
End Class