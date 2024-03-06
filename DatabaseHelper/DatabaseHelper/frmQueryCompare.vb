Imports CustomControllers
Imports System.Data.SqlClient

Public Class frmQueryCompare
    ' Declare a List to store references to the dynamically generated QueryControl instances
    Private queryControls As New List(Of QueryControl)

    Private _connection As SqlConnection

    ' Constructor modified to accept an existing SqlConnection
    Public Sub New(ByVal connection As SqlConnection)
        InitializeComponent()

        ' Set the connection
        _connection = connection

        ' Initialize the form
        Initialize()
    End Sub

    Public Sub Initialize()
        Try
            ' Reinitialize the controller with the new connection
            ' You may want to do some additional initialization here if needed

        Catch ex As Exception
            MessageBox.Show($"An error occurred while initializing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmQueryCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add two permanently added items
        Dim permanentItem1 As New QueryControl()
        permanentItem1.Connection = _connection ' Use the existing connection
        FlowLayoutPanel1.Controls.Add(permanentItem1)
        queryControls.Add(permanentItem1)

        Dim permanentItem2 As New QueryControl()
        permanentItem2.Connection = _connection ' Use the existing connection
        FlowLayoutPanel1.Controls.Add(permanentItem2)
        queryControls.Add(permanentItem2)

        ' Update the ComboBox to reflect the added permanent items
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If queryControls.Count >= 2 Then
            ' You can't add more than two permanent items
            Dim QC1 As New CustomControllers.QueryControl()
            QC1.Connection = _connection
            QC1.IsDeleteButtonVisible = True

            ' Add b1 to the list of QueryControl instances
            queryControls.Add(QC1)

            FlowLayoutPanel1.Controls.Add(QC1)

        Else
            MessageBox.Show("You can't add more than two permanent items.")
        End If
    End Sub

End Class
