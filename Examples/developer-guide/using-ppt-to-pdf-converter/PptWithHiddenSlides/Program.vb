Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Show hidden slides through load options
        Dim converter As New PptToPdfConverter("with-hidden-slides.ppt", Sub(options)
            options.ShowHiddenSlides = True
        End Sub)

        ' Convert PPT to PDF
        converter.Convert("with-hidden-slides.pdf")
    End Sub
End Module
