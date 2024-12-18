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
        tabRatings = New TabControl()
        tabActivityList = New TabPage()
        Panel4 = New Panel()
        lstActivityList = New ListView()
        Panel3 = New Panel()
        Label12 = New Label()
        tabMyActivityRatings = New TabPage()
        Panel5 = New Panel()
        Label3 = New Label()
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
        pnlRatings = New Panel()
        btnCancel = New Button()
        btnSubmit = New Button()
        dtpRatingDate = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        txtComments = New TextBox()
        Label2 = New Label()
        txtRatingID = New TextBox()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        txtActivityID = New TextBox()
        txtStudentID = New TextBox()
        nudRating = New NumericUpDown()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        tabRatings.SuspendLayout()
        tabActivityList.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        tabMyActivityRatings.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        pnlRatings.SuspendLayout()
        CType(nudRating, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabRatings)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
        ' 
        ' tabRatings
        ' 
        tabRatings.Appearance = TabAppearance.Buttons
        tabRatings.Controls.Add(tabActivityList)
        tabRatings.Controls.Add(tabMyActivityRatings)
        tabRatings.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabRatings.Location = New Point(3, 3)
        tabRatings.Name = "tabRatings"
        tabRatings.SelectedIndex = 0
        tabRatings.Size = New Size(1506, 611)
        tabRatings.TabIndex = 2
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
        ' tabMyActivityRatings
        ' 
        tabMyActivityRatings.Controls.Add(Panel1)
        tabMyActivityRatings.Controls.Add(Panel5)
        tabMyActivityRatings.Location = New Point(4, 41)
        tabMyActivityRatings.Name = "tabMyActivityRatings"
        tabMyActivityRatings.Size = New Size(1498, 566)
        tabMyActivityRatings.TabIndex = 2
        tabMyActivityRatings.Text = "My Activity Ratings"
        tabMyActivityRatings.UseVisualStyleBackColor = True
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
        Label3.Size = New Size(493, 43)
        Label3.TabIndex = 0
        Label3.Text = "   My Activity Ratings"
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
        ' pnlRatings
        ' 
        pnlRatings.AutoSize = True
        pnlRatings.BorderStyle = BorderStyle.Fixed3D
        pnlRatings.Controls.Add(Panel11)
        pnlRatings.Controls.Add(Panel2)
        pnlRatings.Controls.Add(Label1)
        pnlRatings.Location = New Point(-9, -8)
        pnlRatings.Margin = New Padding(4)
        pnlRatings.Name = "pnlRatings"
        pnlRatings.Size = New Size(1564, 959)
        pnlRatings.TabIndex = 4
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DodgerBlue
        btnCancel.FlatAppearance.BorderColor = Color.LightGray
        btnCancel.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.Gainsboro
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(734, 321)
        btnCancel.Margin = New Padding(4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(204, 54)
        btnCancel.TabIndex = 55
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Transparent
        btnSubmit.FlatAppearance.BorderColor = Color.LightGray
        btnSubmit.FlatAppearance.MouseOverBackColor = Color.Brown
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(483, 321)
        btnSubmit.Margin = New Padding(4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(204, 54)
        btnSubmit.TabIndex = 54
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' dtpRatingDate
        ' 
        dtpRatingDate.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpRatingDate.Location = New Point(959, 246)
        dtpRatingDate.Name = "dtpRatingDate"
        dtpRatingDate.Size = New Size(408, 32)
        dtpRatingDate.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label5.Location = New Point(788, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 29)
        Label5.TabIndex = 52
        Label5.Text = "Rating Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label4.Location = New Point(788, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 29)
        Label4.TabIndex = 51
        Label4.Text = "Comments:"
        ' 
        ' txtComments
        ' 
        txtComments.Font = New Font("Tahoma", 10F)
        txtComments.Location = New Point(959, 128)
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(426, 98)
        txtComments.TabIndex = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label2.Location = New Point(838, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 29)
        Label2.TabIndex = 49
        Label2.Text = "Rating:"
        ' 
        ' txtRatingID
        ' 
        txtRatingID.Enabled = False
        txtRatingID.Font = New Font("Tahoma", 10F)
        txtRatingID.Location = New Point(261, 71)
        txtRatingID.Name = "txtRatingID"
        txtRatingID.Size = New Size(426, 32)
        txtRatingID.TabIndex = 46
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label23.Location = New Point(104, 74)
        Label23.Name = "Label23"
        Label23.Size = New Size(137, 29)
        Label23.TabIndex = 43
        Label23.Text = "Rating ID:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label22.Location = New Point(92, 131)
        Label22.Name = "Label22"
        Label22.Size = New Size(150, 29)
        Label22.TabIndex = 44
        Label22.Text = "Activity ID:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        Label21.Location = New Point(90, 194)
        Label21.Name = "Label21"
        Label21.Size = New Size(153, 29)
        Label21.TabIndex = 45
        Label21.Text = "Student ID:"
        ' 
        ' txtActivityID
        ' 
        txtActivityID.Enabled = False
        txtActivityID.Font = New Font("Tahoma", 10F)
        txtActivityID.Location = New Point(261, 131)
        txtActivityID.Name = "txtActivityID"
        txtActivityID.Size = New Size(426, 32)
        txtActivityID.TabIndex = 47
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Enabled = False
        txtStudentID.Font = New Font("Tahoma", 10F)
        txtStudentID.Location = New Point(261, 194)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(426, 32)
        txtStudentID.TabIndex = 48
        ' 
        ' nudRating
        ' 
        nudRating.Font = New Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudRating.Location = New Point(959, 66)
        nudRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudRating.Name = "nudRating"
        nudRating.Size = New Size(63, 32)
        nudRating.TabIndex = 42
        nudRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtActivityID)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(nudRating)
        Panel1.Controls.Add(btnSubmit)
        Panel1.Controls.Add(txtStudentID)
        Panel1.Controls.Add(dtpRatingDate)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(txtComments)
        Panel1.Controls.Add(txtRatingID)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(20, 125)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1448, 426)
        Panel1.TabIndex = 56
        ' 
        ' LayoutStudentRatings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1547, 943)
        Controls.Add(pnlRatings)
        FormBorderStyle = FormBorderStyle.None
        Name = "LayoutStudentRatings"
        Text = "LayoutStudentRatings"
        Panel2.ResumeLayout(False)
        tabRatings.ResumeLayout(False)
        tabActivityList.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        tabMyActivityRatings.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        pnlRatings.ResumeLayout(False)
        pnlRatings.PerformLayout()
        CType(nudRating, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents pnlRatings As Panel
    Friend WithEvents tabRatings As TabControl
    Friend WithEvents tabActivityList As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstActivityList As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabMyActivityRatings As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtActivityID As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents nudRating As NumericUpDown
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents dtpRatingDate As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents txtRatingID As TextBox
    Friend WithEvents Label2 As Label
End Class
