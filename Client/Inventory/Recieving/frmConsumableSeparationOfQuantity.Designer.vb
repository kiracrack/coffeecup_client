<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumableSeparationOfQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsumableSeparationOfQuantity))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.officeid_to = New System.Windows.Forms.TextBox()
        Me.officeid_from = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.ponumber = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.BackColor = System.Drawing.Color.White
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(167, 128)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(141, 30)
        Me.cmdset.TabIndex = 7
        Me.cmdset.Text = "Confirm Separate"
        Me.cmdset.UseVisualStyleBackColor = False
        '
        'officeid_to
        '
        Me.officeid_to.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid_to.ForeColor = System.Drawing.Color.Black
        Me.officeid_to.Location = New System.Drawing.Point(684, 224)
        Me.officeid_to.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid_to.Name = "officeid_to"
        Me.officeid_to.Size = New System.Drawing.Size(69, 22)
        Me.officeid_to.TabIndex = 415
        Me.officeid_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid_to.Visible = False
        '
        'officeid_from
        '
        Me.officeid_from.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid_from.ForeColor = System.Drawing.Color.Black
        Me.officeid_from.Location = New System.Drawing.Point(607, 224)
        Me.officeid_from.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid_from.Name = "officeid_from"
        Me.officeid_from.Size = New System.Drawing.Size(69, 22)
        Me.officeid_from.TabIndex = 419
        Me.officeid_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid_from.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(167, 22)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(91, 24)
        Me.txtQuantity.TabIndex = 420
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(58, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Available Quantity"
        '
        'txtNewQuantity
        '
        Me.txtNewQuantity.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtNewQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtNewQuantity.Location = New System.Drawing.Point(167, 49)
        Me.txtNewQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewQuantity.Name = "txtNewQuantity"
        Me.txtNewQuantity.Size = New System.Drawing.Size(91, 24)
        Me.txtNewQuantity.TabIndex = 0
        Me.txtNewQuantity.Text = "1"
        Me.txtNewQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(61, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 423
        Me.Label3.Text = "Separate Quantity"
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(167, 76)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(141, 24)
        Me.txtUnitCost.TabIndex = 1
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(104, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 425
        Me.Label1.Text = "Unit Cost"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtTotalCost.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCost.Location = New System.Drawing.Point(167, 102)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(141, 24)
        Me.txtTotalCost.TabIndex = 426
        Me.txtTotalCost.Text = "0.00"
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(104, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 427
        Me.Label2.Text = "Total Cost"
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(45, 193)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(61, 24)
        Me.trnid.TabIndex = 428
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'ponumber
        '
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.ponumber.ForeColor = System.Drawing.Color.Black
        Me.ponumber.Location = New System.Drawing.Point(114, 193)
        Me.ponumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(61, 24)
        Me.ponumber.TabIndex = 429
        Me.ponumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ponumber.Visible = False
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(152, 183)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(61, 24)
        Me.productid.TabIndex = 430
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'frmConsumableSeparationOfQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(364, 175)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.officeid_from)
        Me.Controls.Add(Me.officeid_to)
        Me.Controls.Add(Me.cmdset)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsumableSeparationOfQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Separation of Quantity"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents officeid_to As System.Windows.Forms.TextBox
    Friend WithEvents officeid_from As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNewQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents ponumber As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
End Class
