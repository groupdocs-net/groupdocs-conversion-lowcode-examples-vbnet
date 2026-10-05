Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Hide tracked changes through load options
        Dim converter As New DocxToPdfConverter("tracked-changes.docx", Sub(options)
            options.HideWordTrackedChanges = True
        End Sub)

        ' Convert DOCX to PDF
        converter.Convert("clean.pdf")
    End Sub
End Module
