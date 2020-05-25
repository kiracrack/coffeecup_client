Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmHotelManagementv2
    Private BandgridView As GridView
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        ElseIf keyData = Keys.Control + (Keys.F12) Then
            'ProgressBarControl1.Visible = True
            'If MessageBox.Show("Are you sure you want to continue Database Migration? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            '    com.CommandText = "delete from tblhotelfoliotransaction where remarks='Offset correction'" : com.ExecuteNonQuery()
            '    ProgressBarControl1.Text = 0
            '    dst = Nothing : dst = New DataSet
            '    msda = New MySqlDataAdapter("select *,ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-(select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0) as BalanceDue from tblhotelfolioguest where closed=1", conn)
            '    msda.Fill(dst, 0)
            '    ProgressBarControl1.Properties.Maximum = dst.Tables(0).Rows.Count
            '    For cnt = 0 To dst.Tables(0).Rows.Count - 1
            '        With (dst.Tables(0))
            '            If Val(.Rows(cnt)("BalanceDue").ToString()) <> 0 Then
            '                com.CommandText = "insert into tblhotelfoliotransaction set folioid='', foliono='" & .Rows(cnt)("foliono").ToString() & "',guestid='" & .Rows(cnt)("guestid").ToString() & "',roomid='',roomno='',trnsumcode='',officeid='', guestcheckno='',remarks='Offset correction', " & If(Val(.Rows(cnt)("BalanceDue").ToString()) > 0, "credit='" & Val(.Rows(cnt)("BalanceDue").ToString()) & "',debit=0,paymenttrn=1", "debit='" & .Rows(cnt)("BalanceDue").ToString().Replace("-", "") & "',credit=0,chargefrompos=1") & ",datetrn=current_timestamp,trnby='100'" : com.ExecuteNonQuery()
            '            End If
            '            ProgressBarControl1.EditValue = cnt
            '            ProgressBarControl1.Update()
            '        End With
            '    Next
            'End If
            'ProgressBarControl1.Visible = False
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelManagementv2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadHotelStatus()
    End Sub
   
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Me.Text = StrConv(GlobalOrganizationName, vbProperCase) & " " & Me.Text
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\hotel.png") = True Then
            PictureBox1.Image = Image.FromFile(Application.StartupPath.ToString & "\Logo\hotel.png")
        End If
        ApplySystemTheme(ToolStrip3)
        txtfrmdate.Text = Format(Now.ToShortDateString)
        txttodate.Text = Format(Now.ToShortDateString)
        tabFilter()
        If HotelOperationMode = True Then
            txtGuestType.Visible = False
            cmdNewCheckinGuest.Text = "New Check-in Guest"
            xTabReservation.PageVisible = False
        Else
            xTabReservation.PageVisible = True
            cmdNewCheckinGuest.Text = "New Reservation"
            txtGuestType.Visible = True
            LoadToToolStripComboBox("select * from tblhotelguesttype", "description", "code", txtGuestType)
            txtGuestType.Items.Add("ALL")
            txtGuestType.Text = "ALL"
        End If
        If globalFontColor = "LIGHT" Then
            cmdHotelSalesSummary.ForeColor = Color.Gold
        Else
            cmdHotelSalesSummary.ForeColor = Color.Red
        End If
        If globalCorporateApprover = True Or LCase(globalusername) = "root" Then
            cmdHotelSalesSummary.Visible = True
            linesummary.Visible = True
        Else
            cmdHotelSalesSummary.Visible = False
            linesummary.Visible = False
        End If
    End Sub
 
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        tabFilter()
        If XtraTabControl1.SelectedTabPage Is xTabArrivalGuest Then
            CheckBox1.Visible = True
        Else
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            tabFilter()
        End If
    End Sub

    Public Sub tabFilter()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        Dim SearchQuery As String = "a.Guest like '%" & rchar(txtsearch.Text) & "%' or a.arrival like '%" & rchar(txtsearch.Text) & "%' or a.departure like '%" & rchar(txtsearch.Text) & "%'  or a.`Guest Type` like '%" & rchar(txtsearch.Text) & "%' or a.FolioNo like '%" & rchar(txtsearch.Text) & "%'"


        If XtraTabControl1.SelectedTabPage Is xTabReservation Then
            Dim DateQuery As String = If(ckasof.Checked = True, "", " and date_format(a.arrival,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Value) & "' and '" & ConvertDate(txttodate.Value) & "' ")
            ReservationList(SearchQuery, If(txtsearch.Text = "", DateQuery, ""), If(txtGuestType.Text = "ALL", "", "and a.guesttype='" & guesttype.Text & "'"))

        ElseIf XtraTabControl1.SelectedTabPage Is xTabGuestList Then
            GuestList()

        ElseIf XtraTabControl1.SelectedTabPage Is xTabInhouseGuest Then
            InHouseRoom()
        ElseIf XtraTabControl1.SelectedTabPage Is xTabArrivalGuest Then
            ArrivalGuest()

        ElseIf XtraTabControl1.SelectedTabPage Is xTabCheckoutGuest Then
            Em_closed.Parent = xTabCheckoutGuest
            Dim DateQuery As String = If(ckasof.Checked = True, "", " and date_format(a.departure,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Value) & "' and '" & ConvertDate(txttodate.Value) & "' ")
            ClosedGuest(SearchQuery, If(txtsearch.Text = "", DateQuery, ""), "a.closed=1 and cancelled=0")
            cmdRestoreCloseFolio.Visible = True
            cmdRestoreCancelledFolio.Visible = False

        ElseIf XtraTabControl1.SelectedTabPage Is xTabCancelledFolio Then
            Em_closed.Parent = xTabCancelledFolio
            Dim DateQuery As String = If(ckasof.Checked = True, "", " and date_format(a.datecancelled,'%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Value) & "' and '" & ConvertDate(txttodate.Value) & "' ")
            ClosedGuest(SearchQuery, If(txtsearch.Text = "", DateQuery, ""), " cancelled=1 ")
            cmdRestoreCloseFolio.Visible = False
            cmdRestoreCancelledFolio.Visible = True

        End If
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub LoadHotelStatus()
        txtStatusArrival.Text = "Arrival: " & countqry("tblhotelfolioroom", "arival=current_date and inhouse=0 and cancelled=0") & " |"
        txtStatusInhouse.Text = "In-House: " & countqry("tblhotelfolioroom", "inhouse=1 and checkout=0 and cancelled=0") & " |"
        txtStatusForCheckout.Text = "For Check-out: " & countqry("tblhotelfolioroom", "departure<=current_date and inhouse=1 and checkout=0 and cancelled=0") & " |"
        txtStatusNoShow.Text = "No Show: " & countqry("tblhotelfolioroom", "arival<current_date and inhouse=0 and checkout=0 and cancelled=0") & " |"
    End Sub

    Public Sub ReservationList(ByVal SearchQuery As String, ByVal DateQuery As String, ByVal Filter As String)
        '+ " ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-(ifnull((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) as BalanceDue, " _
        LoadXgrid("select * from (select  " _
                                        + " case when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival=current_date and inhouse=0 and cancelled=0)>0 then 'Arrive Today' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival<current_date and inhouse=0 and cancelled=0)> 0 then 'No Show' else if(confirmedreservation=1,'Confirmed','Tentative') end as Status, " _
                                        + " notified as 'Notified Email', " _
                                        + " FolioNo, " _
                                        + " (select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as Guest, " _
                                        + " (select contactnumber from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'Contact Number', " _
                                        + " (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) as 'Guest Type', " _
                                        + " (select group_concat(roomno separator ', ') from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono and roomno<>'') as 'Room No.', " _
                                        + " (select count(*) from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono) as 'Total Room', " _
                                        + " date_format(arival,'%Y-%m-%d') as Arrival, " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " (select agentname from tblhotelagent where code = tblhotelfolioguest.agentcode) as 'Agent', Flight, Remarks, " _
                                        + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioguest.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
                                        + " (select fullname from tblaccounts where accountid=tblhotelfolioguest.trnby) as 'Posted By', date_format(datereservation,'%Y-%m-%d %r') as 'Date Reservation', " _
                                        + " Reservation,Walkin, Closed, Cancelled, guesttype,inhouse " _
                                        + " from tblhotelfolioguest) as a where a.reservation=1 and a.cancelled=0 and a.inhouse=0 and a.closed=0 and a.FolioNo in (select foliono from `tblhotelfolioroom` where inhouse=0 and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "')) and (" & SearchQuery & ") " & DateQuery & Filter, "tblhotelfolioguest", Em_Reservation, GridView_Reservation)
        XgridHideColumn({"Reservation", "Walkin", "Closed", "Cancelled", "guesttype", "inhouse"}, GridView_Reservation)
        XgridColCurrency({"BalanceDue"}, GridView_Reservation)
        XgridColAlign({"FolioNo", "Contact Number", "Guest Type", "Arrival", "Departure", "Room No.", "Total Room", "Status", "Posted By", "Date Reservation"}, GridView_Reservation, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"BalanceDue"}, GridView_Reservation)
        XgridGroupSummaryCurrency({"BalanceDue"}, GridView_Reservation)
        'XgridColWidth({"Remarks", "Flight"}, GridView_Reservation, 200)
        GridView_Reservation.Columns("Room No.").ColumnEdit = MemoEdit
        XgridColWidth({"Room No."}, GridView_Reservation, 150)
        XgridColWidth({"Status"}, GridView_Reservation, 130)
        XgridColWidth({"BalanceDue"}, GridView_Reservation, 100)
    End Sub

    Private Sub GridView_Reservation_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_Reservation.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "Arrive Today" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf status = "No Show" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub


    Public Sub GuestList()
        '+ " ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-(ifnull((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) as BalanceDue, " _
        LoadXgrid("select * from (select " _
                                        + " case when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival=current_date and inhouse=0 and checkout=1 and closed=0)>0 then 'Arrive Today' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and departure=current_date and inhouse=1 and checkout=0 and closed=0)>0 then 'Checkout Today' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and departure < current_date and inhouse=1 and checkout=0 and closed=0)>0 then 'Forgot Checkout' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and inhouse=1 and checkout=0 and closed=0 and cancelled=0) = 0 and ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) > 0 then 'Unsettled Payment' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and inhouse=1 and checkout=0 and closed=0 and cancelled=0) = 0 and ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) = 0 then 'For Close' " _
                                        + " else 'In-House' end as Status, FolioNo, " _
                                        + " (select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as Guest, " _
                                        + " (select contactnumber from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'Contact Number', " _
                                        + " (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) as 'Guest Type', " _
                                        + " (select group_concat(roomno separator ', ') from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono and roomno<>'') as 'Room No.', " _
                                        + " date_format(arival,'%Y-%m-%d') as Arrival, " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " (select agentname from tblhotelagent where code = tblhotelfolioguest.agentcode) as 'Agent', Flight, Remarks, " _
                                        + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioguest.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
                                        + " Closed, Cancelled " _
                                        + " from tblhotelfolioguest) as a where a.closed=0 and a.cancelled=0 and a.foliono in (select foliono from `tblhotelfolioroom` where inhouse=1 and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "')) and (a.Guest like '%" & rchar(txtsearch.Text) & "%' or a.Arrival like '%" & rchar(txtsearch.Text) & "%' or a.FolioNo like '%" & rchar(txtsearch.Text) & "%')", "tblhotelfolioguest", Em_GuestList, GridView_GuestList)
        XgridHideColumn({"Closed", "Cancelled"}, GridView_GuestList)
        XgridColCurrency({"BalanceDue"}, GridView_GuestList)
        XgridColAlign({"FolioNo", "Contact Number", "Guest Type", "Room No.", "Arrival", "Departure", "Status"}, GridView_GuestList, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"BalanceDue"}, GridView_GuestList)
        XgridGroupSummaryCurrency({"BalanceDue"}, GridView_GuestList)
        GridView_GuestList.Columns("Room No.").ColumnEdit = MemoEdit
        XgridColWidth({"Room No."}, GridView_GuestList, 150)
        'XgridColWidth({"Remarks"}, GridView_GuestList, 200)
        XgridColWidth({"Status"}, GridView_GuestList, 130)
        XgridColWidth({"BalanceDue"}, GridView_GuestList, 100)
    End Sub

    Private Sub cmdMergePayment_Click(sender As Object, e As EventArgs) Handles cmdMergePayment.Click
        If GridView_GuestList.SelectedRowsCount > 1 Then
            If MessageBox.Show("You are about to merge payment for multiple folio transaction! Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim SelectedFolio As String = "" : Dim SelectedBalance As Double = 0
                For I = 0 To GridView_GuestList.SelectedRowsCount - 1
                    SelectedFolio += GridView_GuestList.GetRowCellValue(GridView_GuestList.GetSelectedRows(I), "FolioNo") & ","
                    SelectedBalance += Val(CC(GridView_GuestList.GetRowCellValue(GridView_GuestList.GetSelectedRows(I), "BalanceDue")))

                    frmHotelPaymentPosting.folioid.Text = SelectedFolio.Remove(SelectedFolio.Length - 1, 1)
                    frmHotelPaymentPosting.txtAmountTender.Text = FormatNumber(SelectedBalance, 2)
                    frmHotelPaymentPosting.ckMainFolio.Checked = True
                    frmHotelPaymentPosting.ckMultiple.Checked = True
                    If frmHotelPaymentPosting.Visible = False Then
                        frmHotelPaymentPosting.Show(Me)
                    Else
                        frmHotelPaymentPosting.WindowState = FormWindowState.Normal
                    End If
                Next
            End If
        Else
            frmHotelPaymentPosting.folioid.Text = GridView_GuestList.GetFocusedRowCellValue("FolioNo").ToString
            frmHotelPaymentPosting.txtAmountTender.Text = FormatNumber(GridView_GuestList.GetFocusedRowCellValue("BalanceDue").ToString, 2)
            frmHotelPaymentPosting.ckMainFolio.Checked = True
            frmHotelPaymentPosting.ckMultiple.Checked = False
            If frmHotelPaymentPosting.Visible = False Then
                frmHotelPaymentPosting.Show(Me)
            Else
                frmHotelPaymentPosting.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub


    Private Sub GridView_GuestList_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_GuestList.RowCellStyle
        Dim View As GridView = sender
        Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
        If e.Column.Name = "colStatus" Then
            If status = "In-House" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Green
            ElseIf status = "Unsettled Payment" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White

            ElseIf status = "Forgot Checkout" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red

            ElseIf status = "Checkout Today" Then
                e.Appearance.BackColor = Color.Gold
                e.Appearance.ForeColor = Color.Black

            ElseIf status = "For Close" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Blue

            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If

    End Sub
    Public Sub InHouseRoom()
        dst.EnforceConstraints = False
        dst.Relations.Clear()
        dst.Clear()
        '+ " ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) as 'RoomCharges', " _
        '                               + " ifnull((select sum(debit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and chargefrompos=1 and cancelled=0 and appliedcoupon=0),0) as 'POS Charges', " _
        '                               + " ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and paymenttrn=1 and cancelled=0),0) as 'Payment', " _
        '                               + " (ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0)+ifnull((select sum(debit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and chargefrompos=1 and cancelled=0 and appliedcoupon=0),0)) - ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and paymenttrn=1 and cancelled=0),0) as 'BalanceDue', " _
        LoadXgrid("select concat(foliono,folioid) as TrnCode,inhouse,checkout,closed,folioid,roomtype, roomid, if(cancelled=1,'Cancelled',if(closed=1,'Closed', if(checkout=1,'Checked-Out',if(inhouse=1,if(departure=current_date,'Check-Out Today',if(departure<current_date,'Forgot Check-Out','Checked-In')),if(arival<current_date,'No Show','-')))))  as 'Status', FolioNo, " _
                                       + " (select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as Guest, " _
                                       + " (select (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) from tblhotelfolioguest where foliono=tblhotelfolioroom.foliono) as 'Type of Guest', " _
                                       + " date_format(arival,'%Y-%m-%d') as 'Arival', " _
                                       + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                       + " roomno as 'Room No.', description as 'Room Type', " _
                                       + " (select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid) as 'Package', " _
                                       + " ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid and dayno=0 limit 1),0)  as 'Package Rate', " _
                                       + " if(chargepernight=1,'Per Night','Per Pax') as 'Charge Type'," _
                                       + " Pax as Adult, Child,extra as 'Extra Person',Pax+extra as 'Total Pax', " _
                                       + " datediff(departure,arival) as 'No. Day', " _
                                       + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioroom.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
                                       + " (select companyname from tblclientaccounts where cifid=tblhotelfolioroom.hotelcif) as Hotel from tblhotelfolioroom where inhouse=1 and closed=0 and cancelled=0 and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "')", "tblhotelfolioroom", Em_InHouse, GridView_InHouse)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, "tblhotelfolioroom")

        Dim CurrencyDetails As Array = {"RoomCharges", "POS Charges", "Payment", "BalanceDue"}
        XgridHideColumn({"TrnCode", "folioid", "roomtype", "roomid", "inhouse", "checkout", "closed"}, GridView_InHouse)
        XgridColCurrency({"Package Rate"}, GridView_InHouse)
        XgridColCurrency(CurrencyDetails, GridView_InHouse)
        XgridColAlign({"FolioNo", "Status", "Type of Guest", "Contact Number", "Room No.", "Arival", "Departure", "No. Day", "Adult", "Child", "Extra Person", "Total Pax", "Charge Type"}, GridView_InHouse, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency(CurrencyDetails, GridView_InHouse)
        XgridGroupSummaryCurrency(CurrencyDetails, GridView_InHouse)
        XgridGeneralSummaryNumber({"Adult", "Child", "Extra Person", "Total Pax"}, GridView_InHouse)
        XgridColWidth({"Status"}, GridView_InHouse, 130)
        XgridColWidth(CurrencyDetails, GridView_InHouse, 85)

        msda = New MySqlDataAdapter("SELECT concat(foliono,folioid) as TrnCode, date_format(datetrn,'%Y-%m-%d')  as Date, Adult, AdultRate as 'RoomRate',Child,ChildRate,Extra as 'ExtraPerson',extraRate as 'ExtraPersonRate',Total FROM `tblhotelfolioroomsummary` where foliono in (select foliono from tblhotelfolioroom where inhouse=1 and closed=0 and cancelled=0) ", conn)
        msda.Fill(dst, "tblhotelfolioroomsummary")

        BandgridView = New GridView(Em_InHouse)
        Dim keyColumn As DataColumn = dst.Tables("tblhotelfolioroom").Columns("TrnCode")
        Dim foreignKeyColumn2 As DataColumn = dst.Tables("tblhotelfolioroomsummary").Columns("TrnCode")

        dst.Relations.Add("RoomDetails", keyColumn, foreignKeyColumn2)
        Em_InHouse.LevelTree.Nodes.Add("RoomDetails", BandgridView)

        Em_InHouse.DataSource = dst.Tables("tblhotelfolioroom")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst.Tables("tblhotelfolioroomsummary"))
        BandgridView.BestFitColumns()

        DXBandGridFormat(BandgridView)
        XgridHideColumn({"TrnCode"}, BandgridView)
        XgridColCurrency({"RoomRate", "ChildRate", "ExtraPersonRate", "Total"}, BandgridView)
        XgridColAlign({"Date", "Adult", "Child", "ExtraPerson", "PerRoomCharge"}, BandgridView, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, BandgridView)
        XgridColWidth({"Date", "Total"}, BandgridView, 120)
    End Sub

  
    Private Sub GridView_InHouse_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_InHouse.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "Checked-In" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf status = "No Show" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.ForeColor = Color.White
            ElseIf status = "Check-Out Today" Then
                e.Appearance.BackColor = Color.Gold
                e.Appearance.ForeColor = Color.Black
            ElseIf status = "Forgot Check-Out" Or status = "Cancelled" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            ElseIf status = "Checked-Out" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Blue
            ElseIf status = "Closed" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Green
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Public Sub ArrivalGuest()
        '+ " ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+ (select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0))-(ifnull((select ifnull(sum(credit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0),0)+ifnull((select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0),0)),0) as BalanceDue, " _
        LoadXgrid("select * from (select  " _
                                        + " case when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival=current_date and inhouse=0 and cancelled=0)>0 then 'Arrive Today' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival>current_date and inhouse=0 and cancelled=0)>0 then 'Arrival Tomorow' " _
                                        + " when (select count(*) from `tblhotelfolioroom` where foliono= tblhotelfolioguest.foliono and arival<current_date and inhouse=0 and cancelled=0)> 0 then 'No Show' end as Status, " _
                                        + " FolioNo, " _
                                        + " (select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as Guest, " _
                                        + " (select contactnumber from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'Contact Number', " _
                                        + " (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) as 'Guest Type', " _
                                        + " (select group_concat(roomno separator ', ') from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono  and roomno<>'') as 'Room No.', " _
                                        + " (select count(*) from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono) as 'Total Room', " _
                                        + " date_format(arival,'%Y-%m-%d') as Arrival, " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " (select agentname from tblhotelagent where code = tblhotelfolioguest.agentcode) as 'Agent', Flight, Remarks, " _
                                        + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioguest.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
                                        + " Closed, Cancelled " _
                                        + " from tblhotelfolioguest) as a where a.closed=0 and a.cancelled=0 and a.foliono in (select foliono from `tblhotelfolioroom` where inhouse=0 and " & If(CheckBox1.Checked = True, " arival<=DATE_ADD(current_date, INTERVAL 1 DAY)", " arival between current_date and DATE_ADD(current_date, INTERVAL 1 DAY)") & " and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "')) and (a.Guest like '%" & rchar(txtsearch.Text) & "%' or a.Arrival like '%" & rchar(txtsearch.Text) & "%' or a.FolioNo like '%" & rchar(txtsearch.Text) & "%') order by a.arrival asc", "tblhotelfolioguest", Em_TodayArrival, GridView_TodayArrival)
        XgridHideColumn({"Closed", "Cancelled"}, GridView_TodayArrival)
        XgridColCurrency({"BalanceDue"}, GridView_TodayArrival)
        XgridColAlign({"FolioNo", "Contact Number", "Guest Type", "Room No.", "Total Room", "Arrival", "Departure", "Status"}, GridView_TodayArrival, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"BalanceDue"}, GridView_TodayArrival)
        XgridGroupSummaryCurrency({"BalanceDue"}, GridView_TodayArrival)
        'XgridColWidth({"Remarks", "Flight"}, GridView_TodayArrival, 200)
        GridView_TodayArrival.Columns("Room No.").ColumnEdit = MemoEdit
        XgridColWidth({"Room No."}, GridView_TodayArrival, 150)
        XgridColWidth({"BalanceDue"}, GridView_TodayArrival, 100)
        XgridColWidth({"Status"}, GridView_TodayArrival, 130)
    End Sub

    Private Sub GridView_TodayArrival_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView_TodayArrival.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colStatus" Then
            Dim status As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Status"))
            If status = "Arrive Today" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
            ElseIf status = "Arrival Tomorow" Then
                e.Appearance.BackColor = Color.Khaki
                e.Appearance.ForeColor = Color.Black
            ElseIf status = "No Show" Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Public Sub ClosedGuest(ByVal SearchQuery As String, ByVal DateQuery As String, ByVal Filter As String)
        LoadXgrid("select * from (select FolioNo, " _
                                        + " (select fullname from tblhotelguest where guestid=tblhotelfolioguest.guestid) as Guest, " _
                                        + " (select contactnumber from tblhotelguest where guestid=tblhotelfolioguest.guestid) as 'Contact Number', " _
                                        + " (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) as 'Guest Type', " _
                                        + " (select group_concat(roomno separator ', ') from tblhotelfolioroom where foliono=tblhotelfolioguest.foliono and roomno<>'') as 'Room No.', " _
                                        + " date_format(arival,'%Y-%m-%d') as Arrival, " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " (select agentname from tblhotelagent where code = tblhotelfolioguest.agentcode) as 'Agent', Flight, Remarks, " _
                                        + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioguest.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
                                        + " ifnull(((select ifnull(sum(total),0) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono)+(select ifnull(sum(debit),0) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0)),0) as 'Total Transaction',  " _
                                        + If(XtraTabControl1.SelectedTabPage Is xTabCancelledFolio, "DateCancelled, CancelledRemarks, ", "") & " " _
                                        + " Closed, Cancelled " _
                                        + " from tblhotelfolioguest) as a where " & Filter & " and (" & SearchQuery & ")  " & DateQuery, "tblhotelfolioguest", Em_closed, Gridview_closed)
        XgridHideColumn({"Closed", "Cancelled"}, Gridview_closed)
        XgridColCurrency({"Total Transaction"}, Gridview_closed)
        XgridColAlign({"FolioNo", "Contact Number", "Room No.", "Guest Type", "Arrival", "Departure"}, Gridview_closed, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total Transaction"}, Gridview_closed)
        Gridview_closed.Columns("Room No.").ColumnEdit = MemoEdit
        XgridColWidth({"Room No."}, Gridview_closed, 150)
        XgridGroupSummaryCurrency({"Total Transaction"}, Gridview_closed)
        'XgridColWidth({"Remarks", "Flight"}, Gridview_closed, 200)
        XgridColWidth({"Total Transaction"}, Gridview_closed, 100)
    End Sub

    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub

    Private Sub cmdRoomTariff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoomTariff.Click
        If frmHotelRoomAvailability.Visible = False Then
            frmHotelRoomAvailability.Show(Me)
        Else
            frmHotelRoomAvailability.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If XtraTabControl1.SelectedTabPage Is xTabReservation Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "Filter: " & txtGuestType.Text, GridView_Reservation, Me)

        ElseIf XtraTabControl1.SelectedTabPage Is xTabGuestList Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "", GridView_GuestList, Me)

        ElseIf XtraTabControl1.SelectedTabPage Is xTabInhouseGuest Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "", GridView_InHouse, Me)

        ElseIf XtraTabControl1.SelectedTabPage Is xTabArrivalGuest Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "", GridView_TodayArrival, Me)

        ElseIf XtraTabControl1.SelectedTabPage Is xTabCheckoutGuest Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "", Gridview_closed, Me)

        ElseIf XtraTabControl1.SelectedTabPage Is xTabCancelledFolio Then
            DXPrintDatagridview(XtraTabControl1.SelectedTabPage.Text, "Database Report", "", Gridview_closed, Me)

        End If

    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        tabFilter()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdNewCheckinGuest.Click
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdTransactionHistory_Click(sender As Object, e As EventArgs) Handles cmdHotelSalesSummary.Click
        If frmHotelReportingTool.Visible = False Then
            frmHotelReportingTool.Show(Me)
        Else
            frmHotelReportingTool.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdProceedCheckin_Click(sender As Object, e As EventArgs) Handles cmdProceedCheckin.Click
        frmHotelCheckInTransactionV2.mode.Text = "edit"
        frmHotelCheckInTransactionV2.foliono.Text = GridView_GuestList.GetFocusedRowCellValue("FolioNo").ToString
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub txtsearch_Click(sender As Object, e As EventArgs) Handles txtsearch.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmHotelCheckInTransactionV2.mode.Text = "edit"
        frmHotelCheckInTransactionV2.foliono.Text = GridView_InHouse.GetFocusedRowCellValue("FolioNo").ToString
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmHotelCheckInTransactionV2.mode.Text = "edit"
        frmHotelCheckInTransactionV2.foliono.Text = GridView_TodayArrival.GetFocusedRowCellValue("FolioNo").ToString
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        frmHotelCheckInTransactionV2.mode.Text = "edit"
        frmHotelCheckInTransactionV2.foliono.Text = Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdCancel_Click_1(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmHotelCancelReservation.foliono.Text = GridView_TodayArrival.GetFocusedRowCellValue("FolioNo").ToString
            frmHotelCancelReservation.txtGuest.Text = GridView_TodayArrival.GetFocusedRowCellValue("Guest").ToString
            frmHotelCancelReservation.Show(Me)
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        frmHotelCheckInTransactionV2.mode.Text = "edit"
        frmHotelCheckInTransactionV2.foliono.Text = GridView_Reservation.GetFocusedRowCellValue("FolioNo").ToString
        If frmHotelCheckInTransactionV2.Visible = False Then
            frmHotelCheckInTransactionV2.Show(Me)
        Else
            frmHotelCheckInTransactionV2.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmHotelCancelReservation.foliono.Text = GridView_Reservation.GetFocusedRowCellValue("FolioNo").ToString
            frmHotelCancelReservation.txtGuest.Text = GridView_Reservation.GetFocusedRowCellValue("Guest").ToString
            frmHotelCancelReservation.Show(Me)
        End If
    End Sub

  
    Private Sub txtGuestType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGuestType.SelectedIndexChanged
        If txtGuestType.Text = "" Then Exit Sub
        If txtGuestType.Text = "ALL" Then
            guesttype.Text = ""
        Else
            guesttype.Text = DirectCast(txtGuestType.SelectedItem, ComboBoxItem).HiddenValue()
        End If
        tabFilter()
    End Sub

    Private Sub cmdRestoreCancelledFolio_Click(sender As Object, e As EventArgs) Handles cmdRestoreCancelledFolio.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "Update tblhotelfolioroom set inhouse=0,checkout=0,closed=0, cancelled=0 where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "Update tblhotelfolioroombreakdown set cancelled=0 where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "Update tblhotelfolioroomsummary set cancelled=0 where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblhotelfolioguest set cancelled=0,datecancelled=null,cancelledby='',cancelledremarks='' where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            tabFilter()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        tabFilter()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        tabFilter()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        tabFilter()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        tabFilter()
    End Sub

    Private Sub cmdGuestManagement_Click(sender As Object, e As EventArgs) Handles cmdGuestManagement.Click
        frmHotelPickGuest.mode.Text = "view"
        If frmHotelPickGuest.Visible = False Then
            frmHotelPickGuest.Show(Me)
        Else
            frmHotelPickGuest.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub RestoreClosedFolioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRestoreCloseFolio.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "Update tblhotelfolioroom set closed=0 where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblhotelfolioguest set closed=0 where foliono='" & Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString & "'" : com.ExecuteNonQuery()
            tabFilter()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        ArrivalGuest()
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub AddAttachementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdAddAttachment.Click
        AddAttachment(GridView_GuestList.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ViewAttachmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdViewAttachment.Click
        ViewAttachment(GridView_GuestList.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        AddAttachment(GridView_InHouse.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        ViewAttachment(GridView_InHouse.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        AddAttachment(GridView_TodayArrival.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        ViewAttachment(GridView_TodayArrival.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        AddAttachment(GridView_Reservation.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        ViewAttachment(GridView_Reservation.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        AddAttachment(Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        ViewAttachment(Gridview_closed.GetFocusedRowCellValue("FolioNo").ToString)
    End Sub

    Public Sub AddAttachment(ByVal trncode As String)
        frmFileUploader.trncode.Text = trncode
        frmFileUploader.trntype.Text = "HotelFolio"
        frmFileUploader.ShowDialog(Me)
    End Sub

    Public Sub ViewAttachment(ByVal trncode As String)
        frmFileViewer.trncode.Text = trncode
        frmFileViewer.trntype.Text = "HotelFolio"
        frmFileViewer.ShowDialog(Me)
    End Sub

End Class