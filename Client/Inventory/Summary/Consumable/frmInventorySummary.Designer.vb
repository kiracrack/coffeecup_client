<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventorySummary
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventorySummary))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MustaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdInventoryLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewInventoryDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckStockSequence = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblOffice = New System.Windows.Forms.ToolStripLabel()
        Me.txtOffice = New System.Windows.Forms.ToolStripComboBox()
        Me.lineOffice = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdManualInventory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLockInventory = New System.Windows.Forms.ToolStripButton()
        Me.lineLockInventory = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnChooser = New System.Windows.Forms.ToolStripButton()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabConsumable = New System.Windows.Forms.TabPage()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.tabConsumables_prepaid = New System.Windows.Forms.TabPage()
        Me.tabCutof = New System.Windows.Forms.TabPage()
        Me.txtCategory = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckZeroQuantity = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabConsumable.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'HiToolStripMenuItem
        '
        Me.HiToolStripMenuItem.Name = "HiToolStripMenuItem"
        Me.HiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HiToolStripMenuItem.Text = "Delete"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'HelloToolStripMenuItem
        '
        Me.HelloToolStripMenuItem.Name = "HelloToolStripMenuItem"
        Me.HelloToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HelloToolStripMenuItem.Text = "View Remarks"
        '
        'MustaToolStripMenuItem
        '
        Me.MustaToolStripMenuItem.Name = "MustaToolStripMenuItem"
        Me.MustaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MustaToolStripMenuItem.Text = "Edit "
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.Size = New System.Drawing.Size(1143, 571)
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(105, 22)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(325, 23)
        Me.txtsearch.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 277
        Me.Label3.Text = "Enter Keywords"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdInventoryLedger, Me.cmdViewInventoryDetails, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(191, 76)
        '
        'cmdInventoryLedger
        '
        Me.cmdInventoryLedger.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list1
        Me.cmdInventoryLedger.Name = "cmdInventoryLedger"
        Me.cmdInventoryLedger.Size = New System.Drawing.Size(190, 22)
        Me.cmdInventoryLedger.Text = "Inventory Ledger"
        '
        'cmdViewInventoryDetails
        '
        Me.cmdViewInventoryDetails.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list1
        Me.cmdViewInventoryDetails.Name = "cmdViewInventoryDetails"
        Me.cmdViewInventoryDetails.Size = New System.Drawing.Size(190, 22)
        Me.cmdViewInventoryDetails.Text = "View Inventory Details"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(187, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(190, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(96, 430)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(100, 23)
        Me.mode.TabIndex = 291
        Me.mode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.ckZeroQuantity)
        Me.GroupBox1.Controls.Add(Me.ckStockSequence)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System Functions"
        '
        'ckStockSequence
        '
        Me.ckStockSequence.AutoSize = True
        Me.ckStockSequence.ForeColor = System.Drawing.Color.Black
        Me.ckStockSequence.Location = New System.Drawing.Point(105, 77)
        Me.ckStockSequence.Name = "ckStockSequence"
        Me.ckStockSequence.Size = New System.Drawing.Size(188, 19)
        Me.ckStockSequence.TabIndex = 279
        Me.ckStockSequence.Text = "Stock sequence inventory view"
        Me.ckStockSequence.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1101, 30)
        Me.Panel2.TabIndex = 311
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator5, Me.lblOffice, Me.txtOffice, Me.lineOffice, Me.cmdManualInventory, Me.ToolStripSeparator7, Me.cmdLockInventory, Me.lineLockInventory, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdExportToExcel, Me.ToolStripSeparator2, Me.cmdColumnChooser})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1101, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdClose
        '
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.CoffeecupClient.My.Resources.Resources.slash
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 24)
        Me.cmdClose.Text = "Close Window"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'lblOffice
        '
        Me.lblOffice.ForeColor = System.Drawing.Color.White
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(73, 24)
        Me.lblOffice.Text = "Select Office"
        '
        'txtOffice
        '
        Me.txtOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtOffice.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(230, 27)
        '
        'lineOffice
        '
        Me.lineOffice.Name = "lineOffice"
        Me.lineOffice.Size = New System.Drawing.Size(6, 27)
        '
        'cmdManualInventory
        '
        Me.cmdManualInventory.ForeColor = System.Drawing.Color.White
        Me.cmdManualInventory.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.cmdManualInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdManualInventory.Name = "cmdManualInventory"
        Me.cmdManualInventory.Size = New System.Drawing.Size(120, 24)
        Me.cmdManualInventory.Text = "Manual Inventory"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'cmdLockInventory
        '
        Me.cmdLockInventory.ForeColor = System.Drawing.Color.White
        Me.cmdLockInventory.Image = Global.CoffeecupClient.My.Resources.Resources.lock__exclamation
        Me.cmdLockInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLockInventory.Name = "cmdLockInventory"
        Me.cmdLockInventory.Size = New System.Drawing.Size(149, 24)
        Me.cmdLockInventory.Text = "Lock Cut-Off Inventory"
        '
        'lineLockInventory
        '
        Me.lineLockInventory.Name = "lineLockInventory"
        Me.lineLockInventory.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrint.Text = "Print Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdExportToExcel
        '
        Me.cmdExportToExcel.ForeColor = System.Drawing.Color.White
        Me.cmdExportToExcel.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.cmdExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExportToExcel.Name = "cmdExportToExcel"
        Me.cmdExportToExcel.Size = New System.Drawing.Size(103, 24)
        Me.cmdExportToExcel.Text = "Export to Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdColumnChooser
        '
        Me.cmdColumnChooser.ForeColor = System.Drawing.Color.White
        Me.cmdColumnChooser.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.cmdColumnChooser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdColumnChooser.Name = "cmdColumnChooser"
        Me.cmdColumnChooser.Size = New System.Drawing.Size(103, 24)
        Me.cmdColumnChooser.Text = "Column Setup"
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabConsumable)
        Me.TabControl1.Controls.Add(Me.tabConsumables_prepaid)
        Me.TabControl1.Controls.Add(Me.tabCutof)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 160)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1077, 476)
        Me.TabControl1.TabIndex = 344
        '
        'tabConsumable
        '
        Me.tabConsumable.Controls.Add(Me.officeid)
        Me.tabConsumable.Controls.Add(Me.MyDataGridView)
        Me.tabConsumable.Location = New System.Drawing.Point(4, 24)
        Me.tabConsumable.Name = "tabConsumable"
        Me.tabConsumable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsumable.Size = New System.Drawing.Size(1069, 448)
        Me.tabConsumable.TabIndex = 1
        Me.tabConsumable.Text = "On hand Inventory Summary"
        Me.tabConsumable.UseVisualStyleBackColor = True
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.Location = New System.Drawing.Point(821, 21)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(75, 23)
        Me.officeid.TabIndex = 346
        Me.officeid.Visible = False
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(1063, 442)
        Me.MyDataGridView.TabIndex = 344
        '
        'tabConsumables_prepaid
        '
        Me.tabConsumables_prepaid.Location = New System.Drawing.Point(4, 24)
        Me.tabConsumables_prepaid.Name = "tabConsumables_prepaid"
        Me.tabConsumables_prepaid.Size = New System.Drawing.Size(1069, 483)
        Me.tabConsumables_prepaid.TabIndex = 3
        Me.tabConsumables_prepaid.Text = "Prepaid Inventory Summary"
        Me.tabConsumables_prepaid.UseVisualStyleBackColor = True
        '
        'tabCutof
        '
        Me.tabCutof.Location = New System.Drawing.Point(4, 24)
        Me.tabCutof.Name = "tabCutof"
        Me.tabCutof.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCutof.Size = New System.Drawing.Size(1069, 483)
        Me.tabCutof.TabIndex = 4
        Me.tabCutof.Text = "Cut-off Inventory Summary"
        Me.tabCutof.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(105, 47)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.AllowMultiSelect = True
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCategory.Size = New System.Drawing.Size(325, 24)
        Me.txtCategory.TabIndex = 281
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Select Category"
        '
        'ckZeroQuantity
        '
        Me.ckZeroQuantity.AutoSize = True
        Me.ckZeroQuantity.ForeColor = System.Drawing.Color.Black
        Me.ckZeroQuantity.Location = New System.Drawing.Point(299, 77)
        Me.ckZeroQuantity.Name = "ckZeroQuantity"
        Me.ckZeroQuantity.Size = New System.Drawing.Size(131, 19)
        Me.ckZeroQuantity.TabIndex = 280
        Me.ckZeroQuantity.Text = "Show Zero Quantity"
        Me.ckZeroQuantity.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(436, 49)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 19)
        Me.CheckBox2.TabIndex = 283
        Me.CheckBox2.Text = "View All"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'frmInventorySummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1101, 641)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventorySummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumable Inventory Summary"
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabConsumable.ResumeLayout(False)
        Me.tabConsumable.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MustaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    'Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdColumnChooser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabConsumable As System.Windows.Forms.TabPage
    Friend WithEvents cmdManualInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tabConsumables_prepaid As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLockInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineLockInventory As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdInventoryLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblOffice As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtOffice As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lineOffice As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents tabCutof As System.Windows.Forms.TabPage
    Friend WithEvents cmdViewInventoryDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckStockSequence As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ckZeroQuantity As System.Windows.Forms.CheckBox
End Class
