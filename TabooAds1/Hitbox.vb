Public Class Hitbox
    Dim r As New Random
    Private Sub Hitbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case r.Next(1, 8)
            Case 1
                Ad1.ShowDialog()
            Case 2
                Ad2.ShowDialog()
            Case 3
                Ad3.ShowDialog()
            Case 4
                Ad4.ShowDialog()
            Case 5
                Ad5.ShowDialog()
            Case 6
                Try
                    Process.Start("C:\Program Files\Workplace2Software\TabooAds\AwesomeVacumsAd.exe")
                Catch ex As Exception
                    Ad4.ShowDialog()
                End Try
            Case 7
                Ad6.ShowDialog()
        End Select
        Application.Exit()
        End
    End Sub
End Class