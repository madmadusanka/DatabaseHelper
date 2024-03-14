<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQueryCompare
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        pnlQueryCompare = New Panel()
        lblQueryCompare = New Label()
        btnAdd = New Button()
        FlowLayoutPanel1.SuspendLayout()
        pnlQueryCompare.SuspendLayout()
        SuspendLayout()
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
        ' pnlQueryCompare
        ' 
        pnlQueryCompare.BackColor = SystemColors.ActiveBorder
        pnlQueryCompare.Controls.Add(lblQueryCompare)
        pnlQueryCompare.Location = New Point(175, 9)
        pnlQueryCompare.Name = "pnlQueryCompare"
        pnlQueryCompare.Size = New Size(1175, 52)
        pnlQueryCompare.TabIndex = 7
        ' 
        ' lblQueryCompare
        ' 
        lblQueryCompare.AutoSize = True
        lblQueryCompare.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQueryCompare.Location = New Point(457, 10)
        lblQueryCompare.Name = "lblQueryCompare"
        lblQueryCompare.Size = New Size(166, 30)
        lblQueryCompare.TabIndex = 8
        lblQueryCompare.Text = "Query Compare"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(14, 12)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(148, 49)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' frmQueryCompare
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 736)
        Controls.Add(btnAdd)
        Controls.Add(pnlQueryCompare)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmQueryCompare"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        FlowLayoutPanel1.ResumeLayout(False)
        pnlQueryCompare.ResumeLayout(False)
        pnlQueryCompare.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlQueryCompare As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblQueryCompare As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAdd As Button
End Class
