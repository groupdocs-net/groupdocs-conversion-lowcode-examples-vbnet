# Basic PPTX to PDF Conversion Example

This example demonstrates how to convert PPTX files to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts PPTX files to PDF format
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
2. Ensure the `presentation.pptx` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `converted.pdf` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a PptxToPdfConverter instance
- Converting the PPTX file to PDF format

## Files

- `Program.vb` - Main program file
- `presentation.pptx` - Sample input file
- `converted.pdf` - Generated output file (after running) 