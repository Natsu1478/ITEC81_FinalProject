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
        Label1 = New Label()
        Panel2 = New Panel()
        tabActivity = New TabControl()
        tabOverview = New TabPage()
        Panel5 = New Panel()
        Label13 = New Label()
        Panel6 = New Panel()
        ListView1 = New ListView()
        tabStudentRatingsList = New TabPage()
        Panel3 = New Panel()
        Label12 = New Label()
        Panel4 = New Panel()
        btnViewDetails = New Button()
        lstRatingsList = New ListView()
        Panel1 = New Panel()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        pnlProfile = New Panel()
        Panel2.SuspendLayout()
        tabActivity.SuspendLayout()
        tabOverview.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        tabStudentRatingsList.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(21, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 33)
        Label1.TabIndex = 0
        Label1.Text = "Ratings"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(tabActivity)
        Panel2.Location = New Point(21, 255)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1210, 494)
        Panel2.TabIndex = 1
        ' 
        ' tabActivity
        ' 
        tabActivity.Appearance = TabAppearance.Buttons
        tabActivity.Controls.Add(tabStudentRatingsList)
        tabActivity.Controls.Add(tabOverview)
        tabActivity.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabActivity.Location = New Point(2, 2)
        tabActivity.Margin = New Padding(2)
        tabActivity.Name = "tabActivity"
        tabActivity.SelectedIndex = 0
        tabActivity.Size = New Size(1205, 489)
        tabActivity.TabIndex = 1
        ' 
        ' tabOverview
        ' 
        tabOverview.Controls.Add(Panel6)
        tabOverview.Controls.Add(Panel5)
        tabOverview.Location = New Point(4, 36)
        tabOverview.Margin = New Padding(2)
        tabOverview.Name = "tabOverview"
        tabOverview.Size = New Size(1197, 449)
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
        Panel5.Location = New Point(14, 18)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1173, 74)
        Panel5.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(19, 14)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(370, 34)
        Label13.TabIndex = 0
        Label13.Text = "   Overview"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(ListView1)
        Panel6.Location = New Point(14, 106)
        Panel6.Margin = New Padding(2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1173, 330)
        Panel6.TabIndex = 2
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(-2, -2)
        ListView1.Margin = New Padding(2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1173, 326)
        ListView1.TabIndex = 19
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' tabStudentRatingsList
        ' 
        tabStudentRatingsList.Controls.Add(Panel4)
        tabStudentRatingsList.Controls.Add(Panel3)
        tabStudentRatingsList.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabStudentRatingsList.Location = New Point(4, 36)
        tabStudentRatingsList.Margin = New Padding(2)
        tabStudentRatingsList.Name = "tabStudentRatingsList"
        tabStudentRatingsList.Padding = New Padding(2)
        tabStudentRatingsList.Size = New Size(1197, 449)
        tabStudentRatingsList.TabIndex = 0
        tabStudentRatingsList.Text = "Ratings List"
        tabStudentRatingsList.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Firebrick
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label12)
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(14, 15)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1173, 74)
        Panel3.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(19, 14)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(370, 34)
        Label12.TabIndex = 0
        Label12.Text = "   Students' Ratings List"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lstRatingsList)
        Panel4.Controls.Add(btnViewDetails)
        Panel4.Location = New Point(14, 106)
        Panel4.Margin = New Padding(2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1173, 330)
        Panel4.TabIndex = 1
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.Transparent
        btnViewDetails.FlatAppearance.BorderColor = Color.LightGray
        btnViewDetails.FlatAppearance.MouseOverBackColor = Color.Brown
        btnViewDetails.FlatStyle = FlatStyle.Popup
        btnViewDetails.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewDetails.ForeColor = Color.Black
        btnViewDetails.Location = New Point(502, 274)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(163, 43)
        btnViewDetails.TabIndex = 18
        btnViewDetails.Text = "View Ratings Details"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' lstRatingsList
        ' 
        lstRatingsList.Location = New Point(-2, -2)
        lstRatingsList.Margin = New Padding(2)
        lstRatingsList.Name = "lstRatingsList"
        lstRatingsList.Size = New Size(1173, 269)
        lstRatingsList.TabIndex = 19
        lstRatingsList.UseCompatibleStateImageBehavior = False
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
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1210, 194)
        Panel1.TabIndex = 1
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_avatar_96
        PictureBox1.Location = New Point(28, 15)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 160)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(226, 83)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 24)
        Label3.TabIndex = 2
        Label3.Text = "ADMINISTRATOR"
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
        ' pnlProfile
        ' 
        pnlProfile.AutoSize = True
        pnlProfile.BorderStyle = BorderStyle.Fixed3D
        pnlProfile.Controls.Add(Panel1)
        pnlProfile.Controls.Add(Panel2)
        pnlProfile.Controls.Add(Label1)
        pnlProfile.Location = New Point(0, 0)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1252, 768)
        pnlProfile.TabIndex = 2
        ' 
        ' RatingLayoutAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 766)
        Controls.Add(pnlProfile)
        Margin = New Padding(2, 2, 2, 2)
        Name = "RatingLayoutAdmin"
        Text = "RatingLayoutAdmin"
        Panel2.ResumeLayout(False)
        tabActivity.ResumeLayout(False)
        tabOverview.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        tabStudentRatingsList.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tabActivity As TabControl
    Friend WithEvents tabStudentRatingsList As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lstRatingsList As ListView
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
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
    Friend WithEvents pnlProfile As Panel
End Class
