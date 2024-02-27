Imports System.Data.SqlClient
Imports System.Threading.Tasks

Public Class Connection

    Public Async Function ConnectServer(ByVal serverName As String, ByVal lblDatabaseCount As Label, ByVal btnToggleConnection As Button) As Task
        ' Connection string to your SQL Server instance
        Dim connectionString As String = "Server=" & serverName & ";Database=master;Integrated Security=True;"

        If Not String.IsNullOrEmpty(serverName) Then
            ' Update button text to "Please wait..."
            btnToggleConnection.Text = "Please wait..."

            ' Create connection
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Open connection
                    Await connection.OpenAsync()

                    ' Query to get the count of databases
                    Dim query As String = "SELECT COUNT(*) FROM sys.databases"

                    ' Create command
                    Using command As New SqlCommand(query, connection)
                        ' Execute scalar query to get the count
                        Dim databaseCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                        ' Set the text of the label to the database count
                        lblDatabaseCount.Text = "Total number of databases: " & databaseCount
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions
                    MessageBox.Show("Server name is Incorrect, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Reset button text to "Disconnect" if connection was successful
                    If connection.State = ConnectionState.Open Then
                        btnToggleConnection.Text = "Disconnect"
                    Else
                        ' Reset button text to "Connect" if connection failed
                        btnToggleConnection.Text = "Connect"
                    End If
                End Try
            End Using
        Else
            MessageBox.Show("Server name is empty or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

End Class
