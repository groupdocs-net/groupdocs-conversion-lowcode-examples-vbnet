Imports System
Imports System.Collections.Generic
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Convert only specific sheets (first and third sheets)
        Dim converter As New XlsxToPdfConverter("invoice-tracker.xlsx", Sub(options)
            options.SheetIndexes = New List(Of Integer) From {0, 2} ' 0-based indexing
        End Sub)

        ' Convert XLSX to PDF
        converter.Convert("specific-sheets.pdf")
    End Sub
End Module