Public Class frmMain
    Private isConnected As Boolean = False
    Private connector As New Connection()

    Private Async Sub btnToggleConnection_Click(sender As Object, e As EventArgs) Handles btnToggleConnection.Click
        If isConnected Then
            ' Disconnect from the server
            DisconnectFromServer()
        Else
            ' Connect to the server
            Await ConnectToServer()
        End If
    End Sub

    Private Async Function ConnectToServer() As Task
        Await connector.ConnectServer(txtServerName.Text, lblDatabaseCount, btnToggleConnection)
        isConnected = True
    End Function

    Private Sub DisconnectFromServer()
        ' Perform disconnect logic here if necessary
        lblDatabaseCount.Text = ""
        isConnected = False
        btnToggleConnection.Text = "Connect"
    End Sub
End Class
