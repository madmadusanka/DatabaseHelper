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
        LB_Groups = New ListBox()
        TXT_NewGroup = New TextBox()
        btnAddNewGroup = New Button()
        PNL_Title = New Panel()
        LBL_Title = New Label()
        PNL_Title.SuspendLayout()
        SuspendLayout()
        ' 
        ' LB_Groups
        ' 
        LB_Groups.FormattingEnabled = True
        LB_Groups.ItemHeight = 15
        LB_Groups.Location = New Point(12, 98)
        LB_Groups.MaximumSize = New Size(304, 259)
        LB_Groups.MinimumSize = New Size(304, 259)
        LB_Groups.Name = "LB_Groups"
        LB_Groups.Size = New Size(304, 259)
        LB_Groups.TabIndex = 0
        ' 
        ' TXT_NewGroup
        ' 
        TXT_NewGroup.Location = New Point(12, 64)
        TXT_NewGroup.Name = "TXT_NewGroup"
        TXT_NewGroup.Size = New Size(171, 23)
        TXT_NewGroup.TabIndex = 1
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
        ' PNL_Title
        ' 
        PNL_Title.BackColor = SystemColors.ActiveBorder
        PNL_Title.Controls.Add(LBL_Title)
        PNL_Title.Location = New Point(12, 9)
        PNL_Title.Name = "PNL_Title"
        PNL_Title.Size = New Size(304, 47)
        PNL_Title.TabIndex = 3
        ' 
        ' LBL_Title
        ' 
        LBL_Title.AutoSize = True
        LBL_Title.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBL_Title.Location = New Point(79, 11)
        LBL_Title.Name = "LBL_Title"
        LBL_Title.Size = New Size(141, 27)
        LBL_Title.TabIndex = 0
        LBL_Title.Text = "Select Your Group"
        LBL_Title.UseCompatibleTextRendering = True
        ' 
        ' FrmSelectSavePath
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(328, 366)
        Controls.Add(PNL_Title)
        Controls.Add(btnAddNewGroup)
        Controls.Add(TXT_NewGroup)
        Controls.Add(LB_Groups)
        MaximizeBox = False
        MaximumSize = New Size(344, 405)
        MinimizeBox = False
        MinimumSize = New Size(344, 405)
        Name = "FrmSelectSavePath"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Save Query"
        PNL_Title.ResumeLayout(False)
        PNL_Title.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LB_Groups As ListBox
    Friend WithEvents TXT_NewGroup As TextBox
    Friend WithEvents btnAddNewGroup As Button
    Friend WithEvents PNL_Title As Panel
    Friend WithEvents LBL_Title As Label
End Class
