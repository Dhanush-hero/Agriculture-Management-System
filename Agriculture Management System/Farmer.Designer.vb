<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Farmer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Farmer))
        btnMyCrops = New Button()
        btnInventory = New Button()
        btnSalesReport = New Button()
        btnProfile = New Button()
        btnLogout = New Button()
        lblWelcome = New Label()
        PanelContainer = New Panel()
        btnViewEmployees = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnMyCrops
        ' 
        btnMyCrops.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMyCrops.Image = CType(resources.GetObject("btnMyCrops.Image"), Image)
        btnMyCrops.ImageAlign = ContentAlignment.MiddleLeft
        btnMyCrops.Location = New Point(30, 430)
        btnMyCrops.Name = "btnMyCrops"
        btnMyCrops.Size = New Size(281, 55)
        btnMyCrops.TabIndex = 0
        btnMyCrops.Text = "Manage Crops"
        btnMyCrops.UseVisualStyleBackColor = True
        ' 
        ' btnInventory
        ' 
        btnInventory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), Image)
        btnInventory.ImageAlign = ContentAlignment.MiddleLeft
        btnInventory.Location = New Point(30, 546)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(281, 55)
        btnInventory.TabIndex = 1
        btnInventory.Text = "View Inventory"
        btnInventory.UseVisualStyleBackColor = True
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalesReport.Image = CType(resources.GetObject("btnSalesReport.Image"), Image)
        btnSalesReport.ImageAlign = ContentAlignment.MiddleLeft
        btnSalesReport.Location = New Point(30, 769)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(275, 55)
        btnSalesReport.TabIndex = 2
        btnSalesReport.Text = "Sales Report"
        btnSalesReport.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), Image)
        btnProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnProfile.Location = New Point(30, 315)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(275, 50)
        btnProfile.TabIndex = 3
        btnProfile.Text = "My Profile"
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(30, 895)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(275, 53)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = SystemColors.ActiveCaptionText
        lblWelcome.Location = New Point(879, 22)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(301, 41)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = """Welcome, Farmer!"""
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.Transparent
        PanelContainer.Location = New Point(357, 85)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1553, 946)
        PanelContainer.TabIndex = 6
        ' 
        ' btnViewEmployees
        ' 
        btnViewEmployees.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewEmployees.Image = CType(resources.GetObject("btnViewEmployees.Image"), Image)
        btnViewEmployees.ImageAlign = ContentAlignment.MiddleLeft
        btnViewEmployees.Location = New Point(30, 657)
        btnViewEmployees.Name = "btnViewEmployees"
        btnViewEmployees.Size = New Size(281, 51)
        btnViewEmployees.TabIndex = 7
        btnViewEmployees.Text = "View Employees"
        btnViewEmployees.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(65, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 185)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Farmer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnSalesReport)
        Controls.Add(btnViewEmployees)
        Controls.Add(btnProfile)
        Controls.Add(PictureBox1)
        Controls.Add(btnInventory)
        Controls.Add(PanelContainer)
        Controls.Add(btnMyCrops)
        Controls.Add(lblWelcome)
        Controls.Add(btnLogout)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Farmer"
        Text = "Farmer"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMyCrops As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnViewEmployees As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
