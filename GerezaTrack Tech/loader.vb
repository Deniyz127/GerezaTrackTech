Public Class loader
    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value > 1 And ProgressBar1.Value < 40 Then
            lblloader.Text = "Hi, we are setting up things for you..."
        Else
            If ProgressBar1.Value > 40 And ProgressBar1.Value < 70 Then
                lblloader.Text = "Connecting components..."
            Else
                If ProgressBar1.Value > 70 And ProgressBar1.Value < 99 Then
                    lblloader.Text = "Almost There..."
                Else
                    If ProgressBar1.Value > 100 And ProgressBar1.Value < 145 Then
                        lblloader.Text = "Welcome to GerezaTrack Tech..."
                    End If
                End If
            End If
        End If
        If ProgressBar1.Value = 140 Then
            Timer1.Enabled = False
            Me.Hide()
            login.Show()
        End If
    End Sub
End Class
