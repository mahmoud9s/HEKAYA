<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up))
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        txtPhoneNumber = New TextBox()
        Label4 = New Label()
        txtPassword = New TextBox()
        txtEmailAddress = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtConfirmPassword = New TextBox()
        btnSignUp = New Button()
        LinkLabel2 = New LinkLabel()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
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
        Label2.Location = New Point(749, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(412, 123)
        Label2.TabIndex = 6
        Label2.Text = "Hekaya"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Copperplate Gothic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(866, 394)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 28)
        Label1.TabIndex = 7
        Label1.Text = "Sign Up"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(641, 498)
        Label5.Name = "Label5"
        Label5.Size = New Size(308, 32)
        Label5.TabIndex = 14
        Label5.Text = "Phone Number:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Anchor = AnchorStyles.None
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Segoe UI", 15F)
        txtPhoneNumber.Location = New Point(954, 504)
        txtPhoneNumber.Margin = New Padding(3, 2, 3, 2)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(222, 34)
        txtPhoneNumber.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(719, 554)
        Label4.Name = "Label4"
        Label4.Size = New Size(229, 32)
        Label4.TabIndex = 18
        Label4.Text = "Password:"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.None
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 15F)
        txtPassword.Location = New Point(954, 555)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(222, 34)
        txtPassword.TabIndex = 17
        ' 
        ' txtEmailAddress
        ' 
        txtEmailAddress.Anchor = AnchorStyles.None
        txtEmailAddress.BorderStyle = BorderStyle.FixedSingle
        txtEmailAddress.Font = New Font("Segoe UI", 15F)
        txtEmailAddress.Location = New Point(954, 453)
        txtEmailAddress.Margin = New Padding(3, 2, 3, 2)
        txtEmailAddress.Name = "txtEmailAddress"
        txtEmailAddress.Size = New Size(222, 34)
        txtEmailAddress.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.BackColor = Color.Transparent
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(641, 448)
        Label6.Name = "Label6"
        Label6.Size = New Size(308, 32)
        Label6.TabIndex = 15
        Label6.Text = "Email Address:"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(583, 600)
        Label7.Name = "Label7"
        Label7.Size = New Size(366, 32)
        Label7.TabIndex = 20
        Label7.Text = "Confirm Password:"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Anchor = AnchorStyles.None
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 15F)
        txtConfirmPassword.Location = New Point(954, 606)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(222, 34)
        txtConfirmPassword.TabIndex = 19
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Anchor = AnchorStyles.Bottom
        btnSignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSignUp.BackColor = Color.White
        btnSignUp.Font = New Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        btnSignUp.Location = New Point(832, 701)
        btnSignUp.Margin = New Padding(3, 2, 3, 2)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(192, 34)
        btnSignUp.TabIndex = 21
        btnSignUp.Text = "SIGN UP"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.Blue
        LinkLabel2.Anchor = AnchorStyles.Bottom
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Sitka Heading", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(978, 738)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(86, 24)
        LinkLabel2.TabIndex = 23
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "LOGIN"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sitka Display", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(776, 738)
        Label8.Name = "Label8"
        Label8.Size = New Size(191, 26)
        Label8.TabIndex = 22
        Label8.Text = "Already have an account?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(1728, 26)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 114)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' lblMessage
        ' 
        lblMessage.Anchor = AnchorStyles.Bottom
        lblMessage.AutoSize = True
        lblMessage.BackColor = Color.Transparent
        lblMessage.Font = New Font("Sitka Display", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMessage.Location = New Point(899, 661)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(16, 26)
        lblMessage.TabIndex = 25
        lblMessage.Text = " "
        ' 
        ' Sign_Up
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1904, 1041)
        Controls.Add(lblMessage)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel2)
        Controls.Add(Label8)
        Controls.Add(btnSignUp)
        Controls.Add(Label7)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(txtEmailAddress)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label1)
        Controls.Add(Label2)
        DoubleBuffered = True
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Sign_Up"
        Text = "Sign_Up"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMessage As Label
End Class
