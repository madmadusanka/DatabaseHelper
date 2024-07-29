Imports CustomControllers
Imports System.Data.SqlClient

Public Class FrmCompareQuery

    Private queryControls As New List(Of QueryControl)()
    Private _connection As SqlConnection

    ' Initializes the form with the provided SqlConnection object
    Public Sub New(ByVal connection As SqlConnection)

        InitializeComponent()
        _connection = connection
        InitializeForm()

    End Sub

    ' Sets the SqlConnection object for query controls
    Public Sub SetConnection(ByVal connection As SqlConnection)

        _connection = connection

        For Each control In queryControls
            control.Connection = _connection
        Next

    End Sub

    'Initializes the form 
    Private Sub InitializeForm()


        Dim permanentItem1 As New QueryControl() With {
        .Connection = _connection
        }

        flpAddCustomComponents.Controls.Add(permanentItem1)
        queryControls.Add(permanentItem1)

        Dim permanentItem2 As New QueryControl() With {
            .Connection = _connection
        }

        flpAddCustomComponents.Controls.Add(permanentItem2)
        queryControls.Add(permanentItem2)

    End Sub

    ' Add new custom components (queryController)
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAddComponent.Click

        If queryControls.Count < 6 Then

            Dim newQueryControl As New QueryControl() With {
                .Connection = _connection,
                .IsDeleteButtonVisible = True
            }

            flpAddCustomComponents.Controls.Add(newQueryControl)
            queryControls.Add(newQueryControl)

        Else
            MessageBox.Show("You can't add more than 6 items.")
        End If

    End Sub

    Private Sub FrmCompareQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
