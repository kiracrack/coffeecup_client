<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSudgestionBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSudgestionBox))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlink = New System.Windows.Forms.LinkLabel()
        Me.cmda1 = New System.Windows.Forms.Button()
        Me.txtattached1 = New System.Windows.Forms.TextBox()
        Me.ckQuotation = New System.Windows.Forms.CheckBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdDownloadApprovedCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDetails)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 335)
        Me.GroupBox1.TabIndex = 386
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please enter Suggestion or Error Report Details"
        '
        'txtDetails
        '
        Me.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtDetails.ForeColor = System.Drawing.Color.Black
        Me.txtDetails.Location = New System.Drawing.Point(3, 19)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(316, 313)
        Me.txtDetails.TabIndex = 379
        '
        'cmdset
        '
        Me.cmdset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(11, 398)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(322, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Submit"
        Me.cmdset.UseVisualStyleBackColor = True
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
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Location = New System.Drawing.Point(338, 62)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(608, 366)
        Me.MyDataGridView.TabIndex = 387
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(766, 8)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 393
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(441, 36)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(68, 19)
        Me.ckasof.TabIndex = 392
        Me.ckasof.Text = "View All"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(614, 10)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 22)
        Me.txttodate.TabIndex = 390
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(339, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 389
        Me.Label1.Text = "Date Filter From"
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(441, 10)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 22)
        Me.txtfrmdate.TabIndex = 388
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(593, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 391
        Me.Label4.Text = "To"
        '
        'txtlink
        '
        Me.txtlink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtlink.AutoSize = True
        Me.txtlink.Location = New System.Drawing.Point(184, 354)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(146, 13)
        Me.txtlink.TabIndex = 397
        Me.txtlink.TabStop = True
        Me.txtlink.Text = "How to compress your files"
        '
        'cmda1
        '
        Me.cmda1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmda1.Enabled = False
        Me.cmda1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmda1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmda1.Location = New System.Drawing.Point(11, 371)
        Me.cmda1.Name = "cmda1"
        Me.cmda1.Size = New System.Drawing.Size(78, 22)
        Me.cmda1.TabIndex = 396
        Me.cmda1.Text = "Browse"
        Me.cmda1.UseCompatibleTextRendering = True
        '
        'txtattached1
        '
        Me.txtattached1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtattached1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtattached1.ForeColor = System.Drawing.Color.Black
        Me.txtattached1.Location = New System.Drawing.Point(91, 371)
        Me.txtattached1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtattached1.Name = "txtattached1"
        Me.txtattached1.ReadOnly = True
        Me.txtattached1.Size = New System.Drawing.Size(242, 22)
        Me.txtattached1.TabIndex = 394
        '
        'ckQuotation
        '
        Me.ckQuotation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckQuotation.AutoSize = True
        Me.ckQuotation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckQuotation.ForeColor = System.Drawing.Color.Black
        Me.ckQuotation.Location = New System.Drawing.Point(12, 351)
        Me.ckQuotation.Name = "ckQuotation"
        Me.ckQuotation.Size = New System.Drawing.Size(114, 19)
        Me.ckQuotation.TabIndex = 395
        Me.ckQuotation.Text = "Add Attachment"
        Me.ckQuotation.UseVisualStyleBackColor = True
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdDownloadApprovedCopy, Me.ExportToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(166, 98)
        '
        'cmdDownloadApprovedCopy
        '
        Me.cmdDownloadApprovedCopy.Image = Global.CoffeecupClient.My.Resources.Resources.inbox_document_text
        Me.cmdDownloadApprovedCopy.Name = "cmdDownloadApprovedCopy"
        Me.cmdDownloadApprovedCopy.Size = New System.Drawing.Size(165, 22)
        Me.cmdDownloadApprovedCopy.Text = "View Attachment"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(162, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(165, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'frmSudgestionBox
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(955, 433)
        Me.Controls.Add(Me.txtlink)
        Me.Controls.Add(Me.cmda1)
        Me.Controls.Add(Me.txtattached1)
        Me.Controls.Add(Me.ckQuotation)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.ckasof)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfrmdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSudgestionBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Coffeecup Suggestion or Error Report Box"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtlink As System.Windows.Forms.LinkLabel
    Friend WithEvents cmda1 As System.Windows.Forms.Button
    Friend WithEvents txtattached1 As System.Windows.Forms.TextBox
    Friend WithEvents ckQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdDownloadApprovedCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
End Class
