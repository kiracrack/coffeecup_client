<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSTagtoRoomTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSTagtoRoomTransaction))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.txtRemainingCredit = New System.Windows.Forms.TextBox()
        Me.ckCreditLimit = New System.Windows.Forms.CheckBox()
        Me.txtGuestCheckno = New System.Windows.Forms.TextBox()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.hotelcifid = New System.Windows.Forms.TextBox()
        Me.companyid = New System.Windows.Forms.TextBox()
        Me.txtRatings = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRewardPrevileges = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(182, 15)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(247, 15)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Reference # 1000010-105"
        Me.lblTransaction.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.BackColor = System.Drawing.Color.Gold
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(244, 35)
        Me.txtTotalOnScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.ReadOnly = True
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(185, 34)
        Me.txtTotalOnScreen.TabIndex = 17
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(135, 219)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(185, 38)
        Me.cmdConfirmPayment.TabIndex = 1
        Me.cmdConfirmPayment.Text = "Confirm "
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(25, 427)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(52, 22)
        Me.txtBatchcode.TabIndex = 396
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBatchcode.Visible = False
        '
        'guestid
        '
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(25, 457)
        Me.guestid.Margin = New System.Windows.Forms.Padding(4)
        Me.guestid.Name = "guestid"
        Me.guestid.ReadOnly = True
        Me.guestid.Size = New System.Drawing.Size(52, 22)
        Me.guestid.TabIndex = 398
        Me.guestid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.guestid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(136, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Total Amount"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRoomNumber.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNumber.Location = New System.Drawing.Point(135, 74)
        Me.txtRoomNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(73, 23)
        Me.txtRoomNumber.TabIndex = 0
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(38, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "Room  Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuestName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuestName.ForeColor = System.Drawing.Color.Black
        Me.txtGuestName.Location = New System.Drawing.Point(210, 74)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(219, 23)
        Me.txtGuestName.TabIndex = 409
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(85, 457)
        Me.folioid.Margin = New System.Windows.Forms.Padding(4)
        Me.folioid.Name = "folioid"
        Me.folioid.ReadOnly = True
        Me.folioid.Size = New System.Drawing.Size(61, 22)
        Me.folioid.TabIndex = 411
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.folioid.Visible = False
        '
        'txtRemainingCredit
        '
        Me.txtRemainingCredit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemainingCredit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemainingCredit.ForeColor = System.Drawing.Color.Black
        Me.txtRemainingCredit.Location = New System.Drawing.Point(96, 488)
        Me.txtRemainingCredit.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemainingCredit.Name = "txtRemainingCredit"
        Me.txtRemainingCredit.ReadOnly = True
        Me.txtRemainingCredit.Size = New System.Drawing.Size(99, 23)
        Me.txtRemainingCredit.TabIndex = 487
        Me.txtRemainingCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRemainingCredit.Visible = False
        '
        'ckCreditLimit
        '
        Me.ckCreditLimit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckCreditLimit.Location = New System.Drawing.Point(30, 388)
        Me.ckCreditLimit.Name = "ckCreditLimit"
        Me.ckCreditLimit.Size = New System.Drawing.Size(108, 25)
        Me.ckCreditLimit.TabIndex = 488
        Me.ckCreditLimit.Text = "Credit Limit"
        Me.ckCreditLimit.UseVisualStyleBackColor = True
        Me.ckCreditLimit.Visible = False
        '
        'txtGuestCheckno
        '
        Me.txtGuestCheckno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuestCheckno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuestCheckno.ForeColor = System.Drawing.Color.Black
        Me.txtGuestCheckno.Location = New System.Drawing.Point(135, 192)
        Me.txtGuestCheckno.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuestCheckno.Name = "txtGuestCheckno"
        Me.txtGuestCheckno.Size = New System.Drawing.Size(73, 23)
        Me.txtGuestCheckno.TabIndex = 1
        Me.txtGuestCheckno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblremarks
        '
        Me.lblremarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblremarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblremarks.Location = New System.Drawing.Point(13, 195)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(114, 15)
        Me.lblremarks.TabIndex = 492
        Me.lblremarks.Text = "Guest Check No."
        Me.lblremarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(210, 192)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(219, 23)
        Me.txtRemarks.TabIndex = 2
        '
        'roomid
        '
        Me.roomid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.roomid.ForeColor = System.Drawing.Color.Black
        Me.roomid.Location = New System.Drawing.Point(85, 427)
        Me.roomid.Margin = New System.Windows.Forms.Padding(4)
        Me.roomid.Name = "roomid"
        Me.roomid.ReadOnly = True
        Me.roomid.Size = New System.Drawing.Size(52, 22)
        Me.roomid.TabIndex = 493
        Me.roomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.roomid.Visible = False
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(145, 427)
        Me.foliono.Margin = New System.Windows.Forms.Padding(4)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(52, 22)
        Me.foliono.TabIndex = 494
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.foliono.Visible = False
        '
        'hotelcifid
        '
        Me.hotelcifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.hotelcifid.ForeColor = System.Drawing.Color.Black
        Me.hotelcifid.Location = New System.Drawing.Point(26, 487)
        Me.hotelcifid.Margin = New System.Windows.Forms.Padding(4)
        Me.hotelcifid.Name = "hotelcifid"
        Me.hotelcifid.ReadOnly = True
        Me.hotelcifid.Size = New System.Drawing.Size(61, 22)
        Me.hotelcifid.TabIndex = 489
        Me.hotelcifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.hotelcifid.Visible = False
        '
        'companyid
        '
        Me.companyid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.companyid.ForeColor = System.Drawing.Color.Black
        Me.companyid.Location = New System.Drawing.Point(210, 490)
        Me.companyid.Margin = New System.Windows.Forms.Padding(4)
        Me.companyid.Name = "companyid"
        Me.companyid.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(52, 22)
        Me.companyid.TabIndex = 495
        Me.companyid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.companyid.Visible = False
        '
        'txtRatings
        '
        Me.txtRatings.BackColor = System.Drawing.Color.Silver
        Me.txtRatings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtRatings.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtRatings.ForeColor = System.Drawing.Color.Black
        Me.txtRatings.Location = New System.Drawing.Point(135, 100)
        Me.txtRatings.Name = "txtRatings"
        Me.txtRatings.Size = New System.Drawing.Size(223, 31)
        Me.txtRatings.TabIndex = 819
        Me.txtRatings.Text = "UNRATED LEVEL"
        Me.txtRatings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(48, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 818
        Me.Label20.Text = "Rewards Level"
        '
        'txtRewardPrevileges
        '
        Me.txtRewardPrevileges.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRewardPrevileges.ForeColor = System.Drawing.Color.Black
        Me.txtRewardPrevileges.Location = New System.Drawing.Point(135, 133)
        Me.txtRewardPrevileges.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRewardPrevileges.Multiline = True
        Me.txtRewardPrevileges.Name = "txtRewardPrevileges"
        Me.txtRewardPrevileges.ReadOnly = True
        Me.txtRewardPrevileges.Size = New System.Drawing.Size(294, 56)
        Me.txtRewardPrevileges.TabIndex = 820
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(22, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 821
        Me.Label3.Text = "Rewards Previleges"
        '
        'frmPOSTagtoRoomTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(478, 268)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRewardPrevileges)
        Me.Controls.Add(Me.txtRatings)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.roomid)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblremarks)
        Me.Controls.Add(Me.txtGuestCheckno)
        Me.Controls.Add(Me.hotelcifid)
        Me.Controls.Add(Me.ckCreditLimit)
        Me.Controls.Add(Me.txtRemainingCredit)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSTagtoRoomTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge to Hotel Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents txtRemainingCredit As System.Windows.Forms.TextBox
    Friend WithEvents ckCreditLimit As System.Windows.Forms.CheckBox
    Friend WithEvents txtGuestCheckno As System.Windows.Forms.TextBox
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents roomid As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents hotelcifid As System.Windows.Forms.TextBox
    Friend WithEvents companyid As System.Windows.Forms.TextBox
    Friend WithEvents txtRatings As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRewardPrevileges As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
