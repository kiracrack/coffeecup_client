Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBatchStockout

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Insert Then
            cmdFind.PerformClick()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmBatchStockout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        txtDateStockout.Text = CDate(Now.ToShortDateString)
        LoadToComboBoxDB("select * from tblstockouttype order by description asc", "description", "stockouttypeid", txtStockouttype)
        FilterNew()
    End Sub

    Public Sub FilterNew()
        LoadXgrid("Select  id,  date_format(postingdate,'%Y-%m-%d') as 'Stockout Date',  " _
                            + " (select itemname from tblglobalproducts where PRODUCTID=tblstockoutitem.PRODUCTID) as 'Item Name', " _
                            + " Quantity,(select quantity from tblinventory where trnid=tblstockoutitem.refcode) as 'Available Stock', Unit, purchasedprice as 'Unit Cost', (purchasedprice*Quantity) as 'Total Cost',  Remarks, " _
                            + " (select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as 'Stockout Type' " _
                            + " from tblstockoutitem where confirmed=0 and trnby='" & globaluserid & "'", "tblstockoutitem", Cm, Gridview1)

        XgridHideColumn({"id"}, Gridview1)
        XgridColCurrencyDecimalCount({"Quantity", "Available Stock", "Unit Cost", "Total Cost"}, 3, Gridview1)
        XgridColAlign({"Quantity", "Available Stock", "Unit", "Stockout Date"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)

        com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & Gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            Gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
            If Val(rst("columnwidth").ToString) > 0 Then
                Gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
            End If
        End While
        rst.Close()
    End Sub
    Private Sub GridView_Reservation_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles Gridview1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colAvailableStock" Then
            Dim quantity As Double = Val(CC(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Quantity"))))
            Dim Stock As Double = Val(CC(View.GetRowCellDisplayText(e.RowHandle, View.Columns("Available Stock"))))
            If quantity > Stock Then
                e.Appearance.BackColor = Color.White
                e.Appearance.ForeColor = Color.Red
            Else
                e.Appearance.BackColor = BackColor
                e.Appearance.ForeColor = ForeColor
            End If
        End If
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles Gridview1.ColumnWidthChanged
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs) Handles Gridview1.DragObjectDrop
        UpdateGridColumnSetting(Me.Name, Gridview1)
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolRemove.Click
        If MessageBox.Show("Are you sure you want to permanently delete this item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            For I = 0 To Gridview1.SelectedRowsCount - 1
                com.CommandText = "DELETE FROM tblstockoutitem where id='" & Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "id").ToString & "'" : com.ExecuteNonQuery()
            Next
            FilterNew()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        FilterNew()
    End Sub


    Private Sub cmdSaveAndFinish_Click(sender As Object, e As EventArgs) Handles cmdSaveAndFinish.Click
        Dim stocknotavailable As Boolean = False
        For I = 0 To Gridview1.SelectedRowsCount - 1
            If Val(CC(Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "Quantity").ToString)) > Val(CC(Gridview1.GetRowCellValue(Gridview1.GetSelectedRows(I), "Available Stock").ToString)) Then
                stocknotavailable = True
            End If
        Next
        If Gridview1.RowCount = 0 Then
            MessageBox.Show("There's no item to execute!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf stocknotavailable = True Then
            MessageBox.Show("Some item Insufficient stock!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Continue confirm batch stockout inventory?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim batchcode As String = getStockoutBatchSequence()
            dst = New DataSet
            msda = New MySqlDataAdapter("Select *,(select description from tblstockouttype where stockouttypeid=tblstockoutitem.stockouttypeid) as stockouttype from tblstockoutitem where confirmed=0 and trnby='" & globaluserid & "'", conn)
            msda.Fill(dst, 0)
            ProgressBarControl1.Visible = True
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = Gridview1.RowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            ProgressBarControl1.Position = 0
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    StockoutInventory("Inventory Stockout", .Rows(cnt)("refcode").ToString(), .Rows(cnt)("officeid").ToString(), .Rows(cnt)("productid").ToString(), Val(CC(.Rows(cnt)("quantity").ToString())), Val(CC(.Rows(cnt)("purchasedprice").ToString())), If(.Rows(cnt)("remarks").ToString() = "", .Rows(cnt)("stockouttype").ToString(), .Rows(cnt)("stockouttype").ToString() & " - " & .Rows(cnt)("remarks").ToString()), batchcode, "")
                    com.CommandText = "update tblstockoutitem set batchcode='" & batchcode & "', confirmed=1 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    com.CommandText = "CALL sp_acct_entries('" & .Rows(cnt)("id").ToString() & "','" & .Rows(cnt)("officeid").ToString() & "', 'STOCK_OUT','')" : com.ExecuteNonQuery()
                End With
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next
            ProgressBarControl1.Update()
            ProgressBarControl1.Refresh()
            ProgressBarControl1.Visible = False
            FilterNew()
            'txtbatchcode.Text = getGlobalTrnid("BS", globaluserid)
            frmStockoutsMain.filter()
            MessageBox.Show("Inventory successfully deducted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        If txtStockouttype.Text = "" Then
            MessageBox.Show("Please select stockout type!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStockouttype.Focus()
            Exit Sub
        End If
        frmStockoutInventory.ShowDialog(Me)
    End Sub

    Private Sub txtStockouttype_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtStockouttype.SelectedValueChanged
        Stockouttypeid.Text = DirectCast(txtStockouttype.SelectedItem, ComboBoxItem).HiddenValue
    End Sub
End Class