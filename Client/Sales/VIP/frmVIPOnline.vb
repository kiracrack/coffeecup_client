Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmVIPOnline
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub frmPOSCustomOrderItemized_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ShowItemList()
        ' PaintColumnFormat()
    End Sub

    Public Sub ShowItemList() 
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select id,cifid, (select companyname from tblclientaccounts where cifid=tblsalesvipguest.cifid) as 'VIP Name', date_format(datein,'%r') as 'Time IN', Companion as 'Number of Companion', ifnull((select sum(total) from tblsalestransaction where cifid=tblsalesvipguest.cifid and cancelled=0 and void=0 and date_format(datetrn,'%Y-%m-%d')=current_date),0) + ifnull((SELECT sum(debit) FROM `tblhoteltransaction` as a inner join tblhotelroomtransaction as b on a.folioid=b.folioid where a.cancelled=0 and a.roomcharge=1 and a.guestid=tblsalesvipguest.guestid and a.datecharge=current_date),0) as 'Total Spending', activateby as 'Activated By' from tblsalesvipguest where checkin=1 and checkout=0", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        GridHideColumn(MyDataGridView, {"id", "cifid"})
        GridColumnAlignment(MyDataGridView, {"Time IN", "Number of Companion"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Total Spending"})
        PaintColumnFormat()
    End Sub
    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"VIP Name"}, 150)
        GridColumAutonWidth(MyDataGridView, {"Time IN", "Number of Companion", "Activated By"})
        GridColumnWidth(MyDataGridView, {"Total Spending"}, 120)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/><strong>Report Date " & CDate(Now.ToShortDateString) & "</strong>", "REPORT DETAILS", "", MyDataGridView, Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(UCase(Me.Text), dst)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles cmdNewVIPGuest.Click
        If frmCheckinVIP.Visible = True Then
            frmCheckinVIP.Focus()
        Else
            frmCheckinVIP.Show(Me)
        End If
    End Sub

    Private Sub RefreshListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshListToolStripMenuItem.Click
        ShowItemList()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                com.CommandText = "update tblsalesvipguest set checkout=1,dateout=current_timestamp,deactivateby='" & globalfullname & "' where id='" & rw.Cells("id").Value.ToString & "'" : com.ExecuteNonQuery()
                com.CommandText = "UPDATE tblclientaccounts set vipactivated=0 where cifid='" & rw.Cells("cifid").Value.ToString & "'" : com.ExecuteNonQuery()
            Next
            ShowItemList()
            MsgBox("Selected transaction successfully cancelled!", MsgBoxStyle.Information)
        End If
    End Sub
End Class