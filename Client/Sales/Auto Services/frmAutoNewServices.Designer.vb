<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoNewServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoNewServices))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRecomendation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCarModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPlateNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdPrintAgreement = New System.Windows.Forms.Button()
        Me.txtClient = New System.Windows.Forms.ComboBox()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtOdoMeter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdNewClient = New System.Windows.Forms.Button()
        Me.txtMechanics = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(47, 99)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(104, 15)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Complete Address"
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(232, 449)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(133, 34)
        Me.cmdProceed.TabIndex = 6
        Me.cmdProceed.Text = "Confirm Save"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(157, 95)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(242, 23)
        Me.txtAddress.TabIndex = 100
        '
        'txtContactNumber
        '
        Me.txtContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtContactNumber.Location = New System.Drawing.Point(157, 121)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(130, 23)
        Me.txtContactNumber.TabIndex = 1001
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(55, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "Contact Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(58, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 415
        Me.Label2.Text = "Select Customer"
        '
        'txtReference
        '
        Me.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReference.ForeColor = System.Drawing.Color.Black
        Me.txtReference.Location = New System.Drawing.Point(157, 43)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(130, 23)
        Me.txtReference.TabIndex = 99
        Me.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(73, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 425
        Me.Label7.Text = "Transaction #"
        '
        'txtRecomendation
        '
        Me.txtRecomendation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRecomendation.ForeColor = System.Drawing.Color.Black
        Me.txtRecomendation.Location = New System.Drawing.Point(23, 255)
        Me.txtRecomendation.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRecomendation.Multiline = True
        Me.txtRecomendation.Name = "txtRecomendation"
        Me.txtRecomendation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecomendation.Size = New System.Drawing.Size(418, 186)
        Me.txtRecomendation.TabIndex = 4
        Me.txtRecomendation.Text = "Enter service recomendation.."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(64, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 25)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "Customer Information"
        '
        'txtCarModel
        '
        Me.txtCarModel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCarModel.ForeColor = System.Drawing.Color.Black
        Me.txtCarModel.Location = New System.Drawing.Point(157, 147)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.Size = New System.Drawing.Size(242, 23)
        Me.txtCarModel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(89, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 442
        Me.Label3.Text = "Car Model"
        '
        'txtPlateNumber
        '
        Me.txtPlateNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPlateNumber.ForeColor = System.Drawing.Color.Black
        Me.txtPlateNumber.Location = New System.Drawing.Point(157, 173)
        Me.txtPlateNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPlateNumber.Name = "txtPlateNumber"
        Me.txtPlateNumber.Size = New System.Drawing.Size(130, 23)
        Me.txtPlateNumber.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(71, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 444
        Me.Label4.Text = "Plate Number"
        '
        'cmdPrintAgreement
        '
        Me.cmdPrintAgreement.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdPrintAgreement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrintAgreement.Location = New System.Drawing.Point(74, 449)
        Me.cmdPrintAgreement.Name = "cmdPrintAgreement"
        Me.cmdPrintAgreement.Size = New System.Drawing.Size(154, 34)
        Me.cmdPrintAgreement.TabIndex = 5
        Me.cmdPrintAgreement.Text = "Print Parking Agreement"
        Me.cmdPrintAgreement.UseVisualStyleBackColor = False
        '
        'txtClient
        '
        Me.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtClient.DropDownHeight = 130
        Me.txtClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtClient.ForeColor = System.Drawing.Color.Black
        Me.txtClient.FormattingEnabled = True
        Me.txtClient.IntegralHeight = False
        Me.txtClient.ItemHeight = 15
        Me.txtClient.Location = New System.Drawing.Point(157, 69)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClient.MaxDropDownItems = 7
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(242, 23)
        Me.txtClient.TabIndex = 0
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(480, 121)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(49, 22)
        Me.cifid.TabIndex = 447
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(483, 101)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(49, 22)
        Me.mode.TabIndex = 1002
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOdoMeter
        '
        Me.txtOdoMeter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOdoMeter.ForeColor = System.Drawing.Color.Black
        Me.txtOdoMeter.Location = New System.Drawing.Point(157, 199)
        Me.txtOdoMeter.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOdoMeter.Name = "txtOdoMeter"
        Me.txtOdoMeter.Size = New System.Drawing.Size(130, 23)
        Me.txtOdoMeter.TabIndex = 3
        Me.txtOdoMeter.Text = "0"
        Me.txtOdoMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(103, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 1004
        Me.Label5.Text = "Mileage   "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdNewClient
        '
        Me.cmdNewClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdNewClient.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNewClient.Location = New System.Drawing.Point(402, 69)
        Me.cmdNewClient.Name = "cmdNewClient"
        Me.cmdNewClient.Size = New System.Drawing.Size(39, 23)
        Me.cmdNewClient.TabIndex = 1005
        Me.cmdNewClient.Text = "..."
        Me.cmdNewClient.UseVisualStyleBackColor = False
        '
        'txtMechanics
        '
        Me.txtMechanics.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMechanics.ForeColor = System.Drawing.Color.Black
        Me.txtMechanics.Location = New System.Drawing.Point(157, 225)
        Me.txtMechanics.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMechanics.Name = "txtMechanics"
        Me.txtMechanics.Size = New System.Drawing.Size(242, 23)
        Me.txtMechanics.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(31, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 1007
        Me.Label6.Text = "Attending Mechanics"
        '
        'frmAutoNewServices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 497)
        Me.Controls.Add(Me.txtMechanics)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdNewClient)
        Me.Controls.Add(Me.txtOdoMeter)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.cifid)
        Me.Controls.Add(Me.cmdPrintAgreement)
        Me.Controls.Add(Me.txtPlateNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCarModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRecomendation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.cmdProceed)
        Me.Controls.Add(Me.lblTransaction)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAutoNewServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRecomendation As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCarModel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintAgreement As System.Windows.Forms.Button
    Friend WithEvents txtClient As System.Windows.Forms.ComboBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtOdoMeter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdNewClient As System.Windows.Forms.Button
    Friend WithEvents txtMechanics As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
