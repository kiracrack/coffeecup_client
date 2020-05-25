<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRRReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRRReport))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtvendor = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.refnumber = New System.Windows.Forms.TextBox()
        Me.ponumber = New System.Windows.Forms.TextBox()
        Me.txtRRNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckAddtoExisting = New System.Windows.Forms.CheckBox()
        Me.txtExistingRR = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNew = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRRDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOffice = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.txtTotalSelectedAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.issueto = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtIssueTo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldRRnumber = New System.Windows.Forms.TextBox()
        Me.txtOldRRAmount = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.txtVatableSales = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalVat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckVatable = New System.Windows.Forms.CheckBox()
        Me.radPayOption = New DevExpress.XtraEditors.RadioGroup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpNew.SuspendLayout()
        Me.cms_em.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radPayOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(144, 431)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(170, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'txtvendor
        '
        Me.txtvendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtvendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtvendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtvendor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtvendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendor.ForeColor = System.Drawing.Color.Black
        Me.txtvendor.FormattingEnabled = True
        Me.txtvendor.ItemHeight = 15
        Me.txtvendor.Location = New System.Drawing.Point(97, 59)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(254, 23)
        Me.txtvendor.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 59)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 20)
        Me.LinkLabel1.TabIndex = 381
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Supplier Mgt."
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'refnumber
        '
        Me.refnumber.Enabled = False
        Me.refnumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.refnumber.ForeColor = System.Drawing.Color.Black
        Me.refnumber.Location = New System.Drawing.Point(30, 529)
        Me.refnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.refnumber.Name = "refnumber"
        Me.refnumber.ReadOnly = True
        Me.refnumber.Size = New System.Drawing.Size(50, 23)
        Me.refnumber.TabIndex = 382
        Me.refnumber.Visible = False
        '
        'ponumber
        '
        Me.ponumber.Enabled = False
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ponumber.ForeColor = System.Drawing.Color.Black
        Me.ponumber.Location = New System.Drawing.Point(82, 511)
        Me.ponumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(50, 23)
        Me.ponumber.TabIndex = 383
        Me.ponumber.Visible = False
        '
        'txtRRNumber
        '
        Me.txtRRNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRRNumber.ForeColor = System.Drawing.Color.Black
        Me.txtRRNumber.Location = New System.Drawing.Point(97, 8)
        Me.txtRRNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRRNumber.Name = "txtRRNumber"
        Me.txtRRNumber.ReadOnly = True
        Me.txtRRNumber.Size = New System.Drawing.Size(121, 22)
        Me.txtRRNumber.TabIndex = 385
        Me.txtRRNumber.Text = "AUTO GENERATED"
        Me.txtRRNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(22, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 15)
        Me.Label13.TabIndex = 384
        Me.Label13.Text = "RR Number"
        '
        'ckAddtoExisting
        '
        Me.ckAddtoExisting.AutoSize = True
        Me.ckAddtoExisting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAddtoExisting.ForeColor = System.Drawing.Color.Black
        Me.ckAddtoExisting.Location = New System.Drawing.Point(144, 12)
        Me.ckAddtoExisting.Name = "ckAddtoExisting"
        Me.ckAddtoExisting.Size = New System.Drawing.Size(193, 19)
        Me.ckAddtoExisting.TabIndex = 386
        Me.ckAddtoExisting.Text = "Add to Existing Received Report"
        Me.ckAddtoExisting.UseVisualStyleBackColor = True
        '
        'txtExistingRR
        '
        Me.txtExistingRR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtExistingRR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtExistingRR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtExistingRR.Enabled = False
        Me.txtExistingRR.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtExistingRR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistingRR.ForeColor = System.Drawing.Color.Black
        Me.txtExistingRR.FormattingEnabled = True
        Me.txtExistingRR.ItemHeight = 15
        Me.txtExistingRR.Location = New System.Drawing.Point(144, 33)
        Me.txtExistingRR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExistingRR.Name = "txtExistingRR"
        Me.txtExistingRR.Size = New System.Drawing.Size(267, 23)
        Me.txtExistingRR.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 389
        Me.Label1.Text = "Select Existing RR"
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.Label6)
        Me.grpNew.Controls.Add(Me.txtRRDate)
        Me.grpNew.Controls.Add(Me.txtInvoiceNumber)
        Me.grpNew.Controls.Add(Me.Label4)
        Me.grpNew.Controls.Add(Me.txtRRNumber)
        Me.grpNew.Controls.Add(Me.txtvendor)
        Me.grpNew.Controls.Add(Me.LinkLabel1)
        Me.grpNew.Controls.Add(Me.Label13)
        Me.grpNew.Controls.Add(Me.txtOffice)
        Me.grpNew.Controls.Add(Me.Label3)
        Me.grpNew.Location = New System.Drawing.Point(47, 60)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(364, 146)
        Me.grpNew.TabIndex = 392
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(42, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 811
        Me.Label6.Text = "RR Date"
        '
        'txtRRDate
        '
        Me.txtRRDate.CustomFormat = "MMMM dd, yyyy"
        Me.txtRRDate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRRDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRRDate.Location = New System.Drawing.Point(97, 112)
        Me.txtRRDate.Name = "txtRRDate"
        Me.txtRRDate.Size = New System.Drawing.Size(172, 22)
        Me.txtRRDate.TabIndex = 810
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(97, 33)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(121, 22)
        Me.txtInvoiceNumber.TabIndex = 387
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(26, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 386
        Me.Label4.Text = "Invoice No"
        '
        'txtOffice
        '
        Me.txtOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtOffice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtOffice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.ForeColor = System.Drawing.Color.Black
        Me.txtOffice.FormattingEnabled = True
        Me.txtOffice.ItemHeight = 15
        Me.txtOffice.Location = New System.Drawing.Point(97, 85)
        Me.txtOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(254, 23)
        Me.txtOffice.TabIndex = 388
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(17, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 389
        Me.Label3.Text = "Select Office"
        '
        'vendorid
        '
        Me.vendorid.Enabled = False
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(131, 511)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(50, 23)
        Me.vendorid.TabIndex = 394
        Me.vendorid.Visible = False
        '
        'txtTotalSelectedAmount
        '
        Me.txtTotalSelectedAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalSelectedAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalSelectedAmount.Location = New System.Drawing.Point(144, 213)
        Me.txtTotalSelectedAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalSelectedAmount.Name = "txtTotalSelectedAmount"
        Me.txtTotalSelectedAmount.ReadOnly = True
        Me.txtTotalSelectedAmount.Size = New System.Drawing.Size(121, 22)
        Me.txtTotalSelectedAmount.TabIndex = 396
        Me.txtTotalSelectedAmount.Text = "0.00"
        Me.txtTotalSelectedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(10, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 395
        Me.Label5.Text = "Total Selected Amount"
        '
        'issueto
        '
        Me.issueto.Enabled = False
        Me.issueto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.issueto.ForeColor = System.Drawing.Color.Black
        Me.issueto.Location = New System.Drawing.Point(183, 511)
        Me.issueto.Margin = New System.Windows.Forms.Padding(4)
        Me.issueto.Name = "issueto"
        Me.issueto.ReadOnly = True
        Me.issueto.Size = New System.Drawing.Size(50, 23)
        Me.issueto.TabIndex = 397
        Me.issueto.Visible = False
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNote.ForeColor = System.Drawing.Color.Black
        Me.txtNote.Location = New System.Drawing.Point(144, 375)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(254, 52)
        Me.txtNote.TabIndex = 400
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(103, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 401
        Me.Label7.Text = "Note"
        '
        'officeid
        '
        Me.officeid.Enabled = False
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(236, 511)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(50, 23)
        Me.officeid.TabIndex = 402
        Me.officeid.Visible = False
        '
        'txtIssueTo
        '
        Me.txtIssueTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtIssueTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtIssueTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtIssueTo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtIssueTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssueTo.ForeColor = System.Drawing.Color.Black
        Me.txtIssueTo.FormattingEnabled = True
        Me.txtIssueTo.ItemHeight = 15
        Me.txtIssueTo.Location = New System.Drawing.Point(144, 348)
        Me.txtIssueTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssueTo.Name = "txtIssueTo"
        Me.txtIssueTo.Size = New System.Drawing.Size(254, 23)
        Me.txtIssueTo.TabIndex = 403
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(86, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 404
        Me.Label2.Text = "Issue To"
        '
        'txtOldRRnumber
        '
        Me.txtOldRRnumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOldRRnumber.ForeColor = System.Drawing.Color.Black
        Me.txtOldRRnumber.Location = New System.Drawing.Point(419, 506)
        Me.txtOldRRnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldRRnumber.Name = "txtOldRRnumber"
        Me.txtOldRRnumber.ReadOnly = True
        Me.txtOldRRnumber.Size = New System.Drawing.Size(57, 22)
        Me.txtOldRRnumber.TabIndex = 405
        Me.txtOldRRnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOldRRnumber.Visible = False
        '
        'txtOldRRAmount
        '
        Me.txtOldRRAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOldRRAmount.ForeColor = System.Drawing.Color.Black
        Me.txtOldRRAmount.Location = New System.Drawing.Point(419, 481)
        Me.txtOldRRAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldRRAmount.Name = "txtOldRRAmount"
        Me.txtOldRRAmount.ReadOnly = True
        Me.txtOldRRAmount.Size = New System.Drawing.Size(57, 22)
        Me.txtOldRRAmount.TabIndex = 406
        Me.txtOldRRAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOldRRAmount.Visible = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ChangeSupplierToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(254, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(253, 22)
        Me.ToolStripMenuItem1.Text = "Remove Selected Item"
        '
        'ChangeSupplierToolStripMenuItem
        '
        Me.ChangeSupplierToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.truck__arrow
        Me.ChangeSupplierToolStripMenuItem.Name = "ChangeSupplierToolStripMenuItem"
        Me.ChangeSupplierToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ChangeSupplierToolStripMenuItem.Text = "Change Supplier for Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(250, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Location = New System.Drawing.Point(417, 8)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(722, 484)
        Me.Em.TabIndex = 867
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Gridview1.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        Me.Gridview1.OptionsView.ShowGroupPanel = False
        Me.Gridview1.PaintStyleName = "Web"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(418, 466)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(720, 25)
        Me.ProgressBarControl1.TabIndex = 868
        Me.ProgressBarControl1.Visible = False
        '
        'txtVatableSales
        '
        Me.txtVatableSales.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVatableSales.ForeColor = System.Drawing.Color.Black
        Me.txtVatableSales.Location = New System.Drawing.Point(144, 238)
        Me.txtVatableSales.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVatableSales.Name = "txtVatableSales"
        Me.txtVatableSales.ReadOnly = True
        Me.txtVatableSales.Size = New System.Drawing.Size(121, 22)
        Me.txtVatableSales.TabIndex = 870
        Me.txtVatableSales.Text = "0.00"
        Me.txtVatableSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(63, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 869
        Me.Label8.Text = "Vatable Sales"
        '
        'txtTotalVat
        '
        Me.txtTotalVat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalVat.ForeColor = System.Drawing.Color.Black
        Me.txtTotalVat.Location = New System.Drawing.Point(144, 263)
        Me.txtTotalVat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalVat.Name = "txtTotalVat"
        Me.txtTotalVat.ReadOnly = True
        Me.txtTotalVat.Size = New System.Drawing.Size(121, 22)
        Me.txtTotalVat.TabIndex = 872
        Me.txtTotalVat.Text = "0.00"
        Me.txtTotalVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(110, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 871
        Me.Label9.Text = "VAT"
        '
        'ckVatable
        '
        Me.ckVatable.AutoSize = True
        Me.ckVatable.Checked = True
        Me.ckVatable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckVatable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckVatable.Location = New System.Drawing.Point(270, 215)
        Me.ckVatable.Name = "ckVatable"
        Me.ckVatable.Size = New System.Drawing.Size(93, 19)
        Me.ckVatable.TabIndex = 873
        Me.ckVatable.Text = "Vatable Sales"
        Me.ckVatable.UseVisualStyleBackColor = True
        '
        'radPayOption
        '
        Me.radPayOption.Location = New System.Drawing.Point(144, 290)
        Me.radPayOption.Name = "radPayOption"
        Me.radPayOption.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radPayOption.Properties.Appearance.Options.UseFont = True
        Me.radPayOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Cash Transaction"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Credit Transaction")})
        Me.radPayOption.Size = New System.Drawing.Size(254, 54)
        Me.radPayOption.TabIndex = 874
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(96, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 15)
        Me.Label10.TabIndex = 875
        Me.Label10.Text = "Pay As"
        '
        'frmRRReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1151, 503)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.radPayOption)
        Me.Controls.Add(Me.ckVatable)
        Me.Controls.Add(Me.txtTotalVat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVatableSales)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.txtOldRRAmount)
        Me.Controls.Add(Me.txtOldRRnumber)
        Me.Controls.Add(Me.txtIssueTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.issueto)
        Me.Controls.Add(Me.txtTotalSelectedAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExistingRR)
        Me.Controls.Add(Me.ckAddtoExisting)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.refnumber)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1122, 482)
        Me.Name = "frmRRReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving Report"
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.cms_em.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radPayOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtvendor As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents refnumber As System.Windows.Forms.TextBox
    Friend WithEvents ponumber As System.Windows.Forms.TextBox
    Friend WithEvents txtRRNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ckAddtoExisting As System.Windows.Forms.CheckBox
    Friend WithEvents txtExistingRR As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpNew As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.ComboBox
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSelectedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents issueto As System.Windows.Forms.TextBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtIssueTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOldRRnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtOldRRAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRRDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txtVatableSales As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalVat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckVatable As System.Windows.Forms.CheckBox
    Friend WithEvents radPayOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
