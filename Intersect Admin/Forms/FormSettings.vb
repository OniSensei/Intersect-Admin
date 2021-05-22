Public Class FormSettings
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        If HostTextbox.Text <> "" Then
            My.Settings.server = HostTextbox.Text
        End If
        If PortTextbox.Text <> "" Then
            My.Settings.port = PortTextbox.Text
        End If
        If MaxBanDurationTextbox.Text <> "" Then
            My.Settings.banDurationMax = MaxBanDurationTextbox.Text
        End If
        If MaxPlayersTextbox.Text <> "" Then
            My.Settings.maxonline = MaxPlayersTextbox.Text
        End If
        My.Settings.Save()

        SettingsStatus.Text = "Settings saved..."
    End Sub

    Private Sub PortTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PortTextbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub HostTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HostTextbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaxBanDurationTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaxBanDurationTextbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaxPlayersTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaxPlayersTextbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        HostTextbox.Text = My.Settings.server
        PortTextbox.Text = My.Settings.port
        MaxBanDurationTextbox.Text = My.Settings.banDurationMax
        MaxPlayersTextbox.Text = My.Settings.maxonline
    End Sub
End Class