Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Show hidden sheets through load options
        Dim converter As New XlsToPdfConverter("hidden-sheets.xls", Sub(options)
            options.ShowHiddenSheets = True
        End Sub)

        ' Convert XLS to PDF
        converter.Convert("with-hidden-sheets.pdf")
    End Sub
End Module