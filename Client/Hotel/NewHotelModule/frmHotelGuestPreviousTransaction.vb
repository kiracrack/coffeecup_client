Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelGuestPreviousTransaction
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelGuestPreviousTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FilterRoom()
        FilterPOStransaction()
    End Sub

#Region "R O O M"

    Public Sub FilterRoom()
        dst3.EnforceConstraints = False : dst3.Relations.Clear() : dst3.Clear()
        LoadXgrid("select concat(foliono,folioid) as TrnCode,inhouse,checkout,closed, folioid,roomtype, roomid, if(cancelled=1,'Cancelled',if(closed=1,'Closed', if(checkout=1,'Checked-Out',if(inhouse=1,if(departure=current_date,'Check-Out Today',if(departure<current_date,'Forgot Check-Out','Checked-In')),if(arival<current_date,'No Show','-')))))  as 'Status',  " _
                                        + " date_format(arival,'%Y-%m-%d') as 'Arival', " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " roomno as 'Room No.', description as 'Room Type', " _
                                        + " (select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid) as 'Package', " _
                                        + " ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid and dayno=0 limit 1),0)  as 'Package Rate', " _
                                        + " if(chargepernight=1,'Per Night','Per Pax') as 'Charge Type'," _
                                        + " Pax as Adult, Child,extra as 'Extra Person', Pax+extra as 'Total Pax', " _
                                        + " datediff(departure,arival) as 'No. Day', " _
                                        + " ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) as 'RoomCharges', " _
                                        + " (select companyname from tblclientaccounts where cifid=tblhotelfolioroom.hotelcif) as Hotel from tblhotelfolioroom where cancelled=0 and guestid='" & guestid.Text & "' and inhouse=1 and checkout=1 order by arival desc limit 10", "tblhotelfolioroom", Em, GridView_Room)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst3, "tblhotelfolioroom")

        Dim CurrencyDetails As Array = {"RoomCharges"}
        XgridHideColumn({"TrnCode", "folioid", "roomtype", "roomid", "inhouse", "checkout", "closed"}, GridView_Room)
        XgridColCurrency({"Package Rate"}, GridView_Room)
        XgridColCurrency(CurrencyDetails, GridView_Room)
        XgridColAlign({"Status", "Room No.", "Arival", "Departure", "No. Day", "Adult", "Child", "Extra Person", "Total Pax", "Charge Type"}, GridView_Room, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency(CurrencyDetails, GridView_Room)
        XgridGroupSummaryCurrency(CurrencyDetails, GridView_Room)
        XgridGeneralSummaryNumber({"Adult", "Child", "Extra Person", "Total Pax"}, GridView_Room)
        XgridColWidth({"Status"}, GridView_Room, 125)
        XgridColWidth(CurrencyDetails, GridView_Room, 85)

        msda = New MySqlDataAdapter("SELECT concat(foliono,folioid) as TrnCode, date_format(datetrn,'%Y-%m-%d')  as Date, Adult, AdultRate as 'RoomRate',Child,ChildRate,Extra as 'ExtraPerson',extraRate as 'ExtraPersonRate',Total FROM `tblhotelfolioroomsummary` where foliono in (select foliono from tblhotelfolioroom where cancelled=0 and guestid='" & guestid.Text & "' and inhouse=1 and checkout=1) ", conn)
        msda.Fill(dst3, "tblhotelfolioroomsummary")

        BandgridView = New GridView(Em)
        Dim keyColumn As DataColumn = dst3.Tables("tblhotelfolioroom").Columns("TrnCode")
        Dim foreignKeyColumn2 As DataColumn = dst3.Tables("tblhotelfolioroomsummary").Columns("TrnCode")

        dst3.Relations.Add("RoomDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("RoomDetails", BandgridView)

        Em.DataSource = dst3.Tables("tblhotelfolioroom")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst3.Tables("tblhotelfolioroomsummary"))
        BandgridView.BestFitColumns()

        DXBandGridFormat(BandgridView)
        XgridHideColumn({"TrnCode"}, BandgridView)
        XgridColCurrency({"RoomRate", "ChildRate", "ExtraPersonRate", "Total"}, BandgridView)
        XgridColAlign({"Date", "Adult", "Child", "ExtraPerson", "PerRoomCharge"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, BandgridView)
        XgridColWidth({"Date", "Total"}, BandgridView, 120)
    End Sub

    Private Sub GridView_Room_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_Room.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim priority As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If priority = "Checked-In" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "No Show" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White
            ElseIf priority = "Check-Out Today" Then
                e.Appearance.BackColor = Color.Gold
                e.Appearance.ForeColor = Color.Black
            ElseIf priority = "Forgot Check-Out" Or priority = "Cancelled" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            ElseIf priority = "Checked-Out" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Blue
            ElseIf priority = "Closed" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Green
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

#End Region


#Region "P O S   T R A N S A C T I O N"
    Public Sub FilterPOStransaction()
        LoadXgrid("select date_format(datetrn, '%Y-%m-%d %r') as 'Date Posted', productname as ItemName, Quantity,sellprice as 'Unit Price', Total from tblsalestransaction where (batchcode in (SELECT referenceno FROM `tblhotelfoliotransaction` where guestid='" & guestid.Text & "' and chargefrompos=1 and cancelled=0 order by datetrn desc) or batchcode in (select batchcode from tblhotelcashtransaction where guestid='" & guestid.Text & "')) and cancelled = 0 order by datetrn", "tblsalestransaction", Em_POS, GridView_POS)
        XgridColCurrency({"Unit Price", "Total"}, GridView_POS)
        XgridColAlign({"Date Posted", "Quantity", "Unit Price"}, GridView_POS, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_POS)
        XgridGroupSummaryCurrency({"Total"}, GridView_POS)
        XgridColWidth({"Total"}, GridView_POS, 120)
    End Sub

#End Region


End Class
