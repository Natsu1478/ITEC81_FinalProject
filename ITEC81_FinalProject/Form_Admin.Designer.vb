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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Panel1 = New Panel()
        Panel4 = New Panel()
        pnlBG = New Panel()
        pnlMAIN = New Panel()
        btnRatings = New Button()
        btnEnrollees = New Button()
        btnActivities = New Button()
        btnSchedule = New Button()
        btnProfile = New Button()
        pnlActivities = New Panel()
        Panel10 = New Panel()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        PictureBox3 = New PictureBox()
        Label27 = New Label()
        Panel12 = New Panel()
        tabActivity = New TabControl()
        tabActivityList = New TabPage()
        Panel13 = New Panel()
        lstActivityList = New ListView()
        btnAddNewActivity = New Button()
        Panel14 = New Panel()
        Label33 = New Label()
        tabManageActivity = New TabPage()
        Panel15 = New Panel()
        btnDeleteActivity = New Button()
        txtActivityName = New TextBox()
        btnEditActivity = New Button()
        Label34 = New Label()
        btnClear = New Button()
        Label36 = New Label()
        dtpEndDate = New DateTimePicker()
        Label41 = New Label()
        dtpStartDate = New DateTimePicker()
        Label43 = New Label()
        txtFacultyAdviser = New TextBox()
        Label44 = New Label()
        Label45 = New Label()
        txtActivityType = New TextBox()
        txtDescription = New TextBox()
        Panel16 = New Panel()
        Label46 = New Label()
        Label47 = New Label()
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
        btnTabRatings = New Button()
        btnTabSchedule = New Button()
        btnTabEnrollees = New Button()
        btnTabActivities = New Button()
        btnTabProfile = New Button()
        btnDashboard = New Button()
        lblFName = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        pnlBG.SuspendLayout()
        pnlMAIN.SuspendLayout()
        pnlActivities.SuspendLayout()
        Panel10.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel12.SuspendLayout()
        tabActivity.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        tabManageActivity.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
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
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(pnlBG)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1566, 825)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Maroon
        Panel4.Location = New Point(286, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1253, 61)
        Panel4.TabIndex = 2
        ' 
        ' pnlBG
        ' 
        pnlBG.Controls.Add(pnlMAIN)
        pnlBG.Controls.Add(pnlActivities)
        pnlBG.Controls.Add(pnlProfile)
        pnlBG.Location = New Point(286, 61)
        pnlBG.Name = "pnlBG"
        pnlBG.Size = New Size(1253, 765)
        pnlBG.TabIndex = 12
        ' 
        ' pnlMAIN
        ' 
        pnlMAIN.BackgroundImage = My.Resources.Resources.bg7
        pnlMAIN.BackgroundImageLayout = ImageLayout.Stretch
        pnlMAIN.Controls.Add(btnRatings)
        pnlMAIN.Controls.Add(btnEnrollees)
        pnlMAIN.Controls.Add(btnActivities)
        pnlMAIN.Controls.Add(btnSchedule)
        pnlMAIN.Controls.Add(btnProfile)
        pnlMAIN.Dock = DockStyle.Fill
        pnlMAIN.Location = New Point(0, 0)
        pnlMAIN.Margin = New Padding(2)
        pnlMAIN.Name = "pnlMAIN"
        pnlMAIN.Size = New Size(1253, 765)
        pnlMAIN.TabIndex = 11
        ' 
        ' btnRatings
        ' 
        btnRatings.BackColor = Color.Transparent
        btnRatings.BackgroundImage = My.Resources.Resources.border__1_
        btnRatings.BackgroundImageLayout = ImageLayout.Stretch
        btnRatings.FlatAppearance.BorderSize = 0
        btnRatings.FlatAppearance.CheckedBackColor = Color.Maroon
        btnRatings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnRatings.FlatAppearance.MouseOverBackColor = Color.Brown
        btnRatings.FlatStyle = FlatStyle.Flat
        btnRatings.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        btnRatings.ForeColor = Color.LightGray
        btnRatings.Location = New Point(459, 296)
        btnRatings.Name = "btnRatings"
        btnRatings.Size = New Size(358, 239)
        btnRatings.TabIndex = 10
        btnRatings.Text = "Ratings"
        btnRatings.UseVisualStyleBackColor = False
        ' 
        ' btnEnrollees
        ' 
        btnEnrollees.BackColor = Color.Transparent
        btnEnrollees.BackgroundImage = My.Resources.Resources.border__1_
        btnEnrollees.BackgroundImageLayout = ImageLayout.Stretch
        btnEnrollees.FlatAppearance.BorderSize = 0
        btnEnrollees.FlatAppearance.CheckedBackColor = Color.Maroon
        btnEnrollees.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnEnrollees.FlatAppearance.MouseOverBackColor = Color.Brown
        btnEnrollees.FlatStyle = FlatStyle.Flat
        btnEnrollees.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        btnEnrollees.ForeColor = Color.LightGray
        btnEnrollees.Location = New Point(847, 33)
        btnEnrollees.Name = "btnEnrollees"
        btnEnrollees.Size = New Size(358, 239)
        btnEnrollees.TabIndex = 8
        btnEnrollees.Text = "Enrollees"
        btnEnrollees.UseVisualStyleBackColor = False
        ' 
        ' btnActivities
        ' 
        btnActivities.BackColor = Color.Transparent
        btnActivities.BackgroundImage = My.Resources.Resources.border__1_
        btnActivities.BackgroundImageLayout = ImageLayout.Stretch
        btnActivities.FlatAppearance.BorderSize = 0
        btnActivities.FlatAppearance.CheckedBackColor = Color.Maroon
        btnActivities.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnActivities.FlatAppearance.MouseOverBackColor = Color.Brown
        btnActivities.FlatStyle = FlatStyle.Flat
        btnActivities.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        btnActivities.ForeColor = Color.LightGray
        btnActivities.Location = New Point(459, 33)
        btnActivities.Name = "btnActivities"
        btnActivities.Size = New Size(358, 239)
        btnActivities.TabIndex = 6
        btnActivities.Text = "Activities"
        btnActivities.UseVisualStyleBackColor = False
        ' 
        ' btnSchedule
        ' 
        btnSchedule.BackColor = Color.Transparent
        btnSchedule.BackgroundImage = My.Resources.Resources.border__1_
        btnSchedule.BackgroundImageLayout = ImageLayout.Stretch
        btnSchedule.FlatAppearance.BorderSize = 0
        btnSchedule.FlatAppearance.CheckedBackColor = Color.Maroon
        btnSchedule.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnSchedule.FlatAppearance.MouseOverBackColor = Color.Brown
        btnSchedule.FlatStyle = FlatStyle.Flat
        btnSchedule.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        btnSchedule.ForeColor = Color.LightGray
        btnSchedule.Location = New Point(77, 296)
        btnSchedule.Name = "btnSchedule"
        btnSchedule.Size = New Size(358, 239)
        btnSchedule.TabIndex = 9
        btnSchedule.Text = "Schedule"
        btnSchedule.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Transparent
        btnProfile.BackgroundImage = My.Resources.Resources.border__1_
        btnProfile.BackgroundImageLayout = ImageLayout.Stretch
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatAppearance.CheckedBackColor = Color.Maroon
        btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnProfile.FlatAppearance.MouseOverBackColor = Color.Brown
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Tahoma", 18F, FontStyle.Bold)
        btnProfile.ForeColor = Color.LightGray
        btnProfile.Location = New Point(77, 31)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(358, 239)
        btnProfile.TabIndex = 5
        btnProfile.Text = "Admin Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' pnlActivities
        ' 
        pnlActivities.AutoSize = True
        pnlActivities.BorderStyle = BorderStyle.Fixed3D
        pnlActivities.Controls.Add(Panel10)
        pnlActivities.Controls.Add(Panel12)
        pnlActivities.Controls.Add(Label47)
        pnlActivities.Dock = DockStyle.Fill
        pnlActivities.Location = New Point(0, 0)
        pnlActivities.Name = "pnlActivities"
        pnlActivities.Size = New Size(1253, 765)
        pnlActivities.TabIndex = 3
        ' 
        ' Panel10
        ' 
        Panel10.AutoSize = True
        Panel10.BackColor = Color.Gainsboro
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(Label15)
        Panel10.Controls.Add(Label16)
        Panel10.Controls.Add(Label17)
        Panel10.Controls.Add(Label18)
        Panel10.Controls.Add(Label19)
        Panel10.Controls.Add(Label23)
        Panel10.Controls.Add(Label24)
        Panel10.Controls.Add(Label25)
        Panel10.Controls.Add(Label26)
        Panel10.Controls.Add(PictureBox3)
        Panel10.Controls.Add(Label27)
        Panel10.Location = New Point(21, 43)
        Panel10.Margin = New Padding(2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1210, 194)
        Panel10.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoEllipsis = True
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ImageAlign = ContentAlignment.MiddleLeft
        Label15.Location = New Point(798, 154)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.RightToLeft = RightToLeft.No
        Label15.Size = New Size(120, 23)
        Label15.TabIndex = 10
        Label15.Text = "09123456789"
        ' 
        ' Label16
        ' 
        Label16.AutoEllipsis = True
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ImageAlign = ContentAlignment.MiddleLeft
        Label16.Location = New Point(798, 42)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.RightToLeft = RightToLeft.No
        Label16.Size = New Size(245, 23)
        Label16.TabIndex = 9
        Label16.Text = "School Of Computer Studies"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.ImageAlign = ContentAlignment.MiddleLeft
        Label17.Location = New Point(725, 144)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.RightToLeft = RightToLeft.No
        Label17.Size = New Size(0, 23)
        Label17.TabIndex = 8
        ' 
        ' Label18
        ' 
        Label18.AutoEllipsis = True
        Label18.AutoSize = True
        Label18.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.ImageAlign = ContentAlignment.MiddleLeft
        Label18.Location = New Point(798, 97)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.RightToLeft = RightToLeft.No
        Label18.Size = New Size(360, 23)
        Label18.TabIndex = 7
        Label18.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
        ' 
        ' Label19
        ' 
        Label19.AutoEllipsis = True
        Label19.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label19.Image = My.Resources.Resources.icons8_phone_number_20
        Label19.ImageAlign = ContentAlignment.MiddleLeft
        Label19.Location = New Point(798, 129)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.RightToLeft = RightToLeft.No
        Label19.Size = New Size(190, 22)
        Label19.TabIndex = 6
        Label19.Text = "     Contact Number: "
        ' 
        ' Label23
        ' 
        Label23.AutoEllipsis = True
        Label23.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label23.Image = My.Resources.Resources.icons8_email_18
        Label23.ImageAlign = ContentAlignment.MiddleLeft
        Label23.Location = New Point(798, 72)
        Label23.Margin = New Padding(2, 0, 2, 0)
        Label23.Name = "Label23"
        Label23.RightToLeft = RightToLeft.No
        Label23.Size = New Size(170, 22)
        Label23.TabIndex = 5
        Label23.Text = "     Email Address: "
        ' 
        ' Label24
        ' 
        Label24.AutoEllipsis = True
        Label24.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label24.Image = My.Resources.Resources.icons8_unit_18
        Label24.ImageAlign = ContentAlignment.MiddleLeft
        Label24.Location = New Point(798, 18)
        Label24.Margin = New Padding(2, 0, 2, 0)
        Label24.Name = "Label24"
        Label24.RightToLeft = RightToLeft.No
        Label24.Size = New Size(151, 22)
        Label24.TabIndex = 4
        Label24.Text = "     Department: "
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(226, 83)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(425, 24)
        Label25.TabIndex = 2
        Label25.Text = "Bachelor of Science In Information Technology"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(226, 30)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(308, 41)
        Label26.TabIndex = 1
        Label26.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox3.Location = New Point(28, 15)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(160, 160)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.BackColor = Color.Transparent
        Label27.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.DarkOrange
        Label27.Location = New Point(226, 58)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(459, 20)
        Label27.TabIndex = 3
        Label27.Text = "___________________________________________________________________________"
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(tabActivity)
        Panel12.Location = New Point(21, 255)
        Panel12.Margin = New Padding(2)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(1210, 494)
        Panel12.TabIndex = 1
        ' 
        ' tabActivity
        ' 
        tabActivity.Appearance = TabAppearance.Buttons
        tabActivity.Controls.Add(tabActivityList)
        tabActivity.Controls.Add(tabManageActivity)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(2, 2)
        tabActivity.Margin = New Padding(2)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1205, 489)
        tabActivity.TabIndex = 1
        ' 
        ' tabActivityList
        ' 
        tabActivityList.Controls.Add(Panel13)
        tabActivityList.Controls.Add(Panel14)
        tabActivityList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivityList.Location = New Point(4, 36)
        tabActivityList.Margin = New Padding(2)
        tabActivityList.Name = "tabActivityList"
        tabActivityList.Padding = New Padding(2)
        tabActivityList.Size = New Size(1197, 449)
        tabActivityList.TabIndex = 0
        tabActivityList.Text = "Activity List"
        tabActivityList.UseVisualStyleBackColor = True
        ' 
        ' Panel13
        ' 
        Panel13.BorderStyle = BorderStyle.Fixed3D
        Panel13.Controls.Add(lstActivityList)
        Panel13.Controls.Add(btnAddNewActivity)
        Panel13.Location = New Point(14, 106)
        Panel13.Margin = New Padding(2)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(1262, 330)
        Panel13.TabIndex = 1
        ' 
        ' lstActivityList
        ' 
        lstActivityList.Location = New Point(-2, -2)
        lstActivityList.Margin = New Padding(2)
        lstActivityList.Name = "lstActivityList"
        lstActivityList.Size = New Size(1173, 269)
        lstActivityList.TabIndex = 19
        lstActivityList.UseCompatibleStateImageBehavior = False
        ' 
        ' btnAddNewActivity
        ' 
        btnAddNewActivity.BackColor = Color.Transparent
        btnAddNewActivity.FlatAppearance.BorderColor = Color.LightGray
        btnAddNewActivity.FlatAppearance.MouseOverBackColor = Color.Brown
        btnAddNewActivity.FlatStyle = FlatStyle.Popup
        btnAddNewActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddNewActivity.ForeColor = Color.Black
        btnAddNewActivity.Location = New Point(523, 278)
        btnAddNewActivity.Name = "btnAddNewActivity"
        btnAddNewActivity.Size = New Size(163, 43)
        btnAddNewActivity.TabIndex = 18
        btnAddNewActivity.Text = "Add New Activity"
        btnAddNewActivity.UseVisualStyleBackColor = False
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.Firebrick
        Panel14.BorderStyle = BorderStyle.Fixed3D
        Panel14.Controls.Add(Label33)
        Panel14.ForeColor = Color.White
        Panel14.Location = New Point(14, 15)
        Panel14.Margin = New Padding(2)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(1173, 74)
        Panel14.TabIndex = 0
        ' 
        ' Label33
        ' 
        Label33.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ImageAlign = ContentAlignment.MiddleLeft
        Label33.Location = New Point(19, 14)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.Size = New Size(311, 34)
        Label33.TabIndex = 0
        Label33.Text = "   Activity List"
        ' 
        ' tabManageActivity
        ' 
        tabManageActivity.Controls.Add(Panel15)
        tabManageActivity.Controls.Add(Panel16)
        tabManageActivity.Location = New Point(4, 36)
        tabManageActivity.Margin = New Padding(2)
        tabManageActivity.Name = "tabManageActivity"
        tabManageActivity.Size = New Size(1197, 449)
        tabManageActivity.TabIndex = 1
        tabManageActivity.Text = "Manage Activity"
        tabManageActivity.UseVisualStyleBackColor = True
        ' 
        ' Panel15
        ' 
        Panel15.BorderStyle = BorderStyle.Fixed3D
        Panel15.Controls.Add(btnDeleteActivity)
        Panel15.Controls.Add(txtActivityName)
        Panel15.Controls.Add(btnEditActivity)
        Panel15.Controls.Add(Label34)
        Panel15.Controls.Add(btnClear)
        Panel15.Controls.Add(Label36)
        Panel15.Controls.Add(dtpEndDate)
        Panel15.Controls.Add(Label41)
        Panel15.Controls.Add(dtpStartDate)
        Panel15.Controls.Add(Label43)
        Panel15.Controls.Add(txtFacultyAdviser)
        Panel15.Controls.Add(Label44)
        Panel15.Controls.Add(Label45)
        Panel15.Controls.Add(txtActivityType)
        Panel15.Controls.Add(txtDescription)
        Panel15.Location = New Point(14, 108)
        Panel15.Margin = New Padding(2)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(1173, 330)
        Panel15.TabIndex = 3
        ' 
        ' btnDeleteActivity
        ' 
        btnDeleteActivity.BackColor = Color.Transparent
        btnDeleteActivity.FlatAppearance.BorderColor = Color.LightGray
        btnDeleteActivity.FlatAppearance.MouseOverBackColor = Color.Brown
        btnDeleteActivity.FlatStyle = FlatStyle.Popup
        btnDeleteActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteActivity.ForeColor = Color.Black
        btnDeleteActivity.Location = New Point(591, 202)
        btnDeleteActivity.Name = "btnDeleteActivity"
        btnDeleteActivity.Size = New Size(163, 43)
        btnDeleteActivity.TabIndex = 34
        btnDeleteActivity.Text = "Delete Activity"
        btnDeleteActivity.UseVisualStyleBackColor = False
        ' 
        ' txtActivityName
        ' 
        txtActivityName.Enabled = False
        txtActivityName.Font = New Font("Tahoma", 10F)
        txtActivityName.Location = New Point(227, 52)
        txtActivityName.Margin = New Padding(2)
        txtActivityName.Name = "txtActivityName"
        txtActivityName.Size = New Size(342, 28)
        txtActivityName.TabIndex = 25
        ' 
        ' btnEditActivity
        ' 
        btnEditActivity.BackColor = Color.Transparent
        btnEditActivity.FlatAppearance.BorderColor = Color.LightGray
        btnEditActivity.FlatAppearance.MouseOverBackColor = Color.Brown
        btnEditActivity.FlatStyle = FlatStyle.Popup
        btnEditActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditActivity.ForeColor = Color.Black
        btnEditActivity.Location = New Point(405, 202)
        btnEditActivity.Name = "btnEditActivity"
        btnEditActivity.Size = New Size(163, 43)
        btnEditActivity.TabIndex = 33
        btnEditActivity.Text = "Edit Activity"
        btnEditActivity.UseVisualStyleBackColor = False
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label34.Location = New Point(70, 56)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(158, 24)
        Label34.TabIndex = 20
        Label34.Text = "Activity Name:"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatAppearance.BorderColor = Color.LightGray
        btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Gainsboro
        btnClear.ImageAlign = ContentAlignment.MiddleRight
        btnClear.Location = New Point(507, 266)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(163, 43)
        btnClear.TabIndex = 32
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label36.Location = New Point(80, 102)
        Label36.Margin = New Padding(2, 0, 2, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(149, 24)
        Label36.TabIndex = 21
        Label36.Text = "Activity Type:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Tahoma", 10F)
        dtpEndDate.Location = New Point(765, 152)
        dtpEndDate.Margin = New Padding(2)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(342, 28)
        dtpEndDate.TabIndex = 31
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label41.Location = New Point(96, 152)
        Label41.Margin = New Padding(2, 0, 2, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(132, 24)
        Label41.TabIndex = 22
        Label41.Text = "Description:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Tahoma", 10F)
        dtpStartDate.Location = New Point(765, 102)
        dtpStartDate.Margin = New Padding(2)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(342, 28)
        dtpStartDate.TabIndex = 30
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label43.Location = New Point(639, 100)
        Label43.Margin = New Padding(2, 0, 2, 0)
        Label43.Name = "Label43"
        Label43.Size = New Size(120, 24)
        Label43.TabIndex = 23
        Label43.Text = "Start Date:"
        ' 
        ' txtFacultyAdviser
        ' 
        txtFacultyAdviser.Enabled = False
        txtFacultyAdviser.Font = New Font("Tahoma", 10F)
        txtFacultyAdviser.Location = New Point(765, 51)
        txtFacultyAdviser.Margin = New Padding(2)
        txtFacultyAdviser.Name = "txtFacultyAdviser"
        txtFacultyAdviser.Size = New Size(342, 28)
        txtFacultyAdviser.TabIndex = 29
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label44.Location = New Point(650, 157)
        Label44.Margin = New Padding(2, 0, 2, 0)
        Label44.Name = "Label44"
        Label44.Size = New Size(108, 24)
        Label44.TabIndex = 24
        Label44.Text = "End Date:"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label45.Location = New Point(586, 56)
        Label45.Margin = New Padding(2, 0, 2, 0)
        Label45.Name = "Label45"
        Label45.Size = New Size(179, 24)
        Label45.TabIndex = 28
        Label45.Text = "Faculty/Adviser:"
        ' 
        ' txtActivityType
        ' 
        txtActivityType.Enabled = False
        txtActivityType.Font = New Font("Tahoma", 10F)
        txtActivityType.Location = New Point(227, 100)
        txtActivityType.Margin = New Padding(2)
        txtActivityType.Name = "txtActivityType"
        txtActivityType.Size = New Size(342, 28)
        txtActivityType.TabIndex = 26
        ' 
        ' txtDescription
        ' 
        txtDescription.Enabled = False
        txtDescription.Font = New Font("Tahoma", 10F)
        txtDescription.Location = New Point(227, 150)
        txtDescription.Margin = New Padding(2)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(342, 28)
        txtDescription.TabIndex = 27
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.Firebrick
        Panel16.BorderStyle = BorderStyle.Fixed3D
        Panel16.Controls.Add(Label46)
        Panel16.ForeColor = Color.White
        Panel16.Location = New Point(14, 17)
        Panel16.Margin = New Padding(2)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(1173, 74)
        Panel16.TabIndex = 2
        ' 
        ' Label46
        ' 
        Label46.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label46.ImageAlign = ContentAlignment.MiddleLeft
        Label46.Location = New Point(19, 14)
        Label46.Margin = New Padding(2, 0, 2, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(426, 34)
        Label46.TabIndex = 0
        Label46.Text = "   Create/Modify/Delete Activity"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label47.Location = New Point(21, 10)
        Label47.Margin = New Padding(2, 0, 2, 0)
        Label47.Name = "Label47"
        Label47.Size = New Size(117, 33)
        Label47.TabIndex = 0
        Label47.Text = "Activity"
        ' 
        ' pnlProfile
        ' 
        pnlProfile.AutoSize = True
        pnlProfile.BorderStyle = BorderStyle.Fixed3D
        pnlProfile.Controls.Add(Panel11)
        pnlProfile.Controls.Add(Panel9)
        pnlProfile.Controls.Add(Label14)
        pnlProfile.Dock = DockStyle.Fill
        pnlProfile.Location = New Point(0, 0)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1253, 765)
        pnlProfile.TabIndex = 2
        pnlProfile.Visible = False
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
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
        Panel5.Controls.Add(btnTabRatings)
        Panel5.Controls.Add(btnTabSchedule)
        Panel5.Controls.Add(btnTabEnrollees)
        Panel5.Controls.Add(btnTabActivities)
        Panel5.Controls.Add(btnTabProfile)
        Panel5.Controls.Add(btnDashboard)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 321)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 505)
        Panel5.TabIndex = 5
        ' 
        ' btnTabRatings
        ' 
        btnTabRatings.BackColor = Color.Transparent
        btnTabRatings.BackgroundImageLayout = ImageLayout.Center
        btnTabRatings.Cursor = Cursors.Hand
        btnTabRatings.Dock = DockStyle.Top
        btnTabRatings.FlatAppearance.BorderSize = 0
        btnTabRatings.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnTabRatings.FlatStyle = FlatStyle.Flat
        btnTabRatings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabRatings.ForeColor = Color.White
        btnTabRatings.Image = CType(resources.GetObject("btnTabRatings.Image"), Image)
        btnTabRatings.ImageAlign = ContentAlignment.MiddleLeft
        btnTabRatings.Location = New Point(0, 315)
        btnTabRatings.Name = "btnTabRatings"
        btnTabRatings.Size = New Size(287, 63)
        btnTabRatings.TabIndex = 10
        btnTabRatings.Text = "          RATINGS"
        btnTabRatings.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTabRatings.UseVisualStyleBackColor = False
        ' 
        ' btnTabSchedule
        ' 
        btnTabSchedule.BackColor = Color.Transparent
        btnTabSchedule.BackgroundImageLayout = ImageLayout.Center
        btnTabSchedule.Cursor = Cursors.Hand
        btnTabSchedule.Dock = DockStyle.Top
        btnTabSchedule.FlatAppearance.BorderSize = 0
        btnTabSchedule.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnTabSchedule.FlatStyle = FlatStyle.Flat
        btnTabSchedule.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabSchedule.ForeColor = Color.White
        btnTabSchedule.Image = CType(resources.GetObject("btnTabSchedule.Image"), Image)
        btnTabSchedule.ImageAlign = ContentAlignment.MiddleLeft
        btnTabSchedule.Location = New Point(0, 252)
        btnTabSchedule.Name = "btnTabSchedule"
        btnTabSchedule.Size = New Size(287, 63)
        btnTabSchedule.TabIndex = 9
        btnTabSchedule.Text = "         SCHEDULE"
        btnTabSchedule.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTabSchedule.UseVisualStyleBackColor = False
        ' 
        ' btnTabEnrollees
        ' 
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabEnrollees.BackgroundImageLayout = ImageLayout.Center
        btnTabEnrollees.Cursor = Cursors.Hand
        btnTabEnrollees.Dock = DockStyle.Top
        btnTabEnrollees.FlatAppearance.BorderSize = 0
        btnTabEnrollees.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnTabEnrollees.FlatStyle = FlatStyle.Flat
        btnTabEnrollees.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabEnrollees.ForeColor = Color.White
        btnTabEnrollees.Image = CType(resources.GetObject("btnTabEnrollees.Image"), Image)
        btnTabEnrollees.ImageAlign = ContentAlignment.MiddleLeft
        btnTabEnrollees.Location = New Point(0, 189)
        btnTabEnrollees.Name = "btnTabEnrollees"
        btnTabEnrollees.Size = New Size(287, 63)
        btnTabEnrollees.TabIndex = 8
        btnTabEnrollees.Text = "        ENROLLEES"
        btnTabEnrollees.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTabEnrollees.UseVisualStyleBackColor = False
        ' 
        ' btnTabActivities
        ' 
        btnTabActivities.BackColor = Color.Transparent
        btnTabActivities.BackgroundImageLayout = ImageLayout.Center
        btnTabActivities.Cursor = Cursors.Hand
        btnTabActivities.Dock = DockStyle.Top
        btnTabActivities.FlatAppearance.BorderSize = 0
        btnTabActivities.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnTabActivities.FlatStyle = FlatStyle.Flat
        btnTabActivities.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabActivities.ForeColor = Color.White
        btnTabActivities.Image = CType(resources.GetObject("btnTabActivities.Image"), Image)
        btnTabActivities.ImageAlign = ContentAlignment.MiddleLeft
        btnTabActivities.Location = New Point(0, 126)
        btnTabActivities.Name = "btnTabActivities"
        btnTabActivities.Size = New Size(287, 63)
        btnTabActivities.TabIndex = 7
        btnTabActivities.Text = "        ACTIVITIES"
        btnTabActivities.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTabActivities.UseVisualStyleBackColor = False
        ' 
        ' btnTabProfile
        ' 
        btnTabProfile.BackColor = Color.Transparent
        btnTabProfile.BackgroundImageLayout = ImageLayout.Center
        btnTabProfile.Cursor = Cursors.Hand
        btnTabProfile.Dock = DockStyle.Top
        btnTabProfile.FlatAppearance.BorderSize = 0
        btnTabProfile.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnTabProfile.FlatStyle = FlatStyle.Flat
        btnTabProfile.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabProfile.ForeColor = Color.White
        btnTabProfile.Image = CType(resources.GetObject("btnTabProfile.Image"), Image)
        btnTabProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnTabProfile.Location = New Point(0, 63)
        btnTabProfile.Name = "btnTabProfile"
        btnTabProfile.Size = New Size(287, 63)
        btnTabProfile.TabIndex = 6
        btnTabProfile.Text = "           PROFILE"
        btnTabProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTabProfile.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.Transparent
        btnDashboard.BackgroundImageLayout = ImageLayout.Center
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 0)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(287, 63)
        btnDashboard.TabIndex = 5
        btnDashboard.Text = "        DASHBOARD"
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.Font = New Font("Georgia", 13.8F, FontStyle.Bold)
        lblFName.ForeColor = Color.White
        lblFName.Location = New Point(140, 285)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(83, 27)
        lblFName.TabIndex = 4
        lblFName.Text = "Jonas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.White
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
        ' Timer1
        ' 
        Timer1.Interval = 1
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
        pnlBG.ResumeLayout(False)
        pnlBG.PerformLayout()
        pnlMAIN.ResumeLayout(False)
        pnlActivities.ResumeLayout(False)
        pnlActivities.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel12.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        tabManageActivity.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel16.ResumeLayout(False)
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
    Friend WithEvents btnEnrollees As Button
    Friend WithEvents btnActivities As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRatings As Button
    Friend WithEvents btnSchedule As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblFName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTabEnrollees As Button
    Friend WithEvents btnTabActivities As Button
    Friend WithEvents btnTabProfile As Button
    Friend WithEvents btnTabRatings As Button
    Friend WithEvents btnTabSchedule As Button
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
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlActivities As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents tabActivity As TabControl
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lstActivityList As ListView
    Friend WithEvents btnAddNewActivity As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents tabManageActivity As TabPage
    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnDeleteActivity As Button
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents btnEditActivity As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label41 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents txtFacultyAdviser As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txtActivityType As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents pnlBG As Panel
End Class
