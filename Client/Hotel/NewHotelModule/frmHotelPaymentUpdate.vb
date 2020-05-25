Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelPaymentUpdate
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelPaymentPosting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmHotelPaymentPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPaymentInfo()
    End Sub

    Public Sub ShowPaymentInfo()
        com.CommandText = "select * from tblhotelfoliotransaction where trnid='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono.Text = rst("foliono").ToString
            txtORNumber.Text = rst("referenceno").ToString
            txtAmountTender.Text = FormatNumber(Val(rst("credit").ToString), 2)
            txtRemarks.Text = rst("remarks").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Edited payment details with remarks """ & txtRemarks.Text & """ for OR reference number " & txtORNumber.Text & " with amount of " & txtAmountTender.Text)
            com.CommandText = "Update tblhotelfoliotransaction set remarks='" & rchar(txtRemarks.Text) & "' where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            If frmHotelCheckInTransactionV2.Visible = True Then
                frmHotelCheckInTransactionV2.FilterPaymentDeposit()
            End If
            MessageBox.Show("Payment details successfully updated", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
    
End Class