<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcctVoucherDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcctVoucherDetails))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtPONumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransactionName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvoiceNo = New DevExpress.XtraEditors.TextEdit()
        Me.supplierid = New DevExpress.XtraEditors.TextEdit()
        Me.suppliername = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPONumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supplierid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.suppliername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(102, 165)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 17)
        Me.LabelControl3.TabIndex = 759
        Me.LabelControl3.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(142, 162)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Size = New System.Drawing.Size(319, 60)
        Me.txtNote.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.EditValue = "0.00"
        Me.txtAmount.Location = New System.Drawing.Point(142, 106)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtAmount.Properties.Appearance.Options.UseFont = True
        Me.txtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAmount.Properties.Mask.EditMask = "n"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmount.Size = New System.Drawing.Size(154, 26)
        Me.txtAmount.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(87, 112)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl4.TabIndex = 756
        Me.LabelControl4.Text = "Amount"
        '
        'cmdSave
        '
        Me.cmdSave.Appearance.BackColor = System.Drawing.Color.Green
        Me.cmdSave.Appearance.BackColor2 = System.Drawing.Color.Green
        Me.cmdSave.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdSave.Appearance.Options.UseBackColor = True
        Me.cmdSave.Appearance.Options.UseFont = True
        Me.cmdSave.Appearance.Options.UseForeColor = True
        Me.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSave.Location = New System.Drawing.Point(142, 228)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 30)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Confirm Save"
        '
        'voucherno
        '
        Me.voucherno.Location = New System.Drawing.Point(108, 358)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(55, 20)
        Me.voucherno.TabIndex = 755
        Me.voucherno.Visible = False
        '
        'trnid
        '
        Me.trnid.Location = New System.Drawing.Point(291, 359)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(55, 20)
        Me.trnid.TabIndex = 760
        Me.trnid.Visible = False
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(352, 359)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(55, 20)
        Me.mode.TabIndex = 761
        Me.mode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(60, 28)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(71, 17)
        Me.LabelControl8.TabIndex = 771
        Me.LabelControl8.Text = "Invoice Date"
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.EditValue = New Date(CType(0, Long))
        Me.txtInvoiceDate.EnterMoveNextControl = True
        Me.txtInvoiceDate.Location = New System.Drawing.Point(142, 25)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInvoiceDate.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtInvoiceDate.Properties.Mask.EditMask = "MMMM dd, yyyy"
        Me.txtInvoiceDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInvoiceDate.Size = New System.Drawing.Size(232, 24)
        Me.txtInvoiceDate.TabIndex = 0
        '
        'txtPONumber
        '
        Me.txtPONumber.EditValue = ""
        Me.txtPONumber.Location = New System.Drawing.Point(142, 52)
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPONumber.Properties.Appearance.Options.UseFont = True
        Me.txtPONumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPONumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPONumber.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPONumber.Size = New System.Drawing.Size(153, 24)
        Me.txtPONumber.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(62, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl1.TabIndex = 773
        Me.LabelControl1.Text = "PO Number"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 138)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(106, 17)
        Me.LabelControl2.TabIndex = 775
        Me.LabelControl2.Text = "Transaction Name"
        '
        'txtTransactionName
        '
        Me.txtTransactionName.EditValue = ""
        Me.txtTransactionName.Location = New System.Drawing.Point(142, 135)
        Me.txtTransactionName.Name = "txtTransactionName"
        Me.txtTransactionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTransactionName.Properties.Appearance.Options.UseFont = True
        Me.txtTransactionName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransactionName.Size = New System.Drawing.Size(319, 24)
        Me.txtTransactionName.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(69, 82)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 17)
        Me.LabelControl5.TabIndex = 777
        Me.LabelControl5.Text = "Invoice No"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.EditValue = ""
        Me.txtInvoiceNo.Location = New System.Drawing.Point(142, 79)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInvoiceNo.Properties.Appearance.Options.UseFont = True
        Me.txtInvoiceNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvoiceNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtInvoiceNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInvoiceNo.Size = New System.Drawing.Size(153, 24)
        Me.txtInvoiceNo.TabIndex = 2
        '
        'supplierid
        '
        Me.supplierid.Location = New System.Drawing.Point(169, 358)
        Me.supplierid.Name = "supplierid"
        Me.supplierid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplierid.Properties.Appearance.Options.UseFont = True
        Me.supplierid.Properties.ReadOnly = True
        Me.supplierid.Size = New System.Drawing.Size(55, 20)
        Me.supplierid.TabIndex = 778
        Me.supplierid.Visible = False
        '
        'suppliername
        '
        Me.suppliername.Location = New System.Drawing.Point(230, 358)
        Me.suppliername.Name = "suppliername"
        Me.suppliername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppliername.Properties.Appearance.Options.UseFont = True
        Me.suppliername.Properties.ReadOnly = True
        Me.suppliername.Size = New System.Drawing.Size(55, 20)
        Me.suppliername.TabIndex = 779
        Me.suppliername.Visible = False
        '
        'frmAcctVoucherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(509, 284)
        Me.Controls.Add(Me.suppliername)
        Me.Controls.Add(Me.supplierid)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTransactionName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtPONumber)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcctVoucherDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Item Details"
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPONumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supplierid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.suppliername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPONumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransactionName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvoiceNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents supplierid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents suppliername As DevExpress.XtraEditors.TextEdit
End Class
