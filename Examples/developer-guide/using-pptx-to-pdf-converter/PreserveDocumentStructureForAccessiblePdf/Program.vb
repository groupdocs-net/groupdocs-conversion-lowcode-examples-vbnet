Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Preserve document structure through load options
        Dim converter As New PptxToPdfConverter("presentation.pptx", Sub(options)
            options.PreserveDocumentStructure = True
        End Sub)

        ' Convert PPTX to PDF
        converter.Convert("accessible.pdf")
    End Sub
End Module