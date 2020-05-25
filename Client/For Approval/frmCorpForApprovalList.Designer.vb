<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorpForApprovalList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorpForApprovalList))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDisapproved = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdornerUIManager1 = New DevExpress.Utils.VisualEffects.AdornerUIManager(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xTabRequisition = New DevExpress.XtraTab.XtraTabPage()
        Me.xtabPurchaseOrder = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_PO = New DevExpress.XtraGrid.GridControl()
        Me.Gridview_PO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtabDisbursementVoucher = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_DV = New DevExpress.XtraGrid.GridControl()
        Me.GridView_DV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.xtabFixedAssetsDisposal = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_FA = New DevExpress.XtraGrid.GridControl()
        Me.GridView_FA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Em_PR = New DevExpress.XtraGrid.GridControl()
        Me.GridView_PR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xTabRequisition.SuspendLayout()
        Me.xtabPurchaseOrder.SuspendLayout()
        CType(Me.Em_PO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview_PO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabDisbursementVoucher.SuspendLayout()
        CType(Me.Em_DV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_DV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtabFixedAssetsDisposal.SuspendLayout()
        CType(Me.Em_FA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_FA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_PR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_PR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(56, 40)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(446, 22)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to approve or disapprove request"
        Me.lbldescription.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(510, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "______________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(54, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(184, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "List of for Approval Request"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtfilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picicon)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbldescription)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 105)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For Approval List"
        '
        'txtfilter
        '
        Me.txtfilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfilter.Location = New System.Drawing.Point(106, 76)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(411, 23)
        Me.txtfilter.TabIndex = 337
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Search Keyworks"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.List
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 19)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(40, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData, Me.cmdDisapproved, Me.RefreshToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(170, 70)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(169, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Override Discount"
        '
        'cmdDisapproved
        '
        Me.cmdDisapproved.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdDisapproved.Name = "cmdDisapproved"
        Me.cmdDisapproved.Size = New System.Drawing.Size(169, 22)
        Me.cmdDisapproved.Text = "Disapprove"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdViewProfile, Me.ToolStripSeparator4, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(167, 22)
        Me.cmdEdit.Text = "Confirm Request"
        '
        'cmdViewProfile
        '
        Me.cmdViewProfile.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list
        Me.cmdViewProfile.Name = "cmdViewProfile"
        Me.cmdViewProfile.Size = New System.Drawing.Size(167, 22)
        Me.cmdViewProfile.Text = "View Asset Profile"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(164, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripMenuItem1.Tag = "1"
        Me.ToolStripMenuItem1.Text = "Refresh Data"
        '
        'AdornerUIManager1
        '
        Me.AdornerUIManager1.Owner = Me
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(7, 113)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xTabRequisition
        Me.XtraTabControl1.Size = New System.Drawing.Size(912, 374)
        Me.XtraTabControl1.TabIndex = 383
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xTabRequisition, Me.xtabPurchaseOrder, Me.xtabDisbursementVoucher, Me.xtabFixedAssetsDisposal})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'xTabRequisition
        '
        Me.xTabRequisition.Controls.Add(Me.Em_PR)
        Me.xTabRequisition.Name = "xTabRequisition"
        Me.xTabRequisition.Size = New System.Drawing.Size(906, 340)
        Me.xTabRequisition.Text = "Purchase Request"
        '
        'xtabPurchaseOrder
        '
        Me.xtabPurchaseOrder.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.xtabPurchaseOrder.Appearance.Header.Options.UseFont = True
        Me.xtabPurchaseOrder.Controls.Add(Me.Em_PO)
        Me.xtabPurchaseOrder.Name = "xtabPurchaseOrder"
        Me.xtabPurchaseOrder.Size = New System.Drawing.Size(906, 340)
        Me.xtabPurchaseOrder.Text = "Purchase Order"
        '
        'Em_PO
        '
        Me.Em_PO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_PO.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_PO.Location = New System.Drawing.Point(0, 0)
        Me.Em_PO.MainView = Me.Gridview_PO
        Me.Em_PO.Name = "Em_PO"
        Me.Em_PO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit3})
        Me.Em_PO.Size = New System.Drawing.Size(906, 340)
        Me.Em_PO.TabIndex = 823
        Me.Em_PO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview_PO, Me.GridView3})
        '
        'Gridview_PO
        '
        Me.Gridview_PO.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_PO.Appearance.GroupFooter.Options.UseFont = True
        Me.Gridview_PO.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_PO.Appearance.GroupPanel.Options.UseFont = True
        Me.Gridview_PO.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_PO.Appearance.GroupRow.Options.UseFont = True
        Me.Gridview_PO.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gridview_PO.Appearance.HeaderPanel.Options.UseFont = True
        Me.Gridview_PO.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.Gridview_PO.Appearance.Row.Options.UseFont = True
        Me.Gridview_PO.Appearance.Row.Options.UseTextOptions = True
        Me.Gridview_PO.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview_PO.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Gridview_PO.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Gridview_PO.GridControl = Me.Em_PO
        Me.Gridview_PO.Name = "Gridview_PO"
        Me.Gridview_PO.OptionsBehavior.Editable = False
        Me.Gridview_PO.OptionsSelection.MultiSelect = True
        Me.Gridview_PO.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.Gridview_PO.OptionsView.ColumnAutoWidth = False
        Me.Gridview_PO.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.Em_PO
        Me.GridView3.Name = "GridView3"
        '
        'xtabDisbursementVoucher
        '
        Me.xtabDisbursementVoucher.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.xtabDisbursementVoucher.Appearance.Header.Options.UseFont = True
        Me.xtabDisbursementVoucher.Controls.Add(Me.Em_DV)
        Me.xtabDisbursementVoucher.Name = "xtabDisbursementVoucher"
        Me.xtabDisbursementVoucher.Size = New System.Drawing.Size(906, 340)
        Me.xtabDisbursementVoucher.Text = "Disbursement Voucher"
        '
        'Em_DV
        '
        Me.Em_DV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_DV.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_DV.Location = New System.Drawing.Point(0, 0)
        Me.Em_DV.MainView = Me.GridView_DV
        Me.Em_DV.Name = "Em_DV"
        Me.Em_DV.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em_DV.Size = New System.Drawing.Size(906, 340)
        Me.Em_DV.TabIndex = 824
        Me.Em_DV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_DV, Me.GridView2})
        '
        'GridView_DV
        '
        Me.GridView_DV.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_DV.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_DV.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_DV.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_DV.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_DV.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_DV.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_DV.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_DV.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_DV.Appearance.Row.Options.UseFont = True
        Me.GridView_DV.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_DV.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_DV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_DV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_DV.GridControl = Me.Em_DV
        Me.GridView_DV.Name = "GridView_DV"
        Me.GridView_DV.OptionsBehavior.Editable = False
        Me.GridView_DV.OptionsSelection.MultiSelect = True
        Me.GridView_DV.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_DV.OptionsView.ColumnAutoWidth = False
        Me.GridView_DV.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Em_DV
        Me.GridView2.Name = "GridView2"
        '
        'xtabFixedAssetsDisposal
        '
        Me.xtabFixedAssetsDisposal.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.xtabFixedAssetsDisposal.Appearance.Header.Options.UseFont = True
        Me.xtabFixedAssetsDisposal.Controls.Add(Me.Em_FA)
        Me.xtabFixedAssetsDisposal.Name = "xtabFixedAssetsDisposal"
        Me.xtabFixedAssetsDisposal.Size = New System.Drawing.Size(906, 340)
        Me.xtabFixedAssetsDisposal.Text = "Fixed Assets Disposal"
        '
        'Em_FA
        '
        Me.Em_FA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_FA.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_FA.Location = New System.Drawing.Point(0, 0)
        Me.Em_FA.MainView = Me.GridView_FA
        Me.Em_FA.Name = "Em_FA"
        Me.Em_FA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_FA.Size = New System.Drawing.Size(906, 340)
        Me.Em_FA.TabIndex = 825
        Me.Em_FA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_FA, Me.GridView1})
        '
        'GridView_FA
        '
        Me.GridView_FA.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_FA.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_FA.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_FA.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_FA.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_FA.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_FA.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_FA.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_FA.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_FA.Appearance.Row.Options.UseFont = True
        Me.GridView_FA.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_FA.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_FA.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_FA.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_FA.GridControl = Me.Em_FA
        Me.GridView_FA.Name = "GridView_FA"
        Me.GridView_FA.OptionsBehavior.Editable = False
        Me.GridView_FA.OptionsSelection.MultiSelect = True
        Me.GridView_FA.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_FA.OptionsView.ColumnAutoWidth = False
        Me.GridView_FA.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Em_FA
        Me.GridView1.Name = "GridView1"
        '
        'Em_PR
        '
        Me.Em_PR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_PR.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_PR.Location = New System.Drawing.Point(0, 0)
        Me.Em_PR.MainView = Me.GridView_PR
        Me.Em_PR.Name = "Em_PR"
        Me.Em_PR.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit4})
        Me.Em_PR.Size = New System.Drawing.Size(906, 340)
        Me.Em_PR.TabIndex = 824
        Me.Em_PR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PR, Me.GridView5})
        '
        'GridView_PR
        '
        Me.GridView_PR.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_PR.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_PR.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_PR.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_PR.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_PR.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_PR.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_PR.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_PR.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_PR.Appearance.Row.Options.UseFont = True
        Me.GridView_PR.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_PR.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_PR.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_PR.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_PR.GridControl = Me.Em_PR
        Me.GridView_PR.Name = "GridView_PR"
        Me.GridView_PR.OptionsBehavior.Editable = False
        Me.GridView_PR.OptionsSelection.MultiSelect = True
        Me.GridView_PR.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_PR.OptionsView.ColumnAutoWidth = False
        Me.GridView_PR.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit4
        '
        Me.RepositoryItemPictureEdit4.Name = "RepositoryItemPictureEdit4"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.Em_PR
        Me.GridView5.Name = "GridView5"
        '
        'frmCorpForApprovalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(927, 491)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCorpForApprovalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Approval Request (Corporate Level)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AdornerUIManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xTabRequisition.ResumeLayout(False)
        Me.xtabPurchaseOrder.ResumeLayout(False)
        CType(Me.Em_PO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview_PO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabDisbursementVoucher.ResumeLayout(False)
        CType(Me.Em_DV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_DV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtabFixedAssetsDisposal.ResumeLayout(False)
        CType(Me.Em_FA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_FA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_PR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_PR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDisapproved As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdornerUIManager1 As DevExpress.Utils.VisualEffects.AdornerUIManager
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xTabRequisition As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtabPurchaseOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_PO As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview_PO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents xtabDisbursementVoucher As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_DV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_DV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents xtabFixedAssetsDisposal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_FA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_FA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Em_PR As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_PR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
