Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmSendMessage

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtmessage.Text.Length < 1 Then
            MessageBox.Show("Please enter message!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtmessage.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue send? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            Me.Cursor = Cursors.WaitCursor
            com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='CHAT', n_title='New Message', n_description='" & rchar(txtmessage.Text) & "', n_type='chat', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0"
            com.ExecuteNonQuery()

            'If GlobalEnableEmailNotification = True Then
            '    FileAttach(0) = ""
            '    strSubject = "CoffeCup Client: Message"
            '    strMessage = txtmessage.Text + "<br/><br/><br/> <strong>" + globalfullname + "</strong>" + globalposition + "<br/>" + globalofficeemail
            '    If SendEmailMessage(strSubject, strMessage, FileAttach) = True Then
            '        MessageBox.Show("Your message was successfully sent.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Me.Close()
            '    End If
            'Else
            MessageBox.Show("Your message was successfully sent.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            'End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub frmSendMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub
End Class