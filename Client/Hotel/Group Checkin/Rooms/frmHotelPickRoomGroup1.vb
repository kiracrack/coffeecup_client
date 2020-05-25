Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class frmHotelPickRoomGroup1
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure
    <DllImport("dwmapi.dll")> _
    Private Shared Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef margin As MARGINS) As Integer
    End Function

    Delegate Sub Execute_Delegate()
    Private Sub Execute_ThreadSafe()
        If Me.InvokeRequired Then
            Dim MyDelegate As New Execute_Delegate(AddressOf Execute_ThreadSafe)
            Me.Invoke(MyDelegate)
        Else
            LoadAvailableRooms()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmHotelPickRoomGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        Dim mg As MARGINS = New MARGINS
        mg.cxLeftWidth = -1
        mg.cxRightWidth = -1
        mg.cyTopHeight = -1
        mg.cyButtomheight = -1
        'set all value -1 to apply glass effect to the all of visible window
        'Try
        '    DwmExtendFrameIntoClientArea(Me.Handle, mg)
        'Catch ex As Exception
        'End Try

        LoadRoomType()
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Public Sub LoadRoomType()
        LoadToComboBoxDB("select * from tblhotelroomtype where hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') ", "description", "code", txtRoomType)
        Dim strroomtype As String = "" : Dim strRoomTypecode As String = ""
        If countqry("tblhotelgrouproom", " bookno='" & BookingNo & "' and cancelled=0") > 0 Then
            com.CommandText = "select * from tblhotelgrouproom where roomtype='" & roomtype.Text & "' limit 1" : rst = com.ExecuteReader
            While rst.Read
                strroomtype = rst("description").ToString
            End While
            rst.Close()
            txtRoomType.Text = strroomtype
        End If
    End Sub

    Private Sub txtRoomType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtRoomType.SelectedValueChanged
        roomtype.Text = DirectCast(txtRoomType.SelectedItem, ComboBoxItem).HiddenValue()
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Public Sub LoadAvailableRooms()
        'MyDataGridView_room.Columns.Clear()
        'Dim datTim1 As Date = txtDateArival.Value.ToShortDateString
        'Dim datTim2 As Date = txtdateCheckout.Value.ToShortDateString
        'Dim extra_night As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)


        'PopulateGridViewControls("Select", 20, "CHECKBOX", MyDataGridView_room, True, False)
        'PopulateGridViewControls("roomid", 0, "", MyDataGridView_room, False, True)
        'PopulateGridViewControls("hotelcifid", 0, "", MyDataGridView_room, False, True)
        'PopulateGridViewControls("roomtype", 0, "", MyDataGridView_room, False, True)
        'If GlobalEnableBookingroomblocking = True Then
        '    PopulateGridViewControls("Room No.", 10, "", MyDataGridView_room, True, True)
        'Else
        '    PopulateGridViewControls("Room No.", 10, "COMBO", MyDataGridView_room, True, True)
        'End If
        'PopulateGridViewControls("Description", 50, "", MyDataGridView_room, True, True)
        'PopulateGridViewControls("Rate Type", 70, "COMBO", MyDataGridView_room, True, True)
        'PopulateGridViewControls("rateid", 0, "", MyDataGridView_room, False, True)
        'PopulateGridViewControls("pernight", 0, "", MyDataGridView_room, False, True)
        'PopulateGridViewControls("Adult", 20, "", MyDataGridView_room, True, False)
        'PopulateGridViewControls("Child", 20, "", MyDataGridView_room, True, False)
        'PopulateGridViewControls("Extra Person", 20, "", MyDataGridView_room, True, False)
        'For i = 0 To extra_night - 1
        '    PopulateGridViewControls("DayAdultRate" & i + 1, 20, "", MyDataGridView_room, True, True)
        '    PopulateGridViewControls("DayChildRate" & i + 1, 20, "", MyDataGridView_room, True, True)
        '    PopulateGridViewControls("DayExtraRate" & i + 1, 20, "", MyDataGridView_room, True, True)
        '    PopulateGridViewControls("Day " & i + 1, 20, "", MyDataGridView_room, True, True)
        'Next
        'Dim row(13 + (extra_night * 4)) As Object
        'PopulateGridViewControls("Total Room Charge", 20, "", MyDataGridView_room, True, True)
        'PopulateGridViewControls("Hotel", 10, "", MyDataGridView_room, True, True)

        'MyDataGridView_room.Rows.Clear()
        'dst = Nothing : dst = New DataSet
        'msda = New MySqlDataAdapter("select *,(select count(*) from tblhotelrooms where roomtype='" & roomtype.Text & "' and hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and " _
        '               + " roomid not in (select roomid from tblhotelgrouproom where (" & TrapRoomQuery(txtDateArival.Value, txtdateCheckout.Value, "group") & ") and bookno<>'" & BookingNo & "' and cancelled=0) and " _
        '               + " roomid not in (select roomid from tblhotelroomtransaction where (" & TrapRoomQuery(txtDateArival.Value, txtdateCheckout.Value, "individual") & ") and bookingref<>'" & BookingNo & "' and closed=0 and cancelled=0) and " _
        '               + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(txtDateArival.Value, txtdateCheckout.Value) & ") and closed=0)) as cnt,(select companyname from tblclientaccounts where cifid=tblhotelroomtype.hotelcif) as hotel from tblhotelroomtype where code='" & roomtype.Text & "'", conn)
        'msda.Fill(dst, 0)
        'For cnt = 0 To dst.Tables(0).Rows.Count - 1
        '    With (dst.Tables(0))
        '        For i = 0 To .Rows(cnt)("cnt").ToString() - 1
        '            row(0) = False
        '            row(1) = ""
        '            row(2) = .Rows(cnt)("hotelcif").ToString()
        '            row(3) = .Rows(cnt)("code").ToString()
        '            row(4) = ""
        '            row(5) = .Rows(cnt)("Description").ToString()
        '            row(6) = ""
        '            row(7) = ""
        '            row(8) = 0
        '            row(9) = 0
        '            row(10) = 0
        '            row(11) = 0
        '            Dim col As Integer = 11
        '            For x = 1 To extra_night
        '                row(col + 1) = 0
        '                row(col + 2) = 0
        '                row(col + 3) = 0
        '                row(col + 4) = 0
        '                col = col + 4
        '            Next
        '            row(12 + (extra_night * 4)) = 0
        '            row(13 + (extra_night * 4)) = .Rows(cnt)("Hotel").ToString()
        '            MyDataGridView_room.Rows.Add(row)
        '        Next
        '    End With
        'Next
        'GridColumnAlignment(MyDataGridView_room, {"Adult", "Child", "Extra Person", "Room No."}, DataGridViewContentAlignment.MiddleCenter)
        'GridCurrencyColumn(MyDataGridView_room, {"Total Room Charge"})
        'If extra_night > 0 Then
        '    For i = 0 To extra_night - 1
        '        GridCurrencyColumn(MyDataGridView_room, {"Day " & i + 1})
        '    Next
        'End If
        'For rowIndex1 As Integer = 0 To MyDataGridView_room.Rows.Count - 1
        '    LoadToGridComboBoxCell("Room No.", rowIndex1, "select * from tblhotelrooms where roomtype='" & roomtype.Text & "' and hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and " _
        '           + " roomid not in (select roomid from tblhotelgrouproom where (" & TrapRoomQuery(txtDateArival.Value, txtdateCheckout.Value, "group") & ") and bookno<>'" & BookingNo & "' and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroomtransaction where  (" & TrapRoomQuery(txtDateArival.Value, txtdateCheckout.Value, "individual") & ") and bookingref<>'" & BookingNo & "' and closed=0 and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(txtDateArival.Value, txtdateCheckout.Value) & ") and closed=0)", "roomnumber", True, MyDataGridView_room)
        'Next

        'For rowIndex2 As Integer = 0 To MyDataGridView_room.Rows.Count - 1
        '    LoadToGridComboBoxCell("Rate Type", rowIndex2, "select concat(ratecode,' - ',description) as val from tblhotelroomrates where (roomtype='" & MyDataGridView_room.Rows(rowIndex2).Cells("roomtype").Value & "' and temporaryrate=0) or (roomtype='" & MyDataGridView_room.Rows(rowIndex2).Cells("roomtype").Value & "' and bookingno='" & BookingNo & "')", "val", False, MyDataGridView_room)
        'Next


        'da = Nothing : st = New DataSet
        'da = New MySqlDataAdapter("select *,(select concat(ratecode,' - ',description) from tblhotelroomrates where ratecode=tblhotelgrouproom.rateid) as rate from tblhotelgrouproom where bookno='" & BookingNo & "' and roomtype='" & roomtype.Text & "' and arival='" & ConvertDate(txtDateArival.Value) & "' and departure='" & ConvertDate(txtdateCheckout.Value) & "'", conn)
        'da.Fill(st, 0)
        'For nt = 0 To st.Tables(0).Rows.Count - 1
        '    MyDataGridView_room.Rows(nt).Cells("Select").Value = 1
        '    Dim cell As DataGridViewComboBoxCell = TryCast(MyDataGridView_room.Rows(nt).Cells("Room No."), DataGridViewComboBoxCell)
        '    If cell.Items.Contains(st.Tables(0).Rows(nt)("roomno").ToString()) Then
        '        MyDataGridView_room.Rows(nt).Cells("roomid").Value = st.Tables(0).Rows(nt)("roomid").ToString()
        '        MyDataGridView_room.Rows(nt).Cells("Room No.").Value = st.Tables(0).Rows(nt)("roomno").ToString()
        '        MyDataGridView_room.Rows(nt).Cells("Rate Type").Value = st.Tables(0).Rows(nt)("rate").ToString()

        '        'MyDataGridView_room.Item("pernight", nt).Value = CBool(rst("pernight"))
        '        MyDataGridView_room.Item("rateid", nt).Value = st.Tables(0).Rows(nt)("rateid").ToString()
        '        MyDataGridView_room.Rows(nt).Cells("Adult").Value = st.Tables(0).Rows(nt)("pax").ToString()
        '        MyDataGridView_room.Rows(nt).Cells("Child").Value = st.Tables(0).Rows(nt)("child").ToString()
        '        MyDataGridView_room.Rows(nt).Cells("Extra Person").Value = st.Tables(0).Rows(nt)("extra").ToString()

        '        Dim TotalRoomCharge As Double = 0
        '        For x = 1 To extra_night
        '            GridClearCell(MyDataGridView_room, {"DayAdultRate" & x, "DayChildRate" & x, "DayExtraRate" & x, "Day " & x}, nt, True)
        '            If countqry("tblhotelratesbreakdown as a inner join tblhotelroomrates as b on a.ratecode = b.ratecode", "b.ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and a.dayrate+1 = " & x & " group by dayrate;") = 0 Then
        '                If x > 1 Then
        '                    MyDataGridView_room.Item("DayAdultRate" & x, nt).Value = MyDataGridView_room.Item("DayAdultRate" & x - 1, nt).Value
        '                    MyDataGridView_room.Item("DayChildRate" & x, nt).Value = MyDataGridView_room.Item("DayChildRate" & x - 1, nt).Value
        '                    MyDataGridView_room.Item("DayExtraRate" & x, nt).Value = MyDataGridView_room.Item("DayExtraRate" & x - 1, nt).Value
        '                    If CBool(MyDataGridView_room.Item("pernight", nt).Value) = True Then
        '                        MyDataGridView_room.Item("Day " & x, nt).Value = Val(MyDataGridView_room.Item("DayAdultRate" & x - 1, nt).Value) + (MyDataGridView_room.Item("Child", nt).Value * Val(MyDataGridView_room.Item("DayChildRate" & x - 1, nt).Value)) + (MyDataGridView_room.Item("Extra Person", nt).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x - 1, nt).Value))
        '                    Else
        '                        MyDataGridView_room.Item("Day " & x, nt).Value = (MyDataGridView_room.Item("Adult", nt).Value * Val(MyDataGridView_room.Item("DayAdultRate" & x - 1, nt).Value)) + (MyDataGridView_room.Item("Child", nt).Value * Val(MyDataGridView_room.Item("DayChildRate" & x - 1, nt).Value)) + (MyDataGridView_room.Item("Extra Person", nt).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x - 1, nt).Value))
        '                    End If
        '                End If
        '            Else
        '                com.CommandText = "SELECT b.ratecode,b.description,(select chargepernight from tblhotelroomtype where code=b.roomtype) as pernight, a.dayrate+1 as 'Day'," _
        '                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=a.dayrate),0) as 'RoomRate', " _
        '                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=a.dayrate),0) as 'ChildRate', " _
        '                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=a.dayrate),0) as 'ExtraPersonRate' " _
        '                                                    + " FROM `tblhotelratesbreakdown` as a inner join tblhotelroomrates as b on a.ratecode = b.ratecode  where b.ratecode='" & st.Tables(0).Rows(nt)("rateid").ToString() & "' and a.dayrate+1 = " & x & " group by dayrate;" : rst = com.ExecuteReader
        '                While rst.Read
        '                    MyDataGridView_room.Item("pernight", nt).Value = CBool(rst("pernight"))
        '                    MyDataGridView_room.Item("rateid", nt).Value = rst("ratecode").ToString
        '                    MyDataGridView_room.Item("DayAdultRate" & rst("Day").ToString, nt).Value = rst("RoomRate").ToString
        '                    MyDataGridView_room.Item("DayChildRate" & rst("Day").ToString, nt).Value = rst("ChildRate").ToString
        '                    MyDataGridView_room.Item("DayExtraRate" & rst("Day").ToString, nt).Value = rst("ExtraPersonRate").ToString
        '                    If CBool(rst("pernight")) = True Then
        '                        MyDataGridView_room.Item("Day " & rst("Day").ToString, nt).Value = Val(rst("RoomRate").ToString) + (MyDataGridView_room.Item("Child", nt).Value * Val(rst("ChildRate").ToString)) + (MyDataGridView_room.Item("Extra Person", nt).Value * Val(rst("ExtraPersonRate").ToString))
        '                    Else
        '                        MyDataGridView_room.Item("Day " & rst("Day").ToString, nt).Value = (MyDataGridView_room.Item("Adult", nt).Value * Val(rst("RoomRate").ToString)) + (MyDataGridView_room.Item("Child", nt).Value * Val(rst("ChildRate").ToString)) + (MyDataGridView_room.Item("Extra Person", nt).Value * Val(rst("ExtraPersonRate").ToString))
        '                    End If
        '                End While
        '                rst.Close()
        '            End If
        '            TotalRoomCharge = TotalRoomCharge + Val(CC(MyDataGridView_room.Item("Day " & x, nt).Value))
        '        Next
        '        MyDataGridView_room.Item("Total Room Charge", nt).Value = TotalRoomCharge
        '        GridColumAutonWidth(MyDataGridView_room, {"Rate Type"})
        '        EnableRow(nt)
        '    End If
        'Next

    End Sub


    Public Sub EnableRow(ByVal rowIndex As Integer)
        MyDataGridView_room.Rows(rowIndex).Cells("Rate Type").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Adult").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Child").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Extra Person").ReadOnly = False
    End Sub
    Private Sub MyDataGridView_room_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_room.CellClick
        If DirectCast(MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Room No.").ReadOnly = False
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Rate Type").ReadOnly = False
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Adult").ReadOnly = False
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Child").ReadOnly = False
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Extra Person").ReadOnly = False
        Else
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Rate Type").ReadOnly = True
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Adult").ReadOnly = True
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Child").ReadOnly = True
            MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Extra Person").ReadOnly = True
        End If
    End Sub

    Private Sub MyDataGridView_room_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_room.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_room.CurrentCell = Me.MyDataGridView_room.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles MyDataGridView_room.EditingControlShowing
        If MyDataGridView_room.CurrentCell.ColumnIndex = 6 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
        If MyDataGridView_room.CurrentCell.ColumnIndex = 4 Then
            Dim roomCombo As ComboBox = CType(e.Control, ComboBox)
            If (roomCombo IsNot Nothing) Then
                RemoveHandler roomCombo.SelectionChangeCommitted, New EventHandler(AddressOf Room_SelectionChangeCommitted)
                AddHandler roomCombo.SelectionChangeCommitted, New EventHandler(AddressOf Room_SelectionChangeCommitted)
            End If
        End If
        If TypeOf e.Control Is System.Windows.Forms.TextBox Then
            With DirectCast(e.Control, System.Windows.Forms.TextBox)
                .BackColor = Color.Gold
                MyDataGridView_room.Item("Total Room Charge", MyDataGridView_room.CurrentRow.Index).Style.BackColor = Color.Gold
            End With
        End If
    End Sub

    Private Sub Room_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        com.CommandText = "select * from tblhotelrooms where roomtype='" & roomtype.Text & "' and roomnumber='" & rchar(combo.SelectedItem) & "'" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView_room.Item("roomid", MyDataGridView_room.CurrentRow.Index).Value = rst("roomid").ToString
        End While
        rst.Close()
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles MyDataGridView_room.CellValueChanged
        Dim datTim1 As Date = txtDateArival.Value.ToShortDateString
        Dim datTim2 As Date = txtdateCheckout.Value.ToShortDateString
        Dim extra_night As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)
        Dim TotalRoomCharge As Double = 0
        For x = 1 To extra_night
            If CBool(MyDataGridView_room.Item("pernight", MyDataGridView_room.CurrentRow.Index).Value) = True Then
                MyDataGridView_room.Item("Day " & x, MyDataGridView_room.CurrentRow.Index).Value = Val(MyDataGridView_room.Item("DayAdultRate" & x, MyDataGridView_room.CurrentRow.Index).Value) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayChildRate" & x, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x, MyDataGridView_room.CurrentRow.Index).Value))
            Else
                MyDataGridView_room.Item("Day " & x, MyDataGridView_room.CurrentRow.Index).Value = (MyDataGridView_room.Item("Adult", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayAdultRate" & x, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayChildRate" & x, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x, MyDataGridView_room.CurrentRow.Index).Value))
            End If
            TotalRoomCharge = TotalRoomCharge + Val(CC(MyDataGridView_room.Item("Day " & x, MyDataGridView_room.CurrentRow.Index).Value))
        Next
        MyDataGridView_room.Item("Total Room Charge", MyDataGridView_room.CurrentRow.Index).Value = TotalRoomCharge
    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim datTim1 As Date = txtDateArival.Value.ToShortDateString
        Dim datTim2 As Date = txtdateCheckout.Value.ToShortDateString
        Dim extra_night As Integer = DateDiff(DateInterval.Day, datTim1, datTim2)
        For x = 1 To extra_night
            GridClearCell(MyDataGridView_room, {"DayAdultRate" & x, "DayChildRate" & x, "DayExtraRate" & x, "Day " & x}, MyDataGridView_room.CurrentRow.Index, True)
            If countqry("tblhotelratesbreakdown as a inner join tblhotelroomrates as b on a.ratecode = b.ratecode", "concat(b.ratecode,' - ',b.description)='" & rchar(combo.SelectedItem) & "' and a.dayrate+1 = " & x & " group by dayrate;") = 0 Then
                If x > 1 Then
                    MyDataGridView_room.Item("DayAdultRate" & x, MyDataGridView_room.CurrentRow.Index).Value = MyDataGridView_room.Item("DayAdultRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value
                    MyDataGridView_room.Item("DayChildRate" & x, MyDataGridView_room.CurrentRow.Index).Value = MyDataGridView_room.Item("DayChildRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value
                    MyDataGridView_room.Item("DayExtraRate" & x, MyDataGridView_room.CurrentRow.Index).Value = MyDataGridView_room.Item("DayExtraRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value
                    If CBool(MyDataGridView_room.Item("pernight", MyDataGridView_room.CurrentRow.Index).Value) = True Then
                        MyDataGridView_room.Item("Day " & x, MyDataGridView_room.CurrentRow.Index).Value = Val(MyDataGridView_room.Item("DayAdultRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayChildRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value))
                    Else
                        MyDataGridView_room.Item("Day " & x, MyDataGridView_room.CurrentRow.Index).Value = (MyDataGridView_room.Item("Adult", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayAdultRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayChildRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(MyDataGridView_room.Item("DayExtraRate" & x - 1, MyDataGridView_room.CurrentRow.Index).Value))
                    End If
                End If
            Else
                com.CommandText = "SELECT b.ratecode,b.description,(select chargepernight from tblhotelroomtype where code=b.roomtype) as pernight, a.dayrate+1 as 'Day'," _
                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='roomrate' and dayrate=a.dayrate),0) as 'RoomRate', " _
                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='child' and dayrate=a.dayrate),0) as 'ChildRate', " _
                                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=a.ratecode and breakdowntype='extra' and dayrate=a.dayrate),0) as 'ExtraPersonRate' " _
                                                    + " FROM `tblhotelratesbreakdown` as a inner join tblhotelroomrates as b on a.ratecode = b.ratecode  where concat(b.ratecode,' - ',b.description)='" & rchar(combo.SelectedItem) & "' and a.dayrate+1 = " & x & " group by dayrate;" : rst = com.ExecuteReader
                While rst.Read
                    MyDataGridView_room.Item("pernight", MyDataGridView_room.CurrentRow.Index).Value = CBool(rst("pernight"))
                    MyDataGridView_room.Item("rateid", MyDataGridView_room.CurrentRow.Index).Value = rst("ratecode").ToString
                    MyDataGridView_room.Item("DayAdultRate" & rst("Day").ToString, MyDataGridView_room.CurrentRow.Index).Value = rst("RoomRate").ToString
                    MyDataGridView_room.Item("DayChildRate" & rst("Day").ToString, MyDataGridView_room.CurrentRow.Index).Value = rst("ChildRate").ToString
                    MyDataGridView_room.Item("DayExtraRate" & rst("Day").ToString, MyDataGridView_room.CurrentRow.Index).Value = rst("ExtraPersonRate").ToString
                    If CBool(rst("pernight")) = True Then
                        MyDataGridView_room.Item("Day " & rst("Day").ToString, MyDataGridView_room.CurrentRow.Index).Value = Val(rst("RoomRate").ToString) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(rst("ChildRate").ToString)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(rst("ExtraPersonRate").ToString))
                    Else
                        MyDataGridView_room.Item("Day " & rst("Day").ToString, MyDataGridView_room.CurrentRow.Index).Value = (MyDataGridView_room.Item("Adult", MyDataGridView_room.CurrentRow.Index).Value * Val(rst("RoomRate").ToString)) + (MyDataGridView_room.Item("Child", MyDataGridView_room.CurrentRow.Index).Value * Val(rst("ChildRate").ToString)) + (MyDataGridView_room.Item("Extra Person", MyDataGridView_room.CurrentRow.Index).Value * Val(rst("ExtraPersonRate").ToString))
                    End If
                End While
                rst.Close()
            End If
        Next
    End Sub


    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click

        'Dim I = 0
        'For I = 0 To MyDataGridView_room.RowCount - 1
        '    If DirectCast(MyDataGridView_room.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 And MyDataGridView_room.Item("Rate Type", I).Value = "" Then
        '        MessageBox.Show("There are room rate currently not selected on checked items", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        'Next
        'Dim checkedCount As Integer = 0
        'For x = 0 To MyDataGridView_room.RowCount - 1
        '    If DirectCast(MyDataGridView_room.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
        '        checkedCount += 1
        '    End If
        'Next
        'Dim arr(checkedCount + 1) As String
        'If checkedCount > 0 Then
        '    For I = 0 To checkedCount - 1
        '        arr(I) = MyDataGridView_room.Item("roomid", I).Value
        '    Next
        '    If ContainsDups(arr) = True Then
        '        MessageBox.Show("Room Conflict. some room number already selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        arr = Nothing
        '        Exit Sub
        '    End If
        'End If
        'arr = Nothing
        'If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
        '    com.CommandText = "DELETE from tblhotelgrouproom where bookno='" & BookingNo & "' and roomtype='" & roomtype.Text & "' and confirmed=0" : com.ExecuteNonQuery()
        '    For I = 0 To MyDataGridView_room.RowCount - 1
        '        If DirectCast(MyDataGridView_room.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
        '            com.CommandText = "insert into tblhotelgrouproom set bookno='" & BookingNo & "', arival='" & ConvertDate(txtDateArival.Value) & "',departure='" & ConvertDate(txtdateCheckout.Value) & "',hotelcif='" & MyDataGridView_room.Item("hotelcifid", I).Value & "',roomid='" & MyDataGridView_room.Item("roomid", I).Value & "',roomno='" & MyDataGridView_room.Item("Room No.", I).Value & "',description='" & MyDataGridView_room.Item("Description", I).Value & "', roomtype='" & MyDataGridView_room.Item("roomtype", I).Value & "',chargepernight=" & CBool(MyDataGridView_room.Item("pernight", I).Value) & ", rateid='" & MyDataGridView_room.Item("rateid", I).Value & "', pax='" & Val(CC(MyDataGridView_room.Item("Adult", I).Value)) & "', child='" & Val(CC(MyDataGridView_room.Item("Child", I).Value)) & "', extra='" & Val(CC(MyDataGridView_room.Item("Extra Person", I).Value)) & "', trnby='" & globaluserid & "', dateposted=current_timestamp" : com.ExecuteNonQuery()
        '        End If
        '    Next
        '    frmHotelGroupCheckin.FilterRoom()
        '    MessageBox.Show("Room selection successfully updated", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.Close()
        'End If


    End Sub
    Public Function ContainsDups(ByVal strArray() As String) As Boolean
        Dim tmp As New ArrayList
        For Each str As String In strArray
            If str <> "" Then
                If tmp.Contains(str) Then
                    Return True
                Else
                    tmp.Add(str)
                End If
            End If
        Next
    End Function

    Private Sub txtDateArival_Validated(sender As Object, e As EventArgs) Handles txtDateArival.Validated, txtdateCheckout.Validated
        txtdateCheckout.MinDate = txtDateArival.Value.AddDays(1)
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DoHeavyWork()
    End Sub

    'UPDATE PROGRESSBAR OR ANY UI COMPONENT
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub
    'CALLED WHEN WORK IS OVER
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'CHECKED IF CANCELLED,ERROR OR FINISHED
        If e.Cancelled = True Then
            MessageBox.Show("cancelled")

        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.Message)
        Else
            'Panel1.Visible = False
            'Panel1.BackColor = Color.FromArgb(200, 100, 100, 100)
        End If
    End Sub

    Private Sub DoHeavyWork()
        System.Threading.Thread.Sleep(100)
        Execute_ThreadSafe()
    End Sub

    Private Sub txtdateCheckout_ValueChanged(sender As Object, e As EventArgs) Handles txtdateCheckout.ValueChanged

    End Sub
End Class