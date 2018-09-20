<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.btnSelectDates = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdo1DrawingError = New System.Windows.Forms.RadioButton()
        Me.rdo2CostRed = New System.Windows.Forms.RadioButton()
        Me.rdo3MfgAssyImp = New System.Windows.Forms.RadioButton()
        Me.rdo4ChangeNote = New System.Windows.Forms.RadioButton()
        Me.rdo5Quality = New System.Windows.Forms.RadioButton()
        Me.rdo6DwgClari = New System.Windows.Forms.RadioButton()
        Me.rdo7Clerical = New System.Windows.Forms.RadioButton()
        Me.rdo8DesReq = New System.Windows.Forms.RadioButton()
        Me.rdo9NewRelease = New System.Windows.Forms.RadioButton()
        Me.rdo10NoChange = New System.Windows.Forms.RadioButton()
        Me.gridDwgs2 = New System.Windows.Forms.DataGridView()
        Me.rdo10Any = New System.Windows.Forms.RadioButton()
        Me.ECR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Request = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requestor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridDwgs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(372, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 29)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "ECR Numbers"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(135, 682)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 58)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelect.Location = New System.Drawing.Point(632, 682)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(136, 58)
        Me.btnSelect.TabIndex = 40
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "To:"
        '
        'dtFrom
        '
        Me.dtFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Location = New System.Drawing.Point(76, 106)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(183, 28)
        Me.dtFrom.TabIndex = 47
        Me.dtFrom.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'dtTo
        '
        Me.dtTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtTo.CustomFormat = "MM/dd/yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Location = New System.Drawing.Point(76, 159)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(183, 28)
        Me.dtTo.TabIndex = 48
        Me.dtTo.Value = New Date(2017, 2, 21, 0, 0, 0, 0)
        '
        'btnSelectDates
        '
        Me.btnSelectDates.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelectDates.Location = New System.Drawing.Point(100, 233)
        Me.btnSelectDates.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelectDates.Name = "btnSelectDates"
        Me.btnSelectDates.Size = New System.Drawing.Size(136, 58)
        Me.btnSelectDates.TabIndex = 49
        Me.btnSelectDates.Text = "Search"
        Me.btnSelectDates.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtTo)
        Me.GroupBox1.Controls.Add(Me.btnSelectDates)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(868, 334)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Date Range:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.rdo10Any)
        Me.GroupBox2.Controls.Add(Me.rdo10NoChange)
        Me.GroupBox2.Controls.Add(Me.rdo9NewRelease)
        Me.GroupBox2.Controls.Add(Me.rdo8DesReq)
        Me.GroupBox2.Controls.Add(Me.rdo7Clerical)
        Me.GroupBox2.Controls.Add(Me.rdo6DwgClari)
        Me.GroupBox2.Controls.Add(Me.rdo5Quality)
        Me.GroupBox2.Controls.Add(Me.rdo4ChangeNote)
        Me.GroupBox2.Controls.Add(Me.rdo3MfgAssyImp)
        Me.GroupBox2.Controls.Add(Me.rdo2CostRed)
        Me.GroupBox2.Controls.Add(Me.rdo1DrawingError)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(331, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 245)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reason for Change:"
        '
        'rdo1DrawingError
        '
        Me.rdo1DrawingError.AutoSize = True
        Me.rdo1DrawingError.Location = New System.Drawing.Point(20, 30)
        Me.rdo1DrawingError.Name = "rdo1DrawingError"
        Me.rdo1DrawingError.Size = New System.Drawing.Size(163, 25)
        Me.rdo1DrawingError.TabIndex = 56
        Me.rdo1DrawingError.TabStop = True
        Me.rdo1DrawingError.Text = "[0] Drawing Error"
        Me.rdo1DrawingError.UseVisualStyleBackColor = True
        '
        'rdo2CostRed
        '
        Me.rdo2CostRed.AutoSize = True
        Me.rdo2CostRed.Location = New System.Drawing.Point(20, 65)
        Me.rdo2CostRed.Name = "rdo2CostRed"
        Me.rdo2CostRed.Size = New System.Drawing.Size(171, 25)
        Me.rdo2CostRed.TabIndex = 57
        Me.rdo2CostRed.TabStop = True
        Me.rdo2CostRed.Text = "[1] Cost Reduction"
        Me.rdo2CostRed.UseVisualStyleBackColor = True
        '
        'rdo3MfgAssyImp
        '
        Me.rdo3MfgAssyImp.AutoSize = True
        Me.rdo3MfgAssyImp.Location = New System.Drawing.Point(20, 100)
        Me.rdo3MfgAssyImp.Name = "rdo3MfgAssyImp"
        Me.rdo3MfgAssyImp.Size = New System.Drawing.Size(232, 25)
        Me.rdo3MfgAssyImp.TabIndex = 58
        Me.rdo3MfgAssyImp.TabStop = True
        Me.rdo3MfgAssyImp.Text = "[2] Mfg/Assy Improvement"
        Me.rdo3MfgAssyImp.UseVisualStyleBackColor = True
        '
        'rdo4ChangeNote
        '
        Me.rdo4ChangeNote.AutoSize = True
        Me.rdo4ChangeNote.Location = New System.Drawing.Point(20, 135)
        Me.rdo4ChangeNote.Name = "rdo4ChangeNote"
        Me.rdo4ChangeNote.Size = New System.Drawing.Size(154, 25)
        Me.rdo4ChangeNote.TabIndex = 59
        Me.rdo4ChangeNote.TabStop = True
        Me.rdo4ChangeNote.Text = "[3] Change Note"
        Me.rdo4ChangeNote.UseVisualStyleBackColor = True
        '
        'rdo5Quality
        '
        Me.rdo5Quality.AutoSize = True
        Me.rdo5Quality.Location = New System.Drawing.Point(20, 170)
        Me.rdo5Quality.Name = "rdo5Quality"
        Me.rdo5Quality.Size = New System.Drawing.Size(190, 25)
        Me.rdo5Quality.TabIndex = 60
        Me.rdo5Quality.TabStop = True
        Me.rdo5Quality.Text = "[4] Reliability/Quality"
        Me.rdo5Quality.UseVisualStyleBackColor = True
        '
        'rdo6DwgClari
        '
        Me.rdo6DwgClari.AutoSize = True
        Me.rdo6DwgClari.Location = New System.Drawing.Point(255, 27)
        Me.rdo6DwgClari.Name = "rdo6DwgClari"
        Me.rdo6DwgClari.Size = New System.Drawing.Size(213, 25)
        Me.rdo6DwgClari.TabIndex = 61
        Me.rdo6DwgClari.TabStop = True
        Me.rdo6DwgClari.Text = "[5] Drawing Clarification"
        Me.rdo6DwgClari.UseVisualStyleBackColor = True
        '
        'rdo7Clerical
        '
        Me.rdo7Clerical.AutoSize = True
        Me.rdo7Clerical.Location = New System.Drawing.Point(255, 63)
        Me.rdo7Clerical.Name = "rdo7Clerical"
        Me.rdo7Clerical.Size = New System.Drawing.Size(171, 25)
        Me.rdo7Clerical.TabIndex = 62
        Me.rdo7Clerical.TabStop = True
        Me.rdo7Clerical.Text = "[6] Clerical/Legacy"
        Me.rdo7Clerical.UseVisualStyleBackColor = True
        '
        'rdo8DesReq
        '
        Me.rdo8DesReq.AutoSize = True
        Me.rdo8DesReq.Location = New System.Drawing.Point(255, 99)
        Me.rdo8DesReq.Name = "rdo8DesReq"
        Me.rdo8DesReq.Size = New System.Drawing.Size(210, 25)
        Me.rdo8DesReq.TabIndex = 63
        Me.rdo8DesReq.TabStop = True
        Me.rdo8DesReq.Text = "[7] Design Requirement"
        Me.rdo8DesReq.UseVisualStyleBackColor = True
        '
        'rdo9NewRelease
        '
        Me.rdo9NewRelease.AutoSize = True
        Me.rdo9NewRelease.Location = New System.Drawing.Point(255, 135)
        Me.rdo9NewRelease.Name = "rdo9NewRelease"
        Me.rdo9NewRelease.Size = New System.Drawing.Size(156, 25)
        Me.rdo9NewRelease.TabIndex = 64
        Me.rdo9NewRelease.TabStop = True
        Me.rdo9NewRelease.Text = "[8] New Release"
        Me.rdo9NewRelease.UseVisualStyleBackColor = True
        '
        'rdo10NoChange
        '
        Me.rdo10NoChange.AutoSize = True
        Me.rdo10NoChange.Location = New System.Drawing.Point(255, 171)
        Me.rdo10NoChange.Name = "rdo10NoChange"
        Me.rdo10NoChange.Size = New System.Drawing.Size(248, 25)
        Me.rdo10NoChange.TabIndex = 65
        Me.rdo10NoChange.TabStop = True
        Me.rdo10NoChange.Text = "[9] No Change/ECR Rejected"
        Me.rdo10NoChange.UseVisualStyleBackColor = True
        '
        'gridDwgs2
        '
        Me.gridDwgs2.AllowUserToAddRows = False
        Me.gridDwgs2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDwgs2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ECR, Me.Status, Me.JobNo, Me.Request, Me.Requestor, Me.Cat})
        Me.gridDwgs2.Location = New System.Drawing.Point(35, 432)
        Me.gridDwgs2.Name = "gridDwgs2"
        Me.gridDwgs2.RowTemplate.Height = 24
        Me.gridDwgs2.Size = New System.Drawing.Size(868, 223)
        Me.gridDwgs2.TabIndex = 51
        '
        'rdo10Any
        '
        Me.rdo10Any.AutoSize = True
        Me.rdo10Any.Location = New System.Drawing.Point(255, 207)
        Me.rdo10Any.Name = "rdo10Any"
        Me.rdo10Any.Size = New System.Drawing.Size(147, 25)
        Me.rdo10Any.TabIndex = 66
        Me.rdo10Any.TabStop = True
        Me.rdo10Any.Text = "[*] Any Reason"
        Me.rdo10Any.UseVisualStyleBackColor = True
        '
        'ECR
        '
        Me.ECR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ECR.HeaderText = "ECR"
        Me.ECR.Name = "ECR"
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'JobNo
        '
        Me.JobNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JobNo.HeaderText = "Job No"
        Me.JobNo.Name = "JobNo"
        '
        'Request
        '
        Me.Request.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Request.HeaderText = "Request"
        Me.Request.Name = "Request"
        '
        'Requestor
        '
        Me.Requestor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Requestor.HeaderText = "Requestor"
        Me.Requestor.Name = "Requestor"
        '
        'Cat
        '
        Me.Cat.HeaderText = "Cat"
        Me.Cat.Name = "Cat"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 765)
        Me.Controls.Add(Me.gridDwgs2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search for ECR Numbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.gridDwgs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents btnSelectDates As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdo10NoChange As RadioButton
    Friend WithEvents rdo9NewRelease As RadioButton
    Friend WithEvents rdo8DesReq As RadioButton
    Friend WithEvents rdo7Clerical As RadioButton
    Friend WithEvents rdo6DwgClari As RadioButton
    Friend WithEvents rdo5Quality As RadioButton
    Friend WithEvents rdo4ChangeNote As RadioButton
    Friend WithEvents rdo3MfgAssyImp As RadioButton
    Friend WithEvents rdo2CostRed As RadioButton
    Friend WithEvents rdo1DrawingError As RadioButton
    Friend WithEvents gridDwgs2 As DataGridView
    Friend WithEvents rdo10Any As RadioButton
    Friend WithEvents ECR As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents JobNo As DataGridViewTextBoxColumn
    Friend WithEvents Request As DataGridViewTextBoxColumn
    Friend WithEvents Requestor As DataGridViewTextBoxColumn
    Friend WithEvents Cat As DataGridViewTextBoxColumn
End Class
