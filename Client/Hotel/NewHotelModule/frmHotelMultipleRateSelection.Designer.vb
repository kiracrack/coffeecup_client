<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelMultipleRateSelection
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rateid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(252, 74)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(134, 34)
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
        Me.txtRoomType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.FormattingEnabled = True
        Me.txtRoomType.IntegralHeight = False
        Me.txtRoomType.ItemHeight = 20
        Me.txtRoomType.Items.AddRange(New Object() {"PER PERSON", "PER NIGHT"})
        Me.txtRoomType.Location = New System.Drawing.Point(48, 13)
        Me.txtRoomType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomType.MaxDropDownItems = 7
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.Size = New System.Drawing.Size(338, 28)
        Me.txtRoomType.TabIndex = 826
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 98)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 19)
        Me.CheckBox1.TabIndex = 827
        Me.CheckBox1.Text = "Charge Per Nyt"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalanceDue.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalanceDue.ForeColor = System.Drawing.Color.Black
        Me.txtBalanceDue.Location = New System.Drawing.Point(252, 45)
        Me.txtBalanceDue.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.ReadOnly = True
        Me.txtBalanceDue.Size = New System.Drawing.Size(134, 25)
        Me.txtBalanceDue.TabIndex = 828
        Me.txtBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(181, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 829
        Me.Label10.Text = "Room Rate"
        '
        'rateid
        '
        Me.rateid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.rateid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateid.Location = New System.Drawing.Point(10, 70)
        Me.rateid.Name = "rateid"
        Me.rateid.Size = New System.Drawing.Size(70, 22)
        Me.rateid.TabIndex = 830
        Me.rateid.Visible = False
        '
        'frmHotelMultipleRateSelection
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(431, 123)
        Me.Controls.Add(Me.rateid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBalanceDue)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.cmdProceed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelMultipleRateSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Rate Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents txtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtBalanceDue As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rateid As System.Windows.Forms.TextBox
End Class
