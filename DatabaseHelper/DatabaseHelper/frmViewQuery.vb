Imports System.Data.SqlClient
Imports Common

Public Class frmViewQuery

    Private connection As SqlConnection
    Public Sub New(ByVal viewName As String, ByVal viewDefinition As String, ByVal connection As SqlConnection)
        InitializeComponent()

        Me.connection = connection
        ' Display view name and definition
        lblViewName.Text = viewName
        txtViewDefinition.Text = viewDefinition
    End Sub

    Private Sub frmViewQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryControlfrmViewQuery.Connection = connection
    End Sub
End Class