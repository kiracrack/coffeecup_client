<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoUpdateTest
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtversion = New System.Windows.Forms.TextBox()
        Me.txtDownloadLocation = New System.Windows.Forms.TextBox()
        Me.txtUpdateUrl = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 118)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(130, 10)
        Me.ProgressBar1.TabIndex = 361
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.Location = New System.Drawing.Point(39, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 12)
        Me.Label1.TabIndex = 360
        Me.Label1.Text = "System downloadin update.."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtversion
        '
        Me.txtversion.Location = New System.Drawing.Point(64, 167)
        Me.txtversion.Name = "txtversion"
        Me.txtversion.Size = New System.Drawing.Size(66, 20)
        Me.txtversion.TabIndex = 364
        Me.txtversion.Visible = False
        '
        'txtDownloadLocation
        '
        Me.txtDownloadLocation.Location = New System.Drawing.Point(64, 225)
        Me.txtDownloadLocation.Name = "txtDownloadLocation"
        Me.txtDownloadLocation.Size = New System.Drawing.Size(66, 20)
        Me.txtDownloadLocation.TabIndex = 363
        Me.txtDownloadLocation.Visible = False
        '
        'txtUpdateUrl
        '
        Me.txtUpdateUrl.Location = New System.Drawing.Point(64, 196)
        Me.txtUpdateUrl.Name = "txtUpdateUrl"
        Me.txtUpdateUrl.Size = New System.Drawing.Size(66, 20)
        Me.txtUpdateUrl.TabIndex = 362
        Me.txtUpdateUrl.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'AutoUpdateTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtversion)
        Me.Controls.Add(Me.txtDownloadLocation)
        Me.Controls.Add(Me.txtUpdateUrl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AutoUpdateTest"
        Me.Text = "AutoUpdateTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtversion As System.Windows.Forms.TextBox
    Friend WithEvents txtDownloadLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateUrl As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
