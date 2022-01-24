<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPointOfSale
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPointOfSale))
        Me.cmdVoidTransaction = New System.Windows.Forms.Button()
        Me.cmdCancelLine = New System.Windows.Forms.Button()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAddCharges = New System.Windows.Forms.Button()
        Me.cmdRemarks = New System.Windows.Forms.Button()
        Me.cmdCouponCharge = New System.Windows.Forms.Button()
        Me.cmdInterOffice = New System.Windows.Forms.Button()
        Me.cmdDiscount = New System.Windows.Forms.Button()
        Me.cmdPrintOrderSlip = New System.Windows.Forms.Button()
        Me.cmdChargeClientAccount = New System.Windows.Forms.Button()
        Me.cmdEditLine = New System.Windows.Forms.Button()
        Me.cmdHold = New System.Windows.Forms.Button()
        Me.cmdPayment = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.txtDateTransaction = New System.Windows.Forms.Label()
        Me.txtTellerAccount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdClosedAccount = New System.Windows.Forms.ToolStripButton()
        Me.lineCloseAccount = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPendingOrderSlip = New System.Windows.Forms.ToolStripButton()
        Me.lineOrderSlip = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnholdTransaction = New System.Windows.Forms.ToolStripButton()
        Me.lineHold = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdProductSearch = New System.Windows.Forms.ToolStripButton()
        Me.lineSearchProduct = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRecoveredTransaction = New System.Windows.Forms.ToolStripButton()
        Me.lineRecoverd = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNewClient = New System.Windows.Forms.ToolStripButton()
        Me.lineNewClient = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdTransactionHistory = New System.Windows.Forms.ToolStripButton()
        Me.lineTransactionHistory = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdTraceTransaction = New System.Windows.Forms.ToolStripButton()
        Me.lineTraceTransaction = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdReturnCurrentInvoice = New System.Windows.Forms.ToolStripButton()
        Me.lineReturnCurrentInvoice = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCreditLimit = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.grpBarcode = New System.Windows.Forms.GroupBox()
        Me.ckNonInventoryItem = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSVC = New System.Windows.Forms.Label()
        Me.txtServiceCharge = New System.Windows.Forms.Label()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.lblDigitalHeader = New System.Windows.Forms.Label()
        Me.lblChit = New System.Windows.Forms.Label()
        Me.txtTotalChit = New System.Windows.Forms.Label()
        Me.txtBatchcode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalDiscount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalCharge = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalItem = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.txtTotalTax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.Label()
        Me.txtTotalCancelled = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpBarcode.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdVoidTransaction
        '
        Me.cmdVoidTransaction.BackColor = System.Drawing.Color.White
        Me.cmdVoidTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdVoidTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVoidTransaction.Location = New System.Drawing.Point(132, 165)
        Me.cmdVoidTransaction.Name = "cmdVoidTransaction"
        Me.cmdVoidTransaction.Size = New System.Drawing.Size(118, 45)
        Me.cmdVoidTransaction.TabIndex = 15
        Me.cmdVoidTransaction.Text = "Void Transaction " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F11"
        Me.cmdVoidTransaction.UseVisualStyleBackColor = False
        '
        'cmdCancelLine
        '
        Me.cmdCancelLine.BackColor = System.Drawing.Color.White
        Me.cmdCancelLine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdCancelLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCancelLine.Location = New System.Drawing.Point(11, 118)
        Me.cmdCancelLine.Name = "cmdCancelLine"
        Me.cmdCancelLine.Size = New System.Drawing.Size(119, 45)
        Me.cmdCancelLine.TabIndex = 14
        Me.cmdCancelLine.Text = "Cancel Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F8"
        Me.cmdCancelLine.UseVisualStyleBackColor = False
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(12, 20)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(86, 22)
        Me.cifid.TabIndex = 4
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.DropDownHeight = 130
        Me.txtClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtClient.ForeColor = System.Drawing.Color.Black
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.IntegralHeight = False
        Me.txtClient.ItemHeight = 15
        Me.txtClient.Location = New System.Drawing.Point(101, 20)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClient.MaxDropDownItems = 7
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(242, 23)
        Me.txtClient.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAddCharges)
        Me.GroupBox1.Controls.Add(Me.cmdRemarks)
        Me.GroupBox1.Controls.Add(Me.cmdCouponCharge)
        Me.GroupBox1.Controls.Add(Me.cmdInterOffice)
        Me.GroupBox1.Controls.Add(Me.cmdDiscount)
        Me.GroupBox1.Controls.Add(Me.cmdPrintOrderSlip)
        Me.GroupBox1.Controls.Add(Me.cmdChargeClientAccount)
        Me.GroupBox1.Controls.Add(Me.cmdEditLine)
        Me.GroupBox1.Controls.Add(Me.cmdHold)
        Me.GroupBox1.Controls.Add(Me.cmdPayment)
        Me.GroupBox1.Controls.Add(Me.cmdCancelLine)
        Me.GroupBox1.Controls.Add(Me.cmdVoidTransaction)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(812, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 332)
        Me.GroupBox1.TabIndex = 364
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POS Transaction Menu"
        '
        'cmdAddCharges
        '
        Me.cmdAddCharges.BackColor = System.Drawing.Color.White
        Me.cmdAddCharges.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAddCharges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddCharges.Location = New System.Drawing.Point(10, 71)
        Me.cmdAddCharges.Name = "cmdAddCharges"
        Me.cmdAddCharges.Size = New System.Drawing.Size(119, 45)
        Me.cmdAddCharges.TabIndex = 401
        Me.cmdAddCharges.Text = "Add Charges" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdAddCharges.UseVisualStyleBackColor = False
        '
        'cmdRemarks
        '
        Me.cmdRemarks.BackColor = System.Drawing.Color.White
        Me.cmdRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdRemarks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemarks.Location = New System.Drawing.Point(132, 23)
        Me.cmdRemarks.Name = "cmdRemarks"
        Me.cmdRemarks.Size = New System.Drawing.Size(119, 45)
        Me.cmdRemarks.TabIndex = 400
        Me.cmdRemarks.Text = "Remarks"
        Me.cmdRemarks.UseVisualStyleBackColor = False
        '
        'cmdCouponCharge
        '
        Me.cmdCouponCharge.BackColor = System.Drawing.Color.White
        Me.cmdCouponCharge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdCouponCharge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCouponCharge.Location = New System.Drawing.Point(11, 259)
        Me.cmdCouponCharge.Name = "cmdCouponCharge"
        Me.cmdCouponCharge.Size = New System.Drawing.Size(118, 45)
        Me.cmdCouponCharge.TabIndex = 399
        Me.cmdCouponCharge.Text = "Charge to Coupon"
        Me.cmdCouponCharge.UseVisualStyleBackColor = False
        '
        'cmdInterOffice
        '
        Me.cmdInterOffice.BackColor = System.Drawing.Color.White
        Me.cmdInterOffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdInterOffice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInterOffice.Location = New System.Drawing.Point(132, 259)
        Me.cmdInterOffice.Name = "cmdInterOffice"
        Me.cmdInterOffice.Size = New System.Drawing.Size(118, 45)
        Me.cmdInterOffice.TabIndex = 398
        Me.cmdInterOffice.Text = "Inter Office   Charge"
        Me.cmdInterOffice.UseVisualStyleBackColor = False
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.White
        Me.cmdDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiscount.Location = New System.Drawing.Point(132, 71)
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(119, 45)
        Me.cmdDiscount.TabIndex = 397
        Me.cmdDiscount.Text = "Add Discount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F7"
        Me.cmdDiscount.UseVisualStyleBackColor = False
        '
        'cmdPrintOrderSlip
        '
        Me.cmdPrintOrderSlip.BackColor = System.Drawing.Color.White
        Me.cmdPrintOrderSlip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdPrintOrderSlip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrintOrderSlip.Location = New System.Drawing.Point(132, 212)
        Me.cmdPrintOrderSlip.Name = "cmdPrintOrderSlip"
        Me.cmdPrintOrderSlip.Size = New System.Drawing.Size(118, 45)
        Me.cmdPrintOrderSlip.TabIndex = 396
        Me.cmdPrintOrderSlip.Text = "Customer Bill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ctrl+O"
        Me.cmdPrintOrderSlip.UseVisualStyleBackColor = False
        '
        'cmdChargeClientAccount
        '
        Me.cmdChargeClientAccount.BackColor = System.Drawing.Color.White
        Me.cmdChargeClientAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdChargeClientAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChargeClientAccount.Location = New System.Drawing.Point(11, 212)
        Me.cmdChargeClientAccount.Name = "cmdChargeClientAccount"
        Me.cmdChargeClientAccount.Size = New System.Drawing.Size(119, 45)
        Me.cmdChargeClientAccount.TabIndex = 18
        Me.cmdChargeClientAccount.Text = "Charge to Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F12"
        Me.cmdChargeClientAccount.UseVisualStyleBackColor = False
        '
        'cmdEditLine
        '
        Me.cmdEditLine.BackColor = System.Drawing.Color.White
        Me.cmdEditLine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdEditLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEditLine.Location = New System.Drawing.Point(132, 118)
        Me.cmdEditLine.Name = "cmdEditLine"
        Me.cmdEditLine.Size = New System.Drawing.Size(119, 45)
        Me.cmdEditLine.TabIndex = 19
        Me.cmdEditLine.Text = "Edit Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F9"
        Me.cmdEditLine.UseVisualStyleBackColor = False
        '
        'cmdHold
        '
        Me.cmdHold.BackColor = System.Drawing.Color.White
        Me.cmdHold.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdHold.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHold.Location = New System.Drawing.Point(11, 165)
        Me.cmdHold.Name = "cmdHold"
        Me.cmdHold.Size = New System.Drawing.Size(119, 45)
        Me.cmdHold.TabIndex = 17
        Me.cmdHold.Text = "Hold Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F10"
        Me.cmdHold.UseVisualStyleBackColor = False
        '
        'cmdPayment
        '
        Me.cmdPayment.BackColor = System.Drawing.Color.White
        Me.cmdPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPayment.Location = New System.Drawing.Point(10, 23)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(119, 45)
        Me.cmdPayment.TabIndex = 16
        Me.cmdPayment.Text = "Enter Payment"
        Me.cmdPayment.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(11, 19)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(86, 31)
        Me.txtQuantity.TabIndex = 0
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarCode
        '
        Me.txtBarCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarCode.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtBarCode.ForeColor = System.Drawing.Color.Black
        Me.txtBarCode.Location = New System.Drawing.Point(99, 19)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(688, 31)
        Me.txtBarCode.TabIndex = 1
        '
        'txtDateTransaction
        '
        Me.txtDateTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDateTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDateTransaction.ForeColor = System.Drawing.Color.Lime
        Me.txtDateTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDateTransaction.Location = New System.Drawing.Point(7, 282)
        Me.txtDateTransaction.Name = "txtDateTransaction"
        Me.txtDateTransaction.Size = New System.Drawing.Size(249, 15)
        Me.txtDateTransaction.TabIndex = 393
        Me.txtDateTransaction.Text = "December 13, 1987, 12:54 PM"
        Me.txtDateTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTellerAccount
        '
        Me.txtTellerAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTellerAccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTellerAccount.ForeColor = System.Drawing.Color.Lime
        Me.txtTellerAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTellerAccount.Location = New System.Drawing.Point(7, 299)
        Me.txtTellerAccount.Name = "txtTellerAccount"
        Me.txtTellerAccount.Size = New System.Drawing.Size(249, 15)
        Me.txtTellerAccount.TabIndex = 383
        Me.txtTellerAccount.Text = "Cashier's Name"
        Me.txtTellerAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(2, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1092, 37)
        Me.Panel2.TabIndex = 397
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.wide_blank2
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator5, Me.cmdClosedAccount, Me.lineCloseAccount, Me.cmdPendingOrderSlip, Me.lineOrderSlip, Me.cmdOnholdTransaction, Me.lineHold, Me.cmdProductSearch, Me.lineSearchProduct, Me.cmdRecoveredTransaction, Me.lineRecoverd, Me.cmdNewClient, Me.lineNewClient, Me.cmdTransactionHistory, Me.lineTransactionHistory, Me.cmdTraceTransaction, Me.lineTraceTransaction, Me.cmdReturnCurrentInvoice, Me.lineReturnCurrentInvoice})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(10, 2, 1, 2)
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(1092, 37)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(46, 30)
        Me.ToolStripButton1.Text = "Exit"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 33)
        '
        'cmdClosedAccount
        '
        Me.cmdClosedAccount.ForeColor = System.Drawing.Color.White
        Me.cmdClosedAccount.Image = Global.CoffeecupClient.My.Resources.Resources.door_open_out
        Me.cmdClosedAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClosedAccount.Name = "cmdClosedAccount"
        Me.cmdClosedAccount.Size = New System.Drawing.Size(119, 30)
        Me.cmdClosedAccount.Text = "Close Transaction"
        '
        'lineCloseAccount
        '
        Me.lineCloseAccount.Name = "lineCloseAccount"
        Me.lineCloseAccount.Size = New System.Drawing.Size(6, 33)
        '
        'cmdPendingOrderSlip
        '
        Me.cmdPendingOrderSlip.ForeColor = System.Drawing.Color.White
        Me.cmdPendingOrderSlip.Image = Global.CoffeecupClient.My.Resources.Resources.flag_blue
        Me.cmdPendingOrderSlip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPendingOrderSlip.Name = "cmdPendingOrderSlip"
        Me.cmdPendingOrderSlip.Size = New System.Drawing.Size(141, 30)
        Me.cmdPendingOrderSlip.Text = "Pending Order Slip F1"
        '
        'lineOrderSlip
        '
        Me.lineOrderSlip.Name = "lineOrderSlip"
        Me.lineOrderSlip.Size = New System.Drawing.Size(6, 33)
        '
        'cmdOnholdTransaction
        '
        Me.cmdOnholdTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdOnholdTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.flag
        Me.cmdOnholdTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOnholdTransaction.Name = "cmdOnholdTransaction"
        Me.cmdOnholdTransaction.Size = New System.Drawing.Size(87, 30)
        Me.cmdOnholdTransaction.Text = "On Hold F2"
        '
        'lineHold
        '
        Me.lineHold.Name = "lineHold"
        Me.lineHold.Size = New System.Drawing.Size(6, 33)
        '
        'cmdProductSearch
        '
        Me.cmdProductSearch.ForeColor = System.Drawing.Color.White
        Me.cmdProductSearch.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_1
        Me.cmdProductSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProductSearch.Name = "cmdProductSearch"
        Me.cmdProductSearch.Size = New System.Drawing.Size(122, 30)
        Me.cmdProductSearch.Text = "Search Product F3"
        '
        'lineSearchProduct
        '
        Me.lineSearchProduct.Name = "lineSearchProduct"
        Me.lineSearchProduct.Size = New System.Drawing.Size(6, 33)
        '
        'cmdRecoveredTransaction
        '
        Me.cmdRecoveredTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdRecoveredTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.clipboard__exclamation
        Me.cmdRecoveredTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRecoveredTransaction.Name = "cmdRecoveredTransaction"
        Me.cmdRecoveredTransaction.Size = New System.Drawing.Size(97, 30)
        Me.cmdRecoveredTransaction.Text = "Recovered F4"
        '
        'lineRecoverd
        '
        Me.lineRecoverd.Name = "lineRecoverd"
        Me.lineRecoverd.Size = New System.Drawing.Size(6, 33)
        '
        'cmdNewClient
        '
        Me.cmdNewClient.ForeColor = System.Drawing.Color.White
        Me.cmdNewClient.Image = Global.CoffeecupClient.My.Resources.Resources.users
        Me.cmdNewClient.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewClient.Name = "cmdNewClient"
        Me.cmdNewClient.Size = New System.Drawing.Size(100, 30)
        Me.cmdNewClient.Text = "New Client F5"
        '
        'lineNewClient
        '
        Me.lineNewClient.Name = "lineNewClient"
        Me.lineNewClient.Size = New System.Drawing.Size(6, 33)
        '
        'cmdTransactionHistory
        '
        Me.cmdTransactionHistory.ForeColor = System.Drawing.Color.White
        Me.cmdTransactionHistory.Image = Global.CoffeecupClient.My.Resources.Resources.clipboard_list
        Me.cmdTransactionHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTransactionHistory.Name = "cmdTransactionHistory"
        Me.cmdTransactionHistory.Size = New System.Drawing.Size(143, 30)
        Me.cmdTransactionHistory.Text = "Transaction History F6"
        '
        'lineTransactionHistory
        '
        Me.lineTransactionHistory.Name = "lineTransactionHistory"
        Me.lineTransactionHistory.Size = New System.Drawing.Size(6, 33)
        '
        'cmdTraceTransaction
        '
        Me.cmdTraceTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdTraceTransaction.Image = Global.CoffeecupClient.My.Resources.Resources.book_open_list1
        Me.cmdTraceTransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTraceTransaction.Name = "cmdTraceTransaction"
        Me.cmdTraceTransaction.Size = New System.Drawing.Size(117, 30)
        Me.cmdTraceTransaction.Text = "Trace Transaction"
        '
        'lineTraceTransaction
        '
        Me.lineTraceTransaction.Name = "lineTraceTransaction"
        Me.lineTraceTransaction.Size = New System.Drawing.Size(6, 33)
        '
        'cmdReturnCurrentInvoice
        '
        Me.cmdReturnCurrentInvoice.ForeColor = System.Drawing.Color.White
        Me.cmdReturnCurrentInvoice.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow
        Me.cmdReturnCurrentInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReturnCurrentInvoice.Name = "cmdReturnCurrentInvoice"
        Me.cmdReturnCurrentInvoice.Size = New System.Drawing.Size(144, 20)
        Me.cmdReturnCurrentInvoice.Text = "Revise Current Invoice"
        '
        'lineReturnCurrentInvoice
        '
        Me.lineReturnCurrentInvoice.Name = "lineReturnCurrentInvoice"
        Me.lineReturnCurrentInvoice.Size = New System.Drawing.Size(6, 33)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblCreditLimit)
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Controls.Add(Me.cmdInfo)
        Me.GroupBox2.Controls.Add(Me.txtClient)
        Me.GroupBox2.Controls.Add(Me.cifid)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client Information"
        '
        'lblCreditLimit
        '
        Me.lblCreditLimit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.lblCreditLimit.ForeColor = System.Drawing.Color.Red
        Me.lblCreditLimit.Location = New System.Drawing.Point(405, 22)
        Me.lblCreditLimit.Name = "lblCreditLimit"
        Me.lblCreditLimit.Size = New System.Drawing.Size(159, 19)
        Me.lblCreditLimit.TabIndex = 7
        Me.lblCreditLimit.Text = "Credit Limit: 900.00"
        Me.lblCreditLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCreditLimit.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_1
        Me.cmdSearch.Location = New System.Drawing.Point(373, 19)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(27, 25)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Image = Global.CoffeecupClient.My.Resources.Resources.information
        Me.cmdInfo.Location = New System.Drawing.Point(345, 19)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(27, 25)
        Me.cmdInfo.TabIndex = 5
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'grpBarcode
        '
        Me.grpBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBarcode.Controls.Add(Me.txtBarCode)
        Me.grpBarcode.Controls.Add(Me.txtQuantity)
        Me.grpBarcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBarcode.Location = New System.Drawing.Point(13, 200)
        Me.grpBarcode.Name = "grpBarcode"
        Me.grpBarcode.Size = New System.Drawing.Size(794, 66)
        Me.grpBarcode.TabIndex = 0
        Me.grpBarcode.TabStop = False
        Me.grpBarcode.Text = "Enter Command (Use shortcut by pressing Alt+T to focus transaction, KEY UP for qu" &
    "antity, Enter Key or Spacebar for product code)"
        '
        'ckNonInventoryItem
        '
        Me.ckNonInventoryItem.AutoSize = True
        Me.ckNonInventoryItem.Location = New System.Drawing.Point(639, 299)
        Me.ckNonInventoryItem.Name = "ckNonInventoryItem"
        Me.ckNonInventoryItem.Size = New System.Drawing.Size(93, 17)
        Me.ckNonInventoryItem.TabIndex = 398
        Me.ckNonInventoryItem.Text = "Non Inventory"
        Me.ckNonInventoryItem.UseVisualStyleBackColor = True
        Me.ckNonInventoryItem.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblSVC)
        Me.Panel1.Controls.Add(Me.txtServiceCharge)
        Me.Panel1.Controls.Add(Me.lblProcessor)
        Me.Panel1.Controls.Add(Me.lblDigitalHeader)
        Me.Panel1.Controls.Add(Me.lblChit)
        Me.Panel1.Controls.Add(Me.txtTotalChit)
        Me.Panel1.Controls.Add(Me.txtBatchcode)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtSubTotal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtTotalDiscount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTotalCharge)
        Me.Panel1.Controls.Add(Me.txtDateTransaction)
        Me.Panel1.Controls.Add(Me.txtTellerAccount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTotalItem)
        Me.Panel1.Controls.Add(Me.lblVat)
        Me.Panel1.Controls.Add(Me.txtTotalTax)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTotalOnScreen)
        Me.Panel1.Location = New System.Drawing.Point(812, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 336)
        Me.Panel1.TabIndex = 399
        '
        'lblSVC
        '
        Me.lblSVC.AutoSize = True
        Me.lblSVC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSVC.ForeColor = System.Drawing.Color.Lime
        Me.lblSVC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSVC.Location = New System.Drawing.Point(8, 144)
        Me.lblSVC.Name = "lblSVC"
        Me.lblSVC.Size = New System.Drawing.Size(28, 15)
        Me.lblSVC.TabIndex = 414
        Me.lblSVC.Text = "SVC"
        '
        'txtServiceCharge
        '
        Me.txtServiceCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServiceCharge.Font = New System.Drawing.Font("Agency FB", 16.25!, System.Drawing.FontStyle.Bold)
        Me.txtServiceCharge.ForeColor = System.Drawing.Color.Lime
        Me.txtServiceCharge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtServiceCharge.Location = New System.Drawing.Point(41, 138)
        Me.txtServiceCharge.Name = "txtServiceCharge"
        Me.txtServiceCharge.Size = New System.Drawing.Size(212, 26)
        Me.txtServiceCharge.TabIndex = 413
        Me.txtServiceCharge.Text = "0.00"
        Me.txtServiceCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProcessor
        '
        Me.lblProcessor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProcessor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblProcessor.ForeColor = System.Drawing.Color.Lime
        Me.lblProcessor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProcessor.Location = New System.Drawing.Point(7, 316)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(249, 15)
        Me.lblProcessor.TabIndex = 412
        Me.lblProcessor.Text = "Processor's Name"
        Me.lblProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProcessor.Visible = False
        '
        'lblDigitalHeader
        '
        Me.lblDigitalHeader.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDigitalHeader.ForeColor = System.Drawing.Color.Lime
        Me.lblDigitalHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDigitalHeader.Location = New System.Drawing.Point(0, 2)
        Me.lblDigitalHeader.Name = "lblDigitalHeader"
        Me.lblDigitalHeader.Size = New System.Drawing.Size(260, 34)
        Me.lblDigitalHeader.TabIndex = 411
        Me.lblDigitalHeader.Text = "WINTER BUGAHOD COFFEECUP SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Coffeecup Computing System"
        Me.lblDigitalHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChit
        '
        Me.lblChit.AutoSize = True
        Me.lblChit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChit.ForeColor = System.Drawing.Color.Lime
        Me.lblChit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblChit.Location = New System.Drawing.Point(8, 168)
        Me.lblChit.Name = "lblChit"
        Me.lblChit.Size = New System.Drawing.Size(30, 15)
        Me.lblChit.TabIndex = 410
        Me.lblChit.Text = "SOP"
        Me.lblChit.Visible = False
        '
        'txtTotalChit
        '
        Me.txtTotalChit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalChit.Font = New System.Drawing.Font("Agency FB", 16.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalChit.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalChit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalChit.Location = New System.Drawing.Point(87, 161)
        Me.txtTotalChit.Name = "txtTotalChit"
        Me.txtTotalChit.Size = New System.Drawing.Size(166, 28)
        Me.txtTotalChit.TabIndex = 409
        Me.txtTotalChit.Text = "0.00"
        Me.txtTotalChit.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtTotalChit.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Lime
        Me.txtBatchcode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBatchcode.Location = New System.Drawing.Point(0, 49)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Size = New System.Drawing.Size(260, 15)
        Me.txtBatchcode.TabIndex = 395
        Me.txtBatchcode.Text = "1000928-101"
        Me.txtBatchcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(7, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 407
        Me.Label11.Text = "SubTotal"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Lime
        Me.txtSubTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSubTotal.Location = New System.Drawing.Point(86, 258)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(166, 17)
        Me.txtSubTotal.TabIndex = 406
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(7, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 405
        Me.Label9.Text = "Discount"
        '
        'txtTotalDiscount
        '
        Me.txtTotalDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalDiscount.Location = New System.Drawing.Point(86, 239)
        Me.txtTotalDiscount.Name = "txtTotalDiscount"
        Me.txtTotalDiscount.Size = New System.Drawing.Size(166, 17)
        Me.txtTotalDiscount.TabIndex = 404
        Me.txtTotalDiscount.Text = "0.00"
        Me.txtTotalDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(7, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 403
        Me.Label6.Text = "Charges"
        '
        'txtTotalCharge
        '
        Me.txtTotalCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCharge.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCharge.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCharge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalCharge.Location = New System.Drawing.Point(86, 220)
        Me.txtTotalCharge.Name = "txtTotalCharge"
        Me.txtTotalCharge.Size = New System.Drawing.Size(166, 17)
        Me.txtTotalCharge.TabIndex = 402
        Me.txtTotalCharge.Text = "0.00"
        Me.txtTotalCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(7, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 401
        Me.Label5.Text = "Total Item"
        '
        'txtTotalItem
        '
        Me.txtTotalItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItem.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalItem.Location = New System.Drawing.Point(86, 201)
        Me.txtTotalItem.Name = "txtTotalItem"
        Me.txtTotalItem.Size = New System.Drawing.Size(166, 17)
        Me.txtTotalItem.TabIndex = 400
        Me.txtTotalItem.Text = "0.00"
        Me.txtTotalItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVat.ForeColor = System.Drawing.Color.Lime
        Me.lblVat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVat.Location = New System.Drawing.Point(7, 119)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(26, 15)
        Me.lblVat.TabIndex = 398
        Me.lblVat.Text = "VAT"
        '
        'txtTotalTax
        '
        Me.txtTotalTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalTax.Font = New System.Drawing.Font("Agency FB", 16.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTax.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalTax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalTax.Location = New System.Drawing.Point(40, 115)
        Me.txtTotalTax.Name = "txtTotalTax"
        Me.txtTotalTax.Size = New System.Drawing.Size(212, 26)
        Me.txtTotalTax.TabIndex = 397
        Me.txtTotalTax.Text = "0.00"
        Me.txtTotalTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 396
        Me.Label1.Text = "TOTAL"
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Agency FB", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalOnScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(45, 68)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(216, 52)
        Me.txtTotalOnScreen.TabIndex = 394
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalCancelled
        '
        Me.txtTotalCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCancelled.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCancelled.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtTotalCancelled.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCancelled.Location = New System.Drawing.Point(631, 379)
        Me.txtTotalCancelled.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCancelled.Name = "txtTotalCancelled"
        Me.txtTotalCancelled.Size = New System.Drawing.Size(107, 22)
        Me.txtTotalCancelled.TabIndex = 400
        Me.txtTotalCancelled.Text = "0.00"
        Me.txtTotalCancelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCancelled.Visible = False
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(13, 271)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(794, 457)
        Me.MyDataGridView.TabIndex = 401
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtuserid.ForeColor = System.Drawing.Color.Black
        Me.txtuserid.Location = New System.Drawing.Point(298, 343)
        Me.txtuserid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(86, 31)
        Me.txtuserid.TabIndex = 5
        Me.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuserid.Visible = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 40)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(823, 104)
        Me.PictureEdit1.TabIndex = 402
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1083, 734)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpBarcode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTotalCancelled)
        Me.Controls.Add(Me.ckNonInventoryItem)
        Me.Controls.Add(Me.PictureEdit1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1034, 577)
        Me.Name = "frmPointOfSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COFFEECUP POINT OF SALE"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpBarcode.ResumeLayout(False)
        Me.grpBarcode.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdVoidTransaction As System.Windows.Forms.Button
    Friend WithEvents cmdCancelLine As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTellerAccount As System.Windows.Forms.Label
    Friend WithEvents txtDateTransaction As System.Windows.Forms.Label
    Friend WithEvents cmdPayment As System.Windows.Forms.Button
    Friend WithEvents cmdHold As System.Windows.Forms.Button
    Friend WithEvents cmdChargeClientAccount As System.Windows.Forms.Button
    Friend WithEvents cmdEditLine As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineHold As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRecoveredTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineCloseAccount As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProductSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOnholdTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineRecoverd As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNewClient As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdClosedAccount As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineNewClient As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdTransactionHistory As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineSearchProduct As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBarcode As System.Windows.Forms.GroupBox
    Friend WithEvents ckNonInventoryItem As System.Windows.Forms.CheckBox
    Friend WithEvents lineOrderSlip As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDiscount As System.Windows.Forms.Button
    Friend WithEvents cmdPrintOrderSlip As System.Windows.Forms.Button
    Friend WithEvents cmdPendingOrderSlip As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineTransactionHistory As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents txtTotalTax As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDiscount As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCharge As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalItem As System.Windows.Forms.Label
    Friend WithEvents txtTotalCancelled As System.Windows.Forms.TextBox
    Friend WithEvents lblChit As System.Windows.Forms.Label
    Friend WithEvents txtTotalChit As System.Windows.Forms.Label
    Friend WithEvents lblDigitalHeader As System.Windows.Forms.Label
    Friend WithEvents lblProcessor As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lineTraceTransaction As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdTraceTransaction As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents cmdReturnCurrentInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineReturnCurrentInvoice As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblSVC As System.Windows.Forms.Label
    Friend WithEvents txtServiceCharge As System.Windows.Forms.Label
    Friend WithEvents cmdCouponCharge As System.Windows.Forms.Button
    Friend WithEvents cmdInterOffice As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents cmdRemarks As System.Windows.Forms.Button
    Friend WithEvents lblCreditLimit As System.Windows.Forms.Label
    Friend WithEvents cmdAddCharges As System.Windows.Forms.Button
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
