<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        btnUpdatePassword = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(109, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(265, 91)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(125, 31)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(265, 151)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(125, 31)
        txtPassword.TabIndex = 3
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Location = New Point(234, 224)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(156, 27)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnUpdatePassword
        ' 
        btnUpdatePassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdatePassword.Location = New Point(109, 323)
        btnUpdatePassword.Name = "btnUpdatePassword"
        btnUpdatePassword.Size = New Size(176, 36)
        btnUpdatePassword.TabIndex = 5
        btnUpdatePassword.Text = "Change Password"
        btnUpdatePassword.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(381, 323)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 36)
        btnClose.TabIndex = 6
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnUpdatePassword)
        Controls.Add(chkShowPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ChangePassword"
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnUpdatePassword As Button
    Friend WithEvents btnClose As Button
End Class
