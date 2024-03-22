' Event arguments for selected folder name
Public Class SelectedFolderNameEventArgs
    Inherits EventArgs

    Public Property SelectedFolderName As String

    Public Sub New(selectedFolderName As String)
        Me.SelectedFolderName = selectedFolderName
    End Sub
End Class