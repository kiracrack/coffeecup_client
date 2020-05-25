<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedFFE
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivedFFE))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReceiveItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSendOfficialReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmda1 = New System.Windows.Forms.Button()
        Me.txtattached1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ponumber = New System.Windows.Forms.ComboBox()
        Me.txtVerifiedAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.officeid = New System.Windows.Forms.TextBox()
        Me.ckAp = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(8, 54)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(559, 392)
        Me.MyDataGridView.TabIndex = 379
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReceiveItemToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdSendOfficialReceipt, Me.ToolStripMenuItem1})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(189, 76)
        '
        'ReceiveItemToolStripMenuItem
        '
        Me.ReceiveItemToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.box__arrow
        Me.ReceiveItemToolStripMenuItem.Name = "ReceiveItemToolStripMenuItem"
        Me.ReceiveItemToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReceiveItemToolStripMenuItem.Text = "Receive Selected Item"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'cmdSendOfficialReceipt
        '
        Me.cmdSendOfficialReceipt.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__arrow
        Me.cmdSendOfficialReceipt.Name = "cmdSendOfficialReceipt"
        Me.cmdSendOfficialReceipt.Size = New System.Drawing.Size(188, 22)
        Me.cmdSendOfficialReceipt.Text = "Include Item"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.CoffeecupClient.My.Resources.Resources.notebook__backarrow
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem1.Text = "Not Included"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(357, 583)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 30)
        Me.Button1.TabIndex = 380
        Me.Button1.Text = "Close Purchase Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmda1
        '
        Me.cmda1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmda1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmda1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmda1.Location = New System.Drawing.Point(278, 558)
        Me.cmda1.Name = "cmda1"
        Me.cmda1.Size = New System.Drawing.Size(78, 22)
        Me.cmda1.TabIndex = 385
        Me.cmda1.Text = "Browse"
        Me.cmda1.UseCompatibleTextRendering = True
        '
        'txtattached1
        '
        Me.txtattached1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtattached1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtattached1.ForeColor = System.Drawing.Color.Black
        Me.txtattached1.Location = New System.Drawing.Point(359, 558)
        Me.txtattached1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtattached1.Name = "txtattached1"
        Me.txtattached1.ReadOnly = True
        Me.txtattached1.Size = New System.Drawing.Size(209, 22)
        Me.txtattached1.TabIndex = 384
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(255, 540)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 15)
        Me.Label5.TabIndex = 386
        Me.Label5.Text = "Please attach delivery and official reciept of delivered item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(6, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 15)
        Me.Label6.TabIndex = 378
        Me.Label6.Text = "Select purchase order number"
        '
        'ponumber
        '
        Me.ponumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ponumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ponumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ponumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ponumber.ForeColor = System.Drawing.Color.Black
        Me.ponumber.FormattingEnabled = True
        Me.ponumber.ItemHeight = 13
        Me.ponumber.Location = New System.Drawing.Point(9, 29)
        Me.ponumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ponumber.Name = "ponumber"
        Me.ponumber.Size = New System.Drawing.Size(484, 21)
        Me.ponumber.TabIndex = 377
        '
        'txtVerifiedAmount
        '
        Me.txtVerifiedAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVerifiedAmount.BackColor = System.Drawing.Color.Yellow
        Me.txtVerifiedAmount.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtVerifiedAmount.ForeColor = System.Drawing.Color.Black
        Me.txtVerifiedAmount.Location = New System.Drawing.Point(432, 509)
        Me.txtVerifiedAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifiedAmount.Name = "txtVerifiedAmount"
        Me.txtVerifiedAmount.ReadOnly = True
        Me.txtVerifiedAmount.Size = New System.Drawing.Size(136, 26)
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
        Me.Label8.Location = New System.Drawing.Point(306, 514)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 424
        Me.Label8.Text = "Verified Total Payable"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(358, 485)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 419
        Me.Label1.Text = "Invoice No."
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(432, 482)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(136, 22)
        Me.txtInvoiceNumber.TabIndex = 413
        Me.txtInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Location = New System.Drawing.Point(432, 452)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(136, 26)
        Me.txtTotalAmount.TabIndex = 418
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(345, 458)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 417
        Me.Label4.Text = "Total Amount"
        '
        'officeid
        '
        Me.officeid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.officeid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.officeid.ForeColor = System.Drawing.Color.Black
        Me.officeid.Location = New System.Drawing.Point(55, 485)
        Me.officeid.Margin = New System.Windows.Forms.Padding(4)
        Me.officeid.Name = "officeid"
        Me.officeid.Size = New System.Drawing.Size(69, 22)
        Me.officeid.TabIndex = 425
        Me.officeid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.officeid.Visible = False
        '
        'ckAp
        '
        Me.ckAp.AutoSize = True
        Me.ckAp.Location = New System.Drawing.Point(9, 486)
        Me.ckAp.Name = "ckAp"
        Me.ckAp.Size = New System.Drawing.Size(39, 17)
        Me.ckAp.TabIndex = 426
        Me.ckAp.Text = "ap"
        Me.ckAp.UseVisualStyleBackColor = True
        Me.ckAp.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.CoffeecupClient.My.Resources.Resources.search__4_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(497, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 429
        Me.Button2.Text = "Find"
        Me.Button2.UseCompatibleTextRendering = True
        '
        'frmReceivedFFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(577, 622)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ckAp)
        Me.Controls.Add(Me.officeid)
        Me.Controls.Add(Me.txtVerifiedAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmda1)
        Me.Controls.Add(Me.txtattached1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ponumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(593, 661)
        Me.Name = "frmReceivedFFE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asset Receiving Stock Delivery"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmda1 As System.Windows.Forms.Button
    Friend WithEvents txtattached1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdSendOfficialReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiveItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ponumber As System.Windows.Forms.ComboBox
    Friend WithEvents txtVerifiedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents officeid As System.Windows.Forms.TextBox
    Friend WithEvents ckAp As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
