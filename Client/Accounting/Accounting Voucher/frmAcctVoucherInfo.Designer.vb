<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcctVoucherInfo
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcctVoucherInfo))
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridVendorAccount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddPayableItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPayableItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDetails = New DevExpress.XtraTab.XtraTabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabJournalEntries = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Journal = New DevExpress.XtraGrid.GridControl()
        Me.contextJournal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Journal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherNo = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAddPayableItem = New DevExpress.XtraEditors.SimpleButton()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.radVoucherType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtVoucherDate = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabCheck = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdCheckPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCheckAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCheckNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtTmpVoucherNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_Office = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPrintVoucher = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVendorAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabJournalEntries.SuspendLayout()
        CType(Me.Em_Journal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextJournal.SuspendLayout()
        CType(Me.GridView_Journal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radVoucherType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabCheck.SuspendLayout()
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTmpVoucherNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(23, 160)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(105, 17)
        Me.LabelControl9.TabIndex = 757
        Me.LabelControl9.Text = "Name of Claimant"
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = "Select Group"
        Me.txtSupplier.Location = New System.Drawing.Point(135, 155)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSupplier.Properties.DisplayMember = "Supplier"
        Me.txtSupplier.Properties.NullText = ""
        Me.txtSupplier.Properties.PopupView = Me.gridVendorAccount
        Me.txtSupplier.Properties.ValueMember = "vendorid"
        Me.txtSupplier.Size = New System.Drawing.Size(319, 26)
        Me.txtSupplier.TabIndex = 2
        '
        'gridVendorAccount
        '
        Me.gridVendorAccount.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVendorAccount.Name = "gridVendorAccount"
        Me.gridVendorAccount.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVendorAccount.OptionsView.ShowGroupPanel = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Appearance.Options.UseForeColor = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(544, 545)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 30)
        Me.cmdSave.TabIndex = 754
        Me.cmdSave.Text = "Confirm Save"
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPayableItemToolStripMenuItem, Me.EditPayableItemToolStripMenuItem, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(182, 98)
        '
        'AddPayableItemToolStripMenuItem
        '
        Me.AddPayableItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.AddPayableItemToolStripMenuItem.Name = "AddPayableItemToolStripMenuItem"
        Me.AddPayableItemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AddPayableItemToolStripMenuItem.Text = "Add Payable Item"
        '
        'EditPayableItemToolStripMenuItem
        '
        Me.EditPayableItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditPayableItemToolStripMenuItem.Name = "EditPayableItemToolStripMenuItem"
        Me.EditPayableItemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EditPayableItemToolStripMenuItem.Text = "Edit Selected Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(181, 22)
        Me.cmdDelete.Text = "Delete Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.Location = New System.Drawing.Point(23, 257)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.tabDetails
        Me.XtraTabControl2.Size = New System.Drawing.Size(888, 278)
        Me.XtraTabControl2.TabIndex = 759
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetails, Me.tabJournalEntries})
        Me.XtraTabControl2.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabDetails
        '
        Me.tabDetails.Controls.Add(Me.Em)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Size = New System.Drawing.Size(882, 246)
        Me.tabDetails.Text = "Payable Item Details"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(882, 246)
        Me.Em.TabIndex = 715
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsPrint.UsePrintStyles = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Web"
        '
        'tabJournalEntries
        '
        Me.tabJournalEntries.Controls.Add(Me.Em_Journal)
        Me.tabJournalEntries.Name = "tabJournalEntries"
        Me.tabJournalEntries.Size = New System.Drawing.Size(882, 246)
        Me.tabJournalEntries.Text = "Journal Entries"
        '
        'Em_Journal
        '
        Me.Em_Journal.ContextMenuStrip = Me.contextJournal
        Me.Em_Journal.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.Em_Journal.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.Em_Journal.Location = New System.Drawing.Point(0, 0)
        Me.Em_Journal.MainView = Me.GridView_Journal
        Me.Em_Journal.Name = "Em_Journal"
        Me.Em_Journal.Size = New System.Drawing.Size(882, 246)
        Me.Em_Journal.TabIndex = 716
        Me.Em_Journal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Journal})
        '
        'contextJournal
        '
        Me.contextJournal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EditSelectedItemToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator2, Me.ToolStripMenuItem3})
        Me.contextJournal.Name = "gridmenustrip"
        Me.contextJournal.Size = New System.Drawing.Size(182, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "Add Journal Item"
        '
        'EditSelectedItemToolStripMenuItem
        '
        Me.EditSelectedItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditSelectedItemToolStripMenuItem.Name = "EditSelectedItemToolStripMenuItem"
        Me.EditSelectedItemToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EditSelectedItemToolStripMenuItem.Text = "Edit Selected Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem2.Text = "Delete Selected Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem3.Text = "Refresh"
        '
        'GridView_Journal
        '
        Me.GridView_Journal.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.GridView_Journal.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView_Journal.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GridView_Journal.Appearance.Row.Options.UseFont = True
        Me.GridView_Journal.GridControl = Me.Em_Journal
        Me.GridView_Journal.Name = "GridView_Journal"
        Me.GridView_Journal.OptionsBehavior.Editable = False
        Me.GridView_Journal.OptionsPrint.UsePrintStyles = False
        Me.GridView_Journal.OptionsSelection.MultiSelect = True
        Me.GridView_Journal.OptionsView.ColumnAutoWidth = False
        Me.GridView_Journal.OptionsView.ShowFooter = True
        Me.GridView_Journal.OptionsView.ShowGroupPanel = False
        Me.GridView_Journal.PaintStyleName = "Web"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(15, 188)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 17)
        Me.LabelControl3.TabIndex = 761
        Me.LabelControl3.Text = "Disbursement Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(135, 185)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(359, 62)
        Me.txtNote.TabIndex = 3
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.Options.UseFont = True
        Me.lblReference.Appearance.Options.UseTextOptions = True
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(86, 17)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(42, 17)
        Me.lblReference.TabIndex = 763
        Me.lblReference.Text = "DV No."
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.EnterMoveNextControl = True
        Me.txtVoucherNo.Location = New System.Drawing.Point(373, 127)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtVoucherNo.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVoucherNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVoucherNo.Size = New System.Drawing.Size(81, 24)
        Me.txtVoucherNo.TabIndex = 762
        Me.txtVoucherNo.Visible = False
        '
        'cmdAddPayableItem
        '
        Me.cmdAddPayableItem.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPayableItem.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddPayableItem.Appearance.Options.UseFont = True
        Me.cmdAddPayableItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAddPayableItem.Location = New System.Drawing.Point(224, 545)
        Me.cmdAddPayableItem.Name = "cmdAddPayableItem"
        Me.cmdAddPayableItem.Size = New System.Drawing.Size(154, 30)
        Me.cmdAddPayableItem.TabIndex = 764
        Me.cmdAddPayableItem.Text = "Add Payable Item"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(373, 99)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(50, 20)
        Me.mode.TabIndex = 765
        Me.mode.Visible = False
        '
        'radVoucherType
        '
        Me.radVoucherType.EditValue = "check"
        Me.radVoucherType.Location = New System.Drawing.Point(135, 62)
        Me.radVoucherType.Name = "radVoucherType"
        Me.radVoucherType.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.radVoucherType.Properties.Appearance.Options.UseFont = True
        Me.radVoucherType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("check", "Check Voucher Payment"), New DevExpress.XtraEditors.Controls.RadioGroupItem("cash", "Cash Voucher Payment")})
        Me.radVoucherType.Size = New System.Drawing.Size(359, 33)
        Me.radVoucherType.TabIndex = 766
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(135, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(209, 17)
        Me.LabelControl1.TabIndex = 767
        Me.LabelControl1.Text = "Select payment voucher clasification"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(49, 132)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl8.TabIndex = 769
        Me.LabelControl8.Text = "Voucher Date"
        '
        'txtVoucherDate
        '
        Me.txtVoucherDate.EditValue = New Date(CType(0, Long))
        Me.txtVoucherDate.EnterMoveNextControl = True
        Me.txtVoucherDate.Location = New System.Drawing.Point(135, 127)
        Me.txtVoucherDate.Name = "txtVoucherDate"
        Me.txtVoucherDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtVoucherDate.Properties.Appearance.Options.UseFont = True
        Me.txtVoucherDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtVoucherDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtVoucherDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVoucherDate.Size = New System.Drawing.Size(232, 24)
        Me.txtVoucherDate.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(511, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabCheck
        Me.XtraTabControl1.Size = New System.Drawing.Size(400, 235)
        Me.XtraTabControl1.TabIndex = 770
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabCheck})
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.cmdCheckPrint)
        Me.tabCheck.Controls.Add(Me.LabelControl7)
        Me.tabCheck.Controls.Add(Me.LabelControl5)
        Me.tabCheck.Controls.Add(Me.txtCheckDate)
        Me.tabCheck.Controls.Add(Me.txtCheckAmount)
        Me.tabCheck.Controls.Add(Me.LabelControl4)
        Me.tabCheck.Controls.Add(Me.LabelControl6)
        Me.tabCheck.Controls.Add(Me.txtCheckNumber)
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(394, 205)
        Me.tabCheck.Text = "Check Payment Details"
        '
        'cmdCheckPrint
        '
        Me.cmdCheckPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmdCheckPrint.Appearance.Options.UseFont = True
        Me.cmdCheckPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.cmdCheckPrint.Location = New System.Drawing.Point(115, 124)
        Me.cmdCheckPrint.Name = "cmdCheckPrint"
        Me.cmdCheckPrint.Size = New System.Drawing.Size(153, 30)
        Me.cmdCheckPrint.TabIndex = 4
        Me.cmdCheckPrint.Text = "Print Check"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(40, 18)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(138, 17)
        Me.LabelControl7.TabIndex = 729
        Me.LabelControl7.Text = "Check Payment Details"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(42, 74)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 17)
        Me.LabelControl5.TabIndex = 716
        Me.LabelControl5.Text = "Check Date"
        '
        'txtCheckDate
        '
        Me.txtCheckDate.EditValue = New Date(CType(0, Long))
        Me.txtCheckDate.EnterMoveNextControl = True
        Me.txtCheckDate.Location = New System.Drawing.Point(115, 68)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCheckDate.Properties.Appearance.Options.UseFont = True
        Me.txtCheckDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCheckDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCheckDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtCheckDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckDate.Size = New System.Drawing.Size(245, 24)
        Me.txtCheckDate.TabIndex = 2
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.EditValue = "0.00"
        Me.txtCheckAmount.Location = New System.Drawing.Point(115, 96)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCheckAmount.Properties.Appearance.Options.UseFont = True
        Me.txtCheckAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCheckAmount.Properties.Mask.EditMask = "n"
        Me.txtCheckAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckAmount.Size = New System.Drawing.Size(154, 24)
        Me.txtCheckAmount.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(62, 102)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl4.TabIndex = 715
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(48, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 17)
        Me.LabelControl6.TabIndex = 714
        Me.LabelControl6.Text = "Check No."
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.EditValue = ""
        Me.txtCheckNumber.Location = New System.Drawing.Point(115, 41)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCheckNumber.Properties.Appearance.Options.UseFont = True
        Me.txtCheckNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCheckNumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckNumber.Size = New System.Drawing.Size(153, 24)
        Me.txtCheckNumber.TabIndex = 1
        '
        'txtTmpVoucherNo
        '
        Me.txtTmpVoucherNo.EditValue = "SYSTEM GENERATED"
        Me.txtTmpVoucherNo.EnterMoveNextControl = True
        Me.txtTmpVoucherNo.Location = New System.Drawing.Point(135, 14)
        Me.txtTmpVoucherNo.Name = "txtTmpVoucherNo"
        Me.txtTmpVoucherNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTmpVoucherNo.Properties.Appearance.Options.UseFont = True
        Me.txtTmpVoucherNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTmpVoucherNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTmpVoucherNo.Properties.ReadOnly = True
        Me.txtTmpVoucherNo.Size = New System.Drawing.Size(155, 24)
        Me.txtTmpVoucherNo.TabIndex = 771
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.Location = New System.Drawing.Point(135, 99)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select Office"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gv_Office
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Size = New System.Drawing.Size(232, 24)
        Me.txtOffice.TabIndex = 0
        '
        'gv_Office
        '
        Me.gv_Office.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_Office.Name = "gv_Office"
        Me.gv_Office.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_Office.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(56, 103)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl2.TabIndex = 772
        Me.LabelControl2.Text = "Select Office"
        '
        'cmdPrintVoucher
        '
        Me.cmdPrintVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintVoucher.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdPrintVoucher.Appearance.Options.UseFont = True
        Me.cmdPrintVoucher.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrintVoucher.Location = New System.Drawing.Point(384, 545)
        Me.cmdPrintVoucher.Name = "cmdPrintVoucher"
        Me.cmdPrintVoucher.Size = New System.Drawing.Size(154, 30)
        Me.cmdPrintVoucher.TabIndex = 774
        Me.cmdPrintVoucher.Text = "Print Voucher"
        '
        'frmAcctVoucherInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(931, 587)
        Me.Controls.Add(Me.cmdPrintVoucher)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTmpVoucherNo)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtVoucherDate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.radVoucherType)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cmdAddPayableItem)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.txtVoucherNo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcctVoucherInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Voucher"
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVendorAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabJournalEntries.ResumeLayout(False)
        CType(Me.Em_Journal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextJournal.ResumeLayout(False)
        CType(Me.GridView_Journal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radVoucherType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucherDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabCheck.ResumeLayout(False)
        Me.tabCheck.PerformLayout()
        CType(Me.txtCheckDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTmpVoucherNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridVendorAccount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddPayableItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDetails As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabJournalEntries As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Em_Journal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Journal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAddPayableItem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents radVoucherType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVoucherDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabCheck As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmdCheckPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCheckAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCheckNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents contextJournal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTmpVoucherNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_Office As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EditSelectedItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPayableItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintVoucher As DevExpress.XtraEditors.SimpleButton
End Class
