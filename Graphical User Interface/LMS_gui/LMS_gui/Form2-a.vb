Public Class Form2a





    'this button opens up a screen for each subjects from which specific classes show up
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If list_courses.SelectedItem = "Math" Then
            math_classes.Show()

        ElseIf list_courses.SelectedItem = "Engineering" Then
            engineering_classes.Show()

        ElseIf list_courses.SelectedItem = "Chemistry" Then
            chemistry_classes.Show()

        ElseIf list_courses.SelectedItem = "Science" Then
            science_classes.Show()

        ElseIf list_courses.SelectedItem = "Reading" Then
            reading_classes.Show()

        Else
            MsgBox("Please Select a subject")


        End If
    End Sub

    'this button opens up a list of subject
    Private Sub btn_subject_Click(sender As Object, e As EventArgs) Handles btn_subject.Click
        btn_search.Show()
        list_courses.Show()
    End Sub

    'this button allows user to go back to the original screen
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form2.Show()
        Me.Close()
    End Sub

    'this button adds a courses and displays it in a list view in Form 2 under My courses
    Private Sub btn_addcourse_Click(sender As Object, e As EventArgs) Handles btn_addcourse.Click

        Dim intIndex As Integer


        For intIndex = 0 To math_classes.Items.Count - 1
            If math_classes.GetItemChecked(intIndex) = True Then
                Form2.classess.Items.Add(math_classes.Items(intIndex))
            End If
        Next


        For intIndex = 0 To math_classes.Items.Count - 1
            If engineering_classes.GetItemChecked(intIndex) = True Then
                Form2.classess.Items.Add(engineering_classes.Items(intIndex))
            End If
        Next

        For intIndex = 0 To math_classes.Items.Count - 1
            If chemistry_classes.GetItemChecked(intIndex) = True Then
                Form2.classess.Items.Add(chemistry_classes.Items(intIndex))
            End If
        Next

        For intIndex = 0 To math_classes.Items.Count - 1
            If science_classes.GetItemChecked(intIndex) = True Then
                Form2.classess.Items.Add(science_classes.Items(intIndex))
            End If
        Next


        Form2.Show()
        Me.Close()



    End Sub
End Class