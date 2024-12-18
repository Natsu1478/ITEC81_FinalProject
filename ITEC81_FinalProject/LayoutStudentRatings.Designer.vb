<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LayoutStudentRatings
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
        Panel2 = New Panel()
        tabActivity = New TabControl()
        tabActivityList = New TabPage()
        Panel4 = New Panel()
        lstActivityList = New ListView()
        Panel3 = New Panel()
        Label12 = New Label()
        tabEventsList = New TabPage()
        Panel1 = New Panel()
        Label2 = New Label()
        tabMyEventsActivityRatings = New TabPage()
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
        Panel11 = New Panel()
        Label1 = New Label()
        pnlProfile = New Panel()
        ListView1 = New ListView()
        Panel5 = New Panel()
        Label3 = New Label()
        Panel2.SuspendLayout()
        tabActivity.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        tabEventsList.SuspendLayout()
        Panel1.SuspendLayout()
        tabMyEventsActivityRatings.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
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
        tabActivity.Controls.Add(tabEventsList)
        tabActivity.Controls.Add(tabMyEventsActivityRatings)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(3, 3)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1506, 611)
        tabActivity.TabIndex = 2
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
        lstActivityList.Size = New Size(1465, 411)
        lstActivityList.TabIndex = 19
        lstActivityList.UseCompatibleStateImageBehavior = False
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
        ' tabEventsList
        ' 
        tabEventsList.Controls.Add(ListView1)
        tabEventsList.Controls.Add(Panel1)
        tabEventsList.Location = New Point(4, 41)
        tabEventsList.Name = "tabEventsList"
        tabEventsList.Size = New Size(1498, 566)
        tabEventsList.TabIndex = 1
        tabEventsList.Text = "Events List"
        tabEventsList.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label2)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(17, 17)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1465, 91)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(24, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(389, 43)
        Label2.TabIndex = 0
        Label2.Text = "   Events List"
        ' 
        ' tabMyEventsActivityRatings
        ' 
        tabMyEventsActivityRatings.Controls.Add(Panel5)
        tabMyEventsActivityRatings.Location = New Point(4, 41)
        tabMyEventsActivityRatings.Name = "tabMyEventsActivityRatings"
        tabMyEventsActivityRatings.Size = New Size(1498, 566)
        tabMyEventsActivityRatings.TabIndex = 2
        tabMyEventsActivityRatings.Text = "My Activity/Events Ratings"
        tabMyEventsActivityRatings.UseVisualStyleBackColor = True
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 39)
        Label1.TabIndex = 0
        Label1.Text = "Ratings"
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
        pnlProfile.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(17, 132)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1465, 411)
        ListView1.TabIndex = 20
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DodgerBlue
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Label3)
        Panel5.ForeColor = Color.White
        Panel5.Location = New Point(20, 16)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1465, 91)
        Panel5.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ImageAlign = ContentAlignment.MiddleLeft
        Label3.Location = New Point(24, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(389, 43)
        Label3.TabIndex = 0
        Label3.Text = "   My Ratings"
        ' 
        ' LayoutStudentRatings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 943)
        Controls.Add(pnlProfile)
        FormBorderStyle = FormBorderStyle.None
        Name = "LayoutStudentRatings"
        Text = "LayoutStudentRatings"
        Panel2.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabEventsList.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        tabMyEventsActivityRatings.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents tabActivity As TabControl
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstActivityList As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabEventsList As TabPage
    Friend WithEvents tabMyEventsActivityRatings As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
End Class
