Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Skip external resources through load options
        Dim converter As New HtmlToPdfConverter("with-image.html", Sub(options)
            options.SkipExternalResources = True
        End Sub)

        ' Convert HTML to PDF
        converter.Convert("without-image.pdf")
    End Sub
End Module