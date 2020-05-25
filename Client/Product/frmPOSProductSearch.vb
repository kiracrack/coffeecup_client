Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Public Class frmPOSProductSearch
    Public TransactionDone As Boolean = False

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Space) Then
            If Not txtSearchBox.Focus = True Then
                txtSearchBox.SelectAll()
                txtSearchBox.Focus()
            End If

        ElseIf keyData = (Keys.Control) + Keys.P Then
            PrintProduct()

        ElseIf keyData = Keys.Control + Keys.N Then
            If Globalenablesalesdirectproductregister = True Then
              
                If GlobalProductTemplate = 2 Then
                    frmPOSDirectProductAdd2.mode.Text = "new"
                    frmPOSDirectProductAdd2.Show(Me)
                ElseIf GlobalProductTemplate = 3 Then
                    frmPOSDirectProductAdd3.mode.Text = "new"
                    frmPOSDirectProductAdd3.Show(Me)
                End If

            End If
        ElseIf keyData = Keys.Control + Keys.E Then
            If Globalenablesalesdirectproductregister = True Then
                MyDataGridView.Focus()

                 If GlobalProductTemplate = 2 Then
                    frmPOSDirectProductAdd2.mode.Text = "edit"
                    frmPOSDirectProductAdd2.productid.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
                    If Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) > 0 Then
                        frmPOSDirectProductAdd2.txtBeginningQuantity.Value = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString))
                    End If
                    frmPOSDirectProductAdd2.Show(Me)

                ElseIf GlobalProductTemplate = 3 Then
                    frmPOSDirectProductAdd3.mode.Text = "edit"
                    frmPOSDirectProductAdd3.productid.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
                    If Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) > 0 Then
                        frmPOSDirectProductAdd3.txtBeginningQuantity.Value = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString))
                    End If
                    frmPOSDirectProductAdd3.Show(Me)
                End If
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
            If MyDataGridView.RowCount = 0 Then Exit Sub
            If mode.Text = "searchmode" Then
                If Globalenablesalesdirectproductregister = True Then
                    MyDataGridView.Focus()
                    If GlobalProductTemplate = 2 Then
                        frmPOSDirectProductAdd2.mode.Text = "edit"
                        frmPOSDirectProductAdd2.productid.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
                        If Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) > 0 Then
                            frmPOSDirectProductAdd2.txtBeginningQuantity.Value = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString))
                        End If
                        frmPOSDirectProductAdd2.Show(Me)
                    ElseIf GlobalProductTemplate = 3 Then
                        frmPOSDirectProductAdd3.mode.Text = "edit"
                        frmPOSDirectProductAdd3.productid.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
                        If Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString)) > 0 Then
                            frmPOSDirectProductAdd3.txtBeginningQuantity.Value = Val(CC(MyDataGridView.Item("Quantity", MyDataGridView.CurrentRow.Index).Value().ToString))
                        End If
                        frmPOSDirectProductAdd3.Show(Me)
                    End If
                End If
            Else
                If CBool(qrysingledata("enablespecialprice", "enablespecialprice", "tblclientaccounts where cifid='" & frmPointOfSale.cifid.Text & "'")) = True Then
                    If countqry("tblglobalproducts", "productid='" & rchar(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString) & "' and forcontract=0") > 0 Then
                        ExecuteSpecialPriceProduct(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("Product Name", MyDataGridView.CurrentRow.Index).Value().ToString)
                    Else
                        If GlobalProductTemplate = 4 Then
                            ExecuteTemplate4()
                        Else
                            ExecuteOtherProduct(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("Unit Price", MyDataGridView.CurrentRow.Index).Value().ToString)
                        End If
                    End If
                Else
                    If GlobalProductTemplate = 4 Then
                        ExecuteTemplate4()
                    Else
                        ExecuteOtherProduct(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString, MyDataGridView.Item("Unit Price", MyDataGridView.CurrentRow.Index).Value().ToString)
                    End If
                End If
            End If
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
        If EnableModuleSales = True Then
            If mode.Text = "searchmode" Then
                msda = New MySqlDataAdapter("select productid as 'Product Code', ucase(itemname) as 'Product Name', ucase(unit) as 'Unit', (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category',(select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) as 'Sub Category',purchasedprice as 'Purchase Price'  from tblglobalproducts where deleted=0 and (" & SearchProductName("itemname", rchar(keywords)) & " or productid like '%" & rchar(keywords) & "%' or barcode like '%" & rchar(keywords) & "%' or (select description from tblprocategory where catid =tblglobalproducts.catid) like '%" & rchar(keywords) & "%' or (select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) like '%" & rchar(keywords) & "%') order by itemname asc", conn)
                msda.Fill(dst, 0)
                MyDataGridView.DataSource = dst.Tables(0)
            Else
                Dim strProductTemplate As String = ""
                If GlobalProductTemplate = 4 Then
                    strProductTemplate = ", sellingprice as 'Unit Price (Original)' " & EncrypGridColumnNumbers("sellingprice", "Unit Price (Encypt)") & ", sellingprice1 as 'Unit Price1' " & EncrypGridColumnNumbers("sellingprice1", "Unit Price1 (Encypt)") & ", sellingprice2 as 'Unit Price2' " & EncrypGridColumnNumbers("sellingprice2", "Unit Price2 (Encypt)") & ", sellingprice3 as 'Unit Price3' " & EncrypGridColumnNumbers("sellingprice3", "Unit Price3 (Encypt)") & ", sellingprice4 as 'Unit Price4' " & EncrypGridColumnNumbers("sellingprice4", "Unit Price4 (Encypt)") & ",'Enter Amount' as 'Optional'"
                Else
                    strProductTemplate = ", if(servicemenuproduct=1,ifnull((select sum(amount) from tblproductserviceitem where source_productid=tblglobalproducts.productid),sellingprice),sellingprice) as 'Unit Price'  " & EncrypGridColumnNumbers("sellingprice", "Unit Price (Encypt)") & ""
                End If
                Dim SearchCommand As String = ""

                SearchCommand = " and (" & SearchProductName("itemname", rchar(keywords)) & " or productid like '%" & rchar(keywords) & "%' or " _
                      + " barcode like '%" & rchar(keywords) & "%')"


                msda = New MySqlDataAdapter("select productid as 'Product Code',Barcode, ucase(itemname) as 'Product Name', (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category', (select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) as 'Sub Category', " & If(GlobalProductTemplate = 3, " partnumber as 'Part Number',", "") & " ifnull((select sum(quantity) from tblinventory where quantity>0 and productid = tblglobalproducts.productid and officeid='" & compOfficeid & "'),0) as 'Quantity', ucase(unit) as 'Unit', purchasedprice as 'Purchase Price' " & EncrypGridColumnNumbers("purchasedprice", "Purchase Price (Encypt)") & "  " & strProductTemplate & "  from tblglobalproducts where deleted=0 " & SearchCommand & "  and enablesell=1 " & If(GlobalenableProductFilter = True, " and catid in (select categorycode from tblproductfilter where permissioncode='" & globalAuthcode & "') ", "") & " order by itemname asc ", conn)
                msda.Fill(dst, 0)
                MyDataGridView.DataSource = dst.Tables(0)
                If GlobalProductTemplate = 4 Then
                    If MyDataGridView.RowCount > 0 Then
                        If MyDataGridView.Columns("Unit Price (Original)").Visible = True Then
                            MyDataGridView.CurrentCell = MyDataGridView(MyDataGridView.Columns("Unit Price (Original)").Index, 0)
                        End If
                    End If
                End If
                GridColumnChoosed(MyDataGridView, Me.Name)
            End If
        Else
            msda = New MySqlDataAdapter("select productid as 'Product Code', ucase(itemname) as 'Product Name', ucase(unit) as 'Unit', (select DESCRIPTION from tblprocategory where CATID = tblglobalproducts.CATID) as 'Category',(select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) as 'Sub Category'  from tblglobalproducts where deleted=0 and (" & SearchProductName("itemname", rchar(keywords)) & " or productid like '%" & rchar(keywords) & "%' or barcode like '%" & rchar(keywords) & "%' or (select description from tblprocategory where catid =tblglobalproducts.catid) like '%" & rchar(keywords) & "%' or (select description from tblprosubcategory where subcatid = tblglobalproducts.subcatid) like '%" & rchar(keywords) & "%') order by itemname asc", conn)
            msda.Fill(dst, 0)
            MyDataGridView.DataSource = dst.Tables(0)
        End If
        GridCurrencyColumn(MyDataGridView, {"Unit Price", "Purchase Price", "Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4"})
        GridColumnAlignment(MyDataGridView, {"Product Code", "Category", "Barcode", "Unit", "Part Number", "Purchase Price", "Unit Price", "Sub Category", "Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4", "Optional", "Purchase Price (Encypt)", "Unit Price (Encypt)", "Unit Price1 (Encypt)", "Unit Price2 (Encypt)", "Unit Price3 (Encypt)", "Unit Price4 (Encypt)"}, DataGridViewContentAlignment.MiddleCenter)
        PaintColumnFormat()
        MyDataGridView.Focus()
    End Sub

    Public Sub PaintColumnFormat()
        GridColumAutonWidth(MyDataGridView, {"Category", "Product Name", "Sub Category", "Part Number"})
        GridColumnWidth(MyDataGridView, {"Barcode", "Product Code"}, 90)
        GridColumnWidth(MyDataGridView, {"Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4", "Optional", "Purchase Price (Encypt)", "Unit Price (Encypt)", "Unit Price1 (Encypt)", "Unit Price2 (Encypt)", "Unit Price3 (Encypt)", "Unit Price4 (Encypt)"}, 80)
        If mode.Text = "searchmode" Then
            GridColumnWidth(MyDataGridView, {"Purchase Price"}, 120)
        End If
        GridColumnWidth(MyDataGridView, {"Unit"}, 100)
        Dim column As Array = {"Product Code", "Purchase Price", "Unit", "Unit Price", "Category", "Sub Category", "Quantity", "Unit Price (Original)", "Unit Price1", "Unit Price2", "Unit Price3", "Unit Price4", "Optional", "Purchase Price (Encypt)", "Unit Price (Encypt)", "Unit Price1 (Encypt)", "Unit Price2 (Encypt)", "Unit Price3 (Encypt)", "Unit Price4 (Encypt)"}
        Dim TotalVisibleColumn As Double = 0
        For Each valueArr As String In column
            For i = 0 To MyDataGridView.ColumnCount - 1
                If valueArr = MyDataGridView.Columns(i).Name Then
                    TotalVisibleColumn = TotalVisibleColumn + MyDataGridView.Columns(i).Width
                End If
            Next
        Next
        If TotalVisibleColumn > MyDataGridView.Width Then
            GridColumnWidth(MyDataGridView, {"Product Name"}, 300)
        Else
            GridColumnWidth(MyDataGridView, {"Product Name"}, MyDataGridView.Width - TotalVisibleColumn)
        End If
    End Sub

    Private Sub frmPOSProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        MyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        MyDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'If Globalenableposviewrowborder = False Then
        '    MyDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        '    MyDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        'End If
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
        PaintColumnFormat()
        GridColumnChoosed(MyDataGridView, Me.Name)
    End Sub

