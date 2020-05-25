Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelUpgradePickRoom
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
        ShowRoomList()
    End Sub

    Public Sub ShowRoomList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select roomid, roomnumber as 'Room Number',Cluster,  Description, roomstatus as 'Room Status', Remarks from tblhotelrooms where  hotelcifid in (select hotelcif from tblhotelfilter where permissioncode='" & globalAuthcode & "') and (roomnumber like '%" & rchar(txtsearch.Text) & "%' or roomstatus  like '%" & rchar(txtsearch.Text) & "%'  or description like '%" & rchar(txtsearch.Text) & "%' ) " _
                                        + " and roomid not in (select roomid from tblhotelfolioroom where (" & TrapRoomQuery(txtDateArival.Value, txtdateCheckout.Value) & ") and folioid<>'" & folioid.Text & "' and arival>=current_date  and cancelled=0) and " _
                                        + " roomid not in (select roomid from tblhotelroommaintainance where (" & TrapRoomMaintainanceQuery(txtDateArival.Value, txtdateCheckout.Value) & ") and closed=0) order by roomid asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        GridColumAutonWidth(MyDataGridView, {"Room Number", "Cluster", "Description", "Room Status", "Remarks"})
        GridColumnAlignment(MyDataGridView, {"Room Number", "Room Status", "Cluster"}, DataGridViewContentAlignment.MiddleCenter)
        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        PaintColumnFormat()
    End Sub
    Public Sub PaintColumnFormat()
        GridHideColumn(MyDataGridView, {"roomid"})
        GridColumnWidth(MyDataGridView, {"roomid"}, 0)
        GridColumAutonWidth(MyDataGridView, {"roomid", "Cluster", "Occupied", "Maintainance", "Room Status", "Remarks"})
        GridColumnWidth(MyDataGridView, {"Room Number"}, 40)

        Dim column As Array = {"roomid", "Room Number", "Cluster", "Description", "Occupied", "Maintainance", "Room Status", "Remarks"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        If TotalVisibleColumn > MyDataGridView.Width Then
            GridColumnWidth(MyDataGridView, {"Description"}, 300)
        Else
            GridColumnWidth(MyDataGridView, {"Description"}, MyDataGridView.Width - TotalVisibleColumn)
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmHotelChangeRoom.newroomid.Text = MyDataGridView.Item("roomid", MyDataGridView.CurrentRow.Index).Value().ToString
            frmHotelChangeRoom.txtRoomNumber.Text = MyDataGridView.Item("Room Number", MyDataGridView.CurrentRow.Index).Value().ToString
            If frmHotelChangeRoom.CheckRoomAvailability() = True Then
                frmHotelChangeRoom.ShowRoomInfo()
                frmHotelChangeRoom.txtRemarks.Focus()
                Me.Close()
            Else
                Exit Sub
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowRoomList()
        End If
    End Sub

    Private Sub frmHotelPickRoom_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PaintColumnFormat()
    End Sub
End Class