<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeSupplier))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtvendor = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.ponumber = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(236, 73)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Update"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'txtvendor
        '
        Me.txtvendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtvendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtvendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtvendor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtvendor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendor.ForeColor = System.Drawing.Color.Black
        Me.txtvendor.FormattingEnabled = True
        Me.txtvendor.ItemHeight = 15
        Me.txtvendor.Location = New System.Drawing.Point(117, 47)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(254, 23)
        Me.txtvendor.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(34, 49)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel1.TabIndex = 381
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Select Supplier"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'vendorid
        '
        Me.vendorid.Enabled = False
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(10, 104)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(50, 23)
        Me.vendorid.TabIndex = 382
        Me.vendorid.Visible = False
        '
        'ponumber
        '
        Me.ponumber.Enabled = False
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ponumber.ForeColor = System.Drawing.Color.Black
        Me.ponumber.Location = New System.Drawing.Point(62, 104)
        Me.ponumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(50, 23)
        Me.ponumber.TabIndex = 383
        Me.ponumber.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.Location = New System.Drawing.Point(117, 22)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(254, 22)
        Me.txtSupplier.TabIndex = 385
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(40, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 15)
        Me.Label13.TabIndex = 384
        Me.Label13.Text = "Old Supplier"
        '
        'frmChangeSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(411, 122)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChangeSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtvendor As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
    Friend WithEvents ponumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
