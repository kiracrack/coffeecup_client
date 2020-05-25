Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelBillPrintOption
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelBillPrintOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), txtFoliono.Text, "Print modified guest statement of account (SOA) with total room charges " & txtRoomCharges.Text & ", total POS charges " & txtPosCharges.Text & " with total charges " & txtTotalCharges.Text & ". And for the total payment " & txtPayment.Text & " and balance due of " & txtBalanceDue.Text)
        GenerateGuestFolioStatementModified(txtFoliono.Text, Val(CC(txtRoomCharges.Text)), Val(CC(txtTotalCharges.Text)), Val(CC(txtPosCharges.Text)), Val(CC(txtPayment.Text)), Val(CC(txtBalanceDue.Text)), Me)
    End Sub

    Private Sub txtRoomCharges_TextChanged(sender As Object, e As EventArgs) Handles txtRoomCharges.TextChanged
        Calculator()
    End Sub
    Public Sub Calculator()
        txtTotalCharges.Text = FormatNumber(Val(CC(txtRoomCharges.Text)) + Val(CC(txtPosCharges.Text)), 2)
        txtBalanceDue.Text = FormatNumber(Val(CC(txtTotalCharges.Text)) - (Val(CC(txtPayment.Text)) + Val(CC(txtDiscount.Text))), 2)
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged
        Calculator()
    End Sub

    Private Sub txtPosCharges_TextChanged(sender As Object, e As EventArgs) Handles txtPosCharges.TextChanged
        Calculator()
    End Sub
End Class