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
        cmbComponents.Items.Add("QueryControl1")
        cmbComponents.Items.Add("QueryControl2")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If queryControls.Count >= 2 Then
            ' You can't add more than two permanent items
            Dim QC1 As New CustomControllers.QueryControl()
            QC1.Connection = _connection

            ' Add b1 to the list of QueryControl instances
            queryControls.Add(QC1)

            FlowLayoutPanel1.Controls.Add(QC1)

            ' Update the ComboBox to reflect the added QueryControl instance
            cmbComponents.Items.Add("QueryControl " & queryControls.Count)
        Else
            MessageBox.Show("You can't add more than two permanent items.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if an item is selected in the ComboBox and not one of the permanent items
        If cmbComponents.SelectedIndex >= 2 AndAlso cmbComponents.SelectedIndex - 2 < queryControls.Count Then
            ' Calculate the correct index in the queryControls list
            Dim indexToRemove As Integer = cmbComponents.SelectedIndex - 2

            ' Remove the selected QueryControl instance from the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Remove(queryControls(indexToRemove))

            ' Remove the corresponding item from the ComboBox
            cmbComponents.Items.RemoveAt(cmbComponents.SelectedIndex)

            ' Remove the selected QueryControl instance from the list
            queryControls.RemoveAt(indexToRemove)
        Else
            MessageBox.Show("You can't delete QueryControl1 and QueryControl2 items.")
        End If
    End Sub

End Class
