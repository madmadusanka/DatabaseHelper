<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        lblDatabaseCount = New Label()
        btnConnectServer = New Button()
        lblServerName = New Label()
        txtServerName = New TextBox()
        Panel2 = New Panel()
        lblsqlserver = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(lblDatabaseCount)
        Panel1.Controls.Add(btnConnectServer)
        Panel1.Controls.Add(lblServerName)
        Panel1.Controls.Add(txtServerName)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(311, 450)
        Panel1.TabIndex = 0
        ' 
        ' lblDatabaseCount
        ' 
        lblDatabaseCount.AutoSize = True
        lblDatabaseCount.Location = New Point(12, 146)
        lblDatabaseCount.Name = "lblDatabaseCount"
        lblDatabaseCount.Size = New Size(104, 15)
        lblDatabaseCount.TabIndex = 4
        lblDatabaseCount.Text = "SQL Server Name :"
        ' 
        ' btnConnectServer
        ' 
        btnConnectServer.Location = New Point(12, 109)
        btnConnectServer.Name = "btnConnectServer"
        btnConnectServer.Size = New Size(287, 23)
        btnConnectServer.TabIndex = 3
        btnConnectServer.Text = "Connect"
        btnConnectServer.UseVisualStyleBackColor = True
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
        lblsqlserver.Location = New Point(112, 12)
        lblsqlserver.Name = "lblsqlserver"
        lblsqlserver.Size = New Size(91, 21)
        lblsqlserver.TabIndex = 0
        lblsqlserver.Text = "SQL Server"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(851, 450)
        Controls.Add(Panel1)
        Name = "frmMain"
        Text = "Main "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblServerName As Label
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblsqlserver As Label
    Friend WithEvents btnConnectServer As Button
    Friend WithEvents lblDatabaseCount As Label

End Class
