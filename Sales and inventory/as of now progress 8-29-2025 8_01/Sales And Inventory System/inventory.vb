Imports System.Data.SqlClient

Public Class inventory


    Dim con As New SqlConnection("Server=DESKTOP-060V3M5\SQLEXPRESS; Database=DBSalesInventory; Trusted_Connection=True;")

    Private Sub FormInventoryReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadInventory()
        cmbcategory.Items.Clear()
        cmbcategory.Items.Add("Beverage")
        cmbcategory.Items.Add("Pastry")
        cmbcategory.Items.Add("Snacks")
        cmbcategory.Items.Add("Coffee")
        cmbcategory.Items.Add("Dessert")
        cmbcategory.SelectedIndex = -1
        Timer1.Start()
    End Sub

    Private Sub LoadInventory()
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM tbl_products"
            Dim adapter As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvproducts.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
            con.Close()
        End Try
    End Sub


    Private Sub dgvInventory_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvproducts.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvproducts.Rows(e.RowIndex)
            txtprodu.Text = row.Cells("product_id").Value.ToString()
            txtProductName.Text = row.Cells("product_name").Value.ToString()
            txtPrice.Text = row.Cells("price").Value.ToString()
            txtQuantity.Text = row.Cells("quantity").Value.ToString()
            cmbcategory.Text = row.Cells("category").Value.ToString()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Product.Show()

    End Sub

   
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            Dim searchQuery As String = "SELECT product_id, product_name, price, quantity, category FROM tbl_products WHERE product_name LIKE @search OR CAST(product_id AS VARCHAR) LIKE @search"
            Dim adapter As New SqlDataAdapter(searchQuery, con)
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvproducts.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Shapes1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Shapes1.Click

    End Sub

    Private Sub btnExportCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportCSV.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = "InventoryReport.csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim sw As New System.IO.StreamWriter(sfd.FileName, False)


                For i As Integer = 0 To dgvproducts.Columns.Count - 1
                    sw.Write(dgvproducts.Columns(i).HeaderText)
                    If i < dgvproducts.Columns.Count - 1 Then
                        sw.Write(",")
                    End If
                Next
                sw.WriteLine()


                For Each row As DataGridViewRow In dgvproducts.Rows
                    If Not row.IsNewRow Then
                        For i As Integer = 0 To dgvproducts.Columns.Count - 1
                            sw.Write(row.Cells(i).Value.ToString())
                            If i < dgvproducts.Columns.Count - 1 Then
                                sw.Write(",")
                            End If
                        Next
                        sw.WriteLine()
                    End If
                Next

                sw.Close()
                MessageBox.Show("CSV file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting to CSV: " & ex.Message)
        End Try
    End Sub

    Private Sub bntrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntrefresh.Click
        LoadInventory()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Product.Show()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvproducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim selectedRow As DataGridViewRow = dgvproducts.SelectedRows(0)
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)

                con.Open()
                Dim cmd As New SqlCommand("DELETE FROM tbl_products WHERE product_id = @id", con)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadInventory()
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
                con.Close()
            End Try
        End If
        txtprodu.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbcategory.SelectedIndex = -1
        txtProductName.Focus()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtprodu.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cmbcategory.SelectedIndex = -1
        txtProductName.Focus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtprodu.Text = "" Then
                MessageBox.Show("Please select a product to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con.Open()
            Dim query As String = "UPDATE tbl_products SET product_name = @name, price = @price, quantity = @quantity, category = @category WHERE product_id = @id"
            Dim cmd As New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@name", txtProductName.Text)
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@category", cmbcategory.Text)
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtprodu.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()

            LoadInventory()

        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Shapes2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Shapes2.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:tt")
    End Sub

    Private Sub Guna2Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Me.Hide()

    End Sub
End Class