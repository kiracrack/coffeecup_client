Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEmailPreviewNotification

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelGuestPreviousTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If txtEmail.Text.Length < 5 Then
            cmdSendEmail.Enabled = False
            cmdSendEmail.ToolTipText = "Unable to send folio notification! No registered email for this guest."
        Else
            cmdSendEmail.Enabled = True
        End If
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        If MessageBox.Show("Do you want to send folio email booking confirmation to " & txtEmail.Text & "? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Send email folio notification to guest at " & txtEmail.Text)
            InsertEmailNotificationClient("FOLIO", txtEmail.Text, "Booking Confirmation", GenerateGuestEmailNotification(foliono.Text, False))
            com.CommandText = "UPDATE tblhotelfolioguest set notified=1 where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            MessageBox.Show("Folio notification Successfully sent", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
