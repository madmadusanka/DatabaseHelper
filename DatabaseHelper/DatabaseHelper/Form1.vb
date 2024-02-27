Imports System.Data.SqlClient
Imports Common


Public Class frmLandingPage
    Private isConnected As Boolean = False
    Private connector As New Connection()

    Private Async Sub btnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click
        Try
            ' Connect to the server
            Dim connection As SqlConnection = Await connector.ConnectServer(txtServerName.Text)

            ' Update the button text based on the connection status
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                btnToggleConnection.Text = "Disconnect"

                ' Retrieve database names and populate ComboBox
                Dim query As String = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')"
                Await PopulateComboBoxWithQuery(query, connection, cmbDatabases)
            Else
                btnToggleConnection.Text = "Connect"
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
