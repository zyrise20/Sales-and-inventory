Public Class userform

    Private Sub userform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsername.Text = LoggedInUsername
        lblEmail.Text = LoggedInEmail


       
    End Sub

    
    Private Sub lblname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub lblEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        Me.Hide()
    End Sub
End Class