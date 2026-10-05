Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        SetLicenseKeys()
    End Sub

    Private Sub SetLicenseKeys()
        ' The public and private keys from your license.
        Dim publicKey As String = "..."
        Dim privateKey As String = "..."

        ' Set license keys.
        License.Set(publicKey, privateKey)
    End Sub
End Module
