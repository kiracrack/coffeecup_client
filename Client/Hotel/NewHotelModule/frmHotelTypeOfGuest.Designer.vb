﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelTypeOfGuest
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescription
        '
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(101, 16)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(224, 22)
        Me.txtdescription.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(215, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Type of Guest"
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MyDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MyDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 75)
        Me.MyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.MyDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.MyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyDataGridView.Size = New System.Drawing.Size(356, 327)
        Me.MyDataGridView.TabIndex = 394
        '
        'frmHotelTypeOfGuest
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 404)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHotelTypeOfGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Type of Guest"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MyDataGridView As System.Windows.Forms.DataGridView

End Class
