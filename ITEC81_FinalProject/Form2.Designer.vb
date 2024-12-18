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
        btnAddNewActivity = New Button()
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
        lstActivityList = New ListView()
        Panel4.SuspendLayout()
        pnlProfile.SuspendLayout()
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
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 39)
        Label1.TabIndex = 0
        Label1.Text = "Activity"
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
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstActivityList)
        Panel4.Controls.Add(btnAddNewActivity)
        Panel4.Location = New Point(17, 133)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1577, 411)
        Panel4.TabIndex = 1
        ' 
        ' btnAddNewActivity
        ' 
        btnAddNewActivity.BackColor = Color.Transparent
        btnAddNewActivity.FlatAppearance.BorderColor = Color.LightGray
        btnAddNewActivity.FlatAppearance.MouseOverBackColor = Color.Brown
        btnAddNewActivity.FlatStyle = FlatStyle.Popup
        btnAddNewActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddNewActivity.ForeColor = Color.Black
        btnAddNewActivity.Location = New Point(654, 355)
        btnAddNewActivity.Margin = New Padding(4)
        btnAddNewActivity.Name = "btnAddNewActivity"
        btnAddNewActivity.Size = New Size(204, 54)
        btnAddNewActivity.TabIndex = 18
        btnAddNewActivity.Text = "Add New Activity"
        btnAddNewActivity.UseVisualStyleBackColor = False
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
        pnlProfile.TabIndex = 1
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
        tabActivity.Controls.Add(tabManageActivity)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(3, 3)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1506, 611)
        tabActivity.TabIndex = 1
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
        ' tabManageActivity
        ' 
        tabManageActivity.Controls.Add(Panel5)
        tabManageActivity.Controls.Add(Panel6)
        tabManageActivity.Location = New Point(4, 41)
        tabManageActivity.Name = "tabManageActivity"
        tabManageActivity.Size = New Size(1498, 566)
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
        Panel5.Location = New Point(17, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1465, 411)
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
        btnDeleteActivity.Location = New Point(739, 253)
        btnDeleteActivity.Margin = New Padding(4)
        btnDeleteActivity.Name = "btnDeleteActivity"
        btnDeleteActivity.Size = New Size(204, 54)
        btnDeleteActivity.TabIndex = 34
        btnDeleteActivity.Text = "Delete Activity"
        btnDeleteActivity.UseVisualStyleBackColor = False
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
        ' btnEditActivity
        ' 
        btnEditActivity.BackColor = Color.Transparent
        btnEditActivity.FlatAppearance.BorderColor = Color.LightGray
        btnEditActivity.FlatAppearance.MouseOverBackColor = Color.Brown
        btnEditActivity.FlatStyle = FlatStyle.Popup
        btnEditActivity.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditActivity.ForeColor = Color.Black
        btnEditActivity.Location = New Point(506, 253)
        btnEditActivity.Margin = New Padding(4)
        btnEditActivity.Name = "btnEditActivity"
        btnEditActivity.Size = New Size(204, 54)
        btnEditActivity.TabIndex = 33
        btnEditActivity.Text = "Edit Activity"
        btnEditActivity.UseVisualStyleBackColor = False
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
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.FlatAppearance.BorderColor = Color.LightGray
        btnClear.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Gainsboro
        btnClear.ImageAlign = ContentAlignment.MiddleRight
        btnClear.Location = New Point(634, 333)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(204, 54)
        btnClear.TabIndex = 32
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
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
        Label27.ImageAlign = ContentAlignment.MiddleLeft
        Label27.Location = New Point(24, 18)
        Label27.Name = "Label27"
        Label27.Size = New Size(532, 43)
        Label27.TabIndex = 0
        Label27.Text = "   Create/Modify/Delete Activity"
        ' 
        ' lstActivityList
        ' 
        lstActivityList.Location = New Point(-2, -2)
        lstActivityList.Name = "lstActivityList"
        lstActivityList.Size = New Size(1465, 335)
        lstActivityList.TabIndex = 19
        lstActivityList.UseCompatibleStateImageBehavior = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1565, 958)
        Controls.Add(pnlProfile)
        Name = "Form2"
        Text = "Form2"
        Panel4.ResumeLayout(False)
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
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
