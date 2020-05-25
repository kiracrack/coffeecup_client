<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSPaymentTypeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSPaymentTypeDetails))
        Me.txtCardPOSBankAccounts = New System.Windows.Forms.ComboBox()
        Me.banknumber = New System.Windows.Forms.TextBox()
        Me.groupCheck = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCheckDetails = New System.Windows.Forms.TextBox()
        Me.txtCheckNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupCard = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcardTraceNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblcardholdername = New System.Windows.Forms.Label()
        Me.txtCardHolderName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCardDetails = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.groupDeposit = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDepositRefNumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDepositBankCode = New System.Windows.Forms.TextBox()
        Me.txtDepositBankAccount = New System.Windows.Forms.ComboBox()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.groupCheck.SuspendLayout()
        Me.groupCard.SuspendLayout()
        Me.groupDeposit.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCardPOSBankAccounts
        '
        Me.txtCardPOSBankAccounts.DropDownHeight = 130
        Me.txtCardPOSBankAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCardPOSBankAccounts.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCardPOSBankAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtCardPOSBankAccounts.FormattingEnabled = True
        Me.txtCardPOSBankAccounts.IntegralHeight = False
        Me.txtCardPOSBankAccounts.ItemHeight = 19
        Me.txtCardPOSBankAccounts.Location = New System.Drawing.Point(13, 184)
        Me.txtCardPOSBankAccounts.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardPOSBankAccounts.MaxDropDownItems = 7
        Me.txtCardPOSBankAccounts.Name = "txtCardPOSBankAccounts"
        Me.txtCardPOSBankAccounts.Size = New System.Drawing.Size(191, 27)
        Me.txtCardPOSBankAccounts.TabIndex = 3
        '
        'banknumber
        '
        Me.banknumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.banknumber.ForeColor = System.Drawing.Color.Black
        Me.banknumber.Location = New System.Drawing.Point(251, 235)
        Me.banknumber.Margin = New System.Windows.Forms.Padding(5)
        Me.banknumber.Name = "banknumber"
        Me.banknumber.ReadOnly = True
        Me.banknumber.Size = New System.Drawing.Size(31, 22)
        Me.banknumber.TabIndex = 406
        Me.banknumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.banknumber.Visible = False
        '
        'groupCheck
        '
        Me.groupCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupCheck.Controls.Add(Me.Label5)
        Me.groupCheck.Controls.Add(Me.txtCheckName)
        Me.groupCheck.Controls.Add(Me.Label4)
        Me.groupCheck.Controls.Add(Me.txtCheckDetails)
        Me.groupCheck.Controls.Add(Me.txtCheckNumber)
        Me.groupCheck.Controls.Add(Me.Label1)
        Me.groupCheck.Location = New System.Drawing.Point(12, 12)
        Me.groupCheck.Name = "groupCheck"
        Me.groupCheck.Size = New System.Drawing.Size(319, 267)
        Me.groupCheck.TabIndex = 409
        Me.groupCheck.TabStop = False
        Me.groupCheck.Text = "Check Payment Details"
        Me.groupCheck.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(13, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 15)
        Me.Label5.TabIndex = 410
        Me.Label5.Text = "Check Name (name of person indicated)"
        '
        'txtCheckName
        '
        Me.txtCheckName.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckName.ForeColor = System.Drawing.Color.Black
        Me.txtCheckName.Location = New System.Drawing.Point(13, 137)
        Me.txtCheckName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckName.Name = "txtCheckName"
        Me.txtCheckName.Size = New System.Drawing.Size(281, 26)
        Me.txtCheckName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(13, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 15)
        Me.Label4.TabIndex = 408
        Me.Label4.Text = "Check Details (Bank Name)"
        '
        'txtCheckDetails
        '
        Me.txtCheckDetails.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCheckDetails.Location = New System.Drawing.Point(13, 88)
        Me.txtCheckDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckDetails.Name = "txtCheckDetails"
        Me.txtCheckDetails.Size = New System.Drawing.Size(281, 26)
        Me.txtCheckDetails.TabIndex = 1
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCheckNumber.Location = New System.Drawing.Point(13, 39)
        Me.txtCheckNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(191, 26)
        Me.txtCheckNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "Check Account Number"
        '
        'groupCard
        '
        Me.groupCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupCard.Controls.Add(Me.Label9)
        Me.groupCard.Controls.Add(Me.txtcardTraceNumber)
        Me.groupCard.Controls.Add(Me.Label6)
        Me.groupCard.Controls.Add(Me.banknumber)
        Me.groupCard.Controls.Add(Me.lblcardholdername)
        Me.groupCard.Controls.Add(Me.txtCardHolderName)
        Me.groupCard.Controls.Add(Me.Label7)
        Me.groupCard.Controls.Add(Me.txtCardDetails)
        Me.groupCard.Controls.Add(Me.txtCardNumber)
        Me.groupCard.Controls.Add(Me.Label8)
        Me.groupCard.Controls.Add(Me.txtCardPOSBankAccounts)
        Me.groupCard.Location = New System.Drawing.Point(12, 12)
        Me.groupCard.Name = "groupCard"
        Me.groupCard.Size = New System.Drawing.Size(319, 267)
        Me.groupCard.TabIndex = 411
        Me.groupCard.TabStop = False
        Me.groupCard.Text = "Card Payment Details"
        Me.groupCard.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(13, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 15)
        Me.Label9.TabIndex = 413
        Me.Label9.Text = "Merchant POS Machine"
        '
        'txtcardTraceNumber
        '
        Me.txtcardTraceNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtcardTraceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtcardTraceNumber.Location = New System.Drawing.Point(13, 230)
        Me.txtcardTraceNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcardTraceNumber.Name = "txtcardTraceNumber"
        Me.txtcardTraceNumber.Size = New System.Drawing.Size(191, 26)
        Me.txtcardTraceNumber.TabIndex = 4
        Me.txtcardTraceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(13, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 15)
        Me.Label6.TabIndex = 411
        Me.Label6.Text = "Approval Code (Trance Number)"
        '
        'lblcardholdername
        '
        Me.lblcardholdername.AutoSize = True
        Me.lblcardholdername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblcardholdername.Location = New System.Drawing.Point(13, 119)
        Me.lblcardholdername.Name = "lblcardholdername"
        Me.lblcardholdername.Size = New System.Drawing.Size(252, 15)
        Me.lblcardholdername.TabIndex = 410
        Me.lblcardholdername.Text = "Card Holder Name (name of person indicated)"
        '
        'txtCardHolderName
        '
        Me.txtCardHolderName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCardHolderName.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCardHolderName.ForeColor = System.Drawing.Color.Black
        Me.txtCardHolderName.Location = New System.Drawing.Point(13, 137)
        Me.txtCardHolderName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardHolderName.Name = "txtCardHolderName"
        Me.txtCardHolderName.Size = New System.Drawing.Size(281, 26)
        Me.txtCardHolderName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(13, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 15)
        Me.Label7.TabIndex = 408
        Me.Label7.Text = "Card Details (Bank Name)"
        '
        'txtCardDetails
        '
        Me.txtCardDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCardDetails.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCardDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCardDetails.Location = New System.Drawing.Point(13, 88)
        Me.txtCardDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardDetails.Name = "txtCardDetails"
        Me.txtCardDetails.Size = New System.Drawing.Size(281, 26)
        Me.txtCardDetails.TabIndex = 1
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCardNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCardNumber.Location = New System.Drawing.Point(13, 39)
        Me.txtCardNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(191, 26)
        Me.txtCardNumber.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Card Number"
        '
        'groupDeposit
        '
        Me.groupDeposit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupDeposit.Controls.Add(Me.Label2)
        Me.groupDeposit.Controls.Add(Me.txtDepositRefNumber)
        Me.groupDeposit.Controls.Add(Me.Label15)
        Me.groupDeposit.Controls.Add(Me.txtDepositBankCode)
        Me.groupDeposit.Controls.Add(Me.txtDepositBankAccount)
        Me.groupDeposit.Location = New System.Drawing.Point(12, 12)
        Me.groupDeposit.Name = "groupDeposit"
        Me.groupDeposit.Size = New System.Drawing.Size(319, 267)
        Me.groupDeposit.TabIndex = 414
        Me.groupDeposit.TabStop = False
        Me.groupDeposit.Text = "Bank Deposit Payment Details"
        Me.groupDeposit.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 413
        Me.Label2.Text = "Select Bank Account"
        '
        'txtDepositRefNumber
        '
        Me.txtDepositRefNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDepositRefNumber.ForeColor = System.Drawing.Color.Black
        Me.txtDepositRefNumber.Location = New System.Drawing.Point(8, 87)
        Me.txtDepositRefNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositRefNumber.Name = "txtDepositRefNumber"
        Me.txtDepositRefNumber.Size = New System.Drawing.Size(191, 26)
        Me.txtDepositRefNumber.TabIndex = 4
        Me.txtDepositRefNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label15.Location = New System.Drawing.Point(8, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 15)
        Me.Label15.TabIndex = 411
        Me.Label15.Text = "Deposit Reference Number"
        '
        'txtDepositBankCode
        '
        Me.txtDepositBankCode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDepositBankCode.ForeColor = System.Drawing.Color.Black
        Me.txtDepositBankCode.Location = New System.Drawing.Point(251, 160)
        Me.txtDepositBankCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositBankCode.Name = "txtDepositBankCode"
        Me.txtDepositBankCode.ReadOnly = True
        Me.txtDepositBankCode.Size = New System.Drawing.Size(31, 22)
        Me.txtDepositBankCode.TabIndex = 406
        Me.txtDepositBankCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDepositBankCode.Visible = False
        '
        'txtDepositBankAccount
        '
        Me.txtDepositBankAccount.DropDownHeight = 130
        Me.txtDepositBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDepositBankAccount.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDepositBankAccount.ForeColor = System.Drawing.Color.Black
        Me.txtDepositBankAccount.FormattingEnabled = True
        Me.txtDepositBankAccount.IntegralHeight = False
        Me.txtDepositBankAccount.ItemHeight = 19
        Me.txtDepositBankAccount.Location = New System.Drawing.Point(8, 38)
        Me.txtDepositBankAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositBankAccount.MaxDropDownItems = 7
        Me.txtDepositBankAccount.Name = "txtDepositBankAccount"
        Me.txtDepositBankAccount.Size = New System.Drawing.Size(303, 27)
        Me.txtDepositBankAccount.TabIndex = 3
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(98, 288)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 33)
        Me.cmdConfirm.TabIndex = 415
        Me.cmdConfirm.Text = "OK"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'frmPOSPaymentTypeDetails
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(344, 336)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.groupCard)
        Me.Controls.Add(Me.groupCheck)
        Me.Controls.Add(Me.groupDeposit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSPaymentTypeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Information"
        Me.groupCheck.ResumeLayout(False)
        Me.groupCheck.PerformLayout()
        Me.groupCard.ResumeLayout(False)
        Me.groupCard.PerformLayout()
        Me.groupDeposit.ResumeLayout(False)
        Me.groupDeposit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCardPOSBankAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents banknumber As System.Windows.Forms.TextBox
    Friend WithEvents groupCheck As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCheckDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCheckName As System.Windows.Forms.TextBox
    Friend WithEvents groupCard As System.Windows.Forms.GroupBox
    Friend WithEvents lblcardholdername As System.Windows.Forms.Label
    Friend WithEvents txtCardHolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCardDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcardTraceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents groupDeposit As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDepositRefNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDepositBankCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
End Class
