<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSReturnedItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSReturnedItem))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.ckPaymentUpdated = New System.Windows.Forms.CheckBox()
        Me.inventorytrnid = New System.Windows.Forms.TextBox()
        Me.ckChargeAccount = New System.Windows.Forms.CheckBox()
        Me.invoiceno = New System.Windows.Forms.TextBox()
        Me.cifid = New System.Windows.Forms.TextBox()
        Me.trnid = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTransactionBy = New System.Windows.Forms.TextBox()
        Me.unit = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.ckReturnInventory = New System.Windows.Forms.CheckBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAvailableQuantity = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.trnsumrefcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.referencenumber = New System.Windows.Forms.TextBox()
        Me.ckRefundCash = New System.Windows.Forms.CheckBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabPost.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(128, 298)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(129, 177)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 22)
        Me.txtTotal.TabIndex = 100
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(89, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Total"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(129, 202)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(262, 47)
        Me.txtRemarks.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(71, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Remarks"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPost)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 421)
        Me.TabControl1.TabIndex = 411
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.lblItemName)
        Me.tabPost.Controls.Add(Me.ckPaymentUpdated)
        Me.tabPost.Controls.Add(Me.inventorytrnid)
        Me.tabPost.Controls.Add(Me.ckChargeAccount)
        Me.tabPost.Controls.Add(Me.invoiceno)
        Me.tabPost.Controls.Add(Me.cifid)
        Me.tabPost.Controls.Add(Me.trnid)
        Me.tabPost.Controls.Add(Me.txtBatchcode)
        Me.tabPost.Controls.Add(Me.Label8)
        Me.tabPost.Controls.Add(Me.txtTransactionBy)
        Me.tabPost.Controls.Add(Me.unit)
        Me.tabPost.Controls.Add(Me.productid)
        Me.tabPost.Controls.Add(Me.ckReturnInventory)
        Me.tabPost.Controls.Add(Me.txtUnitCost)
        Me.tabPost.Controls.Add(Me.Label7)
        Me.tabPost.Controls.Add(Me.txtAvailableQuantity)
        Me.tabPost.Controls.Add(Me.txtQuantity)
        Me.tabPost.Controls.Add(Me.Label6)
        Me.tabPost.Controls.Add(Me.trnsumrefcode)
        Me.tabPost.Controls.Add(Me.Label5)
        Me.tabPost.Controls.Add(Me.txtProduct)
        Me.tabPost.Controls.Add(Me.Label1)
        Me.tabPost.Controls.Add(Me.referencenumber)
        Me.tabPost.Controls.Add(Me.ckRefundCash)
        Me.tabPost.Controls.Add(Me.cmdConfirm)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtRemarks)
        Me.tabPost.Controls.Add(Me.txtTotal)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Controls.Add(Me.lblWarning)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(794, 395)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'ckPaymentUpdated
        '
        Me.ckPaymentUpdated.AutoSize = True
        Me.ckPaymentUpdated.Enabled = False
        Me.ckPaymentUpdated.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckPaymentUpdated.Location = New System.Drawing.Point(242, 53)
        Me.ckPaymentUpdated.Name = "ckPaymentUpdated"
        Me.ckPaymentUpdated.Size = New System.Drawing.Size(87, 17)
        Me.ckPaymentUpdated.TabIndex = 442
        Me.ckPaymentUpdated.Text = "Invoice Paid"
        Me.ckPaymentUpdated.UseVisualStyleBackColor = True
        '
        'inventorytrnid
        '
        Me.inventorytrnid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.inventorytrnid.ForeColor = System.Drawing.Color.Black
        Me.inventorytrnid.Location = New System.Drawing.Point(731, 7)
        Me.inventorytrnid.Margin = New System.Windows.Forms.Padding(4)
        Me.inventorytrnid.Name = "inventorytrnid"
        Me.inventorytrnid.ReadOnly = True
        Me.inventorytrnid.Size = New System.Drawing.Size(54, 22)
        Me.inventorytrnid.TabIndex = 441
        Me.inventorytrnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.inventorytrnid.Visible = False
        '
        'ckChargeAccount
        '
        Me.ckChargeAccount.AutoSize = True
        Me.ckChargeAccount.Enabled = False
        Me.ckChargeAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckChargeAccount.Location = New System.Drawing.Point(129, 53)
        Me.ckChargeAccount.Name = "ckChargeAccount"
        Me.ckChargeAccount.Size = New System.Drawing.Size(107, 17)
        Me.ckChargeAccount.TabIndex = 440
        Me.ckChargeAccount.Text = "Invoice Account"
        Me.ckChargeAccount.UseVisualStyleBackColor = True
        '
        'invoiceno
        '
        Me.invoiceno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.invoiceno.ForeColor = System.Drawing.Color.Black
        Me.invoiceno.Location = New System.Drawing.Point(731, 151)
        Me.invoiceno.Margin = New System.Windows.Forms.Padding(4)
        Me.invoiceno.Name = "invoiceno"
        Me.invoiceno.ReadOnly = True
        Me.invoiceno.Size = New System.Drawing.Size(54, 22)
        Me.invoiceno.TabIndex = 439
        Me.invoiceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.invoiceno.Visible = False
        '
        'cifid
        '
        Me.cifid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cifid.ForeColor = System.Drawing.Color.Black
        Me.cifid.Location = New System.Drawing.Point(731, 175)
        Me.cifid.Margin = New System.Windows.Forms.Padding(4)
        Me.cifid.Name = "cifid"
        Me.cifid.ReadOnly = True
        Me.cifid.Size = New System.Drawing.Size(54, 22)
        Me.cifid.TabIndex = 438
        Me.cifid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cifid.Visible = False
        '
        'trnid
        '
        Me.trnid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnid.ForeColor = System.Drawing.Color.Black
        Me.trnid.Location = New System.Drawing.Point(731, 103)
        Me.trnid.Margin = New System.Windows.Forms.Padding(4)
        Me.trnid.Name = "trnid"
        Me.trnid.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(54, 22)
        Me.trnid.TabIndex = 437
        Me.trnid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnid.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(731, 127)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(54, 22)
        Me.txtBatchcode.TabIndex = 436
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(40, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 435
        Me.Label8.Text = "Transaction By"
        '
        'txtTransactionBy
        '
        Me.txtTransactionBy.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTransactionBy.ForeColor = System.Drawing.Color.Black
        Me.txtTransactionBy.Location = New System.Drawing.Point(129, 102)
        Me.txtTransactionBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionBy.Name = "txtTransactionBy"
        Me.txtTransactionBy.ReadOnly = True
        Me.txtTransactionBy.Size = New System.Drawing.Size(262, 22)
        Me.txtTransactionBy.TabIndex = 434
        '
        'unit
        '
        Me.unit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.unit.ForeColor = System.Drawing.Color.Black
        Me.unit.Location = New System.Drawing.Point(731, 79)
        Me.unit.Margin = New System.Windows.Forms.Padding(4)
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Size = New System.Drawing.Size(54, 22)
        Me.unit.TabIndex = 433
        Me.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.unit.Visible = False
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(731, 55)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(54, 22)
        Me.productid.TabIndex = 432
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'ckReturnInventory
        '
        Me.ckReturnInventory.AutoSize = True
        Me.ckReturnInventory.Checked = True
        Me.ckReturnInventory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckReturnInventory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckReturnInventory.Location = New System.Drawing.Point(129, 254)
        Me.ckReturnInventory.Name = "ckReturnInventory"
        Me.ckReturnInventory.Size = New System.Drawing.Size(126, 17)
        Me.ckReturnInventory.TabIndex = 431
        Me.ckReturnInventory.Text = "Return to Inventory"
        Me.ckReturnInventory.UseVisualStyleBackColor = True
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCost.Location = New System.Drawing.Point(129, 152)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.ReadOnly = True
        Me.txtUnitCost.Size = New System.Drawing.Size(136, 22)
        Me.txtUnitCost.TabIndex = 429
        Me.txtUnitCost.Text = "0.00"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(72, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 430
        Me.Label7.Text = "Unit Cost"
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAvailableQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(731, 199)
        Me.txtAvailableQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(54, 22)
        Me.txtAvailableQuantity.TabIndex = 428
        Me.txtAvailableQuantity.Text = "0"
        Me.txtAvailableQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAvailableQuantity.Visible = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(129, 127)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(77, 22)
        Me.txtQuantity.TabIndex = 1
        Me.txtQuantity.Text = "0.00"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(72, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 427
        Me.Label6.Text = "Quantity"
        '
        'trnsumrefcode
        '
        Me.trnsumrefcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.trnsumrefcode.ForeColor = System.Drawing.Color.Black
        Me.trnsumrefcode.Location = New System.Drawing.Point(731, 31)
        Me.trnsumrefcode.Margin = New System.Windows.Forms.Padding(4)
        Me.trnsumrefcode.Name = "trnsumrefcode"
        Me.trnsumrefcode.ReadOnly = True
        Me.trnsumrefcode.Size = New System.Drawing.Size(54, 22)
        Me.trnsumrefcode.TabIndex = 425
        Me.trnsumrefcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.trnsumrefcode.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(40, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 424
        Me.Label5.Text = "Select Product"
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
        Me.txtProduct.Location = New System.Drawing.Point(129, 75)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.MaxDropDownItems = 7
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(262, 23)
        Me.txtProduct.TabIndex = 423
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 422
        Me.Label1.Text = "Reference Code"
        '
        'referencenumber
        '
        Me.referencenumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.referencenumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.referencenumber.ForeColor = System.Drawing.Color.Black
        Me.referencenumber.Location = New System.Drawing.Point(129, 18)
        Me.referencenumber.Margin = New System.Windows.Forms.Padding(5)
        Me.referencenumber.Name = "referencenumber"
        Me.referencenumber.Size = New System.Drawing.Size(200, 29)
        Me.referencenumber.TabIndex = 0
        Me.referencenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckRefundCash
        '
        Me.ckRefundCash.AutoSize = True
        Me.ckRefundCash.Checked = True
        Me.ckRefundCash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckRefundCash.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckRefundCash.Location = New System.Drawing.Point(129, 275)
        Me.ckRefundCash.Name = "ckRefundCash"
        Me.ckRefundCash.Size = New System.Drawing.Size(361, 17)
        Me.ckRefundCash.TabIndex = 420
        Me.ckRefundCash.Text = "Replace Item (Note: Please create new transction for replacement)"
        Me.ckRefundCash.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(275, 133)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(275, 71)
        Me.lblWarning.TabIndex = 443
        Me.lblWarning.Text = "NOTE: This transaction was already paid by client! System will automaticaly debit" & _
    "ed your cash as returned. if you do replacement of this returned item, please ta" & _
    "g the transaction as paid"
        Me.lblWarning.Visible = False
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.MyDataGridView)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(794, 395)
        Me.tabTransaction.TabIndex = 1
        Me.tabTransaction.Text = "View Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.ContextMenuStrip = Me.cms_em
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(3, 3)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(788, 389)
        Me.MyDataGridView.TabIndex = 412
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(175, 26)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(174, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Cancel Transaction"
        '
        'lblItemName
        '
        Me.lblItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(398, 75)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(370, 58)
        Me.lblItemName.TabIndex = 444
        '
        'frmPOSReturnedItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(802, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(687, 368)
        Me.Name = "frmPOSReturnedItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Returned Item"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckRefundCash As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents referencenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAvailableQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents trnsumrefcode As System.Windows.Forms.TextBox
    Friend WithEvents ckReturnInventory As System.Windows.Forms.CheckBox
    Friend WithEvents unit As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionBy As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents trnid As System.Windows.Forms.TextBox
    Friend WithEvents cifid As System.Windows.Forms.TextBox
    Friend WithEvents invoiceno As System.Windows.Forms.TextBox
    Friend WithEvents ckChargeAccount As System.Windows.Forms.CheckBox
    Friend WithEvents inventorytrnid As System.Windows.Forms.TextBox
    Friend WithEvents ckPaymentUpdated As System.Windows.Forms.CheckBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
End Class
