<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLandingPage
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
        pnlSqlServer = New Panel()
        txtConnectedserverName = New TextBox()
        pnlMain = New Panel()
        pnlSelectDetails = New Panel()
        cmbSelectTable = New ComboBox()
        btnTableOption = New Button()
        btnShowProcedure = New Button()
        btnShowViewQuery = New Button()
        pnlSelectViewlbl = New Panel()
        lblSelectViewlbl = New Label()
        cmbSelectProcedure = New ComboBox()
        pnlSelectProcedurelbl = New Panel()
        lblSelectProcedurelbl = New Label()
        cmbSelectView = New ComboBox()
        pnlselectTablelbl = New Panel()
        lblselectTablelbl = New Label()
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
        pnlselectYourDatabaselbl = New Panel()
        lblSelectyourDatabaselbl = New Label()
        btnConnection = New Button()
        pnlSqlServerlbl = New Panel()
        lblsqlserver = New Label()
        btnfrmQueryCompare = New Button()
        Button2 = New Button()
        btnQueryTemplate = New Button()
        pnlDashBoardMain = New Panel()
        QueryExecuterLandingPage = New CustomControllers.QueryControl()
        Button5 = New Button()
        Button4 = New Button()
        pnlSqlServer.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlSelectDetails.SuspendLayout()
        pnlSelectViewlbl.SuspendLayout()
        pnlSelectProcedurelbl.SuspendLayout()
        pnlselectTablelbl.SuspendLayout()
        pnlShowView.SuspendLayout()
        pnlShowSp.SuspendLayout()
        pnlShowTable.SuspendLayout()
        pnlselectYourDatabaselbl.SuspendLayout()
        pnlSqlServerlbl.SuspendLayout()
        pnlDashBoardMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSqlServer
        ' 
        pnlSqlServer.BackColor = SystemColors.ActiveBorder
        pnlSqlServer.Controls.Add(txtConnectedserverName)
        pnlSqlServer.Controls.Add(pnlMain)
        pnlSqlServer.Controls.Add(btnConnection)
        pnlSqlServer.Controls.Add(pnlSqlServerlbl)
        pnlSqlServer.Dock = DockStyle.Left
        pnlSqlServer.Location = New Point(0, 0)
        pnlSqlServer.Name = "pnlSqlServer"
        pnlSqlServer.Size = New Size(311, 738)
        pnlSqlServer.TabIndex = 0
        ' 
        ' txtConnectedserverName
        ' 
        txtConnectedserverName.Location = New Point(16, 60)
        txtConnectedserverName.Name = "txtConnectedserverName"
        txtConnectedserverName.Size = New Size(281, 23)
        txtConnectedserverName.TabIndex = 6
        txtConnectedserverName.Visible = False
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
        pnlMain.Controls.Add(pnlselectYourDatabaselbl)
        pnlMain.Location = New Point(12, 128)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(287, 556)
        pnlMain.TabIndex = 5
        pnlMain.Visible = False
        ' 
        ' pnlSelectDetails
        ' 
        pnlSelectDetails.Controls.Add(cmbSelectTable)
        pnlSelectDetails.Controls.Add(btnTableOption)
        pnlSelectDetails.Controls.Add(btnShowProcedure)
        pnlSelectDetails.Controls.Add(btnShowViewQuery)
        pnlSelectDetails.Controls.Add(pnlSelectViewlbl)
        pnlSelectDetails.Controls.Add(cmbSelectProcedure)
        pnlSelectDetails.Controls.Add(pnlSelectProcedurelbl)
        pnlSelectDetails.Controls.Add(cmbSelectView)
        pnlSelectDetails.Controls.Add(pnlselectTablelbl)
        pnlSelectDetails.Location = New Point(3, 192)
        pnlSelectDetails.Name = "pnlSelectDetails"
        pnlSelectDetails.Size = New Size(281, 343)
        pnlSelectDetails.TabIndex = 11
        pnlSelectDetails.Visible = False
        ' 
        ' cmbSelectTable
        ' 
        cmbSelectTable.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectTable.FormattingEnabled = True
        cmbSelectTable.Location = New Point(12, 59)
        cmbSelectTable.Name = "cmbSelectTable"
        cmbSelectTable.Size = New Size(258, 23)
        cmbSelectTable.TabIndex = 15
        ' 
        ' btnTableOption
        ' 
        btnTableOption.Location = New Point(12, 86)
        btnTableOption.Name = "btnTableOption"
        btnTableOption.Size = New Size(259, 23)
        btnTableOption.TabIndex = 14
        btnTableOption.Text = "Show View Table Options"
        btnTableOption.UseVisualStyleBackColor = True
        ' 
        ' btnShowProcedure
        ' 
        btnShowProcedure.Location = New Point(12, 192)
        btnShowProcedure.Name = "btnShowProcedure"
        btnShowProcedure.Size = New Size(259, 23)
        btnShowProcedure.TabIndex = 13
        btnShowProcedure.Text = "Show Procedure"
        btnShowProcedure.UseVisualStyleBackColor = True
        ' 
        ' btnShowViewQuery
        ' 
        btnShowViewQuery.Location = New Point(11, 302)
        btnShowViewQuery.Name = "btnShowViewQuery"
        btnShowViewQuery.Size = New Size(259, 23)
        btnShowViewQuery.TabIndex = 12
        btnShowViewQuery.Text = "Show View "
        btnShowViewQuery.UseVisualStyleBackColor = True
        ' 
        ' pnlSelectViewlbl
        ' 
        pnlSelectViewlbl.BackColor = SystemColors.ControlDark
        pnlSelectViewlbl.Controls.Add(lblSelectViewlbl)
        pnlSelectViewlbl.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectViewlbl.Location = New Point(11, 234)
        pnlSelectViewlbl.Name = "pnlSelectViewlbl"
        pnlSelectViewlbl.Size = New Size(260, 34)
        pnlSelectViewlbl.TabIndex = 8
        ' 
        ' lblSelectViewlbl
        ' 
        lblSelectViewlbl.AutoSize = True
        lblSelectViewlbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectViewlbl.Location = New Point(93, 9)
        lblSelectViewlbl.Name = "lblSelectViewlbl"
        lblSelectViewlbl.Size = New Size(78, 17)
        lblSelectViewlbl.TabIndex = 2
        lblSelectViewlbl.Text = "Select View"
        ' 
        ' cmbSelectProcedure
        ' 
        cmbSelectProcedure.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectProcedure.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectProcedure.FormattingEnabled = True
        cmbSelectProcedure.Location = New Point(11, 163)
        cmbSelectProcedure.Name = "cmbSelectProcedure"
        cmbSelectProcedure.Size = New Size(260, 23)
        cmbSelectProcedure.TabIndex = 9
        ' 
        ' pnlSelectProcedurelbl
        ' 
        pnlSelectProcedurelbl.BackColor = SystemColors.ControlDark
        pnlSelectProcedurelbl.Controls.Add(lblSelectProcedurelbl)
        pnlSelectProcedurelbl.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectProcedurelbl.Location = New Point(11, 123)
        pnlSelectProcedurelbl.Name = "pnlSelectProcedurelbl"
        pnlSelectProcedurelbl.Size = New Size(260, 34)
        pnlSelectProcedurelbl.TabIndex = 8
        ' 
        ' lblSelectProcedurelbl
        ' 
        lblSelectProcedurelbl.AutoSize = True
        lblSelectProcedurelbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectProcedurelbl.Location = New Point(78, 9)
        lblSelectProcedurelbl.Name = "lblSelectProcedurelbl"
        lblSelectProcedurelbl.Size = New Size(110, 17)
        lblSelectProcedurelbl.TabIndex = 2
        lblSelectProcedurelbl.Text = "Select Procedure"
        ' 
        ' cmbSelectView
        ' 
        cmbSelectView.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbSelectView.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbSelectView.FormattingEnabled = True
        cmbSelectView.Location = New Point(11, 274)
        cmbSelectView.Name = "cmbSelectView"
        cmbSelectView.Size = New Size(260, 23)
        cmbSelectView.TabIndex = 10
        ' 
        ' pnlselectTablelbl
        ' 
        pnlselectTablelbl.BackColor = SystemColors.ControlDark
        pnlselectTablelbl.Controls.Add(lblselectTablelbl)
        pnlselectTablelbl.ForeColor = SystemColors.ActiveCaptionText
        pnlselectTablelbl.Location = New Point(11, 21)
        pnlselectTablelbl.Name = "pnlselectTablelbl"
        pnlselectTablelbl.Size = New Size(260, 34)
        pnlselectTablelbl.TabIndex = 8
        ' 
        ' lblselectTablelbl
        ' 
        lblselectTablelbl.AutoSize = True
        lblselectTablelbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblselectTablelbl.Location = New Point(89, 9)
        lblselectTablelbl.Name = "lblselectTablelbl"
        lblselectTablelbl.Size = New Size(81, 17)
        lblselectTablelbl.TabIndex = 2
        lblselectTablelbl.Text = "Select Table"
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
        ' pnlselectYourDatabaselbl
        ' 
        pnlselectYourDatabaselbl.BackColor = SystemColors.ControlDark
        pnlselectYourDatabaselbl.Controls.Add(lblSelectyourDatabaselbl)
        pnlselectYourDatabaselbl.ForeColor = SystemColors.ActiveCaptionText
        pnlselectYourDatabaselbl.Location = New Point(13, 54)
        pnlselectYourDatabaselbl.Name = "pnlselectYourDatabaselbl"
        pnlselectYourDatabaselbl.Size = New Size(260, 34)
        pnlselectYourDatabaselbl.TabIndex = 7
        ' 
        ' lblSelectyourDatabaselbl
        ' 
        lblSelectyourDatabaselbl.AutoSize = True
        lblSelectyourDatabaselbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectyourDatabaselbl.Location = New Point(62, 9)
        lblSelectyourDatabaselbl.Name = "lblSelectyourDatabaselbl"
        lblSelectyourDatabaselbl.Size = New Size(137, 17)
        lblSelectyourDatabaselbl.TabIndex = 2
        lblSelectyourDatabaselbl.Text = "Select your Database"
        ' 
        ' btnConnection
        ' 
        btnConnection.Location = New Point(16, 88)
        btnConnection.Name = "btnConnection"
        btnConnection.Size = New Size(280, 23)
        btnConnection.TabIndex = 3
        btnConnection.Text = "Connect"
        btnConnection.UseVisualStyleBackColor = True
        ' 
        ' pnlSqlServerlbl
        ' 
        pnlSqlServerlbl.BackColor = SystemColors.ControlDarkDark
        pnlSqlServerlbl.Controls.Add(lblsqlserver)
        pnlSqlServerlbl.Location = New Point(0, 0)
        pnlSqlServerlbl.Name = "pnlSqlServerlbl"
        pnlSqlServerlbl.Size = New Size(311, 48)
        pnlSqlServerlbl.TabIndex = 0
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
        ' btnfrmQueryCompare
        ' 
        btnfrmQueryCompare.Location = New Point(23, 26)
        btnfrmQueryCompare.Name = "btnfrmQueryCompare"
        btnfrmQueryCompare.Size = New Size(177, 106)
        btnfrmQueryCompare.TabIndex = 1
        btnfrmQueryCompare.Text = "Multiple Query Execution"
        btnfrmQueryCompare.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(436, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 106)
        Button2.TabIndex = 2
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' btnQueryTemplate
        ' 
        btnQueryTemplate.Location = New Point(230, 26)
        btnQueryTemplate.Name = "btnQueryTemplate"
        btnQueryTemplate.Size = New Size(177, 106)
        btnQueryTemplate.TabIndex = 3
        btnQueryTemplate.Text = "Query Template"
        btnQueryTemplate.UseVisualStyleBackColor = True
        btnQueryTemplate.Visible = False
        ' 
        ' pnlDashBoardMain
        ' 
        pnlDashBoardMain.Controls.Add(QueryExecuterLandingPage)
        pnlDashBoardMain.Controls.Add(Button5)
        pnlDashBoardMain.Controls.Add(Button4)
        pnlDashBoardMain.Controls.Add(btnfrmQueryCompare)
        pnlDashBoardMain.Controls.Add(Button2)
        pnlDashBoardMain.Controls.Add(btnQueryTemplate)
        pnlDashBoardMain.Dock = DockStyle.Right
        pnlDashBoardMain.Location = New Point(317, 0)
        pnlDashBoardMain.Name = "pnlDashBoardMain"
        pnlDashBoardMain.Size = New Size(1053, 738)
        pnlDashBoardMain.TabIndex = 4
        pnlDashBoardMain.Visible = False
        ' 
        ' QueryExecuterLandingPage
        ' 
        QueryExecuterLandingPage.Connection = Nothing
        QueryExecuterLandingPage.IsDeleteButtonVisible = False
        QueryExecuterLandingPage.Location = New Point(12, 146)
        QueryExecuterLandingPage.Name = "QueryExecuterLandingPage"
        QueryExecuterLandingPage.Size = New Size(1029, 538)
        QueryExecuterLandingPage.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(846, 26)
        Button5.Name = "Button5"
        Button5.Size = New Size(177, 106)
        Button5.TabIndex = 5
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        Button5.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(639, 26)
        Button4.Name = "Button4"
        Button4.Size = New Size(177, 106)
        Button4.TabIndex = 4
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' FrmLandingPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 738)
        Controls.Add(pnlSqlServer)
        Controls.Add(pnlDashBoardMain)
        Name = "FrmLandingPage"
        Text = "Landing Page"
        WindowState = FormWindowState.Maximized
        pnlSqlServer.ResumeLayout(False)
        pnlSqlServer.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlSelectDetails.ResumeLayout(False)
        pnlSelectViewlbl.ResumeLayout(False)
        pnlSelectViewlbl.PerformLayout()
        pnlSelectProcedurelbl.ResumeLayout(False)
        pnlSelectProcedurelbl.PerformLayout()
        pnlselectTablelbl.ResumeLayout(False)
        pnlselectTablelbl.PerformLayout()
        pnlShowView.ResumeLayout(False)
        pnlShowView.PerformLayout()
        pnlShowSp.ResumeLayout(False)
        pnlShowSp.PerformLayout()
        pnlShowTable.ResumeLayout(False)
        pnlShowTable.PerformLayout()
        pnlselectYourDatabaselbl.ResumeLayout(False)
        pnlselectYourDatabaselbl.PerformLayout()
        pnlSqlServerlbl.ResumeLayout(False)
        pnlSqlServerlbl.PerformLayout()
        pnlDashBoardMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSqlServer As Panel
    Friend WithEvents pnlSqlServerlbl As Panel
    Friend WithEvents lblsqlserver As Label
    Friend WithEvents btnConnection As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents cmbDatabases As ComboBox
    Friend WithEvents btnfrmQueryCompare As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnQueryTemplate As Button
    Friend WithEvents pnlDashBoardMain As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents lblTableCount As Label
    Friend WithEvents pnlShowView As Panel
    Friend WithEvents pnlShowSp As Panel
    Friend WithEvents pnlShowTable As Panel
    Friend WithEvents lblViewCount As Label
    Friend WithEvents lblSpCount As Label
    Friend WithEvents lbltbllbl As Label
    Friend WithEvents lblviewlbl As Label
    Friend WithEvents lblsplbl As Label
    Friend WithEvents pnlselectYourDatabaselbl As Panel
    Friend WithEvents lblDBCount As Label
    Friend WithEvents lblSelectyourDatabaselbl As Label
    Friend WithEvents pnlSelectViewlbl As Panel
    Friend WithEvents lblSelectViewlbl As Label
    Friend WithEvents pnlSelectProcedurelbl As Panel
    Friend WithEvents lblSelectProcedurelbl As Label
    Friend WithEvents pnlselectTablelbl As Panel
    Friend WithEvents lblselectTablelbl As Label
    Friend WithEvents cmbSelectView As ComboBox
    Friend WithEvents cmbSelectProcedure As ComboBox
    Friend WithEvents pnlSelectDetails As Panel
    Friend WithEvents btnShowViewQuery As Button
    Friend WithEvents btnShowProcedure As Button
    Friend WithEvents btnTableOption As Button
    Friend WithEvents QueryExecuterLandingPage As CustomControllers.QueryControl
    Friend WithEvents cmbSelectTable As ComboBox
    Friend WithEvents txtConnectedserverName As TextBox

End Class
