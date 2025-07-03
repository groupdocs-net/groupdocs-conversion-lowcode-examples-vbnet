# DOC to PDF/A Format Example

This example demonstrates how to convert DOC files to PDF/A format using GroupDocs.Conversion.LowCode.

## Features

- Converts DOC files to PDF/A format (archival standard)
- Sets PDF/A-1A compliance for long-term preservation
- Uses environment variables for license keys
- Ensures document accessibility and preservation

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
2. Ensure the `business-plan.doc` file is in the output directory
3. Run the executable

## Expected Output

The example will generate an `archived.pdf` file in PDF/A-1A format in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocToPdfConverter instance
- Setting conversion options to specify PDF/A-1A format
- Converting the DOC file to PDF/A format for archival purposes

## Files

- `Program.vb` - Main program file
- `business-plan.doc` - Sample input file
- `archived.pdf` - Generated PDF/A format output file (after running) 