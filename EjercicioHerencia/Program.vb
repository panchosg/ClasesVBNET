Imports System

Module Program
    Sub Main(args As String())
        Dim listaEmpleados As List(Of Empleado)

        'Simulo que obtengo los datos de una BBDDD
        listaEmpleados = ExtraccionBBDD()

        For Each empleado In listaEmpleados
            empleado.CalculaSalarioMes()
            Console.WriteLine("el empleado " & empleado.Nombre & "recibirá " & empleado.SalarioMes)
        Next

    End Sub

    ''' <summary>
    ''' Esto simula la extracción de una base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function ExtraccionBBDD() As List(Of Empleado)
        Dim listaEmpleados As List(Of Empleado)
        listaEmpleados = New List(Of Empleado)

        Dim tiempoTrabajadoNormal As TimeSpan
        tiempoTrabajadoNormal = New Date(2022, 2, 28) - New Date(2022, 2, 1)

        listaEmpleados.Add(New Becario("Becario 1", "Y162734T", 4.5, tiempoTrabajadoNormal))
        listaEmpleados.Add(New Becario("Becario 2", "Y192734T", 4.5, tiempoTrabajadoNormal))

        listaEmpleados.Add(New Ingeniero("Ingeniero 1", "Y102734T", 15.5, tiempoTrabajadoNormal))

        listaEmpleados.Add(New Administrador("Administrador 1", "Y202734T", 10.5, tiempoTrabajadoNormal))

        Return listaEmpleados
    End Function
End Module
