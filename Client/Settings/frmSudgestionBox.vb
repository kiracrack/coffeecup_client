Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmSudgestionBox
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ViewHistory()
    End Sub

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtDetails.Text = "" Then
            MessageBox.Show("Please enter your suggestion or error report details!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDetails.Focus()
            Exit Sub
        ElseIf checkAttachment(txtattached1.Text) = False Then
            MessageBox.Show("Attached file is too large!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtattached1.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to submit report? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim refno As String = getGlobalTrnid(compOfficeid, globaluserid)
            If ckQuotation.Checked = True Then
                If AddAttachmentPackage(refno, "suggestion-box", {txtattached1.Text}) = True Then
                    com.CommandText = "insert into tblsuggestionbox set refnumber='" & refno & "', version='" & fversion & "', systemname='CLIENT', datesubmitted=current_timestamp,officeid='" & compOfficeid & "', submitby='" & globaluserid & "', details='" & rchar(txtDetails.Text) & "'" : com.ExecuteNonQuery()
                End If
            Else
                com.CommandText = "insert into tblsuggestionbox set refnumber='" & refno & "', version='" & fversion & "', systemname='CLIENT', datesubmitted=current_timestamp,officeid='" & compOfficeid & "', submitby='" & globaluserid & "', details='" & rchar(txtDetails.Text) & "'" : com.ExecuteNonQuery()
            End If

            txtDetails.Text = "" : ViewHistory() : txtattached1.Text = ""
            MessageBox.Show("Report successfully submitted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub ViewHistory()
        Dim filterasof As String = ""
        Dim startSchedule As Date = txtfrmdate.Value.Date
        Dim endSchedule As Date = txttodate.Value.Date.AddDays(1)
        If ckasof.Checked = True Then
            filterasof = " datesubmitted <= '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        Else
            filterasof = " datesubmitted  between '" + startSchedule.ToString("yyyy-MM-dd") + "' AND '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        End If
        dst = New DataSet
        msda = New MySqlDataAdapter("Select id, refnumber, (select officename from tblcompoffice where officeid = tblsuggestionbox.officeid) as 'Office', (select fullname from tblaccounts where accountid = tblsuggestionbox.submitby) as 'Submit By',  version as 'Version',date_format(datesubmitted,'%Y-%m-%d') as 'Date',Details, Resolved, " _
                                    + " (select if(count(*)>0, 'YES', 'NO') from "  & sqlfiledir & ".tblattachmentlogs where refnumber = tblsuggestionbox.refnumber) as 'Attachment' " _
                                    + " from tblsuggestionbox where systemname='CLIENT' order by datesubmitted desc", conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"id", "refnumber"})
        GridColumnAlignment(MyDataGridView, {"Attachment"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        ViewHistory()
    End Sub

    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmda1.Enabled = True
        Else
            txtattached1.Text = ""
            cmda1.Enabled = False
        End If
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "All Types (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With
        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                'txtattached1.Text = objOpenFileDialog.FileName
                If checkAttachment(objOpenFileDialog.FileName) = False Then
                    txtattached1.BackColor = Color.Red
                Else
                    txtattached1.BackColor = Color.White
                End If
                If (Not System.IO.Directory.Exists(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")) Then
                    System.IO.Directory.CreateDirectory(file_Attachment & Now.ToString("yyyy-MM-dd") & "\")
                End If
                System.IO.File.Delete(file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                System.IO.File.Copy(objOpenFileDialog.FileName, file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName))
                txtattached1.Text = file_Attachment & Now.ToString("yyyy-MM-dd") & "\" & System.IO.Path.GetFileName(objOpenFileDialog.FileName)
            Catch fileException As Exception
                Throw fileException
            End Try
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Process.Start(Application.StartupPath & "\attachment.pdf")
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

    Private Sub cmdDownloadApprovedCopy_Click(sender As Object, e As EventArgs) Handles cmdDownloadApprovedCopy.Click
        If MyDataGridView.Item("Attachment", MyDataGridView.CurrentRow.Index).Value().ToString = "NO" Then
            MessageBox.Show("No file attached!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Me.WindowState = FormWindowState.Minimized
        ViewAttachmentPackage_Database({MyDataGridView.Item("refnumber", MyDataGridView.CurrentRow.Index).Value().ToString}, "suggestion-box")
    End Sub
End Class