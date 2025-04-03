Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class CropManagement
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub CropManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCrops() ' Load crops when form opens
    End Sub

    ' Load Crops from Database
    Private Sub LoadCrops()
        Dim query As String = "SELECT CropID, CropName, PlantingDate, HarvestDate, Quantity FROM Crops"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            DataGridView1.DataSource = dt ' Show crops in DataGridView
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    ' Load selected crop details into text fields
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            txtCropID.Text = DataGridView1.SelectedRows(0).Cells("CropID").Value.ToString()
            txtCropName.Text = DataGridView1.SelectedRows(0).Cells("CropName").Value.ToString()
            dtpPlanting.Value = Convert.ToDateTime(DataGridView1.SelectedRows(0).Cells("PlantingDate").Value)

            ' Check if HarvestDate is null before assigning
            Dim harvestDateObj As Object = DataGridView1.SelectedRows(0).Cells("HarvestDate").Value
            If harvestDateObj IsNot DBNull.Value Then
                dtpHarvest.Value = Convert.ToDateTime(harvestDateObj)
                dtpHarvest.Checked = True
            Else
                dtpHarvest.Checked = False
            End If

            txtQuantity.Text = DataGridView1.SelectedRows(0).Cells("Quantity").Value.ToString()
        End If
    End Sub


    ' Add New Crop
    Private Sub btnAddCrop_Click(sender As Object, e As EventArgs) Handles btnAddCrop.Click
        If txtCropName.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please enter crop details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO Crops (FarmerID, CropName, PlantingDate, HarvestDate, Quantity) VALUES (@FarmerID, @CropName, @PlantingDate, @HarvestDate, @Quantity)"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@FarmerID", 1) ' Assuming 1 farmer
        cmd.Parameters.AddWithValue("@CropName", txtCropName.Text)
        cmd.Parameters.AddWithValue("@PlantingDate", dtpPlanting.Value)
        cmd.Parameters.AddWithValue("@HarvestDate", If(dtpHarvest.Checked, dtpHarvest.Value, DBNull.Value))
        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Crop added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCrops() ' Refresh list
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        ' Check if the crop already exists for the farmer
        Dim checkQuery As String = "SELECT COUNT(*) FROM Crops WHERE FarmerID = @FarmerID AND CropName = @CropName AND PlantingDate = @PlantingDate"
        Dim checkCmd As New SqlCommand(checkQuery, con)
        checkCmd.Parameters.AddWithValue("@FarmerID", 1) ' Assuming single farmer
        checkCmd.Parameters.AddWithValue("@CropName", txtCropName.Text)
        checkCmd.Parameters.AddWithValue("@PlantingDate", dtpPlanting.Value)


    End Sub
    ' Update Crop Details
    Private Sub btnEditCrop_Click(sender As Object, e As EventArgs) Handles btnEditCrop.Click
        ' Validate Selection
        If txtCropID.Text = "" Then
            MessageBox.Show("Please select a crop to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate Input
        If txtCropName.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please enter all details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Query for Updating the Crop
        Dim query As String = "UPDATE Crops SET CropName=@CropName, PlantingDate=@PlantingDate, HarvestDate=@HarvestDate, Quantity=@Quantity WHERE CropID=@CropID"
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@CropID", Convert.ToInt32(txtCropID.Text))
        cmd.Parameters.AddWithValue("@CropName", txtCropName.Text)
        cmd.Parameters.AddWithValue("@PlantingDate", dtpPlanting.Value)
        cmd.Parameters.AddWithValue("@HarvestDate", If(dtpHarvest.Checked, dtpHarvest.Value, DBNull.Value))
        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Crop updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCrops() ' Refresh list
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    ' Delete Selected Crop
    Private Sub btnDeleteCrop_Click(sender As Object, e As EventArgs) Handles btnDeleteCrop.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a crop to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cropID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CropID").Value)
        Dim query As String = "DELETE FROM Crops WHERE CropID = @CropID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@CropID", cropID)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Crop deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCrops() ' Refresh list
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txtCropID_TextChanged(sender As Object, e As EventArgs) Handles txtCropID.TextChanged

    End Sub
End Class
