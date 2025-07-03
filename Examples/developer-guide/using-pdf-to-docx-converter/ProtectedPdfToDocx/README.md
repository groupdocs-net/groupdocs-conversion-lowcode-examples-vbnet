# Protected PDF to DOCX Example

This example demonstrates how to convert password-protected PDF files to DOCX format using GroupDocs.Conversion.LowCode.

## Features

- Converts password-protected PDF files to DOCX format
- Handles password-protected input documents
- Uses environment variables for license keys
- Converts protected documents to unprotected output

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
2. Ensure the `protected.pdf` file is in the output directory
3. Run the executable

## Expected Output

The example will generate an `unprotected.docx` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToDocxConverter instance with load options
- Providing password for the protected PDF file
- Converting the protected PDF file to unprotected DOCX format

## Files

- `Program.vb` - Main program file
- `protected.pdf` - Sample password-protected input file
- `unprotected.docx` - Generated unprotected output file (after running) 