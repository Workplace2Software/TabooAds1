Public Class Ad1
    Dim GrooveMove As Integer = 1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.OldManDance, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If GrooveMove = 1 Then
            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y)
            GrooveMove = 2
        Else
            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y)
            GrooveMove = 1
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
