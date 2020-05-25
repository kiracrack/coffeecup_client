<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicAttendingPersonnel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClinicAttendingPersonnel))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckAttendingPersonnel = New System.Windows.Forms.CheckedListBox()
        Me.cmdProceed = New System.Windows.Forms.Button()
        Me.schedid = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.TextBox()
        Me.serviceid = New System.Windows.Forms.TextBox()
        Me.serviceno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 466
        Me.Label1.Text = "Select Attending Personnel"
        '
        'ckAttendingPersonnel
        '
        Me.ckAttendingPersonnel.CheckOnClick = True
        Me.ckAttendingPersonnel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckAttendingPersonnel.FormattingEnabled = True
        Me.ckAttendingPersonnel.Location = New System.Drawing.Point(10, 31)
        Me.ckAttendingPersonnel.Name = "ckAttendingPersonnel"
        Me.ckAttendingPersonnel.Size = New System.Drawing.Size(363, 238)
        Me.ckAttendingPersonnel.TabIndex = 2
        '
        'cmdProceed
        '
        Me.cmdProceed.BackColor = System.Drawing.Color.Khaki
        Me.cmdProceed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdProceed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProceed.Location = New System.Drawing.Point(91, 273)
        Me.cmdProceed.Name = "cmdProceed"
        Me.cmdProceed.Size = New System.Drawing.Size(200, 34)
        Me.cmdProceed.TabIndex = 467
        Me.cmdProceed.Text = "Confirm Clear"
        Me.cmdProceed.UseVisualStyleBackColor = False
        '
        'schedid
        '
        Me.schedid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.schedid.ForeColor = System.Drawing.Color.Black
        Me.schedid.Location = New System.Drawing.Point(123, 362)
        Me.schedid.Margin = New System.Windows.Forms.Padding(5)
        Me.schedid.Name = "schedid"
        Me.schedid.Size = New System.Drawing.Size(47, 23)
        Me.schedid.TabIndex = 468
        Me.schedid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'productid
        '
        Me.productid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.productid.ForeColor = System.Drawing.Color.Black
        Me.productid.Location = New System.Drawing.Point(189, 362)
        Me.productid.Margin = New System.Windows.Forms.Padding(5)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(47, 23)
        Me.productid.TabIndex = 469
        Me.productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'serviceid
        '
        Me.serviceid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.serviceid.ForeColor = System.Drawing.Color.Black
        Me.serviceid.Location = New System.Drawing.Point(123, 395)
        Me.serviceid.Margin = New System.Windows.Forms.Padding(5)
        Me.serviceid.Name = "serviceid"
        Me.serviceid.Size = New System.Drawing.Size(47, 23)
        Me.serviceid.TabIndex = 470
        Me.serviceid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'serviceno
        '
        Me.serviceno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.serviceno.ForeColor = System.Drawing.Color.Black
        Me.serviceno.Location = New System.Drawing.Point(189, 395)
        Me.serviceno.Margin = New System.Windows.Forms.Padding(5)
        Me.serviceno.Name = "serviceno"
        Me.serviceno.Size = New System.Drawing.Size(47, 23)
        Me.serviceno.TabIndex = 471
        Me.serviceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmClinicAttendingPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(384, 315)
        Me.Controls.Add(Me.serviceno)
        Me.Controls.Add(Me.serviceid)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.schedid)
        Me.Controls.Add(Me.cmdProceed)
        Me.Controls.Add(Me.ckAttendingPersonnel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClinicAttendingPersonnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attending Personnel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckAttendingPersonnel As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdProceed As System.Windows.Forms.Button
    Friend WithEvents schedid As System.Windows.Forms.TextBox
    Friend WithEvents productid As System.Windows.Forms.TextBox
    Friend WithEvents serviceid As System.Windows.Forms.TextBox
    Friend WithEvents serviceno As System.Windows.Forms.TextBox
End Class
