<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label12 = New Label()
        Panel4 = New Panel()
        lstActivityList = New ListView()
        btnAddNewActivity = New Button()
        pnlActivities = New Panel()
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
        tabActivity = New TabControl()
        tabActivityList = New TabPage()
        Panel3 = New Panel()
        tabManageActivity = New TabPage()
        Panel5 = New Panel()
        btnDeleteActivity = New Button()
        txtActivityName = New TextBox()
        btnEditActivity = New Button()
        Label23 = New Label()
        btnClear = New Button()
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
        Panel4.SuspendLayout()
        pnlActivities.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        tabActivity.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel3.SuspendLayout()
        tabManageActivity.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 33)
        Label1.TabIndex = 0
        Label1.Text = "Activity"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(19, 14)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(311, 34)
        Label12.TabIndex = 0
        Label12.Text = "   Activity List"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstActivityList)
        Panel4.Controls.Add(btnAddNewActivity)
        Panel4.Location = New Point(14, 106)
        Panel4.Margin = New Padding(2, 2, 2, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1262, 330)
        Panel4.TabIndex = 1
        ' 
        ' lstActivityList
        ' 
        lstActivityList.Location = New Point(-2, -2)
        lstActivityList.Margin = New Padding(2, 2, 2, 2)
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
        ' pnlActivities
        ' 
        pnlActivities.AutoSize = True
        pnlActivities.BorderStyle = BorderStyle.Fixed3D
        pnlActivities.Controls.Add(Panel1)
        pnlActivities.Controls.Add(Panel2)
        pnlActivities.Controls.Add(Label1)
        pnlActivities.Location = New Point(0, 0)
        pnlActivities.Name = "pnlActivities"
        pnlActivities.Size = New Size(1252, 768)
        pnlActivities.TabIndex = 1
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
        Panel1.Location = New Point(21, 43)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1210, 194)
        Panel1.TabIndex = 1
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(226, 83)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(425, 24)
        Label3.TabIndex = 2
        Label3.Text = "Bachelor of Science In Information Technology"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(226, 30)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 41)
        Label2.TabIndex = 1
        Label2.Text = "Alba, Glerisse Venn"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox1.Location = New Point(28, 15)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 160)
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
        Label4.Location = New Point(226, 58)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(459, 20)
        Label4.TabIndex = 3
        Label4.Text = "___________________________________________________________________________"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabActivity)
        Panel2.Location = New Point(21, 255)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1210, 494)
        Panel2.TabIndex = 1
        ' 
        ' tabActivity
        ' 
        tabActivity.Appearance = TabAppearance.Buttons
        tabActivity.Controls.Add(tabActivityList)
        tabActivity.Controls.Add(tabManageActivity)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(2, 2)
        tabActivity.Margin = New Padding(2, 2, 2, 2)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1205, 489)
        tabActivity.TabIndex = 1
        ' 
        ' tabActivityList
        ' 
        tabActivityList.Controls.Add(Panel4)
        tabActivityList.Controls.Add(Panel3)
        tabActivityList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivityList.Location = New Point(4, 36)
        tabActivityList.Margin = New Padding(2, 2, 2, 2)
        tabActivityList.Name = "tabActivityList"
        tabActivityList.Padding = New Padding(2, 2, 2, 2)
        tabActivityList.Size = New Size(1197, 449)
        tabActivityList.TabIndex = 0
        tabActivityList.Text = "Activity List"
        tabActivityList.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Firebrick
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label12)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(14, 15)
        Panel3.Margin = New Padding(2, 2, 2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1173, 74)
        Panel3.TabIndex = 0
        ' 
        ' tabManageActivity
        ' 
        tabManageActivity.Controls.Add(Panel5)
        tabManageActivity.Controls.Add(Panel6)
        tabManageActivity.Location = New Point(4, 36)
        tabManageActivity.Margin = New Padding(2, 2, 2, 2)
        tabManageActivity.Name = "tabManageActivity"
        tabManageActivity.Size = New Size(1197, 449)
        tabManageActivity.TabIndex = 1
        tabManageActivity.Text = "Manage Activity"
        tabManageActivity.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(btnDeleteActivity)
        Panel5.Controls.Add(txtActivityName)
        Panel5.Controls.Add(btnEditActivity)
        Panel5.Controls.Add(Label23)
        Panel5.Controls.Add(btnClear)
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
        Panel5.Location = New Point(14, 108)
        Panel5.Margin = New Padding(2, 2, 2, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1173, 330)
        Panel5.TabIndex = 3
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
        txtActivityName.Margin = New Padding(2, 2, 2, 2)
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
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label23.Location = New Point(70, 56)
        Label23.Margin = New Padding(2, 0, 2, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(158, 24)
        Label23.TabIndex = 20
        Label23.Text = "Activity Name:"
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
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(80, 102)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(149, 24)
        Label22.TabIndex = 21
        Label22.Text = "Activity Type:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Tahoma", 10F)
        dtpEndDate.Location = New Point(765, 152)
        dtpEndDate.Margin = New Padding(2, 2, 2, 2)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(342, 28)
        dtpEndDate.TabIndex = 31
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label21.Location = New Point(96, 152)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(132, 24)
        Label21.TabIndex = 22
        Label21.Text = "Description:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Tahoma", 10F)
        dtpStartDate.Location = New Point(765, 102)
        dtpStartDate.Margin = New Padding(2, 2, 2, 2)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(342, 28)
        dtpStartDate.TabIndex = 30
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label20.Location = New Point(639, 100)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(120, 24)
        Label20.TabIndex = 23
        Label20.Text = "Start Date:"
        ' 
        ' txtFacultyAdviser
        ' 
        txtFacultyAdviser.Enabled = False
        txtFacultyAdviser.Font = New Font("Tahoma", 10F)
        txtFacultyAdviser.Location = New Point(765, 51)
        txtFacultyAdviser.Margin = New Padding(2, 2, 2, 2)
        txtFacultyAdviser.Name = "txtFacultyAdviser"
        txtFacultyAdviser.Size = New Size(342, 28)
        txtFacultyAdviser.TabIndex = 29
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label19.Location = New Point(650, 157)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(108, 24)
        Label19.TabIndex = 24
        Label19.Text = "End Date:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label16.Location = New Point(586, 56)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(179, 24)
        Label16.TabIndex = 28
        Label16.Text = "Faculty/Adviser:"
        ' 
        ' txtActivityType
        ' 
        txtActivityType.Enabled = False
        txtActivityType.Font = New Font("Tahoma", 10F)
        txtActivityType.Location = New Point(227, 100)
        txtActivityType.Margin = New Padding(2, 2, 2, 2)
        txtActivityType.Name = "txtActivityType"
        txtActivityType.Size = New Size(342, 28)
        txtActivityType.TabIndex = 26
        ' 
        ' txtDescription
        ' 
        txtDescription.Enabled = False
        txtDescription.Font = New Font("Tahoma", 10F)
        txtDescription.Location = New Point(227, 150)
        txtDescription.Margin = New Padding(2, 2, 2, 2)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(342, 28)
        txtDescription.TabIndex = 27
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Firebrick
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(Label27)
        Panel6.ForeColor = Color.White
        Panel6.Location = New Point(14, 17)
        Panel6.Margin = New Padding(2, 2, 2, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1173, 74)
        Panel6.TabIndex = 2
        ' 
        ' Label27
        ' 
        Label27.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ImageAlign = ContentAlignment.MiddleLeft
        Label27.Location = New Point(19, 14)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(426, 34)
        Label27.TabIndex = 0
        Label27.Text = "   Create/Modify/Delete Activity"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 766)
        Controls.Add(pnlActivities)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form2"
        Text = "Form2"
        Panel4.ResumeLayout(False)
        pnlActivities.ResumeLayout(False)
        pnlActivities.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabManageActivity.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlActivities As Panel
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
    Friend WithEvents tabActivity As TabControl
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tabManageActivity As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents btnAddNewActivity As Button
    Friend WithEvents btnEditActivity As Button
    Friend WithEvents btnDeleteActivity As Button
    Friend WithEvents txtActivityName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnClear As Button
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
    Friend WithEvents lstActivityList As ListView
End Class
