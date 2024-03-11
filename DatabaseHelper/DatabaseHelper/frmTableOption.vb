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
        Try
            ' Display view name and definition
            Await PopulateTriggersComboBoxWithQuery(selectedDatabaseName, selectedTableName, connection, cmbSelectTrigger)

            ' Get the table schema asynchronously
            Dim schemaTables As List(Of DataTable) = Await Task.Run(Function() GetTableSchema(selectedDatabaseName, selectedTableName, connection))

            ' Check if schemaTables has data
            If schemaTables IsNot Nothing AndAlso schemaTables.Count > 0 AndAlso schemaTables(0).Rows.Count > 0 Then
                ' Bind the first schema table to DataGridView1
                dgvTableSchema1.DataSource = schemaTables(0)
                dgvTableSchema2.DataSource = schemaTables(1)
                dgvTableSchema3.DataSource = schemaTables(2)
                dgvTableSchema4.DataSource = schemaTables(3)
                dgvTableSchema5.DataSource = schemaTables(4)
                dgvTableSchema6.DataSource = schemaTables(5)
                dgvTableSchema7.DataSource = schemaTables(6)
            Else
                MessageBox.Show("No data found for the table schema.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnViewTrigger_Click(sender As Object, e As EventArgs) Handles btnViewTrigger.Click
        Try
            If cmbSelectTrigger.SelectedItem IsNot Nothing Then
                ' Get the selected trigger name
                Dim selectedTriggerName As String = cmbSelectTrigger.SelectedItem.ToString()

                ' Query to retrieve the trigger definition
                Dim query As String = String.Format(TriggerDetailQuery, selectedTriggerName)

                Await frmLandingPage.ShowQuery(query, connection, selectedTriggerName)
            Else
                MessageBox.Show("Please select a trigger.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Function GetTableSchema(ByVal databaseName As String, ByVal tableName As String, ByVal connection As SqlConnection) As List(Of DataTable)
        Dim schemaTables As New List(Of DataTable)()

        Try
            ' Check if the connection is open
            If connection.State <> ConnectionState.Open Then
                Throw New Exception("Connection is not open.")
            End If

            ' Construct the SQL query to retrieve table schema
            Dim query As String = String.Format(TableSchemadesignQuery, databaseName, tableName)

            ' Create a new data adapter and fill the DataSet
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet)

                ' Add DataTables from the DataSet to the list
                For Each table As DataTable In dataSet.Tables
                    schemaTables.Add(table)
                Next
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while fetching table schema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return schemaTables
    End Function

    Private Sub frmTableOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryExecuterTableOption.Connection = connection
        lblTableStructurelbl.Text = $"{selectedTableName} Table Stucture"
    End Sub
End Class