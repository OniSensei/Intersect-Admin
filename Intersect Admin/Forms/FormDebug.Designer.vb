<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDebug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDebug))
        Me.DebugText = New Intersect_Admin.XylosTextBox()
        Me.PostText = New Intersect_Admin.XylosTextBox()
        Me.XylosButton1 = New Intersect_Admin.XylosButton()
        Me.XylosButton2 = New Intersect_Admin.XylosButton()
        Me.GetText = New Intersect_Admin.XylosTextBox()
        Me.DebugText2 = New Intersect_Admin.XylosTextBox()
        Me.SuspendLayout()
        '
        'DebugText
        '
        Me.DebugText.EnabledCalc = True
        Me.DebugText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DebugText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.DebugText.Location = New System.Drawing.Point(12, 12)
        Me.DebugText.MaxLength = 9999999
        Me.DebugText.MultiLine = True
        Me.DebugText.Name = "DebugText"
        Me.DebugText.ReadOnly = False
        Me.DebugText.Size = New System.Drawing.Size(721, 205)
        Me.DebugText.TabIndex = 0
        Me.DebugText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DebugText.UseSystemPasswordChar = False
        '
        'PostText
        '
        Me.PostText.EnabledCalc = True
        Me.PostText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PostText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PostText.Location = New System.Drawing.Point(12, 223)
        Me.PostText.MaxLength = 32767
        Me.PostText.MultiLine = False
        Me.PostText.Name = "PostText"
        Me.PostText.ReadOnly = False
        Me.PostText.Size = New System.Drawing.Size(640, 29)
        Me.PostText.TabIndex = 1
        Me.PostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PostText.UseSystemPasswordChar = False
        '
        'XylosButton1
        '
        Me.XylosButton1.EnabledCalc = True
        Me.XylosButton1.Location = New System.Drawing.Point(658, 223)
        Me.XylosButton1.Name = "XylosButton1"
        Me.XylosButton1.Size = New System.Drawing.Size(75, 29)
        Me.XylosButton1.TabIndex = 2
        Me.XylosButton1.Text = "SUBMIT"
        '
        'XylosButton2
        '
        Me.XylosButton2.EnabledCalc = True
        Me.XylosButton2.Location = New System.Drawing.Point(658, 469)
        Me.XylosButton2.Name = "XylosButton2"
        Me.XylosButton2.Size = New System.Drawing.Size(75, 29)
        Me.XylosButton2.TabIndex = 5
        Me.XylosButton2.Text = "SUBMIT"
        '
        'GetText
        '
        Me.GetText.EnabledCalc = True
        Me.GetText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GetText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.GetText.Location = New System.Drawing.Point(12, 469)
        Me.GetText.MaxLength = 32767
        Me.GetText.MultiLine = False
        Me.GetText.Name = "GetText"
        Me.GetText.ReadOnly = False
        Me.GetText.Size = New System.Drawing.Size(640, 29)
        Me.GetText.TabIndex = 4
        Me.GetText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GetText.UseSystemPasswordChar = False
        '
        'DebugText2
        '
        Me.DebugText2.EnabledCalc = True
        Me.DebugText2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DebugText2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.DebugText2.Location = New System.Drawing.Point(12, 258)
        Me.DebugText2.MaxLength = 32767
        Me.DebugText2.MultiLine = True
        Me.DebugText2.Name = "DebugText2"
        Me.DebugText2.ReadOnly = False
        Me.DebugText2.Size = New System.Drawing.Size(721, 205)
        Me.DebugText2.TabIndex = 3
        Me.DebugText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DebugText2.UseSystemPasswordChar = False
        '
        'FormDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(745, 505)
        Me.Controls.Add(Me.XylosButton2)
        Me.Controls.Add(Me.GetText)
        Me.Controls.Add(Me.DebugText2)
        Me.Controls.Add(Me.XylosButton1)
        Me.Controls.Add(Me.PostText)
        Me.Controls.Add(Me.DebugText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDebug"
        Me.Text = "Debugging"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DebugText As XylosTextBox
    Friend WithEvents PostText As XylosTextBox
    Friend WithEvents XylosButton1 As XylosButton
    Friend WithEvents XylosButton2 As XylosButton
    Friend WithEvents GetText As XylosTextBox
    Friend WithEvents DebugText2 As XylosTextBox
End Class
