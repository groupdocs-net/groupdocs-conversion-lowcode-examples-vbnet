Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Set zoom level to 150% through load options
        Dim converter As New HtmlToPdfConverter("sample.html", Sub(options)
            options.Zoom = 150 ' 150% zoom level
        End Sub)

        ' Convert HTML to PDF
        converter.Convert("zoomed-sample.pdf")
    End Sub
End Module