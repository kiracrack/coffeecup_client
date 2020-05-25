Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelChangeRoom
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmPOSOnholdConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadHotelPackages()
        ShowFolioInfo()
    End Sub

    Public Sub LoadHotelPackages()
        LoadXgridLookupSearch("select ratecode, (select description from tblhotelroomtype where code=tblhotelroomrates.roomtype) as 'Room Type', Description as Package, ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate' and dayrate=0),0) as 'Package Rate' from tblhotelroomrates where (temporaryrate=0 or (temporaryrate=1 and bookingno='" & frmHotelCheckInTransactionV2.foliono.Text & "')) and deleted=0 order by description asc", "tblhotelroomrates", txtPackageName, gridPackage)
        gridPackage.Columns("ratecode").Visible = False
        XgridColCurrency({"Package Rate"}, gridPackage)
    End Sub

    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPackageName.EditValueChanged
        On Error Resume Next
        Dim iCurrentRow As Integer = CInt(txtPackageName.Properties.View.FocusedRowHandle.ToString)
        rateid.Text = txtPackageName.Properties.View.GetFocusedRowCellValue("ratecode").ToString()
    End Sub

    Public Sub ShowFolioInfo()
        Dim package As String = ""
        com.CommandText = "select *,(select roomnumber from tblhotelrooms where roomid=tblhotelfolioroom.roomid) as roomno, " _
            + " (select description from tblhotelroomtype where code=tblhotelfolioroom.roomtype) as typeroom, " _
            + " (select description from tblhotelroomrates where ratecode=tblhotelfolioroom.rateid) as 'Package', " _
            + " ifnull((select adultrate from tblhotelfolioroomsummary where foliono=tblhotelfolioroom.foliono and folioid=tblhotelfolioroom.folioid and dayno=0 limit 1),0)  as 'PackageRate', " _
            + " (select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as guest from tblhotelfolioroom where folioid='" & txtfolioid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            fromroomid.Text = rst("roomid").ToString
            foliono.Text = rst("foliono").ToString
            txtPackageName.EditValue = rst("rateid").ToString
            rateid.Text = rst("rateid").ToString

            txtPackageRate.Text = FormatNumber(Val(rst("PackageRate").ToString), 2)
            guestid.Text = rst("guestid").ToString
            txtCurrRoomNo.Text = rst("roomno").ToString
            txtCurrroomtype.Text = rst("typeroom").ToString
            txtGuest.Text = rst("guest").ToString
            txtDateArival.Value = rst("arival").ToString
            txtDeparture.Text = rst("departure").ToString
        End While
        rst.Close()

    End Sub

    Public Sub ShowRoomInfo()
        com.CommandText = "select *,(select description from tblhotelroomtype where code=tblhotelrooms.roomtype) as room_type from tblhotelrooms where roomid='" & newroomid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            roomtype.Text = rst("roomtype").ToString
            txtRoomType.Text = rst("room_type").ToString
            hotelcifid.Text = rst("hotelcifid").ToString
        End While
        rst.Close()
        txtRemarks.Focus()
    End Sub

    Public Function CheckRoomAvailability() As Boolean
        If newroomid.Text = "" And txtRoomNumber.Text <> "" Then
            MessageBox.Show("Room Number not found! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomNumber.Focus()
            Return False

        ElseIf countqry("tblhotelrooms", "roomid='" & newroomid.Text & "' and hotelcifid='" & GlobalHotelCif & "' and maintainance=1 and deleted=0") > 0 Then
            MessageBox.Show("Room currently not avalaible due to maintainance mode:" & Environment.NewLine & Environment.NewLine & qrysingledata("remarks", "remarks", "tblhotelrooms where roomid='" & newroomid.Text & "' and maintainance=1"), CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ClearRoomInfo()
            txtRoomNumber.Focus()
            Return False

        ElseIf countqry("tblhotelfolioroom", "roomid='" & newroomid.Text & "' and folioid<>'" & txtfolioid.Text & "' and hotelcif='" & GlobalHotelCif & "' and inhouse=1 and (" & TrapRoomQuery(txtDateArival.Value, txtDeparture.Value) & ") and checkout=0 and cancelled=0") > 0 Then
            MessageBox.Show("Room not avalaible! Already taken with current checkin guest", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ClearRoomInfo()
            txtRoomNumber.Focus()
            Return False

        ElseIf countqry("tblhotelfolioroom", "roomid='" & newroomid.Text & "' and hotelcif='" & GlobalHotelCif & "' and inhouse=1 and departure='" & ConvertDate(txtDateArival.Value) & "' and inhouse=1 and checkout=0 and guestid<>'" & guestid.Text & "' and cancelled=0") > 0 Then
            MessageBox.Show("Current CHECK-IN guest " & qrysingledata("guest", "(select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as guest", "tblhotelfolioroom where roomid='" & newroomid.Text & "' and departure='" & ConvertDate(txtDateArival.Value) & "' and inhouse=1 and checkout=0") & " will checkout on selected date! Please wait previous checkin guest to be checkout, to prevent room conflict!", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ClearRoomInfo()
            txtRoomNumber.Focus()
            Return False

        End If
        Return True
    End Function

    Public Sub ClearRoomInfo()
        txtRoomNumber.Text = ""
        txtRoomType.Text = ""

    End Sub
    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If newroomid.Text = "" Then
            MessageBox.Show("Please select room", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRoomNumber.Focus()
            Exit Sub
        ElseIf txtRemarks.Text = "" Then
            MessageBox.Show("Please enter remarks", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRemarks.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            PostTransaction()
        End If
    End Sub

    Public Sub PostTransaction()
        If MessageBox.Show("Are you sure you want to change current room? " & Environment.NewLine & Environment.NewLine & "Note: changing room transaction needs an administrative login overide!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), foliono.Text, "Room upgrade from " & txtCurrroomtype.Text & " (" & txtCurrRoomNo.Text & ") to " & txtRoomType.Text & " (" & txtRoomNumber.Text & ") overide by " & GetUserinfo(frmPOSAdminConfirmation.userid.Text, "fullname"))

                Dim userateid As String = rateid.Text
                If countqry("tblhotelroomrates", "ratecode='" & rateid.Text & "' and temporaryrate=1 and bookingno='" & foliono.Text & "'") = 0 Then
                    Dim copyrateid As String = qrysingledata("newratecode", "ratecode+1 as newratecode", "tblhotelroomrates order by ratecode desc limit 1")

                    com.CommandText = "INSERT INTO tblhotelroomrates set ratecode='" & copyrateid & "', roomtype='" & roomtype.Text & "',description='" & rchar(txtPackageName.Text) & "',allowzerorate=0,actived=1,lockrate=0,temporaryrate=1,originrate='" & rateid.Text & "', onlinerate=0,packagedetails='',bookingno='" & foliono.Text & "', addedby='" & globaluserid & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO tblhotelratesbreakdown (roomtype,ratecode,dayrate,breakdowntype,itemcode,itemname,amount) " _
                                           + " SELECT '" & txtCurrroomtype.Text & "','" & copyrateid & "',dayrate,breakdowntype,itemcode,itemname,amount FROM tblhotelratesbreakdown where ratecode='" & rateid.Text & "'" : com.ExecuteNonQuery()

                    com.CommandText = "update tblhotelfolioroom set rateid='" & copyrateid & "' where foliono='" & foliono.Text & "' and roomtype='" & txtCurrroomtype.Text & "' and rateid='" & rateid.Text & "' " : com.ExecuteNonQuery()

                    com.CommandText = "update tblhotelfolioroombreakdown set ratecode='" & copyrateid & "' where foliono='" & foliono.Text & "' and ratecode='" & rateid.Text & "' " : com.ExecuteNonQuery()
                    com.CommandText = "update tblhotelfolioroomsummary set rateid='" & copyrateid & "' where foliono='" & foliono.Text & "' and rateid='" & rateid.Text & "' " : com.ExecuteNonQuery()
                    userateid = copyrateid
                End If

                com.CommandText = "update tblhotelfolioroom set roomid='" & newroomid.Text & "', roomno='" & txtRoomNumber.Text & "', description='" & rchar(txtRoomType.Text) & "', roomtype='" & roomtype.Text & "', shortcode=ifnull((select shortcode from tblhotelroomtype where code='" & roomtype.Text & "'),''),rateid='" & userateid & "' where folioid='" & txtfolioid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblhotelfoliotransaction set trnsumcode='', folioid='" & txtfolioid.Text & "', foliono='" & foliono.Text & "', hotelcifid='" & hotelcifid.Text & "', guestid='" & guestid.Text & "', roomid='" & newroomid.Text & "', roomno='" & txtRoomNumber.Text & "',  referenceno='',officeid='" & compOfficeid & "', remarks='Upgraded Room from " & txtCurrroomtype.Text & " to " & txtRoomType.Text & "', datetrn=current_timestamp, trnby='" & globaluserid & "' " : com.ExecuteNonQuery()
                com.CommandText = "insert into tblhotelroomchangelog set folioid='" & txtfolioid.Text & "', guestid='" & guestid.Text & "', fromroomid='" & fromroomid.Text & "', fromroomno='" & txtCurrRoomNo.Text & "', fromroomtype='" & txtCurrroomtype.Text & "', toroomid='" & newroomid.Text & "', toroomno='" & txtRoomNumber.Text & "', toroomtype='" & txtRoomType.Text & "', remarks='" & rchar(txtRemarks.Text) & "', changeby='" & globaluserid & "', datechange=current_timestamp,overideby='" & frmPOSAdminConfirmation.userid.Text & "'" : com.ExecuteNonQuery()

                com.CommandText = "update tblhotelrooms set currentfolio='" & foliono.Text & "', occupied=1,roomstatus='" & Globalhoteldefaultcheckinstatuscode & "',remarks='OCCUPIED' where roomid='" & newroomid.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "update tblhotelrooms set currentfolio='', occupied=0, maintainance=1, roomstatus='" & Globalhotelmaintainancedefaultstatus & "',remarks='Upgrade to " & txtRoomType.Text & " (" & txtRoomNumber.Text & ")' where roomid='" & fromroomid.Text & "'" : com.ExecuteNonQuery()

                UpdateFolioSummary(foliono.Text)
                frmHotelCheckInTransactionV2.FilterRoom()
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
                MessageBox.Show("Room successfully upgraded! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmHotelUpgradePickRoom.folioid.Text = txtFolioid.Text
        frmHotelUpgradePickRoom.txtDateArival.Text = txtDateArival.Value
        frmHotelUpgradePickRoom.txtdateCheckout.Text = txtDeparture.Value
        frmHotelUpgradePickRoom.mode.Text = "upgrade"
        frmHotelUpgradePickRoom.Show(Me)
    End Sub

 
End Class