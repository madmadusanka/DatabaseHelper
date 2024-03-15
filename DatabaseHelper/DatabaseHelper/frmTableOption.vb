Imports System.Data.SqlClient
Imports Common

Public Class FrmTableOption
    Private selectedDatabaseName As String
    Private selectedTableName As String
    Private connection As SqlConnection

    Public Sub New(ByVal selectedDatabaseName As String, ByVal selectedTableName As String, ByVal connection As SqlConnection)
        InitializeComponent()

        Me.selectedDatabaseName = selectedDatabaseName
        Me.selectedTableName = selectedTableName
        Me.connection = connection

        InitializeAsync(selectedDatabaseName, selectedTableName, connection)
    End Sub

    Private Async Sub InitializeAsync(ByVal selectedDatabaseName As String, ByVal selectedTableName As String, connection As SqlConnection)
        Try
            Await PopulateTriggersComboBoxWithQuery(selectedDatabaseName, selectedTableName, connection, cmbSelectTrigger)
            Dim schemaTables As List(Of DataTable) = Await Task.Run(Function() GetTableSchema(selectedDatabaseName, selectedTableName, connection))

            If schemaTables IsNot Nothing AndAlso schemaTables.Count > 0 AndAlso schemaTables(0).Rows.Count > 0 Then
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

    ' show trigger button
    Private Async Sub BtnViewTrigger_Click(sender As Object, e As EventArgs) Handles btnViewTrigger.Click
        Try
            If cmbSelectTrigger.SelectedItem IsNot Nothing Then
                Dim selectedTriggerName As String = cmbSelectTrigger.SelectedItem.ToString()
                Dim query As String = String.Format(TriggerDetailQuery, selectedTriggerName)
                Await FrmLandingPage.ShowQuery(query, connection, selectedTriggerName)
            Else
                MessageBox.Show("Please select a trigger.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' load data to trigger combo box
    Private Async Function PopulateTriggersComboBoxWithQuery(ByVal databaseName As String, ByVal selectedTableName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
                Dim query As String = String.Format(TriggerNamesQuery, databaseName, selectedTableName)
                Using command As New SqlCommand(query, connection)

                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()

                        cmb.Items.Clear()

                        While reader.Read()
                            cmb.Items.Add(reader("TriggerName").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' get tables for table schema view
    Private Function GetTableSchema(ByVal databaseName As String, ByVal tableName As String, ByVal connection As SqlConnection) As List(Of DataTable)
        Dim schemaTables As New List(Of DataTable)()

        Try

            If connection.State <> ConnectionState.Open Then
                Throw New Exception("Connection is not open.")
            End If

            Dim query As String = String.Format(TableSchemadesignQuery, databaseName, tableName)

            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet)

                For Each table As DataTable In dataSet.Tables
                    schemaTables.Add(table)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while fetching table schema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return schemaTables
    End Function

    Private Sub FrmTableOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryExecuterTableOption.Connection = connection
        lblTableStructurelbl.Text = $"{selectedTableName} Table Stucture"
    End Sub
End Class