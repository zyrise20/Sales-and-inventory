Imports System.Data.SqlClient
Public Class Createaccount
    Dim connString As String = "Server=DESKTOP-060V3M5\SQLEXPRESS;Database=DBSalesInventory;Trusted_Connection=True;"
  

    Private Sub bntSignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntSignup.Click
        If txtusername.Text = "" OrElse txtpassword.Text = "" OrElse txtemail.Text = "" Then
            MessageBox.Show("Please fill all fields")
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO account (Username, Password, Email) VALUES (@username, @password, @Email)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account created successfully!")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guna2Shapes1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Shapes1.Click

    End Sub
End Class