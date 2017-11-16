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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Course1Button = New System.Windows.Forms.Button()
        Me.Course2Button = New System.Windows.Forms.Button()
        Me.Course3Button = New System.Windows.Forms.Button()
        Me.Course4Button = New System.Windows.Forms.Button()
        Me.Course1Label = New System.Windows.Forms.Label()
        Me.Course2Label = New System.Windows.Forms.Label()
        Me.Course3Label = New System.Windows.Forms.Label()
        Me.Course4Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(339, 289)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 23)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Course1Button
        '
        Me.Course1Button.Location = New System.Drawing.Point(194, 41)
        Me.Course1Button.Name = "Course1Button"
        Me.Course1Button.Size = New System.Drawing.Size(137, 38)
        Me.Course1Button.TabIndex = 1
        Me.Course1Button.Text = "Theory of Computation"
        Me.Course1Button.UseVisualStyleBackColor = True
        '
        'Course2Button
        '
        Me.Course2Button.Location = New System.Drawing.Point(194, 97)
        Me.Course2Button.Name = "Course2Button"
        Me.Course2Button.Size = New System.Drawing.Size(137, 38)
        Me.Course2Button.TabIndex = 2
        Me.Course2Button.Text = "Digital Logic"
        Me.Course2Button.UseVisualStyleBackColor = True
        '
        'Course3Button
        '
        Me.Course3Button.Location = New System.Drawing.Point(194, 154)
        Me.Course3Button.Name = "Course3Button"
        Me.Course3Button.Size = New System.Drawing.Size(137, 38)
        Me.Course3Button.TabIndex = 3
        Me.Course3Button.Text = "Software Engineering"
        Me.Course3Button.UseVisualStyleBackColor = True
        '
        'Course4Button
        '
        Me.Course4Button.Location = New System.Drawing.Point(194, 213)
        Me.Course4Button.Name = "Course4Button"
        Me.Course4Button.Size = New System.Drawing.Size(137, 38)
        Me.Course4Button.TabIndex = 4
        Me.Course4Button.Text = "Operating Systems"
        Me.Course4Button.UseVisualStyleBackColor = True
        '
        'Course1Label
        '
        Me.Course1Label.AutoSize = True
        Me.Course1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course1Label.Location = New System.Drawing.Point(78, 49)
        Me.Course1Label.Name = "Course1Label"
        Me.Course1Label.Size = New System.Drawing.Size(110, 20)
        Me.Course1Label.TabIndex = 5
        Me.Course1Label.Text = "Course Name:"
        '
        'Course2Label
        '
        Me.Course2Label.AutoSize = True
        Me.Course2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course2Label.Location = New System.Drawing.Point(78, 105)
        Me.Course2Label.Name = "Course2Label"
        Me.Course2Label.Size = New System.Drawing.Size(110, 20)
        Me.Course2Label.TabIndex = 6
        Me.Course2Label.Text = "Course Name:"
        '
        'Course3Label
        '
        Me.Course3Label.AutoSize = True
        Me.Course3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course3Label.Location = New System.Drawing.Point(78, 162)
        Me.Course3Label.Name = "Course3Label"
        Me.Course3Label.Size = New System.Drawing.Size(110, 20)
        Me.Course3Label.TabIndex = 7
        Me.Course3Label.Text = "Course Name:"
        '
        'Course4Label
        '
        Me.Course4Label.AutoSize = True
        Me.Course4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course4Label.Location = New System.Drawing.Point(78, 221)
        Me.Course4Label.Name = "Course4Label"
        Me.Course4Label.Size = New System.Drawing.Size(110, 20)
        Me.Course4Label.TabIndex = 8
        Me.Course4Label.Text = "Course Name:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 337)
        Me.Controls.Add(Me.Course4Label)
        Me.Controls.Add(Me.Course3Label)
        Me.Controls.Add(Me.Course2Label)
        Me.Controls.Add(Me.Course1Label)
        Me.Controls.Add(Me.Course4Button)
        Me.Controls.Add(Me.Course3Button)
        Me.Controls.Add(Me.Course2Button)
        Me.Controls.Add(Me.Course1Button)
        Me.Controls.Add(Me.btn_logout)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_logout As Button
    Friend WithEvents Course1Button As Button
    Friend WithEvents Course2Button As Button
    Friend WithEvents Course3Button As Button
    Friend WithEvents Course4Button As Button
    Friend WithEvents Course1Label As Label
    Friend WithEvents Course2Label As Label
    Friend WithEvents Course3Label As Label
    Friend WithEvents Course4Label As Label
End Class
