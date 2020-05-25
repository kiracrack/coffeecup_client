Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelVipSelectFolio
    Public TransactionDone As Boolean = False
    
    Private Sub frmHotelVipSelectFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        MyDataGridView.Focus()
    End Sub

    Public Sub LoadFolio()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select folioid as 'Folio No', ifnull((select roomnumber from tblhotelrooms where roomid  = tblhotelroomtransaction.roomid),'-') as 'Room No.', " _
                           + " ifnull(((select sum(debit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0 and appliedcoupon=0) - (select sum(credit) from tblhoteltransaction where folioid = tblhotelroomtransaction.folioid and cancelled=0)),0) as 'Open Balance'  " _
                           + " from tblhotelroomtransaction where closed=0 and vip=1 and guestid='" & guestid.Text & "' and hotelcif='" & hotelcifid.Text & "'", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Folio No", "Room No."}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Open Balance"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView, {"Open Balance"})
    End Sub

    Private Sub guestid_TextChanged(sender As Object, e As EventArgs) Handles guestid.TextChanged
        LoadFolio()
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Hide()

        End If

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
        Return
    End Sub
       
End Class