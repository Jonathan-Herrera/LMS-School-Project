Public Class Form2


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn_add_course_Click(sender As Object, e As EventArgs) Handles btn_add_course.Click
        Form2a.Show()
        Me.Close()
    End Sub

    Private Sub lbl_one_Click(sender As Object, e As EventArgs) Handles lbl_one.Click

    End Sub
End Class