﻿Imports System.Data.SqlClient
Public Class Manufacture

    Dim con As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=C:\USERS\ANGEL\DOCUMENTS\PHARMACY.MDF;Data Source=.")
    Dim cmd As SqlCommand = New SqlCommand()
    Sub updateGridView()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from CompTbl", con)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Sub clearTextBoxes()
        Comname.Text = ""
        Comphone.Text = ""
        comadd.Text = ""
    End Sub

    Private Sub Manufacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateGridView()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Comname.Text = DataGridView1.CurrentRow.Cells(1).Value
        Comphone.Text = DataGridView1.CurrentRow.Cells(2).Value
        comadd.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim query As String = "insert into CompTbl (CompName, CompPhone, CompAdd) values ('" + Comname.Text + "','" + Comphone.Text + "','" + comadd.Text + "')"
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
        Dim cmd As New SqlCommand("UPDATE CompTbl SET CompName =  '" + Comname.Text + "', CompPhone = '" + Comphone.Text + "', CompAdd = '" + comadd.Text + "' WHERE CompId = @CID ", con)
        cmd.Parameters.AddWithValue("@CID", DataGridView1.CurrentRow.Cells(0).Value)
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

        Dim cmd As New SqlCommand("delete from CompTbl where CompId = @CompId", con)
        cmd.Parameters.AddWithValue("@CompId", DataGridView1.CurrentRow.Cells(0).Value)

        MessageBox.Show("Delete Successfully")
        cmd.ExecuteNonQuery()

        updateGridView()
    End Sub
End Class