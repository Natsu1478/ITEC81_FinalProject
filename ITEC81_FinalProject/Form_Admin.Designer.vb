<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Panel1 = New Panel()
        pnlMAIN = New Panel()
        pnlProfile = New Panel()
        Panel11 = New Panel()
        lblContact = New Label()
        lblDept = New Label()
        Label35 = New Label()
        lblEmail = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        lblFullName = New Label()
        PictureBox4 = New PictureBox()
        Label42 = New Label()
        Panel9 = New Panel()
        tabAboutMe = New TabControl()
        tab1 = New TabPage()
        Panel8 = New Panel()
        txtContactNumber = New TextBox()
        txtEmail = New TextBox()
        txtDateOfBirth = New TextBox()
        txtGender = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label28 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Panel7 = New Panel()
        Label29 = New Label()
        Label14 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Panel4 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        btnStudent = New Button()
        Panel2 = New Panel()
        Panel6 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label12 = New Label()
        PictureBox2 = New PictureBox()
        Label13 = New Label()
        Panel5 = New Panel()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        lblFName = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        pnlMAIN.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel11.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        tabAboutMe.SuspendLayout()
        tab1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(pnlMAIN)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnStudent)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1566, 825)
        Panel1.TabIndex = 0
        ' 
        ' pnlMAIN
        ' 
        pnlMAIN.Controls.Add(pnlProfile)
        pnlMAIN.Location = New Point(286, 60)
        pnlMAIN.Margin = New Padding(2)
        pnlMAIN.Name = "pnlMAIN"
        pnlMAIN.Size = New Size(1259, 766)
        pnlMAIN.TabIndex = 11
        ' 
        ' pnlProfile
        ' 
        pnlProfile.AutoSize = True
        pnlProfile.BorderStyle = BorderStyle.Fixed3D
        pnlProfile.Controls.Add(Panel11)
        pnlProfile.Controls.Add(Panel9)
        pnlProfile.Controls.Add(Label14)
        pnlProfile.Location = New Point(0, 0)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1259, 768)
        pnlProfile.TabIndex = 2
        ' 
        ' Panel11
        ' 
        Panel11.AutoSize = True
        Panel11.BackColor = Color.Gainsboro
        Panel11.BorderStyle = BorderStyle.Fixed3D
        Panel11.Controls.Add(lblContact)
        Panel11.Controls.Add(lblDept)
        Panel11.Controls.Add(Label35)
        Panel11.Controls.Add(lblEmail)
        Panel11.Controls.Add(Label37)
        Panel11.Controls.Add(Label38)
        Panel11.Controls.Add(Label39)
        Panel11.Controls.Add(Label40)
        Panel11.Controls.Add(lblFullName)
        Panel11.Controls.Add(PictureBox4)
        Panel11.Controls.Add(Label42)
        Panel11.Location = New Point(23, 46)
        Panel11.Margin = New Padding(2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(1210, 194)
        Panel11.TabIndex = 2
        ' 
        ' lblContact
        ' 
        lblContact.AutoEllipsis = True
        lblContact.AutoSize = True
        lblContact.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContact.ImageAlign = ContentAlignment.MiddleLeft
        lblContact.Location = New Point(798, 154)
        lblContact.Margin = New Padding(2, 0, 2, 0)
        lblContact.Name = "lblContact"
        lblContact.RightToLeft = RightToLeft.No
        lblContact.Size = New Size(120, 23)
        lblContact.TabIndex = 10
        lblContact.Text = "09123456789"
        ' 
        ' lblDept
        ' 
        lblDept.AutoEllipsis = True
        lblDept.AutoSize = True
        lblDept.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDept.ImageAlign = ContentAlignment.MiddleLeft
        lblDept.Location = New Point(798, 42)
        lblDept.Margin = New Padding(2, 0, 2, 0)
        lblDept.Name = "lblDept"
        lblDept.RightToLeft = RightToLeft.No
        lblDept.Size = New Size(245, 23)
        lblDept.TabIndex = 9
        lblDept.Text = "School Of Computer Studies"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.ImageAlign = ContentAlignment.MiddleLeft
        Label35.Location = New Point(725, 144)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.No
        Label35.Size = New Size(0, 23)
        Label35.TabIndex = 8
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoEllipsis = True
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ImageAlign = ContentAlignment.MiddleLeft
        lblEmail.Location = New Point(798, 97)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.RightToLeft = RightToLeft.No
        lblEmail.Size = New Size(360, 23)
        lblEmail.TabIndex = 7
        lblEmail.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
        ' 
        ' Label37
        ' 
        Label37.AutoEllipsis = True
        Label37.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label37.Image = My.Resources.Resources.icons8_phone_number_20
        Label37.ImageAlign = ContentAlignment.MiddleLeft
        Label37.Location = New Point(798, 129)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.RightToLeft = RightToLeft.No
        Label37.Size = New Size(251, 22)
        Label37.TabIndex = 6
        Label37.Text = "     Contact Number: "
        ' 
        ' Label38
        ' 
        Label38.AutoEllipsis = True
        Label38.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label38.Image = My.Resources.Resources.icons8_email_18
        Label38.ImageAlign = ContentAlignment.MiddleLeft
        Label38.Location = New Point(798, 72)
        Label38.Margin = New Padding(2, 0, 2, 0)
        Label38.Name = "Label38"
        Label38.RightToLeft = RightToLeft.No
        Label38.Size = New Size(273, 22)
        Label38.TabIndex = 5
        Label38.Text = "     Email Address: "
        ' 
        ' Label39
        ' 
        Label39.AutoEllipsis = True
        Label39.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label39.Image = My.Resources.Resources.icons8_unit_18
        Label39.ImageAlign = ContentAlignment.MiddleLeft
        Label39.Location = New Point(798, 18)
        Label39.Margin = New Padding(2, 0, 2, 0)
        Label39.Name = "Label39"
        Label39.RightToLeft = RightToLeft.No
        Label39.Size = New Size(190, 22)
        Label39.TabIndex = 4
        Label39.Text = "     Department: "
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(240, 106)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(163, 24)
        Label40.TabIndex = 2
        Label40.Text = "ADMINISTRATOR"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(226, 55)
        lblFullName.Margin = New Padding(2, 0, 2, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(308, 41)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox4.Location = New Point(28, 15)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(160, 160)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.BackColor = Color.Transparent
        Label42.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label42.ForeColor = Color.DarkOrange
        Label42.Location = New Point(226, 83)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(459, 20)
        Label42.TabIndex = 3
        Label42.Text = "___________________________________________________________________________"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(tabAboutMe)
        Panel9.Location = New Point(21, 255)
        Panel9.Margin = New Padding(2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1210, 494)
        Panel9.TabIndex = 1
        ' 
        ' tabAboutMe
        ' 
        tabAboutMe.Appearance = TabAppearance.Buttons
        tabAboutMe.Controls.Add(tab1)
        tabAboutMe.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabAboutMe.Location = New Point(2, 2)
        tabAboutMe.Margin = New Padding(2)
        tabAboutMe.Name = "tabAboutMe"
        tabAboutMe.SelectedIndex = 0
        tabAboutMe.Size = New Size(1205, 489)
        tabAboutMe.TabIndex = 1
        ' 
        ' tab1
        ' 
        tab1.Controls.Add(Panel8)
        tab1.Controls.Add(Panel7)
        tab1.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tab1.Location = New Point(4, 36)
        tab1.Margin = New Padding(2)
        tab1.Name = "tab1"
        tab1.Padding = New Padding(2)
        tab1.Size = New Size(1197, 449)
        tab1.TabIndex = 0
        tab1.Text = "About Me"
        tab1.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(txtContactNumber)
        Panel8.Controls.Add(txtEmail)
        Panel8.Controls.Add(txtDateOfBirth)
        Panel8.Controls.Add(txtGender)
        Panel8.Controls.Add(txtMiddleName)
        Panel8.Controls.Add(txtFirstName)
        Panel8.Controls.Add(txtLastName)
        Panel8.Controls.Add(Label20)
        Panel8.Controls.Add(Label21)
        Panel8.Controls.Add(Label22)
        Panel8.Controls.Add(Label28)
        Panel8.Controls.Add(Label30)
        Panel8.Controls.Add(Label31)
        Panel8.Controls.Add(Label32)
        Panel8.Location = New Point(14, 106)
        Panel8.Margin = New Padding(2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1173, 330)
        Panel8.TabIndex = 1
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Enabled = False
        txtContactNumber.Location = New Point(798, 219)
        txtContactNumber.Margin = New Padding(2)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(252, 30)
        txtContactNumber.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.Enabled = False
        txtEmail.Location = New Point(798, 157)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(252, 30)
        txtEmail.TabIndex = 11
        ' 
        ' txtDateOfBirth
        ' 
        txtDateOfBirth.Enabled = False
        txtDateOfBirth.Location = New Point(801, 100)
        txtDateOfBirth.Margin = New Padding(2)
        txtDateOfBirth.Name = "txtDateOfBirth"
        txtDateOfBirth.Size = New Size(252, 30)
        txtDateOfBirth.TabIndex = 10
        ' 
        ' txtGender
        ' 
        txtGender.Enabled = False
        txtGender.Location = New Point(801, 48)
        txtGender.Margin = New Padding(2)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(252, 30)
        txtGender.TabIndex = 8
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Enabled = False
        txtMiddleName.Location = New Point(264, 183)
        txtMiddleName.Margin = New Padding(2)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(252, 30)
        txtMiddleName.TabIndex = 9
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Enabled = False
        txtFirstName.Location = New Point(264, 112)
        txtFirstName.Margin = New Padding(2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(252, 30)
        txtFirstName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Enabled = False
        txtLastName.Location = New Point(264, 52)
        txtLastName.Margin = New Padding(2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(252, 30)
        txtLastName.TabIndex = 7
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label20.Location = New Point(606, 225)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(181, 24)
        Label20.TabIndex = 6
        Label20.Text = "Contact Number:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label21.Location = New Point(714, 163)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(72, 24)
        Label21.TabIndex = 5
        Label21.Text = "Email:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(639, 106)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(146, 24)
        Label22.TabIndex = 4
        Label22.Text = "Date of Birth:"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label28.Location = New Point(693, 54)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(91, 24)
        Label28.TabIndex = 3
        Label28.Text = "Gender:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label30.Location = New Point(100, 183)
        Label30.Margin = New Padding(2, 0, 2, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(149, 24)
        Label30.TabIndex = 2
        Label30.Text = "Middle Name:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label31.Location = New Point(125, 114)
        Label31.Margin = New Padding(2, 0, 2, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(126, 24)
        Label31.TabIndex = 1
        Label31.Text = "First Name:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label32.Location = New Point(130, 54)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(122, 24)
        Label32.TabIndex = 0
        Label32.Text = "Last Name:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Firebrick
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(Label29)
        Panel7.ForeColor = Color.White
        Panel7.Location = New Point(14, 15)
        Panel7.Margin = New Padding(2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1173, 74)
        Panel7.TabIndex = 0
        ' 
        ' Label29
        ' 
        Label29.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Image = My.Resources.Resources.icons8_info_22
        Label29.ImageAlign = ContentAlignment.MiddleLeft
        Label29.Location = New Point(19, 14)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(311, 34)
        Label29.TabIndex = 0
        Label29.Text = "    Basic Information"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Maroon
        Label14.Location = New Point(21, 10)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(198, 33)
        Label14.TabIndex = 0
        Label14.Text = "Admin Profile"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button3.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button3.Location = New Point(732, 285)
        Button3.Name = "Button3"
        Button3.Size = New Size(358, 126)
        Button3.TabIndex = 10
        Button3.Text = "Ratings"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button4.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button4.Location = New Point(330, 285)
        Button4.Name = "Button4"
        Button4.Size = New Size(358, 126)
        Button4.TabIndex = 9
        Button4.Text = "Schedule"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Maroon
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1566, 61)
        Panel4.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button2.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button2.Location = New Point(1134, 119)
        Button2.Name = "Button2"
        Button2.Size = New Size(358, 126)
        Button2.TabIndex = 8
        Button2.Text = "Enrollees"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button1.Location = New Point(732, 119)
        Button1.Name = "Button1"
        Button1.Size = New Size(358, 126)
        Button1.TabIndex = 6
        Button1.Text = "Activities"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.WhiteSmoke
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatAppearance.CheckedBackColor = Color.DarkRed
        btnStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnStudent.FlatAppearance.MouseOverBackColor = Color.Maroon
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btnStudent.Location = New Point(330, 119)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(358, 126)
        btnStudent.TabIndex = 5
        btnStudent.Text = "Admin Profile "
        btnStudent.TextAlign = ContentAlignment.TopLeft
        btnStudent.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gray
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(lblFName)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(287, 826)
        Panel2.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.AutoSize = True
        Panel6.BackColor = Color.Gainsboro
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(Label9)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label12)
        Panel6.Controls.Add(PictureBox2)
        Panel6.Controls.Add(Label13)
        Panel6.Location = New Point(308, 106)
        Panel6.Margin = New Padding(2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1210, 194)
        Panel6.TabIndex = 12
        ' 
        ' Label11
        ' 
        Label11.AutoEllipsis = True
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(798, 154)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.RightToLeft = RightToLeft.No
        Label11.Size = New Size(120, 23)
        Label11.TabIndex = 10
        Label11.Text = "09123456789"
        ' 
        ' Label10
        ' 
        Label10.AutoEllipsis = True
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ImageAlign = ContentAlignment.MiddleLeft
        Label10.Location = New Point(798, 42)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.No
        Label10.Size = New Size(245, 23)
        Label10.TabIndex = 9
        Label10.Text = "School Of Computer Studies"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ImageAlign = ContentAlignment.MiddleLeft
        Label9.Location = New Point(725, 144)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.No
        Label9.Size = New Size(0, 23)
        Label9.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoEllipsis = True
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ImageAlign = ContentAlignment.MiddleLeft
        Label8.Location = New Point(798, 97)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.No
        Label8.Size = New Size(360, 23)
        Label8.TabIndex = 7
        Label8.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
        ' 
        ' Label7
        ' 
        Label7.AutoEllipsis = True
        Label7.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label7.Image = My.Resources.Resources.icons8_phone_number_20
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(798, 129)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(190, 22)
        Label7.TabIndex = 6
        Label7.Text = "     Contact Number: "
        ' 
        ' Label6
        ' 
        Label6.AutoEllipsis = True
        Label6.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label6.Image = My.Resources.Resources.icons8_email_18
        Label6.ImageAlign = ContentAlignment.MiddleLeft
        Label6.Location = New Point(798, 72)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(170, 22)
        Label6.TabIndex = 5
        Label6.Text = "     Email Address: "
        ' 
        ' Label5
        ' 
        Label5.AutoEllipsis = True
        Label5.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label5.Image = My.Resources.Resources.icons8_unit_18
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(798, 18)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(151, 22)
        Label5.TabIndex = 4
        Label5.Text = "     Department: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(226, 83)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(425, 24)
        Label4.TabIndex = 2
        Label4.Text = "Bachelor of Science In Information Technology"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(226, 30)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(308, 41)
        Label12.TabIndex = 1
        Label12.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox2.Location = New Point(28, 15)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(160, 160)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.DarkOrange
        Label13.Location = New Point(226, 58)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(459, 20)
        Label13.TabIndex = 3
        Label13.Text = "___________________________________________________________________________"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button10)
        Panel5.Controls.Add(Button9)
        Panel5.Controls.Add(Button8)
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Button6)
        Panel5.Controls.Add(Button5)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 321)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 505)
        Panel5.TabIndex = 5
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Transparent
        Button10.BackgroundImageLayout = ImageLayout.Center
        Button10.Cursor = Cursors.Hand
        Button10.Dock = DockStyle.Top
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(0, 315)
        Button10.Name = "Button10"
        Button10.Size = New Size(287, 63)
        Button10.TabIndex = 10
        Button10.Text = "          RATINGS"
        Button10.TextImageRelation = TextImageRelation.ImageBeforeText
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.BackgroundImageLayout = ImageLayout.Center
        Button9.Cursor = Cursors.Hand
        Button9.Dock = DockStyle.Top
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.White
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 252)
        Button9.Name = "Button9"
        Button9.Size = New Size(287, 63)
        Button9.TabIndex = 9
        Button9.Text = "         SCHEDULE"
        Button9.TextImageRelation = TextImageRelation.ImageBeforeText
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImageLayout = ImageLayout.Center
        Button8.Cursor = Cursors.Hand
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(0, 189)
        Button8.Name = "Button8"
        Button8.Size = New Size(287, 63)
        Button8.TabIndex = 8
        Button8.Text = "        ENROLLEES"
        Button8.TextImageRelation = TextImageRelation.ImageBeforeText
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImageLayout = ImageLayout.Center
        Button7.Cursor = Cursors.Hand
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(0, 126)
        Button7.Name = "Button7"
        Button7.Size = New Size(287, 63)
        Button7.TabIndex = 7
        Button7.Text = "        ACTIVITIES"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImageLayout = ImageLayout.Center
        Button6.Cursor = Cursors.Hand
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 63)
        Button6.Name = "Button6"
        Button6.Size = New Size(287, 63)
        Button6.TabIndex = 6
        Button6.Text = "           PROFILE"
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImageLayout = ImageLayout.Center
        Button5.Cursor = Cursors.Hand
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(0, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(287, 63)
        Button5.TabIndex = 5
        Button5.Text = "        DASHBOARD"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFName.Location = New Point(140, 285)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(83, 27)
        lblFName.TabIndex = 4
        lblFName.Text = "Jonas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 27)
        Label2.TabIndex = 3
        Label2.Text = "Hello,"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(38, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 20)
        Label1.TabIndex = 2
        Label1.Text = "___________________________________"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(287, 61)
        Panel3.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(28, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 27)
        Label3.TabIndex = 6
        Label3.Text = "Admin Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cct_logo
        PictureBox1.Location = New Point(92, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 174)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form_Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1539, 826)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form_Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form_Admin"
        Panel1.ResumeLayout(False)
        pnlMAIN.ResumeLayout(False)
        pnlMAIN.PerformLayout()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        tabAboutMe.ResumeLayout(False)
        tab1.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents lblFName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents pnlMAIN As Panel
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents tabAboutMe As TabControl
    Friend WithEvents tab1 As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblContact As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label40 As Label
End Class
