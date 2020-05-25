Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmSelectParticular
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
         
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
        msda = New MySqlDataAdapter("Select tblglobalproducts.catid,  PRODUCTID as 'Item Code', " _
                           + " ITEMNAME as 'Particulars', " _
                           + " (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category',Unit, " _
                           + " ifnull(ifnull((select procost from tblitemvendor where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by lastupdate asc limit 1), (select purchasedprice from tblinventory where productid=tblglobalproducts.productid and officeid = '" & compOfficeid & "'  order by lastupdate desc limit 1)),0) as 'Latest Cost', " _
                           + " (select sum(quantity) from tblinventory where quantity>0 and productid=tblglobalproducts.productid and officeid='" & compOfficeid & "') as 'Available Inventory', " _
                           + " (select vendorid from tblitemvendor where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by procost asc limit 1) as 'vendorid',(select companyname from tblitemvendor inner join tblglobalvendor on tblglobalvendor.vendorid = tblitemvendor.vendorid  where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by procost asc limit 1) as 'vendor' " _
                           + " from tblglobalproducts inner join tblprocategory on tblglobalproducts.catid = tblprocategory.catid  where deleted=0 " & If(Globalenablshowallproductsuponpr = True, " and enablereqfilter=1 ", " and potypeid='" & potypeid.Text & "' ") & " and " _
                           + " (ITEMNAME like '%" & textsearch.Text & "%' or PRODUCTID like '%" & textsearch.Text & "%' or (select companyname from tblitemvendor inner join tblglobalvendor on tblglobalvendor.vendorid = tblitemvendor.vendorid  where officeid='" & compOfficeid & "' and itemid = tblglobalproducts.productid order by procost asc limit 1) like '%" & textsearch.Text & "%') " _
                           + " order by ITEMNAME asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"catid", "vendor", "vendorid"})
        GridColumnAlignment(MyDataGridView, {"Item Code", "Unit", "Available Inventory"}, DataGridViewContentAlignment.MiddleCenter)
        GridCurrencyColumn(MyDataGridView, {"Latest Cost"})
        MyDataGridView.Focus()
    End Sub
   
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub textsearch_GotFocus(sender As Object, e As EventArgs) Handles textsearch.GotFocus
        If textsearch.Text = "Enter keyword here to search.." Then
            textsearch.Text = ""
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

    Public Sub showInfo()
        frmRequestQuantitySelect.productid.Text = MyDataGridView.Item("Item Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.catid.Text = MyDataGridView.Item("catid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtunit.Text = MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtProductName.Text = MyDataGridView.Item("Particulars", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.txtsti.Text = MyDataGridView.Item("Latest Cost", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.vendorid.Text = MyDataGridView.Item("vendorid", MyDataGridView.CurrentRow.Index).Value().ToString
        'frmRequestQuantitySelect.txtTempVendor.Text = MyDataGridView.Item("vendor", MyDataGridView.CurrentRow.Index).Value().ToString
        frmRequestQuantitySelect.pid.Text = pid.Text
        frmRequestQuantitySelect.Show(Me)
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        'You're Code
        If e.KeyCode = Keys.Enter Then
            showInfo()
        ElseIf e.KeyCode = Keys.Space Then
            textsearch.Focus()
            textsearch.SelectAll()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
        Else
            e.Handled = True
        End If
        Return
    End Sub

    Private Sub EditChapterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditChapterToolStripMenuItem.Click
        showInfo()
    End Sub

    Private Sub textsearch_Click(sender As Object, e As EventArgs) Handles textsearch.Click

    End Sub

    Private Sub textsearch_LostFocus(sender As Object, e As EventArgs) Handles textsearch.LostFocus
        If textsearch.Text = "" Then
            textsearch.Text = "Enter keyword here to search.."
        End If
    End Sub

    Private Sub MyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyDataGridView.CellContentClick

    End Sub

    Private Sub MyDataGridView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyDataGridView.KeyPress

    End Sub
End Class