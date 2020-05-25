Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmInventoryLedger
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmInventoryLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        If (countqry("tblinventoryledger", "officeid='" & officeid.text & "' and productid='" & itemid.Text & "' order by datetrn desc limit 1")) > 0 Then
            txtfrmdate.Value = CDate(qrysingledata("datetrn", "datetrn", "tblinventoryledger where officeid='" & officeid.text & "' and productid='" & itemid.Text & "' order by datetrn desc limit 1"))
        Else
            txtfrmdate.Value = CDate(Now)
        End If
        txttodate.Value = CDate(Now)
        ViewLocalparticulars()
    End Sub
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        ViewLocalparticulars()
    End Sub
    Public Sub ViewLocalparticulars()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select date_format(a.datetrn, '%Y-%m-%d %r') as 'Date Transaction', " _
                        + " a.remarks as 'Remarks', " _
                        + " a.debit as 'Stock In', " _
                        + " a.credit as 'Stock Out', " _
                        + " (SELECT SUM(COALESCE(debit,0) - COALESCE(credit,0)) FROM tblinventoryledger as b " _
                        + " WHERE b.id <= a.id and b.officeid=a.officeid and b.productid=a.productid) AS 'Balance', Cost,referenceno as 'Reference No.', trntype as 'Transaction Type', trnby as 'Transaction By' " _
                        + " FROM tblinventoryledger as a where a.officeid='" & officeid.Text & "' and a.productid='" & itemid.Text & "' and date_format(a.datetrn, '%Y-%m-%d') between '" & ConvertDate(txtfrmdate.Value) & "' and '" & ConvertDate(txttodate.Value) & "' order by a.id asc", conn)

        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)

        GridCurrencyColumnDecimalCount(MyDataGridView, {"Stock In", "Stock Out", "Balance"}, 4)
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Cost"}, 2)
        GridColumnWidth(MyDataGridView, {"Stock In", "Stock Out", "Balance"}, 80)
        GridColumnAlignment(MyDataGridView, {"Stock In", "Stock Out", "Reference No.", "Date Transaction"}, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        ExportGridToExcel(RemoveSpecialCharacter(Me.Text), dst)
    End Sub

  
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview("Inventory ledger <br/><strong>" & Me.Text & "</strong>", "Inventory Ledger", "Report period from " & CDate(txtfrmdate.Value).ToString("MMMM, dd yyyy") & " to " & CDate(txttodate.Value).ToString("MMMM, dd yyyy"), MyDataGridView, Me)
    End Sub

    Private Sub itemid_TextChanged(sender As Object, e As EventArgs) Handles itemid.TextChanged
        ViewLocalparticulars()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewLocalparticulars()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class