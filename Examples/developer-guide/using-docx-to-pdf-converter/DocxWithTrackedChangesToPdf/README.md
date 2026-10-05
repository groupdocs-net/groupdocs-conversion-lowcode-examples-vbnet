# Convert DOCX with Tracked Changes to PDF

By default, tracked changes are converted and displayed in the output PDF document. See this [tracked-changes.pdf](https://docs.groupdocs.net/conversion/_sample_files/developer-guide/using-docx-to-pdf-converter/tracked-changes.pdf) that includes the list of changes.

The following example shows how to convert a DOCX file that contains tracked changes and save a clean PDF file without those revisions.

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

        ' Hide tracked changes through load options
        Dim converter As New DocxToPdfConverter("tracked-changes.docx", Sub(options)
            options.HideWordTrackedChanges = True
        End Sub)

        ' Convert DOCX to PDF
        converter.Convert("clean.pdf")
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

- `tracked-changes.docx`

## Learn More

- [Using DOCX to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-docx-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
