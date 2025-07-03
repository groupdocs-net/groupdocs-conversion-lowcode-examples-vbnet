# Preserve Document Structure for Accessible PDF

This example demonstrates how to convert a PPTX presentation to PDF format while preserving document structure for better accessibility using GroupDocs.Conversion.LowCode.

## Features

- Converts PPTX presentations to PDF format
- Preserves document structure for accessibility compliance
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
- Load the source PPTX file (`presentation.pptx`)
- Convert it to PDF format while preserving document structure
- Save the result as `accessible.pdf`

## Code Explanation

The example uses the `PptxToPdfConverter` class with the `PreserveDocumentStructure` option set to `True`. This ensures that the document structure (headings, lists, tables, etc.) is preserved in the PDF output, making it more accessible for screen readers and other assistive technologies.

```vb
Dim converter As New PptxToPdfConverter("presentation.pptx", Sub(options)
    options.PreserveDocumentStructure = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `PreserveDocumentStructureForAccessiblePdf.vbproj` - Project file
- `presentation.pptx` - Sample PPTX presentation file
- `accessible.pdf` - Output accessible PDF file (generated after running the example) 