<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryLedger))
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.itemid = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.txtfrmdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(151, 54)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(150, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'itemid
        '
        Me.itemid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemid.ForeColor = System.Drawing.Color.Black
        Me.itemid.Location = New System.Drawing.Point(629, 170)
        Me.itemid.Margin = New System.Windows.Forms.Padding(4)
        Me.itemid.Name = "itemid"
        Me.itemid.ReadOnly = True
        Me.itemid.Size = New System.Drawing.Size(90, 22)
        Me.itemid.TabIndex = 350
        Me.itemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemid.Visible = False
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
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 65)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(913, 393)
        Me.MyDataGridView.TabIndex = 349
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose, Me.ToolStripSeparator3, Me.cmdPrint})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(913, 31)
        Me.ToolStrip3.TabIndex = 352
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
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM dd, yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(288, 36)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(150, 22)
        Me.txttodate.TabIndex = 355
        '
        'txtfrmdate
        '
        Me.txtfrmdate.CustomFormat = "MMMM dd, yyyy"
        Me.txtfrmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtfrmdate.Location = New System.Drawing.Point(115, 36)
        Me.txtfrmdate.Name = "txtfrmdate"
        Me.txtfrmdate.Size = New System.Drawing.Size(150, 22)
        Me.txtfrmdate.TabIndex = 353
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(267, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Date Period From"
        '
        'cmdlogin
        '
        Me.cmdlogin.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.cmdlogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdlogin.Location = New System.Drawing.Point(441, 35)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(36, 25)
        Me.cmdlogin.TabIndex = 357
        Me.cmdlogin.UseVisualStyleBackColor = True
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(629, 200)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(90, 22)
        Me.officeid.TabIndex = 358
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'frmInventoryLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(913, 458)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.cmdlogin)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.txtfrmdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.itemid)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.cmdreset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventoryLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Ledger"
        Me.cms_em.ResumeLayout(False)
        CType(Me.MyDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip3.ResumeLayout(false)
        Me.ToolStrip3.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents itemid As System.Windows.Forms.TextBox
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfrmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents officeid As System.Windows.Forms.TextBox
End Class
