Imports System.Data.SqlClient
Imports Common
Imports CustomControllers

Public Class FrmLandingPage

    Private _connection As SqlConnection
    Private selectedDatabaseName As String
    Private reconnect As Boolean = False

    ' Property representing the connection state or status
    Public Property Connection As SqlConnection

        Get
            Return _connection
        End Get
        Set(value As SqlConnection)
            _connection = value
        End Set

    End Property

    ' Programmatically trigger the Connect Button to reconnect to the server
    Public Sub ProgrammaticallyClickConnectButton()

        btnConnection.PerformClick()
        reconnect = True

    End Sub

    ' Button to establish connection with the server
    Private Async Sub Btnconnect_Click(sender As Object, e As EventArgs) Handles btnConnection.Click

        Dim frmConnectServerInstance As FrmConnectServer = Application.OpenForms.OfType(Of FrmConnectServer).FirstOrDefault()

        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

            Common.Connection.DisconnectServer(Connection)
            btnConnection.Text = "Connect"
            Await ConnectToServer()

        Else

            If frmConnectServerInstance IsNot Nothing Then
                frmConnectServerInstance.BringToFront()
            Else
                Dim newFrmConnectServer As New FrmConnectServer()
                AddHandler newFrmConnectServer.ServerConnected, AddressOf OnServerConnected
                newFrmConnectServer.Show()
            End If

        End If

    End Sub

    ' Event handler for when a server is successfully connected
    Private Async Sub OnServerConnected(sender As Object, e As ServerConnectedEventArgs)

        Connection = e.Connection
        txtConnectedserverName.Text = e.Servername
        Await ConnectToServer()

    End Sub

    ' connect server Function
    Public Async Function ConnectToServer() As Task

        Try

            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

                Dim countDBquery As String = SQLQueries.DbCountQuery
                Await ShowDBCount(countDBquery, Connection, lblDBCount)

                Dim getDBquery As String = SQLQueries.DBNamesQuery
                Await ShowDbNames(getDBquery, Connection, cmbDatabases)

                QueryExecuterLandingPage.Connection = Connection
                pnlDashBoardMain.Visible = True
                txtConnectedserverName.Visible = True
                btnConnection.Text = "Disconnect"
                pnlMain.Visible = True

                Dim formToOpen As FrmQueryCompare = Nothing

                ' Iterate through the open forms collection
                For Each frm As Form In Application.OpenForms

                    If TypeOf frm Is FrmQueryCompare Then
                        ' The form is already open, set formToOpen and exit the loop
                        formToOpen = DirectCast(frm, FrmQueryCompare)
                        Exit For
                    End If

                Next

                ' If the request is for reconnection, display the already open form
                If reconnect Then

                    If formToOpen.Visible Then
                        formToOpen.SetConnection(Connection)
                        formToOpen.BringToFront()
                        reconnect = False
                    End If

                End If

            Else
                ClearData()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the count of database records
    Private Async Function ShowDBCount(ByVal query As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Using command As New SqlCommand(query, connection)
                    Dim count As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())
                    lbl.Text = "Total databases : " & count.ToString()
                End Using

            End If

        Catch ex As Exception
            lbl.Text = "Error retrieving database count: " & ex.Message
        End Try

    End Function

    ' Select a database from the combobox
    Public Async Sub CmbDatabaseNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatabases.SelectedIndexChanged

        Try

            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

                If cmbDatabases.SelectedItem IsNot Nothing Then

                    selectedDatabaseName = cmbDatabases.SelectedItem.ToString()

                    Dim getDBNamesquery As String = SQLQueries.DBNamesQuery

                    Await ShowDbNames(getDBNamesquery, Connection, cmbDatabases)

                    Await ShowTableCount(selectedDatabaseName, Connection, lblTableCount)
                    Await ShowSpCount(selectedDatabaseName, Connection, lblSpCount)
                    Await ViewCount(selectedDatabaseName, Connection, lblViewCount)

                    Await PopulateTableComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectTable)
                    Await PopulateProcedureComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectProcedure)
                    Await PopulateViewComboBoxWithQuery(selectedDatabaseName, Connection, cmbSelectView)

                    pnlSelectDetails.Visible = True

                Else
                    MessageBox.Show("Please select a database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Display the names of available databases
    Private Async Function ShowDbNames(ByVal query As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Using command As New SqlCommand(query, connection)

                    Dim reader As SqlDataReader = Await command.ExecuteReaderAsync()
                    cmb.Items.Clear()

                    While reader.Read()
                        cmb.Items.Add(reader("name").ToString())
                    End While

                    reader.Close()
                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while populating the ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the counts of tables for each database
    Private Async Function ShowTableCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(TablesCountQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    pnlShowTable.Visible = True
                    lbltbllbl.Text = "Table"
                    lbl.Text = tableCount.ToString()

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the counts of stored procedures for each database
    Private Async Function ShowSpCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(StoredProceduresCountQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    pnlShowSp.Visible = True
                    lblsplbl.Text = "Procedure"
                    lbl.Text = tableCount.ToString()

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the counts of views for each database
    Private Async Function ViewCount(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal lbl As Label) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(ViewsCountQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Dim tableCount As Integer = Convert.ToInt32(Await command.ExecuteScalarAsync())

                    pnlShowView.Visible = True
                    lblviewlbl.Text = "View"
                    lbl.Text = tableCount.ToString()
                End Using

            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving table count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the names of tables for each database
    Private Async Function PopulateTableComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(TablesNamesQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()

                        cmb.Items.Clear()

                        While reader.Read()
                            cmb.Items.Add(reader("TABLE_NAME").ToString())
                        End While

                    End Using

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display the names of stored procedures for each database
    Private Async Function PopulateProcedureComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(StoredProceduresNamesQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()

                        cmb.Items.Clear()

                        While reader.Read()
                            cmb.Items.Add(reader("StoredProcedureName").ToString())
                        End While

                    End Using

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    'Display the names of views for each database
    Private Async Function PopulateViewComboBoxWithQuery(ByVal databaseName As String, ByVal connection As SqlConnection, ByVal cmb As ComboBox) As Task

        Try

            If connection.State = ConnectionState.Open Then

                Dim query As String = String.Format(ViewsNamesQuery, databaseName)

                Using command As New SqlCommand(query, connection)

                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()

                        cmb.Items.Clear()

                        While reader.Read()
                            cmb.Items.Add(reader("ViewName").ToString())
                        End While

                    End Using

                End Using

            End If

        Catch ex As Exception
            MessageBox.Show($"An error occurred while populating the ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Display SQL query
    Public Shared Function ShowQuery(ByVal query As String, ByVal connection As SqlConnection, ByVal selectedName As String) As Task

        Try

            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then

                Using command As New SqlCommand(query, connection)

                    Dim QueryDefinition As String = command.ExecuteScalar()?.ToString()
                    Dim viewQueryForm As New FrmViewQuery(selectedName, QueryDefinition, connection)
                    viewQueryForm.Show()

                End Using

            Else
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Task.CompletedTask

    End Function

    ' Display the SQL query for the selected view
    Private Async Sub BtnShowViewQuery_Click(sender As Object, e As EventArgs) Handles btnShowViewQuery.Click

        If cmbSelectView.SelectedItem IsNot Nothing Then

            Dim selectedViewName As String = cmbSelectView.SelectedItem.ToString()
            Dim query As String = String.Format(ViewDetailQuery, selectedViewName)
            Await ShowQuery(query, Connection, selectedViewName)

        Else
            MessageBox.Show("Please select a view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ' Display the SQL query for the selected Stored Procedure
    Private Async Sub BtnShowProcedure_Click(sender As Object, e As EventArgs) Handles btnShowProcedure.Click

        If cmbSelectProcedure.SelectedItem IsNot Nothing Then

            Dim selectedProcedureName As String = cmbSelectProcedure.SelectedItem.ToString()
            Dim query As String = String.Format(ProcedureDetailQuery, selectedProcedureName)
            Await ShowQuery(query, Connection, selectedProcedureName)

        Else
            MessageBox.Show("Please select a procedure.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ' Show selected Table options
    Private Sub BtnTableOption_Click(sender As Object, e As EventArgs) Handles btnTableOption.Click

        Try

            If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then

                Dim selectedTableName As String = cmbSelectTable.SelectedItem?.ToString()

                If selectedTableName IsNot Nothing Then

                    Dim TableOptionForm As New FrmTableOption(selectedDatabaseName, selectedTableName, Connection)
                    TableOptionForm.Show()

                Else
                    MessageBox.Show("Please select a table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Database connection is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Open Query Compare screen
    Private Sub BtnfrmQueryCompare_Click(sender As Object, e As EventArgs) Handles btnfrmQueryCompare.Click

        Dim queryCompareFormInstance As FrmQueryCompare = Application.OpenForms.OfType(Of FrmQueryCompare).FirstOrDefault()

        If queryCompareFormInstance IsNot Nothing Then
            queryCompareFormInstance.BringToFront()
        Else
            Dim queryCompareForm As New FrmQueryCompare(Connection)
            queryCompareForm.Show()
        End If

    End Sub

    ' Clear all items after Desconnect
    Private Sub ClearData()

        lblDBCount.Text = ""
        cmbDatabases.SelectedIndex = -1
        cmbSelectTable.SelectedIndex = -1
        cmbSelectProcedure.SelectedIndex = -1
        cmbSelectView.SelectedIndex = -1
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

    End Sub

End Class