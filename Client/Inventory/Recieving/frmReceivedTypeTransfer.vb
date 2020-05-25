Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmReceivedTypeTransfer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmReceivedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim transfer As Integer = countqry("tbltransferbatch", "confirmed=0 and cancelled=0 and inventory_to='" & compOfficeid & "'")
        If transfer > 0 Then
            cmdTransfer.Text = "Consumable Incoming (" & transfer & ")"
            cmdTransfer.ForeColor = Color.Red
        Else
            cmdTransfer.Text = "Consumable Transfer Report"
            cmdTransfer.ForeColor = DefaultForeColor
        End If

        Dim FFeIncoming As Integer = countqry("tblinventoryffetransfer", "received=0 and cancelled=0 and officeid_to='" & compOfficeid & "'")
        If FFeIncoming > 0 Then
            cmdFFETransfer.Text = "Fixed Asset Incoming (" & FFeIncoming & ")"
            cmdFFETransfer.ForeColor = Color.Red
        Else
            cmdFFETransfer.Text = "Fixed Asset Transfer Report"
            cmdFFETransfer.ForeColor = DefaultForeColor
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        If compInventoryMethod = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        frmRecievedTransferConsumable.Show()
        Me.Close()
    End Sub

    Private Sub cmdFFETransfer_Click(sender As Object, e As EventArgs) Handles cmdFFETransfer.Click
        frmReceivedTransferFFE.Show()
        Me.Close()
    End Sub
End Class