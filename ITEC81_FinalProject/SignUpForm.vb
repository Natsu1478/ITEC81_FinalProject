Public Class SignUpForm
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdbStudent_CheckedChanged(sender As Object, e As EventArgs)
        rdbFaculty.Checked = False

    End Sub

    Private Sub rdbFaculty_CheckedChanged(sender As Object, e As EventArgs)
        rdbStudent.Checked = False

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        LogInForm.Show()
    End Sub

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

        txtUsername.Text = ""
        txtPassword.Text = ""
        rdbFaculty.Checked = False
        rdbStudent.Checked = False
        Me.Hide()
        FillupForm.Show()

    End Sub
End Class