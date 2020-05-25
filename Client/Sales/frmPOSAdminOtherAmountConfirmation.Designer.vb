<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSAdminOtherAmountConfirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSAdminOtherAmountConfirmation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please Enter Authorized User Account"
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(91, 89)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(187, 22)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = "Username"
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtpassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.Location = New System.Drawing.Point(91, 113)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(187, 20)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.Text = "Password"
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirm.Location = New System.Drawing.Point(125, 136)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(118, 28)
        Me.cmdConfirm.TabIndex = 15
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'userid
        '
        Me.userid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.userid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userid.Location = New System.Drawing.Point(293, 184)
        Me.userid.Margin = New System.Windows.Forms.Padding(4)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(60, 22)
        Me.userid.TabIndex = 16
        Me.userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.userid.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(61, 30)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(247, 31)
        Me.txtAmount.TabIndex = 0
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(126, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Please Enter Amount"
        '
        'frmPOSAdminOtherAmountConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(355, 180)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.userid)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSAdminOtherAmountConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authorized Confirmation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents userid As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
