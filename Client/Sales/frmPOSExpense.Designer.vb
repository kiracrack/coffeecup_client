<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSExpense))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGLItem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemcode = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentCash = New System.Windows.Forms.TextBox()
        Me.ckAffectCash = New System.Windows.Forms.CheckBox()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.txtlink = New System.Windows.Forms.LinkLabel()
        Me.cmda1 = New System.Windows.Forms.Button()
        Me.txtattached1 = New System.Windows.Forms.TextBox()
        Me.ckQuotation = New System.Windows.Forms.CheckBox()
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
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(112, 238)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirm.TabIndex = 5
        Me.cmdConfirm.Text = "Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(113, 95)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(136, 22)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(56, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Amount"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(113, 45)
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
        Me.Label2.Location = New System.Drawing.Point(55, 47)
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
        Me.txtGLItem.Location = New System.Drawing.Point(113, 19)
        Me.txtGLItem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGLItem.MaxDropDownItems = 7
        Me.txtGLItem.Name = "txtGLItem"
        Me.txtGLItem.Size = New System.Drawing.Size(262, 23)
        Me.txtGLItem.TabIndex = 403
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Expense Name"
        '
        'itemcode
        '
        Me.itemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.ForeColor = System.Drawing.Color.Black
        Me.itemcode.Location = New System.Drawing.Point(411, 47)
        Me.itemcode.Margin = New System.Windows.Forms.Padding(4)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Size = New System.Drawing.Size(41, 22)
        Me.itemcode.TabIndex = 405
        Me.itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.itemcode.Visible = False
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
        Me.TabControl1.TabIndex = 411
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.Label5)
        Me.tabPost.Controls.Add(Me.txtORNumber)
        Me.tabPost.Controls.Add(Me.Label1)
        Me.tabPost.Controls.Add(Me.txtCurrentCash)
        Me.tabPost.Controls.Add(Me.ckAffectCash)
        Me.tabPost.Controls.Add(Me.lblAttachment)
        Me.tabPost.Controls.Add(Me.txtlink)
        Me.tabPost.Controls.Add(Me.cmda1)
        Me.tabPost.Controls.Add(Me.txtattached1)
        Me.tabPost.Controls.Add(Me.ckQuotation)
        Me.tabPost.Controls.Add(Me.Label4)
        Me.tabPost.Controls.Add(Me.itemcode)
        Me.tabPost.Controls.Add(Me.cmdConfirm)
        Me.tabPost.Controls.Add(Me.txtGLItem)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtRemarks)
        Me.tabPost.Controls.Add(Me.txtAmount)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(663, 303)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(37, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 424
        Me.Label5.Text = "OR Number"
        '
        'txtORNumber
        '
        Me.txtORNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtORNumber.ForeColor = System.Drawing.Color.Black
        Me.txtORNumber.Location = New System.Drawing.Point(113, 120)
        Me.txtORNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(136, 22)
        Me.txtORNumber.TabIndex = 4
        Me.txtORNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(30, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 422
        Me.Label1.Text = "Current Cash"
        '
        'txtCurrentCash
        '
        Me.txtCurrentCash.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCurrentCash.ForeColor = System.Drawing.Color.Black
        Me.txtCurrentCash.Location = New System.Drawing.Point(113, 213)
        Me.txtCurrentCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentCash.Name = "txtCurrentCash"
        Me.txtCurrentCash.ReadOnly = True
        Me.txtCurrentCash.Size = New System.Drawing.Size(136, 22)
        Me.txtCurrentCash.TabIndex = 421
        Me.txtCurrentCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckAffectCash
        '
        Me.ckAffectCash.AutoSize = True
        Me.ckAffectCash.Checked = True
        Me.ckAffectCash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckAffectCash.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckAffectCash.Location = New System.Drawing.Point(112, 192)
        Me.ckAffectCash.Name = "ckAffectCash"
        Me.ckAffectCash.Size = New System.Drawing.Size(125, 17)
        Me.ckAffectCash.TabIndex = 420
        Me.ckAffectCash.Text = "Affect Cashier Cash"
        Me.ckAffectCash.UseVisualStyleBackColor = True
        '
        'lblAttachment
        '
        Me.lblAttachment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttachment.ForeColor = System.Drawing.Color.Red
        Me.lblAttachment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAttachment.Location = New System.Drawing.Point(378, 165)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(223, 44)
        Me.lblAttachment.TabIndex = 419
        '
        'txtlink
        '
        Me.txtlink.AutoSize = True
        Me.txtlink.Location = New System.Drawing.Point(231, 148)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(146, 13)
        Me.txtlink.TabIndex = 418
        Me.txtlink.TabStop = True
        Me.txtlink.Text = "How to compress your files"
        '
        'cmda1
        '
        Me.cmda1.Enabled = False
        Me.cmda1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmda1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmda1.Location = New System.Drawing.Point(34, 165)
        Me.cmda1.Name = "cmda1"
        Me.cmda1.Size = New System.Drawing.Size(78, 22)
        Me.cmda1.TabIndex = 417
        Me.cmda1.Text = "Browse"
        Me.cmda1.UseCompatibleTextRendering = True
        '
        'txtattached1
        '
        Me.txtattached1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtattached1.ForeColor = System.Drawing.Color.Black
        Me.txtattached1.Location = New System.Drawing.Point(114, 165)
        Me.txtattached1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtattached1.Name = "txtattached1"
        Me.txtattached1.ReadOnly = True
        Me.txtattached1.Size = New System.Drawing.Size(261, 22)
        Me.txtattached1.TabIndex = 415
        '
        'ckQuotation
        '
        Me.ckQuotation.AutoSize = True
        Me.ckQuotation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckQuotation.ForeColor = System.Drawing.Color.Black
        Me.ckQuotation.Location = New System.Drawing.Point(113, 146)
        Me.ckQuotation.Name = "ckQuotation"
        Me.ckQuotation.Size = New System.Drawing.Size(114, 19)
        Me.ckQuotation.TabIndex = 416
        Me.ckQuotation.Text = "Add Attachment"
        Me.ckQuotation.UseVisualStyleBackColor = True
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
        Me.MyDataGridView.Size = New System.Drawing.Size(657, 297)
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
        'frmPOSExpense
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
        Me.Name = "frmPOSExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Post Expense"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGLItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemcode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents txtlink As System.Windows.Forms.LinkLabel
    Friend WithEvents cmda1 As System.Windows.Forms.Button
    Friend WithEvents txtattached1 As System.Windows.Forms.TextBox
    Friend WithEvents ckQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents ckAffectCash As System.Windows.Forms.CheckBox
    Friend WithEvents txtCurrentCash As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtORNumber As System.Windows.Forms.TextBox
End Class
