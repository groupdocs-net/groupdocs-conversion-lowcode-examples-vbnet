# PDF with Annotations to Markdown Without Annotations Example

This example demonstrates how to convert PDF files with annotations to Markdown format while hiding the annotations using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF files with annotations to Markdown format
- Hides annotations during conversion using HidePdfAnnotations
- Uses environment variables for license keys
- Clean Markdown output without annotation elements

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
2. Ensure the `with-annotations.pdf` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `no-annotations.md` file without annotations in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PdfToMdConverter instance with load options
- Setting HidePdfAnnotations to True to exclude annotations
- Converting the PDF file to Markdown format without annotations

## Files

- `Program.vb` - Main program file
- `with-annotations.pdf` - Sample input file with annotations
- `no-annotations.md` - Generated output file without annotations (after running) 