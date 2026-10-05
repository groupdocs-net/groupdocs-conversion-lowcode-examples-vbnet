# Basic Example

The following example shows the most common use case for converting HTML document to PDF. The source HTML file is loaded from a current folder. The converted file is saved to the same folder.

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
        Dim converter As New HtmlToPdfConverter("sample.html")

        ' Convert HTML to PDF
        converter.Convert("sample.pdf")
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

- `sample.html`

## Learn More

- [Using HTML to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-html-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
