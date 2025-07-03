# Protected PDF to PDF/A

This example demonstrates how to convert a password-protected PDF document to PDF/A format using GroupDocs.Conversion.LowCode.

## Features

- Converts password-protected PDF documents to PDF/A format
- Handles password-protected source files
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
- Load the password-protected source PDF file (`protected.pdf`) using password "12345"
- Convert it to PDF/A format
- Save the result as `not-protected.pdf` (without password protection)

## Code Explanation

The example uses the `PdfToPdfAConverter` class with the `Password` option in the load options to handle the password-protected source PDF. The converter will use the provided password to unlock the source file before converting it to PDF/A format.

```vb
Dim converter As New PdfToPdfAConverter("protected.pdf", Sub(options)
    options.Password = "12345"
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `ProtectedPdfToPdfa.vbproj` - Project file
- `protected.pdf` - Sample password-protected PDF file
- `not-protected.pdf` - Output PDF/A file (generated after running the example) 