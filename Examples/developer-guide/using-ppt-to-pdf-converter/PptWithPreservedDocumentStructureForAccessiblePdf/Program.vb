Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Preserve document structure for accessible PDF
        Dim converter As New PptToPdfConverter("presentation.ppt", Sub(options)
            options.PreserveDocumentStructure = True
        End Sub)

        ' Convert PPT to accessible PDF
        converter.Convert("accessible.pdf")
    End Sub
End Module
