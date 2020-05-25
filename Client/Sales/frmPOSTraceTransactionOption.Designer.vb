<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSTraceTransactionOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSTraceTransactionOption))
        Me.cmdTracePreviousTransaction = New System.Windows.Forms.Button()
        Me.cmdTraceCurrentTransaction = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdTracePreviousTransaction
        '
        Me.cmdTracePreviousTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdTracePreviousTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTracePreviousTransaction.Location = New System.Drawing.Point(123, 22)
        Me.cmdTracePreviousTransaction.Name = "cmdTracePreviousTransaction"
        Me.cmdTracePreviousTransaction.Size = New System.Drawing.Size(197, 35)
        Me.cmdTracePreviousTransaction.TabIndex = 123512
        Me.cmdTracePreviousTransaction.Text = "Trace Previous Transaction"
        Me.cmdTracePreviousTransaction.UseVisualStyleBackColor = False
        '
        'cmdTraceCurrentTransaction
        '
        Me.cmdTraceCurrentTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdTraceCurrentTransaction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTraceCurrentTransaction.Location = New System.Drawing.Point(123, 60)
        Me.cmdTraceCurrentTransaction.Name = "cmdTraceCurrentTransaction"
        Me.cmdTraceCurrentTransaction.Size = New System.Drawing.Size(197, 35)
        Me.cmdTraceCurrentTransaction.TabIndex = 123513
        Me.cmdTraceCurrentTransaction.Text = "Trace Current Transaction"
        Me.cmdTraceCurrentTransaction.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTracePreviousTransaction)
        Me.GroupBox1.Controls.Add(Me.cmdTraceCurrentTransaction)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 108)
        Me.GroupBox1.TabIndex = 123514
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please select option of tracing sales transaction"
        '
        'frmPOSTraceTransactionOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 131)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSTraceTransactionOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Trace Option"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTracePreviousTransaction As System.Windows.Forms.Button
    Friend WithEvents cmdTraceCurrentTransaction As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
