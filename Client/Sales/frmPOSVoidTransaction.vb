Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.Data.OleDb

Public Class frmPOSVoidTransaction
    Public TransactionDone As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSTransactionsHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmPOSVoidTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadToComboBoxDB("select trncode, concat(trncode,' - ', (select fullname from tblaccounts where accountid = tblsalessummary.userid)) as 'Cashier' from tblsalessummary where openfortrn=1 ", "Cashier", "trncode", txtCashier)
    End Sub

    Private Sub txtSearchKeyword_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCashier.SelectedValueChanged
        trnsumcode.Text = DirectCast(txtCashier.SelectedItem, ComboBoxItem).HiddenValue()
        ShowBatchTransactions()
    End Sub

    Public Sub ShowBatchTransactions()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select  batchcode as 'Batch Code', (select companyname from tblclientaccounts where cifid = tblsalesbatch.cifid) as 'Client', " _
                        + " totalitem as 'Total Item', totaldiscount as 'Total Discount',totalcharge as 'Total Charges', subtotal as 'Sub Total', total as 'Total Amount', amounttendered as 'Amount Tendered', amountchange as 'Change',ucase(paymenttype) as 'Payment Type', CAST(date_format(datetrn,'%Y-%m-%d %r') as CHAR(100)) as 'Date Transaction' " _
                        + " from tblsalesbatch where onhold=0 and void=0  and trnsumcode='" & trnsumcode.Text & "' and (batchcode like '%" & txtSearch.Text & "%' or total like '%" & txtSearch.Text & "%')", conn)
        msda.SelectCommand.CommandTimeout = 9999999
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Batch Code", "Total Item", "Payment Type"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Amount Tendered", "Change"}, DataGridViewContentAlignment.MiddleRight)
        GridCurrencyColumn(MyDataGridView, {"Sub Total", "Total Amount", "Total Discount", "Total Charges", "Amount Tendered", "Change"})
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are you sure you want to void current transaction? " & Environment.NewLine & Environment.NewLine & "Note: Voiding transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            frmPOSVoidConfirmation.ShowDialog(Me)
            If frmPOSVoidConfirmation.ApprovedConfirmation = True Then
                For Each rw As DataGridViewRow In MyDataGridView.SelectedRows
                    VoidBatchSalesTransaction(rw.Cells("Batch Code").Value.ToString, frmPOSVoidConfirmation.txtReason.Text, frmPOSVoidConfirmation.userid.Text)
                Next
                ShowBatchTransactions()
                MsgBox("Transaction successfully void!", MsgBoxStyle.Information)
                frmPOSVoidConfirmation.ApprovedConfirmation = False
                frmPOSVoidConfirmation.Dispose()
            End If
        End If
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            ShowBatchTransactions()
        End If
    End Sub

    Private Sub trnsumcode_TextChanged(sender As Object, e As EventArgs) Handles trnsumcode.TextChanged
        If txtCashier.Text = "" Then
            txtSearch.Enabled = False
        Else
            txtSearch.Enabled = True
        End If
    End Sub
End Class