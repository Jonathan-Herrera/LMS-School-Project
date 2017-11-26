<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_student_management = New System.Windows.Forms.Button()
        Me.btn_modify_student_record = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_student_management
        '
        Me.btn_student_management.Location = New System.Drawing.Point(138, 60)
        Me.btn_student_management.Name = "btn_student_management"
        Me.btn_student_management.Size = New System.Drawing.Size(172, 65)
        Me.btn_student_management.TabIndex = 0
        Me.btn_student_management.Text = "Student Management"
        Me.btn_student_management.UseVisualStyleBackColor = True
        '
        'btn_modify_student_record
        '
        Me.btn_modify_student_record.Location = New System.Drawing.Point(138, 160)
        Me.btn_modify_student_record.Name = "btn_modify_student_record"
        Me.btn_modify_student_record.Size = New System.Drawing.Size(172, 65)
        Me.btn_modify_student_record.TabIndex = 1
        Me.btn_modify_student_record.Text = "Modify Student Record"
        Me.btn_modify_student_record.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(12, 278)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(89, 36)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 326)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_modify_student_record)
        Me.Controls.Add(Me.btn_student_management)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_student_management As Button
    Friend WithEvents btn_modify_student_record As Button
    Friend WithEvents btn_logout As Button
End Class
