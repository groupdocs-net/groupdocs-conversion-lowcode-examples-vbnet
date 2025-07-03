Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        SetLicenseKeys()
    End Sub

    Private Sub SetLicenseKeys()
        ' The path to the license file. The path can be relative or absolute.
        Dim privateKey As String = "..."
        Dim publicKey As String = "..."

        ' Check if license keys are provided
        If String.IsNullOrEmpty(privateKey) OrElse privateKey = "..." OrElse 
           String.IsNullOrEmpty(publicKey) OrElse publicKey = "..." Then
            Console.WriteLine("WARNING: License keys are not set!")
            Console.WriteLine("Please provide valid private and public keys.")
            Console.WriteLine("Learn more about licensing at https://docs.groupdocs.net/conversion/licensing/")
            Return
        End If

        ' Set license keys.
        License.Set(privateKey, publicKey)
    End Sub
End Module