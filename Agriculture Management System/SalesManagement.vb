Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SalesManagement
    ' Database Connection
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub SalesManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSales()
        LoadCrops()
        LoadInventory()

        ' Ensure DataGridView selection works
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSales.MultiSelect = False
        dgvSales.ReadOnly = False
        dgvSales.ClearSelection()
    End Sub

    ' Load Sales Data
    Private Sub LoadSales()
        Dim query As String = "SELECT s.SaleID, c.CropName, i.ItemName, s.Quantity, s.SalePrice, s.SaleDate 
                               FROM Sales s 
                               JOIN Crops c ON s.CropID = c.CropID 
                               JOIN Inventory i ON s.InventoryID = i.InventoryID"

        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            dgvSales.DataSource = dt
            dgvSales.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message)
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
            cmbCrop.SelectedIndex = -1  ' Deselect default value
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

    ' Add Sale Record
    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnAddSale.Click
        If cmbCrop.SelectedValue Is Nothing OrElse cmbInventory.SelectedValue Is Nothing OrElse txtQuantity.Text = "" OrElse txtSalePrice.Text = "" Then
            MessageBox.Show("Please enter all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "INSERT INTO Sales (CropID, InventoryID, Quantity, SalePrice, SaleDate) VALUES (@CropID, @InventoryID, @Quantity, @SalePrice, GETDATE())"
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@CropID", cmbCrop.SelectedValue)
        cmd.Parameters.AddWithValue("@InventoryID", cmbInventory.SelectedValue)
        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
        cmd.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(txtSalePrice.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Sale recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSales()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding sale: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Update Sale Record
    Private Sub btnUpdateSale_Click(sender As Object, e As EventArgs) Handles btnUpdateSale.Click
        If dgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a sale record to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim saleID As Integer = Convert.ToInt32(dgvSales.SelectedRows(0).Cells(0).Value) ' Ensure correct column index
        Dim query As String = "UPDATE Sales SET CropID=@CropID, InventoryID=@InventoryID, Quantity=@Quantity, SalePrice=@SalePrice WHERE SaleID=@SaleID"
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@SaleID", saleID)
        cmd.Parameters.AddWithValue("@CropID", cmbCrop.SelectedValue)
        cmd.Parameters.AddWithValue("@InventoryID", cmbInventory.SelectedValue)
        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtQuantity.Text))
        cmd.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(txtSalePrice.Text))

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Sale updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSales()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating sale: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Delete Sale Record
    Private Sub btnDeleteSale_Click(sender As Object, e As EventArgs) Handles btnDeleteSale.Click
        If dgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a sale record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim saleID As Integer = Convert.ToInt32(dgvSales.SelectedRows(0).Cells(0).Value)
        Dim query As String = "DELETE FROM Sales WHERE SaleID=@SaleID"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@SaleID", saleID)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Sale deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSales()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting sale: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Select Row from DataGridView
    Private Sub dgvSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSales.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvSales.Rows(e.RowIndex)

            cmbCrop.Text = selectedRow.Cells("CropName").Value.ToString()
            cmbInventory.Text = selectedRow.Cells("ItemName").Value.ToString()
            txtQuantity.Text = selectedRow.Cells("Quantity").Value.ToString()
            txtSalePrice.Text = selectedRow.Cells("SalePrice").Value.ToString()
        End If
    End Sub

    ' Clear Fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtQuantity.Text = ""
        txtSalePrice.Text = ""
        cmbCrop.SelectedIndex = -1
        cmbInventory.SelectedIndex = -1
        dgvSales.ClearSelection()
    End Sub

    ' Open Sales Report Form
    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Dim salesReportForm As New SalesReport()
        salesReportForm.Show()
    End Sub

    Private Sub dgvSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSales.CellContentClick

    End Sub
End Class

