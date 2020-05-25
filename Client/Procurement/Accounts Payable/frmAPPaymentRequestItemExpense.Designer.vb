<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucherOtherExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoucherOtherExpense))
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.trnid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.itemcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransactionName = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Gridview_TransactionName = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtCheckAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.voucherno = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.companyid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mode
        '
        Me.mode.Location = New System.Drawing.Point(234, 213)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Properties.ReadOnly = True
        Me.mode.Size = New System.Drawing.Size(55, 20)
        Me.mode.TabIndex = 761
        Me.mode.Visible = False
        '
        'trnid
        '
        Me.trnid.Location = New System.Drawing.Point(173, 213)
        Me.trnid.Name = "trnid"
        Me.trnid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trnid.Properties.Appearance.Options.UseFont = True
        Me.trnid.Properties.ReadOnly = True
        Me.trnid.Size = New System.Drawing.Size(55, 20)
        Me.trnid.TabIndex = 760
        Me.trnid.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 17)
        Me.LabelControl3.TabIndex = 759
        Me.LabelControl3.Text = "Expense Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(138, 78)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(319, 60)
        Me.txtRemarks.TabIndex = 753
        '
        'itemcode
        '
        Me.itemcode.EnterMoveNextControl = True
        Me.itemcode.Location = New System.Drawing.Point(117, 213)
        Me.itemcode.Name = "itemcode"
        Me.itemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.itemcode.Properties.Appearance.Options.UseFont = True
        Me.itemcode.Size = New System.Drawing.Size(50, 20)
        Me.itemcode.TabIndex = 758
        Me.itemcode.Visible = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(21, 23)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(106, 17)
        Me.LabelControl9.TabIndex = 757
        Me.LabelControl9.Text = "Transaction Name"
        '
        'txtTransactionName
        '
        Me.txtTransactionName.EditValue = "Select Group"
        Me.txtTransactionName.Location = New System.Drawing.Point(138, 19)
        Me.txtTransactionName.Name = "txtTransactionName"
        Me.txtTransactionName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.75!)
        Me.txtTransactionName.Properties.Appearance.Options.UseFont = True
        Me.txtTransactionName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTransactionName.Properties.DisplayMember = "Item Name"
        Me.txtTransactionName.Properties.NullText = ""
        Me.txtTransactionName.Properties.PopupView = Me.Gridview_TransactionName
        Me.txtTransactionName.Properties.ValueMember = "itemcode"
        Me.txtTransactionName.Size = New System.Drawing.Size(232, 26)
        Me.txtTransactionName.TabIndex = 751
        '
        'Gridview_TransactionName
        '
        Me.Gridview_TransactionName.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Gridview_TransactionName.Name = "Gridview_TransactionName"
        Me.Gridview_TransactionName.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Gridview_TransactionName.OptionsView.ShowGroupPanel = False
        '
        'txtCheckAmount
        '
        Me.txtCheckAmount.EditValue = "0.00"
        Me.txtCheckAmount.Location = New System.Drawing.Point(138, 49)
        Me.txtCheckAmount.Name = "txtCheckAmount"
        Me.txtCheckAmount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCheckAmount.Properties.Appearance.Options.UseFont = True
        Me.txtCheckAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCheckAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCheckAmount.Properties.Mask.EditMask = "n"
        Me.txtCheckAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCheckAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCheckAmount.Size = New System.Drawing.Size(154, 26)
        Me.txtCheckAmount.TabIndex = 752
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(83, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 15)
        Me.LabelControl4.TabIndex = 756
        Me.LabelControl4.Text = "Amount"
        '
        'voucherno
        '
        Me.voucherno.Location = New System.Drawing.Point(56, 213)
        Me.voucherno.Name = "voucherno"
        Me.voucherno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherno.Properties.Appearance.Options.UseFont = True
        Me.voucherno.Properties.ReadOnly = True
        Me.voucherno.Size = New System.Drawing.Size(55, 20)
        Me.voucherno.TabIndex = 755
        Me.voucherno.Visible = False
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
        Me.cmdSave.Location = New System.Drawing.Point(303, 144)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 30)
        Me.cmdSave.TabIndex = 754
        Me.cmdSave.Text = "Confirm Save"
        '
        'companyid
        '
        Me.companyid.Location = New System.Drawing.Point(56, 239)
        Me.companyid.Name = "companyid"
        Me.companyid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.companyid.Properties.Appearance.Options.UseFont = True
        Me.companyid.Properties.ReadOnly = True
        Me.companyid.Size = New System.Drawing.Size(55, 20)
        Me.companyid.TabIndex = 762
        Me.companyid.Visible = False
        '
        'frmVoucherOtherExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(473, 189)
        Me.Controls.Add(Me.companyid)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.trnid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.itemcode)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtTransactionName)
        Me.Controls.Add(Me.txtCheckAmount)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.voucherno)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucherOtherExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Expense Item"
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trnid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransactionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridview_TransactionName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCheckAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voucherno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.companyid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents trnid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents itemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransactionName As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents Gridview_TransactionName As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCheckAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents voucherno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents companyid As DevExpress.XtraEditors.TextEdit
End Class
