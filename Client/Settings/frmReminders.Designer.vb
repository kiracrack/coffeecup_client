<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReminders
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReminders))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdViewLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCloseReminder = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.txtTitle = New System.Windows.Forms.ComboBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCreate = New System.Windows.Forms.TabPage()
        Me.tabOpenReminders = New System.Windows.Forms.TabPage()
        Me.tabCloseReminder = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_close = New System.Windows.Forms.DataGridView()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabCreate.SuspendLayout()
        Me.tabOpenReminders.SuspendLayout()
        Me.tabCloseReminder.SuspendLayout()
        CType(Me.MyDataGridView_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(658, 326)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdViewLogs, Me.cmdCloseReminder, Me.cmdDelete, Me.ExportToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(182, 164)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(181, 22)
        Me.cmdEdit.Text = "Edit Reminder"
        '
        'cmdViewLogs
        '
        Me.cmdViewLogs.Image = Global.CoffeecupClient.My.Resources.Resources.notebook_sticky_note
        Me.cmdViewLogs.Name = "cmdViewLogs"
        Me.cmdViewLogs.Size = New System.Drawing.Size(181, 22)
        Me.cmdViewLogs.Text = "View Reminder Logs"
        '
        'cmdCloseReminder
        '
        Me.cmdCloseReminder.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow1
        Me.cmdCloseReminder.Name = "cmdCloseReminder"
        Me.cmdCloseReminder.Size = New System.Drawing.Size(181, 22)
        Me.cmdCloseReminder.Text = "Close Reminder"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(181, 22)
        Me.cmdDelete.Text = "Delete Reminders"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(178, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(181, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(173, 150)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(197, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Save Reminder"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(78, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 392
        Me.Label1.Text = "Follow up Date"
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(173, 125)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(197, 22)
        Me.txttodate.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtTitle.FormattingEnabled = True
        Me.txtTitle.Location = New System.Drawing.Point(18, 15)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(352, 21)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Select title or add new title.."
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.SystemColors.Window
        Me.txtContent.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtContent.Location = New System.Drawing.Point(18, 42)
        Me.txtContent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(352, 79)
        Me.txtContent.TabIndex = 1
        Me.txtContent.Text = "Content details.."
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(562, 245)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(44, 22)
        Me.mode.TabIndex = 343
        Me.mode.Visible = False
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(512, 245)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(44, 22)
        Me.code.TabIndex = 344
        Me.code.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCreate)
        Me.TabControl1.Controls.Add(Me.tabOpenReminders)
        Me.TabControl1.Controls.Add(Me.tabCloseReminder)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(672, 358)
        Me.TabControl1.TabIndex = 345
        '
        'tabCreate
        '
        Me.tabCreate.Controls.Add(Me.cmdset)
        Me.tabCreate.Controls.Add(Me.code)
        Me.tabCreate.Controls.Add(Me.txtTitle)
        Me.tabCreate.Controls.Add(Me.mode)
        Me.tabCreate.Controls.Add(Me.Label1)
        Me.tabCreate.Controls.Add(Me.txtContent)
        Me.tabCreate.Controls.Add(Me.txttodate)
        Me.tabCreate.Location = New System.Drawing.Point(4, 22)
        Me.tabCreate.Name = "tabCreate"
        Me.tabCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreate.Size = New System.Drawing.Size(664, 332)
        Me.tabCreate.TabIndex = 0
        Me.tabCreate.Text = "Create Reminder"
        Me.tabCreate.UseVisualStyleBackColor = True
        '
        'tabOpenReminders
        '
        Me.tabOpenReminders.Controls.Add(Me.MyDataGridView)
        Me.tabOpenReminders.Location = New System.Drawing.Point(4, 22)
        Me.tabOpenReminders.Name = "tabOpenReminders"
        Me.tabOpenReminders.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOpenReminders.Size = New System.Drawing.Size(664, 332)
        Me.tabOpenReminders.TabIndex = 1
        Me.tabOpenReminders.Text = "Open Reminders"
        Me.tabOpenReminders.UseVisualStyleBackColor = True
        '
        'tabCloseReminder
        '
        Me.tabCloseReminder.Controls.Add(Me.MyDataGridView_close)
        Me.tabCloseReminder.Location = New System.Drawing.Point(4, 22)
        Me.tabCloseReminder.Name = "tabCloseReminder"
        Me.tabCloseReminder.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCloseReminder.Size = New System.Drawing.Size(664, 332)
        Me.tabCloseReminder.TabIndex = 2
        Me.tabCloseReminder.Text = "Closed Reminders"
        Me.tabCloseReminder.UseVisualStyleBackColor = True
        '
        'MyDataGridView_close
        '
        Me.MyDataGridView_close.AllowUserToAddRows = False
        Me.MyDataGridView_close.AllowUserToDeleteRows = False
        Me.MyDataGridView_close.AllowUserToResizeColumns = False
        Me.MyDataGridView_close.AllowUserToResizeRows = False
        Me.MyDataGridView_close.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_close.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_close.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_close.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_close.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_close.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_close.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_close.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_close.MultiSelect = False
        Me.MyDataGridView_close.Name = "MyDataGridView_close"
        Me.MyDataGridView_close.ReadOnly = True
        Me.MyDataGridView_close.RowHeadersVisible = False
        Me.MyDataGridView_close.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_close.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_close.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_close.Size = New System.Drawing.Size(658, 326)
        Me.MyDataGridView_close.TabIndex = 343
        '
        'frmReminders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(672, 358)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReminders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminders"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabCreate.ResumeLayout(False)
        Me.tabCreate.PerformLayout()
        Me.tabOpenReminders.ResumeLayout(False)
        Me.tabCloseReminder.ResumeLayout(False)
        CType(Me.MyDataGridView_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents code As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdViewLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCreate As System.Windows.Forms.TabPage
    Friend WithEvents tabOpenReminders As System.Windows.Forms.TabPage
    Friend WithEvents tabCloseReminder As System.Windows.Forms.TabPage
    Friend WithEvents cmdCloseReminder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView_close As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
End Class
