Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmHotelRoomAvailability
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelRoomAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtDateArival.Value = CDate(Now)
        txtdateCheckout.Value = CDate(Now.AddDays(1))
        FilterRoom()
    End Sub

    Public Sub FilterRoom()
        'LoadXgrid("select (select description from tblhotelroomtype where code=tblhotelrooms.roomtype) as 'Room Type', count(*) - (select count(*) from tblhotelfolioroom where  (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtDateDeparture.Value)) & ") and arival>=current_date and cancelled=0 and roomtype=tblhotelrooms.roomtype) as 'Total Rooms', (select companyname from tblclientaccounts where cifid=tblhotelrooms.hotelcifid) as 'Hotel' from tblhotelrooms where hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') group by roomtype;", "tblhotelrooms", Em, GridView_Room)
        LoadXgrid("select code, Description as 'Room Type',(select count(*) from tblhotelrooms where roomtype=tblhotelroomtype.code and hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and " _
                                    + " roomid not in (select roomid from tblhotelfolioroom where (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value)) & ") and cancelled=0) and " _
                                    + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value)) & ") and closed=0)) as 'Available Rooms',(select companyname from tblclientaccounts where cifid=tblhotelroomtype.hotelcif) as Hotel from tblhotelroomtype group by code;", "tblhotelroomtype", Em, GridView_Room)
        XgridHideColumn({"code"}, GridView_Room)
        XgridColAlign({"Available Rooms"}, GridView_Room, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryNumber({"Available Rooms"}, GridView_Room)
        XgridColWidth({"Room Type"}, GridView_Room, 300)
    End Sub

    Private Sub cmdEditGuest_Click(sender As Object, e As EventArgs) Handles cmdEditGuest.Click
        FilterRoom()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        GenerateRoomAvailabity(GridView_Room.GetFocusedRowCellValue("code").ToString, GridView_Room.GetFocusedRowCellValue("Room Type").ToString, txtDateArival.Value, txtdateCheckout.Value, Me)
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub txtDateArival_ValueChanged(sender As Object, e As EventArgs) Handles txtDateArival.ValueChanged
        txtdateCheckout.MinDate = txtDateArival.Value.AddDays(1)
    End Sub
End Class
