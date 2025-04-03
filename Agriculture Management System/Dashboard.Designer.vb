<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        lblTotalCrops = New Label()
        lblTotalInventory = New Label()
        lblTotalEmployees = New Label()
        lblTotalSales = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTotalCrops
        ' 
        lblTotalCrops.AutoSize = True
        lblTotalCrops.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCrops.Location = New Point(28, 180)
        lblTotalCrops.Name = "lblTotalCrops"
        lblTotalCrops.Size = New Size(273, 41)
        lblTotalCrops.TabIndex = 0
        lblTotalCrops.Text = "Total No of Crops:"
        ' 
        ' lblTotalInventory
        ' 
        lblTotalInventory.AutoSize = True
        lblTotalInventory.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalInventory.Location = New Point(1, 180)
        lblTotalInventory.Name = "lblTotalInventory"
        lblTotalInventory.Size = New Size(337, 41)
        lblTotalInventory.TabIndex = 1
        lblTotalInventory.Text = "Total No of Inventory :"
        ' 
        ' lblTotalEmployees
        ' 
        lblTotalEmployees.AutoSize = True
        lblTotalEmployees.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalEmployees.Location = New Point(0, 178)
        lblTotalEmployees.Name = "lblTotalEmployees"
        lblTotalEmployees.Size = New Size(342, 41)
        lblTotalEmployees.TabIndex = 2
        lblTotalEmployees.Text = "Total No of Employees:"
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSales.Location = New Point(31, 178)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(271, 41)
        lblTotalSales.TabIndex = 3
        lblTotalSales.Text = "Total No of Sales :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(93, 18)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(141, 139)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(97, 18)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(143, 139)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(88, 21)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(141, 135)
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(101, 17)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(149, 135)
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(lblTotalCrops)
        Panel1.Location = New Point(104, 51)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(338, 278)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(lblTotalInventory)
        Panel2.Location = New Point(868, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 278)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(lblTotalEmployees)
        Panel3.Location = New Point(104, 505)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(338, 278)
        Panel3.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(lblTotalSales)
        Panel4.Location = New Point(868, 505)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(338, 278)
        Panel4.TabIndex = 11
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTotalCrops As Label
    Friend WithEvents lblTotalInventory As Label
    Friend WithEvents lblTotalEmployees As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
