<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemindersHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemindersHistory))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdDownloadApprovedCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(4, 65)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(493, 344)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdDownloadApprovedCopy, Me.ReportHistoryToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(153, 120)
        '
        'cmdDownloadApprovedCopy
        '
        Me.cmdDownloadApprovedCopy.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdDownloadApprovedCopy.Name = "cmdDownloadApprovedCopy"
        Me.cmdDownloadApprovedCopy.Size = New System.Drawing.Size(152, 22)
        Me.cmdDownloadApprovedCopy.Text = "Edit Reminder"
        '
        'ReportHistoryToolStripMenuItem
        '
        Me.ReportHistoryToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook_sticky_note
        Me.ReportHistoryToolStripMenuItem.Name = "ReportHistoryToolStripMenuItem"
        Me.ReportHistoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportHistoryToolStripMenuItem.Text = "Report History"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(152, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'cmdset
        '
        Me.cmdset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(435, 2)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(62, 58)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Post Update"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContent.BackColor = System.Drawing.SystemColors.Window
        Me.txtContent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContent.Location = New System.Drawing.Point(4, 2)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(430, 57)
        Me.txtContent.TabIndex = 0
        Me.txtContent.Text = "Post update.."
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(254, 130)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(44, 22)
        Me.mode.TabIndex = 343
        Me.mode.Visible = False
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(204, 130)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(44, 22)
        Me.code.TabIndex = 344
        Me.code.Visible = False
        '
        'frmRemindersHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 411)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtContent)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRemindersHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdDownloadApprovedCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
