Imports System.Data.SqlClient

Public Class QueryExecutorController
    Private _connection As SqlConnection

    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal connection As SqlConnection)
        Me.Connection = connection
    End Sub

    Public Function ExecuteQuery(ByVal query As String) As DataTable
        Try
            If Connection Is Nothing Then
                Throw New InvalidOperationException("Connection property is not set.")
            End If

            If Connection.State <> ConnectionState.Open Then
                Connection.Open()
            End If

            Using command As New SqlCommand(query, Connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                Return dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Class
