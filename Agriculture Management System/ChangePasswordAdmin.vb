Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class ChangePasswordAdmin
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Admin User ID (Should be dynamically set during login)
    Public USERID As Integer = 1 ' Admin has UserID = 1

    Private Sub ChangePasswordAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdminDetails()
    End Sub

    ' Load Admin Details
    Private Sub LoadAdminDetails()
        Dim query As String = "SELECT Username, Password FROM Users WHERE UserID = @USERID AND UserRole = 'Admin'"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@USERID", USERID)

        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtUsername.Text = reader("Username").ToString()
                txtPassword.Text = reader("Password").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading admin profile: " & ex.Message)
        Finally
            con.Close()
        End Try

        ' Make username read-only, only password should be updated
        txtUsername.ReadOnly = True
    End Sub

    ' Update Admin Password
    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        If txtPassword.Text = "" Then
            MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "UPDATE Users SET Password = @Password WHERE UserID = @USERID AND UserRole = 'Admin'"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@USERID", USERID)

        Try
            con.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No changes were made. Ensure you are logged in as an admin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Show/Hide Password Checkbox
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, ControlChars.NullChar, "*"c)
    End Sub

    ' Close the Admin Profile Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
