<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectParticular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectParticular))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.potypeid = New System.Windows.Forms.TextBox()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.textsearch = New System.Windows.Forms.ToolStripTextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(828, 568)
        Me.TabControl1.TabIndex = 260
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.potypeid)
        Me.tabParticular.Controls.Add(Me.pid)
        Me.tabParticular.Controls.Add(Me.Panel2)
        Me.tabParticular.Controls.Add(Me.MyDataGridView)
        Me.tabParticular.Location = New System.Drawing.Point(4, 22)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(820, 542)
        Me.tabParticular.TabIndex = 1
        Me.tabParticular.Text = "To complete your request please search particular item and add to your request"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'potypeid
        '
        Me.potypeid.Location = New System.Drawing.Point(440, 161)
        Me.potypeid.Name = "potypeid"
        Me.potypeid.Size = New System.Drawing.Size(100, 22)
        Me.potypeid.TabIndex = 349
        Me.potypeid.Visible = False
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid.ForeColor = System.Drawing.Color.Black
        Me.pid.Location = New System.Drawing.Point(467, 506)
        Me.pid.Margin = New System.Windows.Forms.Padding(4)
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(90, 22)
        Me.pid.TabIndex = 348
        Me.pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pid.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 30)
        Me.Panel2.TabIndex = 343
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.textsearch})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(905, 31)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 24)
        Me.ToolStripLabel1.Text = "Search Product"
        '
        'textsearch
        '
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(300, 27)
        Me.textsearch.Text = "Enter keyword here to search.."
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(815, 507)
        Me.MyDataGridView.TabIndex = 1
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(186, 54)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.page_white_go
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EditChapterToolStripMenuItem.Text = "Select Particular Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(182, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(185, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'frmSelectParticular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(828, 568)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelectParticular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Particular Item List"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        Me.tabParticular.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textsearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents potypeid As System.Windows.Forms.TextBox
End Class
