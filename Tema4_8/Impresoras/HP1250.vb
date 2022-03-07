Option Explicit On
Option Strict On

Public Class HP1250 : Implements IImpresora

    Private pvEncederLedsRojos As Boolean

    Public Property EstaConectada As Boolean Implements IImpresora.EstaConectada
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property
    Public Property ErroImpresora As Boolean Implements IImpresora.ErrorImpresora
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Property EncederLedsRojos As Boolean Implements IImpresora.EncederLedsRojos
        Get
            Return pvEncederLedsRojos
        End Get
        Set(value As Boolean)
            pvEncederLedsRojos = TurnOnRedsLeds(value)
        End Set
    End Property

    Public Property EncederLedsVerdes As Boolean Implements IImpresora.EncederLedsVerdes
        Get

        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public Function ImprimirHP1250(textoImprimir As String) As String Implements IImpresora.Imprimir
        Return NativePrinterHPCorp(textoImprimir)
    End Function

    Public Function Cancelar() As Boolean Implements IImpresora.Cancelar
        Return CancelJob(True)
    End Function







#Region "----- Funciones Nativas HP ------"
    Private Function NativePrinterHPCorp(textToPrinter As String) As String
        'Codigo nativo de la HP
        'var = &HHH093
        '.....
        Return "Print With HP1250"
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
