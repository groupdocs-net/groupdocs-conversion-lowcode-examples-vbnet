# XLS to PDF with Specific PDF Format Example

This example demonstrates how to convert XLS files to PDF format with specific PDF/A-1b format using GroupDocs.Conversion.LowCode.

## Features

- Converts XLS files to PDF format
- Sets specific PDF/A-1b format for archiving compliance
- Uses environment variables for license keys
- Archive-compliant PDF generation

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
2. Ensure the `cost-analysis.xls` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `converted.pdf` file in PDF/A-1b format in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating an XlsToPdfConverter instance
- Setting conversion options to specify PDF/A-1b format
- Converting the XLS file to archive-compliant PDF format

## Files

- `Program.vb` - Main program file
- `cost-analysis.xls` - Sample input file
- `converted.pdf` - Generated PDF/A-1b output file (after running) 