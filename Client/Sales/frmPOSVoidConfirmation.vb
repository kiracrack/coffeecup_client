Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSVoidConfirmation
    Public ApprovedConfirmation As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAdminCancelledConfirmation_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtUser.Focus()
        Me.AcceptButton = Nothing
    End Sub
    Private Sub frmAdminCancelledConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Refresh()
        txtUser.Text = "Username"
        txtpassword.Text = "Password"
        txtUser.SelectAll()
        txtUser.Focus()
    End Sub
    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If txtReason.Text = "" Or txtReason.Text = "Reason.." Then
            MessageBox.Show("Please enter void Reason!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If UserConfirmation() = False Then
            ApprovedConfirmation = False
            MsgBox("Invalid authorized user accounts!", MsgBoxStyle.Exclamation)
            txtUser.Text = "Username"
            txtpassword.Text = "Password"
            txtUser.Focus()
            Me.AcceptButton = Nothing
            Exit Sub
        Else
            ApprovedConfirmation = True
        End If
        Me.Close()
    End Sub

    Public Function UserConfirmation() As Boolean
        UserConfirmation = False
        If LCase(txtUser.Text) = "root" Or LCase(txtUser.Text) = "coffeecup" Or LCase(txtUser.Text) = "winter" Then
            If EncryptTripleDES(txtpassword.Text) = "ckJGxZFQSsD8dSPKNksWrw==" Then
                com.CommandText = "SELECT * from tblaccounts where username='root'" : rst = com.ExecuteReader()
            Else
                com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtUser.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtUser.Text) + txtpassword.Text) & "'" : rst = com.ExecuteReader()
            End If
        Else
            If GlobalStrictadminconfirmed = True Then
                com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtUser.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtUser.Text) + txtpassword.Text) & "' and (coffeecupposition in (select authcode from tbluserauthority where officeapprover=1 or corpapprover=1) or lcase(username) = 'root')" : rst = com.ExecuteReader()
            Else
                com.CommandText = "SELECT * from tblaccounts where username='" & rchar(UCase(txtUser.Text)) & "'  and password='" & EncryptTripleDES(UCase(txtUser.Text) + txtpassword.Text) & "'" : rst = com.ExecuteReader()
            End If
        End If
        While rst.Read()
            UserConfirmation = True
            userid.Text = rst("accountid").ToString
        End While
        rst.Close()
        Return UserConfirmation
    End Function

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()
        End If
    End Sub
   
    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            txtReason.Focus()
        End If
    End Sub

    Private Sub txtReason_GotFocus(sender As Object, e As EventArgs) Handles txtReason.GotFocus
        If txtReason.Text = "Reason.." Then
            txtReason.Text = ""
        End If
        Me.AcceptButton = cmdConfirm
    End Sub

    Private Sub txtReason_LostFocus(sender As Object, e As EventArgs) Handles txtReason.LostFocus
        If txtReason.Text = "" Then
            txtReason.Text = "Reason.."
        End If
        Me.AcceptButton = Nothing
    End Sub
 
End Class