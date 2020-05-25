<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailPreviewNotification
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.cmdSendEmail = New System.Windows.Forms.ToolStripButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 31)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(797, 506)
        Me.WebBrowser1.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.cmdSendEmail})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(797, 31)
        Me.ToolStrip3.TabIndex = 318
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'cmdSendEmail
        '
        Me.cmdSendEmail.ForeColor = System.Drawing.Color.White
        Me.cmdSendEmail.Image = Global.CoffeecupClient.My.Resources.Resources.email_go
        Me.cmdSendEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSendEmail.Name = "cmdSendEmail"
        Me.cmdSendEmail.Size = New System.Drawing.Size(198, 24)
        Me.cmdSendEmail.Text = "Send Email Notification to Guest"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(287, 257)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(89, 22)
        Me.txtEmail.TabIndex = 319
        Me.txtEmail.Visible = False
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(409, 257)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(89, 22)
        Me.foliono.TabIndex = 320
        Me.foliono.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(103, 24)
        Me.ToolStripButton1.Text = "Close Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'frmEmailPreviewNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 537)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Name = "frmEmailPreviewNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Folio Notification"
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSendEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
