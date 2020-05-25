Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmHotelRoomTariff

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
       
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ShowRoomList()
    End Sub
    Public Sub ShowRoomList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select (select description from tblhotelroomtype where code=tblhotelroomrates.roomtype) as 'Room Type', Description as 'Package Name', " _
                                    + " (select if(chargepernight=1,'Night','Pax') from tblhotelroomtype where code=tblhotelroomrates.roomtype) as 'Rate Type', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='roomrate'),0) as 'Room Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='child'),0) as 'Child Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='extra'),0) as 'Extra Person Rate', " _
                                    + " ifnull((select sum(amount) from tblhotelratesbreakdown where ratecode=tblhotelroomrates.ratecode and breakdowntype='night'),0) as 'Extra Night'  " _
                                    + "  from tblhotelroomrates  where actived =1 and temporaryrate=0 order by (select description from tblhotelroomtype where code=tblhotelroomrates.roomtype) asc;", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Room Rate", "Child Rate", "Extra Person Rate", "Extra Night"})

        For i = 0 To MyDataGridView.Columns.Count - 1
            MyDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        PaintColumnFormat()
    End Sub
    Public Sub PaintColumnFormat()

        GridColumnWidth(MyDataGridView, {"Room Rate", "Child Rate", "Extra Person", "Extra Night"}, 80)
        GridColumnWidth(MyDataGridView, {"Room Type"}, 150)

        Dim column As Array = {"Rate Type", "Room Type", "Room Rate", "Child Rate", "Extra Person Rate", "Extra Night"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        GridColumnWidth(MyDataGridView, {"Package Name"}, MyDataGridView.Width - TotalVisibleColumn)
    End Sub
    Private Sub MyDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MyDataGridView.CellFormatting
        If e.RowIndex > 0 And e.ColumnIndex = 0 Then
            If MyDataGridView.Item(0, e.RowIndex - 1).Value = e.Value Then
                e.Value = ""
            ElseIf e.RowIndex < MyDataGridView.Rows.Count - 1 Then
                MyDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub
 
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/>", Me.Text, "", MyDataGridView, Me)
    End Sub

 
    Private Sub frmHotelRoomTariff_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PaintColumnFormat()
    End Sub
End Class