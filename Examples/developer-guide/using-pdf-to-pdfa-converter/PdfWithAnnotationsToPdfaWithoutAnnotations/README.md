# PDF with Annotations to PDF/A Without Annotations

This example demonstrates how to convert a PDF document with annotations to PDF/A format while removing all annotations using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF documents to PDF/A format
- Removes all annotations from the source PDF during conversion
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
- Load the source PDF file (`with-annotations.pdf`)
- Convert it to PDF/A format while removing all annotations
- Save the result as `no-annotations.pdf`

## Code Explanation

The example uses the `PdfToPdfAConverter` class with the `HidePdfAnnotations` option set to `True`. This ensures that all annotations (comments, highlights, drawings, etc.) in the source PDF are removed during the conversion to PDF/A format.

```vb
Dim converter As New PdfToPdfAConverter("with-annotations.pdf", Sub(options)
    options.HidePdfAnnotations = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `PdfWithAnnotationsToPdfaWithoutAnnotations.vbproj` - Project file
- `with-annotations.pdf` - Sample PDF file with annotations
- `no-annotations.pdf` - Output PDF/A file without annotations (generated after running the example) 