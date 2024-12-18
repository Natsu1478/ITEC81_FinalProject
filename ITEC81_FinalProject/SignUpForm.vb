Public Class SignUpForm
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdbStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rdbStudent.Click
        btnSignUp.BackColor = Color.Navy
        btnBack.FlatAppearance.MouseOverBackColor = Color.Navy
    End Sub

    Private Sub rdbFaculty_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFaculty.Click
        btnSignUp.BackColor = Color.Maroon
        btnBack.FlatAppearance.MouseOverBackColor = Color.Maroon

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        LogInForm.Show()
    End Sub

    Public Function assignUsername() As String
        Dim assignedUsername = txtUsername.Text
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim CurrUser As String
        If rdbFaculty.Checked = True Then
            CurrUser = "ADMIN"
        ElseIf rdbStudent.Checked = True Then
            CurrUser = "STUDENT"

        Else
            MessageBox.Show("Please choose user category", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Create_User(username, password, CurrUser)

        FillupForm.Name = username
        rdbFaculty.Checked = False
        rdbStudent.Checked = False
        Me.Hide()
        FillupForm.Show()

    End Sub

    Private Sub Label1_Hover(sender As Object, e As EventArgs) Handles Label1.MouseMove
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        LogInForm.Show()
    End Sub

    Private Sub Label1_HoverLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub
End Class