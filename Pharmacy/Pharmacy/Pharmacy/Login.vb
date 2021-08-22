Public Class Login
    Private Sub lgbtn_Click(sender As Object, e As EventArgs) Handles lgbtn.Click
        If UnameTb.Text = "" Or Passtb.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf UnameTb.Text = "Admin" And Passtb.Text = "Password" Then
            Dim mn = New Menu
            mn.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub

    Private Sub lgoutbtn_Click(sender As Object, e As EventArgs) Handles lgoutbtn.Click
        Application.Exit()
    End Sub
End Class