<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCottagesSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCottagesSummary))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OccupieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReserveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseSelectedTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetSortOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 41)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(725, 473)
        Me.MyDataGridView.TabIndex = 392
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OccupieToolStripMenuItem, Me.ReserveToolStripMenuItem, Me.CloseSelectedTransactionToolStripMenuItem, Me.cmdLocalData, Me.SetSortOrderToolStripMenuItem, Me.ToolStripSeparator1, Me.RefreshToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(210, 142)
        '
        'OccupieToolStripMenuItem
        '
        Me.OccupieToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.xfn_colleague_met
        Me.OccupieToolStripMenuItem.Name = "OccupieToolStripMenuItem"
        Me.OccupieToolStripMenuItem.ShortcutKeyDisplayString = "Space"
        Me.OccupieToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.OccupieToolStripMenuItem.Text = "Check-in"
        '
        'ReserveToolStripMenuItem
        '
        Me.ReserveToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.xfn_friend_met
        Me.ReserveToolStripMenuItem.Name = "ReserveToolStripMenuItem"
        Me.ReserveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReserveToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ReserveToolStripMenuItem.Text = "Reserve"
        '
        'CloseSelectedTransactionToolStripMenuItem
        '
        Me.CloseSelectedTransactionToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.xfn_sweetheart_met
        Me.CloseSelectedTransactionToolStripMenuItem.Name = "CloseSelectedTransactionToolStripMenuItem"
        Me.CloseSelectedTransactionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CloseSelectedTransactionToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CloseSelectedTransactionToolStripMenuItem.Text = "Close Transaction"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.user__minus
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.cmdLocalData.Size = New System.Drawing.Size(209, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Cancel Transaction"
        '
        'SetSortOrderToolStripMenuItem
        '
        Me.SetSortOrderToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.edit_line_spacing
        Me.SetSortOrderToolStripMenuItem.Name = "SetSortOrderToolStripMenuItem"
        Me.SetSortOrderToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SetSortOrderToolStripMenuItem.Text = "Set Sort Order"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
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
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(53, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(331, 23)
        Me.txtsearch.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 398
        Me.Label3.Text = "Search"
        '
        'frmHotelCottagesSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(738, 518)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelCottagesSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cottages and Tables Summary"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseSelectedTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OccupieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReserveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SetSortOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
