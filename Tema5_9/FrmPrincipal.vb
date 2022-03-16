Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdicionarJugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarJugadoresToolStripMenuItem.Click
        Dim formAdicionarJ As FrmAdicionarJ
        formAdicionarJ = New FrmAdicionarJ()
        formAdicionarJ.MdiParent = Me
        formAdicionarJ.Show() 'Indica que se muestre el formulario
    End Sub

    Private Sub MostrarSueldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarSueldosToolStripMenuItem.Click
        Dim formMostrarSueldos As FrmMostrarSueldos
        formMostrarSueldos = New FrmMostrarSueldos
        formMostrarSueldos.MdiParent = Me
        formMostrarSueldos.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim quiereSalir As DialogResult
        quiereSalir = MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If quiereSalir = DialogResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        SalirToolStripMenuItem_Click(sender, e)
    End Sub

End Class
