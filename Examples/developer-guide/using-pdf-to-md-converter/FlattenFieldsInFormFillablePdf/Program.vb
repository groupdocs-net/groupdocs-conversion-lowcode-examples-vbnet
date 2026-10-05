Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Flatten form fields through load options
        Dim converter As New PdfToMdConverter("form-fields.pdf", Sub(options)
            options.FlattenAllFields = True
        End Sub)

        ' Convert PDF to Markdown
        converter.Convert("flattened.md")
    End Sub
End Module
