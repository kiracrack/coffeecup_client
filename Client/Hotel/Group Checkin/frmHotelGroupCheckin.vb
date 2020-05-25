Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text

Public Class frmHotelGroupCheckin
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.F3 Then
            PickGuest()
            Return False
        ElseIf keyData = (Keys.Insert) Then
            If TabControl1.SelectedTab Is tabAddonInfo Then
                cmdAddonAdd.PerformClick()
            End If
        ElseIf keyData = (Keys.Delete) Then
            If TabControl1.SelectedTab Is tabAddonInfo Then
                cmdAddonRemove.PerformClick()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelGroupCheckin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ShowOverallCompleteBookingInfo()
        FilterRoomSummary()
        If MyDataGridView_summary.RowCount = 0 Then
            UpdateFolioSummary(txtBookingNo.Text)
            FilterRoomSummary()
            ShowOverallCompleteBookingInfo()
        End If
    End Sub

    Private Sub frmHotelGroupCheckin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Val(countqry("tblhotelgrouproom", "bookno='" & txtBookingNo.Text & "'")) +
                    Val(countqry("tblhotelgroupaddon", "bookno='" & txtBookingNo.Text & "'")) +
                    Val(countqry("tblhotelroomsdiscounttransaction", "bookingref='" & txtBookingNo.Text & "'")) +
                    Val(countqry("tblhotelroomrates", "bookingno='" & txtBookingNo.Text & "'")) > 0 +
                    Val(countqry("tblhoteltransaction", "bookingref='" & txtBookingNo.Text & "'"))) > 0 And countqry("tblhotelfolio", "bookno='" & txtBookingNo.Text & "'") = 0 Then
            If MessageBox.Show("System found transaction currently not validated! Are you sure you want to cancel current transaction?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "delete from tblhotelgrouproom where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelgroupaddon where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelroomsdiscounttransaction where bookingref='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
                'com.CommandText = "delete from tblhoteltransaction where bookingref='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelratesbreakdown where ratecode in (select ratecode from tblhotelroomrates where bookingno='" & txtBookingNo.Text & "')" : com.ExecuteNonQuery()
                com.CommandText = "delete from tblhotelroomrates where bookingno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If
        End If
        If Val(countqry("tblhotelgrouproom", "bookno='" & txtBookingNo.Text & "'")) And countqry("tblhotelfolio", "bookno='" & txtBookingNo.Text & "'") = 0 Then
            com.CommandText = "delete from tblhotelgrouproom where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
        End If
    End Sub

    Private Sub frmHotelGroupCheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadAgent()

        If trntype.Text = "booking" Then
            txtDateArival.Enabled = True
            groupBooking.Visible = True
            groupCheckin.Visible = False
        Else
            txtDateArival.Enabled = False
            groupBooking.Visible = False
            groupCheckin.Visible = True
        End If
        If mode.Text = "view" Then
            FilterInformation()
            ShowBookingInfo()
            cmdAmend.Visible = True
            cmdEdit.Visible = True
            ' cmdEditGuest.Visible = False
            'groupCheckin.Visible = False
            'groupBooking.Visible = False
        Else
            txtdateCheckout.Value = Format(Now.AddDays(1))
            txtdateCheckout.MinDate = txtDateArival.Value
            txtDateArival.Value = Format(CDate(Now))
            txtDateArival.MinDate = Format(CDate(Now))
            txtBookingNo.Text = LoadBookingNo()
            txtdateCheckout.MinDate = txtDateArival.Value.AddDays(1)
            FilterRoom()
            FilterRoomSummary()
            FilterAddon()
            FilterCompanion()
            FilterPaymentDeposit()
            cmdAmend.Visible = False
            cmdEdit.Visible = False
            cmdEditGuest.Visible = False
        End If


    End Sub
   
  
    Private Sub txtDateArival_ValueChanged(sender As Object, e As EventArgs) Handles txtDateArival.ValueChanged, txtdateCheckout.ValueChanged
        txtdateCheckout.MinDate = txtDateArival.Value.AddDays(1)
    End Sub


#Region "R O O M"
    Public Sub FilterRoom()
        MyDataGridView_room.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select id,folioid,roomtype, if(Confirmed=1,'Checked-In','-') as 'Status',  " _
                                        + " date_format(arival,'%Y-%m-%d') as 'Arival', " _
                                        + " date_format(departure,'%Y-%m-%d') as 'Departure', " _
                                        + " roomno as 'Room No.', description as 'Room Type', " _
                                        + " (select description from tblhotelroomrates where ratecode=tblhotelgrouproom.rateid) as 'Package', " _
                                        + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelgrouproom.rateid and breakdowntype='roomrate' and dayrate=0),0) as 'Package Rate', " _
                                        + " (select allowzerorate from tblhotelroomrates where ratecode=tblhotelgrouproom.rateid) as 'allowzero', " _
                                        + " Pax as Adult, Child,extra as 'Extra Person', " _
                                        + " datediff(departure,arival) as 'No. Days', " _
                                        + " (select companyname from tblclientaccounts where cifid=tblhotelgrouproom.hotelcif) as Hotel, Confirmed from tblhotelgrouproom where bookno='" & txtBookingNo.Text & "' and cancelled=0 and hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "')", conn)

        msda.Fill(dst, 0)
        MyDataGridView_room.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_room, {"id", "allowzero", "folioid", "roomtype", "Confirmed"})
        GridColumnAlignment(MyDataGridView_room, {"Status", "Room No.", "Room Type", "Arival", "Departure", "No. Days", "Adult", "Child", "Extra Person"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView_room, {"Package Rate"})

        For i = 0 To MyDataGridView_room.RowCount - 1
            If MyDataGridView_room.Item("Status", i).Value.ToString = "Checked-In" Then
                MyDataGridView_room.Rows(i).Cells("Status").Style.BackColor = Color.LightGreen
                MyDataGridView_room.Rows(i).Cells("Status").Style.ForeColor = Color.Black
            Else
                MyDataGridView_room.Rows(i).Cells("Status").Style.BackColor = DefaultBackColor
                MyDataGridView_room.Rows(i).Cells("Status").Style.ForeColor = DefaultForeColor
            End If
        Next
    End Sub

    Private Sub MyDataGridView_room_room_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_room.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_room.CurrentCell = Me.MyDataGridView_room.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdRoomAdd_Click(sender As Object, e As EventArgs) Handles cmdRoomAdd.Click

        If MyDataGridView_room.RowCount = 0 Then
            BookingNo = txtBookingNo.Text
            frmHotelPickRoomGroup.txtDateArival.Value = txtDateArival.Value
            frmHotelPickRoomGroup.txtdateCheckout.Value = txtdateCheckout.Value
        Else

            BookingNo = txtBookingNo.Text
            frmHotelPickRoomGroup.roomtype.Text = MyDataGridView_room.Item("roomtype", MyDataGridView_room.CurrentRow.Index).Value()
            frmHotelPickRoomGroup.txtRoomType.Text = MyDataGridView_room.Item("Room Type", MyDataGridView_room.CurrentRow.Index).Value().ToString
            frmHotelPickRoomGroup.txtDateArival.Value = CDate(MyDataGridView_room.Item("Arival", MyDataGridView_room.CurrentRow.Index).Value().ToString)
            frmHotelPickRoomGroup.txtdateCheckout.Value = CDate(MyDataGridView_room.Item("Departure", MyDataGridView_room.CurrentRow.Index).Value().ToString)
        End If

        If frmHotelPickRoomGroup.Visible = True Then
            frmHotelPickRoomGroup.Focus()
        Else
            frmHotelPickRoomGroup.Show(Me)
        End If

    End Sub

    Private Sub cmdRoomRemove_Click(sender As Object, e As EventArgs) Handles cmdRoomRemove.Click
        If CBool(MyDataGridView_room.Item("Confirmed", MyDataGridView_room.CurrentRow.Index).Value().ToString) = True Then
            If countqry("tblhoteltransaction", "folioid='" & MyDataGridView_room.Item("folioid", MyDataGridView_room.CurrentRow.Index).Value().ToString & "' and roomcharge=0") > 0 Then
                If MessageBox.Show("Room cannot remove! system found current room folio has charge to room transaction" & Environment.NewLine & Environment.NewLine & "Do you want to review folio statement of account?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmHotelGuestStatementLedger.Folioid.Text = MyDataGridView_room.Item("folioid", MyDataGridView_room.CurrentRow.Index).Value().ToString
                    If frmHotelGuestStatementLedger.Visible = False Then
                        frmHotelGuestStatementLedger.Show(Me)
                    Else
                        frmHotelGuestStatementLedger.WindowState = FormWindowState.Normal
                    End If
                End If
                Exit Sub
            End If
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblhotelroomtransaction where folioid='" & MyDataGridView_room.Item("folioid", MyDataGridView_room.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            If MyDataGridView_room.Item("folioid", MyDataGridView_room.CurrentRow.Index).Value().ToString <> "" Then
                com.CommandText = "UPDATE tblhoteltransaction set cancelled=1,cancelledby='" & Me.Name & "' where folioid='" & MyDataGridView_room.Item("folioid", MyDataGridView_room.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            End If
            com.CommandText = "DELETE from tblhotelgrouproom where id='" & MyDataGridView_room.Item("id", MyDataGridView_room.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            UpdateFolioSummary(txtBookingNo.Text)
            FilterRoom()
        End If
    End Sub
    Private Sub cmdRoomRefresh_Click(sender As Object, e As EventArgs) Handles cmdRoomRefresh.Click
        FilterRoom()
    End Sub
#End Region

#Region "R O O M  S U M M A R Y"
    Public Sub FilterRoomSummary()
        MyDataGridView_summary.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("SELECT date_format(datetrn,'%Y-%m-%d') as Date,dayno+1 as 'Day',roomdesc as 'Room Type',count(*) as Rooms, sum(adult+extra) as Pax,sum(total) as Total FROM `tblhotelfoliosummary` where bookno='" & txtBookingNo.Text & "' group by datetrn,roomtype", conn)
        msda.Fill(dst, 0)
        MyDataGridView_summary.DataSource = dst.Tables(0)

        GridColumnAlignment(MyDataGridView_summary, {"Date", "Day", "Room Type", "Rooms", "Pax"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView_summary, {"Total"})
    End Sub

#End Region

#Region "A D D O N"
    Public Sub FilterAddon()
        MyDataGridView_Addon.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select id,productid,(select itemname from tblglobalproducts where productid=tblhotelgroupaddon.productid) as 'Product', Quantity, Unit, unitPrice as 'Unit Price',Total,Remarks, (select officename from tblcompoffice where officeid=tblhotelgroupaddon.officeid) as 'Office Center', Confirmed  from tblhotelgroupaddon where bookno='" & txtBookingNo.Text & "' ", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Addon.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Addon, {"productid", "id"})
        GridColumnAlignment(MyDataGridView_Addon, {"Unit", "Quantity"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView_Addon, {"Unit Price", "Total"})
    End Sub
    Private Sub cmdAddonAdd_Click(sender As Object, e As EventArgs) Handles cmdAddonAdd.Click
        BookingNo = txtBookingNo.Text
        Bookingday = txtDateArival.Value
        frmHotelAddonProductSearch.Show(Me)
    End Sub
    Private Sub cmdAddonEdit_Click(sender As Object, e As EventArgs) Handles cmdAddonEdit.Click
        BookingNo = txtBookingNo.Text
        Bookingday = txtDateArival.Value
        frmHotelAddonSelectQuantity.productid.Text = MyDataGridView_Addon.Item("productid", MyDataGridView_Addon.CurrentRow.Index).Value().ToString
        frmHotelAddonSelectQuantity.id.Text = MyDataGridView_Addon.Item("id", MyDataGridView_Addon.CurrentRow.Index).Value().ToString
        frmHotelAddonSelectQuantity.mode.Text = "edit"
        frmHotelAddonSelectQuantity.Show(Me)
    End Sub
    Private Sub MyDataGridView_room_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Addon.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Addon.CurrentCell = Me.MyDataGridView_Addon.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdAddonRemove_Click(sender As Object, e As EventArgs) Handles cmdAddonRemove.Click
        If countqry("tblsalescoupon", " batchcode='" & txtBookingNo.Text & "-" & MyDataGridView_Addon.Item("id", MyDataGridView_Addon.CurrentRow.Index).Value().ToString & "' and trntype='ADDON' and verified=1") > 0 Then
            MessageBox.Show("Removing addon is not allowed! Addon service already verified", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "UPDATE tblsalescoupon set cancelled=1,datecancelled=current_timestamp,cancelledby='" & globaluserid & "' where batchcode='" & txtBookingNo.Text & "' and trntype='ADDON" & "-" & MyDataGridView_Addon.Item("id", MyDataGridView_Addon.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "DELETE from tblhotelgroupaddon where id='" & MyDataGridView_Addon.Item("id", MyDataGridView_Addon.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterAddon()
        End If
    End Sub
    Private Sub cmdAddonRefresh_Click(sender As Object, e As EventArgs) Handles cmdAddonRefresh.Click
        FilterAddon()
    End Sub
#End Region

#Region "C O M P A N I O N"
    Public Sub FilterCompanion()
        MyDataGridView_Companion.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select id, Fullname, Age from tblhotelguestcompanion where bookno='" & txtBookingNo.Text & "'", conn)
        msda.Fill(dst, 0)
        MyDataGridView_Companion.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Companion, {"id"})
        GridColumnAlignment(MyDataGridView_Companion, {"Age"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnWidth(MyDataGridView_Companion, {"Fullname"}, 300)
        GridColumnWidth(MyDataGridView_Companion, {"Age"}, 60)
    End Sub
    Private Sub cmdAddCompanion_Click(sender As Object, e As EventArgs) Handles cmdAddCompanion.Click
        BookingNo = txtBookingNo.Text
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub cmdEditCompanion_Click(sender As Object, e As EventArgs) Handles cmdEditCompanion.Click
        BookingNo = txtBookingNo.Text
        frmHotelGuestCompanion.id.Text = MyDataGridView_Companion.Item("id", MyDataGridView_Companion.CurrentRow.Index).Value().ToString
        frmHotelGuestCompanion.mode.Text = "edit"
        frmHotelGuestCompanion.Show(Me)
    End Sub
    Private Sub MyDataGridView_Companion_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Companion.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Companion.CurrentCell = Me.MyDataGridView_Companion.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdRemoveCompanion_Click(sender As Object, e As EventArgs) Handles cmdRemoveCompanion.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "DELETE from tblhotelguestcompanion where id='" & MyDataGridView_Companion.Item("id", MyDataGridView_Companion.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterCompanion()
        End If
    End Sub
    Private Sub cmdRefreshCompanion_Click(sender As Object, e As EventArgs) Handles cmdRefreshCompanion.Click
        FilterCompanion()
    End Sub
#End Region

#Region " D E P O S I T"
    Public Sub FilterPaymentDeposit()
        MyDataGridView_deposit.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select trnid,referenceno, datetrn as 'Date Posted', Remarks, credit as Amount,concat('#',referenceno) as 'Reference', (select fullname from tblaccounts where accountid=tblhoteltransaction.trnby) as 'Transaction By'  from tblhoteltransaction where bookingref='" & txtBookingNo.Text & "' and paymenttrn=1 and cancelled=0 order by datetrn asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView_deposit.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_deposit, {"trnid", "referenceno"})
        GridColumnAlignment(MyDataGridView_deposit, {"Date Posted", "Reference", "PaymentForRoom"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView_deposit, {"Amount"})
        GridColumAutonWidth(MyDataGridView_deposit, {"Date Posted", "Remarks"})
    End Sub

    Private Sub cmdAddnnewDeposit_Click(sender As Object, e As EventArgs) Handles cmdAddnnewDeposit.Click
        'frmHotelPaymentPosting.foliono.Text = txtBookingNo.Text
        frmHotelPaymentPosting.txtAmountTender.Text = txtTotalPackage.Text
        frmHotelPaymentPosting.Show(Me)
    End Sub

    Private Sub cmdRefreshDeposit_Click(sender As Object, e As EventArgs) Handles cmdRefreshDeposit.Click
        FilterPaymentDeposit()
    End Sub
    Private Sub cmdEditDeposit_Click(sender As Object, e As EventArgs) Handles cmdEditDeposit.Click
        frmHotelPaymentPosting.mode.Text = "edit"
        frmHotelPaymentPosting.txtORNumber.Text = MyDataGridView_deposit.Item("referenceno", MyDataGridView_deposit.CurrentRow.Index).Value().ToString
        frmHotelPaymentPosting.txtAmountTender.Text = MyDataGridView_deposit.Item("Amount", MyDataGridView_deposit.CurrentRow.Index).Value().ToString
        'frmHotelPaymentPosting.foliono.Text = txtBookingNo.Text
        frmHotelPaymentPosting.Show(Me)
    End Sub

    Private Sub cmdRemoveDeposit_Click(sender As Object, e As EventArgs) Handles cmdRemoveDeposit.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "UPDATE tblhoteltransaction set cancelled=1,datecancelled=current_timestamp,cancelledby='" & globaluserid & "' where trnid='" & MyDataGridView_deposit.Item("trnid", MyDataGridView_deposit.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            FilterPaymentDeposit()
        End If
    End Sub

#End Region

#Region "G U E S T"
    Public Sub showGuestInfo()
        com.CommandText = "select *,(select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as country  from tblhotelguest where guestid='" & guestid.Text & "'" : rst = com.ExecuteReader
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
        End While
        rst.Close()
        txtDateArival.Focus()
        cmdEditGuest.Visible = True
    End Sub

    Public Sub PickGuest()
        frmHotelPickGuest.mode.Text = "group"
        If frmHotelPickGuest.Visible = False Then
            frmHotelPickGuest.Show(Me)
        Else
            frmHotelPickGuest.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdPickGuest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdPickGuest.LinkClicked
        PickGuest()
    End Sub
#End Region

#Region "D A Y  S U M M A R Y"
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ' ShowDayCompleteBookingInfo()
    End Sub


    'Public Sub ShowDayCompleteBookingInfo()
    '    txtDayNoPax.Text = "1"
    '    txtDayNoPax.Text = qrysingledata("ttl", "ifnull(sum(pax+child+extra),0) as ttl", "tblhotelgrouproom where bookno='" & txtBookingNo.Text & "' and trndate='" & ConvertDate(txtBookingDay.Value) & "'")
    '    txtDayTotalRoom.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum((ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelgrouproom.rateid and breakdowntype='roomrate'),0)+ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelgrouproom.rateid and breakdowntype='child'),0)+ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelgrouproom.rateid and breakdowntype='extra'),0))),0) as ttl", "tblhotelgrouproom where bookno='" & txtBookingNo.Text & "' and trndate='" & ConvertDate(txtBookingDay.Value) & "'"), 2)
    '    txtDayTotalAddon.Text = FormatNumber(qrysingledata("ttl", "ifnull(sum(total),0) as ttl", "tblhotelgroupaddon where bookno='" & txtBookingNo.Text & "' and trndate='" & ConvertDate(txtBookingDay.Value) & "'"), 2)
    '    txtDayTotalPackage.Text = FormatNumber(Val(CC(txtDayTotalRoom.Text)) + Val(CC(txtDayTotalAddon.Text)), 2)
    '    FilterRoom()
    '    FilterAddon()
    'End Sub
#End Region

#Region "OVERALL SUMMARY"
   
    Public Sub LoadAgent()
        LoadToComboBoxDB("select * from tblhotelagent order by agentname asc", "agentname", "code", txtAgent)
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmHotelAgent.ShowDialog(Me)
        LoadAgent()
    End Sub

    Private Sub txtAgent_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAgent.SelectedValueChanged
        If txtAgent.Text = "" Then Exit Sub
        agentid.Text = DirectCast(txtAgent.SelectedItem, ComboBoxItem).HiddenValue()
    End Sub
    Public Sub ShowOverallCompleteBookingInfo()
        txtTotalPackage.Text = FormatNumber(Val(qrysingledata("ttl", "sum(total) as ttl", "tblhotelfoliosummary where bookno='" & txtBookingNo.Text & "'")), 2)
    End Sub
    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs)
        ShowOverallCompleteBookingInfo()
    End Sub
#End Region

#Region "BOOKING INFORMATION"
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "edit"
        FilterInformation()
    End Sub
    Private Sub cmdAmend_Click(sender As Object, e As EventArgs) Handles cmdAmend.Click
        mode.Text = "edit"
        FilterInformation()
    End Sub
    Public Sub FilterInformation()
        If mode.Text = "edit" Then
            txtDateArival.Enabled = True
            txtdateCheckout.Enabled = True
            cmdPickGuest.Enabled = True
            txtAgent.Enabled = True
            txtIncidental.ReadOnly = False
            txtFlight.ReadOnly = False
            txtRemarks.ReadOnly = False
            MyDataGridView_room.ContextMenuStrip = cms_room
            MyDataGridView_Addon.ContextMenuStrip = cms_addon
            MyDataGridView_Companion.ContextMenuStrip = cms_companion
            MyDataGridView_deposit.ContextMenuStrip = cms_deposit
            ckCustomPackage.Enabled = True
            If ckCustomPackage.Checked = True Then
                cmdPackages.Enabled = True
            End If
            If trntype.Text = "booking" Then
                cmdAmend.Enabled = False
                cmdSaveBooking.Enabled = True
            Else
                cmdEdit.Enabled = False
                cmdProceedCheckin.Enabled = True
                If ckConfirmed.Checked = True Then
                    cmdProceedCheckin.Text = "Update Folio Info"
                Else
                    cmdProceedCheckin.Text = "Proceed Checkin All"
                End If

            End If
        Else
            txtDateArival.Enabled = False
            txtdateCheckout.Enabled = False
            cmdPickGuest.Enabled = False
            txtAgent.Enabled = False
            txtIncidental.ReadOnly = True
            txtFlight.ReadOnly = True
            txtRemarks.ReadOnly = True
            MyDataGridView_room.ContextMenuStrip = Nothing
            MyDataGridView_Addon.ContextMenuStrip = Nothing
            MyDataGridView_Companion.ContextMenuStrip = Nothing
            MyDataGridView_deposit.ContextMenuStrip = Nothing
            ckCustomPackage.Enabled = False
            cmdPackages.Enabled = False
            If trntype.Text = "booking" Then
                cmdAmend.Enabled = True
                cmdSaveBooking.Enabled = False
            Else
                cmdEdit.Enabled = True
                If ckConfirmed.Checked = True Then
                    cmdProceedCheckin.Enabled = False
                    cmdProceedCheckin.Text = "Update Folio Info"
                Else
                    cmdProceedCheckin.Enabled = True
                    cmdProceedCheckin.Text = "Proceed Checkin All"
                End If

            End If
        End If

    End Sub

    Public Sub ShowBookingInfo()
        Dim DateArival As String = "" : Dim DateCheckout As String = ""
        com.CommandText = "select *,(select fullname from tblhotelguest where guestid=tblhotelfolio.guestid) as guest, " _
                            + " (select agentname from tblhotelagent where code=tblhotelfolio.agentcode) as 'agent', " _
                            + " (select description from tblhotelroomsdiscount where discode=tblhotelfolio.discountcode) as 'discount' from tblhotelfolio where bookno='" & txtBookingNo.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            DateArival = rst("arival").ToString
            DateCheckout = rst("departure").ToString
            ckCustomPackage.Checked = rst("customizedrate")
            guestid.Text = rst("guestid").ToString
            txtGuest.Text = rst("guest").ToString
            txtTotalPackage.Text = FormatNumber(rst("totalpackage").ToString, 2)
            agentid.Text = rst("agentcode").ToString
            txtAgent.Text = rst("agent").ToString
            txtIncidental.Text = FormatNumber(rst("incidental").ToString, 2)
            txtFlight.Text = rst("flight").ToString
            txtRemarks.Text = rst("remarks").ToString
            ckConfirmed.Checked = rst("confirmed")
            If CBool(rst("closed")) = True Then
                groupCheckin.Visible = False
                groupBooking.Visible = False
            End If
        End While
        rst.Close()
        txtDateArival.Value = DateArival
        txtdateCheckout.Value = DateCheckout
        showGuestInfo()
        FilterRoomSummary()
        FilterRoom()
        FilterAddon()
        FilterCompanion()
        FilterPaymentDeposit()
        ShowOverallCompleteBookingInfo()
        FilterInformation()
    End Sub

    Private Sub cmdSaveBooking_Click(sender As Object, e As EventArgs) Handles cmdSaveBooking.Click
        'If guestid.Text = "" Then
        '    MessageBox.Show("Selected Guest is Invalid", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtGuest.Focus()
        '    Exit Sub
        'End If
        'UpdateFolio()
        'If frmHotelReservation.Visible = True Then
        '    frmHotelReservation.LoadReservation()
        'End If
        'If frmHotelManagement.Visible = True Then
        '    frmHotelManagement.tabFilter()
        'End If
        'MsgBox("Booking Successfully saved!", MsgBoxStyle.Information, "Message")
        'Me.Close()
    End Sub
    Private Sub cmdConfirmedBooking_Click(sender As Object, e As EventArgs) Handles cmdConfirmedBooking.Click
        If guestid.Text = "" Then
            MessageBox.Show("Selected Guest is Invalid", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGuest.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If countqry("tblhotelfolio", "bookno='" & txtBookingNo.Text & "'") > 0 Then
                com.CommandText = "UPDATE tblhotelfolio set " _
                        + " guestid='" & guestid.Text & "', " _
                        + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
                        + " departure='" & ConvertDate(txtdateCheckout.Value) & "', " _
                        + " customizedrate=" & ckCustomPackage.CheckState & ", " _
                        + " totalpackage='" & Val(CC(txtTotalPackage.Text)) & "', " _
                        + " agentcode='" & agentid.Text & "', " _
                        + " incidental='" & Val(CC(txtIncidental.Text)) & "', " _
                        + " flight='" & rchar(txtFlight.Text) & "', " _
                        + " remarks='" & rchar(txtRemarks.Text) & "',bookedconfirmed=1,datebookedconfirmed=current_timestamp,bookedconfirmedby='" & globaluserid & "'  where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblhotelfolio set " _
                        + " bookno='" & txtBookingNo.Text & "', " _
                        + " guestid='" & guestid.Text & "', " _
                        + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
                        + " departure='" & ConvertDate(txtdateCheckout.Value) & "', " _
                        + " customizedrate=" & ckCustomPackage.CheckState & ", " _
                        + " totalpackage='" & Val(CC(txtTotalPackage.Text)) & "', " _
                        + " agentcode='" & agentid.Text & "', " _
                        + " incidental='" & Val(CC(txtIncidental.Text)) & "', " _
                        + " flight='" & rchar(txtFlight.Text) & "', " _
                        + " remarks='" & rchar(txtRemarks.Text) & "', " _
                        + " trnby='" & globaluserid & "', " _
                        + " datetrn=current_timestamp,bookedconfirmed=1,datebookedconfirmed=current_timestamp,bookedconfirmedby='" & globaluserid & "' " : com.ExecuteNonQuery()
            End If

            'If frmHotelReservation.Visible = True Then
            '    frmHotelReservation.LoadReservation()
            'End If
            If frmHotelManagement.Visible = True Then
                frmHotelManagement.tabFilter()
            End If
            Me.Close()
            MsgBox("Booking Successfully Confirmed!", MsgBoxStyle.Information, "Message")
        End If
    End Sub
    Public Sub UpdateFolio()

        If countqry("tblhotelfolio", "bookno='" & txtBookingNo.Text & "'") > 0 Then
            com.CommandText = "UPDATE tblhotelfolio set " _
                    + " guestid='" & guestid.Text & "', " _
                    + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
                    + " departure='" & ConvertDate(txtdateCheckout.Value) & "', " _
                    + " customizedrate=" & ckCustomPackage.CheckState & ", " _
                    + " totalpackage='" & Val(CC(txtTotalPackage.Text)) & "', " _
                    + " agentcode='" & agentid.Text & "', " _
                    + " incidental='" & Val(CC(txtIncidental.Text)) & "', " _
                    + " flight='" & rchar(txtFlight.Text) & "', " _
                    + " remarks='" & rchar(txtRemarks.Text) & "' where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblhotelfolio set " _
                    + " bookno='" & txtBookingNo.Text & "', " _
                    + " guestid='" & guestid.Text & "', " _
                    + " arival='" & ConvertDate(txtDateArival.Value) & "', " _
                    + " departure='" & ConvertDate(txtdateCheckout.Value) & "', " _
                    + " customizedrate=" & ckCustomPackage.CheckState & ", " _
                    + " totalpackage='" & Val(CC(txtTotalPackage.Text)) & "', " _
                    + " agentcode='" & agentid.Text & "', " _
                    + " incidental='" & Val(CC(txtIncidental.Text)) & "', " _
                    + " flight='" & rchar(txtFlight.Text) & "', " _
                    + " remarks='" & rchar(txtRemarks.Text) & "', " _
                    + " trnby='" & globaluserid & "', " _
                    + " datetrn=current_timestamp" : com.ExecuteNonQuery()
        End If
    End Sub
#End Region

#Region "CONFIRM BOOKING"
    Private Sub cmdProceed_Click(sender As Object, e As EventArgs) Handles cmdProceedCheckin.Click
        Dim noRoom As Integer = 0 : Dim allowzero As Integer = 0
        For i = 0 To MyDataGridView_room.RowCount - 1
            If MyDataGridView_room.Item("Room No.", i).Value().ToString = "" Then
                noRoom += 1
            End If
            If CBool(MyDataGridView_room.Item("allowzero", i).Value()) = False And Val(CC(MyDataGridView_room.Item("Package Rate", i).Value().ToString)) = 0 Then
                allowzero += 1
            End If
        Next
        If guestid.Text = "" Then
            MessageBox.Show("Selected Guest is Invalid", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGuest.Focus()
            Exit Sub
        ElseIf noRoom > 0 Then
            MessageBox.Show("Some room currently not assigned room number! Please update room selection", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf allowzero > 0 Then
            MessageBox.Show("Some room currently no proper rate! Please update room selection", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            UpdateFolio()
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("SELECT *,ifnull((select sum(total) from tblhotelfoliosummary where roomid=tblhotelgrouproom.roomid and arival=tblhotelgrouproom.arival),0) as total, ifnull((select total from tblhotelfoliosummary where roomid=tblhotelgrouproom.roomid and arival=tblhotelgrouproom.arival and dayno=0 and bookno=tblhotelgrouproom.bookno),0) as rate FROM `tblhotelgrouproom` where bookno='" & txtBookingNo.Text & "' and confirmed=0 order by arival asc;", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                PostRoomTransaction(st.Tables(0).Rows(nt)("id").ToString(), txtBookingNo.Text, st.Tables(0).Rows(nt)("arival").ToString(), st.Tables(0).Rows(nt)("departure").ToString(), st.Tables(0).Rows(nt)("hotelcif").ToString(), st.Tables(0).Rows(nt)("roomtype").ToString(), st.Tables(0).Rows(nt)("chargepernight").ToString(), st.Tables(0).Rows(nt)("roomid").ToString(), _
                                    st.Tables(0).Rows(nt)("rateid").ToString(), st.Tables(0).Rows(nt)("rate").ToString(), st.Tables(0).Rows(nt)("pax").ToString(), st.Tables(0).Rows(nt)("child").ToString(), st.Tables(0).Rows(nt)("extra").ToString(), Val(st.Tables(0).Rows(nt)("total").ToString()), st.Tables(0).Rows(nt)("dateposted").ToString())

            Next
            'create coupon for addon products
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("SELECT * FROM `tblhotelgroupaddon` where bookno='" & txtBookingNo.Text & "' and confirmed=0 order by trndate asc;", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                CouponCheck("ADDON" & "-" & st.Tables(0).Rows(nt)("id").ToString(), txtBookingNo.Text, st.Tables(0).Rows(nt)("productid").ToString(), st.Tables(0).Rows(nt)("quantity").ToString(), CDate(st.Tables(0).Rows(nt)("trndate").ToString()).ToShortDateString)
                com.CommandText = "update tblhotelgroupaddon set confirmed=1 where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
            Next
            com.CommandText = "update tblhotelfolio set bookedconfirmed=1, confirmed=1, confirmedby='" & globaluserid & "', dateconfirmed=current_timestamp where bookno='" & txtBookingNo.Text & "'" : com.ExecuteNonQuery()
            'If frmHotelReservation.Visible = True Then
            '    frmHotelReservation.LoadReservation()
            'End If
            If frmHotelManagement.Visible = True Then
                frmHotelManagement.tabFilter()
            End If
            'If countqry("tblsalescoupon", "batchcode='" & txtBookingNo.Text & "' and cancelled=0 and printed=0") > 0 Then
            '    Dim CouponList As String = ""
            '    com.CommandText = "select *,(select itemname from tblglobalproducts where productid=tblsalescoupon.productid) as product from tblsalescoupon where batchcode='" & txtBookingNo.Text & "' and cancelled=0" : rst = com.ExecuteReader
            '    While rst.Read
            '        CouponList += rst("couponcode").ToString & " - " & rst("product") & vbTab & FormatNumber(Val(rst("total").ToString), 2).ToString & Environment.NewLine
            '    End While
            '    rst.Close()

            '    If MessageBox.Show("Your transaction contains coupon! Do you want to print room package coupon ticket?" & Environment.NewLine & Environment.NewLine & CouponList, GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            '        PrintCoupon(txtBookingNo.Text)
            '    End If
            'End If
            MessageBox.Show("Booking Successfully Confirmed", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Public Sub PostRoomTransaction(ByVal trnroomid As String, ByVal bookingref As String, ByVal arival As Date, ByVal departure As Date, ByVal hotelcif As String, ByVal roomtype As String, ByVal chargepernight As Boolean, ByVal roomid As String, _
                                   ByVal rateid As String, ByVal roomrate As Double, ByVal txtAdult As Integer, ByVal txtChild As Integer, ByVal txtExtraPerson As Integer, ByVal txtTotalCharge As Double, ByVal datetrn As DateTime)

        If countqry("tblhotelroomtransaction", "bookingref='" & bookingref & "' and roomid='" & roomid & "' and cancelled=0") = 0 Then
            Dim folioid As String = getPOSHotelTransactionSequence()
            Dim foliono As String = getPOSHotelFolioNo(hotelcif)
            Dim roomno As String = qrysingledata("roomnumber", "roomnumber", "tblhotelrooms where roomid='" & roomid & "'")
            com.CommandText = "delete from tblhotelroomsalesbreakdown where folioid='" & folioid & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblhotelgrouproom set confirmed=1, folioid='" & folioid & "' where id='" & trnroomid & "'" : com.ExecuteNonQuery()

            'If Globalenablehoteldayafterrevenue = True Then
            '    com.CommandText = "insert into tblhoteltransaction set folioid='" & folioid & "', guestid='" & guestid.Text & "', bookingref='" & bookingref & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', remarks='ROOM CHARGE " & CDate(arival.AddDays(1)).ToShortDateString & "', debit='" & Val(CC(txtTotalCharge)) & "',roomcharge=1,roomtype='" & roomtype & "',roomprofit='" & Val(CC(txtRoomProfit)) & "', datecharge='" & ConvertDate(CDate(arival.AddDays(1)).ToShortDateString) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            '    RecordHotelSalesBreakdown(hotelcif, folioid, roomid, roomno, txtAdult, txtChild, txtExtraPerson, roomtype, rateid, "roomrate", If(chargepernight = True, "1", txtAdult), CDate(arival.AddDays(1)).ToShortDateString, compOfficeid)
            'Else
            '    com.CommandText = "insert into tblhoteltransaction set folioid='" & folioid & "', guestid='" & guestid.Text & "', bookingref='" & bookingref & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', remarks='ROOM CHARGE " & CDate(arival).ToShortDateString & "', debit='" & Val(CC(txtTotalCharge)) & "',roomcharge=1,roomtype='" & roomtype & "',roomprofit='" & Val(CC(txtRoomProfit)) & "', datecharge='" & ConvertDate(CDate(arival).ToShortDateString) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
            '    RecordHotelSalesBreakdown(hotelcif, folioid, roomid, roomno, txtAdult, txtChild, txtExtraPerson, roomtype, rateid, "roomrate", If(chargepernight = True, "1", txtAdult), CDate(arival).ToShortDateString, compOfficeid)
            'End If

            'CouponCheck("HOTEL", bookingref, packageid, Val(txtAdult), CDate(datecharge.AddDays(1)).ToShortDateString)
            com.CommandText = "insert into tblhotelroomtransaction set folioid='" & folioid & "', " _
                                                        + " foliono='" & foliono & "', " _
                                                        + " walkinguest=0, " _
                                                        + " bookingref='" & bookingref & "', " _
                                                        + " officeid='" & compOfficeid & "', " _
                                                        + " trnsumcode='" & globalSalesTrnCOde & "', " _
                                                        + " inhouse=1, " _
                                                        + " vip=0, " _
                                                        + " roomcheckin=1, " _
                                                        + " guestid='" & guestid.Text & "', " _
                                                        + " hotelcif='" & hotelcif & "', " _
                                                        + " roomid='" & roomid & "', " _
                                                        + " roomtype='" & roomtype & "', " _
                                                        + " chargepernight=" & chargepernight & ", " _
                                                        + " rateid='" & rateid & "', " _
                                                        + " roomrate='" & Val(CC(roomrate)) & "', " _
                                                        + " extranightrate='0', " _
                                                        + " datecheckin='" & ConvertDate(arival) & "', " _
                                                        + " timecheckin=current_time, " _
                                                        + " datecheckout='" & ConvertDate(departure) & "', " _
                                                        + " timecheckout='" & ConvertTime(Globalhotelcheckouttime) & "', " _
                                                        + " nodays=" & DateDiff(DateInterval.Day, arival, departure) & ", " _
                                                        + " noadults='" & txtAdult & "', " _
                                                        + " nochild='" & txtChild & "', " _
                                                        + " childrate=0, " _
                                                        + " noextra='" & txtExtraPerson & "', " _
                                                        + " extrarate=0, " _
                                                        + " roomcharge='" & Val(CC(txtTotalCharge)) & "', " _
                                                        + " discountrate='0', " _
                                                        + " roomdiscount='0', " _
                                                        + " totaldiscount='0', " _
                                                        + " totalamount='" & Val(CC(txtTotalCharge)) & "', " _
                                                        + " platenumber='', " _
                                                        + " remarks='" & rchar(txtRemarks.Text) & "', " _
                                                        + " incidental='" & Val(CC(txtIncidental.Text)) & "', " _
                                                        + " flight='" & rchar(txtFlight.Text) & "'," _
                                                        + " agentcode='" & agentid.Text & "'," _
                                                        + " companion='', " _
                                                        + " trnby='" & globaluserid & "',  " _
                                                        + " datetrn='" & ConvertDateTime(datetrn) & "' " : com.ExecuteNonQuery()
            com.CommandText = "update tblhotelrooms set occupied=1,roomstatus='" & Globalhoteldefaultcheckinstatuscode & "' where roomid='" & roomid & "'" : com.ExecuteNonQuery()

            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblhotelfoliosummary where bookno='" & txtBookingNo.Text & "' and roomid='" & roomid & "'", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    'RecordHotelSalesBreakdown(hotelcif, folioid, .Rows(cnt)("roomid").ToString(), .Rows(cnt)("roomno").ToString(), .Rows(cnt)("adult").ToString(), .Rows(cnt)("child").ToString(), .Rows(cnt)("extra").ToString(), .Rows(cnt)("roomtype").ToString(), rateid, "night", If(chargepernight = True, "1", txtAdult), CDate(.Rows(cnt)("datetrn").ToString()).ToShortDateString, compOfficeid)
                    com.CommandText = "insert into tblhoteltransaction set folioid='" & folioid & "', guestid='" & guestid.Text & "', bookingref='" & bookingref & "', trnsumcode='" & globalSalesTrnCOde & "', officeid='" & compOfficeid & "', remarks='ROOM CHARGE " & If(.Rows(cnt)("dayno").ToString() = "0", "", "(extra night) ") & CDate(.Rows(cnt)("datetrn").ToString()).ToShortDateString & "', debit='" & Val(CC(.Rows(cnt)("total").ToString())) & "',roomcharge=1,roomtype='" & roomtype & "',roomprofit='" & Val(CC(.Rows(cnt)("total").ToString())) & "', datecharge='" & ConvertDate(CDate(.Rows(cnt)("datetrn").ToString()).ToShortDateString) & "', datetrn=current_timestamp,trnby='" & globaluserid & "'" : com.ExecuteNonQuery()
                End With
            Next
        End If
    End Sub

    Private Sub ProceedCheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProceedCheckinToolStripMenuItem.Click
        If MyDataGridView_room.Item("Room No.", MyDataGridView_room.CurrentRow.Index).Value().ToString = "" Then
            MessageBox.Show("Please assigned room to continue proceed!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf CBool(MyDataGridView_room.Item("Confirmed", MyDataGridView_room.CurrentRow.Index).Value().ToString) = True Then
            MessageBox.Show("Room already proceed! cannot be execute", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("SELECT *,ifnull((select sum(total) from tblhotelfoliosummary where roomid=tblhotelgrouproom.roomid and arival=tblhotelgrouproom.arival),0) as total, ifnull((select total from tblhotelfoliosummary where roomid=tblhotelgrouproom.roomid and arival=tblhotelgrouproom.arival and dayno=0 and bookno=tblhotelgrouproom.bookno),0) as rate FROM `tblhotelgrouproom` where id='" & MyDataGridView_room.Item("id", MyDataGridView_room.CurrentRow.Index).Value().ToString & "' order by arival asc;", conn)
            da.Fill(st, 0)
            For nt = 0 To st.Tables(0).Rows.Count - 1
                PostRoomTransaction(st.Tables(0).Rows(nt)("id").ToString(), txtBookingNo.Text, st.Tables(0).Rows(nt)("arival").ToString(), st.Tables(0).Rows(nt)("departure").ToString(), st.Tables(0).Rows(nt)("hotelcif").ToString(), st.Tables(0).Rows(nt)("roomtype").ToString(), st.Tables(0).Rows(nt)("chargepernight").ToString(), st.Tables(0).Rows(nt)("roomid").ToString(), _
                                  st.Tables(0).Rows(nt)("rateid").ToString(), st.Tables(0).Rows(nt)("rate").ToString(), st.Tables(0).Rows(nt)("pax").ToString(), st.Tables(0).Rows(nt)("child").ToString(), st.Tables(0).Rows(nt)("extra").ToString(), Val(st.Tables(0).Rows(nt)("total").ToString()), st.Tables(0).Rows(nt)("dateposted").ToString())

            Next
            FilterRoom()
            MessageBox.Show("Room successfully checkin", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
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

    Private Sub ckCustomPackage_CheckedChanged(sender As Object, e As EventArgs) Handles ckCustomPackage.CheckedChanged
        If ckCustomPackage.Checked = True Then
            If mode.Text = "edit" Or mode.Text = "" Then
                cmdPackages.Enabled = True
            Else
                cmdPackages.Enabled = False
            End If
        Else
            cmdPackages.Enabled = False
        End If
    End Sub

    Private Sub cmdPackages_Click(sender As Object, e As EventArgs) Handles cmdPackages.Click
        BookingNo = txtBookingNo.Text
        Bookingday = txtDateArival.Value
        frmHotelCustomPackage.Show(Me)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If countqry("tblhotelfolio", "bookno='" & txtBookingNo.Text & "'") = 0 Then
            MessageBox.Show("Current checkin transaction not yet validate! Please confirm transaction first", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            GenerateGuestFolio(txtBookingNo.Text, Me)
        End If
    End Sub

    Private Sub txtAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAgent.SelectedIndexChanged

    End Sub
End Class