Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelChangeChargeType
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCheckInTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico

    End Sub

    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If txtRoomType.Text = "" Then
            MessageBox.Show("Please select charge type!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRoomType.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmHotelCheckInTransactionV2.ChangeChargeType(txtRoomType.SelectedIndex)
            Me.Close()
        End If
    End Sub
 
End Class