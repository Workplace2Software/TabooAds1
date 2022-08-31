Public Class Ad2

    Private Sub Ad2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Process.Start("https://motion-ninja-pro-video-editor-animation-maker.en.softonic.com/android")
        Me.Close()
    End Sub

    Private Sub Ad2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Ad2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Ad2_MUS, AudioPlayMode.BackgroundLoop)
    End Sub
End Class