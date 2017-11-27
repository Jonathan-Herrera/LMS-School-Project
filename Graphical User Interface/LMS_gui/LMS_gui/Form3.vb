Public Class Form3
    Private Sub btn_student_management_Click(sender As Object, e As EventArgs) Handles btn_student_management.Click
        Student_Management.Show()
        Me.Close()
    End Sub

    Private Sub btn_modify_student_record_Click(sender As Object, e As EventArgs) 
        Modify_Student_Record.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class