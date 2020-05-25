<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicPackageSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicPackageSchedule))
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdClearedSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(148, 90)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(181, 34)
        Me.cmdProceed.TabIndex = 6
        Me.cmdProceed.Text = "Add Schedule"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(614, 131)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(49, 22)
        Me.trnid.TabIndex = 447
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(41, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 1012
        Me.Label5.Text = "Product Schedule"
        '
        'txtProduct
        '
        Me.txtProduct.DropDownHeight = 130
        Me.txtProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtProduct.ForeColor = System.Drawing.Color.Black
        Me.txtProduct.FormattingEnabled = True
        Me.txtProduct.IntegralHeight = False
        Me.txtProduct.ItemHeight = 15
        Me.txtProduct.Location = New System.Drawing.Point(148, 36)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.MaxDropDownItems = 7
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(262, 23)
        Me.txtProduct.TabIndex = 1011
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(55, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 1015
        Me.Label1.Text = "Package Schedule"
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(541, 37)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(49, 22)
        Me.productid.TabIndex = 1017
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'txtSchedule
        '
        Me.txtSchedule.CustomFormat = "MMMM dd, yyyy"
        Me.txtSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtSchedule.Location = New System.Drawing.Point(148, 63)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(181, 23)
        Me.txtSchedule.TabIndex = 1020
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(86, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 1021
        Me.Label3.Text = "Schedule"
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
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(2, 133)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(502, 341)
        Me.MyDataGridView.TabIndex = 1022
        '
        'txtReference
        '
        Me.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReference.ForeColor = System.Drawing.Color.Black
        Me.txtReference.Location = New System.Drawing.Point(529, 7)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ReadOnly = True
        Me.txtReference.Size = New System.Drawing.Size(75, 23)
        Me.txtReference.TabIndex = 99
        Me.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReference.Visible = False
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClearedSchedule, Me.ToolStripSeparator2, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(162, 54)
        '
        'cmdClearedSchedule
        '
        Me.cmdClearedSchedule.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdClearedSchedule.Name = "cmdClearedSchedule"
        Me.cmdClearedSchedule.Size = New System.Drawing.Size(161, 22)
        Me.cmdClearedSchedule.Text = "Cancel Schedule"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(161, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'frmClinicPackageSchedule
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(508, 477)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSchedule)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.cmdProceed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClinicPackageSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinic Schedule"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents txtSchedule As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdClearedSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
End Class
