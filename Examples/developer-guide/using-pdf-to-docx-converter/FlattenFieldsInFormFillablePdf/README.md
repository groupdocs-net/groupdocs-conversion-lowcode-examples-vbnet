# PDF to DOCX Flattening Form Fields Example

This example demonstrates how to convert PDF files with form fields to DOCX format while flattening the form fields using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF files with form fields to DOCX format
- Flattens all form fields during conversion
- Uses environment variables for license keys
- Converts interactive forms to static content

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
2. Ensure the `form-fields.pdf` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `flattened.docx` file with flattened form fields in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToDocxConverter instance with load options
- Setting FlattenAllFields to True to flatten form fields
- Converting the PDF file to DOCX format with flattened fields

## Files

- `Program.vb` - Main program file
- `form-fields.pdf` - Sample input file with form fields
- `flattened.docx` - Generated output file with flattened fields (after running) 