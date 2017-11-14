<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.WelcomingLabel = New System.Windows.Forms.Label()
        Me.User_Logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WelcomingLabel
        '
        Me.WelcomingLabel.AutoSize = True
        Me.WelcomingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomingLabel.Location = New System.Drawing.Point(12, 9)
        Me.WelcomingLabel.Name = "WelcomingLabel"
        Me.WelcomingLabel.Size = New System.Drawing.Size(95, 31)
        Me.WelcomingLabel.TabIndex = 0
        Me.WelcomingLabel.Text = "Label1"
        '
        'User_Logout
        '
        Me.User_Logout.Location = New System.Drawing.Point(479, 238)
        Me.User_Logout.Name = "User_Logout"
        Me.User_Logout.Size = New System.Drawing.Size(65, 42)
        Me.User_Logout.TabIndex = 1
        Me.User_Logout.Text = "Logout"
        Me.User_Logout.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Administrator.My.Resources.Resources.chalkboard
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 363)
        Me.Controls.Add(Me.User_Logout)
        Me.Controls.Add(Me.WelcomingLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2 "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomingLabel As Label
    Friend WithEvents User_Logout As Button
End Class
