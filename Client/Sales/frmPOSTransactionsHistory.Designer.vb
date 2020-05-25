<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSTransactionsHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSTransactionsHistory))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdVoid = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdReprint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInvoices = New System.Windows.Forms.TabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.tabInteroffice = New System.Windows.Forms.TabPage()
        Me.tabBatch = New System.Windows.Forms.TabPage()
        Me.tabDetails = New System.Windows.Forms.TabPage()
        Me.tabVoid = New System.Windows.Forms.TabPage()
        Me.tabCancelled = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdColumnChooser = New System.Windows.Forms.ToolStripButton()
        Me.cms_em.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabInvoices.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVoid, Me.cmdReprint})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(209, 48)
        '
        'cmdVoid
        '
        Me.cmdVoid.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdVoid.Name = "cmdVoid"
        Me.cmdVoid.Size = New System.Drawing.Size(208, 22)
        Me.cmdVoid.Tag = "1"
        Me.cmdVoid.Text = "Void Selected Transaction"
        '
        'cmdReprint
        '
        Me.cmdReprint.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.cmdReprint.Name = "cmdReprint"
        Me.cmdReprint.Size = New System.Drawing.Size(208, 22)
        Me.cmdReprint.Text = "Reprint Transaction"
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(271, 197)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(86, 22)
        Me.mode.TabIndex = 396
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInvoices)
        Me.TabControl1.Controls.Add(Me.tabInteroffice)
        Me.TabControl1.Controls.Add(Me.tabBatch)
        Me.TabControl1.Controls.Add(Me.tabDetails)
        Me.TabControl1.Controls.Add(Me.tabVoid)
        Me.TabControl1.Controls.Add(Me.tabCancelled)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(941, 436)
        Me.TabControl1.TabIndex = 397
        '
        'tabInvoices
        '
        Me.tabInvoices.Controls.Add(Me.Em)
        Me.tabInvoices.Location = New System.Drawing.Point(4, 24)
        Me.tabInvoices.Name = "tabInvoices"
        Me.tabInvoices.Size = New System.Drawing.Size(933, 408)
        Me.tabInvoices.TabIndex = 3
        Me.tabInvoices.Text = "Charge to Accounts Transaction"
        Me.tabInvoices.UseVisualStyleBackColor = True
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(0, 0)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.Em.Size = New System.Drawing.Size(933, 408)
        Me.Em.TabIndex = 823
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'tabInteroffice
        '
        Me.tabInteroffice.Location = New System.Drawing.Point(4, 24)
        Me.tabInteroffice.Name = "tabInteroffice"
        Me.tabInteroffice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInteroffice.Size = New System.Drawing.Size(933, 408)
        Me.tabInteroffice.TabIndex = 4
        Me.tabInteroffice.Text = "Inter Office Transaction"
        Me.tabInteroffice.UseVisualStyleBackColor = True
        '
        'tabBatch
        '
        Me.tabBatch.Location = New System.Drawing.Point(4, 24)
        Me.tabBatch.Name = "tabBatch"
        Me.tabBatch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBatch.Size = New System.Drawing.Size(933, 408)
        Me.tabBatch.TabIndex = 0
        Me.tabBatch.Text = "Batch Transaction Summary"
        Me.tabBatch.UseVisualStyleBackColor = True
        '
        'tabDetails
        '
        Me.tabDetails.Location = New System.Drawing.Point(4, 24)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetails.Size = New System.Drawing.Size(933, 408)
        Me.tabDetails.TabIndex = 1
        Me.tabDetails.Text = "Detail Transaction History "
        Me.tabDetails.UseVisualStyleBackColor = True
        '
        'tabVoid
        '
        Me.tabVoid.Location = New System.Drawing.Point(4, 24)
        Me.tabVoid.Name = "tabVoid"
        Me.tabVoid.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVoid.Size = New System.Drawing.Size(933, 408)
        Me.tabVoid.TabIndex = 2
        Me.tabVoid.Text = "Void Item Transaction"
        Me.tabVoid.UseVisualStyleBackColor = True
        '
        'tabCancelled
        '
        Me.tabCancelled.Location = New System.Drawing.Point(4, 24)
        Me.tabCancelled.Name = "tabCancelled"
        Me.tabCancelled.Size = New System.Drawing.Size(933, 408)
        Me.tabCancelled.TabIndex = 5
        Me.tabCancelled.Text = "Cancelled Item Transaction"
        Me.tabCancelled.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator3, Me.cmdPrint, Me.ToolStripSeparator2, Me.cmdColumnChooser})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(941, 31)
        Me.ToolStrip3.TabIndex = 398
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrint
        '
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Normal
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 24)
        Me.cmdPrint.Text = "Print Report"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'cmdColumnChooser
        '
        Me.cmdColumnChooser.ForeColor = System.Drawing.Color.White
        Me.cmdColumnChooser.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.cmdColumnChooser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdColumnChooser.Name = "cmdColumnChooser"
        Me.cmdColumnChooser.Size = New System.Drawing.Size(103, 24)
        Me.cmdColumnChooser.Text = "Column Setup"
        '
        'frmPOSTransactionsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(941, 467)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSTransactionsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Transaction History"
        Me.cms_em.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabInvoices.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabBatch As System.Windows.Forms.TabPage
    Friend WithEvents tabDetails As System.Windows.Forms.TabPage
    Friend WithEvents tabVoid As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdVoid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabInvoices As System.Windows.Forms.TabPage
    Friend WithEvents cmdReprint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabInteroffice As System.Windows.Forms.TabPage
    Friend WithEvents tabCancelled As System.Windows.Forms.TabPage
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdColumnChooser As System.Windows.Forms.ToolStripButton
End Class
