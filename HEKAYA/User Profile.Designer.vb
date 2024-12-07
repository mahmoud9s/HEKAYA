<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Profile))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Picture9
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(10, 70)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(143, 112)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label1.Location = New Point(166, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 41)
        Label1.TabIndex = 11
        Label1.Text = "HI : Username "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label2.Location = New Point(10, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 41)
        Label2.TabIndex = 12
        Label2.Text = "EMAIL : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label3.Location = New Point(10, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(258, 41)
        Label3.TabIndex = 13
        Label3.Text = "Mobile Number :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 22F)
        Label4.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label4.Location = New Point(145, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 41)
        Label4.TabIndex = 14
        Label4.Text = "user@gmail.com"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 22F)
        Label5.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label5.Location = New Point(294, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(194, 41)
        Label5.TabIndex = 15
        Label5.Text = "01012345678" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label6.Location = New Point(10, 321)
        Label6.Name = "Label6"
        Label6.Size = New Size(250, 41)
        Label6.TabIndex = 16
        Label6.Text = "Recently Viewed"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label7.Location = New Point(864, 602)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 36)
        Label7.TabIndex = 17
        Label7.Text = "Cairo Tower"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label8.Location = New Point(478, 602)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 36)
        Label8.TabIndex = 18
        Label8.Text = "Al Masa"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 19F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(98), CByte(62), CByte(42))
        Label9.Location = New Point(13, 602)
        Label9.Name = "Label9"
        Label9.Size = New Size(273, 36)
        Label9.TabIndex = 19
        Label9.Text = "Revolving Restaurant"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(814, 423)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(262, 142)
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = My.Resources.Resources.Masa
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(423, 423)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(262, 142)
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = My.Resources.Resources.revolving_restaurant_F_875x323
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(26, 423)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(262, 142)
        PictureBox4.TabIndex = 22
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = My.Resources.Resources.Picture9
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Location = New Point(1021, 14)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(55, 39)
        PictureBox5.TabIndex = 23
        PictureBox5.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = My.Resources.Resources.love
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Cursor = Cursors.Hand
        PictureBox7.Location = New Point(946, 14)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(60, 39)
        PictureBox7.TabIndex = 25
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.Picture6
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Location = New Point(99, 14)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(55, 39)
        PictureBox6.TabIndex = 26
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImage = My.Resources.Resources.Picture7
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Cursor = Cursors.Hand
        PictureBox8.Location = New Point(13, 14)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(70, 39)
        PictureBox8.TabIndex = 27
        PictureBox8.TabStop = False
        ' 
        ' User_Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(235), CByte(229))
        ClientSize = New Size(1104, 791)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "User_Profile"
        Text = "User_Profile"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
