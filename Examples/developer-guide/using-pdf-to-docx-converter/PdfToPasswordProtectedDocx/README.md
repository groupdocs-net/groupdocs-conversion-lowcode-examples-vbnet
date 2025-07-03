# PDF to Password Protected DOCX Example

This example demonstrates how to convert PDF files to password-protected DOCX format using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF files to password-protected DOCX format
- Sets password protection on the output DOCX
- Uses environment variables for license keys
- Secure document conversion with password protection

## Prerequisites

- .NET 6 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license keys

## Environment Variables

Set the following environment variables before running the example:

```bash
GD_PUBLIC_KEY=your_public_key_here
GD_PRIVATE_KEY=your_private_key_here
```

## How to Run

1. Build the project
2. Ensure the `business-plan.pdf` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `protected.docx` file with password protection in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToDocxConverter instance
- Setting conversion options to add password protection
- Converting the PDF file to password-protected DOCX format

## Files

- `Program.vb` - Main program file
- `business-plan.pdf` - Sample input file
- `protected.docx` - Generated password-protected output file (after running) 