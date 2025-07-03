# Flatten Fields in Form Fillable PDF

This example demonstrates how to convert a PDF document with form fields to PDF/A format while flattening all form fields using GroupDocs.Conversion.LowCode.

## Features

- Converts PDF documents to PDF/A format
- Flattens all form fields in the source PDF
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
- Load the source PDF file (`form-fields.pdf`)
- Convert it to PDF/A format with all form fields flattened
- Save the result as `flattened.pdf`

## Code Explanation

The example uses the `PdfToPdfAConverter` class with the `FlattenAllFields` option set to `True`. This ensures that all interactive form fields in the source PDF are flattened (converted to static content) during the conversion to PDF/A format.

```vb
Dim converter As New PdfToPdfAConverter("form-fields.pdf", Sub(options)
    options.FlattenAllFields = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `FlattenFieldsInFormFillablePdf.vbproj` - Project file
- `form-fields.pdf` - Sample PDF file with form fields
- `flattened.pdf` - Output PDF/A file (generated after running the example) 