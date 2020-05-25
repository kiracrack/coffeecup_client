Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHotelRoomForHouseKeeping
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            txtsearch.SelectAll()
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtfrmdate.Value = CDate(Now)
        txttodate.Value = CDate(Now)
        LoadToComboBoxDB("select * from tblclientaccounts where hotelclient=1 and deleted=0 and cifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') order by companyname asc", "companyname", "cifid", txtHotel)
        LoadToComboBoxDB("select * from tblhotelroomstatus", "description", "statuscode", txtRoomStatus)
        txtHotel.Text = defaultCombobox(txtHotel, Me, False)
        hotelcif.Text = defaultCombobox(txtHotel, Me, True)
        ShowRoomList()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tabTransaction Then
            FilterTransaction()
        ElseIf TabControl1.SelectedTab Is tabMaintainance Then
            FilterMaintainance()
        End If
    End Sub

#Region "ROOM MANAGEMENT"
    Private Sub txtHotel_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtHotel.SelectedValueChanged
        If txtHotel.Text = "" Then Exit Sub
        hotelcif.Text = DirectCast(txtHotel.SelectedItem, ComboBoxItem).HiddenValue()
        SaveDefaultComboItem(txtHotel, txtHotel.Text, DirectCast(txtHotel.SelectedItem, ComboBoxItem).HiddenValue(), Me)
        ShowRoomList()
    End Sub
    Private Sub txtRoomStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomStatus.SelectedValueChanged
        If txtRoomStatus.Text = "" Then Exit Sub
        roomstatus.Text = DirectCast(txtRoomStatus.SelectedItem, ComboBoxItem).HiddenValue()
        ShowRoomList()
    End Sub
    Public Sub ShowRoomList()
        If txtHotel.Text = "" Or (txtRoomStatus.Text = "" And ckViewAll.Checked = False) Then Exit Sub

        LoadXgrid("select tblhotelrooms.roomid, ifnull((select color from tblhotelroomstatus where statuscode=tblhotelrooms.roomstatus),'') as color, roomnumber as 'Room Number', tblhotelrooms.Description,Cluster, roomstatus as 'Room Status',  " _
                                    + " ifnull((select fullname from tblhotelguest where guestid = tblhotelfolioroom.guestid),'')  as 'Guest', " _
                                    + " date_format(arival, '%Y-%m-%d') as 'Arival Date', " _
                                    + " date_format(departure, '%Y-%m-%d') as 'Departure Date', " _
                                    + " pax as 'Adults', " _
                                    + " child as 'Kids', " _
                                    + " extra as 'Extra Person', " _
                                    + " (pax+child+extra) as 'Total Person', " _
                                    + " Remarks " _
                                    + " from tblhotelrooms left join tblhotelfolioroom on tblhotelrooms.roomid = tblhotelfolioroom.roomid and tblhotelfolioroom.foliono=tblhotelrooms.currentfolio where hotelcifid='" & hotelcif.Text & "' " & If(ckViewAll.Checked = True, "", " and roomstatus='" & roomstatus.Text & "' ") & " and deleted=0 and (roomnumber = '" & rchar(txtsearch.Text) & "' or tblhotelrooms.description like '%" & rchar(txtsearch.Text) & "%') order by roomid asc", "tblhotelrooms", Em, Gridview1)
        XgridHideColumn({"roomid", "color"}, Gridview1)
        XgridColCurrency({"BalanceDue"}, Gridview1)
        XgridColAlign({"Room Number", "Cluster", "Adults", "Kids", "Extra Person", "Total Person", "Room Status"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)

    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender

        Dim colorRgb As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("color"))
        'e.Appearance.BackColor = RGBColorConverter(colorRgb)
        'e.Appearance.BackColor2 = RGBColorConverter(colorRgb)
        e.Appearance.ForeColor = RGBColorConverter(colorRgb)
    End Sub
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowRoomList()
        End If
    End Sub

    Private Sub ckViewAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAll.CheckedChanged
        If ckViewAll.Checked = True Then
            txtRoomStatus.Enabled = False
        Else
            txtRoomStatus.Enabled = True
        End If
        ShowRoomList()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowRoomList()
    End Sub

    Private Sub cmdProceedCheckin_Click(sender As Object, e As EventArgs) Handles cmdProceedCheckin.Click
        If frmHotelHouseKeepingUpdateInfo.Visible = True Then
            frmHotelHouseKeepingUpdateInfo.Focus()
        Else
            frmHotelHouseKeepingUpdateInfo.Show(Me)
        End If
    End Sub
    Public Sub UpdateRoomStatus(ByVal statuscode As String, ByVal allowcheckin As Boolean, ByVal maintainance As Boolean, ByVal housekeeper As String, ByVal remarks As String)
        For I = 0 To Gridview1.SelectedRowsCount - 1
            For Each word In housekeeper.Split(New Char() {","c})
                If word.Length > 1 Then
                    com.CommandText = "insert into tblhotelhousekeepingreports set hotel='" & hotelcif.Text & "', roomid='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "roomid").ToString & "',roomno='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "Room Number").ToString & "', description='" & rchar(Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "Description").ToString) & "', maintainancemode=" & maintainance & ", roomstatus='" & statuscode & "', remarks='" & rchar(remarks) & "', housekeeper='" & word & "', dateupdate=current_timestamp,postedby='" & globalfullname & "'" : com.ExecuteNonQuery()
                End If
            Next

            If maintainance = True Then
                com.CommandText = "UPDATE tblhotelrooms set maintainance=" & maintainance & ", roomstatus='" & statuscode & "',remarks='" & rchar(remarks) & "' where roomid='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "roomid").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblhotelrooms set occupied=" & If(allowcheckin = True, "0", "1") & ", maintainance=0, roomstatus='" & statuscode & "',remarks='" & rchar(remarks) & "' where roomid='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "roomid").ToString & "'" : com.ExecuteNonQuery()
            End If
        Next
        ShowRoomList()
    End Sub
    Private Sub SetMaintainanceTimeFrameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetMaintainanceTimeFrameToolStripMenuItem.Click
        If Gridview1.SelectedRowsCount > 1 Then
            MsgBox("Multiple room selection not allowed!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        frmHotelMaintainanceTimeframe.roomid.Text = Gridview1.GetFocusedRowCellValue("roomid").ToString
        frmHotelMaintainanceTimeframe.Show(Me)
    End Sub
#End Region


#Region "MAINTAINANCE TIMEFRAME"
    Public Sub FilterMaintainance()
        DataGridView2.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select roomid," & If(ckClosed.Checked = False, "if(enddate<current_timestamp,'DUE TODAY',concat(datediff(enddate,current_timestamp),' Day(s) Remaining')) as Status, ", "") & " hotelname as 'Hotel', roomno as 'Room No.', roomdetails as 'Room Type', startdate as 'Start Date', enddate as 'End Date', roomstatus as 'Room Status',Remarks,trnby as 'Added By', datetrn as 'Date Added', updateby as 'Update By',dateupdated as 'Date Updated' " & If(ckClosed.Checked = True, ",dateclosed as 'Date Closed', closeby as 'Closed By' ", "") & " from tblhotelroommaintainance where closed=" & ckClosed.CheckState & " " & If(ckClosed.Checked = True, " and date_format(startdate, '%Y-%m-%d') between '" & ConvertDate(txtMaintainanceFrom.Value) & "' and '" & ConvertDate(txtMaintainanceTo.Value) & "'", "") & "  order by startdate asc", conn)

        msda.Fill(dst, 0)
        DataGridView2.DataSource = dst.Tables(0)
        GridHideColumn(DataGridView2, {"roomid"})
        GridColumnAlignment(DataGridView2, {"Hotel", "Status", "Room No.", "Room Type", "Maintainance Mode", "Room Status", "Start Date", "End Date", "Date Added", "Date Updated", "Date Closed"}, DataGridViewContentAlignment.MiddleCenter)

        For i = 0 To DataGridView2.RowCount - 1
            If DataGridView2.Item("Status", i).Value.ToString = "DUE TODAY" Then
                DataGridView2.Rows(i).Cells("Status").Style.BackColor = Color.Red
                DataGridView2.Rows(i).Cells("Status").Style.ForeColor = Color.White
            Else
                DataGridView2.Rows(i).Cells("Status").Style.BackColor = DefaultBackColor
                DataGridView2.Rows(i).Cells("Status").Style.ForeColor = DefaultForeColor
            End If
        Next
    End Sub

    Private Sub cmdFilterMaintainance_Click(sender As Object, e As EventArgs) Handles cmdFilterMaintainance.Click
        FilterMaintainance()
    End Sub

    Private Sub cmdPrintMaintainance_Click(sender As Object, e As EventArgs) Handles cmdPrintMaintainance.Click
        PrintDatagridview("Room Maintainance Report <br/><strong>" & Me.Text & "</strong>", "Room Maintainance Report", "Report period from " & CDate(txtfrmdate.Value).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Value).ToString("MMMM, dd yyyy"), DataGridView2, Me)
    End Sub
    Private Sub DataGridView2_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.DataGridView2.CurrentCell = Me.DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles cmdUpdatemaintainance.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("No item selected!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If DataGridView2.SelectedRows.Count > 1 Then
            MsgBox("Multiple room selection not allowed!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For Each rw As DataGridViewRow In DataGridView2.SelectedRows
            frmHotelMaintainanceTimeframe.roomid.Text = rw.Cells("roomid").Value.ToString
            frmHotelMaintainanceTimeframe.Show(Me)
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles cmdClosed.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("No item selected!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue close maintainance? " & Environment.NewLine & Environment.NewLine & "NOTE: Room will automatically set status as " & Globalhoteldefaultvacantstatuscode, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For Each rw As DataGridViewRow In DataGridView2.SelectedRows
                com.CommandText = "UPDATE tblhotelrooms set maintainance=0, roomstatus='" & Globalhoteldefaultvacantstatuscode & "',remarks='Maintainance Closed' where roomid='" & rw.Cells("roomid").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblhotelroommaintainance set closed=1, dateclosed=current_timestamp,closeby='" & globalfullname & "' where roomid='" & rw.Cells("roomid").Value.ToString & "' and closed=0" : com.ExecuteNonQuery()
            Next
            FilterMaintainance()
            MsgBox("Selected room successfully closed!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FilterMaintainance()
    End Sub
    Private Sub ckClosed_CheckedChanged(sender As Object, e As EventArgs) Handles ckClosed.CheckedChanged
        If ckClosed.Checked = True Then
            cmdClosed.Visible = False
            cmdUpdatemaintainance.Visible = False
            ToolStripSeparator1.Visible = False
        Else
            cmdClosed.Visible = True
            cmdUpdatemaintainance.Visible = True
            ToolStripSeparator1.Visible = True
        End If
        FilterMaintainance()
    End Sub
#End Region

#Region "REPORT"
    Public Sub FilterTransaction()
        DataGridView1.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select (select companyname from tblclientaccounts where cifid=tblhotelhousekeepingreports.hotel) as 'Hotel', roomno as 'Room No',Description, maintainancemode as 'Maintainance Mode', roomstatus as 'Room Status', Remarks, housekeeper as 'House Keeper', date_format(dateupdate, '%Y-%m-%d %r') as 'Date Update',postedby as 'Posted By'  from tblhotelhousekeepingreports where hotel in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and date_format(dateupdate, '%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Value) & "' and '" & ConvertDate(txttodate.Value) & "' order by dateupdate asc", conn)

        msda.Fill(dst, 0)
        DataGridView1.DataSource = dst.Tables(0)
        GridColumnAlignment(DataGridView1, {"Hotel", "Room No", "Maintainance Mode", "Room Status"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        FilterTransaction()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview("House Keeping Report <br/><strong>" & Me.Text & "</strong>", "House Keeping Report", "Report period from " & CDate(txtfrmdate.Value).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Value).ToString("MMMM, dd yyyy"), DataGridView1, Me)
    End Sub
    Private Sub DataGridView1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
#End Region

End Class