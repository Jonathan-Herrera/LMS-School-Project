Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Course1Button_Click(sender As Object, e As EventArgs) Handles Course1Button.Click
        Me.Hide()
        Course4Form.Show()
    End Sub

    Private Sub Course2Button_Click(sender As Object, e As EventArgs) Handles Course2Button.Click

    End Sub

    Private Sub Course3Button_Click(sender As Object, e As EventArgs) Handles Course3Button.Click

    End Sub

    Private Sub Course4Button_Click(sender As Object, e As EventArgs) Handles Course4Button.Click

    End Sub
End Class