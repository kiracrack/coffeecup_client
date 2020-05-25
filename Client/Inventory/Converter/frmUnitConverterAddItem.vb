Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmUnitConverterAddItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        loadProductSales()
    End Sub
    Public Sub loadProductSales()
        If GlobalenableProductFilter = True Then
            LoadToComboBoxDB("select productid, itemname from tblglobalproducts where catid in (select catid from tblprocategory where consumable=1) and catid in (select categorycode from tblproductfilter where permissioncode='" & globalAuthcode & "')  order by itemname asc", "itemname", "productid", txtProduct)
        Else
            LoadToComboBoxDB("select productid,itemname from tblglobalproducts where catid in (select catid from tblprocategory where consumable=1) order by itemname asc", "itemname", "productid", txtProduct)
        End If
    End Sub
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If Val(CC(txtquan.Text)) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub
        End If
        If countqry("tblunitconverter", "convcode='" & id.Text & "'") = 0 Then
            frmUnitConverterInfo.AddnewItemFromSource(productid.Text, txtProduct.Text, Val(CC(txtquan.Text)))
        Else
            com.CommandText = "delete from tblunitconverterdetails where convcode='" & id.Text & "' and productid='" & productid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tblunitconverterdetails set convcode='" & id.Text & "', productid='" & productid.Text & "',   quantity=" & Val(CC(txtquan.Text)) & "" : com.ExecuteNonQuery()
            frmUnitConverterInfo.FilterDetails(id.Text)
        End If
        Me.Close()
    End Sub
 
    Private Sub txtProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProduct.SelectedIndexChanged
        productid.Text = DirectCast(txtProduct.SelectedItem, ComboBoxItem).HiddenValue()
        txtunit.Text = qrysingledata("unit", "unit", "tblglobalproducts where productid='" & productid.Text & "'")
    End Sub
End Class