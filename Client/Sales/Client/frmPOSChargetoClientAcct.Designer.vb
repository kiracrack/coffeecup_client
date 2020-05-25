<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSChargetoClientAcct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSChargetoClientAcct))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtGLItem = New System.Windows.Forms.ComboBox()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(169, 15)
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
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(231, 35)
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
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(231, 252)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(185, 38)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm "
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Name"
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(142, 335)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(41, 22)
        Me.txtBatchcode.TabIndex = 396
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBatchcode.Visible = False
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
        Me.txtGLItem.Location = New System.Drawing.Point(122, 127)
        Me.txtGLItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGLItem.MaxDropDownItems = 7
        Me.txtGLItem.Name = "txtGLItem"
        Me.txtGLItem.Size = New System.Drawing.Size(294, 23)
        Me.txtGLItem.TabIndex = 1
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(98, 334)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(41, 22)
        Me.cifid.TabIndex = 398
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(120, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Total Amount"
        '
        'txtClientName
        '
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtClientName.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Location = New System.Drawing.Point(122, 101)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(294, 22)
        Me.txtClientName.TabIndex = 400
        Me.txtClientName.Text = "WINTER S. BUGAHOD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(43, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 401
        Me.Label3.Text = "Client Name"
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(84, 321)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(4)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(41, 22)
        Me.itemcode.TabIndex = 402
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(122, 154)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(294, 43)
        Me.txtRemarks.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(64, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Remarks"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(231, 72)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(185, 26)
        Me.txtInvoiceNumber.TabIndex = 10
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(155, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 406
        Me.Label5.Text = "Invoice No."
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(156, 356)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 35)
        Me.WebBrowser1.TabIndex = 407
        '
        'txtAmountTender
        '
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(233, 224)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(183, 24)
        Me.txtAmountTender.TabIndex = 0
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(136, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 409
        Me.Label6.Text = "Partial Payment"
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(287, 201)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(129, 17)
        Me.rbMultiPayment.TabIndex = 412
        Me.rbMultiPayment.Text = "OTHER PAYMENT (F2)"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(177, 201)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(103, 17)
        Me.rbCash.TabIndex = 411
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH ONLY (F1)"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'frmPOSChargetoClientAcct
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(439, 305)
        Me.Controls.Add(Me.rbMultiPayment)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGLItem)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSChargetoClientAcct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge to Client Account Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtGLItem As System.Windows.Forms.ComboBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtAmountTender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbMultiPayment As RadioButton
    Friend WithEvents rbCash As RadioButton
End Class
