Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmRequestChangeAmount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestChangeAmount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadVendor()
        loadInfo()
    End Sub
    Public Sub LoadInfo()
        com.CommandText = "select *,(select ITEMNAME from tblglobalproducts where PRODUCTID = tblrequisitionsitem.PRODUCTID ) as product,(select COMPANYNAME from tblglobalvendor where vendorid = tblrequisitionsitem.vendorid ) as vendor from tblrequisitionsitem where trnid='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtProductName.Text = rst("product").ToString
            txtunit.Text = rst("unit").ToString
            txtQuantity.Text = rst("quantity").ToString
            txtUnitCost.Text = FormatNumber(rst("cost").ToString, 2)
            txtvendor.Text = rst("vendor").ToString
            vendorid.Text = rst("vendorid").ToString
            txtdetails.Text = rst("remarks").ToString
        End While
        rst.Close()
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

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub


    Private Sub txtsti_GotFocus(sender As Object, e As EventArgs) Handles txtUnitCost.GotFocus
        Me.AcceptButton = cmdset
    End Sub

    Private Sub txtsti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitCost.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdset.PerformClick()
        Else
            InputNumberOnly(txtUnitCost, e)
        End If
    End Sub


    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(13) Then
            txtUnitCost.Focus()
        Else
            InputNumberOnly(txtQuantity, e)
        End If
    End Sub

    Private Sub txtsti_LostFocus(sender As Object, e As EventArgs) Handles txtUnitCost.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        com.CommandText = "update tblrequisitionsitem set quantity=" & Val(CC(txtQuantity.Text)) & ",cost='" & Val(CC(txtUnitCost.Text)) & "',total=(" & Val(CC(txtUnitCost.Text)) * Val(CC(txtQuantity.Text)) & "), remarks='" & rchar(txtdetails.Text) & "', vendorid='" & vendorid.Text & "' where trnid='" & id.Text & "'" : com.ExecuteNonQuery()
        If frmForApproval_RequisitionsBranch.Visible = True Then
            frmForApproval_RequisitionsBranch.ShowParticularsItems()
        End If
        If frmForApproval_RequisitionsCorporate.Visible = True Then
            frmForApproval_RequisitionsCorporate.ShowParticularsItems()
        End If
        Me.Close()
    End Sub
 
End Class