<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        btn_Admin = New Button()
        btnStudent = New Button()
        Label1 = New Label()
        PanelUserOption = New Panel()
        lblCreateAccount = New Label()
        PanelLogIn = New Panel()
        lblCurrUser = New Label()
        btnBack = New Button()
        btnLogin = New Button()
        cbxShowPassword = New CheckBox()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        PanelUserOption.SuspendLayout()
        PanelLogIn.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_Admin
        ' 
        btn_Admin.BackColor = Color.Brown
        btn_Admin.FlatStyle = FlatStyle.Flat
        btn_Admin.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btn_Admin.ForeColor = Color.White
        btn_Admin.Location = New Point(93, 80)
        btn_Admin.Name = "btn_Admin"
        btn_Admin.Size = New Size(250, 111)
        btn_Admin.TabIndex = 0
        btn_Admin.Text = "FACULTY"
        btn_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.White
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btnStudent.Location = New Point(93, 220)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(250, 111)
        btnStudent.TabIndex = 1
        btnStudent.Text = "STUDENT"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 45)
        Label1.TabIndex = 2
        Label1.Text = "Log In Form"
        ' 
        ' PanelUserOption
        ' 
        PanelUserOption.Controls.Add(lblCreateAccount)
        PanelUserOption.Controls.Add(btn_Admin)
        PanelUserOption.Controls.Add(btnStudent)
        PanelUserOption.Location = New Point(22, 34)
        PanelUserOption.Name = "PanelUserOption"
        PanelUserOption.Size = New Size(428, 427)
        PanelUserOption.TabIndex = 3
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.FlatStyle = FlatStyle.Flat
        lblCreateAccount.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreateAccount.ForeColor = Color.Brown
        lblCreateAccount.Location = New Point(140, 358)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New Size(154, 25)
        lblCreateAccount.TabIndex = 2
        lblCreateAccount.Text = "Create Account"
        ' 
        ' PanelLogIn
        ' 
        PanelLogIn.Controls.Add(lblCurrUser)
        PanelLogIn.Controls.Add(btnBack)
        PanelLogIn.Controls.Add(Label1)
        PanelLogIn.Controls.Add(btnLogin)
        PanelLogIn.Controls.Add(cbxShowPassword)
        PanelLogIn.Controls.Add(Label3)
        PanelLogIn.Controls.Add(txtPassword)
        PanelLogIn.Controls.Add(Label2)
        PanelLogIn.Controls.Add(txtUsername)
        PanelLogIn.Location = New Point(22, 34)
        PanelLogIn.Name = "PanelLogIn"
        PanelLogIn.Size = New Size(428, 427)
        PanelLogIn.TabIndex = 4
        PanelLogIn.Visible = False
        ' 
        ' lblCurrUser
        ' 
        lblCurrUser.AutoSize = True
        lblCurrUser.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrUser.Location = New Point(67, 36)
        lblCurrUser.Name = "lblCurrUser"
        lblCurrUser.Size = New Size(176, 54)
        lblCurrUser.TabIndex = 5
        lblCurrUser.Text = "STUDENT"
        lblCurrUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Brown
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(144, 340)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(87, 43)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(47, 340)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(87, 43)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' cbxShowPassword
        ' 
        cbxShowPassword.AutoSize = True
        cbxShowPassword.Location = New Point(238, 251)
        cbxShowPassword.Name = "cbxShowPassword"
        cbxShowPassword.Size = New Size(132, 24)
        cbxShowPassword.TabIndex = 4
        cbxShowPassword.Text = "Show Password"
        cbxShowPassword.UseVisualStyleBackColor = True
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
        txtPassword.Location = New Point(144, 201)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(226, 28)
        txtPassword.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(144, 158)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(226, 28)
        txtUsername.TabIndex = 0
        ' 
        ' LogInForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(485, 493)
        Controls.Add(PanelLogIn)
        Controls.Add(PanelUserOption)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "LogInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogInForm"
        PanelUserOption.ResumeLayout(False)
        PanelUserOption.PerformLayout()
        PanelLogIn.ResumeLayout(False)
        PanelLogIn.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_Admin As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelUserOption As Panel
    Friend WithEvents PanelLogIn As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents cbxShowPassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCurrUser As Label
    Friend WithEvents lblCreateAccount As Label
End Class
