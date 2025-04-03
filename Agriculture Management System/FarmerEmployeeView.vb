Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class FarmerEmployeeView
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub FarmerEmployeeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
    End Sub

    ' Load Employees - Farmers Can Only View
    Private Sub LoadEmployees()
        Dim query As String = "SELECT EmployeeID, Name, Contact, Role, Salary, FarmID, CropID, InventoryID FROM Employees"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            dgvEmployees.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
