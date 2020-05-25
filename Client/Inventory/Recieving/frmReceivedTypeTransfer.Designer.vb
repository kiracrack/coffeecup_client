<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedTypeTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivedTypeTransfer))
        Me.cmdTransfer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdFFETransfer = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTransfer
        '
        Me.cmdTransfer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdTransfer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTransfer.Location = New System.Drawing.Point(105, 22)
        Me.cmdTransfer.Name = "cmdTransfer"
        Me.cmdTransfer.Size = New System.Drawing.Size(227, 30)
        Me.cmdTransfer.TabIndex = 7
        Me.cmdTransfer.Text = "Consumable Transfer"
        Me.cmdTransfer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdFFETransfer)
        Me.GroupBox2.Controls.Add(Me.cmdTransfer)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 102)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receive transfered inventory"
        '
        'cmdFFETransfer
        '
        Me.cmdFFETransfer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdFFETransfer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFFETransfer.Location = New System.Drawing.Point(105, 58)
        Me.cmdFFETransfer.Name = "cmdFFETransfer"
        Me.cmdFFETransfer.Size = New System.Drawing.Size(227, 30)
        Me.cmdFFETransfer.TabIndex = 8
        Me.cmdFFETransfer.Text = "Asset Transfer"
        Me.cmdFFETransfer.UseVisualStyleBackColor = True
        '
        'frmReceivedTypeTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 122)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReceivedTypeTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please select receiving type.."
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTransfer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdFFETransfer As System.Windows.Forms.Button
End Class
