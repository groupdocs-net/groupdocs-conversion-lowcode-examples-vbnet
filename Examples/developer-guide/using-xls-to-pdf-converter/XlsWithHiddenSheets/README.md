# Convert XLS with Hidden Sheets

By default hidden sheets are not added to the converted PDF document.

The following example shows how to include hidden sheets when converting XLS to PDF using the `ShowHiddenSheets` property.

## Code Example

```vb
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
```

## How to Run

1. Install the .NET SDK for `net10.0`.
2. Set the `GD_PUBLIC_KEY` and `GD_PRIVATE_KEY` environment variables to your license keys.
3. Open this directory and run the example:
   ```bash
   dotnet run
   ```

## Input Files

- `hidden-sheets.xls`

## Learn More

- [Using XLS to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-xls-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
