Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class SalesReport
    ' Database Connection String
    Dim con As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesReport()
        LoadCrops()
        LoadInventory()
    End Sub

    ' Load Sales Data into DataGridView
    Private Sub LoadSalesReport()
        Dim query As String = "SELECT Sales.SaleID, Sales.SaleDate, Crops.CropName, Inventory.ItemName, Sales.Quantity, Sales.SalePrice, 
                                      (Sales.Quantity * Sales.SalePrice) AS TotalAmount 
                               FROM Sales 
                               LEFT JOIN Crops ON Sales.CropID = Crops.CropID 
                               LEFT JOIN Inventory ON Sales.InventoryID = Inventory.InventoryID"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            dgvSalesReport.DataSource = dt
            CalculateTotalRevenue()
        Catch ex As Exception
            MessageBox.Show("Error loading sales report: " & ex.Message)
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

            cmbCropFilter.DataSource = dt
            cmbCropFilter.DisplayMember = "CropName"
            cmbCropFilter.ValueMember = "CropID"
            cmbCropFilter.SelectedIndex = -1 ' Default to no selection
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

            cmbInventoryFilter.DataSource = dt
            cmbInventoryFilter.DisplayMember = "ItemName"
            cmbInventoryFilter.ValueMember = "InventoryID"
            cmbInventoryFilter.SelectedIndex = -1 ' Default to no selection
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Filter Sales Report
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim query As String = "SELECT Sales.SaleID, Sales.SaleDate, Crops.CropName, Inventory.ItemName, Sales.Quantity, Sales.SalePrice, 
                                      (Sales.Quantity * Sales.SalePrice) AS TotalAmount 
                               FROM Sales 
                               LEFT JOIN Crops ON Sales.CropID = Crops.CropID 
                               LEFT JOIN Inventory ON Sales.InventoryID = Inventory.InventoryID 
                               WHERE SaleDate BETWEEN @StartDate AND @EndDate"

        If cmbCropFilter.SelectedValue IsNot Nothing Then
            query &= " AND Sales.CropID = @CropID"
        End If
        If cmbInventoryFilter.SelectedValue IsNot Nothing Then
            query &= " AND Sales.InventoryID = @InventoryID"
        End If

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value)
        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value)

        If cmbCropFilter.SelectedValue IsNot Nothing Then
            cmd.Parameters.AddWithValue("@CropID", cmbCropFilter.SelectedValue)
        End If
        If cmbInventoryFilter.SelectedValue IsNot Nothing Then
            cmd.Parameters.AddWithValue("@InventoryID", cmbInventoryFilter.SelectedValue)
        End If

        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            con.Open()
            adapter.Fill(dt)
            con.Close()

            dgvSalesReport.DataSource = dt
            CalculateTotalRevenue()
        Catch ex As Exception
            MessageBox.Show("Error filtering sales report: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Calculate Total Revenue
    Private Sub CalculateTotalRevenue()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvSalesReport.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("TotalAmount").Value) Then
                total += Convert.ToDecimal(row.Cells("TotalAmount").Value)
            End If
        Next

        lblTotalRevenue.Text = "Total Revenue: Rs " & total.ToString("N2")
    End Sub

    ' Clear Filters
    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        cmbCropFilter.SelectedIndex = -1
        cmbInventoryFilter.SelectedIndex = -1
        dtpStartDate.Value = DateTime.Today.AddMonths(-1) ' Default to last month
        dtpEndDate.Value = DateTime.Today
        LoadSalesReport()
    End Sub
End Class





