Public Class LogInForm
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click, btnStudent.Click
        If sender Is btn_Admin Then
            lblCurrUser.Text = "ADMIN"
        ElseIf sender Is btnStudent Then
            lblCurrUser.Text = "STUDENT"
        End If
        PanelUserOption.Visible = False
        PanelLogIn.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim currUser As String = lblCurrUser.Text


        If ValidateLogin(username, password, currUser) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If currUser = "ADMIN" Then
                Form_Admin.Name = username
                Me.Hide()
                Form_Admin.Show()

            ElseIf currUser = "STUDENT" Then
                Me.Hide()
                'StudentForm.Show()
            End If

        Else
            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub Hover(sender As Object, e As EventArgs) Handles lblCreateAccount.MouseMove
        lblCreateAccount.ForeColor = Color.White
    End Sub

    Private Sub HoverLeave(sender As Object, e As EventArgs) Handles lblCreateAccount.MouseLeave
        lblCreateAccount.ForeColor = Color.Maroon
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        PanelUserOption.Visible = True
        PanelLogIn.Visible = False
        txtUsername.Text = ""
        txtPassword.Text = ""
        cbxShowPassword.Checked = False
    End Sub

    Private Sub cbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbxShowPassword.CheckedChanged
        If cbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub lclCreateAccount_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub
End Class