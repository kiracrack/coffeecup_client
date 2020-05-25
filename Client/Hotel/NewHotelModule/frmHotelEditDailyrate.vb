Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelEditDailyrate
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelEditFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowFolioInfo()
        LoadHotelPackages()
    End Sub

    Public Sub LoadHotelPackages()
        LoadXgridLookupSearch("select ratecode,  Description as Package, ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate' and dayrate=0),0) as 'Package Rate' from tblhotelroomrates where deleted=0 and roomtype='" & roomtype.Text & "' and (temporaryrate=0 or bookingno='" & foliono.Text & "') order by description asc", "tblhotelroomrates", txtRoomPackageRate, gridPackage)
        gridPackage.Columns("ratecode").Visible = False
        XgridColCurrency({"Package Rate"}, gridPackage)
    End Sub

    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomPackageRate.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtRoomPackageRate.Properties.View.FocusedRowHandle.ToString)
        rateid.Text = txtRoomPackageRate.Properties.View.GetFocusedRowCellValue("ratecode").ToString()
        txtPackageRate.Text = FormatNumber(txtRoomPackageRate.Properties.View.GetFocusedRowCellValue("Package Rate").ToString(), 2)
    End Sub

    Public Sub ShowFolioInfo()
        com.CommandText = "select *,ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelfolioroomsummary.rateid and breakdowntype='roomrate' and dayrate=0),0) as rate from tblhotelfolioroomsummary where id='" & trnid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono.Text = rst("foliono").ToString
            folioid.Text = rst("folioid").ToString
            roomtype.Text = rst("roomtype").ToString
            txtDate.Text = CDate(rst("datetrn").ToString).ToString("MMMM dd, yyyy")
            txtPax.Text = rst("adult").ToString
            txtChild.Text = rst("child").ToString
            txtExtra.Text = rst("extra").ToString
            rateid.Text = rst("rateid").ToString
            txtRoomPackageRate.Text = rst("rateid").ToString
            txtPackageRate.Text = FormatNumber(Val(rst("rate").ToString), 2)
        End While
        rst.Close()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tblhotelfolioroomsummary set adult='" & Val(txtPax.Text) & "', child='" & Val(txtChild.Text) & "', extra='" & Val(txtExtra.Text) & "',rateid='" & rateid.Text & "' where id='" & trnid.Text & "'" : com.ExecuteNonQuery()

            UpdateFolioSummary(foliono.Text)
            If frmHotelFolioRoomInfo.Visible = True Then
                frmHotelFolioRoomInfo.LoadRoomInformation()
            End If
            frmHotelCheckInTransactionV2.FilterRoom()
            MessageBox.Show("Daily rate successfully updated! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

End Class