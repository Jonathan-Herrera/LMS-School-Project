Public Class Course4Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim i As ListViewItem
        i = ListView1.Items.Add(FirstNameTextBox.Text)
        i.SubItems.Add(LastNameTextBox.Text)
        i.SubItems.Add(Entry1.Text)
        i.SubItems.Add(Entry2.Text)
        i.SubItems.Add(Entry3.Text)
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class