Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class EmployeeManagement
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadFarms()
        LoadCrops()
        LoadInventory()
        cmbRole.SelectedIndex = 0 ' Set default selection
    End Sub

    ' Load Employees
    Private Sub LoadEmployees()
        Dim query As String = "SELECT * FROM Employees"
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

    ' Load Farms into ComboBox
    Private Sub LoadFarms()
        Dim query As String = "SELECT FarmID, FarmName FROM Farms"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            cmbFarm.DataSource = dt
            cmbFarm.DisplayMember = "FarmName"
            cmbFarm.ValueMember = "FarmID"
            cmbFarm.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading farms: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Load Crops into ComboBox
    Private Sub LoadCrops()
        Dim query As String = "SELECT CropID, CropName FROM Crops"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            cmbCrop.DataSource = dt
            cmbCrop.DisplayMember = "CropName"
            cmbCrop.ValueMember = "CropID"
            cmbCrop.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading crops: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Load Inventory into ComboBox
    Private Sub LoadInventory()
        Dim query As String = "SELECT InventoryID, ItemName FROM Inventory"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            cmbInventory.DataSource = dt
            cmbInventory.DisplayMember = "ItemName"
            cmbInventory.ValueMember = "InventoryID"
            cmbInventory.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Add Employee
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If txtName.Text = "" Or txtContact.Text = "" Or txtSalary.Text = "" Or cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Please enter all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO Employees (Name, Contact, Role, Salary, FarmID, CropID, InventoryID) 
                               VALUES (@Name, @Contact, @Role, @Salary, @FarmID, @CropID, @InventoryID)"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text))
        cmd.Parameters.AddWithValue("@FarmID", cmbFarm.SelectedValue)
        cmd.Parameters.AddWithValue("@CropID", cmbCrop.SelectedValue)
        cmd.Parameters.AddWithValue("@InventoryID", cmbInventory.SelectedValue)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEmployees()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Update Employee
    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim employeeID As Integer = Convert.ToInt32(dgvEmployees.SelectedRows(0).Cells("EmployeeID").Value)
        Dim query As String = "UPDATE Employees SET Name=@Name, Contact=@Contact, Role=@Role, Salary=@Salary, 
                               FarmID=@FarmID, CropID=@CropID, InventoryID=@InventoryID WHERE EmployeeID=@EmployeeID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text))
        cmd.Parameters.AddWithValue("@FarmID", cmbFarm.SelectedValue)
        cmd.Parameters.AddWithValue("@CropID", cmbCrop.SelectedValue)
        cmd.Parameters.AddWithValue("@InventoryID", cmbInventory.SelectedValue)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEmployees()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Delete Employee
    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        If dgvEmployees.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an employee to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim employeeID As Integer = Convert.ToInt32(dgvEmployees.SelectedRows(0).Cells("EmployeeID").Value)
        Dim query As String = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadEmployees()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Clear Fields
    ' Clear Button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtContact.Clear()
        txtSalary.Clear()
        cmbRole.SelectedIndex = -1
        cmbFarm.SelectedIndex = -1
        cmbCrop.SelectedIndex = -1
        cmbInventory.SelectedIndex = -1
    End Sub

    ' Populate Fields when selecting a row
    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)
            txtName.Text = row.Cells("Name").Value.ToString()
            txtContact.Text = row.Cells("Contact").Value.ToString()
            cmbRole.SelectedItem = row.Cells("Role").Value.ToString()
            txtSalary.Text = row.Cells("Salary").Value.ToString()
            cmbFarm.SelectedValue = row.Cells("FarmID").Value
            cmbCrop.SelectedValue = row.Cells("CropID").Value
            cmbInventory.SelectedValue = row.Cells("InventoryID").Value
        End If
    End Sub
End Class






