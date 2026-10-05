# Convert HTML with Zoom Level

The following example shows how to set a custom zoom level when converting HTML to PDF using the `Zoom` property.

**Note:** When using zoom levels greater than 100%, the content may not fit into standard page sizes. Consider using [PageLayoutOptions](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Load/WebLoadOptions/PageLayoutOptions/) to fit page by width or height if needed.

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

        ' Set zoom level to 150% through load options
        Dim converter As New HtmlToPdfConverter("sample.html", Sub(options)
            options.Zoom = 150 ' 150% zoom level
        End Sub)

        ' Convert HTML to PDF
        converter.Convert("zoomed-sample.pdf")
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
