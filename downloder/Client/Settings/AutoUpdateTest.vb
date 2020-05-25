Imports System.Net
Imports System.IO
Imports System.Reflection

Public Class AutoUpdateTest
    Dim filename As String
    Dim updater As WebClient = New WebClient

    Private Sub AutoUpdateTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler updater.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler updater.DownloadFileCompleted, AddressOf client_DownloadCompleted

        If OpenMysqlConnection() = True Then
            If CheckNewUpdate() = True Then
                Label1.Text = "Downloading.."
                Timer1.Enabled = True
                ProgressBar1.Visible = True
            Else
                'Go to your main form or make visible all hide control in login form
            End If
        End If

    End Sub

#Region "AUTO UPDATE MODULE"

    Public Function CheckNewUpdate() As Boolean
        com.CommandText = "select *, date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') as dt from tblclientsystemupdate where date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') > '" & ConvertDate(dversion) & "' and isclient=1  order by date_format(str_to_date(version, '%Y.%m.%d'), '%Y-%m-%d') asc limit 1" : rst = com.ExecuteReader
        If rst.Read Then
            txtUpdateUrl.Text = rst("downloadurl").ToString
            txtversion.Text = rst("version").ToString
            CheckNewUpdate = True
        Else
            CheckNewUpdate = False
        End If
        rst.Close()
    End Function
     
    Public Sub GetFileInformation()
        Dim ArchivedLocation As String = Application.StartupPath.ToString & "\UpdateVersion\"

        If (Not System.IO.Directory.Exists(ArchivedLocation)) Then
            System.IO.Directory.CreateDirectory(ArchivedLocation)
        End If

        filename = ArchivedLocation & Me.txtUpdateUrl.Text.Split("/"c)(Me.txtUpdateUrl.Text.Split("/"c).Length - 1)
        txtDownloadLocation.Text = filename
        updater.DownloadFileAsync(New Uri(txtUpdateUrl.Text), txtDownloadLocation.Text)
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        Label1.Text = "Downloading " & Int32.Parse(Math.Truncate(percentage).ToString()) & "%"
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim ass As Assembly = Assembly.GetExecutingAssembly()
        Dim updateFileInfo As String = Application.StartupPath.ToString & "\UpdateVersion" & "\UpdateInfo.txt"
        If System.IO.File.Exists(updateFileInfo) = True Then
            System.IO.File.Delete(updateFileInfo)
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(updateFileInfo, True)
        detailsFile.WriteLine(Path.GetFileName(ass.Location) & "|" & System.IO.Path.GetDirectoryName(ass.Location) & "|" & txtDownloadLocation.Text & "|" & txtversion.Text)
        detailsFile.Close()
        Process.Start(Application.StartupPath.ToString & "\SystemUpdater.exe")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() : Timer1.Enabled = False
        GetFileInformation()
    End Sub

#End Region

End Class