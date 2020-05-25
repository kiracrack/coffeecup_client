<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitConverterAddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnitConverterAddItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(46, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Quantity"
        '
        'txtunit
        '
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(262, 48)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(96, 26)
        Me.txtunit.TabIndex = 358
        Me.txtunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(105, 78)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(153, 33)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Add Item"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtProduct.DropDownHeight = 152
        Me.txtProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtProduct.ForeColor = System.Drawing.Color.Black
        Me.txtProduct.FormattingEnabled = True
        Me.txtProduct.IntegralHeight = False
        Me.txtProduct.ItemHeight = 19
        Me.txtProduct.Location = New System.Drawing.Point(105, 16)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(319, 27)
        Me.txtProduct.TabIndex = 380
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(22, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "Select Source"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(13, 166)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(40, 22)
        Me.id.TabIndex = 383
        Me.id.Visible = False
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(13, 141)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(40, 22)
        Me.productid.TabIndex = 384
        Me.productid.Visible = False
        '
        'txtquan
        '
        Me.txtquan.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtquan.ForeColor = System.Drawing.Color.Black
        Me.txtquan.Location = New System.Drawing.Point(105, 48)
        Me.txtquan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(153, 26)
        Me.txtquan.TabIndex = 385
        Me.txtquan.Text = "0"
        Me.txtquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmUnitConverterAddItem
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(466, 124)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUnitConverterAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.TextBox
End Class
