# PDF to Markdown Skipping Images Example

This example demonstrates how to convert PDF files to Markdown format while skipping images using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF files to Markdown format
- Skips images during conversion by disabling base64 export
- Uses environment variables for license keys
- Cleaner Markdown output without embedded images

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

The example will generate a `without-images.md` file without embedded images in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToMdConverter instance
- Setting MarkdownOptions to disable image export as base64
- Converting the PDF file to Markdown format without images

## Files

- `Program.vb` - Main program file
- `business-plan.pdf` - Sample input file
- `without-images.md` - Generated output file without images (after running) 