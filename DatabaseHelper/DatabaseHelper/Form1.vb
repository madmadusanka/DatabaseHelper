Public Class frmMain
    Private Sub btnConnectServer_Click(sender As Object, e As EventArgs) Handles btnConnectServer.Click
        Dim connector As New Connection()
        connector.ConnectServer(txtServerName.Text, lblDatabaseCount)
    End Sub
End Class
