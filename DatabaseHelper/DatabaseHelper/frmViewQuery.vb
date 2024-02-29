Public Class frmViewQuery
    Public Sub New(ByVal viewName As String, ByVal viewDefinition As String)
        InitializeComponent()

        ' Display view name and definition
        lblViewName.Text = viewName
        txtViewDefinition.Text = viewDefinition
    End Sub

End Class