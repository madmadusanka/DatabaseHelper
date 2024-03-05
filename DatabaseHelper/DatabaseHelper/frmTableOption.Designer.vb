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
        dgvTableSchema1 = New DataGridView()
        dgvTableSchema2 = New DataGridView()
        dgvTableSchema3 = New DataGridView()
        dgvTableSchema4 = New DataGridView()
        dgvTableSchema5 = New DataGridView()
        dgvTableSchema6 = New DataGridView()
        dgvTableSchema7 = New DataGridView()
        QueryExecuterTableOption = New CustomControllers.QueryControl()
        pnlSelectTriggerlbl.SuspendLayout()
        CType(dgvTableSchema1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema3, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema4, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema6, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnViewTrigger
        ' 
        btnViewTrigger.Location = New Point(1079, 81)
        btnViewTrigger.Name = "btnViewTrigger"
        btnViewTrigger.Size = New Size(259, 23)
        btnViewTrigger.TabIndex = 19
        btnViewTrigger.Text = "Show Trigger"
        btnViewTrigger.UseVisualStyleBackColor = True
        ' 
        ' cmbSelectTrigger
        ' 
        cmbSelectTrigger.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectTrigger.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectTrigger.FormattingEnabled = True
        cmbSelectTrigger.Location = New Point(1079, 52)
        cmbSelectTrigger.Name = "cmbSelectTrigger"
        cmbSelectTrigger.Size = New Size(260, 23)
        cmbSelectTrigger.TabIndex = 18
        ' 
        ' pnlSelectTriggerlbl
        ' 
        pnlSelectTriggerlbl.BackColor = SystemColors.ControlDark
        pnlSelectTriggerlbl.Controls.Add(lblSelectTriggerlbl)
        pnlSelectTriggerlbl.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectTriggerlbl.Location = New Point(1079, 12)
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
        ' dgvTableSchema1
        ' 
        dgvTableSchema1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema1.Location = New Point(21, 12)
        dgvTableSchema1.Name = "dgvTableSchema1"
        dgvTableSchema1.Size = New Size(702, 78)
        dgvTableSchema1.TabIndex = 20
        ' 
        ' dgvTableSchema2
        ' 
        dgvTableSchema2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema2.Location = New Point(21, 94)
        dgvTableSchema2.Name = "dgvTableSchema2"
        dgvTableSchema2.Size = New Size(702, 131)
        dgvTableSchema2.TabIndex = 21
        ' 
        ' dgvTableSchema3
        ' 
        dgvTableSchema3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema3.Location = New Point(21, 228)
        dgvTableSchema3.Name = "dgvTableSchema3"
        dgvTableSchema3.Size = New Size(702, 102)
        dgvTableSchema3.TabIndex = 22
        ' 
        ' dgvTableSchema4
        ' 
        dgvTableSchema4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema4.Location = New Point(21, 336)
        dgvTableSchema4.Name = "dgvTableSchema4"
        dgvTableSchema4.Size = New Size(702, 78)
        dgvTableSchema4.TabIndex = 23
        ' 
        ' dgvTableSchema5
        ' 
        dgvTableSchema5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema5.Location = New Point(21, 419)
        dgvTableSchema5.Name = "dgvTableSchema5"
        dgvTableSchema5.Size = New Size(702, 78)
        dgvTableSchema5.TabIndex = 24
        ' 
        ' dgvTableSchema6
        ' 
        dgvTableSchema6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema6.Location = New Point(21, 501)
        dgvTableSchema6.Name = "dgvTableSchema6"
        dgvTableSchema6.Size = New Size(702, 78)
        dgvTableSchema6.TabIndex = 25
        ' 
        ' dgvTableSchema7
        ' 
        dgvTableSchema7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema7.Location = New Point(21, 584)
        dgvTableSchema7.Name = "dgvTableSchema7"
        dgvTableSchema7.Size = New Size(702, 129)
        dgvTableSchema7.TabIndex = 26
        ' 
        ' QueryExecuter
        ' 
        QueryExecuterTableOption.Connection = Nothing
        QueryExecuterTableOption.Location = New Point(739, 121)
        QueryExecuterTableOption.Name = "QueryExecuter"
        QueryExecuterTableOption.Size = New Size(599, 592)
        QueryExecuterTableOption.TabIndex = 27
        ' 
        ' frmTableOption
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1356, 749)
        Controls.Add(QueryExecuterTableOption)
        Controls.Add(dgvTableSchema7)
        Controls.Add(dgvTableSchema6)
        Controls.Add(dgvTableSchema5)
        Controls.Add(dgvTableSchema4)
        Controls.Add(dgvTableSchema3)
        Controls.Add(dgvTableSchema2)
        Controls.Add(dgvTableSchema1)
        Controls.Add(btnViewTrigger)
        Controls.Add(cmbSelectTrigger)
        Controls.Add(pnlSelectTriggerlbl)
        Name = "frmTableOption"
        Text = "Table Options"
        WindowState = FormWindowState.Maximized
        pnlSelectTriggerlbl.ResumeLayout(False)
        pnlSelectTriggerlbl.PerformLayout()
        CType(dgvTableSchema1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema3, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema4, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema6, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewTrigger As Button
    Friend WithEvents cmbSelectTrigger As ComboBox
    Friend WithEvents pnlSelectTriggerlbl As Panel
    Friend WithEvents lblSelectTriggerlbl As Label
    Friend WithEvents dgvTableSchema1 As DataGridView
    Friend WithEvents dgvTableSchema2 As DataGridView
    Friend WithEvents dgvTableSchema3 As DataGridView
    Friend WithEvents dgvTableSchema4 As DataGridView
    Friend WithEvents dgvTableSchema5 As DataGridView
    Friend WithEvents dgvTableSchema6 As DataGridView
    Friend WithEvents dgvTableSchema7 As DataGridView
    Friend WithEvents QueryExecuterTableOption As CustomControllers.QueryControl
End Class
