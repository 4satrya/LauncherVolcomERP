Imports DevExpress.XtraEditors

Module Common
    Sub stopCustom(ByVal stop_msg As String)
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        Dim u As New DevExpress.LookAndFeel.UserLookAndFeel(AppLauncher)
        u.UseDefaultLookAndFeel = False
        u.UseWindowsXPTheme = False
        u.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        u.SkinName = "Metropolis"

        XtraMessageBox.Show(u, stop_msg, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Sub infoCustom(ByVal info_msg As String)
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        Dim u As New DevExpress.LookAndFeel.UserLookAndFeel(AppLauncher)
        u.UseDefaultLookAndFeel = False
        u.UseWindowsXPTheme = False
        u.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin

        u.SkinName = "Metropolis"

        XtraMessageBox.Show(u, info_msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub warningCustom(ByVal warning_msg As String)
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        Dim u As New DevExpress.LookAndFeel.UserLookAndFeel(AppLauncher)
        u.UseDefaultLookAndFeel = False
        u.UseWindowsXPTheme = False
        u.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        u.SkinName = "Metropolis"

        XtraMessageBox.Show(u, warning_msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Module