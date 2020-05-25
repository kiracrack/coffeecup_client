<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSOnholdConfirmation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSOnholdConfirmation))
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.txtAdvancePayment = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.batchcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdAddPayment = New System.Windows.Forms.Button()
        Me.Em = New DevExpress.XtraGrid.GridControl()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdVoid = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.cmdConfirmPayment = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Em, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_em.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTransaction.Location = New System.Drawing.Point(110, 10)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(94, 15)
        Me.lblTransaction.TabIndex = 9
        Me.lblTransaction.Text = "Customer Name"
        '
        'txtAdvancePayment
        '
        Me.txtAdvancePayment.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.txtAdvancePayment.ForeColor = System.Drawing.Color.Black
        Me.txtAdvancePayment.Location = New System.Drawing.Point(112, 59)
        Me.txtAdvancePayment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAdvancePayment.Name = "txtAdvancePayment"
        Me.txtAdvancePayment.Size = New System.Drawing.Size(258, 41)
        Me.txtAdvancePayment.TabIndex = 1
        Me.txtAdvancePayment.Text = "0.00"
        Me.txtAdvancePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContactPerson
        '
        Me.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactPerson.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.ForeColor = System.Drawing.Color.Black
        Me.txtContactPerson.Location = New System.Drawing.Point(112, 29)
        Me.txtContactPerson.Margin = New System.Windows.Forms.Padding(5)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(371, 27)
        Me.txtContactPerson.TabIndex = 0
        Me.txtContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'batchcode
        '
        Me.batchcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.batchcode.ForeColor = System.Drawing.Color.Black
        Me.batchcode.Location = New System.Drawing.Point(14, 401)
        Me.batchcode.Margin = New System.Windows.Forms.Padding(5)
        Me.batchcode.Name = "batchcode"
        Me.batchcode.Size = New System.Drawing.Size(57, 22)
        Me.batchcode.TabIndex = 406
        Me.batchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.batchcode.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(248, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 15)
        Me.Label3.TabIndex = 407
        Me.Label3.Text = "Transaction Reference #10001009-1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdAddPayment
        '
        Me.cmdAddPayment.Location = New System.Drawing.Point(372, 58)
        Me.cmdAddPayment.Name = "cmdAddPayment"
        Me.cmdAddPayment.Size = New System.Drawing.Size(111, 43)
        Me.cmdAddPayment.TabIndex = 409
        Me.cmdAddPayment.Text = "Add Deposit"
        '
        'Em
        '
        Me.Em.ContextMenuStrip = Me.cms_em
        Me.Em.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.Em.Location = New System.Drawing.Point(25, 107)
        Me.Em.MainView = Me.GridView1
        Me.Em.Name = "Em"
        Me.Em.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit5})
        Me.Em.Size = New System.Drawing.Size(534, 187)
        Me.Em.TabIndex = 824
        Me.Em.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVoid})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(161, 26)
        '
        'cmdVoid
        '
        Me.cmdVoid.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdVoid.Name = "cmdVoid"
        Me.cmdVoid.Size = New System.Drawing.Size(160, 22)
        Me.cmdVoid.Tag = "1"
        Me.cmdVoid.Text = "Cancel Payment"
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseTextOptions = True
        Me.GridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.GridControl = Me.Em
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit5
        '
        Me.RepositoryItemPictureEdit5.Name = "RepositoryItemPictureEdit5"
        '
        'cmdConfirmPayment
        '
        Me.cmdConfirmPayment.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirmPayment.Appearance.Options.UseFont = True
        Me.cmdConfirmPayment.Location = New System.Drawing.Point(177, 300)
        Me.cmdConfirmPayment.Name = "cmdConfirmPayment"
        Me.cmdConfirmPayment.Size = New System.Drawing.Size(230, 42)
        Me.cmdConfirmPayment.TabIndex = 825
        Me.cmdConfirmPayment.Text = "Confirm Hold Transaction"
        '
        'frmPOSOnholdConfirmation
        '
        Me.AcceptButton = Me.cmdConfirmPayment
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(583, 354)
        Me.Controls.Add(Me.cmdConfirmPayment)
        Me.Controls.Add(Me.Em)
        Me.Controls.Add(Me.cmdAddPayment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.batchcode)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.txtAdvancePayment)
        Me.Controls.Add(Me.lblTransaction)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPOSOnholdConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "On Hold Transaction Confirmation"
        CType(Me.Em, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_em.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTransaction As System.Windows.Forms.Label
    Friend WithEvents txtAdvancePayment As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents batchcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAddPayment As System.Windows.Forms.Button
    Friend WithEvents Em As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdVoid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdConfirmPayment As DevExpress.XtraEditors.SimpleButton
End Class
