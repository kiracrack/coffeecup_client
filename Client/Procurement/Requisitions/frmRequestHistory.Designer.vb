<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestHistory))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtRequestLogs_history = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdcancel_history = New System.Windows.Forms.Button()
        Me.MyDataGridView_history = New System.Windows.Forms.DataGridView()
        Me.pid_history = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.tabHistory.SuspendLayout()
        CType(Me.MyDataGridView_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabHistory)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(949, 460)
        Me.TabControl1.TabIndex = 374
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.cmdset)
        Me.tabHistory.Controls.Add(Me.txtRequestLogs_history)
        Me.tabHistory.Controls.Add(Me.Label2)
        Me.tabHistory.Controls.Add(Me.cmdcancel_history)
        Me.tabHistory.Controls.Add(Me.MyDataGridView_history)
        Me.tabHistory.Controls.Add(Me.pid_history)
        Me.tabHistory.Location = New System.Drawing.Point(4, 22)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistory.Size = New System.Drawing.Size(941, 434)
        Me.tabHistory.TabIndex = 1
        Me.tabHistory.Text = "Requisition History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'cmdset
        '
        Me.cmdset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(611, 350)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(150, 30)
        Me.cmdset.TabIndex = 378
        Me.cmdset.Text = "Restore as New"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtRequestLogs_history
        '
        Me.txtRequestLogs_history.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRequestLogs_history.AutoSize = True
        Me.txtRequestLogs_history.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestLogs_history.Location = New System.Drawing.Point(5, 350)
        Me.txtRequestLogs_history.Name = "txtRequestLogs_history"
        Me.txtRequestLogs_history.Size = New System.Drawing.Size(106, 15)
        Me.txtRequestLogs_history.TabIndex = 377
        Me.txtRequestLogs_history.Text = "Total Request Logs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 15)
        Me.Label2.TabIndex = 374
        Me.Label2.Text = "Please select your previous request. "
        '
        'cmdcancel_history
        '
        Me.cmdcancel_history.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcancel_history.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdcancel_history.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdcancel_history.Location = New System.Drawing.Point(767, 350)
        Me.cmdcancel_history.Name = "cmdcancel_history"
        Me.cmdcancel_history.Size = New System.Drawing.Size(150, 30)
        Me.cmdcancel_history.TabIndex = 373
        Me.cmdcancel_history.Text = "Cancel"
        Me.cmdcancel_history.UseVisualStyleBackColor = True
        '
        'MyDataGridView_history
        '
        Me.MyDataGridView_history.AllowUserToDeleteRows = False
        Me.MyDataGridView_history.AllowUserToResizeColumns = False
        Me.MyDataGridView_history.AllowUserToResizeRows = False
        Me.MyDataGridView_history.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView_history.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_history.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_history.Location = New System.Drawing.Point(213, 29)
        Me.MyDataGridView_history.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_history.MultiSelect = False
        Me.MyDataGridView_history.Name = "MyDataGridView_history"
        Me.MyDataGridView_history.ReadOnly = True
        Me.MyDataGridView_history.RowHeadersVisible = False
        Me.MyDataGridView_history.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_history.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_history.Size = New System.Drawing.Size(704, 316)
        Me.MyDataGridView_history.TabIndex = 376
        '
        'pid_history
        '
        Me.pid_history.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pid_history.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.pid_history.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.pid_history.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.pid_history.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pid_history.ForeColor = System.Drawing.Color.Black
        Me.pid_history.FormattingEnabled = True
        Me.pid_history.ItemHeight = 13
        Me.pid_history.Location = New System.Drawing.Point(8, 29)
        Me.pid_history.Margin = New System.Windows.Forms.Padding(4)
        Me.pid_history.MaxDropDownItems = 10
        Me.pid_history.Name = "pid_history"
        Me.pid_history.Size = New System.Drawing.Size(199, 323)
        Me.pid_history.TabIndex = 375
        '
        'frmRequestHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(949, 460)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRequestHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisition History"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.MyDataGridView_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabHistory As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdcancel_history As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_history As System.Windows.Forms.DataGridView
    Friend WithEvents pid_history As System.Windows.Forms.ComboBox
    Friend WithEvents txtRequestLogs_history As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
End Class
