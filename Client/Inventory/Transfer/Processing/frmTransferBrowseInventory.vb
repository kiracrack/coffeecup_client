Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmTransferBrowseInventory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            textsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmChapterInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        ViewIventoryItem()
    End Sub

    Public Sub ViewIventoryItem()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select trnid, productid as 'Item Code', " _
                           + " productname as 'Particulars',  " _
                           + " quantity as 'Available Quantity', Unit,purchasedprice as 'Unit Cost', dateinventory as 'Date Inventory' " _
                           + " from tblinventory where quantity>0 and officeid='" & compOfficeid & "' and (productname like '%" & textsearch.Text & "%' or productid like '%" & textsearch.Text & "%') " _
                           + " order by productname asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"Item Code", "trnid"})
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Available Quantity", "Unit Cost"}, 4)
        GridColumnAlignment(MyDataGridView, {"Item Code", "Available Quantity", "Unit", "Date Inventory"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost"})
    End Sub

    Private Sub textsearch_GotFocus(sender As Object, e As EventArgs) Handles textsearch.GotFocus
        If textsearch.Text = "Enter keyword here to search.." Then
            textsearch.Text = ""
        End If
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            ViewIventoryItem()
        End If
    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        showInfo()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Synchronize online data may take a while, depending on the amount of data and internet connectivity. " & Environment.NewLine & "Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Application.DoEvents()
            End While
            ViewIventoryItem()
        End If
    End Sub
    Public Sub showInfo()
        If mode.Text = "process" And Val(CC(MyDataGridView.Item("Available Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) = 0 Then
            MessageBox.Show("Zero quantity not allowed", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Val(CC(MyDataGridView.Item("Available Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) = 0 Then
            If MessageBox.Show("Your are about to request with zero available quantity.." & Environment.NewLine & "Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbNo Then
                Exit Sub
            End If
        End If
        frmTransferQuantitySelect.trnid.Text = MyDataGridView.Item("trnid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferQuantitySelect.productid.Text = MyDataGridView.Item("Item Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferQuantitySelect.txtunit.Text = MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferQuantitySelect.txtProductName.Text = MyDataGridView.Item("Particulars", MyDataGridView.CurrentRow.Index).Value().ToString
        frmTransferQuantitySelect.txtavailable.Text = Val(CC(MyDataGridView.Item("Available Quantity", MyDataGridView.CurrentRow.Index).Value().ToString))
        frmTransferQuantitySelect.batchcode.Text = batchcode.Text
        frmTransferQuantitySelect.mode.Text = mode.Text
        frmTransferQuantitySelect.Show(Me)
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        'You're Code
        If e.KeyCode = Keys.Enter Then
            showInfo()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ViewIventoryItem()
    End Sub


    Private Sub textsearch_LostFocus(sender As Object, e As EventArgs) Handles textsearch.LostFocus
        If textsearch.Text = "" Then
            textsearch.Text = "Enter keyword here to search.."
        End If
    End Sub

End Class