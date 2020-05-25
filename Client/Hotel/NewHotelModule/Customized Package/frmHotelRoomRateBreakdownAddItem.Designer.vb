<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelRoomRateBreakdownAddItem
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ratecode = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.breakdowntype = New System.Windows.Forms.TextBox()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.txtDayRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(114, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Item Name"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmount.Location = New System.Drawing.Point(114, 45)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(139, 25)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtitemname
        '
        Me.txtitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtitemname.DropDownHeight = 130
        Me.txtitemname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtitemname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtitemname.ForeColor = System.Drawing.Color.Black
        Me.txtitemname.FormattingEnabled = True
        Me.txtitemname.IntegralHeight = False
        Me.txtitemname.ItemHeight = 17
        Me.txtitemname.Location = New System.Drawing.Point(114, 16)
        Me.txtitemname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtitemname.MaxDropDownItems = 7
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(349, 25)
        Me.txtitemname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(44, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Amount"
        '
        'ratecode
        '
        Me.ratecode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ratecode.ForeColor = System.Drawing.Color.Black
        Me.ratecode.Location = New System.Drawing.Point(324, 203)
        Me.ratecode.Margin = New System.Windows.Forms.Padding(5)
        Me.ratecode.Name = "ratecode"
        Me.ratecode.Size = New System.Drawing.Size(57, 23)
        Me.ratecode.TabIndex = 808
        Me.ratecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ratecode.Visible = False
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(257, 203)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(57, 23)
        Me.roomtype.TabIndex = 807
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomtype.Visible = False
        '
        'breakdowntype
        '
        Me.breakdowntype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.breakdowntype.ForeColor = System.Drawing.Color.Black
        Me.breakdowntype.Location = New System.Drawing.Point(324, 193)
        Me.breakdowntype.Margin = New System.Windows.Forms.Padding(5)
        Me.breakdowntype.Name = "breakdowntype"
        Me.breakdowntype.Size = New System.Drawing.Size(57, 23)
        Me.breakdowntype.TabIndex = 809
        Me.breakdowntype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.breakdowntype.Visible = False
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(324, 165)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(5)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(57, 23)
        Me.itemcode.TabIndex = 810
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'txtDayRate
        '
        Me.txtDayRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDayRate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDayRate.Location = New System.Drawing.Point(324, 135)
        Me.txtDayRate.Name = "txtDayRate"
        Me.txtDayRate.Size = New System.Drawing.Size(57, 22)
        Me.txtDayRate.TabIndex = 811
        Me.txtDayRate.Visible = False
        '
        'frmHotelRoomRateBreakdownAddItem
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 117)
        Me.Controls.Add(Me.txtDayRate)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.breakdowntype)
        Me.Controls.Add(Me.ratecode)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHotelRoomRateBreakdownAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtitemname As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ratecode As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
    Friend WithEvents breakdowntype As System.Windows.Forms.TextBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDayRate As System.Windows.Forms.TextBox

End Class
