Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmStockoutQuantity
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmStockoutQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtquantity.Select(0, txtquantity.Text.Length)
        ShowStockInfo()
    End Sub

    Private Sub stockid_TextChanged(sender As Object, e As EventArgs) Handles stockid.TextChanged
        ShowStockInfo()
    End Sub
    Public Sub ShowStockInfo()
        com.CommandText = "select * from tblinventory where trnid='" & stockid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            Me.Text = rst("productname").ToString
            officeid.Text = rst("officeid").ToString
            txtproduct.Text = rst("productname").ToString
            productid.Text = rst("productid").ToString
            catid.Text = rst("catid").ToString
            txtUnitCost.Text = FormatNumber(rst("purchasedprice").ToString, 3)
            txtAvailableQuantity.Text = rst("quantity").ToString
            txtquantity.Text = rst("quantity").ToString
            txtunit.Text = rst("unit").ToString
        End While
        rst.Close()
    End Sub


    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        Dim tempQry As String = ""
        If txtquantity.Text.ToString = "" Or Val(CC(txtquantity.Text)) <= 0 Then
            MessageBox.Show("Please enter valid quantity!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            MessageBox.Show("Maximum quantity is " & txtAvailableQuantity.Text & "!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        ElseIf countqry("tblstockoutitem", "refcode='" & stockid.Text & "' and trnby='" & globaluserid & "' and confirmed=0") > 0 Then
            MessageBox.Show("Item already exists on stockout transaction!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtquantity.Focus()
            Exit Sub
        End If
        While MainForm.BackgroundWorker1.IsBusy()
            Application.DoEvents()
        End While
        com.CommandText = "insert into tblstockoutitem set " _
                                + " batchcode='', " _
                                + " postingdate='" & ConvertDate(frmBatchStockout.txtDateStockout.Value) & "', " _
                                + " officeid='" & officeid.Text & "', " _
                                + " refcode='" & stockid.Text & "', " _
                                + " productid='" & productid.Text & "', " _
                                + " catid='" & catid.Text & "', " _
                                + " quantity='" & Val(CC(txtquantity.Text)) & "', " _
                                + " purchasedprice='" & Val(CC(txtUnitCost.Text)) & "', " _
                                + " unit='" & txtunit.Text & "', " _
                                + " stockouttypeid='" & frmBatchStockout.Stockouttypeid.Text & "', " _
                                + " remarks='" & rchar(txtRemarks.Text) & "', " _
                                + " trnby='" & globaluserid & "', " _
                                + " confirmed=0, " _
                                + " datetrn=current_timestamp " : com.ExecuteNonQuery()


        frmBatchStockout.FilterNew()
        Me.Close()
    End Sub

    Public Sub Calculator()
        If Val(CC(txtquantity.Text)) > Val(CC(txtAvailableQuantity.Text)) Then
            txtquantity.ForeColor = Color.White
            txtquantity.BackColor = Color.Red
        Else
            txtquantity.ForeColor = Color.Black
            txtquantity.BackColor = Color.Yellow
        End If
        txtTotal.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtquantity.Text)), 3)
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        InputNumberOnly(txtquantity, e)
    End Sub

    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged
        Calculator()
    End Sub

   
End Class