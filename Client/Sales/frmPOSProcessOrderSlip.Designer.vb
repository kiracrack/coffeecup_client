<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSProcessOrderSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSProcessOrderSlip))
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtSalesPerson = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ckChitCounter = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salesid = New System.Windows.Forms.TextBox()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtPaymentMode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radComplimentary = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtAmountTender
        '
        Me.txtAmountTender.Font = New System.Drawing.Font("Agency FB", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(145, 205)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(371, 59)
        Me.txtAmountTender.TabIndex = 0
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Enabled = False
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(196, 330)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(268, 44)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Submit Order Slip to Cashier"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(142, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Payment Amount"
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(376, 422)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Size = New System.Drawing.Size(57, 22)
        Me.txtBatchcode.TabIndex = 406
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'txtSalesPerson
        '
        Me.txtSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtSalesPerson.DropDownHeight = 130
        Me.txtSalesPerson.Font = New System.Drawing.Font("Segoe UI", 11.65!)
        Me.txtSalesPerson.ForeColor = System.Drawing.Color.Black
        Me.txtSalesPerson.FormattingEnabled = True
        Me.txtSalesPerson.IntegralHeight = False
        Me.txtSalesPerson.ItemHeight = 21
        Me.txtSalesPerson.Location = New System.Drawing.Point(145, 293)
        Me.txtSalesPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesPerson.MaxDropDownItems = 7
        Me.txtSalesPerson.Name = "txtSalesPerson"
        Me.txtSalesPerson.Size = New System.Drawing.Size(371, 29)
        Me.txtSalesPerson.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'ckChitCounter
        '
        Me.ckChitCounter.AutoSize = True
        Me.ckChitCounter.Location = New System.Drawing.Point(407, 185)
        Me.ckChitCounter.Name = "ckChitCounter"
        Me.ckChitCounter.Size = New System.Drawing.Size(112, 19)
        Me.ckChitCounter.TabIndex = 413
        Me.ckChitCounter.Text = "&Chit Transaction"
        Me.ckChitCounter.UseVisualStyleBackColor = True
        Me.ckChitCounter.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(142, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 19)
        Me.Label1.TabIndex = 414
        Me.Label1.Text = "Please enter sales person name to validate transaction"
        '
        'salesid
        '
        Me.salesid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.salesid.ForeColor = System.Drawing.Color.Black
        Me.salesid.Location = New System.Drawing.Point(309, 422)
        Me.salesid.Margin = New System.Windows.Forms.Padding(5)
        Me.salesid.Name = "salesid"
        Me.salesid.Size = New System.Drawing.Size(57, 22)
        Me.salesid.TabIndex = 415
        Me.salesid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.salesid.Visible = False
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(251, 113)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(129, 17)
        Me.rbMultiPayment.TabIndex = 419
        Me.rbMultiPayment.Text = "OTHER PAYMENT (F2)"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(145, 113)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(103, 17)
        Me.rbCash.TabIndex = 418
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH ONLY (F1)"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.BackColor = System.Drawing.Color.Gold
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Agency FB", 32.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(145, 46)
        Me.txtTotalOnScreen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.ReadOnly = True
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(371, 59)
        Me.txtTotalOnScreen.TabIndex = 417
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(142, 26)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(238, 15)
        Me.lblTransaction.TabIndex = 416
        Me.lblTransaction.Text = "Total Transaction (Reference # 1000010-105)"
        '
        'txtClientName
        '
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtClientName.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Location = New System.Drawing.Point(443, 422)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(57, 22)
        Me.txtClientName.TabIndex = 420
        Me.txtClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClientName.Visible = False
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentMode.Location = New System.Drawing.Point(145, 151)
        Me.txtPaymentMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.ReadOnly = True
        Me.txtPaymentMode.Size = New System.Drawing.Size(370, 29)
        Me.txtPaymentMode.TabIndex = 722
        Me.txtPaymentMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(142, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 723
        Me.Label3.Text = "Payment Mode"
        '
        'radComplimentary
        '
        Me.radComplimentary.AutoSize = True
        Me.radComplimentary.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.radComplimentary.Location = New System.Drawing.Point(383, 114)
        Me.radComplimentary.Name = "radComplimentary"
        Me.radComplimentary.Size = New System.Drawing.Size(133, 17)
        Me.radComplimentary.TabIndex = 724
        Me.radComplimentary.Text = "COMPLIMENTARY (F3)"
        Me.radComplimentary.UseVisualStyleBackColor = True
        '
        'frmPOSProcessOrderSlip
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(655, 405)
        Me.Controls.Add(Me.radComplimentary)
        Me.Controls.Add(Me.txtPaymentMode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.rbMultiPayment)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.salesid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.ckChitCounter)
        Me.Controls.Add(Me.txtSalesPerson)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSProcessOrderSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Slip Transaction Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ckChitCounter As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents salesid As System.Windows.Forms.TextBox
    Friend WithEvents rbMultiPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radComplimentary As System.Windows.Forms.RadioButton
End Class
