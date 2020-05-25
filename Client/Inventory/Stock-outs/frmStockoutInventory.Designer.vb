<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockoutInventory))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.Mainmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.inventoryGrid = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtfilter = New System.Windows.Forms.ToolStripTextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mainmenu.SuspendLayout()
        CType(Me.inventoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(389, 451)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(99, 30)
        Me.cmdreset.TabIndex = 8
        Me.cmdreset.Text = "Reset"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(231, 451)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(152, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Send Request"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 527)
        Me.TabControl1.TabIndex = 260
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.Em)
        Me.tabParticular.Controls.Add(Me.Panel2)
        Me.tabParticular.Location = New System.Drawing.Point(4, 22)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(767, 501)
        Me.tabParticular.TabIndex = 1
        Me.tabParticular.Text = "To complete your request please search particular item and add to your batch"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'Em
        '
        Me.Em.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Em.ContextMenuStrip = Me.Mainmenu
        Me.Em.Location = New System.Drawing.Point(3, 35)
        Me.Em.MainView = Me.inventoryGrid
        Me.Em.Name = "Em"
        Me.Em.Size = New System.Drawing.Size(761, 463)
        Me.Em.TabIndex = 344
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.inventoryGrid})
        '
        'Mainmenu
        '
        Me.Mainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuView, Me.ToolStripSeparator1, Me.RefreshDataToolStripMenuItem})
        Me.Mainmenu.Name = "ContextMenuStrip1"
        Me.Mainmenu.Size = New System.Drawing.Size(141, 54)
        '
        'menuView
        '
        Me.menuView.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_curve_180
        Me.menuView.Name = "menuView"
        Me.menuView.Size = New System.Drawing.Size(140, 22)
        Me.menuView.Text = "Select Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'inventoryGrid
        '
        Me.inventoryGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.inventoryGrid.GridControl = Me.Em
        Me.inventoryGrid.Name = "inventoryGrid"
        Me.inventoryGrid.OptionsBehavior.Editable = False
        Me.inventoryGrid.OptionsSelection.MultiSelect = True
        Me.inventoryGrid.OptionsSelection.UseIndicatorForSelection = False
        Me.inventoryGrid.OptionsView.ColumnAutoWidth = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtfilter})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(852, 31)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 24)
        Me.ToolStripLabel1.Text = "Search"
        '
        'txtfilter
        '
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(250, 27)
        Me.txtfilter.Text = "Enter keyword here to search.."
        '
        'frmStockoutInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(775, 527)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockoutInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Stock Inventory for Stock Out"
        Me.TabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mainmenu.ResumeLayout(False)
        CType(Me.inventoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtfilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents inventoryGrid As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Mainmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
