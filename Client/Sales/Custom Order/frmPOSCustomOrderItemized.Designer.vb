<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSCustomOrderItemized
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSCustomOrderItemized))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.postrn = New System.Windows.Forms.TextBox()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
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
        Me.MyDataGridView.Size = New System.Drawing.Size(647, 344)
        Me.MyDataGridView.TabIndex = 0
        '
        'postrn
        '
        Me.postrn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.postrn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.postrn.Location = New System.Drawing.Point(293, 183)
        Me.postrn.Margin = New System.Windows.Forms.Padding(4)
        Me.postrn.Name = "postrn"
        Me.postrn.Size = New System.Drawing.Size(60, 22)
        Me.postrn.TabIndex = 393
        Me.postrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.postrn.Visible = False
        '
        'txtBatchcode
        '
        Me.txtBatchcode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBatchcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBatchcode.Location = New System.Drawing.Point(361, 183)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.Size = New System.Drawing.Size(60, 22)
        Me.txtBatchcode.TabIndex = 394
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBatchcode.Visible = False
        '
        'productid
        '
        Me.productid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.productid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.productid.Location = New System.Drawing.Point(429, 183)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(60, 22)
        Me.productid.TabIndex = 395
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'frmPOSCustomOrderItemized
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(647, 344)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.postrn)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSCustomOrderItemized"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customized Order (list per item) | Press INSERT key to add item, Press DELETE key" & _
    " to remove"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents postrn As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
End Class
