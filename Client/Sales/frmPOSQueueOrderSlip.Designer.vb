<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOSQueueOrderSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOSQueueOrderSlip))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdVoid = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVoid})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(209, 26)
        '
        'cmdVoid
        '
        Me.cmdVoid.Image = Global.CoffeecupClient.My.Resources.Resources.cross
        Me.cmdVoid.Name = "cmdVoid"
        Me.cmdVoid.Size = New System.Drawing.Size(208, 22)
        Me.cmdVoid.Tag = "1"
        Me.cmdVoid.Text = "Void Selected Transaction"
        '
        'ImageMenu
        '
        Me.ImageMenu.ImageStream = CType(resources.GetObject("ImageMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageMenu.Images.SetKeyName(0, "Table-96.png")
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(832, 501)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'frmPOSCashiersQueueSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(832, 501)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPOSCashiersQueueSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdVoid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageMenu As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
