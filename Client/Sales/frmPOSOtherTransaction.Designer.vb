<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSOtherTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSOtherTransaction))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGLItem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmountTender = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdInputPaymentDetails = New System.Windows.Forms.LinkLabel()
        Me.rbMultiPayment = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.tabTransaction = New System.Windows.Forms.TabPage()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tabPost.SuspendLayout()
        Me.tabTransaction.SuspendLayout()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(119, 195)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirmPayment.TabIndex = 5
        Me.cmdConfirmPayment.Text = "Save"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(118, 104)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(262, 47)
        Me.txtRemarks.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(60, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 400
        Me.Label2.Text = "Remarks"
        '
        'txtGLItem
        '
        Me.txtGLItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtGLItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtGLItem.DropDownHeight = 130
        Me.txtGLItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGLItem.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtGLItem.ForeColor = System.Drawing.Color.Black
        Me.txtGLItem.FormattingEnabled = True
        Me.txtGLItem.IntegralHeight = False
        Me.txtGLItem.ItemHeight = 15
        Me.txtGLItem.Location = New System.Drawing.Point(118, 27)
        Me.txtGLItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGLItem.MaxDropDownItems = 7
        Me.txtGLItem.Name = "txtGLItem"
        Me.txtGLItem.Size = New System.Drawing.Size(262, 23)
        Me.txtGLItem.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(46, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Item Name"
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(388, 28)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(4)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(41, 22)
        Me.itemcode.TabIndex = 405
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(61, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Amount"
        '
        'txtAmountTender
        '
        Me.txtAmountTender.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmountTender.ForeColor = System.Drawing.Color.Black
        Me.txtAmountTender.Location = New System.Drawing.Point(118, 79)
        Me.txtAmountTender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountTender.Name = "txtAmountTender"
        Me.txtAmountTender.Size = New System.Drawing.Size(136, 22)
        Me.txtAmountTender.TabIndex = 2
        Me.txtAmountTender.Text = "0.00"
        Me.txtAmountTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPost)
        Me.TabControl1.Controls.Add(Me.tabTransaction)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(671, 329)
        Me.TabControl1.TabIndex = 410
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.txtORNumber)
        Me.tabPost.Controls.Add(Me.Label5)
        Me.tabPost.Controls.Add(Me.cmdInputPaymentDetails)
        Me.tabPost.Controls.Add(Me.rbMultiPayment)
        Me.tabPost.Controls.Add(Me.rbCash)
        Me.tabPost.Controls.Add(Me.Label4)
        Me.tabPost.Controls.Add(Me.cmdConfirmPayment)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtRemarks)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Controls.Add(Me.itemcode)
        Me.tabPost.Controls.Add(Me.txtAmountTender)
        Me.tabPost.Controls.Add(Me.txtGLItem)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(663, 303)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'txtORNumber
        '
        Me.txtORNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtORNumber.ForeColor = System.Drawing.Color.Black
        Me.txtORNumber.Location = New System.Drawing.Point(118, 53)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(136, 23)
        Me.txtORNumber.TabIndex = 718
        Me.txtORNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(31, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 719
        Me.Label5.Text = "Reference No."
        '
        'cmdInputPaymentDetails
        '
        Me.cmdInputPaymentDetails.AutoSize = True
        Me.cmdInputPaymentDetails.Location = New System.Drawing.Point(116, 176)
        Me.cmdInputPaymentDetails.Name = "cmdInputPaymentDetails"
        Me.cmdInputPaymentDetails.Size = New System.Drawing.Size(185, 13)
        Me.cmdInputPaymentDetails.TabIndex = 705
        Me.cmdInputPaymentDetails.TabStop = True
        Me.cmdInputPaymentDetails.Text = "Please input other payment details"
        '
        'rbMultiPayment
        '
        Me.rbMultiPayment.AutoSize = True
        Me.rbMultiPayment.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbMultiPayment.Location = New System.Drawing.Point(234, 155)
        Me.rbMultiPayment.Name = "rbMultiPayment"
        Me.rbMultiPayment.Size = New System.Drawing.Size(108, 17)
        Me.rbMultiPayment.TabIndex = 707
        Me.rbMultiPayment.Text = "OTHER PAYMENT"
        Me.rbMultiPayment.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Checked = True
        Me.rbCash.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.rbCash.Location = New System.Drawing.Point(119, 155)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(101, 17)
        Me.rbCash.TabIndex = 706
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "CASH PAYMENT"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'tabTransaction
        '
        Me.tabTransaction.Controls.Add(Me.MyDataGridView)
        Me.tabTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tabTransaction.Name = "tabTransaction"
        Me.tabTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTransaction.Size = New System.Drawing.Size(663, 303)
        Me.tabTransaction.TabIndex = 1
        Me.tabTransaction.Text = "View Transaction"
        Me.tabTransaction.UseVisualStyleBackColor = True
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
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
        Me.MyDataGridView.Size = New System.Drawing.Size(657, 297)
        Me.MyDataGridView.TabIndex = 394
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
        'frmPOSOtherTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(671, 329)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(687, 368)
        Me.Name = "frmPOSOtherTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Transaction"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGLItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmountTender As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdInputPaymentDetails As LinkLabel
    Friend WithEvents rbMultiPayment As RadioButton
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents Label5 As Label
End Class
