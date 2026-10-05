# Convert Specific PDF Pages to PDF/A

To convert only a portion of the document instead of all pages. You can specify which pages to include in the output PDF using the [Pages](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/IPagedConvertOptions/PageNumber/) property of `PdfConvertOptions` class.

As an alternative you can use `PageNumber` to specify the page number to start conversion from and `PagesCount` to set number of pages to convert starting from `PageNumber`. 

The following example shows how to convert the first three pages of a PDF file to PDF/A:

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
        Dim converter As New PdfToPdfAConverter("business-plan.pdf")

        ' Save first three pages to PDF/A
        converter.Convert("pages-1-2-3.pdf", Sub(convertOptions)
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

- `business-plan.pdf`

## Learn More

- [Using PDF to PDF/A Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-pdfa-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
