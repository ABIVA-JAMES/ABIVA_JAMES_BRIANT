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
        Me.age_txtbox = New System.Windows.Forms.TextBox()
        Me.EVALUATE_BTN = New System.Windows.Forms.Button()
        Me.TXTBOX_LBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'age_txtbox
        '
        Me.age_txtbox.Location = New System.Drawing.Point(108, 71)
        Me.age_txtbox.Name = "age_txtbox"
        Me.age_txtbox.Size = New System.Drawing.Size(343, 20)
        Me.age_txtbox.TabIndex = 0
        '
        'EVALUATE_BTN
        '
        Me.EVALUATE_BTN.Location = New System.Drawing.Point(223, 157)
        Me.EVALUATE_BTN.Name = "EVALUATE_BTN"
        Me.EVALUATE_BTN.Size = New System.Drawing.Size(75, 23)
        Me.EVALUATE_BTN.TabIndex = 1
        Me.EVALUATE_BTN.Text = "EVALUATE"
        Me.EVALUATE_BTN.UseVisualStyleBackColor = True
        '
        'TXTBOX_LBL
        '
        Me.TXTBOX_LBL.AutoSize = True
        Me.TXTBOX_LBL.Location = New System.Drawing.Point(108, 52)
        Me.TXTBOX_LBL.Name = "TXTBOX_LBL"
        Me.TXTBOX_LBL.Size = New System.Drawing.Size(57, 13)
        Me.TXTBOX_LBL.TabIndex = 2
        Me.TXTBOX_LBL.Text = "TEXTBOX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 273)
        Me.Controls.Add(Me.TXTBOX_LBL)
        Me.Controls.Add(Me.EVALUATE_BTN)
        Me.Controls.Add(Me.age_txtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents age_txtbox As TextBox
    Friend WithEvents EVALUATE_BTN As Button
    Friend WithEvents TXTBOX_LBL As Label
End Class
