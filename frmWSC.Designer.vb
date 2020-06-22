<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWSC
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
        Me.components = New System.ComponentModel.Container()
        Dim Office_IDLabel As System.Windows.Forms.Label
        Dim WSC_EmployeeReviewerLabel As System.Windows.Forms.Label
        Dim WSC_DateCreatedLabel As System.Windows.Forms.Label
        Dim WSC_DateLastReviewedLabel As System.Windows.Forms.Label
        Dim WSC_ActiveLabel As System.Windows.Forms.Label
        Dim WCS_ApproverLabel As System.Windows.Forms.Label
        Dim WCS_ReviewerLabel As System.Windows.Forms.Label
        Dim WCS_ApproverDateLabel As System.Windows.Forms.Label
        Dim WCS_ReviewerDateLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.WSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSCTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSCTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter()
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter()
        Me.WSC_IDTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Office_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSC_EmployeeReviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSC_DateCreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WSC_DateLastReviewedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WSC_ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.WCS_ApproverComboBox = New System.Windows.Forms.ComboBox()
        Me.WCS_ReviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.WCS_ApproverDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WCS_ReviewerDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.tStrip_WasteStreamCharacterization = New System.Windows.Forms.ToolStrip()
        Me.btn_PreviousForm = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_PathBackButton = New System.Windows.Forms.ToolStripLabel()
        Me.btn_NewWSC = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Delete = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Update = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Undo = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_WSC_F1 = New FontAwesome.Sharp.IconButton()
        Me.lbl_ReferenceName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WSC_WDB_UKnowledgeCheckBox = New System.Windows.Forms.CheckBox()
        Me.WSC_WDB_WAnalysisCheckBox = New System.Windows.Forms.CheckBox()
        Me.WCS_PCB_ContaminatedCheckBox = New System.Windows.Forms.CheckBox()
        Office_IDLabel = New System.Windows.Forms.Label()
        WSC_EmployeeReviewerLabel = New System.Windows.Forms.Label()
        WSC_DateCreatedLabel = New System.Windows.Forms.Label()
        WSC_DateLastReviewedLabel = New System.Windows.Forms.Label()
        WSC_ActiveLabel = New System.Windows.Forms.Label()
        WCS_ApproverLabel = New System.Windows.Forms.Label()
        WCS_ReviewerLabel = New System.Windows.Forms.Label()
        WCS_ApproverDateLabel = New System.Windows.Forms.Label()
        WCS_ReviewerDateLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_WasteStreamCharacterization.SuspendLayout()
        Me.SuspendLayout()
        '
        'Office_IDLabel
        '
        Office_IDLabel.AutoSize = True
        Office_IDLabel.Location = New System.Drawing.Point(141, 56)
        Office_IDLabel.Name = "Office_IDLabel"
        Office_IDLabel.Size = New System.Drawing.Size(67, 28)
        Office_IDLabel.TabIndex = 7
        Office_IDLabel.Text = "Office:"
        '
        'WSC_EmployeeReviewerLabel
        '
        WSC_EmployeeReviewerLabel.AutoSize = True
        WSC_EmployeeReviewerLabel.Location = New System.Drawing.Point(104, 106)
        WSC_EmployeeReviewerLabel.Name = "WSC_EmployeeReviewerLabel"
        WSC_EmployeeReviewerLabel.Size = New System.Drawing.Size(104, 28)
        WSC_EmployeeReviewerLabel.TabIndex = 9
        WSC_EmployeeReviewerLabel.Text = "Requestor:"
        '
        'WSC_DateCreatedLabel
        '
        WSC_DateCreatedLabel.AutoSize = True
        WSC_DateCreatedLabel.Location = New System.Drawing.Point(78, 156)
        WSC_DateCreatedLabel.Name = "WSC_DateCreatedLabel"
        WSC_DateCreatedLabel.Size = New System.Drawing.Size(130, 28)
        WSC_DateCreatedLabel.TabIndex = 11
        WSC_DateCreatedLabel.Text = "Date Created:"
        '
        'WSC_DateLastReviewedLabel
        '
        WSC_DateLastReviewedLabel.AutoSize = True
        WSC_DateLastReviewedLabel.Location = New System.Drawing.Point(25, 204)
        WSC_DateLastReviewedLabel.Name = "WSC_DateLastReviewedLabel"
        WSC_DateLastReviewedLabel.Size = New System.Drawing.Size(183, 28)
        WSC_DateLastReviewedLabel.TabIndex = 13
        WSC_DateLastReviewedLabel.Text = "Date Last Reviewed:"
        '
        'WSC_ActiveLabel
        '
        WSC_ActiveLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WSC_ActiveLabel.AutoSize = True
        WSC_ActiveLabel.Location = New System.Drawing.Point(594, 252)
        WSC_ActiveLabel.Name = "WSC_ActiveLabel"
        WSC_ActiveLabel.Size = New System.Drawing.Size(70, 28)
        WSC_ActiveLabel.TabIndex = 15
        WSC_ActiveLabel.Text = "Active:"
        '
        'WCS_ApproverLabel
        '
        WCS_ApproverLabel.AutoSize = True
        WCS_ApproverLabel.Location = New System.Drawing.Point(109, 300)
        WCS_ApproverLabel.Name = "WCS_ApproverLabel"
        WCS_ApproverLabel.Size = New System.Drawing.Size(99, 28)
        WCS_ApproverLabel.TabIndex = 23
        WCS_ApproverLabel.Text = "Approver:"
        '
        'WCS_ReviewerLabel
        '
        WCS_ReviewerLabel.AutoSize = True
        WCS_ReviewerLabel.Location = New System.Drawing.Point(115, 398)
        WCS_ReviewerLabel.Name = "WCS_ReviewerLabel"
        WCS_ReviewerLabel.Size = New System.Drawing.Size(93, 28)
        WCS_ReviewerLabel.TabIndex = 25
        WCS_ReviewerLabel.Text = "Reviewer:"
        '
        'WCS_ApproverDateLabel
        '
        WCS_ApproverDateLabel.AutoSize = True
        WCS_ApproverDateLabel.Location = New System.Drawing.Point(58, 350)
        WCS_ApproverDateLabel.Name = "WCS_ApproverDateLabel"
        WCS_ApproverDateLabel.Size = New System.Drawing.Size(150, 28)
        WCS_ApproverDateLabel.TabIndex = 27
        WCS_ApproverDateLabel.Text = "Approved Date:"
        '
        'WCS_ReviewerDateLabel
        '
        WCS_ReviewerDateLabel.AutoSize = True
        WCS_ReviewerDateLabel.Location = New System.Drawing.Point(64, 448)
        WCS_ReviewerDateLabel.Name = "WCS_ReviewerDateLabel"
        WCS_ReviewerDateLabel.Size = New System.Drawing.Size(144, 28)
        WCS_ReviewerDateLabel.TabIndex = 29
        WCS_ReviewerDateLabel.Text = "Reviewed Date:"
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WSCBindingSource
        '
        Me.WSCBindingSource.DataMember = "WSC"
        Me.WSCBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'WSCTableAdapter
        '
        Me.WSCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.LibraryTableAdapter = Nothing
        Me.TableAdapterManager.SDSTableAdapter = Nothing
        Me.TableAdapterManager.sysdiagramsTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_CategoryTableAdapter = Nothing
        Me.TableAdapterManager.tlkpCHW_Toxic_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.tlkpEmployee_TitleTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHazard_ClassTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHSC_HealthHazardTableAdapter = Nothing
        Me.TableAdapterManager.tlkpHSC_PhysicalHazardTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLHW_FKTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLHW_PUTableAdapter = Nothing
        Me.TableAdapterManager.tlkpLibrary_DocumentTypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_BuildingTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_DivisionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_GroupTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_PhysicalLocationTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_TypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOfficeTableAdapter = Me.TlkpOfficeTableAdapter
        Me.TableAdapterManager.tlkpRCRA_TypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpRegionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpUTS_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.trace_xe_action_mapTableAdapter = Nothing
        'Me.TableAdapterManager.trace_xe_event_mapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnviroHealthSafety_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WSC_CHW_ToxicConstituentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_CHWTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_FListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_KListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_PListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHW_UListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_LHWTableAdapter = Nothing
        Me.TableAdapterManager.WSC_RCRA_DeterminationTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SupportingDocumentTableAdapter = Nothing
        Me.TableAdapterManager.WSC_SW_261_2TableAdapter = Nothing
        Me.TableAdapterManager.WSC_SWE_261_4TableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSD_UserKnowledgeTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSD_WasteAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTD_UHCListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTDTableAdapter = Nothing
        Me.TableAdapterManager.WSCTableAdapter = Me.WSCTableAdapter
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Me.Ztbl_EmployeeTableAdapter
        '
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
        '
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'WSC_IDTextBox
        '
        Me.WSC_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSCBindingSource, "WSC_ID", True))
        Me.WSC_IDTextBox.Enabled = False
        Me.WSC_IDTextBox.Location = New System.Drawing.Point(672, 58)
        Me.WSC_IDTextBox.Name = "WSC_IDTextBox"
        Me.WSC_IDTextBox.Size = New System.Drawing.Size(33, 34)
        Me.WSC_IDTextBox.TabIndex = 2
        '
        'WSC_NameTextBox
        '
        Me.WSC_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WSCBindingSource, "WSC_Name", True))
        Me.WSC_NameTextBox.Location = New System.Drawing.Point(12, 50)
        Me.WSC_NameTextBox.Name = "WSC_NameTextBox"
        Me.WSC_NameTextBox.Size = New System.Drawing.Size(33, 34)
        Me.WSC_NameTextBox.TabIndex = 4
        Me.WSC_NameTextBox.Visible = False
        '
        'Office_IDComboBox
        '
        Me.Office_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WSCBindingSource, "Office_ID", True))
        Me.Office_IDComboBox.DataSource = Me.TlkpOfficeBindingSource
        Me.Office_IDComboBox.DisplayMember = "Office_Name"
        Me.Office_IDComboBox.FormattingEnabled = True
        Me.Office_IDComboBox.Location = New System.Drawing.Point(214, 56)
        Me.Office_IDComboBox.Name = "Office_IDComboBox"
        Me.Office_IDComboBox.Size = New System.Drawing.Size(450, 36)
        Me.Office_IDComboBox.TabIndex = 8
        Me.Office_IDComboBox.ValueMember = "Office_ID"
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'WSC_EmployeeReviewerComboBox
        '
        Me.WSC_EmployeeReviewerComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_EmployeeReviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WSCBindingSource, "WSC_EmployeeReviewer", True))
        Me.WSC_EmployeeReviewerComboBox.DataSource = Me.ZtblEmployeeBindingSource
        Me.WSC_EmployeeReviewerComboBox.DisplayMember = "Employee_FirstLastName"
        Me.WSC_EmployeeReviewerComboBox.FormattingEnabled = True
        Me.WSC_EmployeeReviewerComboBox.Location = New System.Drawing.Point(214, 106)
        Me.WSC_EmployeeReviewerComboBox.Name = "WSC_EmployeeReviewerComboBox"
        Me.WSC_EmployeeReviewerComboBox.Size = New System.Drawing.Size(491, 36)
        Me.WSC_EmployeeReviewerComboBox.TabIndex = 10
        Me.WSC_EmployeeReviewerComboBox.ValueMember = "Employee_ID"
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'WSC_DateCreatedDateTimePicker
        '
        Me.WSC_DateCreatedDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_DateCreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WSCBindingSource, "WSC_DateCreated", True))
        Me.WSC_DateCreatedDateTimePicker.Location = New System.Drawing.Point(214, 156)
        Me.WSC_DateCreatedDateTimePicker.Name = "WSC_DateCreatedDateTimePicker"
        Me.WSC_DateCreatedDateTimePicker.Size = New System.Drawing.Size(491, 34)
        Me.WSC_DateCreatedDateTimePicker.TabIndex = 12
        '
        'WSC_DateLastReviewedDateTimePicker
        '
        Me.WSC_DateLastReviewedDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_DateLastReviewedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WSCBindingSource, "WSC_DateLastReviewed", True))
        Me.WSC_DateLastReviewedDateTimePicker.Location = New System.Drawing.Point(214, 204)
        Me.WSC_DateLastReviewedDateTimePicker.Name = "WSC_DateLastReviewedDateTimePicker"
        Me.WSC_DateLastReviewedDateTimePicker.Size = New System.Drawing.Size(491, 34)
        Me.WSC_DateLastReviewedDateTimePicker.TabIndex = 14
        '
        'WSC_ActiveCheckBox
        '
        Me.WSC_ActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSCBindingSource, "WSC_Active", True))
        Me.WSC_ActiveCheckBox.Location = New System.Drawing.Point(670, 252)
        Me.WSC_ActiveCheckBox.Name = "WSC_ActiveCheckBox"
        Me.WSC_ActiveCheckBox.Size = New System.Drawing.Size(35, 30)
        Me.WSC_ActiveCheckBox.TabIndex = 16
        Me.WSC_ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'WCS_ApproverComboBox
        '
        Me.WCS_ApproverComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_ApproverComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WSCBindingSource, "WCS_Approver", True))
        Me.WCS_ApproverComboBox.DataSource = Me.ZtblEmployeeBindingSource
        Me.WCS_ApproverComboBox.DisplayMember = "Employee_FirstLastName"
        Me.WCS_ApproverComboBox.FormattingEnabled = True
        Me.WCS_ApproverComboBox.Location = New System.Drawing.Point(214, 300)
        Me.WCS_ApproverComboBox.Name = "WCS_ApproverComboBox"
        Me.WCS_ApproverComboBox.Size = New System.Drawing.Size(491, 36)
        Me.WCS_ApproverComboBox.TabIndex = 24
        Me.WCS_ApproverComboBox.ValueMember = "Employee_ID"
        '
        'WCS_ReviewerComboBox
        '
        Me.WCS_ReviewerComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_ReviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WSCBindingSource, "WCS_Reviewer", True))
        Me.WCS_ReviewerComboBox.DataSource = Me.ZtblEmployeeBindingSource
        Me.WCS_ReviewerComboBox.DisplayMember = "Employee_FirstLastName"
        Me.WCS_ReviewerComboBox.FormattingEnabled = True
        Me.WCS_ReviewerComboBox.Location = New System.Drawing.Point(214, 398)
        Me.WCS_ReviewerComboBox.Name = "WCS_ReviewerComboBox"
        Me.WCS_ReviewerComboBox.Size = New System.Drawing.Size(491, 36)
        Me.WCS_ReviewerComboBox.TabIndex = 26
        Me.WCS_ReviewerComboBox.ValueMember = "Employee_ID"
        '
        'WCS_ApproverDateDateTimePicker
        '
        Me.WCS_ApproverDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_ApproverDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WSCBindingSource, "WCS_ApproverDate", True))
        Me.WCS_ApproverDateDateTimePicker.Location = New System.Drawing.Point(214, 350)
        Me.WCS_ApproverDateDateTimePicker.Name = "WCS_ApproverDateDateTimePicker"
        Me.WCS_ApproverDateDateTimePicker.Size = New System.Drawing.Size(491, 34)
        Me.WCS_ApproverDateDateTimePicker.TabIndex = 28
        '
        'WCS_ReviewerDateDateTimePicker
        '
        Me.WCS_ReviewerDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WCS_ReviewerDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WSCBindingSource, "WCS_ReviewerDate", True))
        Me.WCS_ReviewerDateDateTimePicker.Location = New System.Drawing.Point(214, 448)
        Me.WCS_ReviewerDateDateTimePicker.Name = "WCS_ReviewerDateDateTimePicker"
        Me.WCS_ReviewerDateDateTimePicker.Size = New System.Drawing.Size(491, 34)
        Me.WCS_ReviewerDateDateTimePicker.TabIndex = 30
        '
        'tStrip_WasteStreamCharacterization
        '
        Me.tStrip_WasteStreamCharacterization.AutoSize = False
        Me.tStrip_WasteStreamCharacterization.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_WasteStreamCharacterization.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_WasteStreamCharacterization.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_WasteStreamCharacterization.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_PreviousForm, Me.tStrip_lbl_PathBackButton, Me.btn_NewWSC, Me.btn_Delete, Me.btn_Update, Me.btn_Undo})
        Me.tStrip_WasteStreamCharacterization.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_WasteStreamCharacterization.Name = "tStrip_WasteStreamCharacterization"
        Me.tStrip_WasteStreamCharacterization.Padding = New System.Windows.Forms.Padding(0)
        Me.tStrip_WasteStreamCharacterization.Size = New System.Drawing.Size(732, 40)
        Me.tStrip_WasteStreamCharacterization.TabIndex = 31
        Me.tStrip_WasteStreamCharacterization.Text = "WSC Details ToolStrip"
        '
        'btn_PreviousForm
        '
        Me.btn_PreviousForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_PreviousForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_PreviousForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_PreviousForm.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btn_PreviousForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_PreviousForm.IconSize = 35
        Me.btn_PreviousForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_PreviousForm.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_PreviousForm.Name = "btn_PreviousForm"
        Me.btn_PreviousForm.Rotation = 0R
        Me.btn_PreviousForm.Size = New System.Drawing.Size(29, 40)
        Me.btn_PreviousForm.Text = "IconToolStripButton1"
        '
        'tStrip_lbl_PathBackButton
        '
        Me.tStrip_lbl_PathBackButton.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_PathBackButton.ForeColor = System.Drawing.Color.Black
        Me.tStrip_lbl_PathBackButton.Name = "tStrip_lbl_PathBackButton"
        Me.tStrip_lbl_PathBackButton.Size = New System.Drawing.Size(67, 37)
        Me.tStrip_lbl_PathBackButton.Text = "Details"
        '
        'btn_NewWSC
        '
        Me.btn_NewWSC.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_NewWSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_NewWSC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_NewWSC.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_NewWSC.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_NewWSC.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_NewWSC.IconSize = 35
        Me.btn_NewWSC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_NewWSC.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_NewWSC.Name = "btn_NewWSC"
        Me.btn_NewWSC.Rotation = 0R
        Me.btn_NewWSC.Size = New System.Drawing.Size(29, 40)
        Me.btn_NewWSC.Text = "New Waste Stream Characterization"
        '
        'btn_Delete
        '
        Me.btn_Delete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_Delete.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_Delete.IconSize = 35
        Me.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Rotation = 0R
        Me.btn_Delete.Size = New System.Drawing.Size(29, 40)
        Me.btn_Delete.Text = "Delete"
        '
        'btn_Update
        '
        Me.btn_Update.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Update.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Update.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_Update.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_Update.IconSize = 35
        Me.btn_Update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Update.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Rotation = 0R
        Me.btn_Update.Size = New System.Drawing.Size(29, 40)
        Me.btn_Update.Text = "Save Details"
        '
        'btn_Undo
        '
        Me.btn_Undo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Undo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Undo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Undo.ForeColor = System.Drawing.Color.Coral
        Me.btn_Undo.IconChar = FontAwesome.Sharp.IconChar.UndoAlt
        Me.btn_Undo.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_Undo.IconSize = 35
        Me.btn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Undo.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Rotation = 0R
        Me.btn_Undo.Size = New System.Drawing.Size(29, 40)
        Me.btn_Undo.Text = "Undo - Cancel"
        '
        'btn_WSC_F1
        '
        Me.btn_WSC_F1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_WSC_F1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_WSC_F1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WSC_F1.FlatAppearance.BorderSize = 0
        Me.btn_WSC_F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WSC_F1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_WSC_F1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WSC_F1.ForeColor = System.Drawing.Color.White
        Me.btn_WSC_F1.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.btn_WSC_F1.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_WSC_F1.IconSize = 30
        Me.btn_WSC_F1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WSC_F1.Location = New System.Drawing.Point(214, 501)
        Me.btn_WSC_F1.Name = "btn_WSC_F1"
        Me.btn_WSC_F1.Rotation = 0R
        Me.btn_WSC_F1.Size = New System.Drawing.Size(491, 40)
        Me.btn_WSC_F1.TabIndex = 32
        Me.btn_WSC_F1.Text = "Next: Waste Stream Characterization"
        Me.btn_WSC_F1.UseVisualStyleBackColor = False
        '
        'lbl_ReferenceName
        '
        Me.lbl_ReferenceName.AutoSize = True
        Me.lbl_ReferenceName.Location = New System.Drawing.Point(55, 252)
        Me.lbl_ReferenceName.Name = "lbl_ReferenceName"
        Me.lbl_ReferenceName.Size = New System.Drawing.Size(153, 28)
        Me.lbl_ReferenceName.TabIndex = 33
        Me.lbl_ReferenceName.Text = "Reference Name"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(214, 252)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 34)
        Me.TextBox1.TabIndex = 34
        '
        'WSC_WDB_UKnowledgeCheckBox
        '
        Me.WSC_WDB_UKnowledgeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSCBindingSource, "WSC_WDB_UKnowledge", True))
        Me.WSC_WDB_UKnowledgeCheckBox.Enabled = False
        Me.WSC_WDB_UKnowledgeCheckBox.FlatAppearance.BorderSize = 0
        Me.WSC_WDB_UKnowledgeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WSC_WDB_UKnowledgeCheckBox.Location = New System.Drawing.Point(214, 501)
        Me.WSC_WDB_UKnowledgeCheckBox.Name = "WSC_WDB_UKnowledgeCheckBox"
        Me.WSC_WDB_UKnowledgeCheckBox.Size = New System.Drawing.Size(30, 24)
        Me.WSC_WDB_UKnowledgeCheckBox.TabIndex = 35
        Me.WSC_WDB_UKnowledgeCheckBox.UseVisualStyleBackColor = True
        '
        'WSC_WDB_WAnalysisCheckBox
        '
        Me.WSC_WDB_WAnalysisCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSCBindingSource, "WSC_WDB_WAnalysis", True))
        Me.WSC_WDB_WAnalysisCheckBox.Enabled = False
        Me.WSC_WDB_WAnalysisCheckBox.FlatAppearance.BorderSize = 0
        Me.WSC_WDB_WAnalysisCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WSC_WDB_WAnalysisCheckBox.Location = New System.Drawing.Point(229, 501)
        Me.WSC_WDB_WAnalysisCheckBox.Name = "WSC_WDB_WAnalysisCheckBox"
        Me.WSC_WDB_WAnalysisCheckBox.Size = New System.Drawing.Size(30, 24)
        Me.WSC_WDB_WAnalysisCheckBox.TabIndex = 36
        Me.WSC_WDB_WAnalysisCheckBox.UseVisualStyleBackColor = True
        '
        'WCS_PCB_ContaminatedCheckBox
        '
        Me.WCS_PCB_ContaminatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.WSCBindingSource, "WCS_PCB_Contaminated", True))
        Me.WCS_PCB_ContaminatedCheckBox.Enabled = False
        Me.WCS_PCB_ContaminatedCheckBox.FlatAppearance.BorderSize = 0
        Me.WCS_PCB_ContaminatedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WCS_PCB_ContaminatedCheckBox.Location = New System.Drawing.Point(250, 501)
        Me.WCS_PCB_ContaminatedCheckBox.Name = "WCS_PCB_ContaminatedCheckBox"
        Me.WCS_PCB_ContaminatedCheckBox.Size = New System.Drawing.Size(30, 24)
        Me.WCS_PCB_ContaminatedCheckBox.TabIndex = 37
        Me.WCS_PCB_ContaminatedCheckBox.UseVisualStyleBackColor = True
        '
        'frmWSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 553)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_ReferenceName)
        Me.Controls.Add(Me.btn_WSC_F1)
        Me.Controls.Add(Me.tStrip_WasteStreamCharacterization)
        Me.Controls.Add(Me.WSC_IDTextBox)
        Me.Controls.Add(Me.WSC_NameTextBox)
        Me.Controls.Add(Office_IDLabel)
        Me.Controls.Add(Me.Office_IDComboBox)
        Me.Controls.Add(WSC_EmployeeReviewerLabel)
        Me.Controls.Add(Me.WSC_EmployeeReviewerComboBox)
        Me.Controls.Add(WSC_DateCreatedLabel)
        Me.Controls.Add(Me.WSC_DateCreatedDateTimePicker)
        Me.Controls.Add(WSC_DateLastReviewedLabel)
        Me.Controls.Add(Me.WSC_DateLastReviewedDateTimePicker)
        Me.Controls.Add(WSC_ActiveLabel)
        Me.Controls.Add(Me.WSC_ActiveCheckBox)
        Me.Controls.Add(WCS_ApproverLabel)
        Me.Controls.Add(Me.WCS_ApproverComboBox)
        Me.Controls.Add(WCS_ReviewerLabel)
        Me.Controls.Add(Me.WCS_ReviewerComboBox)
        Me.Controls.Add(WCS_ApproverDateLabel)
        Me.Controls.Add(Me.WCS_ApproverDateDateTimePicker)
        Me.Controls.Add(WCS_ReviewerDateLabel)
        Me.Controls.Add(Me.WCS_ReviewerDateDateTimePicker)
        Me.Controls.Add(Me.WCS_PCB_ContaminatedCheckBox)
        Me.Controls.Add(Me.WSC_WDB_WAnalysisCheckBox)
        Me.Controls.Add(Me.WSC_WDB_UKnowledgeCheckBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmWSC"
        Me.Text = "Waste Stream Characterization Background"
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_WasteStreamCharacterization.ResumeLayout(False)
        Me.tStrip_WasteStreamCharacterization.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents WSCBindingSource As BindingSource
    Friend WithEvents WSCTableAdapter As EnviroHealthSafety_DataTableAdapters.WSCTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents WSC_IDTextBox As TextBox
    Friend WithEvents WSC_NameTextBox As TextBox
    Friend WithEvents Office_IDComboBox As ComboBox
    Friend WithEvents WSC_EmployeeReviewerComboBox As ComboBox
    Friend WithEvents WSC_DateCreatedDateTimePicker As DateTimePicker
    Friend WithEvents WSC_DateLastReviewedDateTimePicker As DateTimePicker
    Friend WithEvents WSC_ActiveCheckBox As CheckBox
    Friend WithEvents WCS_ApproverComboBox As ComboBox
    Friend WithEvents WCS_ReviewerComboBox As ComboBox
    Friend WithEvents WCS_ApproverDateDateTimePicker As DateTimePicker
    Friend WithEvents WCS_ReviewerDateDateTimePicker As DateTimePicker
    Friend WithEvents tStrip_WasteStreamCharacterization As ToolStrip
    Friend WithEvents tStrip_lbl_PathBackButton As ToolStripLabel
    Friend WithEvents btn_WSC_F1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_ReferenceName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
    Friend WithEvents btn_PreviousForm As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_NewWSC As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Delete As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Update As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Undo As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents WSC_WDB_UKnowledgeCheckBox As CheckBox
    Friend WithEvents WSC_WDB_WAnalysisCheckBox As CheckBox
    Friend WithEvents WCS_PCB_ContaminatedCheckBox As CheckBox
End Class
