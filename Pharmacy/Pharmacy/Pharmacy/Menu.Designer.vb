<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MedBtn = New System.Windows.Forms.Button()
        Me.Agentbtn = New System.Windows.Forms.Button()
        Me.BillBtn = New System.Windows.Forms.Button()
        Me.ManBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Medicine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Agent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(493, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Billing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Manufacture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(331, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Exit"
        '
        'MedBtn
        '
        Me.MedBtn.Location = New System.Drawing.Point(122, 154)
        Me.MedBtn.Name = "MedBtn"
        Me.MedBtn.Size = New System.Drawing.Size(75, 23)
        Me.MedBtn.TabIndex = 10
        Me.MedBtn.Text = "Button1"
        Me.MedBtn.UseVisualStyleBackColor = True
        '
        'Agentbtn
        '
        Me.Agentbtn.Location = New System.Drawing.Point(474, 154)
        Me.Agentbtn.Name = "Agentbtn"
        Me.Agentbtn.Size = New System.Drawing.Size(75, 23)
        Me.Agentbtn.TabIndex = 11
        Me.Agentbtn.Text = "Button2"
        Me.Agentbtn.UseVisualStyleBackColor = True
        '
        'BillBtn
        '
        Me.BillBtn.Location = New System.Drawing.Point(474, 243)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(75, 23)
        Me.BillBtn.TabIndex = 12
        Me.BillBtn.Text = "Button3"
        Me.BillBtn.UseVisualStyleBackColor = True
        '
        'ManBtn
        '
        Me.ManBtn.Location = New System.Drawing.Point(122, 243)
        Me.ManBtn.Name = "ManBtn"
        Me.ManBtn.Size = New System.Drawing.Size(75, 23)
        Me.ManBtn.TabIndex = 13
        Me.ManBtn.Text = "Button4"
        Me.ManBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(319, 348)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 14
        Me.ExitBtn.Text = "Button5"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.ManBtn)
        Me.Controls.Add(Me.BillBtn)
        Me.Controls.Add(Me.Agentbtn)
        Me.Controls.Add(Me.MedBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MedBtn As Button
    Friend WithEvents Agentbtn As Button
    Friend WithEvents BillBtn As Button
    Friend WithEvents ManBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
