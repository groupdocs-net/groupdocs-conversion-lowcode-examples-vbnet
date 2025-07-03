# PDF to DOCX with A4 Page Size Example

This example demonstrates how to convert PDF files to DOCX format with specific A4 page size using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF files to DOCX format
- Sets A4 page size for the output document
- Uses environment variables for license keys
- Customizable page size configuration

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

The example will generate an `a4-size.docx` file with A4 page size in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToDocxConverter instance
- Setting conversion options to specify A4 page size
- Converting the PDF file to DOCX format with custom page size

## Files

- `Program.vb` - Main program file
- `business-plan.pdf` - Sample input file
- `a4-size.docx` - Generated output file with A4 page size (after running) 