<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelManagementv2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelManagementv2))
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
        Me.cms_guestlist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdProceedCheckin = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdMergePayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttachementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtGuestType = New System.Windows.Forms.ToolStripComboBox()
        Me.txtsearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNewCheckinGuest = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdGuestManagement = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRoomTariff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.linesummary = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdHotelSalesSummary = New System.Windows.Forms.ToolStripButton()
        Me.updates = New System.Windows.Forms.ToolStripLabel()
        Me.guesttype = New System.Windows.Forms.TextBox()
        Me.Em_Reservation = New DevExpress.XtraGrid.GridControl()
        Me.cms_reservation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Reservation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Em_GuestList = New DevExpress.XtraGrid.GridControl()
        Me.GridView_GuestList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Em_InHouse = New DevExpress.XtraGrid.GridControl()
        Me.cmd_inhouse = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_InHouse = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Em_TodayArrival = New DevExpress.XtraGrid.GridControl()
        Me.cms_arival = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_TodayArrival = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Em_closed = New DevExpress.XtraGrid.GridControl()
        Me.cms_closed = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRestoreCloseFolio = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRestoreCancelledFolio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview_closed = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtStatusTitle = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatusArrival = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatusInhouse = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatusForCheckout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStatusNoShow = New System.Windows.Forms.ToolStripStatusLabel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xTabReservation = New DevExpress.XtraTab.XtraTabPage()
        Me.xTabGuestList = New DevExpress.XtraTab.XtraTabPage()
        Me.xTabInhouseGuest = New DevExpress.XtraTab.XtraTabPage()
        Me.xTabArrivalGuest = New DevExpress.XtraTab.XtraTabPage()
        Me.xTabCheckoutGuest = New DevExpress.XtraTab.XtraTabPage()
        Me.xTabCancelledFolio = New DevExpress.XtraTab.XtraTabPage()
        Me.cms_guestlist.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.Em_Reservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_reservation.SuspendLayout()
        CType(Me.GridView_Reservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_GuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_GuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_InHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_inhouse.SuspendLayout()
        CType(Me.GridView_InHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_TodayArrival, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_arival.SuspendLayout()
        CType(Me.GridView_TodayArrival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_closed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_closed.SuspendLayout()
        CType(Me.Gridview_closed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xTabReservation.SuspendLayout()
        Me.xTabGuestList.SuspendLayout()
        Me.xTabInhouseGuest.SuspendLayout()
        Me.xTabArrivalGuest.SuspendLayout()
        Me.xTabCheckoutGuest.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
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
        'cms_guestlist
        '
        Me.cms_guestlist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdProceedCheckin, Me.cmdMergePayment, Me.AttachementToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_guestlist.Name = "ContextMenuStrip1"
        Me.cms_guestlist.Size = New System.Drawing.Size(218, 98)
        '
        'cmdProceedCheckin
        '
        Me.cmdProceedCheckin.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow2
        Me.cmdProceedCheckin.Name = "cmdProceedCheckin"
        Me.cmdProceedCheckin.Size = New System.Drawing.Size(217, 22)
        Me.cmdProceedCheckin.Text = "View Folio Information"
        '
        'cmdMergePayment
        '
        Me.cmdMergePayment.Image = Global.CoffeecupClient.My.Resources.Resources.Money_Hot
        Me.cmdMergePayment.Name = "cmdMergePayment"
        Me.cmdMergePayment.Size = New System.Drawing.Size(217, 22)
        Me.cmdMergePayment.Text = "Payment to Selected Room"
        '
        'AttachementToolStripMenuItem
        '
        Me.AttachementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddAttachment, Me.cmdViewAttachment})
        Me.AttachementToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.AttachementToolStripMenuItem.Name = "AttachementToolStripMenuItem"
        Me.AttachementToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.AttachementToolStripMenuItem.Text = "Folio Attachment"
        '
        'cmdAddAttachment
        '
        Me.cmdAddAttachment.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__plus
        Me.cmdAddAttachment.Name = "cmdAddAttachment"
        Me.cmdAddAttachment.Size = New System.Drawing.Size(165, 22)
        Me.cmdAddAttachment.Text = "Add Attachment"
        '
        'cmdViewAttachment
        '
        Me.cmdViewAttachment.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__arrow
        Me.cmdViewAttachment.Name = "cmdViewAttachment"
        Me.cmdViewAttachment.Size = New System.Drawing.Size(165, 22)
        Me.cmdViewAttachment.Text = "View Attachment"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(214, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(217, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ckasof
        '
        Me.ckasof.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckasof.AutoSize = True
        Me.ckasof.BackColor = System.Drawing.Color.Transparent
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(862, 66)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(128, 19)
        Me.ckasof.TabIndex = 295
        Me.ckasof.Text = "View all transaction"
        Me.ckasof.UseVisualStyleBackColor = False
        '
        'txttodate
        '
        Me.txttodate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttodate.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(1016, 37)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 23)
        Me.txttodate.TabIndex = 293
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(859, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 292
        Me.Label1.Text = "Report filter date option"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfrmdate.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(861, 37)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 23)
        Me.txtfrmdate.TabIndex = 291
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(892, 43)
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
        Me.Panel2.Location = New System.Drawing.Point(12, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 30)
        Me.Panel2.TabIndex = 311
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtGuestType, Me.txtsearch, Me.ToolStripSeparator2, Me.cmdNewCheckinGuest, Me.ToolStripSeparator1, Me.cmdGuestManagement, Me.ToolStripSeparator5, Me.cmdRoomTariff, Me.ToolStripSeparator6, Me.cmdPrint, Me.linesummary, Me.cmdHotelSalesSummary})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1216, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 24)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtGuestType
        '
        Me.txtGuestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGuestType.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txtGuestType.Items.AddRange(New Object() {"GROUP", "INDIVIDUAL"})
        Me.txtGuestType.Name = "txtGuestType"
        Me.txtGuestType.Size = New System.Drawing.Size(130, 27)
        '
        'txtsearch
        '
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(200, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdNewCheckinGuest
        '
        Me.cmdNewCheckinGuest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewCheckinGuest.ForeColor = System.Drawing.Color.White
        Me.cmdNewCheckinGuest.Image = Global.CoffeecupClient.My.Resources.Resources.user__plus1
        Me.cmdNewCheckinGuest.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewCheckinGuest.Name = "cmdNewCheckinGuest"
        Me.cmdNewCheckinGuest.Size = New System.Drawing.Size(140, 24)
        Me.cmdNewCheckinGuest.Text = "New Check-in Guest"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdGuestManagement
        '
        Me.cmdGuestManagement.ForeColor = System.Drawing.Color.White
        Me.cmdGuestManagement.Image = Global.CoffeecupClient.My.Resources.Resources._007
        Me.cmdGuestManagement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGuestManagement.Name = "cmdGuestManagement"
        Me.cmdGuestManagement.Size = New System.Drawing.Size(131, 24)
        Me.cmdGuestManagement.Text = "Guest Management"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'cmdRoomTariff
        '
        Me.cmdRoomTariff.ForeColor = System.Drawing.Color.White
        Me.cmdRoomTariff.Image = Global.CoffeecupClient.My.Resources.Resources.calendar_blue
        Me.cmdRoomTariff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRoomTariff.Name = "cmdRoomTariff"
        Me.cmdRoomTariff.Size = New System.Drawing.Size(198, 24)
        Me.cmdRoomTariff.Text = "Room Availability Calendar View"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(121, 24)
        Me.cmdPrint.Text = "Print Selected Tab"
        '
        'linesummary
        '
        Me.linesummary.Name = "linesummary"
        Me.linesummary.Size = New System.Drawing.Size(6, 27)
        '
        'cmdHotelSalesSummary
        '
        Me.cmdHotelSalesSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHotelSalesSummary.ForeColor = System.Drawing.Color.Yellow
        Me.cmdHotelSalesSummary.Image = Global.CoffeecupClient.My.Resources.Resources.clipboard_list
        Me.cmdHotelSalesSummary.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHotelSalesSummary.Name = "cmdHotelSalesSummary"
        Me.cmdHotelSalesSummary.Size = New System.Drawing.Size(175, 24)
        Me.cmdHotelSalesSummary.Text = "Print Hotel Sales Summary"
        Me.cmdHotelSalesSummary.ToolTipText = "Please select exact date above to filter records"
        '
        'updates
        '
        Me.updates.BackColor = System.Drawing.Color.Transparent
        Me.updates.ForeColor = System.Drawing.Color.White
        Me.updates.Name = "updates"
        Me.updates.Size = New System.Drawing.Size(0, 24)
        '
        'guesttype
        '
        Me.guesttype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guesttype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guesttype.Location = New System.Drawing.Point(691, 5)
        Me.guesttype.Name = "guesttype"
        Me.guesttype.Size = New System.Drawing.Size(70, 22)
        Me.guesttype.TabIndex = 829
        Me.guesttype.Visible = False
        '
        'Em_Reservation
        '
        Me.Em_Reservation.ContextMenuStrip = Me.cms_reservation
        Me.Em_Reservation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Reservation.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Reservation.Location = New System.Drawing.Point(0, 0)
        Me.Em_Reservation.MainView = Me.GridView_Reservation
        Me.Em_Reservation.Name = "Em_Reservation"
        Me.Em_Reservation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.Em_Reservation.Size = New System.Drawing.Size(1210, 398)
        Me.Em_Reservation.TabIndex = 822
        Me.Em_Reservation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Reservation})
        '
        'cms_reservation
        '
        Me.cms_reservation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem10, Me.ToolStripMenuItem8, Me.ToolStripSeparator10, Me.ToolStripMenuItem9})
        Me.cms_reservation.Name = "ContextMenuStrip1"
        Me.cms_reservation.Size = New System.Drawing.Size(222, 98)
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow2
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem7.Text = "View Reservation Info"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.ToolStripMenuItem10.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem10.Text = "Folio Attachment"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__plus
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem11.Text = "Add Attachment"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__arrow
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem12.Text = "View Attachment"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem8.Text = "Cancel Selected Reservation"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(218, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem9.Tag = "1"
        Me.ToolStripMenuItem9.Text = "Refresh Data"
        '
        'GridView_Reservation
        '
        Me.GridView_Reservation.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Reservation.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Reservation.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Reservation.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Reservation.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Reservation.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Reservation.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Reservation.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Reservation.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Reservation.Appearance.Row.Options.UseFont = True
        Me.GridView_Reservation.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Reservation.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Reservation.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Reservation.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Reservation.GridControl = Me.Em_Reservation
        Me.GridView_Reservation.Name = "GridView_Reservation"
        Me.GridView_Reservation.OptionsBehavior.Editable = False
        Me.GridView_Reservation.OptionsSelection.MultiSelect = True
        Me.GridView_Reservation.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Reservation.OptionsView.ColumnAutoWidth = False
        Me.GridView_Reservation.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'Em_GuestList
        '
        Me.Em_GuestList.ContextMenuStrip = Me.cms_guestlist
        Me.Em_GuestList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_GuestList.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_GuestList.Location = New System.Drawing.Point(0, 0)
        Me.Em_GuestList.MainView = Me.GridView_GuestList
        Me.Em_GuestList.Name = "Em_GuestList"
        Me.Em_GuestList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em_GuestList.Size = New System.Drawing.Size(1210, 398)
        Me.Em_GuestList.TabIndex = 821
        Me.Em_GuestList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_GuestList})
        '
        'GridView_GuestList
        '
        Me.GridView_GuestList.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_GuestList.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_GuestList.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_GuestList.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_GuestList.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_GuestList.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_GuestList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_GuestList.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_GuestList.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_GuestList.Appearance.Row.Options.UseFont = True
        Me.GridView_GuestList.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_GuestList.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_GuestList.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_GuestList.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_GuestList.GridControl = Me.Em_GuestList
        Me.GridView_GuestList.Name = "GridView_GuestList"
        Me.GridView_GuestList.OptionsBehavior.Editable = False
        Me.GridView_GuestList.OptionsSelection.MultiSelect = True
        Me.GridView_GuestList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_GuestList.OptionsView.ColumnAutoWidth = False
        Me.GridView_GuestList.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'Em_InHouse
        '
        Me.Em_InHouse.ContextMenuStrip = Me.cmd_inhouse
        Me.Em_InHouse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_InHouse.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_InHouse.Location = New System.Drawing.Point(0, 0)
        Me.Em_InHouse.MainView = Me.GridView_InHouse
        Me.Em_InHouse.Name = "Em_InHouse"
        Me.Em_InHouse.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_InHouse.Size = New System.Drawing.Size(1210, 398)
        Me.Em_InHouse.TabIndex = 823
        Me.Em_InHouse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_InHouse})
        '
        'cmd_inhouse
        '
        Me.cmd_inhouse.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem13, Me.ToolStripSeparator7, Me.ToolStripMenuItem3})
        Me.cmd_inhouse.Name = "ContextMenuStrip1"
        Me.cmd_inhouse.Size = New System.Drawing.Size(195, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow2
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripMenuItem1.Text = "View Folio Information"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.ToolStripMenuItem15})
        Me.ToolStripMenuItem13.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripMenuItem13.Text = "Folio Attachment"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__plus
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem14.Text = "Add Attachment"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__arrow
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem15.Text = "View Attachment"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(191, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(194, 22)
        Me.ToolStripMenuItem3.Tag = "1"
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'GridView_InHouse
        '
        Me.GridView_InHouse.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_InHouse.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_InHouse.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_InHouse.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_InHouse.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_InHouse.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_InHouse.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_InHouse.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_InHouse.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_InHouse.Appearance.Row.Options.UseFont = True
        Me.GridView_InHouse.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_InHouse.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_InHouse.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_InHouse.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_InHouse.GridControl = Me.Em_InHouse
        Me.GridView_InHouse.Name = "GridView_InHouse"
        Me.GridView_InHouse.OptionsBehavior.Editable = False
        Me.GridView_InHouse.OptionsSelection.MultiSelect = True
        Me.GridView_InHouse.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_InHouse.OptionsView.ColumnAutoWidth = False
        Me.GridView_InHouse.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'Em_TodayArrival
        '
        Me.Em_TodayArrival.ContextMenuStrip = Me.cms_arival
        Me.Em_TodayArrival.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_TodayArrival.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_TodayArrival.Location = New System.Drawing.Point(0, 0)
        Me.Em_TodayArrival.MainView = Me.GridView_TodayArrival
        Me.Em_TodayArrival.Name = "Em_TodayArrival"
        Me.Em_TodayArrival.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_TodayArrival.Size = New System.Drawing.Size(1210, 398)
        Me.Em_TodayArrival.TabIndex = 822
        Me.Em_TodayArrival.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_TodayArrival})
        '
        'cms_arival
        '
        Me.cms_arival.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem16, Me.cmdCancel, Me.ToolStripSeparator8, Me.ToolStripMenuItem4})
        Me.cms_arival.Name = "ContextMenuStrip1"
        Me.cms_arival.Size = New System.Drawing.Size(222, 98)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow2
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem2.Text = "View Folio Information"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.ToolStripMenuItem16.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem16.Text = "Folio Attachment"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__plus
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem17.Text = "Add Attachment"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__arrow
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem18.Text = "View Attachment"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(221, 22)
        Me.cmdCancel.Text = "Cancel Selected Transaction"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(218, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem4.Tag = "1"
        Me.ToolStripMenuItem4.Text = "Refresh Data"
        '
        'GridView_TodayArrival
        '
        Me.GridView_TodayArrival.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_TodayArrival.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_TodayArrival.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_TodayArrival.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_TodayArrival.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_TodayArrival.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_TodayArrival.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_TodayArrival.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_TodayArrival.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_TodayArrival.Appearance.Row.Options.UseFont = True
        Me.GridView_TodayArrival.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_TodayArrival.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_TodayArrival.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_TodayArrival.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_TodayArrival.GridControl = Me.Em_TodayArrival
        Me.GridView_TodayArrival.Name = "GridView_TodayArrival"
        Me.GridView_TodayArrival.OptionsBehavior.Editable = False
        Me.GridView_TodayArrival.OptionsSelection.MultiSelect = True
        Me.GridView_TodayArrival.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_TodayArrival.OptionsView.ColumnAutoWidth = False
        Me.GridView_TodayArrival.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'Em_closed
        '
        Me.Em_closed.ContextMenuStrip = Me.cms_closed
        Me.Em_closed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_closed.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_closed.Location = New System.Drawing.Point(0, 0)
        Me.Em_closed.MainView = Me.Gridview_closed
        Me.Em_closed.Name = "Em_closed"
        Me.Em_closed.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit4})
        Me.Em_closed.Size = New System.Drawing.Size(1210, 398)
        Me.Em_closed.TabIndex = 823
        Me.Em_closed.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview_closed})
        '
        'cms_closed
        '
        Me.cms_closed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem19, Me.cmdRestoreCloseFolio, Me.cmdRestoreCancelledFolio, Me.ToolStripSeparator9, Me.ToolStripMenuItem6})
        Me.cms_closed.Name = "ContextMenuStrip1"
        Me.cms_closed.Size = New System.Drawing.Size(201, 120)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow2
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem5.Text = "View Folio Information"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem20, Me.ToolStripMenuItem21})
        Me.ToolStripMenuItem19.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem19.Text = "Folio Attachment"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__plus
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem20.Text = "Add Attachment"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Image = Global.CoffeecupClient.My.Resources.Resources.inbox__arrow
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem21.Text = "View Attachment"
        '
        'cmdRestoreCloseFolio
        '
        Me.cmdRestoreCloseFolio.Image = Global.CoffeecupClient.My.Resources.Resources._116
        Me.cmdRestoreCloseFolio.Name = "cmdRestoreCloseFolio"
        Me.cmdRestoreCloseFolio.Size = New System.Drawing.Size(200, 22)
        Me.cmdRestoreCloseFolio.Text = "Restore Closed Folio"
        '
        'cmdRestoreCancelledFolio
        '
        Me.cmdRestoreCancelledFolio.Image = Global.CoffeecupClient.My.Resources.Resources._116
        Me.cmdRestoreCancelledFolio.Name = "cmdRestoreCancelledFolio"
        Me.cmdRestoreCancelledFolio.Size = New System.Drawing.Size(200, 22)
        Me.cmdRestoreCancelledFolio.Text = "Restore Cancelled Folio "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(197, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripMenuItem6.Tag = "1"
        Me.ToolStripMenuItem6.Text = "Refresh Data"
        '
        'Gridview_closed
        '
        Me.Gridview_closed.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_closed.Appearance.GroupFooter.Options.UseFont = True
        Me.Gridview_closed.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_closed.Appearance.GroupPanel.Options.UseFont = True
        Me.Gridview_closed.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_closed.Appearance.GroupRow.Options.UseFont = True
        Me.Gridview_closed.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview_closed.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview_closed.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_closed.Appearance.Row.Options.UseFont = True
        Me.Gridview_closed.Appearance.Row.Options.UseTextOptions = True
        Me.Gridview_closed.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview_closed.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Gridview_closed.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview_closed.GridControl = Me.Em_closed
        Me.Gridview_closed.Name = "Gridview_closed"
        Me.Gridview_closed.OptionsBehavior.Editable = False
        Me.Gridview_closed.OptionsSelection.MultiSelect = True
        Me.Gridview_closed.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.Gridview_closed.OptionsView.ColumnAutoWidth = False
        Me.Gridview_closed.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit4
        '
        Me.RepositoryItemPictureEdit4.Name = "RepositoryItemPictureEdit4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ProgressBarControl1)
        Me.GroupBox1.Controls.Add(Me.cmdlogin)
        Me.GroupBox1.Controls.Add(Me.ckasof)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtfrmdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1216, 114)
        Me.GroupBox1.TabIndex = 342
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(1049, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(117, 19)
        Me.CheckBox1.TabIndex = 831
        Me.CheckBox1.Text = "Display No-Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(861, 7)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(305, 27)
        Me.ProgressBarControl1.TabIndex = 822
        Me.ProgressBarControl1.Visible = False
        '
        'cmdlogin
        '
        Me.cmdlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdlogin.BackColor = System.Drawing.Color.Transparent
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(1169, 36)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 296
        Me.cmdlogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1206, 114)
        Me.PictureBox1.TabIndex = 403
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtStatusTitle, Me.txtStatusArrival, Me.txtStatusInhouse, Me.txtStatusForCheckout, Me.txtStatusNoShow})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 594)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1232, 22)
        Me.StatusStrip1.TabIndex = 345
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtStatusTitle
        '
        Me.txtStatusTitle.Name = "txtStatusTitle"
        Me.txtStatusTitle.Size = New System.Drawing.Size(189, 17)
        Me.txtStatusTitle.Text = "Today's status September 9,2017 : "
        '
        'txtStatusArrival
        '
        Me.txtStatusArrival.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatusArrival.ForeColor = System.Drawing.Color.Black
        Me.txtStatusArrival.Name = "txtStatusArrival"
        Me.txtStatusArrival.Size = New System.Drawing.Size(56, 17)
        Me.txtStatusArrival.Text = "Arival: 0 |"
        '
        'txtStatusInhouse
        '
        Me.txtStatusInhouse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatusInhouse.Name = "txtStatusInhouse"
        Me.txtStatusInhouse.Size = New System.Drawing.Size(76, 17)
        Me.txtStatusInhouse.Text = "In-House: 0 |"
        '
        'txtStatusForCheckout
        '
        Me.txtStatusForCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatusForCheckout.Name = "txtStatusForCheckout"
        Me.txtStatusForCheckout.Size = New System.Drawing.Size(96, 17)
        Me.txtStatusForCheckout.Text = "For Checkout: 0 |"
        '
        'txtStatusNoShow
        '
        Me.txtStatusNoShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatusNoShow.Name = "txtStatusNoShow"
        Me.txtStatusNoShow.Size = New System.Drawing.Size(75, 17)
        Me.txtStatusNoShow.Text = "No Show: 0 |"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 161)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xTabReservation
        Me.XtraTabControl1.Size = New System.Drawing.Size(1216, 430)
        Me.XtraTabControl1.TabIndex = 830
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xTabReservation, Me.xTabGuestList, Me.xTabInhouseGuest, Me.xTabArrivalGuest, Me.xTabCheckoutGuest, Me.xTabCancelledFolio})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'xTabReservation
        '
        Me.xTabReservation.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabReservation.Appearance.Header.Options.UseFont = True
        Me.xTabReservation.Controls.Add(Me.guesttype)
        Me.xTabReservation.Controls.Add(Me.Em_Reservation)
        Me.xTabReservation.Name = "xTabReservation"
        Me.xTabReservation.Size = New System.Drawing.Size(1210, 398)
        Me.xTabReservation.Text = "Reservation List"
        '
        'xTabGuestList
        '
        Me.xTabGuestList.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabGuestList.Appearance.Header.Options.UseFont = True
        Me.xTabGuestList.Controls.Add(Me.Em_GuestList)
        Me.xTabGuestList.Name = "xTabGuestList"
        Me.xTabGuestList.Size = New System.Drawing.Size(1210, 398)
        Me.xTabGuestList.Text = "Current Guest List"
        '
        'xTabInhouseGuest
        '
        Me.xTabInhouseGuest.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabInhouseGuest.Appearance.Header.Options.UseFont = True
        Me.xTabInhouseGuest.Controls.Add(Me.Em_InHouse)
        Me.xTabInhouseGuest.Name = "xTabInhouseGuest"
        Me.xTabInhouseGuest.Size = New System.Drawing.Size(1210, 398)
        Me.xTabInhouseGuest.Text = "In-House Rooms"
        '
        'xTabArrivalGuest
        '
        Me.xTabArrivalGuest.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabArrivalGuest.Appearance.Header.Options.UseFont = True
        Me.xTabArrivalGuest.Controls.Add(Me.Em_TodayArrival)
        Me.xTabArrivalGuest.Name = "xTabArrivalGuest"
        Me.xTabArrivalGuest.Size = New System.Drawing.Size(1210, 398)
        Me.xTabArrivalGuest.Text = "Today Arrival"
        '
        'xTabCheckoutGuest
        '
        Me.xTabCheckoutGuest.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabCheckoutGuest.Appearance.Header.Options.UseFont = True
        Me.xTabCheckoutGuest.Controls.Add(Me.Em_closed)
        Me.xTabCheckoutGuest.Name = "xTabCheckoutGuest"
        Me.xTabCheckoutGuest.Size = New System.Drawing.Size(1210, 398)
        Me.xTabCheckoutGuest.Text = "Checkout Guest Folio"
        '
        'xTabCancelledFolio
        '
        Me.xTabCancelledFolio.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTabCancelledFolio.Appearance.Header.Options.UseFont = True
        Me.xTabCancelledFolio.Name = "xTabCancelledFolio"
        Me.xTabCancelledFolio.Size = New System.Drawing.Size(1210, 398)
        Me.xTabCancelledFolio.Text = "Cancelled Folio"
        '
        'frmHotelManagementv2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1232, 616)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(897, 585)
        Me.Name = "frmHotelManagementv2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Management"
        Me.cms_guestlist.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.Em_Reservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_reservation.ResumeLayout(False)
        CType(Me.GridView_Reservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_GuestList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_GuestList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_InHouse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_inhouse.ResumeLayout(False)
        CType(Me.GridView_InHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_TodayArrival, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_arival.ResumeLayout(False)
        CType(Me.GridView_TodayArrival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_closed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_closed.ResumeLayout(False)
        CType(Me.Gridview_closed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xTabReservation.ResumeLayout(False)
        Me.xTabReservation.PerformLayout()
        Me.xTabGuestList.ResumeLayout(False)
        Me.xTabInhouseGuest.ResumeLayout(False)
        Me.xTabArrivalGuest.ResumeLayout(False)
        Me.xTabCheckoutGuest.ResumeLayout(False)
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
    Friend WithEvents cms_guestlist As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents updates As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdRoomTariff As System.Windows.Forms.ToolStripButton
    Friend WithEvents linesummary As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdNewCheckinGuest As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdHotelSalesSummary As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtsearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProceedCheckin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdGuestManagement As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtStatusArrival As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatusForCheckout As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatusNoShow As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatusTitle As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatusInhouse As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Em_GuestList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_GuestList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Em_InHouse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_InHouse As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_TodayArrival As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_TodayArrival As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmd_inhouse As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_arival As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em_closed As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview_closed As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cms_closed As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em_Reservation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Reservation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents txtGuestType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cms_reservation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents guesttype As System.Windows.Forms.TextBox
    Friend WithEvents cmdRestoreCancelledFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xTabReservation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xTabGuestList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xTabInhouseGuest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xTabArrivalGuest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xTabCheckoutGuest As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xTabCancelledFolio As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdMergePayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRestoreCloseFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AttachementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAddAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
End Class
