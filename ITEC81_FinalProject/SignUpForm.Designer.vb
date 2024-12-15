<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        PanelLogIn = New Panel()
        GroupBox1 = New GroupBox()
        rdbFaculty = New RadioButton()
        rdbStudent = New RadioButton()
        btnBack = New Button()
        Label1 = New Label()
        btnSignUp = New Button()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        Panel1 = New Panel()
        PanelLogIn.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelLogIn
        ' 
        PanelLogIn.Controls.Add(GroupBox1)
        PanelLogIn.Controls.Add(btnBack)
        PanelLogIn.Controls.Add(Label1)
        PanelLogIn.Controls.Add(btnSignUp)
        PanelLogIn.Controls.Add(Label3)
        PanelLogIn.Controls.Add(txtPassword)
        PanelLogIn.Controls.Add(Label2)
        PanelLogIn.Controls.Add(txtUsername)
        PanelLogIn.Location = New Point(86, 38)
        PanelLogIn.Name = "PanelLogIn"
        PanelLogIn.Size = New Size(428, 427)
        PanelLogIn.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImageLayout = ImageLayout.Center
        GroupBox1.Controls.Add(rdbFaculty)
        GroupBox1.Controls.Add(rdbStudent)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(42, 251)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 80)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Category:"
        ' 
        ' rdbFaculty
        ' 
        rdbFaculty.AutoSize = True
        rdbFaculty.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbFaculty.Location = New Point(193, 27)
        rdbFaculty.Name = "rdbFaculty"
        rdbFaculty.Size = New Size(85, 27)
        rdbFaculty.TabIndex = 1
        rdbFaculty.TabStop = True
        rdbFaculty.Text = "Faculty"
        rdbFaculty.UseVisualStyleBackColor = True
        ' 
        ' rdbStudent
        ' 
        rdbStudent.AutoSize = True
        rdbStudent.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbStudent.Location = New Point(75, 27)
        rdbStudent.Name = "rdbStudent"
        rdbStudent.Size = New Size(92, 27)
        rdbStudent.TabIndex = 0
        rdbStudent.TabStop = True
        rdbStudent.Text = "Student"
        rdbStudent.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Brown
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(144, 361)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(87, 43)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 59)
        Label1.TabIndex = 2
        Label1.Text = "Sign Up Form"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.White
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignUp.Location = New Point(36, 361)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(87, 43)
        btnSignUp.TabIndex = 5
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(47, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(144, 202)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(226, 28)
        txtPassword.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(144, 159)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(226, 28)
        txtUsername.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Brown
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(85, 515)
        Panel1.TabIndex = 6
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 497)
        Controls.Add(Panel1)
        Controls.Add(PanelLogIn)
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUpForm"
        PanelLogIn.ResumeLayout(False)
        PanelLogIn.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLogIn As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbFaculty As RadioButton
    Friend WithEvents rdbStudent As RadioButton
End Class
