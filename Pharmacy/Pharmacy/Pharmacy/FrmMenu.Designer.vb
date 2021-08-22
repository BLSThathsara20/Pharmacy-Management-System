<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManufactureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.FrontToolStripMenuItem, Me.MedicineToolStripMenuItem, Me.AgentToolStripMenuItem, Me.ManufactureToolStripMenuItem, Me.BillToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'FrontToolStripMenuItem
        '
        Me.FrontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.FrontToolStripMenuItem.Name = "FrontToolStripMenuItem"
        Me.FrontToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FrontToolStripMenuItem.Text = "Front"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'MedicineToolStripMenuItem
        '
        Me.MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem"
        Me.MedicineToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.MedicineToolStripMenuItem.Text = "Medicine"
        '
        'AgentToolStripMenuItem
        '
        Me.AgentToolStripMenuItem.Name = "AgentToolStripMenuItem"
        Me.AgentToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AgentToolStripMenuItem.Text = "Agent"
        '
        'ManufactureToolStripMenuItem
        '
        Me.ManufactureToolStripMenuItem.Name = "ManufactureToolStripMenuItem"
        Me.ManufactureToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ManufactureToolStripMenuItem.Text = "Manufacture"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManufactureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As ToolStripMenuItem
End Class
