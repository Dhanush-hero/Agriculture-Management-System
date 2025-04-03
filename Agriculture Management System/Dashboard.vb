Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Dashboard
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Load Data when the Form Loads
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    ' Method to Load Data into Dashboard
    Private Sub LoadDashboardData()
        Try
            con.Open()

            ' Get Total Crops
            lblTotalCrops.Text = "Total No of Crops: 
               " & GetTotalCount("SELECT COUNT(*) FROM Crops")

            ' Get Total Inventory Items
            lblTotalInventory.Text = "Total No of Inventory: 
                   " & GetTotalCount("SELECT COUNT(*) FROM Inventory")

            ' Get Total Employees
            lblTotalEmployees.Text = "Total No of Employees: 
                   " & GetTotalCount("SELECT COUNT(*) FROM Employees")

            ' Get Total Sales
            lblTotalSales.Text = "Total No of Sales:
               " & GetTotalCount("SELECT COUNT(*) FROM Sales")

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    ' Helper Function to Get Count from Database
    Private Function GetTotalCount(query As String) As String
        Dim cmd As New SqlCommand(query, con)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count.ToString()
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblTotalEmployees_Click(sender As Object, e As EventArgs) Handles lblTotalEmployees.Click

    End Sub
End Class

