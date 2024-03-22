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
        QueryResultDataGridView = New DataGridView()
        ExecuteQueryButton = New Button()
        btnDeleteThis = New Button()
        tabControlQuery = New TabControl()
        tabResult = New TabPage()
        tabMessage = New TabPage()
        txtQueryMessage = New TextBox()
        btnsavequery = New Button()
        flpCustomComponent = New FlowLayoutPanel()
        fastColoredTextBox = New FastColoredTextBoxNS.FastColoredTextBox()
        BtnQueryList = New Button()
        CType(QueryResultDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        tabControlQuery.SuspendLayout()
        tabResult.SuspendLayout()
        tabMessage.SuspendLayout()
        CType(fastColoredTextBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' QueryResultDataGridView
        ' 
        QueryResultDataGridView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        QueryResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        QueryResultDataGridView.Location = New Point(0, 0)
        QueryResultDataGridView.Name = "QueryResultDataGridView"
        QueryResultDataGridView.Size = New Size(634, 194)
        QueryResultDataGridView.TabIndex = 2
        ' 
        ' ExecuteQueryButton
        ' 
        ExecuteQueryButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ExecuteQueryButton.Location = New Point(542, 304)
        ExecuteQueryButton.Name = "ExecuteQueryButton"
        ExecuteQueryButton.Size = New Size(109, 23)
        ExecuteQueryButton.TabIndex = 3
        ExecuteQueryButton.Text = "Execute"
        ExecuteQueryButton.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteThis
        ' 
        btnDeleteThis.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeleteThis.Location = New Point(18, 303)
        btnDeleteThis.Name = "btnDeleteThis"
        btnDeleteThis.Size = New Size(109, 23)
        btnDeleteThis.TabIndex = 4
        btnDeleteThis.Text = "Delete this"
        btnDeleteThis.UseVisualStyleBackColor = True
        btnDeleteThis.Visible = False
        ' 
        ' tabControlQuery
        ' 
        tabControlQuery.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabControlQuery.Controls.Add(tabResult)
        tabControlQuery.Controls.Add(tabMessage)
        tabControlQuery.Location = New Point(18, 333)
        tabControlQuery.Name = "tabControlQuery"
        tabControlQuery.SelectedIndex = 0
        tabControlQuery.Size = New Size(642, 222)
        tabControlQuery.TabIndex = 5
        ' 
        ' tabResult
        ' 
        tabResult.AccessibleRole = AccessibleRole.None
        tabResult.Controls.Add(QueryResultDataGridView)
        tabResult.Location = New Point(4, 24)
        tabResult.Name = "tabResult"
        tabResult.Padding = New Padding(3)
        tabResult.Size = New Size(634, 194)
        tabResult.TabIndex = 0
        tabResult.Text = "Results"
        tabResult.UseVisualStyleBackColor = True
        ' 
        ' tabMessage
        ' 
        tabMessage.Controls.Add(txtQueryMessage)
        tabMessage.Location = New Point(4, 24)
        tabMessage.Name = "tabMessage"
        tabMessage.Padding = New Padding(3)
        tabMessage.Size = New Size(634, 194)
        tabMessage.TabIndex = 1
        tabMessage.Text = "Message"
        tabMessage.UseVisualStyleBackColor = True
        ' 
        ' txtQueryMessage
        ' 
        txtQueryMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtQueryMessage.Location = New Point(0, 0)
        txtQueryMessage.Multiline = True
        txtQueryMessage.Name = "txtQueryMessage"
        txtQueryMessage.Size = New Size(635, 239)
        txtQueryMessage.TabIndex = 0
        ' 
        ' btnsavequery
        ' 
        btnsavequery.Location = New Point(22, 5)
        btnsavequery.Name = "btnsavequery"
        btnsavequery.Size = New Size(105, 24)
        btnsavequery.TabIndex = 6
        btnsavequery.Text = "Save Query"
        btnsavequery.UseVisualStyleBackColor = True
        ' 
        ' flpCustomComponent
        ' 
        flpCustomComponent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpCustomComponent.AutoScroll = True
        flpCustomComponent.Location = New Point(133, 3)
        flpCustomComponent.Name = "flpCustomComponent"
        flpCustomComponent.Size = New Size(524, 112)
        flpCustomComponent.TabIndex = 8
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
        fastColoredTextBox.Location = New Point(0, 75)
        fastColoredTextBox.Name = "fastColoredTextBox"
        fastColoredTextBox.Paddings = New Padding(0)
        fastColoredTextBox.SelectionColor = Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        fastColoredTextBox.ServiceColors = CType(resources.GetObject("fastColoredTextBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        fastColoredTextBox.ServiceLinesColor = Color.Gray
        fastColoredTextBox.Size = New Size(660, 222)
        fastColoredTextBox.TabIndex = 0
        fastColoredTextBox.Zoom = 100
        ' 
        ' BtnQueryList
        ' 
        BtnQueryList.Location = New Point(22, 33)
        BtnQueryList.Name = "BtnQueryList"
        BtnQueryList.Size = New Size(105, 24)
        BtnQueryList.TabIndex = 9
        BtnQueryList.Text = "Query List"
        BtnQueryList.UseVisualStyleBackColor = True
        ' 
        ' QueryControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BtnQueryList)
        Controls.Add(fastColoredTextBox)
        Controls.Add(flpCustomComponent)
        Controls.Add(btnsavequery)
        Controls.Add(tabControlQuery)
        Controls.Add(btnDeleteThis)
        Controls.Add(ExecuteQueryButton)
        Name = "QueryControl"
        Size = New Size(660, 573)
        CType(QueryResultDataGridView, ComponentModel.ISupportInitialize).EndInit()
        tabControlQuery.ResumeLayout(False)
        tabResult.ResumeLayout(False)
        tabMessage.ResumeLayout(False)
        tabMessage.PerformLayout()
        CType(fastColoredTextBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QueryResultDataGridView As DataGridView
    Friend WithEvents ExecuteQueryButton As Button
    Friend WithEvents btnDeleteThis As Button
    Friend WithEvents tabControlQuery As TabControl
    Friend WithEvents tabResult As TabPage
    Friend WithEvents tabMessage As TabPage
    Friend WithEvents txtQueryMessage As TextBox
    Friend WithEvents btnsavequery As Button
    Friend WithEvents flpCustomComponent As FlowLayoutPanel
    Friend WithEvents fastColoredTextBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents BtnQueryList As Button

End Class
