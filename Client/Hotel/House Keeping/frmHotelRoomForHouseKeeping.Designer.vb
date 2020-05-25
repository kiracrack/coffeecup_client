<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomForHouseKeeping
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelRoomForHouseKeeping))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdProceedCheckin = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetMaintainanceTimeFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHotel = New System.Windows.Forms.ComboBox()
        Me.ckViewAll = New System.Windows.Forms.CheckBox()
        Me.txtRoomStatus = New System.Windows.Forms.ComboBox()
        Me.roomstatus = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.hotelcif = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabMaintainance = New System.Windows.Forms.TabPage()
        Me.ckClosed = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdPrintMaintainance = New System.Windows.Forms.ToolStripButton()
        Me.cmdFilterMaintainance = New System.Windows.Forms.Button()
        Me.txtMaintainanceTo = New System.Windows.Forms.DateTimePicker()
        Me.txtMaintainanceFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdClosed = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUpdatemaintainance = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPost.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMaintainance.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdProceedCheckin, Me.SetMaintainanceTimeFrameToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(227, 76)
        '
        'cmdProceedCheckin
        '
        Me.cmdProceedCheckin.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow
        Me.cmdProceedCheckin.Name = "cmdProceedCheckin"
        Me.cmdProceedCheckin.Size = New System.Drawing.Size(226, 22)
        Me.cmdProceedCheckin.Text = "Update Room Status"
        '
        'SetMaintainanceTimeFrameToolStripMenuItem
        '
        Me.SetMaintainanceTimeFrameToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.Time_Hot1
        Me.SetMaintainanceTimeFrameToolStripMenuItem.Name = "SetMaintainanceTimeFrameToolStripMenuItem"
        Me.SetMaintainanceTimeFrameToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SetMaintainanceTimeFrameToolStripMenuItem.Text = "Set maintainance time frame"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(223, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(226, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(744, 21)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(268, 23)
        Me.txtsearch.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtHotel)
        Me.GroupBox1.Controls.Add(Me.ckViewAll)
        Me.GroupBox1.Controls.Add(Me.txtRoomStatus)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please select filter by status | or enterKey Command - Press F3 to enter command " & _
    "search | Press ENTER key to validate "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(696, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 481
        Me.Label2.Text = "Search"
        '
        'txtHotel
        '
        Me.txtHotel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtHotel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtHotel.DropDownHeight = 130
        Me.txtHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHotel.ForeColor = System.Drawing.Color.Black
        Me.txtHotel.FormattingEnabled = True
        Me.txtHotel.IntegralHeight = False
        Me.txtHotel.ItemHeight = 15
        Me.txtHotel.Location = New System.Drawing.Point(6, 22)
        Me.txtHotel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHotel.MaxDropDownItems = 7
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Size = New System.Drawing.Size(204, 23)
        Me.txtHotel.TabIndex = 482
        '
        'ckViewAll
        '
        Me.ckViewAll.AutoSize = True
        Me.ckViewAll.Checked = True
        Me.ckViewAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckViewAll.Location = New System.Drawing.Point(430, 26)
        Me.ckViewAll.Name = "ckViewAll"
        Me.ckViewAll.Size = New System.Drawing.Size(67, 17)
        Me.ckViewAll.TabIndex = 480
        Me.ckViewAll.Text = "View All"
        Me.ckViewAll.UseVisualStyleBackColor = True
        '
        'txtRoomStatus
        '
        Me.txtRoomStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomStatus.DropDownHeight = 130
        Me.txtRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomStatus.Enabled = False
        Me.txtRoomStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomStatus.ForeColor = System.Drawing.Color.Black
        Me.txtRoomStatus.FormattingEnabled = True
        Me.txtRoomStatus.IntegralHeight = False
        Me.txtRoomStatus.ItemHeight = 15
        Me.txtRoomStatus.Location = New System.Drawing.Point(213, 22)
        Me.txtRoomStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomStatus.MaxDropDownItems = 7
        Me.txtRoomStatus.Name = "txtRoomStatus"
        Me.txtRoomStatus.Size = New System.Drawing.Size(212, 23)
        Me.txtRoomStatus.TabIndex = 477
        '
        'roomstatus
        '
        Me.roomstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomstatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomstatus.ForeColor = System.Drawing.Color.Black
        Me.roomstatus.Location = New System.Drawing.Point(564, 206)
        Me.roomstatus.Margin = New System.Windows.Forms.Padding(5)
        Me.roomstatus.Name = "roomstatus"
        Me.roomstatus.ReadOnly = True
        Me.roomstatus.Size = New System.Drawing.Size(45, 23)
        Me.roomstatus.TabIndex = 479
        Me.roomstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomstatus.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(677, 207)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(54, 24)
        Me.mode.TabIndex = 393
        Me.mode.Visible = False
        '
        'hotelcif
        '
        Me.hotelcif.Location = New System.Drawing.Point(617, 207)
        Me.hotelcif.Name = "hotelcif"
        Me.hotelcif.Size = New System.Drawing.Size(54, 24)
        Me.hotelcif.TabIndex = 394
        Me.hotelcif.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(739, 207)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 23)
        Me.TextBox1.TabIndex = 483
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPost)
        Me.TabControl1.Controls.Add(Me.tabMaintainance)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1039, 562)
        Me.TabControl1.TabIndex = 485
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.Em)
        Me.tabPost.Controls.Add(Me.TextBox1)
        Me.tabPost.Controls.Add(Me.GroupBox1)
        Me.tabPost.Controls.Add(Me.hotelcif)
        Me.tabPost.Controls.Add(Me.roomstatus)
        Me.tabPost.Controls.Add(Me.mode)
        Me.tabPost.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.tabPost.Location = New System.Drawing.Point(4, 24)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(1031, 534)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Room Updates"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(6, 65)
        Me.Em.MainView = Me.Gridview1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.Em.Size = New System.Drawing.Size(1019, 461)
        Me.Em.TabIndex = 823
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1})
        '
        'Gridview1
        '
        Me.Gridview1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview1.Appearance.GroupFooter.Options.UseFont = True
        Me.Gridview1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview1.Appearance.GroupPanel.Options.UseFont = True
        Me.Gridview1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview1.Appearance.GroupRow.Options.UseFont = True
        Me.Gridview1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview1.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview1.Appearance.Row.Options.UseFont = True
        Me.Gridview1.Appearance.Row.Options.UseTextOptions = True
        Me.Gridview1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Gridview1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview1.GridControl = Me.Em
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        Me.Gridview1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'tabMaintainance
        '
        Me.tabMaintainance.Controls.Add(Me.ckClosed)
        Me.tabMaintainance.Controls.Add(Me.ToolStrip1)
        Me.tabMaintainance.Controls.Add(Me.cmdFilterMaintainance)
        Me.tabMaintainance.Controls.Add(Me.txtMaintainanceTo)
        Me.tabMaintainance.Controls.Add(Me.txtMaintainanceFrom)
        Me.tabMaintainance.Controls.Add(Me.Label1)
        Me.tabMaintainance.Controls.Add(Me.Label5)
        Me.tabMaintainance.Controls.Add(Me.DataGridView2)
        Me.tabMaintainance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.tabMaintainance.Location = New System.Drawing.Point(4, 24)
        Me.tabMaintainance.Name = "tabMaintainance"
        Me.tabMaintainance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMaintainance.Size = New System.Drawing.Size(1031, 534)
        Me.tabMaintainance.TabIndex = 2
        Me.tabMaintainance.Text = "Room Maintainance Timeframe"
        Me.tabMaintainance.UseVisualStyleBackColor = True
        '
        'ckClosed
        '
        Me.ckClosed.AutoSize = True
        Me.ckClosed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckClosed.Location = New System.Drawing.Point(120, 69)
        Me.ckClosed.Name = "ckClosed"
        Me.ckClosed.Size = New System.Drawing.Size(129, 17)
        Me.ckClosed.TabIndex = 407
        Me.ckClosed.Text = "Show Close Reports"
        Me.ckClosed.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrintMaintainance})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1025, 31)
        Me.ToolStrip1.TabIndex = 406
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdPrintMaintainance
        '
        Me.cmdPrintMaintainance.ForeColor = System.Drawing.Color.White
        Me.cmdPrintMaintainance.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrintMaintainance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintMaintainance.Name = "cmdPrintMaintainance"
        Me.cmdPrintMaintainance.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrintMaintainance.Text = "Print Report"
        '
        'cmdFilterMaintainance
        '
        Me.cmdFilterMaintainance.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdFilterMaintainance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFilterMaintainance.Location = New System.Drawing.Point(446, 38)
        Me.cmdFilterMaintainance.Name = "cmdFilterMaintainance"
        Me.cmdFilterMaintainance.Size = New System.Drawing.Size(36, 25)
        Me.cmdFilterMaintainance.TabIndex = 405
        Me.cmdFilterMaintainance.UseVisualStyleBackColor = True
        '
        'txtMaintainanceTo
        '
        Me.txtMaintainanceTo.CalendarFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMaintainanceTo.CustomFormat = "MMMM dd, yyyy"
        Me.txtMaintainanceTo.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMaintainanceTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtMaintainanceTo.Location = New System.Drawing.Point(293, 39)
        Me.txtMaintainanceTo.Name = "txtMaintainanceTo"
        Me.txtMaintainanceTo.Size = New System.Drawing.Size(150, 24)
        Me.txtMaintainanceTo.TabIndex = 403
        '
        'txtMaintainanceFrom
        '
        Me.txtMaintainanceFrom.CalendarFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMaintainanceFrom.CustomFormat = "MMMM dd, yyyy"
        Me.txtMaintainanceFrom.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtMaintainanceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtMaintainanceFrom.Location = New System.Drawing.Point(120, 39)
        Me.txtMaintainanceFrom.Name = "txtMaintainanceFrom"
        Me.txtMaintainanceFrom.Size = New System.Drawing.Size(150, 24)
        Me.txtMaintainanceFrom.TabIndex = 401
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(272, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 404
        Me.Label1.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 402
        Me.Label5.Text = "Date Period From"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(6, 91)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1018, 438)
        Me.DataGridView2.TabIndex = 393
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClosed, Me.cmdUpdatemaintainance, Me.ToolStripSeparator1, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(249, 76)
        '
        'cmdClosed
        '
        Me.cmdClosed.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdClosed.Name = "cmdClosed"
        Me.cmdClosed.Size = New System.Drawing.Size(248, 22)
        Me.cmdClosed.Text = "Close Maintainance"
        '
        'cmdUpdatemaintainance
        '
        Me.cmdUpdatemaintainance.Image = Global.CoffeecupClient.My.Resources.Resources.Time_Hot1
        Me.cmdUpdatemaintainance.Name = "cmdUpdatemaintainance"
        Me.cmdUpdatemaintainance.Size = New System.Drawing.Size(248, 22)
        Me.cmdUpdatemaintainance.Text = "Update maintainance time frame"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(245, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(248, 22)
        Me.ToolStripMenuItem3.Tag = "1"
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.ToolStrip3)
        Me.tabTransaction.Controls.Add(Me.cmdlogin)
        Me.tabTransaction.Controls.Add(Me.txttodate)
        Me.tabTransaction.Controls.Add(Me.txtfrmdate)
        Me.tabTransaction.Controls.Add(Me.Label4)
        Me.tabTransaction.Controls.Add(Me.Label3)
        Me.tabTransaction.Controls.Add(Me.DataGridView1)
        Me.tabTransaction.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 24)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(1031, 534)
        Me.tabTransaction.TabIndex = 1
        Me.tabTransaction.Text = "House Keeping Reports"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1025, 31)
        Me.ToolStrip3.TabIndex = 400
        Me.ToolStrip3.Text = "ToolStrip3"
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
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(446, 38)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 399
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CalendarFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(293, 39)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 24)
        Me.txttodate.TabIndex = 397
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CalendarFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(120, 39)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 24)
        Me.txtfrmdate.TabIndex = 395
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(272, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 398
        Me.Label4.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 396
        Me.Label3.Text = "Date Period From"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(3, 73)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 454)
        Me.DataGridView1.TabIndex = 394
        '
        'frmHotelRoomForHouseKeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1039, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(870, 502)
        Me.Name = "frmHotelRoomForHouseKeeping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "House Keeping"
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMaintainance.ResumeLayout(False)
        Me.tabMaintainance.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabTransaction.ResumeLayout(False)
        Me.tabTransaction.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents hotelcif As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomStatus As System.Windows.Forms.ComboBox
    Friend WithEvents roomstatus As System.Windows.Forms.TextBox
    Friend WithEvents ckViewAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHotel As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdProceedCheckin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SetMaintainanceTimeFrameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabMaintainance As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrintMaintainance As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdFilterMaintainance As System.Windows.Forms.Button
    Friend WithEvents txtMaintainanceTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMaintainanceFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckClosed As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdClosed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUpdatemaintainance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
