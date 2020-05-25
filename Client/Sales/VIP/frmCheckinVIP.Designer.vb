<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckinVIP
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.txtVIPCardNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.txtCompanion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(160, 110)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(124, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Activate Card"
        '
        'txtVIPCardNo
        '
        Me.txtVIPCardNo.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtVIPCardNo.ForeColor = System.Drawing.Color.Black
        Me.txtVIPCardNo.Location = New System.Drawing.Point(160, 29)
        Me.txtVIPCardNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVIPCardNo.Name = "txtVIPCardNo"
        Me.txtVIPCardNo.Size = New System.Drawing.Size(124, 27)
        Me.txtVIPCardNo.TabIndex = 1
        Me.txtVIPCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(107, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "VIP No."
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(160, 59)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(249, 22)
        Me.txtCompanyName.TabIndex = 409
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(94, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "VIP Name"
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(50, 304)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(46, 22)
        Me.cifid.TabIndex = 411
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(106, 304)
        Me.guestid.Margin = New System.Windows.Forms.Padding(4)
        Me.guestid.Name = "guestid"
        Me.guestid.ReadOnly = True
        Me.guestid.Size = New System.Drawing.Size(46, 22)
        Me.guestid.TabIndex = 413
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCompanion
        '
        Me.txtCompanion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanion.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanion.ForeColor = System.Drawing.Color.Black
        Me.txtCompanion.Location = New System.Drawing.Point(160, 84)
        Me.txtCompanion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanion.Name = "txtCompanion"
        Me.txtCompanion.Size = New System.Drawing.Size(124, 22)
        Me.txtCompanion.TabIndex = 414
        Me.txtCompanion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(22, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 415
        Me.Label4.Text = "Number of Companion"
        '
        'frmCheckinVIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 186)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.txtCompanion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVIPCardNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckinVIP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Card Activation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents txtVIPCardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
