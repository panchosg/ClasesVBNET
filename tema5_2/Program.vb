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
        'Declaración y asignación con putenro
        Dim delegadoTexto As New VerMensaje(AddressOf MostrarTexto)
        'Ejecución o  invacación del delegado
        delegadoTexto.Invoke()
    End Sub
    ''' <summary>
    ''' Función que se ejecutará a través del delagado
    ''' </summary>
    Public Sub MostrarTexto()
        Console.WriteLine("Hola, esto es una prueba de delegado")
    End Sub

End Module
