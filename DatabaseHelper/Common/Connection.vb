Imports System.Data
Imports System.Data.SqlClient

Public Class Connection
    Private sqlConnection As SqlConnection

    Public Async Function ConnectServer(ByVal serverName As String) As Task(Of SqlConnection)
        ' Connection string to your SQL Server instance
        Dim connectionString As String = "Server=" & serverName & ";Database=master;Integrated Security=True;"

        If Not String.IsNullOrEmpty(serverName) Then
            Try
                ' Create and open connection
                sqlConnection = New SqlConnection(connectionString)
                Await sqlConnection.OpenAsync()

                ' Return the opened connection
                Return sqlConnection
            Catch ex As Exception
                ' Handle any exceptions
                Throw New Exception("An error occurred while connecting to the server: " & ex.Message)
            End Try
        Else
            Throw New Exception("Server name is empty or null")
        End If
    End Function

    Public Sub DisconnectServer()
        If sqlConnection IsNot Nothing AndAlso sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
            sqlConnection.Dispose()
        End If
    End Sub
End Class
