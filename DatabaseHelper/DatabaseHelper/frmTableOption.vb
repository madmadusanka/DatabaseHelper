Imports System.Data.SqlClient
Imports Common

Public Class frmTableOption
    Private selectedDatabaseName As String
    Private selectedTableName As String
    Private connection As SqlConnection

    Public Sub New(ByVal selectedDatabaseName As String, ByVal selectedTableName As String, ByVal connection As SqlConnection)
        InitializeComponent()

        ' Initialize the form fields with the provided parameters
        Me.selectedDatabaseName = selectedDatabaseName
        Me.selectedTableName = selectedTableName
        Me.connection = connection

        ' Call an asynchronous method to further initialize the form
        InitializeAsync(selectedDatabaseName, selectedTableName, connection)
    End Sub

    Private Async Sub InitializeAsync(ByVal selectedDatabaseName As String, ByVal selectedTableName As String, connection As SqlConnection)
        ' Display view name and definition
        Await PopulateTriggersComboBoxWithQuery(selectedDatabaseName, selectedTableName, connection, cmbSelectTrigger)
    End Sub


    Private Async Sub btnViewTrigger_Click(sender As Object, e As EventArgs) Handles btnViewTrigger.Click
        ' Get the selected trigger name
        Dim selectedTriggerName As String = cmbSelectTrigger.SelectedItem.ToString()

        ' Query to retrieve the trigger definition
        Dim query As String = String.Format(TriggerDetailQuery, selectedTriggerName)

        Await frmlandingpage.ShowQuery(query, connection, selectedTriggerName)

    End Sub

    Private Async Function PopulateTriggersComboBoxWithQuery(ByVal databaseName As String, ByVal selectedTableName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Construct the SQL query to retrieve table names
                Dim query As String = String.Format(TriggerNamesQuery, databaseName, selectedTableName)

                ' Create and execute the command asynchronously
                Using command As New SqlCommand(query, connection)
                    ' Execute the query asynchronously
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        ' Clear existing items in the ComboBox
                        cmb.Items.Clear()

                        ' Iterate over the result set and add table names to the ComboBox
                        While reader.Read()
                            cmb.Items.Add(reader("TriggerName").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Class