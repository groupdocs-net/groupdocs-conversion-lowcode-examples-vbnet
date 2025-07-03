# PDF to Password Protected PDF/A

This example demonstrates how to convert a PDF document to password-protected PDF/A format using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF documents to PDF/A format
- Applies password protection to the output PDF/A file
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
- Load the source PDF file (`business-plan.pdf`)
- Convert it to password-protected PDF/A format
- Save the result as `protected.pdf` with password "12345"

## Code Explanation

The example uses the `PdfToPdfAConverter` class to convert the PDF to PDF/A format. During the conversion, it applies password protection using the `Password` option in the convert options.

```vb
Dim converter As New PdfToPdfAConverter("business-plan.pdf")

converter.Convert("protected.pdf", Sub(convertOptions)
    convertOptions.Password = "12345"
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `PdfToPasswordProtectedPdfa.vbproj` - Project file
- `business-plan.pdf` - Sample PDF file
- `protected.pdf` - Output password-protected PDF/A file (generated after running the example) 