<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelDiscount))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(158, 125)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(132, 30)
        Me.cmdConfirmPayment.TabIndex = 3
        Me.cmdConfirmPayment.Text = "Confirm OK"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'folioid
        '
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(63, 250)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(57, 22)
        Me.folioid.TabIndex = 410
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.folioid.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(158, 72)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(232, 50)
        Me.txtRemarks.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(100, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Remarks"
        '
        'txtDiscount
        '
        Me.txtDiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(158, 47)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(132, 22)
        Me.txtDiscount.TabIndex = 0
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoomNo
        '
        Me.txtRoomNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoomNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNo.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNo.Location = New System.Drawing.Point(158, 23)
        Me.txtRoomNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.ReadOnly = True
        Me.txtRoomNo.Size = New System.Drawing.Size(132, 22)
        Me.txtRoomNo.TabIndex = 512
        Me.txtRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 513
        Me.Label1.Text = "Discount for Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(51, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 514
        Me.Label2.Text = "Amount Discount"
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(130, 249)
        Me.mode.Margin = New System.Windows.Forms.Padding(5)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(68, 23)
        Me.mode.TabIndex = 515
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.mode.Visible = False
        '
        'trnid
        '
        Me.trnid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(208, 250)
        Me.trnid.Margin = New System.Windows.Forms.Padding(5)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(68, 23)
        Me.trnid.TabIndex = 516
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.trnid.Visible = False
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(277, 249)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(57, 22)
        Me.foliono.TabIndex = 517
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.foliono.Visible = False
        '
        'frmHotelDiscount
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(450, 175)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRoomNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flexible Discount Posting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
End Class
