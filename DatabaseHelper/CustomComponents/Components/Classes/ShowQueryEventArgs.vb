' Event arguments for showing a query
Public Class ShowQueryEventArgs
    Inherits EventArgs

    Public Property QueryFilePath As String

    Public Sub New(queryFilePath As String)
        Me.QueryFilePath = queryFilePath
    End Sub
End Class


