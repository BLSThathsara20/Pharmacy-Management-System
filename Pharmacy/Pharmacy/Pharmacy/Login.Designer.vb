<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Passtb = New System.Windows.Forms.TextBox()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.lgbtn = New System.Windows.Forms.Button()
        Me.lgoutbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(258, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Passtb
        '
        Me.Passtb.Location = New System.Drawing.Point(392, 187)
        Me.Passtb.Name = "Passtb"
        Me.Passtb.Size = New System.Drawing.Size(100, 20)
        Me.Passtb.TabIndex = 2
        '
        'UnameTb
        '
        Me.UnameTb.Location = New System.Drawing.Point(392, 142)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(100, 20)
        Me.UnameTb.TabIndex = 3
        '
        'lgbtn
        '
        Me.lgbtn.Location = New System.Drawing.Point(352, 301)
        Me.lgbtn.Name = "lgbtn"
        Me.lgbtn.Size = New System.Drawing.Size(75, 23)
        Me.lgbtn.TabIndex = 4
        Me.lgbtn.Text = "Login"
        Me.lgbtn.UseVisualStyleBackColor = True
        '
        'lgoutbtn
        '
        Me.lgoutbtn.Location = New System.Drawing.Point(449, 301)
        Me.lgoutbtn.Name = "lgoutbtn"
        Me.lgoutbtn.Size = New System.Drawing.Size(75, 23)
        Me.lgoutbtn.TabIndex = 5
        Me.lgoutbtn.Text = "Logout"
        Me.lgoutbtn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lgoutbtn)
        Me.Controls.Add(Me.lgbtn)
        Me.Controls.Add(Me.UnameTb)
        Me.Controls.Add(Me.Passtb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Passtb As TextBox
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents lgbtn As Button
    Friend WithEvents lgoutbtn As Button
End Class
