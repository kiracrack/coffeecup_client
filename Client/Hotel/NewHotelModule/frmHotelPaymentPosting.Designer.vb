<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPaymentPosting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelPaymentPosting))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReferenceNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdInputPaymentDetails = New System.Windows.Forms.LinkLabel()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.txtPaymentMode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.lblSettlement = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckMultiple = New System.Windows.Forms.CheckBox()
        Me.ckMainFolio = New System.Windows.Forms.CheckBox()
        Me.ckDue = New System.Windows.Forms.CheckBox()
        Me.txtORNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(166, 288)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(132, 30)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm OK"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtAmountTender
        '
        Me.txtAmountTender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(166, 206)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(177, 29)
        Me.txtAmountTender.TabIndex = 2
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(108, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Amount"
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(14, 383)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(57, 22)
        Me.folioid.TabIndex = 410
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(166, 237)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(346, 49)
        Me.txtRemarks.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(45, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Supporting Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(127, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 419
        Me.Label2.Text = "Select Payment Option"
        '
        'txtReferenceNo
        '
        Me.txtReferenceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenceNo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtReferenceNo.ForeColor = System.Drawing.Color.Black
        Me.txtReferenceNo.Location = New System.Drawing.Point(166, 134)
        Me.txtReferenceNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReferenceNo.Name = "txtReferenceNo"
        Me.txtReferenceNo.Size = New System.Drawing.Size(177, 22)
        Me.txtReferenceNo.TabIndex = 0
        Me.txtReferenceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(78, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 15)
        Me.Label7.TabIndex = 714
        Me.Label7.Text = "Reference No."
        '
        'cmdInputPaymentDetails
        '
        Me.cmdInputPaymentDetails.AutoSize = True
        Me.cmdInputPaymentDetails.Location = New System.Drawing.Point(163, 115)
        Me.cmdInputPaymentDetails.Name = "cmdInputPaymentDetails"
        Me.cmdInputPaymentDetails.Size = New System.Drawing.Size(189, 15)
        Me.cmdInputPaymentDetails.TabIndex = 715
        Me.cmdInputPaymentDetails.TabStop = True
        Me.cmdInputPaymentDetails.Text = "Please input other payment details"
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(281, 94)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(108, 17)
        Me.rbMultiPayment.TabIndex = 717
        Me.rbMultiPayment.Text = "OTHER PAYMENT"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(166, 94)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(101, 17)
        Me.rbCash.TabIndex = 716
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH PAYMENT"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentMode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.txtPaymentMode.Location = New System.Drawing.Point(166, 182)
        Me.txtPaymentMode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.ReadOnly = True
        Me.txtPaymentMode.Size = New System.Drawing.Size(177, 22)
        Me.txtPaymentMode.TabIndex = 718
        Me.txtPaymentMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(71, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 719
        Me.Label3.Text = "Payment Mode"
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(111, 407)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(35, 22)
        Me.mode.TabIndex = 725
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'trnid
        '
        Me.trnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(59, 358)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(35, 22)
        Me.trnid.TabIndex = 726
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'lblSettlement
        '
        Me.lblSettlement.AutoSize = True
        Me.lblSettlement.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettlement.Location = New System.Drawing.Point(14, 7)
        Me.lblSettlement.Name = "lblSettlement"
        Me.lblSettlement.Size = New System.Drawing.Size(156, 24)
        Me.lblSettlement.TabIndex = 727
        Me.lblSettlement.Text = "Folio Settlement"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 15)
        Me.Label6.TabIndex = 728
        Me.Label6.Text = "Hotel payment settlement form"
        '
        'ckMultiple
        '
        Me.ckMultiple.AutoSize = True
        Me.ckMultiple.Location = New System.Drawing.Point(339, 14)
        Me.ckMultiple.Name = "ckMultiple"
        Me.ckMultiple.Size = New System.Drawing.Size(140, 19)
        Me.ckMultiple.TabIndex = 729
        Me.ckMultiple.Text = "MutipleFolioPayment"
        Me.ckMultiple.UseVisualStyleBackColor = True
        Me.ckMultiple.Visible = False
        '
        'ckMainFolio
        '
        Me.ckMainFolio.AutoSize = True
        Me.ckMainFolio.Location = New System.Drawing.Point(339, 39)
        Me.ckMainFolio.Name = "ckMainFolio"
        Me.ckMainFolio.Size = New System.Drawing.Size(126, 19)
        Me.ckMainFolio.TabIndex = 730
        Me.ckMainFolio.Text = "MainFolioPayment"
        Me.ckMainFolio.UseVisualStyleBackColor = True
        Me.ckMainFolio.Visible = False
        '
        'ckDue
        '
        Me.ckDue.AutoSize = True
        Me.ckDue.Location = New System.Drawing.Point(349, 213)
        Me.ckDue.Name = "ckDue"
        Me.ckDue.Size = New System.Drawing.Size(161, 19)
        Me.ckDue.TabIndex = 731
        Me.ckDue.Text = "Due to Accounting Office"
        Me.ckDue.UseVisualStyleBackColor = True
        '
        'txtORNo
        '
        Me.txtORNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORNo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtORNo.ForeColor = System.Drawing.Color.Black
        Me.txtORNo.Location = New System.Drawing.Point(166, 158)
        Me.txtORNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtORNo.Name = "txtORNo"
        Me.txtORNo.Size = New System.Drawing.Size(177, 22)
        Me.txtORNo.TabIndex = 1
        Me.txtORNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(89, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 733
        Me.Label5.Text = "OR Number"
        '
        'frmHotelPaymentPosting
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(561, 342)
        Me.Controls.Add(Me.txtORNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckDue)
        Me.Controls.Add(Me.ckMainFolio)
        Me.Controls.Add(Me.ckMultiple)
        Me.Controls.Add(Me.lblSettlement)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtPaymentMode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdInputPaymentDetails)
        Me.Controls.Add(Me.rbMultiPayment)
        Me.Controls.Add(Me.rbCash)
        Me.Controls.Add(Me.txtReferenceNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelPaymentPosting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Payment Posting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdInputPaymentDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents rbMultiPayment As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtPaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents lblSettlement As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckMultiple As System.Windows.Forms.CheckBox
    Friend WithEvents ckMainFolio As System.Windows.Forms.CheckBox
    Friend WithEvents ckDue As System.Windows.Forms.CheckBox
    Friend WithEvents txtORNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
