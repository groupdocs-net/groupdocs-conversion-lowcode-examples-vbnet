Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Include hidden sheets in conversion
        Dim converter As New XlsxToPdfConverter("hidden-worksheets.xlsx", Sub(options)
            options.ShowHiddenSheets = True
        End Sub)

        ' Convert XLSX to PDF
        converter.Convert("with-hidden-sheets.pdf")
    End Sub
End Module
