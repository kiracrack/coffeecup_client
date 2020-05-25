<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedTransferFFE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivedTransferFFE))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabInComing = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdReceived = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFFEProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabInTransit = New System.Windows.Forms.TabPage()
        Me.tabTransfered = New System.Windows.Forms.TabPage()
        Me.tabCancelled = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintPreview = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.tabInComing.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabInComing)
        Me.TabControl1.Controls.Add(Me.tabInTransit)
        Me.TabControl1.Controls.Add(Me.tabTransfered)
        Me.TabControl1.Controls.Add(Me.tabCancelled)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TabControl1.Location = New System.Drawing.Point(7, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(896, 502)
        Me.TabControl1.TabIndex = 418
        '
        'tabInComing
        '
        Me.tabInComing.Controls.Add(Me.MyDataGridView)
        Me.tabInComing.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tabInComing.Location = New System.Drawing.Point(4, 24)
        Me.tabInComing.Name = "tabInComing"
        Me.tabInComing.Size = New System.Drawing.Size(888, 474)
        Me.tabInComing.TabIndex = 4
        Me.tabInComing.Text = "In Coming Summary"
        Me.tabInComing.UseVisualStyleBackColor = True
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
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(888, 474)
        Me.MyDataGridView.TabIndex = 412
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdReceived, Me.cmdCancel, Me.ViewFFEProfileToolStripMenuItem, Me.ToolStripSeparator1, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(158, 98)
        '
        'cmdReceived
        '
        Me.cmdReceived.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdReceived.Name = "cmdReceived"
        Me.cmdReceived.Size = New System.Drawing.Size(157, 22)
        Me.cmdReceived.Text = "Received FFE"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.slash
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(157, 22)
        Me.cmdCancel.Text = "Cancel Transfer"
        '
        'ViewFFEProfileToolStripMenuItem
        '
        Me.ViewFFEProfileToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list
        Me.ViewFFEProfileToolStripMenuItem.Name = "ViewFFEProfileToolStripMenuItem"
        Me.ViewFFEProfileToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewFFEProfileToolStripMenuItem.Text = "View FFE Profile"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(157, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh List"
        '
        'tabInTransit
        '
        Me.tabInTransit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tabInTransit.Location = New System.Drawing.Point(4, 24)
        Me.tabInTransit.Name = "tabInTransit"
        Me.tabInTransit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInTransit.Size = New System.Drawing.Size(888, 474)
        Me.tabInTransit.TabIndex = 1
        Me.tabInTransit.Text = "In Transit Summary"
        Me.tabInTransit.UseVisualStyleBackColor = True
        '
        'tabTransfered
        '
        Me.tabTransfered.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tabTransfered.Location = New System.Drawing.Point(4, 24)
        Me.tabTransfered.Name = "tabTransfered"
        Me.tabTransfered.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransfered.Size = New System.Drawing.Size(888, 474)
        Me.tabTransfered.TabIndex = 2
        Me.tabTransfered.Text = "Transfered Summary"
        Me.tabTransfered.UseVisualStyleBackColor = True
        '
        'tabCancelled
        '
        Me.tabCancelled.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tabCancelled.Location = New System.Drawing.Point(4, 24)
        Me.tabCancelled.Name = "tabCancelled"
        Me.tabCancelled.Size = New System.Drawing.Size(888, 474)
        Me.tabCancelled.TabIndex = 3
        Me.tabCancelled.Text = "Cancelled Summary"
        Me.tabCancelled.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdlogin)
        Me.GroupBox1.Controls.Add(Me.ckasof)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtfrmdate)
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(900, 70)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters and Printing Setup"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(434, 18)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 296
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Enabled = False
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(109, 45)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(129, 19)
        Me.ckasof.TabIndex = 295
        Me.ckasof.Text = "Use as of Date Filter"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Enabled = False
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(282, 19)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 23)
        Me.txttodate.TabIndex = 293
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 292
        Me.Label5.Text = "Date Filter From"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Enabled = False
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(109, 19)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 23)
        Me.txtfrmdate.TabIndex = 291
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.Location = New System.Drawing.Point(633, 36)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(260, 23)
        Me.txtsearch.TabIndex = 276
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(587, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 277
        Me.Label6.Text = "Search"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(261, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 15)
        Me.Label7.TabIndex = 294
        Me.Label7.Text = "To"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator3, Me.cmdPrint, Me.ToolStripSeparator5, Me.cmdPrintPreview})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(914, 31)
        Me.ToolStrip3.TabIndex = 419
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrintPreview
        '
        Me.cmdPrintPreview.ForeColor = System.Drawing.Color.White
        Me.cmdPrintPreview.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.cmdPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.Size = New System.Drawing.Size(103, 24)
        Me.cmdPrintPreview.Text = "Export to Excel"
        '
        'frmReceivedTransferFFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(914, 619)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(889, 488)
        Me.Name = "frmReceivedTransferFFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFE Transfer Management"
        Me.TabControl1.ResumeLayout(False)
        Me.tabInComing.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabInTransit As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tabTransfered As System.Windows.Forms.TabPage
    Friend WithEvents tabCancelled As System.Windows.Forms.TabPage
    Friend WithEvents tabInComing As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdReceived As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFFEProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
