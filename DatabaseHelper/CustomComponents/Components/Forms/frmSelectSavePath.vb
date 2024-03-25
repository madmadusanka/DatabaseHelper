Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmSelectSavePath

    Private rootPath As String = Path.Combine(Application.StartupPath, "Queries")
    Private selectedFolderName As String = ""
    Public Event SelectFolder As EventHandler(Of SelectedFolderNameEventArgs)

    ' Populates the ListBox with directories
    Private Sub PupulateListBox(ByVal path As String)

        Try

            Dim directories As String() = Directory.GetDirectories(path)

            For Each directory As String In directories
                Dim folderName As String = IO.Path.GetFileName(directory)
                LB_Groups.Items.Add(folderName)
                ' Recursively populate subdirectories
                PupulateListBox(directory)
            Next

        Catch ex As Exception
            MessageBox.Show("Error populating ListBox: " & ex.Message)
        End Try

    End Sub

    ' Handles the load event of the form
    Private Sub FrmSelectSavePath_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Directory.Exists(rootPath) Then
            ' Populate the ListBox with folder names
            PupulateListBox(rootPath)
        Else
            MessageBox.Show("The specified path does not exist.")
        End If

    End Sub

    ' Handles the selected index changed event of the ListBox
    Private Sub LBFolders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Groups.SelectedIndexChanged

        If LB_Groups.SelectedIndex <> -1 Then
            selectedFolderName = LB_Groups.SelectedItem.ToString()
            RaiseEvent SelectFolder(Me, New SelectedFolderNameEventArgs(selectedFolderName))
            Me.Close()
        End If

    End Sub

    ' Handles the click event for adding a new folder button
    Private Sub BtnAddFolder_Click(sender As Object, e As EventArgs) Handles btnAddNewGroup.Click

        If Not String.IsNullOrEmpty(TXT_NewGroup.Text) Then
            LB_Groups.Items.Add(TXT_NewGroup.Text)
        Else
            MessageBox.Show("Please Enter Folder Name")
        End If

    End Sub

End Class