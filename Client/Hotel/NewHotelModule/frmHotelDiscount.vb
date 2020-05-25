Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelDiscount
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "edit" Then
            com.CommandText = "select * from tblhotelfoliotransaction where trnid='" & trnid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                foliono.Text = rst("foliono").ToString
                folioid.Text = rst("folioid").ToString
                txtRoomNo.Text = rst("roomno").ToString
                txtDiscount.Text = FormatNumber(rst("credit"), 2)
                txtRemarks.Text = rst("remarks").ToString
            End While
            rst.Close()
        End If
    End Sub
  
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If Val(CC(txtDiscount.Text)) <= 0 Then
            MessageBox.Show("Please enter proper discount amount", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDiscount.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter discount remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim cmdQuery As String = ""
            com.CommandText = "select * from tblhotelfolioroom where folioid='" & folioid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                cmdQuery += " tblhotelfoliotransaction set folioid='" & folioid.Text & "', foliono='" & rst("foliono").ToString & "', guestid='" & rst("guestid").ToString & "',roomid='" & rst("roomid").ToString & "',roomno='" & rst("roomno").ToString & "', trnsumcode='', officeid='" & compOfficeid & "', remarks='" & rchar(txtRemarks.Text) & "', credit='" & Val(CC(txtDiscount.Text)) & "',paymenttrn=0,discount=1,datetrn=current_timestamp,trnby='" & globaluserid & "'"
            End While
            rst.Close()

            Dim discountOveride As String = ""
            If MessageBox.Show("Posting discount requires an administrative approval! " & Environment.NewLine & Environment.NewLine & "If you want to overide current discount click YES to enter autorized account or NO to submit it as for approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                frmPOSAdminConfirmation.ShowDialog(Me)
                If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                    discountOveride = ",discountoveride=1,discountoverideby='" & frmPOSAdminConfirmation.userid.Text & "' "
                    frmPOSAdminConfirmation.ApprovedConfirmation = False
                    frmPOSAdminConfirmation.Dispose()
                End If
            End If

            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Post discount for room " & GetRoomFolioInfo(folioid.Text, "roomno") & " amount " & txtDiscount.Text & ", discount overide by " & GetUserinfo(frmPOSAdminConfirmation.userid.Text, "fullname"))
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblhotelfoliotransaction set remarks='" & rchar(txtRemarks.Text) & "', credit='" & Val(CC(txtDiscount.Text)) & "' " & discountOveride & " where trnid='" & trnid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "INSERT INTO " & cmdQuery & discountOveride : com.ExecuteNonQuery()
            End If

            If frmHotelCheckInTransactionV2.Visible = True Then
                frmHotelCheckInTransactionV2.LoadFolioInfo()
            End If
            MessageBox.Show("Discount Successfully posted", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class