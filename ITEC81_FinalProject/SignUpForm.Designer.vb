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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        rdbFaculty = New RadioButton()
        rdbStudent = New RadioButton()
        btnBack = New Button()
        btnSignUp = New Button()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        PanelLogIn.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLogIn
        ' 
        PanelLogIn.BackgroundImage = My.Resources.Resources.bg11
        PanelLogIn.BackgroundImageLayout = ImageLayout.Stretch
        PanelLogIn.Controls.Add(Label1)
        PanelLogIn.Controls.Add(GroupBox1)
        PanelLogIn.Controls.Add(btnBack)
        PanelLogIn.Controls.Add(btnSignUp)
        PanelLogIn.Controls.Add(Label3)
        PanelLogIn.Controls.Add(txtPassword)
        PanelLogIn.Controls.Add(Label2)
        PanelLogIn.Controls.Add(txtUsername)
        PanelLogIn.Controls.Add(PictureBox1)
        PanelLogIn.Location = New Point(0, 1)
        PanelLogIn.Margin = New Padding(4)
        PanelLogIn.Name = "PanelLogIn"
        PanelLogIn.Size = New Size(600, 700)
        PanelLogIn.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(551, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 47)
        Label1.TabIndex = 9
        Label1.Text = "x"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.BackgroundImageLayout = ImageLayout.Center
        GroupBox1.Controls.Add(rdbFaculty)
        GroupBox1.Controls.Add(rdbStudent)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(95, 418)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(410, 100)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Category:"
        ' 
        ' rdbFaculty
        ' 
        rdbFaculty.AutoSize = True
        rdbFaculty.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbFaculty.Location = New Point(241, 34)
        rdbFaculty.Margin = New Padding(4)
        rdbFaculty.Name = "rdbFaculty"
        rdbFaculty.Size = New Size(103, 32)
        rdbFaculty.TabIndex = 1
        rdbFaculty.TabStop = True
        rdbFaculty.Text = "Faculty"
        rdbFaculty.UseVisualStyleBackColor = True
        ' 
        ' rdbStudent
        ' 
        rdbStudent.AutoSize = True
        rdbStudent.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbStudent.Location = New Point(94, 34)
        rdbStudent.Margin = New Padding(4)
        rdbStudent.Name = "rdbStudent"
        rdbStudent.Size = New Size(111, 32)
        rdbStudent.TabIndex = 0
        rdbStudent.TabStop = True
        rdbStudent.Text = "Student"
        rdbStudent.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.FlatAppearance.BorderColor = Color.LightGray
        btnBack.FlatAppearance.MouseOverBackColor = Color.Brown
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.LightGray
        btnBack.Location = New Point(432, 586)
        btnBack.Margin = New Padding(4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(109, 54)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.Brown
        btnSignUp.FlatAppearance.BorderColor = Color.LightGray
        btnSignUp.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.Gainsboro
        btnSignUp.Location = New Point(302, 586)
        btnSignUp.Margin = New Padding(4)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(109, 54)
        btnSignUp.TabIndex = 5
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(101, 362)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 30)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(222, 356)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(282, 32)
        txtPassword.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(101, 314)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 30)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(222, 302)
        txtUsername.Margin = New Padding(4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(282, 32)
        txtUsername.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.SIGN_UP_FORM_removebg_preview
        PictureBox1.Location = New Point(62, 101)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(479, 156)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 700)
        ControlBox = False
        Controls.Add(PanelLogIn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "SignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUpForm"
        PanelLogIn.ResumeLayout(False)
        PanelLogIn.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelLogIn As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbFaculty As RadioButton
    Friend WithEvents rdbStudent As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
