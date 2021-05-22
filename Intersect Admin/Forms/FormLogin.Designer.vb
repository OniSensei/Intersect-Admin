<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.NsTheme1 = New Intersect_Admin.NSTheme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NsCheckBox1 = New Intersect_Admin.NSCheckBox()
        Me.LoginNotice = New Intersect_Admin.LogInStatusBar()
        Me.LoginButton = New Intersect_Admin.NSButton()
        Me.NsOnOffBox1 = New Intersect_Admin.NSOnOffBox()
        Me.UsernameTextbox = New Intersect_Admin.NSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextbox = New Intersect_Admin.NSTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsControlButton1 = New Intersect_Admin.NSControlButton()
        Me.NsButton1 = New Intersect_Admin.NSButton()
        Me.NsTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Intersect_Admin.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Controls.Add(Me.PictureBox1)
        Me.NsTheme1.Controls.Add(Me.NsCheckBox1)
        Me.NsTheme1.Controls.Add(Me.LoginNotice)
        Me.NsTheme1.Controls.Add(Me.LoginButton)
        Me.NsTheme1.Controls.Add(Me.NsOnOffBox1)
        Me.NsTheme1.Controls.Add(Me.UsernameTextbox)
        Me.NsTheme1.Controls.Add(Me.Label2)
        Me.NsTheme1.Controls.Add(Me.PasswordTextbox)
        Me.NsTheme1.Controls.Add(Me.Label1)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(391, 301)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Intersect Admin - Login"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 123)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Location = New System.Drawing.Point(12, 249)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(108, 23)
        Me.NsCheckBox1.TabIndex = 9
        Me.NsCheckBox1.Text = "Remember Me"
        '
        'LoginNotice
        '
        Me.LoginNotice.Alignment = Intersect_Admin.LogInStatusBar.Alignments.Left
        Me.LoginNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LoginNotice.BaseColour = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LoginNotice.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LoginNotice.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LoginNotice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginNotice.ForeColor = System.Drawing.Color.White
        Me.LoginNotice.LinesToShow = Intersect_Admin.LogInStatusBar.LinesCount.One
        Me.LoginNotice.Location = New System.Drawing.Point(0, 278)
        Me.LoginNotice.Name = "LoginNotice"
        Me.LoginNotice.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LoginNotice.ShowBorder = True
        Me.LoginNotice.ShowLine = True
        Me.LoginNotice.Size = New System.Drawing.Size(391, 23)
        Me.LoginNotice.TabIndex = 8
        Me.LoginNotice.Text = "Please Login..."
        Me.LoginNotice.TextColour = System.Drawing.Color.White
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(323, 249)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(56, 23)
        Me.LoginButton.TabIndex = 7
        Me.LoginButton.Text = "  Login"
        '
        'NsOnOffBox1
        '
        Me.NsOnOffBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsOnOffBox1.Checked = True
        Me.NsOnOffBox1.Location = New System.Drawing.Point(323, 219)
        Me.NsOnOffBox1.MaximumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.MinimumSize = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.Name = "NsOnOffBox1"
        Me.NsOnOffBox1.Size = New System.Drawing.Size(56, 24)
        Me.NsOnOffBox1.TabIndex = 5
        Me.NsOnOffBox1.Text = "NsOnOffBox1"
        '
        'UsernameTextbox
        '
        Me.UsernameTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextbox.Location = New System.Drawing.Point(12, 176)
        Me.UsernameTextbox.MaxLength = 32767
        Me.UsernameTextbox.Multiline = False
        Me.UsernameTextbox.Name = "UsernameTextbox"
        Me.UsernameTextbox.ReadOnly = False
        Me.UsernameTextbox.Size = New System.Drawing.Size(305, 24)
        Me.UsernameTextbox.TabIndex = 4
        Me.UsernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UsernameTextbox.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'PasswordTextbox
        '
        Me.PasswordTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextbox.Location = New System.Drawing.Point(12, 219)
        Me.PasswordTextbox.MaxLength = 32767
        Me.PasswordTextbox.Multiline = False
        Me.PasswordTextbox.Name = "PasswordTextbox"
        Me.PasswordTextbox.ReadOnly = False
        Me.PasswordTextbox.Size = New System.Drawing.Size(305, 24)
        Me.PasswordTextbox.TabIndex = 2
        Me.PasswordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordTextbox.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = Intersect_Admin.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(364, 2)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 0
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(259, 249)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(58, 23)
        Me.NsButton1.TabIndex = 11
        Me.NsButton1.Text = "Settings"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 301)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intersect Admin - Login"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents UsernameTextbox As NSTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTextbox As NSTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NsControlButton1 As NSControlButton
    Friend WithEvents LoginButton As NSButton
    Friend WithEvents NsOnOffBox1 As NSOnOffBox
    Friend WithEvents NsCheckBox1 As NSCheckBox
    Friend WithEvents LoginNotice As LogInStatusBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NsButton1 As NSButton
End Class
