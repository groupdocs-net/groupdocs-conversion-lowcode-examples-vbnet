Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Apply custom CSS styling through load options
        Dim converter As New HtmlToPdfConverter("sample.html", Sub(options)
            options.CustomCssStyle = "body { font-family: Arial, sans-serif; font-size: 14px; color: #333; }"
        End Sub)

        ' Convert HTML to PDF
        converter.Convert("styled-sample.pdf")
    End Sub
End Module
