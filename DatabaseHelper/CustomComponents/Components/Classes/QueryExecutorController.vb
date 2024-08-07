﻿Imports System.Data.SqlClient

' Controller for executing SQL queries
Public Class QueryExecutorController

    Private _connection As SqlConnection

    ' Property for managing the SqlConnection object
    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
        End Set
    End Property

    ' Default constructor
    Public Sub New()
    End Sub

    ' Constructor for initializing the connection property
    Public Sub New(ByVal connection As SqlConnection)
        Me.Connection = connection
    End Sub

    ' Executes the SQL query and returns the result as a DataTable
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
