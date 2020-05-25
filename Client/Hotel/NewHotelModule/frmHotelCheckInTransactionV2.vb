Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports System.IO


Public Class frmHotelCheckInTransactionV2
    Private BandgridView As GridView
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F3 Then
            If cmdPickGuest.Enabled = True Then
                PickGuest()
            End If
            Return False
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelCheckInTransactionV2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Val(countqry("tblhotelgrouproom", "bookno='" & foliono.Text & "'")) +
                    Val(countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "'")) +
                    Val(countqry("tblhotelfolioroombreakdown", "foliono='" & foliono.Text & "'")) +
                    Val(countqry("tblhotelfolioroomsummary", "foliono='" & foliono.Text & "'")) +
                    Val(countqry("tblhotelfoliotransaction", "foliono='" & foliono.Text & "'"))) > 0 And countqry("tblhotelfolioguest", "foliono='" & foliono.Text & "'") = 0 Then
            Dim msg = MessageBox.Show("System found transaction currently not save! Do you want to save current transaction?", GlobalOrganizationName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If msg = vbYes Then
                If CheckSecuritySaveInfo() = True Then
                    If HotelOperationMode = True Then
                        SaveFolioInfo(", walkin=1, inhouse=1 ")
                    Else
                        SaveFolioInfo(", reservation=1, datereservation=current_timestamp, confirmedreservation=0,dateconfirmedreservation=null ")
                    End If
                Else
                    e.Cancel = True
                End If
            ElseIf msg = vbNo Then
                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblhotelfoliotransaction where foliono='" & foliono.Text & "' and paymenttrn=1 and cancelled=0 order by datetrn asc", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        CancelPaymentTransaction(.Rows(cnt)("referenceno").ToString())
                    End With
                Next
                com.CommandText = "delete from tblhotelfolioroom where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelfolioroombreakdown where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelfolioroomsummary where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelfoliotransaction where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmHotelCheckInTransactionV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        LoadAgent()
        LoadAgentTypeofGuest()
        If HotelOperationMode = True Then
            txtDateArival.Enabled = False
            cmdCloseTransaction.Visible = True
            cmdSaveFolio.Text = "Save Folio"
            cmdConfirmReservation.Visible = False
            lineReservation.Visible = False
        Else
            txtDateArival.Enabled = True
            cmdCloseTransaction.Visible = False
            cmdSaveFolio.Text = "Tentative Reservation"
        End If
        If mode.Text = "edit" Then
            LoadFolioInfo()
        Else
            foliono.Text = LoadBookingNo()
            'foliono.Text = getPOSHotelFolioNo(GlobalHotelCif)
            txtDateArival.Value = CDate(Now)
            txtDeparture.MinDate = Format(CDate(Now))
            txtDeparture.Value = Format(CDate(Now.AddDays(1)))
        End If
        If globalSalesOpentrn = False Then
            cmdPayment.Visible = False
            linePostPayment.Visible = False
            cmdChargeToClientAccount.Visible = False
            lineChargeToClientAccount.Visible = False
            Em_Payment.ContextMenuStrip = Nothing
            cmdMergePayment.Visible = False
        End If
    End Sub

    Public Function LoadBookingNo() As String
        Dim BookNumber As String = ""
        Dim firstletter As String = "BCDFGHJKLMNPQRSTVWXYZ"
        Dim sb As New StringBuilder()
        Dim sb2 As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 2
            Dim idx As Integer = rand.Next(0, firstletter.Length)
            Dim idx2 As Integer = rand.Next(0, firstletter.Length)
            Dim randomChar As Char = firstletter(idx)
            Dim randomChar2 As Char = firstletter(idx2)
            sb.Append(randomChar)
            sb2.Append(randomChar2)
        Next i
        BookNumber = getPOSBookingNo() & sb2.ToString()
        Return BookNumber
    End Function

    Public Sub LoadFolioInfo()
        SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
        com.CommandText = "select * from tblhotelfolioguest where foliono='" & foliono.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            cancelled.Checked = CBool(rst("cancelled"))
        End While
        rst.Close()

        If cancelled.Checked = True Then
            UpdateFolioSummary(foliono.Text)
        End If
        Dim attachement As String = ""
        com.CommandText = "select *, (select description from tblhotelguesttype where code=tblhotelfolioguest.guesttype) as guest_type, " _
            + " (select agentname from tblhotelagent where code = tblhotelfolioguest.agentcode) as agent, " _
            + " (select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioguest.foliono) as TotalRoom, " _
            + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblhotelfolioguest.foliono and trntype='HotelFolio'),'-') as 'Attachment', " _
            + " (select sum(debit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and chargefrompos=1 and appliedcoupon=0 and cancelled=0) as TotalPOS, " _
            + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and discount=1 and cancelled=0) as TotalDiscount, " _
            + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0 and roomid<>'') as TotalPaymentRoom, " _
            + " (select sum(credit) from tblhotelfoliotransaction where foliono=tblhotelfolioguest.foliono and paymenttrn=1 and cancelled=0 and roomid='') as TotalPaymentFolio " _
            + " from tblhotelfolioguest where foliono='" & foliono.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            ckClose.Checked = CBool(rst("closed"))
            guestid.Text = rst("guestid").ToString
            guestType.Text = rst("guesttype").ToString
            txtGuestType.Text = rst("guest_type").ToString
            txtDateArival.Value = rst("arival").ToString
            txtDeparture.Value = rst("departure").ToString


            txtCurrentArrival.Value = rst("arival").ToString
            txtCurrentDeparture.Value = rst("departure").ToString

            txtPlateNumber.Text = rst("platenumber").ToString
            txtFlight.Text = rst("flight").ToString
            agentid.Text = rst("agentcode").ToString
            txtAgent.Text = rst("agent").ToString
            txtRemarks.Text = rst("remarks").ToString

            txtTotalRoomCharge.Text = FormatNumber(Val(rst("TotalRoom").ToString), 2)
            txtTotalPOS.Text = FormatNumber(Val(rst("TotalPOS").ToString), 2)
            txtTotalRoomPayment.Text = FormatNumber(Val(rst("TotalPaymentRoom").ToString), 2)
            txtTotalFolioPayment.Text = FormatNumber(Val(rst("TotalPaymentFolio").ToString), 2)
            txtTotalDiscounts.Text = FormatNumber(Val(rst("TotalDiscount").ToString), 2)

            txtTotalCharges.Text = FormatNumber(Val(CC(txtTotalRoomCharge.Text)) + Val(CC(txtTotalPOS.Text)), 2)
            txtTotalPayments.Text = FormatNumber(Val(CC(txtTotalRoomPayment.Text)) + Val(CC(txtTotalFolioPayment.Text)), 2)
            txtBalanceDue.Text = FormatNumber(Val(CC(txtTotalCharges.Text)) - (Val(CC(txtTotalPayments.Text)) + Val(CC(txtTotalDiscounts.Text))), 2)

            If CBool(rst("confirmedreservation")) = True Then
                cmdConfirmReservation.Text = "Save Confirmed Reservation"
            Else
                cmdConfirmReservation.Text = "Confirm Reservation"
            End If
            attachement = rst("Attachment").ToString
        End While
        rst.Close()
        If attachement.Length < 2 Then
            cmdAttachment.Enabled = False
            cmdAttachment.Text = "Not Availaible"
        Else
            cmdAttachment.Enabled = True
            cmdAttachment.Text = attachement
        End If
        showGuestInfo()
        FilterRoom()
        FilterRoomSummary()
        FilterPOStransaction()
        FilterCASHtransaction()
        FilterRoomDiscount()
        FilterPaymentDeposit()
        FilterCompanion()
        FilterFolioAuditTrail()
        If Val(CC(txtBalanceDue.Text)) > 0 Then
            txtBalanceDue.BackColor = Color.Red
            txtBalanceDue.ForeColor = Color.White
        ElseIf Val(CC(txtBalanceDue.Text)) < 0 Then
            txtBalanceDue.BackColor = Color.Gold
            txtBalanceDue.ForeColor = Color.Black
        Else
            txtBalanceDue.BackColor = DefaultBackColor
            txtBalanceDue.ForeColor = DefaultForeColor
        End If
        If Val(CC(txtBalanceDue.Text)) = 0 And countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "' and inhouse=1 and checkout=0 and closed=0 and cancelled=0") = 0 Then
            cmdCloseTransaction.Enabled = True
        Else
            cmdCloseTransaction.Enabled = False
            cmdCloseTransaction.ToolTipText = "Please make sure all rooms are checked out and payments are settled"
        End If

        If cancelled.Checked = True Then
            ReadOnlyFields(True, True, True)
        Else
            If ckClose.Checked = True Then
                ReadOnlyFields(True, True, False)
            Else
                If Val(CC(txtBalanceDue.Text)) > 0 Then
                    cmdPayment.Enabled = True
                    cmdChargeToClientAccount.Enabled = True

                ElseIf Val(CC(txtBalanceDue.Text)) < 0 Then
                    cmdPayment.Enabled = True
                    cmdChargeToClientAccount.Enabled = False

                Else
                    cmdPayment.Enabled = False
                    cmdChargeToClientAccount.Enabled = False
                End If
                ReadOnlyFields(False, False, False)
            End If
        End If
        If countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "' and inhouse=1 and cancelled=0") > 0 Then
            com.CommandText = "update tblhotelfolioguest set inhouse=1 where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            cmdSaveFolio.Text = "Save Folio"
            cmdConfirmReservation.Visible = False
            lineReservation.Visible = False
        End If
        If HotelOperationMode = False Then
            cmdProceedCheckin.Visible = False
            cmdCheckout.Visible = False
        End If
        SplashScreenManager.CloseForm()
    End Sub

    Public Sub ReadOnlyFields(ByVal Read_only As Boolean, ByVal ButtonHide As Boolean, ByVal HideContextMenu As Boolean)
        'enable/disable
        If Read_only = True Then
            cmdPickGuest.Enabled = False
            cmdEditGuest.Enabled = False
            txtGuestType.Enabled = False
            txtDateArival.Enabled = False
            txtDeparture.Enabled = False
            txtAgent.Enabled = False
            cmdTypeofGuest.Enabled = False
            cmdTypeofAgent.Enabled = False
        Else
            cmdPickGuest.Enabled = True
            cmdEditGuest.Enabled = True
            txtGuestType.Enabled = True
            txtDateArival.Enabled = True
            txtDeparture.Enabled = True
            txtAgent.Enabled = True
            cmdTypeofGuest.Enabled = True
            cmdTypeofAgent.Enabled = True
        End If

        txtPlateNumber.ReadOnly = Read_only
        txtFlight.ReadOnly = Read_only
        txtRemarks.ReadOnly = Read_only


        If ButtonHide = True Then
            cmdSaveFolio.Visible = False
            lineSave.Visible = False
            cmdPayment.Visible = False
            linePostPayment.Visible = False
            cmdCloseTransaction.Visible = False
            cmdConfirmReservation.Visible = False
            lineReservation.Visible = False
            cmdChargeToClientAccount.Visible = False
            lineChargeToClientAccount.Visible = False
        Else
            If HotelOperationMode = True Then
                cmdConfirmReservation.Visible = False
                lineReservation.Visible = False

                cmdChargeToClientAccount.Visible = True
                lineChargeToClientAccount.Visible = True
            Else
                cmdConfirmReservation.Visible = True
                lineReservation.Visible = True

                cmdChargeToClientAccount.Visible = False
                lineChargeToClientAccount.Visible = False
            End If
            cmdSaveFolio.Visible = True
            lineSave.Visible = True
            cmdPayment.Visible = True
            linePostPayment.Visible = True
            cmdCloseTransaction.Visible = True
        End If

        If HideContextMenu = True Then
            cmdPrintGuestFolio.Visible = False
            lineGuestFolio.Visible = False
            cmdConsolidatedMasterFolio.Visible = False
            cmdPrintMainFolio.Visible = False
            cmdPrintTransaction.Visible = False
            Em.ContextMenuStrip = Nothing
            Em_Discount.ContextMenuStrip = Nothing
            Em_Payment.ContextMenuStrip = Nothing
            Em_Companion.ContextMenuStrip = Nothing
        Else
            cmdPrintGuestFolio.Visible = True
            lineGuestFolio.Visible = True
            cmdConsolidatedMasterFolio.Visible = True
            cmdPrintMainFolio.Visible = True
            cmdPrintTransaction.Visible = True

            Em.ContextMenuStrip = cms_room
            Em_Discount.ContextMenuStrip = cms_discount
            Em_Payment.ContextMenuStrip = cms_deposit
            Em_Companion.ContextMenuStrip = cms_companion

            'context button settings
            If ButtonHide = True Then
                cmdRoomAdd.Visible = False
                cmdProceedCheckin.Visible = False
                cmdCheckout.Visible = False
                lineCheckout.Visible = False
                cmdDiscount.Visible = False
                cmdRestoreUncheckOut.Visible = False
                cmdMergePayment.Visible = False
                lineCompanion.Visible = False
                cmdRoomAddCompanion.Visible = False
                cmdRoomRemove.Visible = False
                cmdRoomUpgrade.Visible = False
                cmdEditRoom.Visible = False
                cmdChangeRoomChargeType.Visible = False
                Em_Discount.ContextMenuStrip = Nothing
                Em_Payment.ContextMenuStrip = Nothing
                Em_Companion.ContextMenuStrip = Nothing
            Else
                cmdRoomAdd.Visible = True
                If HotelOperationMode = True Then
                    cmdProceedCheckin.Visible = True
                    cmdCheckout.Visible = True
                    lineCheckout.Visible = True
                    cmdRestoreUncheckOut.Visible = True
                Else
                    cmdProceedCheckin.Visible = False
                    cmdCheckout.Visible = False
                    lineCheckout.Visible = False
                    cmdRestoreUncheckOut.Visible = False
                End If
                cmdRoomUpgrade.Visible = True
                cmdChangeRoomChargeType.Visible = True
                cmdDiscount.Visible = True
                cmdMergePayment.Visible = True
                lineCompanion.Visible = True
                cmdRoomAddCompanion.Visible = True
                cmdRoomRemove.Visible = True
                cmdEditRoom.Visible = True
                Em_Discount.ContextMenuStrip = cms_discount
                Em_Payment.ContextMenuStrip = cms_deposit
                Em_Companion.ContextMenuStrip = cms_companion
            End If

        End If
    End Sub


    Private Sub cmdPrintGuestFolio_Click(sender As Object, e As EventArgs) Handles cmdPrintGuestFolio.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print guest folio")
        GenerateGuestFolio(foliono.Text, Me)
    End Sub

    Private Sub cmdPrintMainFolio_Click(sender As Object, e As EventArgs) Handles cmdPrintMainFolio.Click
        If MessageBox.Show("Do you want to print original bill figure? Select NO to modify", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print guest statement of account (SOA)")
            GenerateGuestFolioStatement(foliono.Text, Me)
        Else
            frmHotelBillPrintOption.txtFoliono.Text = foliono.Text
            frmHotelBillPrintOption.txtRoomCharges.Text = FormatNumber(txtTotalRoomCharge.Text, 2)
            frmHotelBillPrintOption.txtPosCharges.Text = FormatNumber(txtTotalPOS.Text, 2)
            frmHotelBillPrintOption.txtTotalCharges.Text = FormatNumber(txtTotalCharges.Text, 2)
            frmHotelBillPrintOption.txtPayment.Text = FormatNumber(txtTotalPayments.Text, 2)
            frmHotelBillPrintOption.txtDiscount.Text = FormatNumber(txtTotalDiscounts.Text, 2)
            frmHotelBillPrintOption.txtBalanceDue.Text = FormatNumber(txtBalanceDue.Text, 2)
            If frmHotelBillPrintOption.Visible = True Then
                frmHotelBillPrintOption.Focus()
            Else
                frmHotelBillPrintOption.Show(Me)
            End If
        End If
    End Sub

    Private Sub cmdPrintTransaction_Click(sender As Object, e As EventArgs) Handles cmdPrintTransaction.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print guest transaction " & XtraTabControl1.SelectedTabPage.Text & " tab")
        If XtraTabControl1.SelectedTabPage Is tabRoomCharge Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, GridView_Room, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabRoomSummary Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, GridView_Summary, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabPos Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, GridView_POS, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabDiscount Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, GridView_Discount, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabPaymentTransaction Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, GridView_Payment, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabFolioAudittrail Then
            GenerateGuestFolioTransaction(foliono.Text, XtraTabControl1.SelectedTabPage.Text, grid_auditTrail, Me)
        End If
    End Sub

#Region "G U E S T "

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdPickGuest.LinkClicked
        PickGuest()
    End Sub
    Public Sub PickGuest()
        frmHotelPickGuest.mode.Text = "checkin2"
        If frmHotelPickGuest.Visible = False Then
            frmHotelPickGuest.Show(Me)
        Else
            frmHotelPickGuest.WindowState = FormWindowState.Normal
        End If
    End Sub

    Public Sub showGuestInfo()
        Dim ratingsid As String = ""
        com.CommandText = "select *,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtGuest.Text = rst("fullname").ToString
            txtCountry.Text = rst("country").ToString
            txtAddress.Text = rst("address").ToString
            txtBirthdate.Text = rst("birthdate").ToString
            txtGender.Text = rst("gender").ToString
            txtNationality.Text = rst("nationality").ToString
            txtContactNumber.Text = rst("contactnumber").ToString
            txtEmail.Text = rst("emailadd").ToString
            txtGuestPreferences.Text = rst("guestpreferences").ToString
            ratingsid = rst("ratings").ToString
        End While
        rst.Close()

        If ratingsid.Length > 0 Then
            com.CommandText = "select * from tblhotelguestratings where code='" & ratingsid & "'" : rst = com.ExecuteReader
            While rst.Read
                txtRatings.Text = rst("ratingsname").ToString
                ChangeColor(txtRatings, rst("colorback").ToString, rst("colorfont").ToString)
            End While
            rst.Close()
        Else
            txtRatings.Text = "UNRATED LEVEL"
            txtRatings.ForeColor = DefaultForeColor
            txtRatings.BackColor = DefaultBackColor
        End If
        
        txtDateArival.Focus()
        cmdEditGuest.Visible = True
        cmdPreviousTransaction.Visible = True

    End Sub

    Public Sub ChangeColor(ByVal lbl As Label, ByVal backcolor As String, ByVal fontcolor As String)
        Dim RGBback As String() = backcolor.Split(",")
        Dim RGBfont As String() = fontcolor.Split(",")

        If backcolor.Length > 0 Then
            lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGBback(0)), Byte), Integer), CType(CType(Val(RGBback(1)), Byte), Integer), CType(CType(Val(RGBback(2)), Byte), Integer))
            lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGBfont(0)), Byte), Integer), CType(CType(Val(RGBfont(1)), Byte), Integer), CType(CType(Val(RGBfont(2)), Byte), Integer))
        Else
            lbl.BackColor = DefaultBackColor : lbl.ForeColor = DefaultForeColor
        End If

    End Sub

