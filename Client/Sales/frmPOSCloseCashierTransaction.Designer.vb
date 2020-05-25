<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCloseCashierTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCloseCashierTransaction))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PanelCashierCloseTransaction = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblSystemCashEnd = New System.Windows.Forms.Label()
        Me.txtSystemCashEnd = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CashRemitted = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NextcashBeginning = New System.Windows.Forms.TextBox()
        Me.cmdCloseCashierTransaction = New System.Windows.Forms.Button()
        Me.txt_ActualCashOnHand = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_TotalBill = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_TotalCoins = New System.Windows.Forms.TextBox()
        Me.myDataGridView_balanceSheetEmail = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        Me.PanelCashierCloseTransaction.SuspendLayout()
        CType(Me.myDataGridView_balanceSheetEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(151, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.printer_pos
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EditChapterToolStripMenuItem.Text = "Print Report"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.document_excel_table
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToolStripMenuItem.Text = "Export to Excel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(147, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(150, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'PanelCashierCloseTransaction
        '
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Label2)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txtDateFrom)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.LinkLabel1)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.lblSystemCashEnd)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txtSystemCashEnd)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Button3)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Button2)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Label1)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txt_CashRemitted)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Label4)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txt_NextcashBeginning)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.cmdCloseCashierTransaction)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txt_ActualCashOnHand)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Label7)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txt_TotalBill)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.Label8)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.txt_TotalCoins)
        Me.PanelCashierCloseTransaction.Controls.Add(Me.myDataGridView_balanceSheetEmail)
        Me.PanelCashierCloseTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCashierCloseTransaction.Location = New System.Drawing.Point(0, 0)
        Me.PanelCashierCloseTransaction.Name = "PanelCashierCloseTransaction"
        Me.PanelCashierCloseTransaction.Size = New System.Drawing.Size(782, 363)
        Me.PanelCashierCloseTransaction.TabIndex = 123487
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LinkLabel1.Location = New System.Drawing.Point(170, 90)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 17)
        Me.LinkLabel1.TabIndex = 123520
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Total Cash End (Enter Denomination)"
        '
        'lblSystemCashEnd
        '
        Me.lblSystemCashEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSystemCashEnd.AutoSize = True
        Me.lblSystemCashEnd.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblSystemCashEnd.Location = New System.Drawing.Point(283, 61)
        Me.lblSystemCashEnd.Name = "lblSystemCashEnd"
        Me.lblSystemCashEnd.Size = New System.Drawing.Size(107, 17)
        Me.lblSystemCashEnd.TabIndex = 123519
        Me.lblSystemCashEnd.Text = "System Cash End"
        '
        'txtSystemCashEnd
        '
        Me.txtSystemCashEnd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSystemCashEnd.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtSystemCashEnd.ForeColor = System.Drawing.Color.Black
        Me.txtSystemCashEnd.Location = New System.Drawing.Point(398, 58)
        Me.txtSystemCashEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSystemCashEnd.Name = "txtSystemCashEnd"
        Me.txtSystemCashEnd.ReadOnly = True
        Me.txtSystemCashEnd.Size = New System.Drawing.Size(171, 26)
        Me.txtSystemCashEnd.TabIndex = 123518
        Me.txtSystemCashEnd.Text = "0.00"
        Me.txtSystemCashEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(207, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 45)
        Me.Button3.TabIndex = 123517
        Me.Button3.Text = "Print Cashier's Blotter"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(398, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 45)
        Me.Button2.TabIndex = 123516
        Me.Button2.Text = "Print Remittance Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label1.Location = New System.Drawing.Point(267, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 123514
        Me.Label1.Text = "Total Cash Remitted"
        '
        'txt_CashRemitted
        '
        Me.txt_CashRemitted.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_CashRemitted.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_CashRemitted.ForeColor = System.Drawing.Color.Black
        Me.txt_CashRemitted.Location = New System.Drawing.Point(398, 203)
        Me.txt_CashRemitted.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CashRemitted.Name = "txt_CashRemitted"
        Me.txt_CashRemitted.ReadOnly = True
        Me.txt_CashRemitted.Size = New System.Drawing.Size(171, 26)
        Me.txt_CashRemitted.TabIndex = 123513
        Me.txt_CashRemitted.Text = "0.00"
        Me.txt_CashRemitted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(193, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 17)
        Me.Label4.TabIndex = 123512
        Me.Label4.Text = "Next Transaction Beginning Cash"
        '
        'txt_NextcashBeginning
        '
        Me.txt_NextcashBeginning.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_NextcashBeginning.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_NextcashBeginning.ForeColor = System.Drawing.Color.Black
        Me.txt_NextcashBeginning.Location = New System.Drawing.Point(398, 174)
        Me.txt_NextcashBeginning.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_NextcashBeginning.Name = "txt_NextcashBeginning"
        Me.txt_NextcashBeginning.Size = New System.Drawing.Size(171, 26)
        Me.txt_NextcashBeginning.TabIndex = 0
        Me.txt_NextcashBeginning.Text = "0.00"
        Me.txt_NextcashBeginning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCloseCashierTransaction
        '
        Me.cmdCloseCashierTransaction.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdCloseCashierTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCloseCashierTransaction.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmdCloseCashierTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCloseCashierTransaction.Location = New System.Drawing.Point(207, 284)
        Me.cmdCloseCashierTransaction.Name = "cmdCloseCashierTransaction"
        Me.cmdCloseCashierTransaction.Size = New System.Drawing.Size(363, 41)
        Me.cmdCloseCashierTransaction.TabIndex = 123510
        Me.cmdCloseCashierTransaction.Text = "Close Transaction"
        Me.cmdCloseCashierTransaction.UseVisualStyleBackColor = False
        '
        'txt_ActualCashOnHand
        '
        Me.txt_ActualCashOnHand.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_ActualCashOnHand.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_ActualCashOnHand.ForeColor = System.Drawing.Color.Black
        Me.txt_ActualCashOnHand.Location = New System.Drawing.Point(398, 87)
        Me.txt_ActualCashOnHand.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ActualCashOnHand.Name = "txt_ActualCashOnHand"
        Me.txt_ActualCashOnHand.ReadOnly = True
        Me.txt_ActualCashOnHand.Size = New System.Drawing.Size(171, 26)
        Me.txt_ActualCashOnHand.TabIndex = 123507
        Me.txt_ActualCashOnHand.Text = "0.00"
        Me.txt_ActualCashOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label7.Location = New System.Drawing.Point(329, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 123506
        Me.Label7.Text = "Total Bills"
        '
        'txt_TotalBill
        '
        Me.txt_TotalBill.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TotalBill.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_TotalBill.ForeColor = System.Drawing.Color.Black
        Me.txt_TotalBill.Location = New System.Drawing.Point(398, 116)
        Me.txt_TotalBill.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TotalBill.Name = "txt_TotalBill"
        Me.txt_TotalBill.ReadOnly = True
        Me.txt_TotalBill.Size = New System.Drawing.Size(171, 26)
        Me.txt_TotalBill.TabIndex = 123503
        Me.txt_TotalBill.Text = "0.00"
        Me.txt_TotalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label8.Location = New System.Drawing.Point(319, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 123505
        Me.Label8.Text = "Total Coins"
        '
        'txt_TotalCoins
        '
        Me.txt_TotalCoins.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TotalCoins.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txt_TotalCoins.ForeColor = System.Drawing.Color.Black
        Me.txt_TotalCoins.Location = New System.Drawing.Point(398, 145)
        Me.txt_TotalCoins.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TotalCoins.Name = "txt_TotalCoins"
        Me.txt_TotalCoins.ReadOnly = True
        Me.txt_TotalCoins.Size = New System.Drawing.Size(171, 26)
        Me.txt_TotalCoins.TabIndex = 123504
        Me.txt_TotalCoins.Text = "0.00"
        Me.txt_TotalCoins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'myDataGridView_balanceSheetEmail
        '
        Me.myDataGridView_balanceSheetEmail.AllowUserToAddRows = False
        Me.myDataGridView_balanceSheetEmail.AllowUserToDeleteRows = False
        Me.myDataGridView_balanceSheetEmail.AllowUserToResizeRows = False
        Me.myDataGridView_balanceSheetEmail.BackgroundColor = System.Drawing.Color.White
        Me.myDataGridView_balanceSheetEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.myDataGridView_balanceSheetEmail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.myDataGridView_balanceSheetEmail.ContextMenuStrip = Me.cms_em
        Me.myDataGridView_balanceSheetEmail.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.myDataGridView_balanceSheetEmail.Location = New System.Drawing.Point(957, 38)
        Me.myDataGridView_balanceSheetEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.myDataGridView_balanceSheetEmail.MultiSelect = False
        Me.myDataGridView_balanceSheetEmail.Name = "myDataGridView_balanceSheetEmail"
        Me.myDataGridView_balanceSheetEmail.ReadOnly = True
        Me.myDataGridView_balanceSheetEmail.RowHeadersVisible = False
        Me.myDataGridView_balanceSheetEmail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.myDataGridView_balanceSheetEmail.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.myDataGridView_balanceSheetEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.myDataGridView_balanceSheetEmail.Size = New System.Drawing.Size(135, 256)
        Me.myDataGridView_balanceSheetEmail.TabIndex = 123515
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(285, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 123522
        Me.Label2.Text = "Transaction Date"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDateFrom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDateFrom.ForeColor = System.Drawing.Color.Black
        Me.txtDateFrom.Location = New System.Drawing.Point(398, 28)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.ReadOnly = True
        Me.txtDateFrom.Size = New System.Drawing.Size(171, 26)
        Me.txtDateFrom.TabIndex = 123521
        Me.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPOSCloseCashierTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(782, 363)
        Me.Controls.Add(Me.PanelCashierCloseTransaction)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSCloseCashierTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Transaction Summary"
        Me.cms_em.ResumeLayout(False)
        Me.PanelCashierCloseTransaction.ResumeLayout(False)
        Me.PanelCashierCloseTransaction.PerformLayout()
        CType(Me.myDataGridView_balanceSheetEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PanelCashierCloseTransaction As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_CashRemitted As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_NextcashBeginning As System.Windows.Forms.TextBox
    Friend WithEvents cmdCloseCashierTransaction As System.Windows.Forms.Button
    Friend WithEvents txt_ActualCashOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalBill As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalCoins As System.Windows.Forms.TextBox
    Friend WithEvents myDataGridView_balanceSheetEmail As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblSystemCashEnd As System.Windows.Forms.Label
    Friend WithEvents txtSystemCashEnd As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateFrom As System.Windows.Forms.TextBox
End Class
