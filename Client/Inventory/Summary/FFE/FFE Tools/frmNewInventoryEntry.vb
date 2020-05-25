Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class frmNewInventoryEntry
    Private cellInError As New Point(-2, -2)
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.F2) Then
            MyDataGridView.Focus()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmNewInventoryEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        ApplySystemTheme(ToolStrip1)
        loaddata()
        PopulateGridViewColumns("required", 10, False, MyDataGridView, False, True)
        PopulateGridViewColumns("sortorder", 10, False, MyDataGridView, False, True)
        PopulateGridViewColumns("fieldname", 10, False, MyDataGridView, False, True)
        PopulateGridViewColumns("Description", 65, False, MyDataGridView, True, True)
        PopulateGridViewColumns("Value", 65, True, MyDataGridView, True, False)
        If mode.Text = "edit" Then
            ShowFFEInformation(ffecode.Text, "edit")
            cmdMemorandumOfReceipt.Visible = True
        ElseIf mode.Text = "view" Then
            ShowFFEInformation(ffecode.Text, "view")

            cmdMemorandumOfReceipt.Visible = True
        Else
            NewInventory()
            cmdMemorandumOfReceipt.Visible = False
        End If
    End Sub

    Public Sub NewInventory()
        txtProductName.Enabled = True
        txtProductName.Text = ""
        txtUnitType.Text = ""
        txtQuantity.Text = "1"
        txtUnitCost.Text = "0.00"
        txtBookValue.Text = "0.00"
        txtMonthlyDepreciation.Text = "0.00"
        txtDepreciationLastUpdate.Value = CDate(Now)
        txtDatePurchased.Value = CDate(Now)
        MyDataGridView.Rows.Clear()
        mode.Text = ""

        txtAccountableView.Visible = False
        txtAccountablePerson.Visible = True
        txtIssueNote.ReadOnly = False
        txtDateIssue.Enabled = True
    End Sub

    Public Sub loaddata()
        LoadStockhouse()
        LoadAccountable()
        LoadVendor()
    End Sub

    Public Sub LoadStockhouse()
        LoadToComboBoxDB("select *,ucase(stockhousename) as 'stockhouse' from tblstockhouse where officeid='" & officeid.text & "' order by stockhousename asc", "stockhouse", "stockhouseid", txtstockhouse)
    End Sub

    Public Sub LoadAccountable()
        LoadToComboBoxDB("select * from tblaccounts where deleted=0 and officeid='" & officeid.text & "' order by fullname asc", "fullname", "accountid", txtAccountablePerson)
    End Sub

    Public Sub LoadVendor()
        LoadToComboBoxDB("select * from tblglobalvendor order by companyname asc", "companyname", "vendorid", txtVendor)
    End Sub

    Private Sub txtstockhouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtstockhouse.SelectedValueChanged
        If txtstockhouse.Text <> "" Then
            stockhouseid.Text = DirectCast(txtstockhouse.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub
    Private Sub txtAccountablePerson_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtAccountablePerson.SelectedValueChanged
        If txtAccountablePerson.Text <> "" Then
            accountableid.Text = DirectCast(txtAccountablePerson.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub
    Private Sub txtVendor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtVendor.SelectedValueChanged
        If txtVendor.Text <> "" Then
            vendorid.Text = DirectCast(txtVendor.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub
    Private Sub txtProductName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProductName.KeyDown
        If e.KeyData = Keys.Enter Then
            If txtProductName.Text = "" Or txtProductName.Text = "%" Then Exit Sub
            If countqry("tblglobalproducts", " concat(itemname,' (',unit,')') = '" & txtProductName.Text & "'") = 0 Then
                LoadToComboBoxDB("SELECT *,concat(itemname,' (',unit,')') as 'productname' FROM tblglobalproducts where deleted=0 and concat(itemname,' (',unit,')') like '%" & txtProductName.Text & "%'  order by itemname asc;", "productname", "productid", txtProductName)
                txtProductName.DroppedDown = True
            Else
                viewProductinfo()
                txtQuantity.Focus()
            End If
        End If
    End Sub

    Private Sub txtProductName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtProductName.SelectedValueChanged
        If mode.Text = "edit" Or mode.Text = "view" Then Exit Sub
        If txtProductName.Text <> "" Then
            viewProductinfo()
        End If
    End Sub
    Public Sub viewProductinfo()
        Dim ffetype As String = ""
        productid.Text = DirectCast(txtProductName.SelectedItem, ComboBoxItem).HiddenValue()
        com.CommandText = "select *,(select description from tblprocategory where catid=tblglobalproducts.catid) as categoryname , ifnull(ifnull((select procost from tblitemvendor where officeid='" & officeid.text & "' and itemid = tblglobalproducts.productid order by lastupdate asc limit 1), " _
            + " (select purchasedprice from tblinventory where productid=tblglobalproducts.productid and officeid = '" & officeid.text & "' limit 1)),0) as 'latestcost' from tblglobalproducts where productid='" & productid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            catid.Text = rst("catid").ToString
            txtCategory.Text = rst("categoryname").ToString
            txtUnitType.Text = rst("unit").ToString
            txtUnitCost.Text = FormatNumber(rst("latestcost").ToString, 2)
            ffetype = rst("ffetype").ToString
        End While
        rst.Close()
        If ffetype = "" Then
            txtExistingFFEType.Visible = False
            txtFFEType.Visible = True
            LoadFFEtype()
            MyDataGridView.Rows.Clear()
        Else
            txtExistingFFEType.Visible = True
            txtFFEType.Visible = False
            ffetypecode.Text = ffetype
            txtExistingFFEType.Text = qrysingledata("description", "description", "tblinventoryffetype where code='" & ffetype & "'")
        End If

        LoadFFEDetails(ffetype)
    End Sub
    Public Sub LoadFFEtype()
        LoadToComboBoxDB("select * from tblinventoryffetype where catid='" & catid.Text & "' order by description asc", "description", "code", txtFFEType)
    End Sub

    Private Sub txtFFEType_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFFEType.SelectedValueChanged
        ffetypecode.Text = DirectCast(txtFFEType.SelectedItem, ComboBoxItem).HiddenValue()
        LoadComboSuggestion("Value", MyDataGridView, "select distinct(value) as val from tblinventoryffedetails where ffetype='" & ffetypecode.Text & "'", "val")
        LoadFFEDetails(ffetypecode.Text)
    End Sub
    Public Sub LoadFFEDetails(ByVal ffetype As String)
        MyDataGridView.Rows.Clear()
        If mode.Text = "edit" Or mode.Text = "view" Then
            If countqry("tblinventoryffedetails", "ffecode='" & ffecode.Text & "'") = 0 Then
                LoadFFEtypeSetup(ffetype)
            Else
                dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblinventoryffesetup where ffetype='" & ffetypecode.Text & "' order by sortorder asc", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        MyDataGridView.Rows.Add(.Rows(cnt)("required"), .Rows(cnt)("sortorder").ToString(), .Rows(cnt)("fieldname").ToString(), .Rows(cnt)("description").ToString(), qrysingledata("value", "value", "tblinventoryffedetails where ffecode='" & ffecode.Text & "' and ffetype='" & ffetypecode.Text & "' and fieldname='" & .Rows(cnt)("fieldname").ToString() & "'"))
                        If CBool(.Rows(cnt)("required")) = True Then
                            MyDataGridView.Rows(cnt).Cells("Description").Style.BackColor = Color.LemonChiffon
                            MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionBackColor = Color.LemonChiffon
                            MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionForeColor = Color.Black
                        Else
                            MyDataGridView.Rows(cnt).Cells("Description").Style.BackColor = Color.White
                            MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionBackColor = Color.White
                            MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionForeColor = Color.Black
                        End If
                    End With
                Next
            End If
        Else
            LoadFFEtypeSetup(ffetype)
        End If

    End Sub

    Public Function LoadFFEtypeSetup(ByVal ffetype As String)
        dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblinventoryffesetup where ffetype='" & ffetype & "' order by sortorder asc", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                MyDataGridView.Rows.Add(.Rows(cnt)("required"), .Rows(cnt)("sortorder").ToString(), .Rows(cnt)("fieldname").ToString(), .Rows(cnt)("description").ToString(), "")
                If CBool(.Rows(cnt)("required")) = True Then
                    MyDataGridView.Rows(cnt).Cells("Description").Style.BackColor = Color.LemonChiffon
                    MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionBackColor = Color.LemonChiffon
                    MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionForeColor = Color.Black
                Else
                    MyDataGridView.Rows(cnt).Cells("Description").Style.BackColor = Color.White
                    MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionBackColor = Color.White
                    MyDataGridView.Rows(cnt).Cells("Description").Style.SelectionForeColor = Color.Black
                End If
            End With
        Next
        Return True
    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If cmdSave.Text = "Close" Then
            Me.Close()
       
        Else
            If txtProductName.Text = "" Then
                MsgBox("Please select Product!", MsgBoxStyle.Critical)
                txtProductName.Focus()
                Exit Sub
            ElseIf countqry("tblglobalproducts", "concat(itemname,' (',unit,')')='" & txtProductName.Text & "' and productid='" & productid.Text & "'") = 0 And mode.Text <> "edit" Then
                MsgBox("Please enter valid product!" + Chr(13) + Chr(13) + "NOTE: to validate proper product selection, please hit ENTER key after typing to validate product information", MsgBoxStyle.Critical)
                txtProductName.Focus()
                Exit Sub
            ElseIf MyDataGridView.Rows.Count = 0 And Globalenablestrictffedetails = True Then
                MsgBox("FFE settings not configured! Please contact procurement department or system administrator", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf Val(CC(txtQuantity.Text)) <= 0 Then
                MsgBox("Quantity not valid!", MsgBoxStyle.Critical)
                txtQuantity.Focus()
                Exit Sub
            ElseIf Val(CC(txtUnitCost.Text)) <= 0 Then
                MsgBox("Unit cost not valid!", MsgBoxStyle.Critical)
                txtUnitCost.Focus()
                Exit Sub
            ElseIf txtAccountablePerson.Text = "" And mode.Text = "new" Then
                MsgBox("Please select accountable person!", MsgBoxStyle.Critical)
                txtAccountablePerson.Focus()
                Exit Sub
            End If

            'validate other required fields
            If Globalenablestrictffedetails = True Then
                Dim RequiredFieldMissing As Boolean = False
                For i = 0 To MyDataGridView.Rows.Count - 1
                    If CBool(MyDataGridView.Rows(i).Cells("required").Value) = True And Trim(MyDataGridView.Rows(i).Cells("Value").Value) = "" Then
                        RequiredFieldMissing = True
                    End If
                Next

                If RequiredFieldMissing = True Then
                    For i = 0 To MyDataGridView.Rows.Count - 1
                        If CBool(MyDataGridView.Rows(i).Cells("required").Value) = True And Trim(MyDataGridView.Rows(i).Cells("Value").Value) = "" Then
                            MyDataGridView.Rows(i).Cells("Value").Style.BackColor = Color.Red
                            MyDataGridView.Rows(i).Cells("Value").Style.ForeColor = Color.White
                        End If
                    Next

                    MsgBox("Please fill the required fields! temporary text value is not acceptable.", MsgBoxStyle.Critical)
                    txtQuantity.Focus()
                    Exit Sub
                End If
            End If

            If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                UpdateFFEInventory(If(mode.Text = "", "new", "edit"), ffecode.Text, "-", officeid.Text, stockhouseid.Text, vendorid.Text, productid.Text, Val(txtQuantity.Text), Val(CC(txtUnitCost.Text)), ConvertDate(txtDatePurchased.Value), ckWarranty.CheckState, ConvertDate(txtWarrantyDate.Value), ckManualDepreciation.CheckState, Val(CC(txtBookValue.Text)), Val(CC(txtMonthlyDepreciation.Text)), ConvertDate(txtDepreciationLastUpdate.Value), accountableid.Text, rchar(txtIssueNote.Text), ConvertDate(txtDateIssue.Value), False, "", False, MyDataGridView)
                frmInventoryFFE.SecurityCheck()
                MsgBox("Product successfully saved!", MsgBoxStyle.Information)
                If allowmanualffeinventory = True Then
                    NewInventory()
                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub MyDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles MyDataGridView.CellBeginEdit
        MyDataGridView.Rows(MyDataGridView.CurrentRow.Index).Cells("Value").Style.BackColor = Color.White
        MyDataGridView.Rows(MyDataGridView.CurrentRow.Index).Cells("Value").Style.ForeColor = Color.Black
    End Sub

    Private Sub MyDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles MyDataGridView.EditingControlShowing
        If TypeOf e.Control Is System.Windows.Forms.ComboBox Then
            With DirectCast(e.Control, System.Windows.Forms.ComboBox)
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles MyDataGridView.CellValidating
        If (TypeOf CType(sender, DataGridView).EditingControl Is DataGridViewComboBoxEditingControl) Then
            Dim cmb As DataGridViewComboBoxEditingControl = CType(CType(sender, DataGridView).EditingControl, DataGridViewComboBoxEditingControl)
            If Not cmb Is Nothing Then
                Dim grid As DataGridView = cmb.EditingControlDataGridView
                Dim value As Object = cmb.Text
                '// Add value to list if not there
                If cmb.Items.IndexOf(value) = -1 And cmb.Text <> "" Then
                    '// Must add to both the current combobox as well as the template, to avoid duplicate entries...
                    cmb.Items.Add(value)
                    Dim cmbCol As DataGridViewComboBoxColumn = CType(grid.Columns(grid.CurrentCell.ColumnIndex), DataGridViewComboBoxColumn)
                    If Not cmbCol Is Nothing Then
                        cmbCol.Items.Add(value)
                        grid.CurrentCell.Value = value
                    End If
                End If
                grid.CurrentCell.Value = value
            End If
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        InputNumberOnly(txtQuantity, e)
    End Sub

    Private Sub txtUnitCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitCost.KeyPress
        InputNumberOnly(txtQuantity, e)
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, txtUnitCost.TextChanged
        txtTotal.Text = FormatNumber(Val(CC(txtUnitCost.Text)) * Val(CC(txtQuantity.Text)))
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProductRequest.Show(Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmStockhouseRegistration.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmEmployees.ShowDialog(Me)
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Me.Close()
    End Sub

    Private Sub ckWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles ckWarranty.CheckedChanged
        If ckWarranty.Checked = True Then
            txtWarrantyDate.Enabled = True
        Else
            txtWarrantyDate.Enabled = False
        End If
    End Sub

#Region "EDIT INFORMATION"
    Public Sub ShowFFEInformation(ByVal ffecodeEdit As String, ByVal mode As String)
        com.CommandText = "select *,(select companyname from tblglobalvendor where vendorid=tblinventoryffe.vendorid) as vendor, " _
                        + " (select stockhousename from tblstockhouse where stockhouseid=tblinventoryffe.stockhouseid) as stockhouse, " _
                        + " (select description from tblinventoryffetype where code=tblinventoryffe.ffetype) as ffe_type from tblinventoryffe where ffecode='" & ffecodeEdit & "'" : rst = com.ExecuteReader
        While rst.Read
            officeid.Text = rst("officeid").ToString
            productid.Text = rst("productid").ToString
            txtProductName.Text = rst("productname").ToString
            txtUnitType.Text = rst("unit").ToString
            catid.Text = rst("catid").ToString
            txtCategory.Text = rst("categoryname").ToString
            txtQuantity.Text = FormatNumber(rst("quantity").ToString, 0)
            txtUnitCost.Text = FormatNumber(rst("unitcost").ToString, 2)
            txtTotal.Text = FormatNumber(rst("totalamount").ToString, 2)
            txtDatePurchased.Value = rst("datepurchased").ToString
            txtVendor.Text = rst("vendor").ToString
            vendorid.Text = rst("vendorid").ToString
            txtstockhouse.Text = rst("stockhouse").ToString
            txtExistingFFEType.Text = rst("ffe_type").ToString
            ffetypecode.Text = rst("ffetype").ToString
            ckManualDepreciation.Checked = rst("manualdepreciation")
            txtBookValue.Text = FormatNumber(rst("bookvalue").ToString, 2)
            txtMonthlyDepreciation.Text = FormatNumber(rst("monthlydepreciation").ToString, 2)
            txtDepreciationLastUpdate.Value = If(rst("lastdepreciationdate").ToString <> "", rst("lastdepreciationdate").ToString, CDate(Now))
            accountableid.Text = rst("acctablepersonid").ToString
            txtAccountableView.Text = rst("acctableperson").ToString
            If CBool(rst("disposalrequested")) = True And CBool(rst("disposalapproved")) = False And CBool(rst("disposed")) = False Then
                If rst("disposalrequestedby").ToString = globaluserid Then
                    cmdMemorandumOfReceipt.Text = "Cancel Disposal Request"
                    cmdMemorandumOfReceipt.BackColor = Color.Orange
                Else
                    cmdMemorandumOfReceipt.Text = "Print Asset Profile"
                    cmdMemorandumOfReceipt.BackColor = Color.White
                End If
            Else
                cmdMemorandumOfReceipt.Text = "Print Asset Profile"
                cmdMemorandumOfReceipt.BackColor = Color.White
            End If
        End While
        rst.Close()
        txtProductName.Enabled = False

        com.CommandText = "select * from tblinventoryffeaccountable where ffecode='" & ffecodeEdit & "' and iscurrent=1" : rst = com.ExecuteReader
        While rst.Read
            issuecode.Text = rst("id").ToString
            txtAccountablePerson.Text = rst("accountname").ToString
            'txtAccountableView.Text = rst("accountname").ToString
            accountableid.Text = rst("acctableperson").ToString
            txtIssueNote.Text = rst("note").ToString
            txtDateIssue.Value = rst("dateissued").ToString
        End While
        rst.Close()

        If txtExistingFFEType.Text = "" Then
            txtExistingFFEType.Visible = False
            txtFFEType.Visible = True
            LoadFFEtype()
            MyDataGridView.Rows.Clear()
        Else
            txtExistingFFEType.Visible = True
            txtFFEType.Visible = False
            ffetypecode.Text = ffetypecode.Text
        End If

        If allowmanualffeinventory = True Then
            txtQuantity.ReadOnly = False
            txtUnitCost.ReadOnly = False
            txtDatePurchased.Enabled = True
            txtVendor.Enabled = True
            ckManualDepreciation.Enabled = True
            txtBookValue.ReadOnly = False
            txtBookValue.ReadOnly = False
            txtDepreciationLastUpdate.Enabled = True
        Else
            txtQuantity.ReadOnly = True
            txtUnitCost.ReadOnly = True
            txtDatePurchased.Enabled = False
            txtVendor.Enabled = False
            ckManualDepreciation.Enabled = False
            txtBookValue.ReadOnly = True
            txtMonthlyDepreciation.ReadOnly = True
            txtDepreciationLastUpdate.Enabled = False
        End If
        cmdSave.Text = "Save Inventory"

        LoadComboSuggestion("Value", MyDataGridView, "select distinct(value) as val from tblinventoryffedetails where ffetype='" & ffetypecode.Text & "'", "val")
        LoadFFEDetails(ffetypecode.Text)

        If mode = "view" Then
            txtQuantity.ReadOnly = True
            txtUnitCost.ReadOnly = True
            txtDatePurchased.Enabled = False
            txtVendor.Enabled = False
            txtstockhouse.Enabled = False
            ckWarranty.Enabled = False
            ckManualDepreciation.Enabled = False
            txtBookValue.ReadOnly = True
            txtMonthlyDepreciation.ReadOnly = True
            txtDepreciationLastUpdate.Enabled = False
            MyDataGridView.ReadOnly = True
            cmdSave.Text = "Close"
            ToolStrip1.Visible = False

            txtAccountableView.Visible = False
            txtAccountablePerson.Visible = True
        Else
            'If txtAccountableView.Text = "" Then
            '    txtAccountableView.Visible = False
            '    txtAccountablePerson.Visible = True
            '    txtIssueNote.ReadOnly = False
            '    txtDateIssue.Enabled = True
            'Else
            '    txtAccountableView.Visible = True
            '    txtAccountablePerson.Enabled = False
            '    txtAccountablePerson.Visible = False
            '    txtIssueNote.ReadOnly = True
            '    txtDateIssue.Enabled = False
            'End If
        End If

       
    End Sub
#End Region
 
    Private Sub cmdMemorandumOfReceipt_Click(sender As Object, e As EventArgs) Handles cmdMemorandumOfReceipt.Click
        If cmdMemorandumOfReceipt.Text = "Cancel Disposal Request" Then
            If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblinventoryffe set disposalrequested=0, disposalrequestcorporatelevel=0, flaged=0, lockedediting=0, flagedreason='' where ffecode='" & ffecode.Text & "'" : com.ExecuteNonQuery()
                LogFFEHistory(ffecode.Text, "request disposal cancelled")
                MessageBox.Show("Disposal request successfully cancelled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmInventoryFFE.ViewLocalInventoryFFE()
                Me.Close()
            End If
        Else
            PrintFFeMR(ffecode.Text, Me)
        End If
    End Sub

   
    Private Sub ckManualDepreciation_CheckedChanged(sender As Object, e As EventArgs) Handles ckManualDepreciation.CheckedChanged
        If ckManualDepreciation.Checked = True Then
            txtBookValue.Enabled = True
            txtMonthlyDepreciation.Enabled = True
            txtDepreciationLastUpdate.Enabled = True
        Else
            txtBookValue.Enabled = False
            txtMonthlyDepreciation.Enabled = False
            txtDepreciationLastUpdate.Enabled = False
        End If
    End Sub

    
    Private Sub txtAccountablePerson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAccountablePerson.SelectedIndexChanged

    End Sub
End Class
