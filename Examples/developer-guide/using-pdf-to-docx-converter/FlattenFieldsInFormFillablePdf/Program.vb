Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Flatten form fields through load options
        Dim converter As New PdfToDocxConverter("form-fields.pdf", Sub(options)
            options.FlattenAllFields = True
        End Sub)

        ' Convert PDF to DOCX
        converter.Convert("flattened.docx")
    End Sub
End Module