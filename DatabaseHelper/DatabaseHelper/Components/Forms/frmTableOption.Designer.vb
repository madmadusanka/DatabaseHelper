<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTableOption
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
        pnlSelectTrigger = New Panel()
        lblSelectTrigger = New Label()
        dgvTableSchema1 = New DataGridView()
        dgvTableSchema2 = New DataGridView()
        dgvTableSchema3 = New DataGridView()
        dgvTableSchema4 = New DataGridView()
        dgvTableSchema5 = New DataGridView()
        dgvTableSchema6 = New DataGridView()
        dgvTableSchema7 = New DataGridView()
        qcTableOption = New CustomControllers.QueryControl()
        pnlTableStructure = New Panel()
        pnlTableStructure_ = New Panel()
        lblTableStructure = New Label()
        pnlSelectTrigger.SuspendLayout()
        CType(dgvTableSchema1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema3, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema4, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema6, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTableSchema7, ComponentModel.ISupportInitialize).BeginInit()
        pnlTableStructure.SuspendLayout()
        pnlTableStructure_.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnViewTrigger
        ' 
        btnViewTrigger.Location = New Point(19, 90)
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
        cmbSelectTrigger.Location = New Point(19, 61)
        cmbSelectTrigger.Name = "cmbSelectTrigger"
        cmbSelectTrigger.Size = New Size(260, 23)
        cmbSelectTrigger.TabIndex = 18
        ' 
        ' pnlSelectTrigger
        ' 
        pnlSelectTrigger.BackColor = SystemColors.ControlDark
        pnlSelectTrigger.Controls.Add(lblSelectTrigger)
        pnlSelectTrigger.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectTrigger.Location = New Point(19, 21)
        pnlSelectTrigger.Name = "pnlSelectTrigger"
        pnlSelectTrigger.Size = New Size(260, 34)
        pnlSelectTrigger.TabIndex = 17
        ' 
        ' lblSelectTrigger
        ' 
        lblSelectTrigger.AutoSize = True
        lblSelectTrigger.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectTrigger.Location = New Point(78, 9)
        lblSelectTrigger.Name = "lblSelectTrigger"
        lblSelectTrigger.Size = New Size(92, 17)
        lblSelectTrigger.TabIndex = 2
        lblSelectTrigger.Text = "Select Trigger"
        ' 
        ' dgvTableSchema1
        ' 
        dgvTableSchema1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema1.Location = New Point(7, 5)
        dgvTableSchema1.Name = "dgvTableSchema1"
        dgvTableSchema1.Size = New Size(702, 78)
        dgvTableSchema1.TabIndex = 20
        ' 
        ' dgvTableSchema2
        ' 
        dgvTableSchema2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema2.Location = New Point(8, 89)
        dgvTableSchema2.Name = "dgvTableSchema2"
        dgvTableSchema2.Size = New Size(702, 131)
        dgvTableSchema2.TabIndex = 21
        ' 
        ' dgvTableSchema3
        ' 
        dgvTableSchema3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema3.Location = New Point(7, 223)
        dgvTableSchema3.Name = "dgvTableSchema3"
        dgvTableSchema3.Size = New Size(702, 102)
        dgvTableSchema3.TabIndex = 22
        ' 
        ' dgvTableSchema4
        ' 
        dgvTableSchema4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema4.Location = New Point(7, 329)
        dgvTableSchema4.Name = "dgvTableSchema4"
        dgvTableSchema4.Size = New Size(702, 78)
        dgvTableSchema4.TabIndex = 23
        ' 
        ' dgvTableSchema5
        ' 
        dgvTableSchema5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema5.Location = New Point(7, 412)
        dgvTableSchema5.Name = "dgvTableSchema5"
        dgvTableSchema5.Size = New Size(702, 78)
        dgvTableSchema5.TabIndex = 24
        ' 
        ' dgvTableSchema6
        ' 
        dgvTableSchema6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema6.Location = New Point(7, 495)
        dgvTableSchema6.Name = "dgvTableSchema6"
        dgvTableSchema6.Size = New Size(702, 78)
        dgvTableSchema6.TabIndex = 25
        ' 
        ' dgvTableSchema7
        ' 
        dgvTableSchema7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTableSchema7.Location = New Point(7, 579)
        dgvTableSchema7.Name = "dgvTableSchema7"
        dgvTableSchema7.Size = New Size(702, 129)
        dgvTableSchema7.TabIndex = 26
        ' 
        ' qcTableOption
        ' 
        qcTableOption.Connection = Nothing
        qcTableOption.IsDeleteButtonVisible = False
        qcTableOption.Location = New Point(747, 12)
        qcTableOption.Name = "qcTableOption"
        qcTableOption.Size = New Size(591, 701)
        qcTableOption.TabIndex = 27
        ' 
        ' pnlTableStructure
        ' 
        pnlTableStructure.AutoScroll = True
        pnlTableStructure.Controls.Add(dgvTableSchema2)
        pnlTableStructure.Controls.Add(dgvTableSchema7)
        pnlTableStructure.Controls.Add(dgvTableSchema1)
        pnlTableStructure.Controls.Add(dgvTableSchema6)
        pnlTableStructure.Controls.Add(dgvTableSchema3)
        pnlTableStructure.Controls.Add(dgvTableSchema5)
        pnlTableStructure.Controls.Add(dgvTableSchema4)
        pnlTableStructure.Location = New Point(12, 192)
        pnlTableStructure.Name = "pnlTableStructure"
        pnlTableStructure.Size = New Size(729, 562)
        pnlTableStructure.TabIndex = 28
        ' 
        ' pnlTableStructure_
        ' 
        pnlTableStructure_.BackColor = SystemColors.ControlDark
        pnlTableStructure_.Controls.Add(lblTableStructure)
        pnlTableStructure_.ForeColor = SystemColors.ActiveCaptionText
        pnlTableStructure_.Location = New Point(20, 132)
        pnlTableStructure_.Name = "pnlTableStructure_"
        pnlTableStructure_.Size = New Size(721, 54)
        pnlTableStructure_.TabIndex = 18
        ' 
        ' lblTableStructure
        ' 
        lblTableStructure.AutoSize = True
        lblTableStructure.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTableStructure.Location = New Point(226, 16)
        lblTableStructure.Name = "lblTableStructure"
        lblTableStructure.Size = New Size(147, 25)
        lblTableStructure.TabIndex = 2
        lblTableStructure.Text = "Table Structure"
        ' 
        ' FrmTableOption
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1356, 691)
        Controls.Add(pnlTableStructure_)
        Controls.Add(qcTableOption)
        Controls.Add(btnViewTrigger)
        Controls.Add(cmbSelectTrigger)
        Controls.Add(pnlSelectTrigger)
        Controls.Add(pnlTableStructure)
        Name = "FrmTableOption"
        Text = "Table Options"
        WindowState = FormWindowState.Maximized
        pnlSelectTrigger.ResumeLayout(False)
        pnlSelectTrigger.PerformLayout()
        CType(dgvTableSchema1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema3, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema4, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema6, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTableSchema7, ComponentModel.ISupportInitialize).EndInit()
        pnlTableStructure.ResumeLayout(False)
        pnlTableStructure_.ResumeLayout(False)
        pnlTableStructure_.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewTrigger As Button
    Friend WithEvents cmbSelectTrigger As ComboBox
    Friend WithEvents pnlSelectTrigger As Panel
    Friend WithEvents lblSelectTrigger As Label
    Friend WithEvents dgvTableSchema1 As DataGridView
    Friend WithEvents dgvTableSchema2 As DataGridView
    Friend WithEvents dgvTableSchema3 As DataGridView
    Friend WithEvents dgvTableSchema4 As DataGridView
    Friend WithEvents dgvTableSchema5 As DataGridView
    Friend WithEvents dgvTableSchema6 As DataGridView
    Friend WithEvents dgvTableSchema7 As DataGridView
    Friend WithEvents qcTableOption As CustomControllers.QueryControl
    Friend WithEvents pnlTableStructure As Panel
    Friend WithEvents pnlTableStructure_ As Panel
    Friend WithEvents lblTableStructure As Label
End Class
