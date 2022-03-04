Option Explicit On
Option Strict On

Module Program
    Sub Main(args As String())
        'Se tiene analizar la calidad de unos libros impresos en diferentes dispositivos,
        'Canon, HP, Lexmark. La calidad se analizará por hoja, cada hoja tendrá una puntuacion entre 1 y 3

        Dim hp As HP
        Dim canon As Canon
        Dim lexmark As Lexmark
        Dim impresoraGenerica As Impresora
        Dim listaImpresoras As List(Of Impresora)
        Dim promCalidadHP As Double
        Dim promCalidadCanon As Double
        Dim promCalidadLexmark As Double
        Dim nombreImpresoras As String = ""


        hp = New HP()
        canon = New Canon()
        lexmark = New Lexmark()

        'listaImpresoras = New List(Of Impresora)
        'otro comentario

        For contador = 0 To 2
            Select Case contador
                Case 0
                    impresoraGenerica = New HP()
                    nombreImpresoras = "HP"
                Case 1
                    impresoraGenerica = New Canon()
                    nombreImpresoras = "Canon"
                Case 2
                    impresoraGenerica = New Lexmark()
                    nombreImpresoras = "Lexmark"
                Case Else
                    impresoraGenerica = New HP()
            End Select
            EjecutarProcesoImpresora(impresoraGenerica, nombreImpresoras)
        Next

        ''Crear las hojas de prueba con su calidad
        'hp.Imprimir()
        ''Sacar calculo de la calidad
        'promCalidadHP = hp.CalculaCalidad()

        'Console.WriteLine("El promedo de calidad de HP es: " & promCalidadHP)

        ''Crear las hojas de prueba con su calidad
        'canon.Imprimir()
        ''Sacar calculo de la calidad
        'promCalidadCanon = canon.CalculaCalidad()

        'Console.WriteLine("El promedo de calidad de Canon es: " & promCalidadCanon)

        ''Crear las hojas de prueba con su calidad
        'lexmark.Imprimir()
        ''Sacar calculo de la calidad
        'promCalidadLexmark = lexmark.CalculaCalidad()

        'Console.WriteLine("El promedo de calidad de Lexmark es: " & promCalidadLexmark)

    End Sub

    Public Sub EjecutarProcesoImpresora(impresoraGenerica As Impresora, nombreImpresoras As String)
        impresoraGenerica.Imprimir()
        Console.WriteLine("El promedo de calidad de la impresora" & nombreImpresoras & " es: " & impresoraGenerica.CalculaCalidad())
    End Sub
End Module
