<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestChangeAmount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestChangeAmount))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtdetails = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.txtvendor = New System.Windows.Forms.ComboBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(191, 199)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Update"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(157, 21)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(288, 22)
        Me.txtProductName.TabIndex = 271
        '
        'txtdetails
        '
        Me.txtdetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtdetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.ForeColor = System.Drawing.Color.Black
        Me.txtdetails.Location = New System.Drawing.Point(191, 150)
        Me.txtdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdetails.Multiline = True
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(254, 46)
        Me.txtdetails.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(58, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Particular Name"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(92, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Details/Remarks"
        '
        'txtunit
        '
        Me.txtunit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(328, 45)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(117, 22)
        Me.txtunit.TabIndex = 358
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(266, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Unit Cost"
        '
        'cmdreset
        '
        Me.cmdreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(328, 199)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(117, 30)
        Me.cmdreset.TabIndex = 5
        Me.cmdreset.Text = "Cancel"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'txtvendor
        '
        Me.txtvendor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtvendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtvendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtvendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtvendor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtvendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendor.ForeColor = System.Drawing.Color.Black
        Me.txtvendor.FormattingEnabled = True
        Me.txtvendor.ItemHeight = 15
        Me.txtvendor.Location = New System.Drawing.Point(191, 124)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(254, 23)
        Me.txtvendor.TabIndex = 2
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(26, 209)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(50, 23)
        Me.id.TabIndex = 374
        Me.id.Visible = False
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(328, 96)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(117, 25)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(106, 126)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel1.TabIndex = 381
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Synch Supplier"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(265, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 382
        Me.Label1.Text = "Unit Type"
        '
        'vendorid
        '
        Me.vendorid.Enabled = False
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(84, 210)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(50, 23)
        Me.vendorid.TabIndex = 383
        Me.vendorid.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(328, 69)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(117, 25)
        Me.txtQuantity.TabIndex = 0
        Me.txtQuantity.Text = "0.00"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(269, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 385
        Me.Label2.Text = "Quantity"
        '
        'frmRequestChangeAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(497, 249)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(513, 288)
        Me.Name = "frmRequestChangeAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Item"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents txtvendor As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
