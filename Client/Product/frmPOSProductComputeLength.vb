Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSProductComputeLength
    Public Executed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSProductComputeLength_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        'txtRemarks.Text = ""

    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtHeight.Text)) = 0 Then
            MsgBox("Please enter height!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        ElseIf Val(CC(txtQuantity.Text)) = 0 Then
            MsgBox("Please enter width!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) = 0 Then
            MsgBox("Please enter unit price!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        End If
        Executed = True
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRemarks.Focus()
        Else
            InputNumberOnly(txtAmount, e)
        End If
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        ComputeLength()
        If Val(CC(txtAmount.Text)) = 0 Then
            txtAmount.BackColor = Color.Red
            txtAmount.ForeColor = Color.White
        Else
            txtAmount.BackColor = Color.White
            txtAmount.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub txtRemarks_GotFocus(sender As Object, e As EventArgs) Handles txtRemarks.GotFocus
        Me.AcceptButton = cmdConfirm
        If txtRemarks.Text = "Add remarks.." Then
            txtRemarks.Text = ""
        End If
    End Sub

    Private Sub txtRemarks_LostFocus(sender As Object, e As EventArgs) Handles txtRemarks.LostFocus
        If txtRemarks.Text = "" Then
            txtRemarks.Text = "Add remarks.."
        End If
        Me.AcceptButton = Nothing
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        ComputeLength()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ComputeLength()
    End Sub

    Public Sub ComputeLength()
        txtTotal.Text = FormatNumber(Val(txtHeight.Text) * Val(txtQuantity.Text) * Val(txtAmount.Text))
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtQuantity.Focus()
        Else
            InputNumberOnly(txtHeight, e)
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAmount.Focus()
        Else
            InputNumberOnly(txtQuantity, e)
        End If
    End Sub

End Class