Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Administrator
    ' Store the role of the logged-in user (default is "Admin")
    Public UserRole As String = "Admin"

    ' Database connection
    Dim connection As New SqlConnection("Data Source=BHAGIII\SQLEXPRESS;Initial Catalog=d;Integrated Security=True;TrustServerCertificate=True")

    ' Form Load - Display Admin Name and Load Dashboard Initially
    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & UserRole & "!"
        OpenFormInPanel(New Dashboard()) ' Load Dashboard when form opens
    End Sub

    ' Function to Open Forms Inside the Panel Without Hiding Dashboard
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

    ' Open Dashboard inside Panel
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenFormInPanel(New Dashboard())
    End Sub

    Private Sub pbChangePassword_Click(sender As Object, e As EventArgs) Handles pbChangePassword.Click
        ' Open Change Password Form for Admin
        Dim changePasswordForm As New ChangePasswordAdmin()
        changePasswordForm.USERID = 1 ' Set Admin User ID
        changePasswordForm.ShowDialog() ' Show the form as a modal dialog
    End Sub


    ' Open Crop Management Form inside Panel
    Private Sub btnCrops_Click(sender As Object, e As EventArgs) Handles btnCrops.Click
        OpenFormInPanel(New CropManagement())
    End Sub

    ' Open Inventory Form inside Panel
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim inventoryForm As New InventoryManagement()
        inventoryForm.UserRole = UserRole ' Pass the role to the Inventory Form
        OpenFormInPanel(inventoryForm)
    End Sub

    ' Open Employee Management Form inside Panel
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        OpenFormInPanel(New EmployeeManagement())
    End Sub

    ' Open Sales & Revenue Form inside Panel
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        OpenFormInPanel(New SalesManagement())
    End Sub

    ' Logout and Return to Login Form
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide() ' Hide dashboard only when logging out
            Dim loginForm As New Form2() ' Open Login Form
            loginForm.Show()
        End If
    End Sub
End Class



