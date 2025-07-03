# Specific PPTX Slides to PDF

This example demonstrates how to convert specific slides from a PPTX presentation to PDF format using GroupDocs.Conversion.LowCode.

## Features

- Converts specific slides from PPTX presentations to PDF format
- Allows selection of individual slides for conversion
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
- Convert only slides 1, 2, and 3 to PDF format
- Save the result as `slides-1-2-3.pdf`

## Code Explanation

The example uses the `PptxToPdfConverter` class to convert the PPTX presentation to PDF format. During the conversion, it specifies which slides to include using the `Pages` option in the convert options.

```vb
Dim converter As New PptxToPdfConverter("presentation.pptx")

converter.Convert("slides-1-2-3.pdf", Sub(convertOptions)
    convertOptions.Pages = New List(Of Integer) From {1, 2, 3}
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `SpecificPptxSlidesToPdf.vbproj` - Project file
- `presentation.pptx` - Sample PPTX presentation file
- `slides-1-2-3.pdf` - Output PDF file with specific slides (generated after running the example) 