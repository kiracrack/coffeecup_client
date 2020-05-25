Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmTransferType

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdProcessing.Click
        frmTransferProcessing.Show()
        Me.Close()
    End Sub

    Private Sub cmdreset_Click(sender As Object, e As EventArgs) Handles cmdRequisition.Click
        frmTransferRequisition.Show()
        Me.Close()
    End Sub


    Private Sub frmReceivedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim StockProcessing As Integer = countqry("tbltransferbatch", " confirmed=0 and cancelled=0 and inventory_from='" & compOfficeid & "'")
        If StockProcessing > 0 Then
            cmdProcessing.Text = "Stock Transfer Processing (" & StockProcessing & ")"
            cmdProcessing.ForeColor = Color.Red
        Else
            cmdProcessing.Text = "Stock Transfer Processing"
            cmdProcessing.ForeColor = DefaultForeColor
        End If

        Dim StockRequisition As Integer = countqry("tbltransferrequest", "cleared=1 and confirmed=0 and cancelled=0 and (inventory_to='" & compOfficeid & "' or inventory_from='" & compOfficeid & "')")
        If StockRequisition > 0 Then
            cmdRequisition.Text = "Stock Transfer Requisition (" & StockRequisition & ")"
            cmdRequisition.ForeColor = Color.Red
        Else
            cmdRequisition.Text = "Stock Transfer Requisition"
            cmdRequisition.ForeColor = DefaultForeColor
        End If

    End Sub
 
End Class