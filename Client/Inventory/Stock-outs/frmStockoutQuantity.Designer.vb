<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockoutQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockoutQuantity))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtproduct = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.stockid = New System.Windows.Forms.TextBox()
        Me.txtAvailableQuantity = New System.Windows.Forms.TextBox()
        Me.txtbatchcode = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(152, 169)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(182, 30)
        Me.cmdset.TabIndex = 2
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtproduct
        '
        Me.txtproduct.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduct.ForeColor = System.Drawing.Color.Black
        Me.txtproduct.Location = New System.Drawing.Point(152, 14)
        Me.txtproduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproduct.Name = "txtproduct"
        Me.txtproduct.ReadOnly = True
        Me.txtproduct.Size = New System.Drawing.Size(279, 22)
        Me.txtproduct.TabIndex = 271
        '
        'txtRemarks
        '
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(152, 120)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(279, 46)
        Me.txtRemarks.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(58, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Particular Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(56, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Details/Remarks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(64, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(276, 39)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(85, 27)
        Me.txtunit.TabIndex = 358
        Me.txtunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(336, 169)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(96, 30)
        Me.cmdreset.TabIndex = 3
        Me.cmdreset.Text = "Cancel"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'stockid
        '
        Me.stockid.Enabled = False
        Me.stockid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.stockid.ForeColor = System.Drawing.Color.Black
        Me.stockid.Location = New System.Drawing.Point(213, 432)
        Me.stockid.Margin = New System.Windows.Forms.Padding(4)
        Me.stockid.Name = "stockid"
        Me.stockid.ReadOnly = True
        Me.stockid.Size = New System.Drawing.Size(50, 23)
        Me.stockid.TabIndex = 376
        Me.stockid.Visible = False
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.Enabled = False
        Me.txtAvailableQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAvailableQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(213, 409)
        Me.txtAvailableQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(50, 23)
        Me.txtAvailableQuantity.TabIndex = 377
        Me.txtAvailableQuantity.Visible = False
        '
        'txtbatchcode
        '
        Me.txtbatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatchcode.Location = New System.Drawing.Point(514, 43)
        Me.txtbatchcode.Name = "txtbatchcode"
        Me.txtbatchcode.ReadOnly = True
        Me.txtbatchcode.Size = New System.Drawing.Size(49, 22)
        Me.txtbatchcode.TabIndex = 380
        Me.txtbatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtbatchcode.Visible = False
        '
        'txtUnitCost
        '
        Me.txtUnitCost.BackColor = System.Drawing.Color.White
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(152, 69)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.ReadOnly = True
        Me.txtUnitCost.Size = New System.Drawing.Size(121, 22)
        Me.txtUnitCost.TabIndex = 382
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(90, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 383
        Me.Label3.Text = "Unit Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(88, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 385
        Me.Label4.Text = "Total Cost"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(152, 94)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(121, 22)
        Me.txtTotal.TabIndex = 384
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtquantity
        '
        Me.txtquantity.BackColor = System.Drawing.Color.White
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtquantity.ForeColor = System.Drawing.Color.Black
        Me.txtquantity.Location = New System.Drawing.Point(152, 39)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(121, 27)
        Me.txtquantity.TabIndex = 0
        Me.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(213, 387)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 386
        Me.productid.Visible = False
        '
        'officeid
        '
        Me.officeid.Enabled = False
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(213, 365)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(50, 23)
        Me.officeid.TabIndex = 387
        Me.officeid.Visible = False
        '
        'catid
        '
        Me.catid.Enabled = False
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.catid.ForeColor = System.Drawing.Color.Black
        Me.catid.Location = New System.Drawing.Point(213, 345)
        Me.catid.Margin = New System.Windows.Forms.Padding(4)
        Me.catid.Name = "catid"
        Me.catid.ReadOnly = True
        Me.catid.Size = New System.Drawing.Size(50, 23)
        Me.catid.TabIndex = 388
        Me.catid.Visible = False
        '
        'frmStockoutQuantity
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(497, 214)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtbatchcode)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.stockid)
        Me.Controls.Add(Me.txtproduct)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStockoutQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stockout Particular Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtproduct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents stockid As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailableQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtbatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents catid As System.Windows.Forms.TextBox
End Class
