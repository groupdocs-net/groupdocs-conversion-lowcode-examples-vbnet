# XLS with Hidden Sheets to PDF

This example demonstrates how to convert an XLS file with hidden sheets to PDF format while including the hidden sheets using GroupDocs.Conversion.LowCode.

## Features

- Converts XLS files to PDF format
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
- Load the source XLS file (`hidden-sheets.xls`)
- Convert it to PDF format including hidden sheets
- Save the result as `with-hidden-sheets.pdf`

## Code Explanation

The example uses the `XlsToPdfConverter` class with the `ShowHiddenSheets` option set to `True`. This ensures that all hidden sheets in the source XLS file are included in the PDF conversion.

```vb
Dim converter As New XlsToPdfConverter("hidden-sheets.xls", Sub(options)
    options.ShowHiddenSheets = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `XlsWithHiddenSheets.vbproj` - Project file
- `hidden-sheets.xls` - Sample XLS file with hidden sheets
- `with-hidden-sheets.pdf` - Output PDF file including hidden sheets (generated after running the example) 