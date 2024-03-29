<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaveFileName
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTemplateName = New TextBox()
        lblFileName = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtTemplateName
        ' 
        txtTemplateName.Location = New Point(55, 66)
        txtTemplateName.Name = "txtTemplateName"
        txtTemplateName.Size = New Size(320, 23)
        txtTemplateName.TabIndex = 0
        ' 
        ' lblFileName
        ' 
        lblFileName.AutoSize = True
        lblFileName.Location = New Point(55, 38)
        lblFileName.Name = "lblFileName"
        lblFileName.Size = New Size(147, 15)
        lblFileName.TabIndex = 1
        lblFileName.Text = "Enter Your Template Name"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(250, 105)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 23)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(55, 105)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 23)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FrmSaveFileName
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 181)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(lblFileName)
        Controls.Add(txtTemplateName)
        MaximizeBox = False
        MaximumSize = New Size(448, 220)
        MinimizeBox = False
        MinimumSize = New Size(448, 220)
        Name = "FrmSaveFileName"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Save File Name"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTemplateName As TextBox
    Friend WithEvents lblFileName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
