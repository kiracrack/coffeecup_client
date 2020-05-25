<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPreviousPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewPreviousPurchase))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.MyDataGridView_Particular = New System.Windows.Forms.DataGridView()
        Me.productid = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(534, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 30)
        Me.Button2.TabIndex = 361
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmdView
        '
        Me.cmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdView.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdView.Location = New System.Drawing.Point(351, 364)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(180, 30)
        Me.cmdView.TabIndex = 362
        Me.cmdView.Text = "View Requisition Details"
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'MyDataGridView_Particular
        '
        Me.MyDataGridView_Particular.AllowUserToAddRows = False
        Me.MyDataGridView_Particular.AllowUserToDeleteRows = False
        Me.MyDataGridView_Particular.AllowUserToResizeColumns = False
        Me.MyDataGridView_Particular.AllowUserToResizeRows = False
        Me.MyDataGridView_Particular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyDataGridView_Particular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Particular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Particular.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Particular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Particular.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Particular.Location = New System.Drawing.Point(11, 11)
        Me.MyDataGridView_Particular.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Particular.MultiSelect = False
        Me.MyDataGridView_Particular.Name = "MyDataGridView_Particular"
        Me.MyDataGridView_Particular.ReadOnly = True
        Me.MyDataGridView_Particular.RowHeadersVisible = False
        Me.MyDataGridView_Particular.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Particular.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Particular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Particular.Size = New System.Drawing.Size(703, 348)
        Me.MyDataGridView_Particular.TabIndex = 402
        '
        'productid
        '
        Me.productid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.Location = New System.Drawing.Point(12, 402)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(67, 23)
        Me.productid.TabIndex = 403
        Me.productid.Visible = False
        '
        'frmViewPreviousPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(721, 399)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.MyDataGridView_Particular)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewPreviousPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Previous Purchases Log"
        CType(Me.MyDataGridView_Particular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents MyDataGridView_Particular As System.Windows.Forms.DataGridView
    Friend WithEvents productid As System.Windows.Forms.TextBox
End Class
