Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomOccupancy

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelRoomOccupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadToComboBoxDB("select * from tblclientaccounts where hotelclient=1 and deleted=0 order by companyname asc", "companyname", "cifid", txtHotel)
        reportfilter()
        txtHotel.Text = defaultCombobox(txtHotel, Me, False)
        hotelcifid.Text = defaultCombobox(txtHotel, Me, True)
    End Sub

    Private Sub txtHotel_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtHotel.SelectedValueChanged
        If txtHotel.Text = "" Then Exit Sub
        hotelcifid.Text = DirectCast(txtHotel.SelectedItem, ComboBoxItem).HiddenValue()
        SaveDefaultComboItem(txtHotel, txtHotel.Text, DirectCast(txtHotel.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        reportfilter()
    End Sub


    Private Sub txtFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtFilter.SelectedIndexChanged
        reportfilter()
    End Sub

    Private Sub txtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTo.ValueChanged
        reportfilter()
    End Sub
    Public Sub reportfilter()
        If LCase(txtFilter.Text) = "arrival list" Then
            txtDateFrom.Visible = True
            txtDateTo.Visible = True
            txtDateFrom.Enabled = True
            txtDateTo.Enabled = True
            txtHotel.Visible = True
            MyDataGridView.ContextMenuStrip = Nothing
            ShowArival()
        ElseIf LCase(txtFilter.Text) = "guest list" Then
            txtDateFrom.Visible = True
            txtDateFrom.Enabled = True
            txtDateTo.Visible = True
            txtDateTo.Enabled = False
            txtHotel.Visible = True
            MyDataGridView.ContextMenuStrip = Nothing
            ShowGuestList()
        ElseIf LCase(txtFilter.Text) = "forecast summary" Then
            txtDateFrom.Visible = True
            txtDateFrom.Enabled = True
            txtDateTo.Visible = True
            txtDateTo.Enabled = True
            txtHotel.Visible = True
            MyDataGridView.ContextMenuStrip = Nothing
            ShowForecast()

        ElseIf LCase(txtFilter.Text) = "occupancy forecast" Then
            txtDateFrom.Visible = True
            txtDateTo.Visible = False
            txtDateFrom.Enabled = True

            txtHotel.Visible = False

            showoccupancyforecast()

        ElseIf LCase(txtFilter.Text) = "room occupancy" Then
            txtDateFrom.Visible = True
            txtDateTo.Visible = True
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = True
            txtHotel.Visible = True
            MyDataGridView.ContextMenuStrip = Nothing
            ShowAccupancy()

        ElseIf LCase(txtFilter.Text) = "inhouse guest" Then
            txtDateFrom.Visible = True
            txtDateTo.Visible = True
            txtDateFrom.Enabled = False
            txtDateTo.Enabled = False
            MyDataGridView.ContextMenuStrip = Nothing
            txtHotel.Visible = True

            ShowInhouseGuest()
            'ElseIf LCase(txtFilter.Text) = "checkout guest" Then
            '    txtDateFrom.Visible = True
            '    txtDateTo.Visible = True
            '    txtDateFrom.Enabled = True
            '    txtDateTo.Enabled = True
            '    MyDataGridView.ContextMenuStrip = Nothing
            '    ShowCheckoutGuest()

        End If
    End Sub

    Public Sub ShowArival()
        If LCase(GlobalReportTemplate) = "palm" Then
            LoadXgrid("select if((select confirmedreservation from tblhotelfolioguest where foliono=a.foliono)=1,'Confirmed','Tentatived') as Status,(select fullname from tblhotelguest where guestid=a.guestid) as Guest, roomno as' Room No',Description as 'Room Type',pax as 'Adult',Child, extra as 'Extra Person', concat(date_format(arival,'%m/%d/%Y'),' ',(select flight from tblhotelfolioguest where foliono=a.foliono)) as 'Arrival',date_format(a.departure,'%m/%d/%Y') as Departure,concat(datediff(departure,arival),' N') as 'Stay',(select nationality from tblhotelguest where guestid=a.guestid) as 'Nationality',(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agency from tblhotelfolioroom as a  where hotelcif='" & hotelcifid.Text & "' and arival between '" & ConvertDate(txtDateFrom.Value) & "' and '" & ConvertDate(txtDateTo.Value) & "'  order by arival asc;", "tblhotelfolioroom", MyDataGridView, GridView1)
        Else
            LoadXgrid("select (select group_concat(shortcode separator '|') from view_folio_shortcode where foliono=a.foliono) as Rooms,(select fullname from tblhotelguest where guestid=a.guestid) as Guest, sum(pax+extra) as Adult, sum(child) as Child, concat(date_format(arival,'%m/%d/%Y'),' ',(select flight from tblhotelfolioguest where foliono=a.foliono)) as 'Arrival',date_format(departure,'%m/%d/%Y') as Departure,(select nationality from tblhotelguest where guestid=a.guestid) as 'Nationality',concat(datediff(departure,arival),' N') as 'Stay',(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agency,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '|') as Package,if(ifnull((select sum(credit) from tblhotelfoliotransaction where foliono = a.foliono and paymenttrn=1 and cancelled=0),0)=0,'Pending','Confirmed') as Status,(select group_concat(concat('#',referenceno)) from tblhotelfoliotransaction where foliono = a.foliono and paymenttrn=1 and cancelled=0) as Payment,(select sum(credit) from tblhotelfoliotransaction where foliono = a.foliono and paymenttrn=1 and cancelled=0) as Deposit,(select group_concat(concat(date_format(datetrn,'%m/%d/%Y')) separator '-') from tblhotelfoliotransaction where foliono = a.foliono and paymenttrn=1 and cancelled=0) as Date from tblhotelfolioroom as a where cancelled=0 and arival between '" & ConvertDate(txtDateFrom.Value) & "' and '" & ConvertDate(txtDateTo.Value) & "' group by foliono order by arival asc", "tblhotelfolioroom", MyDataGridView, GridView1)
        End If
        msda.Fill(dst, 0)

        XgridColCurrency({"Deposit"}, GridView1)
        XgridColAlign({"Rooms", "Room No", "Adult", "Child", "Extra Person", "Nationality", "Departure", "No. Days", "Stay", "Status", "Date"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryNumber({"Adult", "Child", "Extra Person"}, GridView1)
        XgridGeneralSummaryCurrency({"Deposit"}, GridView1)
        'XgridColWidth({"Remarks", "Flight"}, GridView1, 200)
        'XgridColWidth({"Status"}, GridView1, 120)
        'XgridColWidth({"BalanceDue"}, GridView1, 100)
    End Sub

    Public Sub ShowGuestList()
        LoadXgrid("select 'IN-HOUSE GUEST' as Status, (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as Rooms,if(a.roomno='','',group_concat(a.roomno separator ', ')) as 'Room Number',(select fullname from tblhotelguest where guestid=a.guestid) as Guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '|') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=1 and hotelcif='" & hotelcifid.Text & "' and cancelled=0 and '" & ConvertDate(txtDateFrom.Value) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) group by foliono union all " _
                                    + " select 'ARRIVAL TOMOROW', (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '|') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where hotelcif='" & hotelcifid.Text & "' and cancelled=0 and arival='" & ConvertDate(txtDateFrom.Value.AddDays(1)) & "' group by foliono union all " _
                                    + " select 'CHECK OUT TOMOROW', (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '|') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=1 and hotelcif='" & hotelcifid.Text & "' and cancelled=0 and departure='" & ConvertDate(txtDateFrom.Value.AddDays(1)) & "' group by foliono union all  " _
                                    + " select 'NO SHOW GUEST', (select group_concat(shortcode) from view_folio_shortcode where foliono=a.foliono and folioid=a.folioid) as shortcode,if(a.roomno='','',group_concat(a.roomno separator ', ')) as roomnumber,(select fullname from tblhotelguest where guestid=a.guestid) as guest,sum(pax+extra) as Adults, Child,group_concat(distinct((select description from tblhotelroomrates where ratecode=a.rateid)) separator '|') as Package,(select (select agentname from tblhotelagent where code=tblhotelfolioguest.agentcode) from tblhotelfolioguest where foliono=a.foliono) as Agent,concat(date_format(a.arival, '%M %d'),'-',date_format(a.departure,'%d')) as 'Stay',(select flight from tblhotelfolioguest where foliono=a.foliono) as Flight,(select remarks from tblhotelfolioguest where foliono=a.foliono) as Remarks  FROM `tblhotelfolioroom` as a where inhouse=0 and hotelcif='" & hotelcifid.Text & "' and cancelled=0 and arival='" & ConvertDate(txtDateFrom.Value.AddDays(-1)) & "' group by foliono", "tblhotelfolioroom", MyDataGridView, GridView1)
        XgridColAlign({"Status", "Rooms", "Room Number", "Adults", "Child", "Stay", "Flight"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Public Sub ShowForecast()
        Dim totalRoomType As Integer = qrysingledata("cnt", "count(distinct(shortcode)) as cnt", "tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode<>''")
        Dim RoomType As String = "" : Dim roomtypeSettings(totalRoomType - 1) As String : Dim RoomTypeColumn As String = ""
        da = Nothing : st = New DataSet
        da = New MySqlDataAdapter("select distinct shortcode from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode<>'' order by sortorder asc", conn)
        da.Fill(st, 0)
        For nt = 0 To st.Tables(0).Rows.Count - 1
            RoomType += "`" & st.Tables(0).Rows(nt)("shortcode").ToString() & "` INTEGER UNSIGNED NOT NULL DEFAULT 0,"
            roomtypeSettings(nt) = st.Tables(0).Rows(nt)("shortcode").ToString()
            RoomTypeColumn = RoomTypeColumn + st.Tables(0).Rows(nt)("shortcode").ToString() & ","
        Next

        com.CommandText = "DROP TEMPORARY TABLE IF EXISTS tempforecast;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE tempforecast(  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `reportdate` DATE NOT NULL,  `reportype` VARCHAR(100) NOT NULL,   " & RoomType & " `PAX` INTEGER UNSIGNED NOT NULL DEFAULT 0, PRIMARY KEY (`id`)) ENGINE = memory;" : com.ExecuteNonQuery()

        Dim countday As Integer = DateDiff(DateInterval.Day, txtDateFrom.Value, txtDateTo.Value)
        For i = 0 To countday
            Dim rptdate As Date = txtDateFrom.Value
            ' Dim tempArivalPax As Integer = 0 : Dim temArivalRoom As Integer = 0
            'INSERT ARRIVAL DATA
            Dim totalArivalPax As Integer = 0
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select distinct shortcode from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode<>'' order by sortorder asc", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                Dim qry As String = ""
                msda = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode='" & st.Tables(0).Rows(nt)("shortcode").ToString() & "'", conn)
                msda.Fill(dst, 0)
                For dnt = 0 To dst.Tables(0).Rows.Count - 1
                    qry = qry + "roomtype='" & dst.Tables(0).Rows(dnt)("code").ToString() & "' or "
                Next
                If qry.Length > 0 Then
                    qry = qry.Remove(qry.Length - 4, 4)
                End If
                Dim PaxArrival As Integer = Val(qrysingledata("ttl", " sum(pax+extra) as 'ttl'", "tblhotelfolioroom where cancelled=0 and arival='" & ConvertDate(rptdate.AddDays(i)) & "' and (" & qry & ")"))
                Dim RoomArrival As Integer = Val(qrysingledata("ttl", " count(*) as 'ttl' ", "tblhotelfolioroom where cancelled=0 and arival='" & ConvertDate(rptdate.AddDays(i)) & "' and (" & qry & ")"))

                totalArivalPax = totalArivalPax + PaxArrival
                If countqry("tempforecast", "reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='arrival'") = 0 Then
                    com.CommandText = "insert into tempforecast set reportdate='" & ConvertDate(rptdate.AddDays(i)) & "',reportype='arrival', " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomArrival & " " : com.ExecuteNonQuery()
                Else
                    com.CommandText = "UPDATE tempforecast set " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomArrival & "  where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='arrival'" : com.ExecuteNonQuery()
                End If
            Next

            com.CommandText = "UPDATE tempforecast set pax=" & totalArivalPax & " where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='arrival'" : com.ExecuteNonQuery()


            'INSERT DEPARTURE
            Dim totalDeparturePax As Integer = 0
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select distinct shortcode from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode<>'' order by sortorder asc", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                Dim qry As String = ""
                msda = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode='" & st.Tables(0).Rows(nt)("shortcode").ToString() & "'", conn)
                msda.Fill(dst, 0)
                For dnt = 0 To dst.Tables(0).Rows.Count - 1
                    qry = qry + "roomtype='" & dst.Tables(0).Rows(dnt)("code").ToString() & "' or "
                Next
                If qry.Length > 0 Then
                    qry = qry.Remove(qry.Length - 4, 4)
                End If
                Dim PaxDeparture As Integer = 0
                Dim RoomDeparture As Integer = 0

                PaxDeparture = Val(qrysingledata("ttl", " sum(pax+extra) as 'ttl'", "tblhotelfolioroom where cancelled=0 and departure='" & ConvertDate(rptdate.AddDays(i)) & "' and (" & qry & ")"))
                RoomDeparture = Val(qrysingledata("ttl", " count(*) as 'ttl' ", "tblhotelfolioroom where cancelled=0 and departure='" & ConvertDate(rptdate.AddDays(i)) & "' and (" & qry & ")"))
                totalDeparturePax = totalDeparturePax + PaxDeparture
                If countqry("tempforecast", "reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='departure'") = 0 Then
                    com.CommandText = "insert into tempforecast set reportdate='" & ConvertDate(rptdate.AddDays(i)) & "',reportype='departure', " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomDeparture & " " : com.ExecuteNonQuery()
                Else
                    com.CommandText = "UPDATE tempforecast set " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomDeparture & "  where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='departure'" : com.ExecuteNonQuery()
                End If
            Next
            com.CommandText = "UPDATE tempforecast set pax=" & totalDeparturePax & " where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='departure'" : com.ExecuteNonQuery()

            'INHOUSE
            Dim totalinhousePax As Integer = 0
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select distinct shortcode from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode<>'' order by sortorder asc", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                Dim qry As String = ""
                msda = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblhotelroomtype where hotelcif='" & hotelcifid.Text & "' and shortcode='" & st.Tables(0).Rows(nt)("shortcode").ToString() & "'", conn)
                msda.Fill(dst, 0)
                For dnt = 0 To dst.Tables(0).Rows.Count - 1
                    qry = qry + "roomtype='" & dst.Tables(0).Rows(dnt)("code").ToString() & "' or "
                Next
                If qry.Length > 0 Then
                    qry = qry.Remove(qry.Length - 4, 4)
                End If
                Dim PaxInhouse As Integer = 0
                Dim RoomInhouse As Integer = 0

                PaxInhouse = Val(qrysingledata("ttl", "sum(pax+extra) as 'ttl'", "tblhotelfolioroom where cancelled=0 and (" & qry & ") and '" & ConvertDate(rptdate.AddDays(i)) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) "))
                RoomInhouse = Val(qrysingledata("ttl", "count(*) as 'ttl'", "tblhotelfolioroom where cancelled=0 and (" & qry & ") and '" & ConvertDate(rptdate.AddDays(i)) & "' between arival and DATE_ADD(departure, INTERVAL -1 DAY) "))

                totalinhousePax = totalinhousePax + PaxInhouse
                If countqry("tempforecast", "reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='inhouse'") = 0 Then
                    com.CommandText = "insert into tempforecast set reportdate='" & ConvertDate(rptdate.AddDays(i)) & "',reportype='inhouse', " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomInhouse & " " : com.ExecuteNonQuery()
                Else
                    com.CommandText = "UPDATE tempforecast set " & st.Tables(0).Rows(nt)("shortcode").ToString() & "=" & RoomInhouse & "  where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='inhouse'" : com.ExecuteNonQuery()
                End If
            Next
            com.CommandText = "UPDATE tempforecast set pax=" & totalinhousePax & " where reportdate='" & ConvertDate(rptdate.AddDays(i)) & "' and reportype='inhouse'" : com.ExecuteNonQuery()
        Next
        LoadXgrid("select reportdate as 'Report Date', ucase(reportype) as 'Report Type'," & RoomTypeColumn & "PAX from tempforecast order by reportype,reportdate asc", "tempforecast", MyDataGridView, GridView1)
        For Each arr In roomtypeSettings
            XgridColAlign({arr}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        Next
        XgridColAlign({"Report Date", "Report Type", "PAX"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
    End Sub

    Public Sub ShowAccupancy()
        
        LoadXgrid("select tblhotelrooms.roomid,ifnull((select color from tblhotelroomstatus where statuscode=tblhotelrooms.roomstatus),'') as Color,  roomnumber as 'Room Number', tblhotelrooms.Description, Occupied, Maintainance, " _
                                    + " roomstatus as 'Room Status', " _
                                    + " ifnull((select fullname from tblhotelguest where guestid = tblhotelfolioroom.guestid),'')  as 'Guest', " _
                                    + " date_format(arival, '%Y-%m-%d') as 'Arival Date', " _
                                    + " date_format(departure, '%Y-%m-%d') as 'Departure Date', " _
                                    + " pax as 'Adults', " _
                                    + " child as 'Kids', " _
                                    + " extra as 'Extra Person', " _
                                    + " Remarks " _
                                    + " from tblhotelrooms left join tblhotelfolioroom on tblhotelrooms.roomid = tblhotelfolioroom.roomid and inhouse=1 and checkout=0 and cancelled=0 and '" & ConvertDate(txtDateTo.Value) & "' between arival and departure where hotelcifid='" & hotelcifid.Text & "' and deleted=0 order by roomid asc", "tblhotelfolioroom", MyDataGridView, GridView1)
        XgridHideColumn({"roomid", "Occupied", "Maintainance"}, GridView1)
        XgridColAlign({"Room Number", "Arival Date", "Departure Date", "Adults", "Kids", "Extra Person", "Plate Number", "Room Status"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub
    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If LCase(txtFilter.Text) = "room occupancy" Then
            If e.Column.Name = "colColor" Then
                Dim colorRgb As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Color"))
                e.Appearance.BackColor = RGBColorConverter(colorRgb)
                e.Appearance.ForeColor = RGBColorConverter(colorRgb)
            End If
        End If
    End Sub
    Public Sub showoccupancyforecast()
        LoadXgrid("select f.foliono as 'Reservation No', if(confirmedreservation=1,'Confirmed','Tentative') as 'Status',(select fullname from tblhotelguest where guestid=f.guestid) as 'Guest', roomno  as 'Room No.',(select description from tblhotelroomtype where code=g.roomtype)  as 'Room Type' ,pax as 'Adult',Child,extra as  'Extra Person',g.arival as 'Arrival',g.departure as  'Departure', datediff(g.departure,g.arival) as 'No. Days',(select nationality from tblhotelguest where guestid=f.guestid)  as 'Nationality',(select agentname from tblhotelagent where code=f.agentcode) as 'Agent'  from tblhotelfolioroom as g inner join tblhotelfolioguest as f on g.foliono = f.foliono where '" & ConvertDate(txtDateFrom.Value) & "' between g.arival and DATE_ADD(g.departure, INTERVAL -1 DAY) and g.cancelled=0", "tblhotelfolioroom", MyDataGridView, GridView1)
        'gridHideColumn({"roomid", "Occupied", "Maintainance", "color"}, GridView1)
        XgridColAlign({"Reservation No", "Status", "Room No.", "Adult", "Child", "Extra Person", "Arrival", "Departure", "No. Days", "Nationality", "Agent"}, GridView1, DevExpress.Utils.HorzAlignment.Center)


    End Sub

    Public Sub ShowInhouseGuest()
 
        LoadXgrid(" select a.FolioNo as 'Folio No',  " _
                           + " (select description from tblhotelguesttype where code=b.guesttype) as 'Type of Guest', " _
                           + " (select fullname from tblhotelguest where guestid=a.guestid) as 'Guest Name', " _
                           + " ifnull((select roomnumber from tblhotelrooms where roomid  = a.roomid),'-') as 'Room No.', " _
                           + " pax as 'Adult', child as 'Child', extra as 'Extra Person', " _
                           + " date_format(a.arival, '%Y-%m-%d') as 'Date Check-in', " _
                           + " date_format(a.departure, '%Y-%m-%d') as 'Date Check-out', " _
                           + " datediff(a.departure,a.arival)  as 'No. Days', " _
                           + " platenumber as 'Plate Number'," _
                           + " Flight, " _
                           + " b.Remarks, " _
                           + " (select agentname from tblhotelagent where code = b.agentcode) as 'Agent', " _
                           + " (select fullname from tblaccounts where accountid = b.trnby) as 'Transaction by' " _
                           + " from tblhotelfolioroom as a inner join tblhotelfolioguest as b on a.foliono=b.foliono where hotelcif='" & hotelcifid.Text & "' and a.inhouse=1 and a.checkout=0 and a.cancelled=0 ", "tblhotelfolioroom", MyDataGridView, GridView1)
        
        XgridColAlign({"Folio No", "Type of Guest", "Room No.", "Room Type", "Rate Type", "Adult", "Child", "Extra Person", "Date Check-in", "Time Check-in", "Date Check-out", "Time Check-out", "No. Days", "Plate Number"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryNumber({"Adult", "Child", "Extra Person"}, GridView1)
    End Sub

    
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            reportfilter()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If LCase(txtFilter.Text) = "room occupancy" Then
            DXPrintDatagridview(Me.Text & "<br/>", Me.Text, "Total Occupied: " & countqry("tblhotelfolioroom", "inhouse=1 and checkout=0 and hotelcif='" & hotelcifid.Text & "'") & "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Total Vacant: " & countqry("tblhotelrooms", "occupied=0 and maintainance=0 and hotelcifid='" & hotelcifid.Text & "'") & "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Maintainance: " & countqry("tblhotelrooms", "occupied=0 and maintainance=1 and hotelcifid='" & hotelcifid.Text & "'"), GridView1, Me)
        ElseIf LCase(txtFilter.Text) = "guest list" Then
            GenerateLXHotelGuestList(hotelcifid.Text, txtHotel.Text, txtDateFrom.Value, Me)
        ElseIf LCase(txtFilter.Text) = "forecast summary" Then
            GenerateLXHotelForecast(txtHotel.Text, hotelcifid.Text, txtDateFrom.Value, txtDateTo.Value, Me)
        ElseIf LCase(txtFilter.Text) = "arrival list" Then
            DXPrintDatagridview(txtFilter.Text & "<br/><h3>" & txtHotel.Text & "</h3>", txtFilter.Text, "<b>Arrival for " & txtDateFrom.Value.ToString("MMMM dd, yyyy") & " to " & txtDateTo.Value.ToString("MMMM dd, yyyy") & "</b>", GridView1, Me)

        ElseIf LCase(txtFilter.Text) = "occupancy forecast" Then
            Dim getTentative As Integer = 0 : Dim getInhouse As Integer = 0 : Dim getConfirmed As Integer = 0 : Dim Total As Integer = 0
            For i = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "Status").ToString = "Tentative" Then
                    getTentative = getTentative + 1
                ElseIf GridView1.GetRowCellValue(i, "Status").ToString = "In-House" Then
                    getInhouse = getInhouse + 1
                ElseIf GridView1.GetRowCellValue(i, "Status").ToString = "Confirmed" Then
                    getConfirmed = getConfirmed + 1
                End If
            Next

            DXPrintDatagridview(txtFilter.Text & "<br/>", txtFilter.Text, "Date Filter: " & txtDateFrom.Text & "</br></br> Tentative: " & getTentative & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Confirmed: " & getConfirmed & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; In-House: " & getInhouse & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total: " & getTentative + getConfirmed + getInhouse & "", GridView1, Me)

        Else
            DXPrintDatagridview(txtFilter.Text & "<br/>", txtFilter.Text, "Date Filter: " & txtDateFrom.Text, GridView1, Me)
        End If
    End Sub


    Private Sub txtDateFilter_ValueChanged(sender As Object, e As EventArgs) Handles txtDateFrom.ValueChanged
        reportfilter()
    End Sub

    Private Sub txtHotel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtHotel.SelectedIndexChanged

    End Sub


End Class