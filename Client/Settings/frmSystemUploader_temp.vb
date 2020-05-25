Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports System.Web

Public Class frmSystemUploader_temp
    Private WithEvents myFtpUploadWebClient As New WebClient

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub


    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmda1.Click
        Dim objOpenFileDialog As New OpenFileDialog
        'With objOpenFileDialog
        '    .Filter = "All files (*.*)|*.*"
        '    .FilterIndex = 1
        '    .Title = "Open File Dialog"
        'End With
        'If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '    Dim allText As String
        '    Try
        '        allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
        '        txtattached1.Text = objOpenFileDialog.FileName
        '        Dim path As String = txtattached1.Text
        '        Dim file() As Byte = System.IO.File.ReadAllBytes(objOpenFileDialog.FileName)
        '        txtTotalSize.Text = "File Size: " & Format(Math.Round((file.Length), 2) / 1024, "n") & " KB"
        '    Catch fileException As Exception
        '        Throw fileException
        '    End Try
        '    objOpenFileDialog.Dispose()
        '    objOpenFileDialog = Nothing
        'End If

        If objOpenFileDialog.ShowDialog() = DialogResult.OK Then
            objOpenFileDialog.Title = "Please choose the Authorization File"
            txtattached1.Text = objOpenFileDialog.FileName
            ProgressBar1.Show()
            Me.Cursor = Cursors.WaitCursor

            Dim filePath As String = txtattached1.Text
            Dim slashPosition As Integer = filePath.LastIndexOf("\")
            Dim filenameOnly As String = filePath.Substring(slashPosition + 1)

            Dim myUri As New Uri("ftp://katipunanbank.com/" & filenameOnly)
            myFtpUploadWebClient.Credentials = New System.Net.NetworkCredential("coffeecupclient@katipunanbank.com", "12cc10134")
            myFtpUploadWebClient.UploadFileAsync(myUri, objOpenFileDialog.FileName)
        End If


    End Sub
    Private Sub myFtpUploadWebClient_UploadFileCompleted(sender As Object, e As System.Net.UploadFileCompletedEventArgs) Handles myFtpUploadWebClient.UploadFileCompleted

        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
        Else
            Me.Cursor = Cursors.Default
            MessageBox.Show("Authorization Form Uploaded Successfully!")
        End If
    End Sub

    Private Sub myFtpUploadWebClient_UploadProgressChanged(sender As Object, e As System.Net.UploadProgressChangedEventArgs) Handles myFtpUploadWebClient.UploadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = txtattached1.Text
        Dim slashPosition As Integer = filePath.LastIndexOf("\")
        Dim filenameOnly As String = filePath.Substring(slashPosition + 1)

        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://katipunanbank.com/" & filenameOnly), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential("coffeecupclient@katipunanbank.com", "12cc10134")
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile



        Dim path As String = txtattached1.Text
        Dim file() As Byte = System.IO.File.ReadAllBytes(path)
        Dim strz As System.IO.Stream = request.GetRequestStream()


        For offset As Integer = 0 To file.Length Step 1024
            ProgressBar1.Value = CType(offset * ProgressBar1.Maximum / file.Length, Integer)
            Dim chunkSize As Integer = file.Length - offset - 1
            If chunkSize > 1024 Then chunkSize = 1024
            strz.Write(file, offset, chunkSize)
        Next
        ProgressBar1.Value = ProgressBar1.Maximum
        strz.Close()
        strz.Dispose()
        frmSystemUpdate.txtUrl.Text = "http://katipunanbank.com/application/coffeecupClient/" & filenameOnly
        MsgBox("File successfully updoaded", MsgBoxStyle.Information)
    End Sub
End Class