<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JugadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarJugadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarSueldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JugadoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JugadoresToolStripMenuItem
        '
        Me.JugadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarJugadoresToolStripMenuItem, Me.MostrarSueldosToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.JugadoresToolStripMenuItem.Name = "JugadoresToolStripMenuItem"
        Me.JugadoresToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.JugadoresToolStripMenuItem.Text = "&Jugadores"
        '
        'AdicionarJugadoresToolStripMenuItem
        '
        Me.AdicionarJugadoresToolStripMenuItem.Name = "AdicionarJugadoresToolStripMenuItem"
        Me.AdicionarJugadoresToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AdicionarJugadoresToolStripMenuItem.Text = "&Adicionar Jugadores"
        '
        'MostrarSueldosToolStripMenuItem
        '
        Me.MostrarSueldosToolStripMenuItem.Name = "MostrarSueldosToolStripMenuItem"
        Me.MostrarSueldosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MostrarSueldosToolStripMenuItem.Text = "&Mostrar Sueldos"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.SalirToolStripMenuItem1.Text = "&Salir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FormPrincipal"
        Me.Text = "Vallecano Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JugadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarJugadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarSueldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
