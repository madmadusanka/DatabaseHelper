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
        pnlLeftMain = New Panel()
        txtConnectedServerName = New TextBox()
        pnlLeftSub = New Panel()
        pnlLeftComboBox = New Panel()
        cmbSelectTable = New ComboBox()
        btnTableOption = New Button()
        btnShowProcedure = New Button()
        btnShowView = New Button()
        pnlSelectView_LBL = New Panel()
        lblSelectView = New Label()
        cmbSelectProcedure = New ComboBox()
        pnlSelectProcedure_LBL = New Panel()
        lblSelectProcedure = New Label()
        cmbSelectView = New ComboBox()
        pnlSelectTable_LBL = New Panel()
        lblSelectTable = New Label()
        lblDBCount = New Label()
        pnlShowViewCount = New Panel()
        lblViewCount = New Label()
        lblCountOfView = New Label()
        pnlShowSpCount = New Panel()
        lblCountOfSp = New Label()
        lblSpCount = New Label()
        cmbDatabases = New ComboBox()
        pnlShowTableCount = New Panel()
        lblTableCount = New Label()
        lblCountOfTable = New Label()
        pnlSelectYourDatabase_LBL = New Panel()
        lblSelectyourDatabase = New Label()
        btnConnect = New Button()
        pnlDatabaseHelper_LBL = New Panel()
        lblDatabaseHelper = New Label()
        btnCompareQuery = New Button()
        btntest2 = New Button()
        btntest1 = New Button()
        pnlRightMain = New Panel()
        qcLandingPage = New CustomControllers.QueryControl()
        btntest4 = New Button()
        btntest3 = New Button()
        pnlLeftMain.SuspendLayout()
        pnlLeftSub.SuspendLayout()
        pnlLeftComboBox.SuspendLayout()
        pnlSelectView_LBL.SuspendLayout()
        pnlSelectProcedure_LBL.SuspendLayout()
        pnlSelectTable_LBL.SuspendLayout()
        pnlShowViewCount.SuspendLayout()
        pnlShowSpCount.SuspendLayout()
        pnlShowTableCount.SuspendLayout()
        pnlSelectYourDatabase_LBL.SuspendLayout()
        pnlDatabaseHelper_LBL.SuspendLayout()
        pnlRightMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeftMain
        ' 
        pnlLeftMain.BackColor = SystemColors.ActiveBorder
        pnlLeftMain.Controls.Add(txtConnectedServerName)
        pnlLeftMain.Controls.Add(pnlLeftSub)
        pnlLeftMain.Controls.Add(btnConnect)
        pnlLeftMain.Controls.Add(pnlDatabaseHelper_LBL)
        pnlLeftMain.Dock = DockStyle.Left
        pnlLeftMain.Location = New Point(0, 0)
        pnlLeftMain.Name = "pnlLeftMain"
        pnlLeftMain.Size = New Size(311, 738)
        pnlLeftMain.TabIndex = 0
        ' 
        ' txtConnectedServerName
        ' 
        txtConnectedServerName.Location = New Point(16, 60)
        txtConnectedServerName.Name = "txtConnectedServerName"
        txtConnectedServerName.Size = New Size(281, 23)
        txtConnectedServerName.TabIndex = 6
        txtConnectedServerName.Visible = False
        ' 
        ' pnlLeftSub
        ' 
        pnlLeftSub.BackColor = SystemColors.ControlDarkDark
        pnlLeftSub.Controls.Add(pnlLeftComboBox)
        pnlLeftSub.Controls.Add(lblDBCount)
        pnlLeftSub.Controls.Add(pnlShowViewCount)
        pnlLeftSub.Controls.Add(pnlShowSpCount)
        pnlLeftSub.Controls.Add(cmbDatabases)
        pnlLeftSub.Controls.Add(pnlShowTableCount)
        pnlLeftSub.Controls.Add(pnlSelectYourDatabase_LBL)
        pnlLeftSub.Location = New Point(12, 128)
        pnlLeftSub.Name = "pnlLeftSub"
        pnlLeftSub.Size = New Size(287, 556)
        pnlLeftSub.TabIndex = 5
        pnlLeftSub.Visible = False
        ' 
        ' pnlLeftComboBox
        ' 
        pnlLeftComboBox.Controls.Add(cmbSelectTable)
        pnlLeftComboBox.Controls.Add(btnTableOption)
        pnlLeftComboBox.Controls.Add(btnShowProcedure)
        pnlLeftComboBox.Controls.Add(btnShowView)
        pnlLeftComboBox.Controls.Add(pnlSelectView_LBL)
        pnlLeftComboBox.Controls.Add(cmbSelectProcedure)
        pnlLeftComboBox.Controls.Add(pnlSelectProcedure_LBL)
        pnlLeftComboBox.Controls.Add(cmbSelectView)
        pnlLeftComboBox.Controls.Add(pnlSelectTable_LBL)
        pnlLeftComboBox.Location = New Point(3, 192)
        pnlLeftComboBox.Name = "pnlLeftComboBox"
        pnlLeftComboBox.Size = New Size(281, 343)
        pnlLeftComboBox.TabIndex = 11
        pnlLeftComboBox.Visible = False
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
        ' btnShowView
        ' 
        btnShowView.Location = New Point(11, 302)
        btnShowView.Name = "btnShowView"
        btnShowView.Size = New Size(259, 23)
        btnShowView.TabIndex = 12
        btnShowView.Text = "Show View"
        btnShowView.UseVisualStyleBackColor = True
        ' 
        ' pnlSelectView_LBL
        ' 
        pnlSelectView_LBL.BackColor = SystemColors.ControlDark
        pnlSelectView_LBL.Controls.Add(lblSelectView)
        pnlSelectView_LBL.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectView_LBL.Location = New Point(11, 234)
        pnlSelectView_LBL.Name = "pnlSelectView_LBL"
        pnlSelectView_LBL.Size = New Size(260, 34)
        pnlSelectView_LBL.TabIndex = 8
        ' 
        ' lblSelectView
        ' 
        lblSelectView.AutoSize = True
        lblSelectView.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectView.Location = New Point(93, 9)
        lblSelectView.Name = "lblSelectView"
        lblSelectView.Size = New Size(78, 17)
        lblSelectView.TabIndex = 2
        lblSelectView.Text = "Select View"
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
        ' pnlSelectProcedure_LBL
        ' 
        pnlSelectProcedure_LBL.BackColor = SystemColors.ControlDark
        pnlSelectProcedure_LBL.Controls.Add(lblSelectProcedure)
        pnlSelectProcedure_LBL.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectProcedure_LBL.Location = New Point(11, 123)
        pnlSelectProcedure_LBL.Name = "pnlSelectProcedure_LBL"
        pnlSelectProcedure_LBL.Size = New Size(260, 34)
        pnlSelectProcedure_LBL.TabIndex = 8
        ' 
        ' lblSelectProcedure
        ' 
        lblSelectProcedure.AutoSize = True
        lblSelectProcedure.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectProcedure.Location = New Point(78, 9)
        lblSelectProcedure.Name = "lblSelectProcedure"
        lblSelectProcedure.Size = New Size(110, 17)
        lblSelectProcedure.TabIndex = 2
        lblSelectProcedure.Text = "Select Procedure"
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
        ' pnlSelectTable_LBL
        ' 
        pnlSelectTable_LBL.BackColor = SystemColors.ControlDark
        pnlSelectTable_LBL.Controls.Add(lblSelectTable)
        pnlSelectTable_LBL.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectTable_LBL.Location = New Point(11, 21)
        pnlSelectTable_LBL.Name = "pnlSelectTable_LBL"
        pnlSelectTable_LBL.Size = New Size(260, 34)
        pnlSelectTable_LBL.TabIndex = 8
        ' 
        ' lblSelectTable
        ' 
        lblSelectTable.AutoSize = True
        lblSelectTable.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectTable.Location = New Point(89, 9)
        lblSelectTable.Name = "lblSelectTable"
        lblSelectTable.Size = New Size(81, 17)
        lblSelectTable.TabIndex = 2
        lblSelectTable.Text = "Select Table"
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
        ' pnlShowViewCount
        ' 
        pnlShowViewCount.BackColor = SystemColors.ActiveCaption
        pnlShowViewCount.Controls.Add(lblViewCount)
        pnlShowViewCount.Controls.Add(lblCountOfView)
        pnlShowViewCount.Location = New Point(201, 128)
        pnlShowViewCount.Name = "pnlShowViewCount"
        pnlShowViewCount.Size = New Size(72, 48)
        pnlShowViewCount.TabIndex = 6
        pnlShowViewCount.Visible = False
        ' 
        ' lblViewCount
        ' 
        lblViewCount.AutoSize = True
        lblViewCount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblViewCount.Location = New Point(18, 4)
        lblViewCount.Name = "lblViewCount"
        lblViewCount.Size = New Size(0, 15)
        lblViewCount.TabIndex = 6
        ' 
        ' lblCountOfView
        ' 
        lblCountOfView.AutoSize = True
        lblCountOfView.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountOfView.Location = New Point(17, 18)
        lblCountOfView.Name = "lblCountOfView"
        lblCountOfView.Size = New Size(0, 25)
        lblCountOfView.TabIndex = 5
        ' 
        ' pnlShowSpCount
        ' 
        pnlShowSpCount.BackColor = Color.PaleGreen
        pnlShowSpCount.Controls.Add(lblCountOfSp)
        pnlShowSpCount.Controls.Add(lblSpCount)
        pnlShowSpCount.Location = New Point(105, 128)
        pnlShowSpCount.Name = "pnlShowSpCount"
        pnlShowSpCount.Size = New Size(72, 48)
        pnlShowSpCount.TabIndex = 6
        pnlShowSpCount.Visible = False
        ' 
        ' lblCountOfSp
        ' 
        lblCountOfSp.AutoSize = True
        lblCountOfSp.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountOfSp.Location = New Point(6, 5)
        lblCountOfSp.Name = "lblCountOfSp"
        lblCountOfSp.Size = New Size(0, 15)
        lblCountOfSp.TabIndex = 5
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
        ' pnlShowTableCount
        ' 
        pnlShowTableCount.BackColor = Color.RosyBrown
        pnlShowTableCount.Controls.Add(lblTableCount)
        pnlShowTableCount.Controls.Add(lblCountOfTable)
        pnlShowTableCount.Location = New Point(13, 128)
        pnlShowTableCount.Name = "pnlShowTableCount"
        pnlShowTableCount.Size = New Size(72, 48)
        pnlShowTableCount.TabIndex = 5
        pnlShowTableCount.Visible = False
        ' 
        ' lblTableCount
        ' 
        lblTableCount.AutoSize = True
        lblTableCount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTableCount.Location = New Point(17, 5)
        lblTableCount.Name = "lblTableCount"
        lblTableCount.Size = New Size(0, 15)
        lblTableCount.TabIndex = 4
        ' 
        ' lblCountOfTable
        ' 
        lblCountOfTable.AutoSize = True
        lblCountOfTable.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCountOfTable.Location = New Point(17, 19)
        lblCountOfTable.Name = "lblCountOfTable"
        lblCountOfTable.Size = New Size(0, 25)
        lblCountOfTable.TabIndex = 3
        ' 
        ' pnlSelectYourDatabase_LBL
        ' 
        pnlSelectYourDatabase_LBL.BackColor = SystemColors.ControlDark
        pnlSelectYourDatabase_LBL.Controls.Add(lblSelectyourDatabase)
        pnlSelectYourDatabase_LBL.ForeColor = SystemColors.ActiveCaptionText
        pnlSelectYourDatabase_LBL.Location = New Point(13, 54)
        pnlSelectYourDatabase_LBL.Name = "pnlSelectYourDatabase_LBL"
        pnlSelectYourDatabase_LBL.Size = New Size(260, 34)
        pnlSelectYourDatabase_LBL.TabIndex = 7
        ' 
        ' lblSelectyourDatabase
        ' 
        lblSelectyourDatabase.AutoSize = True
        lblSelectyourDatabase.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectyourDatabase.Location = New Point(62, 9)
        lblSelectyourDatabase.Name = "lblSelectyourDatabase"
        lblSelectyourDatabase.Size = New Size(137, 17)
        lblSelectyourDatabase.TabIndex = 2
        lblSelectyourDatabase.Text = "Select your Database"
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(16, 88)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(280, 23)
        btnConnect.TabIndex = 3
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' pnlDatabaseHelper_LBL
        ' 
        pnlDatabaseHelper_LBL.BackColor = SystemColors.ControlDarkDark
        pnlDatabaseHelper_LBL.Controls.Add(lblDatabaseHelper)
        pnlDatabaseHelper_LBL.Location = New Point(0, 0)
        pnlDatabaseHelper_LBL.Name = "pnlDatabaseHelper_LBL"
        pnlDatabaseHelper_LBL.Size = New Size(311, 48)
        pnlDatabaseHelper_LBL.TabIndex = 0
        ' 
        ' lblDatabaseHelper
        ' 
        lblDatabaseHelper.AutoSize = True
        lblDatabaseHelper.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDatabaseHelper.ForeColor = SystemColors.ButtonFace
        lblDatabaseHelper.Location = New Point(86, 13)
        lblDatabaseHelper.Name = "lblDatabaseHelper"
        lblDatabaseHelper.Size = New Size(131, 21)
        lblDatabaseHelper.TabIndex = 0
        lblDatabaseHelper.Text = "Database Helper"
        ' 
        ' btnCompareQuery
        ' 
        btnCompareQuery.Location = New Point(23, 26)
        btnCompareQuery.Name = "btnCompareQuery"
        btnCompareQuery.Size = New Size(177, 106)
        btnCompareQuery.TabIndex = 1
        btnCompareQuery.Text = "Compare Query "
        btnCompareQuery.UseVisualStyleBackColor = True
        ' 
        ' btntest2
        ' 
        btntest2.Location = New Point(436, 26)
        btntest2.Name = "btntest2"
        btntest2.Size = New Size(177, 106)
        btntest2.TabIndex = 2
        btntest2.Text = "BTN_test2"
        btntest2.UseVisualStyleBackColor = True
        btntest2.Visible = False
        ' 
        ' btntest1
        ' 
        btntest1.Location = New Point(230, 26)
        btntest1.Name = "btntest1"
        btntest1.Size = New Size(177, 106)
        btntest1.TabIndex = 3
        btntest1.Text = "BTN_test1"
        btntest1.UseVisualStyleBackColor = True
        btntest1.Visible = False
        ' 
        ' pnlRightMain
        ' 
        pnlRightMain.Controls.Add(qcLandingPage)
        pnlRightMain.Controls.Add(btntest4)
        pnlRightMain.Controls.Add(btntest3)
        pnlRightMain.Controls.Add(btnCompareQuery)
        pnlRightMain.Controls.Add(btntest2)
        pnlRightMain.Controls.Add(btntest1)
        pnlRightMain.Dock = DockStyle.Right
        pnlRightMain.Location = New Point(317, 0)
        pnlRightMain.Name = "pnlRightMain"
        pnlRightMain.Size = New Size(1053, 738)
        pnlRightMain.TabIndex = 4
        pnlRightMain.Visible = False
        ' 
        ' qcLandingPage
        ' 
        qcLandingPage.Connection = Nothing
        qcLandingPage.IsDeleteButtonVisible = False
        qcLandingPage.IsflpCustomComponentVisible = False
        qcLandingPage.IsViewTemplateButtonVisible = False
        qcLandingPage.Location = New Point(12, 146)
        qcLandingPage.Name = "qcLandingPage"
        qcLandingPage.Size = New Size(1029, 538)
        qcLandingPage.TabIndex = 6
        ' 
        ' btntest4
        ' 
        btntest4.Location = New Point(846, 26)
        btntest4.Name = "btntest4"
        btntest4.Size = New Size(177, 106)
        btntest4.TabIndex = 5
        btntest4.Text = "BTN_test4"
        btntest4.UseVisualStyleBackColor = True
        btntest4.Visible = False
        ' 
        ' btntest3
        ' 
        btntest3.Location = New Point(639, 26)
        btntest3.Name = "btntest3"
        btntest3.Size = New Size(177, 106)
        btntest3.TabIndex = 4
        btntest3.Text = "BTN_test3"
        btntest3.UseVisualStyleBackColor = True
        btntest3.Visible = False
        ' 
        ' FrmLandingPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 738)
        Controls.Add(pnlLeftMain)
        Controls.Add(pnlRightMain)
        Name = "FrmLandingPage"
        Text = "Landing Page"
        WindowState = FormWindowState.Maximized
        pnlLeftMain.ResumeLayout(False)
        pnlLeftMain.PerformLayout()
        pnlLeftSub.ResumeLayout(False)
        pnlLeftSub.PerformLayout()
        pnlLeftComboBox.ResumeLayout(False)
        pnlSelectView_LBL.ResumeLayout(False)
        pnlSelectView_LBL.PerformLayout()
        pnlSelectProcedure_LBL.ResumeLayout(False)
        pnlSelectProcedure_LBL.PerformLayout()
        pnlSelectTable_LBL.ResumeLayout(False)
        pnlSelectTable_LBL.PerformLayout()
        pnlShowViewCount.ResumeLayout(False)
        pnlShowViewCount.PerformLayout()
        pnlShowSpCount.ResumeLayout(False)
        pnlShowSpCount.PerformLayout()
        pnlShowTableCount.ResumeLayout(False)
        pnlShowTableCount.PerformLayout()
        pnlSelectYourDatabase_LBL.ResumeLayout(False)
        pnlSelectYourDatabase_LBL.PerformLayout()
        pnlDatabaseHelper_LBL.ResumeLayout(False)
        pnlDatabaseHelper_LBL.PerformLayout()
        pnlRightMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeftMain As Panel
    Friend WithEvents pnlDatabaseHelper_LBL As Panel
    Friend WithEvents lblDatabaseHelper As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents pnlLeftSub As Panel
    Friend WithEvents cmbDatabases As ComboBox
    Friend WithEvents btnCompareQuery As Button
    Friend WithEvents btntest2 As Button
    Friend WithEvents btntest1 As Button
    Friend WithEvents pnlRightMain As Panel
    Friend WithEvents btntest3 As Button
    Friend WithEvents btntest4 As Button
    Friend WithEvents lblCountOfTable As Label
    Friend WithEvents pnlShowViewCount As Panel
    Friend WithEvents pnlShowSpCount As Panel
    Friend WithEvents pnlShowTableCount As Panel
    Friend WithEvents lblCountOfView As Label
    Friend WithEvents lblSpCount As Label
    Friend WithEvents lblTableCount As Label
    Friend WithEvents lblViewCount As Label
    Friend WithEvents lblCountOfSp As Label
    Friend WithEvents pnlSelectYourDatabase_LBL As Panel
    Friend WithEvents lblDBCount As Label
    Friend WithEvents lblSelectyourDatabase As Label
    Friend WithEvents pnlSelectView_LBL As Panel
    Friend WithEvents lblSelectView As Label
    Friend WithEvents pnlSelectProcedure_LBL As Panel
    Friend WithEvents lblSelectProcedure As Label
    Friend WithEvents pnlSelectTable_LBL As Panel
    Friend WithEvents lblSelectTable As Label
    Friend WithEvents cmbSelectView As ComboBox
    Friend WithEvents cmbSelectProcedure As ComboBox
    Friend WithEvents pnlLeftComboBox As Panel
    Friend WithEvents btnShowView As Button
    Friend WithEvents btnShowProcedure As Button
    Friend WithEvents btnTableOption As Button
    Friend WithEvents qcLandingPage As CustomControllers.QueryControl
    Friend WithEvents cmbSelectTable As ComboBox
    Friend WithEvents txtConnectedServerName As TextBox

End Class
