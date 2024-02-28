Imports System.Data.SqlClient

Public Class Connection

    Public Async Function ConnectServer(ByVal serverName As String) As Task(Of SqlConnection)
        ' Connection string to your SQL Server instance
        Dim connectionString As String = "Server=" & serverName & ";Database=master;Integrated Security=True;"

        If Not String.IsNullOrEmpty(serverName) Then
            Try
                ' Create and open connection
                Dim connection As New SqlConnection(connectionString)
                Await connection.OpenAsync()

                ' Return the opened connection
                ' Return the opened connection
                Return connection
            Catch ex As Exception
                ' Handle any exceptions
                Throw New Exception("An error occurred while connecting to the server: " & ex.Message)
                Return Nothing
            End Try
        Else
            Throw New Exception("Server name is empty or null")
            Return Nothing
        End If
    End Function

End Class
