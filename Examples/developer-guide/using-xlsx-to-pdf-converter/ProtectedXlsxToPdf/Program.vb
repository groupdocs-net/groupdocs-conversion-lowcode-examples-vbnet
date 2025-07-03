Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Provide password through load options
        Dim converter As New XlsxToPdfConverter("protected.xlsx", Sub(options)
            options.Password = "12345"
        End Sub)

        ' Convert XLSX to PDF
        converter.Convert("not-protected.pdf")
    End Sub
End Module