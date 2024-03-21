<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectSavePath
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
        LBFolders = New ListBox()
        txtnewFolder = New TextBox()
        btnAddFolder = New Button()
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlTitle.SuspendLayout()
        SuspendLayout()
        ' 
        ' LBFolders
        ' 
        LBFolders.FormattingEnabled = True
        LBFolders.ItemHeight = 15
        LBFolders.Location = New Point(12, 98)
        LBFolders.MaximumSize = New Size(304, 259)
        LBFolders.MinimumSize = New Size(304, 259)
        LBFolders.Name = "LBFolders"
        LBFolders.Size = New Size(304, 259)
        LBFolders.TabIndex = 0
        ' 
        ' txtnewFolder
        ' 
        txtnewFolder.Location = New Point(12, 64)
        txtnewFolder.Name = "txtnewFolder"
        txtnewFolder.Size = New Size(171, 23)
        txtnewFolder.TabIndex = 1
        ' 
        ' btnAddFolder
        ' 
        btnAddFolder.Location = New Point(189, 64)
        btnAddFolder.Name = "btnAddFolder"
        btnAddFolder.Size = New Size(127, 23)
        btnAddFolder.TabIndex = 2
        btnAddFolder.Text = "Add Folder"
        btnAddFolder.UseVisualStyleBackColor = True
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
        lblTitle.Size = New Size(142, 27)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Select Your Folder"
        lblTitle.UseCompatibleTextRendering = True
        ' 
        ' FrmSelectSavePath
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 366)
        Controls.Add(pnlTitle)
        Controls.Add(btnAddFolder)
        Controls.Add(txtnewFolder)
        Controls.Add(LBFolders)
        MaximizeBox = False
        MaximumSize = New Size(344, 405)
        MinimizeBox = False
        MinimumSize = New Size(344, 405)
        Name = "FrmSelectSavePath"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSelectSavePath"
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBFolders As ListBox
    Friend WithEvents txtnewFolder As TextBox
    Friend WithEvents btnAddFolder As Button
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
End Class
