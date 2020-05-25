<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSCouponCharge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCouponCharge))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.txtCouponDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCouponCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.txtCouponAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(107, 22)
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
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(169, 42)
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
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(169, 159)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(185, 38)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm "
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Total Amount"
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(93, 335)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(4)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(41, 22)
        Me.itemcode.TabIndex = 402
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'txtCouponDetails
        '
        Me.txtCouponDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCouponDetails.ForeColor = System.Drawing.Color.Black
        Me.txtCouponDetails.Location = New System.Drawing.Point(169, 108)
        Me.txtCouponDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCouponDetails.Name = "txtCouponDetails"
        Me.txtCouponDetails.ReadOnly = True
        Me.txtCouponDetails.Size = New System.Drawing.Size(292, 22)
        Me.txtCouponDetails.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(73, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Coupon Details"
        '
        'txtCouponCode
        '
        Me.txtCouponCode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCouponCode.ForeColor = System.Drawing.Color.Black
        Me.txtCouponCode.Location = New System.Drawing.Point(169, 83)
        Me.txtCouponCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCouponCode.Name = "txtCouponCode"
        Me.txtCouponCode.Size = New System.Drawing.Size(98, 22)
        Me.txtCouponCode.TabIndex = 0
        Me.txtCouponCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(80, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 406
        Me.Label5.Text = "Coupon Code"
        '
        'officeid
        '
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(191, 335)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.ReadOnly = True
        Me.officeid.Size = New System.Drawing.Size(41, 22)
        Me.officeid.TabIndex = 409
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.officeid.Visible = False
        '
        'txtCouponAmount
        '
        Me.txtCouponAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCouponAmount.ForeColor = System.Drawing.Color.Black
        Me.txtCouponAmount.Location = New System.Drawing.Point(169, 133)
        Me.txtCouponAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCouponAmount.Name = "txtCouponAmount"
        Me.txtCouponAmount.ReadOnly = True
        Me.txtCouponAmount.Size = New System.Drawing.Size(119, 22)
        Me.txtCouponAmount.TabIndex = 2
        Me.txtCouponAmount.Text = "0.00"
        Me.txtCouponAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(110, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 411
        Me.Label2.Text = "Amount"
        '
        'frmPOSCouponCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(509, 214)
        Me.Controls.Add(Me.txtCouponAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtCouponCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCouponDetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSCouponCharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupon Charge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCouponDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCouponCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents txtCouponAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
