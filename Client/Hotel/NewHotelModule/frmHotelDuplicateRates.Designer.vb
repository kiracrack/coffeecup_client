<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelDuplicateRates
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
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRateName = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(141, 74)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(140, 34)
        Me.cmdProceed.TabIndex = 19
        Me.cmdProceed.Text = "Confirm"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label22.Location = New System.Drawing.Point(69, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(285, 17)
        Me.Label22.TabIndex = 827
        Me.Label22.Text = "Please enter or change rate name you prefered"
        '
        'txtRateName
        '
        Me.txtRateName.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtRateName.ForeColor = System.Drawing.Color.Black
        Me.txtRateName.Location = New System.Drawing.Point(30, 42)
        Me.txtRateName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRateName.Name = "txtRateName"
        Me.txtRateName.Size = New System.Drawing.Size(363, 26)
        Me.txtRateName.TabIndex = 0
        Me.txtRateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(457, 14)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(48, 22)
        Me.foliono.TabIndex = 828
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'roomtype
        '
        Me.roomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(457, 39)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(48, 22)
        Me.roomtype.TabIndex = 829
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'rateid
        '
        Me.rateid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rateid.ForeColor = System.Drawing.Color.Black
        Me.rateid.Location = New System.Drawing.Point(457, 65)
        Me.rateid.Margin = New System.Windows.Forms.Padding(5)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(48, 22)
        Me.rateid.TabIndex = 830
        Me.rateid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rateid.Visible = False
        '
        'frmHotelDuplicateRates
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 126)
        Me.Controls.Add(Me.rateid)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.txtRateName)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdProceed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelDuplicateRates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duplicate Standard Rate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtRateName As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents rateid As System.Windows.Forms.TextBox
End Class
