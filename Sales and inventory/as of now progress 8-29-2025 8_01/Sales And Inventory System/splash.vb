Public Class splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Guna2ProgressBar1.Value < 100 Then
            Guna2ProgressBar1.Value += 5
            lblPercent.Text = "Loading... " & Guna2ProgressBar1.Value & "%"
        Else
            Timer1.Stop()

            Dim mainForm As New Form1
            mainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2ProgressBar1.Value = 0
        Timer1.Interval = 50
        Timer1.Start()
    End Sub
End Class