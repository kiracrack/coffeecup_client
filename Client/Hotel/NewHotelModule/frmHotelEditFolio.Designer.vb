<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotelEditFolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHotelEditFolio))
        Me.cmdConfirmPayment = New System.Windows.Forms.Button()
        Me.txtPax = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDateArival = New System.Windows.Forms.DateTimePicker()
        Me.txtDeparture = New System.Windows.Forms.DateTimePicker()
        Me.folioid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChild = New System.Windows.Forms.TextBox()
        Me.txtExtra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.foliono = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdConfirmPayment.ForeColor = System.Drawing.Color.Black
        Me.cmdConfirmPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(184, 181)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(145, 34)
        Me.cmdConfirmPayment.TabIndex = 19
        Me.cmdConfirmPayment.Text = "Confirm"
        Me.cmdConfirmPayment.UseVisualStyleBackColor = False
        '
        'txtPax
        '
        Me.txtPax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPax.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPax.ForeColor = System.Drawing.Color.Black
        Me.txtPax.Location = New System.Drawing.Point(226, 97)
        Me.txtPax.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPax.Name = "txtPax"
        Me.txtPax.Size = New System.Drawing.Size(103, 23)
        Me.txtPax.TabIndex = 0
        Me.txtPax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label20.Location = New System.Drawing.Point(55, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 20)
        Me.Label20.TabIndex = 466
        Me.Label20.Text = "Room Information"
        '
        'txtDateArival
        '
        Me.txtDateArival.CustomFormat = "MMMM dd, yyyy"
        Me.txtDateArival.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDateArival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateArival.Location = New System.Drawing.Point(129, 46)
        Me.txtDateArival.Name = "txtDateArival"
        Me.txtDateArival.Size = New System.Drawing.Size(200, 22)
        Me.txtDateArival.TabIndex = 816
        '
        'txtDeparture
        '
        Me.txtDeparture.CustomFormat = "MMMM dd, yyyy"
        Me.txtDeparture.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDeparture.Location = New System.Drawing.Point(129, 71)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(200, 22)
        Me.txtDeparture.TabIndex = 817
        '
        'folioid
        '
        Me.folioid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.folioid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.folioid.ForeColor = System.Drawing.Color.Black
        Me.folioid.Location = New System.Drawing.Point(127, 300)
        Me.folioid.Margin = New System.Windows.Forms.Padding(5)
        Me.folioid.Name = "folioid"
        Me.folioid.Size = New System.Drawing.Size(59, 23)
        Me.folioid.TabIndex = 827
        Me.folioid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 828
        Me.Label1.Text = "Arrival"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(64, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 829
        Me.Label2.Text = "Departure"
        '
        'txtChild
        '
        Me.txtChild.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChild.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChild.ForeColor = System.Drawing.Color.Black
        Me.txtChild.Location = New System.Drawing.Point(226, 124)
        Me.txtChild.Margin = New System.Windows.Forms.Padding(5)
        Me.txtChild.Name = "txtChild"
        Me.txtChild.Size = New System.Drawing.Size(103, 23)
        Me.txtChild.TabIndex = 830
        Me.txtChild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExtra
        '
        Me.txtExtra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExtra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExtra.ForeColor = System.Drawing.Color.Black
        Me.txtExtra.Location = New System.Drawing.Point(226, 150)
        Me.txtExtra.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Size = New System.Drawing.Size(103, 23)
        Me.txtExtra.TabIndex = 831
        Me.txtExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(181, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 832
        Me.Label3.Text = "Adult"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(182, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 833
        Me.Label4.Text = "Child"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(146, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 834
        Me.Label5.Text = "Extra Person"
        '
        'foliono
        '
        Me.foliono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.foliono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.foliono.ForeColor = System.Drawing.Color.Black
        Me.foliono.Location = New System.Drawing.Point(196, 300)
        Me.foliono.Margin = New System.Windows.Forms.Padding(5)
        Me.foliono.Name = "foliono"
        Me.foliono.Size = New System.Drawing.Size(59, 23)
        Me.foliono.TabIndex = 835
        Me.foliono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'roomtype
        '
        Me.roomtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.roomtype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.roomtype.ForeColor = System.Drawing.Color.Black
        Me.roomtype.Location = New System.Drawing.Point(58, 300)
        Me.roomtype.Margin = New System.Windows.Forms.Padding(5)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(59, 23)
        Me.roomtype.TabIndex = 840
        Me.roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHotelEditFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(371, 240)
        Me.Controls.Add(Me.roomtype)
        Me.Controls.Add(Me.foliono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtExtra)
        Me.Controls.Add(Me.txtChild)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.folioid)
        Me.Controls.Add(Me.txtDateArival)
        Me.Controls.Add(Me.txtDeparture)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtPax)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHotelEditFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConfirmPayment As System.Windows.Forms.Button
    Friend WithEvents txtPax As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDateArival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents folioid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtChild As System.Windows.Forms.TextBox
    Friend WithEvents txtExtra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents foliono As System.Windows.Forms.TextBox
    Friend WithEvents roomtype As System.Windows.Forms.TextBox
End Class
