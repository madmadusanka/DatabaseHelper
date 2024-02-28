<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLandingPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel3 = New Panel()
        lblDBCount = New Label()
        Label1 = New Label()
        cmbDatabases = New ComboBox()
        lblDatabaseCount = New Label()
        btnToggleConnection = New Button()
        lblServerName = New Label()
        txtServerName = New TextBox()
        Panel2 = New Panel()
        lblsqlserver = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button5 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lblDatabaseCount)
        Panel1.Controls.Add(btnToggleConnection)
        Panel1.Controls.Add(lblServerName)
        Panel1.Controls.Add(txtServerName)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(311, 738)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlDarkDark
        Panel3.Controls.Add(lblDBCount)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(cmbDatabases)
        Panel3.Location = New Point(12, 146)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(287, 538)
        Panel3.TabIndex = 5
        ' 
        ' lblDBCount
        ' 
        lblDBCount.AutoSize = True
        lblDBCount.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDBCount.Location = New Point(76, 16)
        lblDBCount.Name = "lblDBCount"
        lblDBCount.Size = New Size(0, 17)
        lblDBCount.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 17)
        Label1.TabIndex = 1
        Label1.Text = "Select your Database"
        ' 
        ' cmbDatabases
        ' 
        cmbDatabases.FormattingEnabled = True
        cmbDatabases.Location = New Point(14, 81)
        cmbDatabases.Name = "cmbDatabases"
        cmbDatabases.Size = New Size(260, 23)
        cmbDatabases.TabIndex = 0
        ' 
        ' lblDatabaseCount
        ' 
        lblDatabaseCount.AutoSize = True
        lblDatabaseCount.Location = New Point(16, 146)
        lblDatabaseCount.Name = "lblDatabaseCount"
        lblDatabaseCount.Size = New Size(0, 15)
        lblDatabaseCount.TabIndex = 4
        ' 
        ' btnToggleConnection
        ' 
        btnToggleConnection.Location = New Point(12, 109)
        btnToggleConnection.Name = "btnToggleConnection"
        btnToggleConnection.Size = New Size(287, 23)
        btnToggleConnection.TabIndex = 3
        btnToggleConnection.Text = "Connect"
        btnToggleConnection.UseVisualStyleBackColor = True
        ' 
        ' lblServerName
        ' 
        lblServerName.AutoSize = True
        lblServerName.Location = New Point(12, 62)
        lblServerName.Name = "lblServerName"
        lblServerName.Size = New Size(104, 15)
        lblServerName.TabIndex = 2
        lblServerName.Text = "SQL Server Name :"
        ' 
        ' txtServerName
        ' 
        txtServerName.Location = New Point(12, 81)
        txtServerName.Name = "txtServerName"
        txtServerName.Size = New Size(287, 23)
        txtServerName.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Controls.Add(lblsqlserver)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(311, 48)
        Panel2.TabIndex = 0
        ' 
        ' lblsqlserver
        ' 
        lblsqlserver.AutoSize = True
        lblsqlserver.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsqlserver.ForeColor = SystemColors.ButtonFace
        lblsqlserver.Location = New Point(99, 12)
        lblsqlserver.Name = "lblsqlserver"
        lblsqlserver.Size = New Size(91, 21)
        lblsqlserver.TabIndex = 0
        lblsqlserver.Text = "SQL Server"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(177, 106)
        Button1.TabIndex = 1
        Button1.Text = "Table Joins"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(436, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 106)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(230, 26)
        Button3.Name = "Button3"
        Button3.Size = New Size(177, 106)
        Button3.TabIndex = 3
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button3)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(317, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1053, 738)
        Panel4.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Location = New Point(23, 162)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(1000, 522)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(846, 26)
        Button5.Name = "Button5"
        Button5.Size = New Size(177, 106)
        Button5.TabIndex = 5
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(639, 26)
        Button4.Name = "Button4"
        Button4.Size = New Size(177, 106)
        Button4.TabIndex = 4
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' frmLandingPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 738)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "frmLandingPage"
        Text = "Landing Page"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblServerName As Label
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblsqlserver As Label
    Friend WithEvents btnToggleConnection As Button
    Friend WithEvents lblDatabaseCount As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbDatabases As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblDBCount As Label

End Class
