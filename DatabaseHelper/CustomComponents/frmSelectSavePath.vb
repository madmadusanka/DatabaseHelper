Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmSelectSavePath
    Private rootPath As String = Path.Combine(Application.StartupPath, "Queries")
    Private selectedFolderName As String = ""
    Public Event SelectFolder As EventHandler(Of SelectedFolderNameEventArgs)

    Private Sub PupulateListBox(ByVal path As String)

        Try
            Dim directories As String() = Directory.GetDirectories(path)
            For Each directory As String In directories
                Dim folderName As String = IO.Path.GetFileName(directory)
                LBFolders.Items.Add(folderName)
                ' Recursively populate subdirectories
                PupulateListBox(directory)
            Next
        Catch ex As Exception
            MessageBox.Show("Error populating ListBox: " & ex.Message)
        End Try

    End Sub

    Private Sub FrmSelectSavePath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(rootPath) Then
            ' Populate the ListBox with folder names
            PupulateListBox(rootPath)
        Else
            MessageBox.Show("The specified path does not exist.")
        End If
    End Sub

    Private Sub LBFolders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBFolders.SelectedIndexChanged
        If LBFolders.SelectedIndex <> -1 Then
            selectedFolderName = LBFolders.SelectedItem.ToString()
            RaiseEvent SelectFolder(Me, New SelectedFolderNameEventArgs(selectedFolderName))
            Me.Close()
        End If

    End Sub

    Private Sub BtnAddFolder_Click(sender As Object, e As EventArgs) Handles btnAddFolder.Click
        If Not String.IsNullOrEmpty(txtnewFolder.Text) Then
            LBFolders.Items.Add(txtnewFolder.Text)
        Else
            MessageBox.Show("Please Enter Folder Name")
        End If
    End Sub

End Class