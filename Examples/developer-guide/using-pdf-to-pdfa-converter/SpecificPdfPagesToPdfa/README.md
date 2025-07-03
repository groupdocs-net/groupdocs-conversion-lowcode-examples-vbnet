# Specific PDF Pages to PDF/A

This example demonstrates how to convert specific pages from a PDF document to PDF/A format using GroupDocs.Conversion.LowCode.

## Features

- Converts specific pages from PDF documents to PDF/A format
- Allows selection of individual pages for conversion
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
- Load the source PDF file (`business-plan.pdf`)
- Convert only pages 1, 2, and 3 to PDF/A format
- Save the result as `pages-1-2-3.pdf`

## Code Explanation

The example uses the `PdfToPdfAConverter` class to convert the PDF to PDF/A format. During the conversion, it specifies which pages to include using the `Pages` option in the convert options.

```vb
Dim converter As New PdfToPdfAConverter("business-plan.pdf")

converter.Convert("pages-1-2-3.pdf", Sub(convertOptions)
    convertOptions.Pages = New List(Of Integer) From {1, 2, 3}
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `SpecificPdfPagesToPdfa.vbproj` - Project file
- `business-plan.pdf` - Sample PDF file
- `pages-1-2-3.pdf` - Output PDF/A file with specific pages (generated after running the example) 