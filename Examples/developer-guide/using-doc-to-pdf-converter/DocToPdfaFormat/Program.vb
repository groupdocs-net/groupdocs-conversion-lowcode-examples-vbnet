Imports GroupDocs.Conversion.Options.Convert
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New DocToPdfConverter("business-plan.doc")

        ' Convert to PDF/A format
        converter.Convert("archived.pdf", Sub(convertOptions)
            convertOptions.PdfOptions.PdfFormat = PdfFormats.PdfA_1A
        End Sub)
    End Sub
End Module