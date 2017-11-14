Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles WelcomingLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub User_Logout_Click(sender As Object, e As EventArgs) Handles User_Logout.Click

        Form1.Show()
        Me.Close()
    End Sub
End Class