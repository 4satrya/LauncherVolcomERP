Imports DevExpress.LookAndFeel

Public Class FormMakePath
    Private Sub FormMakePath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.UseWindowsXPTheme = False
        UserLookAndFeel.Default.SkinName = "Metropolis"
    End Sub
End Class