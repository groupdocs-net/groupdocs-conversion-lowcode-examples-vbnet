Imports GroupDocs.Conversion.LowCode
Imports System.IO

Module Program
    Sub Main()
        SetLicenseFromFile()
    End Sub

    Private Sub SetLicenseFromFile()
        ' The path to the license file. The path can be relative or absolute.
        Dim licensePath As String = "./GroupDocs.Conversion.LowCode.lic"

        ' Check if the license file exists
        If Not File.Exists(licensePath) Then
            Console.WriteLine("Warning: License file not found at: " & licensePath)
            Console.WriteLine("Please ensure the license file exists at the specified path.")
            Console.WriteLine("Learn more about licensing at https://docs.groupdocs.net/conversion/licensing/")
            Return
        End If

        ' Apply the license. 
        License.Set(licensePath)
        Console.WriteLine("License applied successfully from: " & licensePath)
    End Sub
End Module