<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferQuantitySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferQuantitySelect))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtdetails = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.NumericUpDown()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.txtavailable = New System.Windows.Forms.TextBox()
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(158, 112)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Add to Batch"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(210, 326)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 270
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
        'txtdetails
        '
        Me.txtdetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.ForeColor = System.Drawing.Color.Black
        Me.txtdetails.Location = New System.Drawing.Point(158, 63)
        Me.txtdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdetails.Multiline = True
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(209, 46)
        Me.txtdetails.TabIndex = 3
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(61, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Details/Remarks"
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
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(295, 112)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(72, 30)
        Me.cmdreset.TabIndex = 5
        Me.cmdreset.Text = "Cancel"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'trnid
        '
        Me.trnid.Enabled = False
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(263, 326)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(50, 23)
        Me.trnid.TabIndex = 372
        '
        'mode
        '
        Me.mode.Enabled = False
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(53, 174)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(50, 23)
        Me.mode.TabIndex = 373
        '
        'batchcode
        '
        Me.batchcode.Enabled = False
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(92, 195)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(50, 23)
        Me.batchcode.TabIndex = 374
        '
        'txtavailable
        '
        Me.txtavailable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtavailable.ForeColor = System.Drawing.Color.Black
        Me.txtavailable.Location = New System.Drawing.Point(13, 112)
        Me.txtavailable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtavailable.Name = "txtavailable"
        Me.txtavailable.ReadOnly = True
        Me.txtavailable.Size = New System.Drawing.Size(52, 22)
        Me.txtavailable.TabIndex = 375
        Me.txtavailable.Visible = False
        '
        'frmTransferQuantitySelect
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(382, 155)
        Me.Controls.Add(Me.txtavailable)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransferQuantitySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Particular Info"
        Me.TopMost = True
        CType(Me.txtquan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtavailable As System.Windows.Forms.TextBox
End Class
