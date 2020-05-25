Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmHotelAddonProductSearch
    Public TransactionDone As Boolean = False

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            If Not txtSearchBox.Focus = True Then
                txtSearchBox.SelectAll()
                txtSearchBox.Focus()
            End If
        ElseIf keyData = Keys.Alt + Keys.V Then
            On Error Resume Next
            Dim colname As String = ""
            frmPOSAdminConfirmation.ShowDialog(Me)
            If frmPOSAdminConfirmation.ApprovedConfirmation = True Then
                For i = 0 To MyDataGridView.ColumnCount - 1
                    colname += MyDataGridView.Columns(i).Name & ","
                Next
                frmColumnChooser.txttype.Text = Me.Name
                frmColumnChooser.init_grid(MyDataGridView)
                frmColumnChooser.txtColumn.Text = colname.Remove(colname.Length - 1, 1)
                frmColumnChooser.Show(Me)

                frmPOSAdminConfirmation.ApprovedConfirmation = False
                frmPOSAdminConfirmation.Dispose()
            Else
                Return False
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub txtSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchBox.KeyPress
        If Trim(txtSearchBox.Text) = "" Then Exit Sub
        If e.KeyChar = Chr(13) Then
            If txtSearchBox.Text.Length < 3 Then
                MsgBox("Please enter keyword at least 3 characters to continue search!", MsgBoxStyle.Exclamation, "Error Search")
                txtSearchBox.Focus()
                Exit Sub
            End If
            SearchProduct(txtSearchBox.Text)
        End If
    End Sub
    Private Sub dataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            ExecuteOtherProduct()
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
        Else
            If e.KeyCode = Keys.Space Then
                txtSearchBox.SelectAll()
                txtSearchBox.Focus()
            End If
            e.Handled = True
        End If
        Return
    End Sub

    Public Sub SearchProduct(ByVal keywords As String)
        If txtSearchBox.Text = "" Then Exit Sub
        MyDataGridView.DataSource = Nothing : dst = New DataSet

        Dim strProductTemplate As String = ", if(servicemenuproduct=1,ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice),sellingprice) as 'Unit Price' "

        msda = New MySqlDataAdapter("select productid as 'Product Code', itemname as 'Product Name', (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category', (select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) as 'Sub Category', Unit " & strProductTemplate & "  from tblglobalproducts where catid in (select catid from tblprocategory where noninventory=1) and deleted=0 and (productid like '%" & rchar(keywords) & "%' or barcode like '%" & rchar(keywords) & "%' or itemname like '%" & rchar(keywords) & "%' or (select description from tblprocategory where catid =tblglobalproducts.catid) like '%" & rchar(keywords) & "%'  or (select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) like '%" & rchar(keywords) & "%') and enablesell=1 " & If(GlobalenableProductFilter = True, " and catid in (select categorycode from tblproductfilter where permissioncode='" & globalAuthcode & "')", ""), conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Product Code", "Unit", "Purchase Price", "Available Quantity", If(GlobalProductTemplate = 3, "Part Number", Nothing)}, DataGridViewContentAlignment.MiddleCenter)
        
        GridColumnChoosed(MyDataGridView, Me.Name)
        GridCurrencyColumn(MyDataGridView, {"Unit Price", "Purchase Price", "Available Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4"})
        GridColumnAlignment(MyDataGridView, {"Product Code", "Unit", "Unit Price", "Sub Category", "Available Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4", "Optional", "Purchase Price (Encypt)", "Unit Price (Encypt)", "Unit Price1 (Encypt)", "Unit Price2 (Encypt)", "Unit Price3 (Encypt)", "Unit Price4 (Encypt)"}, DataGridViewContentAlignment.MiddleCenter)
        MyDataGridView.Focus()
    End Sub
    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
    Private Sub frmPOSProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If GlobalProductTemplate = 4 Then
            MyDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect
            If MyDataGridView.RowCount > 0 Then
                If MyDataGridView.Columns("Unit Price (Original)").Visible = True Then
                    MyDataGridView.CurrentCell = MyDataGridView(MyDataGridView.Columns("Unit Price (Original)").Index, 0)
                End If
            End If
        Else
            MyDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            MyDataGridView.Focus()
        End If
        GridColumnChoosed(MyDataGridView, Me.Name)
    End Sub

#Region "PRODUCT SEARCH EXECUTION"

    Public Sub ExecuteOtherProduct()
        frmHotelAddonSelectQuantity.productid.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmHotelAddonSelectQuantity.Show(Me)
    End Sub

#End Region

End Class