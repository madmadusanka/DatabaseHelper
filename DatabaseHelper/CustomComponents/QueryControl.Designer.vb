﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        txtSearch = New TextBox()
        tabMessage = New TabPage()
        txtQueryMessage = New TextBox()
        btnsavequery = New Button()
        flpCustomComponent = New FlowLayoutPanel()
        fastColoredTextBox = New FastColoredTextBoxNS.FastColoredTextBox()
        BtnQueryList = New Button()
        btnViewTemplate = New Button()
        btnExportWithData = New Button()
        btnImportWithData = New Button()
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
        QueryResultDataGridView.Location = New Point(0, 35)
        QueryResultDataGridView.Name = "QueryResultDataGridView"
        QueryResultDataGridView.Size = New Size(634, 202)
        QueryResultDataGridView.TabIndex = 2
        ' 
        ' ExecuteQueryButton
        ' 
        ExecuteQueryButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ExecuteQueryButton.BackColor = SystemColors.ActiveBorder
        ExecuteQueryButton.ForeColor = SystemColors.ActiveCaptionText
        ExecuteQueryButton.Location = New Point(542, 261)
        ExecuteQueryButton.Name = "ExecuteQueryButton"
        ExecuteQueryButton.Size = New Size(109, 48)
        ExecuteQueryButton.TabIndex = 3
        ExecuteQueryButton.Text = "Execute"
        ExecuteQueryButton.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteThis
        ' 
        btnDeleteThis.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDeleteThis.Location = New Point(18, 261)
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
        tabControlQuery.Location = New Point(18, 290)
        tabControlQuery.Name = "tabControlQuery"
        tabControlQuery.SelectedIndex = 0
        tabControlQuery.Size = New Size(642, 265)
        tabControlQuery.TabIndex = 5
        ' 
        ' tabResult
        ' 
        tabResult.AccessibleRole = AccessibleRole.None
        tabResult.Controls.Add(txtSearch)
        tabResult.Controls.Add(QueryResultDataGridView)
        tabResult.Location = New Point(4, 24)
        tabResult.Name = "tabResult"
        tabResult.Padding = New Padding(3)
        tabResult.Size = New Size(634, 237)
        tabResult.TabIndex = 0
        tabResult.Text = "Results"
        tabResult.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.Location = New Point(6, 6)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(622, 23)
        txtSearch.TabIndex = 3
        ' 
        ' tabMessage
        ' 
        tabMessage.Controls.Add(txtQueryMessage)
        tabMessage.Location = New Point(4, 24)
        tabMessage.Name = "tabMessage"
        tabMessage.Padding = New Padding(3)
        tabMessage.Size = New Size(634, 237)
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
        txtQueryMessage.Size = New Size(635, 264)
        txtQueryMessage.TabIndex = 0
        ' 
        ' btnsavequery
        ' 
        btnsavequery.Location = New Point(22, 4)
        btnsavequery.Name = "btnsavequery"
        btnsavequery.Size = New Size(105, 23)
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
        flpCustomComponent.Visible = False
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
        fastColoredTextBox.Hotkeys = resources.GetString("fastColoredTextBox.Hotkeys")
        fastColoredTextBox.IsReplaceMode = False
        fastColoredTextBox.Location = New Point(0, 84)
        fastColoredTextBox.Name = "fastColoredTextBox"
        fastColoredTextBox.Paddings = New Padding(0)
        fastColoredTextBox.SelectionColor = Color.FromArgb(CByte(60), CByte(0), CByte(0), CByte(255))
        fastColoredTextBox.ServiceColors = CType(resources.GetObject("fastColoredTextBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        fastColoredTextBox.ServiceLinesColor = Color.Gray
        fastColoredTextBox.Size = New Size(660, 171)
        fastColoredTextBox.TabIndex = 0
        fastColoredTextBox.Zoom = 100
        ' 
        ' BtnQueryList
        ' 
        BtnQueryList.Location = New Point(22, 30)
        BtnQueryList.Name = "BtnQueryList"
        BtnQueryList.Size = New Size(105, 23)
        BtnQueryList.TabIndex = 9
        BtnQueryList.Text = "Query List"
        BtnQueryList.UseVisualStyleBackColor = True
        ' 
        ' btnViewTemplate
        ' 
        btnViewTemplate.Location = New Point(22, 57)
        btnViewTemplate.Name = "btnViewTemplate"
        btnViewTemplate.Size = New Size(105, 23)
        btnViewTemplate.TabIndex = 10
        btnViewTemplate.Text = "View Template"
        btnViewTemplate.UseVisualStyleBackColor = True
        btnViewTemplate.Visible = False
        ' 
        ' btnExportWithData
        ' 
        btnExportWithData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportWithData.Location = New Point(415, 261)
        btnExportWithData.Name = "btnExportWithData"
        btnExportWithData.Size = New Size(123, 23)
        btnExportWithData.TabIndex = 11
        btnExportWithData.Text = "Export With Data"
        btnExportWithData.UseVisualStyleBackColor = True
        ' 
        ' btnImportWithData
        ' 
        btnImportWithData.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnImportWithData.Location = New Point(415, 285)
        btnImportWithData.Name = "btnImportWithData"
        btnImportWithData.Size = New Size(123, 24)
        btnImportWithData.TabIndex = 12
        btnImportWithData.Text = "Import with Data"
        btnImportWithData.UseVisualStyleBackColor = True
        ' 
        ' QueryControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnImportWithData)
        Controls.Add(ExecuteQueryButton)
        Controls.Add(btnExportWithData)
        Controls.Add(btnViewTemplate)
        Controls.Add(BtnQueryList)
        Controls.Add(fastColoredTextBox)
        Controls.Add(flpCustomComponent)
        Controls.Add(btnsavequery)
        Controls.Add(tabControlQuery)
        Controls.Add(btnDeleteThis)
        Name = "QueryControl"
        Size = New Size(660, 573)
        CType(QueryResultDataGridView, ComponentModel.ISupportInitialize).EndInit()
        tabControlQuery.ResumeLayout(False)
        tabResult.ResumeLayout(False)
        tabResult.PerformLayout()
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
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnViewTemplate As Button
    Friend WithEvents btnExportWithData As Button
    Friend WithEvents btnImportWithData As Button

End Class
