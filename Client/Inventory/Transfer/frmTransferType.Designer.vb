<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferType))
        Me.cmdProcessing = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRequisition = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdProcessing
        '
        Me.cmdProcessing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProcessing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProcessing.Location = New System.Drawing.Point(133, 22)
        Me.cmdProcessing.Name = "cmdProcessing"
        Me.cmdProcessing.Size = New System.Drawing.Size(199, 30)
        Me.cmdProcessing.TabIndex = 7
        Me.cmdProcessing.Text = "Stock Transfer Processing"
        Me.cmdProcessing.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdProcessing)
        Me.GroupBox1.Controls.Add(Me.cmdRequisition)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Transfer Management Tool"
        '
        'cmdRequisition
        '
        Me.cmdRequisition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdRequisition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRequisition.Location = New System.Drawing.Point(133, 55)
        Me.cmdRequisition.Name = "cmdRequisition"
        Me.cmdRequisition.Size = New System.Drawing.Size(199, 30)
        Me.cmdRequisition.TabIndex = 8
        Me.cmdRequisition.Text = "Stock Transfer Requisition"
        Me.cmdRequisition.UseVisualStyleBackColor = True
        '
        'frmTransferType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 119)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransferType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please select transfer management tool"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdProcessing As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRequisition As System.Windows.Forms.Button
End Class
