Public Class Form4


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim i As ListViewItem
        i = ListView1.Items.Add(FirstNameTextBox.Text)
        i.SubItems.Add(LastNameTextBox.Text)
        i.SubItems.Add(Entry1.Text)
        i.SubItems.Add(Entry2.Text)
        i.SubItems.Add(Entry3.Text)



    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class