Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmChangeMultipleSupplier
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestChangeAmount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadVendor()
    End Sub
  
    Public Sub loadVendor()
        LoadToComboBoxDB("select * from tblglobalvendor order by companyname asc", "companyname", "vendorid", txtvendor)
    End Sub
    Private Sub txtvendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvendor.SelectedIndexChanged
        If txtvendor.Text <> "" Then
            vendorid.Text = DirectCast(txtvendor.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            vendorid.Text = ""
        End If
    End Sub
 
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If txtvendor.Text = "" Then
            MessageBox.Show("Please select supplier!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtvendor.Focus()
            Exit Sub
        End If
        If frmForApproval_RequisitionsBranch.Visible = True Then
            frmForApproval_RequisitionsBranch.ChangeSupplier(vendorid.Text)
        End If
        If frmForApproval_RequisitionsCorporate.Visible = True Then
            frmForApproval_RequisitionsCorporate.ChangeSupplier(vendorid.Text)
        End If
       
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class