Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing

Public Class frmSupplierManagement
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
        ViewSupplierList()
    End Sub

    
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            ViewSupplierList()
        End If
    End Sub

    Public Sub ViewSupplierList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("Select vendorid," _
                  + " COMPANYNAME as 'Company Name', " _
                  + " COMPADD as 'Address', " _
                  + " TELEPHONE as 'Telephone', " _
                  + " EMAIL as 'Email Address', " _
                  + " WEBSITE as 'Website', " _
                  + " CONTPERSON as 'Contact Person', " _
                  + " DESIGNATION as 'Position', " _
                  + " bankaccount as 'Bank Account', " _
                  + " accountnumber as 'Account Number' " _
                  + " from tblglobalvendor where deleted=0 and (companyname like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " compadd like '%" & rchar(txtsearch.Text) & "%' or " _
                  + " contperson like '%" & rchar(txtsearch.Text) & "%') order by COMPANYNAME asc ", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridHideColumn(MyDataGridView, {"vendorid"})
        GridColumnChoosed(MyDataGridView, Me.Name)
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub cmdLocalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocalData.Click
        ViewSupplierList()
    End Sub
 

    Private Sub cmdColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColumnChooser.Click
        On Error Resume Next
        Dim colname As String = ""
        For i = 0 To MyDataGridView.ColumnCount - 1
            colname += MyDataGridView.Columns(i).Name & ","
        Next
        frmColumnChooser.txttype.Text = Me.Name
        frmColumnChooser.init_grid(MyDataGridView)
        frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
        frmColumnChooser.Show(Me)
    End Sub

    
    Private Sub cmdSet2_Click(sender As Object, e As EventArgs) Handles cmdSet2.Click
        frmSupplierRegistration.mode.Text = ""
        frmSupplierRegistration.Show(Me)
    End Sub

    Private Sub EditSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSupplierToolStripMenuItem.Click
        frmSupplierRegistration.mode.Text = "edit"
        frmSupplierRegistration.vendorid.Text = MyDataGridView.Item("vendorid", MyDataGridView.CurrentRow.Index).Value().ToString
        frmSupplierRegistration.Show(Me)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintDatagridview(Me.Text, "List of Supplier", "", MyDataGridView, Me)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ExportGridToExcel(Me.Text, dst)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripSeparator1_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator1.Click

    End Sub
End Class