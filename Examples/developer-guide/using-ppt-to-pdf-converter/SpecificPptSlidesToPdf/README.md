# Convert Specific PPT Slides to PDF

To convert only a portion of the presentation instead of all slides. You can specify which slides to include in the output PDF using the [Pages](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/IPagedConvertOptions/PageNumber/) property of `PdfConvertOptions` class.

As an alternative you can use `PageNumber` to specify the slide number to start conversion from and `PagesCount` to set number of slides to convert starting from `PageNumber`. 

The following example shows how to convert the first three slides of a PPT file to PDF:

## Code Example

```vb
Imports System
Imports System.Collections.Generic
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Create the converter
        Dim converter As New PptToPdfConverter("presentation.ppt")

        ' Save first three slides to PDF
        converter.Convert("slides-1-2-3.pdf", Sub(convertOptions)
                                                convertOptions.Pages = New List(Of Integer) From {1, 2, 3}
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

- `presentation.ppt`

## Learn More

- [Using PPT to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-ppt-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
