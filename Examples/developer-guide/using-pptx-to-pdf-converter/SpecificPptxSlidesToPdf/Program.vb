Imports System
Imports System.Collections.Generic
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New PptxToPdfConverter("presentation.pptx")

        ' Save first three slides to PDF
        converter.Convert("slides-1-2-3.pdf", Sub(convertOptions)
                                                convertOptions.Pages = New List(Of Integer) From {1, 2, 3}
                                            End Sub)
    End Sub
End Module