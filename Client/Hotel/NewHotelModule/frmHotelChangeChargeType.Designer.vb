<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelChangeChargeType
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
        Me.txtRoomType = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(145, 77)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(140, 34)
        Me.cmdProceed.TabIndex = 19
        Me.cmdProceed.Text = "Confirm"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomType.DropDownHeight = 130
        Me.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.FormattingEnabled = True
        Me.txtRoomType.IntegralHeight = False
        Me.txtRoomType.ItemHeight = 23
        Me.txtRoomType.Items.AddRange(New Object() {"Per Pax Charge", "Per Night Charge"})
        Me.txtRoomType.Location = New System.Drawing.Point(75, 43)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.MaxDropDownItems = 7
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(281, 31)
        Me.txtRoomType.TabIndex = 826
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label22.Location = New System.Drawing.Point(117, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(197, 17)
        Me.Label22.TabIndex = 827
        Me.Label22.Text = "Please select charge type option"
        '
        'frmHotelChangeChargeType
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 129)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.cmdProceed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelChangeChargeType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Charge Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents txtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
