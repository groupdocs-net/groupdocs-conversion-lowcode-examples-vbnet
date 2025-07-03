# Set Convert Options Example

This example demonstrates how to set conversion options when saving documents using GroupDocs.Conversion.LowCode.

## Features

- Converts DOCX files to PDF format
- Sets custom conversion options
- Converts specific pages only (pages 1, 2, and 3)
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
2. Ensure the `business-plan.docx` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `pages-1-2-3.pdf` file containing only the first three pages of the original document.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocxToPdfConverter instance
- Setting conversion options to specify which pages to convert
- Converting only selected pages (1, 2, and 3) to PDF format

## Files

- `Program.vb` - Main program file
- `business-plan.docx` - Sample input file
- `pages-1-2-3.pdf` - Generated output file with selected pages (after running) 