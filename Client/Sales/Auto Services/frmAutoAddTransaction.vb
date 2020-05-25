Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmAutoAddTransaction
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        FillBatchcode()
    End Sub

    Private Sub txtNewBatchcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewBatchcode.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtNewBatchcode.Text = "" Or txtNewBatchcode.Text = "%" Then Exit Sub
            If countqry("tblsalesbatch", " batchcode = '" & txtNewBatchcode.Text & "' and void=0") = 0 Then
                LoadToComboBoxDB("SELECT batchcode FROM tblsalesbatch where batchcode  like '%" & txtNewBatchcode.Text & "%' and void=0", "batchcode", "batchcode", txtNewBatchcode)
                txtNewBatchcode.DroppedDown = True
                cmdConfirmPayment.Enabled = False
            Else
                cmdConfirmPayment.Enabled = True
                cmdConfirmPayment.Focus()
            End If
        End If
    End Sub

    Private Sub FillBatchcode()
        GridBatchcode.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select Batchcode from tblsalesautotransaction where trncode='" & txtReference.Text & "'", conn)
        msda.Fill(dst, 0)
        GridBatchcode.DataSource = dst.Tables(0)
        GridColumnAlignment(GridBatchcode, {"Batchcode"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub GridBatchcode_SelectionChanged(sender As Object, e As EventArgs) Handles GridBatchcode.SelectionChanged
        LoadItems()
    End Sub
    Private Sub GridBatchcode_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBatchcode.CellClick
        LoadItems()
    End Sub

    Public Sub LoadItems()
        Dim batchcode As String = ""
        If GridBatchcode.Rows.Count > 0 Then
            batchcode = GridBatchcode.Item("Batchcode", GridBatchcode.CurrentRow.Index).Value().ToString
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select productname as 'Particular', " _
                                + " (select DESCRIPTION from tblprocategory where catid = tblsalestransaction.catid) as 'Category', " _
                                + " sum(quantity) as 'Quantity'," _
                                + " Unit, " _
                                + " sellprice as 'Unit Cost', " _
                                + " sum(total) as 'Total' " _
                                + " from tblsalestransaction " _
                                + " where batchcode='" & GridBatchcode.Item("Batchcode", GridBatchcode.CurrentRow.Index).Value().ToString & "' and total > 0 and cancelled=0 and void=0 group by productid", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost", "Total"})
        GridColumnAlignment(MyDataGridView, {"Quantity", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumnAlignment(MyDataGridView, {"Unit Cost", "Total"}, DataGridViewContentAlignment.MiddleRight)

        If MyDataGridView.RowCount - 1 > 0 Then
            Dim totalsum As Double = 0
            For i = 0 To MyDataGridView.RowCount - 1
                totalsum = totalsum + MyDataGridView.Rows(i).Cells("Total").Value()
            Next
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Unit Cost").Value = "Total"
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).Cells("Total").Value = FormatNumber(totalsum, 2)
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            MyDataGridView.Rows(MyDataGridView.RowCount - 1).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub cmdConfirmPayment_Click(sender As Object, e As EventArgs) Handles cmdConfirmPayment.Click
        If countqry("tblsalesbatch", " batchcode = '" & txtNewBatchcode.Text & "'") = 0 Then
            MessageBox.Show("Batch transaction not exists!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewBatchcode.Focus()
            Exit Sub
        ElseIf countqry("tblsalesautotransaction", " batchcode = '" & txtNewBatchcode.Text & "' and trncode='" & txtReference.Text & "'") > 0 Then
            MessageBox.Show("Batch transaction already exists!", compOfficename, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNewBatchcode.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want add transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "insert into tblsalesautotransaction set trncode='" & txtReference.Text & "', batchcode='" & txtNewBatchcode.Text & "'" : com.ExecuteNonQuery()
            FillBatchcode()
            txtNewBatchcode.Text = ""
            MyDataGridView.Focus()
            LoadItems()
            cmdConfirmPayment.Enabled = False
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        LoadItems()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete From tblsalesautotransaction where trncode='" & txtReference.Text & "' and batchcode='" & GridBatchcode.Item("Batchcode", GridBatchcode.CurrentRow.Index).Value().ToString & "' " : com.ExecuteNonQuery()
            FillBatchcode()
            LoadItems()
            cmdConfirmPayment.Enabled = False
        End If
    End Sub

   
End Class