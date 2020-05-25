<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoAddTransaction
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoAddTransaction))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNewBatchcode = New System.Windows.Forms.ComboBox()
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.GridBatchcode = New System.Windows.Forms.DataGridView()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.GridBatchcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "New batchcode"
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(163, 56)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.MultiSelect = False
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(679, 332)
        Me.MyDataGridView.TabIndex = 370
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdCancel, Me.ToolStripSeparator4, Me.cmdLocalData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(175, 54)
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(174, 22)
        Me.cmdCancel.Text = "Cancel Transaction"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(171, 6)
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(174, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'txtNewBatchcode
        '
        Me.txtNewBatchcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtNewBatchcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtNewBatchcode.DropDownHeight = 130
        Me.txtNewBatchcode.Font = New System.Drawing.Font("Segoe UI", 8.65!)
        Me.txtNewBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtNewBatchcode.FormattingEnabled = True
        Me.txtNewBatchcode.IntegralHeight = False
        Me.txtNewBatchcode.ItemHeight = 15
        Me.txtNewBatchcode.Location = New System.Drawing.Point(8, 29)
        Me.txtNewBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewBatchcode.MaxDropDownItems = 7
        Me.txtNewBatchcode.Name = "txtNewBatchcode"
        Me.txtNewBatchcode.Size = New System.Drawing.Size(151, 23)
        Me.txtNewBatchcode.TabIndex = 0
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Enabled = False
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(163, 29)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(104, 24)
        Me.cmdConfirmPayment.TabIndex = 417
        Me.cmdConfirmPayment.Text = "Add Transaction"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtReference
        '
        Me.txtReference.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReference.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReference.ForeColor = System.Drawing.Color.Black
        Me.txtReference.Location = New System.Drawing.Point(290, 162)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(57, 23)
        Me.txtReference.TabIndex = 418
        Me.txtReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReference.Visible = False
        '
        'GridBatchcode
        '
        Me.GridBatchcode.AllowUserToAddRows = False
        Me.GridBatchcode.AllowUserToDeleteRows = False
        Me.GridBatchcode.AllowUserToResizeColumns = False
        Me.GridBatchcode.AllowUserToResizeRows = False
        Me.GridBatchcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridBatchcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridBatchcode.BackgroundColor = System.Drawing.Color.White
        Me.GridBatchcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridBatchcode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridBatchcode.ContextMenuStrip = Me.cms_em
        Me.GridBatchcode.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridBatchcode.Location = New System.Drawing.Point(8, 56)
        Me.GridBatchcode.Margin = New System.Windows.Forms.Padding(2)
        Me.GridBatchcode.MultiSelect = False
        Me.GridBatchcode.Name = "GridBatchcode"
        Me.GridBatchcode.ReadOnly = True
        Me.GridBatchcode.RowHeadersVisible = False
        Me.GridBatchcode.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.GridBatchcode.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridBatchcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBatchcode.Size = New System.Drawing.Size(151, 332)
        Me.GridBatchcode.TabIndex = 419
        '
        'frmAutoAddTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(853, 397)
        Me.Controls.Add(Me.GridBatchcode)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.txtNewBatchcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(658, 405)
        Me.Name = "frmAutoAddTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Services Transaction"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.GridBatchcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtNewBatchcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridBatchcode As System.Windows.Forms.DataGridView
End Class
