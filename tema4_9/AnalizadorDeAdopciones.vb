''' <summary>
''' Se encarga de analizar si una mascota se puede dar en adopción
''' </summary>
Public Class AnalizadorDeAdopciones(Of T As IAnimales)

    Public Property MascotaAlmacenada As T

    ''' <summary>
    ''' Decide si una mascota se puede dar en adopción
    ''' </summary>
    ''' <returns>True si se puede dar en adopción</returns>
    Public Function AnalizarMascota(mascota As T) As Boolean
        'Para que una mascota sea adoptable, debe tener buena salud y tener sus vacunas
        If mascota.Salud = True And mascota.Vacunas = True Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
