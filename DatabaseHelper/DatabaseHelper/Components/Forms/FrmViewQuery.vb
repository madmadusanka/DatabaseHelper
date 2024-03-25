Imports System.Data.SqlClient

Public Class FrmShowQuery

    Private connection As SqlConnection

    ' Constructor for initializing form with viewDefinition and connection
    Public Sub New(ByVal ShowName As String, ByVal ShowDefinition As String, ByVal connection As SqlConnection)
        InitializeComponent()

        Me.connection = connection
        LBL_Selected_Name.Text = ShowName
        txtShowDefinition.Text = ShowDefinition

    End Sub

    ' Form Load event
    Private Sub FRM_ShowQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qcShowQuery.Connection = connection
    End Sub

End Class