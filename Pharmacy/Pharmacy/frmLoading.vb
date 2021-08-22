Public Class frmLoading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerPb.Tick
        If ProgressBar1.Value >= 100 Then
            ProgressBar1.Value = 0
            Dim frmL As New Login
            Me.Hide()
            TimerPb.Stop()
            frmL.Show()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            lblLodingPrecentage.Text = ProgressBar1.Value & "% Completing..."
        End If
    End Sub

    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerPb.Start()
    End Sub
End Class