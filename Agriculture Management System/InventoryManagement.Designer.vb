<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryManagement))
        dgvInventory = New DataGridView()
        lblItemName = New Label()
        lblQuantity = New Label()
        lblPurchaseDate = New Label()
        lblExpiryDate = New Label()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        dtpPurchaseDate = New DateTimePicker()
        dtpExpiryDate = New DateTimePicker()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        cmbCrop = New ComboBox()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvInventory
        ' 
        dgvInventory.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvInventory.DefaultCellStyle = DataGridViewCellStyle2
        dgvInventory.Location = New Point(631, 53)
        dgvInventory.Name = "dgvInventory"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvInventory.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.Size = New Size(827, 458)
        dgvInventory.TabIndex = 0
        ' 
        ' lblItemName
        ' 
        lblItemName.AutoSize = True
        lblItemName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblItemName.Location = New Point(39, 96)
        lblItemName.Name = "lblItemName"
        lblItemName.Size = New Size(99, 23)
        lblItemName.TabIndex = 1
        lblItemName.Text = "Item Name"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(39, 161)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(80, 23)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity"
        ' 
        ' lblPurchaseDate
        ' 
        lblPurchaseDate.AutoSize = True
        lblPurchaseDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPurchaseDate.Location = New Point(39, 232)
        lblPurchaseDate.Name = "lblPurchaseDate"
        lblPurchaseDate.Size = New Size(123, 23)
        lblPurchaseDate.TabIndex = 3
        lblPurchaseDate.Text = "Purchase Date"
        ' 
        ' lblExpiryDate
        ' 
        lblExpiryDate.AutoSize = True
        lblExpiryDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExpiryDate.Location = New Point(39, 294)
        lblExpiryDate.Name = "lblExpiryDate"
        lblExpiryDate.Size = New Size(104, 23)
        lblExpiryDate.TabIndex = 4
        lblExpiryDate.Text = "Expiry Date"
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtItemName.Location = New Point(212, 89)
        txtItemName.Name = "txtItemName"
        txtItemName.PlaceholderText = "Enter Item Name"
        txtItemName.Size = New Size(150, 30)
        txtItemName.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(212, 154)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.PlaceholderText = "Enter Quantity"
        txtQuantity.Size = New Size(150, 30)
        txtQuantity.TabIndex = 6
        ' 
        ' dtpPurchaseDate
        ' 
        dtpPurchaseDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpPurchaseDate.Format = DateTimePickerFormat.Short
        dtpPurchaseDate.Location = New Point(212, 226)
        dtpPurchaseDate.Name = "dtpPurchaseDate"
        dtpPurchaseDate.Size = New Size(250, 30)
        dtpPurchaseDate.TabIndex = 7
        dtpPurchaseDate.Value = New Date(2025, 3, 1, 0, 0, 0, 0)
        ' 
        ' dtpExpiryDate
        ' 
        dtpExpiryDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpExpiryDate.Format = DateTimePickerFormat.Short
        dtpExpiryDate.Location = New Point(212, 287)
        dtpExpiryDate.Name = "dtpExpiryDate"
        dtpExpiryDate.Size = New Size(250, 30)
        dtpExpiryDate.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(39, 465)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(163, 465)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(294, 465)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(438, 465)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' cmbCrop
        ' 
        cmbCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCrop.FormattingEnabled = True
        cmbCrop.Location = New Point(212, 356)
        cmbCrop.Name = "cmbCrop"
        cmbCrop.Size = New Size(151, 31)
        cmbCrop.TabIndex = 13
        ' 
        ' InventoryManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(cmbCrop)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dtpExpiryDate)
        Controls.Add(dtpPurchaseDate)
        Controls.Add(txtQuantity)
        Controls.Add(txtItemName)
        Controls.Add(lblExpiryDate)
        Controls.Add(lblPurchaseDate)
        Controls.Add(lblQuantity)
        Controls.Add(lblItemName)
        Controls.Add(dgvInventory)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "InventoryManagement"
        Text = "InventoryManagement"
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPurchaseDate As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents dtpPurchaseDate As DateTimePicker
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbCrop As ComboBox
End Class
