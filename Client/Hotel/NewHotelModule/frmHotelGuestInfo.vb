Imports System.Runtime.InteropServices, System.IO, DShowNET, DShowNET.Device, System.Drawing, System.Drawing.Imaging, System.Collections, System.ComponentModel, System.Diagnostics
Imports System.Data, DirectShowLib
Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelGuestInfo

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelGuestInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select * from tblcountries order by countryname asc", "countryname", "countrycode", txtCountry)
        loadNationality()

        If mode.Text = "edit" Then
            showGuestInfo()
        End If
    End Sub

    Private Sub txtCountry_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCountry.SelectedValueChanged
        If txtCountry.Text <> "" Then
            countrycode.Text = DirectCast(txtCountry.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            countrycode.Text = ""
        End If
    End Sub

    Public Sub loadNationality()
        LoadToComboBoxDB("select nationality from tblguestnationality order by nationality", "nationality", "nationality", txtNationality)
    End Sub


    Public Sub showGuestInfo()
        com.CommandText = "select *,(select picture from "  & sqlfiledir & ".tblhotelguestimage where guestid=tblhotelguest.guestid) as pic,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country,(select description from tblhotelviptype where vipcode=tblhotelguest.viptype) as 'vip' from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtGuest.Text = rst("fullname").ToString
            countrycode.Text = rst("countrycode").ToString
            txtCountry.Text = rst("country").ToString
            txtAddress.Text = rst("address").ToString
            If rst("birthdate").ToString <> "" Then
                CheckBox1.Checked = True
                txtBirthdate.Value = rst("birthdate").ToString
            Else
                CheckBox1.Checked = False
            End If
            txtGender.Text = rst("gender").ToString
            txtNationality.Text = rst("nationality").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmail.Text = rst("emailadd").ToString
            txtGuestPreferences.Text = rst("guestpreferences").ToString
            'If rst("pic").ToString <> "" Then
            '    CloseInterfaces(True)
            '    ProfilePic.Visible = True
            '    cmdChangePicture.Visible = True
            '    ShowImage("pic", ProfilePic)
            'Else
            '    ActivateCamera()
            '    StartInterface()
            '    ProfilePic.Visible = False
            '    cmdChangePicture.Visible = False
            'End If

        End While
        rst.Close()

    End Sub

    Private Sub guestid_TextChanged(sender As Object, e As EventArgs) Handles guestid.TextChanged
        showGuestInfo()
    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtGuest.Text = "" Then
            MessageBox.Show("Please enter guest Fullname", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGuest.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("Please enter guest address", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub
        ElseIf txtGender.Text = "" Then
            MessageBox.Show("Please enter guest gender", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAddress.Focus()
            Exit Sub
        ElseIf txtContactNumber.Text = "" Then
            MessageBox.Show("Please enter guest contact number", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        ElseIf txtEmail.Text = "" Or txtEmail.Text.Contains("@") = False Or txtEmail.Text.Contains(".") = False Then
            MessageBox.Show("Please enter valid guest email address", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmail.Focus()
            Exit Sub
        ElseIf countqry("tblhotelguest", "fullname like '%" & RemoveWhiteSpaces(txtGuest.Text, True) & "%' and guestid<>'" & guestid.Text & "'") > 0 Then
            MessageBox.Show("Guest name allready exists", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGender.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Edit guest information")
            com.CommandText = "UPDATE tblhotelguest set fullname='" & rchar(UCase(txtGuest.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', " & If(CheckBox1.Checked = True, "birthdate='" & ConvertDate(txtBirthdate.Text) & "',", "") & " gender='" & UCase(txtGender.Text) & "',countrycode='" & countrycode.Text & "', nationality='" & UCase(rchar(txtNationality.Text)) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "',guestpreferences='" & rchar(txtGuestPreferences.Text) & "'  where guestid='" & guestid.Text & "'" : com.ExecuteNonQuery()
        Else
            Dim newGuestid As String = CreateGuestID()
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Added new guest information named " & txtGuest.Text)
            com.CommandText = "insert into tblhotelguest set guestid='" & newGuestid & "', fullname='" & rchar(UCase(txtGuest.Text)) & "', address='" & rchar(UCase(txtAddress.Text)) & "', " & If(CheckBox1.Checked = True, "birthdate='" & ConvertDate(txtBirthdate.Text) & "',", "") & " gender='" & UCase(txtGender.Text) & "',countrycode='" & countrycode.Text & "', nationality='" & UCase(rchar(txtNationality.Text)) & "', contactnumber='" & rchar(txtContactNumber.Text) & "', emailadd='" & rchar(txtEmail.Text) & "',guestpreferences='" & rchar(txtGuestPreferences.Text) & "', datetrn=current_timestamp, trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        End If
        frmHotelPickGuest.txtsearch.Text = txtGuest.Text
        frmHotelPickGuest.ShowGuestList()
        MessageBox.Show("Guest info successfuly saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub txtContactNumber_GotFocus(sender As Object, e As EventArgs) Handles txtContactNumber.GotFocus
        Me.AcceptButton = cmdProceed
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtBirthdate.Enabled = True
        Else
            txtBirthdate.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmHotelGuestNationality.ShowDialog(Me)
        loadNationality()
    End Sub
End Class