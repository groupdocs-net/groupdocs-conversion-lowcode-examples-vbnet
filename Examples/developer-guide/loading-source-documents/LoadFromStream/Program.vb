Imports System.IO
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Load stream and convert
        Using stream As FileStream = File.OpenRead("business-plan.docx")
            Dim converter As New DocxToPdfConverter(stream)

            ' Convert DOCX to PDF
            converter.Convert("business-plan.pdf")
        End Using
    End Sub
End Module