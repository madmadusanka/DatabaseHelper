﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSavedQuery
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
        tvwSavedQuery = New TreeView()
        txtSearch = New TextBox()
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlTitle.SuspendLayout()
        SuspendLayout()
        ' 
        ' tvwSavedQuery
        ' 
        tvwSavedQuery.Location = New Point(12, 96)
        tvwSavedQuery.Name = "tvwSavedQuery"
        tvwSavedQuery.Size = New Size(395, 344)
        tvwSavedQuery.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 67)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(395, 23)
        txtSearch.TabIndex = 2
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = SystemColors.ActiveBorder
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Location = New Point(12, 12)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(395, 49)
        pnlTitle.TabIndex = 3
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(104, 16)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(173, 21)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Select query Template"
        ' 
        ' frmSavedQuery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 452)
        Controls.Add(pnlTitle)
        Controls.Add(txtSearch)
        Controls.Add(tvwSavedQuery)
        MaximizeBox = False
        MaximumSize = New Size(435, 491)
        MinimizeBox = False
        MinimumSize = New Size(435, 491)
        Name = "frmSavedQuery"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Query Templates"
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents tvwSavedQuery As TreeView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
End Class
