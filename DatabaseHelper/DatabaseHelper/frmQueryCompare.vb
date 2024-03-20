Imports CustomControllers
Imports System.Data.SqlClient

Public Class FrmQueryCompare
    Private queryControls As New List(Of QueryControl)()
    Private _connection As SqlConnection

    Public Sub New(ByVal connection As SqlConnection)
        InitializeComponent()
        _connection = connection
        InitializeForm()
    End Sub

    Public Sub SetConnection(ByVal connection As SqlConnection)
        _connection = connection
        For Each control In queryControls
            control.Connection = _connection
        Next
    End Sub

    Private Sub InitializeForm()
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
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If queryControls.Count < 6 Then
            Dim newQueryControl As New QueryControl() With {
                .Connection = _connection,
                .IsDeleteButtonVisible = True
            }
            FlowLayoutPanel1.Controls.Add(newQueryControl)
            queryControls.Add(newQueryControl)
        Else
            MessageBox.Show("You can't add more than 6 items.")
        End If
    End Sub

End Class
