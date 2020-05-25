<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLJournalInformation
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabInformation = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTrndate = New DevExpress.XtraEditors.DateEdit()
        Me.txtOffice = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gv_Office = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.officeid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblReference = New DevExpress.XtraEditors.LabelControl()
        Me.txtTicketNo = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSaveVoucher = New DevExpress.XtraEditors.SimpleButton()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.gridmenustrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditExpenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdAddExpense = New DevExpress.XtraEditors.SimpleButton()
        Me.tabTransaction = New DevExpress.XtraTab.XtraTabPage()
        Me.Em_Tickets = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.grid_tickets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTicketNumber = New DevExpress.XtraEditors.TextEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabInformation.SuspendLayout()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridmenustrip.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransaction.SuspendLayout()
        CType(Me.Em_Tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.grid_tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabInformation
        Me.XtraTabControl1.Size = New System.Drawing.Size(721, 567)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInformation, Me.tabTransaction})
        Me.XtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabInformation
        '
        Me.tabInformation.Controls.Add(Me.txtTicketNumber)
        Me.tabInformation.Controls.Add(Me.LabelControl8)
        Me.tabInformation.Controls.Add(Me.txtTrndate)
        Me.tabInformation.Controls.Add(Me.txtOffice)
        Me.tabInformation.Controls.Add(Me.officeid)
        Me.tabInformation.Controls.Add(Me.LabelControl1)
        Me.tabInformation.Controls.Add(Me.mode)
        Me.tabInformation.Controls.Add(Me.LabelControl3)
        Me.tabInformation.Controls.Add(Me.lblReference)
        Me.tabInformation.Controls.Add(Me.txtTicketNo)
        Me.tabInformation.Controls.Add(Me.cmdSaveVoucher)
        Me.tabInformation.Controls.Add(Me.Em)
        Me.tabInformation.Controls.Add(Me.txtDetails)
        Me.tabInformation.Controls.Add(Me.cmdAddExpense)
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Size = New System.Drawing.Size(715, 537)
        Me.tabInformation.Text = "Ticket Information"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(54, 45)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(74, 17)
        Me.LabelControl8.TabIndex = 765
        Me.LabelControl8.Text = "Posting Date"
        '
        'txtTrndate
        '
        Me.txtTrndate.EditValue = New Date(CType(0, Long))
        Me.txtTrndate.EnterMoveNextControl = True
        Me.txtTrndate.Location = New System.Drawing.Point(137, 42)
        Me.txtTrndate.Name = "txtTrndate"
        Me.txtTrndate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTrndate.Properties.Appearance.Options.UseFont = True
        Me.txtTrndate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTrndate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtTrndate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtTrndate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTrndate.Size = New System.Drawing.Size(233, 24)
        Me.txtTrndate.TabIndex = 764
        '
        'txtOffice
        '
        Me.txtOffice.EditValue = ""
        Me.txtOffice.Location = New System.Drawing.Point(137, 70)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOffice.Properties.Appearance.Options.UseFont = True
        Me.txtOffice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOffice.Properties.DisplayMember = "Select Office"
        Me.txtOffice.Properties.NullText = ""
        Me.txtOffice.Properties.PopupView = Me.gv_Office
        Me.txtOffice.Properties.ValueMember = "officeid"
        Me.txtOffice.Size = New System.Drawing.Size(323, 24)
        Me.txtOffice.TabIndex = 763
        '
        'gv_Office
        '
        Me.gv_Office.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gv_Office.Name = "gv_Office"
        Me.gv_Office.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gv_Office.OptionsView.ShowGroupPanel = False
        '
        'officeid
        '
        Me.officeid.EnterMoveNextControl = True
        Me.officeid.Location = New System.Drawing.Point(525, 1)
        Me.officeid.Name = "officeid"
        Me.officeid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.officeid.Properties.Appearance.Options.UseFont = True
        Me.officeid.Size = New System.Drawing.Size(49, 24)
        Me.officeid.TabIndex = 762
        Me.officeid.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(56, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl1.TabIndex = 761
        Me.LabelControl1.Text = "Select Office"
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(580, 3)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(82, 24)
        Me.mode.TabIndex = 759
        Me.mode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 17)
        Me.LabelControl3.TabIndex = 756
        Me.LabelControl3.Text = "Ticket Description"
        '
        'lblReference
        '
        Me.lblReference.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblReference.Appearance.Options.UseFont = True
        Me.lblReference.Appearance.Options.UseTextOptions = True
        Me.lblReference.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblReference.Location = New System.Drawing.Point(43, 17)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(85, 17)
        Me.lblReference.TabIndex = 755
        Me.lblReference.Text = "Ticket Number"
        '
        'txtTicketNo
        '
        Me.txtTicketNo.EditValue = ""
        Me.txtTicketNo.EnterMoveNextControl = True
        Me.txtTicketNo.Location = New System.Drawing.Point(552, 33)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTicketNo.Properties.Appearance.Options.UseFont = True
        Me.txtTicketNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTicketNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTicketNo.Size = New System.Drawing.Size(120, 24)
        Me.txtTicketNo.TabIndex = 754
        Me.txtTicketNo.Visible = False
        '
        'cmdSaveVoucher
        '
        Me.cmdSaveVoucher.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSaveVoucher.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmdSaveVoucher.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSaveVoucher.Appearance.Options.UseFont = True
        Me.cmdSaveVoucher.Location = New System.Drawing.Point(363, 499)
        Me.cmdSaveVoucher.Name = "cmdSaveVoucher"
        Me.cmdSaveVoucher.Size = New System.Drawing.Size(165, 30)
        Me.cmdSaveVoucher.TabIndex = 753
        Me.cmdSaveVoucher.Text = "Save Ticket"
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.gridmenustrip
        GridLevelNode1.RelationName = "Level1"
        Me.Em.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em.Location = New System.Drawing.Point(16, 168)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(682, 325)
        Me.Em.TabIndex = 752
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'gridmenustrip
        '
        Me.gridmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.EditExpenseToolStripMenuItem, Me.cmdDelete, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.gridmenustrip.Name = "gridmenustrip"
        Me.gridmenustrip.Size = New System.Drawing.Size(145, 98)
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'EditExpenseToolStripMenuItem
        '
        Me.EditExpenseToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditExpenseToolStripMenuItem.Name = "EditExpenseToolStripMenuItem"
        Me.EditExpenseToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.EditExpenseToolStripMenuItem.Text = "Edit Item"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(144, 22)
        Me.cmdDelete.Text = "Remove Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
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
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(137, 98)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtDetails.Properties.Appearance.Options.UseFont = True
        Me.txtDetails.Size = New System.Drawing.Size(561, 64)
        Me.txtDetails.TabIndex = 751
        '
        'cmdAddExpense
        '
        Me.cmdAddExpense.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAddExpense.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmdAddExpense.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdAddExpense.Appearance.Options.UseFont = True
        Me.cmdAddExpense.Location = New System.Drawing.Point(192, 499)
        Me.cmdAddExpense.Name = "cmdAddExpense"
        Me.cmdAddExpense.Size = New System.Drawing.Size(165, 30)
        Me.cmdAddExpense.TabIndex = 757
        Me.cmdAddExpense.Text = "Add Item"
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.Em_Tickets)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Size = New System.Drawing.Size(715, 537)
        Me.tabTransaction.Text = "Ticket Transaction"
        '
        'Em_Tickets
        '
        Me.Em_Tickets.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Em_Tickets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Tickets.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Tickets.Location = New System.Drawing.Point(0, 0)
        Me.Em_Tickets.MainView = Me.grid_tickets
        Me.Em_Tickets.Name = "Em_Tickets"
        Me.Em_Tickets.Size = New System.Drawing.Size(715, 537)
        Me.Em_Tickets.TabIndex = 11
        Me.Em_Tickets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_tickets, Me.GridView3})
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditVoucherToolStripMenuItem, Me.cmdViewItem, Me.CancelVoucherToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(193, 98)
        '
        'EditVoucherToolStripMenuItem
        '
        Me.EditVoucherToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.EditVoucherToolStripMenuItem.Name = "EditVoucherToolStripMenuItem"
        Me.EditVoucherToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EditVoucherToolStripMenuItem.Text = "Edit Ticket"
        '
        'cmdViewItem
        '
        Me.cmdViewItem.Image = Global.CoffeecupClient.My.Resources.Resources._164
        Me.cmdViewItem.Name = "cmdViewItem"
        Me.cmdViewItem.Size = New System.Drawing.Size(192, 22)
        Me.cmdViewItem.Text = "View Ticket Details"
        '
        'CancelVoucherToolStripMenuItem
        '
        Me.CancelVoucherToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.CancelVoucherToolStripMenuItem.Name = "CancelVoucherToolStripMenuItem"
        Me.CancelVoucherToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CancelVoucherToolStripMenuItem.Text = "Cancel Selected Ticket"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem1.Text = "Refresh Data"
        '
        'grid_tickets
        '
        Me.grid_tickets.GridControl = Me.Em_Tickets
        Me.grid_tickets.Name = "grid_tickets"
        Me.grid_tickets.OptionsBehavior.Editable = False
        Me.grid_tickets.OptionsPrint.UsePrintStyles = False
        Me.grid_tickets.OptionsSelection.MultiSelect = True
        Me.grid_tickets.OptionsView.ColumnAutoWidth = False
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.Em_Tickets
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.EditValue = "AUTO GENERATE"
        Me.txtTicketNumber.EnterMoveNextControl = True
        Me.txtTicketNumber.Location = New System.Drawing.Point(137, 14)
        Me.txtTicketNumber.Name = "txtTicketNumber"
        Me.txtTicketNumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTicketNumber.Properties.Appearance.Options.UseFont = True
        Me.txtTicketNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTicketNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTicketNumber.Size = New System.Drawing.Size(161, 24)
        Me.txtTicketNumber.TabIndex = 766
        '
        'frmGLJournalInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(721, 567)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.MinimumSize = New System.Drawing.Size(687, 368)
        Me.Name = "frmGLJournalInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entries Transaction"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabInformation.PerformLayout()
        CType(Me.txtTrndate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrndate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridmenustrip.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.Em_Tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.grid_tickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabInformation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTransaction As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblReference As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTicketNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveVoucher As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdAddExpense As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridmenustrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditExpenseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Em_Tickets As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditVoucherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelVoucherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grid_tickets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffice As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gv_Office As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents officeid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTrndate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTicketNumber As DevExpress.XtraEditors.TextEdit
End Class
