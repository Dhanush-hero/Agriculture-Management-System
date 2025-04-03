Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class InventoryManagement
    ' Database Connection
    Dim connection As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Variables to Store Role & FarmerID (Set these during login)
    Public UserRole As String
    Public LoggedInFarmerID As Integer

    ' Load Inventory on Form Load
    Private Sub InventoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCrops() ' Load crops into ComboBox

        ' Load Inventory based on user role
        If UserRole = "Admin" Then
            LoadAllInventory()
        Else
            LoadFarmerInventory()
        End If
    End Sub

    ' Load Crop List in ComboBox
    Private Sub LoadCrops()
        Try
            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "SELECT CropID, CropName FROM Crops"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Add default selection option
            Dim newRow As DataRow = dt.NewRow()
            newRow("CropID") = 0
            newRow("CropName") = "-- Select Crop --"
            dt.Rows.InsertAt(newRow, 0)

            cmbCrop.DataSource = dt
            cmbCrop.DisplayMember = "CropName"
            cmbCrop.ValueMember = "CropID"
            cmbCrop.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error loading crops: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load All Inventory (For Admin)
    Private Sub LoadAllInventory()
        Try
            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "SELECT * FROM Inventory"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvInventory.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load Only Farmer's Inventory
    Private Sub LoadFarmerInventory()
        Try
            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "SELECT * FROM Inventory WHERE FarmerID = @FarmerID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@FarmerID", LoggedInFarmerID)
            Dim adapter As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvInventory.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading farmer's inventory: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Add New Inventory Item
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate input
        If txtItemName.Text = "" Or txtQuantity.Text = "" Or cmbCrop.SelectedIndex = 0 Then
            MessageBox.Show("Please enter all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "INSERT INTO Inventory (ItemName, Quantity, PurchaseDate, ExpiryDate, CropID, FarmerID) VALUES (@ItemName, @Quantity, @PurchaseDate, @ExpiryDate, @CropID, @FarmerID)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            command.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            command.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            command.Parameters.AddWithValue("@CropID", cmbCrop.SelectedValue)
            command.Parameters.AddWithValue("@FarmerID", LoggedInFarmerID) ' Use logged-in FarmerID

            command.ExecuteNonQuery()
            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            If UserRole = "Admin" Then
                LoadAllInventory()
            Else
                LoadFarmerInventory()
            End If

        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update Selected Inventory Item
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim selectedID As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("InventoryID").Value)

            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "UPDATE Inventory SET ItemName=@ItemName, Quantity=@Quantity, PurchaseDate=@PurchaseDate, ExpiryDate=@ExpiryDate WHERE InventoryID=@InventoryID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ItemName", txtItemName.Text)
            command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
            command.Parameters.AddWithValue("@PurchaseDate", dtpPurchaseDate.Value)
            command.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value)
            command.Parameters.AddWithValue("@InventoryID", selectedID)
            command.ExecuteNonQuery()

            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            If UserRole = "Admin" Then
                LoadAllInventory()
            Else
                LoadFarmerInventory()
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating item: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete Selected Inventory Item (Only for Admin)
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If UserRole = "Farmer" Then
            MessageBox.Show("You are not allowed to delete inventory items.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim selectedID As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("InventoryID").Value)

            If connection.State = ConnectionState.Open Then connection.Close()
            connection.Open()

            Dim query As String = "DELETE FROM Inventory WHERE InventoryID=@InventoryID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@InventoryID", selectedID)
            command.ExecuteNonQuery()

            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllInventory()

        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Clear All Input Fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtItemName.Clear()
        txtQuantity.Clear()
        cmbCrop.SelectedIndex = 0 ' Reset to "-- Select Crop --"
        dtpPurchaseDate.Value = DateTime.Now ' Reset to current date
        dtpExpiryDate.Value = DateTime.Now ' Reset to current date
        dgvInventory.ClearSelection() ' Deselect any selected row
        txtItemName.Focus()
    End Sub

    ' Select Inventory Item from DataGridView
    Private Sub dgvInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInventory.Rows(e.RowIndex)
            txtItemName.Text = row.Cells("ItemName").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            dtpPurchaseDate.Value = Convert.ToDateTime(row.Cells("PurchaseDate").Value)
            dtpExpiryDate.Value = Convert.ToDateTime(row.Cells("ExpiryDate").Value)
        End If
    End Sub
End Class
