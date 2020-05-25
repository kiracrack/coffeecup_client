<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryFFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryFFE))
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckall = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcategory = New System.Windows.Forms.ComboBox()
        Me.ckDisposed = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblOffice = New System.Windows.Forms.ToolStripLabel()
        Me.txtOffice = New System.Windows.Forms.ToolStripComboBox()
        Me.lineOffice = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdManualInventory = New System.Windows.Forms.ToolStripButton()
        Me.lineManuelInventory = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDisposal = New System.Windows.Forms.ToolStripButton()
        Me.lineDisposal = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnChooser = New System.Windows.Forms.ToolStripButton()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdTransfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintMemorandumOfReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRequestforDisposal = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSeparationOfQuantity = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
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
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(795, 20)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(260, 23)
        Me.txtsearch.TabIndex = 276
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(747, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 277
        Me.Label3.Text = "Search"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdTransfer, Me.cmdViewProfile, Me.PrintMemorandumOfReceiptToolStripMenuItem, Me.cmdRequestforDisposal, Me.cmdSeparationOfQuantity, Me.ViewTransactionHistoryToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 208)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ckall)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcategory)
        Me.GroupBox1.Controls.Add(Me.ckDisposed)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1071, 55)
        Me.GroupBox1.TabIndex = 342
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters and Settings"
        '
        'ckall
        '
        Me.ckall.AutoSize = True
        Me.ckall.Checked = True
        Me.ckall.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckall.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckall.ForeColor = System.Drawing.Color.Black
        Me.ckall.Location = New System.Drawing.Point(302, 23)
        Me.ckall.Name = "ckall"
        Me.ckall.Size = New System.Drawing.Size(91, 19)
        Me.ckall.TabIndex = 300
        Me.ckall.Text = "All Category"
        Me.ckall.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 299
        Me.Label4.Text = "Category"
        '
        'txtcategory
        '
        Me.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcategory.Enabled = False
        Me.txtcategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcategory.FormattingEnabled = True
        Me.txtcategory.Location = New System.Drawing.Point(72, 21)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(224, 23)
        Me.txtcategory.TabIndex = 298
        '
        'ckDisposed
        '
        Me.ckDisposed.AutoSize = True
        Me.ckDisposed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckDisposed.ForeColor = System.Drawing.Color.Black
        Me.ckDisposed.Location = New System.Drawing.Point(397, 23)
        Me.ckDisposed.Name = "ckDisposed"
        Me.ckDisposed.Size = New System.Drawing.Size(133, 19)
        Me.ckDisposed.TabIndex = 297
        Me.ckDisposed.Text = "Show Disposed Item"
        Me.ckDisposed.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 30)
        Me.Panel2.TabIndex = 311
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(4, 99)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(1071, 424)
        Me.MyDataGridView.TabIndex = 344
        '
        'catid
        '
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.catid.Location = New System.Drawing.Point(880, 109)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(75, 23)
        Me.catid.TabIndex = 301
        Me.catid.Visible = False
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.Location = New System.Drawing.Point(799, 109)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(75, 23)
        Me.officeid.TabIndex = 345
        Me.officeid.Visible = False
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator5, Me.lblOffice, Me.txtOffice, Me.lineOffice, Me.cmdManualInventory, Me.lineManuelInventory, Me.cmdDisposal, Me.lineDisposal, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdExportToExcel, Me.ToolStripSeparator1, Me.cmdColumnChooser})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1078, 31)
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
        'lineManuelInventory
        '
        Me.lineManuelInventory.Name = "lineManuelInventory"
        Me.lineManuelInventory.Size = New System.Drawing.Size(6, 27)
        '
        'cmdDisposal
        '
        Me.cmdDisposal.ForeColor = System.Drawing.Color.White
        Me.cmdDisposal.Image = Global.CoffeecupClient.My.Resources.Resources.book_question
        Me.cmdDisposal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDisposal.Name = "cmdDisposal"
        Me.cmdDisposal.Size = New System.Drawing.Size(134, 24)
        Me.cmdDisposal.Text = "Request for Disposal"
        '
        'lineDisposal
        '
        Me.lineDisposal.Name = "lineDisposal"
        Me.lineDisposal.Size = New System.Drawing.Size(6, 27)
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
        Me.cmdExportToExcel.Size = New System.Drawing.Size(90, 24)
        Me.cmdExportToExcel.Text = "Print Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
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
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(193, 22)
        Me.cmdEdit.Text = "Edit Selected"
        '
        'cmdTransfer
        '
        Me.cmdTransfer.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_next
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Size = New System.Drawing.Size(193, 22)
        Me.cmdTransfer.Text = "Transfer FFE"
        '
        'cmdViewProfile
        '
        Me.cmdViewProfile.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list
        Me.cmdViewProfile.Name = "cmdViewProfile"
        Me.cmdViewProfile.Size = New System.Drawing.Size(193, 22)
        Me.cmdViewProfile.Text = "View Asset Profile"
        '
        'PrintMemorandumOfReceiptToolStripMenuItem
        '
        Me.PrintMemorandumOfReceiptToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.PrintMemorandumOfReceiptToolStripMenuItem.Name = "PrintMemorandumOfReceiptToolStripMenuItem"
        Me.PrintMemorandumOfReceiptToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PrintMemorandumOfReceiptToolStripMenuItem.Text = "Print Asset Profile"
        '
        'cmdRequestforDisposal
        '
        Me.cmdRequestforDisposal.Image = Global.CoffeecupClient.My.Resources.Resources.book__minus
        Me.cmdRequestforDisposal.Name = "cmdRequestforDisposal"
        Me.cmdRequestforDisposal.Size = New System.Drawing.Size(193, 22)
        Me.cmdRequestforDisposal.Text = "Request for Disposal"
        '
        'cmdSeparationOfQuantity
        '
        Me.cmdSeparationOfQuantity.Image = Global.CoffeecupClient.My.Resources.Resources.notebooks
        Me.cmdSeparationOfQuantity.Name = "cmdSeparationOfQuantity"
        Me.cmdSeparationOfQuantity.Size = New System.Drawing.Size(193, 22)
        Me.cmdSeparationOfQuantity.Text = "Separation of Quantity"
        '
        'ViewTransactionHistoryToolStripMenuItem
        '
        Me.ViewTransactionHistoryToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources._165
        Me.ViewTransactionHistoryToolStripMenuItem.Name = "ViewTransactionHistoryToolStripMenuItem"
        Me.ViewTransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ViewTransactionHistoryToolStripMenuItem.Text = "View FFE History"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'frmInventoryFFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1078, 529)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(990, 568)
        Me.Name = "frmInventoryFFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Inventory Summary"
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
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
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdColumnChooser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdManualInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineManuelInventory As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ckDisposed As System.Windows.Forms.CheckBox
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintMemorandumOfReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdViewProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcategory As System.Windows.Forms.ComboBox
    Friend WithEvents ckall As System.Windows.Forms.CheckBox
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents lblOffice As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtOffice As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lineOffice As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents cmdTransfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRequestforDisposal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTransactionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDisposal As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineDisposal As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSeparationOfQuantity As System.Windows.Forms.ToolStripMenuItem
End Class
