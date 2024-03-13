﻿Imports System.Data.SqlClient
Imports Common
Imports DatabaseHelper.DataCache

Public Class frmConnectServer

    Enum AuthType
        Windows_Authentication = 1
        SQL_Server_Authentication = 2
    End Enum

    Public Event ServerConnected As EventHandler(Of ServerConnectedEventArgs)

    Private isConnected As Boolean = False
    Private connection As SqlConnection
    Private ConnectionManager As New Connection()
    Private originalComboBoxItems As New List(Of Object)()
    Private selectedDatabaseName As String
    Private serverNames As New List(Of String)()
    Dim fm As frmLandingPage
    Private ServerUserName As String
    Private ServerUserPassword As String

    Dim TableOptionForm As String
    Private selectedEnumNumber As Integer = -1

    Private Async Sub btnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click
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

    Private Async Function ConnectToServer(ByVal selectedEnumNumber As Integer) As Task
        Try
            If Not String.IsNullOrEmpty(txtServerName.Text) Then
                If isConnected Then
                    ' Disconnect from the server
                    ConnectionManager.DisconnectServer(connection)
                    btnToggleConnection.Text = "Connect"
                    isConnected = False

                    ' Return connection to already open form
                    If fm IsNot Nothing Then
                        fm.Connection = connection
                    End If

                    RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                Else
                    ' Connect to the server
                    If selectedEnumNumber = 1 Then
                        btnToggleConnection.Text = "Please Wait.."
                        connection = Await ConnectionManager.ConnectServer(txtServerName.Text)

                        ServerNameCache.CacheServerName(txtServerName.Text)

                        ' Update the button text based on the connection status
                        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                            btnToggleConnection.Text = "Disconnect"
                            isConnected = True

                            ' Raise the ServerConnected event
                            RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                        End If
                    ElseIf selectedEnumNumber = 2 Then
                        btnToggleConnection.Text = "Please Wait.."
                        connection = Await ConnectionManager.ConnectServer(txtServerName.Text, ServerUserName, ServerUserPassword)
                        ServerNameCache.CacheServerName(txtServerName.Text)

                        ' Update the button text based on the connection status
                        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                            btnToggleConnection.Text = "Disconnect"
                            isConnected = True

                            ' Raise the ServerConnected event
                            RaiseEvent ServerConnected(Me, New ServerConnectedEventArgs(connection, txtServerName.Text))

                        End If
                    End If
                End If
            Else
                MessageBox.Show("Server name is empty or null. Please enter a valid server name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub frmConnectServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cachedServerName As String = ServerNameCache.GetCachedServerName()
        txtServerName.Text = cachedServerName
        LoadComboBoxFromEnum()
        cmbAuthselect.SelectedIndex = 0
    End Sub


    Private Sub LoadComboBoxFromEnum()
        ' Clear existing items in the ComboBox
        cmbAuthselect.Items.Clear()

        ' Loop through enum values and add them to the ComboBox
        For Each day As AuthType In [Enum].GetValues(GetType(AuthType))
            cmbAuthselect.Items.Add(day.ToString())
        Next
    End Sub

    Private Sub cmbAuthselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthselect.SelectedIndexChanged
        ' Get the selected index of the ComboBox
        Dim selectedIndex As Integer = cmbAuthselect.SelectedIndex

        ' Map the selected index to the associated number from the enum
        Select Case selectedIndex
            Case 0
                selectedEnumNumber = CInt(AuthType.Windows_Authentication)
                pnlUserName.Visible = False
                btnToggleConnection.Location = New Point(89, 125)
            Case 1
                selectedEnumNumber = CInt(AuthType.SQL_Server_Authentication)
                pnlUserName.Visible = True
                btnToggleConnection.Location = New Point(89, 190)
        End Select
    End Sub

End Class
