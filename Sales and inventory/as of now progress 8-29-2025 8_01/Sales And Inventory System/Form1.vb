Imports System.Data.SqlClient
Imports System
Public Class Form1
    Dim connString As String = "Server=DESKTOP-060V3M5\SQLEXPRESS;Database=DBSalesInventory;Integrated Security=True;"
    Dim con As New SqlConnection(connString)
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        TotalStocks()
        TotalStock()
        TotalCategory()
        LoadLowStocks()
        
    End Sub

    Private Sub Guna2TileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntproduct.Click
        Product.Show()

    End Sub


    Private Sub Guna2TileButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        inventory.Show()
    End Sub

    Private Sub bntsales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Stocks As New Stocks()
        Stocks.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:tt")
    End Sub

    Private Sub bntsreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SalesReport.Show()
    End Sub


    Private Sub TotalStocks()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblstocks.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error counting total stocks: " & ex.Message)
        End Try
    End Sub
    Private Sub TotalStock()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Sum all quantities from tbl_products
                Dim query As String = "SELECT SUM(Quantity) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    ' If no products yet, show 0
                    If IsDBNull(result) OrElse result Is Nothing Then
                        lblstock.Text = "0"
                    Else
                        lblstock.Text = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error getting total stocks: " & ex.Message)
        End Try
    End Sub
    Private Sub TotalCategory()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                ' Count unique categories
                Dim query As String = "SELECT COUNT(DISTINCT category) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblcategory.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error counting categories: " & ex.Message)
        End Try
    End Sub
    Private Sub RefreshTotalProducts()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblstocks.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error counting products: " & ex.Message)
        End Try
    End Sub

    ' ✅ Total Stocks (sum of Quantity column)
    Private Sub RefreshTotalStocks()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT SUM(Quantity) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim result As Object = cmd.ExecuteScalar()
                    If IsDBNull(result) OrElse result Is Nothing Then
                        lblstock.Text = "0"
                    Else
                        lblstock.Text = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error getting total stocks: " & ex.Message)
        End Try
    End Sub

    ' ✅ Total Categories (count unique categories)
    Private Sub RefreshTotalCategories()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT COUNT(DISTINCT category) FROM tbl_products"
                Using cmd As New SqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblCategory.Text = count.ToString()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error counting categories: " & ex.Message)
        End Try
    End Sub

   
    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        RefreshDashboard()
        LoadLowStocks()
    End Sub
    Private Sub RefreshDashboard()
        RefreshTotalProducts()
        RefreshTotalStocks()
        RefreshTotalCategories()
    End Sub
    Sub LoadLowStocks()
        Try
            con.Open()
            Dim query As String = "SELECT product_name, Quantity, Category " & "FROM tbl_products " & "WHERE Quantity <= 10"   ' set threshold here
            cmd = New SqlCommand(query, con)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Bind to DataGridView
            dgvlowstocks.DataSource = dt

            ' Show alert if there are low stock items
           
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        LoadLowStocks()
    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Application.Exit()
    End Sub

    Private Sub bntuser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntuser.Click
        Dim uf As New userform()
        uf.ShowDialog()
    End Sub

    Private Sub bntproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntproduct.Click
        Product.Show()
    End Sub

    Private Sub bntinventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntinventory.Click
        inventory.Show()
    End Sub

    Private Sub bntsales_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntsales.Click
        Dim Stocks As New Stocks()
        Stocks.Show()
    End Sub

    Private Sub bntsreport_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntsreport.Click
        SalesReport.Show()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class
