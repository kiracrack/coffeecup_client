Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmCreateTransferFFE
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmReceivedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select officeid, officename from tblcompoffice where officeid <> '" & officeid_from.Text & "';", "officename", "officeid", txtOfficeName)
    End Sub

    Private Sub txtOfficeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtOfficeName.SelectedValueChanged
        If txtOfficeName.Text = "" Then Exit Sub
        officeid_to.Text = DirectCast(txtOfficeName.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Private Sub txtFFECode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFFECode.KeyPress
        If e.KeyChar() = Chr(13) Then
            FFEDetails()
        End If
    End Sub
    Public Sub FFEDetails()
        If countqry("tblinventoryffe", "ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'") > 0 Then
            com.CommandText = "select *,(select description from tblinventoryffetype where code = tblinventoryffe.ffetype) as 'ffetypedescription' from tblinventoryffe where ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                txtProductName.Text = rst("productname").ToString
                txtFFEType.Text = rst("ffetypedescription").ToString
            End While
            rst.Close()
        Else
            MessageBox.Show("FFE unit not found!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOfficeName.Text = ""
            txtFFEType.Text = ""
            txtFFECode.Text = ""
            txtFFECode.Focus()
        End If
    End Sub
 
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If countqry("tblinventoryffe", "ffecode='" & txtFFECode.Text & "' and officeid='" & officeid_from.Text & "'") = 0 Then
            MessageBox.Show("FFE unit not found!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtOfficeName.Text = "" Then
            MessageBox.Show("Please select office!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtMessage.Text = "" Then
            MessageBox.Show("Please enter message!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblinventoryffetransfer set ffecode='" & txtFFECode.Text & "', productname='" & rchar(txtProductName.Text) & "', producttype='" & rchar(txtFFEType.Text) & "', officeid_from='" & officeid_from.Text & "', officeid_to='" & officeid_to.Text & "', message='" & rchar(txtMessage.Text) & "', daterequest=current_timestamp,requestby='" & globalfullname & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblinventoryffe set flaged=1, lockedediting=1, flagedreason='IN TRANSIT TO " & UCase(rchar(txtOfficeName.Text)) & "' where ffecode='" & txtFFECode.Text & "'" : com.ExecuteNonQuery()
            LogFFEHistory(txtFFECode.Text, "in transit to " & LCase(txtOfficeName.Text) & " - " & rchar(txtMessage.Text))
            txtOfficeName.Text = "" : txtFFEType.Text = "" : txtFFECode.Text = "" : txtProductName.Text = "" : txtMessage.Text = "" : txtFFECode.ReadOnly = False : txtFFECode.Focus()
            MessageBox.Show("FFE successfully on requested!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
     
End Class