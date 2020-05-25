<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCustomProductEnterQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCustomProductEnterQuantity))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.postrn = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(209, 122)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(148, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Add to Package"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(63, 256)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 270
        Me.productid.Visible = False
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(150, 22)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(207, 22)
        Me.txtProductName.TabIndex = 271
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(56, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Particular Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(62, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Enter Quantity"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.ForeColor = System.Drawing.Color.Black
        Me.txtUnit.Location = New System.Drawing.Point(209, 47)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(148, 22)
        Me.txtUnit.TabIndex = 358
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(147, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Unit Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(170, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 363
        Me.Label4.Text = "Total"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCost.Location = New System.Drawing.Point(209, 97)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(148, 22)
        Me.txtTotalCost.TabIndex = 104
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mode
        '
        Me.mode.Enabled = False
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(3, 351)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(50, 23)
        Me.mode.TabIndex = 372
        Me.mode.Visible = False
        '
        'officeid
        '
        Me.officeid.Enabled = False
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(5, 204)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(50, 23)
        Me.officeid.TabIndex = 374
        Me.officeid.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(150, 47)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(56, 22)
        Me.txtQuantity.TabIndex = 0
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(209, 72)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.ReadOnly = True
        Me.txtUnitCost.Size = New System.Drawing.Size(148, 22)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(121, 204)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(50, 23)
        Me.id.TabIndex = 371
        Me.id.Visible = False
        '
        'postrn
        '
        Me.postrn.Enabled = False
        Me.postrn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.postrn.ForeColor = System.Drawing.Color.Black
        Me.postrn.Location = New System.Drawing.Point(63, 204)
        Me.postrn.Margin = New System.Windows.Forms.Padding(4)
        Me.postrn.Name = "postrn"
        Me.postrn.ReadOnly = True
        Me.postrn.Size = New System.Drawing.Size(50, 23)
        Me.postrn.TabIndex = 375
        Me.postrn.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Enabled = False
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(5, 235)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(50, 23)
        Me.txtBatchcode.TabIndex = 376
        Me.txtBatchcode.Visible = False
        '
        'frmPOSCustomProductEnterQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(423, 173)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.postrn)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSCustomProductEnterQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Quantity"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents postrn As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
End Class
