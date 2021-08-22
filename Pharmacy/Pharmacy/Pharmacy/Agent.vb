Imports System.Data.SqlClient
Public Class Agent

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angel\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand = New SqlCommand()
    Sub updateGridView()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from EmpTbl", con)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Sub clearTextBoxes()
        EmpId.Text = ""
        EmpName.Text = ""
        EmpSal.Text = ""
        EmpAge.Text = ""
        EmpPhone.Text = ""
    End Sub

    Private Sub Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateGridView()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim mn = New Menu
        mn.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        EmpId.Text = DataGridView1.CurrentRow.Cells(0).Value
        EmpId.Enabled = False
        EmpName.Text = DataGridView1.CurrentRow.Cells(1).Value
        EmpSal.Text = DataGridView1.CurrentRow.Cells(2).Value
        EmpAge.Text = DataGridView1.CurrentRow.Cells(3).Value
        EmpPhone.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim query As String = "insert into EmpTbl (EmpId, EmpName, EmpSal, EmpAge, EmpPhone) values ('" + EmpId.Text + "','" + EmpName.Text + "','" + EmpSal.Text + "','" + EmpAge.Text + "','" + EmpPhone.Text + "')"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Added")

        End Using

        updateGridView()
        clearTextBoxes()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        con.Open()
        Dim cmd As New SqlCommand("UPDATE EmpTbl SET EmpId = '" + EmpId.Text + "', EmpName =  '" + EmpName.Text + "', EmpSal = '" + EmpSal.Text + "', EmpAge = '" + EmpAge.Text + "', EmpPhone = '" + EmpPhone.Text + "' WHERE EmpId = '" + EmpId.Text + "' ", con)
        cmd.ExecuteNonQuery()
        con.Close()
        updateGridView()
        clearTextBoxes()
        MessageBox.Show("Updated")
    End Sub

    Private Sub delte_Click(sender As Object, e As EventArgs) Handles delte.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim cmd As New SqlCommand("delete from EmpTbl where EmpId  = @EmpId", con)
        cmd.Parameters.AddWithValue("@EmpId", DataGridView1.CurrentRow.Cells(0).Value)

        MessageBox.Show("Delete Successfully")
        cmd.ExecuteNonQuery()

        updateGridView()
    End Sub
End Class