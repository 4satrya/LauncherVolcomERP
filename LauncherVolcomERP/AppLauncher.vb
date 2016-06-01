Imports System.Net
Imports System.ComponentModel
Imports System.IO

Public Class AppLauncher
    Dim _list_download As Queue(Of String) = New Queue(Of String)()
    Dim url_volcom As String = ""
    Dim url_volcom_un As String = ""

    Private Sub AppLauncher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim line As String = ""
        Try
            ' Open the file using a stream reader.
            Using sr As New StreamReader("Location.txt")
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
            End Using
        Catch ex As Exception
        End Try

        If Environment.Is64BitOperatingSystem.ToString Then
            url_volcom = line + ":\Program Files (x86)\Volcom Indonesia\Volcom ERP\Volcom MRP.exe"
            url_volcom_un = line + ":\Program Files (x86)\Volcom Indonesia\Volcom ERP\uninstall_command.bat"
        Else
            url_volcom = line + ":\Program Files\Volcom Indonesia\Volcom ERP\Volcom MRP.exe"
            url_volcom_un = line + ":\Program Files\Volcom Indonesia\Volcom ERP\uninstall_command.bat"
        End If
        DevExpress.UserSkins.BonusSkins.Register()
        LookAndFeel.SkinName = "Metropolis"
        load_form()
    End Sub
    Sub load_form()
        '"C:\Program Files\Volcom Indonesia\Volcom ERP\Volcom MRP.exe"
        Dim myFileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath() + "\LauncherVolcomERP.exe")
        Try
            myFileVersionInfo = FileVersionInfo.GetVersionInfo(url_volcom)
        Catch ex As Exception
        End Try


        PictureEdit1.LoadAsync("http://192.168.1.2/app_upd/launch_img.jpg")

        LVersion.Text = "Volcom ERP (Version : " & myFileVersionInfo.FileVersion.ToString & ")"
        Dim update_url As String = "http://192.168.1.2/app_upd/"
        Dim web As New Net.WebClient
        Dim LatestVersion As String = web.DownloadString(update_url & "version.txt") 'To download the Lastest Version from a specified URL.

        'Dim LatestVersion_v = New Version(LatestVersion)
        'Dim myFileVersionInfo_v = New Version(myFileVersionInfo.FileVersion.ToString)

        'Dim result = LatestVersion_v.CompareTo(myFileVersionInfo_v)
        'If result > 0 Then
        'Console.WriteLine("LatestVersion_v is greater")
        'ElseIf result < 0 Then
        'Console.WriteLine("myFileVersionInfo_v is greater")
        'Else
        'Console.WriteLine("versions are equal")
        'End If

        If myFileVersionInfo.FileVersion.ToString < LatestVersion Then
            'infoCustom("Latest Version : " & LatestVersion & " of this application is available !")
            BLaunch.Text = "Update"
        Else
            BLaunch.Text = "Start"
        End If
    End Sub
    Sub DownloadQueue()
        _list_download.Enqueue("http://192.168.1.2/app_upd/SetupVolcomERP.msi")
        _list_download.Enqueue("http://192.168.1.2/app_upd/setup.exe")

        download_start()
    End Sub
    Sub download_start()
        If _list_download.Any() Then
            Dim _web_client As New WebClient
            AddHandler _web_client.DownloadProgressChanged, AddressOf client_DownloadProgressChanged
            AddHandler _web_client.DownloadFileCompleted, AddressOf client_DownloadFileCompleted

            Dim url = _list_download.Dequeue
            Dim filename As String = url.Substring(url.LastIndexOf("/") + 1, (url.Length - url.LastIndexOf("/") - 1))
            _web_client.DownloadFileAsync(New Uri(url), My.Application.Info.DirectoryPath.ToString + "/" + filename)
            Return
        End If
        infoCustom("Download complete, installing new version..")

        If System.IO.File.Exists(url_volcom_un) Then
            Dim myProcessUn As New Process()
            myProcessUn.StartInfo.FileName = url_volcom_un
            myProcessUn.StartInfo.CreateNoWindow = True
            myProcessUn.Start()
            myProcessUn.WaitForExit()
        End If


        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = My.Application.Info.DirectoryPath.ToString & "/SetupVolcomERP.msi"
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        myProcess.WaitForExit()
        'check if the app succesfully updated
        load_form()
    End Sub

    Sub client_DownloadFileCompleted(ByVal sender As System.Object, ByVal e As AsyncCompletedEventArgs)
        If Not e.Error Is Nothing Then
            stopCustom(e.Error.ToString)
        End If
        If e.Cancelled Then

        End If

        download_start()
    End Sub

    Sub client_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBarControl1.EditValue = Integer.Parse(Math.Truncate(percentage).ToString())
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLaunch.Click
        If BLaunch.Text = "Update" Then
            DownloadQueue()
        ElseIf BLaunch.Text = "Start" Then
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = url_volcom
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.Start()
            Close()
        End If
    End Sub

    Private Sub AppLauncher_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class