Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Create a converter from file path
        Dim converter As New PptxToPdfConverter("presentation.pptx")

        ' Convert PPTX to PDF
        converter.Convert("converted.pdf")
    End Sub
End Module
