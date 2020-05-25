Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmFFEHistory
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

  
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        showHistory()
    End Sub
    Public Sub showHistory()
        msda = New MySqlDataAdapter("select date_format(datetrn, '%Y-%m-%d %r') as 'Date History', lcase(Remarks) as 'Remarks', trnby as 'Transaction By', officename as 'Office'  from tblinventoryffehistory where ffecode='" & ffecode.Text & "' order by id asc", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Date History"}, DataGridViewContentAlignment.MiddleCenter)
        MyDataGridView.Columns("Remarks").Width = 300
        MyDataGridView.Columns("Date History").Width = 150
        MyDataGridView.Columns("Transaction By").Width = 250
        MyDataGridView.Columns("Remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

   
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview("FFE HISTORY REPORTS<br/><strong>" & "(" & ffecode.Text & ") " & txtDescription.Text & "</strong>", "HISTORY", "", MyDataGridView, Me)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class
