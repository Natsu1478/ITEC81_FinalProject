<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Panel1 = New Panel()
        pnlAdminProfile = New Panel()
        Button3 = New Button()
        Button4 = New Button()
        Panel4 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        btnStudent = New Button()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        lblFName = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        AnimationTimer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(pnlAdminProfile)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnStudent)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1566, 825)
        Panel1.TabIndex = 0
        ' 
        ' pnlAdminProfile
        ' 
        pnlAdminProfile.Location = New Point(287, 62)
        pnlAdminProfile.Name = "pnlAdminProfile"
        pnlAdminProfile.Size = New Size(1252, 761)
        pnlAdminProfile.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button3.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button3.Location = New Point(732, 285)
        Button3.Name = "Button3"
        Button3.Size = New Size(358, 126)
        Button3.TabIndex = 10
        Button3.Text = "Ratings"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button4.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button4.Location = New Point(330, 285)
        Button4.Name = "Button4"
        Button4.Size = New Size(358, 126)
        Button4.TabIndex = 9
        Button4.Text = "Schedule"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Maroon
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1566, 61)
        Panel4.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button2.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button2.Location = New Point(1134, 119)
        Button2.Name = "Button2"
        Button2.Size = New Size(358, 126)
        Button2.TabIndex = 8
        Button2.Text = "Enrollees"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.WhiteSmoke
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.CheckedBackColor = Color.DarkRed
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.Maroon
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Georgia", 18F, FontStyle.Bold)
        Button1.Location = New Point(732, 119)
        Button1.Name = "Button1"
        Button1.Size = New Size(358, 126)
        Button1.TabIndex = 6
        Button1.Text = "Activities"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.WhiteSmoke
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatAppearance.CheckedBackColor = Color.DarkRed
        btnStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnStudent.FlatAppearance.MouseOverBackColor = Color.Maroon
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Georgia", 18F, FontStyle.Bold)
        btnStudent.Location = New Point(330, 119)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(358, 126)
        btnStudent.TabIndex = 5
        btnStudent.Text = "Admin Profile "
        btnStudent.TextAlign = ContentAlignment.TopLeft
        btnStudent.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gray
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(lblFName)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(287, 826)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button10)
        Panel5.Controls.Add(Button9)
        Panel5.Controls.Add(Button8)
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Button6)
        Panel5.Controls.Add(Button5)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(0, 321)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 505)
        Panel5.TabIndex = 5
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Transparent
        Button10.BackgroundImageLayout = ImageLayout.Center
        Button10.Cursor = Cursors.Hand
        Button10.Dock = DockStyle.Top
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(0, 315)
        Button10.Name = "Button10"
        Button10.Size = New Size(287, 63)
        Button10.TabIndex = 10
        Button10.Text = "          RATINGS"
        Button10.TextImageRelation = TextImageRelation.ImageBeforeText
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.BackgroundImageLayout = ImageLayout.Center
        Button9.Cursor = Cursors.Hand
        Button9.Dock = DockStyle.Top
        Button9.FlatAppearance.BorderSize = 0
        Button9.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.ForeColor = Color.White
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(0, 252)
        Button9.Name = "Button9"
        Button9.Size = New Size(287, 63)
        Button9.TabIndex = 9
        Button9.Text = "         SCHEDULE"
        Button9.TextImageRelation = TextImageRelation.ImageBeforeText
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImageLayout = ImageLayout.Center
        Button8.Cursor = Cursors.Hand
        Button8.Dock = DockStyle.Top
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.MiddleLeft
        Button8.Location = New Point(0, 189)
        Button8.Name = "Button8"
        Button8.Size = New Size(287, 63)
        Button8.TabIndex = 8
        Button8.Text = "        ENROLLEES"
        Button8.TextImageRelation = TextImageRelation.ImageBeforeText
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImageLayout = ImageLayout.Center
        Button7.Cursor = Cursors.Hand
        Button7.Dock = DockStyle.Top
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(0, 126)
        Button7.Name = "Button7"
        Button7.Size = New Size(287, 63)
        Button7.TabIndex = 7
        Button7.Text = "        ACTIVITIES"
        Button7.TextImageRelation = TextImageRelation.ImageBeforeText
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImageLayout = ImageLayout.Center
        Button6.Cursor = Cursors.Hand
        Button6.Dock = DockStyle.Top
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(0, 63)
        Button6.Name = "Button6"
        Button6.Size = New Size(287, 63)
        Button6.TabIndex = 6
        Button6.Text = "           PROFILE"
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImageLayout = ImageLayout.Center
        Button5.Cursor = Cursors.Hand
        Button5.Dock = DockStyle.Top
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.DarkOrange
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(0, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(287, 63)
        Button5.TabIndex = 5
        Button5.Text = "        DASHBOARD"
        Button5.TextImageRelation = TextImageRelation.ImageBeforeText
        Button5.UseVisualStyleBackColor = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFName.Location = New Point(140, 285)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(83, 27)
        lblFName.TabIndex = 4
        lblFName.Text = "Jonas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 27)
        Label2.TabIndex = 3
        Label2.Text = "Hello,"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DarkOrange
        Label1.Location = New Point(38, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 20)
        Label1.TabIndex = 2
        Label1.Text = "___________________________________"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(287, 61)
        Panel3.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(28, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 27)
        Label3.TabIndex = 6
        Label3.Text = "Admin Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.cct_logo
        PictureBox1.Location = New Point(92, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 174)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' AnimationTimer1
        ' 
        ' 
        ' Form_Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1540, 826)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form_Admin"
        Text = "Form_Admin"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents lblFName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents AnimationTimer1 As Timer
    Friend WithEvents pnlAdminProfile As Panel
End Class
