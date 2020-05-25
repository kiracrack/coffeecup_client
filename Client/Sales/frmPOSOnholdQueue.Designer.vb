<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSOnholdQueue
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSOnholdQueue))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.onholdqueuecode = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(228, 360)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(268, 44)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm Hold Transaction"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(-4, 328)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Size = New System.Drawing.Size(57, 22)
        Me.batchcode.TabIndex = 406
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(246, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 15)
        Me.Label3.TabIndex = 407
        Me.Label3.Text = "Transaction Reference #10001009-1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'onholdqueuecode
        '
        Me.onholdqueuecode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.onholdqueuecode.ForeColor = System.Drawing.Color.Black
        Me.onholdqueuecode.Location = New System.Drawing.Point(63, 328)
        Me.onholdqueuecode.Margin = New System.Windows.Forms.Padding(5)
        Me.onholdqueuecode.Name = "onholdqueuecode"
        Me.onholdqueuecode.Size = New System.Drawing.Size(57, 22)
        Me.onholdqueuecode.TabIndex = 408
        Me.onholdqueuecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.onholdqueuecode.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 31)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(702, 323)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ImageMenu
        '
        Me.ImageMenu.ImageStream = CType(resources.GetObject("ImageMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageMenu.Images.SetKeyName(0, "Table-96.png")
        '
        'frmPOSOnholdQueue
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(726, 415)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.onholdqueuecode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSOnholdQueue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "On Hold Transaction Confirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents onholdqueuecode As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageMenu As System.Windows.Forms.ImageList
End Class
