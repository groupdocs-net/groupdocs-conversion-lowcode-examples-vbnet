# Convert PDF to DOCX with A4 Page Size

You can specify the page size for the output DOCX file using the [SizeSettings](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/WordProcessingConvertOptions/SizeSettings/) property of the `WordProcessingConvertOptions` class, which takes a [PageSizeOptions](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options/PageSizeOptions/) object.

The following example shows how to convert a PDF file to DOCX with A4 page size:

## Code Example

```vb
Imports GroupDocs.Conversion.LowCode
Imports GroupDocs.Conversion.Options

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New PdfToDocxConverter("business-plan.pdf")

        ' Convert to DOCX with A4 page size
        converter.Convert("a4-size.docx", Sub(convertOptions)
            convertOptions.SizeSettings = New PageSizeOptions With {.PageSize = PageSize.A4}
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

- `business-plan.pdf`

## Learn More

- [Using PDF to DOCX Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-docx-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
