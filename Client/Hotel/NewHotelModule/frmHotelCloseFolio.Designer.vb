<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCloseFolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCloseFolio))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalTransaction = New System.Windows.Forms.TextBox()
        Me.txtFoliono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRatings = New System.Windows.Forms.ComboBox()
        Me.txtValidity = New System.Windows.Forms.TextBox()
        Me.ratingsid = New System.Windows.Forms.TextBox()
        Me.guestid = New System.Windows.Forms.TextBox()
        Me.txtGuestname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblYearly = New System.Windows.Forms.Label()
        Me.txtYearTotal = New System.Windows.Forms.TextBox()
        Me.ckSetLEvel = New DevExpress.XtraEditors.CheckEdit()
        Me.ckyearly = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCurrentValidity = New System.Windows.Forms.TextBox()
        CType(Me.ckSetLEvel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckyearly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(188, 243)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(186, 40)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm Close Folio"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(121, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Validity"
        '
        'txtTotalTransaction
        '
        Me.txtTotalTransaction.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalTransaction.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalTransaction.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.txtTotalTransaction.ForeColor = System.Drawing.Color.Black
        Me.txtTotalTransaction.Location = New System.Drawing.Point(188, 61)
        Me.txtTotalTransaction.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalTransaction.Name = "txtTotalTransaction"
        Me.txtTotalTransaction.ReadOnly = True
        Me.txtTotalTransaction.Size = New System.Drawing.Size(186, 29)
        Me.txtTotalTransaction.TabIndex = 0
        Me.txtTotalTransaction.Text = "0.00"
        Me.txtTotalTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFoliono
        '
        Me.txtFoliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFoliono.Font = New System.Drawing.Font("Segoe UI", 15.25!)
        Me.txtFoliono.ForeColor = System.Drawing.Color.Black
        Me.txtFoliono.Location = New System.Drawing.Point(188, 23)
        Me.txtFoliono.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFoliono.Name = "txtFoliono"
        Me.txtFoliono.ReadOnly = True
        Me.txtFoliono.Size = New System.Drawing.Size(132, 35)
        Me.txtFoliono.TabIndex = 512
        Me.txtFoliono.Text = "2362XK"
        Me.txtFoliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(113, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 513
        Me.Label1.Text = "Folio No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(85, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 514
        Me.Label2.Text = "Current Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(51, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 516
        Me.Label3.Text = "Set Rewards Level"
        '
        'txtRatings
        '
        Me.txtRatings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRatings.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRatings.DropDownHeight = 130
        Me.txtRatings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtRatings.Enabled = False
        Me.txtRatings.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtRatings.ForeColor = System.Drawing.Color.Black
        Me.txtRatings.FormattingEnabled = True
        Me.txtRatings.IntegralHeight = False
        Me.txtRatings.ItemHeight = 20
        Me.txtRatings.Location = New System.Drawing.Point(188, 182)
        Me.txtRatings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRatings.MaxDropDownItems = 7
        Me.txtRatings.Name = "txtRatings"
        Me.txtRatings.Size = New System.Drawing.Size(186, 28)
        Me.txtRatings.TabIndex = 515
        '
        'txtValidity
        '
        Me.txtValidity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtValidity.ForeColor = System.Drawing.Color.Black
        Me.txtValidity.Location = New System.Drawing.Point(188, 213)
        Me.txtValidity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValidity.Name = "txtValidity"
        Me.txtValidity.ReadOnly = True
        Me.txtValidity.Size = New System.Drawing.Size(186, 27)
        Me.txtValidity.TabIndex = 517
        Me.txtValidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ratingsid
        '
        Me.ratingsid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ratingsid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratingsid.ForeColor = System.Drawing.Color.Black
        Me.ratingsid.Location = New System.Drawing.Point(493, 23)
        Me.ratingsid.Margin = New System.Windows.Forms.Padding(5)
        Me.ratingsid.Name = "ratingsid"
        Me.ratingsid.Size = New System.Drawing.Size(37, 22)
        Me.ratingsid.TabIndex = 518
        Me.ratingsid.Visible = False
        '
        'guestid
        '
        Me.guestid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guestid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestid.ForeColor = System.Drawing.Color.Black
        Me.guestid.Location = New System.Drawing.Point(446, 23)
        Me.guestid.Margin = New System.Windows.Forms.Padding(5)
        Me.guestid.Name = "guestid"
        Me.guestid.Size = New System.Drawing.Size(37, 22)
        Me.guestid.TabIndex = 519
        Me.guestid.Visible = False
        '
        'txtGuestname
        '
        Me.txtGuestname.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtGuestname.ForeColor = System.Drawing.Color.Black
        Me.txtGuestname.Location = New System.Drawing.Point(188, 125)
        Me.txtGuestname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuestname.Name = "txtGuestname"
        Me.txtGuestname.ReadOnly = True
        Me.txtGuestname.Size = New System.Drawing.Size(309, 27)
        Me.txtGuestname.TabIndex = 521
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(89, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 520
        Me.Label5.Text = "Guest Name"
        '
        'lblYearly
        '
        Me.lblYearly.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblYearly.Location = New System.Drawing.Point(21, 97)
        Me.lblYearly.Name = "lblYearly"
        Me.lblYearly.Size = New System.Drawing.Size(158, 20)
        Me.lblYearly.TabIndex = 523
        Me.lblYearly.Text = "Whole Year Total"
        Me.lblYearly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYearTotal
        '
        Me.txtYearTotal.BackColor = System.Drawing.Color.Yellow
        Me.txtYearTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtYearTotal.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.txtYearTotal.ForeColor = System.Drawing.Color.Black
        Me.txtYearTotal.Location = New System.Drawing.Point(188, 93)
        Me.txtYearTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYearTotal.Name = "txtYearTotal"
        Me.txtYearTotal.ReadOnly = True
        Me.txtYearTotal.Size = New System.Drawing.Size(186, 29)
        Me.txtYearTotal.TabIndex = 522
        Me.txtYearTotal.Text = "0.00"
        Me.txtYearTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ckSetLEvel
        '
        Me.ckSetLEvel.Location = New System.Drawing.Point(188, 156)
        Me.ckSetLEvel.Name = "ckSetLEvel"
        Me.ckSetLEvel.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.ckSetLEvel.Properties.Appearance.Options.UseFont = True
        Me.ckSetLEvel.Properties.Caption = "Set Reward Level"
        Me.ckSetLEvel.Size = New System.Drawing.Size(186, 23)
        Me.ckSetLEvel.TabIndex = 524
        '
        'ckyearly
        '
        Me.ckyearly.Location = New System.Drawing.Point(447, 53)
        Me.ckyearly.Name = "ckyearly"
        Me.ckyearly.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.ckyearly.Properties.Appearance.Options.UseFont = True
        Me.ckyearly.Properties.Caption = "yearly"
        Me.ckyearly.Size = New System.Drawing.Size(106, 23)
        Me.ckyearly.TabIndex = 525
        Me.ckyearly.Visible = False
        '
        'txtCurrentValidity
        '
        Me.txtCurrentValidity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurrentValidity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentValidity.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentValidity.Location = New System.Drawing.Point(447, 81)
        Me.txtCurrentValidity.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCurrentValidity.Name = "txtCurrentValidity"
        Me.txtCurrentValidity.Size = New System.Drawing.Size(37, 22)
        Me.txtCurrentValidity.TabIndex = 526
        Me.txtCurrentValidity.Visible = False
        '
        'frmHotelCloseFolio
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(565, 313)
        Me.Controls.Add(Me.txtCurrentValidity)
        Me.Controls.Add(Me.ckyearly)
        Me.Controls.Add(Me.ckSetLEvel)
        Me.Controls.Add(Me.lblYearly)
        Me.Controls.Add(Me.txtYearTotal)
        Me.Controls.Add(Me.txtGuestname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.guestid)
        Me.Controls.Add(Me.ratingsid)
        Me.Controls.Add(Me.txtValidity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRatings)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFoliono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalTransaction)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelCloseFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Close Folio Transaction"
        CType(Me.ckSetLEvel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckyearly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTransaction As System.Windows.Forms.TextBox
    Friend WithEvents txtFoliono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRatings As System.Windows.Forms.ComboBox
    Friend WithEvents txtValidity As System.Windows.Forms.TextBox
    Friend WithEvents ratingsid As System.Windows.Forms.TextBox
    Friend WithEvents guestid As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblYearly As System.Windows.Forms.Label
    Friend WithEvents txtYearTotal As System.Windows.Forms.TextBox
    Friend WithEvents ckSetLEvel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckyearly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtCurrentValidity As System.Windows.Forms.TextBox
End Class
