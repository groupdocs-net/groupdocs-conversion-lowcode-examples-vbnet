# HTML to PDF with Custom CSS Styling Example

This example demonstrates how to convert HTML files to PDF format with custom CSS styling using GroupDocs.Conversion.LowCode.

## Features

- Converts HTML files to PDF format
- Applies custom CSS styling during conversion
- Uses environment variables for license keys
- Customizable document appearance

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
2. Ensure the `sample.html` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `styled-sample.pdf` file with custom CSS styling in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating an HtmlToPdfConverter instance with load options
- Setting custom CSS styling for the document
- Converting the HTML file to PDF format with applied styling

## Files

- `Program.vb` - Main program file
- `sample.html` - Sample input file
- `styled-sample.pdf` - Generated output file with custom styling (after running) 