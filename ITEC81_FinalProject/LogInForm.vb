Public Class LogInForm
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_Admin.Click, btnStudent.Click
        If sender Is btn_Admin Then
            lblCurrUser.Text = "ADMIN"
            btnBack.BackColor = Color.Maroon
        ElseIf sender Is btnStudent Then
            lblCurrUser.Text = "STUDENT"
            btnBack.BackColor = Color.Navy
        End If
        PanelUserOption.Visible = False
        PanelLogIn.Visible = True
    End Sub

    Private Sub btn_Hover(sender As Object, e As EventArgs) Handles btnLogin.MouseMove, btnBack.MouseMove

        If lblCurrUser.Text Is "ADMIN" Then
            If sender Is btnLogin Then
                sender.ForeColor = Color.White
                sender.BackColor = Color.Maroon
            ElseIf sender Is btnBack Then
                sender.ForeColor = Color.Black
                sender.BackColor = Color.White
            End If
        Else
            If sender Is btnLogin Then
                sender.ForeColor = Color.White
                sender.BackColor = Color.Navy
            ElseIf sender Is btnBack Then
                sender.ForeColor = Color.Black
                sender.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub btn_Hover(sender As Object, e As EventArgs) Handles btnLogin.MouseMove, btnBack.MouseMove

        If lblCurrUser.Text Is "ADMIN" Then
            If sender Is btnLogin Then
                sender.ForeColor = Color.White
                sender.BackColor = Color.Maroon
            ElseIf sender Is btnBack Then
                sender.ForeColor = Color.Black
                sender.BackColor = Color.White
            End If
        Else
            If sender Is btnLogin Then
                sender.ForeColor = Color.White
                sender.BackColor = Color.Navy
            ElseIf sender Is btnBack Then
                sender.ForeColor = Color.Black
                sender.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub btn_HoverLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave, btnBack.MouseLeave
        btnBack.ForeColor = Color.White
        btnLogin.ForeColor = Color.Black
        If lblCurrUser.Text Is "ADMIN" Then
            btnBack.BackColor = Color.Maroon
        Else
            btnBack.BackColor = Color.Navy
        End If

    End Sub

    Private Sub ButtonHover(sender As Object, e As EventArgs) Handles btn_Admin.MouseMove, btnStudent.MouseMove
        sender.ForeColor = Color.White
        sender.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub ButtonHoverLeave(sender As Object, e As EventArgs) Handles btn_Admin.MouseLeave, btnStudent.MouseLeave
        sender.ForeColor = Color.Black
        sender.FlatAppearance.BorderSize = 1
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

    Private Sub lblCreateAccount_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim result As DialogResult = MessageBox.Show("Exit Program?", "Close Program.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Me.Hide()
        End If
    End Sub

    Private Sub Label4_Hover(sender As Object, e As EventArgs) Handles Label4.MouseMove, lblCreateAccount.MouseMove
        sender.ForeColor = Color.Maroon
    End Sub

    Private Sub Label4_HoverLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave, lblCreateAccount.MouseLeave
        sender.ForeColor = Color.Black
    End Sub
End Class