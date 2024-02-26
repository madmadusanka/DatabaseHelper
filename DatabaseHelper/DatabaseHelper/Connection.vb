Imports System.Data.SqlClient

Public Class Connection

    Sub ConnectServer(ByVal serverName As String, ByVal lblDatabaseCount As Label)
        ' Connection string to your SQL Server instance
        Dim connectionString As String = "Server=" & serverName & ";Database=master;Integrated Security=True;"

        If Not String.IsNullOrEmpty(serverName) Then
            ' Create connection
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Open connection
                    connection.Open()

                    ' Query to get the count of databases
                    Dim query As String = "SELECT COUNT(*) FROM sys.databases"

                    ' Create command
                    Using command As New SqlCommand(query, connection)
                        ' Execute scalar query to get the count
                        Dim databaseCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                        ' Set the text of the label to the database count
                        lblDatabaseCount.Text = "Total number of databases: " & databaseCount
                    End Using
                Catch ex As Exception
                    ' Handle any exceptions
                    lblDatabaseCount.Invoke(Sub() MessageBox.Show("Server name is Incorrect, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error))
                End Try
            End Using
        Else
            MessageBox.Show("Server name is empty or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
