<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelTransactionsHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelTransactionsHistory))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabHotelCharges = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Detail = New System.Windows.Forms.DataGridView()
        Me.tabChargefromPOS = New System.Windows.Forms.TabPage()
        Me.tabPayment = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.cms_em.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabHotelCharges.SuspendLayout()
        CType(Me.MyDataGridView_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(209, 48)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(208, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Void Selected Transaction"
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabHotelCharges)
        Me.TabControl1.Controls.Add(Me.tabChargefromPOS)
        Me.TabControl1.Controls.Add(Me.tabPayment)
        Me.TabControl1.Location = New System.Drawing.Point(0, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 498)
        Me.TabControl1.TabIndex = 397
        '
        'tabHotelCharges
        '
        Me.tabHotelCharges.Controls.Add(Me.MyDataGridView_Detail)
        Me.tabHotelCharges.Location = New System.Drawing.Point(4, 22)
        Me.tabHotelCharges.Name = "tabHotelCharges"
        Me.tabHotelCharges.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHotelCharges.Size = New System.Drawing.Size(858, 472)
        Me.tabHotelCharges.TabIndex = 1
        Me.tabHotelCharges.Text = "Hotel Charges "
        Me.tabHotelCharges.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Detail
        '
        Me.MyDataGridView_Detail.AllowUserToAddRows = False
        Me.MyDataGridView_Detail.AllowUserToDeleteRows = False
        Me.MyDataGridView_Detail.AllowUserToResizeColumns = False
        Me.MyDataGridView_Detail.AllowUserToResizeRows = False
        Me.MyDataGridView_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Detail.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Detail.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Detail.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Detail.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Detail.Name = "MyDataGridView_Detail"
        Me.MyDataGridView_Detail.ReadOnly = True
        Me.MyDataGridView_Detail.RowHeadersVisible = False
        Me.MyDataGridView_Detail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Detail.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Detail.Size = New System.Drawing.Size(852, 466)
        Me.MyDataGridView_Detail.TabIndex = 393
        '
        'tabChargefromPOS
        '
        Me.tabChargefromPOS.Location = New System.Drawing.Point(4, 22)
        Me.tabChargefromPOS.Name = "tabChargefromPOS"
        Me.tabChargefromPOS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChargefromPOS.Size = New System.Drawing.Size(858, 472)
        Me.tabChargefromPOS.TabIndex = 2
        Me.tabChargefromPOS.Text = "Charge From POS"
        Me.tabChargefromPOS.UseVisualStyleBackColor = True
        '
        'tabPayment
        '
        Me.tabPayment.Location = New System.Drawing.Point(4, 22)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Size = New System.Drawing.Size(858, 472)
        Me.tabPayment.TabIndex = 3
        Me.tabPayment.Text = "Payment Transaction"
        Me.tabPayment.UseVisualStyleBackColor = True
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
        Me.ToolStrip3.Size = New System.Drawing.Size(866, 31)
        Me.ToolStrip3.TabIndex = 398
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
        'frmHotelTransactionsHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(866, 532)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelTransactionsHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Transaction Report"
        Me.cms_em.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabHotelCharges.ResumeLayout(False)
        CType(Me.MyDataGridView_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabHotelCharges As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Detail As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabChargefromPOS As System.Windows.Forms.TabPage
    Friend WithEvents tabPayment As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
End Class
