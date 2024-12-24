<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_page))
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtEmailAddress = New TextBox()
        txtPassword = New TextBox()
        Label5 = New Label()
        btnLogin = New Button()
        Label6 = New Label()
        LinkLabel2 = New LinkLabel()
        lblMessage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Calisto MT", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(704, 398)
        Label2.Name = "Label2"
        Label2.Size = New Size(370, 121)
        Label2.TabIndex = 5
        Label2.Text = "Hekaya"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(802, 198)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 30)
        Label1.TabIndex = 3
        Label1.Text = "WELCOME TO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(819, 269)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 114)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(661, 557)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 32)
        Label3.TabIndex = 6
        Label3.Text = "Username:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Anchor = AnchorStyles.None
        txtEmailAddress.BorderStyle = BorderStyle.FixedSingle
        txtEmailAddress.Font = New Font("Segoe UI", 15F)
        txtEmailAddress.Location = New Point(896, 557)
        txtEmailAddress.Margin = New Padding(3, 2, 3, 2)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(222, 34)
        txtEmailAddress.TabIndex = 8
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 15F)
        txtPassword.Location = New Point(896, 609)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(222, 34)
        txtPassword.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(661, 611)
        Label5.Name = "Label5"
        Label5.Size = New Size(229, 32)
        Label5.TabIndex = 10
        Label5.Text = "Password:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogin.BackColor = Color.White
        btnLogin.Font = New Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        btnLogin.Location = New Point(802, 746)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(192, 34)
        btnLogin.TabIndex = 11
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Display", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(754, 705)
        Label6.Name = "Label6"
        Label6.Size = New Size(197, 26)
        Label6.TabIndex = 12
        Label6.Text = "If you don’t have account, "
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.Blue
        LinkLabel2.Anchor = AnchorStyles.None
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Sitka Heading", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(944, 705)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(86, 24)
        LinkLabel2.TabIndex = 13
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Sign Up"
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.None
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Sitka Display", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMessage.Location = New Point(797, 669)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 26)
        lblMessage.TabIndex = 12
        ' 
        ' Login_page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(LinkLabel2)
        Controls.Add(lblMessage)
        Controls.Add(Label6)
        Controls.Add(btnLogin)
        Controls.Add(Label5)
        Controls.Add(txtPassword)
        Controls.Add(txtEmailAddress)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login_page"
        Text = "Login Page"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents lblMessage As Label
End Class
