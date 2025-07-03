# Specific Sheets from XLS to PDF

This example demonstrates how to convert specific sheets from an XLS file to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts specific sheets from XLS files to PDF format
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
- Load the source XLS file (`invoice-tracker.xls`)
- Convert only the first and third sheets (indexes 0 and 2) to PDF format
- Save the result as `specific-sheets.pdf`

## Code Explanation

The example uses the `XlsToPdfConverter` class with the `SheetIndexes` option to specify which sheets to include in the conversion. The sheet indexes are zero-based, so the first sheet is index 0, second sheet is index 1, etc.

```vb
Dim converter As New XlsToPdfConverter("invoice-tracker.xls", Sub(options)
    options.SheetIndexes = New List(Of Integer) From {0, 2} ' Convert first and third sheets
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `SpecificSheetsFromXlsToPdf.vbproj` - Project file
- `invoice-tracker.xls` - Sample XLS file with multiple sheets
- `specific-sheets.pdf` - Output PDF file with specific sheets (generated after running the example) 