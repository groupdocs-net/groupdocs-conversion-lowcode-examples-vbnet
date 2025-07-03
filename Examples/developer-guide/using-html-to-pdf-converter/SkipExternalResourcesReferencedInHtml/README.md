# HTML to PDF Skipping External Resources Example

This example demonstrates how to convert HTML files to PDF format while skipping external resources using GroupDocs.Conversion.LowCode.

## Features

- Converts HTML files to PDF format
- Skips external resources (images, CSS, etc.) during conversion
- Uses environment variables for license keys
- Faster conversion by excluding external dependencies

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
2. Ensure the `with-image.html` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `without-image.pdf` file without external resources in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating an HtmlToPdfConverter instance with load options
- Setting SkipExternalResources to True to exclude external content
- Converting the HTML file to PDF format without external resources

## Files

- `Program.vb` - Main program file
- `with-image.html` - Sample input file with external resources
- `without-image.pdf` - Generated output file without external resources (after running) 