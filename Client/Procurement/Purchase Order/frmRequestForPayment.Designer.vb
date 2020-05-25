<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestForPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestForPayment))
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.txtApprovingLevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start_Button
        '
        Me.Start_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Start_Button.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Button.Location = New System.Drawing.Point(134, 40)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(129, 31)
        Me.Start_Button.TabIndex = 1
        Me.Start_Button.Text = "Confirm Request"
        Me.Start_Button.UseVisualStyleBackColor = False
        '
        'txtApprovingLevel
        '
        Me.txtApprovingLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtApprovingLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtApprovingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtApprovingLevel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovingLevel.ForeColor = System.Drawing.Color.Black
        Me.txtApprovingLevel.FormattingEnabled = True
        Me.txtApprovingLevel.ItemHeight = 17
        Me.txtApprovingLevel.Items.AddRange(New Object() {"BRANCH LEVEL", "CORPORATE OFFICE"})
        Me.txtApprovingLevel.Location = New System.Drawing.Point(134, 12)
        Me.txtApprovingLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApprovingLevel.Name = "txtApprovingLevel"
        Me.txtApprovingLevel.Size = New System.Drawing.Size(253, 25)
        Me.txtApprovingLevel.TabIndex = 385
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 386
        Me.Label4.Text = "Disbursing Office"
        '
        'frmRequestForPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 85)
        Me.Controls.Add(Me.txtApprovingLevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Start_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRequestForPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request for payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents txtApprovingLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
