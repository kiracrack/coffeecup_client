Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSConfirmClientSpecialPrice
    Public Executed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

  
    Private Sub frmAdminCancelledConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If countqry("tblclientspecialprice", "cifid='" & frmPointOfSale.cifid.Text & "' and productid='" & productid.Text & "'") = 0 Then
            lblCLientName.Text = "Enter special price for " & StrConv(frmPointOfSale.txtClient.Text, vbProperCase)
            txtAmount.Text = "0.00"
            txtAmount.Enabled = True
            txtAmount.SelectAll()
            txtAmount.Focus()
            CheckBox1.Checked = True
        Else
            lblCLientName.Text = "Special price of " & StrConv(frmPointOfSale.txtClient.Text, vbProperCase)
            txtAmount.Text = FormatNumber(qrysingledata("amount", "amount", "tblclientspecialprice where cifid='" & frmPointOfSale.cifid.Text & "' and productid='" & productid.Text & "'"), 2)
            txtAmount.Enabled = False
            cmdConfirm.Focus()
            CheckBox1.Checked = False
        End If
    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtAmount.Text)) < 0 Then
            MsgBox("Please enter proper amount!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        End If
        If CheckBox1.Checked = True Then
            com.CommandText = "insert into tblclientspecialprice set cifid='" & frmPointOfSale.cifid.Text & "', productid='" & productid.Text & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
        End If
        Executed = True
        Me.Close()
    End Sub
End Class