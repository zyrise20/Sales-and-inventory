Imports System.Data.SqlClient

Public Class Product
    Dim con As New SqlConnection("Server=DESKTOP-060V3M5\SQLEXPRESS; Database=DBSalesInventory; Trusted_Connection=True;")

    Private Sub FormAddProduct_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbCategory.Items.AddRange(New String() {"Hot Drinks", "Cold Drinks", "Snacks", "Desserts"})
        cmbcategory.SelectedIndex = 0
        Timer1.Start()
    End Sub

    Private Sub txtprodu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprodu.TextChanged

    End Sub

    Private Sub txtquantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bntadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntadd.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO tbl_products (product_name, price, quantity, category) VALUES (@name, @price, @quantity, @category)", con)
            cmd.Parameters.AddWithValue("@name", txtprodu.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtprice.Text))
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtquantity.Text))
            cmd.Parameters.AddWithValue("@category", cmbcategory.Text)
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Product successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtprodu.Clear()
            txtprice.Clear()
            txtquantity.Clear()
            cmbcategory.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:tt")
    End Sub


End Class
