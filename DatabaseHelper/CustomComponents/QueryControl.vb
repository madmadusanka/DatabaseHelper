Imports System.Data.SqlClient

Public Class QueryControl
    Private controller As New QueryExecutorController
    Private _connection As SqlConnection
    Private adapter As SqlDataAdapter ' Declare SqlDataAdapter here

    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
            ' Reinitialize the controller with the new connection
            Initialize()
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub Initialize()
        Try
            ' Reinitialize the controller with the new connection
            controller = New QueryExecutorController(Connection)
            adapter = New SqlDataAdapter() ' Initialize SqlDataAdapter
        Catch ex As Exception
            MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExecuteQueryButton_Click(sender As Object, e As EventArgs) Handles ExecuteQueryButton.Click
        ' Check if query is not empty
        If Not String.IsNullOrEmpty(fastColoredTextBox.Text) Then
            Try
                ' Check if connection is set
                If Connection IsNot Nothing Then
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
                    MessageBox.Show("Connection property is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Query is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnDeleteThis_Click(sender As Object, e As EventArgs) Handles btnDeleteThis.Click
        If Me.Parent IsNot Nothing Then
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Public Property IsDeleteButtonVisible As Boolean
        Get
            Return btnDeleteThis.Visible
        End Get
        Set(value As Boolean)
            btnDeleteThis.Visible = value
        End Set
    End Property
End Class
