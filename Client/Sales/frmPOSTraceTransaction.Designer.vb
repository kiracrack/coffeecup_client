<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSTraceTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSTraceTransaction))
        Me.txtSearchKeyword = New System.Windows.Forms.ComboBox()
        Me.txtVoidBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckVoid = New System.Windows.Forms.CheckBox()
        Me.txtChitNetDiscount = New System.Windows.Forms.TextBox()
        Me.lblChitNetDiscount = New System.Windows.Forms.Label()
        Me.txtChitCustomerName = New System.Windows.Forms.TextBox()
        Me.lblChitCustomerName = New System.Windows.Forms.Label()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPaymentType = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAmountChange = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAmountTendered = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalChit = New System.Windows.Forms.TextBox()
        Me.lblChitAmount = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyDataGridView_Trace = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdVoidTransaction = New System.Windows.Forms.Button()
        CType(Me.MyDataGridView_Trace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchKeyword
        '
        Me.txtSearchKeyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearchKeyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtSearchKeyword.DropDownHeight = 130
        Me.txtSearchKeyword.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSearchKeyword.ForeColor = System.Drawing.Color.Black
        Me.txtSearchKeyword.FormattingEnabled = True
        Me.txtSearchKeyword.IntegralHeight = False
        Me.txtSearchKeyword.ItemHeight = 15
        Me.txtSearchKeyword.Location = New System.Drawing.Point(23, 32)
        Me.txtSearchKeyword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchKeyword.MaxDropDownItems = 7
        Me.txtSearchKeyword.Name = "txtSearchKeyword"
        Me.txtSearchKeyword.Size = New System.Drawing.Size(281, 23)
        Me.txtSearchKeyword.TabIndex = 723
        '
        'txtVoidBy
        '
        Me.txtVoidBy.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVoidBy.ForeColor = System.Drawing.Color.Black
        Me.txtVoidBy.Location = New System.Drawing.Point(156, 253)
        Me.txtVoidBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoidBy.Name = "txtVoidBy"
        Me.txtVoidBy.ReadOnly = True
        Me.txtVoidBy.Size = New System.Drawing.Size(148, 22)
        Me.txtVoidBy.TabIndex = 441
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(101, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 440
        Me.Label1.Text = "Void By"
        '
        'ckVoid
        '
        Me.ckVoid.AutoSize = True
        Me.ckVoid.Enabled = False
        Me.ckVoid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckVoid.Location = New System.Drawing.Point(156, 236)
        Me.ckVoid.Name = "ckVoid"
        Me.ckVoid.Size = New System.Drawing.Size(110, 17)
        Me.ckVoid.TabIndex = 439
        Me.ckVoid.Text = "Transaction Void"
        Me.ckVoid.UseVisualStyleBackColor = True
        '
        'txtChitNetDiscount
        '
        Me.txtChitNetDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtChitNetDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtChitNetDiscount.Location = New System.Drawing.Point(156, 338)
        Me.txtChitNetDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChitNetDiscount.Name = "txtChitNetDiscount"
        Me.txtChitNetDiscount.ReadOnly = True
        Me.txtChitNetDiscount.Size = New System.Drawing.Size(148, 22)
        Me.txtChitNetDiscount.TabIndex = 436
        Me.txtChitNetDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChitNetDiscount.Visible = False
        '
        'lblChitNetDiscount
        '
        Me.lblChitNetDiscount.AutoSize = True
        Me.lblChitNetDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblChitNetDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblChitNetDiscount.Location = New System.Drawing.Point(22, 342)
        Me.lblChitNetDiscount.Name = "lblChitNetDiscount"
        Me.lblChitNetDiscount.Size = New System.Drawing.Size(125, 15)
        Me.lblChitNetDiscount.TabIndex = 435
        Me.lblChitNetDiscount.Text = "Net Discount After Tax"
        Me.lblChitNetDiscount.Visible = False
        '
        'txtChitCustomerName
        '
        Me.txtChitCustomerName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtChitCustomerName.ForeColor = System.Drawing.Color.Black
        Me.txtChitCustomerName.Location = New System.Drawing.Point(156, 313)
        Me.txtChitCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChitCustomerName.Name = "txtChitCustomerName"
        Me.txtChitCustomerName.ReadOnly = True
        Me.txtChitCustomerName.Size = New System.Drawing.Size(148, 22)
        Me.txtChitCustomerName.TabIndex = 434
        Me.txtChitCustomerName.Visible = False
        '
        'lblChitCustomerName
        '
        Me.lblChitCustomerName.AutoSize = True
        Me.lblChitCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblChitCustomerName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblChitCustomerName.Location = New System.Drawing.Point(28, 316)
        Me.lblChitCustomerName.Name = "lblChitCustomerName"
        Me.lblChitCustomerName.Size = New System.Drawing.Size(119, 15)
        Me.lblChitCustomerName.TabIndex = 433
        Me.lblChitCustomerName.Text = "Chit Customer Name"
        Me.lblChitCustomerName.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(156, 58)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(148, 22)
        Me.txtBatchcode.TabIndex = 426
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(20, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 15)
        Me.Label14.TabIndex = 425
        Me.Label14.Text = "Transaction Batchcode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(21, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 15)
        Me.Label13.TabIndex = 424
        Me.Label13.Text = "Please Enter keywords to search"
        '
        'txtPaymentType
        '
        Me.txtPaymentType.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPaymentType.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentType.Location = New System.Drawing.Point(156, 208)
        Me.txtPaymentType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentType.Name = "txtPaymentType"
        Me.txtPaymentType.ReadOnly = True
        Me.txtPaymentType.Size = New System.Drawing.Size(148, 22)
        Me.txtPaymentType.TabIndex = 419
        Me.txtPaymentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(65, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 418
        Me.Label12.Text = "Payment Type"
        '
        'txtAmountChange
        '
        Me.txtAmountChange.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmountChange.ForeColor = System.Drawing.Color.Black
        Me.txtAmountChange.Location = New System.Drawing.Point(156, 183)
        Me.txtAmountChange.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountChange.Name = "txtAmountChange"
        Me.txtAmountChange.ReadOnly = True
        Me.txtAmountChange.Size = New System.Drawing.Size(148, 22)
        Me.txtAmountChange.TabIndex = 417
        Me.txtAmountChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(52, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 416
        Me.Label11.Text = "Amount Change"
        '
        'txtAmountTendered
        '
        Me.txtAmountTendered.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmountTendered.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTendered.Location = New System.Drawing.Point(156, 158)
        Me.txtAmountTendered.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountTendered.Name = "txtAmountTendered"
        Me.txtAmountTendered.ReadOnly = True
        Me.txtAmountTendered.Size = New System.Drawing.Size(148, 22)
        Me.txtAmountTendered.TabIndex = 415
        Me.txtAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(44, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 414
        Me.Label6.Text = "Amount Tendered"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Location = New System.Drawing.Point(156, 133)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(148, 22)
        Me.txtTotalAmount.TabIndex = 413
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(67, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 412
        Me.Label5.Text = "Total Amount"
        '
        'txtTotalChit
        '
        Me.txtTotalChit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalChit.ForeColor = System.Drawing.Color.Black
        Me.txtTotalChit.Location = New System.Drawing.Point(156, 288)
        Me.txtTotalChit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalChit.Name = "txtTotalChit"
        Me.txtTotalChit.ReadOnly = True
        Me.txtTotalChit.Size = New System.Drawing.Size(148, 22)
        Me.txtTotalChit.TabIndex = 411
        Me.txtTotalChit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalChit.Visible = False
        '
        'lblChitAmount
        '
        Me.lblChitAmount.AutoSize = True
        Me.lblChitAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblChitAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblChitAmount.Location = New System.Drawing.Point(42, 291)
        Me.lblChitAmount.Name = "lblChitAmount"
        Me.lblChitAmount.Size = New System.Drawing.Size(105, 15)
        Me.lblChitAmount.TabIndex = 410
        Me.lblChitAmount.Text = "Total Chit Amount"
        Me.lblChitAmount.Visible = False
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(156, 83)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.ReadOnly = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(148, 22)
        Me.txtInvoiceNumber.TabIndex = 407
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(55, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 406
        Me.Label4.Text = "Invoice Number"
        '
        'txtTotalItem
        '
        Me.txtTotalItem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalItem.ForeColor = System.Drawing.Color.Black
        Me.txtTotalItem.Location = New System.Drawing.Point(156, 108)
        Me.txtTotalItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalItem.Name = "txtTotalItem"
        Me.txtTotalItem.ReadOnly = True
        Me.txtTotalItem.Size = New System.Drawing.Size(148, 22)
        Me.txtTotalItem.TabIndex = 397
        Me.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(87, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 396
        Me.Label3.Text = "Total Item"
        '
        'MyDataGridView_Trace
        '
        Me.MyDataGridView_Trace.AllowUserToAddRows = False
        Me.MyDataGridView_Trace.AllowUserToDeleteRows = False
        Me.MyDataGridView_Trace.AllowUserToResizeColumns = False
        Me.MyDataGridView_Trace.AllowUserToResizeRows = False
        Me.MyDataGridView_Trace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView_Trace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Trace.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Trace.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Trace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Trace.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Trace.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MyDataGridView_Trace.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Trace.Location = New System.Drawing.Point(310, 32)
        Me.MyDataGridView_Trace.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Trace.MultiSelect = False
        Me.MyDataGridView_Trace.Name = "MyDataGridView_Trace"
        Me.MyDataGridView_Trace.ReadOnly = True
        Me.MyDataGridView_Trace.RowHeadersVisible = False
        Me.MyDataGridView_Trace.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Trace.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Trace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Trace.Size = New System.Drawing.Size(672, 428)
        Me.MyDataGridView_Trace.TabIndex = 394
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem2.Text = "Reprint Transaction"
        '
        'cmdVoidTransaction
        '
        Me.cmdVoidTransaction.BackColor = System.Drawing.Color.OrangeRed
        Me.cmdVoidTransaction.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmdVoidTransaction.ForeColor = System.Drawing.Color.White
        Me.cmdVoidTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVoidTransaction.Location = New System.Drawing.Point(75, 379)
        Me.cmdVoidTransaction.Name = "cmdVoidTransaction"
        Me.cmdVoidTransaction.Size = New System.Drawing.Size(172, 41)
        Me.cmdVoidTransaction.TabIndex = 123511
        Me.cmdVoidTransaction.Text = "Void Transaction"
        Me.cmdVoidTransaction.UseVisualStyleBackColor = False
        Me.cmdVoidTransaction.Visible = False
        '
        'frmPOSTraceTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(993, 469)
        Me.Controls.Add(Me.cmdVoidTransaction)
        Me.Controls.Add(Me.txtSearchKeyword)
        Me.Controls.Add(Me.txtVoidBy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckVoid)
        Me.Controls.Add(Me.txtChitNetDiscount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblChitNetDiscount)
        Me.Controls.Add(Me.MyDataGridView_Trace)
        Me.Controls.Add(Me.txtChitCustomerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblChitCustomerName)
        Me.Controls.Add(Me.txtTotalItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblChitAmount)
        Me.Controls.Add(Me.txtTotalChit)
        Me.Controls.Add(Me.txtPaymentType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.txtAmountChange)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAmountTendered)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(999, 508)
        Me.Name = "frmPOSTraceTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Trace Transaction"
        CType(Me.MyDataGridView_Trace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView_Trace As System.Windows.Forms.DataGridView
    Friend WithEvents txtPaymentType As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAmountChange As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAmountTendered As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalChit As System.Windows.Forms.TextBox
    Friend WithEvents lblChitAmount As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalItem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtChitNetDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblChitNetDiscount As System.Windows.Forms.Label
    Friend WithEvents txtChitCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblChitCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtVoidBy As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckVoid As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearchKeyword As ComboBox
    Friend WithEvents cmdVoidTransaction As System.Windows.Forms.Button
End Class
