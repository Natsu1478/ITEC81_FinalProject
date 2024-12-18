<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class layout2
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
        pnlActivity = New Panel()
        Panel11 = New Panel()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        PictureBox4 = New PictureBox()
        Label42 = New Label()
        tabAboutMe = New TabControl()
        tabActivityList = New TabPage()
        Panel2 = New Panel()
        btnAddNewActivity = New Button()
        lstActivityList = New ListBox()
        Panel1 = New Panel()
        Label1 = New Label()
        tabManageActivity = New TabPage()
        Panel8 = New Panel()
        Me.btnDeleteActivity = New Button()
        btnClear = New Button()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        txtFaculty = New TextBox()
        txtDescription = New TextBox()
        txtActivityType = New TextBox()
        txtActivityName = New TextBox()
        Label21 = New Label()
        Label22 = New Label()
        Label28 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Panel7 = New Panel()
        Label29 = New Label()
        Label14 = New Label()
        Me.btnEditActivity = New Button()
        pnlActivity.SuspendLayout()
        Panel11.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        tabAboutMe.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        tabManageActivity.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlActivity
        ' 
        pnlActivity.Controls.Add(Panel11)
        pnlActivity.Controls.Add(tabAboutMe)
        pnlActivity.Controls.Add(Label14)
        pnlActivity.Location = New Point(0, 0)
        pnlActivity.Name = "pnlActivity"
        pnlActivity.Size = New Size(1564, 959)
        pnlActivity.TabIndex = 0
        ' 
        ' Panel11
        ' 
        Panel11.AutoSize = True
        Panel11.BackColor = Color.Gainsboro
        Panel11.BorderStyle = BorderStyle.Fixed3D
        Panel11.Controls.Add(Label33)
        Panel11.Controls.Add(Label34)
        Panel11.Controls.Add(Label35)
        Panel11.Controls.Add(Label36)
        Panel11.Controls.Add(Label37)
        Panel11.Controls.Add(Label38)
        Panel11.Controls.Add(Label39)
        Panel11.Controls.Add(Label40)
        Panel11.Controls.Add(Label41)
        Panel11.Controls.Add(PictureBox4)
        Panel11.Controls.Add(Label42)
        Panel11.Location = New Point(15, 50)
        Panel11.Margin = New Padding(2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(1528, 242)
        Panel11.TabIndex = 3
        ' 
        ' Label33
        ' 
        Label33.AutoEllipsis = True
        Label33.AutoSize = True
        Label33.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label33.ImageAlign = ContentAlignment.MiddleLeft
        Label33.Location = New Point(998, 192)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.RightToLeft = RightToLeft.No
        Label33.Size = New Size(144, 27)
        Label33.TabIndex = 10
        Label33.Text = "09123456789"
        ' 
        ' Label34
        ' 
        Label34.AutoEllipsis = True
        Label34.AutoSize = True
        Label34.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label34.ImageAlign = ContentAlignment.MiddleLeft
        Label34.Location = New Point(998, 52)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.RightToLeft = RightToLeft.No
        Label34.Size = New Size(283, 27)
        Label34.TabIndex = 9
        Label34.Text = "School Of Computer Studies"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.ImageAlign = ContentAlignment.MiddleLeft
        Label35.Location = New Point(906, 180)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.RightToLeft = RightToLeft.No
        Label35.Size = New Size(0, 27)
        Label35.TabIndex = 8
        ' 
        ' Label36
        ' 
        Label36.AutoEllipsis = True
        Label36.AutoSize = True
        Label36.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label36.ImageAlign = ContentAlignment.MiddleLeft
        Label36.Location = New Point(998, 121)
        Label36.Margin = New Padding(2, 0, 2, 0)
        Label36.Name = "Label36"
        Label36.RightToLeft = RightToLeft.No
        Label36.Size = New Size(419, 27)
        Label36.TabIndex = 7
        Label36.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
        ' 
        ' Label37
        ' 
        Label37.AutoEllipsis = True
        Label37.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label37.Image = My.Resources.Resources.icons8_phone_number_20
        Label37.ImageAlign = ContentAlignment.MiddleLeft
        Label37.Location = New Point(998, 161)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.RightToLeft = RightToLeft.No
        Label37.Size = New Size(238, 28)
        Label37.TabIndex = 6
        Label37.Text = "     Contact Number: "
        ' 
        ' Label38
        ' 
        Label38.AutoEllipsis = True
        Label38.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label38.Image = My.Resources.Resources.icons8_email_18
        Label38.ImageAlign = ContentAlignment.MiddleLeft
        Label38.Location = New Point(998, 90)
        Label38.Margin = New Padding(2, 0, 2, 0)
        Label38.Name = "Label38"
        Label38.RightToLeft = RightToLeft.No
        Label38.Size = New Size(212, 28)
        Label38.TabIndex = 5
        Label38.Text = "     Email Address: "
        ' 
        ' Label39
        ' 
        Label39.AutoEllipsis = True
        Label39.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label39.Image = My.Resources.Resources.icons8_unit_18
        Label39.ImageAlign = ContentAlignment.MiddleLeft
        Label39.Location = New Point(998, 22)
        Label39.Margin = New Padding(2, 0, 2, 0)
        Label39.Name = "Label39"
        Label39.RightToLeft = RightToLeft.No
        Label39.Size = New Size(189, 28)
        Label39.TabIndex = 4
        Label39.Text = "     Department: "
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(282, 104)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(510, 29)
        Label40.TabIndex = 2
        Label40.Text = "Bachelor of Science In Information Technology"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label41.Location = New Point(282, 38)
        Label41.Margin = New Padding(2, 0, 2, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(360, 48)
        Label41.TabIndex = 1
        Label41.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox4.Location = New Point(35, 19)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(200, 200)
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
        Label42.Location = New Point(282, 72)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(537, 25)
        Label42.TabIndex = 3
        Label42.Text = "___________________________________________________________________________"
        ' 
        ' tabAboutMe
        ' 
        tabAboutMe.Appearance = TabAppearance.Buttons
        tabAboutMe.Controls.Add(tabActivityList)
        tabAboutMe.Controls.Add(tabManageActivity)
        tabAboutMe.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabAboutMe.Location = New Point(11, 300)
        tabAboutMe.Margin = New Padding(2)
        tabAboutMe.Name = "tabAboutMe"
        tabAboutMe.SelectedIndex = 0
        tabAboutMe.Size = New Size(1547, 658)
        tabAboutMe.TabIndex = 2
        ' 
        ' tabActivityList
        ' 
        tabActivityList.Controls.Add(Panel2)
        tabActivityList.Controls.Add(Panel1)
        tabActivityList.Location = New Point(4, 41)
        tabActivityList.Name = "tabActivityList"
        tabActivityList.Size = New Size(1539, 613)
        tabActivityList.TabIndex = 1
        tabActivityList.Text = "Activity List"
        tabActivityList.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnAddNewActivity)
        Panel2.Controls.Add(lstActivityList)
        Panel2.Font = New Font("Tahoma", 9F)
        Panel2.Location = New Point(13, 118)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1510, 479)
        Panel2.TabIndex = 2
        ' 
        ' btnAddNewActivity
        ' 
        btnAddNewActivity.BackColor = Color.White
        btnAddNewActivity.FlatStyle = FlatStyle.Flat
        btnAddNewActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddNewActivity.Location = New Point(625, 417)
        btnAddNewActivity.Margin = New Padding(4)
        btnAddNewActivity.Name = "btnAddNewActivity"
        btnAddNewActivity.Size = New Size(195, 54)
        btnAddNewActivity.TabIndex = 14
        btnAddNewActivity.Text = "Add New Activity"
        btnAddNewActivity.UseVisualStyleBackColor = False
        ' 
        ' lstActivityList
        ' 
        lstActivityList.FormattingEnabled = True
        lstActivityList.ItemHeight = 22
        lstActivityList.Location = New Point(-2, -2)
        lstActivityList.Name = "lstActivityList"
        lstActivityList.Size = New Size(1510, 400)
        lstActivityList.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(13, 11)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1515, 92)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Image = My.Resources.Resources.icons8_list_25
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(24, 18)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(508, 42)
        Label1.TabIndex = 0
        Label1.Text = "   Activity List"
        ' 
        ' tabManageActivity
        ' 
        tabManageActivity.Controls.Add(Panel8)
        tabManageActivity.Controls.Add(Panel7)
        tabManageActivity.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabManageActivity.Location = New Point(4, 41)
        tabManageActivity.Margin = New Padding(2)
        tabManageActivity.Name = "tabManageActivity"
        tabManageActivity.Padding = New Padding(2)
        tabManageActivity.Size = New Size(1539, 613)
        tabManageActivity.TabIndex = 0
        tabManageActivity.Text = "Manage Activity"
        tabManageActivity.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(Me.btnEditActivity)
        Panel8.Controls.Add(Me.btnDeleteActivity)
        Panel8.Controls.Add(btnClear)
        Panel8.Controls.Add(dtpEndDate)
        Panel8.Controls.Add(dtpStartDate)
        Panel8.Controls.Add(txtFaculty)
        Panel8.Controls.Add(txtDescription)
        Panel8.Controls.Add(txtActivityType)
        Panel8.Controls.Add(txtActivityName)
        Panel8.Controls.Add(Label21)
        Panel8.Controls.Add(Label22)
        Panel8.Controls.Add(Label28)
        Panel8.Controls.Add(Label30)
        Panel8.Controls.Add(Label31)
        Panel8.Controls.Add(Label32)
        Panel8.Font = New Font("Tahoma", 9F)
        Panel8.Location = New Point(18, 115)
        Panel8.Margin = New Padding(2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1510, 479)
        Panel8.TabIndex = 1
        ' 
        ' btnDeleteActivity
        ' 
        Me.btnDeleteActivity.BackColor = Color.White
        Me.btnDeleteActivity.FlatStyle = FlatStyle.Flat
        Me.btnDeleteActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.btnDeleteActivity.Location = New Point(758, 303)
        Me.btnDeleteActivity.Margin = New Padding(4)
        Me.btnDeleteActivity.Name = "btnDeleteActivity"
        Me.btnDeleteActivity.Size = New Size(195, 54)
        Me.btnDeleteActivity.TabIndex = 14
        Me.btnDeleteActivity.Text = "Delete Activity"
        Me.btnDeleteActivity.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(651, 394)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(195, 54)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Tahoma", 9F)
        dtpEndDate.Location = New Point(960, 206)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(455, 29)
        dtpEndDate.TabIndex = 11
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Tahoma", 9F)
        dtpStartDate.Location = New Point(960, 127)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(455, 29)
        dtpStartDate.TabIndex = 10
        ' 
        ' txtFaculty
        ' 
        txtFaculty.Enabled = False
        txtFaculty.Font = New Font("Tahoma", 9F)
        txtFaculty.Location = New Point(960, 43)
        txtFaculty.Margin = New Padding(2)
        txtFaculty.Name = "txtFaculty"
        txtFaculty.Size = New Size(455, 29)
        txtFaculty.TabIndex = 8
        ' 
        ' txtDescription
        ' 
        txtDescription.Enabled = False
        txtDescription.Font = New Font("Tahoma", 9F)
        txtDescription.Location = New Point(264, 196)
        txtDescription.Margin = New Padding(2)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(455, 29)
        txtDescription.TabIndex = 9
        ' 
        ' txtActivityType
        ' 
        txtActivityType.Enabled = False
        txtActivityType.Font = New Font("Tahoma", 9F)
        txtActivityType.Location = New Point(264, 119)
        txtActivityType.Margin = New Padding(2)
        txtActivityType.Name = "txtActivityType"
        txtActivityType.Size = New Size(455, 29)
        txtActivityType.TabIndex = 8
        ' 
        ' txtActivityName
        ' 
        txtActivityName.Enabled = False
        txtActivityName.Font = New Font("Tahoma", 9F)
        txtActivityName.Location = New Point(264, 43)
        txtActivityName.Margin = New Padding(2)
        txtActivityName.Name = "txtActivityName"
        txtActivityName.Size = New Size(455, 29)
        txtActivityName.TabIndex = 7
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label21.Location = New Point(826, 206)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(130, 29)
        Label21.TabIndex = 5
        Label21.Text = "End Date:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(809, 124)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(144, 29)
        Label22.TabIndex = 4
        Label22.Text = "Start Date:"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label28.Location = New Point(745, 45)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(211, 29)
        Label28.TabIndex = 3
        Label28.Text = "Faculty/Adviser:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label30.Location = New Point(102, 198)
        Label30.Margin = New Padding(2, 0, 2, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(158, 29)
        Label30.TabIndex = 2
        Label30.Text = "Description:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label31.Location = New Point(82, 121)
        Label31.Margin = New Padding(2, 0, 2, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(178, 29)
        Label31.TabIndex = 1
        Label31.Text = "Activity Type:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label32.Location = New Point(70, 45)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(190, 29)
        Label32.TabIndex = 0
        Label32.Text = "Activity Name:"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Firebrick
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(Label29)
        Panel7.ForeColor = Color.White
        Panel7.Location = New Point(18, 19)
        Panel7.Margin = New Padding(2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1510, 92)
        Panel7.TabIndex = 0
        ' 
        ' Label29
        ' 
        Label29.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Image = My.Resources.Resources.icons8_plus_minus_____25
        Label29.ImageAlign = ContentAlignment.MiddleLeft
        Label29.Location = New Point(24, 18)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(614, 53)
        Label29.TabIndex = 0
        Label29.Text = "   Create/Modify/Delete Activity"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Maroon
        Label14.Location = New Point(11, 9)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(139, 39)
        Label14.TabIndex = 1
        Label14.Text = "Activity"
        ' 
        ' btnEditActivity
        ' 
        Me.btnEditActivity.BackColor = Color.White
        Me.btnEditActivity.FlatStyle = FlatStyle.Flat
        Me.btnEditActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Me.btnEditActivity.Location = New Point(524, 303)
        Me.btnEditActivity.Margin = New Padding(4)
        Me.btnEditActivity.Name = "btnEditActivity"
        Me.btnEditActivity.Size = New Size(195, 54)
        Me.btnEditActivity.TabIndex = 15
        Me.btnEditActivity.Text = "Edit Activity"
        Me.btnEditActivity.UseVisualStyleBackColor = False
        ' 
        ' layout2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1569, 965)
        Controls.Add(pnlActivity)
        Name = "layout2"
        Text = "layout2"
        pnlActivity.ResumeLayout(False)
        pnlActivity.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        tabAboutMe.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        tabManageActivity.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlActivity As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents tabAboutMe As TabControl
    Friend WithEvents tabManageActivity As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtFaculty As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtActivityType As TextBox
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNewActivity As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lstActivityList As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddNewActivity As Button
End Class
