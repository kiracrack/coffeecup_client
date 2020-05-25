<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicNewPackage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicNewPackage))
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.clinicid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBatchcodeRef = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.salestrnid = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(156, 232)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(200, 34)
        Me.cmdProceed.TabIndex = 6
        Me.cmdProceed.Text = "Confirm Save"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'txtReference
        '
        Me.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReference.ForeColor = System.Drawing.Color.Black
        Me.txtReference.Location = New System.Drawing.Point(156, 39)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ReadOnly = True
        Me.txtReference.Size = New System.Drawing.Size(130, 23)
        Me.txtReference.TabIndex = 99
        Me.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(71, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 425
        Me.Label7.Text = "Transaction #"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(156, 175)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(287, 54)
        Me.txtRemarks.TabIndex = 4
        Me.txtRemarks.Text = "Enter service remarks.."
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(510, 134)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(49, 22)
        Me.cifid.TabIndex = 447
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(614, 101)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(49, 22)
        Me.mode.TabIndex = 1002
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clinicid
        '
        Me.clinicid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.clinicid.ForeColor = System.Drawing.Color.Black
        Me.clinicid.Location = New System.Drawing.Point(614, 73)
        Me.clinicid.Margin = New System.Windows.Forms.Padding(4)
        Me.clinicid.Name = "clinicid"
        Me.clinicid.ReadOnly = True
        Me.clinicid.Size = New System.Drawing.Size(49, 22)
        Me.clinicid.TabIndex = 1008
        Me.clinicid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clinicid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(53, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 1012
        Me.Label5.Text = "Product Package"
        '
        'txtProduct
        '
        Me.txtProduct.DropDownHeight = 130
        Me.txtProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProduct.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtProduct.ForeColor = System.Drawing.Color.Black
        Me.txtProduct.FormattingEnabled = True
        Me.txtProduct.IntegralHeight = False
        Me.txtProduct.ItemHeight = 15
        Me.txtProduct.Location = New System.Drawing.Point(156, 123)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.MaxDropDownItems = 7
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(262, 23)
        Me.txtProduct.TabIndex = 1011
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(59, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 1010
        Me.Label3.Text = "Reference Code"
        '
        'txtBatchcodeRef
        '
        Me.txtBatchcodeRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchcodeRef.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBatchcodeRef.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcodeRef.Location = New System.Drawing.Point(156, 65)
        Me.txtBatchcodeRef.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcodeRef.Name = "txtBatchcodeRef"
        Me.txtBatchcodeRef.Size = New System.Drawing.Size(200, 29)
        Me.txtBatchcodeRef.TabIndex = 1009
        Me.txtBatchcodeRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(156, 149)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtTotal.TabIndex = 1013
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(98, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 1014
        Me.Label4.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(70, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 25)
        Me.Label1.TabIndex = 1015
        Me.Label1.Text = "Package Information"
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(526, 40)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        Me.batchcode.Size = New System.Drawing.Size(49, 22)
        Me.batchcode.TabIndex = 1016
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'salestrnid
        '
        Me.salestrnid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.salestrnid.ForeColor = System.Drawing.Color.Black
        Me.salestrnid.Location = New System.Drawing.Point(510, 164)
        Me.salestrnid.Margin = New System.Windows.Forms.Padding(4)
        Me.salestrnid.Name = "salestrnid"
        Me.salestrnid.ReadOnly = True
        Me.salestrnid.Size = New System.Drawing.Size(49, 22)
        Me.salestrnid.TabIndex = 1017
        Me.salestrnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.salestrnid.Visible = False
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(526, 73)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(49, 22)
        Me.trnid.TabIndex = 1018
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'txtClientName
        '
        Me.txtClientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtClientName.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Location = New System.Drawing.Point(156, 97)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(262, 23)
        Me.txtClientName.TabIndex = 1019
        Me.txtClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(78, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 1020
        Me.Label2.Text = "Client name"
        '
        'frmClinicNewPackage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(588, 289)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.salestrnid)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBatchcodeRef)
        Me.Controls.Add(Me.clinicid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdProceed)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClinicNewPackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinic Package Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents clinicid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBatchcodeRef As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents salestrnid As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
