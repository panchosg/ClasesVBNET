Imports System
Imports System.Xml

Module Program
    Sub Main(args As String())
        Dim documentoXml As XmlDocument
        Dim listaNodosReceta As XmlNodeList
        Dim nacionalidad As String
        documentoXml = New XmlDocument()
        documentoXml.Load("Restaurante.xml")

        listaNodosReceta = documentoXml.SelectNodes("/restaurante/recetas/receta")

        For Each receta As XmlNode In listaNodosReceta
            Console.WriteLine("Receta: " & receta.Attributes("id").Value)
            nacionalidad = receta.SelectSingleNode("nacionalidad").InnerText
            Console.WriteLine("Nacionalidad: " & nacionalidad)
        Next



    End Sub
End Module
