# HTML to Password Protected PDF Example

This example demonstrates how to convert HTML files to password-protected PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts HTML files to password-protected PDF format
- Sets password protection on the output PDF
- Uses environment variables for license keys
- Secure document conversion with password protection

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

The example will generate a `protected.pdf` file with password protection in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating an HtmlToPdfConverter instance
- Setting conversion options to add password protection
- Converting the HTML file to password-protected PDF format

## Files

- `Program.vb` - Main program file
- `sample.html` - Sample input file
- `protected.pdf` - Generated password-protected output file (after running) 