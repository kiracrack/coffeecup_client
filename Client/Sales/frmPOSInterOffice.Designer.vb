<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSInterOffice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSInterOffice))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtGLItem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOffice = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.companyid = New System.Windows.Forms.TextBox()
        Me.cmdInputPaymentDetails = New System.Windows.Forms.LinkLabel()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaymentMode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmountCovered = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lbldds = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
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
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(230, 375)
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
        Me.Label2.Location = New System.Drawing.Point(16, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Transaction Code"
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(138, 551)
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
        Me.txtGLItem.Location = New System.Drawing.Point(122, 275)
        Me.txtGLItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGLItem.MaxDropDownItems = 7
        Me.txtGLItem.Name = "txtGLItem"
        Me.txtGLItem.Size = New System.Drawing.Size(294, 23)
        Me.txtGLItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(126, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Amount Due"
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(89, 551)
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
        Me.txtRemarks.Location = New System.Drawing.Point(122, 327)
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
        Me.Label4.Location = New System.Drawing.Point(63, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Remarks"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(231, 71)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.ReadOnly = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(185, 22)
        Me.txtInvoiceNumber.TabIndex = 10
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(118, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 406
        Me.Label5.Text = "Reference Number"
        '
        'txtOffice
        '
        Me.txtOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtOffice.DropDownHeight = 130
        Me.txtOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtOffice.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtOffice.ForeColor = System.Drawing.Color.Black
        Me.txtOffice.FormattingEnabled = True
        Me.txtOffice.IntegralHeight = False
        Me.txtOffice.ItemHeight = 15
        Me.txtOffice.Location = New System.Drawing.Point(122, 301)
        Me.txtOffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOffice.MaxDropDownItems = 7
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(294, 23)
        Me.txtOffice.TabIndex = 407
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 408
        Me.Label3.Text = "Office Name"
        '
        'companyid
        '
        Me.companyid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.companyid.ForeColor = System.Drawing.Color.Black
        Me.companyid.Location = New System.Drawing.Point(187, 551)
        Me.companyid.Margin = New System.Windows.Forms.Padding(4)
        Me.companyid.Name = "companyid"
        Me.companyid.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(41, 22)
        Me.companyid.TabIndex = 409
        Me.companyid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.companyid.Visible = False
        '
        'cmdInputPaymentDetails
        '
        Me.cmdInputPaymentDetails.AutoSize = True
        Me.cmdInputPaymentDetails.Location = New System.Drawing.Point(239, 152)
        Me.cmdInputPaymentDetails.Name = "cmdInputPaymentDetails"
        Me.cmdInputPaymentDetails.Size = New System.Drawing.Size(168, 13)
        Me.cmdInputPaymentDetails.TabIndex = 720
        Me.cmdInputPaymentDetails.TabStop = True
        Me.cmdInputPaymentDetails.Text = "Please input other payment details"
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(349, 133)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(66, 17)
        Me.rbMultiPayment.TabIndex = 722
        Me.rbMultiPayment.Text = "OTHERS"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(239, 133)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(101, 17)
        Me.rbCash.TabIndex = 721
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH PAYMENT"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'txtORNumber
        '
        Me.txtORNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtORNumber.ForeColor = System.Drawing.Color.Black
        Me.txtORNumber.Location = New System.Drawing.Point(239, 170)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.ReadOnly = True
        Me.txtORNumber.Size = New System.Drawing.Size(177, 22)
        Me.txtORNumber.TabIndex = 718
        Me.txtORNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(162, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 719
        Me.Label7.Text = "OR Number"
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentMode.Location = New System.Drawing.Point(239, 194)
        Me.txtPaymentMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.ReadOnly = True
        Me.txtPaymentMode.Size = New System.Drawing.Size(177, 22)
        Me.txtPaymentMode.TabIndex = 725
        Me.txtPaymentMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(144, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 726
        Me.Label6.Text = "Payment Mode"
        '
        'txtAmountTender
        '
        Me.txtAmountTender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(239, 218)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(177, 29)
        Me.txtAmountTender.TabIndex = 723
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(95, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 15)
        Me.Label8.TabIndex = 724
        Me.Label8.Text = "Payment Excess Amount"
        '
        'txtAmountCovered
        '
        Me.txtAmountCovered.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountCovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountCovered.ForeColor = System.Drawing.Color.Black
        Me.txtAmountCovered.Location = New System.Drawing.Point(231, 96)
        Me.txtAmountCovered.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountCovered.Name = "txtAmountCovered"
        Me.txtAmountCovered.Size = New System.Drawing.Size(185, 29)
        Me.txtAmountCovered.TabIndex = 727
        Me.txtAmountCovered.Text = "0.00"
        Me.txtAmountCovered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(126, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 728
        Me.Label9.Text = "Amount Covered"
        '
        'txtTotal
        '
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(239, 249)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(177, 22)
        Me.txtTotal.TabIndex = 729
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbldds
        '
        Me.lbldds.AutoSize = True
        Me.lbldds.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbldds.Location = New System.Drawing.Point(157, 253)
        Me.lbldds.Name = "lbldds"
        Me.lbldds.Size = New System.Drawing.Size(75, 13)
        Me.lbldds.TabIndex = 730
        Me.lbldds.Text = "Total Amount"
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(232, 551)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(41, 22)
        Me.officeid.TabIndex = 731
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.officeid.Visible = False
        '
        'frmPOSInterOffice
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(461, 431)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lbldds)
        Me.Controls.Add(Me.txtAmountCovered)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPaymentMode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdInputPaymentDetails)
        Me.Controls.Add(Me.rbMultiPayment)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGLItem)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSInterOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inter Office Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtGLItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents companyid As System.Windows.Forms.TextBox
    Friend WithEvents cmdInputPaymentDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents rbMultiPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtORNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAmountCovered As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lbldds As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
End Class
