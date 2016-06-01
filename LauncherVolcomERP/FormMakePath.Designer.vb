<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMakePath
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TEPathUpdate = New DevExpress.XtraEditors.TextEdit()
        Me.BSubmit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TEPathUpdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Path Update"
        '
        'TEPathUpdate
        '
        Me.TEPathUpdate.Location = New System.Drawing.Point(90, 20)
        Me.TEPathUpdate.Name = "TEPathUpdate"
        Me.TEPathUpdate.Size = New System.Drawing.Size(383, 20)
        Me.TEPathUpdate.TabIndex = 1
        '
        'BSubmit
        '
        Me.BSubmit.Location = New System.Drawing.Point(479, 18)
        Me.BSubmit.Name = "BSubmit"
        Me.BSubmit.Size = New System.Drawing.Size(93, 23)
        Me.BSubmit.TabIndex = 2
        Me.BSubmit.Text = "Submit"
        '
        'FormMakePath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 72)
        Me.Controls.Add(Me.BSubmit)
        Me.Controls.Add(Me.TEPathUpdate)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMakePath"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path Maker Volcom MRP"
        CType(Me.TEPathUpdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPathUpdate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BSubmit As DevExpress.XtraEditors.SimpleButton
End Class
