Public Class Menu
    Private Sub MedBtn_Click(sender As Object, e As EventArgs) Handles MedBtn.Click
        Dim md = New Medicine
        md.Show()
        Me.Hide()
    End Sub

    Private Sub Agentbtn_Click(sender As Object, e As EventArgs) Handles Agentbtn.Click
        Dim ag = New Agent
        ag.Show()
        Me.Hide()
    End Sub

    Private Sub ManBtn_Click(sender As Object, e As EventArgs) Handles ManBtn.Click
        Dim mf = New Manufacture
        mf.Show()
        Me.Hide()
    End Sub

    Private Sub BillBtn_Click(sender As Object, e As EventArgs) Handles BillBtn.Click
        Dim bill = New Bill
        bill.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub
End Class