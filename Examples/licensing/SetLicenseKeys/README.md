# Set License Keys Example

This example demonstrates how to set the GroupDocs.Conversion license using public and private keys in code with GroupDocs.Conversion.LowCode.

## Features

- Sets license using public and private key strings
- Checks if the keys are provided and valid
- Provides user feedback if the keys are missing or invalid

## Prerequisites

- .NET 6 or later
- GroupDocs.Conversion.LowCode package
- Valid GroupDocs license public and private keys

## How to Run

1. Build the project
2. Edit the `Program.vb` file to provide your actual public and private keys in place of the placeholders
3. Run the executable

## Expected Output

- If the keys are provided, the license will be applied
- If the keys are missing or invalid, a warning message will be shown

## Code Explanation

The example demonstrates:
- Checking if the public and private keys are set
- Applying the license using `License.Set(privateKey, publicKey)`
- Providing user feedback for both success and failure cases

## Files

- `Program.vb` - Main program file
- (No license file required; keys are set in code) 