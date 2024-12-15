<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FillupFormStudent
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
        btnFillInfo = New Button()
        Back = New Button()
        dtpBirthDate = New DateTimePicker()
        txtGender = New TextBox()
        txtContactNumber = New TextBox()
        txtEmailAddress = New TextBox()
        txtCourse = New TextBox()
        txtLastName = New TextBox()
        txtMiddleName = New TextBox()
        txtFirstName = New TextBox()
        txtStudent_ID = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        label2 = New Label()
        lblCurrUser = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnFillInfo
        ' 
        btnFillInfo.BackColor = Color.White
        btnFillInfo.FlatStyle = FlatStyle.Flat
        btnFillInfo.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFillInfo.ForeColor = Color.Black
        btnFillInfo.Location = New Point(202, 517)
        btnFillInfo.Name = "btnFillInfo"
        btnFillInfo.Size = New Size(139, 43)
        btnFillInfo.TabIndex = 50
        btnFillInfo.Text = "Fill Information"
        btnFillInfo.UseVisualStyleBackColor = False
        ' 
        ' Back
        ' 
        Back.BackColor = Color.Brown
        Back.FlatStyle = FlatStyle.Flat
        Back.Font = New Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Back.ForeColor = Color.White
        Back.Location = New Point(351, 517)
        Back.Name = "Back"
        Back.Size = New Size(139, 43)
        Back.TabIndex = 49
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = False
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Location = New Point(202, 424)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(288, 27)
        dtpBirthDate.TabIndex = 48
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(202, 462)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(288, 27)
        txtGender.TabIndex = 47
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(202, 383)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(288, 27)
        txtContactNumber.TabIndex = 46
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Location = New Point(202, 341)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(288, 27)
        txtEmailAddress.TabIndex = 45
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(202, 298)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(288, 27)
        txtCourse.TabIndex = 44
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(202, 258)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(288, 27)
        txtLastName.TabIndex = 43
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(202, 219)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(288, 27)
        txtMiddleName.TabIndex = 42
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(202, 180)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(288, 27)
        txtFirstName.TabIndex = 41
        ' 
        ' txtStudent_ID
        ' 
        txtStudent_ID.Enabled = False
        txtStudent_ID.Location = New Point(202, 140)
        txtStudent_ID.Name = "txtStudent_ID"
        txtStudent_ID.Size = New Size(288, 27)
        txtStudent_ID.TabIndex = 40
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label15.Location = New Point(105, 464)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(92, 25)
        Label15.TabIndex = 39
        Label15.Text = "Gender: "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label14.Location = New Point(77, 426)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(120, 25)
        Label14.TabIndex = 38
        Label14.Text = "Birth Date: "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label13.Location = New Point(26, 385)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(176, 25)
        Label13.TabIndex = 37
        Label13.Text = "Contact Number: "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label12.Location = New Point(42, 343)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 25)
        Label12.TabIndex = 36
        Label12.Text = "Email Address: "
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label11.Location = New Point(73, 260)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 25)
        Label11.TabIndex = 35
        Label11.Text = "Last Name: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label5.Location = New Point(105, 300)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 25)
        Label5.TabIndex = 34
        Label5.Text = "Course: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label4.Location = New Point(52, 221)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 25)
        Label4.TabIndex = 33
        Label4.Text = "Middle Name: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        Label3.Location = New Point(74, 182)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 25)
        Label3.TabIndex = 32
        Label3.Text = "First Name: "
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Franklin Gothic Book", 12F, FontStyle.Bold)
        label2.Location = New Point(77, 142)
        label2.Margin = New Padding(2, 0, 2, 0)
        label2.Name = "label2"
        label2.Size = New Size(123, 25)
        label2.TabIndex = 31
        label2.Text = "Student ID: "
        ' 
        ' lblCurrUser
        ' 
        lblCurrUser.AutoSize = True
        lblCurrUser.Font = New Font("Impact", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrUser.Location = New Point(144, 29)
        lblCurrUser.Margin = New Padding(2, 0, 2, 0)
        lblCurrUser.Name = "lblCurrUser"
        lblCurrUser.Size = New Size(176, 54)
        lblCurrUser.TabIndex = 30
        lblCurrUser.Text = "STUDENT"
        lblCurrUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(197, 74)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 45)
        Label1.TabIndex = 29
        Label1.Text = "Fill Up Form"
        ' 
        ' FillupFormStudent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(516, 586)
        Controls.Add(btnFillInfo)
        Controls.Add(Back)
        Controls.Add(dtpBirthDate)
        Controls.Add(txtGender)
        Controls.Add(txtContactNumber)
        Controls.Add(txtEmailAddress)
        Controls.Add(txtCourse)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFirstName)
        Controls.Add(txtStudent_ID)
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
        MaximizeBox = False
        MinimizeBox = False
        Name = "FillupFormStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FillupFormStudent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnFillInfo As Button
    Friend WithEvents Back As Button
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtStudent_ID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents lblCurrUser As Label
    Friend WithEvents Label1 As Label
End Class
