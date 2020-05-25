Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports System.Web

Public Class frmSystemUploader
    Dim m_CountTo As Integer = 0

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

   
      Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Update the progress bar
        Me.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim filePath As String = txtattached1.Text
        Dim slashPosition As Integer = filePath.LastIndexOf("\")
        Dim filenameOnly As String = filePath.Substring(slashPosition + 1)

        My.Computer.Network.UploadFile(txtattached1.Text, "ftp://katipunanbank.com/" & filenameOnly, "coffeecupclient@katipunanbank.com", "12cc10134", FileIO.UIOption.AllDialogs, 100, FileIO.UICancelOption.DoNothing)

        Dim clsRequest As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://katipunanbank.com/" & filenameOnly), System.Net.FtpWebRequest)
        clsRequest.Credentials = New System.Net.NetworkCredential("usrname", "pass")
        clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        ' read in file...
        Dim bFile() As Byte = System.IO.File.ReadAllBytes(txtattached1.Text)

        ' upload file...
        Dim clsStream As System.IO.Stream = clsRequest.GetRequestStream()
        clsStream.Write(bFile, 0, bFile.Length)
        clsStream.Close()
        clsStream.Dispose()

        For i As Integer = 0 To m_CountTo
            ' Has the background worker be told to stop?
            If BackgroundWorker1.CancellationPending Then
                ' Set Cancel to True
                e.Cancel = True
                Exit For
            End If
            System.Threading.Thread.Sleep(1000) ' Sleep for 1 Second
            ' Report The progress of the Background Worker.
            BackgroundWorker1.ReportProgress(CInt((i / m_CountTo) * 100))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Dim OpenFileDialog1 As OpenFileDialog
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Title = "Chose a File"
        txtattached1.Text = OpenFileDialog1.FileName
        txtattached1.Text = OpenFileDialog1.SafeFileName
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    
    Private Sub frmSystemUploader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
End Class