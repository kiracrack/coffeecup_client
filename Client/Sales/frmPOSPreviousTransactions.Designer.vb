<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSPreviousTransactions
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSPreviousTransactions))
        Me.MyDataGridView_Batch = New System.Windows.Forms.DataGridView()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabBatch = New System.Windows.Forms.TabPage()
        Me.tabDetails = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_Detail = New System.Windows.Forms.DataGridView()
        Me.tabVoidCancelled = New System.Windows.Forms.TabPage()
        Me.MyDataGridView_VoidCancelled = New System.Windows.Forms.DataGridView()
        CType(Me.MyDataGridView_Batch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabBatch.SuspendLayout()
        Me.tabDetails.SuspendLayout()
        CType(Me.MyDataGridView_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVoidCancelled.SuspendLayout()
        CType(Me.MyDataGridView_VoidCancelled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGridView_Batch
        '
        Me.MyDataGridView_Batch.AllowUserToAddRows = False
        Me.MyDataGridView_Batch.AllowUserToDeleteRows = False
        Me.MyDataGridView_Batch.AllowUserToResizeRows = False
        Me.MyDataGridView_Batch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Batch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Batch.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Batch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Batch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Batch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Batch.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Batch.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Batch.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Batch.MultiSelect = False
        Me.MyDataGridView_Batch.Name = "MyDataGridView_Batch"
        Me.MyDataGridView_Batch.RowHeadersVisible = False
        Me.MyDataGridView_Batch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Batch.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyDataGridView_Batch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Batch.Size = New System.Drawing.Size(852, 500)
        Me.MyDataGridView_Batch.TabIndex = 392
        '
        'mode
        '
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(271, 197)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(86, 22)
        Me.mode.TabIndex = 396
        Me.mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mode.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabBatch)
        Me.TabControl1.Controls.Add(Me.tabDetails)
        Me.TabControl1.Controls.Add(Me.tabVoidCancelled)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(866, 532)
        Me.TabControl1.TabIndex = 397
        '
        'tabBatch
        '
        Me.tabBatch.Controls.Add(Me.MyDataGridView_Batch)
        Me.tabBatch.Location = New System.Drawing.Point(4, 22)
        Me.tabBatch.Name = "tabBatch"
        Me.tabBatch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBatch.Size = New System.Drawing.Size(858, 506)
        Me.tabBatch.TabIndex = 0
        Me.tabBatch.Text = "Batch Transaction Summary"
        Me.tabBatch.UseVisualStyleBackColor = True
        '
        'tabDetails
        '
        Me.tabDetails.Controls.Add(Me.MyDataGridView_Detail)
        Me.tabDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabDetails.Name = "tabDetails"
        Me.tabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetails.Size = New System.Drawing.Size(858, 506)
        Me.tabDetails.TabIndex = 1
        Me.tabDetails.Text = "Detail Transaction History "
        Me.tabDetails.UseVisualStyleBackColor = True
        '
        'MyDataGridView_Detail
        '
        Me.MyDataGridView_Detail.AllowUserToAddRows = False
        Me.MyDataGridView_Detail.AllowUserToDeleteRows = False
        Me.MyDataGridView_Detail.AllowUserToResizeColumns = False
        Me.MyDataGridView_Detail.AllowUserToResizeRows = False
        Me.MyDataGridView_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_Detail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_Detail.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_Detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_Detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_Detail.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_Detail.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_Detail.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_Detail.MultiSelect = False
        Me.MyDataGridView_Detail.Name = "MyDataGridView_Detail"
        Me.MyDataGridView_Detail.ReadOnly = True
        Me.MyDataGridView_Detail.RowHeadersVisible = False
        Me.MyDataGridView_Detail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_Detail.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.MyDataGridView_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_Detail.Size = New System.Drawing.Size(852, 500)
        Me.MyDataGridView_Detail.TabIndex = 393
        '
        'tabVoidCancelled
        '
        Me.tabVoidCancelled.Controls.Add(Me.MyDataGridView_VoidCancelled)
        Me.tabVoidCancelled.Location = New System.Drawing.Point(4, 22)
        Me.tabVoidCancelled.Name = "tabVoidCancelled"
        Me.tabVoidCancelled.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVoidCancelled.Size = New System.Drawing.Size(858, 506)
        Me.tabVoidCancelled.TabIndex = 2
        Me.tabVoidCancelled.Text = "Voided and Cancelled Item Transaction"
        Me.tabVoidCancelled.UseVisualStyleBackColor = True
        '
        'MyDataGridView_VoidCancelled
        '
        Me.MyDataGridView_VoidCancelled.AllowUserToAddRows = False
        Me.MyDataGridView_VoidCancelled.AllowUserToDeleteRows = False
        Me.MyDataGridView_VoidCancelled.AllowUserToResizeRows = False
        Me.MyDataGridView_VoidCancelled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MyDataGridView_VoidCancelled.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MyDataGridView_VoidCancelled.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView_VoidCancelled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView_VoidCancelled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MyDataGridView_VoidCancelled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView_VoidCancelled.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView_VoidCancelled.Location = New System.Drawing.Point(3, 3)
        Me.MyDataGridView_VoidCancelled.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView_VoidCancelled.MultiSelect = False
        Me.MyDataGridView_VoidCancelled.Name = "MyDataGridView_VoidCancelled"
        Me.MyDataGridView_VoidCancelled.RowHeadersVisible = False
        Me.MyDataGridView_VoidCancelled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView_VoidCancelled.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.MyDataGridView_VoidCancelled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView_VoidCancelled.Size = New System.Drawing.Size(852, 500)
        Me.MyDataGridView_VoidCancelled.TabIndex = 393
        '
        'frmPOSPreviousTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(866, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSPreviousTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Transaction History"
        CType(Me.MyDataGridView_Batch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabBatch.ResumeLayout(False)
        Me.tabDetails.ResumeLayout(False)
        CType(Me.MyDataGridView_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVoidCancelled.ResumeLayout(False)
        CType(Me.MyDataGridView_VoidCancelled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MyDataGridView_Batch As System.Windows.Forms.DataGridView
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabBatch As System.Windows.Forms.TabPage
    Friend WithEvents tabDetails As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_Detail As System.Windows.Forms.DataGridView
    Friend WithEvents tabVoidCancelled As System.Windows.Forms.TabPage
    Friend WithEvents MyDataGridView_VoidCancelled As System.Windows.Forms.DataGridView
End Class
