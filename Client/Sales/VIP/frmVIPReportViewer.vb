Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmVIPReportViewer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmReportGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ShowReport()

    End Sub

    Public Sub ShowReport()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT cifid,vipguestid,companyname as 'Client Name', ucase(telephone) as 'Contact No.', ifnull((select sum(total) from tblsalestransaction where cifid=tblclientaccounts.cifid and cancelled=0 and void=0 " & If(CheckBox1.Checked = True, "", "and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(date_from.Value) & "' and '" & ConvertDate(date_to.Value) & "'") & "),0) + ifnull((SELECT sum(debit) FROM `tblhoteltransaction` as a inner join tblhotelroomtransaction as b on a.folioid=b.folioid where a.cancelled=0 and a.roomcharge=1 and a.guestid=tblclientaccounts.vipguestid " & If(CheckBox1.Checked = True, "", "and a.datecharge between '" & ConvertDate(date_from.Value) & "' and '" & ConvertDate(date_to.Value) & "'") & "),0) as 'Total Spending' FROM `tblclientaccounts` where deleted=0 and walkinaccount=0 and hotelclient=0 and vip=1;", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"cifid", "vipguestid"})
        GridCurrencyColumn(MyDataGridView, {"Total Spending"})
        GridColumnAlignment(MyDataGridView, {"Contact No."}, DataGridViewContentAlignment.MiddleCenter)
        PaintColumnFormat()
    End Sub
    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ExportGridToExcel(RemoveSpecialCharacter(Me.Text), dst)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/><strong>" & If(CheckBox1.Checked = True, "ALL TRANSACTIONS", "Report period from " & CDate(date_from.Value).ToString("MMMM, dd yyyy") & " to " & CDate(date_to.Value).ToString("MMMM, dd yyyy") & "") & "</strong>", "REPORT DETAILS", "", MyDataGridView, Me)
    End Sub

    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"cifid", "vipguestid"}, 0)
        GridColumAutonWidth(MyDataGridView, {"Client Name"})
        GridColumAutonWidth(MyDataGridView, {"Contact No."})
        GridColumnWidth(MyDataGridView, {"Total Spending"}, 120)

        'Dim column As Array = {"cifid", "Client Name", "Total Spending"}
        'Dim TotalVisibleColumn As Double = 0
        'For Each valueArr As String In column
        '    For i = 0 To MyDataGridView.ColumnCount - 1
        '        If valueArr = MyDataGridView.Columns(i).Name Then
        '            TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
        '        End If
        '    Next
        'Next
        '   GridColumnWidth(MyDataGridView, {"Client Name"}, (MyDataGridView.Width) - TotalVisibleColumn)
    End Sub
   
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(UCase(Me.Text), dst)
    End Sub
 
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        ShowReport()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowReport()
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        frmVipTransactionDetails.cifid.Text = MyDataGridView.Item("cifid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmVipTransactionDetails.guestid.Text = MyDataGridView.Item("vipguestid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmVipTransactionDetails.Text = MyDataGridView.Item("Client Name", MyDataGridView.CurrentRow.Index).Value().ToString
        frmVipTransactionDetails.ShowDialog(Me)
    End Sub
End Class