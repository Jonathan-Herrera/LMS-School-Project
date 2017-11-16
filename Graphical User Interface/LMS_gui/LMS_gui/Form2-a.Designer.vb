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
        Me.list_courses = New System.Windows.Forms.ListBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_addcourse = New System.Windows.Forms.Button()
        Me.math_classes = New System.Windows.Forms.CheckedListBox()
        Me.engineering_classes = New System.Windows.Forms.CheckedListBox()
        Me.chemistry_classes = New System.Windows.Forms.CheckedListBox()
        Me.science_classes = New System.Windows.Forms.CheckedListBox()
        Me.reading_classes = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btn_subject
        '
        Me.btn_subject.Location = New System.Drawing.Point(29, 37)
        Me.btn_subject.Name = "btn_subject"
        Me.btn_subject.Size = New System.Drawing.Size(116, 23)
        Me.btn_subject.TabIndex = 0
        Me.btn_subject.Text = "Choose Subject"
        Me.btn_subject.UseVisualStyleBackColor = True
        '
        'list_courses
        '
        Me.list_courses.FormattingEnabled = True
        Me.list_courses.Items.AddRange(New Object() {"Math", "Engineering", "Chemistry", "Science", "Reading", "Art", "Music ", "History", "Computer Science"})
        Me.list_courses.Location = New System.Drawing.Point(29, 75)
        Me.list_courses.Name = "list_courses"
        Me.list_courses.Size = New System.Drawing.Size(120, 95)
        Me.list_courses.TabIndex = 3
        Me.list_courses.Visible = False
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(29, 188)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 4
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        Me.btn_search.Visible = False
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(595, 37)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_addcourse
        '
        Me.btn_addcourse.Location = New System.Drawing.Point(414, 362)
        Me.btn_addcourse.Name = "btn_addcourse"
        Me.btn_addcourse.Size = New System.Drawing.Size(75, 23)
        Me.btn_addcourse.TabIndex = 9
        Me.btn_addcourse.Text = "Add Course"
        Me.btn_addcourse.UseVisualStyleBackColor = True
        '
        'math_classes
        '
        Me.math_classes.FormattingEnabled = True
        Me.math_classes.Items.AddRange(New Object() {"class one", "class two ", "class three ", "class four", "class five ", "class six ", "class seven"})
        Me.math_classes.Location = New System.Drawing.Point(184, 37)
        Me.math_classes.Name = "math_classes"
        Me.math_classes.Size = New System.Drawing.Size(305, 319)
        Me.math_classes.TabIndex = 10
        Me.math_classes.Visible = False
        '
        'engineering_classes
        '
        Me.engineering_classes.FormattingEnabled = True
        Me.engineering_classes.Items.AddRange(New Object() {"class one", "class two ", "class three ", "class four", "class five ", "class six ", "class seven"})
        Me.engineering_classes.Location = New System.Drawing.Point(184, 37)
        Me.engineering_classes.Name = "engineering_classes"
        Me.engineering_classes.Size = New System.Drawing.Size(305, 304)
        Me.engineering_classes.TabIndex = 11
        Me.engineering_classes.Visible = False
        '
        'chemistry_classes
        '
        Me.chemistry_classes.FormattingEnabled = True
        Me.chemistry_classes.Items.AddRange(New Object() {"class one", "class two ", "class three ", "class four", "class five ", "class six ", "class seven"})
        Me.chemistry_classes.Location = New System.Drawing.Point(184, 37)
        Me.chemistry_classes.Name = "chemistry_classes"
        Me.chemistry_classes.Size = New System.Drawing.Size(305, 289)
        Me.chemistry_classes.TabIndex = 12
        Me.chemistry_classes.Visible = False
        '
        'science_classes
        '
        Me.science_classes.FormattingEnabled = True
        Me.science_classes.Items.AddRange(New Object() {"class one", "class two ", "class three ", "class four", "class five ", "class six ", "class seven"})
        Me.science_classes.Location = New System.Drawing.Point(184, 37)
        Me.science_classes.Name = "science_classes"
        Me.science_classes.Size = New System.Drawing.Size(305, 274)
        Me.science_classes.TabIndex = 13
        Me.science_classes.Visible = False
        '
        'reading_classes
        '
        Me.reading_classes.FormattingEnabled = True
        Me.reading_classes.Items.AddRange(New Object() {"class one", "class two ", "class three ", "class four", "class five ", "class six ", "class seven"})
        Me.reading_classes.Location = New System.Drawing.Point(184, 37)
        Me.reading_classes.Name = "reading_classes"
        Me.reading_classes.Size = New System.Drawing.Size(305, 259)
        Me.reading_classes.TabIndex = 14
        Me.reading_classes.Visible = False
        '
        'Form2a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 430)
        Me.Controls.Add(Me.reading_classes)
        Me.Controls.Add(Me.science_classes)
        Me.Controls.Add(Me.chemistry_classes)
        Me.Controls.Add(Me.engineering_classes)
        Me.Controls.Add(Me.math_classes)
        Me.Controls.Add(Me.btn_addcourse)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.list_courses)
        Me.Controls.Add(Me.btn_subject)
        Me.Name = "Form2a"
        Me.Text = "Form2a"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_subject As Button
    Friend WithEvents list_courses As ListBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_addcourse As Button
    Friend WithEvents math_classes As CheckedListBox
    Friend WithEvents engineering_classes As CheckedListBox
    Friend WithEvents chemistry_classes As CheckedListBox
    Friend WithEvents science_classes As CheckedListBox
    Friend WithEvents reading_classes As CheckedListBox
End Class
