<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        lblStartDate = New Label()
        lblEndDate = New Label()
        lblCropFilter = New Label()
        lblInventoryFilter = New Label()
        lblTotalRevenue = New Label()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        cmbCropFilter = New ComboBox()
        cmbInventoryFilter = New ComboBox()
        btnFilter = New Button()
        btnClearFilters = New Button()
        dgvSalesReport = New DataGridView()
        CType(dgvSalesReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStartDate.Location = New Point(33, 46)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(93, 23)
        lblStartDate.TabIndex = 0
        lblStartDate.Text = "Start Date"
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEndDate.Location = New Point(33, 112)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(83, 23)
        lblEndDate.TabIndex = 1
        lblEndDate.Text = "End Date"
        ' 
        ' lblCropFilter
        ' 
        lblCropFilter.AutoSize = True
        lblCropFilter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCropFilter.Location = New Point(33, 178)
        lblCropFilter.Name = "lblCropFilter"
        lblCropFilter.Size = New Size(102, 23)
        lblCropFilter.TabIndex = 2
        lblCropFilter.Text = "Select Crop"
        ' 
        ' lblInventoryFilter
        ' 
        lblInventoryFilter.AutoSize = True
        lblInventoryFilter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInventoryFilter.Location = New Point(33, 242)
        lblInventoryFilter.Name = "lblInventoryFilter"
        lblInventoryFilter.Size = New Size(140, 23)
        lblInventoryFilter.TabIndex = 3
        lblInventoryFilter.Text = "Select Inventory"
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.Location = New Point(33, 321)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(192, 25)
        lblTotalRevenue.TabIndex = 4
        lblTotalRevenue.Text = "Shows Total Revenue"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(217, 39)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(250, 30)
        dtpStartDate.TabIndex = 5
        dtpStartDate.Value = New Date(2025, 3, 1, 0, 0, 0, 0)
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(217, 105)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 30)
        dtpEndDate.TabIndex = 6
        ' 
        ' cmbCropFilter
        ' 
        cmbCropFilter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCropFilter.FormattingEnabled = True
        cmbCropFilter.Location = New Point(217, 170)
        cmbCropFilter.Name = "cmbCropFilter"
        cmbCropFilter.Size = New Size(151, 31)
        cmbCropFilter.TabIndex = 7
        ' 
        ' cmbInventoryFilter
        ' 
        cmbInventoryFilter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbInventoryFilter.FormattingEnabled = True
        cmbInventoryFilter.Location = New Point(217, 234)
        cmbInventoryFilter.Name = "cmbInventoryFilter"
        cmbInventoryFilter.Size = New Size(151, 31)
        cmbInventoryFilter.TabIndex = 8
        ' 
        ' btnFilter
        ' 
        btnFilter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFilter.Location = New Point(33, 409)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(113, 29)
        btnFilter.TabIndex = 9
        btnFilter.Text = "Filter Report"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnClearFilters
        ' 
        btnClearFilters.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClearFilters.Location = New Point(244, 409)
        btnClearFilters.Name = "btnClearFilters"
        btnClearFilters.Size = New Size(124, 29)
        btnClearFilters.TabIndex = 10
        btnClearFilters.Text = "Clear Filters"
        btnClearFilters.UseVisualStyleBackColor = True
        ' 
        ' dgvSalesReport
        ' 
        dgvSalesReport.BackgroundColor = SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSalesReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSalesReport.DefaultCellStyle = DataGridViewCellStyle2
        dgvSalesReport.Location = New Point(528, 39)
        dgvSalesReport.Name = "dgvSalesReport"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSalesReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSalesReport.RowHeadersWidth = 51
        dgvSalesReport.Size = New Size(908, 458)
        dgvSalesReport.TabIndex = 12
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(dgvSalesReport)
        Controls.Add(btnClearFilters)
        Controls.Add(btnFilter)
        Controls.Add(cmbInventoryFilter)
        Controls.Add(cmbCropFilter)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(lblTotalRevenue)
        Controls.Add(lblInventoryFilter)
        Controls.Add(lblCropFilter)
        Controls.Add(lblEndDate)
        Controls.Add(lblStartDate)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SalesReport"
        Text = "SalesReport"
        CType(dgvSalesReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblCropFilter As Label
    Friend WithEvents lblInventoryFilter As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents cmbCropFilter As ComboBox
    Friend WithEvents cmbInventoryFilter As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents dgvSalesReport As DataGridView
End Class
