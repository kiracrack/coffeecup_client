<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestQuantitySelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestQuantitySelect))
        Me.catid = New System.Windows.Forms.TextBox()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtdetails = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.cattype = New System.Windows.Forms.TextBox()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.txtvendor = New System.Windows.Forms.ComboBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.editindex = New System.Windows.Forms.TextBox()
        Me.editRef = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.txtsti = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
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
        Me.catid.Visible = False
        '
        'cmdset
        '
        Me.cmdset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(157, 199)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Add to Request"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(158, 384)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 270
        Me.productid.Visible = False
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(157, 15)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(254, 22)
        Me.txtProductName.TabIndex = 271
        '
        'txtdetails
        '
        Me.txtdetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtdetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.ForeColor = System.Drawing.Color.Black
        Me.txtdetails.Location = New System.Drawing.Point(157, 150)
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
        Me.Label13.Location = New System.Drawing.Point(58, 18)
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
        Me.Label10.Location = New System.Drawing.Point(58, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Details/Remarks"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(67, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "Enter Quantity"
        '
        'txtunit
        '
        Me.txtunit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunit.ForeColor = System.Drawing.Color.Black
        Me.txtunit.Location = New System.Drawing.Point(263, 40)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.ReadOnly = True
        Me.txtunit.Size = New System.Drawing.Size(148, 25)
        Me.txtunit.TabIndex = 358
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(201, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 361
        Me.Label5.Text = "Unit Cost"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(197, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 363
        Me.Label4.Text = "Total Cost"
        '
        'txttotal
        '
        Me.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttotal.BackColor = System.Drawing.Color.Yellow
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Black
        Me.txttotal.Location = New System.Drawing.Point(263, 96)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(148, 25)
        Me.txttotal.TabIndex = 104
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vendorid
        '
        Me.vendorid.Enabled = False
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(158, 353)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(50, 23)
        Me.vendorid.TabIndex = 366
        Me.vendorid.Visible = False
        '
        'cattype
        '
        Me.cattype.Enabled = False
        Me.cattype.Location = New System.Drawing.Point(213, 362)
        Me.cattype.Name = "cattype"
        Me.cattype.ReadOnly = True
        Me.cattype.Size = New System.Drawing.Size(62, 20)
        Me.cattype.TabIndex = 369
        Me.cattype.Visible = False
        '
        'pid
        '
        Me.pid.Enabled = False
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pid.ForeColor = System.Drawing.Color.Black
        Me.pid.Location = New System.Drawing.Point(158, 326)
        Me.pid.Margin = New System.Windows.Forms.Padding(4)
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(50, 23)
        Me.pid.TabIndex = 370
        Me.pid.Visible = False
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
        Me.id.Visible = False
        '
        'cmdreset
        '
        Me.cmdreset.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(294, 199)
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
        Me.txtvendor.Location = New System.Drawing.Point(157, 124)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(254, 23)
        Me.txtvendor.TabIndex = 2
        '
        'mode
        '
        Me.mode.Enabled = False
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(-9, 297)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(50, 23)
        Me.mode.TabIndex = 372
        Me.mode.Visible = False
        '
        'editindex
        '
        Me.editindex.Enabled = False
        Me.editindex.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editindex.ForeColor = System.Drawing.Color.Black
        Me.editindex.Location = New System.Drawing.Point(49, 298)
        Me.editindex.Margin = New System.Windows.Forms.Padding(4)
        Me.editindex.Name = "editindex"
        Me.editindex.ReadOnly = True
        Me.editindex.Size = New System.Drawing.Size(50, 23)
        Me.editindex.TabIndex = 373
        Me.editindex.Visible = False
        '
        'editRef
        '
        Me.editRef.Enabled = False
        Me.editRef.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.editRef.ForeColor = System.Drawing.Color.Black
        Me.editRef.Location = New System.Drawing.Point(-9, 266)
        Me.editRef.Margin = New System.Windows.Forms.Padding(4)
        Me.editRef.Name = "editRef"
        Me.editRef.ReadOnly = True
        Me.editRef.Size = New System.Drawing.Size(50, 23)
        Me.editRef.TabIndex = 374
        Me.editRef.Visible = False
        '
        'txtquan
        '
        Me.txtquan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtquan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquan.ForeColor = System.Drawing.Color.Black
        Me.txtquan.Location = New System.Drawing.Point(157, 40)
        Me.txtquan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(103, 25)
        Me.txtquan.TabIndex = 0
        Me.txtquan.Text = "1"
        Me.txtquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsti
        '
        Me.txtsti.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtsti.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsti.ForeColor = System.Drawing.Color.Black
        Me.txtsti.Location = New System.Drawing.Point(263, 68)
        Me.txtsti.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsti.Name = "txtsti"
        Me.txtsti.Size = New System.Drawing.Size(148, 25)
        Me.txtsti.TabIndex = 1
        Me.txtsti.Text = "0.00"
        Me.txtsti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(72, 126)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel1.TabIndex = 381
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Synch Supplier"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'frmRequestQuantitySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(497, 249)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtsti)
        Me.Controls.Add(Me.txtquan)
        Me.Controls.Add(Me.editRef)
        Me.Controls.Add(Me.editindex)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.cattype)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(513, 288)
        Me.Name = "frmRequestQuantitySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Particular Info"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtunit As System.Windows.Forms.TextBox
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents cattype As System.Windows.Forms.TextBox
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents txtvendor As System.Windows.Forms.ComboBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents editindex As System.Windows.Forms.TextBox
    Friend WithEvents editRef As System.Windows.Forms.TextBox
    Friend WithEvents txtquan As System.Windows.Forms.TextBox
    Friend WithEvents txtsti As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
