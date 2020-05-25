Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net

Public Class frmPOSSalesSelectCashier
    Public SelectDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            If cmdset.Focused = True Then
                txtUserAccount.Focus()
            Else
                Me.Close()
            End If

        End If
        Return ProcessCmdKey
    End Function

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtUserAccount.Text = "" Then
            MessageBox.Show("Please select user account!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserAccount.Focus()
            Exit Sub
        End If
        If OpenMysqlConnection() = True Then
            If globalAssistantUserId = "" Then
                globalTransactionUserid = globaluserid
                globalAssistantUserId = globaluserid
                globalAssistantFullName = globalfullname
            End If
            globaluserid = DirectCast(txtUserAccount.SelectedItem, ComboBoxItem).HiddenValue()
            LoadCashierDetails(globaluserid)
            If EnableModuleSales = True Then
                MainForm.VerifyOpenTransaction()
            End If
            SelectDone = True
            Me.Close()
        End If
    End Sub

    Private Sub txtUserAccount_GotFocus(sender As Object, e As EventArgs) Handles txtUserAccount.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Public Sub viewAccountinfo()
        com.CommandText = "select *,(select officename from tblcompoffice where officeid = tblaccounts.officeid) as 'office',(select authDescription from tbluserauthority where authcode = tblaccounts.coffeecupposition)  as 'permissiontemp' from tblaccounts where accountid='" & DirectCast(txtUserAccount.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader()
        While rst.Read
            txtAccountDetails.Text = "Username: " & rst("username").ToString & Environment.NewLine _
                            + "Account Name: " & rst("fullname").ToString & Environment.NewLine _
                            + "Position: " & rst("designation").ToString & Environment.NewLine _
                            + "Branch: " & rst("office").ToString & Environment.NewLine _
                            + "Permission: " & rst("permissiontemp").ToString
        End While
        rst.Close()
        Me.AcceptButton = cmdset
    End Sub


    Private Sub frmAdminChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("SELECT userid, (select fullname from tblaccounts where accountid=tblsalessummary.userid) as 'fullname' FROM tblsalessummary where openfortrn = 1 and officeid='" & compOfficeid & "'", "fullname", "userid", txtUserAccount)
        txtAccountDetails.Text = ""
    End Sub


    Private Sub txtUserAccount_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtUserAccount.SelectedValueChanged
        viewAccountinfo()
    End Sub
End Class