Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmAccountInformation

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If globalUserRequiredUpdateInfo = True Then
            Me.StartPosition = FormStartPosition.CenterScreen
        End If
        If GlobalOrganization_KB = True Then
            lblEmail.Text = "Your Zimbra Email Add"
        End If
        txtSystemIcon.Items.Clear()
        For Each folder In System.IO.Directory.GetDirectories(Application.StartupPath & "\Icon")
            txtSystemIcon.Items.Add(folder.Replace(Application.StartupPath & "\Icon\", ""))
        Next
        com.CommandText = "select * from tblaccounts where accountid = '" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "'" : rst = com.ExecuteReader
        While rst.Read
            txtName.Text = rst("fullname").ToString
            txtNickname.Text = rst("nickname").ToString
            txtPosition.Text = rst("designation").ToString
            If rst("emailaddress").ToString = "" Then
                'Dim word As String() = globalserverEmailAddress.Split("@")
                'txtEmail.Text = "username@" + word(1)
                'txtEmail.BackColor = Color.Red
                'txtEmail.ForeColor = Color.White
            Else
                txtEmail.Text = rst("emailaddress").ToString
                txtEmail.BackColor = Color.White
                txtEmail.ForeColor = DefaultForeColor
            End If
            txtContactNumber.Text = rst("contactnumber").ToString
            txtSystemIcon.Text = rst("iconfolderclient").ToString
            txtBgColor.Text = rst("bgcolorclient").ToString
            txtFontColor.Text = rst("fontcolorclient").ToString
            ChangeColor(rst("bgcolorclient").ToString)
            ShowImage("profileimg", imgProfile)
        End While
        rst.Close()
    End Sub

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtNickname.Text = "" Then
            MessageBox.Show("Please enter your nickname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNickname.Focus()
            Exit Sub
        ElseIf txtContactNumber.Text = "" Then
            MessageBox.Show("Please enter your contact number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        ElseIf txtCurrentPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter your current password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter you new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please verify your new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text And ckChangePassword.Checked = True Then
            MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "accountid='" & globaluserid & "' and password='" & EncryptTripleDES(UCase(globalusername) + txtCurrentPassword.Text) & "'") = 0 And ckChangePassword.Checked = True Then
            MessageBox.Show("Your current password is invalid! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to update changes? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            com.CommandText = "update tblaccounts set nickname='" & rchar(txtNickname.Text) & "', designation='" & rchar(txtPosition.Text) & "', emailaddress='" & txtEmail.Text & "', contactnumber='" & txtContactNumber.Text & "', iconfolderclient='" & txtSystemIcon.Text & "',bgcolorclient='" & txtBgColor.Text & "',fontcolorclient='" & txtFontColor.Text & "', requiredupdate=0 where accountid='" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "' " : com.ExecuteNonQuery()

            If ckPicChanged.Checked = True Then
                UpdateImage("accountid='" & globaluserid & "'", "profileimg", "tblaccounts", Imaging.ImageFormat.Png, imgProfile)
            End If

            If ckChangePassword.Checked = True Then
                com.CommandText = "update tblaccounts set password='" & EncryptTripleDES(UCase(globalusername) + txtVerifyPassword.Text) & "', webpassword=DES_ENCRYPT('" & globalusername + txtVerifyPassword.Text & "','kira')  where accountid='" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "'" : com.ExecuteNonQuery()
            End If
            If mode.Text = "startup" Then
                MessageBox.Show("Hello " & txtNickname.Text & "! Welcome to new coffeecup system, and your account information successfully updated.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                globalUserRequiredUpdateInfo = False
                MessageBox.Show("your account successfully updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
           
            LoadAccountDetails(globaluserid)
            Me.Close()
        End If

    End Sub

    Private Sub imgProfile_EditValueChanged(sender As Object, e As EventArgs) Handles imgProfile.EditValueChanged
        ckPicChanged.Checked = True
    End Sub

    Private Sub imgProfile_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles imgProfile.Validating
        ResizeImage(imgProfile, 450)
    End Sub

    Private Sub ckEnableEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles ckChangePassword.CheckedChanged
        If ckChangePassword.Checked = True Then
            txtCurrentPassword.ReadOnly = False
            txtNewPassword.ReadOnly = False
            txtVerifyPassword.ReadOnly = False
        Else
            txtCurrentPassword.ReadOnly = True
            txtNewPassword.ReadOnly = True
            txtVerifyPassword.ReadOnly = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtBgColor.Text = ColorDialog1.Color.R.ToString & "," & ColorDialog1.Color.G.ToString & "," & ColorDialog1.Color.B.ToString
            ChangeColor(txtBgColor.Text)
        End If
    End Sub

    Public Sub ChangeColor(ByVal RGBString As String)
        Dim RGB As String() = RGBString.Split(",")
        txtBgColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        txtBgColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
    End Sub

    Private Sub txtBgColor_TextChanged(sender As Object, e As EventArgs) Handles txtSystemIcon.TextChanged, txtBgColor.TextChanged, txtFontColor.TextChanged
        MainForm.LoadSystemAppearance(txtSystemIcon.Text, txtBgColor.Text, txtFontColor.Text)
    End Sub
End Class