<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarmerProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarmerProfile))
        lblName = New Label()
        lblContact = New Label()
        lblAddress = New Label()
        lblEmail = New Label()
        txtName = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        btnClose = New Button()
        btnUpdate = New Button()
        btnChangePassword = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = SystemColors.ScrollBar
        lblName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = SystemColors.ActiveCaptionText
        lblName.Location = New Point(131, 109)
        lblName.Name = "lblName"
        lblName.Size = New Size(97, 25)
        lblName.TabIndex = 0
        lblName.Text = "Full Name"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContact.Location = New Point(131, 171)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(78, 25)
        lblContact.TabIndex = 1
        lblContact.Text = "Contact"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(131, 236)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(80, 25)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(131, 306)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(58, 25)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(283, 103)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter your Name"
        txtName.Size = New Size(165, 31)
        txtName.TabIndex = 5
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(283, 165)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "Enter Contact No"
        txtContact.Size = New Size(165, 31)
        txtContact.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(283, 233)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "Enter Address"
        txtAddress.Size = New Size(167, 27)
        txtAddress.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(283, 300)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Email"
        txtEmail.Size = New Size(227, 31)
        txtEmail.TabIndex = 8
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(415, 485)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(105, 39)
        btnClose.TabIndex = 11
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(131, 485)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(152, 39)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update Profile"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChangePassword.Location = New Point(283, 375)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(173, 38)
        btnChangePassword.TabIndex = 16
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = True
        ' 
        ' FarmerProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnChangePassword)
        Controls.Add(btnUpdate)
        Controls.Add(btnClose)
        Controls.Add(txtEmail)
        Controls.Add(txtAddress)
        Controls.Add(txtContact)
        Controls.Add(txtName)
        Controls.Add(lblEmail)
        Controls.Add(lblAddress)
        Controls.Add(lblContact)
        Controls.Add(lblName)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FarmerProfile"
        Text = "FarmerProfile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnChangePassword As Button
End Class
