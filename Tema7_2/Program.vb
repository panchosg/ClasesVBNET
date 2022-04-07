Imports System
Imports System.IO
Imports System.Xml

Module Program
    Sub Main(args As String())


        'Forma de cargar documentos xml desde archivos
        'Dim documentoXml As XDocument
        'Dim path As String


        'path = Directory.GetCurrentDirectory & "\xmlOrigen.xml"
        'Console.WriteLine(path)
        'documentoXml = XDocument.Load(path)

        Dim doc As XmlDocument = New XmlDocument()
        Dim raiz As XmlElement
        Dim raizAtributos As XmlAttributeCollection
        Dim atributo As XmlAttribute

        doc.LoadXml("<Libro Genero='Novela' " & "ISBN='1-861001-57-5' " &
                    "Comentario='mal estado'>" & "<Titulo>El oro del Rey</Titulo>" &
                    "<Precio>14.95</Precio>" & "</Libro>")

        raiz = doc.DocumentElement
        raizAtributos = raiz.Attributes
        For posicion = 0 To raizAtributos.Count - 1
            Console.Write("el nombre del atributo en la raíz es:" & raizAtributos(posicion).Name)
            Console.WriteLine("; el valor del atributo en la raíz es:" & raizAtributos(posicion).Value)
        Next

        If raiz.HasAttribute("ISBN") Then
            atributo = raizAtributos("ISBN")
            Console.WriteLine("El valor del atributo ISBN es " & atributo.Value)
        End If














    End Sub
End Module
