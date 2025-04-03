Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Farmer
    ' Store the role of the logged-in user (Default is "Farmer")
    Public UserRole As String = "Farmer"

    ' Database connection
    Dim connection As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Form Load - Display Farmer Name
    Private Sub Farmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & UserRole & "!"
        OpenFormInPanel(New FarmerProfile())
    End Sub

    ' Function to Open Forms Inside the Panel Without Hiding the Dashboard
    Private Sub OpenFormInPanel(childForm As Form)
        ' Close any existing form inside the panel
        For Each ctrl As Control In PanelContainer.Controls
            If TypeOf ctrl Is Form Then
                Dim openForm As Form = CType(ctrl, Form)
                openForm.Close()
            End If
        Next

        ' Set the new form inside the panel
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None ' Remove border for clean UI
        childForm.Dock = DockStyle.Fill ' Make it fill the panel
        PanelContainer.Controls.Clear() ' Remove any existing controls
        PanelContainer.Controls.Add(childForm) ' Add the new form to panel
        childForm.Show()
    End Sub

    ' Open Crop Management Form inside Panel
    Private Sub btnMyCrops_Click(sender As Object, e As EventArgs) Handles btnMyCrops.Click
        Dim cropForm As New CropManagement()
        OpenFormInPanel(cropForm)
    End Sub

    ' Open Inventory View Form inside Panel
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim inventoryForm As New InventoryManagement()
        inventoryForm.UserRole = UserRole ' Pass role to Inventory Form
        OpenFormInPanel(inventoryForm)
    End Sub

    ' Open Sales Report Form inside Panel
    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        Dim salesReportForm As New SalesReport()
        OpenFormInPanel(salesReportForm)
    End Sub

    ' Open My Profile Form inside Panel
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim profileForm As New FarmerProfile()
        OpenFormInPanel(profileForm)
    End Sub

    ' Open Employee View Form inside Panel (Farmers Can Only View Employees)
    Private Sub btnViewEmployees_Click(sender As Object, e As EventArgs) Handles btnViewEmployees.Click
        Dim empView As New FarmerEmployeeView()
        OpenFormInPanel(empView)
    End Sub

    ' Logout and Return to Login Form
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide() ' Hide Farmer dashboard
            Dim loginForm As New Form2() ' Open Login Form
            loginForm.Show()
        End If
    End Sub
End Class


