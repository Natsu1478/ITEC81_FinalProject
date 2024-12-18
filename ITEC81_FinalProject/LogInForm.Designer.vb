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
        Label4 = New Label()
        Panel1 = New Panel()
        PanelUserOption.SuspendLayout()
        PanelLogIn.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_Admin
        ' 
        btn_Admin.BackColor = Color.White
        btn_Admin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btn_Admin.FlatAppearance.MouseOverBackColor = Color.Maroon
        btn_Admin.FlatStyle = FlatStyle.Flat
        btn_Admin.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btn_Admin.ForeColor = Color.Black
        btn_Admin.Location = New Point(44, 53)
        btn_Admin.Name = "btn_Admin"
        btn_Admin.Size = New Size(337, 173)
        btn_Admin.TabIndex = 0
        btn_Admin.TabStop = False
        btn_Admin.Text = "FACULTY"
        btn_Admin.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.White
        btnStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btnStudent.FlatAppearance.MouseOverBackColor = Color.Navy
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btnStudent.Location = New Point(44, 251)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(337, 173)
        btnStudent.TabIndex = 0
        btnStudent.TabStop = False
        btnStudent.Text = "STUDENT"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 45)
        Label1.TabIndex = 2
        Label1.Text = "Log In Form"
        ' 
        ' PanelUserOption
        ' 
        PanelUserOption.BackColor = Color.Transparent
        PanelUserOption.Controls.Add(lblCreateAccount)
        PanelUserOption.Controls.Add(btn_Admin)
        PanelUserOption.Controls.Add(btnStudent)
        PanelUserOption.Location = New Point(438, 49)
        PanelUserOption.Name = "PanelUserOption"
        PanelUserOption.Size = New Size(429, 583)
        PanelUserOption.TabIndex = 3
        ' 
        ' lblCreateAccount
        ' 
        lblCreateAccount.AutoSize = True
        lblCreateAccount.FlatStyle = FlatStyle.Flat
        lblCreateAccount.Font = New Font("Freestyle Script", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCreateAccount.ForeColor = Color.Black
        lblCreateAccount.Location = New Point(128, 457)
        lblCreateAccount.Name = "lblCreateAccount"
        lblCreateAccount.Size = New Size(180, 44)
        lblCreateAccount.TabIndex = 0
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
        PanelLogIn.Location = New Point(438, 49)
        PanelLogIn.Name = "PanelLogIn"
        PanelLogIn.Size = New Size(429, 583)
        PanelLogIn.TabIndex = 4
        PanelLogIn.Visible = False
        ' 
        ' lblCurrUser
        ' 
        lblCurrUser.AutoSize = True
        lblCurrUser.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrUser.Location = New Point(62, 69)
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
        btnBack.Location = New Point(278, 381)
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
        btnLogin.Location = New Point(172, 381)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(87, 43)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Log In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' cbxShowPassword
        ' 
        cbxShowPassword.AutoSize = True
        cbxShowPassword.Location = New Point(233, 284)
        cbxShowPassword.Name = "cbxShowPassword"
        cbxShowPassword.Size = New Size(132, 24)
        cbxShowPassword.TabIndex = 0
        cbxShowPassword.TabStop = False
        cbxShowPassword.Text = "Show Password"
        cbxShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(139, 234)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(226, 28)
        txtPassword.TabIndex = 2
        txtPassword.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Franklin Gothic Book", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(139, 191)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(226, 28)
        txtUsername.TabIndex = 0
        txtUsername.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(818, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 39)
        Label4.TabIndex = 10
        Label4.Text = "x"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.bg5
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(0, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 637)
        Panel1.TabIndex = 11
        ' 
        ' LogInForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(867, 632)
        Controls.Add(Panel1)
        Controls.Add(Label4)
        Controls.Add(PanelUserOption)
        Controls.Add(PanelLogIn)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "LogInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogInForm"
        PanelUserOption.ResumeLayout(False)
        PanelUserOption.PerformLayout()
        PanelLogIn.ResumeLayout(False)
        PanelLogIn.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
