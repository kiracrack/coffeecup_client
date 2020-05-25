<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForApproval_AccountsPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForApproval_AccountsPayable))
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRequestby = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdatereq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdApproved = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Em_Voucher = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Voucher = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Summary = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.voucherno = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.ckCorporate = New System.Windows.Forms.CheckBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.ckFinalApprover = New System.Windows.Forms.CheckBox()
        Me.requestby = New System.Windows.Forms.TextBox()
        Me.cmdHold = New System.Windows.Forms.Button()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabRequestDescription = New DevExpress.XtraTab.XtraTabPage()
        Me.tabItemRequested = New DevExpress.XtraTab.XtraTabPage()
        Me.tabApprovalHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_History = New DevExpress.XtraGrid.GridControl()
        Me.gridHistory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.ckCustom = New System.Windows.Forms.CheckBox()
        Me.txtAttachmentQuery = New System.Windows.Forms.TextBox()
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabRequestDescription.SuspendLayout()
        Me.tabItemRequested.SuspendLayout()
        Me.tabApprovalHistory.SuspendLayout()
        CType(Me.Em_History, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtStatus.Location = New System.Drawing.Point(109, 8)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(195, 29)
        Me.txtStatus.TabIndex = 343
        Me.txtStatus.Text = "FOR APPROVAL"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Payable No"
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtoffice.Location = New System.Drawing.Point(109, 66)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.ReadOnly = True
        Me.txtoffice.Size = New System.Drawing.Size(195, 23)
        Me.txtoffice.TabIndex = 347
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Office"
        '
        'txtRequestby
        '
        Me.txtRequestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestby.Location = New System.Drawing.Point(109, 92)
        Me.txtRequestby.Name = "txtRequestby"
        Me.txtRequestby.ReadOnly = True
        Me.txtRequestby.Size = New System.Drawing.Size(195, 23)
        Me.txtRequestby.TabIndex = 349
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 350
        Me.Label3.Text = "Request By"
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDesignation.Location = New System.Drawing.Point(109, 118)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(195, 23)
        Me.txtDesignation.TabIndex = 351
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(52, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 352
        Me.Label4.Text = "Position"
        '
        'txtdatereq
        '
        Me.txtdatereq.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdatereq.Location = New System.Drawing.Point(109, 144)
        Me.txtdatereq.Name = "txtdatereq"
        Me.txtdatereq.ReadOnly = True
        Me.txtdatereq.Size = New System.Drawing.Size(195, 23)
        Me.txtdatereq.TabIndex = 353
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 354
        Me.Label5.Text = "Date Request"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSupplier.Location = New System.Drawing.Point(109, 170)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(195, 23)
        Me.txtSupplier.TabIndex = 355
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(47, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "Claimant"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalAmount.Location = New System.Drawing.Point(109, 196)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(195, 23)
        Me.txtTotalAmount.TabIndex = 357
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 358
        Me.Label7.Text = "Total Amount"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNote.Location = New System.Drawing.Point(108, 222)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ReadOnly = True
        Me.txtNote.Size = New System.Drawing.Size(195, 51)
        Me.txtNote.TabIndex = 359
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(69, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 360
        Me.Label8.Text = "Note"
        '
        'cmdApproved
        '
        Me.cmdApproved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApproved.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdApproved.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdApproved.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdApproved.Location = New System.Drawing.Point(676, 417)
        Me.cmdApproved.Name = "cmdApproved"
        Me.cmdApproved.Size = New System.Drawing.Size(180, 30)
        Me.cmdApproved.TabIndex = 362
        Me.cmdApproved.Text = "Approved"
        Me.cmdApproved.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(311, 362)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(728, 51)
        Me.txtRemarks.TabIndex = 364
        Me.txtRemarks.Text = "Please enter message"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAttachment.Location = New System.Drawing.Point(108, 275)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(196, 30)
        Me.cmdAttachment.TabIndex = 365
        Me.cmdAttachment.Text = "Complete Attachment"
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 366
        Me.Label9.Text = "Attachment"
        '
        'Em_Voucher
        '
        Me.Em_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Voucher.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Voucher.Location = New System.Drawing.Point(0, 0)
        Me.Em_Voucher.MainView = Me.GridView_Voucher
        Me.Em_Voucher.Name = "Em_Voucher"
        Me.Em_Voucher.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Voucher.Size = New System.Drawing.Size(723, 318)
        Me.Em_Voucher.TabIndex = 822
        Me.Em_Voucher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Voucher})
        '
        'GridView_Voucher
        '
        Me.GridView_Voucher.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Voucher.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Voucher.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Voucher.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Voucher.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Voucher.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Voucher.Appearance.Row.Options.UseFont = True
        Me.GridView_Voucher.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Voucher.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Voucher.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Voucher.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Voucher.GridControl = Me.Em_Voucher
        Me.GridView_Voucher.Name = "GridView_Voucher"
        Me.GridView_Voucher.OptionsBehavior.Editable = False
        Me.GridView_Voucher.OptionsSelection.MultiSelect = True
        Me.GridView_Voucher.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Voucher.OptionsView.ColumnAutoWidth = False
        Me.GridView_Voucher.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView_Summary
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(723, 318)
        Me.Em.TabIndex = 821
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Summary})
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
        Me.GridView_Summary.GridControl = Me.Em
        Me.GridView_Summary.Name = "GridView_Summary"
        Me.GridView_Summary.OptionsBehavior.Editable = False
        Me.GridView_Summary.OptionsSelection.MultiSelect = True
        Me.GridView_Summary.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Summary.OptionsView.ColumnAutoWidth = False
        Me.GridView_Summary.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(192, 54)
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditItemToolStripMenuItem.Text = "Print Approval History"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(191, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'vendorid
        '
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.Location = New System.Drawing.Point(207, 338)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(33, 23)
        Me.vendorid.TabIndex = 368
        Me.vendorid.Visible = False
        '
        'voucherno
        '
        Me.voucherno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.voucherno.Location = New System.Drawing.Point(109, 40)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(195, 23)
        Me.voucherno.TabIndex = 370
        Me.voucherno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(170, 365)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(33, 23)
        Me.mode.TabIndex = 373
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'ckCorporate
        '
        Me.ckCorporate.AutoSize = True
        Me.ckCorporate.Location = New System.Drawing.Point(12, 357)
        Me.ckCorporate.Name = "ckCorporate"
        Me.ckCorporate.Size = New System.Drawing.Size(78, 17)
        Me.ckCorporate.TabIndex = 374
        Me.ckCorporate.Text = "Corporate"
        Me.ckCorporate.UseVisualStyleBackColor = True
        Me.ckCorporate.Visible = False
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.Location = New System.Drawing.Point(207, 311)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(33, 23)
        Me.officeid.TabIndex = 375
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'ckFinalApprover
        '
        Me.ckFinalApprover.AutoSize = True
        Me.ckFinalApprover.Location = New System.Drawing.Point(12, 382)
        Me.ckFinalApprover.Name = "ckFinalApprover"
        Me.ckFinalApprover.Size = New System.Drawing.Size(101, 17)
        Me.ckFinalApprover.TabIndex = 376
        Me.ckFinalApprover.Text = "Final Approver"
        Me.ckFinalApprover.UseVisualStyleBackColor = True
        Me.ckFinalApprover.Visible = False
        '
        'requestby
        '
        Me.requestby.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.requestby.Location = New System.Drawing.Point(170, 338)
        Me.requestby.Name = "requestby"
        Me.requestby.ReadOnly = True
        Me.requestby.Size = New System.Drawing.Size(33, 23)
        Me.requestby.TabIndex = 378
        Me.requestby.Visible = False
        '
        'cmdHold
        '
        Me.cmdHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdHold.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdHold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHold.Location = New System.Drawing.Point(859, 417)
        Me.cmdHold.Name = "cmdHold"
        Me.cmdHold.Size = New System.Drawing.Size(180, 30)
        Me.cmdHold.TabIndex = 381
        Me.cmdHold.Text = "Hold"
        Me.cmdHold.UseVisualStyleBackColor = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(310, 8)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabRequestDescription
        Me.XtraTabControl1.Size = New System.Drawing.Size(729, 348)
        Me.XtraTabControl1.TabIndex = 382
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabRequestDescription, Me.tabItemRequested, Me.tabApprovalHistory})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabRequestDescription
        '
        Me.tabRequestDescription.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRequestDescription.Appearance.Header.Options.UseFont = True
        Me.tabRequestDescription.Controls.Add(Me.Em_Voucher)
        Me.tabRequestDescription.Name = "tabRequestDescription"
        Me.tabRequestDescription.Size = New System.Drawing.Size(723, 318)
        Me.tabRequestDescription.Text = "Request Description"
        '
        'tabItemRequested
        '
        Me.tabItemRequested.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabItemRequested.Appearance.Header.Options.UseFont = True
        Me.tabItemRequested.Controls.Add(Me.Em)
        Me.tabItemRequested.Name = "tabItemRequested"
        Me.tabItemRequested.Size = New System.Drawing.Size(723, 318)
        Me.tabItemRequested.Text = "Item Requested Reference"
        '
        'tabApprovalHistory
        '
        Me.tabApprovalHistory.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabApprovalHistory.Appearance.Header.Options.UseFont = True
        Me.tabApprovalHistory.Controls.Add(Me.Em_History)
        Me.tabApprovalHistory.Name = "tabApprovalHistory"
        Me.tabApprovalHistory.Size = New System.Drawing.Size(723, 318)
        Me.tabApprovalHistory.Text = "Approval History"
        '
        'Em_History
        '
        Me.Em_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_History.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_History.Location = New System.Drawing.Point(0, 0)
        Me.Em_History.MainView = Me.gridHistory
        Me.Em_History.Name = "Em_History"
        Me.Em_History.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_History.Size = New System.Drawing.Size(723, 318)
        Me.Em_History.TabIndex = 823
        Me.Em_History.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridHistory})
        '
        'gridHistory
        '
        Me.gridHistory.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridHistory.Appearance.GroupFooter.Options.UseFont = True
        Me.gridHistory.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridHistory.Appearance.GroupPanel.Options.UseFont = True
        Me.gridHistory.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridHistory.Appearance.GroupRow.Options.UseFont = True
        Me.gridHistory.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridHistory.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridHistory.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridHistory.Appearance.Row.Options.UseFont = True
        Me.gridHistory.Appearance.Row.Options.UseTextOptions = True
        Me.gridHistory.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridHistory.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.gridHistory.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.gridHistory.GridControl = Me.Em_History
        Me.gridHistory.Name = "gridHistory"
        Me.gridHistory.OptionsBehavior.Editable = False
        Me.gridHistory.OptionsSelection.MultiSelect = True
        Me.gridHistory.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.gridHistory.OptionsView.ColumnAutoWidth = False
        Me.gridHistory.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'ckCustom
        '
        Me.ckCustom.AutoSize = True
        Me.ckCustom.Location = New System.Drawing.Point(12, 334)
        Me.ckCustom.Name = "ckCustom"
        Me.ckCustom.Size = New System.Drawing.Size(63, 17)
        Me.ckCustom.TabIndex = 384
        Me.ckCustom.Text = "custom"
        Me.ckCustom.UseVisualStyleBackColor = True
        Me.ckCustom.Visible = False
        '
        'txtAttachmentQuery
        '
        Me.txtAttachmentQuery.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAttachmentQuery.Location = New System.Drawing.Point(170, 311)
        Me.txtAttachmentQuery.Name = "txtAttachmentQuery"
        Me.txtAttachmentQuery.ReadOnly = True
        Me.txtAttachmentQuery.Size = New System.Drawing.Size(33, 23)
        Me.txtAttachmentQuery.TabIndex = 823
        Me.txtAttachmentQuery.Visible = False
        '
        'frmForApproval_AccountsPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1046, 451)
        Me.Controls.Add(Me.txtAttachmentQuery)
        Me.Controls.Add(Me.ckCustom)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.cmdHold)
        Me.Controls.Add(Me.requestby)
        Me.Controls.Add(Me.ckFinalApprover)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.ckCorporate)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cmdApproved)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdatereq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRequestby)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(988, 490)
        Me.Name = "frmForApproval_AccountsPayable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Payable for Approval"
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabRequestDescription.ResumeLayout(False)
        Me.tabItemRequested.ResumeLayout(False)
        Me.tabApprovalHistory.ResumeLayout(False)
        CType(Me.Em_History, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRequestby As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdatereq As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdApproved As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents voucherno As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents ckCorporate As System.Windows.Forms.CheckBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents ckFinalApprover As System.Windows.Forms.CheckBox
    Friend WithEvents requestby As System.Windows.Forms.TextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Summary As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents Em_Voucher As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Voucher As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmdHold As System.Windows.Forms.Button
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabRequestDescription As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabItemRequested As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabApprovalHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_History As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ckCustom As System.Windows.Forms.CheckBox
    Friend WithEvents txtAttachmentQuery As System.Windows.Forms.TextBox
End Class
