<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnectToServer
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
        btnToggleConnection = New Button()
        lblServerName = New Label()
        txtServerName = New TextBox()
        cmbAuthselect = New ComboBox()
        txtServerUserName = New TextBox()
        lblUserName = New Label()
        lblPassword = New Label()
        pnlUserName = New Panel()
        txtServerUserPassword = New TextBox()
        pnlTitle = New Panel()
        lblTitle = New Label()
        pnlUserName.SuspendLayout()
        pnlTitle.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnToggleConnection
        ' 
        btnToggleConnection.Location = New Point(69, 241)
        btnToggleConnection.Name = "btnToggleConnection"
        btnToggleConnection.Size = New Size(287, 23)
        btnToggleConnection.TabIndex = 6
        btnToggleConnection.Text = "Connect"
        btnToggleConnection.UseVisualStyleBackColor = True
        ' 
        ' lblServerName
        ' 
        lblServerName.AutoSize = True
        lblServerName.Location = New Point(67, 97)
        lblServerName.Name = "lblServerName"
        lblServerName.Size = New Size(80, 15)
        lblServerName.TabIndex = 5
        lblServerName.Text = "Server Name :"
        ' 
        ' txtServerName
        ' 
        txtServerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtServerName.Location = New Point(69, 116)
        txtServerName.Name = "txtServerName"
        txtServerName.Size = New Size(287, 23)
        txtServerName.TabIndex = 4
        ' 
        ' cmbAuthselect
        ' 
        cmbAuthselect.FormattingEnabled = True
        cmbAuthselect.Location = New Point(69, 145)
        cmbAuthselect.Name = "cmbAuthselect"
        cmbAuthselect.Size = New Size(287, 23)
        cmbAuthselect.TabIndex = 8
        ' 
        ' txtServerUserName
        ' 
        txtServerUserName.Location = New Point(85, 8)
        txtServerUserName.Name = "txtServerUserName"
        txtServerUserName.Size = New Size(195, 23)
        txtServerUserName.TabIndex = 10
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(8, 16)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(71, 15)
        lblUserName.TabIndex = 12
        lblUserName.Text = "User Name :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(8, 41)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(63, 15)
        lblPassword.TabIndex = 13
        lblPassword.Text = "Password :"
        ' 
        ' pnlUserName
        ' 
        pnlUserName.Controls.Add(lblUserName)
        pnlUserName.Controls.Add(txtServerUserName)
        pnlUserName.Controls.Add(lblPassword)
        pnlUserName.Controls.Add(txtServerUserPassword)
        pnlUserName.Location = New Point(69, 170)
        pnlUserName.Name = "pnlUserName"
        pnlUserName.Size = New Size(287, 68)
        pnlUserName.TabIndex = 14
        pnlUserName.Visible = False
        ' 
        ' txtServerUserPassword
        ' 
        txtServerUserPassword.Location = New Point(85, 38)
        txtServerUserPassword.Name = "txtServerUserPassword"
        txtServerUserPassword.Size = New Size(195, 23)
        txtServerUserPassword.TabIndex = 11
        txtServerUserPassword.UseSystemPasswordChar = True
        ' 
        ' pnlTitle
        ' 
        pnlTitle.BackColor = SystemColors.ActiveBorder
        pnlTitle.Controls.Add(lblTitle)
        pnlTitle.Location = New Point(69, 29)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(287, 63)
        pnlTitle.TabIndex = 15
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(79, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(134, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SQL SERVER"
        ' 
        ' FrmConnectToServer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 294)
        Controls.Add(pnlTitle)
        Controls.Add(pnlUserName)
        Controls.Add(cmbAuthselect)
        Controls.Add(btnToggleConnection)
        Controls.Add(lblServerName)
        Controls.Add(txtServerName)
        Name = "FrmConnectToServer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Connect To Server"
        pnlUserName.ResumeLayout(False)
        pnlUserName.PerformLayout()
        pnlTitle.ResumeLayout(False)
        pnlTitle.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnToggleConnection As Button
    Friend WithEvents lblServerName As Label
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents cmbAuthselect As ComboBox
    Friend WithEvents txtServerUserName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents pnlUserName As Panel
    Friend WithEvents txtServerUserPassword As TextBox
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
End Class
