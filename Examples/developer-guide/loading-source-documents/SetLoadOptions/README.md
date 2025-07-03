# Set Load Options Example

This example demonstrates how to set load options for protected documents and convert them to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Handles password-protected documents
- Sets custom load options for document loading
- Converts protected DOCX files to unprotected PDF format
- Uses environment variables for license keys

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
2. Ensure the `protected.docx` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `not-protected.pdf` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocxToPdfConverter instance with load options
- Setting password for protected document access
- Converting the protected DOCX file to unprotected PDF format

## Files

- `Program.vb` - Main program file
- `protected.docx` - Sample password-protected input file
- `not-protected.pdf` - Generated unprotected output file (after running) 