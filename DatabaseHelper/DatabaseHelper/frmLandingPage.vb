Imports System.Data.SqlClient
Imports Common
Imports DatabaseHelper.DataCache

Public Class frmLandingPage
    Private isConnected As Boolean = False
    Private _connection As SqlConnection
    Private ConnectionManager As New Connection()
    Private originalComboBoxItems As New List(Of Object)()
    Private selectedDatabaseName As String
    Private serverNames As New List(Of String)()

    Dim TableOptionForm As String

    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(value As SqlConnection)
            _connection = value
            ' Use the connection object here
        End Set
    End Property

    Private Async Sub OnServerConnected(sender As Object, e As ServerConnectedEventArgs)
        Connection = e.Connection
        txtConnectedserverName.Text = e.Servername
        Await ConnectToServer()
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

    Public Async Sub cmbDatabases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatabases.SelectedIndexChanged
        Try
            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
                ' Get the selected database name
                selectedDatabaseName = cmbDatabases.SelectedItem.ToString()

                Dim getDBquery As String = SQLQueries.DBNamesQuery
                Await PopulateComboBoxWithQuery(getDBquery, Connection, cmbDatabases)

                ' Show the table count for the selected database
                Await ShowTableCount(selectedDatabaseName, Connection, lblTableCount)
                Await ShowSpCount(selectedDatabaseName, Connection, lblSpCount)
                Await viewCount(selectedDatabaseName, Connection, lblViewCount)

                Await PopulateTableComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectTable)
                Await PopulateProcedureComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectProcedure)
                Await PopulateViewComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectView)

                pnlSelectDetails.Visible = True

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
                Dim query As String = String.Format(TablesCountQuery, databaseName)


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
                Dim query As String = String.Format(StoredProceduresCountQuery, databaseName)

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
                Dim query As String = String.Format(ViewsCountQuery, databaseName)


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

    Private Async Function PopulateTableComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Construct the SQL query to retrieve table names

                Dim query As String = String.Format(TablesNamesQuery, databaseName)

                ' Create and execute the command asynchronously
                Using command As New SqlCommand(query, connection)
                    ' Execute the query asynchronously
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        ' Clear existing items in the ComboBox
                        cmb.Items.Clear()

                        ' Iterate over the result set and add table names to the ComboBox
                        While reader.Read()
                            cmb.Items.Add(reader("TABLE_NAME").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function PopulateProcedureComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Construct the SQL query to retrieve table names
                Dim query As String = String.Format(StoredProceduresNamesQuery, databaseName)

                ' Create and execute the command asynchronously
                Using command As New SqlCommand(query, connection)
                    ' Execute the query asynchronously
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        ' Clear existing items in the ComboBox
                        cmb.Items.Clear()

                        ' Iterate over the result set and add table names to the ComboBox
                        While reader.Read()
                            cmb.Items.Add(reader("StoredProcedureName").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function PopulateViewComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task
        Try
            If connection.State = ConnectionState.Open Then
                ' Construct the SQL query to retrieve table names

                Dim query As String = String.Format(ViewsNamesQuery, databaseName)

                ' Create and execute the command asynchronously
                Using command As New SqlCommand(query, connection)
                    ' Execute the query asynchronously
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        ' Clear existing items in the ComboBox
                        cmb.Items.Clear()

                        ' Iterate over the result set and add table names to the ComboBox
                        While reader.Read()
                            cmb.Items.Add(reader("ViewName").ToString())
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Sub btnShowViewQuery_Click(sender As Object, e As EventArgs) Handles btnShowViewQuery.Click
        ' Get the selected view name
        If cmbSelectView.SelectedItem IsNot Nothing Then
            Dim selectedViewName As String = cmbSelectView.SelectedItem.ToString()

            ' Query to retrieve the view definition
            Dim query As String = String.Format(ViewDetailQuery, selectedViewName)

            Await ShowQuery(query, Connection, selectedViewName)
        Else
            MessageBox.Show("Please select a view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Function ShowQuery(ByVal query As String, ByVal connection As SqlConnection, ByVal selectedName As String) As Task
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then

                ' Execute the query
                Using command As New SqlCommand(query, connection)
                    Dim QueryDefinition As String = command.ExecuteScalar()?.ToString()

                    ' Open the ViewQueryForm and pass the view query
                    Dim viewQueryForm As New frmViewQuery(selectedName, QueryDefinition, connection)
                    viewQueryForm.Show()
                End Using
            Else
                ' Display error message if database connection is closed
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Task.CompletedTask
    End Function

    Private Async Sub btnShowProcedure_Click(sender As Object, e As EventArgs) Handles btnShowProcedure.Click
        ' Get the selected view name
        If cmbSelectProcedure.SelectedItem IsNot Nothing Then
            Dim selectedProcedureName As String = cmbSelectProcedure.SelectedItem.ToString()

            ' Query to retrieve the view definition
            Dim query As String = String.Format(ProcedureDetailQuery, selectedProcedureName)

            Await ShowQuery(query, Connection, selectedProcedureName)
        Else
            MessageBox.Show("Please select a procedure.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnTableOption_Click(sender As Object, e As EventArgs) Handles btnTableOption.Click
        Try
            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
                ' Check if an item is selected in cmbSelectTable
                Dim selectedTableName As String = cmbSelectTable.SelectedItem?.ToString()

                If selectedTableName IsNot Nothing Then
                    ' An item is selected, so proceed with its value
                    Dim TableOptionForm As New frmTableOption(selectedDatabaseName, selectedTableName, Connection)
                    TableOptionForm.Show()
                Else
                    ' No item is selected in cmbSelectTable, show an error message
                    MessageBox.Show("Please select a table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnfrmQueryCompare.Click
        Dim queryCompareForm As New frmQueryCompare(Connection)
        queryCompareForm.Show()
    End Sub

    Public Async Function ConnectToServer() As Task
        Try
            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
                pnlMain.Visible = True

                Dim countDBquery As String = SQLQueries.DbCountQuery
                Await ShowDBCount(countDBquery, Connection, lblDBCount)

                ' Retrieve database names and populate ComboBox
                Dim getDBquery As String = SQLQueries.DBNamesQuery
                Await PopulateComboBoxWithQuery(getDBquery, Connection, cmbDatabases)

                QueryExecuterLandingPage.Connection = Connection
                pnlDashBoardMain.Visible = True
                txtConnectedserverName.Visible = True
                btnConnection.Text = "Disconnect"

            Else
                lblDBCount.Text = ""
                cmbDatabases.SelectedIndex = -1
                cmbDatabases.Items.Clear()
                cmbSelectTable.Items.Clear()
                cmbSelectProcedure.Items.Clear()
                cmbSelectView.Items.Clear()
                lblTableCount.Text = ""
                lblSpCount.Text = ""
                lblViewCount.Text = ""
                lbltbllbl.Text = ""
                lblsplbl.Text = ""
                lblviewlbl.Text = ""
                pnlShowTable.Visible = False
                pnlShowSp.Visible = False
                pnlShowView.Visible = False
                pnlMain.Visible = False
                pnlSelectDetails.Visible = False
                selectedDatabaseName = ""
                pnlDashBoardMain.Visible = False
                pnlDashBoardMain.Visible = False
                btnConnection.Text = "Connect"
                txtConnectedserverName.Text = ""
                txtConnectedserverName.Visible = False
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Sub btnconnect_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        Dim frmConnectServerInstance As frmConnectServer = Application.OpenForms.OfType(Of frmConnectServer).FirstOrDefault()

        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            ConnectionManager.DisconnectServer(Connection)
            btnConnection.Text = "Connect"
            isConnected = False
            Await ConnectToServer()

        Else
            Dim newFrmConnectServer As New frmConnectServer()
            AddHandler newFrmConnectServer.ServerConnected, AddressOf OnServerConnected
            newFrmConnectServer.Show()
        End If
    End Sub

End Class