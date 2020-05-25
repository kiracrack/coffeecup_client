<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountsPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountsPayable))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPending = New System.Windows.Forms.TabPage()
        Me.Em_Voucher = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Voucher = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.DataGridView_Pending = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdRevise = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestForPaymentApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdCreatePayment = New System.Windows.Forms.ToolStripButton()
        Me.tabCleared = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabPending.SuspendLayout()
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Pending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.tabCleared.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbldescription.Text = "To view accounts payable detail please double click on list view."
        Me.lbldescription.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(456, 15)
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
        Me.lbltitle.Size = New System.Drawing.Size(162, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "List of Accounts Payable"
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
        Me.GroupBox1.Text = "List of Accounts Payable"
        '
        'txtfilter
        '
        Me.txtfilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfilter.Location = New System.Drawing.Point(52, 76)
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
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Search"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabPending)
        Me.TabControl1.Controls.Add(Me.tabCleared)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(7, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(912, 394)
        Me.TabControl1.TabIndex = 343
        '
        'tabPending
        '
        Me.tabPending.Controls.Add(Me.DataGridView_Pending)
        Me.tabPending.Controls.Add(Me.ToolStrip3)
        Me.tabPending.Location = New System.Drawing.Point(4, 24)
        Me.tabPending.Name = "tabPending"
        Me.tabPending.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPending.Size = New System.Drawing.Size(904, 366)
        Me.tabPending.TabIndex = 2
        Me.tabPending.Text = "For Approval Payable"
        Me.tabPending.UseVisualStyleBackColor = True
        '
        'Em_Voucher
        '
        Me.Em_Voucher.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Voucher.Location = New System.Drawing.Point(14, 450)
        Me.Em_Voucher.MainView = Me.GridView_Voucher
        Me.Em_Voucher.Name = "Em_Voucher"
        Me.Em_Voucher.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Voucher.Size = New System.Drawing.Size(901, 336)
        Me.Em_Voucher.TabIndex = 823
        Me.Em_Voucher.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Voucher})
        Me.Em_Voucher.Visible = False
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
        Me.GridView_Voucher.OptionsPrint.UsePrintStyles = False
        Me.GridView_Voucher.OptionsSelection.MultiSelect = True
        Me.GridView_Voucher.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView_Voucher.OptionsView.ColumnAutoWidth = False
        Me.GridView_Voucher.OptionsView.RowAutoHeight = True
        Me.GridView_Voucher.PaintStyleName = "Web"
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'DataGridView_Pending
        '
        Me.DataGridView_Pending.AllowUserToAddRows = False
        Me.DataGridView_Pending.AllowUserToDeleteRows = False
        Me.DataGridView_Pending.AllowUserToResizeColumns = False
        Me.DataGridView_Pending.AllowUserToResizeRows = False
        Me.DataGridView_Pending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView_Pending.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_Pending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView_Pending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView_Pending.ContextMenuStrip = Me.cms_em
        Me.DataGridView_Pending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Pending.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_Pending.Location = New System.Drawing.Point(3, 34)
        Me.DataGridView_Pending.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_Pending.Name = "DataGridView_Pending"
        Me.DataGridView_Pending.ReadOnly = True
        Me.DataGridView_Pending.RowHeadersVisible = False
        Me.DataGridView_Pending.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView_Pending.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Pending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Pending.Size = New System.Drawing.Size(898, 329)
        Me.DataGridView_Pending.TabIndex = 400
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdRevise, Me.ViewDetailsToolStripMenuItem, Me.RequestForPaymentApprovalToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(197, 98)
        '
        'cmdRevise
        '
        Me.cmdRevise.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow
        Me.cmdRevise.Name = "cmdRevise"
        Me.cmdRevise.Size = New System.Drawing.Size(196, 22)
        Me.cmdRevise.Text = "Revise Hold Payable"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ViewDetailsToolStripMenuItem.Text = "View Payable Details"
        '
        'RequestForPaymentApprovalToolStripMenuItem
        '
        Me.RequestForPaymentApprovalToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.RequestForPaymentApprovalToolStripMenuItem.Name = "RequestForPaymentApprovalToolStripMenuItem"
        Me.RequestForPaymentApprovalToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RequestForPaymentApprovalToolStripMenuItem.Text = "Print Accounts Payable"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(193, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(196, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCreatePayment})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(898, 31)
        Me.ToolStrip3.TabIndex = 399
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdCreatePayment
        '
        Me.cmdCreatePayment.ForeColor = System.Drawing.Color.White
        Me.cmdCreatePayment.Image = Global.CoffeecupClient.My.Resources.Resources.money
        Me.cmdCreatePayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCreatePayment.Name = "cmdCreatePayment"
        Me.cmdCreatePayment.Size = New System.Drawing.Size(156, 24)
        Me.cmdCreatePayment.Text = "Create Payment Request"
        '
        'tabCleared
        '
        Me.tabCleared.Controls.Add(Me.MyDataGridView)
        Me.tabCleared.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCleared.Location = New System.Drawing.Point(4, 24)
        Me.tabCleared.Name = "tabCleared"
        Me.tabCleared.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCleared.Size = New System.Drawing.Size(904, 338)
        Me.tabCleared.TabIndex = 0
        Me.tabCleared.Text = "Cleared Payable"
        Me.tabCleared.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(898, 332)
        Me.MyDataGridView.TabIndex = 344
        '
        'frmAccountsPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(927, 517)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Em_Voucher)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccountsPayable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Payabale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPending.ResumeLayout(False)
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Pending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.tabCleared.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCleared As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tabPending As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RequestForPaymentApprovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdCreatePayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView_Pending As System.Windows.Forms.DataGridView
    Friend WithEvents Em_Voucher As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Voucher As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmdRevise As System.Windows.Forms.ToolStripMenuItem
End Class
