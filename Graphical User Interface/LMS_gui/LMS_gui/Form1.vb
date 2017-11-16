Option Strict On

Public Class Form1



    'This code helps with resizing form ------------------------------------------------------------------------------
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height

    Private Sub Form1_Resize(ByVal sender As Object,
            ByVal e As System.EventArgs) Handles Me.Resize

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width
        CH = Me.Height

    End Sub
    '------------------------------------------------------------------------------------------------
    Private Sub Form1Load(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles MyBase.Load

        IW = Me.Width
        IH = Me.Height

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txtuser.Text = "username" And txtpass.Text = "password" Then
            ProgressBar1.Show()
            Timer1.Start()
        ElseIf txtuser.Text <> "username" And txtpass.Text <> "password" Then
            MessageBox.Show("Sorry, Wrong Username Or Password")
            txtuser.Clear()
            txtpass.Clear()
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Form2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class







