<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCurrentTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCurrentTransactions))
        Me.MyDataGridView_Batch = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MyDataGridView_Batch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView_Batch
        '
        Me.MyDataGridView_Batch.AllowUserToAddRows = False
        Me.MyDataGridView_Batch.AllowUserToDeleteRows = False
        Me.MyDataGridView_Batch.AllowUserToResizeRows = False
        Me.MyDataGridView_Batch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Batch.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Batch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Batch.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Batch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Batch.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Batch.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView_Batch.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Batch.Name = "MyDataGridView_Batch"
        Me.MyDataGridView_Batch.ReadOnly = True
        Me.MyDataGridView_Batch.RowHeadersVisible = False
        Me.MyDataGridView_Batch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Batch.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Batch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Batch.Size = New System.Drawing.Size(866, 532)
        Me.MyDataGridView_Batch.TabIndex = 392
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData, Me.ReprintTransactionToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(209, 70)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(208, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Void Selected Transaction"
        '
        'ReprintTransactionToolStripMenuItem
        '
        Me.ReprintTransactionToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.ReprintTransactionToolStripMenuItem.Name = "ReprintTransactionToolStripMenuItem"
        Me.ReprintTransactionToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ReprintTransactionToolStripMenuItem.Text = "Reprint Transaction"
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem2.Text = "Reprint Transaction"
        '
        'frmPOSCurrentTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(866, 532)
        Me.Controls.Add(Me.MyDataGridView_Batch)
        Me.Controls.Add(Me.mode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSCurrentTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Transaction History"
        CType(Me.MyDataGridView_Batch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView_Batch As System.Windows.Forms.DataGridView
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReprintTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
