<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LayoutStudentActivity
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
        Panel5 = New Panel()
        cbxStatus = New ComboBox()
        Label2 = New Label()
        txtActivityName = New TextBox()
        btnEnroll = New Button()
        Label23 = New Label()
        btnWithdraw = New Button()
        Label22 = New Label()
        dtpEndDate = New DateTimePicker()
        Label21 = New Label()
        dtpStartDate = New DateTimePicker()
        Label20 = New Label()
        txtFacultyAdviser = New TextBox()
        Label19 = New Label()
        Label16 = New Label()
        txtActivityType = New TextBox()
        txtDescription = New TextBox()
        Panel6 = New Panel()
        Label27 = New Label()
        Panel3 = New Panel()
        Label12 = New Label()
        tabActivityList = New TabPage()
        Panel4 = New Panel()
        lstActivityList = New ListView()
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
        Panel2 = New Panel()
        tabActivity = New TabControl()
        tabActivityEnrollment = New TabPage()
        Label1 = New Label()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel4.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel11.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        tabActivity.SuspendLayout()
        tabActivityEnrollment.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(cbxStatus)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(txtActivityName)
        Panel5.Controls.Add(btnEnroll)
        Panel5.Controls.Add(Label23)
        Panel5.Controls.Add(btnWithdraw)
        Panel5.Controls.Add(Label22)
        Panel5.Controls.Add(dtpEndDate)
        Panel5.Controls.Add(Label21)
        Panel5.Controls.Add(dtpStartDate)
        Panel5.Controls.Add(Label20)
        Panel5.Controls.Add(txtFacultyAdviser)
        Panel5.Controls.Add(Label19)
        Panel5.Controls.Add(Label16)
        Panel5.Controls.Add(txtActivityType)
        Panel5.Controls.Add(txtDescription)
        Panel5.Location = New Point(17, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1465, 411)
        Panel5.TabIndex = 3
        ' 
        ' cbxStatus
        ' 
        cbxStatus.Enabled = False
        cbxStatus.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"Active", "Completed", "Withdrawn"})
        cbxStatus.Location = New Point(954, 244)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(428, 32)
        cbxStatus.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label2.Location = New Point(838, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 29)
        Label2.TabIndex = 34
        Label2.Text = "Status:"
        ' 
        ' txtActivityName
        ' 
        txtActivityName.Enabled = False
        txtActivityName.Font = New Font("Tahoma", 10F)
        txtActivityName.Location = New Point(284, 65)
        txtActivityName.Name = "txtActivityName"
        txtActivityName.Size = New Size(426, 32)
        txtActivityName.TabIndex = 25
        ' 
        ' btnEnroll
        ' 
        btnEnroll.BackColor = Color.Transparent
        btnEnroll.FlatAppearance.BorderColor = Color.LightGray
        btnEnroll.FlatAppearance.MouseOverBackColor = Color.Brown
        btnEnroll.FlatStyle = FlatStyle.Popup
        btnEnroll.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnroll.ForeColor = Color.Black
        btnEnroll.Location = New Point(506, 333)
        btnEnroll.Margin = New Padding(4)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(204, 54)
        btnEnroll.TabIndex = 33
        btnEnroll.Text = "Enroll"
        btnEnroll.UseVisualStyleBackColor = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label23.Location = New Point(88, 70)
        Label23.Name = "Label23"
        Label23.Size = New Size(190, 29)
        Label23.TabIndex = 20
        Label23.Text = "Activity Name:"
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.DodgerBlue
        btnWithdraw.FlatAppearance.BorderColor = Color.LightGray
        btnWithdraw.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnWithdraw.FlatStyle = FlatStyle.Flat
        btnWithdraw.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdraw.ForeColor = Color.Gainsboro
        btnWithdraw.ImageAlign = ContentAlignment.MiddleRight
        btnWithdraw.Location = New Point(732, 333)
        btnWithdraw.Margin = New Padding(4)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(204, 54)
        btnWithdraw.TabIndex = 32
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(100, 127)
        Label22.Name = "Label22"
        Label22.Size = New Size(178, 29)
        Label22.TabIndex = 21
        Label22.Text = "Activity Type:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Tahoma", 10F)
        dtpEndDate.Location = New Point(956, 190)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(426, 32)
        dtpEndDate.TabIndex = 31
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label21.Location = New Point(120, 190)
        Label21.Name = "Label21"
        Label21.Size = New Size(158, 29)
        Label21.TabIndex = 22
        Label21.Text = "Description:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Tahoma", 10F)
        dtpStartDate.Location = New Point(956, 127)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(426, 32)
        dtpStartDate.TabIndex = 30
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label20.Location = New Point(799, 125)
        Label20.Name = "Label20"
        Label20.Size = New Size(144, 29)
        Label20.TabIndex = 23
        Label20.Text = "Start Date:"
        ' 
        ' txtFacultyAdviser
        ' 
        txtFacultyAdviser.Enabled = False
        txtFacultyAdviser.Font = New Font("Tahoma", 10F)
        txtFacultyAdviser.Location = New Point(956, 64)
        txtFacultyAdviser.Name = "txtFacultyAdviser"
        txtFacultyAdviser.Size = New Size(426, 32)
        txtFacultyAdviser.TabIndex = 29
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label19.Location = New Point(813, 196)
        Label19.Name = "Label19"
        Label19.Size = New Size(130, 29)
        Label19.TabIndex = 24
        Label19.Text = "End Date:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label16.Location = New Point(732, 70)
        Label16.Name = "Label16"
        Label16.Size = New Size(211, 29)
        Label16.TabIndex = 28
        Label16.Text = "Faculty/Adviser:"
        ' 
        ' txtActivityType
        ' 
        txtActivityType.Enabled = False
        txtActivityType.Font = New Font("Tahoma", 10F)
        txtActivityType.Location = New Point(284, 125)
        txtActivityType.Name = "txtActivityType"
        txtActivityType.Size = New Size(426, 32)
        txtActivityType.TabIndex = 26
        ' 
        ' txtDescription
        ' 
        txtDescription.Enabled = False
        txtDescription.Font = New Font("Tahoma", 10F)
        txtDescription.Location = New Point(284, 188)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(426, 32)
        txtDescription.TabIndex = 27
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.DodgerBlue
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(Label27)
        Panel6.ForeColor = Color.White
        Panel6.Location = New Point(17, 21)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1465, 91)
        Panel6.TabIndex = 2
        ' 
        ' Label27
        ' 
        Label27.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ImageAlign = ContentAlignment.MiddleLeft
        Label27.Location = New Point(24, 18)
        Label27.Name = "Label27"
        Label27.Size = New Size(532, 43)
        Label27.TabIndex = 0
        Label27.Text = "   Activity Enrollment"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DodgerBlue
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label12)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(17, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1465, 91)
        Panel3.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(24, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(389, 43)
        Label12.TabIndex = 0
        Label12.Text = "   Activity List"
        ' 
        ' tabActivityList
        ' 
        tabActivityList.Controls.Add(Panel4)
        tabActivityList.Controls.Add(Panel3)
        tabActivityList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivityList.Location = New Point(4, 41)
        tabActivityList.Name = "tabActivityList"
        tabActivityList.Padding = New Padding(3)
        tabActivityList.Size = New Size(1498, 566)
        tabActivityList.TabIndex = 0
        tabActivityList.Text = "Activity List"
        tabActivityList.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstActivityList)
        Panel4.Location = New Point(17, 133)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1577, 411)
        Panel4.TabIndex = 1
        ' 
        ' lstActivityList
        ' 
        lstActivityList.Location = New Point(-2, -2)
        lstActivityList.Name = "lstActivityList"
        lstActivityList.Size = New Size(1465, 406)
        lstActivityList.TabIndex = 19
        lstActivityList.UseCompatibleStateImageBehavior = False
        ' 
        ' pnlProfile
        ' 
        pnlProfile.AutoSize = True
        pnlProfile.BorderStyle = BorderStyle.Fixed3D
        pnlProfile.Controls.Add(Panel11)
        pnlProfile.Controls.Add(Panel2)
        pnlProfile.Controls.Add(Label1)
        pnlProfile.Location = New Point(-9, -8)
        pnlProfile.Margin = New Padding(4)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1564, 959)
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
        Panel11.Location = New Point(33, 53)
        Panel11.Margin = New Padding(2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(1486, 242)
        Panel11.TabIndex = 3
        ' 
        ' lblContact
        ' 
        lblContact.AutoEllipsis = True
        lblContact.AutoSize = True
        lblContact.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContact.ImageAlign = ContentAlignment.MiddleLeft
        lblContact.Location = New Point(998, 192)
        lblContact.Margin = New Padding(2, 0, 2, 0)
        lblContact.Name = "lblContact"
        lblContact.RightToLeft = RightToLeft.No
        lblContact.Size = New Size(144, 27)
        lblContact.TabIndex = 10
        lblContact.Text = "09123456789"
        ' 
        ' lblDept
        ' 
        lblDept.AutoEllipsis = True
        lblDept.AutoSize = True
        lblDept.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDept.ImageAlign = ContentAlignment.MiddleLeft
        lblDept.Location = New Point(998, 52)
        lblDept.Margin = New Padding(2, 0, 2, 0)
        lblDept.Name = "lblDept"
        lblDept.RightToLeft = RightToLeft.No
        lblDept.Size = New Size(464, 27)
        lblDept.TabIndex = 9
        lblDept.Text = "Bachelor of Science in Information Technology"
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
        ' lblEmail
        ' 
        lblEmail.AutoEllipsis = True
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ImageAlign = ContentAlignment.MiddleLeft
        lblEmail.Location = New Point(998, 121)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.RightToLeft = RightToLeft.No
        lblEmail.Size = New Size(419, 27)
        lblEmail.TabIndex = 7
        lblEmail.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
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
        Label37.Size = New Size(314, 28)
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
        Label38.Size = New Size(341, 28)
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
        Label39.Size = New Size(238, 28)
        Label39.TabIndex = 4
        Label39.Text = "     Course:"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label40.Location = New Point(300, 132)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(115, 29)
        Label40.TabIndex = 2
        Label40.Text = "STUDENT"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullName.Location = New Point(282, 69)
        lblFullName.Margin = New Padding(2, 0, 2, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(360, 48)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Alba, Glerisse Venn"
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
        Label42.Location = New Point(282, 104)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(537, 25)
        Label42.TabIndex = 3
        Label42.Text = "___________________________________________________________________________"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabActivity)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
        ' 
        ' tabActivity
        ' 
        tabActivity.Appearance = TabAppearance.Buttons
        tabActivity.Controls.Add(tabActivityList)
        tabActivity.Controls.Add(tabActivityEnrollment)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(3, 3)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1506, 611)
        tabActivity.TabIndex = 1
        ' 
        ' tabActivityEnrollment
        ' 
        tabActivityEnrollment.Controls.Add(Panel5)
        tabActivityEnrollment.Controls.Add(Panel6)
        tabActivityEnrollment.Location = New Point(4, 41)
        tabActivityEnrollment.Name = "tabActivityEnrollment"
        tabActivityEnrollment.Size = New Size(1498, 566)
        tabActivityEnrollment.TabIndex = 1
        tabActivityEnrollment.Text = "Activity Enrollment"
        tabActivityEnrollment.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 39)
        Label1.TabIndex = 0
        Label1.Text = "Activity"
        ' 
        ' LayoutStudentActivity
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 943)
        Controls.Add(pnlProfile)
        FormBorderStyle = FormBorderStyle.None
        Name = "LayoutStudentActivity"
        Text = "LayoutStudentActivity"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabActivityEnrollment.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnDeleteActivity As Button
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFacultyAdviser As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtActivityType As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstActivityList As ListView
    Friend WithEvents btnEnroll As Button
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tabActivity As TabControl
    Friend WithEvents tabActivityEnrollment As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblContact As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxStatus As ComboBox
End Class
