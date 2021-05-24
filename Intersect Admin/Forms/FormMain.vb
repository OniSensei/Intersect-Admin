Imports System.ComponentModel
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class FormMain
    Dim basepath As String = Application.StartupPath
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        BanDurationBar.Maximum = My.Settings.banDurationMax
        BanTypeCombo.SelectedIndex = 0
        UnbanTypeCombo.SelectedIndex = 0
        KickKillTypeCombo.SelectedIndex = 0
        WarpTypeCombo.SelectedIndex = 0
        ChatPrefix.SelectedIndex = 0

        DashboardStatus.Text = "Welcome, " & FormLogin.UsernameTextbox.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim jsonobj As New Chilkat.JsonObject
            jsonobj.AddStringAt(-1, "grant_type", "refresh_token")
            jsonobj.AddStringAt(-1, "refresh_token", My.Settings.refreshToken)
            jsonobj.EmitCompact = False
            Dim jsontext As String = jsonobj.Emit
            Dim requestResp As String = sendPostRequest(jsontext, baseurl & "/api/oauth/token")
            If requestResp.Contains("access_token") Then
                Dim infoPull As New oAuthToken
                infoPull = JsonConvert.DeserializeObject(Of oAuthToken)(requestResp)

                My.Settings.authorized = True
                My.Settings.token = infoPull.access_token
                My.Settings.refreshToken = infoPull.refresh_token
                My.Settings.Save()

                DashboardStatus.Text = "API token refreshed."
            End If

            Dim ServerStatsPull As New ServerStats
            ServerStatsPull = JsonConvert.DeserializeObject(Of ServerStats)(sendGetRequest(baseurl & "/api/v1/info/stats"))

            OnlinePlayers.Maximum = My.Settings.maxonline
            OnlinePlayers.Value = ServerStatsPull.onlineCount
            CPSValue.Value2 = ServerStatsPull.cps

            Dim t As TimeSpan = TimeSpan.FromMilliseconds(ServerStatsPull.uptime)
            Dim uptimeoutput As String = String.Format("{0:D2} Days {1:D2} Hours {2:D2} Minutes {3:D2} Seconds", t.Days, t.Hours, t.Minutes, t.Seconds, t.Milliseconds)
            UptimeValue.Value2 = uptimeoutput
        Catch ex As Exception
            DashboardStatus.Text = "Error refreshing API token."
        End Try
    End Sub

    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormLogin.Close()
    End Sub

    Private Sub CpuUsage_Click(sender As Object, e As EventArgs) Handles CpuUsage.Click
        CpuUsage.Value = GetServerCpuPerformance()
        DashboardStatus.Text = "Server CPU usage refreshed."
    End Sub

    Private Sub CpuTimer_Tick(sender As Object, e As EventArgs) Handles CpuTimer.Tick
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            CpuUsage.Value = GetServerCpuPerformance()
            Dim ServerStatsPull As New ServerStats
            ServerStatsPull = JsonConvert.DeserializeObject(Of ServerStats)(sendGetRequest(baseurl & "/api/v1/info/stats"))
            CPSValue.Value2 = ServerStatsPull.cps
            Dim t As TimeSpan = TimeSpan.FromMilliseconds(ServerStatsPull.uptime)
            Dim uptimeoutput As String = String.Format("{0:D2} Days {1:D2} Hours {2:D2} Minutes {3:D2} Seconds", t.Days, t.Hours, t.Minutes, t.Seconds, t.Milliseconds)
            UptimeValue.Value2 = uptimeoutput
        Catch ex As Exception
            DashboardStatus.Text = "Error refreshing server stats."
        End Try
    End Sub

    Private Sub NsTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BanDurationText.TextChanged
        BanDurationBar.Value = BanDurationText.Text
    End Sub

    Private Sub BanDurationText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BanDurationText.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub WarpX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WarpX.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub WarpY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WarpY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BanDurationBar_Scroll(sender As Object) Handles BanDurationBar.Scroll
        BanDurationText.Text = BanDurationBar.Value
    End Sub

    Private Sub BanButton_Click(sender As Object, e As EventArgs) Handles BanButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim username As String = BanUsername.Text
            Dim reason As String = BanReasonText.Text
            Dim duration As Integer = BanDurationText.Text
            Dim includeip As Boolean = False
            If BanIPCheck.Checked Then
                includeip = True
            End If

            Dim jsonobj As New Chilkat.JsonObject
            jsonobj.AddIntAt(-1, "duration", duration)
            jsonobj.AddStringAt(-1, "reason", reason)
            jsonobj.AddStringAt(-1, "modereator", FormLogin.UsernameTextbox.Text)
            jsonobj.AddBoolAt(-1, "ip", includeip)
            jsonobj.EmitCompact = False
            Dim jsontext As String = jsonobj.Emit
            Dim requestResp As String
            Select Case BanTypeCombo.Text
                Case "Ban User"
                    requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & username & "/admin/ban")
                Case "Ban Player"
                    requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/players/" & username & "/admin/ban")
                Case "Mute User"
                    requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & username & "/admin/mute")
                Case "Mute Player"
                    requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/players/" & username & "/admin/mute")
            End Select

            Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If requestResp.Contains("has been muted") Then
                AdminStatus.Text = username & " has been muted!"
            ElseIf requestResp.Contains("has been banned") Then
                AdminStatus.Text = username & " has been banned!"
            Else
                AdminStatus.Text = "Could not ban/mute " & username & ", please check your spelling and try again."
            End If

            BanUsername.Text = ""
            BanTypeCombo.SelectedIndex = 0
            BanDurationBar.Value = 0
            BanDurationText.Text = 0
            BanReasonText.Text = ""
            BanIPCheck.Checked = False
        Catch ex As Exception
            AdminStatus.Text = "Error banning the user. Please try again."
        End Try
    End Sub

    Private Sub UnbanButton_Click(sender As Object, e As EventArgs) Handles UnbanButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim username As String = UnbanUsername.Text

            Dim requestResp As String
            Select Case UnbanTypeCombo.Text
                Case "Unban User"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/users/" & username & "/admin/unban")
                Case "Unban Player"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/players/" & username & "/admin/unban")
                Case "Unmute User"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/users/" & username & "/admin/unmute")
                Case "Unmute Player"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/players/" & username & "/admin/unmute")
            End Select

            Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If requestResp.Contains("has been unmuted") Then
                AdminStatus.Text = username & " has been unmuted!"
            ElseIf requestResp.Contains("has been unbanned") Then
                AdminStatus.Text = username & " has been unbanned!"
            Else
                AdminStatus.Text = "Could not unban/unmute " & username & ", please check your spelling and try again."
            End If

            UnbanUsername.Text = ""
            UnbanTypeCombo.SelectedIndex = 0
        Catch ex As Exception
            AdminStatus.Text = "Error unbanning/unmuting the user. Please try again."
        End Try
    End Sub

    Private Sub KickKillButton_Click(sender As Object, e As EventArgs) Handles KickKillButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim username As String = KickKillUsername.Text

            Dim requestResp As String
            Select Case KickKillTypeCombo.Text
                Case "Kick User"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/users/" & username & "/admin/kick")
                Case "Kick Player"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/players/" & username & "/admin/kick")
                Case "Kill User"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/users/" & username & "/admin/kill")
                Case "Kill Player"
                    requestResp = sendPostRequestWithAuth("", baseurl & "/api/v1/players/" & username & "/admin/kill")
            End Select

            Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If requestResp.Contains("has been kicked") Then
                AdminStatus.Text = username & " has been kicked by the server!"
            ElseIf requestResp.Contains("has been killed") Then
                AdminStatus.Text = username & " has been killed!"
            Else
                AdminStatus.Text = "Could not kick/kill " & username & ", please check your spelling and try again."
            End If

            KickKillTypeCombo.SelectedIndex = 0
            KickKillUsername.Text = ""
        Catch ex As Exception
            AdminStatus.Text = "Error kicking/killing the user. Please try again."
        End Try
    End Sub

    Private Sub WarpButton_Click(sender As Object, e As EventArgs) Handles WarpButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim username As String = WarpUsername.Text
            Dim mapname As String = WarpMapList.Text
            Dim xcord As Integer = WarpX.Text
            Dim ycord As Integer = WarpY.Text

            Dim jsonobj As New Chilkat.JsonObject
            jsonobj.AddStringAt(-1, "MapId", MapName2ID(mapname))
            If WarpCoordinates.Checked Then
                jsonobj.AddIntAt(-1, "x", xcord)
                jsonobj.AddIntAt(-1, "y", ycord)
            End If
            jsonobj.EmitCompact = False
            Dim jsontext As String = jsonobj.Emit
            Dim requestResp As String
            Select Case WarpTypeCombo.Text
                Case "Warp User"
                    If WarpCoordinates.Checked Then
                        requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & username & "/admin/warptoloc")
                    Else
                        requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & username & "/admin/warpto")
                    End If
                Case "Warp Player"
                    If WarpCoordinates.Checked Then
                        requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/players/" & username & "/admin/warptoloc")
                    Else
                        requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/players/" & username & "/admin/warpto")
                    End If
            End Select

            Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If requestResp.Contains("Warped") Then
                AdminStatus.Text = username & " has been warped!"
            Else
                AdminStatus.Text = "Could not warp " & username & ", please check your spelling and try again."
            End If

            WarpTypeCombo.SelectedIndex = 0
            WarpMapList.SelectedIndex = 0
            WarpUsername.Text = ""
            WarpCoordinates.Checked = False
            WarpX.Text = 0
            WarpY.Text = 0
        Catch ex As Exception
            AdminStatus.Text = "Error warping the user. Please try again."
        End Try
    End Sub

    Private Sub ChatColorButton_Click(sender As Object, e As EventArgs) Handles ChatColorButton.Click
        Dim result As DialogResult = ChatMessageColorDialog.ShowDialog
        If result <> DialogResult.Cancel Then
            Dim color As Color = ChatMessageColorDialog.Color
            Dim A As Byte = color.A
            Dim R As Byte = color.R
            Dim G As Byte = color.G
            Dim B As Byte = color.B

            ChatColorText.Text = A & "," & R & "," & G & "," & B
        End If
    End Sub

    Private Sub ChatSendButton_Click(sender As Object, e As EventArgs) Handles ChatSendButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim gMessage As String
            Dim gMessageColor As String() = ChatColorText.Text.Split(",")
            Dim A As Integer = gMessageColor(0)
            Dim R As Integer = gMessageColor(1)
            Dim G As Integer = gMessageColor(2)
            Dim B As Integer = gMessageColor(3)

            Select Case ChatPrefix.Text
                Case "None"
                    gMessage = ChatMessage.Text
                Case "{LoggedIn}:"
                    gMessage = FormLogin.UsernameTextbox.Text & ": " & ChatMessage.Text
                Case Else
                    gMessage = ChatPrefix.Text & " " & ChatMessage.Text
            End Select
            Dim globalSubstring As String() = {gMessage, ChatColorText.Text}
            GameChatLog.AddItem(Date.Now.ToString, globalSubstring)

            Dim jsonobj As New Chilkat.JsonObject
            Dim index As Integer = -1
            jsonobj.AddStringAt(-1, "Message", gMessage)
            jsonobj.AddObjectAt(-1, "Color")
            Dim jsoncolorobj As Chilkat.JsonObject = jsonobj.ObjectAt(jsonobj.Size - 1)
            jsoncolorobj.AddIntAt(-1, "A", A)
            jsoncolorobj.AddIntAt(-1, "R", R)
            jsoncolorobj.AddIntAt(-1, "G", G)
            jsoncolorobj.AddIntAt(-1, "B", B)
            If gMessage.Contains("@") Then
                Dim msgsplit As String() = gMessage.Split(" ")
                For Each m As String In msgsplit
                    If m.Contains("@") Then
                        Dim target As String = m.Replace("@", "")
                        jsonobj.AddStringAt(-1, "Target", target)
                    End If
                Next
            ElseIf DmCheckbox.Checked Then
                jsonobj.AddStringAt(-1, "Target", DmUsername.Text)
            Else
                jsonobj.AddStringAt(-1, "Target", "")
            End If
            jsonobj.EmitCompact = False
            Dim jsontext As String = jsonobj.Emit
            Dim requestResp As String
            If DmCheckbox.Checked Then
                If DmUsername.Text <> "" Then
                    requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/chat/direct/" & DmUsername.Text)
                    Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                    FormDebug.DebugText.Text = jsonstringformat
                    If requestResp.Contains("true") Then
                        ChatStatus.Text = "Message Sent: " & gMessage
                        ChatMapCheck.Checked = False
                        DmCheckbox.Checked = False
                    End If
                Else
                    ChatStatus.Text = "Please enter a player name."
                End If
            ElseIf ChatMapCheck.Checked Then
                Dim mapid As String = MapName2ID(ChatMaps.Text)
                requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/chat/proximity/" & mapid)
                Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                FormDebug.DebugText.Text = jsonstringformat
                If requestResp.Contains("true") Then
                    ChatStatus.Text = "Message Sent: " & gMessage
                    ChatMapCheck.Checked = False
                    DmCheckbox.Checked = False
                End If
            Else
                requestResp = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/chat/global")
                Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                FormDebug.DebugText.Text = jsonstringformat
                If requestResp.Contains("true") Then
                    ChatStatus.Text = "Message Sent: " & gMessage
                    ChatMapCheck.Checked = False
                    DmCheckbox.Checked = False
                End If
            End If
        Catch ex As Exception
            ChatStatus.Text = "You're sending messages to fast."
        End Try
    End Sub

    Private Sub DmCheckbox_CheckedChanged(sender As Object) Handles DmCheckbox.CheckedChanged
        If ChatMapCheck.Checked = True Then
            ChatMapCheck.Checked = False
        End If
    End Sub

    Private Sub ChatMapCheck_CheckedChanged(sender As Object) Handles ChatMapCheck.CheckedChanged
        If DmCheckbox.Checked = True Then
            DmCheckbox.Checked = False
        End If
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles UserSearchButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            For Each lvitem As NSListView.NSListViewItem In UsersList.Items
                UsersList.RemoveItem(lvitem)
            Next

            Dim ListUserPull As New ListUsers
            ListUserPull = JsonConvert.DeserializeObject(Of ListUsers)(sendGetRequest(baseurl & "/api/v1/users?page=0&pageSize=99999"))

            For i As Integer = 0 To ListUserPull.Count - 1
                If UsersSearchText.Text <> "" Then
                    If ListUserPull.Values(i).Name.Contains(UsersSearchText.Text) Then
                        UsersList.AddItem(ListUserPull.Values(i).Name, ListUserPull.Values(i).Email, ListUserPull.Values(i).Id)
                    End If
                Else
                    UsersList.AddItem(ListUserPull.Values(i).Name, ListUserPull.Values(i).Email, ListUserPull.Values(i).Id)
                End If
            Next

            UsersListStatus.Text = "List updated."
        Catch ex As Exception
            UsersListStatus.Text = "Error performing search."
        End Try
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            If UsersList.SelectedItems.Count > 0 Then
                Dim UserDetailsPull As New UserDetails
                UserDetailsPull = JsonConvert.DeserializeObject(Of UserDetails)(sendGetRequest(baseurl & "/api/v1/users/" & UsersList.SelectedItems(0).Text))
                If UserDetailsPull.Power.Editor Then EditorBool.Checked = True
                If UserDetailsPull.Power.Ban Then BanBool.Checked = True
                If UserDetailsPull.Power.Kick Then KickBool.Checked = True
                If UserDetailsPull.Power.Mute Then MuteBool.Checked = True
                If UserDetailsPull.Power.Api Then ApiBool.Checked = True
                If UserDetailsPull.Power.PersonalInformation Then PersonalBool.Checked = True
                DetailsUserLabel.Value2 = UserDetailsPull.Name
                UserDetailsAccountID.Text = UserDetailsPull.Id
                If UserDetailsPull.IsMuted Then
                    UserDetailsIsMuted.Checked = True
                    UserDetailsMuteReason.Text = UserDetailsPull.MuteReason
                End If

                UsersTabControl.SelectedIndex = 1

                Dim ListPlayersPull As New ListPlayers
                ListPlayersPull = JsonConvert.DeserializeObject(Of ListPlayers)(sendGetRequest(baseurl & "/api/v1/players?page=0&pageSize=99999"))

                For Each lvitem As NSListView.NSListViewItem In UserDetailsCharacterList.Items
                    UserDetailsCharacterList.RemoveItem(lvitem)
                Next
                For lu As Integer = 0 To ListPlayersPull.Count - 1
                    If ListPlayersPull.Values(lu).UserId = UserDetailsPull.Id Then
                        UserDetailsCharacterList.AddItem(ListPlayersPull.Values(lu).Name)
                    End If
                Next
                UsersListStatus.Text = "User details received."
            End If
        Catch ex As Exception
            UsersListStatus.Text = "Error fetching user details."
        End Try
    End Sub

    Private Sub CopyIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyIDToolStripMenuItem.Click
        My.Computer.Clipboard.Clear()
        Dim sb As New StringBuilder
        For i As Integer = 0 To UsersList.SelectedItems.Count - 1
            sb.Append(UsersList.SelectedItems(i).SubItems(1).Text).AppendLine()
        Next
        My.Computer.Clipboard.SetText(sb.ToString)

        UsersListStatus.Text = "User ID copied to clipboard."
    End Sub

    Private Sub NsButton1_Click_1(sender As Object, e As EventArgs) Handles NsButton1.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            If UserDetailsNewPass.Text <> "" Then
                Dim crypt As New Chilkat.Crypt2
                crypt.HashAlgorithm = "sha256"
                crypt.Charset = "utf-8"

                Dim hashBytes() As Byte
                hashBytes = crypt.HashString(UserDetailsNewPass.Text)
                Dim sb As New Chilkat.StringBuilder
                sb.AppendEncoded(hashBytes, "hex")
                Dim hashedPass As String = sb.GetAsString()

                Dim passobj As New Chilkat.JsonObject
                passobj.AddStringAt(-1, "new", hashedPass)
                passobj.EmitCompact = False
                Dim jsontext As String = passobj.Emit
                Dim requestResp As String = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & UsersList.SelectedItems(0).Text & "/manage/password/change")
                Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                FormDebug.DebugText.Text = jsonstringformat

                If requestResp.Contains("Password Correct") Then
                    UserDetailsStatus.Text = "New password set."
                    UserDetailsNewPass.Text = ""
                End If
            End If

            If UserDetailsNewEmail.Text <> "" Then
                Dim emailobj As New Chilkat.JsonObject
                emailobj.AddStringAt(-1, "new", UserDetailsNewEmail.Text)
                emailobj.EmitCompact = False
                Dim jsontext As String = emailobj.Emit
                Dim requestResp As String = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/" & UsersList.SelectedItems(0).Text & "/manage/email/change")
                Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                FormDebug.DebugText.Text = jsonstringformat

                If requestResp.Contains(UserDetailsNewEmail.Text) Then
                    UserDetailsStatus.Text = "New email set."
                    UserDetailsNewEmail.Text = ""
                End If
            End If
        Catch ex As Exception
            UsersListStatus.Text = "Error updating user email/password."
        End Try
    End Sub

    Private Sub NsTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NsTabControl1.SelectedIndexChanged
        Select Case NsTabControl1.SelectedIndex
            Case 3
                LoadUserList()
            Case 4
                LoadPlayerList()
        End Select
    End Sub

    Private Sub OnlinePlayers_MouseHover(sender As Object, e As EventArgs) Handles OnlinePlayers.MouseHover
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            Dim jsonobj As New Chilkat.JsonObject
            jsonobj.AddIntAt(-1, "page", 0)
            jsonobj.AddIntAt(-1, "count", OnlinePlayers.Value)
            jsonobj.EmitCompact = False
            Dim jsontext As String = jsonobj.Emit
            Dim requestResp As String = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/players/online")
            Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If requestResp.Contains("total") Then
                Dim infoPull As New PlayersOnline
                infoPull = JsonConvert.DeserializeObject(Of PlayersOnline)(requestResp)

                OnlinePlayersContext.Items.Clear()
                For i As Integer = 0 To infoPull.count - 1
                    OnlinePlayersContext.Items.Add(infoPull.entries(i).Name, My.Resources.Online)
                Next

                OnlinePlayers.Value = infoPull.count
                DashboardStatus.Text = "Players online refreshed."
            End If
        Catch ex As Exception
            DashboardStatus.Text = "Error accessing online players list from API."
        End Try
    End Sub

    Private Sub NsButton2_Click_1(sender As Object, e As EventArgs) Handles RegisterNewButton.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            If RegisterUsername.Text <> "" AndAlso RegisterPass.Text <> "" AndAlso RegisterEmail.Text <> "" Then
                Dim crypt As New Chilkat.Crypt2
                crypt.HashAlgorithm = "sha256"
                crypt.Charset = "utf-8"

                Dim hashBytes() As Byte
                hashBytes = crypt.HashString(RegisterPass.Text)
                Dim sb As New Chilkat.StringBuilder
                sb.AppendEncoded(hashBytes, "hex")
                Dim hashedPass As String = sb.GetAsString()

                Dim jsonobj As New Chilkat.JsonObject
                jsonobj.AddStringAt(-1, "username", RegisterUsername.Text)
                jsonobj.AddStringAt(-1, "password", hashedPass)
                jsonobj.AddStringAt(-1, "email", RegisterEmail.Text)
                jsonobj.EmitCompact = False
                Dim jsontext As String = jsonobj.Emit
                Dim requestResp As String = sendPostRequestWithAuth(jsontext, baseurl & "/api/v1/users/register")
                Dim jsonstringformat As String = JValue.Parse(requestResp).ToString(Formatting.Indented)
                FormDebug.DebugText.Text = jsonstringformat
                If requestResp.Contains(RegisterUsername.Text) Then
                    RegisterStatus.Text = "New account registered."
                End If
            Else
                RegisterStatus.Text = "Error please fill out the form completely."
            End If
        Catch ex As Exception
            RegisterStatus.Text = "Error registering new account."
        End Try
    End Sub

    Private Sub PlayersList_Click(sender As Object, e As EventArgs) Handles PlayersList.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            If PlayersList.SelectedItems.Count = 1 Then
                Dim PlayerDetails As ListPlayersValue
                PlayerDetails = JsonConvert.DeserializeObject(Of ListPlayersValue)(sendGetRequest(baseurl & "/api/v1/players/" & PlayersList.SelectedItems(0).Text))

                Dim parentdirectory As DirectoryInfo = Directory.GetParent(basepath)
                Dim entitiesdirectory As String = parentdirectory.FullName & "\Client and Editor\resources\entities\"
                Dim sprite As New Bitmap(entitiesdirectory & PlayerDetails.Sprite)
                Dim srcRECT As New Rectangle(0, 0, sprite.Width / 4, sprite.Height / 4)
                sprite = sprite.Clone(srcRECT, sprite.PixelFormat)
                CharPreview.BackgroundImage = sprite

                CharacterDetailsBox.Visible = True

                CharName.Text = "[Lvl: " & PlayerDetails.Level & "] " & PlayerDetails.Name
                CharClass.Text = "Class: " & ClassID2Name(PlayerDetails.ClassId)
                CharMap.Text = "Map: " & MapID2Name(PlayerDetails.MapId)
                CharHP.Text = "HP: [" & PlayerDetails.Vitals(0) & "/" & PlayerDetails.MaxVitals(0) & "]"
                CharHpBar.Maximum = PlayerDetails.MaxVitals(0)
                CharHpBar.Value = PlayerDetails.Vitals(0)
                CharMP.Text = "MP: [" & PlayerDetails.Vitals(1) & "/" & PlayerDetails.MaxVitals(1) & "]"
                CharMpBar.Maximum = PlayerDetails.MaxVitals(1)
                CharMpBar.Value = PlayerDetails.Vitals(1)
                CharEXP.Text = "EXP: [" & PlayerDetails.Exp & "/" & PlayerDetails.ExperienceToNextLevel & "]"
                CharExpBar.Maximum = PlayerDetails.ExperienceToNextLevel
                CharExpBar.Value = PlayerDetails.Exp
                CharAtk.Text = PlayerDetails.BaseStats(0) & " [+" & PlayerDetails.StatPointAllocations(0) & "]"
                CharAtkBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(0)
                CharAtkBar.Value = PlayerDetails.StatPointAllocations(0) + PlayerDetails.BaseStats(0)
                CharDef.Text = PlayerDetails.BaseStats(1) & " [+" & PlayerDetails.StatPointAllocations(1) & "]"
                CharDefBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(1)
                CharDefBar.Value = PlayerDetails.StatPointAllocations(1) + PlayerDetails.BaseStats(1)
                CharSpd.Text = PlayerDetails.BaseStats(2) & " [+" & PlayerDetails.StatPointAllocations(2) & "]"
                CharSpeedBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(2)
                CharSpeedBar.Value = PlayerDetails.StatPointAllocations(2) + PlayerDetails.BaseStats(2)
                CharAP.Text = PlayerDetails.BaseStats(3) & " [+" & PlayerDetails.StatPointAllocations(3) & "]"
                CharApBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(3)
                CharApBar.Value = PlayerDetails.StatPointAllocations(3) + PlayerDetails.BaseStats(3)
                CharMR.Text = PlayerDetails.BaseStats(4) & " [+" & PlayerDetails.StatPointAllocations(4) & "]"
                CharMrBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(4)
                CharMrBar.Value = PlayerDetails.StatPointAllocations(4) + PlayerDetails.BaseStats(4)
                CharStatPoints.Text = "Points Remaining: " & PlayerDetails.StatPoints - (PlayerDetails.StatPointAllocations(0) + PlayerDetails.StatPointAllocations(1) + PlayerDetails.StatPointAllocations(2) + PlayerDetails.StatPointAllocations(3) + PlayerDetails.StatPointAllocations(4))
            End If
        Catch ex As Exception
            PlayersListStatus.Text = "Error getting player details."
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            NsTabControl1.SelectedIndex = 4

            Dim PlayerDetails As ListPlayersValue
            PlayerDetails = JsonConvert.DeserializeObject(Of ListPlayersValue)(sendGetRequest(baseurl & "/api/v1/players/" & UserDetailsCharacterList.SelectedItems(0).Text))

            Dim parentdirectory As DirectoryInfo = Directory.GetParent(basepath)
            Dim entitiesdirectory As String = parentdirectory.FullName & "\Client and Editor\resources\entities\"
            Dim sprite As New Bitmap(entitiesdirectory & PlayerDetails.Sprite)
            Dim srcRECT As New Rectangle(0, 0, sprite.Width / 4, sprite.Height / 4)
            sprite = sprite.Clone(srcRECT, sprite.PixelFormat)
            CharPreview.BackgroundImage = sprite

            CharacterDetailsBox.Visible = True

            CharName.Text = "[Lvl: " & PlayerDetails.Level & "] " & PlayerDetails.Name
            CharClass.Text = "Class: " & ClassID2Name(PlayerDetails.ClassId)
            CharMap.Text = "Map: " & MapID2Name(PlayerDetails.MapId)
            CharHP.Text = "HP: [" & PlayerDetails.Vitals(0) & "/" & PlayerDetails.MaxVitals(0) & "]"
            CharHpBar.Maximum = PlayerDetails.MaxVitals(0)
            CharHpBar.Value = PlayerDetails.Vitals(0)
            CharMP.Text = "MP: [" & PlayerDetails.Vitals(1) & "/" & PlayerDetails.MaxVitals(1) & "]"
            CharMpBar.Maximum = PlayerDetails.MaxVitals(1)
            CharMpBar.Value = PlayerDetails.Vitals(1)
            CharEXP.Text = "EXP: [" & PlayerDetails.Exp & "/" & PlayerDetails.ExperienceToNextLevel & "]"
            CharExpBar.Maximum = PlayerDetails.ExperienceToNextLevel
            CharExpBar.Value = PlayerDetails.Exp
            CharAtk.Text = PlayerDetails.BaseStats(0) & " [+" & PlayerDetails.StatPointAllocations(0) & "]"
            CharAtkBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(0)
            CharAtkBar.Value = PlayerDetails.StatPointAllocations(0) + PlayerDetails.BaseStats(0)
            CharDef.Text = PlayerDetails.BaseStats(1) & " [+" & PlayerDetails.StatPointAllocations(1) & "]"
            CharDefBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(1)
            CharDefBar.Value = PlayerDetails.StatPointAllocations(1) + PlayerDetails.BaseStats(1)
            CharSpd.Text = PlayerDetails.BaseStats(2) & " [+" & PlayerDetails.StatPointAllocations(2) & "]"
            CharSpeedBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(2)
            CharSpeedBar.Value = PlayerDetails.StatPointAllocations(2) + PlayerDetails.BaseStats(2)
            CharAP.Text = PlayerDetails.BaseStats(3) & " [+" & PlayerDetails.StatPointAllocations(3) & "]"
            CharApBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(3)
            CharApBar.Value = PlayerDetails.StatPointAllocations(3) + PlayerDetails.BaseStats(3)
            CharMR.Text = PlayerDetails.BaseStats(4) & " [+" & PlayerDetails.StatPointAllocations(4) & "]"
            CharMrBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(4)
            CharMrBar.Value = PlayerDetails.StatPointAllocations(4) + PlayerDetails.BaseStats(4)
            CharStatPoints.Text = "Points Remaining: " & PlayerDetails.StatPoints - (PlayerDetails.StatPointAllocations(0) + PlayerDetails.StatPointAllocations(1) + PlayerDetails.StatPointAllocations(2) + PlayerDetails.StatPointAllocations(3) + PlayerDetails.StatPointAllocations(4))
        Catch ex As Exception
            PlayersListStatus.Text = "Error getting player details."
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

            NsTabControl1.SelectedIndex = 4

            Dim PlayerDetails As ListPlayersValue
            PlayerDetails = JsonConvert.DeserializeObject(Of ListPlayersValue)(sendGetRequest(baseurl & "/api/v1/players/" & RankTable.SelectedItems(0).SubItems(1).Text))

            Dim parentdirectory As DirectoryInfo = Directory.GetParent(basepath)
            Dim entitiesdirectory As String = parentdirectory.FullName & "\Client and Editor\resources\entities\"
            Dim sprite As New Bitmap(entitiesdirectory & PlayerDetails.Sprite)
            Dim srcRECT As New Rectangle(0, 0, sprite.Width / 4, sprite.Height / 4)
            sprite = sprite.Clone(srcRECT, sprite.PixelFormat)
            CharPreview.BackgroundImage = sprite

            CharacterDetailsBox.Visible = True

            CharName.Text = "[Lvl: " & PlayerDetails.Level & "] " & PlayerDetails.Name
            CharClass.Text = "Class: " & ClassID2Name(PlayerDetails.ClassId)
            CharMap.Text = "Map: " & MapID2Name(PlayerDetails.MapId)
            CharHP.Text = "HP: [" & PlayerDetails.Vitals(0) & "/" & PlayerDetails.MaxVitals(0) & "]"
            CharHpBar.Maximum = PlayerDetails.MaxVitals(0)
            CharHpBar.Value = PlayerDetails.Vitals(0)
            CharMP.Text = "MP: [" & PlayerDetails.Vitals(1) & "/" & PlayerDetails.MaxVitals(1) & "]"
            CharMpBar.Maximum = PlayerDetails.MaxVitals(1)
            CharMpBar.Value = PlayerDetails.Vitals(1)
            CharEXP.Text = "EXP: [" & PlayerDetails.Exp & "/" & PlayerDetails.ExperienceToNextLevel & "]"
            CharExpBar.Maximum = PlayerDetails.ExperienceToNextLevel
            CharExpBar.Value = PlayerDetails.Exp
            CharAtk.Text = PlayerDetails.BaseStats(0) & " [+" & PlayerDetails.StatPointAllocations(0) & "]"
            CharAtkBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(0)
            CharAtkBar.Value = PlayerDetails.StatPointAllocations(0) + PlayerDetails.BaseStats(0)
            CharDef.Text = PlayerDetails.BaseStats(1) & " [+" & PlayerDetails.StatPointAllocations(1) & "]"
            CharDefBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(1)
            CharDefBar.Value = PlayerDetails.StatPointAllocations(1) + PlayerDetails.BaseStats(1)
            CharSpd.Text = PlayerDetails.BaseStats(2) & " [+" & PlayerDetails.StatPointAllocations(2) & "]"
            CharSpeedBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(2)
            CharSpeedBar.Value = PlayerDetails.StatPointAllocations(2) + PlayerDetails.BaseStats(2)
            CharAP.Text = PlayerDetails.BaseStats(3) & " [+" & PlayerDetails.StatPointAllocations(3) & "]"
            CharApBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(3)
            CharApBar.Value = PlayerDetails.StatPointAllocations(3) + PlayerDetails.BaseStats(3)
            CharMR.Text = PlayerDetails.BaseStats(4) & " [+" & PlayerDetails.StatPointAllocations(4) & "]"
            CharMrBar.Maximum = My.Settings.maxstat + PlayerDetails.BaseStats(4)
            CharMrBar.Value = PlayerDetails.StatPointAllocations(4) + PlayerDetails.BaseStats(4)
            CharStatPoints.Text = "Points Remaining: " & PlayerDetails.StatPoints - (PlayerDetails.StatPointAllocations(0) + PlayerDetails.StatPointAllocations(1) + PlayerDetails.StatPointAllocations(2) + PlayerDetails.StatPointAllocations(3) + PlayerDetails.StatPointAllocations(4))
        Catch ex As Exception
            PlayersListStatus.Text = "Error getting player details."
        End Try
    End Sub

    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        FormSettings.Show()
    End Sub
End Class
