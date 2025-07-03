# Set License from File Example

This example demonstrates how to set the GroupDocs.Conversion license from a license file using GroupDocs.Conversion.LowCode.

## Features

- Loads and applies a license from a file path
- Checks for the existence of the license file
- Provides user feedback if the license file is missing

## Prerequisites

- .NET 6 or later
- GroupDocs.Conversion.LowCode package
- A valid GroupDocs license file (e.g., `GroupDocs.Conversion.LowCode.lic`)

## How to Run

1. Build the project
2. Place your license file (e.g., `GroupDocs.Conversion.LowCode.lic`) in the output directory or update the path in the code
3. Run the executable

## Expected Output

- If the license file exists, the license will be applied and a success message will be shown
- If the license file does not exist, a warning message will be shown

## Code Explanation

The example demonstrates:
- Checking for the existence of the license file
- Applying the license using `License.Set(licensePath)`
- Providing user feedback for both success and failure cases

## Files

- `Program.vb` - Main program file
- `GroupDocs.Conversion.LowCode.lic` - License file (not included, must be provided by user) 