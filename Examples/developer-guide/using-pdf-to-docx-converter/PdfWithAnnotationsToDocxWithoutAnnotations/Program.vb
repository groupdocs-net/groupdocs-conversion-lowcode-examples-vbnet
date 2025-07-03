Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Hide annotations using HidePdfAnnotations
        Dim converter As New PdfToDocxConverter("with-annotations.pdf", Sub(options)
                                                                             options.HidePdfAnnotations = True
                                                                         End Sub)

        ' Convert PDF to DOCX
        converter.Convert("no-annotations.docx")
    End Sub
End Module