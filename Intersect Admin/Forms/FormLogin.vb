Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FormLogin
    Dim passvisible As Boolean = False

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

        Dim username As String = UsernameTextbox.Text
        Dim passraw As String = PasswordTextbox.Text

        If My.Settings.rememberMe = True Then
            My.Settings.username = UsernameTextbox.Text
            My.Settings.password = PasswordTextbox.Text
            My.Settings.Save()
        End If

        Dim crypt As New Chilkat.Crypt2
        crypt.HashAlgorithm = "sha256"
        crypt.Charset = "utf-8"

        Dim hashBytes() As Byte
        hashBytes = crypt.HashString(passraw)
        Dim sb As New Chilkat.StringBuilder
        sb.AppendEncoded(hashBytes, "hex")
        Dim hashedPass As String = sb.GetAsString()

        Dim jsonobj As New Chilkat.JsonObject
        Dim index As Integer = -1
        jsonobj.AddStringAt(-1, "grant_type", "password")
        jsonobj.AddStringAt(-1, "username", username)
        jsonobj.AddStringAt(-1, "password", hashedPass)
        jsonobj.EmitCompact = False
        Dim jsontext As String = jsonobj.Emit
        Dim requestResp As String = sendPostRequest(jsontext, "http://" & My.Settings.server & ":" & My.Settings.port & "/api/oauth/token")
        If requestResp.Contains("access_token") Then
            Dim infoPull As New oAuthToken
            infoPull = JsonConvert.DeserializeObject(Of oAuthToken)(requestResp)
            My.Settings.authorized = True
            My.Settings.token = infoPull.access_token
            My.Settings.refreshToken = infoPull.refresh_token
            My.Settings.Save()

            Dim t As TimeSpan = TimeSpan.FromSeconds(infoPull.expires_in)

            Dim ServerStatsPull As New ServerStats
            ServerStatsPull = JsonConvert.DeserializeObject(Of ServerStats)(sendGetRequest(baseurl & "/api/v1/info/stats"))
            LoginNotice.Text = "Server stats pulled."

            Dim gameobj As New Chilkat.JsonObject
            gameobj.AddIntAt(-1, "page", 0)
            gameobj.AddIntAt(-1, "count", 99999)
            gameobj.EmitCompact = False
            Dim mapjsontext As String = gameobj.Emit
            Dim ServerMapsPull As New GameObjectsMap
            ServerMapsPull = JsonConvert.DeserializeObject(Of GameObjectsMap)(sendPostRequestWithAuth(mapjsontext, baseurl & "/api/v1/gameobjects/map"))
            LoginNotice.Text = "Map count pulled."

            Dim npcjsontext As String = gameobj.Emit
            Dim ServerNpcPull As New GameObjectsNpc
            ServerNpcPull = JsonConvert.DeserializeObject(Of GameObjectsNpc)(sendPostRequestWithAuth(npcjsontext, baseurl & "/api/v1/gameobjects/npc"))
            LoginNotice.Text = "NPC count pulled."

            Dim questjsontext As String = gameobj.Emit
            Dim ServerQuestPull As New GameObjectsQuest
            ServerQuestPull = JsonConvert.DeserializeObject(Of GameObjectsQuest)(sendPostRequestWithAuth(questjsontext, baseurl & "/api/v1/gameobjects/quest"))
            LoginNotice.Text = "Quest count pulled."

            Dim animationjsontext As String = gameobj.Emit
            Dim ServerAnimationPull As New GameObjectsAnimation
            ServerAnimationPull = JsonConvert.DeserializeObject(Of GameObjectsAnimation)(sendPostRequestWithAuth(animationjsontext, baseurl & "/api/v1/gameobjects/animation"))
            LoginNotice.Text = "Animation count pulled."

            Dim classjsontext As String = gameobj.Emit
            Dim ServerClassPull As New GameObjectsClass
            ServerClassPull = JsonConvert.DeserializeObject(Of GameObjectsClass)(sendPostRequestWithAuth(classjsontext, baseurl & "/api/v1/gameobjects/class"))
            LoginNotice.Text = "Class count pulled."

            Dim itemjsontext As String = gameobj.Emit
            Dim ServerItemPull As New GameObjectsItem
            ServerItemPull = JsonConvert.DeserializeObject(Of GameObjectsItem)(sendPostRequestWithAuth(itemjsontext, baseurl & "/api/v1/gameobjects/item"))
            LoginNotice.Text = "Item count pulled."

            Dim projectilejsontext As String = gameobj.Emit
            Dim ServerProjectilePull As New GameObjectsProjectile
            ServerProjectilePull = JsonConvert.DeserializeObject(Of GameObjectsProjectile)(sendPostRequestWithAuth(projectilejsontext, baseurl & "/api/v1/gameobjects/projectile"))
            LoginNotice.Text = "Projectile count pulled."

            Dim resourcejsontext As String = gameobj.Emit
            Dim ServerResourcePull As New GameObjectsResource
            ServerResourcePull = JsonConvert.DeserializeObject(Of GameObjectsResource)(sendPostRequestWithAuth(resourcejsontext, baseurl & "/api/v1/gameobjects/resource"))
            LoginNotice.Text = "Resource count pulled."

            Dim shopjsontext As String = gameobj.Emit
            Dim ServerShopPull As New GameObjectsShop
            ServerShopPull = JsonConvert.DeserializeObject(Of GameObjectsShop)(sendPostRequestWithAuth(shopjsontext, baseurl & "/api/v1/gameobjects/shop"))
            LoginNotice.Text = "Shop count pulled."

            Dim spelljsontext As String = gameobj.Emit
            Dim ServerSpellPull As New GameObjectsSpell
            ServerSpellPull = JsonConvert.DeserializeObject(Of GameObjectsSpell)(sendPostRequestWithAuth(spelljsontext, baseurl & "/api/v1/gameobjects/spell"))
            LoginNotice.Text = "Spell count pulled."

            Dim crafttablejsontext As String = gameobj.Emit
            Dim ServerCraftTablePull As New GameObjectsCraftTables
            ServerCraftTablePull = JsonConvert.DeserializeObject(Of GameObjectsCraftTables)(sendPostRequestWithAuth(crafttablejsontext, baseurl & "/api/v1/gameobjects/crafttables"))
            LoginNotice.Text = "Craft Table count pulled."

            Dim craftjsontext As String = gameobj.Emit
            Dim ServerCraftPull As New GameObjectsCrafts
            ServerCraftPull = JsonConvert.DeserializeObject(Of GameObjectsCrafts)(sendPostRequestWithAuth(craftjsontext, baseurl & "/api/v1/gameobjects/crafts"))
            LoginNotice.Text = "Crafts count pulled."

            Dim eventjsontext As String = gameobj.Emit
            Dim ServerEventPull As New GameObjectsEvent
            ServerEventPull = JsonConvert.DeserializeObject(Of GameObjectsEvent)(sendPostRequestWithAuth(eventjsontext, baseurl & "/api/v1/gameobjects/event"))
            LoginNotice.Text = "Event count pulled."

            Dim playervarjsontext As String = gameobj.Emit
            Dim ServerPlayerVarPull As New GameObjectsPlayerVar
            ServerPlayerVarPull = JsonConvert.DeserializeObject(Of GameObjectsPlayerVar)(sendPostRequestWithAuth(playervarjsontext, baseurl & "/api/v1/gameobjects/playervariable"))
            LoginNotice.Text = "Player Variable count pulled."

            Dim servervarjsontext As String = gameobj.Emit
            Dim ServerServerVarPull As New GameObjectsServerVar
            ServerServerVarPull = JsonConvert.DeserializeObject(Of GameObjectsServerVar)(sendPostRequestWithAuth(servervarjsontext, baseurl & "/api/v1/gameobjects/servervariable"))
            LoginNotice.Text = "Server Variable count pulled."

            Dim tilesetjsontext As String = gameobj.Emit
            Dim ServerTilesetPull As New GameObjectsServerTileset
            ServerTilesetPull = JsonConvert.DeserializeObject(Of GameObjectsServerTileset)(sendPostRequestWithAuth(tilesetjsontext, baseurl & "/api/v1/gameobjects/tileset"))
            LoginNotice.Text = "Tileset count pulled."

            For i As Integer = 0 To ServerMapsPull.count - 1
                Dim ServerMapDetailsPull As New GameObjectsMapDetails
                ServerMapDetailsPull = JsonConvert.DeserializeObject(Of GameObjectsMapDetails)(sendGetRequest(baseurl & "/api/v1/gameobjects/map/" & ServerMapsPull.entries(i).Key))

                FormMain.WarpMapList.Items.Add(ServerMapDetailsPull.Name)
                FormMain.ChatMaps.Items.Add(ServerMapDetailsPull.Name)
                FormMain.WarpMapList.SelectedIndex = 0
                FormMain.ChatMaps.SelectedIndex = 0
            Next
            LoginNotice.Text = "Maps updated."

            Dim RankPull As String = sendGetRequest(baseurl & "/api/v1/players/rank?page=0&pageSize=10&sortDirection=Descending")
            Dim jsonstringformat As String = JValue.Parse(RankPull).ToString(Formatting.Indented)
            FormDebug.DebugText.Text = jsonstringformat
            If RankPull.Contains("Total") Then
                Dim PlayerRankPull As New ListPlayers
                PlayerRankPull = JsonConvert.DeserializeObject(Of ListPlayers)(RankPull)

                For i As Integer = 0 To PlayerRankPull.Count - 1
                    FormMain.RankTable.AddItem(i + 1, PlayerRankPull.Values(i).Level, PlayerRankPull.Values(i).Name)
                Next
                LoginNotice.Text = "Rankings updated."
            End If

            LoginNotice.Text = "Login Success: Token expires in " & t.Minutes & " minutes."

            Dim ServerConfigPull As New ServerConfig
            ServerConfigPull = JsonConvert.DeserializeObject(Of ServerConfig)(sendGetRequest(baseurl & "/api/v1/info/config"))
            LoginNotice.Text = "Server configuration pulled."

            My.Settings.maxstat = ServerConfigPull.Player.MaxStat
            My.Settings.maxbank = ServerConfigPull.Player.MaxBank
            My.Settings.maxinventory = ServerConfigPull.Player.MaxInventory
            My.Settings.maxspell = ServerConfigPull.Player.MaxSpells
            My.Settings.Save()

            FormMain.Text = "Intersect Admin [" & ServerConfigPull.GameName & ":" & ServerConfigPull.ServerPort & "]"
            FormMain.NsTheme1.Text = "Intersect Admin [" & ServerConfigPull.GameName & ":" & ServerConfigPull.ServerPort & "]"
            FormMain.OnlinePlayers.Maximum = My.Settings.maxonline
            FormMain.OnlinePlayers.Value = ServerStatsPull.onlineCount
            FormMain.CPSValue.Value2 = ServerStatsPull.cps
            Dim ts As TimeSpan = TimeSpan.FromMilliseconds(ServerStatsPull.uptime)
            Dim uptimeoutput As String = String.Format("{0:D2} Days {1:D2} Hours {2:D2} Minutes {3:D2} Seconds", ts.Days, ts.Hours, ts.Minutes, ts.Seconds)
            FormMain.UptimeValue.Value2 = uptimeoutput
            FormMain.MapsCount.Value2 = ServerMapsPull.total
            FormMain.NpcCount.Value2 = ServerNpcPull.total
            FormMain.QuestCount.Value2 = ServerQuestPull.total
            FormMain.AnimationsCount.Value2 = ServerAnimationPull.total
            FormMain.ItemsCount.Value2 = ServerItemPull.total
            FormMain.ProjectileCount.Value2 = ServerProjectilePull.total
            FormMain.ResourceCount.Value2 = ServerResourcePull.total
            FormMain.ShopsCount.Value2 = ServerShopPull.total
            FormMain.SpellsCount.Value2 = ServerSpellPull.total
            FormMain.CraftingTableCount.Value2 = ServerCraftTablePull.total
            FormMain.CraftsCount.Value2 = ServerCraftPull.total
            FormMain.EventsCount.Value2 = ServerEventPull.total
            FormMain.PlayerVarCount.Value2 = ServerPlayerVarPull.total
            FormMain.ServerVarCount.Value2 = ServerServerVarPull.total
            FormMain.TilesetsCount.Value2 = ServerTilesetPull.total
            FormMain.CpuUsage.Value = GetServerCpuPerformance()

            FormMain.RefreshTimer.Start()
            FormMain.CpuTimer.Start()
            FormMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.rememberMe Then
            NsCheckBox1.Checked = True
            UsernameTextbox.Text = My.Settings.username
            PasswordTextbox.Text = My.Settings.password
        End If
        FormDebug.Show()
    End Sub

    Private Sub NsOnOffBox1_CheckedChanged(sender As Object) Handles NsOnOffBox1.CheckedChanged
        If passvisible Then
            PasswordTextbox.UseSystemPasswordChar = True
            passvisible = False
        Else
            PasswordTextbox.UseSystemPasswordChar = False
            passvisible = True
        End If
    End Sub

    Private Sub NsCheckBox1_Click(sender As Object, e As EventArgs) Handles NsCheckBox1.Click
        If My.Settings.rememberMe Then
            My.Settings.rememberMe = False
            My.Settings.username = ""
            My.Settings.password = ""
            My.Settings.Save()
            UsernameTextbox.Text = ""
            PasswordTextbox.Text = ""
            NsCheckBox1.Checked = False
        Else
            My.Settings.rememberMe = True
            NsCheckBox1.Checked = True
        End If
    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        FormSettings.Show()
    End Sub
End Class