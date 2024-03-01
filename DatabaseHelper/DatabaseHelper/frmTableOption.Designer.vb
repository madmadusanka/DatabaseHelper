<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableOption
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
        btnViewTrigger = New Button()
        cmbSelectTrigger = New ComboBox()
        pnlSelectTriggerlbl = New Panel()
        lblSelectTriggerlbl = New Label()
        pnlSelectTriggerlbl.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnViewTrigger
        ' 
        btnViewTrigger.Location = New Point(57, 123)
        btnViewTrigger.Name = "btnViewTrigger"
        btnViewTrigger.Size = New Size(259, 23)
        btnViewTrigger.TabIndex = 19
        btnViewTrigger.Text = "Show View Trigger"
        btnViewTrigger.UseVisualStyleBackColor = True
        ' 
        ' cmbSelectTrigger
        ' 
        cmbSelectTrigger.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectTrigger.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectTrigger.FormattingEnabled = True
        cmbSelectTrigger.Location = New Point(57, 94)
        cmbSelectTrigger.Name = "cmbSelectTrigger"
        cmbSelectTrigger.Size = New Size(260, 23)
        cmbSelectTrigger.TabIndex = 18
        ' 
        ' pnlSelectTriggerlbl
        ' 
        pnlSelectTriggerlbl.BackColor = SystemColors.ControlDark
        pnlSelectTriggerlbl.Controls.Add(lblSelectTriggerlbl)
        pnlSelectTriggerlbl.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectTriggerlbl.Location = New Point(57, 54)
        pnlSelectTriggerlbl.Name = "pnlSelectTriggerlbl"
        pnlSelectTriggerlbl.Size = New Size(260, 34)
        pnlSelectTriggerlbl.TabIndex = 17
        ' 
        ' lblSelectTriggerlbl
        ' 
        lblSelectTriggerlbl.AutoSize = True
        lblSelectTriggerlbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectTriggerlbl.Location = New Point(78, 9)
        lblSelectTriggerlbl.Name = "lblSelectTriggerlbl"
        lblSelectTriggerlbl.Size = New Size(92, 17)
        lblSelectTriggerlbl.TabIndex = 2
        lblSelectTriggerlbl.Text = "Select Trigger"
        ' 
        ' frmTableOption
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnViewTrigger)
        Controls.Add(cmbSelectTrigger)
        Controls.Add(pnlSelectTriggerlbl)
        Name = "frmTableOption"
        Text = "Table Options"
        WindowState = FormWindowState.Maximized
        pnlSelectTriggerlbl.ResumeLayout(False)
        pnlSelectTriggerlbl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewTrigger As Button
    Friend WithEvents cmbSelectTrigger As ComboBox
    Friend WithEvents pnlSelectTriggerlbl As Panel
    Friend WithEvents lblSelectTriggerlbl As Label
End Class
