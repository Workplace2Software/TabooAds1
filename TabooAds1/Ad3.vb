Public Class Ad3
    Dim Countdown As Integer = 6
    Private Sub Ad3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Countdown = 1 Then
            e.Cancel = True
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Ad3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.Ad3_MUS, AudioPlayMode.BackgroundLoop)
        Countdown = 6
        Button1.Text = "5"
        Button1.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Countdown = 6 Then
            Countdown = 5
            Button1.Text = "4"
        ElseIf Countdown = 5 Then
            Countdown = 4
            Button1.Text = "3"
        ElseIf Countdown = 4 Then
            Countdown = 3
            Button1.Text = "2"
        ElseIf Countdown = 3 Then
            Countdown = 2
            Button1.Text = "1"
        ElseIf Countdown = 2 Then
            Countdown = 1
            Timer1.Stop()
            Button1.Text = "> Skip Ad"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class