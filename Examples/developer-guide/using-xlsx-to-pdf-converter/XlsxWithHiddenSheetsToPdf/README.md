# XLSX with Hidden Sheets to PDF

This example demonstrates how to convert an XLSX file with hidden sheets to PDF format while including the hidden sheets using GroupDocs.Conversion.LowCode.

## Features

- Converts XLSX files to PDF format
- Includes hidden sheets in the conversion process
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
- Load the source XLSX file (`hidden-worksheets.xlsx`)
- Convert it to PDF format including hidden sheets
- Save the result as `with-hidden-sheets.pdf`

## Code Explanation

The example uses the `XlsxToPdfConverter` class with the `ShowHiddenSheets` option set to `True`. This ensures that all hidden sheets in the source XLSX file are included in the PDF conversion.

```vb
Dim converter As New XlsxToPdfConverter("hidden-worksheets.xlsx", Sub(options)
    options.ShowHiddenSheets = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `XlsxWithHiddenSheetsToPdf.vbproj` - Project file
- `hidden-worksheets.xlsx` - Sample XLSX file with hidden sheets
- `with-hidden-sheets.pdf` - Output PDF file including hidden sheets (generated after running the example) 