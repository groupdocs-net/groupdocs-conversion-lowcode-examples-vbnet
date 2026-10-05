Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Provide password through load options
        Dim converter As New PdfToMdConverter("protected.pdf", Sub(options)
            options.Password = "12345"
        End Sub)

        ' Convert PDF to Markdown
        converter.Convert("unprotected.md")
    End Sub
End Module
