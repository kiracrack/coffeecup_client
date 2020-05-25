<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCheckEncashment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCheckEncashment))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtCheckNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIssuerBank = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPost = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDateTransaction = New System.Windows.Forms.DateTimePicker()
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
        Me.cmdConfirm.Location = New System.Drawing.Point(124, 196)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(137, 38)
        Me.cmdConfirm.TabIndex = 4
        Me.cmdConfirm.Text = "Save"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCheckNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCheckNumber.Location = New System.Drawing.Point(125, 21)
        Me.txtCheckNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(136, 22)
        Me.txtCheckNumber.TabIndex = 0
        Me.txtCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(32, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 396
        Me.Label4.Text = "Check Number"
        '
        'txtIssuerBank
        '
        Me.txtIssuerBank.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtIssuerBank.ForeColor = System.Drawing.Color.Black
        Me.txtIssuerBank.Location = New System.Drawing.Point(125, 46)
        Me.txtIssuerBank.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssuerBank.Name = "txtIssuerBank"
        Me.txtIssuerBank.Size = New System.Drawing.Size(262, 22)
        Me.txtIssuerBank.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(53, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "Issuer Bank"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(125, 171)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(136, 22)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(68, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 402
        Me.Label3.Text = "Amount"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(125, 96)
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
        Me.Label2.Location = New System.Drawing.Point(67, 98)
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
        Me.TabControl1.Size = New System.Drawing.Size(671, 329)
        Me.TabControl1.TabIndex = 412
        '
        'tabPost
        '
        Me.tabPost.Controls.Add(Me.Label6)
        Me.tabPost.Controls.Add(Me.txtCompanyName)
        Me.tabPost.Controls.Add(Me.Label5)
        Me.tabPost.Controls.Add(Me.txtDateTransaction)
        Me.tabPost.Controls.Add(Me.Label4)
        Me.tabPost.Controls.Add(Me.txtAmount)
        Me.tabPost.Controls.Add(Me.cmdConfirm)
        Me.tabPost.Controls.Add(Me.Label3)
        Me.tabPost.Controls.Add(Me.txtCheckNumber)
        Me.tabPost.Controls.Add(Me.txtRemarks)
        Me.tabPost.Controls.Add(Me.Label1)
        Me.tabPost.Controls.Add(Me.Label2)
        Me.tabPost.Controls.Add(Me.txtIssuerBank)
        Me.tabPost.Location = New System.Drawing.Point(4, 22)
        Me.tabPost.Name = "tabPost"
        Me.tabPost.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPost.Size = New System.Drawing.Size(663, 303)
        Me.tabPost.TabIndex = 0
        Me.tabPost.Text = "Post Transaction"
        Me.tabPost.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(25, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 409
        Me.Label6.Text = "Company Name"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompanyName.ForeColor = System.Drawing.Color.Black
        Me.txtCompanyName.Location = New System.Drawing.Point(125, 71)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(262, 22)
        Me.txtCompanyName.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(53, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 407
        Me.Label5.Text = "Check Date"
        '
        'txtDateTransaction
        '
        Me.txtDateTransaction.CustomFormat = " yyyy-MM-dd"
        Me.txtDateTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTransaction.Location = New System.Drawing.Point(125, 146)
        Me.txtDateTransaction.Name = "txtDateTransaction"
        Me.txtDateTransaction.Size = New System.Drawing.Size(136, 22)
        Me.txtDateTransaction.TabIndex = 4
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
        'frmPOSCheckEncashment
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
        Me.Name = "frmPOSCheckEncashment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Encashment"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPost.ResumeLayout(False)
        Me.tabPost.PerformLayout()
        Me.tabTransaction.ResumeLayout(False)
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIssuerBank As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPost As System.Windows.Forms.TabPage
    Friend WithEvents tabTransaction As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDateTransaction As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
End Class
