<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelCancelReservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelCancelReservation))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuest = New System.Windows.Forms.TextBox()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(244, 109)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(178, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm Cancel"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(74, 41)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(348, 61)
        Me.txtRemarks.TabIndex = 1
        Me.txtRemarks.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Guest"
        '
        'txtGuest
        '
        Me.txtGuest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.Location = New System.Drawing.Point(159, 12)
        Me.txtGuest.Margin = New System.Windows.Forms.Padding(5)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.Size = New System.Drawing.Size(263, 25)
        Me.txtGuest.TabIndex = 411
        Me.txtGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foliono
        '
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(74, 12)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.ReadOnly = True
        Me.foliono.Size = New System.Drawing.Size(82, 25)
        Me.foliono.TabIndex = 412
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 414
        Me.Label2.Text = "Remarks"
        '
        'frmHotelCancelReservation
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(452, 157)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelCancelReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGuest As System.Windows.Forms.TextBox
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
