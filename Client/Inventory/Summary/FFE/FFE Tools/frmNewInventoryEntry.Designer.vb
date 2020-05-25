<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewInventoryEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDatePurchased = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.ComboBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitType = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtstockhouse = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAccountablePerson = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDateIssue = New System.Windows.Forms.DateTimePicker()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.stockhouseid = New System.Windows.Forms.TextBox()
        Me.accountableid = New System.Windows.Forms.TextBox()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtFFEType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ckWarranty = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWarrantyDate = New System.Windows.Forms.DateTimePicker()
        Me.ffetypecode = New System.Windows.Forms.TextBox()
        Me.txtExistingFFEType = New System.Windows.Forms.TextBox()
        Me.txtIssueNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.ffecode = New System.Windows.Forms.TextBox()
        Me.cmdMemorandumOfReceipt = New System.Windows.Forms.Button()
        Me.issuecode = New System.Windows.Forms.TextBox()
        Me.txtBookValue = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMonthlyDepreciation = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDepreciationLastUpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ckManualDepreciation = New System.Windows.Forms.CheckBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtAccountableView = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.Location = New System.Drawing.Point(675, 672)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(219, 33)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save Inventory"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(95, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(97, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Quantity"
        '
        'txtDatePurchased
        '
        Me.txtDatePurchased.CustomFormat = "MMMM dd, yyyy"
        Me.txtDatePurchased.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDatePurchased.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDatePurchased.Location = New System.Drawing.Point(159, 192)
        Me.txtDatePurchased.Name = "txtDatePurchased"
        Me.txtDatePurchased.Size = New System.Drawing.Size(215, 23)
        Me.txtDatePurchased.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(61, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 380
        Me.Label7.Text = "Date Purchased"
        '
        'txtProductName
        '
        Me.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtProductName.DropDownHeight = 200
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProductName.FormattingEnabled = True
        Me.txtProductName.IntegralHeight = False
        Me.txtProductName.ItemHeight = 15
        Me.txtProductName.Location = New System.Drawing.Point(159, 60)
        Me.txtProductName.MaxDropDownItems = 20
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(272, 23)
        Me.txtProductName.TabIndex = 0
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.Location = New System.Drawing.Point(159, 86)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(272, 22)
        Me.txtCategory.TabIndex = 1000
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(159, 111)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(112, 24)
        Me.txtQuantity.TabIndex = 1
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnitType
        '
        Me.txtUnitType.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUnitType.ForeColor = System.Drawing.Color.Black
        Me.txtUnitType.Location = New System.Drawing.Point(274, 111)
        Me.txtUnitType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitType.Name = "txtUnitType"
        Me.txtUnitType.ReadOnly = True
        Me.txtUnitType.Size = New System.Drawing.Size(69, 24)
        Me.txtUnitType.TabIndex = 392
        Me.txtUnitType.Text = "UNIT"
        Me.txtUnitType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(159, 138)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(112, 24)
        Me.txtUnitCost.TabIndex = 2
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(94, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 15)
        Me.Label9.TabIndex = 393
        Me.Label9.Text = "Unit Cost"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(159, 165)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(112, 24)
        Me.txtTotal.TabIndex = 396
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(118, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 15)
        Me.Label10.TabIndex = 395
        Me.Label10.Text = "Total"
        '
        'txtstockhouse
        '
        Me.txtstockhouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtstockhouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtstockhouse.DropDownHeight = 200
        Me.txtstockhouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtstockhouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstockhouse.FormattingEnabled = True
        Me.txtstockhouse.IntegralHeight = False
        Me.txtstockhouse.ItemHeight = 15
        Me.txtstockhouse.Location = New System.Drawing.Point(159, 271)
        Me.txtstockhouse.MaxDropDownItems = 20
        Me.txtstockhouse.Name = "txtstockhouse"
        Me.txtstockhouse.Size = New System.Drawing.Size(272, 23)
        Me.txtstockhouse.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(24, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 15)
        Me.Label11.TabIndex = 397
        Me.Label11.Text = "Office Subsidiary/OBO"
        '
        'txtAccountablePerson
        '
        Me.txtAccountablePerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAccountablePerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtAccountablePerson.DropDownHeight = 200
        Me.txtAccountablePerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAccountablePerson.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAccountablePerson.FormattingEnabled = True
        Me.txtAccountablePerson.IntegralHeight = False
        Me.txtAccountablePerson.ItemHeight = 15
        Me.txtAccountablePerson.Location = New System.Drawing.Point(159, 520)
        Me.txtAccountablePerson.MaxDropDownItems = 20
        Me.txtAccountablePerson.Name = "txtAccountablePerson"
        Me.txtAccountablePerson.Size = New System.Drawing.Size(272, 23)
        Me.txtAccountablePerson.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(37, 524)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 15)
        Me.Label12.TabIndex = 399
        Me.Label12.Text = "Accountable Person"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(83, 611)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 402
        Me.Label13.Text = "Date Issued"
        '
        'txtDateIssue
        '
        Me.txtDateIssue.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateIssue.Location = New System.Drawing.Point(159, 607)
        Me.txtDateIssue.Name = "txtDateIssue"
        Me.txtDateIssue.Size = New System.Drawing.Size(215, 23)
        Me.txtDateIssue.TabIndex = 13
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MyDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.MyDataGridView.Location = New System.Drawing.Point(446, 54)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(448, 613)
        Me.MyDataGridView.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(74, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 19)
        Me.Label1.TabIndex = 404
        Me.Label1.Text = "General Asset Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(443, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(357, 15)
        Me.Label6.TabIndex = 405
        Me.Label6.Text = "Inventory Other Details (click on right input field then start typing)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 25)
        Me.ToolStrip1.TabIndex = 408
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripSplitButton1.Text = "Close Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.box__plus1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripButton1.Text = "Request Product Registration"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.CoffeecupClient.My.Resources.Resources.building__plus
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripButton2.Text = "Add Subsidiary Office"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.CoffeecupClient.My.Resources.Resources.user__plus
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripButton3.Text = "Add Accountable Person"
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(457, 79)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(69, 24)
        Me.productid.TabIndex = 409
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'stockhouseid
        '
        Me.stockhouseid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.stockhouseid.ForeColor = System.Drawing.Color.Black
        Me.stockhouseid.Location = New System.Drawing.Point(457, 234)
        Me.stockhouseid.Margin = New System.Windows.Forms.Padding(4)
        Me.stockhouseid.Name = "stockhouseid"
        Me.stockhouseid.Size = New System.Drawing.Size(69, 24)
        Me.stockhouseid.TabIndex = 410
        Me.stockhouseid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.stockhouseid.Visible = False
        '
        'accountableid
        '
        Me.accountableid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.accountableid.ForeColor = System.Drawing.Color.Black
        Me.accountableid.Location = New System.Drawing.Point(457, 260)
        Me.accountableid.Margin = New System.Windows.Forms.Padding(4)
        Me.accountableid.Name = "accountableid"
        Me.accountableid.Size = New System.Drawing.Size(69, 24)
        Me.accountableid.TabIndex = 411
        Me.accountableid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.accountableid.Visible = False
        '
        'catid
        '
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.catid.ForeColor = System.Drawing.Color.Black
        Me.catid.Location = New System.Drawing.Point(457, 106)
        Me.catid.Margin = New System.Windows.Forms.Padding(4)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(69, 24)
        Me.catid.TabIndex = 414
        Me.catid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.catid.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(457, 319)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(69, 24)
        Me.mode.TabIndex = 1001
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'txtFFEType
        '
        Me.txtFFEType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFFEType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtFFEType.DropDownHeight = 200
        Me.txtFFEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFFEType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFFEType.FormattingEnabled = True
        Me.txtFFEType.IntegralHeight = False
        Me.txtFFEType.ItemHeight = 15
        Me.txtFFEType.Location = New System.Drawing.Point(159, 245)
        Me.txtFFEType.MaxDropDownItems = 20
        Me.txtFFEType.Name = "txtFFEType"
        Me.txtFFEType.Size = New System.Drawing.Size(272, 23)
        Me.txtFFEType.TabIndex = 1003
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(88, 247)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 1004
        Me.Label14.Text = "Asset Type"
        '
        'ckWarranty
        '
        Me.ckWarranty.AutoSize = True
        Me.ckWarranty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckWarranty.ForeColor = System.Drawing.Color.Black
        Me.ckWarranty.Location = New System.Drawing.Point(159, 300)
        Me.ckWarranty.Name = "ckWarranty"
        Me.ckWarranty.Size = New System.Drawing.Size(101, 19)
        Me.ckWarranty.TabIndex = 6
        Me.ckWarranty.Text = "Item Warranty"
        Me.ckWarranty.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(68, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1006
        Me.Label2.Text = "Warranty Date"
        '
        'txtWarrantyDate
        '
        Me.txtWarrantyDate.CustomFormat = "MMMM dd, yyyy"
        Me.txtWarrantyDate.Enabled = False
        Me.txtWarrantyDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtWarrantyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtWarrantyDate.Location = New System.Drawing.Point(159, 320)
        Me.txtWarrantyDate.Name = "txtWarrantyDate"
        Me.txtWarrantyDate.Size = New System.Drawing.Size(215, 23)
        Me.txtWarrantyDate.TabIndex = 7
        '
        'ffetypecode
        '
        Me.ffetypecode.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.ffetypecode.ForeColor = System.Drawing.Color.Black
        Me.ffetypecode.Location = New System.Drawing.Point(457, 287)
        Me.ffetypecode.Margin = New System.Windows.Forms.Padding(4)
        Me.ffetypecode.Name = "ffetypecode"
        Me.ffetypecode.Size = New System.Drawing.Size(69, 24)
        Me.ffetypecode.TabIndex = 1007
        Me.ffetypecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ffetypecode.Visible = False
        '
        'txtExistingFFEType
        '
        Me.txtExistingFFEType.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtExistingFFEType.ForeColor = System.Drawing.Color.Black
        Me.txtExistingFFEType.Location = New System.Drawing.Point(159, 244)
        Me.txtExistingFFEType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExistingFFEType.Name = "txtExistingFFEType"
        Me.txtExistingFFEType.ReadOnly = True
        Me.txtExistingFFEType.Size = New System.Drawing.Size(270, 24)
        Me.txtExistingFFEType.TabIndex = 1008
        Me.txtExistingFFEType.Visible = False
        '
        'txtIssueNote
        '
        Me.txtIssueNote.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtIssueNote.ForeColor = System.Drawing.Color.Black
        Me.txtIssueNote.Location = New System.Drawing.Point(159, 546)
        Me.txtIssueNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssueNote.Multiline = True
        Me.txtIssueNote.Name = "txtIssueNote"
        Me.txtIssueNote.Size = New System.Drawing.Size(272, 58)
        Me.txtIssueNote.TabIndex = 12
        Me.txtIssueNote.Text = "The items stated above are in good condition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(88, 549)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 1010
        Me.Label8.Text = "Issue Note"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(74, 496)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 19)
        Me.Label15.TabIndex = 1011
        Me.Label15.Text = "Accountable Person"
        '
        'txtVendor
        '
        Me.txtVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtVendor.DropDownHeight = 200
        Me.txtVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtVendor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtVendor.FormattingEnabled = True
        Me.txtVendor.IntegralHeight = False
        Me.txtVendor.ItemHeight = 15
        Me.txtVendor.Location = New System.Drawing.Point(159, 218)
        Me.txtVendor.MaxDropDownItems = 20
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(272, 23)
        Me.txtVendor.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(101, 221)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 15)
        Me.Label16.TabIndex = 1013
        Me.Label16.Text = "Supplier"
        '
        'vendorid
        '
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(457, 206)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.Size = New System.Drawing.Size(69, 24)
        Me.vendorid.TabIndex = 1014
        Me.vendorid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.vendorid.Visible = False
        '
        'ffecode
        '
        Me.ffecode.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.ffecode.ForeColor = System.Drawing.Color.Black
        Me.ffecode.Location = New System.Drawing.Point(733, 206)
        Me.ffecode.Margin = New System.Windows.Forms.Padding(4)
        Me.ffecode.Name = "ffecode"
        Me.ffecode.Size = New System.Drawing.Size(69, 24)
        Me.ffecode.TabIndex = 1015
        Me.ffecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ffecode.Visible = False
        '
        'cmdMemorandumOfReceipt
        '
        Me.cmdMemorandumOfReceipt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdMemorandumOfReceipt.Location = New System.Drawing.Point(159, 633)
        Me.cmdMemorandumOfReceipt.Name = "cmdMemorandumOfReceipt"
        Me.cmdMemorandumOfReceipt.Size = New System.Drawing.Size(215, 33)
        Me.cmdMemorandumOfReceipt.TabIndex = 1016
        Me.cmdMemorandumOfReceipt.Text = "Print Asset Profile"
        Me.cmdMemorandumOfReceipt.UseVisualStyleBackColor = False
        '
        'issuecode
        '
        Me.issuecode.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.issuecode.ForeColor = System.Drawing.Color.Black
        Me.issuecode.Location = New System.Drawing.Point(457, 409)
        Me.issuecode.Margin = New System.Windows.Forms.Padding(4)
        Me.issuecode.Name = "issuecode"
        Me.issuecode.Size = New System.Drawing.Size(69, 24)
        Me.issuecode.TabIndex = 1018
        Me.issuecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.issuecode.Visible = False
        '
        'txtBookValue
        '
        Me.txtBookValue.Enabled = False
        Me.txtBookValue.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtBookValue.ForeColor = System.Drawing.Color.Black
        Me.txtBookValue.Location = New System.Drawing.Point(159, 406)
        Me.txtBookValue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookValue.Name = "txtBookValue"
        Me.txtBookValue.Size = New System.Drawing.Size(112, 24)
        Me.txtBookValue.TabIndex = 8
        Me.txtBookValue.Text = "0.00"
        Me.txtBookValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label17.Location = New System.Drawing.Point(29, 410)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 15)
        Me.Label17.TabIndex = 1020
        Me.Label17.Text = "Current Booked Value"
        '
        'txtMonthlyDepreciation
        '
        Me.txtMonthlyDepreciation.Enabled = False
        Me.txtMonthlyDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMonthlyDepreciation.ForeColor = System.Drawing.Color.Black
        Me.txtMonthlyDepreciation.Location = New System.Drawing.Point(159, 433)
        Me.txtMonthlyDepreciation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonthlyDepreciation.Name = "txtMonthlyDepreciation"
        Me.txtMonthlyDepreciation.Size = New System.Drawing.Size(112, 24)
        Me.txtMonthlyDepreciation.TabIndex = 9
        Me.txtMonthlyDepreciation.Text = "0.00"
        Me.txtMonthlyDepreciation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(28, 436)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 15)
        Me.Label18.TabIndex = 1022
        Me.Label18.Text = "Monthly Depreciation"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(81, 464)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 15)
        Me.Label19.TabIndex = 1024
        Me.Label19.Text = "Last Update"
        '
        'txtDepreciationLastUpdate
        '
        Me.txtDepreciationLastUpdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtDepreciationLastUpdate.Enabled = False
        Me.txtDepreciationLastUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDepreciationLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDepreciationLastUpdate.Location = New System.Drawing.Point(159, 460)
        Me.txtDepreciationLastUpdate.Name = "txtDepreciationLastUpdate"
        Me.txtDepreciationLastUpdate.Size = New System.Drawing.Size(215, 23)
        Me.txtDepreciationLastUpdate.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(74, 361)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 19)
        Me.Label20.TabIndex = 1025
        Me.Label20.Text = "Asset Depreciation"
        '
        'ckManualDepreciation
        '
        Me.ckManualDepreciation.AutoSize = True
        Me.ckManualDepreciation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckManualDepreciation.ForeColor = System.Drawing.Color.Black
        Me.ckManualDepreciation.Location = New System.Drawing.Point(159, 386)
        Me.ckManualDepreciation.Name = "ckManualDepreciation"
        Me.ckManualDepreciation.Size = New System.Drawing.Size(136, 19)
        Me.ckManualDepreciation.TabIndex = 1026
        Me.ckManualDepreciation.Text = "Manual Depreciation"
        Me.ckManualDepreciation.UseVisualStyleBackColor = True
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(457, 138)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(69, 24)
        Me.officeid.TabIndex = 1027
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'txtAccountableView
        '
        Me.txtAccountableView.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccountableView.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAccountableView.ForeColor = System.Drawing.Color.Black
        Me.txtAccountableView.Location = New System.Drawing.Point(159, 521)
        Me.txtAccountableView.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccountableView.Name = "txtAccountableView"
        Me.txtAccountableView.ReadOnly = True
        Me.txtAccountableView.Size = New System.Drawing.Size(272, 22)
        Me.txtAccountableView.TabIndex = 1028
        '
        'frmNewInventoryEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 721)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtDepreciationLastUpdate)
        Me.Controls.Add(Me.txtMonthlyDepreciation)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBookValue)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.issuecode)
        Me.Controls.Add(Me.cmdMemorandumOfReceipt)
        Me.Controls.Add(Me.ffecode)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.txtVendor)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIssueNote)
        Me.Controls.Add(Me.ffetypecode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWarrantyDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.accountableid)
        Me.Controls.Add(Me.stockhouseid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDateIssue)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtstockhouse)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUnitType)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDatePurchased)
        Me.Controls.Add(Me.ckWarranty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtFFEType)
        Me.Controls.Add(Me.ckManualDepreciation)
        Me.Controls.Add(Me.txtExistingFFEType)
        Me.Controls.Add(Me.txtAccountablePerson)
        Me.Controls.Add(Me.txtAccountableView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(934, 760)
        Me.Name = "frmNewInventoryEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Information"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDatePurchased As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.ComboBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitType As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtstockhouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAccountablePerson As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents stockhouseid As System.Windows.Forms.TextBox
    Friend WithEvents accountableid As System.Windows.Forms.TextBox
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFFEType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ckWarranty As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWarrantyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ffetypecode As System.Windows.Forms.TextBox
    Friend WithEvents txtExistingFFEType As System.Windows.Forms.TextBox
    Friend WithEvents txtIssueNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVendor As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents ffecode As System.Windows.Forms.TextBox
    Friend WithEvents cmdMemorandumOfReceipt As System.Windows.Forms.Button
    Friend WithEvents issuecode As System.Windows.Forms.TextBox
    Friend WithEvents txtBookValue As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMonthlyDepreciation As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDepreciationLastUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ckManualDepreciation As System.Windows.Forms.CheckBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountableView As System.Windows.Forms.TextBox

End Class
