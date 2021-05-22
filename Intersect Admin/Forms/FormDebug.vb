Public Class FormDebug
    Dim baseurl As String = "http://" & My.Settings.server & ":" & My.Settings.port
    Private Sub XylosButton1_Click(sender As Object, e As EventArgs) Handles XylosButton1.Click
        Dim jsonobj As New Chilkat.JsonObject
        jsonobj.AddIntAt(-1, "page", 0)
        jsonobj.AddIntAt(-1, "count", 10)
        jsonobj.EmitCompact = False
        Dim jsontext As String = jsonobj.Emit
        Dim requestResp As String = sendPostRequestWithAuth(jsontext, baseurl & PostText.Text)
    End Sub

    Private Sub XylosButton2_Click(sender As Object, e As EventArgs) Handles XylosButton2.Click
        Dim requestResp As String = sendGetRequest(baseurl & GetText.Text)
        DebugText2.Text = requestResp
    End Sub
End Class