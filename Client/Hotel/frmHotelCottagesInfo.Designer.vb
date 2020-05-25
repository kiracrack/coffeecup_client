<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCottagesInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCottagesInfo))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(39, 51)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(123, 15)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Contact Person Name"
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(167, 102)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(243, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtContactPerson
        '
        Me.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.Location = New System.Drawing.Point(167, 45)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(243, 25)
        Me.txtContactPerson.TabIndex = 0
        Me.txtContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(12, 200)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.Size = New System.Drawing.Size(57, 22)
        Me.trnid.TabIndex = 406
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(167, 74)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(243, 25)
        Me.txtContactNumber.TabIndex = 1
        Me.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(66, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Contact Number"
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(12, 172)
        Me.productid.Margin = New System.Windows.Forms.Padding(5)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(57, 22)
        Me.productid.TabIndex = 410
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'txtProductName
        '
        Me.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(39, 12)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(371, 29)
        Me.txtProductName.TabIndex = 411
        Me.txtProductName.Text = "COTAGE FULLNAME HERE"
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(12, 226)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(57, 22)
        Me.mode.TabIndex = 412
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'frmHotelCottagesCheckIn
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(444, 146)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.lblTransaction)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelCottagesCheckIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check-In Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
End Class
