Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSProductEnterByChitAmount
    Public Executed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAdminCancelledConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtAmount.Text)) = 0 Then
            MsgBox("Please enter proper amount!", MsgBoxStyle.Exclamation, "Invalid Amount")
            txtAmount.Focus()
            Exit Sub
        ElseIf Val(CC(txtChitAmount.Text)) > 0 And Val(CC(txtChitAmount.Text)) <= Val(CC(txtAmount.Text)) Then
            MsgBox("SOP amount must be greater than original amount!", MsgBoxStyle.Exclamation, "Invalid Amount")
            txtChitAmount.Focus()
            Exit Sub
        End If
        Executed = True
        Me.Close()
    End Sub

    Private Sub txtAmount_GotFocus(sender As Object, e As EventArgs) Handles txtAmount.GotFocus
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            txtChitAmount.Focus()
        Else
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

    Private Sub txtChitAmount_GotFocus(sender As Object, e As EventArgs) Handles txtChitAmount.GotFocus
        Me.AcceptButton = cmdConfirm
    End Sub

    Private Sub txtChitAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChitAmount.KeyPress
       InputNumberOnly(txtChitAmount, e)
    End Sub
 
End Class