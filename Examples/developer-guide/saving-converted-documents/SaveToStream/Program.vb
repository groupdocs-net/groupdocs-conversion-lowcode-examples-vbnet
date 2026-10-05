Imports System
Imports System.IO
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Load DOCX file as stream
        Using inputStream As FileStream = File.OpenRead("business-plan.docx"),
              outputStream As FileStream = File.Create("business-plan.pdf")

            ' Create a converter from stream
            Dim converter As New DocxToPdfConverter(inputStream)

            ' Convert DOCX to PDF
            converter.Convert(outputStream)
        End Using
    End Sub
End Module
