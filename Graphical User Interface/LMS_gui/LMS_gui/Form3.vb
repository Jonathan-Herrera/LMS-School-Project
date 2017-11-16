Public Class Form3


    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_course1_Click(sender As Object, e As EventArgs) Handles btn_course1.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class