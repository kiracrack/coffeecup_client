<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrderView
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MyDataGridView_Particular = New System.Windows.Forms.DataGridView()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.ponumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabParticular = New System.Windows.Forms.TabPage()
        Me.tabApprovalHistory = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Approval = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtApprovingLEvel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.txtVerifiedAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabParticular.SuspendLayout()
        Me.tabApprovalHistory.SuspendLayout()
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView_Particular
        '
        Me.MyDataGridView_Particular.AllowUserToDeleteRows = False
        Me.MyDataGridView_Particular.AllowUserToResizeColumns = False
        Me.MyDataGridView_Particular.AllowUserToResizeRows = False
        Me.MyDataGridView_Particular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Particular.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Particular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Particular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Particular.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Particular.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Particular.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Particular.MultiSelect = False
        Me.MyDataGridView_Particular.Name = "MyDataGridView_Particular"
        Me.MyDataGridView_Particular.ReadOnly = True
        Me.MyDataGridView_Particular.RowHeadersVisible = False
        Me.MyDataGridView_Particular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.MyDataGridView_Particular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Particular.Size = New System.Drawing.Size(698, 400)
        Me.MyDataGridView_Particular.TabIndex = 342
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.LightSeaGreen
        Me.txtStatus.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtStatus.Location = New System.Drawing.Point(95, 6)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(209, 31)
        Me.txtStatus.TabIndex = 343
        Me.txtStatus.Text = "FOR APPROVAL"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ponumber
        '
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ponumber.Location = New System.Drawing.Point(95, 40)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.ReadOnly = True
        Me.ponumber.Size = New System.Drawing.Size(209, 23)
        Me.ponumber.TabIndex = 345
        Me.ponumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Reference No"
        '
        'txtoffice
        '
        Me.txtoffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtoffice.Location = New System.Drawing.Point(95, 66)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.ReadOnly = True
        Me.txtoffice.Size = New System.Drawing.Size(209, 23)
        Me.txtoffice.TabIndex = 347
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Branch"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSupplier.Location = New System.Drawing.Point(95, 118)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(209, 23)
        Me.txtSupplier.TabIndex = 355
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(39, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "Supplier"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAttachment.Location = New System.Drawing.Point(137, 303)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(168, 30)
        Me.cmdAttachment.TabIndex = 365
        Me.cmdAttachment.Text = "Download Purchase Order"
        Me.cmdAttachment.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabParticular)
        Me.TabControl1.Controls.Add(Me.tabApprovalHistory)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(309, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(712, 434)
        Me.TabControl1.TabIndex = 0
        '
        'tabParticular
        '
        Me.tabParticular.Controls.Add(Me.MyDataGridView_Particular)
        Me.tabParticular.Location = New System.Drawing.Point(4, 24)
        Me.tabParticular.Name = "tabParticular"
        Me.tabParticular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParticular.Size = New System.Drawing.Size(704, 406)
        Me.tabParticular.TabIndex = 0
        Me.tabParticular.Text = "Particular Entries"
        Me.tabParticular.UseVisualStyleBackColor = True
        '
        'tabApprovalHistory
        '
        Me.tabApprovalHistory.Controls.Add(Me.MyDataGridView_Approval)
        Me.tabApprovalHistory.Location = New System.Drawing.Point(4, 24)
        Me.tabApprovalHistory.Name = "tabApprovalHistory"
        Me.tabApprovalHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabApprovalHistory.Size = New System.Drawing.Size(704, 406)
        Me.tabApprovalHistory.TabIndex = 1
        Me.tabApprovalHistory.Text = "Approval History"
        Me.tabApprovalHistory.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Approval
        '
        Me.MyDataGridView_Approval.AllowUserToAddRows = False
        Me.MyDataGridView_Approval.AllowUserToDeleteRows = False
        Me.MyDataGridView_Approval.AllowUserToResizeColumns = False
        Me.MyDataGridView_Approval.AllowUserToResizeRows = False
        Me.MyDataGridView_Approval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Approval.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Approval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Approval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Approval.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView_Approval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Approval.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Approval.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Approval.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Approval.Name = "MyDataGridView_Approval"
        Me.MyDataGridView_Approval.ReadOnly = True
        Me.MyDataGridView_Approval.RowHeadersVisible = False
        Me.MyDataGridView_Approval.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Approval.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.MyDataGridView_Approval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Approval.Size = New System.Drawing.Size(698, 400)
        Me.MyDataGridView_Approval.TabIndex = 343
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditItemToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(192, 54)
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditItemToolStripMenuItem.Text = "Print Approval History"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(191, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtApprovingLEvel
        '
        Me.txtApprovingLEvel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtApprovingLEvel.Location = New System.Drawing.Point(95, 92)
        Me.txtApprovingLEvel.Name = "txtApprovingLEvel"
        Me.txtApprovingLEvel.ReadOnly = True
        Me.txtApprovingLEvel.Size = New System.Drawing.Size(209, 23)
        Me.txtApprovingLEvel.TabIndex = 370
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 371
        Me.Label7.Text = "Request Level"
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.pid.Location = New System.Drawing.Point(270, 379)
        Me.pid.Name = "pid"
        Me.pid.ReadOnly = True
        Me.pid.Size = New System.Drawing.Size(33, 23)
        Me.pid.TabIndex = 346
        Me.pid.Visible = False
        '
        'txtVerifiedAmount
        '
        Me.txtVerifiedAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVerifiedAmount.BackColor = System.Drawing.Color.Yellow
        Me.txtVerifiedAmount.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtVerifiedAmount.ForeColor = System.Drawing.Color.Black
        Me.txtVerifiedAmount.Location = New System.Drawing.Point(138, 275)
        Me.txtVerifiedAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifiedAmount.Name = "txtVerifiedAmount"
        Me.txtVerifiedAmount.ReadOnly = True
        Me.txtVerifiedAmount.Size = New System.Drawing.Size(166, 26)
        Me.txtVerifiedAmount.TabIndex = 423
        Me.txtVerifiedAmount.Text = "0.00"
        Me.txtVerifiedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(13, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 424
        Me.Label8.Text = "Verified Total Payable"
        '
        'txtDiscount
        '
        Me.txtDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(138, 250)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(166, 22)
        Me.txtDiscount.TabIndex = 416
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(78, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 422
        Me.Label4.Text = "Discount"
        '
        'txtCharges
        '
        Me.txtCharges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCharges.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCharges.ForeColor = System.Drawing.Color.Black
        Me.txtCharges.Location = New System.Drawing.Point(138, 225)
        Me.txtCharges.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.ReadOnly = True
        Me.txtCharges.Size = New System.Drawing.Size(166, 22)
        Me.txtCharges.TabIndex = 415
        Me.txtCharges.Text = "0.00"
        Me.txtCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(82, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Charges"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(65, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 419
        Me.Label10.Text = "Invoice No."
        '
        'txtVat
        '
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtVat.ForeColor = System.Drawing.Color.Black
        Me.txtVat.Location = New System.Drawing.Point(138, 200)
        Me.txtVat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(166, 22)
        Me.txtVat.TabIndex = 414
        Me.txtVat.Text = "0.00"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(105, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 15)
        Me.Label11.TabIndex = 420
        Me.Label11.Text = "VAT"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(138, 150)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.ReadOnly = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(166, 22)
        Me.txtInvoiceNumber.TabIndex = 413
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Location = New System.Drawing.Point(138, 175)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(166, 22)
        Me.txtTotalAmount.TabIndex = 418
        Me.txtTotalAmount.Text = "0.00"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(76, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 417
        Me.Label12.Text = "Sub Total"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(62, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 425
        Me.Label3.Text = "Attachment"
        '
        'frmPurchaseOrderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1028, 451)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVerifiedAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtApprovingLEvel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1044, 490)
        Me.Name = "frmPurchaseOrderView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Status"
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabParticular.ResumeLayout(False)
        Me.tabApprovalHistory.ResumeLayout(False)
        CType(Me.MyDataGridView_Approval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView_Particular As System.Windows.Forms.DataGridView
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents ponumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabParticular As System.Windows.Forms.TabPage
    Friend WithEvents tabApprovalHistory As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Approval As System.Windows.Forms.DataGridView
    Friend WithEvents txtApprovingLEvel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pid As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtVerifiedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
