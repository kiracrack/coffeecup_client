<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryLockCutoff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryLockCutoff))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txttodate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrepaid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOnhand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.Red
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ForeColor = System.Drawing.Color.White
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(139, 94)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(156, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'txttodate
        '
        Me.txttodate.CustomFormat = "MMMM, dd yyyy"
        Me.txttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttodate.Location = New System.Drawing.Point(140, 19)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(187, 22)
        Me.txttodate.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(58, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 389
        Me.Label4.Text = "Total Prepaid"
        '
        'txtPrepaid
        '
        Me.txtPrepaid.BackColor = System.Drawing.Color.White
        Me.txtPrepaid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPrepaid.ForeColor = System.Drawing.Color.Black
        Me.txtPrepaid.Location = New System.Drawing.Point(140, 69)
        Me.txtPrepaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrepaid.Name = "txtPrepaid"
        Me.txtPrepaid.ReadOnly = True
        Me.txtPrepaid.Size = New System.Drawing.Size(155, 22)
        Me.txtPrepaid.TabIndex = 388
        Me.txtPrepaid.Text = "0.00"
        Me.txtPrepaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(52, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 387
        Me.Label3.Text = "Total On hand"
        '
        'txtOnhand
        '
        Me.txtOnhand.BackColor = System.Drawing.Color.White
        Me.txtOnhand.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOnhand.ForeColor = System.Drawing.Color.Black
        Me.txtOnhand.Location = New System.Drawing.Point(140, 44)
        Me.txtOnhand.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOnhand.Name = "txtOnhand"
        Me.txtOnhand.ReadOnly = True
        Me.txtOnhand.Size = New System.Drawing.Size(155, 22)
        Me.txtOnhand.TabIndex = 386
        Me.txtOnhand.Text = "0.00"
        Me.txtOnhand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(61, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 390
        Me.Label1.Text = "Cut-off Date"
        '
        'frmInventoryLockCutoff
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(414, 155)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrepaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOnhand)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.cmdset)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryLockCutoff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Lock Cut-off"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txttodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrepaid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOnhand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
