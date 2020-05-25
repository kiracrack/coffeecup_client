<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelRoomDiscount))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
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
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 140)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(487, 284)
        Me.MyDataGridView.TabIndex = 392
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdDelete, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(158, 76)
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__pencil
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(157, 22)
        Me.cmdEdit.Text = "Edit Discount"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__minus
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(157, 22)
        Me.cmdDelete.Text = "Delete Discount"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(154, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(157, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(82, 45)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(268, 23)
        Me.txtDescription.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.cmdProceed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Discount Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(190, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 15)
        Me.Label3.TabIndex = 447
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(47, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 446
        Me.Label2.Text = "Rate"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRate.Location = New System.Drawing.Point(82, 70)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(104, 23)
        Me.txtRate.TabIndex = 1
        Me.txtRate.Text = "0.00"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(81, 94)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(105, 30)
        Me.cmdProceed.TabIndex = 2
        Me.cmdProceed.Text = "Save"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 443
        Me.Label1.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCode.Location = New System.Drawing.Point(82, 20)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(104, 23)
        Me.txtCode.TabIndex = 442
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(10, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 15)
        Me.Label15.TabIndex = 441
        Me.Label15.Text = "Description"
        '
        'mode
        '
        Me.mode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.Location = New System.Drawing.Point(132, 200)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(192, 23)
        Me.mode.TabIndex = 446
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'frmHotelRoomDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 429)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHotelRoomDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Discount"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
End Class
