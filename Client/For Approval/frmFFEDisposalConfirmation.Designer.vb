<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFFEDisposalConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFFEDisposalConfirmation))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtRequestType = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.FFECode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(143, 150)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(205, 30)
        Me.cmdConfirm.TabIndex = 7
        Me.cmdConfirm.Text = "Confirm Disposal"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(71, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please select confirm type for disposal request."
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(71, 95)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(364, 51)
        Me.txtRemarks.TabIndex = 365
        Me.txtRemarks.Text = "Please enter message"
        '
        'txtRequestType
        '
        Me.txtRequestType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRequestType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRequestType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRequestType.ForeColor = System.Drawing.Color.Black
        Me.txtRequestType.FormattingEnabled = True
        Me.txtRequestType.ItemHeight = 15
        Me.txtRequestType.Items.AddRange(New Object() {"APPROVED", "DISAPPROVED"})
        Me.txtRequestType.Location = New System.Drawing.Point(72, 41)
        Me.txtRequestType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRequestType.Name = "txtRequestType"
        Me.txtRequestType.Size = New System.Drawing.Size(208, 23)
        Me.txtRequestType.TabIndex = 506
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescription.Location = New System.Drawing.Point(169, 68)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(266, 23)
        Me.txtDescription.TabIndex = 507
        '
        'FFECode
        '
        Me.FFECode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FFECode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FFECode.Location = New System.Drawing.Point(71, 68)
        Me.FFECode.Name = "FFECode"
        Me.FFECode.ReadOnly = True
        Me.FFECode.Size = New System.Drawing.Size(95, 23)
        Me.FFECode.TabIndex = 508
        Me.FFECode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmFFEDisposalConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(509, 202)
        Me.Controls.Add(Me.FFECode)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtRequestType)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFFEDisposalConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Type Confirmation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtRequestType As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents FFECode As System.Windows.Forms.TextBox
End Class
