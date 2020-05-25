Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Text

Public Class frmHotelPickRoomGroup
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
        txtDateArival.MinDate = frmHotelGroupCheckin.txtDateArival.Value
        txtDateArival.MaxDate = frmHotelGroupCheckin.txtdateCheckout.Value
        txtdateCheckout.MinDate = frmHotelGroupCheckin.txtDateArival.Value
        txtdateCheckout.MaxDate = frmHotelGroupCheckin.txtdateCheckout.Value

        PopulateGridViewControls("Select", 20, "CHECKBOX", MyDataGridView_room, True, False)
        PopulateGridViewControls("roomid", 0, "", MyDataGridView_room, False, True)
        PopulateGridViewControls("hotelcifid", 0, "", MyDataGridView_room, False, True)
        PopulateGridViewControls("roomtype", 0, "", MyDataGridView_room, False, True)
        If GlobalEnableBookingroomblocking = True Then
            PopulateGridViewControls("Room No.", 10, "", MyDataGridView_room, True, True)
        Else
            PopulateGridViewControls("Room No.", 10, "COMBO", MyDataGridView_room, True, True)
        End If
        PopulateGridViewControls("Description", 50, "", MyDataGridView_room, True, True)
        PopulateGridViewControls("Rate Type", 70, "COMBO", MyDataGridView_room, True, True)
        PopulateGridViewControls("rateid", 0, "", MyDataGridView_room, False, True)
        PopulateGridViewControls("Package Rate", 30, "", MyDataGridView_room, True, True)
        PopulateGridViewControls("Adult", 20, "", MyDataGridView_room, True, False)
        PopulateGridViewControls("Child", 20, "", MyDataGridView_room, True, False)
        PopulateGridViewControls("Extra Person", 20, "", MyDataGridView_room, True, False)
        PopulateGridViewControls("Hotel", 10, "", MyDataGridView_room, True, True)
        PopulateGridViewControls("pernight", 0, "", MyDataGridView_room, False, True)
        PopulateGridViewControls("Room Status", 10, "", MyDataGridView_room, True, True)
        PopulateGridViewControls("Room Remarks", 10, "", MyDataGridView_room, True, True)
        LoadRoomType()
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Public Sub LoadRoomType()
        LoadToComboBoxDB("select code, ucase(description) as room_type from tblhotelroomtype where hotelcif in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') ", "room_type", "code", txtRoomType)
        Dim strroomtype As String = "" : Dim strRoomTypecode As String = ""
        If countqry("tblhotelgrouproom", " bookno='" & BookingNo & "' and cancelled=0") > 0 Then
            com.CommandText = "select ucase(description) as room_type from tblhotelgrouproom where roomtype='" & roomtype.Text & "' and bookno='" & BookingNo & "' limit 1" : rst = com.ExecuteReader
            While rst.Read
                strroomtype = rst("room_type").ToString
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
        'If txtDateArival.Text = "" Or txtdateCheckout.Text = "" Then Exit Sub
        'MyDataGridView_room.Rows.Clear()
        'dst = Nothing : dst = New DataSet
        'msda = New MySqlDataAdapter("select *,(select count(*) from tblhotelrooms where roomtype='" & roomtype.Text & "' and hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and " _
        '           + " roomid not in (select roomid from tblhotelgrouproom where (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value)) & ") and bookno<>'" & BookingNo & "' and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroomtransaction where (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value), "individual") & ") and bookingref<>'" & BookingNo & "' and closed=0 and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value)) & ") and closed=0)) as cnt,(select companyname from tblclientaccounts where cifid=tblhotelroomtype.hotelcif) as hotel from tblhotelroomtype where code='" & roomtype.Text & "'", conn)
        'msda.Fill(dst, 0)
        'For cnt = 0 To dst.Tables(0).Rows.Count - 1
        '    With (dst.Tables(0))
        '        For i = 0 To .Rows(cnt)("cnt").ToString() - 1
        '            MyDataGridView_room.Rows.Add(False, "", .Rows(cnt)("hotelcif").ToString(), .Rows(cnt)("code").ToString(), "", .Rows(cnt)("Description").ToString(), "", "", 0, 0, 0, 0, .Rows(cnt)("Hotel").ToString(), 0, "", "")
        '        Next
        '    End With
        'Next
        'GridCurrencyColumn(MyDataGridView_room, {"Package Rate"})
        'For rowIndexx As Integer = 0 To MyDataGridView_room.Rows.Count - 1
        '    LoadToGridComboBoxCell("Room No.", rowIndexx, "select * from tblhotelrooms where roomtype='" & roomtype.Text & "' and hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and " _
        '           + " roomid not in (select roomid from tblhotelgrouproom where (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value), "group") & ") and bookno<>'" & BookingNo & "' and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroomtransaction where  (" & TrapRoomQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value), "individual") & ") and bookingref<>'" & BookingNo & "' and closed=0 and cancelled=0) and " _
        '           + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(ConvertDate(txtDateArival.Value), ConvertDate(txtdateCheckout.Value)) & ") and closed=0)", "roomnumber", True, MyDataGridView_room)
        'Next


        'For rowIndexr As Integer = 0 To MyDataGridView_room.Rows.Count - 1
        '    LoadToGridComboBoxCell("Rate Type", rowIndexr, "select concat(ratecode,' - ',description) as val from tblhotelroomrates where (roomtype='" & MyDataGridView_room.Rows(rowIndexr).Cells("roomtype").Value & "' and temporaryrate=0) or (roomtype='" & MyDataGridView_room.Rows(rowIndexr).Cells("roomtype").Value & "' and bookingno='" & BookingNo & "') order by description asc", "val", False, MyDataGridView_room)
        'Next
        'GridColumnAlignment(MyDataGridView_room, {"Adult", "Child", "Extra Person", "Room No.", "Room Status"}, DataGridViewContentAlignment.MiddleCenter)


        'Dim rowIndex As Integer = 0
        'Dim roomid As String = "" : Dim roomno As String = ""
        'com.CommandText = "select *,ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelgrouproom.rateid and breakdowntype='roomrate' and dayrate=0),0) as roomrate,concat(ratecode,' - ',tblhotelroomrates.description) as rate,(select chargepernight from tblhotelroomtype where code=tblhotelroomrates.roomtype) as pernight " _
        '                         + "  from tblhotelgrouproom inner join tblhotelroomrates on ratecode=tblhotelgrouproom.rateid where bookno='" & BookingNo & "' and tblhotelgrouproom.arival='" & ConvertDate(txtDateArival.Value) & "' and tblhotelgrouproom.departure='" & ConvertDate(txtdateCheckout.Value) & "'  and tblhotelgrouproom.roomtype='" & roomtype.Text & "' and cancelled=0 and confirmed=0" : rst = com.ExecuteReader
        'While rst.Read
        '    MyDataGridView_room.Rows(rowIndex).Cells("Select").Value = 1
        '    Dim cell As DataGridViewComboBoxCell = TryCast(MyDataGridView_room.Rows(rowIndex).Cells("Room No."), DataGridViewComboBoxCell)
        '    If cell.Items.Contains(rst("roomno").ToString) Then
        '        MyDataGridView_room.Rows(rowIndex).Cells("roomid").Value = rst("roomid").ToString
        '        MyDataGridView_room.Rows(rowIndex).Cells("Room No.").Value = rst("roomno").ToString
        '        MyDataGridView_room.Rows(rowIndex).Cells("Rate Type").Value = rst("rate").ToString
        '        MyDataGridView_room.Rows(rowIndex).Cells("Package Rate").Value = FormatNumber(rst("roomrate").ToString, 2)

        '        MyDataGridView_room.Item("pernight", rowIndex).Value = CBool(rst("pernight"))
        '        MyDataGridView_room.Item("rateid", rowIndex).Value = rst("ratecode").ToString


        '        MyDataGridView_room.Rows(rowIndex).Cells("Adult").Value = rst("pax").ToString
        '        MyDataGridView_room.Rows(rowIndex).Cells("Child").Value = rst("child").ToString
        '        MyDataGridView_room.Rows(rowIndex).Cells("Extra Person").Value = rst("extra").ToString

        '        GridColumAutonWidth(MyDataGridView_room, {"Rate Type"})
        '        EnableRow(rowIndex)
        '    End If
        '    rowIndex += 1
        'End While
        'rst.Close()


    End Sub

    Public Sub EnableRow(ByVal rowIndex As Integer)
        MyDataGridView_room.Rows(rowIndex).Cells("Rate Type").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Adult").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Child").ReadOnly = False
        MyDataGridView_room.Rows(rowIndex).Cells("Extra Person").ReadOnly = False
    End Sub
    Private Sub MyDataGridView_room_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView_room.CellClick
        If DirectCast(MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
            If GlobalEnableBookingroomblocking = True Then
                MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Room No.").ReadOnly = True
            Else
                MyDataGridView_room.Rows(MyDataGridView_room.CurrentRow.Index).Cells("Room No.").ReadOnly = False
            End If
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
        'If MyDataGridView_room.CurrentCell.ColumnIndex = 4 Then
        '    Dim roomno As ComboBox = CType(e.Control, ComboBox)
        '    If (roomno IsNot Nothing) Then
        '        RemoveHandler roomno.SelectionChangeCommitted, New EventHandler(AddressOf RoomNo_SelectionChangeCommitted)
        '        AddHandler roomno.SelectionChangeCommitted, New EventHandler(AddressOf RoomNo_SelectionChangeCommitted)
        '    End If
        'End If
        If MyDataGridView_room.CurrentCell.ColumnIndex = 4 Then
            Dim roomCombo As ComboBox = CType(e.Control, ComboBox)
            If (roomCombo IsNot Nothing) Then
                RemoveHandler roomCombo.SelectionChangeCommitted, New EventHandler(AddressOf Room_SelectionChangeCommitted)
                AddHandler roomCombo.SelectionChangeCommitted, New EventHandler(AddressOf Room_SelectionChangeCommitted)
            End If
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

    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        com.CommandText = "select *,ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate' and dayrate=0),0) as roomrate,(select chargepernight from tblhotelroomtype where code=tblhotelroomrates.roomtype) as pernight  from tblhotelroomrates where concat(ratecode,' - ',description)='" & rchar(combo.SelectedItem) & "'" : rst = com.ExecuteReader
        While rst.Read
            MyDataGridView_room.Item("pernight", MyDataGridView_room.CurrentRow.Index).Value = CBool(rst("pernight"))
            MyDataGridView_room.Item("rateid", MyDataGridView_room.CurrentRow.Index).Value = rst("ratecode").ToString
            MyDataGridView_room.Item("Package Rate", MyDataGridView_room.CurrentRow.Index).Value = FormatNumber(rst("roomrate").ToString, 2)
        End While
        rst.Close()
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        Dim I = 0
        For I = 0 To MyDataGridView_room.RowCount - 1
            If DirectCast(MyDataGridView_room.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 And MyDataGridView_room.Item("Rate Type", I).Value = "" Then
                MessageBox.Show("There are Package Rate currently not selected on checked items", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next
        Dim checkedCount As Integer = 0
        For x = 0 To MyDataGridView_room.RowCount - 1
            If DirectCast(MyDataGridView_room.Rows(x).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                checkedCount += 1
            End If
        Next
        Dim arr(checkedCount + 1) As String
        If checkedCount > 0 Then
            For I = 0 To checkedCount - 1
                arr(I) = MyDataGridView_room.Item("roomid", I).Value
            Next
            If ContainsDups(arr) = True Then
                MessageBox.Show("Room Conflict. some room number already selected", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                arr = Nothing
                Exit Sub
            End If
        End If
        arr = Nothing
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "DELETE from tblhotelgrouproom where bookno='" & BookingNo & "' and roomtype='" & roomtype.Text & "' and arival='" & ConvertDate(txtDateArival.Value) & "' and departure='" & ConvertDate(txtdateCheckout.Value) & "' and confirmed=0" : com.ExecuteNonQuery()
            For I = 0 To MyDataGridView_room.RowCount - 1
                If DirectCast(MyDataGridView_room.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                    com.CommandText = "insert into tblhotelgrouproom set bookno='" & BookingNo & "', arival='" & ConvertDate(txtDateArival.Value) & "',departure='" & ConvertDate(txtdateCheckout.Value) & "',hotelcif='" & MyDataGridView_room.Item("hotelcifid", I).Value & "',roomid='" & MyDataGridView_room.Item("roomid", I).Value & "',roomno='" & MyDataGridView_room.Item("Room No.", I).Value & "',description='" & txtRoomType.Text & "', roomtype='" & MyDataGridView_room.Item("roomtype", I).Value & "',chargepernight=" & CBool(MyDataGridView_room.Item("pernight", I).Value) & ", rateid='" & MyDataGridView_room.Item("rateid", I).Value & "', pax='" & Val(CC(MyDataGridView_room.Item("Adult", I).Value)) & "', child='" & Val(CC(MyDataGridView_room.Item("Child", I).Value)) & "', extra='" & Val(CC(MyDataGridView_room.Item("Extra Person", I).Value)) & "', trnby='" & globaluserid & "', dateposted=current_timestamp" : com.ExecuteNonQuery()
                End If
            Next
            UpdateFolioSummary(BookingNo)
            frmHotelGroupCheckin.FilterRoom()
            MessageBox.Show("Room selection successfully updated", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If


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

    Private Sub txtDateArival_ValueChanged(sender As Object, e As EventArgs) Handles txtDateArival.ValueChanged, txtdateCheckout.ValueChanged
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

    Private Sub cmdPackages_Click(sender As Object, e As EventArgs) Handles cmdPackages.Click
        frmHotelCustomPackage.ShowDialog(Me)
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub
End Class