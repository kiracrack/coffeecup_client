<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidationForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVoucherAmount = New System.Windows.Forms.TextBox()
        Me.voucherno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDescription = New System.Windows.Forms.TabPage()
        Me.Em_Voucher = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Voucher = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabOtherExpense = New System.Windows.Forms.TabPage()
        Me.Em_OtherExpense = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview_OtherExpense = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView_Summary = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.txtAmountSpend = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmountRefunded = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmountReimbursed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.companyid = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabDescription.SuspendLayout()
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOtherExpense.SuspendLayout()
        CType(Me.Em_OtherExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Gridview_OtherExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParticular.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(115, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 492
        Me.Label2.Text = "Voucher No."
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtVoucherAmount.ForeColor = System.Drawing.Color.Black
        Me.txtVoucherAmount.Location = New System.Drawing.Point(195, 41)
        Me.txtVoucherAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVoucherAmount.Name = "txtVoucherAmount"
        Me.txtVoucherAmount.ReadOnly = True
        Me.txtVoucherAmount.Size = New System.Drawing.Size(159, 25)
        Me.txtVoucherAmount.TabIndex = 490
        Me.txtVoucherAmount.Text = "0.00"
        Me.txtVoucherAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'voucherno
        '
        Me.voucherno.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.voucherno.ForeColor = System.Drawing.Color.Black
        Me.voucherno.Location = New System.Drawing.Point(195, 13)
        Me.voucherno.Margin = New System.Windows.Forms.Padding(5)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(95, 25)
        Me.voucherno.TabIndex = 479
        Me.voucherno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(118, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 487
        Me.Label5.Text = "DV Amount"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabDescription)
        Me.TabControl1.Controls.Add(Me.tabOtherExpense)
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(365, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 489)
        Me.TabControl1.TabIndex = 494
        '
        'tabDescription
        '
        Me.tabDescription.Controls.Add(Me.Em_Voucher)
        Me.tabDescription.Location = New System.Drawing.Point(4, 24)
        Me.tabDescription.Name = "tabDescription"
        Me.tabDescription.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDescription.Size = New System.Drawing.Size(648, 461)
        Me.tabDescription.TabIndex = 2
        Me.tabDescription.Text = "Expense Summary"
        Me.tabDescription.UseVisualStyleBackColor = True
        '
        'Em_Voucher
        '
        Me.Em_Voucher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_Voucher.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em_Voucher.Location = New System.Drawing.Point(3, 3)
        Me.Em_Voucher.MainView = Me.GridView_Voucher
        Me.Em_Voucher.Name = "Em_Voucher"
        Me.Em_Voucher.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit2})
        Me.Em_Voucher.Size = New System.Drawing.Size(642, 455)
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
        'tabOtherExpense
        '
        Me.tabOtherExpense.Controls.Add(Me.Em_OtherExpense)
        Me.tabOtherExpense.Location = New System.Drawing.Point(4, 24)
        Me.tabOtherExpense.Name = "tabOtherExpense"
        Me.tabOtherExpense.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOtherExpense.Size = New System.Drawing.Size(648, 461)
        Me.tabOtherExpense.TabIndex = 3
        Me.tabOtherExpense.Text = "Additional Direct Expense"
        Me.tabOtherExpense.UseVisualStyleBackColor = True
        '
        'Em_OtherExpense
        '
        Me.Em_OtherExpense.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Em_OtherExpense.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Em_OtherExpense.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Em_OtherExpense.Location = New System.Drawing.Point(3, 3)
        Me.Em_OtherExpense.MainView = Me.Gridview_OtherExpense
        Me.Em_OtherExpense.Name = "Em_OtherExpense"
        Me.Em_OtherExpense.Size = New System.Drawing.Size(642, 455)
        Me.Em_OtherExpense.TabIndex = 717
        Me.Em_OtherExpense.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview_OtherExpense})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.ToolStripSeparator2, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "gridmenustrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__plus
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem1.Text = "Add Other Expense"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem3.Text = "Edit Selected Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "Cancel Selected Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem4.Text = "Refresh"
        '
        'Gridview_OtherExpense
        '
        Me.Gridview_OtherExpense.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Gridview_OtherExpense.Appearance.FooterPanel.Options.UseFont = True
        Me.Gridview_OtherExpense.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.Gridview_OtherExpense.Appearance.Row.Options.UseFont = True
        Me.Gridview_OtherExpense.GridControl = Me.Em_OtherExpense
        Me.Gridview_OtherExpense.Name = "Gridview_OtherExpense"
        Me.Gridview_OtherExpense.OptionsBehavior.Editable = False
        Me.Gridview_OtherExpense.OptionsPrint.UsePrintStyles = False
        Me.Gridview_OtherExpense.OptionsSelection.MultiSelect = True
        Me.Gridview_OtherExpense.OptionsView.ColumnAutoWidth = False
        Me.Gridview_OtherExpense.OptionsView.ShowFooter = True
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.Em)
        Me.tabParticular.Location = New System.Drawing.Point(4, 24)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(648, 461)
        Me.tabParticular.TabIndex = 0
        Me.tabParticular.Text = "Actual Expense Reference"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'Em
        '
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(3, 3)
        Me.Em.MainView = Me.GridView_Summary
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.Em.Size = New System.Drawing.Size(642, 455)
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
        'txtAmountSpend
        '
        Me.txtAmountSpend.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmountSpend.ForeColor = System.Drawing.Color.Black
        Me.txtAmountSpend.Location = New System.Drawing.Point(195, 69)
        Me.txtAmountSpend.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountSpend.Name = "txtAmountSpend"
        Me.txtAmountSpend.ReadOnly = True
        Me.txtAmountSpend.Size = New System.Drawing.Size(159, 25)
        Me.txtAmountSpend.TabIndex = 496
        Me.txtAmountSpend.Text = "0.00"
        Me.txtAmountSpend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(71, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 495
        Me.Label3.Text = "Total Amount Spend"
        '
        'txtAmountRefunded
        '
        Me.txtAmountRefunded.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmountRefunded.ForeColor = System.Drawing.Color.Black
        Me.txtAmountRefunded.Location = New System.Drawing.Point(195, 97)
        Me.txtAmountRefunded.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountRefunded.Name = "txtAmountRefunded"
        Me.txtAmountRefunded.ReadOnly = True
        Me.txtAmountRefunded.Size = New System.Drawing.Size(159, 25)
        Me.txtAmountRefunded.TabIndex = 498
        Me.txtAmountRefunded.Text = "0.00"
        Me.txtAmountRefunded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 497
        Me.Label1.Text = "Amount Refunded"
        '
        'txtAmountReimbursed
        '
        Me.txtAmountReimbursed.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmountReimbursed.ForeColor = System.Drawing.Color.Black
        Me.txtAmountReimbursed.Location = New System.Drawing.Point(195, 125)
        Me.txtAmountReimbursed.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountReimbursed.Name = "txtAmountReimbursed"
        Me.txtAmountReimbursed.ReadOnly = True
        Me.txtAmountReimbursed.Size = New System.Drawing.Size(159, 25)
        Me.txtAmountReimbursed.TabIndex = 500
        Me.txtAmountReimbursed.Text = "0.00"
        Me.txtAmountReimbursed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(40, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 15)
        Me.Label4.TabIndex = 499
        Me.Label4.Text = "Amount to be Reimbursed"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAttachment.Location = New System.Drawing.Point(31, 158)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(159, 30)
        Me.cmdAttachment.TabIndex = 501
        Me.cmdAttachment.Text = "Print Liquidation"
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(193, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 30)
        Me.Button1.TabIndex = 502
        Me.Button1.Text = "Submit Liquidation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'companyid
        '
        Me.companyid.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.companyid.ForeColor = System.Drawing.Color.Black
        Me.companyid.Location = New System.Drawing.Point(239, 209)
        Me.companyid.Margin = New System.Windows.Forms.Padding(5)
        Me.companyid.Name = "companyid"
        Me.companyid.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(95, 25)
        Me.companyid.TabIndex = 503
        Me.companyid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.companyid.Visible = False
        '
        'frmLiquidationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1033, 513)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.txtAmountReimbursed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmountRefunded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmountSpend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVoucherAmount)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(711, 552)
        Me.Name = "frmLiquidationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidation Form"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDescription.ResumeLayout(False)
        CType(Me.Em_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOtherExpense.ResumeLayout(False)
        CType(Me.Em_OtherExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Gridview_OtherExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParticular.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView_Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVoucherAmount As System.Windows.Forms.TextBox
    Friend WithEvents voucherno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDescription As System.Windows.Forms.TabPage
    Friend WithEvents Em_Voucher As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Voucher As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView_Summary As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents txtAmountSpend As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmountRefunded As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmountReimbursed As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tabOtherExpense As System.Windows.Forms.TabPage
    Friend WithEvents Em_OtherExpense As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gridview_OtherExpense As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents companyid As System.Windows.Forms.TextBox
End Class
