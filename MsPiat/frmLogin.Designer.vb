<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_Level = New System.Windows.Forms.ComboBox()
        Me.txt_Pass = New System.Windows.Forms.TextBox()
        Me.txt_User = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(334, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cb_Level
        '
        Me.cb_Level.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Level.FormattingEnabled = True
        Me.cb_Level.Location = New System.Drawing.Point(234, 168)
        Me.cb_Level.Name = "cb_Level"
        Me.cb_Level.Size = New System.Drawing.Size(233, 38)
        Me.cb_Level.TabIndex = 16
        Me.cb_Level.Text = "--Select Level--"
        '
        'txt_Pass
        '
        Me.txt_Pass.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pass.Location = New System.Drawing.Point(234, 122)
        Me.txt_Pass.Name = "txt_Pass"
        Me.txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Pass.Size = New System.Drawing.Size(233, 38)
        Me.txt_Pass.TabIndex = 15
        '
        'txt_User
        '
        Me.txt_User.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_User.Location = New System.Drawing.Point(234, 83)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Size = New System.Drawing.Size(233, 38)
        Me.txt_User.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Username:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 304)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_Level)
        Me.Controls.Add(Me.txt_Pass)
        Me.Controls.Add(Me.txt_User)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cb_Level As ComboBox
    Friend WithEvents txt_Pass As TextBox
    Friend WithEvents txt_User As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
