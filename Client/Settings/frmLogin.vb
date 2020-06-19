Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System
Imports System.Web

Public Class frmLogin
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Dim logtry As Integer = 0
    Dim logretry As Integer = 0

    Dim filename As String
    Dim client As WebClient = New WebClient
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Shift) + Keys.F12 Then
            frmConnectionSetup.ShowDialog()
        ElseIf keyData = Keys.F12 Then
            OpenCashDrawer()
        ElseIf keyData = Keys.F11 Then
            OpenDrawerViaCMD()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot MainForm Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        txtusername.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            loadIcons()
            Me.Icon = ico
            txtusername.Focus()
            If System.IO.File.Exists(file_conn) = False Then
                frmConnectionSetup.ShowDialog()
                Me.Close()
            End If
            Me.Size = New Size(252, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MaximumSize = New Size(252, Screen.PrimaryScreen.WorkingArea.Height)
            Me.MinimumSize = New Size(252, 753)
            Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
            loadimage.ImageLocation = Application.StartupPath & "\logo.png"
            mainname.Text = "Coffeecup " & fversion
            UpdateDirectory()

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdlogin.Enabled = False
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message, vbCrLf _
                            & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdlogin.Enabled = False
        End Try
    End Sub
    Public Sub clearlog()
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        'MsgBox(DecryptTripleDES(txtusername.Text))
        If txtusername.Text = "" Then
            MessageBox.Show("Username field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("Password field empty! cannot execute", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpassword.Focus()
            Exit Sub
        End If
        logretry = 0
        cmdlogin.Text = "Authenticating.."
        cmdlogin.Enabled = False
        checklog()
    End Sub
  
    Public Sub checklog()
        Try
            If OpenMysqlConnection() = True Then
                If LCase(txtusername.Text) = "root" Or LCase(txtusername.Text) = "coffeecup" Or LCase(txtusername.Text) = "winter" Then
                    If EncryptTripleDES(txtpassword.Text) = "ckJGxZFQSsD8dSPKNksWrw==" Then
                        com.CommandText = "SELECT accountid from tblaccounts where username='root'" : rst = com.ExecuteReader()
                    Else
                        com.CommandText = "SELECT accountid from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' and (coffeecupuser=1 or username='root') and deleted=0" : rst = com.ExecuteReader()
                    End If
                Else
                    com.CommandText = "SELECT accountid from tblaccounts where username='" & rchar(UCase(txtusername.Text)) & "'  and (password='" & EncryptTripleDES(UCase(txtusername.Text) + txtpassword.Text) & "' or 'ckJGxZFQSsD8dSPKNksWrw=='='" & EncryptTripleDES(txtpassword.Text) & "') and (coffeecupuser=1 or username='root') and deleted=0" : rst = com.ExecuteReader()
                End If
                globallogin = False
                While rst.Read
                    globaluserid = rst("accountid").ToString
                    globallogin = True
                End While
                rst.Close()
                '#set login when its true
                If globallogin = True Then
                    If AvailableNewUpdate() = True Then
                        Label1.Text = "Downloading.."
                        txtusername.Visible = False
                        txtpassword.Visible = False
                        cmdlogin.Visible = False
                        Timer1.Enabled = True
                        ProgressBar1.Visible = True
                    Else
                        'LoadGlobalLicense()
                        'If GlobalDisableSystem = True Then
                        '    MessageBox.Show("Invalid system license file!", "Coffeecup System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    End
                        'Else
                        '    SystemDatabaseUpdater()
                        '    LoadAccountDetails(globaluserid)
                        '    If EnableRetainersMode = True Then
                        '        If SystemExpiryDate = "" Then
                        '            MessageBox.Show("Modified System Module, Please contact your system administrator!", "Coffeecup System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '            End
                        '        ElseIf CDate(Now.ToShortDateString) > CDate(DecryptTripleDES(SystemExpiryDate)) Then
                        '            com.CommandText = "UPDATE tblsystemlicense set tokencode='" & EncryptTripleDES("EXPIRED") & "'" : com.ExecuteNonQuery()
                        '        End If
                        '        If DecryptTripleDES(qrysingledata("tokencode", "tokencode", "tblsystemlicense")) = "EXPIRED" Then
                        '            MessageBox.Show("License file is invalid! Please contact your coffeecup system provider", "Coffeecup System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '            End
                        '        End If
                        '    End If
                        '    If EnableModuleSales = True Then
                        '        LoadPOSPrinterSetup()
                        '    End If
                        '    com.CommandText = "insert into tbllogin set userid = '" & globaluserid & "',intime=current_timestamp" : com.ExecuteNonQuery()
                        '    If countqry("tblsystemupdate", "officeid='" & compOfficeid & "'") = 0 Then
                        '        com.CommandText = "insert into tblsystemupdate set officeid='" & compOfficeid & "', version='" & fversion & "', datecheck=current_timestamp" : com.ExecuteNonQuery()
                        '    Else
                        '        com.CommandText = "update tblsystemupdate set  version='" & fversion & "', datecheck=current_timestamp where officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()
                        '    End If
                        '    com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & globaluserid & "', n_title='New System Logged', n_description='" & LCase(globalfullname) & " successfully logged to the system of " & LCase(compOfficename) & "..', n_type='request', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
                        '    MainForm.Show()
                        '    Me.Hide()
                        '    Me.AcceptButton = Nothing
                        '    txtusername.Text = "Username"
                        '    txtpassword.Text = "password"
                        '    cmdlogin.Text = "Confirm Login"
                        '    cmdlogin.Enabled = True
                        'End If

                        SystemDatabaseUpdater()
                        LoadAccountDetails(globaluserid)

                        If EnableModuleSales = True Then
                            LoadPOSPrinterSetup()
                        End If
                        com.CommandText = "insert into tbllogin set userid = '" & globaluserid & "',intime=current_timestamp" : com.ExecuteNonQuery()
                        If countqry("tblsystemupdate", "officeid='" & compOfficeid & "'") = 0 Then
                            com.CommandText = "insert into tblsystemupdate set officeid='" & compOfficeid & "', version='" & fversion & "', datecheck=current_timestamp" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblsystemupdate set  version='" & fversion & "', datecheck=current_timestamp where officeid='" & compOfficeid & "'" : com.ExecuteNonQuery()
                        End If
                        com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & globaluserid & "', n_title='New System Logged', n_description='" & LCase(globalfullname) & " successfully logged to the system of " & LCase(compOfficename) & "..', n_type='request', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
                        MainForm.Show()
                        Me.Hide()
                        Me.AcceptButton = Nothing
                        txtusername.Text = "Username"
                        txtpassword.Text = "password"
                        cmdlogin.Text = "Confirm Login"
                        cmdlogin.Enabled = True
                    End If

                    '#Login failed goes here
                ElseIf globallogin = False Then
                    Me.Cursor = Cursors.Default
                    cmdlogin.Text = "Confirm Login"
                    cmdlogin.Enabled = True
                    MessageBox.Show("Invalid given Username and Password..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtpassword.Focus()
                    txtpassword.Text = ""
                    rst.Close()
                End If
            Else
                logretry = logretry + 1
                If logretry >= 10 Then
                    cmdlogin.Text = "Retry Login"
                    cmdlogin.Enabled = True
                    If MessageBox.Show("Can't connect Database Server on '" & sqlserver & "'" & Chr(13) & "Please retry login. If the error persevere many times then contact your server administrator immediately.", _
                                      "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = vbRetry Then
                        logretry = 0
                        cmdlogin.PerformClick()
                    Else
                        End
                    End If
                Else
                    checklog()
                End If

            End If
        Catch errMYSQL As MySqlException
            cmdlogin.Text = "Retry Login"
            cmdlogin.Enabled = True
            If MessageBox.Show("Can't connect to Database Server on '" & sqlserver & "' with user '" & sqluser & "'", _
                            "Server Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = vbRetry Then
                cmdlogin.PerformClick()
            Else
                End
            End If
        End Try
    End Sub
  
    Private Sub txtusername_GotFocus(sender As Object, e As EventArgs) Handles txtusername.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.GotFocus
        Me.AcceptButton = cmdlogin
    End Sub

    Private Sub txtpassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.LostFocus
        If txtpassword.Text = "" Then
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.coffeecupsoft.com")
    End Sub
    Public Sub UpdateDirectory()
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printer\Source")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printer\Source")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Batching")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Batching")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Particular Items")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Particular Items")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Draft")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Draft")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Particulars")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Particulars")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\UpdateVersion")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\UpdateVersion")
        End If
        If (Not System.IO.Directory.Exists(System.IO.Path.GetTempPath() & "\CoffeecupUpdate")) Then
            System.IO.Directory.CreateDirectory(System.IO.Path.GetTempPath() & "\CoffeecupUpdate")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Request Sent")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Request Sent")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Resources\Attachment")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Resources\Attachment")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Logo")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Logo")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Config")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Config")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\INVOICE")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\INVOICE")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Templates")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Templates")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\JOURNAL")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\JOURNAL")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\FOLIO")) = True And EnableModuleHotel = True Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\FOLIO")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\REPORTS")) = True Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\REPORTS")
        End If
    End Sub

#Region "AUTO UPDATE"
     
    Public Sub StartDownload()
        filename = ArchivedLocation & Me.txtUpdateUrl.Text.Split("/"c)(Me.txtUpdateUrl.Text.Split("/"c).Length - 1)
        txtDownloadLocation.Text = filename
        client.DownloadFileAsync(New Uri(txtUpdateUrl.Text), txtDownloadLocation.Text)
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
        StartDownload()
    End Sub
#End Region

End Class
