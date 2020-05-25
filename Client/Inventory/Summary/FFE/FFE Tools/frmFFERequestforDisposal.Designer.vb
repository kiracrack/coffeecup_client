<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFFERequestforDisposal
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRequestLevel = New System.Windows.Forms.ComboBox()
        Me.txtFFECode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(118, 37)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(253, 23)
        Me.txtDescription.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(118, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit for Approval"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "FFE Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(33, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 505
        Me.Label8.Text = "Request Level"
        '
        'txtRequestLevel
        '
        Me.txtRequestLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRequestLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRequestLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRequestLevel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestLevel.ForeColor = System.Drawing.Color.Black
        Me.txtRequestLevel.FormattingEnabled = True
        Me.txtRequestLevel.ItemHeight = 15
        Me.txtRequestLevel.Items.AddRange(New Object() {"BRANCH LEVEL", "CORPORATE OFFICE"})
        Me.txtRequestLevel.Location = New System.Drawing.Point(118, 63)
        Me.txtRequestLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRequestLevel.Name = "txtRequestLevel"
        Me.txtRequestLevel.Size = New System.Drawing.Size(155, 23)
        Me.txtRequestLevel.TabIndex = 504
        '
        'txtFFECode
        '
        Me.txtFFECode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFFECode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFFECode.Location = New System.Drawing.Point(118, 12)
        Me.txtFFECode.Name = "txtFFECode"
        Me.txtFFECode.ReadOnly = True
        Me.txtFFECode.Size = New System.Drawing.Size(105, 23)
        Me.txtFFECode.TabIndex = 506
        Me.txtFFECode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 507
        Me.Label1.Text = "FFE Code"
        '
        'frmFFERequestforDisposal
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 141)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFFECode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRequestLevel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFFERequestforDisposal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFE Request for Disposal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRequestLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtFFECode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
