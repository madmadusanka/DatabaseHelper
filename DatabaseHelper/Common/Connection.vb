Imports System.Data.SqlClient
Imports System.Threading.Tasks

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
                Return connection
            Catch ex As Exception
                ' Handle any exceptions
                'MessageBox.Show("An error occurred while connecting to the server: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        Else
            ' MessageBox.Show("Server name is empty or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End If
    End Function

End Class
