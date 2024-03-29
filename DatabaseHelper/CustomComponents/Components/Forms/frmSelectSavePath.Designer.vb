<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSavePath
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
        lbGroups = New ListBox()
        txtNewGroup = New TextBox()
        btnAddNewGroup = New Button()
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlTitle.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbGroups
        ' 
        lbGroups.FormattingEnabled = True
        lbGroups.ItemHeight = 15
        lbGroups.Location = New Point(12, 98)
        lbGroups.MaximumSize = New Size(304, 259)
        lbGroups.MinimumSize = New Size(304, 259)
        lbGroups.Name = "lbGroups"
        lbGroups.Size = New Size(304, 259)
        lbGroups.TabIndex = 0
        ' 
        ' txtNewGroup
        ' 
        txtNewGroup.Location = New Point(12, 64)
        txtNewGroup.Name = "txtNewGroup"
        txtNewGroup.Size = New Size(171, 23)
        txtNewGroup.TabIndex = 1
        ' 
        ' btnAddNewGroup
        ' 
        btnAddNewGroup.Location = New Point(189, 64)
        btnAddNewGroup.Name = "btnAddNewGroup"
        btnAddNewGroup.Size = New Size(127, 23)
        btnAddNewGroup.TabIndex = 2
        btnAddNewGroup.Text = "Add New Group"
        btnAddNewGroup.UseVisualStyleBackColor = True
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = SystemColors.ActiveBorder
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Location = New Point(12, 9)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(304, 47)
        pnlTitle.TabIndex = 3
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(79, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(141, 27)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Select Your Group"
        lblTitle.UseCompatibleTextRendering = True
        ' 
        ' frmSelectSavePath
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 366)
        Controls.Add(pnlTitle)
        Controls.Add(btnAddNewGroup)
        Controls.Add(txtNewGroup)
        Controls.Add(lbGroups)
        MaximizeBox = False
        MaximumSize = New Size(344, 405)
        MinimizeBox = False
        MinimumSize = New Size(344, 405)
        Name = "frmSelectSavePath"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Save Query"
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbGroups As ListBox
    Friend WithEvents txtNewGroup As TextBox
    Friend WithEvents btnAddNewGroup As Button
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
End Class
