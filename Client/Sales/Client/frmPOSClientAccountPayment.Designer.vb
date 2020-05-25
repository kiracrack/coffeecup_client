<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSClientAccountPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSClientAccountPayment))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtDiscountRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPaymentMode = New System.Windows.Forms.TextBox()
        Me.ckChange = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOpenBalance = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblvariance = New System.Windows.Forms.Label()
        Me.txtVariance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.ckDiscount = New System.Windows.Forms.CheckBox()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmdInputPaymentDetails = New System.Windows.Forms.LinkLabel()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckasof = New System.Windows.Forms.CheckBox()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtdateFrom = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tabPost.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(137, 356)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirm.TabIndex = 5
        Me.cmdConfirm.Text = "Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtDiscountRemarks
        '
        Me.txtDiscountRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDiscountRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountRemarks.Location = New System.Drawing.Point(137, 277)
        Me.txtDiscountRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountRemarks.Multiline = True
        Me.txtDiscountRemarks.Name = "txtDiscountRemarks"
        Me.txtDiscountRemarks.ReadOnly = True
        Me.txtDiscountRemarks.Size = New System.Drawing.Size(236, 28)
        Me.txtDiscountRemarks.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(30, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Discount Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(51, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Enter Amount"
        '
        'txtAmountTender
        '
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(137, 178)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(136, 22)
        Me.txtAmountTender.TabIndex = 0
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtClient.Location = New System.Drawing.Point(138, 12)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClient.MaxDropDownItems = 7
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(258, 23)
        Me.txtClient.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(47, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "Client Account"
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(791, 379)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(41, 22)
        Me.cifid.TabIndex = 409
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPost)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(854, 459)
        Me.TabControl1.TabIndex = 410
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.Label8)
        Me.tabPost.Controls.Add(Me.txtPaymentMode)
        Me.tabPost.Controls.Add(Me.ckChange)
        Me.tabPost.Controls.Add(Me.Label9)
        Me.tabPost.Controls.Add(Me.txtOpenBalance)
        Me.tabPost.Controls.Add(Me.txtBatchcode)
        Me.tabPost.Controls.Add(Me.Label5)
        Me.tabPost.Controls.Add(Me.lblvariance)
        Me.tabPost.Controls.Add(Me.txtVariance)
        Me.tabPost.Controls.Add(Me.Label7)
        Me.tabPost.Controls.Add(Me.txtNote)
        Me.tabPost.Controls.Add(Me.Label6)
        Me.tabPost.Controls.Add(Me.txtDiscount)
        Me.tabPost.Controls.Add(Me.ckDiscount)
        Me.tabPost.Controls.Add(Me.lblbalance)
        Me.tabPost.Controls.Add(Me.txtAmount)
        Me.tabPost.Controls.Add(Me.cmdInputPaymentDetails)
        Me.tabPost.Controls.Add(Me.rbMultiPayment)
        Me.tabPost.Controls.Add(Me.rbCash)
        Me.tabPost.Controls.Add(Me.Label4)
        Me.tabPost.Controls.Add(Me.ckasof)
        Me.tabPost.Controls.Add(Me.txtDateTo)
        Me.tabPost.Controls.Add(Me.txtdateFrom)
        Me.tabPost.Controls.Add(Me.ListView1)
        Me.tabPost.Controls.Add(Me.cifid)
        Me.tabPost.Controls.Add(Me.cmdConfirm)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtClient)
        Me.tabPost.Controls.Add(Me.txtDiscountRemarks)
        Me.tabPost.Controls.Add(Me.Label1)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Controls.Add(Me.txtAmountTender)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(846, 433)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(47, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 723
        Me.Label8.Text = "Payment Type"
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentMode.Location = New System.Drawing.Point(137, 105)
        Me.txtPaymentMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.ReadOnly = True
        Me.txtPaymentMode.Size = New System.Drawing.Size(136, 23)
        Me.txtPaymentMode.TabIndex = 722
        Me.txtPaymentMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckChange
        '
        Me.ckChange.AutoSize = True
        Me.ckChange.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckChange.ForeColor = System.Drawing.Color.Black
        Me.ckChange.Location = New System.Drawing.Point(277, 256)
        Me.ckChange.Name = "ckChange"
        Me.ckChange.Size = New System.Drawing.Size(110, 19)
        Me.ckChange.TabIndex = 720
        Me.ckChange.Text = "Deposit Change"
        Me.ckChange.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(8, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 15)
        Me.Label9.TabIndex = 719
        Me.Label9.Text = "Open Balance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtOpenBalance
        '
        Me.txtOpenBalance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtOpenBalance.ForeColor = System.Drawing.Color.Black
        Me.txtOpenBalance.Location = New System.Drawing.Point(137, 130)
        Me.txtOpenBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOpenBalance.Name = "txtOpenBalance"
        Me.txtOpenBalance.ReadOnly = True
        Me.txtOpenBalance.Size = New System.Drawing.Size(136, 22)
        Me.txtOpenBalance.TabIndex = 718
        Me.txtOpenBalance.Text = "0.00"
        Me.txtOpenBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBatchcode
        '
        Me.txtBatchcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(137, 80)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Size = New System.Drawing.Size(136, 23)
        Me.txtBatchcode.TabIndex = 716
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(51, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 717
        Me.Label5.Text = "Reference No."
        '
        'lblvariance
        '
        Me.lblvariance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblvariance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblvariance.Location = New System.Drawing.Point(11, 257)
        Me.lblvariance.Name = "lblvariance"
        Me.lblvariance.Size = New System.Drawing.Size(118, 15)
        Me.lblvariance.TabIndex = 715
        Me.lblvariance.Text = "Variance"
        Me.lblvariance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtVariance
        '
        Me.txtVariance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariance.ForeColor = System.Drawing.Color.Black
        Me.txtVariance.Location = New System.Drawing.Point(137, 253)
        Me.txtVariance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVariance.Name = "txtVariance"
        Me.txtVariance.ReadOnly = True
        Me.txtVariance.Size = New System.Drawing.Size(136, 22)
        Me.txtVariance.TabIndex = 714
        Me.txtVariance.Text = "0.00"
        Me.txtVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(49, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 713
        Me.Label7.Text = "Payment Note"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNote.ForeColor = System.Drawing.Color.Black
        Me.txtNote.Location = New System.Drawing.Point(137, 307)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(236, 47)
        Me.txtNote.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(78, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 711
        Me.Label6.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(137, 229)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(136, 22)
        Me.txtDiscount.TabIndex = 710
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ckDiscount
        '
        Me.ckDiscount.AutoSize = True
        Me.ckDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckDiscount.ForeColor = System.Drawing.Color.Black
        Me.ckDiscount.Location = New System.Drawing.Point(137, 209)
        Me.ckDiscount.Name = "ckDiscount"
        Me.ckDiscount.Size = New System.Drawing.Size(73, 19)
        Me.ckDiscount.TabIndex = 709
        Me.ckDiscount.Text = "Discount"
        Me.ckDiscount.UseVisualStyleBackColor = True
        '
        'lblbalance
        '
        Me.lblbalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblbalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblbalance.Location = New System.Drawing.Point(8, 157)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(124, 15)
        Me.lblbalance.TabIndex = 708
        Me.lblbalance.Text = "Total Checked Invoice"
        Me.lblbalance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Yellow
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(137, 154)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(136, 22)
        Me.txtAmount.TabIndex = 707
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdInputPaymentDetails
        '
        Me.cmdInputPaymentDetails.AutoSize = True
        Me.cmdInputPaymentDetails.Location = New System.Drawing.Point(134, 62)
        Me.cmdInputPaymentDetails.Name = "cmdInputPaymentDetails"
        Me.cmdInputPaymentDetails.Size = New System.Drawing.Size(154, 13)
        Me.cmdInputPaymentDetails.TabIndex = 0
        Me.cmdInputPaymentDetails.TabStop = True
        Me.cmdInputPaymentDetails.Text = "Please input payment details"
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(252, 39)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(108, 17)
        Me.rbMultiPayment.TabIndex = 704
        Me.rbMultiPayment.Text = "OTHER PAYMENT"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(137, 39)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(101, 17)
        Me.rbCash.TabIndex = 702
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH PAYMENT"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(561, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 15)
        Me.Label4.TabIndex = 701
        Me.Label4.Text = "-"
        '
        'ckasof
        '
        Me.ckasof.AutoSize = True
        Me.ckasof.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckasof.ForeColor = System.Drawing.Color.Black
        Me.ckasof.Location = New System.Drawing.Point(743, 16)
        Me.ckasof.Name = "ckasof"
        Me.ckasof.Size = New System.Drawing.Size(76, 19)
        Me.ckasof.TabIndex = 700
        Me.ckasof.Text = "Check All"
        Me.ckasof.UseVisualStyleBackColor = True
        '
        'txtDateTo
        '
        Me.txtDateTo.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTo.Location = New System.Drawing.Point(578, 13)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(150, 22)
        Me.txtDateTo.TabIndex = 699
        '
        'txtdateFrom
        '
        Me.txtdateFrom.CustomFormat = "MMMM dd, yyyy"
        Me.txtdateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdateFrom.Location = New System.Drawing.Point(403, 13)
        Me.txtdateFrom.Name = "txtdateFrom"
        Me.txtdateFrom.Size = New System.Drawing.Size(150, 22)
        Me.txtdateFrom.TabIndex = 698
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(403, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(435, 385)
        Me.ListView1.TabIndex = 697
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.MyDataGridView)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(846, 433)
        Me.tabTransaction.TabIndex = 1
        Me.tabTransaction.Text = "View Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(840, 427)
        Me.MyDataGridView.TabIndex = 394
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(175, 26)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(174, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Cancel Transaction"
        '
        'frmPOSClientAccountPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(854, 459)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(870, 476)
        Me.Name = "frmPOSClientAccountPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Account Payment Transaction"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtDiscountRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckasof As System.Windows.Forms.CheckBox
    Friend WithEvents txtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdInputPaymentDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents rbMultiPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblvariance As System.Windows.Forms.Label
    Friend WithEvents txtVariance As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents ckDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtOpenBalance As TextBox
    Friend WithEvents ckChange As System.Windows.Forms.CheckBox
    Friend WithEvents txtPaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
