<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.NsTheme1 = New Intersect_Admin.NSTheme()
        Me.SettingsStatus = New Intersect_Admin.LogInStatusBar()
        Me.NsButton1 = New Intersect_Admin.NSButton()
        Me.NsGroupBox2 = New Intersect_Admin.NSGroupBox()
        Me.MaxBanDurationTextbox = New Intersect_Admin.NSTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaxPlayersTextbox = New Intersect_Admin.NSTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NsGroupBox1 = New Intersect_Admin.NSGroupBox()
        Me.PortTextbox = New Intersect_Admin.NSTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HostTextbox = New Intersect_Admin.NSTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsControlButton1 = New Intersect_Admin.NSControlButton()
        Me.NsTheme1.SuspendLayout()
        Me.NsGroupBox2.SuspendLayout()
        Me.NsGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Intersect_Admin.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.SettingsStatus)
        Me.NsTheme1.Controls.Add(Me.NsGroupBox2)
        Me.NsTheme1.Controls.Add(Me.NsGroupBox1)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = False
        Me.NsTheme1.Size = New System.Drawing.Size(355, 349)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Intersect Admin - Settings"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'SettingsStatus
        '
        Me.SettingsStatus.Alignment = Intersect_Admin.LogInStatusBar.Alignments.Left
        Me.SettingsStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SettingsStatus.BaseColour = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SettingsStatus.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SettingsStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SettingsStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SettingsStatus.ForeColor = System.Drawing.Color.White
        Me.SettingsStatus.LinesToShow = Intersect_Admin.LogInStatusBar.LinesCount.One
        Me.SettingsStatus.Location = New System.Drawing.Point(0, 326)
        Me.SettingsStatus.Name = "SettingsStatus"
        Me.SettingsStatus.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SettingsStatus.ShowBorder = True
        Me.SettingsStatus.ShowLine = True
        Me.SettingsStatus.Size = New System.Drawing.Size(355, 23)
        Me.SettingsStatus.TabIndex = 9
        Me.SettingsStatus.Text = "Settings loaded..."
        Me.SettingsStatus.TextColour = System.Drawing.Color.White
        '
        'NsButton1
        '
        Me.NsButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsButton1.Location = New System.Drawing.Point(6, 123)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(322, 31)
        Me.NsButton1.TabIndex = 3
        Me.NsButton1.Text = "                                    SAVE"
        '
        'NsGroupBox2
        '
        Me.NsGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsGroupBox2.Controls.Add(Me.MaxBanDurationTextbox)
        Me.NsGroupBox2.Controls.Add(Me.NsButton1)
        Me.NsGroupBox2.Controls.Add(Me.Label3)
        Me.NsGroupBox2.Controls.Add(Me.MaxPlayersTextbox)
        Me.NsGroupBox2.Controls.Add(Me.Label4)
        Me.NsGroupBox2.DrawSeperator = False
        Me.NsGroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.NsGroupBox2.Name = "NsGroupBox2"
        Me.NsGroupBox2.Size = New System.Drawing.Size(331, 157)
        Me.NsGroupBox2.SubTitle = "Minor details."
        Me.NsGroupBox2.TabIndex = 2
        Me.NsGroupBox2.Text = "NsGroupBox2"
        Me.NsGroupBox2.Title = "Basic"
        '
        'MaxBanDurationTextbox
        '
        Me.MaxBanDurationTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxBanDurationTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaxBanDurationTextbox.Location = New System.Drawing.Point(6, 94)
        Me.MaxBanDurationTextbox.MaxLength = 32767
        Me.MaxBanDurationTextbox.Multiline = False
        Me.MaxBanDurationTextbox.Name = "MaxBanDurationTextbox"
        Me.MaxBanDurationTextbox.ReadOnly = False
        Me.MaxBanDurationTextbox.Size = New System.Drawing.Size(322, 23)
        Me.MaxBanDurationTextbox.TabIndex = 3
        Me.MaxBanDurationTextbox.Text = "99999"
        Me.MaxBanDurationTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxBanDurationTextbox.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Max Ban Duration:"
        '
        'MaxPlayersTextbox
        '
        Me.MaxPlayersTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxPlayersTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaxPlayersTextbox.Location = New System.Drawing.Point(6, 52)
        Me.MaxPlayersTextbox.MaxLength = 32767
        Me.MaxPlayersTextbox.Multiline = False
        Me.MaxPlayersTextbox.Name = "MaxPlayersTextbox"
        Me.MaxPlayersTextbox.ReadOnly = False
        Me.MaxPlayersTextbox.Size = New System.Drawing.Size(322, 23)
        Me.MaxPlayersTextbox.TabIndex = 1
        Me.MaxPlayersTextbox.Text = "100"
        Me.MaxPlayersTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaxPlayersTextbox.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Max Players Online:"
        '
        'NsGroupBox1
        '
        Me.NsGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsGroupBox1.Controls.Add(Me.PortTextbox)
        Me.NsGroupBox1.Controls.Add(Me.Label2)
        Me.NsGroupBox1.Controls.Add(Me.HostTextbox)
        Me.NsGroupBox1.Controls.Add(Me.Label1)
        Me.NsGroupBox1.DrawSeperator = False
        Me.NsGroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.NsGroupBox1.Name = "NsGroupBox1"
        Me.NsGroupBox1.Size = New System.Drawing.Size(331, 123)
        Me.NsGroupBox1.SubTitle = "Server host and port."
        Me.NsGroupBox1.TabIndex = 1
        Me.NsGroupBox1.Text = "NsGroupBox1"
        Me.NsGroupBox1.Title = "Server"
        '
        'PortTextbox
        '
        Me.PortTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PortTextbox.Location = New System.Drawing.Point(6, 94)
        Me.PortTextbox.MaxLength = 32767
        Me.PortTextbox.Multiline = False
        Me.PortTextbox.Name = "PortTextbox"
        Me.PortTextbox.ReadOnly = False
        Me.PortTextbox.Size = New System.Drawing.Size(322, 23)
        Me.PortTextbox.TabIndex = 3
        Me.PortTextbox.Text = "5400"
        Me.PortTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PortTextbox.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port:"
        '
        'HostTextbox
        '
        Me.HostTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HostTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HostTextbox.Location = New System.Drawing.Point(6, 52)
        Me.HostTextbox.MaxLength = 32767
        Me.HostTextbox.Multiline = False
        Me.HostTextbox.Name = "HostTextbox"
        Me.HostTextbox.ReadOnly = False
        Me.HostTextbox.Size = New System.Drawing.Size(322, 23)
        Me.HostTextbox.TabIndex = 1
        Me.HostTextbox.Text = "localhost"
        Me.HostTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HostTextbox.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host:"
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = Intersect_Admin.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(328, 2)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 0
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 349)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intersect Admin - Settings"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsGroupBox2.ResumeLayout(False)
        Me.NsGroupBox2.PerformLayout()
        Me.NsGroupBox1.ResumeLayout(False)
        Me.NsGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents NsGroupBox1 As NSGroupBox
    Friend WithEvents PortTextbox As NSTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HostTextbox As NSTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NsControlButton1 As NSControlButton
    Friend WithEvents NsGroupBox2 As NSGroupBox
    Friend WithEvents MaxBanDurationTextbox As NSTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaxPlayersTextbox As NSTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents SettingsStatus As LogInStatusBar
End Class
