<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RatingLayoutAdmin
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
        Panel4 = New Panel()
        lstRatingsList = New ListView()
        btnViewDetails = New Button()
        Panel3 = New Panel()
        Label12 = New Label()
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
        tabStudentRatingsList = New TabPage()
        Label1 = New Label()
        tabOverview = New TabPage()
        Panel5 = New Panel()
        Label13 = New Label()
        Panel6 = New Panel()
        ListView1 = New ListView()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        pnlProfile.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        tabActivity.SuspendLayout()
        tabStudentRatingsList.SuspendLayout()
        tabOverview.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstRatingsList)
        Panel4.Controls.Add(btnViewDetails)
        Panel4.Location = New Point(17, 133)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1465, 411)
        Panel4.TabIndex = 1
        ' 
        ' lstRatingsList
        ' 
        lstRatingsList.Location = New Point(-2, -2)
        lstRatingsList.Name = "lstRatingsList"
        lstRatingsList.Size = New Size(1465, 335)
        lstRatingsList.TabIndex = 19
        lstRatingsList.UseCompatibleStateImageBehavior = False
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.Transparent
        btnViewDetails.FlatAppearance.BorderColor = Color.LightGray
        btnViewDetails.FlatAppearance.MouseOverBackColor = Color.Brown
        btnViewDetails.FlatStyle = FlatStyle.Popup
        btnViewDetails.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewDetails.ForeColor = Color.Black
        btnViewDetails.Location = New Point(628, 343)
        btnViewDetails.Margin = New Padding(4)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(204, 54)
        btnViewDetails.TabIndex = 18
        btnViewDetails.Text = "View Ratings Details"
        btnViewDetails.UseVisualStyleBackColor = False
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
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(24, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(463, 43)
        Label12.TabIndex = 0
        Label12.Text = "   Students' Ratings List"
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
        Panel2.Controls.Add(tabActivity)
        Panel2.Location = New Point(26, 319)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1512, 617)
        Panel2.TabIndex = 1
        ' 
        ' tabActivity
        ' 
        tabActivity.Appearance = TabAppearance.Buttons
        tabActivity.Controls.Add(tabStudentRatingsList)
        tabActivity.Controls.Add(tabOverview)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(3, 3)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1506, 611)
        tabActivity.TabIndex = 1
        ' 
        ' tabStudentRatingsList
        ' 
        tabStudentRatingsList.Controls.Add(Panel4)
        tabStudentRatingsList.Controls.Add(Panel3)
        tabStudentRatingsList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabStudentRatingsList.Location = New Point(4, 41)
        tabStudentRatingsList.Name = "tabStudentRatingsList"
        tabStudentRatingsList.Padding = New Padding(3)
        tabStudentRatingsList.Size = New Size(1498, 566)
        tabStudentRatingsList.TabIndex = 0
        tabStudentRatingsList.Text = "Ratings List"
        tabStudentRatingsList.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 39)
        Label1.TabIndex = 0
        Label1.Text = "Ratings"
        ' 
        ' tabOverview
        ' 
        tabOverview.Controls.Add(Panel6)
        tabOverview.Controls.Add(Panel5)
        tabOverview.Location = New Point(4, 41)
        tabOverview.Name = "tabOverview"
        tabOverview.Size = New Size(1498, 566)
        tabOverview.TabIndex = 1
        tabOverview.Text = "Overview"
        tabOverview.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Firebrick
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Label13)
        Panel5.ForeColor = Color.White
        Panel5.Location = New Point(18, 22)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1465, 91)
        Panel5.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(24, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(463, 43)
        Label13.TabIndex = 0
        Label13.Text = "   Overview"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(ListView1)
        Panel6.Location = New Point(18, 133)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1465, 411)
        Panel6.TabIndex = 2
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(-2, -2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1465, 406)
        ListView1.TabIndex = 19
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' RatingLayoutAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1565, 958)
        Controls.Add(pnlProfile)
        Name = "RatingLayoutAdmin"
        Text = "RatingLayoutAdmin"
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabStudentRatingsList.ResumeLayout(False)
        tabOverview.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstRatingsList As ListView
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
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
    Friend WithEvents tabStudentRatingsList As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
End Class
