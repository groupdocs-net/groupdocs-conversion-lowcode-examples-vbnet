# DOCX with Comments to PDF Without Comments Example

This example demonstrates how to convert DOCX files with comments to PDF format while hiding the comments using GroupDocs.Conversion.LowCode.

## Features

- Converts DOCX files with comments to PDF format
- Hides comments during conversion using CommentDisplayMode
- Uses environment variables for license keys
- Clean PDF output without comment annotations

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
2. Ensure the `with-comments.docx` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `no-comments.pdf` file without comments in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocxToPdfConverter instance with load options
- Setting CommentDisplayMode to Hidden to exclude comments
- Converting the DOCX file to PDF format without comments

## Files

- `Program.vb` - Main program file
- `with-comments.docx` - Sample input file with comments
- `no-comments.pdf` - Generated output file without comments (after running) 