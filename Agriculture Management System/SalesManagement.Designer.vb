<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesManagement))
        lblCrop = New Label()
        lblInventory = New Label()
        lblQuantity = New Label()
        lblSalePrice = New Label()
        cmbCrop = New ComboBox()
        cmbInventory = New ComboBox()
        txtQuantity = New TextBox()
        txtSalePrice = New TextBox()
        btnAddSale = New Button()
        btnUpdateSale = New Button()
        btnDeleteSale = New Button()
        btnClear = New Button()
        dgvSales = New DataGridView()
        btnSalesReport = New Button()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCrop
        ' 
        lblCrop.AutoSize = True
        lblCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCrop.Location = New Point(45, 84)
        lblCrop.Name = "lblCrop"
        lblCrop.Size = New Size(49, 23)
        lblCrop.TabIndex = 0
        lblCrop.Text = "Crop"
        ' 
        ' lblInventory
        ' 
        lblInventory.AutoSize = True
        lblInventory.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventory.Location = New Point(45, 153)
        lblInventory.Name = "lblInventory"
        lblInventory.Size = New Size(87, 23)
        lblInventory.TabIndex = 1
        lblInventory.Text = "Inventory"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(45, 213)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(80, 23)
        lblQuantity.TabIndex = 2
        lblQuantity.Text = "Quantity"
        ' 
        ' lblSalePrice
        ' 
        lblSalePrice.AutoSize = True
        lblSalePrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSalePrice.Location = New Point(45, 275)
        lblSalePrice.Name = "lblSalePrice"
        lblSalePrice.Size = New Size(114, 23)
        lblSalePrice.TabIndex = 3
        lblSalePrice.Text = "Sale Price (₹)"
        ' 
        ' cmbCrop
        ' 
        cmbCrop.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCrop.FormattingEnabled = True
        cmbCrop.Location = New Point(231, 76)
        cmbCrop.Name = "cmbCrop"
        cmbCrop.Size = New Size(151, 31)
        cmbCrop.TabIndex = 4
        ' 
        ' cmbInventory
        ' 
        cmbInventory.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbInventory.FormattingEnabled = True
        cmbInventory.Location = New Point(231, 145)
        cmbInventory.Name = "cmbInventory"
        cmbInventory.Size = New Size(151, 31)
        cmbInventory.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(231, 206)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(151, 30)
        txtQuantity.TabIndex = 6
        ' 
        ' txtSalePrice
        ' 
        txtSalePrice.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSalePrice.Location = New Point(231, 268)
        txtSalePrice.Name = "txtSalePrice"
        txtSalePrice.Size = New Size(151, 30)
        txtSalePrice.TabIndex = 7
        ' 
        ' btnAddSale
        ' 
        btnAddSale.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddSale.Location = New Point(45, 431)
        btnAddSale.Name = "btnAddSale"
        btnAddSale.Size = New Size(94, 29)
        btnAddSale.TabIndex = 8
        btnAddSale.Text = "Add"
        btnAddSale.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateSale
        ' 
        btnUpdateSale.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateSale.Location = New Point(190, 431)
        btnUpdateSale.Name = "btnUpdateSale"
        btnUpdateSale.Size = New Size(94, 29)
        btnUpdateSale.TabIndex = 9
        btnUpdateSale.Text = "Update"
        btnUpdateSale.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteSale
        ' 
        btnDeleteSale.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteSale.Location = New Point(346, 431)
        btnDeleteSale.Name = "btnDeleteSale"
        btnDeleteSale.Size = New Size(94, 29)
        btnDeleteSale.TabIndex = 10
        btnDeleteSale.Text = "Delete"
        btnDeleteSale.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(512, 431)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvSales
        ' 
        dgvSales.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSales.DefaultCellStyle = DataGridViewCellStyle2
        dgvSales.Location = New Point(686, 34)
        dgvSales.Name = "dgvSales"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSales.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSales.RowHeadersWidth = 51
        dgvSales.Size = New Size(808, 458)
        dgvSales.TabIndex = 12
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalesReport.Location = New Point(45, 353)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(172, 29)
        btnSalesReport.TabIndex = 13
        btnSalesReport.Text = "View Sales Report"
        btnSalesReport.UseVisualStyleBackColor = True
        ' 
        ' SalesManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnSalesReport)
        Controls.Add(dgvSales)
        Controls.Add(btnClear)
        Controls.Add(btnDeleteSale)
        Controls.Add(btnUpdateSale)
        Controls.Add(btnAddSale)
        Controls.Add(txtSalePrice)
        Controls.Add(txtQuantity)
        Controls.Add(cmbInventory)
        Controls.Add(cmbCrop)
        Controls.Add(lblSalePrice)
        Controls.Add(lblQuantity)
        Controls.Add(lblInventory)
        Controls.Add(lblCrop)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SalesManagement"
        Text = "SalesManagement"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCrop As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblSalePrice As Label
    Friend WithEvents cmbCrop As ComboBox
    Friend WithEvents cmbInventory As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtSalePrice As TextBox
    Friend WithEvents btnAddSale As Button
    Friend WithEvents btnUpdateSale As Button
    Friend WithEvents btnDeleteSale As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents btnSalesReport As Button
End Class
