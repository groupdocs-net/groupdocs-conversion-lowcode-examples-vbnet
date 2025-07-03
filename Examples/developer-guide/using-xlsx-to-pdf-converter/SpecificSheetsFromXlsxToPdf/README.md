# Specific Sheets from XLSX to PDF

This example demonstrates how to convert specific sheets from an XLSX file to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts specific sheets from XLSX files to PDF format
- Allows selection of individual sheets for conversion
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
- Load the source XLSX file (`invoice-tracker.xlsx`)
- Convert only the first and third sheets (indexes 0 and 2) to PDF format
- Save the result as `specific-sheets.pdf`

## Code Explanation

The example uses the `XlsxToPdfConverter` class with the `SheetIndexes` option to specify which sheets to include in the conversion. The sheet indexes are zero-based, so the first sheet is index 0, second sheet is index 1, etc.

```vb
Dim converter As New XlsxToPdfConverter("invoice-tracker.xlsx", Sub(options)
    options.SheetIndexes = New List(Of Integer) From {0, 2} ' 0-based indexing
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `SpecificSheetsFromXlsxToPdf.vbproj` - Project file
- `invoice-tracker.xlsx` - Sample XLSX file with multiple sheets
- `specific-sheets.pdf` - Output PDF file with specific sheets (generated after running the example) 