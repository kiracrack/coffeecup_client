<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCharges
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCharges))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtDiscountType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalOnScreen = New System.Windows.Forms.TextBox()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtDiscountRate = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtTotalCharges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(254, 180)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(162, 38)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtDiscountType
        '
        Me.txtDiscountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDiscountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDiscountType.DropDownHeight = 130
        Me.txtDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDiscountType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDiscountType.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountType.FormattingEnabled = True
        Me.txtDiscountType.IntegralHeight = False
        Me.txtDiscountType.ItemHeight = 20
        Me.txtDiscountType.Location = New System.Drawing.Point(166, 116)
        Me.txtDiscountType.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountType.MaxDropDownItems = 7
        Me.txtDiscountType.Name = "txtDiscountType"
        Me.txtDiscountType.Size = New System.Drawing.Size(250, 28)
        Me.txtDiscountType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(167, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 413
        Me.Label1.Text = "Select Charges type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(120, 56)
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
        Me.txtTotalOnScreen.Location = New System.Drawing.Point(231, 49)
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
        Me.lblTransaction.Location = New System.Drawing.Point(169, 29)
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
        Me.productid.Location = New System.Drawing.Point(33, 297)
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
        Me.txtDiscountRate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtDiscountRate.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountRate.Location = New System.Drawing.Point(89, 116)
        Me.txtDiscountRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscountRate.Name = "txtDiscountRate"
        Me.txtDiscountRate.ReadOnly = True
        Me.txtDiscountRate.Size = New System.Drawing.Size(73, 27)
        Me.txtDiscountRate.TabIndex = 418
        Me.txtDiscountRate.Text = "0.00"
        Me.txtDiscountRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(33, 271)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(80, 22)
        Me.txtBatchcode.TabIndex = 419
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'txtTotalCharges
        '
        Me.txtTotalCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCharges.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtTotalCharges.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCharges.Location = New System.Drawing.Point(254, 149)
        Me.txtTotalCharges.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCharges.Name = "txtTotalCharges"
        Me.txtTotalCharges.Size = New System.Drawing.Size(162, 27)
        Me.txtTotalCharges.TabIndex = 1
        Me.txtTotalCharges.Text = "0.00"
        Me.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(169, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 421
        Me.Label2.Text = "Total Charges"
        '
        'frmPOSCharges
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(502, 245)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalCharges)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.txtDiscountRate)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalOnScreen)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiscountType)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Charges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtDiscountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalOnScreen As System.Windows.Forms.TextBox
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountRate As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
