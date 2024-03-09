<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Username_txtbox = New System.Windows.Forms.TextBox()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PASSSWORD = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Username_txtbox
        '
        Me.Username_txtbox.Location = New System.Drawing.Point(192, 129)
        Me.Username_txtbox.Name = "Username_txtbox"
        Me.Username_txtbox.Size = New System.Drawing.Size(500, 21)
        Me.Username_txtbox.TabIndex = 0
        '
        'password_txtbox
        '
        Me.password_txtbox.Location = New System.Drawing.Point(192, 204)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(500, 21)
        Me.password_txtbox.TabIndex = 1
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.login_btn.Font = New System.Drawing.Font("Papyrus", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Location = New System.Drawing.Point(340, 290)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(149, 55)
        Me.login_btn.TabIndex = 2
        Me.login_btn.Text = "LOG IN"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USERNAME:"
        '
        'PASSSWORD
        '
        Me.PASSSWORD.AutoSize = True
        Me.PASSSWORD.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSSWORD.Location = New System.Drawing.Point(127, 175)
        Me.PASSSWORD.Name = "PASSSWORD"
        Me.PASSSWORD.Size = New System.Drawing.Size(83, 20)
        Me.PASSSWORD.TabIndex = 4
        Me.PASSSWORD.Text = "PASSWORD:"
        '
        'Label4
        '
        Me.Label4.Image = Global.WindowsApplication1.My.Resources.Resources.lock_FILL0_wght400_GRAD0_opsz241
        Me.Label4.Location = New System.Drawing.Point(149, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 30)
        Me.Label4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Image = Global.WindowsApplication1.My.Resources.Resources.person_FILL0_wght400_GRAD0_opsz241
        Me.Label3.Location = New System.Drawing.Point(149, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 34)
        Me.Label3.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = Global.WindowsApplication1.My.Resources.Resources.person_FILL0_wght400_GRAD0_opsz24
        Me.Label2.Location = New System.Drawing.Point(149, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "USER LOG IN"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkCyan
        Me.Label6.Image = Global.WindowsApplication1.My.Resources.Resources.east_FILL0_wght400_GRAD0_opsz24__1_
        Me.Label6.Location = New System.Drawing.Point(444, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 37)
        Me.Label6.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(922, 634)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PASSSWORD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.Username_txtbox)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN UP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username_txtbox As TextBox
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents login_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PASSSWORD As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
