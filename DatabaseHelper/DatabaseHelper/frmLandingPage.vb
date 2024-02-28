Imports System.Data.SqlClient
Imports Common

Public Class frmLandingPage
    Private isConnected As Boolean = False
    Private connector As New Connection()

    Private Async Sub btnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click
        Try
            If isConnected Then
                ' Disconnect from the server
                connector.DisconnectServer()
                btnToggleConnection.Text = "Connect"
                isConnected = False
                lblDBCount.Text = ""
                cmbDatabases.Items.Clear()
            Else
                ' Connect to the server
                Dim connection As SqlConnection = Await connector.ConnectServer(txtServerName.Text)

                ' Update the button text based on the connection status
                If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                    btnToggleConnection.Text = "Disconnect"
                    isConnected = True

                    Dim countDBquery As String = "SELECT COUNT(name) FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"
                    Await ShowDBCount(countDBquery, connection, lblDBCount)

                    ' Retrieve database names and populate ComboBox
                    Dim getDBquery As String = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"
                    Await PopulateComboBoxWithQuery(getDBquery, connection, cmbDatabases)
                End If
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function PopulateComboBoxWithQuery(ByVal query As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            ' Create command
            Using command As New SqlCommand(query, connection)
                ' Execute the query
                Dim reader As SqlDataReader = Await command.ExecuteReaderAsync()

                ' Clear existing items in the dropdown list
                cmb.Items.Clear()

                ' Add database names to the dropdown list
                While reader.Read()
                    cmb.Items.Add(reader("name").ToString())
                End While

                ' Close the reader
                reader.Close()
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred while populating the ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function ShowDBCount(ByVal query As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task
        Try
            ' Create command
            Using command As New SqlCommand(query, connection)
                ' Execute the query to get the count
                Dim count As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                ' Set the text of the label to display the count
                lbl.Text = "Total databases : " & count.ToString()
            End Using
        Catch ex As Exception
            ' Handle any exceptions
            lbl.Text = "Error retrieving database count: " & ex.Message
        End Try
    End Function

End Class
