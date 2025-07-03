# Save to Stream Example

This example demonstrates how to save converted documents to a stream using GroupDocs.Conversion.LowCode.

## Features

- Converts DOCX files to PDF format
- Saves converted documents to stream
- Uses environment variables for license keys
- Stream-based saving approach for memory efficiency

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

The example will generate a `business-plan.pdf` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Opening input and output file streams
- Creating a DocxToPdfConverter instance with input stream
- Converting the DOCX file to PDF format and saving to output stream
- Proper resource disposal with Using statement

## Files

- `Program.vb` - Main program file
- `business-plan.docx` - Sample input file
- `business-plan.pdf` - Generated output file (after running) 