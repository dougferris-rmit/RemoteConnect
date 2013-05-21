Public Class RemoteControl

    Private Sub btnRemoteConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoteConnect.Click
        Dim hostname As String = tbHostName.Text
        Dim batlocation As String = "c:\scratch\remoteconnect.bat"
        Dim cnwriter As New System.IO.StreamWriter(batlocation)
        Dim remoteconnect As New Process
        With remoteconnect
            .StartInfo.FileName = "cmd.exe"
            .StartInfo.Arguments = "/k " + batlocation
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = False
        End With
        Dim kill As String = ""
        If cbKill.Checked = True Then
            kill = "taskkill /IM RC.exe /F"
        Else
            kill = ""
        End If
        If hostname = "" Then
            MsgBox("Please enter hostname")
        Else
            If hostname.Substring(0, 3) = "131" Then
                hostname = hostname
                MsgBox("Please use hostname rather than IP." + Environment.NewLine + "If you don't know how, open cmd and run the following command:" + Environment.NewLine + "nslookup " + hostname)
            ElseIf hostname.Substring(0, 1) = "w" Then
                hostname = hostname
                cnwriter.Write("@echo off" + Environment.NewLine + kill + Environment.NewLine + "SET mgruser=mgr-%USERNAME%" + Environment.NewLine + "runas /savecred /user:rmit\%mgruser% ""C:\Program Files (x86)\Microsoft\ConfigurationManager2007RemoteControl\RC.exe 1 " + hostname + Environment.NewLine + "exit")
                cnwriter.Close()
                remoteconnect.Start()
            ElseIf hostname.Substring(0, 1) = "W" Then
                hostname = hostname
                cnwriter.Write("@echo off" + Environment.NewLine + kill + Environment.NewLine + "SET mgruser=mgr-%USERNAME%" + Environment.NewLine + "runas /savecred /user:rmit\%mgruser% ""C:\Program Files (x86)\Microsoft\ConfigurationManager2007RemoteControl\RC.exe 1 " + hostname + Environment.NewLine + "exit")
                cnwriter.Close()
                remoteconnect.Start()
            Else
                hostname = "w" + hostname
                cnwriter.Write("@echo off" + Environment.NewLine + kill + Environment.NewLine + "SET mgruser=mgr-%USERNAME%" + Environment.NewLine + "runas /savecred /user:rmit\%mgruser% ""C:\Program Files (x86)\Microsoft\ConfigurationManager2007RemoteControl\RC.exe 1 " + hostname + Environment.NewLine + "exit")
                cnwriter.Close()
                remoteconnect.Start()
            End If
        End If
    End Sub
End Class
