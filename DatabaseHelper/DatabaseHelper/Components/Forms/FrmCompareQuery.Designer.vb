<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompareQuery
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
        flpAddCustomComponents = New FlowLayoutPanel()
        pnlQueryCompare = New Panel()
        lblCompareQuery = New Label()
        btnAddComponent = New Button()
        pnlQueryCompare.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpAddCustomComponents
        ' 
        flpAddCustomComponents.AutoScroll = True
        flpAddCustomComponents.Location = New Point(9, 68)
        flpAddCustomComponents.Name = "flpAddCustomComponents"
        flpAddCustomComponents.Size = New Size(1346, 656)
        flpAddCustomComponents.TabIndex = 2
        ' 
        ' pnlQueryCompare
        ' 
        pnlQueryCompare.BackColor = SystemColors.ActiveBorder
        pnlQueryCompare.Controls.Add(lblCompareQuery)
        pnlQueryCompare.Location = New Point(175, 9)
        pnlQueryCompare.Name = "pnlQueryCompare"
        pnlQueryCompare.Size = New Size(1175, 52)
        pnlQueryCompare.TabIndex = 7
        ' 
        ' lblCompareQuery
        ' 
        lblCompareQuery.AutoSize = True
        lblCompareQuery.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompareQuery.Location = New Point(457, 10)
        lblCompareQuery.Name = "lblCompareQuery"
        lblCompareQuery.Size = New Size(166, 30)
        lblCompareQuery.TabIndex = 8
        lblCompareQuery.Text = "Compare Query"
        ' 
        ' btnAddComponent
        ' 
        btnAddComponent.Location = New Point(14, 12)
        btnAddComponent.Name = "btnAddComponent"
        btnAddComponent.Size = New Size(148, 49)
        btnAddComponent.TabIndex = 8
        btnAddComponent.Text = "Add Component"
        btnAddComponent.UseVisualStyleBackColor = True
        ' 
        ' FrmCompareQuery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 736)
        Controls.Add(btnAddComponent)
        Controls.Add(pnlQueryCompare)
        Controls.Add(flpAddCustomComponents)
        Name = "FrmCompareQuery"
        Text = "Query Compare"


        WindowState = FormWindowState.Maximized
        pnlQueryCompare.ResumeLayout(False)
        pnlQueryCompare.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlQueryCompare As Panel
    Friend WithEvents flpAddCustomComponents As FlowLayoutPanel
    Friend WithEvents lblCompareQuery As Label
    Friend WithEvents btnAddComponent As Button
End Class
