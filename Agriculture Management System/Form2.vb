Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form2
    ' Database Connection String
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Constructor (Enable Double Buffering)
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True ' Reduce flickering
    End Sub

    ' 🔹 Login Button Click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate Input
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter both Username and Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            con.Open()
            Dim query As String = "SELECT UserRole FROM Users WHERE Username=@Username AND Password=@Password"
            Using cmd As New SqlCommand(query, con)
                ' Add Parameters to Prevent SQL Injection
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()) ' Note: Hash password in real applications

                Dim roleObj As Object = cmd.ExecuteScalar() ' Get the role

                ' Check if UserRole is found
                If roleObj IsNot Nothing AndAlso Not IsDBNull(roleObj) Then
                    Dim role As String = roleObj.ToString().Trim().ToLower() ' Convert role to lowercase

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Redirect User Based on Role
                    If role = "admin" Then
                        Dim adminForm As New Administrator()
                        adminForm.Show()
                    ElseIf role = "farmer" Then
                        Dim farmerForm As New Farmer()
                        farmerForm.Show()
                    Else
                        MessageBox.Show("Unknown role detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Me.Hide() ' Hide login form
                Else
                    MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ' 🔹 Show Password Checkbox
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.PasswordChar = If(chkShowPassword.Checked, ControlChars.NullChar, "*"c)
    End Sub

    ' 🔹 Reset Button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
        chkShowPassword.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class





