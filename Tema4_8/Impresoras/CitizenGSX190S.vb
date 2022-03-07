Public Class CitizenGSX190S : Implements IImpresora

    Public Property EstaConectada As Boolean Implements IImpresora.EstaConectada
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property ErrorImpresora As Boolean Implements IImpresora.ErrorImpresora
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property EncederLedsRojos As Boolean Implements IImpresora.EncederLedsRojos
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property EncederLedsVerdes As Boolean Implements IImpresora.EncederLedsVerdes
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Function Imprimir(textoImprimir As String) As String Implements IImpresora.Imprimir
        Return NativePrinterCITIZENCorp(textoImprimir)
    End Function

    Public Function Cancelar() As Boolean Implements IImpresora.Cancelar

    End Function


#Region "----- Funciones Nativas CITIZEN ------"
    Private Function NativePrinterCITIZENCorp(textToPrinter As String) As String
        'Codigo nativo de la CITIZEN
        'var = &HHH093
        '.....
        Return textToPrinter & vbCrLf & " Printed With CITIZEN 190 GSX"
    End Function

    Private Function TurnOnGreenLeds(turnOn As Boolean) As Boolean
        Return turnOn
    End Function

    Private Function TurnOnRedsLeds(turnOn As Boolean) As Boolean
        Return turnOn
    End Function

    Private Function CancelJob(isCancel As Boolean) As Boolean
        Return isCancel
    End Function
#End Region


End Class
