<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomStatementLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelRoomStatementLedger))
        Me.txtDateCheckinOut = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdExtend = New System.Windows.Forms.ToolStripButton()
        Me.lineExtend = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCheckout = New System.Windows.Forms.ToolStripButton()
        Me.lineCheckOut = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintStatement = New System.Windows.Forms.ToolStripButton()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabConsolidated = New System.Windows.Forms.TabPage()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.txtCurrentCheckout = New System.Windows.Forms.DateTimePicker()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.ckPerRoom = New System.Windows.Forms.CheckBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_consolidated = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabRoomCharges = New System.Windows.Forms.TabPage()
        Me.Em_rooms = New DevExpress.XtraGrid.GridControl()
        Me.GridView_rooms = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabPOSTransaction = New System.Windows.Forms.TabPage()
        Me.Em_POS = New DevExpress.XtraGrid.GridControl()
        Me.GridView_POS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabPayment = New System.Windows.Forms.TabPage()
        Me.Em_Payment = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Payment = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabConsolidated.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_consolidated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomCharges.SuspendLayout()
        CType(Me.Em_rooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_rooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPOSTransaction.SuspendLayout()
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayment.SuspendLayout()
        CType(Me.Em_Payment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Payment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDateCheckinOut
        '
        Me.txtDateCheckinOut.BackColor = System.Drawing.Color.Transparent
        Me.txtDateCheckinOut.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateCheckinOut.ForeColor = System.Drawing.Color.Gray
        Me.txtDateCheckinOut.Location = New System.Drawing.Point(53, 28)
        Me.txtDateCheckinOut.Name = "txtDateCheckinOut"
        Me.txtDateCheckinOut.Size = New System.Drawing.Size(341, 15)
        Me.txtDateCheckinOut.TabIndex = 334
        '
        'txtGuest
        '
        Me.txtGuest.AutoSize = True
        Me.txtGuest.BackColor = System.Drawing.Color.Transparent
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtGuest.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtGuest.Location = New System.Drawing.Point(53, 9)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(246, 19)
        Me.txtGuest.TabIndex = 333
        Me.txtGuest.Text = "DOUBLE BED GOOD FOR 2 PERSONS"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdExtend, Me.lineExtend, Me.cmdCheckout, Me.lineCheckOut, Me.cmdPrintStatement})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(861, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdExtend
        '
        Me.cmdExtend.ForeColor = System.Drawing.Color.White
        Me.cmdExtend.Image = Global.CoffeecupClient.My.Resources.Resources.Time_Hot1
        Me.cmdExtend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExtend.Name = "cmdExtend"
        Me.cmdExtend.Size = New System.Drawing.Size(110, 24)
        Me.cmdExtend.Text = "Add Extra Night"
        '
        'lineExtend
        '
        Me.lineExtend.Name = "lineExtend"
        Me.lineExtend.Size = New System.Drawing.Size(6, 27)
        '
        'cmdCheckout
        '
        Me.cmdCheckout.ForeColor = System.Drawing.Color.White
        Me.cmdCheckout.Image = Global.CoffeecupClient.My.Resources.Resources.user__arrow
        Me.cmdCheckout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCheckout.Name = "cmdCheckout"
        Me.cmdCheckout.Size = New System.Drawing.Size(116, 24)
        Me.cmdCheckout.Text = "Check-out Guest"
        '
        'lineCheckOut
        '
        Me.lineCheckOut.Name = "lineCheckOut"
        Me.lineCheckOut.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrintStatement
        '
        Me.cmdPrintStatement.ForeColor = System.Drawing.Color.White
        Me.cmdPrintStatement.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.cmdPrintStatement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintStatement.Name = "cmdPrintStatement"
        Me.cmdPrintStatement.Size = New System.Drawing.Size(109, 24)
        Me.cmdPrintStatement.Text = "Print Statement"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Home_new
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.InitialImage = Global.CoffeecupClient.My.Resources.Resources.Home_new
        Me.picicon.Location = New System.Drawing.Point(13, 9)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(35, 33)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabConsolidated)
        Me.TabControl1.Controls.Add(Me.tabRoomCharges)
        Me.TabControl1.Controls.Add(Me.tabPOSTransaction)
        Me.TabControl1.Controls.Add(Me.tabPayment)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(11, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 424)
        Me.TabControl1.TabIndex = 822
        '
        'tabConsolidated
        '
        Me.tabConsolidated.Controls.Add(Me.foliono)
        Me.tabConsolidated.Controls.Add(Me.txtCurrentCheckout)
        Me.tabConsolidated.Controls.Add(Me.folioid)
        Me.tabConsolidated.Controls.Add(Me.ckPerRoom)
        Me.tabConsolidated.Controls.Add(Me.Em)
        Me.tabConsolidated.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tabConsolidated.Location = New System.Drawing.Point(4, 26)
        Me.tabConsolidated.Name = "tabConsolidated"
        Me.tabConsolidated.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsolidated.Size = New System.Drawing.Size(854, 394)
        Me.tabConsolidated.TabIndex = 0
        Me.tabConsolidated.Text = "Consolidated Ledger"
        Me.tabConsolidated.UseVisualStyleBackColor = True
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(538, 93)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(57, 23)
        Me.foliono.TabIndex = 828
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'txtCurrentCheckout
        '
        Me.txtCurrentCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtCurrentCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCurrentCheckout.Location = New System.Drawing.Point(538, 45)
        Me.txtCurrentCheckout.Name = "txtCurrentCheckout"
        Me.txtCurrentCheckout.Size = New System.Drawing.Size(141, 22)
        Me.txtCurrentCheckout.TabIndex = 827
        Me.txtCurrentCheckout.Visible = False
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(605, 93)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(57, 23)
        Me.folioid.TabIndex = 823
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'ckPerRoom
        '
        Me.ckPerRoom.AutoSize = True
        Me.ckPerRoom.Location = New System.Drawing.Point(670, 90)
        Me.ckPerRoom.Name = "ckPerRoom"
        Me.ckPerRoom.Size = New System.Drawing.Size(82, 17)
        Me.ckPerRoom.TabIndex = 824
        Me.ckPerRoom.Text = "CheckBox1"
        Me.ckPerRoom.UseVisualStyleBackColor = True
        Me.ckPerRoom.Visible = False
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(3, 3)
        Me.Em.MainView = Me.GridView_consolidated
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(848, 388)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_consolidated})
        '
        'GridView_consolidated
        '
        Me.GridView_consolidated.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_consolidated.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_consolidated.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_consolidated.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_consolidated.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_consolidated.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_consolidated.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_consolidated.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_consolidated.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_consolidated.Appearance.Row.Options.UseFont = True
        Me.GridView_consolidated.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_consolidated.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_consolidated.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_consolidated.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_consolidated.GridControl = Me.Em
        Me.GridView_consolidated.Name = "GridView_consolidated"
        Me.GridView_consolidated.OptionsBehavior.Editable = False
        Me.GridView_consolidated.OptionsSelection.MultiSelect = True
        Me.GridView_consolidated.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_consolidated.OptionsView.ColumnAutoWidth = False
        Me.GridView_consolidated.OptionsView.RowAutoHeight = True
        Me.GridView_consolidated.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'tabRoomCharges
        '
        Me.tabRoomCharges.Controls.Add(Me.Em_rooms)
        Me.tabRoomCharges.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tabRoomCharges.Location = New System.Drawing.Point(4, 26)
        Me.tabRoomCharges.Name = "tabRoomCharges"
        Me.tabRoomCharges.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRoomCharges.Size = New System.Drawing.Size(854, 394)
        Me.tabRoomCharges.TabIndex = 5
        Me.tabRoomCharges.Text = "Room Charges"
        Me.tabRoomCharges.UseVisualStyleBackColor = True
        '
        'Em_rooms
        '
        Me.Em_rooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_rooms.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_rooms.Location = New System.Drawing.Point(3, 3)
        Me.Em_rooms.MainView = Me.GridView_rooms
        Me.Em_rooms.Name = "Em_rooms"
        Me.Em_rooms.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_rooms.Size = New System.Drawing.Size(848, 388)
        Me.Em_rooms.TabIndex = 821
        Me.Em_rooms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_rooms})
        '
        'GridView_rooms
        '
        Me.GridView_rooms.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_rooms.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_rooms.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_rooms.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_rooms.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_rooms.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_rooms.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_rooms.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_rooms.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_rooms.Appearance.Row.Options.UseFont = True
        Me.GridView_rooms.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_rooms.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_rooms.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_rooms.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_rooms.GridControl = Me.Em_rooms
        Me.GridView_rooms.Name = "GridView_rooms"
        Me.GridView_rooms.OptionsBehavior.Editable = False
        Me.GridView_rooms.OptionsSelection.MultiSelect = True
        Me.GridView_rooms.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_rooms.OptionsView.ColumnAutoWidth = False
        Me.GridView_rooms.OptionsView.RowAutoHeight = True
        Me.GridView_rooms.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'tabPOSTransaction
        '
        Me.tabPOSTransaction.Controls.Add(Me.Em_POS)
        Me.tabPOSTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPOSTransaction.Location = New System.Drawing.Point(4, 26)
        Me.tabPOSTransaction.Name = "tabPOSTransaction"
        Me.tabPOSTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPOSTransaction.Size = New System.Drawing.Size(854, 394)
        Me.tabPOSTransaction.TabIndex = 6
        Me.tabPOSTransaction.Text = "POS Transaction"
        Me.tabPOSTransaction.UseVisualStyleBackColor = True
        '
        'Em_POS
        '
        Me.Em_POS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_POS.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_POS.Location = New System.Drawing.Point(3, 3)
        Me.Em_POS.MainView = Me.GridView_POS
        Me.Em_POS.Name = "Em_POS"
        Me.Em_POS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_POS.Size = New System.Drawing.Size(848, 388)
        Me.Em_POS.TabIndex = 822
        Me.Em_POS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_POS})
        '
        'GridView_POS
        '
        Me.GridView_POS.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_POS.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_POS.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_POS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_POS.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_POS.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_POS.Appearance.Row.Options.UseFont = True
        Me.GridView_POS.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_POS.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_POS.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_POS.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_POS.GridControl = Me.Em_POS
        Me.GridView_POS.Name = "GridView_POS"
        Me.GridView_POS.OptionsBehavior.Editable = False
        Me.GridView_POS.OptionsSelection.MultiSelect = True
        Me.GridView_POS.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_POS.OptionsView.ColumnAutoWidth = False
        Me.GridView_POS.OptionsView.RowAutoHeight = True
        Me.GridView_POS.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'tabPayment
        '
        Me.tabPayment.Controls.Add(Me.Em_Payment)
        Me.tabPayment.Location = New System.Drawing.Point(4, 26)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPayment.Size = New System.Drawing.Size(854, 394)
        Me.tabPayment.TabIndex = 7
        Me.tabPayment.Text = "Payment Transaction"
        Me.tabPayment.UseVisualStyleBackColor = True
        '
        'Em_Payment
        '
        Me.Em_Payment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Payment.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Payment.Location = New System.Drawing.Point(3, 3)
        Me.Em_Payment.MainView = Me.GridView_Payment
        Me.Em_Payment.Name = "Em_Payment"
        Me.Em_Payment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit4})
        Me.Em_Payment.Size = New System.Drawing.Size(848, 388)
        Me.Em_Payment.TabIndex = 824
        Me.Em_Payment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Payment})
        '
        'GridView_Payment
        '
        Me.GridView_Payment.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Payment.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Payment.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Payment.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Payment.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Payment.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Payment.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Payment.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Payment.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Payment.Appearance.Row.Options.UseFont = True
        Me.GridView_Payment.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Payment.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Payment.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Payment.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Payment.GridControl = Me.Em_Payment
        Me.GridView_Payment.Name = "GridView_Payment"
        Me.GridView_Payment.OptionsBehavior.Editable = False
        Me.GridView_Payment.OptionsSelection.MultiSelect = True
        Me.GridView_Payment.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Payment.OptionsView.ColumnAutoWidth = False
        Me.GridView_Payment.OptionsView.RowAutoHeight = True
        Me.GridView_Payment.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit4
        '
        Me.RepositoryItemPictureEdit4.Name = "RepositoryItemPictureEdit4"
        '
        'frmHotelRoomStatementLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 522)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtDateCheckinOut)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(901, 561)
        Me.Name = "frmHotelRoomStatementLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statement of Account"
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabConsolidated.ResumeLayout(False)
        Me.tabConsolidated.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_consolidated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomCharges.ResumeLayout(False)
        CType(Me.Em_rooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_rooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPOSTransaction.ResumeLayout(False)
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayment.ResumeLayout(False)
        CType(Me.Em_Payment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Payment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents txtDateCheckinOut As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdCheckout As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtGuest As System.Windows.Forms.Label
    Friend WithEvents lineCheckOut As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintStatement As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExtend As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineExtend As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabConsolidated As System.Windows.Forms.TabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_consolidated As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents tabRoomCharges As System.Windows.Forms.TabPage
    Friend WithEvents Em_rooms As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_rooms As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents tabPOSTransaction As System.Windows.Forms.TabPage
    Friend WithEvents Em_POS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_POS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents tabPayment As System.Windows.Forms.TabPage
    Friend WithEvents Em_Payment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Payment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ckPerRoom As System.Windows.Forms.CheckBox
    Friend WithEvents txtCurrentCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents foliono As System.Windows.Forms.TextBox
End Class
