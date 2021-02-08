<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSAttendingPersonnel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSAttendingPersonnel))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.txtSalesPerson = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salesid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Enabled = False
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(117, 84)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(268, 44)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm and Process Item"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(376, 402)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Size = New System.Drawing.Size(57, 22)
        Me.txtBatchcode.TabIndex = 406
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'txtSalesPerson
        '
        Me.txtSalesPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSalesPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtSalesPerson.DropDownHeight = 130
        Me.txtSalesPerson.Font = New System.Drawing.Font("Segoe UI", 11.65!)
        Me.txtSalesPerson.ForeColor = System.Drawing.Color.Black
        Me.txtSalesPerson.FormattingEnabled = True
        Me.txtSalesPerson.IntegralHeight = False
        Me.txtSalesPerson.ItemHeight = 21
        Me.txtSalesPerson.Location = New System.Drawing.Point(66, 45)
        Me.txtSalesPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesPerson.MaxDropDownItems = 7
        Me.txtSalesPerson.Name = "txtSalesPerson"
        Me.txtSalesPerson.Size = New System.Drawing.Size(371, 29)
        Me.txtSalesPerson.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(60, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 19)
        Me.Label1.TabIndex = 414
        Me.Label1.Text = "Please enter personnel incharge name to validate transaction"
        '
        'salesid
        '
        Me.salesid.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.salesid.ForeColor = System.Drawing.Color.Black
        Me.salesid.Location = New System.Drawing.Point(426, 97)
        Me.salesid.Margin = New System.Windows.Forms.Padding(5)
        Me.salesid.Name = "salesid"
        Me.salesid.Size = New System.Drawing.Size(57, 22)
        Me.salesid.TabIndex = 415
        Me.salesid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.salesid.Visible = False
        '
        'frmPOSAttendingPersonnel
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(508, 150)
        Me.Controls.Add(Me.salesid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSalesPerson)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSAttendingPersonnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personnel Incharge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents salesid As System.Windows.Forms.TextBox
End Class
