Imports System.Data.SqlClient

Public Class Stocks
    Dim con As New SqlConnection("Server=DESKTOP-060V3M5\SQLEXPRESS; Database=DBSalesInventory; Trusted_Connection=True;")
    Private Sub Stocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT product_id FROM tbl_products"
        Dim cmd As New SqlCommand(query, con)
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cmbProductID.Items.Add(reader("product_id").ToString())
        End While
        con.Close()
        Timer1.Start()
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductID.SelectedIndexChanged
        Dim query As String = "SELECT product_name, price, category, quantity FROM tbl_products WHERE product_id = @id"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id", cmbProductID.Text)
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            txtProductName.Text = reader("product_name").ToString()
            txtPrice.Text = reader("price").ToString()
            txtCategory.Text = reader("category").ToString()
            txtStock.Text = reader("quantity").ToString()
        End If
        con.Close()
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtyBuy.TextChanged
        If IsNumeric(txtPrice.Text) AndAlso IsNumeric(txtQtyBuy.Text) Then
            Dim total As Decimal = Val(txtPrice.Text) * Val(txtQtyBuy.Text)
            txtSale.Text = total.ToString("F2")
        Else
            txtSale.Text = ""
        End If
    End Sub

    Private Sub btnSell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSell.Click
        If Not IsNumeric(txtQtyBuy.Text) Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim currentQty As Integer = Val(txtStock.Text)
        Dim buyQty As Integer = Val(txtQtyBuy.Text)

        If buyQty <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If buyQty > currentQty Then
            MessageBox.Show("Not enough stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newQty As Integer = currentQty - buyQty


        Dim updateQuery As String = "UPDATE tbl_products SET quantity = @qty WHERE product_id = @id"
        Using cmd As New SqlCommand(updateQuery, con)
            cmd.Parameters.AddWithValue("@qty", newQty)
            cmd.Parameters.AddWithValue("@id", cmbProductID.Text)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using


        Dim insertQuery As String = "INSERT INTO tbl_sales (product_id, product_name, category, quantity, sales, sale_date)  VALUES (@id, @pname, @cat, @qty, @sales, GETDATE())"

        Using cmd As New SqlCommand(insertQuery, con)
            cmd.Parameters.AddWithValue("@id", cmbProductID.Text)
            cmd.Parameters.AddWithValue("@pname", txtProductName.Text)
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text)
            cmd.Parameters.AddWithValue("@qty", buyQty)
            cmd.Parameters.AddWithValue("@sales", Val(txtPrice.Text) * buyQty)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using

        MessageBox.Show("New Sales added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh UI
        txtStock.Text = newQty.ToString()
        txtQtyBuy.Clear()
        txtSale.Clear()

    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged

    End Sub

    Private Sub txtSale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSale.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:tt")
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Me.Hide()
    End Sub
End Class