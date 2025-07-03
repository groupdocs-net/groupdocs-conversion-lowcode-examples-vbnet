# DOC with Tracked Changes to PDF Example

This example demonstrates how to convert DOC files with tracked changes to PDF format while hiding the tracked changes using GroupDocs.Conversion.LowCode.

## Features

- Converts DOC files with tracked changes to PDF format
- Hides tracked changes during conversion
- Uses environment variables for license keys
- Clean PDF output without revision marks

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
2. Ensure the `tracked-changes.doc` file is in the output directory
3. Run the executable

## Expected Output

The example will generate a `clean.pdf` file without tracked changes in the same directory.

## Code Explanation

The example demonstrates:
- Loading license keys from environment variables
- Creating a DocToPdfConverter instance with load options
- Setting HideWordTrackedChanges to True to exclude tracked changes
- Converting the DOC file to PDF format without revision marks

## Files

- `Program.vb` - Main program file
- `tracked-changes.doc` - Sample input file with tracked changes
- `clean.pdf` - Generated output file without tracked changes (after running) 