﻿Imports System.Data.SqlClient
Public Class Bill
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angel\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand = New SqlCommand()

    Sub updateGridView()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from BillTbl", con)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Sub clearTextBoxes()
        BillId.Text = ""
        Sellername.Text = ""
        MedNme.Text = ""
        sellprice.Text = ""
        qty.Text = ""
        total.Text = ""
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim mn = New Menu
        mn.Show()
        Me.Hide()
    End Sub

    Private Sub Bprice_TextChanged(sender As Object, e As EventArgs) Handles MedNme.TextChanged
        con.Open()
        Dim cmd As New SqlCommand("select * from MedTbl where MedName LIKE '" + MedNme.Text + "' ", con)
        Dim drr As SqlDataReader = cmd.ExecuteReader()
        If (drr.Read) Then
            sellprice.Text = drr("SellingPrice").ToString

        End If
        con.Close()
    End Sub

    Private Sub Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateGridView()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        BillId.Text = DataGridView1.CurrentRow.Cells(0).Value
        BillId.Enabled = False
        Sellername.Text = DataGridView1.CurrentRow.Cells(1).Value
        MedNme.Text = DataGridView1.CurrentRow.Cells(2).Value
        sellprice.Text = DataGridView1.CurrentRow.Cells(3).Value
        qty.Text = DataGridView1.CurrentRow.Cells(4).Value
        total.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim query As String = "insert into BillTbl (BillId, SellerName, MedicineName, Price, Quantitty, TotalPrice) values ('" + BillId.Text + "','" + Sellername.Text + "','" + MedNme.Text + "','" + sellprice.Text + "', '" + qty.Text + "','" + total.Text + "')"
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
        Dim cmd As New SqlCommand("UPDATE BillTbl SET BillId= '" + BillId.Text + "', SellerName =  '" + Sellername.Text + "', MedicineName = '" + MedNme.Text + "', Price = '" + sellprice.Text + "', Quantitty = '" + qty.Text + "', TotalPrice = '" + total.Text + "' WHERE BillId = '" + BillId.Text + "' ", con)
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

        Dim cmd As New SqlCommand("delete from BillTbl where BillId = @BillId", con)
        cmd.Parameters.AddWithValue("@BillId", DataGridView1.CurrentRow.Cells(0).Value)

        MessageBox.Show("Delete Successfully")
        cmd.ExecuteNonQuery()

        updateGridView()
    End Sub
End Class