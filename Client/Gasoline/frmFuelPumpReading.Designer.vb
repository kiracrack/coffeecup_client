<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelPumpReading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuelPumpReading))
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtProduct = New System.Windows.Forms.ComboBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(7, 54)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(298, 267)
        Me.MyDataGridView.TabIndex = 392
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
        Me.txtProduct.Location = New System.Drawing.Point(7, 27)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.MaxDropDownItems = 7
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(298, 23)
        Me.txtProduct.TabIndex = 397
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(219, 58)
        Me.productid.Margin = New System.Windows.Forms.Padding(4)
        Me.productid.Name = "productid"
        Me.productid.ReadOnly = True
        Me.productid.Size = New System.Drawing.Size(86, 22)
        Me.productid.TabIndex = 398
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.productid.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "Select Fuel product"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(40, 325)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(230, 38)
        Me.cmdConfirm.TabIndex = 400
        Me.cmdConfirm.Text = "Save and Lock Reading"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'frmFuelPumpReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(311, 367)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFuelPumpReading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fuel Pump Reading"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtProduct As System.Windows.Forms.ComboBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
End Class
