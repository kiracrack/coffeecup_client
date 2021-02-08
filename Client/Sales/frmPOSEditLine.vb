Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSEditLine
    Public ConfirmedEdit As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, txtAmount.TextChanged, txtSellPrice.TextChanged
        ComputeTransaction()
    End Sub
 
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtQuantity, e)
        End If
    End Sub
    Private Sub txtSellPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSellPrice.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtSellPrice, e)
        End If
    End Sub
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdConfirm.PerformClick()
        Else
            InputNumberOnly(txtAmount, e)
        End If
    End Sub
    Private Sub frmPOSEditLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "EA" Then
            txtAmount.Focus()
        Else
            txtQuantity.Focus()
        End If
        Dim allowinputdiscountedamount = CBool(qrysingledata("allowinputdiscountedamount", "allowinputdiscountedamount", "tblglobalproducts where productid='" & rchar(txtBarCode.Text) & "'"))
        If allowinputdiscountedamount = True Then
            txtSellPrice.ReadOnly = False
        Else
            txtSellPrice.ReadOnly = True
        End If
    End Sub
    Public Sub ComputeTransaction()
        If txtQuantity.Text = "" Or txtSellPrice.Text = "" Then Exit Sub
            Dim selp As Double = txtSellPrice.Text : Dim quantity As Double = txtQuantity.Text
            txtAmount.Text = FormatNumber(selp * quantity, 2)
    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If MessageBox.Show("Are you sure you want to continue update current item? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If frmPointOfSale.TrapTransaction(txtBarCode.Text) = True Then
                '#returned the original quantity to inventory
                RollBackInventory()
                If compEnableInventory = True Then
                    frmPointOfSale.ckNonInventoryItem.Checked = True
                Else
                    frmPointOfSale.ckNonInventoryItem.Checked = CBool(qrysingledata("forcontract", "forcontract", "tblglobalproducts where productid='" & txtBarCode.Text & "'"))
                End If
                frmPointOfSale.PostSalesTransaction(False, txtBarCode.Text, txtQuantity.Text, Val(CC(txtSellPrice.Text)), 0, ", remarks='" & rchar(txtRemarks.Text) & "'")
                frmPointOfSale.txtBarCode.Focus()
                Me.Close()
            End If
        End If
    End Sub
     
    Public Sub RollBackInventory()
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblsalestransaction where productid='" & rchar(txtBarCode.Text) & "'  and batchcode='" & txtBatchCode.Text & "' and inventory=1", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                StockinInventory("POS Quantity Changed", .Rows(cnt)("inventorytrnid").ToString(), compOfficeid, .Rows(cnt)("productid").ToString(), .Rows(cnt)("quantity").ToString(), .Rows(cnt)("purchasedprice").ToString(), "rollback quantity batchcode #" + txtBatchCode.Text, "", txtBatchCode.Text, "")
            End With
        Next
        com.CommandText = "update tblsalescoupon set cancelled=1, cancelledby='CS',datecancelled=current_timestamp where batchcode='" & txtBatchCode.Text & "'" : com.ExecuteNonQuery()
        com.CommandText = "DELETE from tblsalestransaction where productid='" & rchar(txtBarCode.Text) & "'  and batchcode='" & txtBatchCode.Text & "'" : com.ExecuteNonQuery()
    End Sub
       
    
     
End Class