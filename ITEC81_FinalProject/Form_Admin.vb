Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form_Admin
    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim username = Me.Name


        Try
            conn.Open()
            Dim query As String = "SELECT AdminID, LastName, FirstName, MiddleName, Department, EmailAddress, ContactNumber, BirthDate, Gender FROM tb_admin WHERE username = @username"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtLastName.Text = reader("LastName").ToString()
                    txtFirstName.Text = reader("FirstName").ToString()
                    txtMiddleName.Text = reader("MiddleName").ToString()
                    lblDept.Text = reader("Department").ToString()
                    txtEmail.Text = reader("EmailAddress").ToString()
                    txtContactNumber.Text = reader("ContactNumber").ToString()
                    txtDateOfBirth.Text = reader("BirthDate")
                    txtGender.Text = reader("Gender").ToString()
                    Dim MiddleInitial = reader("MiddleName").ToString()
                    lblFullName.Text = reader("LastName").ToString() + ", " + reader("FirstName").ToString + " " + MiddleInitial(0) + "."
                    lblEmail.Text = reader("EmailAddress").ToString()
                    lblContact.Text = reader("ContactNumber").ToString()
                    conn.Close()
                Else
                    MessageBox.Show("No Data Found.")
                End If
            End Using

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
            conn.Close()

        End Try
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnStudent.MouseMove, Button1.MouseMove, Button2.MouseMove, Button3.MouseMove, Button4.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnStudent.MouseLeave, Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave
        btnStudent.ForeColor = Color.LightGray
        Button1.ForeColor = Color.LightGray
        Button2.ForeColor = Color.LightGray
        Button3.ForeColor = Color.LightGray
        Button4.ForeColor = Color.LightGray
    End Sub

End Class