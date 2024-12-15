<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FillupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblCurrUser = New Label()
        Label1 = New Label()
        label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        btnBack = New Button()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        txtAdmin_ID = New TextBox()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        txtLastName = New TextBox()
        txtDepartment = New TextBox()
        txtEmailAddress = New TextBox()
        txtContactNumber = New TextBox()
        txtGender = New TextBox()
        dtpBirthDate = New DateTimePicker()
        Button1 = New Button()
        btnComplete = New Button()
        btnFillInfo = New Button()
        SuspendLayout()
        ' 
        ' lblCurrUser
        ' 
        lblCurrUser.AutoSize = True
        lblCurrUser.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrUser.Location = New Point(159, 29)
        lblCurrUser.Margin = New Padding(2, 0, 2, 0)
        lblCurrUser.Name = "lblCurrUser"
        lblCurrUser.Size = New Size(136, 54)
        lblCurrUser.TabIndex = 7
        lblCurrUser.Text = "ADMIN"
        lblCurrUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 77)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 45)
        Label1.TabIndex = 6
        Label1.Text = "Fill Up Form"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        label2.Location = New Point(81, 144)
        label2.Margin = New Padding(2, 0, 2, 0)
        label2.Name = "label2"
        label2.Size = New Size(109, 25)
        label2.TabIndex = 8
        label2.Text = "Admin ID: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(67, 184)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 25)
        Label3.TabIndex = 9
        Label3.Text = "First Name: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(45, 223)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 25)
        Label4.TabIndex = 10
        Label4.Text = "Middle Name: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(58, 302)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 25)
        Label5.TabIndex = 11
        Label5.Text = "Department: "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(57, 361)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 25)
        Label6.TabIndex = 12
        Label6.Text = "Department: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(36, 410)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 25)
        Label7.TabIndex = 13
        Label7.Text = "Email Address: "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(18, 457)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 25)
        Label8.TabIndex = 14
        Label8.Text = "Contact Number: "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label9.Location = New Point(72, 506)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 25)
        Label9.TabIndex = 15
        Label9.Text = "Birth Date: "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label10.Location = New Point(100, 555)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 25)
        Label10.TabIndex = 16
        Label10.Text = "Gender: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(200, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(315, 27)
        TextBox1.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(200, 209)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(315, 27)
        TextBox2.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(200, 264)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(315, 27)
        TextBox3.TabIndex = 19
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(200, 313)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(315, 27)
        TextBox4.TabIndex = 20
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(200, 361)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(315, 27)
        TextBox5.TabIndex = 21
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(200, 410)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(315, 27)
        TextBox6.TabIndex = 22
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(200, 457)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(315, 27)
        TextBox7.TabIndex = 23
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(200, 555)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(315, 27)
        TextBox8.TabIndex = 24
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(200, 506)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(315, 27)
        DateTimePicker1.TabIndex = 25
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Brown
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Franklin Gothic Medium Cond", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(416, 626)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(99, 43)
        btnBack.TabIndex = 27
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label11.Location = New Point(66, 262)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 25)
        Label11.TabIndex = 12
        Label11.Text = "Last Name: "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label12.Location = New Point(35, 345)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 25)
        Label12.TabIndex = 13
        Label12.Text = "Email Address: "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label13.Location = New Point(19, 387)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(176, 25)
        Label13.TabIndex = 14
        Label13.Text = "Contact Number: "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label14.Location = New Point(70, 428)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(120, 25)
        Label14.TabIndex = 15
        Label14.Text = "Birth Date: "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Franklin Gothic Book", 12.0F, FontStyle.Bold)
        Label15.Location = New Point(98, 466)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(92, 25)
        Label15.TabIndex = 16
        Label15.Text = "Gender: "
        ' 
        ' txtAdmin_ID
        ' 
        txtAdmin_ID.Enabled = False
        txtAdmin_ID.Location = New Point(195, 142)
        txtAdmin_ID.Name = "txtAdmin_ID"
        txtAdmin_ID.Size = New Size(288, 27)
        txtAdmin_ID.TabIndex = 17
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(195, 182)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(288, 27)
        txtFirstName.TabIndex = 18
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(195, 221)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(288, 27)
        txtMiddleName.TabIndex = 19
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(195, 260)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(288, 27)
        txtLastName.TabIndex = 20
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Location = New Point(195, 300)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(288, 27)
        txtDepartment.TabIndex = 21
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(195, 343)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(288, 27)
        txtEmailAddress.TabIndex = 22
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(195, 385)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(288, 27)
        txtContactNumber.TabIndex = 23
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(195, 464)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(288, 27)
        txtGender.TabIndex = 24
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(195, 426)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(288, 27)
        dtpBirthDate.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Franklin Gothic Medium Cond", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(344, 519)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 43)
        Button1.TabIndex = 27
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnComplete
        ' 
        btnComplete.Location = New Point(0, 0)
        btnComplete.Name = "btnComplete"
        btnComplete.Size = New Size(75, 23)
        btnComplete.TabIndex = 0
        ' 
        ' btnFillInfo
        ' 
        btnFillInfo.BackColor = Color.White
        btnFillInfo.FlatStyle = FlatStyle.Flat
        btnFillInfo.Font = New Font("Franklin Gothic Medium Cond", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFillInfo.ForeColor = Color.Black
        btnFillInfo.Location = New Point(195, 519)
        btnFillInfo.Name = "btnFillInfo"
        btnFillInfo.Size = New Size(139, 43)
        btnFillInfo.TabIndex = 28
        btnFillInfo.Text = "Fill Information"
        btnFillInfo.UseVisualStyleBackColor = False
        ' 
        ' FillupForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(516, 586)
        Controls.Add(btnFillInfo)
        Controls.Add(Button1)
        Controls.Add(dtpBirthDate)
        Controls.Add(txtGender)
        Controls.Add(txtContactNumber)
        Controls.Add(txtEmailAddress)
        Controls.Add(txtDepartment)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFirstName)
        Controls.Add(txtAdmin_ID)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(label2)
        Controls.Add(lblCurrUser)
        Controls.Add(Label1)
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FillupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FillupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCurrUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents btnComplete As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAdmin_ID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFillInfo As Button
End Class
