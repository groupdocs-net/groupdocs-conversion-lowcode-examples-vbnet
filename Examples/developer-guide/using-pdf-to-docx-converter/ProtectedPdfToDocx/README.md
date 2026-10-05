# Convert Protected PDF to DOCX

The following example shows how to convert protected PDF file and save it to unprotected DOCX file.

In case you do not specify password for protected document [PasswordRequiredException](https://reference.groupdocs.net/conversion/GroupDocs.Conversion.Exceptions/PasswordRequiredException/) is going to be thrown.

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

        ' Provide password through load options
        Dim converter As New PdfToDocxConverter("protected.pdf", Sub(options)
            options.Password = "12345"
        End Sub)

        ' Convert PDF to DOCX
        converter.Convert("unprotected.docx")
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

- `protected.pdf`

## Learn More

- [Using PDF to DOCX Converter](https://docs.groupdocs.net/conversion/developer-guide/using-pdf-to-docx-converter/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
