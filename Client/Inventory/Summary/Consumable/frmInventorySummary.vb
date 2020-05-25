Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports System.Text
Imports DevExpress.XtraEditors.Controls

Public Class frmInventorySummary
    ' The class that will do the printing process.
    Dim MyDataGridViewPrinter As DataGridViewPrinter
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F3) Then
            txtsearch.Focus()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip3)
        If countqry("tblinventory", "officeid='" & compOfficeid & "' and quantity>0") < 5000 Then
            tabFilter()
        End If
        If compallowmanagconsumableotheroffice = True Then
            lblOffice.Visible = True
            txtOffice.Visible = True
            lineOffice.Visible = True
            LoadOffice()
        Else
            lblOffice.Visible = False
            txtOffice.Visible = False
            lineOffice.Visible = False
            officeid.Text = compOfficeid
        End If
        If LCase(globalusername) = "root" Or allowbegginingInventory = True Then
            cmdManualInventory.Visible = True
            ToolStripSeparator7.Visible = True
        Else
            cmdManualInventory.Visible = False
            ToolStripSeparator7.Visible = False
        End If
        loadCategory()
        CheckInventoryLockedStatus()
    End Sub

    Public Sub loadCategory()
        com.CommandText = "select * from tblprocategory where consumable=1 order by description asc;" : rst = com.ExecuteReader
        While rst.Read
            txtCategory.Properties.Items.Add(rst("catid").ToString, False, True)
            txtCategory.Properties.Items.Item(rst("catid").ToString).Description = rst("description").ToString
            txtCategory.Properties.Items.Item(rst("catid").ToString).Value = rst("catid").ToString
        End While
        rst.Close()


    End Sub

    Public Sub LoadOffice()
        com.CommandText = "select * from tblcompoffice" : rst = com.ExecuteReader
        While rst.Read
            txtOffice.Items.Add(rst("officename").ToString())
        End While
        rst.Close()
        txtOffice.Text = compOfficename
    End Sub
    Public Sub CheckInventoryLockedStatus()
        If countqry("tblinventorylocked", "date_format(cutoff,'%Y-%m')=date_format(current_date,'%Y-%m')") > 0 Then
            cmdLockInventory.Visible = False
            lineLockInventory.Visible = False
        Else
            cmdLockInventory.Visible = True
            lineLockInventory.Visible = True
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        tabFilter()
    End Sub

    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            tabFilter()
        End If
    End Sub

    Public Sub tabFilter()
        If TabControl1.SelectedTab Is tabConsumable Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            cmdInventoryLedger.Visible = True
            cmdViewInventoryDetails.Visible = False
            ViewLocalInventoryConsumable(False)


        ElseIf TabControl1.SelectedTab Is tabConsumables_prepaid Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            cmdInventoryLedger.Visible = True
            cmdViewInventoryDetails.Visible = False
            ViewLocalInventoryConsumable(True)

        ElseIf TabControl1.SelectedTab Is tabCutof Then
            MyDataGridView.Parent = TabControl1.SelectedTab
            cmdInventoryLedger.Visible = False
            cmdViewInventoryDetails.Visible = True
            ViewLocalCutOffInventory()

        End If
    End Sub

    Public Sub ViewLocalInventoryConsumable(ByVal consumabletype As Boolean)
        Dim SelectedCategory As String = ""
        For Each item As CheckedListBoxItem In txtCategory.Properties.Items
            If item.CheckState = CheckState.Checked Then
                SelectedCategory += "catid='" & item.Value.ToString() & "' or "
            End If
        Next
        If SelectedCategory.Length > 0 Then
            SelectedCategory = SelectedCategory.Remove(SelectedCategory.Length - 3, 3)
        End If

        If ckStockSequence.Checked = True Then
            StockSequenceInventoryView(consumabletype, SelectedCategory)
        Else
            StockSummaryInventoryView(consumabletype, SelectedCategory)
        End If
    End Sub

    Public Sub StockSequenceInventoryView(ByVal consumabletype As Boolean, ByVal category As String)
        Dim saleQuery As String = ""
        If EnableModuleSales = True Then
            saleQuery = " sellingprice  as 'Selling Cost', "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select officeid,catid, trnid as 'Stock ID', " _
                           + " PRODUCTID as 'Product ID', " _
                           + " productname as 'Particular', " _
                           + " categoryname as 'Category', " _
                           + " quantity as 'Available Quantity', " _
                           + " ucase(Unit) as Unit, " _
                           + " purchasedprice as 'Latest Cost', " _
                           + saleQuery _
                           + " (purchasedprice*QUANTITY) as 'Total', " _
                           + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update', " _
                           + " date_format(dateinventory, '%Y-%m-%d %r') as 'Date Inventory' " _
                           + " from tblinventory where prepaid=" & consumabletype & If(ckZeroQuantity.Checked = True, "", " and quantity > 0 ") & If(CheckBox2.Checked = True Or category = "", "", " and (" & category & ") ") & " and " _
                           + If(compallowmanagconsumableotheroffice = True, " officeid='" & officeid.Text & "' and ", " officeid='" & compOfficeid & "' and ") _
                           + " (PRODUCTID like '%" & txtsearch.Text & "%' or " _
                           + " productname like '%" & txtsearch.Text & "%' or " _
                           + " categoryname like '%" & txtsearch.Text & "%' or " _
                           + " QUANTITY like '%" & txtsearch.Text & "%' or " _
                           + " (purchasedprice*QUANTITY) like '%" & txtsearch.Text & "%' or " _
                           + " date_format(lastupdate, '%Y-%m-%d %r') like '%" & txtsearch.Text & "%') order by productname,dateinventory asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        MyDataGridView.AllowUserToAddRows = True
        If EnableModuleSales = True Then
            GridCurrencyColumnDecimalCount(MyDataGridView, {"Available Quantity"}, 4)
            GridCurrencyColumn(MyDataGridView, {"Latest Cost", "Selling Cost", "Total"})
        Else
            GridCurrencyColumnDecimalCount(MyDataGridView, {"Available Quantity"}, 4)
            GridCurrencyColumn(MyDataGridView, {"Latest Cost", "Total"})
        End If

        GridColumnChoosed(MyDataGridView, TabControl1.SelectedTab.Name)
        GridColumnAlignment(MyDataGridView, {"Stock ID", "Product ID", "Available Quantity", "Unit", "Last Update", "Date Inventory"}, DataGridViewContentAlignment.MiddleCenter)
        ShowGridTotalSummary("Available Quantity", "Total", MyDataGridView)
    End Sub

    Public Sub StockSummaryInventoryView(ByVal consumabletype As Boolean, ByVal category As String)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select PRODUCTID as 'Product ID', " _
                           + " productname as 'Particular', " _
                           + " categoryname as 'Category', " _
                           + " ucase(Unit) as Unit, " _
                           + " sum(QUANTITY) as 'Available Quantity', " _
                           + " date_format(lastupdate, '%Y-%m-%d %r') as 'Last Update' " _
                           + " from tblinventory where prepaid=" & consumabletype & If(ckZeroQuantity.Checked = True, "", " and quantity > 0 ") & If(CheckBox2.Checked = True Or category = "", "", " and (" & category & ") ") & " and " _
                           + If(compallowmanagconsumableotheroffice = True, " officeid='" & officeid.Text & "' and ", " officeid='" & compOfficeid & "' and ") _
                           + " (PRODUCTID like '%" & txtsearch.Text & "%' or " _
                           + " productname like '%" & txtsearch.Text & "%' or " _
                           + " categoryname like '%" & txtsearch.Text & "%' or " _
                           + " date_format(lastupdate, '%Y-%m-%d %r') like '%" & txtsearch.Text & "%') group by productid order by productname asc", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        MyDataGridView.AllowUserToAddRows = False
        GridCurrencyColumnDecimalCount(MyDataGridView, {"Available Quantity"}, 4)

        'GridColumnChoosed(MyDataGridView, TabControl1.SelectedTab.Name)
        GridColumnAlignment(MyDataGridView, {"Product ID", "Available Quantity", "Unit", "Last Update"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Public Sub ViewLocalCutOffInventory()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select date_format(cutoff,'%Y-%m') as datecutoff, date_format(cutoff,'%M %Y') as 'Cut off', ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=0 and cutoff=a.cutoff),0) as 'On Hand', " _
                                + " ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=1 and cutoff=a.cutoff),0) as 'Prepaid', " _
                                + " ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=0 and cutoff=a.cutoff),0)+ifnull((select ifnull(sum(quantity*purchasedprice),0) as total from tblinventorylocked where officeid=a.officeid and prepaid=1 and cutoff=a.cutoff),0) as 'Total' from tblinventorylocked as a where a.officeid='" & compOfficeid & "' group by a.cutoff order by cutoff asc;", conn)

        msda.Fill(dst, 0)
        msda.SelectCommand.CommandTimeout = 99999999
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        MyDataGridView.AllowUserToAddRows = False
        MyDataGridView.Columns("Cut off").Width = 220
        GridHideColumn(MyDataGridView, {"datecutoff"})
        GridCurrencyColumn(MyDataGridView, {"On Hand", "Prepaid", "Total"})

        GridColumnChoosed(MyDataGridView, TabControl1.SelectedTab.Name)


    End Sub

    Private Sub MyDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellDoubleClick
        cmdInventoryLedger.PerformClick()
    End Sub


    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub


    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        tabFilter()
    End Sub


    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        ColumnGridSetup(TabControl1.SelectedTab.Name, MyDataGridView, Me)
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdColumnChooser.PerformClick()
    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdManualInventory.Click
        If compInventoryMethod = "" Then
            MessageBox.Show("Your office have not set inventory method, please contact your administrator!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If frmManualInventory.Visible = True Then
            frmManualInventory.WindowState = FormWindowState.Normal
        Else
            frmManualInventory.Show(Me)
        End If

    End Sub

    'Private Sub AdjustInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdAdjust.Click
    '    frmInventoryAdjust.refno.Text = MyDataGridView.Item("Stock ID", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtunit.Text = MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtquan.Text = MyDataGridView.Item("Available Quantity", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtCurrQuantity.Text = MyDataGridView.Item("Available Quantity", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtUnitCost.Text = MyDataGridView.Item("Latest Cost", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtTotalCost.Text = MyDataGridView.Item("Total", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.txtProductName.Text = MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString
    '    frmInventoryAdjust.Show(Me)
    'End Sub

    'Private Sub RemoveFromInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
    '    If MessageBox.Show("Are you sure you want to remove selected item? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '        com.CommandText = "delete from tblinventory where trnid='" & MyDataGridView.Item("Stock ID", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
    '        com.CommandText = "insert into tblnotifylist set officeid='" & compOfficeid & "', reference='" & MyDataGridView.Item("Stock ID", MyDataGridView.CurrentRow.Index).Value().ToString & "', n_title='Inventory Removed', n_description='" & MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString & " of " & StrConv(compOfficename, vbProperCase) & " inventory', n_type='request', n_by='" & globaluserid & "', n_datetime=current_timestamp,forsync=0" : com.ExecuteNonQuery()
    '    End If
    'End Sub

    Private Sub MyDataGridView_Sorted(sender As Object, e As EventArgs) Handles MyDataGridView.Sorted
        If TabControl1.SelectedTab Is tabConsumable Then
            For i = 0 To MyDataGridView.RowCount - 2
                If MyDataGridView.Item("Available Quantity", i).Value().ToString <> "" Then
                    Dim quantity As Double = MyDataGridView.Item("Available Quantity", i).Value().ToString
                    If quantity < 3 Then
                        MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    ElseIf quantity >= 3 And quantity < 7 Then
                        MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Orange
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub cmdLockInventory_Click(sender As Object, e As EventArgs) Handles cmdLockInventory.Click
        frmInventoryLockCutoff.ShowDialog(Me)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim ReportDetails As String = "" : Dim TableDetails As String = ""
        If TabControl1.SelectedTab Is tabConsumable Then
            ReportDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Inventory Summary (On hand)"
            TableDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Inventory summary (On hand) as of " & CDate(Now).ToString("MMMM, dd yyyy")
        ElseIf TabControl1.SelectedTab Is tabConsumable Then
            ReportDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Inventory Summary (Prepaid)"
            TableDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Inventory summary (Prepaid) as of " & CDate(Now).ToString("MMMM, dd yyyy")
        Else
            ReportDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Cut-off inventory summary"
            TableDetails = StrConv(txtOffice.Text, VbStrConv.ProperCase) & " Cut-off report as of " & CDate(Now).ToString("MMMM, dd yyyy")
        End If

        PrintDatagridview(TabControl1.SelectedTab.Text, ReportDetails, TableDetails, MyDataGridView, Me)
    End Sub

    Private Sub InventoryLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdInventoryLedger.Click
        frmInventoryLedger.itemid.Text = MyDataGridView.Item("Product ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmInventoryLedger.Text = UCase(MyDataGridView.Item("Particular", MyDataGridView.CurrentRow.Index).Value().ToString)
        frmInventoryLedger.officeid.Text = officeid.Text
        If frmInventoryLedger.Visible = True Then
            frmInventoryLedger.WindowState = FormWindowState.Normal
            frmInventoryLedger.Focus()
        Else
            frmInventoryLedger.Show(Me)
        End If
    End Sub

    Private Sub cmdExportToExcel_Click(sender As Object, e As EventArgs) Handles cmdExportToExcel.Click
        ExportGridToExcel(Me.Text, dst)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ckZeroQuantity_CheckedChanged(sender As Object, e As EventArgs)
        tabFilter()
    End Sub

    Private Sub txtOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtOffice.SelectedIndexChanged
        officeid.Text = qrysingledata("officeid", "officeid", "tblcompoffice where officename='" & txtOffice.Text & "'")
        tabFilter()
    End Sub

    Private Sub cmdViewInventoryDetails_Click(sender As Object, e As EventArgs) Handles cmdViewInventoryDetails.Click
        frmInventoryLockCutoffDetails.cutoff.Text = MyDataGridView.Item("datecutoff", MyDataGridView.CurrentRow.Index).Value().ToString
        frmInventoryLockCutoffDetails.Text = "Cut-off report period of " & MyDataGridView.Item("Cut off", MyDataGridView.CurrentRow.Index).Value().ToString
        frmInventoryLockCutoffDetails.Show(Me)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckStockSequence.CheckedChanged
        tabFilter()
    End Sub

    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick

    End Sub

    Private Sub txtCategory_EditValueChanged(sender As Object, e As EventArgs) Handles txtCategory.EditValueChanged
        tabFilter()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtCategory.Enabled = False
        Else
            txtCategory.Enabled = True
        End If
        tabFilter()
    End Sub

    Private Sub ckZeroQuantity_CheckedChanged_1(sender As Object, e As EventArgs) Handles ckZeroQuantity.CheckedChanged
        tabFilter()
    End Sub
End Class