#Region "PRODUCT SEARCH EXECUTION"

    Public Sub ExecuteTemplate4()
        Dim ExecuteAmount As Double = 0
        Dim SalesMode As String = qrysingledata("salemode", "salemode", "tblglobalproducts where productid='" & MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'")
        If SalesMode <> "esba" Then
            If MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Unit Price (Original)" And
                   MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Unit Price1" And
                   MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Unit Price2" And
                   MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Unit Price3" And
                   MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Unit Price4" And
                   MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name <> "Optional" Then
                Exit Sub
            End If

            If countqry("tblinventory", "productid='" & rchar(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString) & "'  and officeid='" & compOfficeid & "'") = 0 And countqry("tblglobalproducts", "productid='" & rchar(MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString) & "' and forcontract=0") > 0 And compEnableInventory = True Then
                MsgBox("Product inventory not available!", MsgBoxStyle.Exclamation, "Error Message")
                Exit Sub
            End If

            If MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Unit Price (Original)" Then
                ExecuteAmount = Val(CC(MyDataGridView.Item("Unit Price (Original)", MyDataGridView.CurrentRow.Index).Value().ToString))
            ElseIf MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Unit Price1" Then
                ExecuteAmount = Val(CC(MyDataGridView.Item("Unit Price1", MyDataGridView.CurrentRow.Index).Value().ToString))
            ElseIf MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Unit Price2" Then
                ExecuteAmount = Val(CC(MyDataGridView.Item("Unit Price2", MyDataGridView.CurrentRow.Index).Value().ToString))
            ElseIf MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Unit Price3" Then
                ExecuteAmount = Val(CC(MyDataGridView.Item("Unit Price3", MyDataGridView.CurrentRow.Index).Value().ToString))
            ElseIf MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Unit Price4" Then
                ExecuteAmount = Val(CC(MyDataGridView.Item("Unit Price4", MyDataGridView.CurrentRow.Index).Value().ToString))
            ElseIf MyDataGridView.Columns(MyDataGridView.CurrentCell.ColumnIndex).Name = "Optional" Then
                If MessageBox.Show("Are you sure you want enter optional selling amount? " & Environment.NewLine & Environment.NewLine & "Note: this transaction needs an administrative login approval!  ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    frmPOSAdminOtherAmountConfirmation.ShowDialog(Me)
                    If frmPOSAdminOtherAmountConfirmation.ApprovedConfirmation = True Then
                        ExecuteAmount = Val(CC(frmPOSAdminOtherAmountConfirmation.txtAmount.Text))
                        frmPOSAdminOtherAmountConfirmation.ApprovedConfirmation = False
                        frmPOSAdminOtherAmountConfirmation.Dispose()
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            End If

            If ExecuteAmount = 0 Then
                MsgBox("System not allowed with zero selling price amount! please contact your system administrator", MsgBoxStyle.Exclamation, "Error Message")
                Exit Sub
            End If
        End If

        frmPointOfSale.txtBarCode.Text = MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString
        If SalesMode = "esba" Then
            If MyDataGridView.Item("Unit", MyDataGridView.CurrentRow.Index).Value().ToString = "" Then
                frmPOSProductEnterByAmountwithUnit.CheckBox1.Checked = CBool(qrysingledata("allownegativeinputs", "allownegativeinputs", "tblglobalproducts where productid='" & MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'"))
                LoadToComboBoxDB("select distinct unit from tblglobalproduct", "unit", "unit", frmPOSProductEnterByAmountwithUnit.txtUnit)
                frmPOSProductEnterByAmountwithUnit.ShowDialog(Me)
                If frmPOSProductEnterByAmountwithUnit.Executed = True Then
                    com.CommandText = "update tblglobalproducts set unit='" & frmPOSProductEnterByAmountwithUnit.txtUnit.Text & "' where productid='" & MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
                    ExecuteAmount = Val(CC(frmPOSConfirmClientSpecialPrice.txtAmount.Text))
                    frmPOSProductEnterByAmountwithUnit.Executed = False
                    frmPOSProductEnterByAmountwithUnit.Dispose()
                Else
                    Exit Sub
                End If
                frmPointOfSale.PostSalesTransaction(False, MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, "")
            Else
                frmPOSProductEnterByAmount.CheckBox1.Checked = CBool(qrysingledata("allownegativeinputs", "allownegativeinputs", "tblglobalproducts where productid='" & MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'"))
                frmPOSProductEnterByAmount.ShowDialog(Me)
                If frmPOSProductEnterByAmount.Executed = True Then
                    ExecuteAmount = Val(CC(frmPOSConfirmClientSpecialPrice.txtAmount.Text))
                    frmPOSProductEnterByAmount.Executed = False
                    frmPOSProductEnterByAmount.Dispose()
                Else
                    Exit Sub
                End If
                frmPointOfSale.PostSalesTransaction(False, MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, "")
            End If

        Else
            frmPointOfSale.PostSalesTransaction(False, MyDataGridView.Item("Product Code", MyDataGridView.CurrentRow.Index).Value().ToString, frmPointOfSale.txtQuantity.Text, Val(CC(MyDataGridView.Item("Unit Price", MyDataGridView.CurrentRow.Index).Value().ToString)), 0, "")
        End If
        ExecuteAmount = 0
        Me.Close()
    End Sub

    Public Sub ExecuteOtherProduct(ByVal productid As String, ByVal unit As String, ByVal unitcost As String)
        If countqry("tblinventory", "productid='" & rchar(productid) & "'  and officeid='" & compOfficeid & "'") = 0 And countqry("tblglobalproducts", "productid='" & rchar(productid) & "' and forcontract=0") > 0 And compEnableInventory = True Then
            MsgBox("Product inventory not available!", MsgBoxStyle.Exclamation, "Error Message")
            Exit Sub
        End If
        Dim ExecuteAmount As Double = 0
        Dim SalesMode As String = qrysingledata("salemode", "salemode", "tblglobalproducts where productid='" & productid & "'")

        If SalesMode = "esba" Then
            If unit = "" Then
                frmPOSProductEnterByAmountwithUnit.CheckBox1.Checked = CBool(qrysingledata("allownegativeinputs", "allownegativeinputs", "tblglobalproducts where productid='" & productid & "'"))
                frmPOSProductEnterByAmountwithUnit.txtAmount.Text = unitcost
                LoadToComboBoxDB("select distinct unit from tblglobalproducts", "unit", "unit", frmPOSProductEnterByAmountwithUnit.txtUnit)
                frmPOSProductEnterByAmountwithUnit.ShowDialog(Me)
                If frmPOSProductEnterByAmountwithUnit.Executed = True Then
                    com.CommandText = "update tblglobalproducts set unit='" & frmPOSProductEnterByAmountwithUnit.txtUnit.Text & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
                    ExecuteAmount = Val(CC(frmPOSProductEnterByAmountwithUnit.txtAmount.Text))
                    frmPOSProductEnterByAmountwithUnit.Executed = False
                    frmPOSProductEnterByAmountwithUnit.Dispose()
                Else
                    Exit Sub
                End If
                frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, "")
            Else
                Dim EnterDiscount As Boolean = CBool(qrysingledata("allownegativeinputs", "allownegativeinputs", "tblglobalproducts where productid='" & productid & "'"))
                Dim EnterCustomAmount As Boolean = CBool(qrysingledata("allowinputdiscountedamount", "allowinputdiscountedamount", "tblglobalproducts where productid='" & productid & "'"))
                Dim updaterequired As Boolean = CBool(qrysingledata("updaterequired", "updaterequired", "tblglobalproducts where productid='" & productid & "'"))
                If (EnterDiscount = True Or updaterequired = True Or EnterCustomAmount = True) And Globalenablechittransaction = False Then
                    Dim remarks As String = ""
                    Dim frm As New frmPOSProductEnterByAmount
                    frm.CheckBox1.Checked = EnterDiscount
                    frm.txtAmount.Text = unitcost
                    frm.ShowDialog(Me)
                    If frm.Executed = True Then
                        ExecuteAmount = Val(CC(frm.txtAmount.Text))
                        remarks = frm.txtRemarks.Text
                        frm.Executed = False
                        frm.Dispose()
                    Else
                        Exit Sub
                    End If
                    frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, ",remarks='" & rchar(remarks) & "'")
                Else
                    Dim chitAmount As Double = 0
                    Dim frm As New frmPOSProductEnterByChitAmount
                    frm.txtAmount.Text = unitcost
                    frm.ShowDialog(Me)
                    If frm.Executed = True Then
                        ExecuteAmount = Val(CC(frm.txtAmount.Text))
                        chitAmount = Val(CC(frm.txtChitAmount.Text))
                        frm.Executed = False
                        frm.Dispose()
                    Else
                        Exit Sub
                    End If
                    frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, ExecuteAmount, chitAmount, "")
                End If
            End If
        Else
            Dim updaterequired As Boolean = CBool(qrysingledata("updaterequired", "updaterequired", "tblglobalproducts where productid='" & productid & "'"))
            If updaterequired = True Then
                Dim frm As New frmPOSProductEnterByAmount
                frm.CheckBox1.Checked = False
                frm.txtAmount.Text = unitcost
                frm.ShowDialog(Me)
                If frm.Executed = True Then
                    ExecuteAmount = Val(CC(frm.txtAmount.Text))
                    frm.Executed = False
                    frm.Dispose()
                Else
                    Exit Sub
                End If
                com.CommandText = "update tblglobalproducts set sellingprice='" & ExecuteAmount & "' where productid='" & productid & "'" : com.ExecuteNonQuery()
                frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, "")
            Else

                frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, Val(CC(unitcost)), 0, "")
            End If
        End If
        Me.Close()
    End Sub

    Public Sub ExecuteSpecialPriceProduct(ByVal productid As String, ByVal productname As String)
        If countqry("tblinventory", "productid='" & productid & "'  and officeid='" & compOfficeid & "'") = 0 And countqry("tblglobalproducts", "productid='" & productid & "' and forcontract=0") > 0 And compEnableInventory = True Then
            MsgBox("Product inventory not available!", MsgBoxStyle.Exclamation, "Error Message")
            Exit Sub
        End If
        Dim ExecuteAmount As Double = 0
        frmPOSConfirmClientSpecialPrice.txtProductName.Text = productname
        frmPOSConfirmClientSpecialPrice.productid.Text = productid
        frmPOSConfirmClientSpecialPrice.ShowDialog(Me)
        If frmPOSConfirmClientSpecialPrice.Executed = True Then
            ExecuteAmount = Val(CC(frmPOSConfirmClientSpecialPrice.txtAmount.Text))
            frmPOSConfirmClientSpecialPrice.Executed = False
            frmPOSConfirmClientSpecialPrice.Dispose()
        Else
            Exit Sub
        End If
        frmPointOfSale.txtBarCode.Text = productid
        frmPointOfSale.PostSalesTransaction(False, productid, frmPointOfSale.txtQuantity.Text, ExecuteAmount, 0, "")
        ExecuteAmount = 0
        Me.Close()
    End Sub

#End Region
  
    Private Sub MyDataGridView_Resize(sender As Object, e As EventArgs) Handles MyDataGridView.Resize
        PaintColumnFormat()
    End Sub
End Class