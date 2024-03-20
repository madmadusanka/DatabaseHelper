Imports DatabaseHelper

Public Class FormViewer
    Implements IFormViewer

    Public Sub ShowLandingPageIfNotOpen() Implements IFormViewer.ShowLandingPageIfNotOpen
        Dim formToOpen As FrmLandingPage = Nothing

        ' Iterate through the open forms collection
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FrmLandingPage Then
                ' The form is already open, set formToOpen and exit the loop
                formToOpen = DirectCast(frm, FrmLandingPage)
                Exit For
            End If
        Next

        ' If the form is not already open, create a new instance
        If formToOpen Is Nothing Then
            formToOpen = New FrmLandingPage()
        End If

        ' Show the form or bring it to the front
        If Not formToOpen.Visible Then
            formToOpen.Show()
        Else
            formToOpen.ProgrammaticallyClickConnectButton()
        End If
    End Sub
End Class
