<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2a
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
        Me.btn_subject = New System.Windows.Forms.Button()
        Me.btn_goback = New System.Windows.Forms.Button()
        Me.list_courses = New System.Windows.Forms.ListBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.list_addcourse1 = New System.Windows.Forms.ListBox()
        Me.list_addcourse2 = New System.Windows.Forms.ListBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_subject
        '
        Me.btn_subject.Location = New System.Drawing.Point(59, 37)
        Me.btn_subject.Name = "btn_subject"
        Me.btn_subject.Size = New System.Drawing.Size(116, 23)
        Me.btn_subject.TabIndex = 0
        Me.btn_subject.Text = "Choose Subject"
        Me.btn_subject.UseVisualStyleBackColor = True
        '
        'btn_goback
        '
        Me.btn_goback.Location = New System.Drawing.Point(698, 37)
        Me.btn_goback.Name = "btn_goback"
        Me.btn_goback.Size = New System.Drawing.Size(75, 23)
        Me.btn_goback.TabIndex = 2
        Me.btn_goback.Text = "Go Back"
        Me.btn_goback.UseVisualStyleBackColor = True
        '
        'list_courses
        '
        Me.list_courses.FormattingEnabled = True
        Me.list_courses.Items.AddRange(New Object() {"Math", "Engineering", "Chemistry", "Science", "Reading", "Art", "Music ", "History", "Computer Science"})
        Me.list_courses.Location = New System.Drawing.Point(59, 89)
        Me.list_courses.Name = "list_courses"
        Me.list_courses.Size = New System.Drawing.Size(120, 95)
        Me.list_courses.TabIndex = 3
        Me.list_courses.Visible = False
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(59, 218)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 4
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        Me.btn_search.Visible = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(494, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'list_addcourse1
        '
        Me.list_addcourse1.FormattingEnabled = True
        Me.list_addcourse1.Items.AddRange(New Object() {"Class1", "Class2", "Class3", "Class4", "Class5", "Class6", "Class7", "Class8", "Class9", "Class10"})
        Me.list_addcourse1.Location = New System.Drawing.Point(213, 53)
        Me.list_addcourse1.Name = "list_addcourse1"
        Me.list_addcourse1.Size = New System.Drawing.Size(301, 199)
        Me.list_addcourse1.TabIndex = 7
        Me.list_addcourse1.Visible = False
        '
        'list_addcourse2
        '
        Me.list_addcourse2.FormattingEnabled = True
        Me.list_addcourse2.Items.AddRange(New Object() {"Class1", "Class2", "Class3", "Class4", "Class5", "Class6", "Class7", "Class8", "Class9", "Class10"})
        Me.list_addcourse2.Location = New System.Drawing.Point(213, 120)
        Me.list_addcourse2.Name = "list_addcourse2"
        Me.list_addcourse2.Size = New System.Drawing.Size(301, 199)
        Me.list_addcourse2.TabIndex = 8
        Me.list_addcourse2.Visible = False
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(439, 325)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Add Course"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Form2a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 370)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.list_addcourse2)
        Me.Controls.Add(Me.list_addcourse1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.list_courses)
        Me.Controls.Add(Me.btn_goback)
        Me.Controls.Add(Me.btn_subject)
        Me.Name = "Form2a"
        Me.Text = "Form2a"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_subject As Button
    Friend WithEvents btn_goback As Button
    Friend WithEvents list_courses As ListBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents list_addcourse1 As ListBox
    Friend WithEvents list_addcourse2 As ListBox
    Friend WithEvents btn_add As Button
End Class
