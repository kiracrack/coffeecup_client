<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelFolioRoomInfo
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grpRoomDetails = New System.Windows.Forms.GroupBox()
        Me.txtDateCheckin = New System.Windows.Forms.TextBox()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEditDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Room = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.roomtrncode = New System.Windows.Forms.TextBox()
        Me.Em_Breakdown = New DevExpress.XtraGrid.GridControl()
        Me.cms_Breakdown = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdRefreshDeposit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_Breakdown = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdUpdateBreakdown = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLoadBreakDown = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.lineTransactionHistory = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.grpRoomDetails.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Em_Breakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Breakdown.SuspendLayout()
        CType(Me.GridView_Breakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grpRoomDetails)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1076, 415)
        Me.SplitContainerControl1.SplitterPosition = 343
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'grpRoomDetails
        '
        Me.grpRoomDetails.Controls.Add(Me.txtDateCheckin)
        Me.grpRoomDetails.Controls.Add(Me.folioid)
        Me.grpRoomDetails.Controls.Add(Me.foliono)
        Me.grpRoomDetails.Controls.Add(Me.Em)
        Me.grpRoomDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRoomDetails.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRoomDetails.Location = New System.Drawing.Point(0, 0)
        Me.grpRoomDetails.Name = "grpRoomDetails"
        Me.grpRoomDetails.Size = New System.Drawing.Size(728, 415)
        Me.grpRoomDetails.TabIndex = 825
        Me.grpRoomDetails.TabStop = False
        Me.grpRoomDetails.Text = "Room Details"
        '
        'txtDateCheckin
        '
        Me.txtDateCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateCheckin.ForeColor = System.Drawing.Color.Black
        Me.txtDateCheckin.Location = New System.Drawing.Point(413, 307)
        Me.txtDateCheckin.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDateCheckin.Name = "txtDateCheckin"
        Me.txtDateCheckin.Size = New System.Drawing.Size(139, 23)
        Me.txtDateCheckin.TabIndex = 825
        Me.txtDateCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDateCheckin.Visible = False
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(562, 307)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(31, 23)
        Me.folioid.TabIndex = 824
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(621, 307)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(31, 23)
        Me.foliono.TabIndex = 823
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(3, 25)
        Me.Em.MainView = Me.GridView_Room
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(722, 387)
        Me.Em.TabIndex = 821
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Room})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEditDate, Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(268, 76)
        '
        'cmdEditDate
        '
        Me.cmdEditDate.Image = Global.CoffeecupClient.My.Resources.Resources.users
        Me.cmdEditDate.Name = "cmdEditDate"
        Me.cmdEditDate.Size = New System.Drawing.Size(267, 22)
        Me.cmdEditDate.Text = "Edit Number of Pax on Selected Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.printer
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(267, 22)
        Me.ToolStripMenuItem2.Text = "Print Selected Date Room Folio"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(264, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(267, 22)
        Me.ToolStripMenuItem3.Tag = "1"
        Me.ToolStripMenuItem3.Text = "Refresh Data"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rateid)
        Me.GroupBox1.Controls.Add(Me.roomtrncode)
        Me.GroupBox1.Controls.Add(Me.Em_Breakdown)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 415)
        Me.GroupBox1.TabIndex = 823
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Charge Internal Breakdown"
        '
        'rateid
        '
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(109, 145)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(31, 23)
        Me.rateid.TabIndex = 825
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rateid.Visible = False
        '
        'roomtrncode
        '
        Me.roomtrncode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtrncode.ForeColor = System.Drawing.Color.Black
        Me.roomtrncode.Location = New System.Drawing.Point(109, 112)
        Me.roomtrncode.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtrncode.Name = "roomtrncode"
        Me.roomtrncode.Size = New System.Drawing.Size(31, 23)
        Me.roomtrncode.TabIndex = 824
        Me.roomtrncode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtrncode.Visible = False
        '
        'Em_Breakdown
        '
        Me.Em_Breakdown.ContextMenuStrip = Me.cms_Breakdown
        Me.Em_Breakdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Breakdown.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Breakdown.Location = New System.Drawing.Point(3, 50)
        Me.Em_Breakdown.MainView = Me.GridView_Breakdown
        Me.Em_Breakdown.Name = "Em_Breakdown"
        Me.Em_Breakdown.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Breakdown.Size = New System.Drawing.Size(337, 362)
        Me.Em_Breakdown.TabIndex = 822
        Me.Em_Breakdown.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Breakdown})
        '
        'cms_Breakdown
        '
        Me.cms_Breakdown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRefreshDeposit})
        Me.cms_Breakdown.Name = "ContextMenuStrip1"
        Me.cms_Breakdown.Size = New System.Drawing.Size(141, 26)
        '
        'cmdRefreshDeposit
        '
        Me.cmdRefreshDeposit.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdRefreshDeposit.Name = "cmdRefreshDeposit"
        Me.cmdRefreshDeposit.Size = New System.Drawing.Size(140, 22)
        Me.cmdRefreshDeposit.Tag = "1"
        Me.cmdRefreshDeposit.Text = "Refresh Data"
        '
        'GridView_Breakdown
        '
        Me.GridView_Breakdown.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Breakdown.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Breakdown.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Breakdown.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Breakdown.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Breakdown.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Breakdown.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Breakdown.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Breakdown.Appearance.Row.Options.UseFont = True
        Me.GridView_Breakdown.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Breakdown.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Breakdown.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Breakdown.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Breakdown.GridControl = Me.Em_Breakdown
        Me.GridView_Breakdown.Name = "GridView_Breakdown"
        Me.GridView_Breakdown.OptionsBehavior.Editable = False
        Me.GridView_Breakdown.OptionsSelection.MultiSelect = True
        Me.GridView_Breakdown.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Breakdown.OptionsView.RowAutoHeight = True
        Me.GridView_Breakdown.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdUpdateBreakdown, Me.ToolStripSeparator2, Me.cmdLoadBreakDown})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 19)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(337, 31)
        Me.ToolStrip1.TabIndex = 826
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdUpdateBreakdown
        '
        Me.cmdUpdateBreakdown.ForeColor = System.Drawing.Color.White
        Me.cmdUpdateBreakdown.Image = Global.CoffeecupClient.My.Resources.Resources.exclamation_octagon
        Me.cmdUpdateBreakdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUpdateBreakdown.Name = "cmdUpdateBreakdown"
        Me.cmdUpdateBreakdown.Size = New System.Drawing.Size(170, 24)
        Me.cmdUpdateBreakdown.Text = "Update Internal Breakdown"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdLoadBreakDown
        '
        Me.cmdLoadBreakDown.ForeColor = System.Drawing.Color.White
        Me.cmdLoadBreakDown.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_circle_double
        Me.cmdLoadBreakDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLoadBreakDown.Name = "cmdLoadBreakDown"
        Me.cmdLoadBreakDown.Size = New System.Drawing.Size(127, 24)
        Me.cmdLoadBreakDown.Text = "Load Updated Rate"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.lineTransactionHistory, Me.cmdPrint, Me.ToolStripSeparator4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1076, 31)
        Me.ToolStrip3.TabIndex = 318
        Me.ToolStrip3.Text = "ToolStrip3"
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
        'lineTransactionHistory
        '
        Me.lineTransactionHistory.Name = "lineTransactionHistory"
        Me.lineTransactionHistory.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(208, 24)
        Me.cmdPrint.Text = "Print Room Folio Report Summary"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'frmHotelFolioRoomInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 446)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmHotelFolioRoomInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Folio Room Info"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.grpRoomDetails.ResumeLayout(False)
        Me.grpRoomDetails.PerformLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView_Room, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Em_Breakdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Breakdown.ResumeLayout(False)
        CType(Me.GridView_Breakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Room As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Em_Breakdown As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Breakdown As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents roomtrncode As System.Windows.Forms.TextBox
    Friend WithEvents grpRoomDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cms_Breakdown As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdRefreshDeposit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rateid As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineTransactionHistory As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdUpdateBreakdown As System.Windows.Forms.ToolStripButton
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents cmdLoadBreakDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEditDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDateCheckin As System.Windows.Forms.TextBox
End Class
