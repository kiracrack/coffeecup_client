Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelCloseFolio
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCloseFolio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
     
    Private Sub frmHotelCloseFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToComboBoxDB("select * from tblhotelguestratings ", "ratingsname", "code", txtRatings)

        Dim ratings As String = ""
        com.CommandText = "SELECT *,(select ratingsname from tblhotelguestratings where code=tblhotelguest.ratings) as ratingsname, " _
            + " (select yearlyvalidity from tblhotelguestratings where code=tblhotelguest.ratings) as yearlyvalidity, " _
            + " (select monthvalidity from tblhotelguestratings where code=tblhotelguest.ratings) as monthvalidity FROM `tblhotelguest` where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader()
        While rst.Read
            If rst("ratingsvalidity").ToString.Length > 0 Then
                ratings = rst("ratingsname").ToString
                ratingsid.Text = rst("ratings").ToString
                txtCurrentValidity.Text = CDate(rst("ratingsvalidity").ToString).ToString("MMMM dd, yyyy")
                txtValidity.Text = CDate(rst("ratingsvalidity").ToString).ToString("MMMM dd, yyyy")
                ckSetLEvel.Checked = True
                ckyearly.Checked = CBool(rst("yearlyvalidity"))
            End If
        End While
        rst.Close()

        Dim TotalPOSCharges As Double = qrysingledata("amount", "ifnull(sum(debit),0) as amount ", "tblhotelfoliotransaction where foliono='" & txtFoliono.Text & "' and chargefrompos=1 and cancelled=0")
        Dim TotalPOSCash As Double = qrysingledata("amount", "ifnull(sum(amount),0) as amount ", "tblhotelcashtransaction where foliono='" & txtFoliono.Text & "'")

        If ratingsid.Text.Length > 0 Then
            If ckyearly.Checked = True Then
                com.CommandText = "SELECT ifnull(sum(total),0) as Total  FROM `tblhotelfolioroomsummary` where foliono in (select foliono from tblhotelfolioguest where guestid='" & guestid.Text & "' and date_format(arival,'%Y-%m-%d') between '" & ConvertDate(txtCurrentValidity.Text) & "' and '" & ConvertDate(CDate(txtCurrentValidity.Text).AddYears(1)) & "' and cancelled=0)  and cancelled=0" : rst = com.ExecuteReader()
                lblYearly.Text = "Covered Year Total"
            Else
                com.CommandText = "SELECT ifnull(sum(total),0) as Total  FROM `tblhotelfolioroomsummary` where foliono in (select foliono from tblhotelfolioguest where guestid='" & guestid.Text & "' and date_format(arival,'%Y')=date_format(current_timestamp,'%Y') and cancelled=0)  and cancelled=0" : rst = com.ExecuteReader()
                lblYearly.Text = "Whole Year Total"
            End If
            While rst.Read
                txtYearTotal.Text = FormatNumber(Val(rst("Total")) + TotalPOSCharges + TotalPOSCash, 2)
            End While
            rst.Close()
        Else
            lblYearly.Text = "Current Transaction"
            txtYearTotal.Text = txtTotalTransaction.Text
        End If
      
        txtRatings.Text = ratings
    End Sub

    Private Sub txtRatings_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRatings.SelectedValueChanged
        If txtRatings.Text <> "" Then
            ratingsid.Text = DirectCast(txtRatings.SelectedItem, ComboBoxItem).HiddenValue()

            com.CommandText = "select *, date_format(current_timestamp,'%Y') as currentyear from tblhotelguestratings where code='" & ratingsid.Text & "'" : rst = com.ExecuteReader
            While rst.Read
                If CBool(rst("yearlyvalidity")) = True Then
                    If txtCurrentValidity.Text = "" Then
                        txtValidity.Text = CDate(Now).AddMonths(12).ToString("MMMM dd, yyyy")
                    End If
                Else
                    txtValidity.Text = CDate(Now).AddMonths(rst("monthvalidity").ToString).ToString("MMMM dd, yyyy")
                End If
            End While
            rst.Close()
        Else
            ratingsid.Text = ""
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If ckSetLEvel.Checked = True And txtRatings.Text.Length = 0 Then
            MessageBox.Show("Please select reward level", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRatings.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), txtFoliono.Text, "Fully closed main folio")


            If ckSetLEvel.Checked = True Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), txtFoliono.Text, "Rate guest level as " & txtRatings.Text)
                com.CommandText = "UPDATE tblhotelguest set ratings='" & ratingsid.Text & "', ratingsvalidity='" & ConvertDate(txtValidity.Text) & "' where guestid='" & guestid.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblhotelguest set ratings='', ratingsvalidity=null where guestid='" & guestid.Text & "'" : com.ExecuteNonQuery()
            End If


            com.CommandText = "UPDATE tblhotelfolioguest set closed=1, closedby='" & globaluserid & "', dateclosed=current_timestamp  where foliono='" & txtFoliono.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblhotelfolioroom set closed=1 where foliono='" & txtFoliono.Text & "'" : com.ExecuteNonQuery()
            frmHotelManagementv2.tabFilter()
            MessageBox.Show("Folio Successfully closed", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            frmHotelCheckInTransactionV2.Close()
        End If
    End Sub

 

    Private Sub ckClearLevel_CheckedChanged(sender As Object, e As EventArgs) Handles ckSetLEvel.CheckedChanged
        If ckSetLEvel.Checked Then
            txtRatings.Enabled = True
            txtValidity.Enabled = True
        Else
            txtRatings.SelectedIndex = -1
            txtValidity.Text = ""
            txtRatings.Enabled = False
            txtValidity.Enabled = False
        End If
    End Sub
End Class