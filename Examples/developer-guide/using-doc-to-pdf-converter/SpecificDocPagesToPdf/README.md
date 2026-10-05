# Convert Specific DOC Pages to PDF

To convert only a portion of the document instead of all pages. You can specify which pages to include in the output PDF using the [Pages](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Options.Convert/IPagedConvertOptions/PageNumber/) property of `PdfConvertOptions` class.

As an alternative you can use `PageNumber` to specify the page number to start conversion from and `PagesCount` to set number of pages to convert starting from `PageNumber`. 

The following example shows how to convert the first three pages of a DOC file to PDF:

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
        Dim converter As New DocToPdfConverter("business-plan.doc")

        ' Save first three pages to PDF
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

- `business-plan.doc`

## Learn More

- [Using DOC to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-doc-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
