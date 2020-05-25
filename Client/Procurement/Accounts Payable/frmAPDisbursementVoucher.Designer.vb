<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPDisbursementVoucher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAPDisbursementVoucher))
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfilter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabForDisbursementPO = New System.Windows.Forms.TabPage()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestForPaymentApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabPending = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.tabCashAdvance = New System.Windows.Forms.TabPage()
        Me.dgv_unliquidated = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabForDisbursementPO.SuspendLayout()
        Me.cms_em.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCashAdvance.SuspendLayout()
        CType(Me.dgv_unliquidated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(56, 40)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(446, 22)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "To view accounts payable detail please double click on list view."
        Me.lbldescription.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(456, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "______________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(54, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(193, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "List of Disbursement Voucher"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtfilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.picicon)
        Me.GroupBox1.Controls.Add(Me.lbltitle)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbldescription)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 105)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Accounts Payable"
        '
        'txtfilter
        '
        Me.txtfilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfilter.Location = New System.Drawing.Point(52, 76)
        Me.txtfilter.Name = "txtfilter"
        Me.txtfilter.Size = New System.Drawing.Size(411, 23)
        Me.txtfilter.TabIndex = 337
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Search"
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.List
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(9, 19)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(40, 48)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabForDisbursementPO)
        Me.TabControl1.Controls.Add(Me.tabPending)
        Me.TabControl1.Controls.Add(Me.tabCashAdvance)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(7, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(912, 366)
        Me.TabControl1.TabIndex = 343
        '
        'tabForDisbursementPO
        '
        Me.tabForDisbursementPO.Controls.Add(Me.MyDataGridView)
        Me.tabForDisbursementPO.Location = New System.Drawing.Point(4, 24)
        Me.tabForDisbursementPO.Name = "tabForDisbursementPO"
        Me.tabForDisbursementPO.Padding = New System.Windows.Forms.Padding(3)
        Me.tabForDisbursementPO.Size = New System.Drawing.Size(904, 338)
        Me.tabForDisbursementPO.TabIndex = 2
        Me.tabForDisbursementPO.Text = "For Approval Voucher"
        Me.tabForDisbursementPO.UseVisualStyleBackColor = True
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailsToolStripMenuItem, Me.RequestForPaymentApprovalToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(195, 76)
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ViewDetailsToolStripMenuItem.Text = "View Voucher Details"
        '
        'RequestForPaymentApprovalToolStripMenuItem
        '
        Me.RequestForPaymentApprovalToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.user__arrow
        Me.RequestForPaymentApprovalToolStripMenuItem.Name = "RequestForPaymentApprovalToolStripMenuItem"
        Me.RequestForPaymentApprovalToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RequestForPaymentApprovalToolStripMenuItem.Text = "Download Attachment"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(191, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(194, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'tabPending
        '
        Me.tabPending.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabPending.Location = New System.Drawing.Point(4, 24)
        Me.tabPending.Name = "tabPending"
        Me.tabPending.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPending.Size = New System.Drawing.Size(904, 338)
        Me.tabPending.TabIndex = 0
        Me.tabPending.Text = "Cleared Voucher"
        Me.tabPending.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(898, 332)
        Me.MyDataGridView.TabIndex = 344
        '
        'tabCashAdvance
        '
        Me.tabCashAdvance.Controls.Add(Me.dgv_unliquidated)
        Me.tabCashAdvance.Location = New System.Drawing.Point(4, 24)
        Me.tabCashAdvance.Name = "tabCashAdvance"
        Me.tabCashAdvance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCashAdvance.Size = New System.Drawing.Size(904, 338)
        Me.tabCashAdvance.TabIndex = 3
        Me.tabCashAdvance.Text = "Unliquidated Cash Advance"
        Me.tabCashAdvance.UseVisualStyleBackColor = True
        '
        'dgv_unliquidated
        '
        Me.dgv_unliquidated.AllowUserToAddRows = False
        Me.dgv_unliquidated.AllowUserToDeleteRows = False
        Me.dgv_unliquidated.AllowUserToResizeColumns = False
        Me.dgv_unliquidated.AllowUserToResizeRows = False
        Me.dgv_unliquidated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_unliquidated.BackgroundColor = System.Drawing.Color.White
        Me.dgv_unliquidated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_unliquidated.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_unliquidated.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_unliquidated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_unliquidated.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_unliquidated.Location = New System.Drawing.Point(3, 3)
        Me.dgv_unliquidated.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_unliquidated.Name = "dgv_unliquidated"
        Me.dgv_unliquidated.ReadOnly = True
        Me.dgv_unliquidated.RowHeadersVisible = False
        Me.dgv_unliquidated.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_unliquidated.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_unliquidated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_unliquidated.Size = New System.Drawing.Size(898, 332)
        Me.dgv_unliquidated.TabIndex = 345
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 54)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem1.Text = "Liquidate Cash Advance"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem3.Tag = "1"
        Me.ToolStripMenuItem3.Text = "Refresh Data"
        '
        'frmDisbursementVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(927, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDisbursementVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement Voucher List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabForDisbursementPO.ResumeLayout(False)
        Me.cms_em.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCashAdvance.ResumeLayout(False)
        CType(Me.dgv_unliquidated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilter As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPending As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tabForDisbursementPO As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RequestForPaymentApprovalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabCashAdvance As System.Windows.Forms.TabPage
    Friend WithEvents dgv_unliquidated As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
