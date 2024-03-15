Imports System.Data.SqlClient
Imports Common

Public Class FrmViewQuery

    Private connection As SqlConnection
    Public Sub New(ByVal viewName As String, ByVal viewDefinition As String, ByVal connection As SqlConnection)
        InitializeComponent()

        Me.connection = connection
        lblViewName.Text = viewName
        txtViewDefinition.Text = viewDefinition
    End Sub

    Private Sub FrmViewQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryControlfrmViewQuery.Connection = connection
    End Sub
End Class