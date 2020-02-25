Imports System.Net
Imports System.ComponentModel
Imports System.IO

Public Class AppLauncher
    Dim _list_download As Queue(Of String) = New Queue(Of String)()
    Dim exe_location As String = ""
    Dim upd_location As String = ""
    Dim pic_name As String = ""
    Dim exe_name As String = ""
    Dim msi_name As String = ""
    Dim ver_name As String = ""

    Private Sub AppLauncher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_form()
    End Sub
    Sub load_form()
        DevExpress.UserSkins.BonusSkins.Register()
        LookAndFeel.SkinName = "Metropolis Dark"

        Try
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath() + "\config.txt")
            Dim line As String

            Do
                line = reader.ReadLine
                '
                If line.Contains("exe_location") Then
                    exe_location = line.Substring(13)
                ElseIf line.Contains("upd_location") Then
                    upd_location = line.Substring(13)
                ElseIf line.Contains("exe_name") Then
                    exe_name = line.Substring(9)
                ElseIf line.Contains("msi_name") Then
                    msi_name = line.Substring(9)
                ElseIf line.Contains("pic_name") Then
                    pic_name = line.Substring(9)
                ElseIf line.Contains("ver_name") Then
                    ver_name = line.Substring(9)
                End If
                '
            Loop Until line Is Nothing

            reader.Close()
        Catch ex As Exception
        End Try

        Dim myFileVersionInfo As FileVersionInfo = Nothing
        Dim version_check As String = "0.0.0.0"
        Try
            myFileVersionInfo = FileVersionInfo.GetVersionInfo(exe_location)
            version_check = myFileVersionInfo.ProductVersion.ToString
        Catch ex As Exception
        End Try

        PictureEdit1.LoadAsync(upd_location & pic_name)

        LVersion.Text = "Volcom Stock Take (Version : " & version_check & ")"

        Dim web As New Net.WebClient
        Dim LatestVersion As String = web.DownloadString(upd_location & ver_name) 'To download the Lastest Version from a specified URL.

        If version_check < LatestVersion Then
            BLaunch.Text = "Update"
        Else
            BLaunch.Text="Start"
        End If
    End Sub
    Sub DownloadQueue()
        _list_download.Enqueue(upd_location & msi_name)
        _list_download.Enqueue(upd_location & exe_name)

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

        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = My.Application.Info.DirectoryPath.ToString & "/" & msi_name
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
            myProcess.StartInfo.FileName = exe_location
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.Start()
            Close()
        End If
    End Sub

    Private Sub AppLauncher_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class