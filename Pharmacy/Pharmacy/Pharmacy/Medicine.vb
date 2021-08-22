Imports System.Data.SqlClient
Public Class Medicine
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angel\Documents\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand = New SqlCommand()
    Sub updateGridView()
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from MedTbl", con)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Sub clearTextBoxes()
        Medname.Text = ""
        Bprice.Text = ""
        sellprice.Text = ""
        qty.Text = ""
        dt.Text = ""
        cmpany.Text = ""
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateGridView()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim mn = New Menu
        mn.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Medname.Text = DataGridView1.CurrentRow.Cells(0).Value
        Medname.Enabled = False
        Bprice.Text = DataGridView1.CurrentRow.Cells(1).Value
        sellprice.Text = DataGridView1.CurrentRow.Cells(2).Value
        qty.Text = DataGridView1.CurrentRow.Cells(3).Value
        dt.Text = DataGridView1.CurrentRow.Cells(4).Value
        cmpany.Text = DataGridView1.CurrentRow.Cells(5).Value

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim query As String = "insert into MedTbl (MedName,BuyingPrice, SellingPrice, MedQty, ExpDate, Company) values ('" + Medname.Text + "','" + Bprice.Text + "','" + sellprice.Text + "','" + qty.Text + "','" + dt.Text + "','" + cmpany.Text + "')"
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
        Dim cmd As New SqlCommand("UPDATE MedTbl SET MedName = '" + Medname.Text + "', BuyingPrice =  '" + Bprice.Text + "', SellingPrice = '" + sellprice.Text + "', MedQty = '" + qty.Text + "', ExpDate = '" + dt.Text + "', Company = '" + cmpany.Text + "' WHERE MedName = '" + Medname.Text + "' ", con)
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

        Dim cmd As New SqlCommand("delete from MedTbl where MedName = @MedName", con)
        cmd.Parameters.AddWithValue("@MedName", DataGridView1.CurrentRow.Cells(0).Value)

        MessageBox.Show("Delete Successfully")
        cmd.ExecuteNonQuery()

        updateGridView()
    End Sub
End Class