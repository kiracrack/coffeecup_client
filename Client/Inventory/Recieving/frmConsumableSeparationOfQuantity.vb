Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmConsumableSeparationOfQuantity

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmSeparationOfQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Public Sub computeTotal()
        txtTotalCost.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtNewQuantity.Text)))
    End Sub
  
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "INSERT INTO `tblpurchaseorderitem` (requestref,ponumber,officeid,vendorid,productid,itemname,catid,quantity,unit,cost,total,remarks,allocatedrefcode,trnby,datetrn,delivered,datedelivered) " _
                               + " SELECT requestref,ponumber,officeid,vendorid,productid,itemname,catid," & Val(CC(txtNewQuantity.Text)) & ",unit," & Val(CC(txtUnitCost.Text)) & "," & Val(CC(txtTotalCost.Text)) & ",'partial received',allocatedrefcode,trnby,current_timestamp,delivered,datedelivered FROM `tblpurchaseorderitem` where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblpurchaseorderitem set quantity=quantity-" & Val(txtNewQuantity.Text) & ",total=cost*" & Val(CC(txtQuantity.Text)) - Val(CC(txtNewQuantity.Text)) & " where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            frmReceivedConsumable.DivisionOFItem(productid.Text, txtQuantity.Text, Val(CC(txtNewQuantity.Text)))
            MessageBox.Show("Consumable item successfully devided!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtUnitCost_TextChanged(sender As Object, e As EventArgs) Handles txtUnitCost.TextChanged
        computeTotal()
    End Sub

    Private Sub txtNewQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtNewQuantity.TextChanged
        computeTotal()
    End Sub
End Class