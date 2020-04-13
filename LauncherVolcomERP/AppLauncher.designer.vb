<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppLauncher
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppLauncher))
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LVersion = New DevExpress.XtraEditors.LabelControl()
        Me.BLaunch = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(10, 11)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(464, 34)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'LVersion
        '
        Me.LVersion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LVersion.Location = New System.Drawing.Point(0, 0)
        Me.LVersion.Name = "LVersion"
        Me.LVersion.Size = New System.Drawing.Size(45, 13)
        Me.LVersion.TabIndex = 1
        Me.LVersion.Text = "Version : "
        '
        'BLaunch
        '
        Me.BLaunch.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BLaunch.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BLaunch.Appearance.Options.UseBackColor = True
        Me.BLaunch.Appearance.Options.UseForeColor = True
        Me.BLaunch.Location = New System.Drawing.Point(480, 11)
        Me.BLaunch.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gainsboro
        Me.BLaunch.LookAndFeel.SkinName = "Metropolis"
        Me.BLaunch.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BLaunch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BLaunch.Name = "BLaunch"
        Me.BLaunch.Size = New System.Drawing.Size(149, 34)
        Me.BLaunch.TabIndex = 3
        Me.BLaunch.Text = "Launch"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LVersion)
        Me.PanelControl2.Location = New System.Drawing.Point(10, 51)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(619, 19)
        Me.PanelControl2.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(80, 100)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 20)
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.ProgressBarControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Controls.Add(Me.BLaunch)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 296)
        Me.PanelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(643, 81)
        Me.PanelControl3.TabIndex = 6
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(643, 296)
        Me.PictureEdit1.TabIndex = 7
        '
        'AppLauncher
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 377)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.PanelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "AppLauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BLaunch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
