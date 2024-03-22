Imports System.Data.SqlClient

' Event arguments for server connection
Public Class ServerConnectedEventArgs
    Inherits EventArgs

    Public Property Connection As SqlConnection
    Public Property Servername As String

    Public Sub New(connection As SqlConnection, servername As String)
        Me.Connection = connection
        Me.Servername = servername
    End Sub
End Class
