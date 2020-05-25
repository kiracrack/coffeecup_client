<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCheckInTransactionV2
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
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblResNo = New System.Windows.Forms.Label()
        Me.cmdPickGuest = New System.Windows.Forms.LinkLabel()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.TextBox()
        Me.txtNationality = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtPlateNumber = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.agentid = New System.Windows.Forms.TextBox()
        Me.cmdTypeofAgent = New System.Windows.Forms.LinkLabel()
        Me.txtAgent = New System.Windows.Forms.ComboBox()
        Me.txtFlight = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabRoomCharge = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cms_room = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddNewRoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRoomAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdProceedCheckin = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCheckout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRestoreUncheckOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdChangeRoomChargeType = New System.Windows.Forms.ToolStripMenuItem()
        Me.lineCheckout = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRoomUpgrade = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewRoomInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRoomStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditRoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRoomRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.lineCompanion = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRoomAddCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdMergePayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRoomRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Room = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.ckClose = New System.Windows.Forms.CheckBox()
        Me.guestType = New System.Windows.Forms.TextBox()
        Me.txtCurrentDeparture = New System.Windows.Forms.DateTimePicker()
        Me.txtCurrentArrival = New System.Windows.Forms.DateTimePicker()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.cancelled = New System.Windows.Forms.CheckBox()
        Me.tabRoomSummary = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Summary = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Summary = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabPos = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_POS = New DevExpress.XtraGrid.GridControl()
        Me.GridView_POS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabDiscount = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Discount = New DevExpress.XtraGrid.GridControl()
        Me.cms_discount = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEditDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshDiscount = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Discount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabPaymentTransaction = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Payment = New DevExpress.XtraGrid.GridControl()
        Me.cms_deposit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddnnewDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Payment = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabGuestCompanion = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Companion = New DevExpress.XtraGrid.GridControl()
        Me.cms_companion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Companion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabFolioAudittrail = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_audittrail = New DevExpress.XtraGrid.GridControl()
        Me.cmd_audittrail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grid_auditTrail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabposcash = New DevExpress.XtraTab.XtraTabPage()
        Me.grpGuest = New System.Windows.Forms.GroupBox()
        Me.txtRatings = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtGuestPreferences = New System.Windows.Forms.TextBox()
        Me.cmdPreviousTransaction = New System.Windows.Forms.LinkLabel()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.cmdEditGuest = New System.Windows.Forms.Button()
        Me.grpFolio = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtGuestType = New System.Windows.Forms.ComboBox()
        Me.cmdTypeofGuest = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDeparture = New System.Windows.Forms.DateTimePicker()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.txtTotalDiscounts = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalPayments = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotalCharges = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalFolioPayment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalRoomPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalPOS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalRoomCharge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.lineClose = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSaveFolio = New System.Windows.Forms.ToolStripButton()
        Me.lineSave = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConfirmReservation = New System.Windows.Forms.ToolStripButton()
        Me.lineReservation = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.cmdPrintGuestFolio = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdConsolidatedMasterFolio = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrintMainFolio = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrintTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEmailNotification = New System.Windows.Forms.ToolStripMenuItem()
        Me.lineGuestFolio = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPayment = New System.Windows.Forms.ToolStripButton()
        Me.linePostPayment = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChargeToClientAccount = New System.Windows.Forms.ToolStripButton()
        Me.lineChargeToClientAccount = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCloseTransaction = New System.Windows.Forms.ToolStripButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Em_Cash = New DevExpress.XtraGrid.GridControl()
        Me.GridView_cash = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabRoomCharge.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_room.SuspendLayout()
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomSummary.SuspendLayout()
        CType(Me.Em_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPos.SuspendLayout()
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDiscount.SuspendLayout()
        CType(Me.Em_Discount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_discount.SuspendLayout()
        CType(Me.GridView_Discount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaymentTransaction.SuspendLayout()
        CType(Me.Em_Payment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_deposit.SuspendLayout()
        CType(Me.GridView_Payment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGuestCompanion.SuspendLayout()
        CType(Me.Em_Companion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_companion.SuspendLayout()
        CType(Me.GridView_Companion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFolioAudittrail.SuspendLayout()
        CType(Me.Em_audittrail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmd_audittrail.SuspendLayout()
        CType(Me.grid_auditTrail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabposcash.SuspendLayout()
        Me.grpGuest.SuspendLayout()
        Me.grpFolio.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.Em_Cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTransaction.Location = New System.Drawing.Point(39, 120)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(48, 13)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(93, 116)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(223, 22)
        Me.txtAddress.TabIndex = 1
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(93, 212)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(223, 22)
        Me.txtContactNumber.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(19, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Contact No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(28, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 417
        Me.Label3.Text = "Birth Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(42, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 419
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(24, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Nationality"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(93, 236)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(223, 22)
        Me.txtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(53, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "Email"
        '
        'lblResNo
        '
        Me.lblResNo.AutoSize = True
        Me.lblResNo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblResNo.Location = New System.Drawing.Point(13, 48)
        Me.lblResNo.Name = "lblResNo"
        Me.lblResNo.Size = New System.Drawing.Size(77, 13)
        Me.lblResNo.TabIndex = 425
        Me.lblResNo.Text = "Folio Number"
        Me.lblResNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdPickGuest
        '
        Me.cmdPickGuest.AutoSize = True
        Me.cmdPickGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPickGuest.Location = New System.Drawing.Point(92, 17)
        Me.cmdPickGuest.Name = "cmdPickGuest"
        Me.cmdPickGuest.Size = New System.Drawing.Size(216, 13)
        Me.cmdPickGuest.TabIndex = 473
        Me.cmdPickGuest.TabStop = True
        Me.cmdPickGuest.Text = "Select From Guest List ( F3 Search Guest )"
        '
        'txtGuest
        '
        Me.txtGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.Location = New System.Drawing.Point(93, 68)
        Me.txtGuest.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.Size = New System.Drawing.Size(223, 22)
        Me.txtGuest.TabIndex = 1
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBirthdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBirthdate.ForeColor = System.Drawing.Color.Black
        Me.txtBirthdate.Location = New System.Drawing.Point(93, 140)
        Me.txtBirthdate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.ReadOnly = True
        Me.txtBirthdate.Size = New System.Drawing.Size(223, 22)
        Me.txtBirthdate.TabIndex = 475
        '
        'txtNationality
        '
        Me.txtNationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNationality.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNationality.ForeColor = System.Drawing.Color.Black
        Me.txtNationality.Location = New System.Drawing.Point(93, 188)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.ReadOnly = True
        Me.txtNationality.Size = New System.Drawing.Size(223, 22)
        Me.txtNationality.TabIndex = 476
        '
        'txtGender
        '
        Me.txtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGender.ForeColor = System.Drawing.Color.Black
        Me.txtGender.Location = New System.Drawing.Point(93, 164)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(122, 22)
        Me.txtGender.TabIndex = 477
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(18, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 478
        Me.Label2.Text = "Guest Name"
        '
        'txtRemarks
        '
        Me.txtRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(2, 24)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(242, 196)
        Me.txtRemarks.TabIndex = 18
        '
        'txtPlateNumber
        '
        Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPlateNumber.ForeColor = System.Drawing.Color.Black
        Me.txtPlateNumber.Location = New System.Drawing.Point(97, 148)
        Me.txtPlateNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPlateNumber.Name = "txtPlateNumber"
        Me.txtPlateNumber.Size = New System.Drawing.Size(225, 22)
        Me.txtPlateNumber.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(14, 153)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 482
        Me.Label22.Text = "Plate Number"
        '
        'txtCountry
        '
        Me.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountry.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCountry.ForeColor = System.Drawing.Color.Black
        Me.txtCountry.Location = New System.Drawing.Point(93, 92)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.ReadOnly = True
        Me.txtCountry.Size = New System.Drawing.Size(223, 22)
        Me.txtCountry.TabIndex = 493
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(39, 96)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 13)
        Me.Label27.TabIndex = 494
        Me.Label27.Text = "Country"
        '
        'agentid
        '
        Me.agentid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.agentid.ForeColor = System.Drawing.Color.Black
        Me.agentid.Location = New System.Drawing.Point(945, 92)
        Me.agentid.Margin = New System.Windows.Forms.Padding(5)
        Me.agentid.Name = "agentid"
        Me.agentid.Size = New System.Drawing.Size(19, 23)
        Me.agentid.TabIndex = 807
        Me.agentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.agentid.Visible = False
        '
        'cmdTypeofAgent
        '
        Me.cmdTypeofAgent.AutoSize = True
        Me.cmdTypeofAgent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdTypeofAgent.Location = New System.Drawing.Point(52, 201)
        Me.cmdTypeofAgent.Name = "cmdTypeofAgent"
        Me.cmdTypeofAgent.Size = New System.Drawing.Size(38, 13)
        Me.cmdTypeofAgent.TabIndex = 806
        Me.cmdTypeofAgent.TabStop = True
        Me.cmdTypeofAgent.Text = "Agent"
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
        Me.txtAgent.Location = New System.Drawing.Point(97, 198)
        Me.txtAgent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgent.MaxDropDownItems = 7
        Me.txtAgent.Name = "txtAgent"
        Me.txtAgent.Size = New System.Drawing.Size(225, 21)
        Me.txtAgent.TabIndex = 19
        '
        'txtFlight
        '
        Me.txtFlight.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFlight.ForeColor = System.Drawing.Color.Black
        Me.txtFlight.Location = New System.Drawing.Point(97, 173)
        Me.txtFlight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFlight.Name = "txtFlight"
        Me.txtFlight.Size = New System.Drawing.Size(225, 22)
        Me.txtFlight.TabIndex = 17
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(15, 176)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 514
        Me.Label26.Text = "Flight Details"
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI Semibold", 15.25!, System.Drawing.FontStyle.Bold)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(97, 36)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(225, 35)
        Me.foliono.TabIndex = 506
        Me.foliono.Text = "SYSTEM GENERATED"
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.XtraTabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1293, 342)
        Me.GroupBox1.TabIndex = 818
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information (right click to add or edit rooms)"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 19)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabRoomCharge
        Me.XtraTabControl1.Size = New System.Drawing.Size(1287, 320)
        Me.XtraTabControl1.TabIndex = 819
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabRoomCharge, Me.tabRoomSummary, Me.tabPos, Me.tabposcash, Me.tabDiscount, Me.tabPaymentTransaction, Me.tabGuestCompanion, Me.tabFolioAudittrail})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabRoomCharge
        '
        Me.tabRoomCharge.Controls.Add(Me.Em)
        Me.tabRoomCharge.Controls.Add(Me.ckClose)
        Me.tabRoomCharge.Controls.Add(Me.guestType)
        Me.tabRoomCharge.Controls.Add(Me.txtCurrentDeparture)
        Me.tabRoomCharge.Controls.Add(Me.agentid)
        Me.tabRoomCharge.Controls.Add(Me.txtCurrentArrival)
        Me.tabRoomCharge.Controls.Add(Me.mode)
        Me.tabRoomCharge.Controls.Add(Me.cancelled)
        Me.tabRoomCharge.Name = "tabRoomCharge"
        Me.tabRoomCharge.Size = New System.Drawing.Size(1281, 288)
        Me.tabRoomCharge.Text = "Room Charge Information"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_room
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView_Room
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(1281, 288)
        Me.Em.TabIndex = 820
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Room})
        '
        'cms_room
        '
        Me.cms_room.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddNewRoom, Me.cmdRoomAdd, Me.cmdProceedCheckin, Me.cmdCheckout, Me.cmdRestoreUncheckOut, Me.cmdChangeRoomChargeType, Me.lineCheckout, Me.RoomManagementToolStripMenuItem, Me.cmdMergePayment, Me.ToolStripSeparator1, Me.cmdRoomRefresh})
        Me.cms_room.Name = "ContextMenuStrip1"
        Me.cms_room.Size = New System.Drawing.Size(218, 214)
        '
        'cmdAddNewRoom
        '
        Me.cmdAddNewRoom.Image = Global.CoffeecupClient.My.Resources.Resources.home__plus
        Me.cmdAddNewRoom.Name = "cmdAddNewRoom"
        Me.cmdAddNewRoom.Size = New System.Drawing.Size(217, 22)
        Me.cmdAddNewRoom.Text = "Add New Room"
        '
        'cmdRoomAdd
        '
        Me.cmdRoomAdd.Image = Global.CoffeecupClient.My.Resources.Resources.home__pencil
        Me.cmdRoomAdd.Name = "cmdRoomAdd"
        Me.cmdRoomAdd.Size = New System.Drawing.Size(217, 22)
        Me.cmdRoomAdd.Text = "Room Selection"
        '
        'cmdProceedCheckin
        '
        Me.cmdProceedCheckin.Image = Global.CoffeecupClient.My.Resources.Resources.home__arrow1
        Me.cmdProceedCheckin.Name = "cmdProceedCheckin"
        Me.cmdProceedCheckin.Size = New System.Drawing.Size(217, 22)
        Me.cmdProceedCheckin.Text = "Proceed Check-in"
        '
        'cmdCheckout
        '
        Me.cmdCheckout.Image = Global.CoffeecupClient.My.Resources.Resources.door_open_out
        Me.cmdCheckout.Name = "cmdCheckout"
        Me.cmdCheckout.Size = New System.Drawing.Size(217, 22)
        Me.cmdCheckout.Text = "Proceed Check Out"
        '
        'cmdRestoreUncheckOut
        '
        Me.cmdRestoreUncheckOut.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_turn_180_left
        Me.cmdRestoreUncheckOut.Name = "cmdRestoreUncheckOut"
        Me.cmdRestoreUncheckOut.Size = New System.Drawing.Size(217, 22)
        Me.cmdRestoreUncheckOut.Text = "Restore Uncheck Out"
        '
        'cmdChangeRoomChargeType
        '
        Me.cmdChangeRoomChargeType.Image = Global.CoffeecupClient.My.Resources.Resources.flag__arrow1
        Me.cmdChangeRoomChargeType.Name = "cmdChangeRoomChargeType"
        Me.cmdChangeRoomChargeType.Size = New System.Drawing.Size(217, 22)
        Me.cmdChangeRoomChargeType.Text = "Change Charge Type"
        '
        'lineCheckout
        '
        Me.lineCheckout.Name = "lineCheckout"
        Me.lineCheckout.Size = New System.Drawing.Size(214, 6)
        '
        'RoomManagementToolStripMenuItem
        '
        Me.RoomManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRoomUpgrade, Me.cmdViewRoomInfo, Me.ViewRoomStatementToolStripMenuItem, Me.cmdDiscount, Me.cmdEditRoom, Me.cmdRoomRemove, Me.lineCompanion, Me.cmdRoomAddCompanion})
        Me.RoomManagementToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources._045
        Me.RoomManagementToolStripMenuItem.Name = "RoomManagementToolStripMenuItem"
        Me.RoomManagementToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RoomManagementToolStripMenuItem.Text = "Room Management"
        '
        'cmdRoomUpgrade
        '
        Me.cmdRoomUpgrade.Image = Global.CoffeecupClient.My.Resources.Resources.Home_Normal
        Me.cmdRoomUpgrade.Name = "cmdRoomUpgrade"
        Me.cmdRoomUpgrade.Size = New System.Drawing.Size(204, 22)
        Me.cmdRoomUpgrade.Text = "Room Upgrade"
        '
        'cmdViewRoomInfo
        '
        Me.cmdViewRoomInfo.Image = Global.CoffeecupClient.My.Resources.Resources.page_white_go
        Me.cmdViewRoomInfo.Name = "cmdViewRoomInfo"
        Me.cmdViewRoomInfo.Size = New System.Drawing.Size(204, 22)
        Me.cmdViewRoomInfo.Text = "View Room Info"
        '
        'ViewRoomStatementToolStripMenuItem
        '
        Me.ViewRoomStatementToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources._165
        Me.ViewRoomStatementToolStripMenuItem.Name = "ViewRoomStatementToolStripMenuItem"
        Me.ViewRoomStatementToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ViewRoomStatementToolStripMenuItem.Text = "Room Statement"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.Image = Global.CoffeecupClient.My.Resources.Resources._185
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(204, 22)
        Me.cmdDiscount.Text = "Post Room Discount"
        '
        'cmdEditRoom
        '
        Me.cmdEditRoom.Image = Global.CoffeecupClient.My.Resources.Resources.door__pencil
        Me.cmdEditRoom.Name = "cmdEditRoom"
        Me.cmdEditRoom.Size = New System.Drawing.Size(204, 22)
        Me.cmdEditRoom.Text = "Edit Selected Room"
        '
        'cmdRoomRemove
        '
        Me.cmdRoomRemove.Image = Global.CoffeecupClient.My.Resources.Resources.home__minus
        Me.cmdRoomRemove.Name = "cmdRoomRemove"
        Me.cmdRoomRemove.Size = New System.Drawing.Size(204, 22)
        Me.cmdRoomRemove.Text = "Remove Selected Rooms"
        '
        'lineCompanion
        '
        Me.lineCompanion.Name = "lineCompanion"
        Me.lineCompanion.Size = New System.Drawing.Size(201, 6)
        '
        'cmdRoomAddCompanion
        '
        Me.cmdRoomAddCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.user__plus
        Me.cmdRoomAddCompanion.Name = "cmdRoomAddCompanion"
        Me.cmdRoomAddCompanion.Size = New System.Drawing.Size(204, 22)
        Me.cmdRoomAddCompanion.Text = "Add Room Companion"
        '
        'cmdMergePayment
        '
        Me.cmdMergePayment.Image = Global.CoffeecupClient.My.Resources.Resources.Money_Hot
        Me.cmdMergePayment.Name = "cmdMergePayment"
        Me.cmdMergePayment.Size = New System.Drawing.Size(217, 22)
        Me.cmdMergePayment.Text = "Payment to Selected Room"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'cmdRoomRefresh
        '
        Me.cmdRoomRefresh.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRoomRefresh.Name = "cmdRoomRefresh"
        Me.cmdRoomRefresh.Size = New System.Drawing.Size(217, 22)
        Me.cmdRoomRefresh.Tag = "1"
        Me.cmdRoomRefresh.Text = "Refresh Data"
        '
        'GridView_Room
        '
        Me.GridView_Room.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Room.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Room.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Room.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Room.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Room.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Room.Appearance.Row.Options.UseFont = True
        Me.GridView_Room.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Room.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Room.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Room.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Room.GridControl = Me.Em
        Me.GridView_Room.Name = "GridView_Room"
        Me.GridView_Room.OptionsBehavior.Editable = False
        Me.GridView_Room.OptionsSelection.MultiSelect = True
        Me.GridView_Room.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Room.OptionsView.ColumnAutoWidth = False
        Me.GridView_Room.OptionsView.RowAutoHeight = True
        Me.GridView_Room.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'ckClose
        '
        Me.ckClose.AutoSize = True
        Me.ckClose.Location = New System.Drawing.Point(1150, 69)
        Me.ckClose.Name = "ckClose"
        Me.ckClose.Size = New System.Drawing.Size(58, 17)
        Me.ckClose.TabIndex = 829
        Me.ckClose.Text = "Closed"
        Me.ckClose.UseVisualStyleBackColor = True
        Me.ckClose.Visible = False
        '
        'guestType
        '
        Me.guestType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestType.ForeColor = System.Drawing.Color.Black
        Me.guestType.Location = New System.Drawing.Point(916, 69)
        Me.guestType.Margin = New System.Windows.Forms.Padding(5)
        Me.guestType.Name = "guestType"
        Me.guestType.Size = New System.Drawing.Size(19, 23)
        Me.guestType.TabIndex = 815
        Me.guestType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestType.Visible = False
        '
        'txtCurrentDeparture
        '
        Me.txtCurrentDeparture.CustomFormat = "MMMM dd, yyyy"
        Me.txtCurrentDeparture.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCurrentDeparture.Location = New System.Drawing.Point(1068, 116)
        Me.txtCurrentDeparture.Name = "txtCurrentDeparture"
        Me.txtCurrentDeparture.Size = New System.Drawing.Size(125, 22)
        Me.txtCurrentDeparture.TabIndex = 827
        Me.txtCurrentDeparture.Visible = False
        '
        'txtCurrentArrival
        '
        Me.txtCurrentArrival.CustomFormat = "MMMM dd, yyyy"
        Me.txtCurrentArrival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCurrentArrival.Location = New System.Drawing.Point(1068, 92)
        Me.txtCurrentArrival.Name = "txtCurrentArrival"
        Me.txtCurrentArrival.Size = New System.Drawing.Size(125, 22)
        Me.txtCurrentArrival.TabIndex = 826
        Me.txtCurrentArrival.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(1199, 91)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(30, 23)
        Me.mode.TabIndex = 824
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'cancelled
        '
        Me.cancelled.AutoSize = True
        Me.cancelled.Location = New System.Drawing.Point(1068, 69)
        Me.cancelled.Name = "cancelled"
        Me.cancelled.Size = New System.Drawing.Size(72, 17)
        Me.cancelled.TabIndex = 828
        Me.cancelled.Text = "Cancelled"
        Me.cancelled.UseVisualStyleBackColor = True
        Me.cancelled.Visible = False
        '
        'tabRoomSummary
        '
        Me.tabRoomSummary.Controls.Add(Me.Em_Summary)
        Me.tabRoomSummary.Name = "tabRoomSummary"
        Me.tabRoomSummary.Size = New System.Drawing.Size(1281, 291)
        Me.tabRoomSummary.Text = "Room Charge Summary"
        '
        'Em_Summary
        '
        Me.Em_Summary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Summary.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Summary.Location = New System.Drawing.Point(0, 0)
        Me.Em_Summary.MainView = Me.GridView_Summary
        Me.Em_Summary.Name = "Em_Summary"
        Me.Em_Summary.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Summary.Size = New System.Drawing.Size(1281, 291)
        Me.Em_Summary.TabIndex = 821
        Me.Em_Summary.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Summary})
        '
        'GridView_Summary
        '
        Me.GridView_Summary.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Summary.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Summary.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Summary.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Summary.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Summary.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Summary.Appearance.Row.Options.UseFont = True
        Me.GridView_Summary.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Summary.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Summary.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Summary.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Summary.GridControl = Me.Em_Summary
        Me.GridView_Summary.Name = "GridView_Summary"
        Me.GridView_Summary.OptionsBehavior.Editable = False
        Me.GridView_Summary.OptionsSelection.MultiSelect = True
        Me.GridView_Summary.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Summary.OptionsView.ColumnAutoWidth = False
        Me.GridView_Summary.OptionsView.RowAutoHeight = True
        Me.GridView_Summary.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'tabPos
        '
        Me.tabPos.Controls.Add(Me.Em_POS)
        Me.tabPos.Name = "tabPos"
        Me.tabPos.Size = New System.Drawing.Size(1281, 288)
        Me.tabPos.Text = "Pos / Other Charges"
        '
        'Em_POS
        '
        Me.Em_POS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_POS.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_POS.Location = New System.Drawing.Point(0, 0)
        Me.Em_POS.MainView = Me.GridView_POS
        Me.Em_POS.Name = "Em_POS"
        Me.Em_POS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_POS.Size = New System.Drawing.Size(1281, 288)
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
        'tabDiscount
        '
        Me.tabDiscount.Controls.Add(Me.Em_Discount)
        Me.tabDiscount.Name = "tabDiscount"
        Me.tabDiscount.Size = New System.Drawing.Size(1281, 291)
        Me.tabDiscount.Text = "Room Discount"
        '
        'Em_Discount
        '
        Me.Em_Discount.ContextMenuStrip = Me.cms_discount
        Me.Em_Discount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Discount.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Discount.Location = New System.Drawing.Point(0, 0)
        Me.Em_Discount.MainView = Me.GridView_Discount
        Me.Em_Discount.Name = "Em_Discount"
        Me.Em_Discount.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit6})
        Me.Em_Discount.Size = New System.Drawing.Size(1281, 291)
        Me.Em_Discount.TabIndex = 824
        Me.Em_Discount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Discount})
        '
        'cms_discount
        '
        Me.cms_discount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEditDiscount, Me.cmdRemoveDiscount, Me.ToolStripSeparator5, Me.cmdRefreshDiscount})
        Me.cms_discount.Name = "ContextMenuStrip1"
        Me.cms_discount.Size = New System.Drawing.Size(215, 76)
        '
        'cmdEditDiscount
        '
        Me.cmdEditDiscount.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditDiscount.Name = "cmdEditDiscount"
        Me.cmdEditDiscount.Size = New System.Drawing.Size(214, 22)
        Me.cmdEditDiscount.Text = "Edit Discount Details"
        '
        'cmdRemoveDiscount
        '
        Me.cmdRemoveDiscount.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveDiscount.Name = "cmdRemoveDiscount"
        Me.cmdRemoveDiscount.Size = New System.Drawing.Size(214, 22)
        Me.cmdRemoveDiscount.Text = "Remove Selected Discount"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(211, 6)
        '
        'cmdRefreshDiscount
        '
        Me.cmdRefreshDiscount.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshDiscount.Name = "cmdRefreshDiscount"
        Me.cmdRefreshDiscount.Size = New System.Drawing.Size(214, 22)
        Me.cmdRefreshDiscount.Tag = "1"
        Me.cmdRefreshDiscount.Text = "Refresh Data"
        '
        'GridView_Discount
        '
        Me.GridView_Discount.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Discount.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Discount.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Discount.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Discount.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Discount.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Discount.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Discount.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Discount.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Discount.Appearance.Row.Options.UseFont = True
        Me.GridView_Discount.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Discount.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Discount.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Discount.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Discount.GridControl = Me.Em_Discount
        Me.GridView_Discount.Name = "GridView_Discount"
        Me.GridView_Discount.OptionsBehavior.Editable = False
        Me.GridView_Discount.OptionsSelection.MultiSelect = True
        Me.GridView_Discount.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Discount.OptionsView.ColumnAutoWidth = False
        Me.GridView_Discount.OptionsView.RowAutoHeight = True
        Me.GridView_Discount.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit6
        '
        Me.RepositoryItemPictureEdit6.Name = "RepositoryItemPictureEdit6"
        '
        'tabPaymentTransaction
        '
        Me.tabPaymentTransaction.Controls.Add(Me.Em_Payment)
        Me.tabPaymentTransaction.Name = "tabPaymentTransaction"
        Me.tabPaymentTransaction.Size = New System.Drawing.Size(1281, 291)
        Me.tabPaymentTransaction.Text = "Payment Transaction"
        '
        'Em_Payment
        '
        Me.Em_Payment.ContextMenuStrip = Me.cms_deposit
        Me.Em_Payment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Payment.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Payment.Location = New System.Drawing.Point(0, 0)
        Me.Em_Payment.MainView = Me.GridView_Payment
        Me.Em_Payment.Name = "Em_Payment"
        Me.Em_Payment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit4})
        Me.Em_Payment.Size = New System.Drawing.Size(1281, 291)
        Me.Em_Payment.TabIndex = 823
        Me.Em_Payment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Payment})
        '
        'cms_deposit
        '
        Me.cms_deposit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddnnewDeposit, Me.cmdEditDeposit, Me.cmdRemoveDeposit, Me.ToolStripSeparator3, Me.cmdRefreshDeposit})
        Me.cms_deposit.Name = "ContextMenuStrip1"
        Me.cms_deposit.Size = New System.Drawing.Size(215, 98)
        '
        'cmdAddnnewDeposit
        '
        Me.cmdAddnnewDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddnnewDeposit.Name = "cmdAddnnewDeposit"
        Me.cmdAddnnewDeposit.Size = New System.Drawing.Size(214, 22)
        Me.cmdAddnnewDeposit.Text = "Add New"
        '
        'cmdEditDeposit
        '
        Me.cmdEditDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditDeposit.Name = "cmdEditDeposit"
        Me.cmdEditDeposit.Size = New System.Drawing.Size(214, 22)
        Me.cmdEditDeposit.Text = "Edit Payment Details"
        '
        'cmdRemoveDeposit
        '
        Me.cmdRemoveDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveDeposit.Name = "cmdRemoveDeposit"
        Me.cmdRemoveDeposit.Size = New System.Drawing.Size(214, 22)
        Me.cmdRemoveDeposit.Text = "Remove Selected Payment"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(211, 6)
        '
        'cmdRefreshDeposit
        '
        Me.cmdRefreshDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshDeposit.Name = "cmdRefreshDeposit"
        Me.cmdRefreshDeposit.Size = New System.Drawing.Size(214, 22)
        Me.cmdRefreshDeposit.Tag = "1"
        Me.cmdRefreshDeposit.Text = "Refresh Data"
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
        'tabGuestCompanion
        '
        Me.tabGuestCompanion.Controls.Add(Me.Em_Companion)
        Me.tabGuestCompanion.Name = "tabGuestCompanion"
        Me.tabGuestCompanion.Size = New System.Drawing.Size(1281, 291)
        Me.tabGuestCompanion.Text = "Guest Companion"
        '
        'Em_Companion
        '
        Me.Em_Companion.ContextMenuStrip = Me.cms_companion
        Me.Em_Companion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Companion.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Companion.Location = New System.Drawing.Point(0, 0)
        Me.Em_Companion.MainView = Me.GridView_Companion
        Me.Em_Companion.Name = "Em_Companion"
        Me.Em_Companion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.Em_Companion.Size = New System.Drawing.Size(1281, 291)
        Me.Em_Companion.TabIndex = 824
        Me.Em_Companion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Companion})
        '
        'cms_companion
        '
        Me.cms_companion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddCompanion, Me.cmdEditCompanion, Me.cmdRemoveCompanion, Me.ToolStripSeparator2, Me.cmdRefreshCompanion})
        Me.cms_companion.Name = "ContextMenuStrip1"
        Me.cms_companion.Size = New System.Drawing.Size(165, 98)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'cmdRefreshCompanion
        '
        Me.cmdRefreshCompanion.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshCompanion.Name = "cmdRefreshCompanion"
        Me.cmdRefreshCompanion.Size = New System.Drawing.Size(164, 22)
        Me.cmdRefreshCompanion.Tag = "1"
        Me.cmdRefreshCompanion.Text = "Refresh Data"
        '
        'GridView_Companion
        '
        Me.GridView_Companion.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Companion.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Companion.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Companion.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Companion.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Companion.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Companion.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Companion.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Companion.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Companion.Appearance.Row.Options.UseFont = True
        Me.GridView_Companion.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Companion.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Companion.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Companion.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Companion.GridControl = Me.Em_Companion
        Me.GridView_Companion.Name = "GridView_Companion"
        Me.GridView_Companion.OptionsBehavior.Editable = False
        Me.GridView_Companion.OptionsSelection.MultiSelect = True
        Me.GridView_Companion.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Companion.OptionsView.ColumnAutoWidth = False
        Me.GridView_Companion.OptionsView.RowAutoHeight = True
        Me.GridView_Companion.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'tabFolioAudittrail
        '
        Me.tabFolioAudittrail.Controls.Add(Me.Em_audittrail)
        Me.tabFolioAudittrail.Name = "tabFolioAudittrail"
        Me.tabFolioAudittrail.Size = New System.Drawing.Size(1281, 291)
        Me.tabFolioAudittrail.Text = "Folio Audit Trail"
        '
        'Em_audittrail
        '
        Me.Em_audittrail.ContextMenuStrip = Me.cmd_audittrail
        Me.Em_audittrail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_audittrail.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_audittrail.Location = New System.Drawing.Point(0, 0)
        Me.Em_audittrail.MainView = Me.grid_auditTrail
        Me.Em_audittrail.Name = "Em_audittrail"
        Me.Em_audittrail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit7})
        Me.Em_audittrail.Size = New System.Drawing.Size(1281, 291)
        Me.Em_audittrail.TabIndex = 825
        Me.Em_audittrail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_auditTrail})
        '
        'cmd_audittrail
        '
        Me.cmd_audittrail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.cmd_audittrail.Name = "ContextMenuStrip1"
        Me.cmd_audittrail.Size = New System.Drawing.Size(141, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripMenuItem4.Tag = "1"
        Me.ToolStripMenuItem4.Text = "Refresh Data"
        '
        'grid_auditTrail
        '
        Me.grid_auditTrail.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.grid_auditTrail.Appearance.GroupFooter.Options.UseFont = True
        Me.grid_auditTrail.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.grid_auditTrail.Appearance.GroupPanel.Options.UseFont = True
        Me.grid_auditTrail.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.grid_auditTrail.Appearance.GroupRow.Options.UseFont = True
        Me.grid_auditTrail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_auditTrail.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_auditTrail.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.grid_auditTrail.Appearance.Row.Options.UseFont = True
        Me.grid_auditTrail.Appearance.Row.Options.UseTextOptions = True
        Me.grid_auditTrail.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.grid_auditTrail.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.grid_auditTrail.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.grid_auditTrail.GridControl = Me.Em_audittrail
        Me.grid_auditTrail.Name = "grid_auditTrail"
        Me.grid_auditTrail.OptionsBehavior.Editable = False
        Me.grid_auditTrail.OptionsSelection.MultiSelect = True
        Me.grid_auditTrail.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.grid_auditTrail.OptionsView.ColumnAutoWidth = False
        Me.grid_auditTrail.OptionsView.RowAutoHeight = True
        Me.grid_auditTrail.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit7
        '
        Me.RepositoryItemPictureEdit7.Name = "RepositoryItemPictureEdit7"
        '
        'tabposcash
        '
        Me.tabposcash.Controls.Add(Me.Em_Cash)
        Me.tabposcash.Name = "tabposcash"
        Me.tabposcash.Size = New System.Drawing.Size(1281, 288)
        Me.tabposcash.Text = "POS Cash Transaction"
        '
        'grpGuest
        '
        Me.grpGuest.Controls.Add(Me.txtRatings)
        Me.grpGuest.Controls.Add(Me.Label20)
        Me.grpGuest.Controls.Add(Me.txtGuestPreferences)
        Me.grpGuest.Controls.Add(Me.cmdPreviousTransaction)
        Me.grpGuest.Controls.Add(Me.guestid)
        Me.grpGuest.Controls.Add(Me.lblTransaction)
        Me.grpGuest.Controls.Add(Me.txtAddress)
        Me.grpGuest.Controls.Add(Me.cmdEditGuest)
        Me.grpGuest.Controls.Add(Me.Label1)
        Me.grpGuest.Controls.Add(Me.txtContactNumber)
        Me.grpGuest.Controls.Add(Me.Label3)
        Me.grpGuest.Controls.Add(Me.Label4)
        Me.grpGuest.Controls.Add(Me.Label5)
        Me.grpGuest.Controls.Add(Me.Label6)
        Me.grpGuest.Controls.Add(Me.txtEmail)
        Me.grpGuest.Controls.Add(Me.cmdPickGuest)
        Me.grpGuest.Controls.Add(Me.txtGuest)
        Me.grpGuest.Controls.Add(Me.txtBirthdate)
        Me.grpGuest.Controls.Add(Me.txtNationality)
        Me.grpGuest.Controls.Add(Me.txtGender)
        Me.grpGuest.Controls.Add(Me.Label2)
        Me.grpGuest.Controls.Add(Me.txtCountry)
        Me.grpGuest.Controls.Add(Me.Label27)
        Me.grpGuest.Location = New System.Drawing.Point(8, 48)
        Me.grpGuest.Name = "grpGuest"
        Me.grpGuest.Size = New System.Drawing.Size(361, 288)
        Me.grpGuest.TabIndex = 819
        Me.grpGuest.TabStop = False
        Me.grpGuest.Text = "Guest Information"
        '
        'txtRatings
        '
        Me.txtRatings.BackColor = System.Drawing.Color.Silver
        Me.txtRatings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRatings.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.txtRatings.ForeColor = System.Drawing.Color.Black
        Me.txtRatings.Location = New System.Drawing.Point(93, 34)
        Me.txtRatings.Name = "txtRatings"
        Me.txtRatings.Size = New System.Drawing.Size(223, 31)
        Me.txtRatings.TabIndex = 817
        Me.txtRatings.Text = "NO GUEST SELECTED"
        Me.txtRatings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(8, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 816
        Me.Label20.Text = "Rewards Level"
        '
        'txtGuestPreferences
        '
        Me.txtGuestPreferences.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtGuestPreferences.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGuestPreferences.ForeColor = System.Drawing.Color.Black
        Me.txtGuestPreferences.Location = New System.Drawing.Point(219, 164)
        Me.txtGuestPreferences.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuestPreferences.Name = "txtGuestPreferences"
        Me.txtGuestPreferences.ReadOnly = True
        Me.txtGuestPreferences.Size = New System.Drawing.Size(55, 22)
        Me.txtGuestPreferences.TabIndex = 815
        Me.txtGuestPreferences.Visible = False
        '
        'cmdPreviousTransaction
        '
        Me.cmdPreviousTransaction.AutoSize = True
        Me.cmdPreviousTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPreviousTransaction.Location = New System.Drawing.Point(91, 260)
        Me.cmdPreviousTransaction.Name = "cmdPreviousTransaction"
        Me.cmdPreviousTransaction.Size = New System.Drawing.Size(178, 13)
        Me.cmdPreviousTransaction.TabIndex = 814
        Me.cmdPreviousTransaction.TabStop = True
        Me.cmdPreviousTransaction.Text = "View Previous Transaction History"
        Me.cmdPreviousTransaction.Visible = False
        '
        'guestid
        '
        Me.guestid.Enabled = False
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(321, 121)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(19, 23)
        Me.guestid.TabIndex = 812
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'cmdEditGuest
        '
        Me.cmdEditGuest.Image = Global.CoffeecupClient.My.Resources.Resources.user__pencil
        Me.cmdEditGuest.Location = New System.Drawing.Point(319, 68)
        Me.cmdEditGuest.Name = "cmdEditGuest"
        Me.cmdEditGuest.Size = New System.Drawing.Size(31, 46)
        Me.cmdEditGuest.TabIndex = 811
        Me.cmdEditGuest.UseVisualStyleBackColor = True
        Me.cmdEditGuest.Visible = False
        '
        'grpFolio
        '
        Me.grpFolio.Controls.Add(Me.Label19)
        Me.grpFolio.Controls.Add(Me.cmdAttachment)
        Me.grpFolio.Controls.Add(Me.GroupControl1)
        Me.grpFolio.Controls.Add(Me.txtGuestType)
        Me.grpFolio.Controls.Add(Me.cmdTypeofGuest)
        Me.grpFolio.Controls.Add(Me.lblResNo)
        Me.grpFolio.Controls.Add(Me.Label8)
        Me.grpFolio.Controls.Add(Me.foliono)
        Me.grpFolio.Controls.Add(Me.txtDateArival)
        Me.grpFolio.Controls.Add(Me.Label13)
        Me.grpFolio.Controls.Add(Me.txtDeparture)
        Me.grpFolio.Controls.Add(Me.txtPlateNumber)
        Me.grpFolio.Controls.Add(Me.txtAgent)
        Me.grpFolio.Controls.Add(Me.cmdTypeofAgent)
        Me.grpFolio.Controls.Add(Me.Label22)
        Me.grpFolio.Controls.Add(Me.txtFlight)
        Me.grpFolio.Controls.Add(Me.Label26)
        Me.grpFolio.Location = New System.Drawing.Point(374, 48)
        Me.grpFolio.Name = "grpFolio"
        Me.grpFolio.Size = New System.Drawing.Size(592, 288)
        Me.grpFolio.TabIndex = 822
        Me.grpFolio.TabStop = False
        Me.grpFolio.Text = "Check-In Information"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(24, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 817
        Me.Label19.Text = "Attachment"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Location = New System.Drawing.Point(97, 222)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(225, 35)
        Me.cmdAttachment.TabIndex = 816
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GroupControl1.Controls.Add(Me.txtRemarks)
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card
        Me.GroupControl1.Location = New System.Drawing.Point(330, 36)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(246, 222)
        Me.GroupControl1.TabIndex = 815
        Me.GroupControl1.Text = "Supporting Remarks"
        '
        'txtGuestType
        '
        Me.txtGuestType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGuestType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtGuestType.DropDownHeight = 130
        Me.txtGuestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGuestType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtGuestType.ForeColor = System.Drawing.Color.Black
        Me.txtGuestType.FormattingEnabled = True
        Me.txtGuestType.IntegralHeight = False
        Me.txtGuestType.ItemHeight = 13
        Me.txtGuestType.Location = New System.Drawing.Point(97, 74)
        Me.txtGuestType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuestType.MaxDropDownItems = 7
        Me.txtGuestType.Name = "txtGuestType"
        Me.txtGuestType.Size = New System.Drawing.Size(225, 21)
        Me.txtGuestType.TabIndex = 813
        '
        'cmdTypeofGuest
        '
        Me.cmdTypeofGuest.AutoSize = True
        Me.cmdTypeofGuest.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdTypeofGuest.Location = New System.Drawing.Point(28, 77)
        Me.cmdTypeofGuest.Name = "cmdTypeofGuest"
        Me.cmdTypeofGuest.Size = New System.Drawing.Size(62, 13)
        Me.cmdTypeofGuest.TabIndex = 814
        Me.cmdTypeofGuest.TabStop = True
        Me.cmdTypeofGuest.Text = "Guest Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(28, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 811
        Me.Label8.Text = "Date Arival"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(97, 98)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(225, 22)
        Me.txtDateArival.TabIndex = 807
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(31, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 809
        Me.Label13.Text = "Departure"
        '
        'txtDeparture
        '
        Me.txtDeparture.CustomFormat = "MMMM dd, yyyy"
        Me.txtDeparture.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDeparture.Location = New System.Drawing.Point(97, 123)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(225, 22)
        Me.txtDeparture.TabIndex = 808
        '
        'grpSummary
        '
        Me.grpSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSummary.Controls.Add(Me.txtTotalDiscounts)
        Me.grpSummary.Controls.Add(Me.Label15)
        Me.grpSummary.Controls.Add(Me.txtTotalPayments)
        Me.grpSummary.Controls.Add(Me.Label17)
        Me.grpSummary.Controls.Add(Me.txtTotalCharges)
        Me.grpSummary.Controls.Add(Me.Label18)
        Me.grpSummary.Controls.Add(Me.Label14)
        Me.grpSummary.Controls.Add(Me.txtTotalFolioPayment)
        Me.grpSummary.Controls.Add(Me.Label12)
        Me.grpSummary.Controls.Add(Me.txtBalanceDue)
        Me.grpSummary.Controls.Add(Me.Label11)
        Me.grpSummary.Controls.Add(Me.txtTotalRoomPayment)
        Me.grpSummary.Controls.Add(Me.Label10)
        Me.grpSummary.Controls.Add(Me.txtTotalPOS)
        Me.grpSummary.Controls.Add(Me.Label9)
        Me.grpSummary.Controls.Add(Me.txtTotalRoomCharge)
        Me.grpSummary.Controls.Add(Me.Label7)
        Me.grpSummary.Controls.Add(Me.Label16)
        Me.grpSummary.Location = New System.Drawing.Point(972, 48)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(329, 288)
        Me.grpSummary.TabIndex = 823
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Folio Transaction Summary"
        '
        'txtTotalDiscounts
        '
        Me.txtTotalDiscounts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalDiscounts.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalDiscounts.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDiscounts.Location = New System.Drawing.Point(180, 192)
        Me.txtTotalDiscounts.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalDiscounts.Name = "txtTotalDiscounts"
        Me.txtTotalDiscounts.ReadOnly = True
        Me.txtTotalDiscounts.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalDiscounts.TabIndex = 817
        Me.txtTotalDiscounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(85, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 818
        Me.Label15.Text = "Total Discounts"
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPayments.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalPayments.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPayments.Location = New System.Drawing.Point(180, 216)
        Me.txtTotalPayments.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.ReadOnly = True
        Me.txtTotalPayments.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalPayments.TabIndex = 815
        Me.txtTotalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(88, 220)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 816
        Me.Label17.Text = "Total Payments"
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCharges.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalCharges.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCharges.Location = New System.Drawing.Point(180, 168)
        Me.txtTotalCharges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.ReadOnly = True
        Me.txtTotalCharges.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalCharges.TabIndex = 813
        Me.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(94, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 814
        Me.Label18.Text = "Total Charges"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(38, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(261, 17)
        Me.Label14.TabIndex = 810
        Me.Label14.Text = "Room Charges and Payments Transaction"
        '
        'txtTotalFolioPayment
        '
        Me.txtTotalFolioPayment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalFolioPayment.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalFolioPayment.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFolioPayment.Location = New System.Drawing.Point(180, 125)
        Me.txtTotalFolioPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalFolioPayment.Name = "txtTotalFolioPayment"
        Me.txtTotalFolioPayment.ReadOnly = True
        Me.txtTotalFolioPayment.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalFolioPayment.TabIndex = 487
        Me.txtTotalFolioPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(62, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 488
        Me.Label12.Text = "Main Folio Payment"
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalanceDue.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceDue.ForeColor = System.Drawing.Color.Black
        Me.txtBalanceDue.Location = New System.Drawing.Point(180, 240)
        Me.txtBalanceDue.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.ReadOnly = True
        Me.txtBalanceDue.Size = New System.Drawing.Size(134, 25)
        Me.txtBalanceDue.TabIndex = 485
        Me.txtBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 486
        Me.Label11.Text = "Balance Due"
        '
        'txtTotalRoomPayment
        '
        Me.txtTotalRoomPayment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalRoomPayment.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalRoomPayment.ForeColor = System.Drawing.Color.Black
        Me.txtTotalRoomPayment.Location = New System.Drawing.Point(180, 101)
        Me.txtTotalRoomPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalRoomPayment.Name = "txtTotalRoomPayment"
        Me.txtTotalRoomPayment.ReadOnly = True
        Me.txtTotalRoomPayment.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalRoomPayment.TabIndex = 483
        Me.txtTotalRoomPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(87, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 484
        Me.Label10.Text = "Room Payment"
        '
        'txtTotalPOS
        '
        Me.txtTotalPOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalPOS.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalPOS.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPOS.Location = New System.Drawing.Point(180, 77)
        Me.txtTotalPOS.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalPOS.Name = "txtTotalPOS"
        Me.txtTotalPOS.ReadOnly = True
        Me.txtTotalPOS.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalPOS.TabIndex = 481
        Me.txtTotalPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(54, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 482
        Me.Label9.Text = "Total POS Transaction"
        '
        'txtTotalRoomCharge
        '
        Me.txtTotalRoomCharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalRoomCharge.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalRoomCharge.ForeColor = System.Drawing.Color.Black
        Me.txtTotalRoomCharge.Location = New System.Drawing.Point(180, 53)
        Me.txtTotalRoomCharge.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalRoomCharge.Name = "txtTotalRoomCharge"
        Me.txtTotalRoomCharge.ReadOnly = True
        Me.txtTotalRoomCharge.Size = New System.Drawing.Size(134, 22)
        Me.txtTotalRoomCharge.TabIndex = 479
        Me.txtTotalRoomCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(66, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 480
        Me.Label7.Text = "Total Room Charge"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(38, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 17)
        Me.Label16.TabIndex = 812
        Me.Label16.Text = "Folio Summary"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.lineClose, Me.cmdSaveFolio, Me.lineSave, Me.cmdConfirmReservation, Me.lineReservation, Me.ToolStripSplitButton1, Me.lineGuestFolio, Me.cmdPayment, Me.linePostPayment, Me.cmdChargeToClientAccount, Me.lineChargeToClientAccount, Me.cmdCloseTransaction})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1313, 45)
        Me.ToolStrip3.TabIndex = 825
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Image = Global.CoffeecupClient.My.Resources.Resources.Action_Close_32x32
        Me.cmdClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(110, 38)
        Me.cmdClose.Text = "Exit Window"
        '
        'lineClose
        '
        Me.lineClose.Name = "lineClose"
        Me.lineClose.Size = New System.Drawing.Size(6, 41)
        '
        'cmdSaveFolio
        '
        Me.cmdSaveFolio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveFolio.ForeColor = System.Drawing.Color.White
        Me.cmdSaveFolio.Image = Global.CoffeecupClient.My.Resources.Resources.Save_32x32__2_
        Me.cmdSaveFolio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSaveFolio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSaveFolio.Name = "cmdSaveFolio"
        Me.cmdSaveFolio.Size = New System.Drawing.Size(68, 38)
        Me.cmdSaveFolio.Text = "Save"
        '
        'lineSave
        '
        Me.lineSave.Name = "lineSave"
        Me.lineSave.Size = New System.Drawing.Size(6, 41)
        '
        'cmdConfirmReservation
        '
        Me.cmdConfirmReservation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmReservation.ForeColor = System.Drawing.Color.White
        Me.cmdConfirmReservation.Image = Global.CoffeecupClient.My.Resources.Resources.ActiveRents_32x32
        Me.cmdConfirmReservation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdConfirmReservation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConfirmReservation.Name = "cmdConfirmReservation"
        Me.cmdConfirmReservation.Size = New System.Drawing.Size(150, 38)
        Me.cmdConfirmReservation.Text = "Confirm Reservation"
        '
        'lineReservation
        '
        Me.lineReservation.Name = "lineReservation"
        Me.lineReservation.Size = New System.Drawing.Size(6, 41)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrintGuestFolio, Me.cmdConsolidatedMasterFolio, Me.cmdPrintMainFolio, Me.cmdPrintTransaction, Me.ToolStripSeparator4, Me.cmdEmailNotification})
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSplitButton1.Image = Global.CoffeecupClient.My.Resources.Resources.Print_32x32__2_
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(109, 38)
        Me.ToolStripSplitButton1.Text = "Print Folio"
        '
        'cmdPrintGuestFolio
        '
        Me.cmdPrintGuestFolio.Image = Global.CoffeecupClient.My.Resources.Resources.Card_32x32__3_
        Me.cmdPrintGuestFolio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPrintGuestFolio.Name = "cmdPrintGuestFolio"
        Me.cmdPrintGuestFolio.Size = New System.Drawing.Size(256, 38)
        Me.cmdPrintGuestFolio.Text = "Print Guest Folio"
        '
        'cmdConsolidatedMasterFolio
        '
        Me.cmdConsolidatedMasterFolio.Image = Global.CoffeecupClient.My.Resources.Resources.Action_Copy_CellValue_32x32
        Me.cmdConsolidatedMasterFolio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdConsolidatedMasterFolio.Name = "cmdConsolidatedMasterFolio"
        Me.cmdConsolidatedMasterFolio.Size = New System.Drawing.Size(256, 38)
        Me.cmdConsolidatedMasterFolio.Text = "Print Consolidated Master Folio"
        '
        'cmdPrintMainFolio
        '
        Me.cmdPrintMainFolio.Image = Global.CoffeecupClient.My.Resources.Resources.TableStyle__2_
        Me.cmdPrintMainFolio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPrintMainFolio.Name = "cmdPrintMainFolio"
        Me.cmdPrintMainFolio.Size = New System.Drawing.Size(256, 38)
        Me.cmdPrintMainFolio.Text = "Print Main Folio Statement"
        '
        'cmdPrintTransaction
        '
        Me.cmdPrintTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.ConvertToRange_32x32
        Me.cmdPrintTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPrintTransaction.Name = "cmdPrintTransaction"
        Me.cmdPrintTransaction.Size = New System.Drawing.Size(256, 38)
        Me.cmdPrintTransaction.Text = "Print Selected Transaction"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(253, 6)
        '
        'cmdEmailNotification
        '
        Me.cmdEmailNotification.Image = Global.CoffeecupClient.My.Resources.Resources.Mail_32x32__4_
        Me.cmdEmailNotification.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEmailNotification.Name = "cmdEmailNotification"
        Me.cmdEmailNotification.Size = New System.Drawing.Size(256, 38)
        Me.cmdEmailNotification.Text = "Send Folio Email Notification"
        '
        'lineGuestFolio
        '
        Me.lineGuestFolio.Name = "lineGuestFolio"
        Me.lineGuestFolio.Size = New System.Drawing.Size(6, 41)
        '
        'cmdPayment
        '
        Me.cmdPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayment.ForeColor = System.Drawing.Color.White
        Me.cmdPayment.Image = Global.CoffeecupClient.My.Resources.Resources.BO_Opportunity_32x32
        Me.cmdPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(116, 38)
        Me.cmdPayment.Text = "Post Payment"
        '
        'linePostPayment
        '
        Me.linePostPayment.Name = "linePostPayment"
        Me.linePostPayment.Size = New System.Drawing.Size(6, 41)
        '
        'cmdChargeToClientAccount
        '
        Me.cmdChargeToClientAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChargeToClientAccount.ForeColor = System.Drawing.Color.White
        Me.cmdChargeToClientAccount.Image = Global.CoffeecupClient.My.Resources.Resources.AssignTo_32x32__2_
        Me.cmdChargeToClientAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdChargeToClientAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChargeToClientAccount.Name = "cmdChargeToClientAccount"
        Me.cmdChargeToClientAccount.Size = New System.Drawing.Size(175, 38)
        Me.cmdChargeToClientAccount.Text = "Charge to Client Account"
        '
        'lineChargeToClientAccount
        '
        Me.lineChargeToClientAccount.Name = "lineChargeToClientAccount"
        Me.lineChargeToClientAccount.Size = New System.Drawing.Size(6, 41)
        '
        'cmdCloseTransaction
        '
        Me.cmdCloseTransaction.Enabled = False
        Me.cmdCloseTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdCloseTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.ActiveCustomersList_32x32
        Me.cmdCloseTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCloseTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCloseTransaction.Name = "cmdCloseTransaction"
        Me.cmdCloseTransaction.Size = New System.Drawing.Size(164, 38)
        Me.cmdCloseTransaction.Text = "Close Folio Transaction"
        Me.cmdCloseTransaction.Visible = False
        '
        'Em_Cash
        '
        Me.Em_Cash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Cash.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Cash.Location = New System.Drawing.Point(0, 0)
        Me.Em_Cash.MainView = Me.GridView_cash
        Me.Em_Cash.Name = "Em_Cash"
        Me.Em_Cash.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit8})
        Me.Em_Cash.Size = New System.Drawing.Size(1281, 288)
        Me.Em_Cash.TabIndex = 823
        Me.Em_Cash.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_cash})
        '
        'GridView_cash
        '
        Me.GridView_cash.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_cash.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_cash.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_cash.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_cash.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_cash.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_cash.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_cash.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_cash.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_cash.Appearance.Row.Options.UseFont = True
        Me.GridView_cash.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_cash.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_cash.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_cash.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_cash.GridControl = Me.Em_Cash
        Me.GridView_cash.Name = "GridView_cash"
        Me.GridView_cash.OptionsBehavior.Editable = False
        Me.GridView_cash.OptionsSelection.MultiSelect = True
        Me.GridView_cash.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_cash.OptionsView.ColumnAutoWidth = False
        Me.GridView_cash.OptionsView.RowAutoHeight = True
        Me.GridView_cash.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit8
        '
        Me.RepositoryItemPictureEdit8.Name = "RepositoryItemPictureEdit8"
        '
        'frmHotelCheckInTransactionV2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1313, 692)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpFolio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpGuest)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(1329, 705)
        Me.Name = "frmHotelCheckInTransactionV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check-In Guest Transaction"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabRoomCharge.ResumeLayout(False)
        Me.tabRoomCharge.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_room.ResumeLayout(False)
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomSummary.ResumeLayout(False)
        CType(Me.Em_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPos.ResumeLayout(False)
        CType(Me.Em_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDiscount.ResumeLayout(False)
        CType(Me.Em_Discount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_discount.ResumeLayout(False)
        CType(Me.GridView_Discount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaymentTransaction.ResumeLayout(False)
        CType(Me.Em_Payment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_deposit.ResumeLayout(False)
        CType(Me.GridView_Payment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGuestCompanion.ResumeLayout(False)
        CType(Me.Em_Companion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_companion.ResumeLayout(False)
        CType(Me.GridView_Companion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFolioAudittrail.ResumeLayout(False)
        CType(Me.Em_audittrail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmd_audittrail.ResumeLayout(False)
        CType(Me.grid_auditTrail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabposcash.ResumeLayout(False)
        Me.grpGuest.ResumeLayout(False)
        Me.grpGuest.PerformLayout()
        Me.grpFolio.ResumeLayout(False)
        Me.grpFolio.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.Em_Cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblResNo As System.Windows.Forms.Label
    Friend WithEvents cmdPickGuest As System.Windows.Forms.LinkLabel
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthdate As System.Windows.Forms.TextBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents txtFlight As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmdTypeofAgent As System.Windows.Forms.LinkLabel
    Friend WithEvents txtAgent As System.Windows.Forms.ComboBox
    Friend WithEvents agentid As System.Windows.Forms.TextBox
    Friend WithEvents cmdEditGuest As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpGuest As System.Windows.Forms.GroupBox
    Friend WithEvents grpFolio As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents cms_companion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPreviousTransaction As System.Windows.Forms.LinkLabel
    Friend WithEvents txtGuestPreferences As System.Windows.Forms.TextBox
    Friend WithEvents cms_room As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRoomAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdProceedCheckin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRoomRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtGuestType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdTypeofGuest As System.Windows.Forms.LinkLabel
    Friend WithEvents guestType As System.Windows.Forms.TextBox
    Friend WithEvents cms_deposit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddnnewDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Room As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_Summary As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Summary As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_POS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_POS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_Payment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Payment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineClose As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents Em_Companion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Companion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents txtBalanceDue As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRoomPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPOS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRoomCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFolioPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdCheckout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCurrentArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCurrentDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents lineCheckout As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lineGuestFolio As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cancelled As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSaveFolio As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineSave As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents linePostPayment As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ckClose As System.Windows.Forms.CheckBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cmdCloseTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents cmdPrintMainFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintGuestFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdConfirmReservation As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineReservation As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdChangeRoomChargeType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRoomUpgrade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewRoomInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewRoomStatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRoomAddCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditRoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lineCompanion As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRoomRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdMergePayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDiscount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_discount As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEditDiscount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveDiscount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshDiscount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em_Discount As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Discount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents txtTotalDiscounts As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdChargeToClientAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineChargeToClientAccount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdConsolidatedMasterFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRestoreUncheckOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEmailNotification As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabRoomCharge As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabRoomSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDiscount As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPaymentTransaction As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabGuestCompanion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents tabFolioAudittrail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_audittrail As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_auditTrail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmd_audittrail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRatings As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdAddNewRoom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabposcash As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_Cash As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_cash As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
