﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        pnlMain = New Panel()
        pnlSelectDetails = New Panel()
        cmbSelectTable = New ComboBox()
        Panel8 = New Panel()
        Label4 = New Label()
        cmbSelectProcedure = New ComboBox()
        Panel7 = New Panel()
        Label3 = New Label()
        cmbSelectView = New ComboBox()
        Panel6 = New Panel()
        Label1 = New Label()
        lblDBCount = New Label()
        pnlShowView = New Panel()
        lblviewlbl = New Label()
        lblViewCount = New Label()
        pnlShowSp = New Panel()
        lblsplbl = New Label()
        lblSpCount = New Label()
        cmbDatabases = New ComboBox()
        pnlShowTable = New Panel()
        lbltbllbl = New Label()
        lblTableCount = New Label()
        Panel5 = New Panel()
        Label2 = New Label()
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
        pnlMain.SuspendLayout()
        pnlSelectDetails.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        pnlShowView.SuspendLayout()
        pnlShowSp.SuspendLayout()
        pnlShowTable.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(pnlMain)
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
        ' pnlMain
        ' 
        pnlMain.BackColor = SystemColors.ControlDarkDark
        pnlMain.Controls.Add(pnlSelectDetails)
        pnlMain.Controls.Add(lblDBCount)
        pnlMain.Controls.Add(pnlShowView)
        pnlMain.Controls.Add(pnlShowSp)
        pnlMain.Controls.Add(cmbDatabases)
        pnlMain.Controls.Add(pnlShowTable)
        pnlMain.Controls.Add(Panel5)
        pnlMain.Location = New Point(12, 146)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(287, 538)
        pnlMain.TabIndex = 5
        pnlMain.Visible = False
        ' 
        ' pnlSelectDetails
        ' 
        pnlSelectDetails.Controls.Add(cmbSelectTable)
        pnlSelectDetails.Controls.Add(Panel8)
        pnlSelectDetails.Controls.Add(cmbSelectProcedure)
        pnlSelectDetails.Controls.Add(Panel7)
        pnlSelectDetails.Controls.Add(cmbSelectView)
        pnlSelectDetails.Controls.Add(Panel6)
        pnlSelectDetails.Location = New Point(3, 223)
        pnlSelectDetails.Name = "pnlSelectDetails"
        pnlSelectDetails.Size = New Size(281, 255)
        pnlSelectDetails.TabIndex = 11
        pnlSelectDetails.Visible = False
        ' 
        ' cmbSelectTable
        ' 
        cmbSelectTable.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectTable.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectTable.FormattingEnabled = True
        cmbSelectTable.Location = New Point(11, 49)
        cmbSelectTable.Name = "cmbSelectTable"
        cmbSelectTable.Size = New Size(260, 23)
        cmbSelectTable.TabIndex = 8
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.ControlDark
        Panel8.Controls.Add(Label4)
        Panel8.ForeColor = SystemColors.ActiveCaptionText
        Panel8.Location = New Point(11, 176)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(260, 34)
        Panel8.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(93, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 17)
        Label4.TabIndex = 2
        Label4.Text = "Select View"
        ' 
        ' cmbSelectProcedure
        ' 
        cmbSelectProcedure.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectProcedure.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectProcedure.FormattingEnabled = True
        cmbSelectProcedure.Location = New Point(11, 132)
        cmbSelectProcedure.Name = "cmbSelectProcedure"
        cmbSelectProcedure.Size = New Size(260, 23)
        cmbSelectProcedure.TabIndex = 9
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ControlDark
        Panel7.Controls.Add(Label3)
        Panel7.ForeColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(11, 92)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(260, 34)
        Panel7.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(78, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 17)
        Label3.TabIndex = 2
        Label3.Text = "Select Procedure"
        ' 
        ' cmbSelectView
        ' 
        cmbSelectView.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectView.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectView.FormattingEnabled = True
        cmbSelectView.Location = New Point(11, 216)
        cmbSelectView.Name = "cmbSelectView"
        cmbSelectView.Size = New Size(260, 23)
        cmbSelectView.TabIndex = 10
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlDark
        Panel6.Controls.Add(Label1)
        Panel6.ForeColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(11, 9)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(260, 34)
        Panel6.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(89, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 17)
        Label1.TabIndex = 2
        Label1.Text = "Select Table"
        ' 
        ' lblDBCount
        ' 
        lblDBCount.AutoSize = True
        lblDBCount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDBCount.ForeColor = SystemColors.ButtonFace
        lblDBCount.Location = New Point(78, 17)
        lblDBCount.Name = "lblDBCount"
        lblDBCount.Size = New Size(0, 17)
        lblDBCount.TabIndex = 3
        ' 
        ' pnlShowView
        ' 
        pnlShowView.BackColor = SystemColors.ActiveCaption
        pnlShowView.Controls.Add(lblviewlbl)
        pnlShowView.Controls.Add(lblViewCount)
        pnlShowView.Location = New Point(201, 128)
        pnlShowView.Name = "pnlShowView"
        pnlShowView.Size = New Size(72, 48)
        pnlShowView.TabIndex = 6
        pnlShowView.Visible = False
        ' 
        ' lblviewlbl
        ' 
        lblviewlbl.AutoSize = True
        lblviewlbl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblviewlbl.Location = New Point(18, 4)
        lblviewlbl.Name = "lblviewlbl"
        lblviewlbl.Size = New Size(0, 15)
        lblviewlbl.TabIndex = 6
        ' 
        ' lblViewCount
        ' 
        lblViewCount.AutoSize = True
        lblViewCount.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblViewCount.Location = New Point(17, 18)
        lblViewCount.Name = "lblViewCount"
        lblViewCount.Size = New Size(0, 25)
        lblViewCount.TabIndex = 5
        ' 
        ' pnlShowSp
        ' 
        pnlShowSp.BackColor = Color.PaleGreen
        pnlShowSp.Controls.Add(lblsplbl)
        pnlShowSp.Controls.Add(lblSpCount)
        pnlShowSp.Location = New Point(105, 128)
        pnlShowSp.Name = "pnlShowSp"
        pnlShowSp.Size = New Size(72, 48)
        pnlShowSp.TabIndex = 6
        pnlShowSp.Visible = False
        ' 
        ' lblsplbl
        ' 
        lblsplbl.AutoSize = True
        lblsplbl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsplbl.Location = New Point(6, 5)
        lblsplbl.Name = "lblsplbl"
        lblsplbl.Size = New Size(0, 15)
        lblsplbl.TabIndex = 5
        ' 
        ' lblSpCount
        ' 
        lblSpCount.AutoSize = True
        lblSpCount.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSpCount.Location = New Point(17, 18)
        lblSpCount.Name = "lblSpCount"
        lblSpCount.Size = New Size(0, 25)
        lblSpCount.TabIndex = 4
        ' 
        ' cmbDatabases
        ' 
        cmbDatabases.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbDatabases.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbDatabases.FormattingEnabled = True
        cmbDatabases.Location = New Point(13, 95)
        cmbDatabases.Name = "cmbDatabases"
        cmbDatabases.Size = New Size(260, 23)
        cmbDatabases.TabIndex = 0
        ' 
        ' pnlShowTable
        ' 
        pnlShowTable.BackColor = Color.RosyBrown
        pnlShowTable.Controls.Add(lbltbllbl)
        pnlShowTable.Controls.Add(lblTableCount)
        pnlShowTable.Location = New Point(13, 128)
        pnlShowTable.Name = "pnlShowTable"
        pnlShowTable.Size = New Size(72, 48)
        pnlShowTable.TabIndex = 5
        pnlShowTable.Visible = False
        ' 
        ' lbltbllbl
        ' 
        lbltbllbl.AutoSize = True
        lbltbllbl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltbllbl.Location = New Point(17, 5)
        lbltbllbl.Name = "lbltbllbl"
        lbltbllbl.Size = New Size(0, 15)
        lbltbllbl.TabIndex = 4
        ' 
        ' lblTableCount
        ' 
        lblTableCount.AutoSize = True
        lblTableCount.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTableCount.Location = New Point(17, 19)
        lblTableCount.Name = "lblTableCount"
        lblTableCount.Size = New Size(0, 25)
        lblTableCount.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ControlDark
        Panel5.Controls.Add(Label2)
        Panel5.ForeColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(13, 54)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(260, 34)
        Panel5.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 17)
        Label2.TabIndex = 2
        Label2.Text = "Select your Database"
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
        lblsqlserver.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Location = New Point(23, 162)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
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
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlSelectDetails.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        pnlShowView.ResumeLayout(False)
        pnlShowView.PerformLayout()
        pnlShowSp.ResumeLayout(False)
        pnlShowSp.PerformLayout()
        pnlShowTable.ResumeLayout(False)
        pnlShowTable.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
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
    Friend WithEvents pnlMain As Panel
    Friend WithEvents cmbDatabases As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTableCount As Label
    Friend WithEvents pnlShowView As Panel
    Friend WithEvents pnlShowSp As Panel
    Friend WithEvents pnlShowTable As Panel
    Friend WithEvents lblViewCount As Label
    Friend WithEvents lblSpCount As Label
    Friend WithEvents lbltbllbl As Label
    Friend WithEvents lblviewlbl As Label
    Friend WithEvents lblsplbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblDBCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSelectView As ComboBox
    Friend WithEvents cmbSelectProcedure As ComboBox
    Friend WithEvents cmbSelectTable As ComboBox
    Friend WithEvents pnlSelectDetails As Panel

End Class
