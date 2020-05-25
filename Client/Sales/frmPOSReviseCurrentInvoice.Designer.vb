<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSReviseCurrentInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSReviseCurrentInvoice))
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtBatchcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdConfirm.BackColor = System.Drawing.Color.Khaki
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(306, 393)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(200, 38)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm Revision"
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Location = New System.Drawing.Point(630, 31)
        Me.txtTotalAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(169, 23)
        Me.txtTotalAmount.TabIndex = 100
        Me.txtTotalAmount.Text = "0.00"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 422
        Me.Label1.Text = "Reference no."
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenceNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReferenceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtReferenceNumber.Location = New System.Drawing.Point(14, 31)
        Me.txtReferenceNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(118, 23)
        Me.txtReferenceNumber.TabIndex = 0
        Me.txtReferenceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(14, 57)
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
        Me.MyDataGridView.Size = New System.Drawing.Size(785, 329)
        Me.MyDataGridView.TabIndex = 412
        '
        'txtBatchcode
        '
        Me.txtBatchcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBatchcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBatchcode.ForeColor = System.Drawing.Color.Black
        Me.txtBatchcode.Location = New System.Drawing.Point(483, 31)
        Me.txtBatchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBatchcode.Name = "txtBatchcode"
        Me.txtBatchcode.ReadOnly = True
        Me.txtBatchcode.Size = New System.Drawing.Size(144, 23)
        Me.txtBatchcode.TabIndex = 444
        Me.txtBatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(479, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 445
        Me.Label2.Text = "Transaction Batchcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(626, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 446
        Me.Label3.Text = "Total Amount"
        '
        'txtClientName
        '
        Me.txtClientName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClientName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtClientName.ForeColor = System.Drawing.Color.Black
        Me.txtClientName.Location = New System.Drawing.Point(135, 31)
        Me.txtClientName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(345, 23)
        Me.txtClientName.TabIndex = 447
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(132, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 448
        Me.Label4.Text = "Client Name"
        '
        'frmPOSReviseCurrentInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(810, 441)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBatchcode)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(826, 480)
        Me.Name = "frmPOSReviseCurrentInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revise Current Invoice"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
