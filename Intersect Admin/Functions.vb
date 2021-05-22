Imports Newtonsoft.Json

Module Functions
    Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port

    Public Function sendPostRequest(ByVal jsonstring As String, ByVal posturl As String) As String
        Dim req As New Chilkat.HttpRequest
        Dim http As New Chilkat.Http

        Dim resp As Chilkat.HttpResponse
        resp = http.PostJson(posturl, jsonstring)
        Dim out As String
        If (http.LastMethodSuccess <> True) Then
            Debug.WriteLine(http.LastErrorText)
            out = http.LastErrorText
        Else
            ' Display the JSON response.
            Debug.WriteLine(resp.BodyStr)
            out = resp.BodyStr
        End If
        FormDebug.DebugText.Text = out
        Return out
    End Function

    Public Function sendGetRequest(ByVal geturl As String) As String
        Dim req As New Chilkat.HttpRequest
        Dim http As New Chilkat.Http
        http.SetRequestHeader("authorization", "Bearer " & My.Settings.token)

        Dim resp As Chilkat.HttpResponse
        resp = http.QuickGetObj(geturl)
        Dim out As String
        If (http.LastMethodSuccess <> True) Then
            Debug.WriteLine(http.LastErrorText)
            out = http.LastErrorText
        Else
            ' Display the JSON response.
            Debug.WriteLine(resp.BodyStr)
            out = resp.BodyStr
        End If
        FormDebug.DebugText.Text = out
        Return out
    End Function

    Public Function sendPostRequestWithAuth(ByVal jsonstring As String, ByVal posturl As String) As String
        Dim req As New Chilkat.HttpRequest
        Dim http As New Chilkat.Http
        http.SetRequestHeader("authorization", "Bearer " & My.Settings.token)

        Dim resp As Chilkat.HttpResponse
        resp = http.PostJson(posturl, jsonstring)
        Dim out As String
        If (http.LastMethodSuccess <> True) Then
            Debug.WriteLine(http.LastErrorText)
            out = http.LastErrorText
        Else
            ' Display the JSON response.
            Debug.WriteLine(resp.BodyStr)
            out = resp.BodyStr
        End If
        FormDebug.DebugText.Text = out
        Return out
    End Function

    Public Function GetServerCpuPerformance() As Integer
        Dim perfCounter As PerformanceCounter
        For Each p As Process In (From t As Process In Process.GetProcesses Where t.MainWindowTitle.Contains("Intersect Server"))
            perfCounter = New PerformanceCounter("Process", "% Processor Time", p.ProcessName)
            perfCounter.NextValue()
        Next
        Dim cpu As Integer = perfCounter.NextValue() / Environment.ProcessorCount
        Return cpu
    End Function

    Public Function MapName2ID(ByVal mapname As String) As String
        Dim mapid As String = "0000-0000-0000-0000"

        Dim gameobj As New Chilkat.JsonObject
        gameobj.AddIntAt(-1, "page", 0)
        gameobj.AddIntAt(-1, "count", 99999)
        gameobj.EmitCompact = False
        Dim mapjsontext As String = gameobj.Emit
        Dim ServerMapsPull As New GameObjectsMap
        ServerMapsPull = JsonConvert.DeserializeObject(Of GameObjectsMap)(sendPostRequestWithAuth(mapjsontext, baseurl & "/api/v1/gameobjects/map"))

        For i As Integer = 0 To ServerMapsPull.count - 1
            If ServerMapsPull.entries(i).Value.Name = mapname Then
                mapid = ServerMapsPull.entries(i).key
            End If
        Next

        Return mapid
    End Function

    Public Function MapID2Name(ByVal mapid As String) As String
        Try
            Dim mapname As String = "New Map"

            Dim gameobj As New Chilkat.JsonObject
            gameobj.AddIntAt(-1, "page", 0)
            gameobj.AddIntAt(-1, "count", 99999)
            gameobj.EmitCompact = False
            Dim mapjsontext As String = gameobj.Emit
            Dim MapsPull As New GameObjectsMap
            MapsPull = JsonConvert.DeserializeObject(Of GameObjectsMap)(sendPostRequestWithAuth(mapjsontext, baseurl & "/api/v1/gameobjects/map"))

            For i As Integer = 0 To MapsPull.count - 1
                If MapsPull.entries(i).Value.Id = mapid Then
                    mapname = MapsPull.entries(i).Value.Name
                End If
            Next

            Return mapname
        Catch ex As Exception

        End Try
    End Function

    Public Function ClassID2Name(ByVal classid As String) As String
        Try
            Dim classname As String = "New Class"

            Dim gameobj As New Chilkat.JsonObject
            gameobj.AddIntAt(-1, "page", 0)
            gameobj.AddIntAt(-1, "count", 99999)
            gameobj.EmitCompact = False
            Dim mapjsontext As String = gameobj.Emit
            Dim ClassPull As New ClassDetails
            ClassPull = JsonConvert.DeserializeObject(Of ClassDetails)(sendPostRequestWithAuth(mapjsontext, baseurl & "/api/v1/gameobjects/class"))

            For i As Integer = 0 To ClassPull.count - 1
                If ClassPull.entries(i).Value.Id = classid Then
                    classname = ClassPull.entries(i).Value.Name
                End If
            Next

            Return classname
        Catch ex As Exception

        End Try
    End Function

    Public Sub LoadUserList()
        If FormMain.UsersList.Items.Count > 0 Then
            For Each users As NSListView.NSListViewItem In FormMain.UsersList.Items
                FormMain.UsersList.RemoveItem(users)
            Next
        End If
        Dim ListUserPull As New ListUsers
        ListUserPull = JsonConvert.DeserializeObject(Of ListUsers)(sendGetRequest(baseurl & "/api/v1/users?page=0&pageSize=99999"))

        For lu As Integer = 0 To ListUserPull.Count - 1
            FormMain.UsersList.AddItem(ListUserPull.Values(lu).Name, ListUserPull.Values(lu).Email, ListUserPull.Values(lu).Id)
        Next
    End Sub

    Public Sub LoadPlayerList()
        If FormMain.PlayersList.Items.Count > 0 Then
            For Each character As NSListView.NSListViewItem In FormMain.PlayersList.Items
                FormMain.PlayersList.RemoveItem(character)
            Next
        End If
        Dim ListPlayersPull As New ListPlayers
        ListPlayersPull = JsonConvert.DeserializeObject(Of ListPlayers)(sendGetRequest(baseurl & "/api/v1/players?page=0&pageSize=99999"))

        For lp As Integer = 0 To ListPlayersPull.Count - 1
            FormMain.PlayersList.AddItem(ListPlayersPull.Values(lp).Name)
        Next
    End Sub
End Module
