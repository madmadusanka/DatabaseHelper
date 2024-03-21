Imports System.Data.SqlClient
Imports FastColoredTextBoxNS
Imports System.IO
Imports System.Text.RegularExpressions
Imports DatabaseHelper

Public Class QueryControl

    Private Const QueryParamStart As String = "<@"
    Private Const QueryParamEnd As String = ">"
    Private controller As New QueryExecutorController
    Private _connection As SqlConnection
    Private adapter As SqlDataAdapter
    Private Shared ReadOnly separator As Char() = {" "c, ","c, ";"c}
    Private _showForm As IFormViewer = New FormViewer()
    Private updatedQuery As String
    Private customComponentInstance As QueryControl
    Private queryFilePath As String
    Private selectedFolderName As String
    Private NewDefaultDirectory As String
    Private frmQuerySave As FrmSelectSavePath
    Private frmQueryList As FrmSavedQuery

    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
            Initialize()
        End Set
    End Property

    Public Property QueryTextBox As FastColoredTextBox
        Get
            Return fastColoredTextBox
        End Get
        Set(ByVal value As FastColoredTextBox)
            fastColoredTextBox = value
        End Set
    End Property

    Public Property IsDeleteButtonVisible As Boolean
        Get
            Return btnDeleteThis.Visible
        End Get
        Set(value As Boolean)
            btnDeleteThis.Visible = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub Initialize()
        Try
            controller = New QueryExecutorController(Connection)
            adapter = New SqlDataAdapter()

        Catch ex As Exception
            MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Query execute button
    Private Sub ExecuteQueryButton_Click(sender As Object, e As EventArgs) Handles ExecuteQueryButton.Click
        QueryExecute()
    End Sub

    Private Sub QueryExecute()
        If Not String.IsNullOrEmpty(fastColoredTextBox.Text) Then
            Try
                ' Check if connection is set
                If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
                    Dim query As String = fastColoredTextBox.Text.Trim()

                    ' Set the SqlCommand for the SqlDataAdapter
                    adapter.SelectCommand = New SqlCommand(query, Connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind DataTable to DataGridView
                    QueryResultDataGridView.DataSource = dataTable

                    ' Execute the SQL command and capture the number of rows affected
                    Dim rowsAffected As Integer = adapter.SelectCommand.ExecuteNonQuery()

                    ' Get the current date and time
                    Dim completionTime As String = DateTime.Now.ToString()

                    txtQueryMessage.Text = ""
                    txtQueryMessage.Text = $"( {rowsAffected} row affected ){Environment.NewLine}Completion time: {completionTime} Operation Completed"

                    If QueryResultDataGridView.Rows.Count > 0 Then
                        tabControlQuery.SelectedTab = tabResult
                    Else
                        ' Handle the case where QueryResultDataGridView has no rows
                        tabControlQuery.SelectedTab = tabMessage
                    End If

                Else
                    Dim result As DialogResult = MessageBox.Show("Connection is closed, You want Reconnect?", "Confirmation", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        _showForm.ShowLandingPageIfNotOpen()
                    Else
                        MessageBox.Show("Connection property is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Query is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnDeleteThis_Click(sender As Object, e As EventArgs) Handles btnDeleteThis.Click
        If Me.Parent IsNot Nothing Then
            Parent.Controls.Remove(Me)
        End If
    End Sub

    ' Button for save query
    Private Sub Btnsavequery_Click(sender As Object, e As EventArgs) Handles btnsavequery.Click

        If Not String.IsNullOrEmpty(fastColoredTextBox.Text) Then
            If frmQuerySave IsNot Nothing AndAlso Not frmQuerySave.IsDisposed Then
                frmQuerySave.BringToFront()
            Else
                frmQuerySave = New FrmSelectSavePath
                AddHandler frmQuerySave.SelectFolder, AddressOf OnSelectFolder
                frmQuerySave.Show()
            End If
        Else
            MessageBox.Show("Query is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub LoadQueryFromFile(filePath As String)
        Try
            ' Read the content of the selected query file
            Dim queryContent As String = File.ReadAllText(filePath)

            ' Display the query content in the TextBox
            QueryTextBox.Text = queryContent
            GenerateTextBoxesForParameters(queryContent)
        Catch ex As Exception
            MessageBox.Show("Please double Click a Sql File")
        End Try
    End Sub

    Public Sub GenerateTextBoxesForParameters(query As String)
        ' Split the query into individual words
        Dim words As String() = query.Split(separator, StringSplitOptions.RemoveEmptyEntries)

        ' Loop through each word to find parameters starting with @
        For Each word As String In words
            If word.StartsWith(QueryParamStart) And word.EndsWith(QueryParamEnd) Then
                ' Remove any non-alphanumeric characters from the parameter name
                Dim parameterName As String = Regex.Replace(word, "[^\w]", "")

                ' Generate a new TextBox control
                Dim textBox As New TextBox() With {
                .Name = "txt_" & parameterName, ' Set a unique name for the TextBox
                .Width = 150
                }

                ' Add the TextBox to the flow layout panel
                flpCustomComponent.Controls.Add(textBox)

                ' Optionally, you can add labels to describe each parameter
                Dim label As New Label() With {
                .Text = parameterName
                }
                ' Add the Label to the flow layout panel
                flpCustomComponent.Controls.Add(label)
            End If
        Next

        If (query.Contains(QueryParamStart)) Then
            ' Create a button dynamically
            Dim btnSetData As New Button() With {
            .Text = "Execute",
            .Width = 100
            }
            AddHandler btnSetData.Click, AddressOf BtnSetData_Click

            ' Add the button to the flow layout panel
            flpCustomComponent.Controls.Add(btnSetData)
        End If

    End Sub

    Private Sub BtnSetData_Click(sender As Object, e As EventArgs)
        updatedQuery = CompleteQueryWithParameters(QueryTextBox.Text)
        QueryTemplateExecute()
    End Sub

    Private Sub QueryTemplateExecute()
        If Not String.IsNullOrEmpty(updatedQuery) Then
            Try
                ' Check if connection is set
                If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

                    ' Set the SqlCommand for the SqlDataAdapter
                    adapter.SelectCommand = New SqlCommand(updatedQuery, Connection)

                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind DataTable to DataGridView
                    QueryResultDataGridView.DataSource = dataTable

                    ' Execute the SQL command and capture the number of rows affected
                    Dim rowsAffected As Integer = adapter.SelectCommand.ExecuteNonQuery()

                    ' Get the current date and time
                    Dim completionTime As String = DateTime.Now.ToString()

                    txtQueryMessage.Text = ""
                    txtQueryMessage.Text = $"( {rowsAffected} row affected ){Environment.NewLine}Completion time: {completionTime} Operation Completed"

                    If QueryResultDataGridView.Rows.Count > 0 Then
                        tabControlQuery.SelectedTab = tabResult
                    Else
                        ' Handle the case where QueryResultDataGridView has no rows
                        tabControlQuery.SelectedTab = tabMessage
                    End If

                Else
                    Dim result As DialogResult = MessageBox.Show("Connection is closed, You want Reconnect?", "Confirmation", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        _showForm.ShowLandingPageIfNotOpen()
                    Else
                        MessageBox.Show("Connection property is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            MessageBox.Show("Query is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CompleteQueryWithParameters(query As String) As String

        Dim completedQuery As String = query
        For Each control As Control In flpCustomComponent.Controls
            If TypeOf control Is TextBox Then
                ' Get the parameter name from the TextBox name
                Dim parameterName As String = control.Name.Replace("txt_", "")
                ' Get the parameter value from the TextBox
                Dim parameterValue As String = DirectCast(control, TextBox).Text

                ' Replace the parameter placeholder in the query string with the parameter value
                completedQuery = completedQuery.Replace(QueryParamStart & parameterName, parameterValue).Replace(QueryParamEnd, "")
            End If
        Next

        ' Return the completed query
        Return completedQuery
    End Function

    Private Sub BtnQueryList_Click(sender As Object, e As EventArgs) Handles BtnQueryList.Click
        If frmQueryList IsNot Nothing AndAlso Not frmQueryList.IsDisposed Then
            frmQueryList.BringToFront()
        Else
            frmQueryList = New FrmSavedQuery
            AddHandler frmQueryList.ShowQuery, AddressOf OnShowQuery
            frmQueryList.Show()
        End If

    End Sub

    Private Sub OnShowQuery(sender As Object, e As ShowQueryEventArgs)
        queryFilePath = e.QueryFilePath
        flpCustomComponent.Controls.Clear()
        LoadQueryFromFile(queryFilePath)
    End Sub

    Private Sub OnSelectFolder(sender As Object, e As SelectedFolderNameEventArgs)
        selectedFolderName = e.SelectedFolderName
        SaveQueryFile(selectedFolderName)
    End Sub

    Private Sub SaveQueryFile(ByRef selectedFolderName As String)
        If Not String.IsNullOrEmpty(fastColoredTextBox.Text) Then

            Dim queryText As String = fastColoredTextBox.Text

            ' Get the application's startup path
            Dim DefaultDirectory As String = Application.StartupPath
            DefaultDirectory = Path.Combine(DefaultDirectory, "Queries")

            ' Combine the startup path with a subfolder to store the queries, if desired
            NewDefaultDirectory = Path.Combine(DefaultDirectory, selectedFolderName)

            ' Check if the subfolder exists, create it if it doesn't
            If Not Directory.Exists(NewDefaultDirectory) Then
                Directory.CreateDirectory(NewDefaultDirectory)
            End If

            ' Display SaveFileDialog with the default directory
            Dim saveDialog As New SaveFileDialog With {
            .InitialDirectory = NewDefaultDirectory,
            .Filter = "SQL Files (*.sql)|*.sql|All files (*.*)|*.*",
            .Title = "Save SQL Query"
            }

            If saveDialog.ShowDialog = DialogResult.OK Then
                ' Get the chosen file path
                Dim filePath As String = saveDialog.FileName

                Try
                    ' Write the text from the TextBox to the chosen file using System.IO.File.WriteAllText
                    File.WriteAllText(filePath, QueryTextBox.Text)
                    MessageBox.Show("SQL query saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while saving the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        Else
            MessageBox.Show("Query is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
