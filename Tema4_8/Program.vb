Option Explicit On
Option Strict On

Module Program
    Sub Main(args As String())
        Dim opcion As String
        Dim impresora As IImpresora
        'Imprimir un hola mundo en diferentes tipos de dispositivo de impresión

        'procedimiento de impresión

        Console.WriteLine("===== MENÚ =====")
        Console.WriteLine("Elija una opción:")
        Console.WriteLine("1. Imprimir con HP1250")
        Console.WriteLine("2. Imprimir con Citizen GSX 190S")
        opcion = Console.ReadLine()

        Select Case opcion
            Case "1"
                impresora = New HP1250()
            Case "2"
                impresora = New CitizenGSX190S()
            Case Else

        End Select

        Console.WriteLine(impresora.Imprimir("Hola mundo"))






    End Sub
End Module
