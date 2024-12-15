Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class FillupForm
    Private Sub FillupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFillInfo_Click(sender As Object, e As EventArgs) Handles btnFillInfo.Click
        Dim FirstName As String = txtFirstName.Text
        Dim MiddleName As String = txtMiddleName.Text
        Dim LastName As String = txtLastName.Text
        Dim Department As String = txtDepartment.Text
        Dim EmailAddress As String = txtEmailAddress.Text
        Dim ContactNumber As String = txtContactNumber.Text
        Dim BirthDate As String = dtpBirthDate.Value
        Dim Gender As String = txtGender.Text
        Dim username As String = Me.Name
        AddRecord(FirstName, MiddleName, LastName, Department, EmailAddress, ContactNumber, BirthDate, Gender, username)
        Me.Hide()
    End Sub
End Class