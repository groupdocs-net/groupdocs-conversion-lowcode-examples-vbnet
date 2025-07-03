Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New PdfToMdConverter("business-plan.pdf")

        ' Convert to Markdown without embedding images as base64
        converter.Convert("without-images.md", Sub(convertOptions)
            convertOptions.MarkdownOptions.ExportImagesAsBase64 = False
        End Sub)
    End Sub
End Module