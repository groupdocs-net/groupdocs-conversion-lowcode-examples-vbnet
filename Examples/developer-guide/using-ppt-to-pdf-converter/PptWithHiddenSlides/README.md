# Convert PPT with Hidden Slides

By default hidden slides are not added to the converted PDF document.

The following example shows how to include hidden slides when converting PPT to PDF using the `ShowHiddenSlides` property.

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

        ' Show hidden slides through load options
        Dim converter As New PptToPdfConverter("with-hidden-slides.ppt", Sub(options)
            options.ShowHiddenSlides = True
        End Sub)

        ' Convert PPT to PDF
        converter.Convert("with-hidden-slides.pdf")
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

- `with-hidden-slides.ppt`

## Learn More

- [Using PPT to PDF Converter](https://docs.groupdocs.net/conversion/developer-guide/using-ppt-to-pdf-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
