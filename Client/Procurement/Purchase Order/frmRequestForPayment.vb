Imports System.IO

Public Class frmRequestForPayment
     Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
   
    Private Sub frmRequestForPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        If txtApprovingLevel.Text = "" Then
            MessageBox.Show("Please select disbursing office!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtApprovingLevel.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Me.Close()
        End If
    End Sub

End Class