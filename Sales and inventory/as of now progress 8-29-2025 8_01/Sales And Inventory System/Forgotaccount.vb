Imports System.Data.SqlClient
Public Class Forgotaccount
    Dim connString As String = "Server=DESKTOP-060V3M5\SQLEXPRESS;Database=DBSalesInventory;;Trusted_Connection=True;"

    Private Sub Forgotaccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub bntRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntRetrieve.Click
        If txtusername.Text = "" OrElse txtemail.Text = "" Then
            MessageBox.Show("Please enter your Username and Email")
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT Password FROM account WHERE Username=@username AND Email=@Email"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim())

                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        MessageBox.Show("Your Password is: " & reader("Password").ToString())
                    Else
                        MessageBox.Show("No account found with this Username and Email")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try

    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Me.Hide()
    End Sub
End Class