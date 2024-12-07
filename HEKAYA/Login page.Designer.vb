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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        LinkLabel2 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Calisto MT", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(398, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(471, 134)
        Label2.TabIndex = 5
        Label2.Text = "Hekaya"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(526, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 40)
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
        PictureBox1.Location = New Point(545, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 152)
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
        Label3.Location = New Point(347, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(262, 42)
        Label3.TabIndex = 6
        Label3.Text = "Username:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 15F)
        TextBox1.Location = New Point(615, 410)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 41)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 15F)
        TextBox2.Location = New Point(615, 484)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 41)
        TextBox2.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(347, 483)
        Label5.Name = "Label5"
        Label5.Size = New Size(262, 42)
        Label5.TabIndex = 10
        Label5.Text = "Password:"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.BackColor = Color.White
        Button1.Font = New Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Button1.Location = New Point(526, 585)
        Button1.Name = "Button1"
        Button1.Size = New Size(219, 45)
        Button1.TabIndex = 11
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Display", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(466, 528)
        Label6.Name = "Label6"
        Label6.Size = New Size(240, 32)
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
        LinkLabel2.Location = New Point(697, 528)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(98, 32)
        LinkLabel2.TabIndex = 13
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Sign Up"
        ' 
        ' Login_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(LinkLabel2)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
