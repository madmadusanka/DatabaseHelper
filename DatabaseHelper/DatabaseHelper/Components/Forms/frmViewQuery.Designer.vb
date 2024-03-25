<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShowQuery
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
        LBL_Selected_Name = New Label()
        txtShowDefinition = New TextBox()
        lblName = New Label()
        qcShowQuery = New CustomControllers.QueryControl()
        SuspendLayout()
        ' 
        ' LBL_Selected_Name
        ' 
        LBL_Selected_Name.AutoSize = True
        LBL_Selected_Name.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBL_Selected_Name.Location = New Point(105, 51)
        LBL_Selected_Name.Name = "LBL_Selected_Name"
        LBL_Selected_Name.Size = New Size(0, 20)
        LBL_Selected_Name.TabIndex = 1
        ' 
        ' txtShowDefinition
        ' 
        txtShowDefinition.Location = New Point(41, 113)
        txtShowDefinition.Multiline = True
        txtShowDefinition.Name = "txtShowDefinition"
        txtShowDefinition.ScrollBars = ScrollBars.Both
        txtShowDefinition.Size = New Size(658, 557)
        txtShowDefinition.TabIndex = 2
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(41, 51)
        lblName.Name = "lblName"
        lblName.Size = New Size(58, 20)
        lblName.TabIndex = 3
        lblName.Text = "Name :"
        ' 
        ' qcShowQuery
        ' 
        qcShowQuery.Connection = Nothing
        qcShowQuery.IsDeleteButtonVisible = False
        qcShowQuery.Location = New Point(726, 35)
        qcShowQuery.Name = "qcShowQuery"
        qcShowQuery.Size = New Size(632, 646)
        qcShowQuery.TabIndex = 4
        ' 
        ' FrmShowQuery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 729)
        Controls.Add(qcShowQuery)
        Controls.Add(lblName)
        Controls.Add(txtShowDefinition)
        Controls.Add(LBL_Selected_Name)
        Name = "FrmShowQuery"
        Text = "Show Query"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LBL_Selected_Name As Label
    Friend WithEvents txtShowDefinition As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents qcShowQuery As CustomControllers.QueryControl
End Class
