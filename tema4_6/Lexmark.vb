Public Class Lexmark : Inherits Impresora

    Public Overrides Sub Imprimir()
        Dim hojaPrueba As Hoja
        Hojas = New List(Of Hoja)

        For index = 1 To 10
            hojaPrueba = New Hoja()
            hojaPrueba.Calidad = 2
            Hojas.Add(hojaPrueba)
        Next
    End Sub
End Class