#End Region

#Region "R O O M"
    Public Sub FilterRoom()
        dst2.EnforceConstraints = False : dst2.Relations.Clear() : dst2.Clear()
        LoadXgrid("select concat(foliono,folioid) as TrnCode,inhouse,checkout,closed, folioid,roomtype,rateid, roomid, if(cancelled=1,'Cancelled', " _
                                        + " if(closed=1,'Closed', if(checkout=1,'Checked-Out',if(inhouse=1,if(departure=current_date,'Check-Out Today',if(departure<current_date,'Forgot Check-Out','Checked-In')),if(arival<current_date,'No Show','-')))))  as 'Status', " _
                                        + If(ckClose.Checked = True Or cancelled.Checked = True, "", "  (select if(roomstatus='','-', roomstatus) from tblhotelrooms where roomid=tblhotelfolioroom.roomid) as 'Room Status', ") _
                                        + " date_format(arival,'%Y-%m-%d') as 'Arival', " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " roomno as 'Room No.', description as 'Room Type', " _
                                        + " (select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid) as 'Current Package', " _
                                        + " ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid order by dayno desc limit 1 ),0)  as 'Current Rate', " _
                                        + " if(chargepernight=1,'Per Night','Per Pax') as 'Charge Type'," _
                                        + " Pax as Adult, Child,extra as 'Extra Person', Pax+extra as 'Total Pax', " _
                                        + " datediff(departure,arival) as 'No. Day', " _
                                        + " ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0) as 'RoomCharges', " _
                                        + " ifnull((select sum(debit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and chargefrompos=1 and cancelled=0 and appliedcoupon=0),0) as 'POS Charges', " _
                                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and discount=1 and cancelled=0),0) as 'Discount', " _
                                        + " ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and paymenttrn=1 and cancelled=0),0) as 'Payment', " _
                                        + " (ifnull((select sum(total) from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid),0)+ifnull((select sum(debit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and chargefrompos=1 and cancelled=0 and appliedcoupon=0),0)) - (ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and paymenttrn=1 and cancelled=0),0)+ifnull((select sum(credit) from tblhotelfoliotransaction where folioid=tblhotelfolioroom.folioid and discount=1 and cancelled=0),0)) as 'BalanceDue', " _
                                        + " (select companyname from tblclientaccounts where cifid=tblhotelfolioroom.hotelcif) as Hotel from tblhotelfolioroom where foliono='" & foliono.Text & "' " & If(cancelled.Checked = True, "", "and cancelled=0 ") & " order by arival asc,description asc, roomno asc", "tblhotelfolioroom", Em, GridView_Room)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst2, "tblhotelfolioroom")

        Dim CurrencyDetails As Array = {"RoomCharges", "POS Charges", "Discount", "Payment", "BalanceDue"}
        XgridHideColumn({"TrnCode", "folioid", "roomtype", "rateid", "roomid", "inhouse", "checkout", "closed"}, GridView_Room)
        XgridColCurrency({"Current Rate"}, GridView_Room)
        XgridColCurrency(CurrencyDetails, GridView_Room)
        XgridColAlign({"Status", "Room Status", "Room No.", "Arival", "Departure", "No. Day", "Adult", "Child", "Extra Person", "Total Pax", "Charge Type"}, GridView_Room, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency(CurrencyDetails, GridView_Room)
        XgridGroupSummaryCurrency(CurrencyDetails, GridView_Room)
        XgridGeneralSummaryNumber({"Adult", "Child", "Extra Person", "Total Pax"}, GridView_Room)
        XgridColWidth({"Status"}, GridView_Room, 130)
        XgridColWidth(CurrencyDetails, GridView_Room, 90)

        msda = New MySqlDataAdapter("SELECT concat(foliono,folioid) as TrnCode, date_format(datetrn,'%Y-%m-%d')  as Date, Adult, (select description from tblhotelroomrates where ratecode=tblhotelfolioroomsummary.rateid) as 'Package',  AdultRate as 'RoomRate',Child,ChildRate,Extra as 'ExtraPerson',extraRate as 'ExtraPersonRate',Total FROM `tblhotelfolioroomsummary` where foliono='" & foliono.Text & "' ", conn)
        msda.Fill(dst2, "tblhotelfolioroomsummary")

        BandgridView = New GridView(Em)
        Dim keyColumn As DataColumn = dst2.Tables("tblhotelfolioroom").Columns("TrnCode")
        Dim foreignKeyColumn2 As DataColumn = dst2.Tables("tblhotelfolioroomsummary").Columns("TrnCode")

        dst2.Relations.Add("RoomDetails", keyColumn, foreignKeyColumn2)
        Em.LevelTree.Nodes.Add("RoomDetails", BandgridView)

        Em.DataSource = dst2.Tables("tblhotelfolioroom")

        '############## Band Gridview #####################
        BandgridView.PopulateColumns(dst2.Tables("tblhotelfolioroomsummary"))
        BandgridView.BestFitColumns(True)

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
        If ckClose.Checked = False And cancelled.Checked = False Then
            If e.Column.Name = "colRoomStatus" Then
                Dim roomstatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Room Status"))
                If roomstatus = Globalhoteldefaultvacantstatuscode Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.ForeColor = Color.Black
                Else
                    e.Appearance.BackColor = BackColor
                    e.Appearance.ForeColor = ForeColor
                End If
            End If
        End If

    End Sub

    Private Sub cmdAddNewRoom_Click(sender As Object, e As EventArgs) Handles cmdAddNewRoom.Click
        If CheckSecuritySaveInfo() = True Then
            frmHotelPackageSelection.guestid.Text = guestid.Text
            frmHotelPackageSelection.foliono.Text = foliono.Text
            If frmHotelPackageSelection.Visible = True Then
                frmHotelPackageSelection.Focus()
            Else
                frmHotelPackageSelection.Show(Me)
            End If
        End If
       
    End Sub

    Private Sub cmdRoomAdd_Click(sender As Object, e As EventArgs) Handles cmdRoomAdd.Click
        If GridView_Room.RowCount = 0 Then
            MessageBox.Show("There's no selected room to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckSecuritySaveInfo() = True Then
            frmHotelPickMultipleRoom.guestid.Text = guestid.Text
            frmHotelPickMultipleRoom.foliono.Text = foliono.Text
            If GridView_Room.RowCount = 0 Then
                frmHotelPickMultipleRoom.txtDateArival.Value = txtDateArival.Value
                frmHotelPickMultipleRoom.txtdateCheckout.Value = txtDeparture.Value
            Else
                frmHotelPickMultipleRoom.roomtype.Text = GridView_Room.GetFocusedRowCellValue("roomtype").ToString
                frmHotelPickMultipleRoom.txtRoomType.Text = GridView_Room.GetFocusedRowCellValue("Room Type").ToString
                frmHotelPickMultipleRoom.txtDateArival.Value = CDate(GridView_Room.GetFocusedRowCellValue("Arival").ToString)
                frmHotelPickMultipleRoom.txtdateCheckout.Value = CDate(GridView_Room.GetFocusedRowCellValue("Departure").ToString)
            End If

            If countqry("tblhotelroomrates", "ratecode='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "' and temporaryrate=1 and bookingno='" & foliono.Text & "'") = 0 Then
                Dim rateid As String = qrysingledata("newratecode", "ratecode+1 as newratecode", "tblhotelroomrates order by ratecode desc limit 1")

                com.CommandText = "INSERT INTO tblhotelroomrates set ratecode='" & rateid & "', roomtype='" & GridView_Room.GetFocusedRowCellValue("roomtype").ToString & "',description='" & rchar(GridView_Room.GetFocusedRowCellValue("Current Package").ToString) & "',allowzerorate=0,actived=1,lockrate=0,temporaryrate=1,originrate='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "', onlinerate=0,packagedetails='',bookingno='" & foliono.Text & "', addedby='" & globaluserid & "'" : com.ExecuteNonQuery()
                com.CommandText = "INSERT INTO tblhotelratesbreakdown (roomtype,ratecode,dayrate,breakdowntype,itemcode,itemname,amount) " _
                                       + " SELECT '" & GridView_Room.GetFocusedRowCellValue("roomtype").ToString & "','" & rateid & "',dayrate,breakdowntype,itemcode,itemname,amount FROM tblhotelratesbreakdown where ratecode='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "'" : com.ExecuteNonQuery()

                com.CommandText = "update tblhotelfolioroom set rateid='" & rateid & "' where foliono='" & foliono.Text & "' and roomtype='" & GridView_Room.GetFocusedRowCellValue("roomtype").ToString & "' and rateid='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "' " : com.ExecuteNonQuery()

                com.CommandText = "update tblhotelfolioroombreakdown set ratecode='" & rateid & "' where foliono='" & foliono.Text & "' and ratecode='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "' " : com.ExecuteNonQuery()
                com.CommandText = "update tblhotelfolioroomsummary set rateid='" & rateid & "' where foliono='" & foliono.Text & "' and rateid='" & GridView_Room.GetFocusedRowCellValue("rateid").ToString & "' " : com.ExecuteNonQuery()

            End If

            If frmHotelPickMultipleRoom.Visible = True Then
                frmHotelPickMultipleRoom.Focus()
            Else
                frmHotelPickMultipleRoom.ShowDialog(Me)
            End If
            FilterRoom()
        End If
    End Sub

    Private Sub cmdViewRoomInfo_Click(sender As Object, e As EventArgs) Handles cmdViewRoomInfo.Click
        frmHotelFolioRoomInfo.foliono.Text = foliono.Text
        frmHotelFolioRoomInfo.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelFolioRoomInfo.grpRoomDetails.Text = GridView_Room.GetFocusedRowCellValue("Room No.").ToString & " - " & GridView_Room.GetFocusedRowCellValue("Room Type").ToString
        If frmHotelFolioRoomInfo.Visible = True Then
            frmHotelFolioRoomInfo.Focus()
        Else
            frmHotelFolioRoomInfo.ShowDialog(Me)
        End If
    End Sub

    Private Sub cmdDiscount_Click(sender As Object, e As EventArgs) Handles cmdDiscount.Click
        If GridView_Room.GetFocusedRowCellValue("Room No.").ToString = "" Then
            MessageBox.Show("Please update room number to continue discount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmHotelDiscount.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelDiscount.txtRoomNo.Text = GridView_Room.GetFocusedRowCellValue("Room No.").ToString
        frmHotelDiscount.Show(Me)
    End Sub

    Private Sub cmdRoomRemove_Click(sender As Object, e As EventArgs) Handles cmdRoomRemove.Click
        Dim overideby As String = ""
        If CBool(GridView_Room.GetFocusedRowCellValue("inhouse").ToString) = True Then
            If countqry("tblhotelfoliotransaction", "folioid='" & GridView_Room.GetFocusedRowCellValue("folioid").ToString & "' and cancelled=0") > 0 Then
                If MessageBox.Show("Room cannot remove! system found current room folio has charge to room transaction" & Environment.NewLine & Environment.NewLine & "Do you want to review folio statement of account?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    ViewRoomStatementToolStripMenuItem.PerformClick()
                End If
                Exit Sub
            End If
            MessageBox.Show("You are about to perform removing already checked-in room! this required an administrative for approval", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                overideby = frmPOSAdminConfirmation.userid.Text
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
        Dim ContainsPayment As Boolean = False
        If countqry("tblhotelfoliotransaction", "folioid='" & GridView_Room.GetFocusedRowCellValue("folioid").ToString & "' and cancelled=0 and paymenttrn=1") > 0 Then
            ContainsPayment = True
        End If
        If MessageBox.Show(If(ContainsPayment = True, "This room has contain a payment transaction! if you continue remove this room, payment for this room will automatically tag as main folio payment." & Environment.NewLine & Environment.NewLine, "") & "Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            SplashScreenManager.ShowForm(GetType(WaitForm1), True, True)
            If CBool(GridView_Room.GetFocusedRowCellValue("inhouse").ToString) = True Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Removed room " & GetRoomFolioInfo(GridView_Room.GetFocusedRowCellValue("folioid").ToString, "roomno") & " overide by " & GetUserinfo(overideby, "fullname"))
            Else
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Removed room " & GetRoomFolioInfo(GridView_Room.GetFocusedRowCellValue("folioid").ToString, "roomno"))
            End If
            com.CommandText = "delete from tblhotelfolioroom where folioid='" & GridView_Room.GetFocusedRowCellValue("folioid").ToString & "'" : com.ExecuteNonQuery()
            UpdateFolioSummary(foliono.Text)
            SplashScreenManager.CloseForm()
            If ContainsPayment = True Then
                com.CommandText = "update tblhotelfoliotransaction set folioid='', roomid='', roomno='' where folioid='" & GridView_Room.GetFocusedRowCellValue("folioid").ToString & "' " : com.ExecuteNonQuery()
            End If
            LoadFolioInfo()
        End If
    End Sub

    Private Sub ProceedCheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdProceedCheckin.Click
        Dim noRoomAssigned As Boolean = False
        Dim roomNotReady As Boolean = False
        For I = 0 To GridView_Room.SelectedRowsCount - 1
            If GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "roomid") = "" Then
                noRoomAssigned = True
            End If
        Next

        For I = 0 To GridView_Room.SelectedRowsCount - 1
            If GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room Status") <> Globalhoteldefaultvacantstatuscode Then
                roomNotReady = True
            End If
        Next
        If noRoomAssigned = True Then
            MessageBox.Show("Please update room number to continue checkin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If roomNotReady = True Then
            MessageBox.Show("Some room you selected are not available! Please contact your housekeeping to unlock room", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView_Room.SelectedRowsCount - 1
                If CBool(GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "inhouse")) = False Then
                    LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Proceed check-in room " & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room No."))
                    com.CommandText = "update tblhotelfolioroom set inhouse=1,timecheckin=current_time where folioid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & "'" : com.ExecuteNonQuery()
                    com.CommandText = "update tblhotelrooms set currentfolio='" & foliono.Text & "', occupied=1,roomstatus='" & Globalhoteldefaultcheckinstatuscode & "',remarks='OCCUPIED' where roomid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "roomid") & "'" : com.ExecuteNonQuery()
                End If
            Next
            LoadFolioInfo()
            MessageBox.Show("Selected room successfull updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub cmdCheckout_Click(sender As Object, e As EventArgs) Handles cmdCheckout.Click
        If MessageBox.Show("Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView_Room.SelectedRowsCount - 1
                If CDate(Now.ToShortDateString) < CDate(GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Departure")) Then
                    MessageBox.Show("You are about to perform early guest checkout for room " & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room No.") & "! this required an administrative for approval", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    frmPOSAdminConfirmation.ShowDialog(Me)
                    If frmPOSAdminConfirmation.ApprovedConfirmation = True Then

                        frmPOSAdminConfirmation.ApprovedConfirmation = False
                        frmPOSAdminConfirmation.Dispose()
                    Else
                        Exit Sub
                    End If
                End If
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Proceed check-checkout room " & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room No."))
                com.CommandText = "update tblhotelfolioroom set checkout=1 ,timecheckout=current_time where folioid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblhotelrooms set currentfolio='', occupied=0, maintainance=1, roomstatus='" & Globalhotelmaintainancedefaultstatus & "',remarks='CHECK OUT' where roomid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "roomid") & "'" : com.ExecuteNonQuery()
                PrintCheckoutSlip(GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid"))
            Next
            LoadFolioInfo()
            MessageBox.Show("Selected room successfull checkout!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdRoomRefresh_Click(sender As Object, e As EventArgs) Handles cmdRoomRefresh.Click
        LoadFolioInfo()
    End Sub

    Private Sub GridView_Room_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Room.FocusedRowChanged
        If GridView_Room.RowCount = 0 Then Exit Sub
        If CBool(GridView_Room.GetFocusedRowCellValue("checkout").ToString) = True Then
            cmdCheckout.Visible = False
            cmdRoomRemove.Visible = False
            If HotelOperationMode = True Then
                cmdRestoreUncheckOut.Visible = True
            End If
        Else
            If HotelOperationMode = True Then
                cmdCheckout.Visible = True
                cmdRoomRemove.Visible = True
            End If
            cmdRestoreUncheckOut.Visible = False
        End If

        If CBool(GridView_Room.GetFocusedRowCellValue("inhouse").ToString) = True Then
            cmdProceedCheckin.Visible = False
            'cmdRoomRemove.Visible = False
        Else
            If HotelOperationMode = True Then
                cmdProceedCheckin.Visible = True
            End If
            cmdCheckout.Visible = False
            'cmdRoomRemove.Visible = True
        End If
    End Sub

    Private Sub cmdMergePayment_Click(sender As Object, e As EventArgs) Handles cmdMergePayment.Click
        If GridView_Room.SelectedRowsCount > 1 Then
            If MessageBox.Show("You are about to merge payment for multiple folio transaction! Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim SelectedFolio As String = "" : Dim SelectedBalance As Double = 0
                For I = 0 To GridView_Room.SelectedRowsCount - 1
                    SelectedFolio += GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & ","
                    SelectedBalance += Val(CC(GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "BalanceDue")))

                    frmHotelPaymentPosting.folioid.Text = SelectedFolio.Remove(SelectedFolio.Length - 1, 1)
                    frmHotelPaymentPosting.txtAmountTender.Text = FormatNumber(SelectedBalance, 2)
                    frmHotelPaymentPosting.ckMultiple.Checked = True
                    If frmHotelPaymentPosting.Visible = False Then
                        frmHotelPaymentPosting.Show(Me)
                    Else
                        frmHotelPaymentPosting.WindowState = FormWindowState.Normal
                    End If
                Next
            End If
        Else
            frmHotelPaymentPosting.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
            frmHotelPaymentPosting.txtAmountTender.Text = FormatNumber(GridView_Room.GetFocusedRowCellValue("BalanceDue").ToString, 2)
            frmHotelPaymentPosting.ckMultiple.Checked = False
            If frmHotelPaymentPosting.Visible = False Then
                frmHotelPaymentPosting.Show(Me)
            Else
                frmHotelPaymentPosting.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub

    Private Sub cmdRoomAddCompanion_Click(sender As Object, e As EventArgs) Handles cmdRoomAddCompanion.Click
        frmHotelGuestCompanion.foliono.Text = foliono.Text
        frmHotelGuestCompanion.LoadRoom()
        frmHotelGuestCompanion.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelGuestCompanion.txtRoomNo.Text = GridView_Room.GetFocusedRowCellValue("Room No.").ToString
        frmHotelGuestCompanion.Show(Me)
    End Sub

    Private Sub ViewRoomStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRoomStatementToolStripMenuItem.Click
        frmHotelRoomStatementLedger.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelRoomStatementLedger.Show(Me)
    End Sub
#End Region

#Region "R O O M  S U M M A R Y"
    Public Sub FilterRoomSummary()
        LoadXgrid("SELECT date_format(datetrn,'%Y-%m-%d') as Date, roomdesc as 'Room Type',count(*) as 'Room(s)', sum(adult+extra) as Pax,sum(total) as Total,(select companyname from tblclientaccounts where cifid=tblhotelfolioroomsummary.hotelcif) as Hotel FROM `tblhotelfolioroomsummary` where foliono='" & foliono.Text & "' group by datetrn,roomdesc asc", "tblhotelfolioroomsummary", Em_Summary, GridView_Summary)

        XgridColCurrency({"Total"}, GridView_Summary)
        XgridColAlign({"Date", "Day", "Room(s)", "Pax"}, GridView_Summary, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Total"}, GridView_Summary)
        XgridGroupSummaryCurrency({"Total"}, GridView_Summary)
        XgridGeneralSummaryNumber({"Room(s)", "Pax"}, GridView_Summary)
        XgridColWidth({"Total"}, GridView_Summary, 140)

    End Sub

#End Region

#Region "C O M P A N I O N"
    Public Sub FilterCompanion()
        LoadXgrid("select id,(select roomno from tblhotelfolioroom where folioid=tblhotelguestcompanion.folioid) as 'Room No.', Fullname, Age from tblhotelguestcompanion where bookno='" & foliono.Text & "'", "tblhotelguestcompanion", Em_Companion, GridView_Companion)
        XgridHideColumn({"id"}, GridView_Companion)
        XgridColAlign({"Age", "Room No."}, GridView_Companion, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Age"}, GridView_Companion, 60)
    End Sub
    Private Sub cmdAddCompanion_Click(sender As Object, e As EventArgs) Handles cmdAddCompanion.Click
        frmHotelGuestCompanion.foliono.Text = foliono.Text
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub cmdEditCompanion_Click(sender As Object, e As EventArgs) Handles cmdEditCompanion.Click
        frmHotelGuestCompanion.foliono.Text = foliono.Text
        frmHotelGuestCompanion.id.Text = GridView_Companion.GetFocusedRowCellValue("id").ToString
        frmHotelGuestCompanion.mode.Text = "edit"
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub cmdRemoveCompanion_Click(sender As Object, e As EventArgs) Handles cmdRemoveCompanion.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Removed companion " & GridView_Companion.GetFocusedRowCellValue("Fullname").ToString)
            com.CommandText = "DELETE from tblhotelguestcompanion where id='" & GridView_Companion.GetFocusedRowCellValue("id").ToString & "'" : com.ExecuteNonQuery()
            FilterCompanion()
        End If
    End Sub
    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        FilterCompanion()
    End Sub
#End Region

#Region "D I S C O U N T"
    Public Sub FilterRoomDiscount()
        LoadXgrid("select trnid,referenceno, datetrn as 'Date Posted',if(roomno='','-',roomno) as 'DiscountForRoom',credit as Amount,Remarks, (select if(nickname='',fullname,ucase(nickname)) from tblaccounts where accountid=tblhotelfoliotransaction.trnby) as 'Transaction By',(select if(nickname='',fullname,ucase(nickname)) from tblaccounts where accountid=tblhotelfoliotransaction.discountoverideby) as 'Overide By'  from tblhotelfoliotransaction where foliono='" & foliono.Text & "' and discount=1 and cancelled=0 order by datetrn asc", "tblhotelfoliotransaction", Em_Discount, GridView_Discount)
        XgridHideColumn({"trnid", "referenceno"}, GridView_Discount)
        XgridColCurrency({"Amount"}, GridView_Discount)
        XgridColAlign({"Date Posted", "DiscountForRoom", "Transaction By"}, GridView_Discount, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Discount)
        XgridColWidth({"Amount"}, GridView_Discount, 140)
    End Sub

    Private Sub cmdRefreshDiscount_Click(sender As Object, e As EventArgs) Handles cmdRefreshDiscount.Click
        FilterRoomDiscount()
    End Sub
    Private Sub cmdEditDiscount_Click(sender As Object, e As EventArgs) Handles cmdEditDiscount.Click
        frmHotelDiscount.trnid.Text = GridView_Discount.GetFocusedRowCellValue("trnid").ToString
        frmHotelDiscount.mode.Text = "edit"
        frmHotelDiscount.Show(Me)
    End Sub

    Private Sub cmdRemoveDiscount_Click(sender As Object, e As EventArgs) Handles cmdRemoveDiscount.Click
        If MessageBox.Show("Cancelling transaction needs an administrative approval. Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Removed discount with amount of " & GridView_Discount.GetFocusedRowCellValue("Amount").ToString & ", overide by " & GetUserinfo(frmPOSAdminConfirmation.userid.Text, "fullname"))
                CancelPaymentTransaction(GridView_Discount.GetFocusedRowCellValue("referenceno").ToString)
                com.CommandText = "UPDATE tblhotelfoliotransaction set cancelled=1,datecancelled=current_timestamp,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "' where trnid='" & GridView_Discount.GetFocusedRowCellValue("trnid").ToString & "'" : com.ExecuteNonQuery()
                LoadFolioInfo()
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region " P A Y M E N T"
    Public Sub FilterPaymentDeposit()
        LoadXgrid("select trnid,referenceno,foliono, datetrn as 'Date Posted',if(roomno='','-',roomno) as 'PaymentForRoom', Remarks, credit as Amount,concat('#',referenceno) as 'Reference', ornumber as 'OR Number', (select if(nickname='',fullname,ucase(nickname)) from tblaccounts where accountid=tblhotelfoliotransaction.trnby) as 'Transaction By'  from tblhotelfoliotransaction where foliono='" & foliono.Text & "' and paymenttrn=1 and cancelled=0 order by datetrn asc", "tblhotelfoliotransaction", Em_Payment, GridView_Payment)
        XgridHideColumn({"trnid", "referenceno", "foliono"}, GridView_Payment)
        XgridColCurrency({"Amount"}, GridView_Payment)
        XgridColAlign({"Date Posted", "Reference", "PaymentForRoom", "OR Number", "Transaction By"}, GridView_Payment, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_Payment)
        XgridColWidth({"Amount"}, GridView_Payment, 140)
    End Sub

    Private Sub cmdAddnnewDeposit_Click(sender As Object, e As EventArgs) Handles cmdAddnnewDeposit.Click
        frmHotelPaymentPosting.folioid.Text = foliono.Text
        frmHotelPaymentPosting.txtAmountTender.Text = txtBalanceDue.Text
        frmHotelPaymentPosting.ckMainFolio.Checked = True
        frmHotelPaymentPosting.Show(Me)
    End Sub

    Private Sub cmdRefreshDeposit_Click(sender As Object, e As EventArgs) Handles cmdRefreshDeposit.Click
        FilterPaymentDeposit()
    End Sub
    Private Sub cmdEditDeposit_Click(sender As Object, e As EventArgs) Handles cmdEditDeposit.Click
        frmHotelPaymentUpdate.trnid.Text = GridView_Payment.GetFocusedRowCellValue("trnid").ToString
        frmHotelPaymentUpdate.Show(Me)
    End Sub

    Private Sub cmdRemoveDeposit_Click(sender As Object, e As EventArgs) Handles cmdRemoveDeposit.Click
        If MessageBox.Show("Cancelling transaction needs an administrative approval. Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                For I = 0 To GridView_Payment.SelectedRowsCount - 1
                    LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Payment removed with reference no. " & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "referenceno").ToString & " total amount of " & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "Amount").ToString & ", overide by " & GetUserinfo(frmPOSAdminConfirmation.userid.Text, "fullname"))
                    CancelPaymentTransaction(GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "referenceno").ToString)
                    com.CommandText = "UPDATE tblhotelfoliotransaction set cancelled=1,datecancelled=current_timestamp,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "' where trnid='" & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "trnid").ToString & "'" : com.ExecuteNonQuery()
                    If GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "foliono").ToString <> "" Then
                        If countqry("tblhotelfoliotransaction", "trnid='" & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "trnid").ToString & "' and offsetpayment=1") > 0 Then
                            com.CommandText = "UPDATE tblsalesclientcharges set cancelled=1,datecancelled=current_timestamp,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "' where invoiceno='" & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "foliono").ToString & "' and foliocharge=1" : com.ExecuteNonQuery()
                            com.CommandText = "UPDATE tblglaccountledger set cancelled=1,datecancelled=current_timestamp,cancelledby='" & frmPOSAdminConfirmation.userid.Text & "' where referenceno='" & GridView_Payment.GetRowCellValue(GridView_Payment.GetSelectedRows(I), "foliono").ToString & "'" : com.ExecuteNonQuery()
                        End If
                    End If
                Next
                LoadFolioInfo()
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "P O S   T R A N S A C T I O N"
    Public Sub FilterPOStransaction()
        LoadXgrid("select datetrn as 'Date Posted',(select officename from tblcompoffice where officeid=tblhotelfoliotransaction.officeid) as 'Charge From', roomno as ChargeToRoom,concat('#',referenceno) as 'Reference',if(appliedcoupon=1,concat(Remarks,' (Complimentary)'),Remarks) as Remarks , debit as Amount, (select if(nickname='',fullname,ucase(nickname)) from tblaccounts where accountid=tblhotelfoliotransaction.trnby) as 'Transaction By'  from tblhotelfoliotransaction where foliono='" & foliono.Text & "' and chargefrompos=1 and cancelled=0 order by datetrn asc", "tblhotelfoliotransaction", Em_POS, GridView_POS)
        XgridColCurrency({"Amount"}, GridView_POS)
        XgridColAlign({"Date Posted", "Reference", "ChargeToRoom", "Transaction By"}, GridView_POS, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_POS)
        XgridGroupSummaryCurrency({"Amount"}, GridView_POS)
        XgridColWidth({"Amount"}, GridView_POS, 120)
    End Sub
   
#End Region

#Region "P O S  C A S H  T R A N S A C T I O N"
    Public Sub FilterCASHtransaction()
        LoadXgrid("select datetrn as 'Date Posted',(select officename from tblcompoffice where officeid=tblhotelcashtransaction.officeid) as 'Transaction From', roomno as 'Room Number',concat('#',batchcode) as 'Transaction No.', guestcheckno as 'Guest Check No.', Remarks , Amount, (select if(nickname='',fullname,ucase(nickname)) from tblaccounts where accountid=tblhotelcashtransaction.trnby) as 'Transaction By'  from tblhotelcashtransaction where foliono='" & foliono.Text & "' order by datetrn asc", "tblhotelcashtransaction", Em_Cash, GridView_cash)
        XgridColCurrency({"Amount"}, GridView_cash)
        XgridColAlign({"Date Posted", "Reference", "Room Number", "Guest Check No.", "Transaction By"}, GridView_cash, DevExpress.Utils.HorzAlignment.Center)
        XgridGeneralSummaryCurrency({"Amount"}, GridView_cash)
        XgridGroupSummaryCurrency({"Amount"}, GridView_cash)
        XgridColWidth({"Amount"}, GridView_cash, 120)
    End Sub

#End Region

#Region "A U D I T  T R A I L "
    Public Sub FilterFolioAuditTrail()
        LoadXgrid("select trntype as 'Transaction By',remarks as 'Action Taken',date_format(datetrn,'%Y-%m-%d %r') as 'Date Taken',trnby as 'Action Taken By' from tblaudittrail where trncode='HOTEL' and referenceno='" & foliono.Text & "' order by datetrn asc", "tblaudittrail", Em_audittrail, grid_auditTrail)
        XgridColAlign({"Transaction By", "Date Taken"}, grid_auditTrail, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Action Taken"}, grid_auditTrail, 500)
        XgridColMemo({"Action Taken"}, grid_auditTrail)
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FilterFolioAuditTrail()
    End Sub
#End Region


    Public Sub LoadAgent()
        LoadToComboBoxDB("select * from tblhotelagent order by agentname asc", "agentname", "code", txtAgent)
    End Sub
    Private Sub cmdTypeofAgent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdTypeofAgent.LinkClicked
        frmHotelAgent.ShowDialog(Me)
        LoadAgent()
    End Sub

    Private Sub txtAgent_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAgent.SelectedValueChanged
        If txtAgent.Text = "" Then Exit Sub
        agentid.Text = DirectCast(txtAgent.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub

    Public Sub LoadAgentTypeofGuest()
        LoadToComboBoxDB("select * from tblhotelguesttype order by description asc", "description", "code", txtGuestType)
    End Sub
    Private Sub cmdTypeofGuest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdTypeofGuest.LinkClicked
        frmHotelTypeOfGuest.ShowDialog(Me)
        LoadAgentTypeofGuest()
    End Sub
    Private Sub txtGuestType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGuestType.SelectedValueChanged
        If txtGuestType.Text = "" Then Exit Sub
        guestType.Text = DirectCast(txtGuestType.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdEditGuest_Click(sender As Object, e As EventArgs) Handles cmdEditGuest.Click
        frmHotelGuestInfo.mode.Text = "edit"
        frmHotelGuestInfo.guestid.Text = guestid.Text
        If frmHotelGuestInfo.Visible = False Then
            frmHotelGuestInfo.ShowDialog(Me)
        Else
            frmHotelGuestInfo.WindowState = FormWindowState.Normal
        End If
        showGuestInfo()
    End Sub


    Private Sub cmdPayment_Click(sender As Object, e As EventArgs) Handles cmdPayment.Click
        cmdAddnnewDeposit.PerformClick()
    End Sub

    Private Sub cmdSaveFolio_Click(sender As Object, e As EventArgs) Handles cmdSaveFolio.Click
        If CheckSecuritySaveInfo() = True Then
            If HotelOperationMode = True Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Check-in new guest")
                SaveFolioInfo(", walkin=1, inhouse=1 ")
            Else
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Reserved new guest")
                SaveFolioInfo(", reservation=1, datereservation=current_timestamp, confirmedreservation=0,dateconfirmedreservation=null ")
            End If
        End If
    End Sub

    Public Function CheckSecuritySaveInfo() As Boolean
        If txtGuest.Text = "" Then
            MessageBox.Show("Please select guest!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuest.Focus()
            Return False
        ElseIf txtGuestType.Text = "" Then
            MessageBox.Show("Please select guest type!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuestType.Focus()
            Return False
        ElseIf CDate(txtDateArival.Value) >= CDate(txtDeparture.Value) Then
            MessageBox.Show("Please select arrival date beyond departure date!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDateArival.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub SaveFolioInfo(ByVal parameter As String)
        Dim details As String = ""
        details = " guesttype='" & guestType.Text & "', " _
                        + " foliono='" & foliono.Text & "', " _
                        + " guestid='" & guestid.Text & "', " _
                        + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
                        + " departure='" & ConvertDate(txtDeparture.Value) & "', " _
                        + " platenumber='" & rchar(txtPlateNumber.Text) & "', " _
                        + " incidental=0, " _
                        + " agentcode='" & agentid.Text & "', " _
                        + " flight='" & rchar(txtFlight.Text) & "', " _
                        + " remarks='" & rchar(txtRemarks.Text) & "' " & parameter
        If countqry("tblhotelfolioguest", "foliono='" & foliono.Text & "'") = 0 Then
            com.CommandText = "insert into tblhotelfolioguest set " & details & ",  trnby='" & globaluserid & "', datetrn=current_timestamp " : com.ExecuteNonQuery()
            LoadFolioInfo()
            MessageBox.Show("Folio Successfully Save", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If ConvertDate(txtDateArival.Value) <> ConvertDate(txtCurrentArrival.Value) Or ConvertDate(txtDeparture.Value) <> ConvertDate(txtCurrentDeparture.Value) Then
                If MessageBox.Show("System found that arrival date or departure date has been changed! System will automatically update all affected room arrival and departure date!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    com.CommandText = "update tblhotelfolioroom set arival='" & ConvertDate(txtDateArival.Value) & "',departure='" & ConvertDate(txtDeparture.Value) & "' where foliono='" & foliono.Text & "' and cancelled=0" : com.ExecuteNonQuery()
                    com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
                    UpdateFolioSummary(foliono.Text)
                    FilterRoom()
                Else
                    com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp  where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
                End If
            Else
                com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp  where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
            End If
            MessageBox.Show("Folio Successfully Save", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



        'Dim details As String = ""
        'details = " guesttype='" & guestType.Text & "', " _
        '                + " foliono='" & foliono.Text & "', " _
        '                + " guestid='" & guestid.Text & "', " _
        '                + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
        '                + " departure='" & ConvertDate(txtDeparture.Value) & "', " _
        '                + " platenumber='" & rchar(txtPlateNumber.Text) & "', " _
        '                + " incidental=0, " _
        '                + " agentcode='" & agentid.Text & "', " _
        '                + " flight='" & rchar(txtFlight.Text) & "', " _
        '                + " remarks='" & rchar(txtRemarks.Text) & "' " & parameter
        'If countqry("tblhotelfolioguest", "foliono='" & foliono.Text & "'") = 0 Then
        '    com.CommandText = "insert into tblhotelfolioguest set " & details & ",  trnby='" & globaluserid & "', datetrn=current_timestamp " : com.ExecuteNonQuery()
        'Else
        '    If ConvertDate(txtDateArival.Value) <> ConvertDate(txtCurrentArrival.Value) Or ConvertDate(txtDeparture.Value) <> ConvertDate(txtCurrentDeparture.Value) Then
        '        If countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "' and arival='" & ConvertDate(txtCurrentArrival.Value) & "' and cancelled=0 and inhouse=0") > 0 Or countqry("tblhotelfolioroom", "foliono='" & foliono.Text & "' and departure='" & ConvertDate(txtCurrentDeparture.Value) & "' and cancelled=0 and inhouse=0") > 0 Then
        '            If MessageBox.Show("System found that arrival date or departure date has been changed! System will automatically update all affected room arrival and departure date!" & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
        '                com.CommandText = "update tblhotelfolioroom set arival='" & ConvertDate(txtDateArival.Value) & "' where foliono='" & foliono.Text & "' and arival='" & ConvertDate(txtCurrentArrival.Value) & "' and cancelled=0 and inhouse=0" : com.ExecuteNonQuery()
        '                com.CommandText = "update tblhotelfolioroom set departure='" & ConvertDate(txtDeparture.Value) & "' where foliono='" & foliono.Text & "' and departure='" & ConvertDate(txtCurrentDeparture.Value) & "' and cancelled=0 and inhouse=0" : com.ExecuteNonQuery()
        '                com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
        '                UpdateFolioSummary(foliono.Text)
        '            End If
        '        Else
        '            com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp  where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
        '        End If
        '    Else
        '        com.CommandText = "UPDATE tblhotelfolioguest set " & details & ",  editedby='" & globaluserid & "', dateedited=current_timestamp  where foliono='" & foliono.Text & "'" : com.ExecuteNonQuery()
        '    End If
        'End If
        'LoadFolioInfo()
        'MessageBox.Show("Folio Successfully Save", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdCloseTransaction_Click(sender As Object, e As EventArgs) Handles cmdCloseTransaction.Click
        Dim TotalPOSCash As Double = qrysingledata("amount", "ifnull(sum(amount),0) as amount ", "tblhotelcashtransaction where foliono='" & foliono.Text & "'")
        frmHotelCloseFolio.txtFoliono.Text = foliono.Text
        frmHotelCloseFolio.guestid.Text = guestid.Text
        frmHotelCloseFolio.txtGuestname.Text = txtGuest.Text
        frmHotelCloseFolio.txtTotalTransaction.Text = FormatNumber(Val(CC(txtTotalCharges.Text)) + TotalPOSCash, 2)
        frmHotelCloseFolio.ShowDialog()
    End Sub


    Private Sub cmdConfirmReservation_Click(sender As Object, e As EventArgs) Handles cmdConfirmReservation.Click
        If CheckSecuritySaveInfo() = True Then
            If countqry("tblhotelfolioguest", "foliono='" & foliono.Text & "' and notified=1") = 0 And txtEmail.Text.Length > 5 Then
                If MessageBox.Show("Do you want to send folio email booking confirmation to " & txtEmail.Text & "? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    InsertEmailNotificationClient("FOLIO", txtEmail.Text, "Booking Confirmation", GenerateGuestEmailNotification(foliono.Text, False))
                    LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Confirmed reservation and send email folio notification to guest at " & txtEmail.Text)
                    SaveFolioInfo(",notified=1,reservation=1, datereservation=current_timestamp, confirmedreservation=1,dateconfirmedreservation=current_timestamp ")
                Else
                    LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Confirmed guest reservation")
                    SaveFolioInfo(",reservation=1, datereservation=current_timestamp, confirmedreservation=1,dateconfirmedreservation=current_timestamp ")
                End If
            Else
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Confirmed guest reservation")
                SaveFolioInfo(",reservation=1, datereservation=current_timestamp, confirmedreservation=1,dateconfirmedreservation=current_timestamp ")
            End If
        End If
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        ToolStripSplitButton1.ShowDropDown()
    End Sub

    Private Sub LinkLabel3_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdPreviousTransaction.LinkClicked
        frmHotelGuestPreviousTransaction.guestid.Text = guestid.Text
        frmHotelGuestPreviousTransaction.Show(Me)
    End Sub

    Private Sub cmdChangeRoomChargeType_Click(sender As Object, e As EventArgs) Handles cmdChangeRoomChargeType.Click
        If frmHotelChangeChargeType.Visible = False Then
            frmHotelChangeChargeType.Show(Me)
        Else
            frmHotelChangeChargeType.WindowState = FormWindowState.Normal
        End If
    End Sub
    Public Sub ChangeChargeType(ByVal chargeType As Integer)
        For I = 0 To GridView_Room.SelectedRowsCount - 1
            LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Change charge type " & LCase(chargeType) & " for room " & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room No."))
            com.CommandText = "update tblhotelfolioroom set chargepernight=" & chargeType & " where folioid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblhotelfolioroomsummary set nightcharge=" & chargeType & " where folioid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & "'" : com.ExecuteNonQuery()
        Next
        UpdateFolioSummary(foliono.Text)
        LoadFolioInfo()
        MessageBox.Show("Rooms successfully updated", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Em_Click(sender As Object, e As EventArgs) Handles Em.Click

    End Sub

    Private Sub cmdRoomUpgrade_Click(sender As Object, e As EventArgs) Handles cmdRoomUpgrade.Click
        frmHotelChangeRoom.txtfolioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelChangeRoom.Show(Me)
    End Sub
 

    Private Sub cmdEditRoom_Click(sender As Object, e As EventArgs) Handles cmdEditRoom.Click
        frmHotelEditFolio.txtDateArival.MinDate = txtDateArival.Value
        frmHotelEditFolio.txtDateArival.MaxDate = txtDeparture.Value.AddDays(-1)
        frmHotelEditFolio.txtDeparture.MaxDate = txtDeparture.Value

        frmHotelEditFolio.roomtype.Text = GridView_Room.GetFocusedRowCellValue("roomtype").ToString
        frmHotelEditFolio.folioid.Text = GridView_Room.GetFocusedRowCellValue("folioid").ToString
        frmHotelEditFolio.Show(Me)
    End Sub


    Private Sub cmdChargeToClientAccount_Click(sender As Object, e As EventArgs) Handles cmdChargeToClientAccount.Click
        If MessageBox.Show("Please print guest statement of account for billing attachment! If done click YES", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmHotelChargeAccount.foliono.Text = foliono.Text
            frmHotelChargeAccount.guestid.Text = guestid.Text
            frmHotelChargeAccount.txtAmountTender.Text = txtBalanceDue.Text
            frmHotelChargeAccount.txtRemarks.Text = "Folio#" & foliono.Text & " Date Check-in: " & CDate(txtDateArival.Text).ToString("M/dd/yyyy")
            frmHotelChargeAccount.Show(Me)
        End If
    End Sub

    Private Sub PrintConsolidatedMasterFolioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdConsolidatedMasterFolio.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Print guest master folio")
        GenerateMasterFolio(True, foliono.Text, True, "", Me)
    End Sub

    Private Sub RestoreUncheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRestoreUncheckOut.Click
        MessageBox.Show("You are about to perform restoring checked-out room! this required an administrative for approval", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        frmPOSAdminConfirmation.ShowDialog(Me)
        If frmPOSAdminConfirmation.ApprovedConfirmation = True Then

            frmPOSAdminConfirmation.ApprovedConfirmation = False
            frmPOSAdminConfirmation.Dispose()
        Else
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To GridView_Room.SelectedRowsCount - 1
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Restore uncheck-out room " & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "Room No."))
                com.CommandText = "update tblhotelfolioroom set checkout=0, closed=0, timecheckout=null where folioid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "folioid") & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblhotelrooms set currentfolio='" & foliono.Text & "',occupied=1, maintainance=0, roomstatus='',remarks='' where roomid='" & GridView_Room.GetRowCellValue(GridView_Room.GetSelectedRows(I), "roomid") & "'" : com.ExecuteNonQuery()
            Next
            LoadFolioInfo()
            MessageBox.Show("Selected room successfull restored!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
     
    Private Sub cmdEmailNotification_Click(sender As Object, e As EventArgs) Handles cmdEmailNotification.Click
        frmEmailPreviewNotification.WebBrowser1.DocumentText = GenerateGuestEmailNotification(foliono.Text, True)
        frmEmailPreviewNotification.txtEmail.Text = txtEmail.Text
        frmEmailPreviewNotification.foliono.Text = foliono.Text
        frmEmailPreviewNotification.Show(Me)
    End Sub

    Private Sub txtDateArival_ValueChanged(sender As Object, e As EventArgs) Handles txtDateArival.ValueChanged, txtDeparture.ValueChanged
        txtDeparture.MinDate = txtDateArival.Value.AddDays(1)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage Is tabRoomCharge Or XtraTabControl1.SelectedTabPage Is tabRoomSummary Or XtraTabControl1.SelectedTabPage Is tabPos Or XtraTabControl1.SelectedTabPage Is tabPaymentTransaction Or XtraTabControl1.SelectedTabPage Is tabDiscount Then
            cmdPrintTransaction.Enabled = True
        Else
            cmdPrintTransaction.Enabled = False
        End If

        If XtraTabControl1.SelectedTabPage Is tabFolioAudittrail Then
            FilterFolioAuditTrail()
        End If
    End Sub
 
    Private Sub cmdAttachment_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "View folio attachment")
        ViewAttachmentPackage_Database({foliono.Text}, "HotelFolio")
    End Sub


    

End Class