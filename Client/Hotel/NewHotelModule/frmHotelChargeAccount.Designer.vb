<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelChargeAccount
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
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.txtGLItem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(165, 212)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(126, 37)
        Me.cmdConfirmPayment.TabIndex = 4
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtAmountTender
        '
        Me.txtAmountTender.BackColor = System.Drawing.Color.Yellow
        Me.txtAmountTender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(165, 49)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(155, 29)
        Me.txtAmountTender.TabIndex = 0
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(79, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Total Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(104, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 451
        Me.Label7.Text = "Folio No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(87, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 474
        Me.Label2.Text = "Select Client"
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.DropDownHeight = 130
        Me.txtClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtClient.ForeColor = System.Drawing.Color.Black
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.IntegralHeight = False
        Me.txtClient.ItemHeight = 15
        Me.txtClient.Location = New System.Drawing.Point(165, 81)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClient.MaxDropDownItems = 7
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(238, 23)
        Me.txtClient.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(107, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 479
        Me.Label4.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(165, 160)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(238, 49)
        Me.txtRemarks.TabIndex = 3
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
        'txtGLItem
        '
        Me.txtGLItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGLItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtGLItem.DropDownHeight = 130
        Me.txtGLItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGLItem.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtGLItem.ForeColor = System.Drawing.Color.Black
        Me.txtGLItem.FormattingEnabled = True
        Me.txtGLItem.IntegralHeight = False
        Me.txtGLItem.ItemHeight = 15
        Me.txtGLItem.Location = New System.Drawing.Point(165, 107)
        Me.txtGLItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGLItem.MaxDropDownItems = 7
        Me.txtGLItem.Name = "txtGLItem"
        Me.txtGLItem.Size = New System.Drawing.Size(238, 23)
        Me.txtGLItem.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(93, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 484
        Me.Label6.Text = "Item Name"
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
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(165, 22)
        Me.foliono.Margin = New System.Windows.Forms.Padding(4)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(96, 24)
        Me.foliono.TabIndex = 486
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtReferenceNo
        '
        Me.txtReferenceNo.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtReferenceNo.ForeColor = System.Drawing.Color.Black
        Me.txtReferenceNo.Location = New System.Drawing.Point(165, 133)
        Me.txtReferenceNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(155, 24)
        Me.txtReferenceNo.TabIndex = 2
        Me.txtReferenceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(78, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 489
        Me.Label3.Text = "Reference No."
        '
        'frmHotelChargeAccount
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(509, 275)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.txtGLItem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.roomid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmHotelChargeAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge to Client Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents roomid As System.Windows.Forms.TextBox
    Friend WithEvents txtGLItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents txtReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
