Option Explicit On
Option Strict On
Module Program
    Public Sub Main()
        Dim frmManual As FrmManual

        frmManual = New FrmManual()
        frmManual.Text = "Probando este código"
        'frmManual.Show() No deja permanente la ejecución del programa
        Application.Run(frmManual)
    End Sub

End Module
