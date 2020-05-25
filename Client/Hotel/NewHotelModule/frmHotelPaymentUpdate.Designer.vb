<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelPaymentUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelPaymentUpdate))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(150, 126)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(132, 30)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm Update"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtAmountTender
        '
        Me.txtAmountTender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(150, 44)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.ReadOnly = True
        Me.txtAmountTender.Size = New System.Drawing.Size(177, 29)
        Me.txtAmountTender.TabIndex = 1
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(92, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Amount"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(150, 75)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(274, 49)
        Me.txtRemarks.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(29, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Supporting Remarks"
        '
        'txtORNumber
        '
        Me.txtORNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtORNumber.ForeColor = System.Drawing.Color.Black
        Me.txtORNumber.Location = New System.Drawing.Point(150, 19)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.ReadOnly = True
        Me.txtORNumber.Size = New System.Drawing.Size(177, 22)
        Me.txtORNumber.TabIndex = 0
        Me.txtORNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(73, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 714
        Me.Label7.Text = "OR Number"
        '
        'trnid
        '
        Me.trnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(59, 338)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(35, 22)
        Me.trnid.TabIndex = 726
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(104, 338)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(35, 22)
        Me.foliono.TabIndex = 727
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'frmHotelPaymentUpdate
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(463, 172)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtORNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmountTender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelPaymentUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Payment Posting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtORNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
End Class
