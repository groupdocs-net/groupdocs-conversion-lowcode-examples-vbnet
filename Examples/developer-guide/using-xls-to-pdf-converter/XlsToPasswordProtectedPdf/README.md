# XLS to Password Protected PDF

This example demonstrates how to convert an XLS file to password-protected PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts XLS files to PDF format
- Applies password protection to the output PDF file
- Uses environment variables for license configuration
- Simple and clean API usage

## Prerequisites

- .NET 6 or later
- GroupDocs.Conversion.LowCode package

## Environment Variables

Set the following environment variables with your GroupDocs license keys:

```bash
GD_PUBLIC_KEY=your_public_key_here
GD_PRIVATE_KEY=your_private_key_here
```

## How to Run

1. Ensure you have the required environment variables set
2. Build the project: `dotnet build`
3. Run the example: `dotnet run`

## Expected Output

The example will:
- Load the source XLS file (`cost-analysis.xls`)
- Convert it to password-protected PDF format
- Save the result as `protected.pdf` with password "12345"

## Code Explanation

The example uses the `XlsToPdfConverter` class to convert the XLS file to PDF format. During the conversion, it applies password protection using the `Password` option in the convert options.

```vb
Dim converter As New XlsToPdfConverter("cost-analysis.xls")

converter.Convert("protected.pdf", Sub(convertOptions)
    convertOptions.Password = "12345"
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `XlsToPasswordProtectedPdf.vbproj` - Project file
- `cost-analysis.xls` - Sample XLS file
- `protected.pdf` - Output password-protected PDF file (generated after running the example) 