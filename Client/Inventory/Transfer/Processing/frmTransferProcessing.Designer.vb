<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferProcessing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferProcessing))
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
        Me.cmdView = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.RePrintTransmittalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnChooser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtabPending = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.xtabConfirm = New DevExpress.XtraTab.XtraTabPage()
        Me.xtabCancelled = New DevExpress.XtraTab.XtraTabPage()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtabPending.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtsearch.Location = New System.Drawing.Point(635, 42)
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
        Me.Label3.Location = New System.Drawing.Point(589, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 277
        Me.Label3.Text = "Search"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdView, Me.cmdCancel, Me.RePrintTransmittalToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(180, 120)
        '
        'cmdView
        '
        Me.cmdView.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(179, 22)
        Me.cmdView.Text = "View Request Item"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(179, 22)
        Me.cmdCancel.Text = "Cancel Request"
        '
        'RePrintTransmittalToolStripMenuItem
        '
        Me.RePrintTransmittalToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.RePrintTransmittalToolStripMenuItem.Name = "RePrintTransmittalToolStripMenuItem"
        Me.RePrintTransmittalToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RePrintTransmittalToolStripMenuItem.Text = "Re-Print Transmittal"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(176, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(179, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(511, 17)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(51, 23)
        Me.mode.TabIndex = 291
        Me.mode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdlogin)
        Me.GroupBox1.Controls.Add(Me.ckasof)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mode)
        Me.GroupBox1.Controls.Add(Me.txtfrmdate)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 80)
        Me.GroupBox1.TabIndex = 342
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters and Printing Setup"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(435, 21)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 296
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(110, 48)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(129, 19)
        Me.ckasof.TabIndex = 295
        Me.ckasof.Text = "Use as of Date Filter"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(283, 22)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 23)
        Me.txttodate.TabIndex = 293
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "Date Filter From"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(110, 22)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 23)
        Me.txtfrmdate.TabIndex = 291
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(262, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = "To"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 30)
        Me.Panel2.TabIndex = 311
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNew, Me.ToolStripSeparator1, Me.cmdColumnChooser, Me.ToolStripSeparator5, Me.cmdPrint, Me.ToolStripSeparator3, Me.cmdClose})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(899, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdNew
        '
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.Image = Global.CoffeecupClient.My.Resources.Resources.receipt__plus
        Me.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(106, 24)
        Me.cmdNew.Text = "Create Transfer"
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
        Me.cmdColumnChooser.Size = New System.Drawing.Size(117, 24)
        Me.cmdColumnChooser.Text = "Column Chooser"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
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
        'cmdClose
        '
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.CoffeecupClient.My.Resources.Resources.slash
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 24)
        Me.cmdClose.Text = "Close Window"
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 121)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtabPending
        Me.XtraTabControl1.Size = New System.Drawing.Size(899, 577)
        Me.XtraTabControl1.TabIndex = 821
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtabPending, Me.xtabConfirm, Me.xtabCancelled})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'xtabPending
        '
        Me.xtabPending.Controls.Add(Me.Em)
        Me.xtabPending.Name = "xtabPending"
        Me.xtabPending.Size = New System.Drawing.Size(893, 545)
        Me.xtabPending.Text = "Pending for Confirmation"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(893, 545)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Expand
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'xtabConfirm
        '
        Me.xtabConfirm.Name = "xtabConfirm"
        Me.xtabConfirm.Size = New System.Drawing.Size(893, 545)
        Me.xtabConfirm.Text = "Confirmed Transmittal"
        '
        'xtabCancelled
        '
        Me.xtabCancelled.Name = "xtabCancelled"
        Me.xtabCancelled.Size = New System.Drawing.Size(893, 545)
        Me.xtabCancelled.Text = "Cancelled Transmittal"
        '
        'frmTransferProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(923, 702)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(897, 679)
        Me.Name = "frmTransferProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Processing Reports"
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtabPending.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents cmdView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdColumnChooser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RePrintTransmittalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtabPending As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents xtabConfirm As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtabCancelled As DevExpress.XtraTab.XtraTabPage
End Class
