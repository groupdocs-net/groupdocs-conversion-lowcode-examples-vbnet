Imports GroupDocs.Conversion.LowCode

Module Program
    Sub Main()
        SetLicenseFromFile()
    End Sub

    Private Sub SetLicenseFromFile()
        ' The path to the license file. The path can be relative or absolute.
        Dim licensePath As String = "./GroupDocs.Conversion.LowCode.lic"

        ' Apply the license. 
        License.Set(licensePath)
    End Sub
End Module
