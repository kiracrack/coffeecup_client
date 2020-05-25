Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmPOSCustomProductEnterQuantity
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtQuantity.Select(0, txtQuantity.Text.Length)
        ShowProductInfo()
        If mode.Text = "edit" Then
            ShowAddonItemInfo()
        End If
    End Sub
    Public Sub ShowAddonItemInfo()
        com.CommandText = "select * from tblsalesproductcustomorder where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            postrn.Text = rst("postrn").ToString
            txtQuantity.Text = rst("quantity").ToString
            txtUnit.Text = rst("unit").ToString
            txtUnitCost.Text = FormatNumber(rst("unitprice").ToString, 2)
            officeid.Text = rst("officeid").ToString
        End While
        rst.Close()
    End Sub

    Public Sub ShowProductInfo()
        com.CommandText = "select * from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtProductName.Text = rst("itemname").ToString
            txtUnit.Text = rst("unit").ToString
            txtUnitCost.Text = FormatNumber(rst("sellingprice").ToString, 2)
            officeid.Text = rst("officecenter").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If CC(txtQuantity.Text) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub
        End If
        'If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblsalesproductcustomorder set postrn='" & postrn.Text & "',trnsumcode='" & globalSalesTrnCOde & "', batchcode='" & txtBatchcode.Text & "', productid='" & productid.Text & "',productname='" & rchar(txtProductName.Text) & "', quantity='" & Val(CC(txtQuantity.Text)) & "', unit='" & txtUnit.Text & "', unitprice='" & Val(CC(txtUnitCost.Text)) & "', officeid='" & officeid.Text & "', trnby='" & globaluserid & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblsalesproductcustomorder set postrn='" & postrn.Text & "',trnsumcode='" & globalSalesTrnCOde & "', batchcode='" & txtBatchcode.Text & "', productid='" & productid.Text & "',productname='" & rchar(txtProductName.Text) & "', quantity='" & Val(CC(txtQuantity.Text)) & "', unit='" & txtUnit.Text & "', unitprice='" & Val(CC(txtUnitCost.Text)) & "', officeid='" & officeid.Text & "', trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        End If
        frmPointOfSale.ValidatePOSTransaction(txtBatchcode.Text)
        frmPOSCustomOrderItemized.ShowItemList()
        Me.Close()
        'End If
    End Sub

    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = Val(CC(txtQuantity.Text))
        stm = Val(CC(txtUnitCost.Text))
        ttl = Val(quan) * Val(stm)
        txtTotalCost.Text = Format(ttl, "n")
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtquan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdset.PerformClick()
        Else
            InputNumberOnly(txtQuantity, e)
        End If
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

    Private Sub txtquan_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        calctotal()
    End Sub

    Private Sub txtsti_LostFocus(sender As Object, e As EventArgs) Handles txtUnitCost.LostFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtsti_TextChanged(sender As Object, e As EventArgs) Handles txtUnitCost.TextChanged
        calctotal()
    End Sub
 
End Class