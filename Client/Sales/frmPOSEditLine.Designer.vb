<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSEditLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSEditLine))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOriginalQuantity = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.txtBatchCode = New System.Windows.Forms.TextBox()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.ckContractMode = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(210, 129)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(162, 38)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Change"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtCompanyName
        '
        Me.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(14, 12)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(358, 27)
        Me.txtCompanyName.TabIndex = 100
        '
        'txtQuantity
        '
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(210, 43)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(162, 27)
        Me.txtQuantity.TabIndex = 0
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmount
        '
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(210, 101)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(162, 27)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(151, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 401
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(171, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Total"
        '
        'txtOriginalQuantity
        '
        Me.txtOriginalQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOriginalQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOriginalQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtOriginalQuantity.Location = New System.Drawing.Point(14, 241)
        Me.txtOriginalQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOriginalQuantity.Name = "txtOriginalQuantity"
        Me.txtOriginalQuantity.Size = New System.Drawing.Size(43, 23)
        Me.txtOriginalQuantity.TabIndex = 403
        Me.txtOriginalQuantity.Text = "1"
        Me.txtOriginalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOriginalQuantity.Visible = False
        '
        'trnid
        '
        Me.trnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(61, 241)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(38, 23)
        Me.trnid.TabIndex = 404
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'txtSellPrice
        '
        Me.txtSellPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSellPrice.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSellPrice.ForeColor = System.Drawing.Color.Black
        Me.txtSellPrice.Location = New System.Drawing.Point(210, 72)
        Me.txtSellPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.ReadOnly = True
        Me.txtSellPrice.Size = New System.Drawing.Size(162, 27)
        Me.txtSellPrice.TabIndex = 1
        Me.txtSellPrice.Text = "0.00"
        Me.txtSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(110, 241)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(38, 23)
        Me.mode.TabIndex = 406
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'txtBarCode
        '
        Me.txtBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBarCode.ForeColor = System.Drawing.Color.Black
        Me.txtBarCode.Location = New System.Drawing.Point(15, 215)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(43, 23)
        Me.txtBarCode.TabIndex = 407
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBarCode.Visible = False
        '
        'txtBatchCode
        '
        Me.txtBatchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBatchCode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchCode.Location = New System.Drawing.Point(61, 215)
        Me.txtBatchCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchCode.Name = "txtBatchCode"
        Me.txtBatchCode.Size = New System.Drawing.Size(43, 23)
        Me.txtBatchCode.TabIndex = 408
        Me.txtBatchCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchCode.Visible = False
        '
        'cifid
        '
        Me.cifid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(110, 215)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.Size = New System.Drawing.Size(43, 23)
        Me.cifid.TabIndex = 409
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'ckContractMode
        '
        Me.ckContractMode.AutoSize = True
        Me.ckContractMode.Location = New System.Drawing.Point(15, 191)
        Me.ckContractMode.Name = "ckContractMode"
        Me.ckContractMode.Size = New System.Drawing.Size(96, 17)
        Me.ckContractMode.TabIndex = 410
        Me.ckContractMode.Text = "Contract Mode"
        Me.ckContractMode.UseVisualStyleBackColor = True
        Me.ckContractMode.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(148, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 411
        Me.Label4.Text = "Unit Cost"
        '
        'frmPOSEditLine
        '
        Me.AcceptButton = Me.cmdConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(387, 176)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ckContractMode)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.txtBatchCode)
        Me.Controls.Add(Me.txtBarCode)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtSellPrice)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtOriginalQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.cmdConfirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSEditLine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalQuantity As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents txtSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchCode As System.Windows.Forms.TextBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents ckContractMode As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
