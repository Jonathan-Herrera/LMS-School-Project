Public Class Student_Management
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.StudentsDataSet.Table)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub Student_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentsDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.StudentsDataSet.Table)
        'TODO: This line of code loads data into the 'StudentsDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.StudentsDataSet.Table)

    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        TableBindingSource.MovePrevious()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        TableBindingSource.MoveNext()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            Me.TableTableAdapter.Insert(CInt(txt_id.Text), CStr(txt_fname.Text), CStr(txt_lname.Text),
                                        CStr(txt_user.Text), CStr(txt_pass.Text), CStr(txt_phone.Text),
                                        CInt(txt_studentid.Text), CStr(txt_class.Text), CInt(txt_t1.Text),
                                        CInt(txt_t2.Text), CInt(txt_t3.Text))
            Me.TableTableAdapter.Fill(StudentsDataSet.Table)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        TableBindingSource.RemoveCurrent()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Me.Validate()
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.StudentsDataSet.Table)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TableBindingSource.EndEdit()
            Me.TableTableAdapter.Update(Me.StudentsDataSet.Table)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class