Imports System.Data
Imports System.Data.SqlClient

Public Class Connection

    ' Windows Authentication
    Public Shared Async Function ConnectServer(ByVal serverName As String) As Task(Of SqlConnection)

        Dim connectionString As String = $"Server={serverName};Database=master;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            Await connection.OpenAsync()
            Return connection
        Catch ex As Exception
            Throw New Exception($"Error connecting to the server: {ex.Message}")
        End Try

    End Function

    ' SQL Server Authentication
    Public Shared Async Function ConnectServer(ByVal serverName As String, ByVal username As String, ByVal password As String) As Task(Of SqlConnection)

        Dim connectionString As String = $"Server={serverName};Database=master;User Id={username};Password={password};"
        Dim connection As New SqlConnection(connectionString)

        Try
            Await connection.OpenAsync()
            Return connection
        Catch ex As Exception
            Throw New Exception($"Error connecting to the server: {ex.Message}")
        End Try

    End Function

    ' Desconnect Server
    Public Shared Sub DisconnectServer(ByVal connection As SqlConnection)
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
                connection.Dispose()
            End If
        Catch ex As Exception
            Throw New Exception($"Error Desconnecting to the server: {ex.Message}")
        End Try


    End Sub

End Class
