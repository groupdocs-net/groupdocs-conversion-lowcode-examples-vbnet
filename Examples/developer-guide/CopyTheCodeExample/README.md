# Step 5: Copy the Code Example

Replace the contents of your `Program` file with the example code below.

## Code Example

```vb
Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        License.Set(publicKey, privateKey)

        Dim converter As New XlsxToPdfConverter("cost-analysis.xlsx")
        converter.Convert("cost-analysis.pdf")
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

- `cost-analysis.xlsx`

## Learn More

- [Developer Guide](https://docs.groupdocs.net/conversion/developer-guide/) in the GroupDocs.Conversion.LowCode documentation
- [GroupDocs.Conversion.LowCode](https://www.nuget.org/packages/GroupDocs.Conversion.LowCode) on NuGet
- [Get a temporary license](https://purchase.groupdocs.net/temporary-license/)
