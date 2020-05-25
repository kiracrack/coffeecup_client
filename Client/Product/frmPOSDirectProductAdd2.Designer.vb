<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSDirectProductAdd2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSDirectProductAdd2))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabRequest = New System.Windows.Forms.TabPage()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckService = New System.Windows.Forms.CheckBox()
        Me.bid = New System.Windows.Forms.TextBox()
        Me.txtBeginningQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblbeginningInventory = New System.Windows.Forms.Label()
        Me.ckBeginningInventory = New System.Windows.Forms.CheckBox()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSellingCost = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabRequest.SuspendLayout()
        CType(Me.txtPurchasePrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeginningQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClose.Location = New System.Drawing.Point(260, 353)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(99, 30)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSave.Location = New System.Drawing.Point(102, 353)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(152, 30)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Save Product"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(408, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to register your product directly to the main server"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(452, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(59, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(180, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Direct Product Registration"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabRequest)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(9, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(458, 292)
        Me.TabControl1.TabIndex = 0
        '
        'tabRequest
        '
        Me.tabRequest.Controls.Add(Me.txtBarcode)
        Me.tabRequest.Controls.Add(Me.Label5)
        Me.tabRequest.Controls.Add(Me.mode)
        Me.tabRequest.Controls.Add(Me.txtPurchasePrice)
        Me.tabRequest.Controls.Add(Me.Label1)
        Me.tabRequest.Controls.Add(Me.ckService)
        Me.tabRequest.Controls.Add(Me.bid)
        Me.tabRequest.Controls.Add(Me.txtBeginningQuantity)
        Me.tabRequest.Controls.Add(Me.lblbeginningInventory)
        Me.tabRequest.Controls.Add(Me.ckBeginningInventory)
        Me.tabRequest.Controls.Add(Me.txtCategory)
        Me.tabRequest.Controls.Add(Me.Label8)
        Me.tabRequest.Controls.Add(Me.productid)
        Me.tabRequest.Controls.Add(Me.Label7)
        Me.tabRequest.Controls.Add(Me.txtSellingCost)
        Me.tabRequest.Controls.Add(Me.Label3)
        Me.tabRequest.Controls.Add(Me.Lbl_Status)
        Me.tabRequest.Controls.Add(Me.CheckBox2)
        Me.tabRequest.Controls.Add(Me.txtUnit)
        Me.tabRequest.Controls.Add(Me.Label2)
        Me.tabRequest.Controls.Add(Me.txtProductName)
        Me.tabRequest.Controls.Add(Me.Label13)
        Me.tabRequest.Location = New System.Drawing.Point(4, 22)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(450, 266)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "Product Information"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.Location = New System.Drawing.Point(146, 37)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(209, 22)
        Me.txtBarcode.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(91, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 412
        Me.Label5.Text = "Barcode"
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(381, 211)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(50, 22)
        Me.mode.TabIndex = 410
        Me.mode.Visible = False
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.DecimalPlaces = 2
        Me.txtPurchasePrice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPurchasePrice.Location = New System.Drawing.Point(146, 159)
        Me.txtPurchasePrice.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(148, 22)
        Me.txtPurchasePrice.TabIndex = 4
        Me.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPurchasePrice.ThousandsSeparator = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(57, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "Purchase Price"
        '
        'ckService
        '
        Me.ckService.AutoSize = True
        Me.ckService.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckService.ForeColor = System.Drawing.Color.Black
        Me.ckService.Location = New System.Drawing.Point(381, 240)
        Me.ckService.Name = "ckService"
        Me.ckService.Size = New System.Drawing.Size(63, 19)
        Me.ckService.TabIndex = 405
        Me.ckService.Text = "Service"
        Me.ckService.UseVisualStyleBackColor = True
        Me.ckService.Visible = False
        '
        'bid
        '
        Me.bid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.bid.ForeColor = System.Drawing.Color.Black
        Me.bid.Location = New System.Drawing.Point(383, 338)
        Me.bid.Margin = New System.Windows.Forms.Padding(4)
        Me.bid.Name = "bid"
        Me.bid.Size = New System.Drawing.Size(50, 22)
        Me.bid.TabIndex = 404
        Me.bid.Visible = False
        '
        'txtBeginningQuantity
        '
        Me.txtBeginningQuantity.DecimalPlaces = 2
        Me.txtBeginningQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBeginningQuantity.Location = New System.Drawing.Point(146, 232)
        Me.txtBeginningQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtBeginningQuantity.Name = "txtBeginningQuantity"
        Me.txtBeginningQuantity.Size = New System.Drawing.Size(148, 22)
        Me.txtBeginningQuantity.TabIndex = 6
        Me.txtBeginningQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBeginningQuantity.ThousandsSeparator = True
        Me.txtBeginningQuantity.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'lblbeginningInventory
        '
        Me.lblbeginningInventory.AutoSize = True
        Me.lblbeginningInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblbeginningInventory.ForeColor = System.Drawing.Color.Black
        Me.lblbeginningInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblbeginningInventory.Location = New System.Drawing.Point(31, 235)
        Me.lblbeginningInventory.Name = "lblbeginningInventory"
        Me.lblbeginningInventory.Size = New System.Drawing.Size(110, 15)
        Me.lblbeginningInventory.TabIndex = 403
        Me.lblbeginningInventory.Text = "Beginning Quantity"
        '
        'ckBeginningInventory
        '
        Me.ckBeginningInventory.AutoSize = True
        Me.ckBeginningInventory.Checked = True
        Me.ckBeginningInventory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckBeginningInventory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckBeginningInventory.ForeColor = System.Drawing.Color.Black
        Me.ckBeginningInventory.Location = New System.Drawing.Point(146, 211)
        Me.ckBeginningInventory.Name = "ckBeginningInventory"
        Me.ckBeginningInventory.Size = New System.Drawing.Size(133, 19)
        Me.ckBeginningInventory.TabIndex = 401
        Me.ckBeginningInventory.Text = "Beginning Inventory"
        Me.ckBeginningInventory.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.DropDownHeight = 130
        Me.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.IntegralHeight = False
        Me.txtCategory.ItemHeight = 13
        Me.txtCategory.Location = New System.Drawing.Point(146, 87)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategory.MaxDropDownItems = 7
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(209, 21)
        Me.txtCategory.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(86, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 15)
        Me.Label8.TabIndex = 400
        Me.Label8.Text = "Category"
        '
        'productid
        '
        Me.productid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(146, 12)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(128, 22)
        Me.productid.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(61, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 398
        Me.Label7.Text = "Product Code"
        '
        'txtSellingCost
        '
        Me.txtSellingCost.DecimalPlaces = 2
        Me.txtSellingCost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSellingCost.Location = New System.Drawing.Point(146, 184)
        Me.txtSellingCost.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtSellingCost.Name = "txtSellingCost"
        Me.txtSellingCost.Size = New System.Drawing.Size(148, 22)
        Me.txtSellingCost.TabIndex = 5
        Me.txtSellingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSellingCost.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(72, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 393
        Me.Label3.Text = "Selling Cost"
        '
        'Lbl_Status
        '
        Me.Lbl_Status.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lbl_Status.Location = New System.Drawing.Point(28, 405)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(405, 13)
        Me.Lbl_Status.TabIndex = 387
        Me.Lbl_Status.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(146, 114)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(113, 19)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Use Existing Unit"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        Me.txtUnit.DropDownHeight = 130
        Me.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnit.ForeColor = System.Drawing.Color.Black
        Me.txtUnit.FormattingEnabled = True
        Me.txtUnit.IntegralHeight = False
        Me.txtUnit.ItemHeight = 13
        Me.txtUnit.Location = New System.Drawing.Point(146, 135)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnit.MaxDropDownItems = 7
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(209, 21)
        Me.txtUnit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(112, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Unit"
        '
        'txtProductName
        '
        Me.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(146, 62)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(209, 22)
        Me.txtProductName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(57, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Product Name"
        '
        'catid
        '
        Me.catid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.catid.ForeColor = System.Drawing.Color.Black
        Me.catid.Location = New System.Drawing.Point(396, 466)
        Me.catid.Margin = New System.Windows.Forms.Padding(4)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(50, 22)
        Me.catid.TabIndex = 401
        Me.catid.Visible = False
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Paper_pencil
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(16, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(44, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmPOSDirectProductAdd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(473, 389)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSDirectProductAdd2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Information"
        Me.TabControl1.ResumeLayout(False)
        Me.tabRequest.ResumeLayout(False)
        Me.tabRequest.PerformLayout()
        CType(Me.txtPurchasePrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeginningQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRequest As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents txtSellingCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents ckBeginningInventory As System.Windows.Forms.CheckBox
    Friend WithEvents txtBeginningQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblbeginningInventory As System.Windows.Forms.Label
    Friend WithEvents bid As System.Windows.Forms.TextBox
    Friend WithEvents ckService As System.Windows.Forms.CheckBox
    Friend WithEvents txtPurchasePrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
