
Public Class ShowQueryEventArgs
    Inherits EventArgs

    Public Property QueryFilePath As String

    Public Sub New(queryFilePath As String)
        Me.QueryFilePath = queryFilePath
    End Sub
End Class

Public Class SelectedFolderNameEventArgs
    Inherits EventArgs

    Public Property SelectedFolderName As String

    Public Sub New(selectedFolderName As String)
        Me.SelectedFolderName = selectedFolderName
    End Sub
End Class


