<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        TVW_SavedQuery = New TreeView()
        TXT_Search = New TextBox()
        PNL_Title = New Panel()
        LBL_Title = New Label()
        PNL_Title.SuspendLayout()
        SuspendLayout()
        ' 
        ' TVW_SavedQuery
        ' 
        TVW_SavedQuery.Location = New Point(12, 96)
        TVW_SavedQuery.Name = "TVW_SavedQuery"
        TVW_SavedQuery.Size = New Size(395, 344)
        TVW_SavedQuery.TabIndex = 1
        ' 
        ' TXT_Search
        ' 
        TXT_Search.Location = New Point(12, 67)
        TXT_Search.Name = "TXT_Search"
        TXT_Search.Size = New Size(395, 23)
        TXT_Search.TabIndex = 2
        ' 
        ' PNL_Title
        ' 
        PNL_Title.BackColor = SystemColors.ActiveBorder
        PNL_Title.Controls.Add(LBL_Title)
        PNL_Title.Location = New Point(12, 12)
        PNL_Title.Name = "PNL_Title"
        PNL_Title.Size = New Size(395, 49)
        PNL_Title.TabIndex = 3
        ' 
        ' LBL_Title
        ' 
        LBL_Title.AutoSize = True
        LBL_Title.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBL_Title.Location = New Point(104, 16)
        LBL_Title.Name = "LBL_Title"
        LBL_Title.Size = New Size(173, 21)
        LBL_Title.TabIndex = 0
        LBL_Title.Text = "Select query Template"
        ' 
        ' FrmSavedQuery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 452)
        Controls.Add(PNL_Title)
        Controls.Add(TXT_Search)
        Controls.Add(TVW_SavedQuery)
        MaximizeBox = False
        MaximumSize = New Size(435, 491)
        MinimizeBox = False
        MinimumSize = New Size(435, 491)
        Name = "FrmSavedQuery"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Query Templates"
        PNL_Title.ResumeLayout(False)
        PNL_Title.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents TVW_SavedQuery As TreeView
    Friend WithEvents TXT_Search As TextBox
    Friend WithEvents PNL_Title As Panel
    Friend WithEvents LBL_Title As Label
End Class
