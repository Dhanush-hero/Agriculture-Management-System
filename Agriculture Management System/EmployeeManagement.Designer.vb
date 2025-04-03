<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeManagement
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeManagement))
        lblName = New Label()
        lblContact = New Label()
        lblSalary = New Label()
        lblEmployeeType = New Label()
        lblFarm = New Label()
        txtName = New TextBox()
        txtContact = New TextBox()
        txtSalary = New TextBox()
        cmbRole = New ComboBox()
        cmbFarm = New ComboBox()
        btnAddEmployee = New Button()
        btnUpdateEmployee = New Button()
        btnDeleteEmployee = New Button()
        btnClear = New Button()
        dgvEmployees = New DataGridView()
        lblCrop = New Label()
        lblInventory = New Label()
        cmbCrop = New ComboBox()
        cmbInventory = New ComboBox()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(31, 61)
        lblName.Name = "lblName"
        lblName.Size = New Size(57, 23)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContact.Location = New Point(31, 127)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(72, 23)
        lblContact.TabIndex = 2
        lblContact.Text = "Contact"
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalary.Location = New Point(31, 185)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(60, 23)
        lblSalary.TabIndex = 3
        lblSalary.Text = "Salary"
        ' 
        ' lblEmployeeType
        ' 
        lblEmployeeType.AutoSize = True
        lblEmployeeType.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmployeeType.Location = New Point(31, 250)
        lblEmployeeType.Name = "lblEmployeeType"
        lblEmployeeType.Size = New Size(131, 23)
        lblEmployeeType.TabIndex = 4
        lblEmployeeType.Text = "Employee Type"
        ' 
        ' lblFarm
        ' 
        lblFarm.AutoSize = True
        lblFarm.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFarm.Location = New Point(31, 314)
        lblFarm.Name = "lblFarm"
        lblFarm.Size = New Size(50, 23)
        lblFarm.TabIndex = 5
        lblFarm.Text = "Farm"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(217, 61)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter Employee Name"
        txtName.Size = New Size(188, 30)
        txtName.TabIndex = 6
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(217, 120)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "Enter Contact No"
        txtContact.Size = New Size(188, 30)
        txtContact.TabIndex = 8
        ' 
        ' txtSalary
        ' 
        txtSalary.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSalary.Location = New Point(217, 178)
        txtSalary.Name = "txtSalary"
        txtSalary.PlaceholderText = "Enter Salary"
        txtSalary.Size = New Size(188, 30)
        txtSalary.TabIndex = 9
        ' 
        ' cmbRole
        ' 
        cmbRole.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Worker", "Supervisor", "Manager"})
        cmbRole.Location = New Point(217, 242)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 31)
        cmbRole.TabIndex = 10
        cmbRole.Text = "Employee type"
        ' 
        ' cmbFarm
        ' 
        cmbFarm.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbFarm.FormattingEnabled = True
        cmbFarm.Location = New Point(217, 306)
        cmbFarm.Name = "cmbFarm"
        cmbFarm.Size = New Size(151, 31)
        cmbFarm.TabIndex = 11
        cmbFarm.Text = "Select Farm"
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.Location = New Point(31, 532)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(94, 29)
        btnAddEmployee.TabIndex = 12
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateEmployee.Location = New Point(181, 532)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(94, 29)
        btnUpdateEmployee.TabIndex = 13
        btnUpdateEmployee.Text = "Update"
        btnUpdateEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteEmployee.Location = New Point(341, 532)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(94, 29)
        btnDeleteEmployee.TabIndex = 14
        btnDeleteEmployee.Text = "Delete"
        btnDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(508, 532)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvEmployees.DefaultCellStyle = DataGridViewCellStyle2
        dgvEmployees.Location = New Point(508, 44)
        dgvEmployees.Name = "dgvEmployees"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(917, 458)
        dgvEmployees.TabIndex = 16
        ' 
        ' lblCrop
        ' 
        lblCrop.AutoSize = True
        lblCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCrop.Location = New Point(31, 381)
        lblCrop.Name = "lblCrop"
        lblCrop.Size = New Size(106, 23)
        lblCrop.TabIndex = 17
        lblCrop.Text = "Assign Crop"
        ' 
        ' lblInventory
        ' 
        lblInventory.AutoSize = True
        lblInventory.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventory.Location = New Point(31, 447)
        lblInventory.Name = "lblInventory"
        lblInventory.Size = New Size(144, 23)
        lblInventory.TabIndex = 18
        lblInventory.Text = "Assign Inventory"
        ' 
        ' cmbCrop
        ' 
        cmbCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCrop.FormattingEnabled = True
        cmbCrop.Location = New Point(217, 373)
        cmbCrop.Name = "cmbCrop"
        cmbCrop.Size = New Size(151, 31)
        cmbCrop.TabIndex = 19
        cmbCrop.Text = "Assign Crops"
        ' 
        ' cmbInventory
        ' 
        cmbInventory.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbInventory.FormattingEnabled = True
        cmbInventory.Location = New Point(217, 439)
        cmbInventory.Name = "cmbInventory"
        cmbInventory.Size = New Size(151, 31)
        cmbInventory.TabIndex = 20
        cmbInventory.Text = "Assign inventory"
        ' 
        ' EmployeeManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(cmbInventory)
        Controls.Add(cmbCrop)
        Controls.Add(lblInventory)
        Controls.Add(lblCrop)
        Controls.Add(dgvEmployees)
        Controls.Add(btnClear)
        Controls.Add(btnDeleteEmployee)
        Controls.Add(btnUpdateEmployee)
        Controls.Add(btnAddEmployee)
        Controls.Add(cmbFarm)
        Controls.Add(cmbRole)
        Controls.Add(txtSalary)
        Controls.Add(txtContact)
        Controls.Add(txtName)
        Controls.Add(lblFarm)
        Controls.Add(lblEmployeeType)
        Controls.Add(lblSalary)
        Controls.Add(lblContact)
        Controls.Add(lblName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EmployeeManagement"
        Text = "EmployeeManagement"
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblEmployeeType As Label
    Friend WithEvents lblFarm As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents cmbFarm As ComboBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents lblCrop As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents cmbCrop As ComboBox
    Friend WithEvents cmbInventory As ComboBox
End Class
