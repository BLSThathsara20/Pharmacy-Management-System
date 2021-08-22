Public Class FrmMenu
    Private Sub FrontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontToolStripMenuItem.Click

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim lg As New Login
        lg.MdiParent = Me
        lg.Show()
    End Sub

    Private Sub MedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim md As New Medicine
        md.MdiParent = Me
        md.Show()
    End Sub

    Private Sub AgentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim ag As New Agent
        ag.MdiParent = Me
        ag.Show()
    End Sub

    Private Sub ManufactureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManufactureToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim mf As New Manufacture
        mf.MdiParent = Me
        mf.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillToolStripMenuItem.Click
        If Not ActiveMdiChild Is Nothing Then
            ActiveMdiChild.Close()
        End If
        Dim bill As New Bill
        bill.MdiParent = Me
        bill.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class