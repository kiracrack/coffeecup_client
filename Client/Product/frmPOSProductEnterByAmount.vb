Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSProductEnterByAmount
    Public Executed As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmAdminCancelledConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        'txtRemarks.Text = ""
        If CheckBox1.Checked = True Then
            GroupBox1.Text = "Enter proceed discount amount start with negative"
            txtAmount.Text = "0"
        Else
            GroupBox1.Text = "Enter proceed transaction amount"
        End If
    End Sub
    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If Val(CC(txtAmount.Text)) = 0 Then
            MsgBox("Please enter proper amount!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        ElseIf Val(CC(txtAmount.Text)) >= 0 And CheckBox1.Checked = True Then
            MsgBox("Please enter valid discount amount start with negative sign!", MsgBoxStyle.Exclamation, "Invalid Amount")
            Exit Sub
        End If
        Executed = True
        Me.Close()
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar() = Chr(13) Then
            If Val(CC(txtAmount.Text)) >= 0 And CheckBox1.Checked = True Then
                MsgBox("Please enter valid discount amount start with negative sign!", MsgBoxStyle.Exclamation, "Invalid Amount")
                Exit Sub
            End If
            txtRemarks.Focus()
        End If
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
End Class