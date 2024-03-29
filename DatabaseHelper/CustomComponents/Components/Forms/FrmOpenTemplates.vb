Imports System.Data.SqlClient

Public Class frmOpenTemplates

    Private _connection As SqlConnection
    Private _queryFilePath As String

    ' Initializes the form with the provided SqlConnection object
    Public Sub New(ByVal connection As SqlConnection, ByVal queryFilePath As String)

        InitializeComponent()
        _connection = connection
        _queryFilePath = queryFilePath
        InitializeForm()

    End Sub

    Private Sub InitializeForm()

        qcMain.Connection = _connection
        qcMain.IsflpCustomComponentVisible = True
        qcMain.IsViewTemplateButtonVisible = False
        qcMain.SetTemplateQueryPath(_queryFilePath)

    End Sub

End Class