<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpenTemplates
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        qcMain = New QueryControl()
        SuspendLayout()
        ' 
        ' qcMain
        ' 
        qcMain.Connection = Nothing
        qcMain.Dock = DockStyle.Fill
        qcMain.IsDeleteButtonVisible = False
        qcMain.IsflpCustomComponentVisible = False
        qcMain.IsViewTemplateButtonVisible = True
        qcMain.Location = New Point(0, 0)
        qcMain.Name = "qcMain"
        qcMain.Size = New Size(800, 450)
        qcMain.TabIndex = 0
        ' 
        ' frmOpenTemplates
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(qcMain)
        MinimizeBox = False
        Name = "frmOpenTemplates"
        Text = "Open Templates"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents qcMain As QueryControl
End Class
