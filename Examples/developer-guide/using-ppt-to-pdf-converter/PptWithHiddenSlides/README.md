# PPT with Hidden Slides to PDF

This example demonstrates how to convert a PPT presentation with hidden slides to PDF format while including the hidden slides using GroupDocs.Conversion.LowCode.

## Features

- Converts PPT presentations to PDF format
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
- Load the source PPT file (`with-hidden-slides.ppt`)
- Convert it to PDF format including hidden slides
- Save the result as `with-hidden-slides.pdf`

## Code Explanation

The example uses the `PptToPdfConverter` class with the `ShowHiddenSlides` option set to `True`. This ensures that all hidden slides in the source PPT presentation are included in the PDF conversion.

```vb
Dim converter As New PptToPdfConverter("with-hidden-slides.ppt", Sub(options)
    options.ShowHiddenSlides = True
End Sub)
```

## Files

- `Program.vb` - Main program file containing the conversion logic
- `PptWithHiddenSlides.vbproj` - Project file
- `with-hidden-slides.ppt` - Sample PPT presentation file with hidden slides
- `with-hidden-slides.pdf` - Output PDF file including hidden slides (generated after running the example) 