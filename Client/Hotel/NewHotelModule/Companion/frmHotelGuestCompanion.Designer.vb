<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelGuestCompanion
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
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtRoomNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFullname
        '
        Me.txtFullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(101, 38)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(198, 22)
        Me.txtFullname.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(101, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Fullname"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(301, 38)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(65, 22)
        Me.txtAge.TabIndex = 1
        Me.txtAge.Text = "AGE"
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'id
        '
        Me.id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(28, 125)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(65, 22)
        Me.id.TabIndex = 20
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Location = New System.Drawing.Point(101, 125)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(65, 22)
        Me.mode.TabIndex = 21
        Me.mode.Visible = False
        '
        'txtRoomNo
        '
        Me.txtRoomNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRoomNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoomNo.DropDownHeight = 130
        Me.txtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRoomNo.Font = New System.Drawing.Font("Segoe UI", 9.55!)
        Me.txtRoomNo.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNo.FormattingEnabled = True
        Me.txtRoomNo.IntegralHeight = False
        Me.txtRoomNo.ItemHeight = 17
        Me.txtRoomNo.Location = New System.Drawing.Point(101, 9)
        Me.txtRoomNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomNo.MaxDropDownItems = 7
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(110, 25)
        Me.txtRoomNo.TabIndex = 809
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 810
        Me.Label1.Text = "Room No."
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliono.Location = New System.Drawing.Point(343, 81)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(46, 22)
        Me.foliono.TabIndex = 811
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folioid.Location = New System.Drawing.Point(291, 81)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(46, 22)
        Me.folioid.TabIndex = 812
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'frmHotelGuestCompanion
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 115)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRoomNo)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFullname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelGuestCompanion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Companion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents folioid As System.Windows.Forms.TextBox

End Class
