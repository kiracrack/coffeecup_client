<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoViewServices
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoViewServices))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.cmdAddTransaction = New System.Windows.Forms.Button()
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
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.cmdClosedService = New System.Windows.Forms.Button()
        Me.tabProducts = New System.Windows.Forms.TabPage()
        Me.tabJobOrder = New System.Windows.Forms.TabPage()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txtOdoMeter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMechanics = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabJobOrder.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
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
        'cmdAddTransaction
        '
        Me.cmdAddTransaction.BackColor = System.Drawing.Color.Khaki
        Me.cmdAddTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAddTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddTransaction.Location = New System.Drawing.Point(23, 457)
        Me.cmdAddTransaction.Name = "cmdAddTransaction"
        Me.cmdAddTransaction.Size = New System.Drawing.Size(133, 34)
        Me.cmdAddTransaction.TabIndex = 5
        Me.cmdAddTransaction.Text = "Add Transaction"
        Me.cmdAddTransaction.UseVisualStyleBackColor = False
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
        Me.txtReference.ReadOnly = True
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
        Me.txtRecomendation.Location = New System.Drawing.Point(23, 254)
        Me.txtRecomendation.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRecomendation.Multiline = True
        Me.txtRecomendation.Name = "txtRecomendation"
        Me.txtRecomendation.ReadOnly = True
        Me.txtRecomendation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecomendation.Size = New System.Drawing.Size(418, 196)
        Me.txtRecomendation.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(64, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 25)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "Service Information"
        '
        'txtCarModel
        '
        Me.txtCarModel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCarModel.ForeColor = System.Drawing.Color.Black
        Me.txtCarModel.Location = New System.Drawing.Point(157, 147)
        Me.txtCarModel.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCarModel.Name = "txtCarModel"
        Me.txtCarModel.ReadOnly = True
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
        Me.txtPlateNumber.ReadOnly = True
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
        Me.cmdPrintAgreement.Location = New System.Drawing.Point(159, 457)
        Me.cmdPrintAgreement.Name = "cmdPrintAgreement"
        Me.cmdPrintAgreement.Size = New System.Drawing.Size(148, 34)
        Me.cmdPrintAgreement.TabIndex = 4
        Me.cmdPrintAgreement.Text = "Print Final Agreement"
        Me.cmdPrintAgreement.UseVisualStyleBackColor = False
        '
        'txtClient
        '
        Me.txtClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClient.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtClient.ForeColor = System.Drawing.Color.Black
        Me.txtClient.Location = New System.Drawing.Point(157, 69)
        Me.txtClient.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(242, 23)
        Me.txtClient.TabIndex = 1003
        '
        'cmdClosedService
        '
        Me.cmdClosedService.BackColor = System.Drawing.Color.Khaki
        Me.cmdClosedService.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClosedService.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClosedService.Location = New System.Drawing.Point(308, 457)
        Me.cmdClosedService.Name = "cmdClosedService"
        Me.cmdClosedService.Size = New System.Drawing.Size(133, 34)
        Me.cmdClosedService.TabIndex = 1005
        Me.cmdClosedService.Text = "Close Service"
        Me.cmdClosedService.UseVisualStyleBackColor = False
        '
        'tabProducts
        '
        Me.tabProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Size = New System.Drawing.Size(556, 419)
        Me.tabProducts.TabIndex = 0
        Me.tabProducts.Text = "Parts Installed Transactions"
        Me.tabProducts.UseVisualStyleBackColor = True
        '
        'tabJobOrder
        '
        Me.tabJobOrder.Controls.Add(Me.cifid)
        Me.tabJobOrder.Controls.Add(Me.MyDataGridView)
        Me.tabJobOrder.Location = New System.Drawing.Point(4, 24)
        Me.tabJobOrder.Name = "tabJobOrder"
        Me.tabJobOrder.Size = New System.Drawing.Size(556, 453)
        Me.tabJobOrder.TabIndex = 3
        Me.tabJobOrder.Text = "Job Order Transactions"
        Me.tabJobOrder.UseVisualStyleBackColor = True
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(91, 132)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(49, 22)
        Me.cifid.TabIndex = 447
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(556, 453)
        Me.MyDataGridView.TabIndex = 393
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabJobOrder)
        Me.TabControl1.Controls.Add(Me.tabProducts)
        Me.TabControl1.Location = New System.Drawing.Point(449, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(564, 481)
        Me.TabControl1.TabIndex = 1004
        '
        'txtOdoMeter
        '
        Me.txtOdoMeter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOdoMeter.ForeColor = System.Drawing.Color.Black
        Me.txtOdoMeter.Location = New System.Drawing.Point(157, 199)
        Me.txtOdoMeter.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOdoMeter.Name = "txtOdoMeter"
        Me.txtOdoMeter.ReadOnly = True
        Me.txtOdoMeter.Size = New System.Drawing.Size(130, 23)
        Me.txtOdoMeter.TabIndex = 1006
        Me.txtOdoMeter.Text = "0"
        Me.txtOdoMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(102, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 1007
        Me.Label5.Text = "Mileage"
        '
        'txtMechanics
        '
        Me.txtMechanics.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMechanics.ForeColor = System.Drawing.Color.Black
        Me.txtMechanics.Location = New System.Drawing.Point(157, 225)
        Me.txtMechanics.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMechanics.Name = "txtMechanics"
        Me.txtMechanics.ReadOnly = True
        Me.txtMechanics.Size = New System.Drawing.Size(242, 23)
        Me.txtMechanics.TabIndex = 1008
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(31, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 1009
        Me.Label6.Text = "Attending Mechanics"
        '
        'frmAutoViewServices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 504)
        Me.Controls.Add(Me.txtMechanics)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOdoMeter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdClosedService)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtClient)
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
        Me.Controls.Add(Me.cmdAddTransaction)
        Me.Controls.Add(Me.lblTransaction)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1041, 484)
        Me.Name = "frmAutoViewServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information"
        Me.tabJobOrder.ResumeLayout(False)
        Me.tabJobOrder.PerformLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents cmdAddTransaction As System.Windows.Forms.Button
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
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents cmdClosedService As System.Windows.Forms.Button
    Friend WithEvents tabProducts As System.Windows.Forms.TabPage
    Friend WithEvents tabJobOrder As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtOdoMeter As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMechanics As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
