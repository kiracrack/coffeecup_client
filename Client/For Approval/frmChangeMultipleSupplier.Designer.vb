<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeMultipleSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeMultipleSupplier))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtvendor = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.vendorid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(238, 50)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Confirm Change"
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
        Me.txtvendor.Location = New System.Drawing.Point(119, 24)
        Me.txtvendor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvendor.Name = "txtvendor"
        Me.txtvendor.Size = New System.Drawing.Size(254, 23)
        Me.txtvendor.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(34, 26)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 20)
        Me.LinkLabel1.TabIndex = 381
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Synch Supplier"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.UseCompatibleTextRendering = True
        '
        'vendorid
        '
        Me.vendorid.Enabled = False
        Me.vendorid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vendorid.ForeColor = System.Drawing.Color.Black
        Me.vendorid.Location = New System.Drawing.Point(13, 76)
        Me.vendorid.Margin = New System.Windows.Forms.Padding(4)
        Me.vendorid.Name = "vendorid"
        Me.vendorid.ReadOnly = True
        Me.vendorid.Size = New System.Drawing.Size(50, 23)
        Me.vendorid.TabIndex = 384
        Me.vendorid.Visible = False
        '
        'frmChangeMultipleSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(397, 103)
        Me.Controls.Add(Me.vendorid)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtvendor)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChangeMultipleSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Supplier"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtvendor As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents vendorid As System.Windows.Forms.TextBox
End Class
