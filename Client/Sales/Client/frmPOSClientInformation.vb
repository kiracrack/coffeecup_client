Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSClientInformation
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmClientInformation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmClientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtClientGroup.Items.Clear()
        com.CommandText = "select * from tblclientgroup order by groupname asc" : rst = com.ExecuteReader
        While rst.Read
            txtClientGroup.Items.Add(New ComboBoxItem(rst("groupname").ToString, rst("groupcode").ToString))
        End While
        rst.Close()

        If mode.Text = "view" Then
            LoadInformation()
            If GLobalenableclientupdatecustomerinfo = True Then
                readOnlineItem(False)
                cmdConfirm.Text = "Save Client"
            Else
                readOnlineItem(True)
                cmdConfirm.Text = "OK"
            End If
            cmdConfirm.Focus()
        Else
            id.Text = getClientid()
            txtCompanyName.Text = ""
            txtAddress.Text = ""
            txtContactNumber.Text = ""
            txtVIPno.Text = ""

            If GLobalenabledirectapprovedclient = True Then
                cmdConfirm.Text = "Save Client"
            Else
                cmdConfirm.Text = "Submit for Approval"
            End If
            readOnlineItem(False)
        End If
    End Sub

    Public Sub readOnlineItem(ByVal readonlyform As Boolean)
        txtCompanyName.ReadOnly = readonlyform
        txtAddress.ReadOnly = readonlyform
        txtContactNumber.ReadOnly = readonlyform
        txtVIPno.ReadOnly = readonlyform
        txtBirthdate.Enabled = If(readonlyform = True, False, True)
        txtEmail.ReadOnly = readonlyform
        txtClientGroup.Enabled = If(readonlyform = True, False, True)
    End Sub
    Public Sub LoadInformation()
        com.CommandText = "select *, (select groupname from tblclientgroup where groupcode = tblclientaccounts.groupcode) as 'acctgroup', " _
                             + " (select vipcardno from tblhotelguest where guestid=tblclientaccounts.vipguestid) as vipno " _
                             + " from tblclientaccounts where cifid='" & id.Text & "'"
        rst = com.ExecuteReader
        While rst.Read
            txtCompanyName.Text = rst("COMPANYNAME").ToString
            txtAddress.Text = rst("COMPADD").ToString
            txtContactNumber.Text = rst("TELEPHONE").ToString

            If rst("birthdate").ToString <> "" Then
                txtBirthdate.Value = rst("birthdate").ToString
            End If
            txtEmail.Text = rst("emailadd").ToString

            txtClientGroup.Text = rst("acctgroup").ToString
            groupcode.Text = rst("groupcode").ToString

            txtVIPno.Text = rst("vipno").ToString
        End While
        rst.Close()

    End Sub
    Private Sub txtClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtClientGroup.SelectedIndexChanged
        If txtClientGroup.Text <> "" Then
            groupcode.Text = DirectCast(txtClientGroup.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            groupcode.Text = ""
        End If
    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If mode.Text = "view" Then
            If GLobalenableclientupdatecustomerinfo = True Then
                com.CommandText = "UPDATE tblclientaccounts set groupcode='" & groupcode.Text & "', companyname='" & rchar(txtCompanyName.Text) & "', compadd='" & rchar(txtAddress.Text) & "', telephone='" & rchar(txtContactNumber.Text) & "', " & If(CDate(txtBirthdate.Value).ToShortDateString = CDate(Now.ToShortDateString), "", " birthdate='" & ConvertDate(txtBirthdate.Value) & "', ") & " emailadd='" & txtEmail.Text & "',entryby='" & globaluserid & "', dateentered=current_timestamp,approved=" & If(GLobalenabledirectapprovedclient = True, True, False) & " where cifid='" & id.Text & "'" : com.ExecuteNonQuery()
                MsgBox("Customer info successfully updated!", MsgBoxStyle.Information)
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            If txtCompanyName.Text = "" Then
                MessageBox.Show("Please enter companyname", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCompanyName.Focus()
                Exit Sub
            ElseIf txtAddress.Text = "" Then
                MessageBox.Show("Please enter company address", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAddress.Focus()
                Exit Sub
            ElseIf txtContactNumber.Text = "" Then
                MessageBox.Show("Please enter client contact number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtContactNumber.Focus()
                Exit Sub
            ElseIf txtClientGroup.Text = "" Then
                MessageBox.Show("Please select client group", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClientGroup.Focus()
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to continue submit client for approval? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "insert into tblclientaccounts set cifid='" & id.Text & "',groupcode='" & groupcode.Text & "', companyname='" & rchar(txtCompanyName.Text) & "', compadd='" & rchar(txtAddress.Text) & "', telephone='" & rchar(txtContactNumber.Text) & "', " & If(CDate(txtBirthdate.Value).ToShortDateString = CDate(Now.ToShortDateString), "", " birthdate='" & ConvertDate(txtBirthdate.Value) & "', ") & " emailadd='" & txtEmail.Text & "',entryby='" & globaluserid & "', dateentered=current_timestamp,approved=" & If(GLobalenabledirectapprovedclient = True, True, False) & "" : com.ExecuteNonQuery()
                If GLobalenabledirectapprovedclient = True Then
                    frmPointOfSale.LoadClient()
                    MsgBox("Client Successfully Saved!", MsgBoxStyle.Information)
                Else
                    MsgBox("Client Successfully Submitted!", MsgBoxStyle.Information)
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class