<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewQuery
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
        lblViewName = New Label()
        txtViewDefinition = New TextBox()
        lblnamelbl = New Label()
        QueryControlfrmViewQuery = New CustomControllers.QueryControl()
        SuspendLayout()
        ' 
        ' lblViewName
        ' 
        lblViewName.AutoSize = True
        lblViewName.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblViewName.Location = New Point(105, 51)
        lblViewName.Name = "lblViewName"
        lblViewName.Size = New Size(0, 20)
        lblViewName.TabIndex = 1
        ' 
        ' txtViewDefinition
        ' 
        txtViewDefinition.Location = New Point(41, 113)
        txtViewDefinition.Multiline = True
        txtViewDefinition.Name = "txtViewDefinition"
        txtViewDefinition.ScrollBars = ScrollBars.Both
        txtViewDefinition.Size = New Size(658, 557)
        txtViewDefinition.TabIndex = 2
        ' 
        ' lblnamelbl
        ' 
        lblnamelbl.AutoSize = True
        lblnamelbl.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblnamelbl.Location = New Point(41, 51)
        lblnamelbl.Name = "lblnamelbl"
        lblnamelbl.Size = New Size(58, 20)
        lblnamelbl.TabIndex = 3
        lblnamelbl.Text = "Name :"
        ' 
        ' QueryControlfrmViewQuery
        ' 
        QueryControlfrmViewQuery.Connection = Nothing
        QueryControlfrmViewQuery.Location = New Point(726, 35)
        QueryControlfrmViewQuery.Name = "QueryControlfrmViewQuery"
        QueryControlfrmViewQuery.Size = New Size(632, 646)
        QueryControlfrmViewQuery.TabIndex = 4
        ' 
        ' frmViewQuery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 729)
        Controls.Add(QueryControlfrmViewQuery)
        Controls.Add(lblnamelbl)
        Controls.Add(txtViewDefinition)
        Controls.Add(lblViewName)
        Name = "frmViewQuery"
        Text = "View Query"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblViewName As Label
    Friend WithEvents txtViewDefinition As TextBox
    Friend WithEvents lblnamelbl As Label
    Friend WithEvents QueryControlfrmViewQuery As CustomControllers.QueryControl
End Class
