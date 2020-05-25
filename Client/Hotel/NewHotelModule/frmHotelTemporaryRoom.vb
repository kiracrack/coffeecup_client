Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmHotelTemporaryRoom
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmHotelAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadUnprocessedRooms()
    End Sub
    Public Sub LoadUnprocessedRooms()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select folioid, foliono as 'Folio No',roomno as 'Room Number', shortcode as 'Room Type', (select fullname from tblhotelguest where guestid=tblhotelfolioroom.guestid) as Guest, dateposted as 'Date Posted', (select fullname from tblaccounts where accountid=tblhotelfolioroom.trnby) as 'Transaction By'  from tblhotelfolioroom where foliono <>'" & foliono.Text & "' and foliono not in (select foliono from tblhotelfolioguest);", conn)
        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"folioid"})
        GridColumnAlignment(MyDataGridView, {"Folio No", "Room Number", "Room Type", "Date Posted"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
            com.CommandText = "DELETE FROM tblhotelfolioroom where folioid='" & rw.Cells("folioid").Value.ToString & "'" : com.ExecuteNonQuery()
        Next
        LoadUnprocessedRooms()

        If Not frmHotelPickMultipleRoom.BackgroundWorker1.IsBusy = True Then
            frmHotelPickMultipleRoom.BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
End Class
