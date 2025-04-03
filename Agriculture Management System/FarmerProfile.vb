Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FarmerProfile
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub FarmerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFarmerDetails()
    End Sub

    ' Load Farmer Details
    Private Sub LoadFarmerDetails()
        Dim query As String = "SELECT Name, Contact, Address, Email FROM Farmers WHERE FarmerID = @FarmerID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@FarmerID", 1) ' Assuming only 1 farmer, change as needed

        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtName.Text = reader("Name").ToString()
                txtContact.Text = reader("Contact").ToString()
                txtAddress.Text = reader("Address").ToString()
                txtEmail.Text = reader("Email").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading farmer profile: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Update Farmer Profile
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE Farmers SET Name=@Name, Contact=@Contact, Address=@Address, Email=@Email WHERE FarmerID = @FarmerID"
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@FarmerID", 1) ' Assuming only 1 farmer

        Try
            con.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Open Change Password Form
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim changePasswordForm As New ChangePassword()
        changePasswordForm.USERID = 2 ' Pass FarmerID dynamically if needed
        changePasswordForm.ShowDialog()
    End Sub

    ' Close the Profile Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class







