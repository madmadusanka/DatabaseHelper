<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQueryCompare
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
        btnAdd = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        btnDelete = New Button()
        cmbComponents = New ComboBox()
        lblSelectYourComponentlbl = New Label()
        pnlQueryCompare = New Panel()
        lblQueryCompare = New Label()
        FlowLayoutPanel1.SuspendLayout()
        pnlQueryCompare.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(1190, 9)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(157, 23)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add New Component"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Location = New Point(9, 68)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1346, 656)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Location = New Point(3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(8, 8)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(1190, 38)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(157, 23)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete Component"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' cmbComponents
        ' 
        cmbComponents.FormattingEnabled = True
        cmbComponents.Location = New Point(993, 38)
        cmbComponents.Name = "cmbComponents"
        cmbComponents.Size = New Size(191, 23)
        cmbComponents.TabIndex = 5
        ' 
        ' lblSelectYourComponentlbl
        ' 
        lblSelectYourComponentlbl.AutoSize = True
        lblSelectYourComponentlbl.Location = New Point(993, 17)
        lblSelectYourComponentlbl.Name = "lblSelectYourComponentlbl"
        lblSelectYourComponentlbl.Size = New Size(130, 15)
        lblSelectYourComponentlbl.TabIndex = 6
        lblSelectYourComponentlbl.Text = "Select your component"
        ' 
        ' pnlQueryCompare
        ' 
        pnlQueryCompare.BackColor = SystemColors.ActiveBorder
        pnlQueryCompare.Controls.Add(lblQueryCompare)
        pnlQueryCompare.Location = New Point(22, 9)
        pnlQueryCompare.Name = "pnlQueryCompare"
        pnlQueryCompare.Size = New Size(961, 52)
        pnlQueryCompare.TabIndex = 7
        ' 
        ' lblQueryCompare
        ' 
        lblQueryCompare.AutoSize = True
        lblQueryCompare.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQueryCompare.Location = New Point(400, 10)
        lblQueryCompare.Name = "lblQueryCompare"
        lblQueryCompare.Size = New Size(166, 30)
        lblQueryCompare.TabIndex = 8
        lblQueryCompare.Text = "Query Compare"
        ' 
        ' frmQueryCompare
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 736)
        Controls.Add(pnlQueryCompare)
        Controls.Add(lblSelectYourComponentlbl)
        Controls.Add(cmbComponents)
        Controls.Add(btnDelete)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnAdd)
        Name = "frmQueryCompare"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        FlowLayoutPanel1.ResumeLayout(False)
        pnlQueryCompare.ResumeLayout(False)
        pnlQueryCompare.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlQueryCompare As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents cmbComponents As ComboBox
    Friend WithEvents lblSelectYourComponentlbl As Label
    Friend WithEvents lblQueryCompare As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
