Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UsernameField.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UsernameField.Text = "administrator" And PasswordField.Text = "password" Then
            Call adminlogin()
        ElseIf UsernameField.Text = "student" And PasswordField.Text = "password2" Then
            Call userlogin()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub

    Private Sub adminlogin()
        Form2.Text = "ChalkBoard"
        Form2.WelcomingLabel.Text = "Welcome Administrator!"
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub userlogin()
        Form2.Text = "ChalkBoard"
        Form2.WelcomingLabel.Text = "Welcome Student!"
        Form2.Show()
        Me.Close()
    End Sub


End Class

