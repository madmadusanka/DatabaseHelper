<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryControl))
        fastColoredTextBox = New FastColoredTextBoxNS.FastColoredTextBox()
        QueryResultDataGridView = New DataGridView()
        ExecuteQueryButton = New Button()
        CType(fastColoredTextBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(QueryResultDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' fastColoredTextBox
        ' 
        fastColoredTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        fastColoredTextBox.AutoCompleteBracketsList = New Char() {"("c, ")"c, "{"c, "}"c, "["c, "]"c, """"c, """"c, "'"c, "'"c}
        fastColoredTextBox.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & vbCrLf & "^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);"
        fastColoredTextBox.AutoScrollMinSize = New Size(27, 14)
        fastColoredTextBox.BackBrush = Nothing
        fastColoredTextBox.CharHeight = 14
        fastColoredTextBox.CharWidth = 8
        fastColoredTextBox.DisabledColor = Color.FromArgb(CByte(100), CByte(180), CByte(180), CByte(180))
        fastColoredTextBox.Font = New Font("Courier New", 9.75F)
        fastColoredTextBox.Hotkeys = resources.GetString("fastColoredTextBox.Hotkeys")
        fastColoredTextBox.IsReplaceMode = False
        fastColoredTextBox.Location = New Point(0, 0)
        fastColoredTextBox.Name = "fastColoredTextBox"
        fastColoredTextBox.Paddings = New Padding(0)
        fastColoredTextBox.SelectionColor = Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        fastColoredTextBox.ServiceColors = CType(resources.GetObject("fastColoredTextBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        fastColoredTextBox.ServiceLinesColor = Color.Gray
        fastColoredTextBox.Size = New Size(660, 278)
        fastColoredTextBox.TabIndex = 0
        fastColoredTextBox.Zoom = 100
        ' 
        ' QueryResultDataGridView
        ' 
        QueryResultDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        QueryResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        QueryResultDataGridView.Location = New Point(0, 318)
        QueryResultDataGridView.Name = "QueryResultDataGridView"
        QueryResultDataGridView.Size = New Size(660, 255)
        QueryResultDataGridView.TabIndex = 2
        ' 
        ' ExecuteQueryButton
        ' 
        ExecuteQueryButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ExecuteQueryButton.Location = New Point(531, 287)
        ExecuteQueryButton.Name = "ExecuteQueryButton"
        ExecuteQueryButton.Size = New Size(109, 23)
        ExecuteQueryButton.TabIndex = 3
        ExecuteQueryButton.Text = "Execute"
        ExecuteQueryButton.UseVisualStyleBackColor = True
        ' 
        ' QueryControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ExecuteQueryButton)
        Controls.Add(QueryResultDataGridView)
        Controls.Add(fastColoredTextBox)
        Name = "QueryControl"
        Size = New Size(660, 573)
        CType(fastColoredTextBox, ComponentModel.ISupportInitialize).EndInit()
        CType(QueryResultDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents fastColoredTextBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QueryResultDataGridView As DataGridView
    Friend WithEvents ExecuteQueryButton As Button

End Class
