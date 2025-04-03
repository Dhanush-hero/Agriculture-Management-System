<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CropManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CropManagement))
        lblPlantingDate = New Label()
        dtpPlanting = New DateTimePicker()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        btnAddCrop = New Button()
        btnDeleteCrop = New Button()
        DataGridView1 = New DataGridView()
        lblCropName = New Label()
        txtCropName = New TextBox()
        lblHarvestDate = New Label()
        dtpHarvest = New DateTimePicker()
        btnEditCrop = New Button()
        txtCropID = New TextBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPlantingDate
        ' 
        lblPlantingDate.AutoSize = True
        lblPlantingDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlantingDate.Location = New Point(69, 214)
        lblPlantingDate.Name = "lblPlantingDate"
        lblPlantingDate.Size = New Size(120, 23)
        lblPlantingDate.TabIndex = 5
        lblPlantingDate.Text = "Planting Date"
        ' 
        ' dtpPlanting
        ' 
        dtpPlanting.CalendarFont = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpPlanting.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpPlanting.Format = DateTimePickerFormat.Short
        dtpPlanting.Location = New Point(231, 207)
        dtpPlanting.Name = "dtpPlanting"
        dtpPlanting.Size = New Size(250, 30)
        dtpPlanting.TabIndex = 6
        dtpPlanting.Value = New Date(2025, 3, 1, 0, 0, 0, 0)
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(231, 364)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.PlaceholderText = "Enter quantity"
        txtQuantity.Size = New Size(137, 30)
        txtQuantity.TabIndex = 9
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(66, 371)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(118, 23)
        lblQuantity.TabIndex = 10
        lblQuantity.Text = "Quantity (kg)"
        ' 
        ' btnAddCrop
        ' 
        btnAddCrop.BackColor = Color.Transparent
        btnAddCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCrop.Location = New Point(67, 472)
        btnAddCrop.Name = "btnAddCrop"
        btnAddCrop.Size = New Size(94, 29)
        btnAddCrop.TabIndex = 13
        btnAddCrop.Text = "Add Crop"
        btnAddCrop.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCrop
        ' 
        btnDeleteCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteCrop.Location = New Point(262, 472)
        btnDeleteCrop.Name = "btnDeleteCrop"
        btnDeleteCrop.Size = New Size(94, 29)
        btnDeleteCrop.TabIndex = 15
        btnDeleteCrop.Text = "Delete Crop"
        btnDeleteCrop.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.GridColor = Color.Silver
        DataGridView1.Location = New Point(777, 53)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ButtonShadow
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(681, 458)
        DataGridView1.TabIndex = 17
        ' 
        ' lblCropName
        ' 
        lblCropName.AutoSize = True
        lblCropName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCropName.Location = New Point(66, 143)
        lblCropName.Name = "lblCropName"
        lblCropName.Size = New Size(101, 23)
        lblCropName.TabIndex = 18
        lblCropName.Text = "Crop Name"
        ' 
        ' txtCropName
        ' 
        txtCropName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCropName.Location = New Point(231, 136)
        txtCropName.Name = "txtCropName"
        txtCropName.PlaceholderText = "Enter Crop Name"
        txtCropName.Size = New Size(158, 30)
        txtCropName.TabIndex = 19
        ' 
        ' lblHarvestDate
        ' 
        lblHarvestDate.AutoSize = True
        lblHarvestDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarvestDate.Location = New Point(66, 293)
        lblHarvestDate.Name = "lblHarvestDate"
        lblHarvestDate.Size = New Size(115, 23)
        lblHarvestDate.TabIndex = 22
        lblHarvestDate.Text = "Harvest Date"
        ' 
        ' dtpHarvest
        ' 
        dtpHarvest.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpHarvest.Format = DateTimePickerFormat.Short
        dtpHarvest.Location = New Point(231, 286)
        dtpHarvest.Name = "dtpHarvest"
        dtpHarvest.Size = New Size(250, 30)
        dtpHarvest.TabIndex = 23
        ' 
        ' btnEditCrop
        ' 
        btnEditCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditCrop.Location = New Point(465, 472)
        btnEditCrop.Name = "btnEditCrop"
        btnEditCrop.Size = New Size(94, 29)
        btnEditCrop.TabIndex = 24
        btnEditCrop.Text = "Update"
        btnEditCrop.UseVisualStyleBackColor = True
        ' 
        ' txtCropID
        ' 
        txtCropID.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCropID.Location = New Point(231, 64)
        txtCropID.Name = "txtCropID"
        txtCropID.Size = New Size(125, 30)
        txtCropID.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 23)
        Label1.TabIndex = 26
        Label1.Text = "Crop ID"
        ' 
        ' CropManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label1)
        Controls.Add(txtCropID)
        Controls.Add(btnEditCrop)
        Controls.Add(dtpHarvest)
        Controls.Add(lblHarvestDate)
        Controls.Add(txtCropName)
        Controls.Add(lblCropName)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteCrop)
        Controls.Add(btnAddCrop)
        Controls.Add(lblQuantity)
        Controls.Add(txtQuantity)
        Controls.Add(dtpPlanting)
        Controls.Add(lblPlantingDate)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CropManagement"
        Text = "CropManagement"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblPlantingDate As Label
    Friend WithEvents dtpPlanting As DateTimePicker
    Friend WithEvents dtpHarvestDate As DateTimePicker
    Friend WithEvents lblHarvestDate As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAddCrop As Button
    Friend WithEvents btnDeleteCrop As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCropName As Label
    Friend WithEvents txtCropName As TextBox
    Friend WithEvents dtpHarvest As DateTimePicker
    Friend WithEvents btnEditCrop As Button
    Friend WithEvents txtCropID As TextBox
    Friend WithEvents Label1 As Label
End Class
