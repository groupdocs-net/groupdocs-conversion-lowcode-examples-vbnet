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
        Dim converter As New PdfToDocxConverter("business-plan.pdf")

        ' Convert to DOCX with A4 page size
        converter.Convert("a4-size.docx", Sub(convertOptions)
            convertOptions.PageSize = PageSize.A4
        End Sub)
    End Sub
End Module