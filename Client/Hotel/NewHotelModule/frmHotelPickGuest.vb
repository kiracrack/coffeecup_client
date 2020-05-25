Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelPickGuest

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
      
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSPaymentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
    End Sub
    Public Sub ShowGuestList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        Dim hotelquery As String = ""
        msda = New MySqlDataAdapter("select guestid, fullname as 'Guest Name', Address, Birthdate, Gender, contactnumber as 'Contact Number',emailadd as 'Email Address', (select countryname from tblcountries where countrycode=tblhotelguest.countrycode) as 'Country', Nationality, vipguest as 'VIP',(select description from tblhotelviptype where vipcode=tblhotelguest.viptype) as 'Vip Card Type', vipcardno as 'Vip Card No.', vipcreditlimit as 'Credit Limit'  from tblhotelguest where deleted=0 and " _
                                    + " (fullname like '%" & rchar(txtsearch.Text) & "%' or " _
                                    + " Address like '%" & rchar(txtsearch.Text) & "%'  or " _
                                    + " if(vipguest=1,'Vip','') like '%" & rchar(txtsearch.Text) & "%' or " _
                                    + " vipcardno like '%" & rchar(txtsearch.Text) & "%' or " _
                                    + " (select countryname from tblcountries where countrycode=tblhotelguest.countrycode) like '%" & rchar(txtsearch.Text) & "%' or " _
                                    + " nationality like '%" & rchar(txtsearch.Text) & "%') order by fullname asc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"guestid"})
        GridColumnAlignment(MyDataGridView, {"Contact Number", "Country", "Birthdate", "Gender", "Vip Card Type", "Vip Card No."}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Credit Limit"})
        MyDataGridView.Focus()
        GridColumnChoosed(MyDataGridView, Me.Name)
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If MyDataGridView.RowCount = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If countqry("tblhotelfolioguest", "foliono='" & frmHotelCheckInTransactionV2.foliono.Text & "'") > 0 Then
                If MessageBox.Show("Are you sure you want to continue to change new guest name?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Change new folio guest name " & MyDataGridView.Item("Guest Name", MyDataGridView.CurrentRow.Index).Value().ToString)
                    com.CommandText = "UPDATE tblhotelfolioguest set guestid='" & MyDataGridView.Item("guestid", MyDataGridView.CurrentRow.Index).Value().ToString & "' where foliono='" & frmHotelCheckInTransactionV2.foliono.Text & "'" : com.ExecuteNonQuery()
                    com.CommandText = "UPDATE tblhotelfolioroom set guestid='" & MyDataGridView.Item("guestid", MyDataGridView.CurrentRow.Index).Value().ToString & "' where foliono='" & frmHotelCheckInTransactionV2.foliono.Text & "'" : com.ExecuteNonQuery()
                    frmHotelCheckInTransactionV2.guestid.Text = MyDataGridView.Item("guestid", MyDataGridView.CurrentRow.Index).Value().ToString
                    frmHotelCheckInTransactionV2.showGuestInfo()
                End If
            Else
                LogAuditTrail("HOTEL", If(HotelOperationMode = True, "Front Desk", "Reservation"), frmHotelCheckInTransactionV2.foliono.Text, "Picked folio guest name " & MyDataGridView.Item("Guest Name", MyDataGridView.CurrentRow.Index).Value().ToString)
                frmHotelCheckInTransactionV2.guestid.Text = MyDataGridView.Item("guestid", MyDataGridView.CurrentRow.Index).Value().ToString
                frmHotelCheckInTransactionV2.showGuestInfo()
            End If
            Me.Close()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowGuestList()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddnewGuest_Click(sender As Object, e As EventArgs) Handles cmdAddnewGuest.Click
        frmHotelGuestInfo.Show(Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowGuestList()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmHotelGuestInfo.mode.Text = "edit"
        frmHotelGuestInfo.guestid.Text = MyDataGridView.Item("guestid", MyDataGridView.CurrentRow.Index).Value().ToString
        If frmHotelGuestInfo.Visible = False Then
            frmHotelGuestInfo.Show(Me)
        Else
            frmHotelGuestInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/>", Me.Text, "", MyDataGridView, Me)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Delete guest name needs an administrative approval. Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    com.CommandText = "UPDATE tblhotelguest set deleted=1,datedeleted=current_timestamp,deletedby='" & frmPOSAdminConfirmation.userid.Text & "' where guestid = '" & rw.Cells("guestid").Value.ToString & "'" : com.ExecuteNonQuery()
                Next
                ShowGuestList()
                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            End If
        End If
    End Sub

    Private Sub cmdColumnChooser_Click(sender As Object, e As EventArgs) Handles cmdColumnChooser.Click
        On Error Resume Next
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = Me.Name
        frmColumnChooser.init_grid(MyDataGridView)
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
        frmColumnChooser.Show(Me)
    End Sub
End Class