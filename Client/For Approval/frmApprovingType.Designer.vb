<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovingType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprovingType))
        Me.cmdBranch = New System.Windows.Forms.Button()
        Me.cmdCorporate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdBranch
        '
        Me.cmdBranch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBranch.Location = New System.Drawing.Point(220, 34)
        Me.cmdBranch.Name = "cmdBranch"
        Me.cmdBranch.Size = New System.Drawing.Size(199, 30)
        Me.cmdBranch.TabIndex = 8
        Me.cmdBranch.Text = "Office Request"
        Me.cmdBranch.UseVisualStyleBackColor = True
        '
        'cmdCorporate
        '
        Me.cmdCorporate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdCorporate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCorporate.Location = New System.Drawing.Point(15, 34)
        Me.cmdCorporate.Name = "cmdCorporate"
        Me.cmdCorporate.Size = New System.Drawing.Size(199, 30)
        Me.cmdCorporate.TabIndex = 7
        Me.cmdCorporate.Text = "Corporate Request"
        Me.cmdCorporate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Where would you like to approve? Please select request type below.."
        '
        'frmApprovingType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(431, 76)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCorporate)
        Me.Controls.Add(Me.cmdBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmApprovingType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Type Confirmation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBranch As System.Windows.Forms.Button
    Friend WithEvents cmdCorporate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
