Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Hide tracked changes through load options
        Dim converter As New PdfToPdfAConverter("form-fields.pdf", Sub(options)
            options.FlattenAllFields = True
        End Sub)

        ' Convert PDF to PDF/A
        converter.Convert("flattened.pdf")
    End Sub
End Module