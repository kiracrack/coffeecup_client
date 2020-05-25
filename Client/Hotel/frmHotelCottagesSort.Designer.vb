<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCottagesSort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCottagesSort))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(154, 9)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(60, 30)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "OK"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
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
        'txtNumber
        '
        Me.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Location = New System.Drawing.Point(96, 9)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(55, 29)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.Text = "0"
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Sort Order"
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
        'frmHotelCottagesSort
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(260, 51)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelCottagesSort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
End Class
