<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleCalendarLayout
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
        tabSchedule = New TabControl()
        tabCalendarofActivities = New TabPage()
        Panel4 = New Panel()
        MonthCalendar1 = New MonthCalendar()
        lslCalendarofActivities = New ListView()
        Panel3 = New Panel()
        Label12 = New Label()
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
        Label1 = New Label()
        Panel2 = New Panel()
        pnlProfile = New Panel()
        tabSchedule.SuspendLayout()
        tabCalendarofActivities.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        tabOngoingActivities.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        tabCompletedActivities.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        tabUpcomingActivities.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        pnlProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabSchedule
        ' 
        tabSchedule.Appearance = TabAppearance.Buttons
        tabSchedule.Controls.Add(tabCalendarofActivities)
        tabSchedule.Controls.Add(tabOngoingActivities)
        tabSchedule.Controls.Add(tabCompletedActivities)
        tabSchedule.Controls.Add(tabUpcomingActivities)
        tabSchedule.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabSchedule.Location = New Point(3, 3)
        tabSchedule.Name = "tabSchedule"
        tabSchedule.SelectedIndex = 0
        tabSchedule.Size = New Size(1506, 611)
        tabSchedule.TabIndex = 1
        ' 
        ' tabCalendarofActivities
        ' 
        tabCalendarofActivities.Controls.Add(Panel4)
        tabCalendarofActivities.Controls.Add(Panel3)
        tabCalendarofActivities.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabCalendarofActivities.Location = New Point(4, 41)
        tabCalendarofActivities.Name = "tabCalendarofActivities"
        tabCalendarofActivities.Padding = New Padding(3)
        tabCalendarofActivities.Size = New Size(1498, 566)
        tabCalendarofActivities.TabIndex = 0
        tabCalendarofActivities.Text = "Calendar of Activities"
        tabCalendarofActivities.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(MonthCalendar1)
        Panel4.Controls.Add(lslCalendarofActivities)
        Panel4.Location = New Point(17, 133)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1577, 411)
        Panel4.TabIndex = 1
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MonthCalendar1.Location = New Point(87, 91)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 1
        ' 
        ' lslCalendarofActivities
        ' 
        lslCalendarofActivities.Location = New Point(496, -2)
        lslCalendarofActivities.Name = "lslCalendarofActivities"
        lslCalendarofActivities.Size = New Size(967, 411)
        lslCalendarofActivities.TabIndex = 0
        lslCalendarofActivities.UseCompatibleStateImageBehavior = False
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
        Label12.Image = My.Resources.Resources.icons8_info_22
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(24, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(460, 43)
        Label12.TabIndex = 0
        Label12.Text = "   Calendar of Activities"
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
        Panel8.BackColor = Color.Firebrick
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
        Panel10.BackColor = Color.Firebrick
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
        Label3.Size = New Size(198, 29)
        Label3.TabIndex = 2
        Label3.Text = "ADMINISTRATOR"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 39)
        Label1.TabIndex = 0
        Label1.Text = "Schedule"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabSchedule)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
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
        pnlProfile.TabIndex = 3
        ' 
        ' ScheduleCalendarLayout
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1565, 958)
        Controls.Add(pnlProfile)
        Name = "ScheduleCalendarLayout"
        Text = "ScheduleCalendarLayout"
        tabSchedule.ResumeLayout(False)
        tabCalendarofActivities.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabOngoingActivities.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        tabCompletedActivities.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        tabUpcomingActivities.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tabSchedule As TabControl
    Friend WithEvents tabCalendarofActivities As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabOngoingActivities As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label27 As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents tabCompletedActivities As TabPage
    Friend WithEvents tabUpcomingActivities As TabPage
    Friend WithEvents lslCalendarofActivities As ListView
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lstOngoingActivities As ListView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lstCompletedActivities As ListView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lstUpcomingActivities As ListView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label14 As Label
End Class
