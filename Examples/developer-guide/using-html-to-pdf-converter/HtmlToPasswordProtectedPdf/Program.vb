Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New HtmlToPdfConverter("sample.html")

        ' Convert to password-protected PDF
        converter.Convert("protected.pdf", Sub(convertOptions)
            convertOptions.Password = "12345"
        End Sub)
    End Sub
End Module