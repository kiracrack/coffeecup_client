<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLJournalDetails
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
        Me.ckDebit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCredit = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.mode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTicketNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblTotalPurchase = New DevExpress.XtraEditors.LabelControl()
        Me.txtDebit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.gridItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        CType(Me.ckDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckDebit
        '
        Me.ckDebit.Location = New System.Drawing.Point(396, 112)
        Me.ckDebit.Name = "ckDebit"
        Me.ckDebit.Properties.Caption = "debit"
        Me.ckDebit.Size = New System.Drawing.Size(63, 19)
        Me.ckDebit.TabIndex = 745
        Me.ckDebit.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(158, 154)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 15)
        Me.LabelControl1.TabIndex = 743
        Me.LabelControl1.Text = "Credit"
        '
        'txtCredit
        '
        Me.txtCredit.EditValue = ""
        Me.txtCredit.Location = New System.Drawing.Point(197, 148)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtCredit.Properties.Appearance.Options.UseFont = True
        Me.txtCredit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCredit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCredit.Properties.Mask.EditMask = "n"
        Me.txtCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredit.Size = New System.Drawing.Size(173, 26)
        Me.txtCredit.TabIndex = 735
        '
        'id
        '
        Me.id.EnterMoveNextControl = True
        Me.id.Location = New System.Drawing.Point(234, 341)
        Me.id.Name = "id"
        Me.id.Properties.Appearance.Options.UseFont = True
        Me.id.Size = New System.Drawing.Size(82, 20)
        Me.id.TabIndex = 742
        Me.id.Visible = False
        '
        'mode
        '
        Me.mode.EnterMoveNextControl = True
        Me.mode.Location = New System.Drawing.Point(323, 341)
        Me.mode.Name = "mode"
        Me.mode.Properties.Appearance.Options.UseFont = True
        Me.mode.Size = New System.Drawing.Size(82, 20)
        Me.mode.TabIndex = 741
        Me.mode.Visible = False
        '
        'txtTicketNo
        '
        Me.txtTicketNo.EnterMoveNextControl = True
        Me.txtTicketNo.Location = New System.Drawing.Point(139, 341)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.Properties.Appearance.Options.UseFont = True
        Me.txtTicketNo.Size = New System.Drawing.Size(82, 20)
        Me.txtTicketNo.TabIndex = 740
        Me.txtTicketNo.Visible = False
        '
        'lblTotalPurchase
        '
        Me.lblTotalPurchase.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalPurchase.Appearance.Options.UseFont = True
        Me.lblTotalPurchase.Location = New System.Drawing.Point(162, 124)
        Me.lblTotalPurchase.Name = "lblTotalPurchase"
        Me.lblTotalPurchase.Size = New System.Drawing.Size(28, 15)
        Me.lblTotalPurchase.TabIndex = 739
        Me.lblTotalPurchase.Text = "Debit"
        '
        'txtDebit
        '
        Me.txtDebit.EditValue = ""
        Me.txtDebit.Location = New System.Drawing.Point(197, 119)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDebit.Properties.Appearance.Options.UseFont = True
        Me.txtDebit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDebit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDebit.Properties.Mask.EditMask = "n"
        Me.txtDebit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebit.Size = New System.Drawing.Size(173, 26)
        Me.txtDebit.TabIndex = 734
        '
        'ItemCode
        '
        Me.ItemCode.EnterMoveNextControl = True
        Me.ItemCode.Location = New System.Drawing.Point(411, 341)
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.Properties.Appearance.Options.UseFont = True
        Me.ItemCode.Size = New System.Drawing.Size(82, 20)
        Me.ItemCode.TabIndex = 738
        Me.ItemCode.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(27, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(223, 15)
        Me.LabelControl3.TabIndex = 737
        Me.LabelControl3.Text = "Select account title for specific transaction"
        '
        'txtItem
        '
        Me.txtItem.EditValue = ""
        Me.txtItem.Location = New System.Drawing.Point(27, 35)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtItem.Properties.DisplayMember = "itemname"
        Me.txtItem.Properties.NullText = ""
        Me.txtItem.Properties.PopupView = Me.gridItem
        Me.txtItem.Properties.ValueMember = "itemcode"
        Me.txtItem.Size = New System.Drawing.Size(343, 26)
        Me.txtItem.TabIndex = 732
        '
        'gridItem
        '
        Me.gridItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridItem.Name = "gridItem"
        Me.gridItem.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridItem.OptionsView.ShowGroupPanel = False
        '
        'cmdOk
        '
        Me.cmdOk.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdOk.Appearance.Options.UseFont = True
        Me.cmdOk.Location = New System.Drawing.Point(197, 180)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(173, 30)
        Me.cmdOk.TabIndex = 736
        Me.cmdOk.Text = "Add to Journal"
        '
        'txtNote
        '
        Me.txtNote.EditValue = ""
        Me.txtNote.Location = New System.Drawing.Point(27, 65)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Properties.Appearance.Options.UseFont = True
        Me.txtNote.Properties.NullValuePrompt = "Specific item remarks.."
        Me.txtNote.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtNote.Size = New System.Drawing.Size(343, 49)
        Me.txtNote.TabIndex = 733
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'frmGLJournalDetails
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(407, 231)
        Me.Controls.Add(Me.ckDebit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtTicketNo)
        Me.Controls.Add(Me.lblTotalPurchase)
        Me.Controls.Add(Me.txtDebit)
        Me.Controls.Add(Me.ItemCode)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmGLJournalDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Entry Item"
        CType(Me.ckDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTicketNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckDebit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTicketNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotalPurchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDebit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents gridItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
End Class
