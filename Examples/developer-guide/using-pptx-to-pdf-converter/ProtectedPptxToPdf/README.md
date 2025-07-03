# Protected PPTX to PDF

This example demonstrates how to convert a password-protected PPTX presentation to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts password-protected PPTX presentations to PDF format
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
- Load the password-protected source PPTX file (`protected.pptx`) using password "12345"
- Convert it to PDF format
- Save the result as `unprotected.pdf` (without password protection)

## Code Explanation

The example uses the `PptxToPdfConverter` class with the `Password` option in the load options to handle the password-protected source PPTX. The converter will use the provided password to unlock the source file before converting it to PDF format.

```vb
Dim converter As New PptxToPdfConverter("protected.pptx", Sub(options)
    options.Password = "12345"
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `ProtectedPptxToPdf.vbproj` - Project file
- `protected.pptx` - Sample password-protected PPTX presentation file
- `unprotected.pdf` - Output PDF file (generated after running the example) 