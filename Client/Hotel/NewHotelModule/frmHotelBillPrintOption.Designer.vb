<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelBillPrintOption
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
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtRoomCharges = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.txtPosCharges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalCharges = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFoliono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(182, 247)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(155, 33)
        Me.cmdConfirmPayment.TabIndex = 2
        Me.cmdConfirmPayment.Text = "Print Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtRoomCharges
        '
        Me.txtRoomCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomCharges.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRoomCharges.ForeColor = System.Drawing.Color.Black
        Me.txtRoomCharges.Location = New System.Drawing.Point(182, 55)
        Me.txtRoomCharges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomCharges.Name = "txtRoomCharges"
        Me.txtRoomCharges.Size = New System.Drawing.Size(155, 29)
        Me.txtRoomCharges.TabIndex = 0
        Me.txtRoomCharges.Text = "0.00"
        Me.txtRoomCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Total Room Charges"
        '
        'roomid
        '
        Me.roomid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.roomid.ForeColor = System.Drawing.Color.Black
        Me.roomid.Location = New System.Drawing.Point(443, 351)
        Me.roomid.Margin = New System.Windows.Forms.Padding(5)
        Me.roomid.Name = "roomid"
        Me.roomid.Size = New System.Drawing.Size(39, 22)
        Me.roomid.TabIndex = 482
        Me.roomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.roomid.Visible = False
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(441, 320)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(4)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(41, 22)
        Me.itemcode.TabIndex = 485
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(443, 383)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(39, 22)
        Me.guestid.TabIndex = 488
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'txtPosCharges
        '
        Me.txtPosCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosCharges.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPosCharges.ForeColor = System.Drawing.Color.Black
        Me.txtPosCharges.Location = New System.Drawing.Point(182, 86)
        Me.txtPosCharges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPosCharges.Name = "txtPosCharges"
        Me.txtPosCharges.Size = New System.Drawing.Size(155, 29)
        Me.txtPosCharges.TabIndex = 489
        Me.txtPosCharges.Text = "0.00"
        Me.txtPosCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(62, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 490
        Me.Label2.Text = "POS/Other Charges"
        '
        'txtPayment
        '
        Me.txtPayment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPayment.ForeColor = System.Drawing.Color.Black
        Me.txtPayment.Location = New System.Drawing.Point(182, 150)
        Me.txtPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(155, 29)
        Me.txtPayment.TabIndex = 1
        Me.txtPayment.Text = "0.00"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(118, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 492
        Me.Label3.Text = "Payment"
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBalanceDue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBalanceDue.ForeColor = System.Drawing.Color.Black
        Me.txtBalanceDue.Location = New System.Drawing.Point(182, 215)
        Me.txtBalanceDue.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.ReadOnly = True
        Me.txtBalanceDue.Size = New System.Drawing.Size(155, 29)
        Me.txtBalanceDue.TabIndex = 3
        Me.txtBalanceDue.Text = "0.00"
        Me.txtBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(100, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 494
        Me.Label4.Text = "Balance Due"
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCharges.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTotalCharges.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCharges.Location = New System.Drawing.Point(182, 118)
        Me.txtTotalCharges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.ReadOnly = True
        Me.txtTotalCharges.Size = New System.Drawing.Size(155, 29)
        Me.txtTotalCharges.TabIndex = 1
        Me.txtTotalCharges.Text = "0.00"
        Me.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(93, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 496
        Me.Label5.Text = "Total Charges"
        '
        'txtFoliono
        '
        Me.txtFoliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFoliono.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtFoliono.ForeColor = System.Drawing.Color.Black
        Me.txtFoliono.Location = New System.Drawing.Point(182, 23)
        Me.txtFoliono.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFoliono.Name = "txtFoliono"
        Me.txtFoliono.ReadOnly = True
        Me.txtFoliono.Size = New System.Drawing.Size(155, 29)
        Me.txtFoliono.TabIndex = 497
        Me.txtFoliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(117, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 498
        Me.Label6.Text = "Folio No."
        '
        'txtDiscount
        '
        Me.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(182, 182)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(155, 29)
        Me.txtDiscount.TabIndex = 499
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(118, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 500
        Me.Label7.Text = "Discount"
        '
        'frmHotelBillPrintOption
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(446, 310)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFoliono)
        Me.Controls.Add(Me.txtTotalCharges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBalanceDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPosCharges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.roomid)
        Me.Controls.Add(Me.txtRoomCharges)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHotelBillPrintOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtRoomCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents roomid As System.Windows.Forms.TextBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents txtPosCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBalanceDue As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFoliono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
