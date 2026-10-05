Imports System
Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        Dim publicKey As String = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey As String = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        License.Set(publicKey, privateKey)

        Dim converter As New XlsxToPdfConverter("cost-analysis.xlsx")
        converter.Convert("cost-analysis.pdf")
    End Sub
End Module
