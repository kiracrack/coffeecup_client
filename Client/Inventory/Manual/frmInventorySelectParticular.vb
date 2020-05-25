Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmInventorySelectParticular

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
        ViewLocalparticulars()
    End Sub
    Public Sub ViewLocalparticulars()
         MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select productid as 'Item Code', ITEMNAME as 'Particulars', (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category', Unit, ifnull(ifnull((select procost from tblitemvendor where itemid = tblglobalproducts.productid and officeid='" & compOfficeid & "' order by lastupdate desc limit 1),(select procost from tblitemvendor where itemid = tblglobalproducts.productid order by lastupdate desc limit 1)),0) as 'Unit Cost' " _
                                    + " from tblglobalproducts where catid in (select catid from tblprocategory where consumable=1) and (ITEMNAME like '%" & textsearch.Text & "%' or PRODUCTID like '%" & textsearch.Text & "%' )  order by ITEMNAME asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Item Code", "Unit"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Unit Cost"})
    End Sub

    Private Sub textsearch_GotFocus(sender As Object, e As EventArgs) Handles textsearch.GotFocus
        If textsearch.Text = "Enter keyword here to search.." Then
            textsearch.Text = ""
        End If
    End Sub

    Private Sub textsearch_LostFocus(sender As Object, e As EventArgs) Handles textsearch.LostFocus
        If textsearch.Text = "" Then
            textsearch.Text = "Enter keyword here to search.."
        End If
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar() = Chr(13) Then
            ViewLocalparticulars()
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
            ViewLocalparticulars()
        End If
    End Sub

    Public Sub showInfo()
        frmInventoryQuantitySelect.productid.Text = MyDataGridView.Item("Item Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmInventoryQuantitySelect.Show(Me)
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
        ViewLocalparticulars()
    End Sub
     
    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProductRequest.Show(Me)
    End Sub

 
End Class