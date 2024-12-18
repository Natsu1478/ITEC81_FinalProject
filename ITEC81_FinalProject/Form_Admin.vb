Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form_Admin
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click, btnTabProfile.Click
        btnTabProfile.BackColor = Color.DarkOrange
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
    End Sub

    Private Sub btnActivities_Click(sender As Object, e As EventArgs) Handles btnActivities.Click, btnTabActivities.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.DarkOrange
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
    End Sub

    Private Sub btnEnrollees_Click(sender As Object, e As EventArgs) Handles btnEnrollees.Click, btnTabEnrollees.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.DarkOrange
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click, btnTabSchedule.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.DarkOrange
        btnTabRatings.BackColor = Color.Transparent
    End Sub

    Private Sub btnRatings_Click(sender As Object, e As EventArgs) Handles btnRatings.Click, btnTabRatings.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.DarkOrange
    End Sub
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

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnProfile.MouseMove, btnActivities.MouseMove, btnEnrollees.MouseMove, btnRatings.MouseMove, btnSchedule.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnProfile.MouseLeave, btnActivities.MouseLeave, btnEnrollees.MouseLeave, btnRatings.MouseLeave, btnSchedule.MouseLeave
        btnProfile.ForeColor = Color.LightGray
        btnActivities.ForeColor = Color.LightGray
        btnEnrollees.ForeColor = Color.LightGray
        btnRatings.ForeColor = Color.LightGray
        btnSchedule.ForeColor = Color.LightGray
    End Sub



    Private Sub ConfigureListView()
        With lstActivityList
            .View = View.Details
            .Columns.Add("Activity ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Activity Name", 150, HorizontalAlignment.Left)
            .Columns.Add("Activity Type", 150, HorizontalAlignment.Left)
            .Columns.Add("Description", 300, HorizontalAlignment.Left)
            .Columns.Add("Faculty Advisor", 200, HorizontalAlignment.Left)
            .Columns.Add("Start Date", 250, HorizontalAlignment.Left)
            .Columns.Add("End Date", 250, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub LoadEmployeeData()
        conn.Open()
        Dim query As String = "SELECT * FROM tb_activities"
        Dim cmd As New MySqlCommand(query, conn)
        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ListViewItem(reader("ActivityID").ToString())
                item.SubItems.Add(reader("ActivityName").ToString())
                item.SubItems.Add(reader("ActivityType").ToString())
                item.SubItems.Add(reader("Description").ToString())
                item.SubItems.Add(reader("Faculty_Advisor").ToString())
                item.SubItems.Add(reader("StartDate").ToString())
                item.SubItems.Add(reader("EndDate").ToString())
                lstActivityList.Items.Add(item)
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub lstActivityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActivityList.SelectedIndexChanged

    End Sub

End Class