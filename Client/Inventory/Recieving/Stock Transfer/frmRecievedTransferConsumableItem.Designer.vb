<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecievedTransferConsumableitem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecievedTransferConsumableitem))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.Cm = New DevExpress.XtraGrid.GridControl()
        Me.Gridview1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cms_em.SuspendLayout()
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintReportToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(138, 54)
        '
        'PrintReportToolStripMenuItem
        '
        Me.PrintReportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.Print_Hot
        Me.PrintReportToolStripMenuItem.Name = "PrintReportToolStripMenuItem"
        Me.PrintReportToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.PrintReportToolStripMenuItem.Text = "Print Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(137, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'batchcode
        '
        Me.batchcode.Location = New System.Drawing.Point(327, 113)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Size = New System.Drawing.Size(100, 22)
        Me.batchcode.TabIndex = 9
        Me.batchcode.Visible = False
        '
        'Cm
        '
        Me.Cm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cm.Location = New System.Drawing.Point(0, 0)
        Me.Cm.MainView = Me.Gridview1
        Me.Cm.Name = "Cm"
        Me.Cm.Size = New System.Drawing.Size(781, 408)
        Me.Cm.TabIndex = 10
        Me.Cm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Gridview1, Me.GridView2})
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
        'frmRecievedTransferConsumableitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(781, 408)
        Me.Controls.Add(Me.Cm)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRecievedTransferConsumableitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Transfer Item"
        Me.cms_em.ResumeLayout(False)
        CType(Me.Cm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents PrintReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cm As DevExpress.XtraGrid.GridControl
    Friend WithEvents Gridview1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
