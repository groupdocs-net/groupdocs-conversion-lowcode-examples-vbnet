# XLSX to PDF with Specific PDF Format

This example demonstrates how to convert an XLSX file to PDF with a specific PDF format (PDF/A-1b) for archiving purposes using GroupDocs.Conversion.LowCode.

## Features

- Converts XLSX files to PDF format
- Specifies PDF/A-1b format for long-term archiving
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
- Load the source XLSX file (`cost-analysis.xlsx`)
- Convert it to PDF/A-1b format for archiving
- Save the result as `archived-cost-analysis.pdf`

## Code Explanation

The example uses the `XlsxToPdfConverter` class to convert the XLSX file to PDF format. During the conversion, it specifies PDF/A-1b format using the `PdfFormat` option in the PDF options. PDF/A-1b is designed for long-term archiving and ensures document preservation.

```vb
Dim converter As New XlsxToPdfConverter("cost-analysis.xlsx")

converter.Convert("archived-cost-analysis.pdf", Sub(convertOptions)
    convertOptions.PdfOptions.PdfFormat = PdfFormats.PdfA_1B
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `XlsxToPdfWithSpecificPdfFormat.vbproj` - Project file
- `cost-analysis.xlsx` - Sample XLSX file
- `archived-cost-analysis.pdf` - Output PDF/A-1b file (generated after running the example) 