<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductRegistration
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
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUnit = New System.Windows.Forms.ComboBox()
        Me.txtcategory = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtProductName
        '
        Me.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(127, 12)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(224, 22)
        Me.txtProductName.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(126, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        Me.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.FormattingEnabled = True
        Me.txtUnit.Location = New System.Drawing.Point(127, 83)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(134, 21)
        Me.txtUnit.TabIndex = 3
        '
        'txtcategory
        '
        Me.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.FormattingEnabled = True
        Me.txtcategory.Location = New System.Drawing.Point(127, 37)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(224, 21)
        Me.txtcategory.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(127, 64)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Create new unit type"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Category"
        '
        'catid
        '
        Me.catid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catid.Location = New System.Drawing.Point(21, 120)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(72, 22)
        Me.catid.TabIndex = 19
        Me.catid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.catid.Visible = False
        '
        'frmProductRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 149)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmProductRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtcategory As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents catid As System.Windows.Forms.TextBox

End Class
