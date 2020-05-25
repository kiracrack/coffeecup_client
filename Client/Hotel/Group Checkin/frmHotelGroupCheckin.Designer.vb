<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGroupCheckin
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelGroupCheckin))
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.cmdPickGuest = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.txtBookingNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSummary = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_summary = New System.Windows.Forms.DataGridView()
        Me.tabRoomInfo = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_room = New System.Windows.Forms.DataGridView()
        Me.cms_room = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabAddonInfo = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Addon = New System.Windows.Forms.DataGridView()
        Me.cms_addon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabCompanion = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Companion = New System.Windows.Forms.DataGridView()
        Me.cms_companion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabPayment = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_deposit = New System.Windows.Forms.DataGridView()
        Me.cms_deposit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.trntype = New System.Windows.Forms.TextBox()
        Me.agentid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdProceedCheckin = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtFlight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAgent = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.groupCheckin = New System.Windows.Forms.Panel()
        Me.groupBooking = New System.Windows.Forms.Panel()
        Me.cmdAmend = New System.Windows.Forms.Button()
        Me.cmdConfirmedBooking = New System.Windows.Forms.Button()
        Me.cmdSaveBooking = New System.Windows.Forms.Button()
        Me.ckCustomPackage = New System.Windows.Forms.CheckBox()
        Me.cmdPackages = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuestPreferences = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIncidental = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckConfirmed = New System.Windows.Forms.CheckBox()
        Me.txtTotalPackage = New System.Windows.Forms.TextBox()
        Me.cmdEditGuest = New System.Windows.Forms.Button()
        Me.cmdRoomAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProceedCheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRoomRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPackageBreakdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRoomRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddonAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddonEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddonRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddonRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAddnnewDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRefreshDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabSummary.SuspendLayout()
        CType(Me.MyDataGridView_summary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomInfo.SuspendLayout()
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_room.SuspendLayout()
        Me.tabAddonInfo.SuspendLayout()
        CType(Me.MyDataGridView_Addon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_addon.SuspendLayout()
        Me.tabCompanion.SuspendLayout()
        CType(Me.MyDataGridView_Companion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_companion.SuspendLayout()
        Me.tabPayment.SuspendLayout()
        CType(Me.MyDataGridView_deposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_deposit.SuspendLayout()
        Me.groupCheckin.SuspendLayout()
        Me.groupBooking.SuspendLayout()
        Me.SuspendLayout()
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(1249, 11)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(57, 23)
        Me.guestid.TabIndex = 410
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(38, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 437
        Me.Label13.Text = "Arival"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(79, 77)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(194, 22)
        Me.txtDateArival.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label20.Location = New System.Drawing.Point(576, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(170, 21)
        Me.Label20.TabIndex = 452
        Me.Label20.Text = "Folio Package Inclusion"
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(1227, 16)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(57, 23)
        Me.trnid.TabIndex = 723
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(304, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 744
        Me.Label2.Text = "Guest Name"
        '
        'txtGuest
        '
        Me.txtGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.Location = New System.Drawing.Point(378, 53)
        Me.txtGuest.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.Size = New System.Drawing.Size(159, 22)
        Me.txtGuest.TabIndex = 729
        '
        'cmdPickGuest
        '
        Me.cmdPickGuest.AutoSize = True
        Me.cmdPickGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPickGuest.Location = New System.Drawing.Point(294, 35)
        Me.cmdPickGuest.Name = "cmdPickGuest"
        Me.cmdPickGuest.Size = New System.Drawing.Size(167, 13)
        Me.cmdPickGuest.TabIndex = 740
        Me.cmdPickGuest.TabStop = True
        Me.cmdPickGuest.Text = "Select Guest ( F3 Search Guest )"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(31, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 21)
        Me.Label9.TabIndex = 739
        Me.Label9.Text = "Folio Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(14, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 746
        Me.Label14.Text = "Departure"
        '
        'txtdateCheckout
        '
        Me.txtdateCheckout.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateCheckout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateCheckout.Location = New System.Drawing.Point(79, 102)
        Me.txtdateCheckout.Name = "txtdateCheckout"
        Me.txtdateCheckout.Size = New System.Drawing.Size(194, 22)
        Me.txtdateCheckout.TabIndex = 2
        '
        'txtBookingNo
        '
        Me.txtBookingNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBookingNo.Font = New System.Drawing.Font("Segoe UI", 17.0!)
        Me.txtBookingNo.ForeColor = System.Drawing.Color.Black
        Me.txtBookingNo.Location = New System.Drawing.Point(79, 35)
        Me.txtBookingNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBookingNo.Name = "txtBookingNo"
        Me.txtBookingNo.ReadOnly = True
        Me.txtBookingNo.Size = New System.Drawing.Size(150, 38)
        Me.txtBookingNo.TabIndex = 756
        Me.txtBookingNo.Text = "KD022BR"
        Me.txtBookingNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(19, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 757
        Me.Label7.Text = "Folio No."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabSummary)
        Me.TabControl1.Controls.Add(Me.tabRoomInfo)
        Me.TabControl1.Controls.Add(Me.tabAddonInfo)
        Me.TabControl1.Controls.Add(Me.tabCompanion)
        Me.TabControl1.Controls.Add(Me.tabPayment)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(580, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(608, 344)
        Me.TabControl1.TabIndex = 761
        '
        'TabSummary
        '
        Me.TabSummary.Controls.Add(Me.MyDataGridView_summary)
        Me.TabSummary.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TabSummary.Location = New System.Drawing.Point(4, 26)
        Me.TabSummary.Name = "TabSummary"
        Me.TabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSummary.Size = New System.Drawing.Size(600, 314)
        Me.TabSummary.TabIndex = 5
        Me.TabSummary.Text = "Transaction Summary"
        Me.TabSummary.UseVisualStyleBackColor = True
        '
        'MyDataGridView_summary
        '
        Me.MyDataGridView_summary.AllowUserToAddRows = False
        Me.MyDataGridView_summary.AllowUserToDeleteRows = False
        Me.MyDataGridView_summary.AllowUserToResizeRows = False
        Me.MyDataGridView_summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_summary.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_summary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_summary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_summary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_summary.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_summary.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_summary.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_summary.MultiSelect = False
        Me.MyDataGridView_summary.Name = "MyDataGridView_summary"
        Me.MyDataGridView_summary.ReadOnly = True
        Me.MyDataGridView_summary.RowHeadersVisible = False
        Me.MyDataGridView_summary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_summary.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_summary.Size = New System.Drawing.Size(594, 308)
        Me.MyDataGridView_summary.TabIndex = 760
        '
        'tabRoomInfo
        '
        Me.tabRoomInfo.Controls.Add(Me.MyDataGridView_room)
        Me.tabRoomInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tabRoomInfo.Location = New System.Drawing.Point(4, 26)
        Me.tabRoomInfo.Name = "tabRoomInfo"
        Me.tabRoomInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRoomInfo.Size = New System.Drawing.Size(600, 314)
        Me.tabRoomInfo.TabIndex = 0
        Me.tabRoomInfo.Text = "Room Information"
        Me.tabRoomInfo.UseVisualStyleBackColor = True
        '
        'MyDataGridView_room
        '
        Me.MyDataGridView_room.AllowUserToAddRows = False
        Me.MyDataGridView_room.AllowUserToDeleteRows = False
        Me.MyDataGridView_room.AllowUserToResizeRows = False
        Me.MyDataGridView_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_room.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_room.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_room.ContextMenuStrip = Me.cms_room
        Me.MyDataGridView_room.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_room.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_room.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_room.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_room.MultiSelect = False
        Me.MyDataGridView_room.Name = "MyDataGridView_room"
        Me.MyDataGridView_room.ReadOnly = True
        Me.MyDataGridView_room.RowHeadersVisible = False
        Me.MyDataGridView_room.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_room.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_room.Size = New System.Drawing.Size(594, 308)
        Me.MyDataGridView_room.TabIndex = 759
        '
        'cms_room
        '
        Me.cms_room.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRoomAdd, Me.ProceedCheckinToolStripMenuItem, Me.cmdRoomRemove, Me.ViewPackageBreakdownToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdRoomRefresh})
        Me.cms_room.Name = "ContextMenuStrip1"
        Me.cms_room.Size = New System.Drawing.Size(209, 120)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'tabAddonInfo
        '
        Me.tabAddonInfo.Controls.Add(Me.MyDataGridView_Addon)
        Me.tabAddonInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabAddonInfo.Location = New System.Drawing.Point(4, 26)
        Me.tabAddonInfo.Name = "tabAddonInfo"
        Me.tabAddonInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddonInfo.Size = New System.Drawing.Size(600, 314)
        Me.tabAddonInfo.TabIndex = 1
        Me.tabAddonInfo.Text = "Add-on Services"
        Me.tabAddonInfo.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Addon
        '
        Me.MyDataGridView_Addon.AllowUserToAddRows = False
        Me.MyDataGridView_Addon.AllowUserToDeleteRows = False
        Me.MyDataGridView_Addon.AllowUserToResizeRows = False
        Me.MyDataGridView_Addon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Addon.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Addon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Addon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Addon.ContextMenuStrip = Me.cms_addon
        Me.MyDataGridView_Addon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Addon.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Addon.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Addon.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Addon.MultiSelect = False
        Me.MyDataGridView_Addon.Name = "MyDataGridView_Addon"
        Me.MyDataGridView_Addon.ReadOnly = True
        Me.MyDataGridView_Addon.RowHeadersVisible = False
        Me.MyDataGridView_Addon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Addon.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView_Addon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Addon.Size = New System.Drawing.Size(594, 308)
        Me.MyDataGridView_Addon.TabIndex = 760
        '
        'cms_addon
        '
        Me.cms_addon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddonAdd, Me.cmdAddonEdit, Me.cmdAddonRemove, Me.ToolStripSeparator4, Me.cmdAddonRefresh})
        Me.cms_addon.Name = "ContextMenuStrip1"
        Me.cms_addon.Size = New System.Drawing.Size(157, 98)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(153, 6)
        '
        'tabCompanion
        '
        Me.tabCompanion.Controls.Add(Me.MyDataGridView_Companion)
        Me.tabCompanion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCompanion.Location = New System.Drawing.Point(4, 26)
        Me.tabCompanion.Name = "tabCompanion"
        Me.tabCompanion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompanion.Size = New System.Drawing.Size(600, 314)
        Me.tabCompanion.TabIndex = 3
        Me.tabCompanion.Text = "Guest Companion"
        Me.tabCompanion.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Companion
        '
        Me.MyDataGridView_Companion.AllowUserToAddRows = False
        Me.MyDataGridView_Companion.AllowUserToDeleteRows = False
        Me.MyDataGridView_Companion.AllowUserToResizeRows = False
        Me.MyDataGridView_Companion.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Companion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Companion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Companion.ContextMenuStrip = Me.cms_companion
        Me.MyDataGridView_Companion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Companion.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Companion.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Companion.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Companion.MultiSelect = False
        Me.MyDataGridView_Companion.Name = "MyDataGridView_Companion"
        Me.MyDataGridView_Companion.ReadOnly = True
        Me.MyDataGridView_Companion.RowHeadersVisible = False
        Me.MyDataGridView_Companion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Companion.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGridView_Companion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Companion.Size = New System.Drawing.Size(594, 308)
        Me.MyDataGridView_Companion.TabIndex = 760
        '
        'cms_companion
        '
        Me.cms_companion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddCompanion, Me.cmdEditCompanion, Me.cmdRemoveCompanion, Me.ToolStripSeparator2, Me.cmdRefreshCompanion})
        Me.cms_companion.Name = "ContextMenuStrip1"
        Me.cms_companion.Size = New System.Drawing.Size(165, 98)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'tabPayment
        '
        Me.tabPayment.Controls.Add(Me.MyDataGridView_deposit)
        Me.tabPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPayment.Location = New System.Drawing.Point(4, 26)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPayment.Size = New System.Drawing.Size(600, 314)
        Me.tabPayment.TabIndex = 4
        Me.tabPayment.Text = "Payment Deposit"
        Me.tabPayment.UseVisualStyleBackColor = True
        '
        'MyDataGridView_deposit
        '
        Me.MyDataGridView_deposit.AllowUserToAddRows = False
        Me.MyDataGridView_deposit.AllowUserToDeleteRows = False
        Me.MyDataGridView_deposit.AllowUserToResizeRows = False
        Me.MyDataGridView_deposit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_deposit.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_deposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_deposit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_deposit.ContextMenuStrip = Me.cms_deposit
        Me.MyDataGridView_deposit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_deposit.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_deposit.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_deposit.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_deposit.MultiSelect = False
        Me.MyDataGridView_deposit.Name = "MyDataGridView_deposit"
        Me.MyDataGridView_deposit.ReadOnly = True
        Me.MyDataGridView_deposit.RowHeadersVisible = False
        Me.MyDataGridView_deposit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_deposit.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MyDataGridView_deposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_deposit.Size = New System.Drawing.Size(594, 308)
        Me.MyDataGridView_deposit.TabIndex = 761
        '
        'cms_deposit
        '
        Me.cms_deposit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddnnewDeposit, Me.cmdEditDeposit, Me.cmdRemoveDeposit, Me.ToolStripSeparator3, Me.cmdRefreshDeposit})
        Me.cms_deposit.Name = "ContextMenuStrip1"
        Me.cms_deposit.Size = New System.Drawing.Size(165, 98)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'trntype
        '
        Me.trntype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trntype.ForeColor = System.Drawing.Color.Black
        Me.trntype.Location = New System.Drawing.Point(1188, 68)
        Me.trntype.Margin = New System.Windows.Forms.Padding(5)
        Me.trntype.Name = "trntype"
        Me.trntype.Size = New System.Drawing.Size(57, 23)
        Me.trntype.TabIndex = 799
        Me.trntype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trntype.Visible = False
        '
        'agentid
        '
        Me.agentid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.agentid.ForeColor = System.Drawing.Color.Black
        Me.agentid.Location = New System.Drawing.Point(1249, 39)
        Me.agentid.Margin = New System.Windows.Forms.Padding(5)
        Me.agentid.Name = "agentid"
        Me.agentid.Size = New System.Drawing.Size(57, 23)
        Me.agentid.TabIndex = 794
        Me.agentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.agentid.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(1188, 11)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(57, 23)
        Me.mode.TabIndex = 795
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(72, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 766
        Me.Label18.Text = "Total Package"
        '
        'cmdProceedCheckin
        '
        Me.cmdProceedCheckin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdProceedCheckin.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceedCheckin.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdProceedCheckin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceedCheckin.Location = New System.Drawing.Point(271, 7)
        Me.cmdProceedCheckin.Name = "cmdProceedCheckin"
        Me.cmdProceedCheckin.Size = New System.Drawing.Size(134, 32)
        Me.cmdProceedCheckin.TabIndex = 779
        Me.cmdProceedCheckin.Text = "Proceed Checkin"
        Me.cmdProceedCheckin.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.BackColor = System.Drawing.Color.Khaki
        Me.cmdEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEdit.Location = New System.Drawing.Point(141, 7)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(128, 32)
        Me.cmdEdit.TabIndex = 785
        Me.cmdEdit.Text = "Amend"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'txtFlight
        '
        Me.txtFlight.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFlight.ForeColor = System.Drawing.Color.Black
        Me.txtFlight.Location = New System.Drawing.Point(98, 233)
        Me.txtFlight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFlight.Name = "txtFlight"
        Me.txtFlight.Size = New System.Drawing.Size(174, 22)
        Me.txtFlight.TabIndex = 788
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(54, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 789
        Me.Label1.Text = "Flight"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(98, 257)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(174, 22)
        Me.txtRemarks.TabIndex = 786
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(41, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 787
        Me.Label3.Text = "Remarks"
        '
        'txtAgent
        '
        Me.txtAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtAgent.DropDownHeight = 130
        Me.txtAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAgent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAgent.ForeColor = System.Drawing.Color.Black
        Me.txtAgent.FormattingEnabled = True
        Me.txtAgent.IntegralHeight = False
        Me.txtAgent.ItemHeight = 13
        Me.txtAgent.Location = New System.Drawing.Point(98, 281)
        Me.txtAgent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgent.MaxDropDownItems = 7
        Me.txtAgent.Name = "txtAgent"
        Me.txtAgent.Size = New System.Drawing.Size(174, 21)
        Me.txtAgent.TabIndex = 792
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LinkLabel1.Location = New System.Drawing.Point(53, 283)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 13)
        Me.LinkLabel1.TabIndex = 793
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Agent"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdExit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExit.Location = New System.Drawing.Point(786, 419)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(103, 32)
        Me.cmdExit.TabIndex = 799
        Me.cmdExit.Text = "Done"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'txtCountry
        '
        Me.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCountry.ForeColor = System.Drawing.Color.Black
        Me.txtCountry.Location = New System.Drawing.Point(378, 77)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(159, 22)
        Me.txtCountry.TabIndex = 819
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(325, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 820
        Me.Label27.Text = "Country"
        '
        'txtGender
        '
        Me.txtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGender.ForeColor = System.Drawing.Color.Black
        Me.txtGender.Location = New System.Drawing.Point(378, 149)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(62, 22)
        Me.txtGender.TabIndex = 817
        '
        'txtNationality
        '
        Me.txtNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNationality.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNationality.ForeColor = System.Drawing.Color.Black
        Me.txtNationality.Location = New System.Drawing.Point(378, 173)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.ReadOnly = True
        Me.txtNationality.Size = New System.Drawing.Size(159, 22)
        Me.txtNationality.TabIndex = 816
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBirthdate.ForeColor = System.Drawing.Color.Black
        Me.txtBirthdate.Location = New System.Drawing.Point(378, 125)
        Me.txtBirthdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.ReadOnly = True
        Me.txtBirthdate.Size = New System.Drawing.Size(159, 22)
        Me.txtBirthdate.TabIndex = 815
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(378, 221)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(159, 22)
        Me.txtEmail.TabIndex = 808
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(339, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 814
        Me.Label12.Text = "Email"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(310, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 813
        Me.Label15.Text = "Nationality"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(328, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 812
        Me.Label17.Text = "Gender"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(314, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 811
        Me.Label21.Text = "Birth Date"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(378, 197)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(159, 22)
        Me.txtContactNumber.TabIndex = 807
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(282, 201)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 13)
        Me.Label23.TabIndex = 810
        Me.Label23.Text = "Contact Number"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(378, 101)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(159, 22)
        Me.txtAddress.TabIndex = 806
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTransaction.Location = New System.Drawing.Point(325, 105)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(48, 13)
        Me.lblTransaction.TabIndex = 809
        Me.lblTransaction.Text = "Address"
        '
        'groupCheckin
        '
        Me.groupCheckin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.groupCheckin.Controls.Add(Me.cmdProceedCheckin)
        Me.groupCheckin.Controls.Add(Me.cmdEdit)
        Me.groupCheckin.Location = New System.Drawing.Point(268, 412)
        Me.groupCheckin.Name = "groupCheckin"
        Me.groupCheckin.Size = New System.Drawing.Size(408, 47)
        Me.groupCheckin.TabIndex = 821
        '
        'groupBooking
        '
        Me.groupBooking.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.groupBooking.Controls.Add(Me.cmdAmend)
        Me.groupBooking.Controls.Add(Me.cmdConfirmedBooking)
        Me.groupBooking.Controls.Add(Me.cmdSaveBooking)
        Me.groupBooking.Location = New System.Drawing.Point(268, 412)
        Me.groupBooking.Name = "groupBooking"
        Me.groupBooking.Size = New System.Drawing.Size(408, 47)
        Me.groupBooking.TabIndex = 822
        '
        'cmdAmend
        '
        Me.cmdAmend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAmend.BackColor = System.Drawing.Color.Khaki
        Me.cmdAmend.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdAmend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAmend.Location = New System.Drawing.Point(20, 7)
        Me.cmdAmend.Name = "cmdAmend"
        Me.cmdAmend.Size = New System.Drawing.Size(125, 32)
        Me.cmdAmend.TabIndex = 786
        Me.cmdAmend.Text = "Amend Booking"
        Me.cmdAmend.UseVisualStyleBackColor = False
        '
        'cmdConfirmedBooking
        '
        Me.cmdConfirmedBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirmedBooking.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmedBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdConfirmedBooking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmedBooking.Location = New System.Drawing.Point(274, 7)
        Me.cmdConfirmedBooking.Name = "cmdConfirmedBooking"
        Me.cmdConfirmedBooking.Size = New System.Drawing.Size(131, 32)
        Me.cmdConfirmedBooking.TabIndex = 779
        Me.cmdConfirmedBooking.Text = "Confirm Booking"
        Me.cmdConfirmedBooking.UseVisualStyleBackColor = False
        '
        'cmdSaveBooking
        '
        Me.cmdSaveBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveBooking.BackColor = System.Drawing.Color.Khaki
        Me.cmdSaveBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdSaveBooking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSaveBooking.Location = New System.Drawing.Point(147, 7)
        Me.cmdSaveBooking.Name = "cmdSaveBooking"
        Me.cmdSaveBooking.Size = New System.Drawing.Size(125, 32)
        Me.cmdSaveBooking.TabIndex = 785
        Me.cmdSaveBooking.Text = "Tentative Booking"
        Me.cmdSaveBooking.UseVisualStyleBackColor = False
        '
        'ckCustomPackage
        '
        Me.ckCustomPackage.AutoSize = True
        Me.ckCustomPackage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckCustomPackage.Location = New System.Drawing.Point(79, 131)
        Me.ckCustomPackage.Name = "ckCustomPackage"
        Me.ckCustomPackage.Size = New System.Drawing.Size(136, 19)
        Me.ckCustomPackage.TabIndex = 823
        Me.ckCustomPackage.Text = "Customized Package"
        Me.ckCustomPackage.UseVisualStyleBackColor = True
        '
        'cmdPackages
        '
        Me.cmdPackages.Enabled = False
        Me.cmdPackages.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPackages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPackages.Location = New System.Drawing.Point(79, 150)
        Me.cmdPackages.Name = "cmdPackages"
        Me.cmdPackages.Size = New System.Drawing.Size(194, 31)
        Me.cmdPackages.TabIndex = 824
        Me.cmdPackages.Text = "Create Custom Package"
        Me.cmdPackages.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(283, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 827
        Me.Label4.Text = "Guest Preferences"
        '
        'txtGuestPreferences
        '
        Me.txtGuestPreferences.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGuestPreferences.ForeColor = System.Drawing.Color.Black
        Me.txtGuestPreferences.Location = New System.Drawing.Point(286, 269)
        Me.txtGuestPreferences.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuestPreferences.Multiline = True
        Me.txtGuestPreferences.Name = "txtGuestPreferences"
        Me.txtGuestPreferences.ReadOnly = True
        Me.txtGuestPreferences.Size = New System.Drawing.Size(285, 110)
        Me.txtGuestPreferences.TabIndex = 826
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(680, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 32)
        Me.Button1.TabIndex = 828
        Me.Button1.Text = "Print Folio"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(46, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 830
        Me.Label5.Text = "Incidental Deposit"
        '
        'txtIncidental
        '
        Me.txtIncidental.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIncidental.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIncidental.ForeColor = System.Drawing.Color.Black
        Me.txtIncidental.Location = New System.Drawing.Point(153, 209)
        Me.txtIncidental.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIncidental.Name = "txtIncidental"
        Me.txtIncidental.Size = New System.Drawing.Size(119, 22)
        Me.txtIncidental.TabIndex = 829
        Me.txtIncidental.Text = "0.00"
        Me.txtIncidental.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(291, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 21)
        Me.Label6.TabIndex = 831
        Me.Label6.Text = "Guest Information"
        '
        'ckConfirmed
        '
        Me.ckConfirmed.AutoSize = True
        Me.ckConfirmed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckConfirmed.Location = New System.Drawing.Point(98, 309)
        Me.ckConfirmed.Name = "ckConfirmed"
        Me.ckConfirmed.Size = New System.Drawing.Size(83, 19)
        Me.ckConfirmed.TabIndex = 832
        Me.ckConfirmed.Text = "Confirmed"
        Me.ckConfirmed.UseVisualStyleBackColor = True
        Me.ckConfirmed.Visible = False
        '
        'txtTotalPackage
        '
        Me.txtTotalPackage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPackage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalPackage.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPackage.Location = New System.Drawing.Point(153, 185)
        Me.txtTotalPackage.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalPackage.Name = "txtTotalPackage"
        Me.txtTotalPackage.ReadOnly = True
        Me.txtTotalPackage.Size = New System.Drawing.Size(119, 22)
        Me.txtTotalPackage.TabIndex = 765
        Me.txtTotalPackage.Text = "0.00"
        Me.txtTotalPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdEditGuest
        '
        Me.cmdEditGuest.Image = Global.CoffeecupClient.My.Resources.Resources.user__pencil
        Me.cmdEditGuest.Location = New System.Drawing.Point(540, 53)
        Me.cmdEditGuest.Name = "cmdEditGuest"
        Me.cmdEditGuest.Size = New System.Drawing.Size(31, 46)
        Me.cmdEditGuest.TabIndex = 825
        Me.cmdEditGuest.UseVisualStyleBackColor = True
        Me.cmdEditGuest.Visible = False
        '
        'cmdRoomAdd
        '
        Me.cmdRoomAdd.Image = Global.CoffeecupClient.My.Resources.Resources.home__plus
        Me.cmdRoomAdd.Name = "cmdRoomAdd"
        Me.cmdRoomAdd.Size = New System.Drawing.Size(208, 22)
        Me.cmdRoomAdd.Text = "Room Selection"
        '
        'ProceedCheckinToolStripMenuItem
        '
        Me.ProceedCheckinToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow1
        Me.ProceedCheckinToolStripMenuItem.Name = "ProceedCheckinToolStripMenuItem"
        Me.ProceedCheckinToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ProceedCheckinToolStripMenuItem.Text = "Proceed Check-in"
        '
        'cmdRoomRemove
        '
        Me.cmdRoomRemove.Image = Global.CoffeecupClient.My.Resources.Resources.home__minus
        Me.cmdRoomRemove.Name = "cmdRoomRemove"
        Me.cmdRoomRemove.Size = New System.Drawing.Size(208, 22)
        Me.cmdRoomRemove.Text = "Remove Rooms"
        '
        'ViewPackageBreakdownToolStripMenuItem
        '
        Me.ViewPackageBreakdownToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ViewPackageBreakdownToolStripMenuItem.Name = "ViewPackageBreakdownToolStripMenuItem"
        Me.ViewPackageBreakdownToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ViewPackageBreakdownToolStripMenuItem.Text = "View Package Breakdown"
        '
        'cmdRoomRefresh
        '
        Me.cmdRoomRefresh.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRoomRefresh.Name = "cmdRoomRefresh"
        Me.cmdRoomRefresh.Size = New System.Drawing.Size(208, 22)
        Me.cmdRoomRefresh.Tag = "1"
        Me.cmdRoomRefresh.Text = "Refresh Data"
        '
        'cmdAddonAdd
        '
        Me.cmdAddonAdd.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddonAdd.Name = "cmdAddonAdd"
        Me.cmdAddonAdd.Size = New System.Drawing.Size(156, 22)
        Me.cmdAddonAdd.Text = "Add Addon"
        '
        'cmdAddonEdit
        '
        Me.cmdAddonEdit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdAddonEdit.Name = "cmdAddonEdit"
        Me.cmdAddonEdit.Size = New System.Drawing.Size(156, 22)
        Me.cmdAddonEdit.Text = "Edit Addon"
        '
        'cmdAddonRemove
        '
        Me.cmdAddonRemove.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdAddonRemove.Name = "cmdAddonRemove"
        Me.cmdAddonRemove.Size = New System.Drawing.Size(156, 22)
        Me.cmdAddonRemove.Text = "Remove Addon"
        '
        'cmdAddonRefresh
        '
        Me.cmdAddonRefresh.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdAddonRefresh.Name = "cmdAddonRefresh"
        Me.cmdAddonRefresh.Size = New System.Drawing.Size(156, 22)
        Me.cmdAddonRefresh.Tag = "1"
        Me.cmdAddonRefresh.Text = "Refresh Data"
        '
        'cmdAddCompanion
        '
        Me.cmdAddCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddCompanion.Name = "cmdAddCompanion"
        Me.cmdAddCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdAddCompanion.Text = "Add New"
        '
        'cmdEditCompanion
        '
        Me.cmdEditCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditCompanion.Name = "cmdEditCompanion"
        Me.cmdEditCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdEditCompanion.Text = "Edit Selected"
        '
        'cmdRemoveCompanion
        '
        Me.cmdRemoveCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveCompanion.Name = "cmdRemoveCompanion"
        Me.cmdRemoveCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRemoveCompanion.Text = "Remove Selected"
        '
        'cmdRefreshCompanion
        '
        Me.cmdRefreshCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshCompanion.Name = "cmdRefreshCompanion"
        Me.cmdRefreshCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRefreshCompanion.Tag = "1"
        Me.cmdRefreshCompanion.Text = "Refresh Data"
        '
        'cmdAddnnewDeposit
        '
        Me.cmdAddnnewDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddnnewDeposit.Name = "cmdAddnnewDeposit"
        Me.cmdAddnnewDeposit.Size = New System.Drawing.Size(164, 22)
        Me.cmdAddnnewDeposit.Text = "Add New"
        '
        'cmdEditDeposit
        '
        Me.cmdEditDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditDeposit.Name = "cmdEditDeposit"
        Me.cmdEditDeposit.Size = New System.Drawing.Size(164, 22)
        Me.cmdEditDeposit.Text = "Edit Selected"
        '
        'cmdRemoveDeposit
        '
        Me.cmdRemoveDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveDeposit.Name = "cmdRemoveDeposit"
        Me.cmdRemoveDeposit.Size = New System.Drawing.Size(164, 22)
        Me.cmdRemoveDeposit.Text = "Remove Selected"
        '
        'cmdRefreshDeposit
        '
        Me.cmdRefreshDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshDeposit.Name = "cmdRefreshDeposit"
        Me.cmdRefreshDeposit.Size = New System.Drawing.Size(164, 22)
        Me.cmdRefreshDeposit.Tag = "1"
        Me.cmdRefreshDeposit.Text = "Refresh Data"
        '
        'frmHotelGroupCheckin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 474)
        Me.Controls.Add(Me.ckConfirmed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIncidental)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGuestPreferences)
        Me.Controls.Add(Me.cmdEditGuest)
        Me.Controls.Add(Me.trntype)
        Me.Controls.Add(Me.cmdPackages)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.ckCustomPackage)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.agentid)
        Me.Controls.Add(Me.txtBirthdate)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtAgent)
        Me.Controls.Add(Me.txtFlight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtTotalPackage)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBookingNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtdateCheckout)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.cmdPickGuest)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.groupCheckin)
        Me.Controls.Add(Me.groupBooking)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1135, 513)
        Me.Name = "frmHotelGroupCheckin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Checkin Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabSummary.ResumeLayout(False)
        CType(Me.MyDataGridView_summary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomInfo.ResumeLayout(False)
        CType(Me.MyDataGridView_room, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_room.ResumeLayout(False)
        Me.tabAddonInfo.ResumeLayout(False)
        CType(Me.MyDataGridView_Addon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_addon.ResumeLayout(False)
        Me.tabCompanion.ResumeLayout(False)
        CType(Me.MyDataGridView_Companion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_companion.ResumeLayout(False)
        Me.tabPayment.ResumeLayout(False)
        CType(Me.MyDataGridView_deposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_deposit.ResumeLayout(False)
        Me.groupCheckin.ResumeLayout(False)
        Me.groupBooking.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents cmdPickGuest As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtdateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBookingNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRoomInfo As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_room As System.Windows.Forms.DataGridView
    Friend WithEvents tabAddonInfo As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Addon As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdProceedCheckin As System.Windows.Forms.Button
    Friend WithEvents cms_addon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddonAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAddonRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAddonRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_room As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRoomAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRoomRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRoomRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAddonEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents txtFlight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAgent As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents agentid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents tabCompanion As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Companion As System.Windows.Forms.DataGridView
    Friend WithEvents cms_companion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthdate As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents groupCheckin As System.Windows.Forms.Panel
    Friend WithEvents trntype As System.Windows.Forms.TextBox
    Friend WithEvents groupBooking As System.Windows.Forms.Panel
    Friend WithEvents cmdAmend As System.Windows.Forms.Button
    Friend WithEvents cmdConfirmedBooking As System.Windows.Forms.Button
    Friend WithEvents cmdSaveBooking As System.Windows.Forms.Button
    Friend WithEvents ckCustomPackage As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPackages As System.Windows.Forms.Button
    Friend WithEvents ProceedCheckinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabPayment As System.Windows.Forms.TabPage
    Friend WithEvents cms_deposit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddnnewDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView_deposit As System.Windows.Forms.DataGridView
    Friend WithEvents cmdEditGuest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuestPreferences As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIncidental As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckConfirmed As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalPackage As System.Windows.Forms.TextBox
    Friend WithEvents TabSummary As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_summary As System.Windows.Forms.DataGridView
    Friend WithEvents ViewPackageBreakdownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
