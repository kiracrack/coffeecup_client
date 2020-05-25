<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferRequestCancelled
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferRequestCancelled))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.Batchcode = New System.Windows.Forms.TextBox()
        Me.txtdetails = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bid = New System.Windows.Forms.TextBox()
        Me.cmdreset = New System.Windows.Forms.Button()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.Red
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ForeColor = System.Drawing.Color.White
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(208, 91)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(135, 30)
        Me.cmdset.TabIndex = 4
        Me.cmdset.Text = "Confirm Cancel"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'productid
        '
        Me.productid.Enabled = False
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(210, 326)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(50, 23)
        Me.productid.TabIndex = 270
        '
        'Batchcode
        '
        Me.Batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Batchcode.ForeColor = System.Drawing.Color.Black
        Me.Batchcode.Location = New System.Drawing.Point(125, 9)
        Me.Batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.Batchcode.Name = "Batchcode"
        Me.Batchcode.ReadOnly = True
        Me.Batchcode.Size = New System.Drawing.Size(292, 22)
        Me.Batchcode.TabIndex = 271
        Me.Batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdetails
        '
        Me.txtdetails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdetails.ForeColor = System.Drawing.Color.Black
        Me.txtdetails.Location = New System.Drawing.Point(125, 35)
        Me.txtdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdetails.Multiline = True
        Me.txtdetails.Name = "txtdetails"
        Me.txtdetails.Size = New System.Drawing.Size(292, 53)
        Me.txtdetails.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(12, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Reference Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(26, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 15)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Cancel Remarks"
        '
        'bid
        '
        Me.bid.Enabled = False
        Me.bid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bid.ForeColor = System.Drawing.Color.Black
        Me.bid.Location = New System.Drawing.Point(158, 326)
        Me.bid.Margin = New System.Windows.Forms.Padding(4)
        Me.bid.Name = "bid"
        Me.bid.ReadOnly = True
        Me.bid.Size = New System.Drawing.Size(50, 23)
        Me.bid.TabIndex = 370
        '
        'cmdreset
        '
        Me.cmdreset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdreset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdreset.Location = New System.Drawing.Point(345, 91)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Size = New System.Drawing.Size(72, 30)
        Me.cmdreset.TabIndex = 5
        Me.cmdreset.Text = "Exit"
        Me.cmdreset.UseVisualStyleBackColor = True
        '
        'trnid
        '
        Me.trnid.Enabled = False
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(263, 326)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(50, 23)
        Me.trnid.TabIndex = 372
        '
        'frmTransferCancelled
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(441, 130)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.bid)
        Me.Controls.Add(Me.Batchcode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtdetails)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.cmdreset)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransferCancelled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancellation Confirmation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdetails As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Batchcode As System.Windows.Forms.TextBox
    Friend WithEvents bid As System.Windows.Forms.TextBox
    Friend WithEvents cmdreset As System.Windows.Forms.Button
    Friend WithEvents trnid As System.Windows.Forms.TextBox
End Class
