Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Module Module1

    Private connectionString As String = "Server=127.0.0.1;Database=db_activities;Uid=root;Pwd=;"

    Public conn As MySqlConnection = New MySqlConnection(connectionString)

    Public Function OpenConnection() As MySqlConnection
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MessageBox.Show("Connection Opened Successfully.")
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error opening connection: " & ex.Message)

        End Try
        Return conn
    End Function

    Public Sub CloseConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                MessageBox.Show("Connection Closed Successfully.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub

    Public Function ValidateLogin(username As String, password As String, currUser As String) As Boolean
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = ""
                If currUser = "ADMIN" Then
                    query = "SELECT COUNT(*) FROM tb_useradmin WHERE username = @username AND password = @password"
                ElseIf currUser = "STUDENT" Then
                    query = "SELECT COUNT(*) FROM tb_userstudents WHERE username = @username AND password = @password"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If result > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using

                conn.Close()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Sub Create_User(username As String, password As String, currUser As String)
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = ""
                If currUser = "ADMIN" Then
                    query = "INSERT INTO tb_useradmin (username,password) VALUES (@username,@password)"
                ElseIf currUser = "STUDENT" Then
                    query = "INSERT INTO tb_userstudents (username,password) VALUES (@username,@password)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Sign up Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                conn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End Using
    End Sub

    Public Sub AddRecord(FirstName As String, MiddleName As String, LastName As String, Department As String, EmailAddress As String, ContactNumber As String, BirthDate As String, Gender As String, username As String)
        Try
            conn.Open()
            Dim query As String = "INSERT INTO tb_admin (FirstName, MiddleName, LastName, Department, EmailAddress, ContactNumber, BirthDate, Gender, username)
                                VALUES (@FirstName, @MiddleName, @LastName, @Department, @EmailAddress, @ContactNumber, @BirthDate, @Gender, @username)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@FirstName", FirstName)
            cmd.Parameters.AddWithValue("@MiddleName", MiddleName)
            cmd.Parameters.AddWithValue("@LastName", LastName)
            cmd.Parameters.AddWithValue("@Department", Department)
            cmd.Parameters.AddWithValue("@EmailAddress", EmailAddress)
            cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber)
            cmd.Parameters.AddWithValue("@BirthDate", BirthDate)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@username", username)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn.Close()

        Catch ex As Exception

            conn.Close()
            MessageBox.Show("Error: " & ex.Message)


        End Try
    End Sub
End Module
