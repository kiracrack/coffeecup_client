﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportType))
        Me.cmdConsumable = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdFFE = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdConsumable
        '
        Me.cmdConsumable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConsumable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConsumable.Location = New System.Drawing.Point(105, 22)
        Me.cmdConsumable.Name = "cmdConsumable"
        Me.cmdConsumable.Size = New System.Drawing.Size(227, 30)
        Me.cmdConsumable.TabIndex = 7
        Me.cmdConsumable.Text = "System Report Generator"
        Me.cmdConsumable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdConsumable)
        Me.GroupBox1.Controls.Add(Me.cmdFFE)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please select report type"
        '
        'cmdFFE
        '
        Me.cmdFFE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdFFE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFFE.Location = New System.Drawing.Point(105, 55)
        Me.cmdFFE.Name = "cmdFFE"
        Me.cmdFFE.Size = New System.Drawing.Size(227, 30)
        Me.cmdFFE.TabIndex = 8
        Me.cmdFFE.Text = "VIP Report Monitoring"
        Me.cmdFFE.UseVisualStyleBackColor = True
        '
        'frmReportType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(366, 123)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReportType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Type"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConsumable As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdFFE As System.Windows.Forms.Button
End Class
