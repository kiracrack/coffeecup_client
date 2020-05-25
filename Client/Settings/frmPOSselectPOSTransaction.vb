Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSselectPOSTransaction
    Dim selected As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSselectPOSTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ShowFilters()
    End Sub
    Public Sub ShowFilters()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("SELECT trncode as 'Transaction Code',date_format(dateopen,'%Y-%m-%d %r') as 'Date Open',date_format(dateclose,'%Y-%m-%d %r') 'Date Closed', cashremitted as 'Total Cash Remitted' FROM `tblsalessummary` where openfortrn=1 and userid='" & globaluserid & "';", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Transaction Code", "Date Open", "Date Closed"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Total Cash Remitted"})
    End Sub


    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                LoadPostTransaction(rw.Cells("Transaction Code").Value.ToString)
                Me.Close()
            Next
        End If
    End Sub
 

    Private Sub MyDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode() = Keys.Enter Then
            cmdset.PerformClick()
        End If
    End Sub
End Class