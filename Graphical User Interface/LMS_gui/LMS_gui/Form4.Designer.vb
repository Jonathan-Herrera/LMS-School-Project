<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Course4Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.FirstNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LastNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Test1Column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Test2Column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Test3Column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AvgGrdColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TestEntry1 = New System.Windows.Forms.Label()
        Me.Entry1 = New System.Windows.Forms.TextBox()
        Me.TestEntry2 = New System.Windows.Forms.Label()
        Me.Entry2 = New System.Windows.Forms.TextBox()
        Me.TestEntry3 = New System.Windows.Forms.Label()
        Me.Entry3 = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(26, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(43, 67)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(106, 20)
        Me.FirstNameLabel.TabIndex = 1
        Me.FirstNameLabel.Text = "First Name :"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(40, 104)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(105, 20)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name :"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(179, 67)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(179, 104)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FirstNameColumn, Me.LastNameColumn, Me.Test1Column, Me.Test2Column, Me.Test3Column, Me.AvgGrdColumn})
        Me.ListView1.Location = New System.Drawing.Point(320, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(458, 237)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.Text = "First Name"
        Me.FirstNameColumn.Width = 77
        '
        'LastNameColumn
        '
        Me.LastNameColumn.Text = "Last Name"
        Me.LastNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LastNameColumn.Width = 87
        '
        'Test1Column
        '
        Me.Test1Column.Text = "Test 1"
        Me.Test1Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test2Column
        '
        Me.Test2Column.Text = "Test 2"
        Me.Test2Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test3Column
        '
        Me.Test3Column.Text = "Test 3"
        Me.Test3Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AvgGrdColumn
        '
        Me.AvgGrdColumn.Text = "Avg Grade"
        Me.AvgGrdColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AvgGrdColumn.Width = 86
        '
        'TestEntry1
        '
        Me.TestEntry1.AutoSize = True
        Me.TestEntry1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestEntry1.Location = New System.Drawing.Point(40, 144)
        Me.TestEntry1.Name = "TestEntry1"
        Me.TestEntry1.Size = New System.Drawing.Size(69, 20)
        Me.TestEntry1.TabIndex = 6
        Me.TestEntry1.Text = "Test 1 :"
        '
        'Entry1
        '
        Me.Entry1.Location = New System.Drawing.Point(179, 144)
        Me.Entry1.Name = "Entry1"
        Me.Entry1.Size = New System.Drawing.Size(100, 20)
        Me.Entry1.TabIndex = 7
        '
        'TestEntry2
        '
        Me.TestEntry2.AutoSize = True
        Me.TestEntry2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestEntry2.Location = New System.Drawing.Point(40, 180)
        Me.TestEntry2.Name = "TestEntry2"
        Me.TestEntry2.Size = New System.Drawing.Size(69, 20)
        Me.TestEntry2.TabIndex = 8
        Me.TestEntry2.Text = "Test 2 :"
        '
        'Entry2
        '
        Me.Entry2.Location = New System.Drawing.Point(179, 180)
        Me.Entry2.Name = "Entry2"
        Me.Entry2.Size = New System.Drawing.Size(100, 20)
        Me.Entry2.TabIndex = 9
        '
        'TestEntry3
        '
        Me.TestEntry3.AutoSize = True
        Me.TestEntry3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestEntry3.Location = New System.Drawing.Point(40, 211)
        Me.TestEntry3.Name = "TestEntry3"
        Me.TestEntry3.Size = New System.Drawing.Size(69, 20)
        Me.TestEntry3.TabIndex = 10
        Me.TestEntry3.Text = "Test 3 :"
        '
        'Entry3
        '
        Me.Entry3.Location = New System.Drawing.Point(179, 210)
        Me.Entry3.Name = "Entry3"
        Me.Entry3.Size = New System.Drawing.Size(100, 20)
        Me.Entry3.TabIndex = 11
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(179, 252)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 35)
        Me.AddButton.TabIndex = 12
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.Location = New System.Drawing.Point(659, 331)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(118, 41)
        Me.LogOutButton.TabIndex = 13
        Me.LogOutButton.Text = "Log Out"
        Me.LogOutButton.UseVisualStyleBackColor = True
        '
        'Course4Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 396)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Entry3)
        Me.Controls.Add(Me.TestEntry3)
        Me.Controls.Add(Me.Entry2)
        Me.Controls.Add(Me.TestEntry2)
        Me.Controls.Add(Me.Entry1)
        Me.Controls.Add(Me.TestEntry1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Course4Form"
        Me.Text = "Theory of Computation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FirstNameColumn As ColumnHeader
    Friend WithEvents LastNameColumn As ColumnHeader
    Friend WithEvents Test1Column As ColumnHeader
    Friend WithEvents Test2Column As ColumnHeader
    Friend WithEvents Test3Column As ColumnHeader
    Friend WithEvents AvgGrdColumn As ColumnHeader
    Friend WithEvents TestEntry1 As Label
    Friend WithEvents Entry1 As TextBox
    Friend WithEvents TestEntry2 As Label
    Friend WithEvents Entry2 As TextBox
    Friend WithEvents TestEntry3 As Label
    Friend WithEvents Entry3 As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents LogOutButton As Button
End Class
