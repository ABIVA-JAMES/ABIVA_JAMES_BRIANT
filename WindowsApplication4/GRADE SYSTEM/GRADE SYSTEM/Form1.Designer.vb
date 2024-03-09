<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GRADE_FORM
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
        Me.evaluate_btn = New System.Windows.Forms.Button()
        Me.math_txt_box = New System.Windows.Forms.TextBox()
        Me.science_txt_box = New System.Windows.Forms.TextBox()
        Me.english_txt_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'evaluate_btn
        '
        Me.evaluate_btn.Location = New System.Drawing.Point(314, 291)
        Me.evaluate_btn.Name = "evaluate_btn"
        Me.evaluate_btn.Size = New System.Drawing.Size(75, 23)
        Me.evaluate_btn.TabIndex = 0
        Me.evaluate_btn.Text = "EVALUATE"
        Me.evaluate_btn.UseVisualStyleBackColor = True
        '
        'math_txt_box
        '
        Me.math_txt_box.Location = New System.Drawing.Point(89, 68)
        Me.math_txt_box.Name = "math_txt_box"
        Me.math_txt_box.Size = New System.Drawing.Size(490, 20)
        Me.math_txt_box.TabIndex = 1
        '
        'science_txt_box
        '
        Me.science_txt_box.Location = New System.Drawing.Point(89, 146)
        Me.science_txt_box.Name = "science_txt_box"
        Me.science_txt_box.Size = New System.Drawing.Size(490, 20)
        Me.science_txt_box.TabIndex = 2
        '
        'english_txt_box
        '
        Me.english_txt_box.Location = New System.Drawing.Point(89, 218)
        Me.english_txt_box.Name = "english_txt_box"
        Me.english_txt_box.Size = New System.Drawing.Size(490, 20)
        Me.english_txt_box.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MATH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SCIENCE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ENGLISH"
        '
        'GRADE_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 326)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.english_txt_box)
        Me.Controls.Add(Me.science_txt_box)
        Me.Controls.Add(Me.math_txt_box)
        Me.Controls.Add(Me.evaluate_btn)
        Me.Name = "GRADE_FORM"
        Me.Text = "GRADE FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents evaluate_btn As Button
    Friend WithEvents math_txt_box As TextBox
    Friend WithEvents science_txt_box As TextBox
    Friend WithEvents english_txt_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
