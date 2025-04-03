<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        btnReset = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.Window
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(62, 11)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = " Username"
        txtUsername.Size = New Size(201, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(60, 10)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = " Password"
        txtPassword.Size = New Size(201, 31)
        txtPassword.TabIndex = 4
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.BackColor = Color.Transparent
        chkShowPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkShowPassword.Image = CType(resources.GetObject("chkShowPassword.Image"), Image)
        chkShowPassword.ImageAlign = ContentAlignment.MiddleLeft
        chkShowPassword.Location = New Point(240, 347)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(153, 32)
        chkShowPassword.TabIndex = 5
        chkShowPassword.Text = "     Password"
        chkShowPassword.TextAlign = ContentAlignment.MiddleRight
        chkShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.RoyalBlue
        btnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.ImageAlign = ContentAlignment.MiddleLeft
        btnLogin.Location = New Point(84, 411)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(321, 40)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Transparent
        btnReset.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ImageAlign = ContentAlignment.MiddleLeft
        btnReset.Location = New Point(84, 457)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(321, 40)
        btnReset.TabIndex = 7
        btnReset.Text = "Clear"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(btnReset)
        Panel1.Location = New Point(1313, 282)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(488, 559)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 38)
        Label1.TabIndex = 12
        Label1.Text = "Sign In"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(81, 278)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(336, 50)
        Panel3.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 41)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(79, 217)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 50)
        Panel2.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 41)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(170, 32)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(141, 113)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1033)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Login"
        TopMost = True
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
