Imports System.Data.SqlClient
Imports FastColoredTextBoxNS
Imports System.IO
Imports System.Text.RegularExpressions
Imports DatabaseHelper

Public Class QueryControl

    Private Shared ReadOnly separator As Char() = {" "c, ","c, ";"c}
    Private Const QueryParamStart As String = "<@"
    Private Const QueryParamEnd As String = ">"
    Private _showForm As IFormViewer = New FormViewer()
    Private _connection As SqlConnection
    Private controller As New QueryExecutorController
    Private adapter As SqlDataAdapter
    Private updatedQuery As String
    Private customComponentInstance As QueryControl
    Private queryFilePath As String
    Private selectedFolderName As String
    Private NewDefaultDirectory As String
    Private frmQuerySave As FrmSelectSavePath
    Private frmQueryList As FrmSavedQuery

    ' Property for managing the SqlConnection object, initializes upon setting
    Public Property Connection As SqlConnection

        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
            Initialize()
        End Set

    End Property

    ' Property for managing the query text box control
    Public Property QueryTextBox As FastColoredTextBox

        Get
            Return fastColoredTextBox
        End Get
        Set(ByVal value As FastColoredTextBox)
            fastColoredTextBox = value
        End Set

    End Property

    ' Property for managing the visibility of the delete button
    Public Property IsDeleteButtonVisible As Boolean

        Get
            Return btnDeleteThis.Visible
        End Get
        Set(value As Boolean)
            btnDeleteThis.Visible = value
        End Set

    End Property

    ' Default constructor to initialize components
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Initializes the QueryExecutorController and SqlDataAdapter
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
        Dim query As String = fastColoredTextBox.Text.Trim()
        QueryExecute(query)
    End Sub

    ' Executes the SQL query and displays the result in QueryResultDataGridView
    Private Sub QueryExecute(ByVal Query As String)

        If Not String.IsNullOrEmpty(Query) Then

            Try

                If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

                    Dim dataTable As New DataTable()
                    Dim completionTime As String = DateTime.Now.ToString()

                    adapter.SelectCommand = New SqlCommand(Query, Connection)
                    adapter.Fill(dataTable)
                    Dim rowsAffected As Integer = adapter.SelectCommand.ExecuteNonQuery()

                    QueryResultDataGridView.DataSource = dataTable
                    txtQueryMessage.Text = ""
                    txtQueryMessage.Text = $"( {rowsAffected} row affected ){Environment.NewLine}Completion time: {completionTime} Operation Completed"

                    If QueryResultDataGridView.Rows.Count > 0 Then
                        tabControlQuery.SelectedTab = tabResult
                    Else
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

    ' Handles the click event for the delete button
    Private Sub BtnDeleteThis_Click(sender As Object, e As EventArgs) Handles btnDeleteThis.Click

        If Me.Parent IsNot Nothing Then
            Parent.Controls.Remove(Me)
        End If

    End Sub

    ' Handles the click event for the save query button
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

    ' Loads a query from a file and displays it in the QueryTextBox
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

    ' Generates TextBox controls for parameters in the query
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

    ' Handles the click event for setting data
    Private Sub BtnSetData_Click(sender As Object, e As EventArgs)

        updatedQuery = CompleteQueryWithParameters(QueryTextBox.Text)
        QueryExecute(updatedQuery)

    End Sub

    ' Completes the query template with parameter values
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

    ' Handles the click event for the query list button
    Private Sub BtnQueryList_Click(sender As Object, e As EventArgs) Handles BtnQueryList.Click
        If frmQueryList IsNot Nothing AndAlso Not frmQueryList.IsDisposed Then
            frmQueryList.BringToFront()
        Else

            frmQueryList = New FrmSavedQuery
            AddHandler frmQueryList.ShowQuery, AddressOf OnShowQuery
            frmQueryList.Show()

        End If

    End Sub

    ' Event handler for showing a query
    Private Sub OnShowQuery(sender As Object, e As ShowQueryEventArgs)

        queryFilePath = e.QueryFilePath
        flpCustomComponent.Controls.Clear()
        LoadQueryFromFile(queryFilePath)

    End Sub

    ' Event handler for selecting a folder
    Private Sub OnSelectFolder(sender As Object, e As SelectedFolderNameEventArgs)

        selectedFolderName = e.SelectedFolderName
        SaveQueryFile(selectedFolderName)

    End Sub

    ' Saves the SQL query to a file
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
