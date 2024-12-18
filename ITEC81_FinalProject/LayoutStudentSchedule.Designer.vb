<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LayoutStudentSchedule
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
        pnlSchedule = New Panel()
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
        tabSchedule = New TabControl()
        tabOngoingActivities = New TabPage()
        Panel5 = New Panel()
        lstOngoingActivities = New ListView()
        Panel6 = New Panel()
        Label27 = New Label()
        tabCompletedActivities = New TabPage()
        Panel7 = New Panel()
        lstCompletedActivities = New ListView()
        Panel8 = New Panel()
        Label13 = New Label()
        tabUpcomingActivities = New TabPage()
        Panel9 = New Panel()
        lstUpcomingActivities = New ListView()
        Panel10 = New Panel()
        Label14 = New Label()
        Label1 = New Label()
        pnlSchedule.SuspendLayout()
        Panel11.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        tabSchedule.SuspendLayout()
        tabOngoingActivities.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        tabCompletedActivities.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        tabUpcomingActivities.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSchedule
        ' 
        pnlSchedule.AutoSize = True
        pnlSchedule.BorderStyle = BorderStyle.Fixed3D
        pnlSchedule.Controls.Add(Panel11)
        pnlSchedule.Controls.Add(Panel2)
        pnlSchedule.Controls.Add(Label1)
        pnlSchedule.Location = New Point(-9, -8)
        pnlSchedule.Margin = New Padding(4)
        pnlSchedule.Name = "pnlSchedule"
        pnlSchedule.Size = New Size(1564, 959)
        pnlSchedule.TabIndex = 3
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
        Panel2.Controls.Add(tabSchedule)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
        ' 
        ' tabSchedule
        ' 
        tabSchedule.Appearance = TabAppearance.Buttons
        tabSchedule.Controls.Add(tabOngoingActivities)
        tabSchedule.Controls.Add(tabCompletedActivities)
        tabSchedule.Controls.Add(tabUpcomingActivities)
        tabSchedule.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabSchedule.Location = New Point(3, 3)
        tabSchedule.Name = "tabSchedule"
        tabSchedule.SelectedIndex = 0
        tabSchedule.Size = New Size(1506, 611)
        tabSchedule.TabIndex = 2
        ' 
        ' tabOngoingActivities
        ' 
        tabOngoingActivities.Controls.Add(Panel5)
        tabOngoingActivities.Controls.Add(Panel6)
        tabOngoingActivities.Location = New Point(4, 41)
        tabOngoingActivities.Name = "tabOngoingActivities"
        tabOngoingActivities.Size = New Size(1498, 566)
        tabOngoingActivities.TabIndex = 1
        tabOngoingActivities.Text = "Ongoing Activities"
        tabOngoingActivities.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(lstOngoingActivities)
        Panel5.Location = New Point(17, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1465, 411)
        Panel5.TabIndex = 3
        ' 
        ' lstOngoingActivities
        ' 
        lstOngoingActivities.Location = New Point(0, -2)
        lstOngoingActivities.Name = "lstOngoingActivities"
        lstOngoingActivities.Size = New Size(1458, 411)
        lstOngoingActivities.TabIndex = 0
        lstOngoingActivities.UseCompatibleStateImageBehavior = False
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
        Label27.Image = My.Resources.Resources.icons8_info_22
        Label27.ImageAlign = ContentAlignment.MiddleLeft
        Label27.Location = New Point(24, 18)
        Label27.Name = "Label27"
        Label27.Size = New Size(532, 43)
        Label27.TabIndex = 0
        Label27.Text = "   Ongoing Activities"
        ' 
        ' tabCompletedActivities
        ' 
        tabCompletedActivities.Controls.Add(Panel7)
        tabCompletedActivities.Controls.Add(Panel8)
        tabCompletedActivities.Location = New Point(4, 41)
        tabCompletedActivities.Name = "tabCompletedActivities"
        tabCompletedActivities.Size = New Size(1498, 566)
        tabCompletedActivities.TabIndex = 2
        tabCompletedActivities.Text = "Completed Activities"
        tabCompletedActivities.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(lstCompletedActivities)
        Panel7.Location = New Point(17, 135)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1465, 411)
        Panel7.TabIndex = 5
        ' 
        ' lstCompletedActivities
        ' 
        lstCompletedActivities.Location = New Point(0, -2)
        lstCompletedActivities.Name = "lstCompletedActivities"
        lstCompletedActivities.Size = New Size(1458, 411)
        lstCompletedActivities.TabIndex = 0
        lstCompletedActivities.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.DodgerBlue
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(Label13)
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(17, 21)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1465, 91)
        Panel8.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Image = My.Resources.Resources.icons8_info_22
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(24, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(532, 43)
        Label13.TabIndex = 0
        Label13.Text = "   Completed Activities"
        ' 
        ' tabUpcomingActivities
        ' 
        tabUpcomingActivities.Controls.Add(Panel9)
        tabUpcomingActivities.Controls.Add(Panel10)
        tabUpcomingActivities.Location = New Point(4, 41)
        tabUpcomingActivities.Name = "tabUpcomingActivities"
        tabUpcomingActivities.Size = New Size(1498, 566)
        tabUpcomingActivities.TabIndex = 3
        tabUpcomingActivities.Text = "Upcoming Activities"
        tabUpcomingActivities.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Controls.Add(lstUpcomingActivities)
        Panel9.Location = New Point(17, 135)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(1465, 411)
        Panel9.TabIndex = 5
        ' 
        ' lstUpcomingActivities
        ' 
        lstUpcomingActivities.Location = New Point(0, -2)
        lstUpcomingActivities.Name = "lstUpcomingActivities"
        lstUpcomingActivities.Size = New Size(1458, 411)
        lstUpcomingActivities.TabIndex = 0
        lstUpcomingActivities.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.DodgerBlue
        Panel10.BorderStyle = BorderStyle.Fixed3D
        Panel10.Controls.Add(Label14)
        Panel10.ForeColor = Color.White
        Panel10.Location = New Point(17, 21)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1465, 91)
        Panel10.TabIndex = 4
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Image = My.Resources.Resources.icons8_info_22
        Label14.ImageAlign = ContentAlignment.MiddleLeft
        Label14.Location = New Point(24, 18)
        Label14.Name = "Label14"
        Label14.Size = New Size(532, 43)
        Label14.TabIndex = 0
        Label14.Text = "   Upcoming Activities"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 39)
        Label1.TabIndex = 0
        Label1.Text = "Schedule"
        ' 
        ' LayoutStudentSchedule
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 943)
        Controls.Add(pnlSchedule)
        FormBorderStyle = FormBorderStyle.None
        Name = "LayoutStudentSchedule"
        Text = "LayoutStudentSchedule"
        pnlSchedule.ResumeLayout(False)
        pnlSchedule.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        tabSchedule.ResumeLayout(False)
        tabOngoingActivities.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        tabCompletedActivities.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        tabUpcomingActivities.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSchedule As Panel
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tabSchedule As TabControl
    Friend WithEvents tabOngoingActivities As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lstOngoingActivities As ListView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents tabCompletedActivities As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lstCompletedActivities As ListView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents tabUpcomingActivities As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lstUpcomingActivities As ListView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label14 As Label
End Class
