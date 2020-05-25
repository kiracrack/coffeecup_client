<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchStockout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatchStockout))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdFind = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSaveAndFinish = New System.Windows.Forms.ToolStripButton()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Cm = New DevExpress.XtraGrid.GridControl()
        Me.Mainmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtStockouttype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateStockout = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Stockouttypeid = New System.Windows.Forms.TextBox()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mainmenu.SuspendLayout()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(50, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(362, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this form to update inventory to main server"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(13, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(610, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(50, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(168, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Batch Stockout Inventory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Batch Code"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(855, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFind, Me.ToolStripSeparator1, Me.cmdSaveAndFinish})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(855, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdFind
        '
        Me.cmdFind.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.ForeColor = System.Drawing.Color.White
        Me.cmdFind.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(127, 24)
        Me.cmdFind.Text = "Browse Inventory"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cmdSaveAndFinish
        '
        Me.cmdSaveAndFinish.ForeColor = System.Drawing.Color.White
        Me.cmdSaveAndFinish.Image = Global.CoffeecupClient.My.Resources.Resources.email_go
        Me.cmdSaveAndFinish.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSaveAndFinish.Name = "cmdSaveAndFinish"
        Me.cmdSaveAndFinish.Size = New System.Drawing.Size(154, 24)
        Me.cmdSaveAndFinish.Text = "Confirm Batch Stockout"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Up_32x32__2_
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(17, 14)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(32, 32)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.ProgressBarControl1)
        Me.GroupControl2.Controls.Add(Me.Cm)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 136)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(855, 340)
        Me.GroupControl2.TabIndex = 518
        Me.GroupControl2.Text = "Selected Particular for Stockout"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(2, 319)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(851, 19)
        Me.ProgressBarControl1.TabIndex = 589
        Me.ProgressBarControl1.Visible = False
        '
        'Cm
        '
        Me.Cm.ContextMenuStrip = Me.Mainmenu
        Me.Cm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cm.Location = New System.Drawing.Point(2, 24)
        Me.Cm.MainView = Me.Gridview1
        Me.Cm.Name = "Cm"
        Me.Cm.Size = New System.Drawing.Size(851, 314)
        Me.Cm.TabIndex = 0
        Me.Cm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.GridView2})
        '
        'Mainmenu
        '
        Me.Mainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolRemove, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.Mainmenu.Name = "ContextMenuStrip1"
        Me.Mainmenu.Size = New System.Drawing.Size(152, 54)
        '
        'toolRemove
        '
        Me.toolRemove.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.toolRemove.Name = "toolRemove"
        Me.toolRemove.Size = New System.Drawing.Size(151, 22)
        Me.toolRemove.Text = "Removed Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(148, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Data"
        '
        'Gridview1
        '
        Me.Gridview1.GridControl = Me.Cm
        Me.Gridview1.Name = "Gridview1"
        Me.Gridview1.OptionsBehavior.Editable = False
        Me.Gridview1.OptionsSelection.MultiSelect = True
        Me.Gridview1.OptionsView.ColumnAutoWidth = False
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Cm
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        '
        'txtStockouttype
        '
        Me.txtStockouttype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtStockouttype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtStockouttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStockouttype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockouttype.ForeColor = System.Drawing.Color.Black
        Me.txtStockouttype.FormattingEnabled = True
        Me.txtStockouttype.ItemHeight = 13
        Me.txtStockouttype.Location = New System.Drawing.Point(218, 73)
        Me.txtStockouttype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockouttype.Name = "txtStockouttype"
        Me.txtStockouttype.Size = New System.Drawing.Size(199, 21)
        Me.txtStockouttype.TabIndex = 519
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(215, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 520
        Me.Label2.Text = "Stockout Type"
        '
        'txtDateStockout
        '
        Me.txtDateStockout.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateStockout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateStockout.Location = New System.Drawing.Point(424, 72)
        Me.txtDateStockout.Name = "txtDateStockout"
        Me.txtDateStockout.Size = New System.Drawing.Size(199, 22)
        Me.txtDateStockout.TabIndex = 521
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(421, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 522
        Me.Label3.Text = "Stockout Date"
        '
        'Stockouttypeid
        '
        Me.Stockouttypeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Stockouttypeid.ForeColor = System.Drawing.Color.Black
        Me.Stockouttypeid.Location = New System.Drawing.Point(759, 36)
        Me.Stockouttypeid.Margin = New System.Windows.Forms.Padding(4)
        Me.Stockouttypeid.Name = "Stockouttypeid"
        Me.Stockouttypeid.ReadOnly = True
        Me.Stockouttypeid.Size = New System.Drawing.Size(47, 22)
        Me.Stockouttypeid.TabIndex = 590
        Me.Stockouttypeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Stockouttypeid.Visible = False
        '
        'txtBatch
        '
        Me.txtBatch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatch.ForeColor = System.Drawing.Color.Black
        Me.txtBatch.Location = New System.Drawing.Point(16, 71)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(199, 22)
        Me.txtBatch.TabIndex = 591
        Me.txtBatch.Text = "SYSTEM GENERATED"
        Me.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBatchStockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(879, 486)
        Me.Controls.Add(Me.txtBatch)
        Me.Controls.Add(Me.Stockouttypeid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDateStockout)
        Me.Controls.Add(Me.txtStockouttype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBatchStockout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Stockout Inventory"
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mainmenu.ResumeLayout(False)
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSaveAndFinish As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Cm As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Mainmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtStockouttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateStockout As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Stockouttypeid As System.Windows.Forms.TextBox
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
End Class
