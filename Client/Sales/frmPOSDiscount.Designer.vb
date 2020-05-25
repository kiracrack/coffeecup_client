<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSDiscount))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscountType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtDiscountedAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(212, 204)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(162, 38)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(212, 174)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(162, 27)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(124, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 411
        Me.Label4.Text = "Enter Amount"
        '
        'txtDiscountType
        '
        Me.txtDiscountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDiscountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDiscountType.DropDownHeight = 130
        Me.txtDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDiscountType.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtDiscountType.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountType.FormattingEnabled = True
        Me.txtDiscountType.IntegralHeight = False
        Me.txtDiscountType.ItemHeight = 15
        Me.txtDiscountType.Location = New System.Drawing.Point(166, 117)
        Me.txtDiscountType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountType.MaxDropDownItems = 7
        Me.txtDiscountType.Name = "txtDiscountType"
        Me.txtDiscountType.Size = New System.Drawing.Size(208, 23)
        Me.txtDiscountType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(86, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 413
        Me.Label1.Text = "Select Discount type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(78, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 21)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Total Amount"
        '
        'txtTotalOnScreen
        '
        Me.txtTotalOnScreen.BackColor = System.Drawing.Color.Gold
        Me.txtTotalOnScreen.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtTotalOnScreen.ForeColor = System.Drawing.Color.Black
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(189, 49)
        Me.txtTotalOnScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalOnScreen.Name = "txtTotalOnScreen"
        Me.txtTotalOnScreen.ReadOnly = True
        Me.txtTotalOnScreen.Size = New System.Drawing.Size(185, 34)
        Me.txtTotalOnScreen.TabIndex = 415
        Me.txtTotalOnScreen.Text = "0.00"
        Me.txtTotalOnScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTransaction
        '
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(127, 29)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(247, 15)
        Me.lblTransaction.TabIndex = 414
        Me.lblTransaction.Text = "Reference # 1000010-105"
        Me.lblTransaction.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(33, 264)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(80, 22)
        Me.productid.TabIndex = 417
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'txtDiscountRate
        '
        Me.txtDiscountRate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDiscountRate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountRate.Location = New System.Drawing.Point(89, 117)
        Me.txtDiscountRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.ReadOnly = True
        Me.txtDiscountRate.Size = New System.Drawing.Size(73, 22)
        Me.txtDiscountRate.TabIndex = 418
        Me.txtDiscountRate.Text = "0.00"
        Me.txtDiscountRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(33, 238)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(80, 22)
        Me.txtBatchcode.TabIndex = 419
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'txtDiscountedAmount
        '
        Me.txtDiscountedAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscountedAmount.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDiscountedAmount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountedAmount.Location = New System.Drawing.Point(212, 144)
        Me.txtDiscountedAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountedAmount.Name = "txtDiscountedAmount"
        Me.txtDiscountedAmount.Size = New System.Drawing.Size(162, 27)
        Me.txtDiscountedAmount.TabIndex = 1
        Me.txtDiscountedAmount.Text = "0.00"
        Me.txtDiscountedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(91, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 421
        Me.Label2.Text = "Discounted Amount"
        '
        'frmPOSDiscount
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(459, 265)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiscountedAmount)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiscountType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountRate As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
