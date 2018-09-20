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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDwgNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtRev = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gridDwgs = New System.Windows.Forms.DataGridView()
        Me.DwgNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.dtNeedBy = New System.Windows.Forms.DateTimePicker()
        Me.dtIssue = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClearECR = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClearDwg = New System.Windows.Forms.Button()
        Me.btnAddDwg = New System.Windows.Forms.Button()
        Me.btnUpdateDwg = New System.Windows.Forms.Button()
        Me.btnDeleteDwg = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSearchECR = New System.Windows.Forms.Button()
        Me.chk1DwgErr = New System.Windows.Forms.CheckBox()
        Me.chk2Cost = New System.Windows.Forms.CheckBox()
        Me.chk3MfgImp = New System.Windows.Forms.CheckBox()
        Me.chk4Change = New System.Windows.Forms.CheckBox()
        Me.chk5Quality = New System.Windows.Forms.CheckBox()
        Me.chk6Clari = New System.Windows.Forms.CheckBox()
        Me.chk7Clerical = New System.Windows.Forms.CheckBox()
        Me.chk8Design = New System.Windows.Forms.CheckBox()
        Me.chk9Release = New System.Windows.Forms.CheckBox()
        Me.chk10Reject = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnChkBoxClear = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtJobNo = New System.Windows.Forms.MaskedTextBox()
        Me.btnClrRequest = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSaveApp = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnClrVer = New System.Windows.Forms.Button()
        Me.dtVerfied = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboVerifiedBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblDProd = New System.Windows.Forms.Label()
        Me.lblDLogistics = New System.Windows.Forms.Label()
        Me.lblDQuantity = New System.Windows.Forms.Label()
        Me.lblDAcc = New System.Windows.Forms.Label()
        Me.lblDPurch = New System.Windows.Forms.Label()
        Me.lblDEngg = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblLogistics = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.lblPurch = New System.Windows.Forms.Label()
        Me.lblEngg = New System.Windows.Forms.Label()
        Me.btnClrProd = New System.Windows.Forms.Button()
        Me.btnClrLogistics = New System.Windows.Forms.Button()
        Me.btnClrQuality = New System.Windows.Forms.Button()
        Me.btnClrAcc = New System.Windows.Forms.Button()
        Me.btnClrPurch = New System.Windows.Forms.Button()
        Me.btnClrEngg = New System.Windows.Forms.Button()
        Me.lblClickProd = New System.Windows.Forms.Label()
        Me.lblClickLogistics = New System.Windows.Forms.Label()
        Me.lblClickQuality = New System.Windows.Forms.Label()
        Me.lblClickAcc = New System.Windows.Forms.Label()
        Me.lblClickPurch = New System.Windows.Forms.Label()
        Me.lblClickEngg = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtImplementation = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboUnits = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtEnggHrs = New System.Windows.Forms.TextBox()
        Me.txtProdHrs = New System.Windows.Forms.TextBox()
        Me.rdoRTV = New System.Windows.Forms.RadioButton()
        Me.rdoModify = New System.Windows.Forms.RadioButton()
        Me.rdoNoAffect = New System.Windows.Forms.RadioButton()
        Me.rdoScrap = New System.Windows.Forms.RadioButton()
        Me.rdoUseAsIs = New System.Windows.Forms.RadioButton()
        Me.btnApproveSubmit = New System.Windows.Forms.Button()
        Me.txtReviews = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoNotAccepted = New System.Windows.Forms.RadioButton()
        Me.rdoWithMods = New System.Windows.Forms.RadioButton()
        Me.rdoAccepted = New System.Windows.Forms.RadioButton()
        Me.btnClrRev = New System.Windows.Forms.Button()
        Me.dtReview = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboReviewBy = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtECRNo = New System.Windows.Forms.TextBox()
        CType(Me.gridDwgs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.Indigo
        Me.btnGenerate.Location = New System.Drawing.Point(601, 64)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 32)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Drawing No:"
        '
        'txtDwgNo
        '
        Me.txtDwgNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDwgNo.Location = New System.Drawing.Point(93, 33)
        Me.txtDwgNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDwgNo.Name = "txtDwgNo"
        Me.txtDwgNo.Size = New System.Drawing.Size(116, 24)
        Me.txtDwgNo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(93, 67)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(216, 24)
        Me.txtTitle.TabIndex = 7
        '
        'txtRev
        '
        Me.txtRev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRev.Location = New System.Drawing.Point(286, 33)
        Me.txtRev.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Size = New System.Drawing.Size(22, 24)
        Me.txtRev.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Rev:"
        '
        'txtReq
        '
        Me.txtReq.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtReq.Location = New System.Drawing.Point(457, 66)
        Me.txtReq.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReq.Name = "txtReq"
        Me.txtReq.Size = New System.Drawing.Size(152, 24)
        Me.txtReq.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(377, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Requestor:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(673, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Issue Date:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(653, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Need By Date:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Job No:"
        '
        'gridDwgs
        '
        Me.gridDwgs.AllowUserToAddRows = False
        Me.gridDwgs.AllowUserToResizeRows = False
        Me.gridDwgs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDwgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridDwgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDwgs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DwgNo, Me.Title, Me.Rev})
        Me.gridDwgs.Location = New System.Drawing.Point(10, 154)
        Me.gridDwgs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gridDwgs.Name = "gridDwgs"
        Me.gridDwgs.ReadOnly = True
        Me.gridDwgs.RowTemplate.Height = 24
        Me.gridDwgs.Size = New System.Drawing.Size(725, 239)
        Me.gridDwgs.TabIndex = 16
        '
        'DwgNo
        '
        Me.DwgNo.HeaderText = "Dwg No"
        Me.DwgNo.Name = "DwgNo"
        Me.DwgNo.ReadOnly = True
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        '
        'Rev
        '
        Me.Rev.HeaderText = "Rev"
        Me.Rev.Name = "Rev"
        Me.Rev.ReadOnly = True
        '
        'txtComments
        '
        Me.txtComments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComments.Location = New System.Drawing.Point(10, 418)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(653, 112)
        Me.txtComments.TabIndex = 17
        '
        'dtNeedBy
        '
        Me.dtNeedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtNeedBy.CustomFormat = "MM/dd/yyyy"
        Me.dtNeedBy.Location = New System.Drawing.Point(753, 65)
        Me.dtNeedBy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtNeedBy.Name = "dtNeedBy"
        Me.dtNeedBy.Size = New System.Drawing.Size(218, 24)
        Me.dtNeedBy.TabIndex = 11
        Me.dtNeedBy.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'dtIssue
        '
        Me.dtIssue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtIssue.CustomFormat = "MM/dd/yyyy"
        Me.dtIssue.Location = New System.Drawing.Point(752, 33)
        Me.dtIssue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtIssue.Name = "dtIssue"
        Me.dtIssue.Size = New System.Drawing.Size(219, 24)
        Me.dtIssue.TabIndex = 10
        Me.dtIssue.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 136)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Drawings Found:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 401)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Design Change Request:"
        '
        'btnClearECR
        '
        Me.btnClearECR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearECR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearECR.ForeColor = System.Drawing.Color.Indigo
        Me.btnClearECR.Location = New System.Drawing.Point(809, 64)
        Me.btnClearECR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClearECR.Name = "btnClearECR"
        Me.btnClearECR.Size = New System.Drawing.Size(93, 32)
        Me.btnClearECR.TabIndex = 4
        Me.btnClearECR.Text = "Reset  ECR"
        Me.btnClearECR.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(88, 544)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 42)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSubmit.Location = New System.Drawing.Point(747, 544)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 42)
        Me.btnSubmit.TabIndex = 31
        Me.btnSubmit.Text = "Submit to Engineering"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClearDwg
        '
        Me.btnClearDwg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClearDwg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearDwg.ForeColor = System.Drawing.Color.Blue
        Me.btnClearDwg.Location = New System.Drawing.Point(363, 105)
        Me.btnClearDwg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClearDwg.Name = "btnClearDwg"
        Me.btnClearDwg.Size = New System.Drawing.Size(87, 26)
        Me.btnClearDwg.TabIndex = 13
        Me.btnClearDwg.Text = "Clear"
        Me.btnClearDwg.UseVisualStyleBackColor = True
        '
        'btnAddDwg
        '
        Me.btnAddDwg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddDwg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDwg.ForeColor = System.Drawing.Color.Blue
        Me.btnAddDwg.Location = New System.Drawing.Point(211, 105)
        Me.btnAddDwg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddDwg.Name = "btnAddDwg"
        Me.btnAddDwg.Size = New System.Drawing.Size(87, 26)
        Me.btnAddDwg.TabIndex = 12
        Me.btnAddDwg.Text = "Add Dwg"
        Me.btnAddDwg.UseVisualStyleBackColor = True
        '
        'btnUpdateDwg
        '
        Me.btnUpdateDwg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdateDwg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateDwg.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdateDwg.Location = New System.Drawing.Point(515, 105)
        Me.btnUpdateDwg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdateDwg.Name = "btnUpdateDwg"
        Me.btnUpdateDwg.Size = New System.Drawing.Size(87, 26)
        Me.btnUpdateDwg.TabIndex = 14
        Me.btnUpdateDwg.Text = "Update Dwg"
        Me.btnUpdateDwg.UseVisualStyleBackColor = True
        '
        'btnDeleteDwg
        '
        Me.btnDeleteDwg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteDwg.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteDwg.ForeColor = System.Drawing.Color.Blue
        Me.btnDeleteDwg.Location = New System.Drawing.Point(667, 105)
        Me.btnDeleteDwg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteDwg.Name = "btnDeleteDwg"
        Me.btnDeleteDwg.Size = New System.Drawing.Size(87, 26)
        Me.btnDeleteDwg.TabIndex = 15
        Me.btnDeleteDwg.Text = "Delete Dwg"
        Me.btnDeleteDwg.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(356, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(331, 23)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Engineering Change Request/Approve"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(462, 746)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 37)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSearchECR
        '
        Me.btnSearchECR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchECR.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchECR.ForeColor = System.Drawing.Color.Indigo
        Me.btnSearchECR.Location = New System.Drawing.Point(705, 64)
        Me.btnSearchECR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearchECR.Name = "btnSearchECR"
        Me.btnSearchECR.Size = New System.Drawing.Size(93, 32)
        Me.btnSearchECR.TabIndex = 3
        Me.btnSearchECR.Text = "Search ECR"
        Me.btnSearchECR.UseVisualStyleBackColor = True
        '
        'chk1DwgErr
        '
        Me.chk1DwgErr.AutoSize = True
        Me.chk1DwgErr.Location = New System.Drawing.Point(14, 24)
        Me.chk1DwgErr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk1DwgErr.Name = "chk1DwgErr"
        Me.chk1DwgErr.Size = New System.Drawing.Size(134, 21)
        Me.chk1DwgErr.TabIndex = 19
        Me.chk1DwgErr.Text = "[0] Drawing Error"
        Me.chk1DwgErr.UseVisualStyleBackColor = True
        '
        'chk2Cost
        '
        Me.chk2Cost.AutoSize = True
        Me.chk2Cost.Location = New System.Drawing.Point(14, 51)
        Me.chk2Cost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk2Cost.Name = "chk2Cost"
        Me.chk2Cost.Size = New System.Drawing.Size(143, 21)
        Me.chk2Cost.TabIndex = 20
        Me.chk2Cost.Text = "[1] Cost Reduction"
        Me.chk2Cost.UseVisualStyleBackColor = True
        '
        'chk3MfgImp
        '
        Me.chk3MfgImp.AutoSize = True
        Me.chk3MfgImp.Location = New System.Drawing.Point(14, 79)
        Me.chk3MfgImp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk3MfgImp.Name = "chk3MfgImp"
        Me.chk3MfgImp.Size = New System.Drawing.Size(192, 21)
        Me.chk3MfgImp.TabIndex = 21
        Me.chk3MfgImp.Text = "[2] Mfg/Assy Improvement"
        Me.chk3MfgImp.UseVisualStyleBackColor = True
        '
        'chk4Change
        '
        Me.chk4Change.AutoSize = True
        Me.chk4Change.Location = New System.Drawing.Point(14, 106)
        Me.chk4Change.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk4Change.Name = "chk4Change"
        Me.chk4Change.Size = New System.Drawing.Size(129, 21)
        Me.chk4Change.TabIndex = 22
        Me.chk4Change.Text = "[3] Change Note"
        Me.chk4Change.UseVisualStyleBackColor = True
        '
        'chk5Quality
        '
        Me.chk5Quality.AutoSize = True
        Me.chk5Quality.Location = New System.Drawing.Point(14, 134)
        Me.chk5Quality.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk5Quality.Name = "chk5Quality"
        Me.chk5Quality.Size = New System.Drawing.Size(150, 21)
        Me.chk5Quality.TabIndex = 23
        Me.chk5Quality.Text = "[4] Reliability/Quality"
        Me.chk5Quality.UseVisualStyleBackColor = True
        '
        'chk6Clari
        '
        Me.chk6Clari.AutoSize = True
        Me.chk6Clari.Location = New System.Drawing.Point(14, 162)
        Me.chk6Clari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk6Clari.Name = "chk6Clari"
        Me.chk6Clari.Size = New System.Drawing.Size(171, 21)
        Me.chk6Clari.TabIndex = 24
        Me.chk6Clari.Text = "[5] Drawing Clarification"
        Me.chk6Clari.UseVisualStyleBackColor = True
        '
        'chk7Clerical
        '
        Me.chk7Clerical.AutoSize = True
        Me.chk7Clerical.Location = New System.Drawing.Point(14, 189)
        Me.chk7Clerical.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk7Clerical.Name = "chk7Clerical"
        Me.chk7Clerical.Size = New System.Drawing.Size(139, 21)
        Me.chk7Clerical.TabIndex = 25
        Me.chk7Clerical.Text = "[6] Clerical/Legacy"
        Me.chk7Clerical.UseVisualStyleBackColor = True
        '
        'chk8Design
        '
        Me.chk8Design.AutoSize = True
        Me.chk8Design.Location = New System.Drawing.Point(14, 217)
        Me.chk8Design.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk8Design.Name = "chk8Design"
        Me.chk8Design.Size = New System.Drawing.Size(172, 21)
        Me.chk8Design.TabIndex = 26
        Me.chk8Design.Text = "[7] Design Requirement"
        Me.chk8Design.UseVisualStyleBackColor = True
        '
        'chk9Release
        '
        Me.chk9Release.AutoSize = True
        Me.chk9Release.Location = New System.Drawing.Point(14, 245)
        Me.chk9Release.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk9Release.Name = "chk9Release"
        Me.chk9Release.Size = New System.Drawing.Size(124, 21)
        Me.chk9Release.TabIndex = 27
        Me.chk9Release.Text = "[8] New Release"
        Me.chk9Release.UseVisualStyleBackColor = True
        '
        'chk10Reject
        '
        Me.chk10Reject.AutoSize = True
        Me.chk10Reject.Location = New System.Drawing.Point(14, 272)
        Me.chk10Reject.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chk10Reject.Name = "chk10Reject"
        Me.chk10Reject.Size = New System.Drawing.Size(206, 21)
        Me.chk10Reject.TabIndex = 28
        Me.chk10Reject.Text = "[9] No Change/ECR Rejected"
        Me.chk10Reject.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnChkBoxClear)
        Me.GroupBox1.Controls.Add(Me.chk1DwgErr)
        Me.GroupBox1.Controls.Add(Me.chk10Reject)
        Me.GroupBox1.Controls.Add(Me.chk2Cost)
        Me.GroupBox1.Controls.Add(Me.chk9Release)
        Me.GroupBox1.Controls.Add(Me.chk3MfgImp)
        Me.GroupBox1.Controls.Add(Me.chk8Design)
        Me.GroupBox1.Controls.Add(Me.chk4Change)
        Me.GroupBox1.Controls.Add(Me.chk7Clerical)
        Me.GroupBox1.Controls.Add(Me.chk5Quality)
        Me.GroupBox1.Controls.Add(Me.chk6Clari)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(747, 145)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(224, 302)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reason for Change:"
        '
        'btnChkBoxClear
        '
        Me.btnChkBoxClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChkBoxClear.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChkBoxClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnChkBoxClear.Location = New System.Drawing.Point(170, 17)
        Me.btnChkBoxClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnChkBoxClear.Name = "btnChkBoxClear"
        Me.btnChkBoxClear.Size = New System.Drawing.Size(47, 29)
        Me.btnChkBoxClear.TabIndex = 29
        Me.btnChkBoxClear.Text = "Clear"
        Me.btnChkBoxClear.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 107)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(995, 628)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.txtJobNo)
        Me.TabPage1.Controls.Add(Me.btnClrRequest)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dtNeedBy)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtRev)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.dtIssue)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.gridDwgs)
        Me.TabPage1.Controls.Add(Me.btnDeleteDwg)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnUpdateDwg)
        Me.TabPage1.Controls.Add(Me.btnAddDwg)
        Me.TabPage1.Controls.Add(Me.txtDwgNo)
        Me.TabPage1.Controls.Add(Me.btnClearDwg)
        Me.TabPage1.Controls.Add(Me.txtTitle)
        Me.TabPage1.Controls.Add(Me.btnSubmit)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.txtReq)
        Me.TabPage1.Controls.Add(Me.txtComments)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(987, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Request"
        '
        'txtJobNo
        '
        Me.txtJobNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtJobNo.Location = New System.Drawing.Point(457, 33)
        Me.txtJobNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJobNo.Mask = "0000-00"
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(152, 24)
        Me.txtJobNo.TabIndex = 8
        '
        'btnClrRequest
        '
        Me.btnClrRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClrRequest.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrRequest.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrRequest.Location = New System.Drawing.Point(687, 418)
        Me.btnClrRequest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrRequest.Name = "btnClrRequest"
        Me.btnClrRequest.Size = New System.Drawing.Size(47, 29)
        Me.btnClrRequest.TabIndex = 18
        Me.btnClrRequest.Text = "Clear"
        Me.btnClrRequest.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Bisque
        Me.TabPage2.Controls.Add(Me.btnSaveApp)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.btnApproveSubmit)
        Me.TabPage2.Controls.Add(Me.txtReviews)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.btnClrRev)
        Me.TabPage2.Controls.Add(Me.dtReview)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.cboReviewBy)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(987, 598)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Approve"
        '
        'btnSaveApp
        '
        Me.btnSaveApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveApp.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveApp.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSaveApp.Location = New System.Drawing.Point(857, 423)
        Me.btnSaveApp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveApp.Name = "btnSaveApp"
        Me.btnSaveApp.Size = New System.Drawing.Size(99, 42)
        Me.btnSaveApp.TabIndex = 39
        Me.btnSaveApp.Text = "Save"
        Me.btnSaveApp.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.btnClrVer)
        Me.GroupBox6.Controls.Add(Me.dtVerfied)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.cboVerifiedBy)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(571, 318)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(408, 70)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 20)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 17)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Verified By:"
        '
        'btnClrVer
        '
        Me.btnClrVer.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrVer.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrVer.Location = New System.Drawing.Point(338, 22)
        Me.btnClrVer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrVer.Name = "btnClrVer"
        Me.btnClrVer.Size = New System.Drawing.Size(47, 29)
        Me.btnClrVer.TabIndex = 26
        Me.btnClrVer.Text = "Clear"
        Me.btnClrVer.UseVisualStyleBackColor = True
        '
        'dtVerfied
        '
        Me.dtVerfied.CustomFormat = "MM/dd/yyyy"
        Me.dtVerfied.Location = New System.Drawing.Point(92, 41)
        Me.dtVerfied.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtVerfied.Name = "dtVerfied"
        Me.dtVerfied.Size = New System.Drawing.Size(218, 24)
        Me.dtVerfied.TabIndex = 25
        Me.dtVerfied.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(46, 46)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 17)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Date:"
        '
        'cboVerifiedBy
        '
        Me.cboVerifiedBy.FormattingEnabled = True
        Me.cboVerifiedBy.Location = New System.Drawing.Point(92, 17)
        Me.cboVerifiedBy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboVerifiedBy.Name = "cboVerifiedBy"
        Me.cboVerifiedBy.Size = New System.Drawing.Size(218, 25)
        Me.cboVerifiedBy.TabIndex = 24
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.lblDProd)
        Me.GroupBox5.Controls.Add(Me.lblDLogistics)
        Me.GroupBox5.Controls.Add(Me.lblDQuantity)
        Me.GroupBox5.Controls.Add(Me.lblDAcc)
        Me.GroupBox5.Controls.Add(Me.lblDPurch)
        Me.GroupBox5.Controls.Add(Me.lblDEngg)
        Me.GroupBox5.Controls.Add(Me.lblProd)
        Me.GroupBox5.Controls.Add(Me.lblLogistics)
        Me.GroupBox5.Controls.Add(Me.lblQuantity)
        Me.GroupBox5.Controls.Add(Me.lblAcc)
        Me.GroupBox5.Controls.Add(Me.lblPurch)
        Me.GroupBox5.Controls.Add(Me.lblEngg)
        Me.GroupBox5.Controls.Add(Me.btnClrProd)
        Me.GroupBox5.Controls.Add(Me.btnClrLogistics)
        Me.GroupBox5.Controls.Add(Me.btnClrQuality)
        Me.GroupBox5.Controls.Add(Me.btnClrAcc)
        Me.GroupBox5.Controls.Add(Me.btnClrPurch)
        Me.GroupBox5.Controls.Add(Me.btnClrEngg)
        Me.GroupBox5.Controls.Add(Me.lblClickProd)
        Me.GroupBox5.Controls.Add(Me.lblClickLogistics)
        Me.GroupBox5.Controls.Add(Me.lblClickQuality)
        Me.GroupBox5.Controls.Add(Me.lblClickAcc)
        Me.GroupBox5.Controls.Add(Me.lblClickPurch)
        Me.GroupBox5.Controls.Add(Me.lblClickEngg)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(19, 406)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(813, 154)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Approvals"
        '
        'lblDProd
        '
        Me.lblDProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDProd.AutoSize = True
        Me.lblDProd.Location = New System.Drawing.Point(699, 119)
        Me.lblDProd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDProd.Name = "lblDProd"
        Me.lblDProd.Size = New System.Drawing.Size(42, 17)
        Me.lblDProd.TabIndex = 54
        Me.lblDProd.Text = "Date:"
        '
        'lblDLogistics
        '
        Me.lblDLogistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDLogistics.AutoSize = True
        Me.lblDLogistics.Location = New System.Drawing.Point(699, 76)
        Me.lblDLogistics.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDLogistics.Name = "lblDLogistics"
        Me.lblDLogistics.Size = New System.Drawing.Size(42, 17)
        Me.lblDLogistics.TabIndex = 53
        Me.lblDLogistics.Text = "Date:"
        '
        'lblDQuantity
        '
        Me.lblDQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDQuantity.AutoSize = True
        Me.lblDQuantity.Location = New System.Drawing.Point(699, 34)
        Me.lblDQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDQuantity.Name = "lblDQuantity"
        Me.lblDQuantity.Size = New System.Drawing.Size(42, 17)
        Me.lblDQuantity.TabIndex = 52
        Me.lblDQuantity.Text = "Date:"
        '
        'lblDAcc
        '
        Me.lblDAcc.AutoSize = True
        Me.lblDAcc.Location = New System.Drawing.Point(271, 118)
        Me.lblDAcc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDAcc.Name = "lblDAcc"
        Me.lblDAcc.Size = New System.Drawing.Size(42, 17)
        Me.lblDAcc.TabIndex = 51
        Me.lblDAcc.Text = "Date:"
        '
        'lblDPurch
        '
        Me.lblDPurch.AutoSize = True
        Me.lblDPurch.Location = New System.Drawing.Point(271, 76)
        Me.lblDPurch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDPurch.Name = "lblDPurch"
        Me.lblDPurch.Size = New System.Drawing.Size(42, 17)
        Me.lblDPurch.TabIndex = 50
        Me.lblDPurch.Text = "Date:"
        '
        'lblDEngg
        '
        Me.lblDEngg.AutoSize = True
        Me.lblDEngg.Location = New System.Drawing.Point(271, 33)
        Me.lblDEngg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDEngg.Name = "lblDEngg"
        Me.lblDEngg.Size = New System.Drawing.Size(42, 17)
        Me.lblDEngg.TabIndex = 35
        Me.lblDEngg.Text = "Date:"
        '
        'lblProd
        '
        Me.lblProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProd.BackColor = System.Drawing.Color.Tan
        Me.lblProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProd.Location = New System.Drawing.Point(597, 118)
        Me.lblProd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(90, 18)
        Me.lblProd.TabIndex = 37
        '
        'lblLogistics
        '
        Me.lblLogistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogistics.BackColor = System.Drawing.Color.Tan
        Me.lblLogistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogistics.Location = New System.Drawing.Point(597, 76)
        Me.lblLogistics.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogistics.Name = "lblLogistics"
        Me.lblLogistics.Size = New System.Drawing.Size(90, 18)
        Me.lblLogistics.TabIndex = 35
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantity.BackColor = System.Drawing.Color.Tan
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Location = New System.Drawing.Point(597, 32)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(90, 18)
        Me.lblQuantity.TabIndex = 33
        '
        'lblAcc
        '
        Me.lblAcc.BackColor = System.Drawing.Color.Tan
        Me.lblAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAcc.Location = New System.Drawing.Point(172, 117)
        Me.lblAcc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(90, 18)
        Me.lblAcc.TabIndex = 31
        '
        'lblPurch
        '
        Me.lblPurch.BackColor = System.Drawing.Color.Tan
        Me.lblPurch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPurch.Location = New System.Drawing.Point(172, 75)
        Me.lblPurch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPurch.Name = "lblPurch"
        Me.lblPurch.Size = New System.Drawing.Size(90, 18)
        Me.lblPurch.TabIndex = 29
        '
        'lblEngg
        '
        Me.lblEngg.BackColor = System.Drawing.Color.Tan
        Me.lblEngg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEngg.Location = New System.Drawing.Point(172, 32)
        Me.lblEngg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEngg.Name = "lblEngg"
        Me.lblEngg.Size = New System.Drawing.Size(90, 18)
        Me.lblEngg.TabIndex = 27
        '
        'btnClrProd
        '
        Me.btnClrProd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClrProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrProd.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrProd.Location = New System.Drawing.Point(485, 115)
        Me.btnClrProd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrProd.Name = "btnClrProd"
        Me.btnClrProd.Size = New System.Drawing.Size(26, 22)
        Me.btnClrProd.TabIndex = 38
        Me.btnClrProd.Text = "C"
        Me.btnClrProd.UseVisualStyleBackColor = True
        '
        'btnClrLogistics
        '
        Me.btnClrLogistics.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClrLogistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrLogistics.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrLogistics.Location = New System.Drawing.Point(485, 72)
        Me.btnClrLogistics.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrLogistics.Name = "btnClrLogistics"
        Me.btnClrLogistics.Size = New System.Drawing.Size(26, 22)
        Me.btnClrLogistics.TabIndex = 36
        Me.btnClrLogistics.Text = "C"
        Me.btnClrLogistics.UseVisualStyleBackColor = True
        '
        'btnClrQuality
        '
        Me.btnClrQuality.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClrQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrQuality.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrQuality.Location = New System.Drawing.Point(485, 26)
        Me.btnClrQuality.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrQuality.Name = "btnClrQuality"
        Me.btnClrQuality.Size = New System.Drawing.Size(26, 22)
        Me.btnClrQuality.TabIndex = 34
        Me.btnClrQuality.Text = "C"
        Me.btnClrQuality.UseVisualStyleBackColor = True
        '
        'btnClrAcc
        '
        Me.btnClrAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrAcc.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrAcc.Location = New System.Drawing.Point(52, 114)
        Me.btnClrAcc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrAcc.Name = "btnClrAcc"
        Me.btnClrAcc.Size = New System.Drawing.Size(26, 22)
        Me.btnClrAcc.TabIndex = 32
        Me.btnClrAcc.Text = "C"
        Me.btnClrAcc.UseVisualStyleBackColor = True
        '
        'btnClrPurch
        '
        Me.btnClrPurch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrPurch.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrPurch.Location = New System.Drawing.Point(52, 71)
        Me.btnClrPurch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrPurch.Name = "btnClrPurch"
        Me.btnClrPurch.Size = New System.Drawing.Size(26, 22)
        Me.btnClrPurch.TabIndex = 30
        Me.btnClrPurch.Text = "C"
        Me.btnClrPurch.UseVisualStyleBackColor = True
        '
        'btnClrEngg
        '
        Me.btnClrEngg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrEngg.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrEngg.Location = New System.Drawing.Point(52, 25)
        Me.btnClrEngg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrEngg.Name = "btnClrEngg"
        Me.btnClrEngg.Size = New System.Drawing.Size(26, 22)
        Me.btnClrEngg.TabIndex = 28
        Me.btnClrEngg.Text = "C"
        Me.btnClrEngg.UseVisualStyleBackColor = True
        '
        'lblClickProd
        '
        Me.lblClickProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClickProd.AutoSize = True
        Me.lblClickProd.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickProd.Location = New System.Drawing.Point(515, 119)
        Me.lblClickProd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickProd.Name = "lblClickProd"
        Me.lblClickProd.Size = New System.Drawing.Size(80, 17)
        Me.lblClickProd.TabIndex = 5
        Me.lblClickProd.Text = "Production:"
        '
        'lblClickLogistics
        '
        Me.lblClickLogistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClickLogistics.AutoSize = True
        Me.lblClickLogistics.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickLogistics.Location = New System.Drawing.Point(515, 76)
        Me.lblClickLogistics.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickLogistics.Name = "lblClickLogistics"
        Me.lblClickLogistics.Size = New System.Drawing.Size(64, 17)
        Me.lblClickLogistics.TabIndex = 4
        Me.lblClickLogistics.Text = "Logistics:"
        '
        'lblClickQuality
        '
        Me.lblClickQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClickQuality.AutoSize = True
        Me.lblClickQuality.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickQuality.Location = New System.Drawing.Point(515, 30)
        Me.lblClickQuality.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickQuality.Name = "lblClickQuality"
        Me.lblClickQuality.Size = New System.Drawing.Size(55, 17)
        Me.lblClickQuality.TabIndex = 3
        Me.lblClickQuality.Text = "Quality:"
        '
        'lblClickAcc
        '
        Me.lblClickAcc.AutoSize = True
        Me.lblClickAcc.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickAcc.Location = New System.Drawing.Point(83, 118)
        Me.lblClickAcc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickAcc.Name = "lblClickAcc"
        Me.lblClickAcc.Size = New System.Drawing.Size(82, 17)
        Me.lblClickAcc.TabIndex = 2
        Me.lblClickAcc.Text = "Accounting:"
        '
        'lblClickPurch
        '
        Me.lblClickPurch.AutoSize = True
        Me.lblClickPurch.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickPurch.Location = New System.Drawing.Point(83, 75)
        Me.lblClickPurch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickPurch.Name = "lblClickPurch"
        Me.lblClickPurch.Size = New System.Drawing.Size(80, 17)
        Me.lblClickPurch.TabIndex = 1
        Me.lblClickPurch.Text = "Purchasing:"
        '
        'lblClickEngg
        '
        Me.lblClickEngg.AutoSize = True
        Me.lblClickEngg.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickEngg.Location = New System.Drawing.Point(83, 29)
        Me.lblClickEngg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClickEngg.Name = "lblClickEngg"
        Me.lblClickEngg.Size = New System.Drawing.Size(84, 17)
        Me.lblClickEngg.TabIndex = 0
        Me.lblClickEngg.Text = "Engineering:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox4.Controls.Add(Me.dtImplementation)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(571, 184)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(408, 72)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Implementation Parts"
        '
        'dtImplementation
        '
        Me.dtImplementation.CustomFormat = "MM/dd/yyyy"
        Me.dtImplementation.Location = New System.Drawing.Point(92, 35)
        Me.dtImplementation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtImplementation.Name = "dtImplementation"
        Me.dtImplementation.Size = New System.Drawing.Size(218, 24)
        Me.dtImplementation.TabIndex = 22
        Me.dtImplementation.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(42, 35)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 17)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 163)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 17)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Reviewer Comments:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cboUnits)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtCost)
        Me.GroupBox3.Controls.Add(Me.txtEnggHrs)
        Me.GroupBox3.Controls.Add(Me.txtProdHrs)
        Me.GroupBox3.Controls.Add(Me.rdoRTV)
        Me.GroupBox3.Controls.Add(Me.rdoModify)
        Me.GroupBox3.Controls.Add(Me.rdoNoAffect)
        Me.GroupBox3.Controls.Add(Me.rdoScrap)
        Me.GroupBox3.Controls.Add(Me.rdoUseAsIs)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(537, 16)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(366, 141)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Disposition of Affected Parts"
        '
        'cboUnits
        '
        Me.cboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnits.FormattingEnabled = True
        Me.cboUnits.Location = New System.Drawing.Point(273, 114)
        Me.cboUnits.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboUnits.Name = "cboUnits"
        Me.cboUnits.Size = New System.Drawing.Size(76, 25)
        Me.cboUnits.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(226, 117)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 17)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Units:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(149, 93)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 17)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Quantity Affected:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(273, 89)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(76, 24)
        Me.txtQuantity.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(166, 68)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Cost-Material $:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(199, 44)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 17)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Engg-Hrs:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(202, 20)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Prod-Hrs:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(273, 65)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(76, 24)
        Me.txtCost.TabIndex = 17
        '
        'txtEnggHrs
        '
        Me.txtEnggHrs.Location = New System.Drawing.Point(273, 41)
        Me.txtEnggHrs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEnggHrs.Name = "txtEnggHrs"
        Me.txtEnggHrs.Size = New System.Drawing.Size(76, 24)
        Me.txtEnggHrs.TabIndex = 16
        '
        'txtProdHrs
        '
        Me.txtProdHrs.Location = New System.Drawing.Point(273, 16)
        Me.txtProdHrs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtProdHrs.Name = "txtProdHrs"
        Me.txtProdHrs.Size = New System.Drawing.Size(76, 24)
        Me.txtProdHrs.TabIndex = 15
        '
        'rdoRTV
        '
        Me.rdoRTV.AutoSize = True
        Me.rdoRTV.Location = New System.Drawing.Point(14, 110)
        Me.rdoRTV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoRTV.Name = "rdoRTV"
        Me.rdoRTV.Size = New System.Drawing.Size(51, 21)
        Me.rdoRTV.TabIndex = 14
        Me.rdoRTV.TabStop = True
        Me.rdoRTV.Text = "RTV"
        Me.rdoRTV.UseVisualStyleBackColor = True
        '
        'rdoModify
        '
        Me.rdoModify.AutoSize = True
        Me.rdoModify.Location = New System.Drawing.Point(14, 64)
        Me.rdoModify.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoModify.Name = "rdoModify"
        Me.rdoModify.Size = New System.Drawing.Size(152, 21)
        Me.rdoModify.TabIndex = 12
        Me.rdoModify.TabStop = True
        Me.rdoModify.Text = "Modify/Rework Parts"
        Me.rdoModify.UseVisualStyleBackColor = True
        '
        'rdoNoAffect
        '
        Me.rdoNoAffect.AutoSize = True
        Me.rdoNoAffect.Location = New System.Drawing.Point(14, 41)
        Me.rdoNoAffect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoNoAffect.Name = "rdoNoAffect"
        Me.rdoNoAffect.Size = New System.Drawing.Size(132, 21)
        Me.rdoNoAffect.TabIndex = 11
        Me.rdoNoAffect.TabStop = True
        Me.rdoNoAffect.Text = "No Parts Affected"
        Me.rdoNoAffect.UseVisualStyleBackColor = True
        '
        'rdoScrap
        '
        Me.rdoScrap.AutoSize = True
        Me.rdoScrap.Location = New System.Drawing.Point(14, 87)
        Me.rdoScrap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoScrap.Name = "rdoScrap"
        Me.rdoScrap.Size = New System.Drawing.Size(61, 21)
        Me.rdoScrap.TabIndex = 13
        Me.rdoScrap.TabStop = True
        Me.rdoScrap.Text = "Scrap"
        Me.rdoScrap.UseVisualStyleBackColor = True
        '
        'rdoUseAsIs
        '
        Me.rdoUseAsIs.AutoSize = True
        Me.rdoUseAsIs.Location = New System.Drawing.Point(14, 19)
        Me.rdoUseAsIs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoUseAsIs.Name = "rdoUseAsIs"
        Me.rdoUseAsIs.Size = New System.Drawing.Size(81, 21)
        Me.rdoUseAsIs.TabIndex = 10
        Me.rdoUseAsIs.TabStop = True
        Me.rdoUseAsIs.Text = "Use As-Is"
        Me.rdoUseAsIs.UseVisualStyleBackColor = True
        '
        'btnApproveSubmit
        '
        Me.btnApproveSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApproveSubmit.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveSubmit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnApproveSubmit.Location = New System.Drawing.Point(857, 509)
        Me.btnApproveSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnApproveSubmit.Name = "btnApproveSubmit"
        Me.btnApproveSubmit.Size = New System.Drawing.Size(99, 42)
        Me.btnApproveSubmit.TabIndex = 40
        Me.btnApproveSubmit.Text = "Submit"
        Me.btnApproveSubmit.UseVisualStyleBackColor = True
        '
        'txtReviews
        '
        Me.txtReviews.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReviews.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReviews.Location = New System.Drawing.Point(18, 184)
        Me.txtReviews.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReviews.Multiline = True
        Me.txtReviews.Name = "txtReviews"
        Me.txtReviews.Size = New System.Drawing.Size(537, 204)
        Me.txtReviews.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.rdoNotAccepted)
        Me.GroupBox2.Controls.Add(Me.rdoWithMods)
        Me.GroupBox2.Controls.Add(Me.rdoAccepted)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(321, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 141)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Review"
        '
        'rdoNotAccepted
        '
        Me.rdoNotAccepted.AutoSize = True
        Me.rdoNotAccepted.Location = New System.Drawing.Point(5, 109)
        Me.rdoNotAccepted.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoNotAccepted.Name = "rdoNotAccepted"
        Me.rdoNotAccepted.Size = New System.Drawing.Size(109, 21)
        Me.rdoNotAccepted.TabIndex = 9
        Me.rdoNotAccepted.TabStop = True
        Me.rdoNotAccepted.Text = "Not Accepted"
        Me.rdoNotAccepted.UseVisualStyleBackColor = True
        '
        'rdoWithMods
        '
        Me.rdoWithMods.AutoSize = True
        Me.rdoWithMods.Location = New System.Drawing.Point(5, 63)
        Me.rdoWithMods.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoWithMods.Name = "rdoWithMods"
        Me.rdoWithMods.Size = New System.Drawing.Size(191, 21)
        Me.rdoWithMods.TabIndex = 8
        Me.rdoWithMods.TabStop = True
        Me.rdoWithMods.Text = "Accepted with Modifcations"
        Me.rdoWithMods.UseVisualStyleBackColor = True
        '
        'rdoAccepted
        '
        Me.rdoAccepted.AutoSize = True
        Me.rdoAccepted.Location = New System.Drawing.Point(5, 18)
        Me.rdoAccepted.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoAccepted.Name = "rdoAccepted"
        Me.rdoAccepted.Size = New System.Drawing.Size(83, 21)
        Me.rdoAccepted.TabIndex = 7
        Me.rdoAccepted.TabStop = True
        Me.rdoAccepted.Text = "Accepted"
        Me.rdoAccepted.UseVisualStyleBackColor = True
        '
        'btnClrRev
        '
        Me.btnClrRev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClrRev.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrRev.ForeColor = System.Drawing.Color.Maroon
        Me.btnClrRev.Location = New System.Drawing.Point(918, 76)
        Me.btnClrRev.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClrRev.Name = "btnClrRev"
        Me.btnClrRev.Size = New System.Drawing.Size(47, 29)
        Me.btnClrRev.TabIndex = 20
        Me.btnClrRev.Text = "Clear"
        Me.btnClrRev.UseVisualStyleBackColor = True
        '
        'dtReview
        '
        Me.dtReview.CustomFormat = "MM/dd/yyyy"
        Me.dtReview.Location = New System.Drawing.Point(102, 119)
        Me.dtReview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtReview.Name = "dtReview"
        Me.dtReview.Size = New System.Drawing.Size(202, 24)
        Me.dtReview.TabIndex = 6
        Me.dtReview.Value = New Date(2019, 12, 25, 23, 59, 59, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 119)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Review date:"
        '
        'cboReviewBy
        '
        Me.cboReviewBy.FormattingEnabled = True
        Me.cboReviewBy.Location = New System.Drawing.Point(102, 34)
        Me.cboReviewBy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReviewBy.Name = "cboReviewBy"
        Me.cboReviewBy.Size = New System.Drawing.Size(202, 25)
        Me.cboReviewBy.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 37)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Reviewer:"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(535, 72)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 21)
        Me.lblStatus.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(483, 72)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Status:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(190, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ECR #:"
        '
        'txtECRNo
        '
        Me.txtECRNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtECRNo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECRNo.Location = New System.Drawing.Point(242, 72)
        Me.txtECRNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtECRNo.Name = "txtECRNo"
        Me.txtECRNo.Size = New System.Drawing.Size(204, 24)
        Me.txtECRNo.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 798)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSearchECR)
        Me.Controls.Add(Me.txtECRNo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnClearECR)
        Me.Controls.Add(Me.lblStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(1008, 836)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ECR Program"
        CType(Me.gridDwgs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDwgNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtRev As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReq As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gridDwgs As DataGridView
    Friend WithEvents txtComments As TextBox
    Friend WithEvents dtNeedBy As DateTimePicker
    Friend WithEvents dtIssue As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClearECR As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClearDwg As Button
    Friend WithEvents btnAddDwg As Button
    Friend WithEvents btnUpdateDwg As Button
    Friend WithEvents btnDeleteDwg As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearchECR As Button
    Friend WithEvents chk1DwgErr As CheckBox
    Friend WithEvents chk2Cost As CheckBox
    Friend WithEvents chk3MfgImp As CheckBox
    Friend WithEvents chk4Change As CheckBox
    Friend WithEvents chk5Quality As CheckBox
    Friend WithEvents chk6Clari As CheckBox
    Friend WithEvents chk7Clerical As CheckBox
    Friend WithEvents chk8Design As CheckBox
    Friend WithEvents chk9Release As CheckBox
    Friend WithEvents chk10Reject As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboReviewBy As ComboBox
    Friend WithEvents dtReview As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoNotAccepted As RadioButton
    Friend WithEvents rdoWithMods As RadioButton
    Friend WithEvents rdoAccepted As RadioButton
    Friend WithEvents btnClrRev As Button
    Friend WithEvents DwgNo As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Rev As DataGridViewTextBoxColumn
    Friend WithEvents btnApproveSubmit As Button
    Friend WithEvents txtReviews As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents btnClrVer As Button
    Friend WithEvents dtVerfied As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents cboVerifiedBy As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtImplementation As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtEnggHrs As TextBox
    Friend WithEvents txtProdHrs As TextBox
    Friend WithEvents rdoRTV As RadioButton
    Friend WithEvents rdoModify As RadioButton
    Friend WithEvents rdoNoAffect As RadioButton
    Friend WithEvents rdoScrap As RadioButton
    Friend WithEvents rdoUseAsIs As RadioButton
    Friend WithEvents btnSaveApp As Button
    Friend WithEvents lblDProd As Label
    Friend WithEvents lblDLogistics As Label
    Friend WithEvents lblDQuantity As Label
    Friend WithEvents lblDAcc As Label
    Friend WithEvents lblDPurch As Label
    Friend WithEvents lblDEngg As Label
    Friend WithEvents lblProd As Label
    Friend WithEvents lblLogistics As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAcc As Label
    Friend WithEvents lblPurch As Label
    Friend WithEvents lblEngg As Label
    Friend WithEvents btnClrProd As Button
    Friend WithEvents btnClrLogistics As Button
    Friend WithEvents btnClrQuality As Button
    Friend WithEvents btnClrAcc As Button
    Friend WithEvents btnClrPurch As Button
    Friend WithEvents btnClrEngg As Button
    Friend WithEvents lblClickProd As Label
    Friend WithEvents lblClickLogistics As Label
    Friend WithEvents lblClickQuality As Label
    Friend WithEvents lblClickAcc As Label
    Friend WithEvents lblClickPurch As Label
    Friend WithEvents lblClickEngg As Label
    Friend WithEvents cboUnits As ComboBox
    Friend WithEvents txtECRNo As TextBox
    Friend WithEvents btnChkBoxClear As Button
    Friend WithEvents btnClrRequest As Button
    Friend WithEvents txtJobNo As MaskedTextBox
End Class
