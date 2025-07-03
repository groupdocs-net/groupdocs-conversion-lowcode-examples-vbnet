Imports GroupDocs.Conversion.LowCode
Imports GroupDocs.Conversion.Options.Convert

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New XlsToPdfConverter("cost-analysis.xls")

        ' Convert to PDF/A-1b format for archiving
        converter.Convert("converted.pdf", Sub(convertOptions)
            convertOptions.PdfOptions.PdfFormat = PdfFormats.PdfA_1B
        End Sub)
    End Sub
End Module