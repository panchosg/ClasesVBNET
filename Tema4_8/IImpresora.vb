Public Interface IImpresora

    Property EstaConectada As Boolean
    Property ErrorImpresora As Boolean
    Property EncederLedsRojos As Boolean
    Property EncederLedsVerdes As Boolean

    ''' <summary>
    ''' Ejecuta comando de impresión
    ''' </summary>
    ''' <param name="textoImprimir">texto que se va a imprimir</param>
    ''' <returns>True si fue correcta la impresión</returns>
    Function Imprimir(textoImprimir As String) As Boolean
    ''' <summary>
    ''' Cancelar impresión
    ''' </summary>
    ''' <returns>True si se pudo cancelar la impresión</returns>
    Function Cancelar() As Boolean


End Interface
