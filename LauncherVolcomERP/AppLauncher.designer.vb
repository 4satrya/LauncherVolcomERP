<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppLauncher
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppLauncher))
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LVersion = New DevExpress.XtraEditors.LabelControl()
        Me.BLaunch = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BStart = New DevExpress.XtraEditors.SimpleButton()
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
        Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(481, 12)
        Me.ProgressBarControl1.TabIndex = 0
        '
        'LVersion
        '
        Me.LVersion.Appearance.ForeColor = System.Drawing.Color.White
        Me.LVersion.Dock = System.Windows.Forms.DockStyle.Left
        Me.LVersion.Location = New System.Drawing.Point(0, 0)
        Me.LVersion.Name = "LVersion"
        Me.LVersion.Size = New System.Drawing.Size(45, 13)
        Me.LVersion.TabIndex = 1
        Me.LVersion.Text = "Version : "
        '
        'BLaunch
        '
        Me.BLaunch.Appearance.BackColor = System.Drawing.Color.Crimson
        Me.BLaunch.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.BLaunch.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BLaunch.Appearance.Options.UseBackColor = True
        Me.BLaunch.Appearance.Options.UseForeColor = True
        Me.BLaunch.Dock = System.Windows.Forms.DockStyle.Top
        Me.BLaunch.Location = New System.Drawing.Point(0, 12)
        Me.BLaunch.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gainsboro
        Me.BLaunch.LookAndFeel.SkinName = "Black"
        Me.BLaunch.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BLaunch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BLaunch.Name = "BLaunch"
        Me.BLaunch.Size = New System.Drawing.Size(481, 34)
        Me.BLaunch.TabIndex = 3
        Me.BLaunch.Text = "Launch"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LVersion)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 86)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(460, 19)
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
        Me.PanelControl3.Controls.Add(Me.BStart)
        Me.PanelControl3.Controls.Add(Me.BLaunch)
        Me.PanelControl3.Controls.Add(Me.ProgressBarControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 265)
        Me.PanelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(481, 112)
        Me.PanelControl3.TabIndex = 6
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(481, 265)
        Me.PictureEdit1.TabIndex = 7
        '
        'BStart
        '
        Me.BStart.Appearance.BackColor = System.Drawing.Color.Blue
        Me.BStart.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BStart.Appearance.Options.UseBackColor = True
        Me.BStart.Appearance.Options.UseForeColor = True
        Me.BStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.BStart.Location = New System.Drawing.Point(0, 46)
        Me.BStart.LookAndFeel.SkinName = "Black"
        Me.BStart.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.BStart.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BStart.Name = "BStart"
        Me.BStart.Size = New System.Drawing.Size(481, 34)
        Me.BStart.TabIndex = 6
        Me.BStart.Text = "Start"
        '
        'AppLauncher
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 377)
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
    Friend WithEvents BStart As DevExpress.XtraEditors.SimpleButton
End Class
