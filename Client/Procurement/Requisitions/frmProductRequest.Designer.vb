<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductRequest))
        Me.Stop_Button = New System.Windows.Forms.Button()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdLocalData = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdOnlineData = New System.Windows.Forms.ToolStripMenuItem()
        Me.My_BgWorker = New System.ComponentModel.BackgroundWorker()
        Me.picicon = New System.Windows.Forms.PictureBox()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cms_em.SuspendLayout()
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stop_Button
        '
        Me.Stop_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Stop_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Stop_Button.Location = New System.Drawing.Point(291, 167)
        Me.Stop_Button.Name = "Stop_Button"
        Me.Stop_Button.Size = New System.Drawing.Size(99, 30)
        Me.Stop_Button.TabIndex = 4
        Me.Stop_Button.Text = "Close"
        Me.Stop_Button.UseVisualStyleBackColor = True
        '
        'Start_Button
        '
        Me.Start_Button.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Start_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Start_Button.Location = New System.Drawing.Point(133, 167)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(152, 30)
        Me.Start_Button.TabIndex = 3
        Me.Start_Button.Text = "Send Request"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbldescription.ForeColor = System.Drawing.Color.Gray
        Me.lbldescription.Location = New System.Drawing.Point(59, 32)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(362, 15)
        Me.lbldescription.TabIndex = 334
        Me.lbldescription.Text = "You can use this service to create request and send to main server"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(9, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 15)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbltitle.Location = New System.Drawing.Point(59, 13)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(271, 19)
        Me.lbltitle.TabIndex = 333
        Me.lbltitle.Text = "Request Particular Item Registration Form"
        '
        'txtUnit
        '
        Me.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtUnit.DropDownHeight = 130
        Me.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUnit.ForeColor = System.Drawing.Color.Black
        Me.txtUnit.FormattingEnabled = True
        Me.txtUnit.IntegralHeight = False
        Me.txtUnit.ItemHeight = 13
        Me.txtUnit.Location = New System.Drawing.Point(134, 87)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnit.MaxDropDownItems = 7
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(134, 21)
        Me.txtUnit.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(67, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 369
        Me.Label2.Text = "Unit Type"
        '
        'txtProductname
        '
        Me.txtProductname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProductname.ForeColor = System.Drawing.Color.Black
        Me.txtProductname.Location = New System.Drawing.Point(134, 62)
        Me.txtProductname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductname.Name = "txtProductname"
        Me.txtProductname.Size = New System.Drawing.Size(209, 22)
        Me.txtProductname.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(32, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 15)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Particular Name"
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditChapterToolStripMenuItem, Me.cmdLocalData, Me.ToolStripSeparator4, Me.cmdOnlineData})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(194, 76)
        '
        'EditChapterToolStripMenuItem
        '
        Me.EditChapterToolStripMenuItem.Image = Global.CoffeecupClient.My.Resources.Resources.application_task
        Me.EditChapterToolStripMenuItem.Name = "EditChapterToolStripMenuItem"
        Me.EditChapterToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EditChapterToolStripMenuItem.Text = "Column Chooser"
        '
        'cmdLocalData
        '
        Me.cmdLocalData.Image = Global.CoffeecupClient.My.Resources.Resources.arrow_continue_090
        Me.cmdLocalData.Name = "cmdLocalData"
        Me.cmdLocalData.Size = New System.Drawing.Size(193, 22)
        Me.cmdLocalData.Tag = "1"
        Me.cmdLocalData.Text = "Refresh Data"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'cmdOnlineData
        '
        Me.cmdOnlineData.Image = Global.CoffeecupClient.My.Resources.Resources.Network_Drive_Connected__3_
        Me.cmdOnlineData.Name = "cmdOnlineData"
        Me.cmdOnlineData.Size = New System.Drawing.Size(193, 22)
        Me.cmdOnlineData.Tag = "0"
        Me.cmdOnlineData.Text = "Online Current Update"
        '
        'My_BgWorker
        '
        Me.My_BgWorker.WorkerReportsProgress = True
        Me.My_BgWorker.WorkerSupportsCancellation = True
        '
        'picicon
        '
        Me.picicon.BackgroundImage = Global.CoffeecupClient.My.Resources.Resources.Paper_pencil
        Me.picicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picicon.Location = New System.Drawing.Point(16, 6)
        Me.picicon.Name = "picicon"
        Me.picicon.Size = New System.Drawing.Size(44, 43)
        Me.picicon.TabIndex = 336
        Me.picicon.TabStop = False
        '
        'txtmessage
        '
        Me.txtmessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtmessage.ForeColor = System.Drawing.Color.Black
        Me.txtmessage.Location = New System.Drawing.Point(134, 111)
        Me.txtmessage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtmessage.Size = New System.Drawing.Size(277, 52)
        Me.txtmessage.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(71, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Message"
        '
        'frmProductRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(492, 210)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picicon)
        Me.Controls.Add(Me.txtProductname)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Stop_Button)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProductRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Information"
        Me.cms_em.ResumeLayout(False)
        CType(Me.picicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Stop_Button As System.Windows.Forms.Button
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents picicon As System.Windows.Forms.PictureBox
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProductname As System.Windows.Forms.TextBox
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditChapterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdLocalData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdOnlineData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents My_BgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmessage As System.Windows.Forms.TextBox
End Class
