# Convert PDF with Annotations to PDF/A without Annotations

By default, annotations are added to the output PDF file, see this [with-annotations.pdf](https://docs.groupdocs.net/conversion/_sample_files/developer-guide/using-pdf-to-pdfa-converter/with-annotations.pdf) (text `HOME BASED PROFESSIONAL SERVICES` is highlighted) as an example of PDF file with annotations.

The following example shows how to convert a PDF file that contains annotations and save a PDF/A file without annotations.

## Code Example

```vb
Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Hide annotations using HidePdfAnnotations
        Dim converter As New PdfToPdfAConverter("with-annotations.pdf", Sub(options)
                                                                             options.HidePdfAnnotations = True
                                                                         End Sub)

        ' Convert PDF to PDF/A
        converter.Convert("no-annotations.pdf")
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

- `with-annotations.pdf`

## Learn More

- [Using PDF to PDF/A Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-pdfa-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
