# Basic Example

The following example shows the most common use case for converting Excel XLS document to PDF. The source XLS file is loaded from a current folder. The converted file is saved to the same folder.

## Code Example

```vb
Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply the license
        License.Set(publicKey, privateKey)

        ' Create a converter from file path
        Dim converter As New XlsToPdfConverter("cost-analysis.xls")

        ' Convert XLS to PDF
        converter.Convert("cost-analysis.pdf")
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

- `cost-analysis.xls`

## Learn More

- [Using XLS to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xls-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
