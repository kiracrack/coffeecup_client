Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSProductEnterByAmountwithUnit
    Public Executed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAdminCancelledConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ' txtAmount.Text = "0.00"
        If CheckBox1.Checked = True Then
            GroupBox1.Text = "Enter proceed discount amount start with negative"
        Else
            GroupBox1.Text = "Enter proceed transaction amount"
        End If
    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtAmount.Text)) = 0 Then
            MsgBox("Please enter proper amount!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        ElseIf txtUnit.Text = "" Then
            MsgBox("Please enter unit!", MsgBoxStyle.Exclamation, "Invalid")
            txtUnit.Focus()
            txtUnit.DroppedDown = True
            Exit Sub
        End If
        Executed = True
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If CheckBox1.Checked = False Then
            InputNumberOnly(txtAmount, e)
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If Val(CC(txtAmount.Text)) = 0 Then
            txtAmount.BackColor = Color.Red
            txtAmount.ForeColor = Color.White
        Else
            txtAmount.BackColor = DefaultBackColor
            txtAmount.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub txtUnit_GotFocus(sender As Object, e As EventArgs) Handles txtUnit.GotFocus
        txtUnit.DroppedDown = True
    End Sub
  
End Class