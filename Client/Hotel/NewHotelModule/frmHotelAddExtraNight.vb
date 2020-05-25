Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelAddExtraNight
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmHotelCheckInTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        com.CommandText = "select *,ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelfolioroom.rateid and breakdowntype='roomrate' and dayrate=0),0) as rate from tblhotelfolioroom where folioid='" & folioid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            foliono.Text = rst("foliono").ToString
            roomtype.Text = rst("roomtype").ToString
            rateid.Text = rst("rateid").ToString
            txtRoomPackageRate.Text = rst("rateid").ToString
            txtPackageRate.Text = FormatNumber(Val(rst("rate").ToString), 2)
        End While
        rst.Close()
    End Sub
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceed.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "' and departure='" & ConvertDate(txtdateCheckout.Value) & "'") = 0 Then
                com.CommandText = "update tblhotelfolioguest set departure='" & ConvertDate(txtdateCheckout.Value) & "' where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            End If
            com.CommandText = "update tblhotelfolioroom set departure='" & ConvertDate(txtdateCheckout.Value) & "' where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblhotelfolioroomsummary set departure='" & ConvertDate(txtdateCheckout.Value) & "' where folioid='" & folioid.Text & "'" : com.ExecuteNonQuery()
            Dim datTim1 As Date = CDate(currentCheckout.Value)
            Dim datTim2 As Date = CDate(txtdateCheckout.Value)
            Dim nights As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)

            For i = 0 To nights - 1
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Added extra night for room " & GetRoomFolioInfo(folioid.Text, "roomno") & " date " & ConvertDate(datTim1.AddDays(i)))
                com.CommandText = "INSERT INTO `tblhotelfolioroomsummary` (folioid,foliono,hotelcif,roomtrncode,arival,departure,dayno,datetrn,roomid,roomno,roomtype,roomdesc,nightcharge,rateid,adult,adultrate,adultbaserate,child,childrate,childbaserate,extra,extrarate,extrabaserate,total,cancelled) " _
                            + " SELECT folioid,foliono,hotelcif,concat(foliono,'-',folioid,'-',dayno+1),arival,departure,dayno+1,'" & ConvertDate(datTim1.AddDays(i)) & "',roomid,roomno,roomtype,roomdesc,nightcharge,'" & rateid.Text & "',adult,adultrate,adultbaserate,child,childrate,childbaserate,extra,extrarate,extrabaserate,total,cancelled FROM  `tblhotelfolioroomsummary` where folioid='" & folioid.Text & "' order by dayno desc limit 1 " : com.ExecuteNonQuery()
            Next
            UpdateFolioSummary(foliono.Text)
            frmHotelRoomStatementLedger.ShowRoomInfo(folioid.Text)
            MessageBox.Show("Room extra night successfully posted", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub txtdateCheckout_ValueChanged(sender As Object, e As EventArgs) Handles txtdateCheckout.ValueChanged
        CalculateNights()
    End Sub
    Public Sub CalculateNights()
        Dim datTim1 As Date = CDate(currentCheckout.Value).ToShortDateString
        Dim datTim2 As Date = CDate(txtdateCheckout.Value).ToShortDateString
        Dim daycount As Integer = DateDiff(DateInterval.Day, CDate(datTim1), CDate(datTim2))
        txtExtraNightCount.Text = daycount
    End Sub
End Class