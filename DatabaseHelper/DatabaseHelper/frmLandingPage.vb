Imports System.Data.SqlClient
Imports Common

Public Class frmLandingPage
    Private isConnected As Boolean = False
    Private connection As SqlConnection
    Private ConnectionManager As New Connection()

    Private Async Sub btnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click
        Try
            If Not String.IsNullOrEmpty(txtServerName.Text) Then
                If isConnected Then
                    ' Disconnect from the server
                    ConnectionManager.DisconnectServer(connection)
                    btnToggleConnection.Text = "Connect"
                    isConnected = False
                    lblDBCount.Text = ""
                    cmbDatabases.Items.Clear()
                    lblTableCount.Text = ""
                    lblSpCount.Text = ""
                    lblViewCount.Text = ""
                    lbltbllbl.Text = ""
                    lblsplbl.Text = ""
                    lblviewlbl.Text = ""
                    pnlShowTable.Visible = False
                    pnlShowSp.Visible = False
                    pnlShowView.Visible = False
                Else
                    ' Connect to the server
                    connection = Await ConnectionManager.ConnectServer(txtServerName.Text)

                    ' Update the button text based on the connection status
                    If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                        btnToggleConnection.Text = "Disconnect"
                        isConnected = True

                        Dim countDBquery As String = SQLQueries.CountDb
                        Await ShowDBCount(countDBquery, connection, lblDBCount)

                        ' Retrieve database names and populate ComboBox
                        Dim getDBquery As String = SQLQueries.FetchDbNames
                        Await PopulateComboBoxWithQuery(getDBquery, connection, cmbDatabases)
                    End If
                End If
            Else
                MessageBox.Show("Server name is empty or null. Please enter a valid server name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function PopulateComboBoxWithQuery(ByVal query As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
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
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred while populating the ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Async Function ShowDBCount(ByVal query As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Create command
                Using command As New SqlCommand(query, connection)
                    ' Execute the query to get the count
                    Dim count As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    ' Set the text of the label to display the count
                    lbl.Text = "Total databases : " & count.ToString()
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            lbl.Text = "Error retrieving database count: " & ex.Message
        End Try
    End Function

    Private Async Sub cmbDatabases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatabases.SelectedIndexChanged
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                ' Get the selected database name
                Dim selectedDatabaseName As String = cmbDatabases.SelectedItem.ToString()

                ' Show the table count for the selected database
                Await ShowTableCount(selectedDatabaseName, connection, lblTableCount)
                Await ShowSpCount(selectedDatabaseName, connection, lblSpCount)
                Await viewCount(selectedDatabaseName, connection, lblViewCount)
            Else
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function ShowTableCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Query to retrieve the count of tables in the database
                Dim query As String = $"USE [{databaseName}]; {SQLQueries.CountTables}"


                ' Create command
                Using command As New SqlCommand(query, connection)
                    ' Execute the query to get the table count
                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    ' Set the text of the label to display the table count
                    pnlShowTable.Visible = True
                    lbltbllbl.Text = "Table"
                    lbl.Text = tableCount.ToString()
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function ShowSpCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Query to retrieve the count of tables in the database
                Dim query As String = $"USE [{databaseName}]; {SQLQueries.CountStoredProcedures}"


                ' Create command
                Using command As New SqlCommand(query, connection)
                    ' Execute the query to get the table count
                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    ' Set the text of the label to display the table count
                    pnlShowSp.Visible = True
                    lblsplbl.Text = "Procedure"
                    lbl.Text = tableCount.ToString()
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function viewCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Query to retrieve the count of tables in the database
                Dim query As String = $"USE [{databaseName}]; {SQLQueries.CountViews}"


                ' Create command
                Using command As New SqlCommand(query, connection)
                    ' Execute the query to get the table count
                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    ' Set the text of the label to display the table count
                    pnlShowView.Visible = True
                    lblviewlbl.Text = "View"
                    lbl.Text = tableCount.ToString()
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Class