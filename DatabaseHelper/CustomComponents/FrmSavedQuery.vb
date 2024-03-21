Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CustomControllers.QueryControl
Imports DatabaseHelper

Public Class FrmSavedQuery

    Dim RootNode As New TreeNode(rootPath)
    Dim rootPath As String = Path.Combine(Application.StartupPath, "Queries")
    Public Event ShowQuery As EventHandler(Of ShowQueryEventArgs)

    Private Sub PopulateTreeView(parentNode As TreeNode, path1 As String)
        ' Populate the TreeView with folder names as roots
        Try
            Dim directories As String() = Directory.GetDirectories(path1)
            For Each directory As String In directories
                Dim DirectoryNode As New TreeNode(Path.GetFileName(directory))
                parentNode.Nodes.Add(DirectoryNode)
                ' Recursively populate subdirectories
                PopulateTreeView(DirectoryNode, directory)
                ' Add file names as children under each root
                PopulateFiles(DirectoryNode, directory)
            Next
        Catch ex As Exception
            MessageBox.Show("Error populating TreeView: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateFiles(parentNode As TreeNode, path1 As String)
        ' Add file names as children under each root
        Try
            Dim files As String() = Directory.GetFiles(path1)
            For Each file As String In files
                Dim FileNode As New TreeNode(Path.GetFileName(file))
                parentNode.Nodes.Add(FileNode)
            Next
        Catch ex As Exception
            MessageBox.Show("Error populating files: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmSavedQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Check if the specified path exists
        If Directory.Exists(rootPath) Then
            ' Set the root node of the TreeView to the specified path

            TVSavedQuery.Nodes.Add(RootNode)

            ' Populate the TreeView with folder names as roots and file names as children
            PopulateTreeView(RootNode, rootPath)
            TVSavedQuery.ExpandAll()
        Else
            MessageBox.Show("The specified path does not exist.")
        End If

    End Sub

    Private Sub TVSavedQuery_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TVSavedQuery.NodeMouseDoubleClick
        Dim clickedNode As TreeNode = e.Node

        Dim selectedNode As TreeNode = TVSavedQuery.SelectedNode

        If selectedNode IsNot Nothing Then
            ' Initialize an empty string to store the path
            Dim selectedPath As String = ""

            ' Traverse the selected node and its ancestors to build the path
            While selectedNode IsNot Nothing
                ' Prepend the text of the current node to the path
                selectedPath = Path.Combine(selectedNode.Text, selectedPath)
                ' Move up to the parent node
                selectedNode = selectedNode.Parent
            End While

            ' Remove the extra leading backslash
            selectedPath = selectedPath.TrimStart(Path.DirectorySeparatorChar)

            ' Combine the path with the application's startup path
            Dim fullPath As String = Path.Combine(Application.StartupPath, "Queries", selectedPath)

            Try
                RaiseEvent ShowQuery(Me, New ShowQueryEventArgs(fullPath))
            Catch ex As Exception
                MessageBox.Show("Please Double Click a Sql file")
            End Try

        End If

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchFile As String = txtSearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchFile) Then
            ' Clear previous search highlights
            ClearSearchHighlights(TVSavedQuery.Nodes)

            ' Start searching from the root nodes
            For Each node As TreeNode In TVSavedQuery.Nodes
                SearchAndHighlightFileNodes(searchFile, node)
            Next
        Else
            ClearSearchHighlights(TVSavedQuery.Nodes)
        End If
    End Sub

    Private Sub ClearSearchHighlights(ByVal parentNode As TreeNodeCollection)
        For Each node As TreeNode In parentNode
            ' Reset the background color of the node
            node.BackColor = TVSavedQuery.BackColor

            ' Recursively clear search highlights in child nodes
            ClearSearchHighlights(node.Nodes)
        Next
    End Sub

    Private Sub SearchAndHighlightFileNodes(ByVal searchQuery As String, ByVal parentNode As TreeNode)
        For Each node As TreeNode In parentNode.Nodes
            If node.Nodes.Count > 0 Then
                ' Recursively search in child nodes
                SearchAndHighlightFileNodes(searchQuery, node)
            ElseIf node.Text.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) Then
                ' File matches the search query
                node.EnsureVisible() ' Scroll to the found node if necessary
                node.BackColor = Color.Yellow ' Highlight the found node
            Else
                ' Node doesn't match the search query
                node.BackColor = TVSavedQuery.BackColor ' Restore the default background color
            End If
        Next
    End Sub

End Class