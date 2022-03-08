Option Explicit On
Option Strict On

Module Program
    Sub Main(args As String())
        'ejemplo de tipos genéricos en colecciones
        'Dim listadoTitulosPeliculas As List(Of String)
        'Dim listadoMascotas As List(Of Mascota)
        'Dim listadoNumLoteria As List(Of Integer)
        'Dim colaNombrePersona As Queue(Of String)

        'Crear un programa que analice si un animal es elegible para adopción

        Dim gata1 As Gato
        Dim perro1 As Perro
        Dim analizador As AnalizadorDeAdopciones(Of IAnimales)
        Dim esAdoptable As Boolean

        gata1 = New Gato()
        gata1.Vacunas = True
        gata1.Salud = True
        gata1.Nombre = "pulgocita"

        perro1 = New Perro()
        perro1.Nombre = "FIRU"
        perro1.Salud = True
        perro1.Vacunas = False

        analizador = New AnalizadorDeAdopciones(Of IAnimales)

        esAdoptable = analizador.AnalizarMascota(gata1)
        If (esAdoptable = True) Then
            Console.WriteLine("la mascota de nombre " & gata1.Nombre & " es adoptable")
            analizador.MascotaAlmacenada = gata1
        End If

        esAdoptable = analizador.AnalizarMascota(perro1)
        If (esAdoptable = True) Then
            Console.WriteLine("la mascota de nombre " & perro1.Nombre & " es adoptable")
        Else
            Console.WriteLine("la mascota de nombre " & perro1.Nombre & " NO es adoptable")
        End If




    End Sub
End Module
