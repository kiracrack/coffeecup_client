<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelUpdatePackage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelUpdatePackage))
        Me.txtPackagename = New System.Windows.Forms.TextBox()
        Me.cmdConfirmedBooking = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.code = New System.Windows.Forms.TextBox()
        Me.txtRoomType = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtdateCheckin = New System.Windows.Forms.TextBox()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Package = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.roomrate = New System.Windows.Forms.TabPage()
        Me.txtNight = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.cms_packages = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdAddnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEditSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveSelected = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefreshCompanion = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView_breakdown = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.child = New System.Windows.Forms.TabPage()
        Me.extra = New System.Windows.Forms.TabPage()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Package, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.roomrate.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_packages.SuspendLayout()
        CType(Me.GridView_breakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPackagename
        '
        Me.txtPackagename.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPackagename.ForeColor = System.Drawing.Color.Black
        Me.txtPackagename.Location = New System.Drawing.Point(195, 238)
        Me.txtPackagename.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPackagename.Name = "txtPackagename"
        Me.txtPackagename.Size = New System.Drawing.Size(58, 22)
        Me.txtPackagename.TabIndex = 1
        Me.txtPackagename.Visible = False
        '
        'cmdConfirmedBooking
        '
        Me.cmdConfirmedBooking.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdConfirmedBooking.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmedBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdConfirmedBooking.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmedBooking.Location = New System.Drawing.Point(757, 397)
        Me.cmdConfirmedBooking.Name = "cmdConfirmedBooking"
        Me.cmdConfirmedBooking.Size = New System.Drawing.Size(165, 32)
        Me.cmdConfirmedBooking.TabIndex = 803
        Me.cmdConfirmedBooking.Text = "Confirm Update Package"
        Me.cmdConfirmedBooking.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNightToolStripMenuItem, Me.RemovePackageToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(224, 76)
        '
        'AddNightToolStripMenuItem
        '
        Me.AddNightToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.AddNightToolStripMenuItem.Name = "AddNightToolStripMenuItem"
        Me.AddNightToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AddNightToolStripMenuItem.Text = "Duplicate for Additional Day"
        '
        'RemovePackageToolStripMenuItem
        '
        Me.RemovePackageToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.RemovePackageToolStripMenuItem.Name = "RemovePackageToolStripMenuItem"
        Me.RemovePackageToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RemovePackageToolStripMenuItem.Text = "Remove Selected Package"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripMenuItem4.Tag = "1"
        Me.ToolStripMenuItem4.Text = "Refresh Data"
        '
        'code
        '
        Me.code.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.code.ForeColor = System.Drawing.Color.Black
        Me.code.Location = New System.Drawing.Point(224, 37)
        Me.code.Margin = New System.Windows.Forms.Padding(5)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(57, 23)
        Me.code.TabIndex = 812
        Me.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.code.Visible = False
        '
        'txtRoomType
        '
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.Location = New System.Drawing.Point(195, 261)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.Size = New System.Drawing.Size(58, 22)
        Me.txtRoomType.TabIndex = 813
        Me.txtRoomType.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(224, 70)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(57, 23)
        Me.roomtype.TabIndex = 814
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(535, 122)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(57, 23)
        Me.foliono.TabIndex = 815
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtdateCheckin)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtRoomType)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtPackagename)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Em)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(910, 379)
        Me.SplitContainerControl1.SplitterPosition = 448
        Me.SplitContainerControl1.TabIndex = 816
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtdateCheckin
        '
        Me.txtdateCheckin.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdateCheckin.ForeColor = System.Drawing.Color.Black
        Me.txtdateCheckin.Location = New System.Drawing.Point(195, 293)
        Me.txtdateCheckin.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdateCheckin.Name = "txtdateCheckin"
        Me.txtdateCheckin.Size = New System.Drawing.Size(58, 22)
        Me.txtdateCheckin.TabIndex = 822
        Me.txtdateCheckin.Visible = False
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView_Package
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(448, 379)
        Me.Em.TabIndex = 821
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Package})
        '
        'GridView_Package
        '
        Me.GridView_Package.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Package.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_Package.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Package.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_Package.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Package.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_Package.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_Package.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_Package.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_Package.Appearance.Row.Options.UseFont = True
        Me.GridView_Package.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_Package.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Package.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_Package.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_Package.GridControl = Me.Em
        Me.GridView_Package.Name = "GridView_Package"
        Me.GridView_Package.OptionsBehavior.Editable = False
        Me.GridView_Package.OptionsSelection.MultiSelect = True
        Me.GridView_Package.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Package.OptionsView.ColumnAutoWidth = False
        Me.GridView_Package.OptionsView.RowAutoHeight = True
        Me.GridView_Package.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.roomrate)
        Me.TabControl1.Controls.Add(Me.child)
        Me.TabControl1.Controls.Add(Me.extra)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(457, 379)
        Me.TabControl1.TabIndex = 413
        '
        'roomrate
        '
        Me.roomrate.Controls.Add(Me.txtNight)
        Me.roomrate.Controls.Add(Me.roomtype)
        Me.roomrate.Controls.Add(Me.code)
        Me.roomrate.Controls.Add(Me.GridControl1)
        Me.roomrate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.roomrate.Location = New System.Drawing.Point(4, 24)
        Me.roomrate.Name = "roomrate"
        Me.roomrate.Padding = New System.Windows.Forms.Padding(3)
        Me.roomrate.Size = New System.Drawing.Size(449, 351)
        Me.roomrate.TabIndex = 0
        Me.roomrate.Text = "Adult Rate/Room Rate"
        Me.roomrate.UseVisualStyleBackColor = True
        '
        'txtNight
        '
        Me.txtNight.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNight.ForeColor = System.Drawing.Color.Black
        Me.txtNight.Location = New System.Drawing.Point(178, 164)
        Me.txtNight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNight.Name = "txtNight"
        Me.txtNight.Size = New System.Drawing.Size(60, 22)
        Me.txtNight.TabIndex = 824
        Me.txtNight.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.cms_packages
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridView_breakdown
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(443, 345)
        Me.GridControl1.TabIndex = 822
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_breakdown})
        '
        'cms_packages
        '
        Me.cms_packages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddnew, Me.cmdEditSelected, Me.cmdRemoveSelected, Me.ToolStripSeparator2, Me.cmdRefreshCompanion})
        Me.cms_packages.Name = "ContextMenuStrip1"
        Me.cms_packages.Size = New System.Drawing.Size(165, 98)
        '
        'cmdAddnew
        '
        Me.cmdAddnew.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.cmdAddnew.Name = "cmdAddnew"
        Me.cmdAddnew.Size = New System.Drawing.Size(164, 22)
        Me.cmdAddnew.Text = "Add New"
        '
        'cmdEditSelected
        '
        Me.cmdEditSelected.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEditSelected.Name = "cmdEditSelected"
        Me.cmdEditSelected.Size = New System.Drawing.Size(164, 22)
        Me.cmdEditSelected.Text = "Edit Selected"
        '
        'cmdRemoveSelected
        '
        Me.cmdRemoveSelected.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdRemoveSelected.Name = "cmdRemoveSelected"
        Me.cmdRemoveSelected.Size = New System.Drawing.Size(164, 22)
        Me.cmdRemoveSelected.Text = "Remove Selected"
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
        'GridView_breakdown
        '
        Me.GridView_breakdown.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_breakdown.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView_breakdown.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_breakdown.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView_breakdown.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_breakdown.Appearance.GroupRow.Options.UseFont = True
        Me.GridView_breakdown.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView_breakdown.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView_breakdown.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView_breakdown.Appearance.Row.Options.UseFont = True
        Me.GridView_breakdown.Appearance.Row.Options.UseTextOptions = True
        Me.GridView_breakdown.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_breakdown.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView_breakdown.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView_breakdown.GridControl = Me.GridControl1
        Me.GridView_breakdown.Name = "GridView_breakdown"
        Me.GridView_breakdown.OptionsBehavior.Editable = False
        Me.GridView_breakdown.OptionsSelection.MultiSelect = True
        Me.GridView_breakdown.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_breakdown.OptionsView.RowAutoHeight = True
        Me.GridView_breakdown.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'child
        '
        Me.child.Location = New System.Drawing.Point(4, 24)
        Me.child.Name = "child"
        Me.child.Padding = New System.Windows.Forms.Padding(3)
        Me.child.Size = New System.Drawing.Size(379, 351)
        Me.child.TabIndex = 1
        Me.child.Text = "Child Rate"
        Me.child.UseVisualStyleBackColor = True
        '
        'extra
        '
        Me.extra.Location = New System.Drawing.Point(4, 24)
        Me.extra.Name = "extra"
        Me.extra.Padding = New System.Windows.Forms.Padding(3)
        Me.extra.Size = New System.Drawing.Size(379, 351)
        Me.extra.TabIndex = 2
        Me.extra.Text = "Extra Person Rate"
        Me.extra.UseVisualStyleBackColor = True
        '
        'frmHotelUpdatePackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(934, 435)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.cmdConfirmedBooking)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelUpdatePackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Package"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Package, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.roomrate.ResumeLayout(False)
        Me.roomrate.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_packages.ResumeLayout(False)
        CType(Me.GridView_breakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPackagename As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmedBooking As System.Windows.Forms.Button
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Package As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_breakdown As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents roomrate As System.Windows.Forms.TabPage
    Friend WithEvents child As System.Windows.Forms.TabPage
    Friend WithEvents extra As System.Windows.Forms.TabPage
    Friend WithEvents cms_packages As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdAddnew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEditSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefreshCompanion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNight As System.Windows.Forms.TextBox
    Friend WithEvents RemovePackageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtdateCheckin As System.Windows.Forms.TextBox
End Class
