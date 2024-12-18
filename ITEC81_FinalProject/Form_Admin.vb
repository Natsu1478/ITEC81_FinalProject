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
        pnlMAIN.Visible = True
        pnlProfile.Visible = False
        pnlActivities.Visible = False
        pnlEnrollment.Visible = False
        pnlSchedule.Visible = False
        pnlRatings.Visible = False
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click, btnTabProfile.Click
        btnTabProfile.BackColor = Color.DarkOrange
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
        pnlMAIN.Visible = False
        pnlProfile.Visible = True
        pnlActivities.Visible = False
        pnlEnrollment.Visible = False
        pnlSchedule.Visible = False
        pnlRatings.Visible = False
    End Sub

    Private Sub btnActivities_Click(sender As Object, e As EventArgs) Handles btnActivities.Click, btnTabActivities.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.DarkOrange
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
        pnlMAIN.Visible = False
        pnlProfile.Visible = False
        pnlActivities.Visible = True
        pnlEnrollment.Visible = False
        pnlSchedule.Visible = False
        pnlRatings.Visible = False
    End Sub

    Private Sub btnEnrollees_Click(sender As Object, e As EventArgs) Handles btnEnrollees.Click, btnTabEnrollees.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.DarkOrange
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.Transparent
        pnlMAIN.Visible = False
        pnlProfile.Visible = False
        pnlActivities.Visible = False
        pnlEnrollment.Visible = True
        pnlSchedule.Visible = False
        pnlRatings.Visible = False
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click, btnTabSchedule.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.DarkOrange
        btnTabRatings.BackColor = Color.Transparent
        pnlMAIN.Visible = False
        pnlProfile.Visible = False
        pnlActivities.Visible = False
        pnlEnrollment.Visible = False
        pnlSchedule.Visible = True
        pnlRatings.Visible = False
    End Sub

    Private Sub btnRatings_Click(sender As Object, e As EventArgs) Handles btnRatings.Click, btnTabRatings.Click
        btnTabProfile.BackColor = Color.Transparent
        btnTabActivities.BackColor = Color.Transparent
        btnTabEnrollees.BackColor = Color.Transparent
        btnTabSchedule.BackColor = Color.Transparent
        btnTabRatings.BackColor = Color.DarkOrange
        pnlMAIN.Visible = False
        pnlProfile.Visible = False
        pnlActivities.Visible = False
        pnlEnrollment.Visible = False
        pnlSchedule.Visible = False
        pnlRatings.Visible = True
    End Sub

    Private Sub EnableText()
        txtActivityName.Enabled = True
        txtActivityType.Enabled = True
        txtDescription.Enabled = True
        txtFacultyAdviser.Enabled = True
        dtpStartDate.Enabled = True
        dtpEndDate.Enabled = True
    End Sub

    Private Sub ClearText()
        txtActivityName.Text = ""
        txtActivityType.Text = ""
        txtDescription.Text = ""
        txtFacultyAdviser.Text = ""
    End Sub

    Private Sub DisabledText()
        txtActivityName.Enabled = False
        txtActivityType.Enabled = False
        txtDescription.Enabled = False
        txtFacultyAdviser.Enabled = False
        dtpStartDate.Enabled = False
        dtpEndDate.Enabled = False
    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        ConfigureListView()
        LoadData()
        Dim username = Me.Name
        Try

            Dim query As String = "SELECT AdminID, LastName, FirstName, MiddleName, Department, EmailAddress, ContactNumber, BirthDate, Gender FROM tb_admin WHERE username = @username"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtLastName.Text = reader("LastName").ToString()
                    txtFirstName.Text = reader("FirstName").ToString()
                    lblFName.Text = reader("FirstName").ToString()
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

                Else
                    MessageBox.Show("No Data Found.")
                End If
            End Using

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)


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

    Private Sub LoadData()

        Dim query As String = "SELECT * FROM tb_activities"
        Dim cmd As New MySqlCommand(query, conn)
        Try
            Dim readerr As MySqlDataReader = cmd.ExecuteReader()
            While readerr.Read()
                Dim item As New ListViewItem(readerr("ActivityID").ToString())
                item.SubItems.Add(readerr("ActivityName").ToString())
                item.SubItems.Add(readerr("ActivityType").ToString())
                item.SubItems.Add(readerr("Description").ToString())
                item.SubItems.Add(readerr("Faculty_Advisor").ToString())
                item.SubItems.Add(readerr("StartDate").ToString())
                item.SubItems.Add(readerr("EndDate").ToString())
                lstActivityList.Items.Add(item)
            End While
            readerr.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading employee data: " & ex.Message)
        End Try

    End Sub

    Private Sub lstActivityList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActivityList.SelectedIndexChanged

        If lstActivityList.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstActivityList.SelectedItems(0)
            txtActivityID.Text = selectedItem.Text
            txtActivityName.Text = selectedItem.SubItems(1).Text
            txtActivityType.Text = selectedItem.SubItems(2).Text
            txtDescription.Text = selectedItem.SubItems(3).Text
            txtFacultyAdviser.Text = selectedItem.SubItems(4).Text

            Dim dateString As String = selectedItem.SubItems(5).Text
            Dim dateFormat As String = "yyyy-MM-dd"
            Dim parsedDate As Date

            Date.TryParseExact(dateString, dateFormat, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedDate)
            dtpStartDate.Value = parsedDate

            Dim dateString1 As String = selectedItem.SubItems(6).Text
            Date.TryParseExact(dateString1, dateFormat, Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, parsedDate)
            dtpEndDate.Value = parsedDate

        End If
        btnEditActivity.Enabled = True
        btnDeleteActivity.Enabled = True
        DisabledText()
        btnAddNewActivity.Enabled = False
        btnAddNewActivity.Text = "Add New Activity"
        btnClear.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Logout?", "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Me.Hide()
            LogInForm.Show()
        End If
    End Sub

    Private Sub btnAddNewActivity_Click(sender As Object, e As EventArgs) Handles btnAddNewActivity.Click
        btnEditActivity.Enabled = False
        btnDeleteActivity.Enabled = False
        If (btnAddNewActivity.Text = "Add New Activity") Then
            ClearText()
            EnableText()
            btnAddNewActivity.Text = "Save Activity"

        Else
            Try

                Dim query As String = "INSERT INTO tb_activities (ActivityName, ActivityType, Description, Faculty_Advisor, StartDate, EndDate)
                                VALUES (@ActivityName, @ActivityType, @Description, @Faculty_Advisor, @StartDate, @EndDate)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@ActivityName", txtActivityName.Text.Trim())
                cmd.Parameters.AddWithValue("@ActivityType", txtActivityType.Text.Trim())
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@Faculty_Advisor", txtFacultyAdviser.Text.Trim())
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)

                lstActivityList.Clear()
                ClearText()


            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            Finally
                ConfigureListView()
                LoadData()
                DisabledText()
                btnAddNewActivity.Text = "Add New Activity"
                btnDeleteActivity.Enabled = True
                btnEditActivity.Enabled = True


            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearText()
    End Sub

    Private Sub btnEditActivity_Click(sender As Object, e As EventArgs) Handles btnEditActivity.Click
        btnAddNewActivity.Enabled = False
        btnClear.Enabled = True
        If (btnEditActivity.Text = "Edit Activity") Then
            EnableText()
            btnEditActivity.Text = "Save Changes"

        Else
            Dim response As DialogResult = MessageBox.Show("Do you really want to Save this record?", "Save", MessageBoxButtons.YesNo)

            If response = DialogResult.Yes Then
                Try

                    Dim query As String = "UPDATE tb_activities SET ActivityName=@ActivityName, ActivityType=@ActivityType, Description=@Description, Faculty_Advisor=@Faculty_Advisor, StartDate=@StartDate, EndDate=@EndDate
                                WHERE ActivityID=@ActivityID"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@ActivityID", txtActivityID.Text.Trim())
                    cmd.Parameters.AddWithValue("@ActivityName", txtActivityName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ActivityType", txtActivityType.Text.Trim())
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("@Faculty_Advisor", txtFacultyAdviser.Text.Trim())
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    lstActivityList.Clear()
                    ClearText()


                Catch ex As Exception

                    MessageBox.Show("Error: " & ex.Message)

                Finally
                    ConfigureListView()
                    LoadData()
                    DisabledText()

                    btnAddNewActivity.Enabled = True
                    btnEditActivity.Enabled = False
                    btnDeleteActivity.Enabled = False
                    btnClear.Enabled = False
                End Try
            ElseIf (response = DialogResult.No) Then
                DisabledText()
                btnEditActivity.Text = "Edit Activity"
                btnClear.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnDeleteActivity_Click(sender As Object, e As EventArgs) Handles btnDeleteActivity.Click
        Dim response As DialogResult = MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo)

        If response = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM tblemployee 
                                WHERE ActivityID=@ActivityID"
                Dim cmd As New MySqlCommand(query, conn)


                cmd.Parameters.AddWithValue("@ActivityID", Convert.ToDouble(txtActivityID.Text.Trim()))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                lstActivityList.Clear()
                Call ClearText()


            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            Finally
                ConfigureListView()
                LoadData()
                DisabledText()

                btnAddNewActivity.Enabled = True
                btnEditActivity.Enabled = False
                btnDeleteActivity.Enabled = False
            End Try
        End If
    End Sub
    Private Sub Form_Admin_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        conn.Close()
    End Sub
End Class