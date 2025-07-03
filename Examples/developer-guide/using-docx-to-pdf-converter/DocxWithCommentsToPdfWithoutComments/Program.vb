Imports GroupDocs.Conversion.LowCode
Imports GroupDocs.Conversion.Options.Load

Module Program
    Sub Main()
        ' Load license keys
        Dim publicKey = Environment.GetEnvironmentVariable("GD_PUBLIC_KEY")
        Dim privateKey = Environment.GetEnvironmentVariable("GD_PRIVATE_KEY")

        ' Apply license
        License.Set(publicKey, privateKey)

        ' Hide comments using CommentDisplayMode
        Dim converter As New DocxToPdfConverter("with-comments.docx", Sub(options)
            options.CommentDisplayMode = WordProcessingCommentDisplay.Hidden
        End Sub)

        ' Convert DOCX to PDF
        converter.Convert("no-comments.pdf")
    End Sub
End Module