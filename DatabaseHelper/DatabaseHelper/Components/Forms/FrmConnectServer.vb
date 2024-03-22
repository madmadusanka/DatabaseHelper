Imports System.Data.SqlClient
Imports DatabaseHelper.DataCache

Public Class FrmConnectServer

    Private isConnected As Boolean = False
    Private connection As SqlConnection
    Private frmlandingpage As FrmLandingPage
    Private ServerUserName As String
    Private ServerUserPassword As String
    Private selectedEnumNumber As Integer = -1
    Public Event ServerConnected As EventHandler(Of ServerConnectedEventArgs)

    ' Enum for authentication types
    Enum AuthType

        Windows_Authentication = 1
        SQL_Server_Authentication = 2

    End Enum

    ' Button to establish connection with the server
    Private Async Sub BtnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click

        If selectedEnumNumber = 1 Then

            Await ConnectToServer(selectedEnumNumber)
            Me.Close()

        ElseIf selectedEnumNumber = 2 Then

            ServerUserName = txtServerUserName.Text
            ServerUserPassword = txtServerUserPassword.Text

            If String.IsNullOrEmpty(ServerUserName) OrElse String.IsNullOrEmpty(ServerUserPassword) Then
                MessageBox.Show("Server username or password is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Await ConnectToServer(selectedEnumNumber)
                Me.Close()
            End If

        Else
            MessageBox.Show("Select Auth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' Function to initiate a connection with the server
    Private Async Function ConnectToServer(ByVal selectedEnumNumber As Integer) As Task

        Try

            If Not String.IsNullOrEmpty(txtServerName.Text) Then

                If isConnected Then

                    Common.Connection.DisconnectServer(connection)
                    btnToggleConnection.Text = "Connect"
                    isConnected = False

                    RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                Else

                    If selectedEnumNumber = 1 Then

                        btnToggleConnection.Text = "Please Wait.."
                        connection = Await Common.Connection.ConnectServer(txtServerName.Text)

                        ServerNameCache.CacheServerName(txtServerName.Text)

                        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then

                            btnToggleConnection.Text = "Disconnect"
                            isConnected = True

                            RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                        End If

                    ElseIf selectedEnumNumber = 2 Then

                        btnToggleConnection.Text = "Please Wait.."
                        connection = Await Common.Connection.ConnectServer(txtServerName.Text, ServerUserName, ServerUserPassword)
                        ServerNameCache.CacheServerName(txtServerName.Text)

                        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then

                            btnToggleConnection.Text = "Disconnect"
                            isConnected = True

                            RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                        End If

                    End If

                End If

            Else
                MessageBox.Show("Server name is empty or null. Please enter a valid server name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ' Load ComboBox with values from an AuthType enum
    Private Sub LoadComboBoxFromEnum()

        cmbAuthselect.Items.Clear()

        ' Loop through enum values and add them to the ComboBox
        For Each day As AuthType In [Enum].GetValues(GetType(AuthType))
            cmbAuthselect.Items.Add(day.ToString())
        Next

    End Sub

    ' Retrieve the selected authentication type from the combobox
    Private Sub CmbAuthselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthselect.SelectedIndexChanged

        Dim selectedIndex As Integer = cmbAuthselect.SelectedIndex

        Select Case selectedIndex

            Case 0

                selectedEnumNumber = CInt(AuthType.Windows_Authentication)
                pnlUserName.Visible = False
                btnToggleConnection.Location = New Point(69, 175)

            Case 1

                selectedEnumNumber = CInt(AuthType.SQL_Server_Authentication)
                pnlUserName.Visible = True
                btnToggleConnection.Location = New Point(69, 240)

        End Select

    End Sub

    ' Form Load Events
    Private Sub FrmConnectServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cachedServerName As String = ServerNameCache.GetCachedServerName()
        txtServerName.Text = cachedServerName
        LoadComboBoxFromEnum()
        cmbAuthselect.SelectedIndex = 0

    End Sub

End Class
