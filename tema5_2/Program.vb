Imports System

Module Program
    Public Delegate Sub VerMensaje()
    Sub Main(args As String())
        'Crea un programa que muestre un mensaje al usuario
        'Declarar delegado
        'Modo 1 -----------------------
        'Dim delegadoTexto As VerMensaje
        ''Asignar puntero a procedimiento u objeto
        'delegadoTexto = AddressOf MostrarTexto
        ''Ejecutar delegado o invocar
        'delegadoTexto.Invoke()

        'Modo 2 ------------------------
        'Declaraci�n y asignaci�n con putenro
        Dim delegadoTexto As New VerMensaje(AddressOf MostrarTexto)
        'Ejecuci�n o  invacaci�n del delegado
        delegadoTexto.Invoke()
    End Sub
    ''' <summary>
    ''' Funci�n que se ejecutar� a trav�s del delagado
    ''' </summary>
    Public Sub MostrarTexto()
        Console.WriteLine("Hola, esto es una prueba de delegado")
    End Sub

End Module
