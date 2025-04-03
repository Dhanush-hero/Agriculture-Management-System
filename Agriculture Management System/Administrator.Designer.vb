<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        btnCrops = New Button()
        btnInventory = New Button()
        btnEmployees = New Button()
        btnSales = New Button()
        btnLogout = New Button()
        lblWelcome = New Label()
        PanelContainer = New Panel()
        btnDashboard = New Button()
        pbChangePassword = New PictureBox()
        CType(pbChangePassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCrops
        ' 
        btnCrops.BackColor = Color.Transparent
        btnCrops.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCrops.ForeColor = Color.Black
        btnCrops.Image = CType(resources.GetObject("btnCrops.Image"), Image)
        btnCrops.ImageAlign = ContentAlignment.MiddleLeft
        btnCrops.Location = New Point(30, 430)
        btnCrops.Name = "btnCrops"
        btnCrops.Size = New Size(281, 55)
        btnCrops.TabIndex = 1
        btnCrops.Text = "Manage Crops"
        btnCrops.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), Image)
        btnInventory.ImageAlign = ContentAlignment.MiddleLeft
        btnInventory.Location = New Point(30, 546)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(281, 51)
        btnInventory.TabIndex = 2
        btnInventory.Text = "Inventory"
        btnInventory.UseVisualStyleBackColor = True
        ' 
        ' btnEmployees
        ' 
        btnEmployees.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmployees.Image = CType(resources.GetObject("btnEmployees.Image"), Image)
        btnEmployees.ImageAlign = ContentAlignment.MiddleLeft
        btnEmployees.Location = New Point(30, 657)
        btnEmployees.Name = "btnEmployees"
        btnEmployees.Size = New Size(275, 50)
        btnEmployees.TabIndex = 3
        btnEmployees.Text = "Employee"
        btnEmployees.UseVisualStyleBackColor = True
        ' 
        ' btnSales
        ' 
        btnSales.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSales.Image = CType(resources.GetObject("btnSales.Image"), Image)
        btnSales.ImageAlign = ContentAlignment.MiddleLeft
        btnSales.Location = New Point(30, 769)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(275, 55)
        btnSales.TabIndex = 4
        btnSales.Text = "Sales And Revenue"
        btnSales.TextAlign = ContentAlignment.MiddleRight
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = SystemColors.ControlText
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(30, 895)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(275, 53)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(790, 21)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(297, 41)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = """Welcome, Admin!"""
        ' 
        ' PanelContainer
        ' 
        PanelContainer.BackColor = Color.Transparent
        PanelContainer.Location = New Point(357, 85)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(1553, 946)
        PanelContainer.TabIndex = 7
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackgroundImageLayout = ImageLayout.Stretch
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(30, 315)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(281, 55)
        btnDashboard.TabIndex = 8
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' pbChangePassword
        ' 
        pbChangePassword.Image = CType(resources.GetObject("pbChangePassword.Image"), Image)
        pbChangePassword.Location = New Point(84, 85)
        pbChangePassword.Name = "pbChangePassword"
        pbChangePassword.Size = New Size(164, 160)
        pbChangePassword.TabIndex = 9
        pbChangePassword.TabStop = False
        ' 
        ' Administrator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(pbChangePassword)
        Controls.Add(btnDashboard)
        Controls.Add(btnLogout)
        Controls.Add(btnSales)
        Controls.Add(PanelContainer)
        Controls.Add(lblWelcome)
        Controls.Add(btnEmployees)
        Controls.Add(btnInventory)
        Controls.Add(btnCrops)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Administrator"
        Text = "Administrator"
        WindowState = FormWindowState.Maximized
        CType(pbChangePassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCrops As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pbChangePassword As PictureBox
End Class
