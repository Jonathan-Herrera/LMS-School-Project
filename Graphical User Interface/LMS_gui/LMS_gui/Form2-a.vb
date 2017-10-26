Public Class Form2a


    Private Sub btn_goback_Click(sender As Object, e As EventArgs) Handles btn_goback.Click
        Form2.Show()
        Me.Close()
    End Sub



    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If list_courses.SelectedItem = "Math" Then
            list_addcourse1.Show()



        ElseIf list_courses.SelectedItem = "Engineering" Then

            list_addcourse2.Show()






            MsgBox("Please Select a subject")
        End If
    End Sub

    Private Sub btn_subject_Click(sender As Object, e As EventArgs) Handles btn_subject.Click
        btn_search.Show()
        list_courses.Show()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub list_addcourse9_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Form2.Show()
    End Sub
End Class