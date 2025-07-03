# Protected DOC to PDF Example

This example demonstrates how to convert password-protected DOC files to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts password-protected DOC files to PDF format
- Sets password for protected document access
- Uses environment variables for license keys
- Securely handles protected documents

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
2. Ensure the `protected.doc` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `not-protected.pdf` file in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocToPdfConverter instance with load options
- Setting password for protected document access
- Converting the protected DOC file to PDF format

## Files

- `Program.vb` - Main program file
- `protected.doc` - Sample password-protected input file
- `not-protected.pdf` - Generated output file (after running) 