Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System

Public Class frmVipTransactionDetails
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
        com.CommandText = "drop temporary table if exists tempviptransaction ;" : com.ExecuteNonQuery()
        com.CommandText = "drop temporary table if exists tempviptransaction1 ;" : com.ExecuteNonQuery()
        com.CommandText = "create temporary table tempviptransaction select date_format(datetrn,'%Y-%m-%d') as trndate,productname,quantity,unit,sellprice,total,(select officename from tblcompoffice where officeid=tblsalestransaction.officeid) as 'Outlet' from tblsalestransaction where cifid='" & cifid.Text & "' and cancelled=0 and void=0 " & If(frmVIPReportViewer.CheckBox1.Checked = True, "", "and date_format(datetrn,'%Y-%m-%d') between '" & ConvertDate(frmVIPReportViewer.date_from.Value) & "' and '" & ConvertDate(frmVIPReportViewer.date_to.Value) & "'") & " union all" _
                        + " select datecharge,concat((select lcase(description) from tblhotelroomtype where code=a.roomtype),' ', lcase(a.remarks)),1,'Night',debit,debit,(select officename from tblcompoffice where officeid=a.officeid) FROM `tblhoteltransaction` as a inner join tblhotelroomtransaction as b on a.folioid=b.folioid where b.cancelled=0 and a.roomcharge=1 and a.guestid='" & guestid.Text & "' " & If(frmVIPReportViewer.CheckBox1.Checked = True, "", "and a.datecharge between '" & ConvertDate(frmVIPReportViewer.date_from.Value) & "' and '" & ConvertDate(frmVIPReportViewer.date_to.Value) & "'") & ";" : com.ExecuteNonQuery()
        com.CommandText = "create temporary table tempviptransaction1 select * from tempviptransaction" : com.ExecuteNonQuery()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select trndate as 'Date Transaction',productname as 'Particular',Quantity,Unit,sellprice as 'Unit Cost',Total,Outlet from tempviptransaction union all " _
                                   + " select '','','','',null,sum(total),'' from tempviptransaction1", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        GridColumnAlignment(MyDataGridView, {"Date Transaction", "Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total"})
        PaintColumnFormat()
    End Sub
    Public Sub PaintColumnFormat()
        GridColumnWidth(MyDataGridView, {"Date Transaction"}, 150)
        GridColumAutonWidth(MyDataGridView, {"Particular", "Outlet"})
        GridColumnWidth(MyDataGridView, {"Quantity", "Unit Cost", "Total"}, 120)
        GridColumnWidth(MyDataGridView, {"Unit"}, 100)
      

    End Sub
   
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text & "<br/><strong>" & If(frmVIPReportViewer.CheckBox1.Checked = True, "ALL TRANSACTIONS", "Report period from " & CDate(frmVIPReportViewer.date_from.Value).ToString("MMMM, dd yyyy") & " to " & CDate(frmVIPReportViewer.date_to.Value).ToString("MMMM, dd yyyy") & "") & "</strong>", "REPORT DETAILS", "", MyDataGridView, Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(UCase(Me.Text), dst)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class