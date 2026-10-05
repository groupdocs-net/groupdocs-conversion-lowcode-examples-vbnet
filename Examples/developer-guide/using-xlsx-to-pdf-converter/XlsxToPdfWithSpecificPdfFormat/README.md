# Convert XLSX to PDF with Specific PDF Format

You can specify the PDF format for the output file using the [PdfFormat](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/PdfOptions/PdfFormat/) property in `PdfOptions` class. This allows you to create PDF files that conform to specific standards like PDF/A for archiving or PDF/X for print production.

The following example shows how to convert an XLSX file to PDF/A-1b format, which is commonly used for long-term archiving:

## Code Example

```vb
Imports GroupDocs.Conversion.LowCode
Imports GroupDocs.Conversion.Options.Convert

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New XlsxToPdfConverter("cost-analysis.xlsx")

        ' Convert to PDF/A-1b format for archiving
        converter.Convert("archived-cost-analysis.pdf", Sub(convertOptions)
            convertOptions.PdfOptions.PdfFormat = PdfFormats.PdfA_1B
        End Sub)
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

- `cost-analysis.xlsx`

## Learn More

- [Using XLSX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xlsx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
