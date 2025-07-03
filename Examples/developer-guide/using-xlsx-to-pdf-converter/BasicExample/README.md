# Basic XLSX to PDF Conversion Example

This example demonstrates how to convert XLSX files to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts XLSX files to PDF format
- Uses environment variables for license keys
- Simple and straightforward conversion process

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
2. Ensure the `cost-analysis.xlsx` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `cost-analysis.pdf` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating an XlsxToPdfConverter instance
- Converting the XLSX file to PDF format

## Files

- `Program.vb` - Main program file
- `cost-analysis.xlsx` - Sample input file
- `cost-analysis.pdf` - Generated output file (after running) 