Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSErrorBatchChecker
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmPOSErrorBatchChecker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowErrorTransaction()
    End Sub

    Public Sub ShowErrorTransaction()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select batchcode as 'Transaction Code', (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid) as 'Client', Total as 'Total Summary',(select sum(total) from tblsalestransaction where batchcode = tblsalesbatch.batchcode and cancelled=0 and void=0) as 'Transaction',total-(select sum(total) from tblsalestransaction where batchcode = tblsalesbatch.batchcode  and cancelled=0 and void=0) as 'Discrepancy' from tblsalesbatch where trnsumcode='" & globalSalesTrnCOde & "' and floattrn=0 and onhold=0 and void=0 and total-(select sum(total) from tblsalestransaction where batchcode = tblsalesbatch.batchcode and cancelled=0 and void=0) > 0 order by datetrn desc", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Transaction Code"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Total Summary", "Transaction", "Discrepancy"})
    End Sub
End Class