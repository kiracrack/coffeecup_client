<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryAdjust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryAdjust))
        Me.catid = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtquan = New System.Windows.Forms.NumericUpDown()
        Me.txtCurrQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cattype = New System.Windows.Forms.TextBox()
        Me.refno = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtUnitCost = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'catid
        '
        Me.catid.Enabled = False
        Me.catid.Location = New System.Drawing.Point(213, 393)
        Me.catid.Name = "catid"
        Me.catid.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(62, 20)
        Me.catid.TabIndex = 248
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(158, 11)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(244, 22)
        Me.txtProductName.TabIndex = 271
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(61, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Particular Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(185, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Enter New Quantity"
        '
        'txtunit
        '
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(298, 37)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(104, 22)
        Me.txtunit.TabIndex = 358
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(199, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Current Quantity"
        '
        'txtquan
        '
        Me.txtquan.DecimalPlaces = 4
        Me.txtquan.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtquan.Location = New System.Drawing.Point(298, 87)
        Me.txtquan.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(104, 22)
        Me.txtquan.TabIndex = 0
        Me.txtquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtquan.ThousandsSeparator = True
        Me.txtquan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCurrQuantity
        '
        Me.txtCurrQuantity.DecimalPlaces = 4
        Me.txtCurrQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrQuantity.Location = New System.Drawing.Point(298, 62)
        Me.txtCurrQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtCurrQuantity.Name = "txtCurrQuantity"
        Me.txtCurrQuantity.ReadOnly = True
        Me.txtCurrQuantity.Size = New System.Drawing.Size(104, 22)
        Me.txtCurrQuantity.TabIndex = 1
        Me.txtCurrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrQuantity.ThousandsSeparator = True
        '
        'cattype
        '
        Me.cattype.Enabled = False
        Me.cattype.Location = New System.Drawing.Point(213, 362)
        Me.cattype.Name = "cattype"
        Me.cattype.ReadOnly = True
        Me.cattype.Size = New System.Drawing.Size(62, 20)
        Me.cattype.TabIndex = 369
        '
        'refno
        '
        Me.refno.Enabled = False
        Me.refno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.refno.ForeColor = System.Drawing.Color.Black
        Me.refno.Location = New System.Drawing.Point(36, 60)
        Me.refno.Margin = New System.Windows.Forms.Padding(4)
        Me.refno.Name = "refno"
        Me.refno.ReadOnly = True
        Me.refno.Size = New System.Drawing.Size(50, 23)
        Me.refno.TabIndex = 370
        Me.refno.Visible = False
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(216, 332)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(50, 23)
        Me.id.TabIndex = 371
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(266, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Unit"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(190, 162)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(214, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtUnitCost
        '
        Me.txtUnitCost.DecimalPlaces = 2
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnitCost.Location = New System.Drawing.Point(249, 112)
        Me.txtUnitCost.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(153, 22)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnitCost.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(190, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 374
        Me.Label3.Text = "Unit Cost"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalCost.DecimalPlaces = 2
        Me.txtTotalCost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalCost.Location = New System.Drawing.Point(249, 137)
        Me.txtTotalCost.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(153, 22)
        Me.txtTotalCost.TabIndex = 2
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCost.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(185, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 376
        Me.Label4.Text = "Total Cost"
        '
        'frmInventoryAdjust
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(414, 198)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.refno)
        Me.Controls.Add(Me.cattype)
        Me.Controls.Add(Me.txtCurrQuantity)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryAdjust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjust Inventory"
        Me.TopMost = True
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCurrQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cattype As System.Windows.Forms.TextBox
    Friend WithEvents refno As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtUnitCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
