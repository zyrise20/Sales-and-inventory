Imports System.Data.SqlClient
Public Class Login
    Dim connString As String = "Server=DESKTOP-060V3M5\SQLEXPRESS; Database=DBSalesInventory; Trusted_Connection=True;"


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        txtpassword.PasswordChar = ControlChars.NullChar
        PictureBox3.Hide()
        PictureBox4.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        txtpassword.PasswordChar = "●"c
        PictureBox4.Hide()
        PictureBox3.Show()
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        txtpassword.PasswordChar = "●"c
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = bntlogin
        
       
    End Sub

    Private Sub bntlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntlogin.Click
        If txtuser.Text.Trim() = "" OrElse txtpassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter both Username and Password")
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM account WHERE Username=@username AND Password=@password"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtuser.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim())

                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()

                        ' ✅ Store the username & email from database
                        LoggedInUsername = reader("Username").ToString()
                        LoggedInEmail = reader("Email").ToString()

                        If txtuser.Text.Trim().ToLower() = "admin" Then
                            MessageBox.Show("Welcome Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Login Successful!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Dim f As New splash()
                        f.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Password")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
        txtuser.Text = ""
        txtpassword.Text = ""
        
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Createaccount.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Forgotaccount.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2TileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Me.Close()
    End Sub
End Class