<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePasswordAdmin))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        chkShowPassword = New CheckBox()
        btnUpdatePassword = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(234, 95)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 31)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(234, 155)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(105, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Location = New Point(234, 215)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(156, 27)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnUpdatePassword
        ' 
        btnUpdatePassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePassword.Location = New Point(105, 292)
        btnUpdatePassword.Name = "btnUpdatePassword"
        btnUpdatePassword.Size = New Size(171, 36)
        btnUpdatePassword.TabIndex = 5
        btnUpdatePassword.Text = "Change Password"
        btnUpdatePassword.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(404, 292)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 36)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' ChangePasswordAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnUpdatePassword)
        Controls.Add(chkShowPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ChangePasswordAdmin"
        Text = "ChangePasswordAdmin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnUpdatePassword As Button
    Friend WithEvents btnClose As Button
End Class
