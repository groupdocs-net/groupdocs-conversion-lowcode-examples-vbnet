# Convert Specific Sheets from XLSX to PDF

The following example shows how to convert only specific sheets from an XLSX file to PDF using the `SheetIndexes` property.

## Code Example

```vb
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
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `invoice-tracker.xlsx`

## Learn More

- [Using XLSX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xlsx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
