Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdicionarJugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarJugadoresToolStripMenuItem.Click
        Dim formAdicionarJ As FrmAdicionarJ
        formAdicionarJ = New FrmAdicionarJ()
        formAdicionarJ.Show() 'Indica que se muestre el formulario
    End Sub
End Class
