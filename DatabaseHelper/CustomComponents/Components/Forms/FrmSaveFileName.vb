Imports System.IO
Imports DatabaseHelper

Public Class FrmSaveFileName

    Public Property FileName As String

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        FileName = txtTemplateName.Text

        Dim validationResult As String = ValidateFileName()
        If Not String.IsNullOrEmpty(validationResult) Then
            MessageBox.Show(validationResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Function ContainsOnlySpaces(input As String) As Boolean

        Dim trimmedString As String = input.Trim()
        Return trimmedString.Length = 0

    End Function

    Private Function ValidateFileName() As String

        Dim fileName As String = txtTemplateName.Text.Trim()

        If String.IsNullOrWhiteSpace(fileName) Then
            Return "Please enter a file name."
        End If

        Dim invalidChars As Char() = Path.GetInvalidFileNameChars()
        If fileName.IndexOfAny(invalidChars) <> -1 Then
            Return "Please enter a valid file name."
        End If

        Return String.Empty
    End Function

    Private Sub TxtTemplateName_TextChanged(sender As Object, e As EventArgs) Handles txtTemplateName.TextChanged
        ValidateFileName()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.No
        Me.Close()

    End Sub
End Class