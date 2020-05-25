Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmInventoryQuantitySelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquan.Select(0, txtquan.Text.Length)
        ShowProductinfo()
    End Sub

    Public Sub ShowProductinfo()
        com.CommandText = "select *,ifnull(ifnull((select procost from tblitemvendor where itemid = tblglobalproducts.productid and officeid='" & compOfficeid & "' order by lastupdate desc limit 1),(select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1)),0) as unitcost from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtProductName.Text = rst("itemname").ToString
            txtunit.Text = rst("unit").ToString
            txtUnitCost.Value = rst("unitcost").ToString
            catid.Text = rst("catid").ToString
        End While
        rst.Close()
    End Sub
    
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If CC(txtquan.Text) <= 0 Then
            MessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtquan.Focus()
            Exit Sub

        ElseIf txtUnitCost.Text = "" Then
            MessageBox.Show("Unit Cost missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnitCost.Focus()
            Exit Sub
        End If
        
        com.CommandText = "insert into tblinventorylogs set officeid='" & compOfficeid & "', catid='" & catid.Text & "', productid='" & productid.Text & "', quantity='" & Val(CC(txtquan.Value)) & "', unit='" & txtunit.Text & "', unitcost='" & Val(CC(txtUnitCost.Value)) & "', total='" & Val(CC(txttotal.Text)) & "', datepurchased=current_timestamp, vendorid='" & BeginningVendorid & "', Remarks='manual inventory', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
        frmManualInventory.loadTempParticular()
        Me.Close()
    End Sub

    Private Sub txtsti_ValueChanged(sender As Object, e As EventArgs) Handles txtUnitCost.ValueChanged
        calctotal()
        Me.AcceptButton = cmdset
    End Sub
    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = CC(txtquan.Text)
        stm = CC(txtUnitCost.Text)
        ttl = Val(quan) * Val(stm)

        txttotal.Text = Format(ttl, "n")
    End Sub

    Private Sub txtquan_ValueChanged(sender As Object, e As EventArgs) Handles txtquan.ValueChanged
        calctotal()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

End Class