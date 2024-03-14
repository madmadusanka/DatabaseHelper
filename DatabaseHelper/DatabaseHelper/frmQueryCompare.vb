Imports CustomControllers
Imports System.Data.SqlClient

Public Class FrmQueryCompare
    ' Declare a List to store references to the dynamically generated QueryControl instances
    Private queryControls As New List(Of QueryControl)

    Private _connection As SqlConnection

    ' Constructor modified to accept an existing SqlConnection
    Public Sub New(ByVal connection As SqlConnection)
        InitializeComponent()

        ' Set the connection
        _connection = connection

    End Sub

    Private Sub FrmQueryCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add two permanently added items
        Dim permanentItem1 As New QueryControl() With {
        .Connection = _connection ' Use the existing connection
        }

        FlowLayoutPanel1.Controls.Add(permanentItem1)
        queryControls.Add(permanentItem1)

        Dim permanentItem2 As New QueryControl() With {
        .Connection = _connection ' Use the existing connection
        }
        FlowLayoutPanel1.Controls.Add(permanentItem2)
        queryControls.Add(permanentItem2)

        ' Update the ComboBox to reflect the added permanent items
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If queryControls.Count >= 2 Then
            ' You can't add more than two permanent items
            Dim QC1 As New CustomControllers.QueryControl() With {
            .Connection = _connection,
            .IsDeleteButtonVisible = True
            }

            ' Add b1 to the list of QueryControl instances
            queryControls.Add(QC1)

            FlowLayoutPanel1.Controls.Add(QC1)

        Else
            MessageBox.Show("You can't add more than two permanent items.")
        End If
    End Sub

End Class
