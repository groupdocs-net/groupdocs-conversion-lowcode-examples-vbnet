# PPTX with Hidden Slides to PDF

This example demonstrates how to convert a PPTX presentation with hidden slides to PDF format while including the hidden slides using GroupDocs.Conversion.LowCode.

## Features

- Converts PPTX presentations to PDF format
- Includes hidden slides in the conversion process
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
- Load the source PPTX file (`with-hidden-slides.pptx`)
- Convert it to PDF format including hidden slides
- Save the result as `with-hidden-slides.pdf`

## Code Explanation

The example uses the `PptxToPdfConverter` class with the `ShowHiddenSlides` option set to `True`. This ensures that all hidden slides in the source PPTX presentation are included in the PDF conversion.

```vb
Dim converter As New PptxToPdfConverter("with-hidden-slides.pptx", Sub(options)
    options.ShowHiddenSlides = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `PptxWithHiddenSlides.vbproj` - Project file
- `with-hidden-slides.pptx` - Sample PPTX presentation file with hidden slides
- `with-hidden-slides.pdf` - Output PDF file including hidden slides (generated after running the example) 