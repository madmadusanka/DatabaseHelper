Imports System.Data.SqlClient

Public Class QueryControl
    Private controller As New QueryExecutorController
    Private _connection As SqlConnection

    Public Property Connection As SqlConnection
        Get
            Return _connection
        End Get
        Set(ByVal value As SqlConnection)
            _connection = value
            ' Reinitialize the controller with the new connection
            Initialize()
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub Initialize()
        Try
            ' Reinitialize the controller with the new connection
            controller = New QueryExecutorController(Connection)
        Catch ex As Exception
            MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExecuteQueryButton_Click(sender As Object, e As EventArgs) Handles ExecuteQueryButton.Click
        Try
            ' Check if connection is set
            If Connection IsNot Nothing Then
                Dim query As String = fastColoredTextBox.Text.Trim()
                Dim dataTable As DataTable = controller.ExecuteQuery(query)

                If dataTable IsNot Nothing Then
                    QueryResultDataGridView.DataSource = dataTable
                Else
                    MessageBox.Show("Failed to execute the query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Connection property is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmQueryExecutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDeleteThis_Click(sender As Object, e As EventArgs) Handles btnDeleteThis.Click
        If Me.Parent IsNot Nothing Then
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Public Property IsDeleteButtonVisible As Boolean
        Get
            Return btnDeleteThis.Visible
        End Get
        Set(value As Boolean)
            btnDeleteThis.Visible = value
        End Set
    End Property
End Class
