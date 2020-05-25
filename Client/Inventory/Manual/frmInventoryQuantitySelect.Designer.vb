<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryQuantitySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryQuantitySelect))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.NumericUpDown()
        Me.txtUnitCost = New System.Windows.Forms.NumericUpDown()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.catid = New System.Windows.Forms.TextBox()
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(158, 117)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Add to Batch"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(158, 11)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(209, 22)
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
        Me.Label1.Location = New System.Drawing.Point(59, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(263, 37)
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
        Me.Label5.Location = New System.Drawing.Point(157, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Unit Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(152, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 363
        Me.Label4.Text = "Total Cost"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Yellow
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txttotal.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Location = New System.Drawing.Point(217, 88)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(150, 22)
        Me.txttotal.TabIndex = 4
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtquan
        '
        Me.txtquan.DecimalPlaces = 4
        Me.txtquan.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtquan.Location = New System.Drawing.Point(158, 37)
        Me.txtquan.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(102, 22)
        Me.txtquan.TabIndex = 0
        Me.txtquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtquan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtUnitCost
        '
        Me.txtUnitCost.DecimalPlaces = 2
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnitCost.Location = New System.Drawing.Point(217, 63)
        Me.txtUnitCost.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(150, 22)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(295, 117)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(72, 30)
        Me.cmdreset.TabIndex = 5
        Me.cmdreset.Text = "Cancel"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(69, 109)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 371
        Me.productid.Visible = False
        '
        'catid
        '
        Me.catid.Enabled = False
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.catid.ForeColor = System.Drawing.Color.Black
        Me.catid.Location = New System.Drawing.Point(11, 109)
        Me.catid.Margin = New System.Windows.Forms.Padding(4)
        Me.catid.Name = "catid"
        Me.catid.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(50, 23)
        Me.catid.TabIndex = 372
        Me.catid.Visible = False
        '
        'frmInventoryQuantitySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(379, 160)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryQuantitySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Particular Info"
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnitCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUnitCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents catid As System.Windows.Forms.TextBox
End Class
