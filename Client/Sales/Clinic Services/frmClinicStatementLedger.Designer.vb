<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicStatementLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicStatementLedger))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.trnid = New System.Windows.Forms.Label()
        Me.txtPackageName = New System.Windows.Forms.Label()
        Me.txtDateTransaction = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cifd = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.txtServiceNo = New System.Windows.Forms.Label()
        Me.txtPackageAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdCloseTransaction = New System.Windows.Forms.ToolStripButton()
        Me.lineClose = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrintStatement = New System.Windows.Forms.ToolStripButton()
        Me.cmdClearedSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(14, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(873, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "________________________________________________________________________________" & _
    "____________________________"
        '
        'txtClient
        '
        Me.txtClient.AutoSize = True
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtClient.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtClient.Location = New System.Drawing.Point(51, 6)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(285, 37)
        Me.txtClient.TabIndex = 333
        Me.txtClient.Text = "WINTER S. BUGAHOD"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(12, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 30)
        Me.Panel2.TabIndex = 343
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
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(12, 170)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(874, 336)
        Me.MyDataGridView.TabIndex = 342
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClearedSchedule, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(166, 54)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(33, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 15)
        Me.Label15.TabIndex = 444
        Me.Label15.Text = "Package Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(29, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 442
        Me.Label7.Text = "Transaction No."
        '
        'trnid
        '
        Me.trnid.AutoSize = True
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.Location = New System.Drawing.Point(649, 73)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(37, 15)
        Me.trnid.TabIndex = 450
        Me.trnid.Text = "10029"
        Me.trnid.Visible = False
        '
        'txtPackageName
        '
        Me.txtPackageName.AutoSize = True
        Me.txtPackageName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPackageName.Location = New System.Drawing.Point(127, 73)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(199, 15)
        Me.txtPackageName.TabIndex = 451
        Me.txtPackageName.Text = "DOUBLE BED GOOD FOR 2 PERSONS"
        '
        'txtDateTransaction
        '
        Me.txtDateTransaction.AutoSize = True
        Me.txtDateTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTransaction.Location = New System.Drawing.Point(127, 91)
        Me.txtDateTransaction.Name = "txtDateTransaction"
        Me.txtDateTransaction.Size = New System.Drawing.Size(148, 15)
        Me.txtDateTransaction.TabIndex = 453
        Me.txtDateTransaction.Text = "December 13, 2015 4:00pm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(24, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 452
        Me.Label11.Text = "Date Transaction"
        '
        'cifd
        '
        Me.cifd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cifd.ForeColor = System.Drawing.Color.Black
        Me.cifd.Location = New System.Drawing.Point(591, 234)
        Me.cifd.Margin = New System.Windows.Forms.Padding(5)
        Me.cifd.Name = "cifd"
        Me.cifd.Size = New System.Drawing.Size(57, 23)
        Me.cifd.TabIndex = 461
        Me.cifd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifd.Visible = False
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDate.Location = New System.Drawing.Point(634, 27)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(252, 15)
        Me.txtDate.TabIndex = 460
        Me.txtDate.Text = "December 13, 2015 4:00pm"
        Me.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServiceNo
        '
        Me.txtServiceNo.AutoSize = True
        Me.txtServiceNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtServiceNo.Location = New System.Drawing.Point(127, 55)
        Me.txtServiceNo.Name = "txtServiceNo"
        Me.txtServiceNo.Size = New System.Drawing.Size(37, 15)
        Me.txtServiceNo.TabIndex = 507
        Me.txtServiceNo.Text = "10029"
        '
        'txtPackageAmount
        '
        Me.txtPackageAmount.AutoSize = True
        Me.txtPackageAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPackageAmount.Location = New System.Drawing.Point(127, 109)
        Me.txtPackageAmount.Name = "txtPackageAmount"
        Me.txtPackageAmount.Size = New System.Drawing.Size(55, 15)
        Me.txtPackageAmount.TabIndex = 509
        Me.txtPackageAmount.Text = "10,000.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(68, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 508
        Me.Label2.Text = "Amount"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCloseTransaction, Me.lineClose, Me.cmdPrintStatement})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(875, 31)
        Me.ToolStrip3.TabIndex = 317
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdCloseTransaction
        '
        Me.cmdCloseTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdCloseTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.user__arrow
        Me.cmdCloseTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCloseTransaction.Name = "cmdCloseTransaction"
        Me.cmdCloseTransaction.Size = New System.Drawing.Size(104, 24)
        Me.cmdCloseTransaction.Text = "Close Account"
        '
        'lineClose
        '
        Me.lineClose.Name = "lineClose"
        Me.lineClose.Size = New System.Drawing.Size(6, 27)
        '
        'cmdPrintStatement
        '
        Me.cmdPrintStatement.ForeColor = System.Drawing.Color.White
        Me.cmdPrintStatement.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.cmdPrintStatement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintStatement.Name = "cmdPrintStatement"
        Me.cmdPrintStatement.Size = New System.Drawing.Size(109, 24)
        Me.cmdPrintStatement.Text = "Print Statement"
        '
        'cmdClearedSchedule
        '
        Me.cmdClearedSchedule.Image = Global.CoffeecupClient.My.Resources.Resources.tick
        Me.cmdClearedSchedule.Name = "cmdClearedSchedule"
        Me.cmdClearedSchedule.Size = New System.Drawing.Size(165, 22)
        Me.cmdClearedSchedule.Text = "Cleared Schedule"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(165, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'picicon
        '
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Image = Global.CoffeecupClient.My.Resources.Resources.flat_icon__1003_
        Me.picicon.Location = New System.Drawing.Point(13, 9)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(35, 33)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'frmClinicStatementLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(899, 517)
        Me.Controls.Add(Me.txtPackageAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServiceNo)
        Me.Controls.Add(Me.cifd)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtDateTransaction)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPackageName)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClinicStatementLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statement of Account"
        Me.Panel2.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdClearedSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdCloseTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.Label
    Friend WithEvents trnid As System.Windows.Forms.Label
    Friend WithEvents txtPackageName As System.Windows.Forms.Label
    Friend WithEvents txtDateTransaction As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lineClose As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrintStatement As System.Windows.Forms.ToolStripButton
    Friend WithEvents cifd As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents txtServiceNo As System.Windows.Forms.Label
    Friend WithEvents txtPackageAmount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
