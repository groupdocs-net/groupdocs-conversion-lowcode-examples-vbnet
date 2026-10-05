# Example 2: Save to Stream

This example demonstrates how to save the converted file to a `Stream`.

## Code Example

```vb
Imports System
Imports System.IO
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Load DOCX file as stream
        Using inputStream As FileStream = File.OpenRead("business-plan.docx"),
              outputStream As FileStream = File.Create("business-plan.pdf")

            ' Create a converter from stream
            Dim converter As New DocxToPdfConverter(inputStream)

            ' Convert DOCX to PDF
            converter.Convert(outputStream)
        End Using
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

- `business-plan.docx`

## Learn More

- [Saving Converted Documents](https://docs.groupdocs.net/conversion/developer-guide/saving-converted-documents/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
