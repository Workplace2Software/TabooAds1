Public Class Ad5
    Dim allowedtoclose As Boolean = False

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Try
            Process.Start("shutdown.exe", "-r -t 1")
            allowedtoclose = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ad5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If allowedtoclose = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Ad5_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        allowedtoclose = False
    End Sub

    Private Sub btn_close_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_close.Click
        allowedtoclose = True
        Me.Close()
    End Sub
End Class