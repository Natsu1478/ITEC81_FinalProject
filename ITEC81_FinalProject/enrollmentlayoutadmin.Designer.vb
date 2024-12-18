<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrollmentlayoutadmin
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
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        txtActivityName = New TextBox()
        btnChangeStatus = New Button()
        Label23 = New Label()
        btnCancel = New Button()
        Label22 = New Label()
        dtpEndDate = New DateTimePicker()
        Label21 = New Label()
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
        tabEnrollmentList = New TabPage()
        Panel4 = New Panel()
        lstEnrollmentList = New ListBox()
        Label1 = New Label()
        pnlProfile = New Panel()
        Panel1 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Panel2 = New Panel()
        tabEnrollment = New TabControl()
        tabManageEnrollees = New TabPage()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        tabEnrollmentList.SuspendLayout()
        Panel4.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        tabEnrollment.SuspendLayout()
        tabManageEnrollees.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(ComboBox1)
        Panel5.Controls.Add(TextBox3)
        Panel5.Controls.Add(TextBox1)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(txtActivityName)
        Panel5.Controls.Add(btnChangeStatus)
        Panel5.Controls.Add(Label23)
        Panel5.Controls.Add(btnCancel)
        Panel5.Controls.Add(Label22)
        Panel5.Controls.Add(dtpEndDate)
        Panel5.Controls.Add(Label21)
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
        ' ComboBox1
        ' 
        ComboBox1.Enabled = False
        ComboBox1.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Active", "Completed", "Withdrawn"})
        ComboBox1.Location = New Point(954, 247)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(428, 32)
        ComboBox1.TabIndex = 39
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Tahoma", 10F)
        TextBox3.Location = New Point(956, 121)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(426, 32)
        TextBox3.TabIndex = 38
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Tahoma", 10F)
        TextBox1.Location = New Point(284, 250)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(426, 32)
        TextBox1.TabIndex = 35
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label13.Location = New Point(171, 252)
        Label13.Name = "Label13"
        Label13.Size = New Size(115, 29)
        Label13.TabIndex = 34
        Label13.Text = "Gender: "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label14.Location = New Point(850, 248)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 29)
        Label14.TabIndex = 36
        Label14.Text = "Status: "
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
        ' btnChangeStatus
        ' 
        btnChangeStatus.BackColor = Color.Transparent
        btnChangeStatus.FlatAppearance.BorderColor = Color.LightGray
        btnChangeStatus.FlatAppearance.MouseOverBackColor = Color.Brown
        btnChangeStatus.FlatStyle = FlatStyle.Popup
        btnChangeStatus.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChangeStatus.ForeColor = Color.Black
        btnChangeStatus.Location = New Point(506, 333)
        btnChangeStatus.Margin = New Padding(4)
        btnChangeStatus.Name = "btnChangeStatus"
        btnChangeStatus.Size = New Size(204, 54)
        btnChangeStatus.TabIndex = 33
        btnChangeStatus.Text = "Change Status"
        btnChangeStatus.UseVisualStyleBackColor = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label23.Location = New Point(88, 70)
        Label23.Name = "Label23"
        Label23.Size = New Size(198, 29)
        Label23.TabIndex = 20
        Label23.Text = "Enrollment_ID:"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Brown
        btnCancel.FlatAppearance.BorderColor = Color.LightGray
        btnCancel.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Gainsboro
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(739, 333)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(204, 54)
        btnCancel.TabIndex = 32
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(24, 124)
        Label22.Name = "Label22"
        Label22.Size = New Size(262, 29)
        Label22.TabIndex = 21
        Label22.Text = "Student's Full Name:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Enabled = False
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
        Label21.Location = New Point(175, 190)
        Label21.Name = "Label21"
        Label21.Size = New Size(111, 29)
        Label21.TabIndex = 22
        Label21.Text = "Course: "
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label20.Location = New Point(753, 64)
        Label20.Name = "Label20"
        Label20.Size = New Size(190, 29)
        Label20.TabIndex = 23
        Label20.Text = "Activity Name:"
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
        Label19.Location = New Point(732, 190)
        Label19.Name = "Label19"
        Label19.Size = New Size(223, 29)
        Label19.TabIndex = 24
        Label19.Text = "Enrollment Date: "
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label16.Location = New Point(739, 127)
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
        Panel6.BackColor = Color.Firebrick
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
        Label27.Image = My.Resources.Resources.icons8_info_22
        Label27.ImageAlign = ContentAlignment.MiddleLeft
        Label27.Location = New Point(24, 18)
        Label27.Name = "Label27"
        Label27.Size = New Size(532, 43)
        Label27.TabIndex = 0
        Label27.Text = "   Manage Enrollee's Status"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Firebrick
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
        Label12.Image = My.Resources.Resources.icons8_list_25__1_
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(24, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(389, 43)
        Label12.TabIndex = 0
        Label12.Text = "   Enrollment List"
        ' 
        ' tabEnrollmentList
        ' 
        tabEnrollmentList.Controls.Add(Panel4)
        tabEnrollmentList.Controls.Add(Panel3)
        tabEnrollmentList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabEnrollmentList.Location = New Point(4, 41)
        tabEnrollmentList.Name = "tabEnrollmentList"
        tabEnrollmentList.Padding = New Padding(3)
        tabEnrollmentList.Size = New Size(1498, 566)
        tabEnrollmentList.TabIndex = 0
        tabEnrollmentList.Text = "Enrollment List"
        tabEnrollmentList.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstEnrollmentList)
        Panel4.Location = New Point(17, 133)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1577, 411)
        Panel4.TabIndex = 1
        ' 
        ' lstEnrollmentList
        ' 
        lstEnrollmentList.Font = New Font("Franklin Gothic Book", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstEnrollmentList.FormattingEnabled = True
        lstEnrollmentList.ItemHeight = 25
        lstEnrollmentList.Location = New Point(-5, -2)
        lstEnrollmentList.Name = "lstEnrollmentList"
        lstEnrollmentList.Size = New Size(1481, 429)
        lstEnrollmentList.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 39)
        Label1.TabIndex = 0
        Label1.Text = "Enrollment"
        ' 
        ' pnlProfile
        ' 
        pnlProfile.AutoSize = True
        pnlProfile.BorderStyle = BorderStyle.Fixed3D
        pnlProfile.Controls.Add(Panel1)
        pnlProfile.Controls.Add(Panel2)
        pnlProfile.Controls.Add(Label1)
        pnlProfile.Location = New Point(0, 0)
        pnlProfile.Margin = New Padding(4)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1564, 959)
        pnlProfile.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.Gainsboro
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(26, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1512, 241)
        Panel1.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoEllipsis = True
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(998, 192)
        Label11.Name = "Label11"
        Label11.RightToLeft = RightToLeft.No
        Label11.Size = New Size(144, 27)
        Label11.TabIndex = 10
        Label11.Text = "09123456789"
        ' 
        ' Label10
        ' 
        Label10.AutoEllipsis = True
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ImageAlign = ContentAlignment.MiddleLeft
        Label10.Location = New Point(998, 52)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.No
        Label10.Size = New Size(283, 27)
        Label10.TabIndex = 9
        Label10.Text = "School Of Computer Studies"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ImageAlign = ContentAlignment.MiddleLeft
        Label9.Location = New Point(906, 180)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.No
        Label9.Size = New Size(0, 27)
        Label9.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoEllipsis = True
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ImageAlign = ContentAlignment.MiddleLeft
        Label8.Location = New Point(998, 121)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.No
        Label8.Size = New Size(419, 27)
        Label8.TabIndex = 7
        Label8.Text = "glevenn@citycollegeoftagaytaycity.edu.ph"
        ' 
        ' Label7
        ' 
        Label7.AutoEllipsis = True
        Label7.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label7.Image = My.Resources.Resources.icons8_phone_number_20
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(998, 161)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(237, 27)
        Label7.TabIndex = 6
        Label7.Text = "     Contact Number: "
        ' 
        ' Label6
        ' 
        Label6.AutoEllipsis = True
        Label6.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label6.Image = My.Resources.Resources.icons8_email_18
        Label6.ImageAlign = ContentAlignment.MiddleLeft
        Label6.Location = New Point(998, 90)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(212, 27)
        Label6.TabIndex = 5
        Label6.Text = "     Email Address: "
        ' 
        ' Label5
        ' 
        Label5.AutoEllipsis = True
        Label5.Font = New Font("Tahoma", 11F, FontStyle.Bold)
        Label5.Image = My.Resources.Resources.icons8_unit_18
        Label5.ImageAlign = ContentAlignment.MiddleLeft
        Label5.Location = New Point(998, 22)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.No
        Label5.Size = New Size(189, 27)
        Label5.TabIndex = 4
        Label5.Text = "     Department: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(283, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(510, 29)
        Label3.TabIndex = 2
        Label3.Text = "Bachelor of Science In Information Technology"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(283, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(360, 48)
        Label2.TabIndex = 1
        Label2.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox1.Location = New Point(35, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkOrange
        Label4.Location = New Point(283, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(537, 25)
        Label4.TabIndex = 3
        Label4.Text = "___________________________________________________________________________"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabEnrollment)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
        ' 
        ' tabEnrollment
        ' 
        tabEnrollment.Appearance = TabAppearance.Buttons
        tabEnrollment.Controls.Add(tabEnrollmentList)
        tabEnrollment.Controls.Add(tabManageEnrollees)
        tabEnrollment.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabEnrollment.Location = New Point(3, 3)
        tabEnrollment.Name = "tabEnrollment"
        tabEnrollment.SelectedIndex = 0
        tabEnrollment.Size = New Size(1506, 611)
        tabEnrollment.TabIndex = 1
        ' 
        ' tabManageEnrollees
        ' 
        tabManageEnrollees.Controls.Add(Panel5)
        tabManageEnrollees.Controls.Add(Panel6)
        tabManageEnrollees.Location = New Point(4, 41)
        tabManageEnrollees.Name = "tabManageEnrollees"
        tabManageEnrollees.Size = New Size(1498, 566)
        tabManageEnrollees.TabIndex = 1
        tabManageEnrollees.Text = "Manage Enrollees"
        tabManageEnrollees.UseVisualStyleBackColor = True
        ' 
        ' enrollmentlayoutadmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1565, 958)
        Controls.Add(pnlProfile)
        Name = "enrollmentlayoutadmin"
        Text = "enrollmentlayoutadmin"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabEnrollmentList.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        tabEnrollment.ResumeLayout(False)
        tabManageEnrollees.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label21 As Label
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
    Friend WithEvents tabEnrollmentList As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstEnrollmentList As ListBox
    Friend WithEvents btnChangeStatus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tabEnrollment As TabControl
    Friend WithEvents tabManageEnrollees As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
