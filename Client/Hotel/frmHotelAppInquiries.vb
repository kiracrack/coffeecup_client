Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmHotelAppInquiries
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
 
    Private Sub frmHotelAppInquiries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        tabFilter()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub
    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabHotelCharges Then
            MyDataGridView_Detail.Parent = TabControl1.SelectedTab
            HotelCharges(0)
            MyDataGridView_Detail.ContextMenuStrip = cms_em
        ElseIf TabControl1.SelectedTab Is tabChargefromPOS Then
            MyDataGridView_Detail.Parent = TabControl1.SelectedTab
            HotelCharges(1)
            MyDataGridView_Detail.ContextMenuStrip = Nothing
        End If
    End Sub

    Public Sub HotelCharges(ByVal cleared As Integer)
        MyDataGridView_Detail.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id, roomno as 'Room Number',Inquiry as 'Inquiry Details', date_format(dateinquiry,'%M %d, %y %r') as 'Date Inquiry' " & If(cleared = 1, ",(select fullname from tblaccounts where accountid=tbltvroominquiries.clearedby) as 'Cleared By',date_format(datecleared,'%M %d, %y %r') as 'Date Cleared' ", "") & " from tbltvroominquiries where cleared='" & cleared & "'", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView_Detail.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView_Detail, {"id"})
        GridColumnAlignment(MyDataGridView_Detail, {"Room Number", "Date Inquiry"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView_Detail.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView_Detail.CurrentCell = Me.MyDataGridView_Detail.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/><strong>" & TabControl1.SelectedTab.Text & "</strong>", TabControl1.SelectedTab.Text, "Cashier: " & globalfullname & "<br/>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy"), MyDataGridView_Detail, Me)
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "UPDATE tbltvroominquiries set cleared=1,clearedby='" & globaluserid & "',datecleared=current_timestamp where id='" & MyDataGridView_Detail.Item("id", MyDataGridView_Detail.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            tabFilter()
        End If
    End Sub

End Class