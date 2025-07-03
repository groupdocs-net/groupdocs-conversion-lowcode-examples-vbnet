# DOCX with Tracked Changes to PDF

This example demonstrates how to convert a DOCX file with tracked changes to PDF format while hiding the tracked changes using GroupDocs.Conversion.LowCode.

## Features

- Converts DOCX files to PDF format
- Hides tracked changes during conversion
- Uses environment variables for license configuration
- Simple and clean API usage

## Prerequisites

- .NET 6 or later
- GroupDocs.Conversion.LowCode package

## Environment Variables

Set the following environment variables with your GroupDocs license keys:

```bash
GD_PUBLIC_KEY=your_public_key_here
GD_PRIVATE_KEY=your_private_key_here
```

## How to Run

1. Ensure you have the required environment variables set
2. Build the project: `dotnet build`
3. Run the example: `dotnet run`

## Expected Output

The example will:
- Load the source DOCX file (`tracked-changes.docx`)
- Convert it to PDF format while hiding tracked changes
- Save the result as `clean.pdf`

## Code Explanation

The example uses the `DocxToPdfConverter` class with the `HideWordTrackedChanges` option set to `True`. This ensures that all tracked changes (insertions, deletions, formatting changes) in the source DOCX file are hidden during the conversion to PDF format.

```vb
Dim converter As New DocxToPdfConverter("tracked-changes.docx", Sub(options)
    options.HideWordTrackedChanges = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `DocxWithTrackedChangesToPdf.vbproj` - Project file
- `tracked-changes.docx` - Sample DOCX file with tracked changes
- `clean.pdf` - Output PDF file without tracked changes (generated after running the example) 