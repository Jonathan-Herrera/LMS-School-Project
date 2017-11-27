Public Class Form2


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Close()
    End Sub



    Private Sub lbl_one_Click(sender As Object, e As EventArgs) 

    End Sub


    Private Sub btn_drop_Click(sender As Object, e As EventArgs) Handles btn_drop.Click
        TableBindingSource.RemoveCurrent()

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.StudentsDataSet.Table)

    End Sub
End Class