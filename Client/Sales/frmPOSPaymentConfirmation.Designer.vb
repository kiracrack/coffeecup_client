<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSPaymentConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSPaymentConfirmation))
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.lbltender = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtPaymentChange = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.ckChitCounter = New System.Windows.Forms.CheckBox()
        Me.GroupChitCounter = New System.Windows.Forms.GroupBox()
        Me.ckSOPclaim = New System.Windows.Forms.CheckBox()
        Me.txtPayableTax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ckChitVat = New System.Windows.Forms.CheckBox()
        Me.txtSOPTaxRate = New System.Windows.Forms.TextBox()
        Me.txtNetSOPAfterTax = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNetSOP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChitContactNumber = New System.Windows.Forms.TextBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.txtChitCustAddress = New System.Windows.Forms.TextBox()
        Me.txtChitCustomerName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.vat = New System.Windows.Forms.TextBox()
        Me.svc = New System.Windows.Forms.TextBox()
        Me.radComplimentary = New System.Windows.Forms.RadioButton()
        Me.txtComplimentaryRemarks = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.GroupBox()
        Me.txtPaymentMode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrintPreview = New System.Windows.Forms.RichTextBox()
        Me.txtdeposit = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupChitCounter.SuspendLayout()
        Me.lblTransaction.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.BackColor = System.Drawing.Color.Gold
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(64, 31)
        Me.txtTotalOnScreen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.ReadOnly = True
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(371, 56)
        Me.txtTotalOnScreen.TabIndex = 17
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountTender
        '
        Me.txtAmountTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(218, 191)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(217, 56)
        Me.txtAmountTender.TabIndex = 0
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltender
        '
        Me.lbltender.AutoSize = True
        Me.lbltender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltender.Location = New System.Drawing.Point(61, 171)
        Me.lbltender.Name = "lbltender"
        Me.lbltender.Size = New System.Drawing.Size(285, 15)
        Me.lbltender.TabIndex = 20
        Me.lbltender.Text = "Enter Amount not less than total transaction amount"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(61, 258)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(119, 15)
        Me.lblChange.TabIndex = 22
        Me.lblChange.Text = "Cash change amount"
        '
        'txtPaymentChange
        '
        Me.txtPaymentChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtPaymentChange.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentChange.Location = New System.Drawing.Point(64, 277)
        Me.txtPaymentChange.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentChange.Name = "txtPaymentChange"
        Me.txtPaymentChange.ReadOnly = True
        Me.txtPaymentChange.Size = New System.Drawing.Size(371, 56)
        Me.txtPaymentChange.TabIndex = 21
        Me.txtPaymentChange.Text = "0.00"
        Me.txtPaymentChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(151, 430)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(166, 22)
        Me.txtBatchcode.TabIndex = 396
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(64, 94)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(103, 17)
        Me.rbCash.TabIndex = 401
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH ONLY (F1)"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(174, 94)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(131, 17)
        Me.rbMultiPayment.TabIndex = 402
        Me.rbMultiPayment.Text = "OTHER PAYMENT (F2)"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'ckChitCounter
        '
        Me.ckChitCounter.AutoSize = True
        Me.ckChitCounter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckChitCounter.Location = New System.Drawing.Point(323, 256)
        Me.ckChitCounter.Name = "ckChitCounter"
        Me.ckChitCounter.Size = New System.Drawing.Size(111, 19)
        Me.ckChitCounter.TabIndex = 412
        Me.ckChitCounter.Text = "&Chit Transaction"
        Me.ckChitCounter.UseVisualStyleBackColor = True
        Me.ckChitCounter.Visible = False
        '
        'GroupChitCounter
        '
        Me.GroupChitCounter.Controls.Add(Me.ckSOPclaim)
        Me.GroupChitCounter.Controls.Add(Me.txtPayableTax)
        Me.GroupChitCounter.Controls.Add(Me.Label16)
        Me.GroupChitCounter.Controls.Add(Me.ckChitVat)
        Me.GroupChitCounter.Controls.Add(Me.txtSOPTaxRate)
        Me.GroupChitCounter.Controls.Add(Me.txtNetSOPAfterTax)
        Me.GroupChitCounter.Controls.Add(Me.Label14)
        Me.GroupChitCounter.Controls.Add(Me.Label13)
        Me.GroupChitCounter.Controls.Add(Me.txtNetSOP)
        Me.GroupChitCounter.Controls.Add(Me.Label10)
        Me.GroupChitCounter.Controls.Add(Me.txtChitContactNumber)
        Me.GroupChitCounter.Controls.Add(Me.label22)
        Me.GroupChitCounter.Controls.Add(Me.txtChitCustAddress)
        Me.GroupChitCounter.Controls.Add(Me.txtChitCustomerName)
        Me.GroupChitCounter.Controls.Add(Me.Label12)
        Me.GroupChitCounter.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupChitCounter.Location = New System.Drawing.Point(804, 12)
        Me.GroupChitCounter.Name = "GroupChitCounter"
        Me.GroupChitCounter.Size = New System.Drawing.Size(342, 345)
        Me.GroupChitCounter.TabIndex = 0
        Me.GroupChitCounter.TabStop = False
        Me.GroupChitCounter.Text = "SOP Customer Details"
        Me.GroupChitCounter.Visible = False
        '
        'ckSOPclaim
        '
        Me.ckSOPclaim.AutoSize = True
        Me.ckSOPclaim.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSOPclaim.Location = New System.Drawing.Point(127, 113)
        Me.ckSOPclaim.Name = "ckSOPclaim"
        Me.ckSOPclaim.Size = New System.Drawing.Size(160, 19)
        Me.ckSOPclaim.TabIndex = 423
        Me.ckSOPclaim.Text = "&Claim SOP on Settlement"
        Me.ckSOPclaim.UseVisualStyleBackColor = True
        '
        'txtPayableTax
        '
        Me.txtPayableTax.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtPayableTax.ForeColor = System.Drawing.Color.White
        Me.txtPayableTax.Location = New System.Drawing.Point(204, 227)
        Me.txtPayableTax.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPayableTax.Name = "txtPayableTax"
        Me.txtPayableTax.ReadOnly = True
        Me.txtPayableTax.Size = New System.Drawing.Size(120, 26)
        Me.txtPayableTax.TabIndex = 422
        Me.txtPayableTax.Text = "0.00"
        Me.txtPayableTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label16.Location = New System.Drawing.Point(128, 233)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 15)
        Me.Label16.TabIndex = 421
        Me.Label16.Text = "Payable Tax"
        '
        'ckChitVat
        '
        Me.ckChitVat.AutoSize = True
        Me.ckChitVat.Checked = True
        Me.ckChitVat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckChitVat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckChitVat.Location = New System.Drawing.Point(127, 175)
        Me.ckChitVat.Name = "ckChitVat"
        Me.ckChitVat.Size = New System.Drawing.Size(69, 19)
        Me.ckChitVat.TabIndex = 420
        Me.ckChitVat.Text = "Tax Rate"
        Me.ckChitVat.UseVisualStyleBackColor = True
        '
        'txtSOPTaxRate
        '
        Me.txtSOPTaxRate.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtSOPTaxRate.ForeColor = System.Drawing.Color.Black
        Me.txtSOPTaxRate.Location = New System.Drawing.Point(204, 171)
        Me.txtSOPTaxRate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSOPTaxRate.Name = "txtSOPTaxRate"
        Me.txtSOPTaxRate.ReadOnly = True
        Me.txtSOPTaxRate.Size = New System.Drawing.Size(120, 26)
        Me.txtSOPTaxRate.TabIndex = 418
        Me.txtSOPTaxRate.Text = "0.00"
        Me.txtSOPTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetSOPAfterTax
        '
        Me.txtNetSOPAfterTax.BackColor = System.Drawing.Color.Red
        Me.txtNetSOPAfterTax.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtNetSOPAfterTax.ForeColor = System.Drawing.Color.White
        Me.txtNetSOPAfterTax.Location = New System.Drawing.Point(204, 199)
        Me.txtNetSOPAfterTax.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNetSOPAfterTax.Name = "txtNetSOPAfterTax"
        Me.txtNetSOPAfterTax.ReadOnly = True
        Me.txtNetSOPAfterTax.Size = New System.Drawing.Size(120, 26)
        Me.txtNetSOPAfterTax.TabIndex = 417
        Me.txtNetSOPAfterTax.Text = "0.00"
        Me.txtNetSOPAfterTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(88, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 15)
        Me.Label14.TabIndex = 416
        Me.Label14.Text = "Net SOP (After Tax)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(73, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 15)
        Me.Label13.TabIndex = 414
        Me.Label13.Text = "Total SOP (Before Tax)"
        '
        'txtNetSOP
        '
        Me.txtNetSOP.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtNetSOP.Location = New System.Drawing.Point(204, 143)
        Me.txtNetSOP.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNetSOP.Name = "txtNetSOP"
        Me.txtNetSOP.ReadOnly = True
        Me.txtNetSOP.Size = New System.Drawing.Size(120, 26)
        Me.txtNetSOP.TabIndex = 413
        Me.txtNetSOP.Text = "0.00"
        Me.txtNetSOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(25, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 410
        Me.Label10.Text = "Contact Number"
        '
        'txtChitContactNumber
        '
        Me.txtChitContactNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtChitContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtChitContactNumber.Location = New System.Drawing.Point(127, 83)
        Me.txtChitContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtChitContactNumber.Name = "txtChitContactNumber"
        Me.txtChitContactNumber.Size = New System.Drawing.Size(197, 26)
        Me.txtChitContactNumber.TabIndex = 2
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.label22.Location = New System.Drawing.Point(17, 60)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(104, 15)
        Me.label22.TabIndex = 408
        Me.label22.Text = "Complete Address"
        '
        'txtChitCustAddress
        '
        Me.txtChitCustAddress.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtChitCustAddress.ForeColor = System.Drawing.Color.Black
        Me.txtChitCustAddress.Location = New System.Drawing.Point(127, 55)
        Me.txtChitCustAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtChitCustAddress.Name = "txtChitCustAddress"
        Me.txtChitCustAddress.Size = New System.Drawing.Size(197, 26)
        Me.txtChitCustAddress.TabIndex = 1
        '
        'txtChitCustomerName
        '
        Me.txtChitCustomerName.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtChitCustomerName.ForeColor = System.Drawing.Color.Black
        Me.txtChitCustomerName.Location = New System.Drawing.Point(127, 27)
        Me.txtChitCustomerName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtChitCustomerName.Name = "txtChitCustomerName"
        Me.txtChitCustomerName.Size = New System.Drawing.Size(197, 26)
        Me.txtChitCustomerName.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(27, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 405
        Me.Label12.Text = "Customer Name"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(64, 191)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(151, 56)
        Me.txtInvoiceNumber.TabIndex = 413
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vat
        '
        Me.vat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.vat.ForeColor = System.Drawing.Color.Black
        Me.vat.Location = New System.Drawing.Point(151, 462)
        Me.vat.Margin = New System.Windows.Forms.Padding(5)
        Me.vat.Name = "vat"
        Me.vat.ReadOnly = True
        Me.vat.Size = New System.Drawing.Size(166, 22)
        Me.vat.TabIndex = 414
        Me.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'svc
        '
        Me.svc.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.svc.ForeColor = System.Drawing.Color.Black
        Me.svc.Location = New System.Drawing.Point(151, 494)
        Me.svc.Margin = New System.Windows.Forms.Padding(5)
        Me.svc.Name = "svc"
        Me.svc.ReadOnly = True
        Me.svc.Size = New System.Drawing.Size(166, 22)
        Me.svc.TabIndex = 415
        Me.svc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'radComplimentary
        '
        Me.radComplimentary.AutoSize = True
        Me.radComplimentary.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.radComplimentary.Location = New System.Drawing.Point(309, 94)
        Me.radComplimentary.Name = "radComplimentary"
        Me.radComplimentary.Size = New System.Drawing.Size(134, 17)
        Me.radComplimentary.TabIndex = 416
        Me.radComplimentary.Text = "COMPLIMENTARY (F3)"
        Me.radComplimentary.UseVisualStyleBackColor = True
        '
        'txtComplimentaryRemarks
        '
        Me.txtComplimentaryRemarks.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtComplimentaryRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtComplimentaryRemarks.Location = New System.Drawing.Point(64, 278)
        Me.txtComplimentaryRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComplimentaryRemarks.Name = "txtComplimentaryRemarks"
        Me.txtComplimentaryRemarks.Size = New System.Drawing.Size(371, 26)
        Me.txtComplimentaryRemarks.TabIndex = 417
        Me.txtComplimentaryRemarks.Visible = False
        '
        'lblTransaction
        '
        Me.lblTransaction.Controls.Add(Me.txtPaymentMode)
        Me.lblTransaction.Controls.Add(Me.Label3)
        Me.lblTransaction.Controls.Add(Me.radComplimentary)
        Me.lblTransaction.Controls.Add(Me.txtComplimentaryRemarks)
        Me.lblTransaction.Controls.Add(Me.txtTotalOnScreen)
        Me.lblTransaction.Controls.Add(Me.txtInvoiceNumber)
        Me.lblTransaction.Controls.Add(Me.txtAmountTender)
        Me.lblTransaction.Controls.Add(Me.ckChitCounter)
        Me.lblTransaction.Controls.Add(Me.lbltender)
        Me.lblTransaction.Controls.Add(Me.rbMultiPayment)
        Me.lblTransaction.Controls.Add(Me.lblChange)
        Me.lblTransaction.Controls.Add(Me.rbCash)
        Me.lblTransaction.Controls.Add(Me.txtPaymentChange)
        Me.lblTransaction.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.lblTransaction.Location = New System.Drawing.Point(302, 9)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(484, 348)
        Me.lblTransaction.TabIndex = 0
        Me.lblTransaction.TabStop = False
        Me.lblTransaction.Text = "Enter proceed transaction amount"
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentMode.Location = New System.Drawing.Point(64, 136)
        Me.txtPaymentMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.ReadOnly = True
        Me.txtPaymentMode.Size = New System.Drawing.Size(370, 29)
        Me.txtPaymentMode.TabIndex = 720
        Me.txtPaymentMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(61, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 721
        Me.Label3.Text = "Payment Mode"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrintPreview)
        Me.GroupBox1.Controls.Add(Me.txtdeposit)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 348)
        Me.GroupBox1.TabIndex = 416
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Preview"
        '
        'txtPrintPreview
        '
        Me.txtPrintPreview.BackColor = System.Drawing.Color.White
        Me.txtPrintPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrintPreview.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.txtPrintPreview.Location = New System.Drawing.Point(3, 18)
        Me.txtPrintPreview.Name = "txtPrintPreview"
        Me.txtPrintPreview.ReadOnly = True
        Me.txtPrintPreview.Size = New System.Drawing.Size(279, 327)
        Me.txtPrintPreview.TabIndex = 0
        Me.txtPrintPreview.Text = ""
        '
        'txtdeposit
        '
        Me.txtdeposit.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtdeposit.ForeColor = System.Drawing.Color.Black
        Me.txtdeposit.Location = New System.Drawing.Point(197, 247)
        Me.txtdeposit.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdeposit.Name = "txtdeposit"
        Me.txtdeposit.Size = New System.Drawing.Size(54, 26)
        Me.txtdeposit.TabIndex = 418
        Me.txtdeposit.Visible = False
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmPayment.Appearance.Options.UseFont = True
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(435, 363)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(230, 42)
        Me.cmdConfirmPayment.TabIndex = 419
        Me.cmdConfirmPayment.Text = "Confirm Payment"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(71, 363)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(164, 42)
        Me.SimpleButton1.TabIndex = 420
        Me.SimpleButton1.Text = "Tag to Room"
        '
        'frmPOSPaymentConfirmation
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 419)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.svc)
        Me.Controls.Add(Me.vat)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.GroupChitCounter)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSPaymentConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale Payment Confirmation"
        Me.GroupChitCounter.ResumeLayout(False)
        Me.GroupChitCounter.PerformLayout()
        Me.lblTransaction.ResumeLayout(False)
        Me.lblTransaction.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents lbltender As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtPaymentChange As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbMultiPayment As System.Windows.Forms.RadioButton
    Friend WithEvents ckChitCounter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupChitCounter As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChitContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents label22 As System.Windows.Forms.Label
    Friend WithEvents txtChitCustAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtChitCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNetSOP As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNetSOPAfterTax As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents ckChitVat As System.Windows.Forms.CheckBox
    Friend WithEvents txtSOPTaxRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPayableTax As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents vat As System.Windows.Forms.TextBox
    Friend WithEvents svc As System.Windows.Forms.TextBox
    Friend WithEvents radComplimentary As System.Windows.Forms.RadioButton
    Friend WithEvents txtComplimentaryRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents txtPaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrintPreview As System.Windows.Forms.RichTextBox
    Friend WithEvents txtdeposit As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckSOPclaim As System.Windows.Forms.CheckBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
