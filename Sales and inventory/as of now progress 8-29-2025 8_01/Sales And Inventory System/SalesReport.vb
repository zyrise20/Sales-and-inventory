Imports System.Data.SqlClient

Public Class SalesReport
    Dim con As New SqlConnection("Server=DESKTOP-060V3M5\SQLEXPRESS; Database=DBSalesInventory; Trusted_Connection=True;")

    Private Sub SalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSales()
        LoadTotalSales()
        cmbfilter.Items.Clear()
        cmbfilter.Items.Add("All")
        cmbfilter.Items.Add("Milk Tea")
        cmbfilter.Items.Add("Hot Drinks")
        cmbfilter.Items.Add("Juice")
        cmbfilter.SelectedIndex = 0
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt")
    End Sub

    Private Sub LoadTotalSales()
        Try
            Dim query As String = "SELECT ISNULL(SUM(sales), 0) FROM tbl_sales"
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Dim total As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                con.Close()

                lblTotalSales.Text = "Total: ₱" & total.ToString("N2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing sales: " & ex.Message)
        End Try

    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadSales()
    End Sub

    Private Sub LoadSales(Optional ByVal category As String = "All", Optional ByVal search As String = "")
        Dim query As String = "SELECT sale_id, product_id, product_name, category, quantity, sales, sale_date FROM tbl_sales WHERE 1=1"
        Dim cmd As New SqlCommand()
        cmd.Connection = con

        ' Apply category filter only if not "All"
        If category <> "All" Then
            query &= " AND category = @category"
            cmd.Parameters.AddWithValue("@category", category)
        End If

        ' Apply search filter only if not empty
        If search.Trim() <> "" Then
            query &= " AND (product_name LIKE @search OR CAST(product_id AS VARCHAR) LIKE @search)"
            cmd.Parameters.AddWithValue("@search", "%" & search & "%")
        End If

        query &= " ORDER BY sale_date DESC"
        cmd.CommandText = query

        Dim dt As New DataTable()
        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        End Using

        dgvSales.DataSource = dt
    End Sub

    Private Sub cmbfilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfilter.SelectedIndexChanged
        LoadSales(cmbfilter.Text)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = "SalesReport.csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Using sw As New System.IO.StreamWriter(sfd.FileName, False)
                    ' Write headers
                    For i As Integer = 0 To dgvSales.Columns.Count - 1
                        sw.Write(EscapeCsv(dgvSales.Columns(i).HeaderText))
                        If i < dgvSales.Columns.Count - 1 Then sw.Write(",")
                    Next
                    sw.WriteLine()

                    ' Write data rows
                    For Each row As DataGridViewRow In dgvSales.Rows
                        If Not row.IsNewRow Then
                            For i As Integer = 0 To dgvSales.Columns.Count - 1
                                Dim cellValue As String = ""

                                If row.Cells(i).Value IsNot Nothing Then
                                    If TypeOf row.Cells(i).Value Is DateTime Then
                                        ' Excel-friendly date format without quotes
                                        cellValue = CType(row.Cells(i).Value, DateTime).ToString("MM/dd/yyyy HH:mm:ss")
                                    Else
                                        cellValue = row.Cells(i).Value.ToString()
                                        ' Escape only non-date text
                                        cellValue = EscapeCsv(cellValue)
                                    End If
                                End If

                                sw.Write(cellValue)
                                If i < dgvSales.Columns.Count - 1 Then sw.Write(",")
                            Next
                            sw.WriteLine()
                        End If
                    Next
                End Using

                MessageBox.Show("CSV file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting to CSV: " & ex.Message)
        End Try
    End Sub
    Private Function EscapeCsv(ByVal value As String) As String
        If value.Contains(",") Or value.Contains("""") Or value.Contains(vbCr) Or value.Contains(vbLf) Then
            value = value.Replace("""", """""") ' Escape quotes
            value = """" & value & """" ' Wrap in quotes
        End If
        Return value
    End Function

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadSales(cmbfilter.Text, txtSearch.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm tt")
    End Sub

    Private Sub lblTotalSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalSales.Click

    End Sub



    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Hide()
    End Sub
End Class
