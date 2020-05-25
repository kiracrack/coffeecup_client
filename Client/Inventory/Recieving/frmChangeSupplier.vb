Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmChangeSupplier
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChangeSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        com.CommandText = "select ifnull((select companyname from tblglobalvendor where vendorid=tblpurchaseorder.vendorid ),'DELETED SUPPLIER') as supplier from tblpurchaseorder where ponumber='" & ponumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtSupplier.Text = rst("supplier").ToString
        End While
        rst.Close()
        loadVendor
    End Sub
    Public Sub loadVendor()
        LoadToComboBoxDB("select * from tblglobalvendor order by companyname asc", "companyname", "vendorid", txtvendor)
    End Sub
 
    Private Sub txtvendor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtvendor.SelectedValueChanged
        If txtvendor.Text <> "" Then
            vendorid.Text = DirectCast(txtvendor.SelectedItem, ComboBoxItem).HiddenValue()
        Else
            vendorid.Text = ""
        End If
    End Sub
    
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblpurchaseorder set vendorid='" & vendorid.Text & "' where ponumber='" & ponumber.Text & "'" : com.ExecuteNonQuery()
            frmReceivedConsumable.LoadPoDetails()
            RecordApprovingHistory("purchase order", ponumber.Text, ponumber.Text, "processed", "change supplier from " & txtSupplier.Text & " to " & txtvendor.Text)
            MessageBox.Show("Supplier successfully change!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class