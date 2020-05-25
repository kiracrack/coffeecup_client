<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSMultiPayments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSMultiPayments))
        Me.txtCardPOSBankAccounts = New System.Windows.Forms.ComboBox()
        Me.banknumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCheckDetails = New System.Windows.Forms.TextBox()
        Me.txtCheckNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcardTraceNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblcardholdername = New System.Windows.Forms.Label()
        Me.txtCardHolderName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDepositRefNumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDepositBankCode = New System.Windows.Forms.TextBox()
        Me.txtDepositBankAccount = New System.Windows.Forms.ComboBox()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCash = New System.Windows.Forms.TabPage()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtpaymentchange = New System.Windows.Forms.TextBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalOtherPayment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCashPayment = New System.Windows.Forms.TextBox()
        Me.tabCheck = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCheckAmount = New System.Windows.Forms.TextBox()
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.MyDataGridView_check = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabCredit = New System.Windows.Forms.TabPage()
        Me.txtCardDetails = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCardAmount = New System.Windows.Forms.TextBox()
        Me.cmdCard = New System.Windows.Forms.Button()
        Me.MyDataGridView_Card = New System.Windows.Forms.DataGridView()
        Me.tabBankDeposit = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDepositAmount = New System.Windows.Forms.TextBox()
        Me.cmdBankDeposit = New System.Windows.Forms.Button()
        Me.MyDataGridView_BankDeposit = New System.Windows.Forms.DataGridView()
        Me.tabVoucher = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtVoucherAmount = New System.Windows.Forms.TextBox()
        Me.cmdVoucher = New System.Windows.Forms.Button()
        Me.MyDataGridView_Voucher = New System.Windows.Forms.DataGridView()
        Me.txtVoucherno = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tabAcctTicket = New System.Windows.Forms.TabPage()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtGlAccount = New System.Windows.Forms.ComboBox()
        Me.txtTicketRemarks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTicketAmount = New System.Windows.Forms.TextBox()
        Me.cmdEntranceTicket = New System.Windows.Forms.Button()
        Me.MyDataGridView_Entrance = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.radSummary = New System.Windows.Forms.RadioButton()
        Me.radCheck = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radBank = New System.Windows.Forms.RadioButton()
        Me.radEntrance = New System.Windows.Forms.RadioButton()
        Me.radVoucher = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.tabCash.SuspendLayout()
        Me.tabCheck.SuspendLayout()
        CType(Me.MyDataGridView_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.tabCredit.SuspendLayout()
        CType(Me.MyDataGridView_Card, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBankDeposit.SuspendLayout()
        CType(Me.MyDataGridView_BankDeposit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVoucher.SuspendLayout()
        CType(Me.MyDataGridView_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAcctTicket.SuspendLayout()
        CType(Me.MyDataGridView_Entrance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCardPOSBankAccounts
        '
        Me.txtCardPOSBankAccounts.DropDownHeight = 130
        Me.txtCardPOSBankAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCardPOSBankAccounts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardPOSBankAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtCardPOSBankAccounts.FormattingEnabled = True
        Me.txtCardPOSBankAccounts.IntegralHeight = False
        Me.txtCardPOSBankAccounts.ItemHeight = 13
        Me.txtCardPOSBankAccounts.Location = New System.Drawing.Point(188, 82)
        Me.txtCardPOSBankAccounts.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardPOSBankAccounts.MaxDropDownItems = 7
        Me.txtCardPOSBankAccounts.Name = "txtCardPOSBankAccounts"
        Me.txtCardPOSBankAccounts.Size = New System.Drawing.Size(191, 21)
        Me.txtCardPOSBankAccounts.TabIndex = 3
        '
        'banknumber
        '
        Me.banknumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.banknumber.ForeColor = System.Drawing.Color.Black
        Me.banknumber.Location = New System.Drawing.Point(250, 218)
        Me.banknumber.Margin = New System.Windows.Forms.Padding(5)
        Me.banknumber.Name = "banknumber"
        Me.banknumber.ReadOnly = True
        Me.banknumber.Size = New System.Drawing.Size(31, 22)
        Me.banknumber.TabIndex = 406
        Me.banknumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.banknumber.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 410
        Me.Label5.Text = "Company Name"
        '
        'txtCheckName
        '
        Me.txtCheckName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckName.ForeColor = System.Drawing.Color.Black
        Me.txtCheckName.Location = New System.Drawing.Point(169, 64)
        Me.txtCheckName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckName.Name = "txtCheckName"
        Me.txtCheckName.Size = New System.Drawing.Size(281, 22)
        Me.txtCheckName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 408
        Me.Label4.Text = "Issuer Bank"
        '
        'txtCheckDetails
        '
        Me.txtCheckDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCheckDetails.Location = New System.Drawing.Point(169, 39)
        Me.txtCheckDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckDetails.Name = "txtCheckDetails"
        Me.txtCheckDetails.Size = New System.Drawing.Size(281, 22)
        Me.txtCheckDetails.TabIndex = 1
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCheckNumber.Location = New System.Drawing.Point(169, 14)
        Me.txtCheckNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(161, 22)
        Me.txtCheckNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "Check Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(127, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 413
        Me.Label9.Text = "Merchant"
        '
        'txtcardTraceNumber
        '
        Me.txtcardTraceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcardTraceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtcardTraceNumber.Location = New System.Drawing.Point(188, 105)
        Me.txtcardTraceNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcardTraceNumber.Name = "txtcardTraceNumber"
        Me.txtcardTraceNumber.Size = New System.Drawing.Size(191, 22)
        Me.txtcardTraceNumber.TabIndex = 4
        Me.txtcardTraceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 13)
        Me.Label6.TabIndex = 411
        Me.Label6.Text = "Approval Code (Trance Number)"
        '
        'lblcardholdername
        '
        Me.lblcardholdername.AutoSize = True
        Me.lblcardholdername.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcardholdername.Location = New System.Drawing.Point(82, 62)
        Me.lblcardholdername.Name = "lblcardholdername"
        Me.lblcardholdername.Size = New System.Drawing.Size(101, 13)
        Me.lblcardholdername.TabIndex = 410
        Me.lblcardholdername.Text = "Card Holder Name"
        '
        'txtCardHolderName
        '
        Me.txtCardHolderName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardHolderName.ForeColor = System.Drawing.Color.Black
        Me.txtCardHolderName.Location = New System.Drawing.Point(188, 58)
        Me.txtCardHolderName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardHolderName.Name = "txtCardHolderName"
        Me.txtCardHolderName.Size = New System.Drawing.Size(281, 22)
        Me.txtCardHolderName.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 408
        Me.Label7.Text = "Card Details (Bank Name)"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCardNumber.Location = New System.Drawing.Point(188, 10)
        Me.txtCardNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(191, 22)
        Me.txtCardNumber.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(108, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "Card Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 413
        Me.Label2.Text = "Select Account"
        '
        'txtDepositRefNumber
        '
        Me.txtDepositRefNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositRefNumber.ForeColor = System.Drawing.Color.Black
        Me.txtDepositRefNumber.Location = New System.Drawing.Point(160, 33)
        Me.txtDepositRefNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositRefNumber.Name = "txtDepositRefNumber"
        Me.txtDepositRefNumber.Size = New System.Drawing.Size(191, 22)
        Me.txtDepositRefNumber.TabIndex = 1
        Me.txtDepositRefNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 411
        Me.Label15.Text = "Deposit Remarks"
        '
        'txtDepositBankCode
        '
        Me.txtDepositBankCode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDepositBankCode.ForeColor = System.Drawing.Color.Black
        Me.txtDepositBankCode.Location = New System.Drawing.Point(15, 241)
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
        Me.txtDepositBankAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositBankAccount.ForeColor = System.Drawing.Color.Black
        Me.txtDepositBankAccount.FormattingEnabled = True
        Me.txtDepositBankAccount.IntegralHeight = False
        Me.txtDepositBankAccount.ItemHeight = 13
        Me.txtDepositBankAccount.Location = New System.Drawing.Point(160, 10)
        Me.txtDepositBankAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositBankAccount.MaxDropDownItems = 7
        Me.txtDepositBankAccount.Name = "txtDepositBankAccount"
        Me.txtDepositBankAccount.Size = New System.Drawing.Size(281, 21)
        Me.txtDepositBankAccount.TabIndex = 0
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(301, 371)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(213, 33)
        Me.cmdConfirm.TabIndex = 1
        Me.cmdConfirm.Text = "Confirm Payment"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabControl1.Controls.Add(Me.tabCash)
        Me.TabControl1.Controls.Add(Me.tabCheck)
        Me.TabControl1.Controls.Add(Me.tabCredit)
        Me.TabControl1.Controls.Add(Me.tabBankDeposit)
        Me.TabControl1.Controls.Add(Me.tabVoucher)
        Me.TabControl1.Controls.Add(Me.tabAcctTicket)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(144, -23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 390)
        Me.TabControl1.TabIndex = 416
        '
        'tabCash
        '
        Me.tabCash.Controls.Add(Me.cifid)
        Me.tabCash.Controls.Add(Me.mode)
        Me.tabCash.Controls.Add(Me.txtpaymentchange)
        Me.tabCash.Controls.Add(Me.batchcode)
        Me.tabCash.Controls.Add(Me.Label17)
        Me.tabCash.Controls.Add(Me.lblTransaction)
        Me.tabCash.Controls.Add(Me.Label16)
        Me.tabCash.Controls.Add(Me.txtTotalOnScreen)
        Me.tabCash.Controls.Add(Me.Label14)
        Me.tabCash.Controls.Add(Me.txtTotalPayment)
        Me.tabCash.Controls.Add(Me.Label13)
        Me.tabCash.Controls.Add(Me.txtTotalOtherPayment)
        Me.tabCash.Controls.Add(Me.Label12)
        Me.tabCash.Controls.Add(Me.txtCashPayment)
        Me.tabCash.Location = New System.Drawing.Point(4, 24)
        Me.tabCash.Name = "tabCash"
        Me.tabCash.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCash.Size = New System.Drawing.Size(553, 362)
        Me.tabCash.TabIndex = 0
        Me.tabCash.Text = "F1 - Payment Summary"
        Me.tabCash.UseVisualStyleBackColor = True
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(432, 165)
        Me.cifid.Margin = New System.Windows.Forms.Padding(5)
        Me.cifid.Name = "cifid"
        Me.cifid.Size = New System.Drawing.Size(58, 22)
        Me.cifid.TabIndex = 434
        Me.cifid.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(432, 140)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(58, 22)
        Me.mode.TabIndex = 433
        Me.mode.Visible = False
        '
        'txtpaymentchange
        '
        Me.txtpaymentchange.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentchange.ForeColor = System.Drawing.Color.Black
        Me.txtpaymentchange.Location = New System.Drawing.Point(432, 115)
        Me.txtpaymentchange.Margin = New System.Windows.Forms.Padding(5)
        Me.txtpaymentchange.Name = "txtpaymentchange"
        Me.txtpaymentchange.Size = New System.Drawing.Size(58, 22)
        Me.txtpaymentchange.TabIndex = 432
        Me.txtpaymentchange.Visible = False
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(432, 90)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Size = New System.Drawing.Size(58, 22)
        Me.batchcode.TabIndex = 431
        Me.batchcode.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(25, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(344, 15)
        Me.Label17.TabIndex = 430
        Me.Label17.Text = "NOTE: Please enter cash transaction if incase payment with cash"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransaction
        '
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(130, 19)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(238, 15)
        Me.lblTransaction.TabIndex = 429
        Me.lblTransaction.Text = "Transaction Reference # 1000010-105"
        Me.lblTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label16.Location = New System.Drawing.Point(38, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 17)
        Me.Label16.TabIndex = 428
        Me.Label16.Text = "Total Transaction"
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.BackColor = System.Drawing.Color.Gold
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(153, 39)
        Me.txtTotalOnScreen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(213, 29)
        Me.txtTotalOnScreen.TabIndex = 427
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label14.Location = New System.Drawing.Point(55, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 17)
        Me.Label14.TabIndex = 426
        Me.Label14.Text = "Total Payment"
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.BackColor = System.Drawing.Color.LimeGreen
        Me.txtTotalPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTotalPayment.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPayment.Location = New System.Drawing.Point(153, 171)
        Me.txtTotalPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.Size = New System.Drawing.Size(213, 29)
        Me.txtTotalPayment.TabIndex = 425
        Me.txtTotalPayment.Text = "0.00"
        Me.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label13.Location = New System.Drawing.Point(18, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 424
        Me.Label13.Text = "Total Other Payment"
        '
        'txtTotalOtherPayment
        '
        Me.txtTotalOtherPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTotalOtherPayment.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOtherPayment.Location = New System.Drawing.Point(153, 140)
        Me.txtTotalOtherPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalOtherPayment.Name = "txtTotalOtherPayment"
        Me.txtTotalOtherPayment.ReadOnly = True
        Me.txtTotalOtherPayment.Size = New System.Drawing.Size(213, 29)
        Me.txtTotalOtherPayment.TabIndex = 423
        Me.txtTotalOtherPayment.Text = "0.00"
        Me.txtTotalOtherPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label12.Location = New System.Drawing.Point(55, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 422
        Me.Label12.Text = "Cash Payment"
        '
        'txtCashPayment
        '
        Me.txtCashPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCashPayment.ForeColor = System.Drawing.Color.Black
        Me.txtCashPayment.Location = New System.Drawing.Point(153, 109)
        Me.txtCashPayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCashPayment.Name = "txtCashPayment"
        Me.txtCashPayment.Size = New System.Drawing.Size(213, 29)
        Me.txtCashPayment.TabIndex = 0
        Me.txtCashPayment.Text = "0.00"
        Me.txtCashPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.Label18)
        Me.tabCheck.Controls.Add(Me.txtCheckDate)
        Me.tabCheck.Controls.Add(Me.Label3)
        Me.tabCheck.Controls.Add(Me.txtCheckAmount)
        Me.tabCheck.Controls.Add(Me.cmdCheck)
        Me.tabCheck.Controls.Add(Me.MyDataGridView_check)
        Me.tabCheck.Controls.Add(Me.Label5)
        Me.tabCheck.Controls.Add(Me.txtCheckName)
        Me.tabCheck.Controls.Add(Me.Label1)
        Me.tabCheck.Controls.Add(Me.Label4)
        Me.tabCheck.Controls.Add(Me.txtCheckNumber)
        Me.tabCheck.Controls.Add(Me.txtCheckDetails)
        Me.tabCheck.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.tabCheck.Location = New System.Drawing.Point(4, 24)
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCheck.Size = New System.Drawing.Size(553, 362)
        Me.tabCheck.TabIndex = 1
        Me.tabCheck.Text = "F2 - Check Payment"
        Me.tabCheck.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(97, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 421
        Me.Label18.Text = "Check Date"
        '
        'txtCheckDate
        '
        Me.txtCheckDate.CustomFormat = "yyyy-MM-dd"
        Me.txtCheckDate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtCheckDate.Location = New System.Drawing.Point(169, 89)
        Me.txtCheckDate.Name = "txtCheckDate"
        Me.txtCheckDate.Size = New System.Drawing.Size(161, 22)
        Me.txtCheckDate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 419
        Me.Label3.Text = "Check Amount"
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCheckAmount.ForeColor = System.Drawing.Color.Black
        Me.txtCheckAmount.Location = New System.Drawing.Point(169, 114)
        Me.txtCheckAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Size = New System.Drawing.Size(161, 25)
        Me.txtCheckAmount.TabIndex = 4
        Me.txtCheckAmount.Text = "0.00"
        Me.txtCheckAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCheck
        '
        Me.cmdCheck.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheck.Location = New System.Drawing.Point(168, 141)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(162, 33)
        Me.cmdCheck.TabIndex = 5
        Me.cmdCheck.Text = "Add Payment"
        Me.cmdCheck.UseVisualStyleBackColor = False
        '
        'MyDataGridView_check
        '
        Me.MyDataGridView_check.AllowUserToAddRows = False
        Me.MyDataGridView_check.AllowUserToDeleteRows = False
        Me.MyDataGridView_check.AllowUserToResizeColumns = False
        Me.MyDataGridView_check.AllowUserToResizeRows = False
        Me.MyDataGridView_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_check.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_check.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_check.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_check.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_check.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_check.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_check.Location = New System.Drawing.Point(4, 180)
        Me.MyDataGridView_check.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_check.Name = "MyDataGridView_check"
        Me.MyDataGridView_check.ReadOnly = True
        Me.MyDataGridView_check.RowHeadersVisible = False
        Me.MyDataGridView_check.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_check.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_check.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_check.Size = New System.Drawing.Size(546, 180)
        Me.MyDataGridView_check.TabIndex = 415
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCancel})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(158, 26)
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(157, 22)
        Me.cmdCancel.Tag = "1"
        Me.cmdCancel.Text = "Cancel Selected"
        '
        'tabCredit
        '
        Me.tabCredit.Controls.Add(Me.txtCardDetails)
        Me.tabCredit.Controls.Add(Me.Label10)
        Me.tabCredit.Controls.Add(Me.txtCardAmount)
        Me.tabCredit.Controls.Add(Me.cmdCard)
        Me.tabCredit.Controls.Add(Me.MyDataGridView_Card)
        Me.tabCredit.Controls.Add(Me.Label9)
        Me.tabCredit.Controls.Add(Me.txtcardTraceNumber)
        Me.tabCredit.Controls.Add(Me.Label8)
        Me.tabCredit.Controls.Add(Me.Label6)
        Me.tabCredit.Controls.Add(Me.txtCardPOSBankAccounts)
        Me.tabCredit.Controls.Add(Me.banknumber)
        Me.tabCredit.Controls.Add(Me.txtCardNumber)
        Me.tabCredit.Controls.Add(Me.lblcardholdername)
        Me.tabCredit.Controls.Add(Me.txtCardHolderName)
        Me.tabCredit.Controls.Add(Me.Label7)
        Me.tabCredit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabCredit.Location = New System.Drawing.Point(4, 24)
        Me.tabCredit.Name = "tabCredit"
        Me.tabCredit.Size = New System.Drawing.Size(553, 362)
        Me.tabCredit.TabIndex = 2
        Me.tabCredit.Text = "F3 - Credit/Debit Card Payment"
        Me.tabCredit.UseVisualStyleBackColor = True
        '
        'txtCardDetails
        '
        Me.txtCardDetails.DropDownHeight = 130
        Me.txtCardDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCardDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCardDetails.FormattingEnabled = True
        Me.txtCardDetails.IntegralHeight = False
        Me.txtCardDetails.ItemHeight = 13
        Me.txtCardDetails.Location = New System.Drawing.Point(188, 35)
        Me.txtCardDetails.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardDetails.MaxDropDownItems = 7
        Me.txtCardDetails.Name = "txtCardDetails"
        Me.txtCardDetails.Size = New System.Drawing.Size(281, 21)
        Me.txtCardDetails.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 422
        Me.Label10.Text = "Transaction Amount"
        '
        'txtCardAmount
        '
        Me.txtCardAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCardAmount.ForeColor = System.Drawing.Color.Black
        Me.txtCardAmount.Location = New System.Drawing.Point(188, 129)
        Me.txtCardAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCardAmount.Name = "txtCardAmount"
        Me.txtCardAmount.Size = New System.Drawing.Size(191, 25)
        Me.txtCardAmount.TabIndex = 5
        Me.txtCardAmount.Text = "0.00"
        Me.txtCardAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCard
        '
        Me.cmdCard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCard.Location = New System.Drawing.Point(188, 156)
        Me.cmdCard.Name = "cmdCard"
        Me.cmdCard.Size = New System.Drawing.Size(192, 33)
        Me.cmdCard.TabIndex = 6
        Me.cmdCard.Text = "Add Payment"
        Me.cmdCard.UseVisualStyleBackColor = False
        '
        'MyDataGridView_Card
        '
        Me.MyDataGridView_Card.AllowUserToAddRows = False
        Me.MyDataGridView_Card.AllowUserToDeleteRows = False
        Me.MyDataGridView_Card.AllowUserToResizeColumns = False
        Me.MyDataGridView_Card.AllowUserToResizeRows = False
        Me.MyDataGridView_Card.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Card.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Card.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Card.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Card.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Card.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Card.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Card.Location = New System.Drawing.Point(3, 194)
        Me.MyDataGridView_Card.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Card.Name = "MyDataGridView_Card"
        Me.MyDataGridView_Card.ReadOnly = True
        Me.MyDataGridView_Card.RowHeadersVisible = False
        Me.MyDataGridView_Card.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Card.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_Card.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Card.Size = New System.Drawing.Size(546, 167)
        Me.MyDataGridView_Card.TabIndex = 414
        '
        'tabBankDeposit
        '
        Me.tabBankDeposit.Controls.Add(Me.Label11)
        Me.tabBankDeposit.Controls.Add(Me.txtDepositAmount)
        Me.tabBankDeposit.Controls.Add(Me.cmdBankDeposit)
        Me.tabBankDeposit.Controls.Add(Me.MyDataGridView_BankDeposit)
        Me.tabBankDeposit.Controls.Add(Me.Label2)
        Me.tabBankDeposit.Controls.Add(Me.txtDepositRefNumber)
        Me.tabBankDeposit.Controls.Add(Me.Label15)
        Me.tabBankDeposit.Controls.Add(Me.txtDepositBankAccount)
        Me.tabBankDeposit.Controls.Add(Me.txtDepositBankCode)
        Me.tabBankDeposit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabBankDeposit.Location = New System.Drawing.Point(4, 24)
        Me.tabBankDeposit.Name = "tabBankDeposit"
        Me.tabBankDeposit.Size = New System.Drawing.Size(553, 362)
        Me.tabBankDeposit.TabIndex = 3
        Me.tabBankDeposit.Text = "F4 - Bank Deposit Payment"
        Me.tabBankDeposit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 425
        Me.Label11.Text = "Transaction Amount"
        '
        'txtDepositAmount
        '
        Me.txtDepositAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDepositAmount.ForeColor = System.Drawing.Color.Black
        Me.txtDepositAmount.Location = New System.Drawing.Point(160, 57)
        Me.txtDepositAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositAmount.Name = "txtDepositAmount"
        Me.txtDepositAmount.Size = New System.Drawing.Size(191, 25)
        Me.txtDepositAmount.TabIndex = 2
        Me.txtDepositAmount.Text = "0.00"
        Me.txtDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdBankDeposit
        '
        Me.cmdBankDeposit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBankDeposit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBankDeposit.Location = New System.Drawing.Point(159, 84)
        Me.cmdBankDeposit.Name = "cmdBankDeposit"
        Me.cmdBankDeposit.Size = New System.Drawing.Size(192, 33)
        Me.cmdBankDeposit.TabIndex = 3
        Me.cmdBankDeposit.Text = "Add Payment"
        Me.cmdBankDeposit.UseVisualStyleBackColor = False
        '
        'MyDataGridView_BankDeposit
        '
        Me.MyDataGridView_BankDeposit.AllowUserToAddRows = False
        Me.MyDataGridView_BankDeposit.AllowUserToDeleteRows = False
        Me.MyDataGridView_BankDeposit.AllowUserToResizeColumns = False
        Me.MyDataGridView_BankDeposit.AllowUserToResizeRows = False
        Me.MyDataGridView_BankDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_BankDeposit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_BankDeposit.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_BankDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_BankDeposit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_BankDeposit.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_BankDeposit.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_BankDeposit.Location = New System.Drawing.Point(4, 121)
        Me.MyDataGridView_BankDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_BankDeposit.Name = "MyDataGridView_BankDeposit"
        Me.MyDataGridView_BankDeposit.ReadOnly = True
        Me.MyDataGridView_BankDeposit.RowHeadersVisible = False
        Me.MyDataGridView_BankDeposit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_BankDeposit.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView_BankDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_BankDeposit.Size = New System.Drawing.Size(546, 240)
        Me.MyDataGridView_BankDeposit.TabIndex = 415
        '
        'tabVoucher
        '
        Me.tabVoucher.Controls.Add(Me.Label22)
        Me.tabVoucher.Controls.Add(Me.txtVoucherAmount)
        Me.tabVoucher.Controls.Add(Me.cmdVoucher)
        Me.tabVoucher.Controls.Add(Me.MyDataGridView_Voucher)
        Me.tabVoucher.Controls.Add(Me.txtVoucherno)
        Me.tabVoucher.Controls.Add(Me.Label23)
        Me.tabVoucher.Location = New System.Drawing.Point(4, 24)
        Me.tabVoucher.Name = "tabVoucher"
        Me.tabVoucher.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVoucher.Size = New System.Drawing.Size(553, 362)
        Me.tabVoucher.TabIndex = 5
        Me.tabVoucher.Text = "Voucher"
        Me.tabVoucher.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(58, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 431
        Me.Label22.Text = "Voucher Amount"
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtVoucherAmount.ForeColor = System.Drawing.Color.Black
        Me.txtVoucherAmount.Location = New System.Drawing.Point(159, 38)
        Me.txtVoucherAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVoucherAmount.Name = "txtVoucherAmount"
        Me.txtVoucherAmount.Size = New System.Drawing.Size(191, 25)
        Me.txtVoucherAmount.TabIndex = 427
        Me.txtVoucherAmount.Text = "0.00"
        Me.txtVoucherAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdVoucher
        '
        Me.cmdVoucher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVoucher.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVoucher.Location = New System.Drawing.Point(158, 65)
        Me.cmdVoucher.Name = "cmdVoucher"
        Me.cmdVoucher.Size = New System.Drawing.Size(192, 33)
        Me.cmdVoucher.TabIndex = 428
        Me.cmdVoucher.Text = "Add Payment"
        Me.cmdVoucher.UseVisualStyleBackColor = False
        '
        'MyDataGridView_Voucher
        '
        Me.MyDataGridView_Voucher.AllowUserToAddRows = False
        Me.MyDataGridView_Voucher.AllowUserToDeleteRows = False
        Me.MyDataGridView_Voucher.AllowUserToResizeColumns = False
        Me.MyDataGridView_Voucher.AllowUserToResizeRows = False
        Me.MyDataGridView_Voucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Voucher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Voucher.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Voucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Voucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Voucher.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Voucher.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Voucher.Location = New System.Drawing.Point(3, 102)
        Me.MyDataGridView_Voucher.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Voucher.Name = "MyDataGridView_Voucher"
        Me.MyDataGridView_Voucher.ReadOnly = True
        Me.MyDataGridView_Voucher.RowHeadersVisible = False
        Me.MyDataGridView_Voucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Voucher.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MyDataGridView_Voucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Voucher.Size = New System.Drawing.Size(546, 258)
        Me.MyDataGridView_Voucher.TabIndex = 430
        '
        'txtVoucherno
        '
        Me.txtVoucherno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherno.ForeColor = System.Drawing.Color.Black
        Me.txtVoucherno.Location = New System.Drawing.Point(159, 14)
        Me.txtVoucherno.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVoucherno.Name = "txtVoucherno"
        Me.txtVoucherno.Size = New System.Drawing.Size(191, 22)
        Me.txtVoucherno.TabIndex = 426
        Me.txtVoucherno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(81, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 429
        Me.Label23.Text = "Voucher No."
        '
        'tabAcctTicket
        '
        Me.tabAcctTicket.Controls.Add(Me.itemcode)
        Me.tabAcctTicket.Controls.Add(Me.Label21)
        Me.tabAcctTicket.Controls.Add(Me.txtGlAccount)
        Me.tabAcctTicket.Controls.Add(Me.txtTicketRemarks)
        Me.tabAcctTicket.Controls.Add(Me.Label19)
        Me.tabAcctTicket.Controls.Add(Me.txtTicketAmount)
        Me.tabAcctTicket.Controls.Add(Me.cmdEntranceTicket)
        Me.tabAcctTicket.Controls.Add(Me.MyDataGridView_Entrance)
        Me.tabAcctTicket.Controls.Add(Me.Label20)
        Me.tabAcctTicket.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabAcctTicket.Location = New System.Drawing.Point(4, 24)
        Me.tabAcctTicket.Name = "tabAcctTicket"
        Me.tabAcctTicket.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAcctTicket.Size = New System.Drawing.Size(553, 362)
        Me.tabAcctTicket.TabIndex = 4
        Me.tabAcctTicket.Text = "Accounting Ticket"
        Me.tabAcctTicket.UseVisualStyleBackColor = True
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(329, 161)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(5)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Size = New System.Drawing.Size(86, 22)
        Me.itemcode.TabIndex = 435
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(78, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 13)
        Me.Label21.TabIndex = 434
        Me.Label21.Text = "Transaction Name"
        '
        'txtGlAccount
        '
        Me.txtGlAccount.DropDownHeight = 130
        Me.txtGlAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGlAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlAccount.ForeColor = System.Drawing.Color.Black
        Me.txtGlAccount.FormattingEnabled = True
        Me.txtGlAccount.IntegralHeight = False
        Me.txtGlAccount.ItemHeight = 13
        Me.txtGlAccount.Location = New System.Drawing.Point(183, 12)
        Me.txtGlAccount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGlAccount.MaxDropDownItems = 7
        Me.txtGlAccount.Name = "txtGlAccount"
        Me.txtGlAccount.Size = New System.Drawing.Size(281, 21)
        Me.txtGlAccount.TabIndex = 0
        '
        'txtTicketRemarks
        '
        Me.txtTicketRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtTicketRemarks.Location = New System.Drawing.Point(182, 63)
        Me.txtTicketRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTicketRemarks.Multiline = True
        Me.txtTicketRemarks.Name = "txtTicketRemarks"
        Me.txtTicketRemarks.Size = New System.Drawing.Size(278, 42)
        Me.txtTicketRemarks.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(127, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 431
        Me.Label19.Text = "Amount"
        '
        'txtTicketAmount
        '
        Me.txtTicketAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTicketAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTicketAmount.Location = New System.Drawing.Point(183, 36)
        Me.txtTicketAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTicketAmount.Name = "txtTicketAmount"
        Me.txtTicketAmount.Size = New System.Drawing.Size(155, 25)
        Me.txtTicketAmount.TabIndex = 1
        Me.txtTicketAmount.Text = "0.00"
        Me.txtTicketAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdEntranceTicket
        '
        Me.cmdEntranceTicket.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEntranceTicket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEntranceTicket.Location = New System.Drawing.Point(182, 107)
        Me.cmdEntranceTicket.Name = "cmdEntranceTicket"
        Me.cmdEntranceTicket.Size = New System.Drawing.Size(192, 33)
        Me.cmdEntranceTicket.TabIndex = 428
        Me.cmdEntranceTicket.Text = "Add Payment"
        Me.cmdEntranceTicket.UseVisualStyleBackColor = False
        '
        'MyDataGridView_Entrance
        '
        Me.MyDataGridView_Entrance.AllowUserToAddRows = False
        Me.MyDataGridView_Entrance.AllowUserToDeleteRows = False
        Me.MyDataGridView_Entrance.AllowUserToResizeColumns = False
        Me.MyDataGridView_Entrance.AllowUserToResizeRows = False
        Me.MyDataGridView_Entrance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Entrance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Entrance.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Entrance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Entrance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Entrance.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Entrance.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Entrance.Location = New System.Drawing.Point(3, 146)
        Me.MyDataGridView_Entrance.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Entrance.Name = "MyDataGridView_Entrance"
        Me.MyDataGridView_Entrance.ReadOnly = True
        Me.MyDataGridView_Entrance.RowHeadersVisible = False
        Me.MyDataGridView_Entrance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Entrance.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MyDataGridView_Entrance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Entrance.Size = New System.Drawing.Size(546, 216)
        Me.MyDataGridView_Entrance.TabIndex = 430
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(125, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 429
        Me.Label20.Text = "Remarks"
        '
        'radSummary
        '
        Me.radSummary.Appearance = System.Windows.Forms.Appearance.Button
        Me.radSummary.Checked = True
        Me.radSummary.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radSummary.Location = New System.Drawing.Point(1, 1)
        Me.radSummary.Name = "radSummary"
        Me.radSummary.Size = New System.Drawing.Size(144, 45)
        Me.radSummary.TabIndex = 423
        Me.radSummary.TabStop = True
        Me.radSummary.Text = "F1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Summary"
        Me.radSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radSummary.UseVisualStyleBackColor = True
        '
        'radCheck
        '
        Me.radCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.radCheck.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radCheck.Location = New System.Drawing.Point(1, 46)
        Me.radCheck.Name = "radCheck"
        Me.radCheck.Size = New System.Drawing.Size(144, 45)
        Me.radCheck.TabIndex = 424
        Me.radCheck.Text = "F2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Check"
        Me.radCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCheck.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.Appearance = System.Windows.Forms.Appearance.Button
        Me.radCredit.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radCredit.Location = New System.Drawing.Point(1, 91)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(144, 45)
        Me.radCredit.TabIndex = 425
        Me.radCredit.Text = "F3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Debit/Credit"
        Me.radCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radBank
        '
        Me.radBank.Appearance = System.Windows.Forms.Appearance.Button
        Me.radBank.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radBank.Location = New System.Drawing.Point(1, 136)
        Me.radBank.Name = "radBank"
        Me.radBank.Size = New System.Drawing.Size(144, 45)
        Me.radBank.TabIndex = 426
        Me.radBank.Text = "F4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Online"
        Me.radBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radBank.UseVisualStyleBackColor = True
        '
        'radEntrance
        '
        Me.radEntrance.Appearance = System.Windows.Forms.Appearance.Button
        Me.radEntrance.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radEntrance.Location = New System.Drawing.Point(1, 225)
        Me.radEntrance.Name = "radEntrance"
        Me.radEntrance.Size = New System.Drawing.Size(144, 45)
        Me.radEntrance.TabIndex = 427
        Me.radEntrance.Text = "F6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Accounting Ticket"
        Me.radEntrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radEntrance.UseVisualStyleBackColor = True
        '
        'radVoucher
        '
        Me.radVoucher.Appearance = System.Windows.Forms.Appearance.Button
        Me.radVoucher.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.radVoucher.Location = New System.Drawing.Point(1, 181)
        Me.radVoucher.Name = "radVoucher"
        Me.radVoucher.Size = New System.Drawing.Size(144, 45)
        Me.radVoucher.TabIndex = 428
        Me.radVoucher.Text = "F5" & Global.Microsoft.VisualBasic.ChrW(13) & "Voucher"
        Me.radVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radVoucher.UseVisualStyleBackColor = True
        '
        'frmPOSMultiPayments
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(707, 411)
        Me.Controls.Add(Me.radVoucher)
        Me.Controls.Add(Me.radEntrance)
        Me.Controls.Add(Me.radBank)
        Me.Controls.Add(Me.radCredit)
        Me.Controls.Add(Me.radCheck)
        Me.Controls.Add(Me.radSummary)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSMultiPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Payment Transaction"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCash.ResumeLayout(False)
        Me.tabCash.PerformLayout()
        Me.tabCheck.ResumeLayout(False)
        Me.tabCheck.PerformLayout()
        CType(Me.MyDataGridView_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.tabCredit.ResumeLayout(False)
        Me.tabCredit.PerformLayout()
        CType(Me.MyDataGridView_Card, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBankDeposit.ResumeLayout(False)
        Me.tabBankDeposit.PerformLayout()
        CType(Me.MyDataGridView_BankDeposit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVoucher.ResumeLayout(False)
        Me.tabVoucher.PerformLayout()
        CType(Me.MyDataGridView_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAcctTicket.ResumeLayout(False)
        Me.tabAcctTicket.PerformLayout()
        CType(Me.MyDataGridView_Entrance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCardPOSBankAccounts As System.Windows.Forms.ComboBox
    Friend WithEvents banknumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCheckDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCheckName As System.Windows.Forms.TextBox
    Friend WithEvents lblcardholdername As System.Windows.Forms.Label
    Friend WithEvents txtCardHolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcardTraceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDepositRefNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDepositBankCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDepositBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCash As TabPage
    Friend WithEvents tabCheck As TabPage
    Friend WithEvents tabCredit As TabPage
    Friend WithEvents tabBankDeposit As TabPage
    Friend WithEvents MyDataGridView_Card As DataGridView
    Friend WithEvents cmdCheck As Button
    Friend WithEvents MyDataGridView_check As DataGridView
    Friend WithEvents MyDataGridView_BankDeposit As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCheckAmount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCardAmount As TextBox
    Friend WithEvents cmdCard As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents cmdBankDeposit As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTotalOnScreen As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotalOtherPayment As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCashPayment As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTransaction As Label
    Friend WithEvents batchcode As TextBox
    Friend WithEvents cms_em As ContextMenuStrip
    Friend WithEvents cmdCancel As ToolStripMenuItem
    Friend WithEvents txtpaymentchange As TextBox
    Friend WithEvents cifid As TextBox
    Friend WithEvents mode As TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCheckDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents radSummary As System.Windows.Forms.RadioButton
    Friend WithEvents radCheck As System.Windows.Forms.RadioButton
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radBank As System.Windows.Forms.RadioButton
    Friend WithEvents txtCardDetails As System.Windows.Forms.ComboBox
    Friend WithEvents tabAcctTicket As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTicketAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmdEntranceTicket As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_Entrance As System.Windows.Forms.DataGridView
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents radEntrance As System.Windows.Forms.RadioButton
    Friend WithEvents txtTicketRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGlAccount As System.Windows.Forms.ComboBox
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents radVoucher As System.Windows.Forms.RadioButton
    Friend WithEvents tabVoucher As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtVoucherAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmdVoucher As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_Voucher As System.Windows.Forms.DataGridView
    Friend WithEvents txtVoucherno As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
