Imports System.Data.SqlClient
Public Class Login

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=C:\USERS\ANGEL\DOCUMENTS\PHARMACY.MDF;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Dim adpt As SqlDataAdapter = New SqlDataAdapter()
    Dim ds As DataSet = New DataSet()

    Private Sub lgbtn_Click(sender As Object, e As EventArgs) Handles lgbtn.Click
        If (UnameTb.Text = "" And Passtb.Text = "") Then
            MessageBox.Show("Please Fill All Filelds!")
        Else
            Try
                con.Open()
                Dim query As String = "select * from Users where UserName = '" + UnameTb.Text + "' and Password = '" + Passtb.Text + "'"
                cmd = New SqlCommand(query, con)
                adpt = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                adpt.Fill(dt)
                con.Close()
                If (dt.Rows.Count > 0) Then
                    MessageBox.Show("login Successfully!")
                    Dim frmlH As New FrmMenu
                    Me.Hide()
                    frmlH.Show()
                Else
                    MessageBox.Show("Please Check Your Details!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub lgoutbtn_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class