<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct_Detail
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
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Product_IssueDateLabel As System.Windows.Forms.Label
        Dim Product_RevisedDateLabel As System.Windows.Forms.Label
        Dim Product_VerifiedDateLabel As System.Windows.Forms.Label
        Dim Product_InputDateLabel As System.Windows.Forms.Label
        Dim Product_InputEmployeeLabel As System.Windows.Forms.Label
        Dim Product_ApprovedLabel As System.Windows.Forms.Label
        Dim Product_HazWasteLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.Chemical_ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Product_IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_RevisedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_VerifiedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_InputDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Product_InputEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_ApprovedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Product_HazWasteCheckBox = New System.Windows.Forms.CheckBox()
        Me.ChemicalManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChemicalResponsiblePartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ResponsiblePartyTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ResponsiblePartyTableAdapter()
        Me.Chemical_ManufacturerTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter()
        Me.TStrip_ProductDetail = New System.Windows.Forms.ToolStrip()
        Me.TStrip_btnPreviousForm = New FontAwesome.Sharp.IconToolStripButton()
        Me.TStrip_btnDelete = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_btnSave = New FontAwesome.Sharp.IconToolStripButton()
        Me.TStrip_lblPrevious = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter()
        Me.btn_tabSDSCard = New FontAwesome.Sharp.IconButton()
        Me.btn_tabLibraryCard = New FontAwesome.Sharp.IconButton()
        Me.btn_tabCurrentLocation = New FontAwesome.Sharp.IconButton()
        Me.btn_tabManufacturer = New FontAwesome.Sharp.IconButton()
        Me.Panel_TabProductDetail = New System.Windows.Forms.Panel()
        Product_NameLabel = New System.Windows.Forms.Label()
        Product_IssueDateLabel = New System.Windows.Forms.Label()
        Product_RevisedDateLabel = New System.Windows.Forms.Label()
        Product_VerifiedDateLabel = New System.Windows.Forms.Label()
        Product_InputDateLabel = New System.Windows.Forms.Label()
        Product_InputEmployeeLabel = New System.Windows.Forms.Label()
        Product_ApprovedLabel = New System.Windows.Forms.Label()
        Product_HazWasteLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalResponsiblePartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TStrip_ProductDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(49, 52)
        Product_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(85, 28)
        Product_NameLabel.TabIndex = 3
        Product_NameLabel.Text = "Product:"
        '
        'Product_IssueDateLabel
        '
        Product_IssueDateLabel.AutoSize = True
        Product_IssueDateLabel.Location = New System.Drawing.Point(30, 101)
        Product_IssueDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_IssueDateLabel.Name = "Product_IssueDateLabel"
        Product_IssueDateLabel.Size = New System.Drawing.Size(104, 28)
        Product_IssueDateLabel.TabIndex = 5
        Product_IssueDateLabel.Text = "Issue Date:"
        '
        'Product_RevisedDateLabel
        '
        Product_RevisedDateLabel.AutoSize = True
        Product_RevisedDateLabel.Location = New System.Drawing.Point(367, 160)
        Product_RevisedDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_RevisedDateLabel.Name = "Product_RevisedDateLabel"
        Product_RevisedDateLabel.Size = New System.Drawing.Size(128, 28)
        Product_RevisedDateLabel.TabIndex = 7
        Product_RevisedDateLabel.Text = "Revised Date:"
        '
        'Product_VerifiedDateLabel
        '
        Product_VerifiedDateLabel.AutoSize = True
        Product_VerifiedDateLabel.Location = New System.Drawing.Point(6, 161)
        Product_VerifiedDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_VerifiedDateLabel.Name = "Product_VerifiedDateLabel"
        Product_VerifiedDateLabel.Size = New System.Drawing.Size(128, 28)
        Product_VerifiedDateLabel.TabIndex = 9
        Product_VerifiedDateLabel.Text = "Verified Date:"
        '
        'Product_InputDateLabel
        '
        Product_InputDateLabel.AutoSize = True
        Product_InputDateLabel.Location = New System.Drawing.Point(387, 101)
        Product_InputDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_InputDateLabel.Name = "Product_InputDateLabel"
        Product_InputDateLabel.Size = New System.Drawing.Size(108, 28)
        Product_InputDateLabel.TabIndex = 11
        Product_InputDateLabel.Text = "Input Date:"
        '
        'Product_InputEmployeeLabel
        '
        Product_InputEmployeeLabel.AutoSize = True
        Product_InputEmployeeLabel.Location = New System.Drawing.Point(398, 214)
        Product_InputEmployeeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_InputEmployeeLabel.Name = "Product_InputEmployeeLabel"
        Product_InputEmployeeLabel.Size = New System.Drawing.Size(99, 28)
        Product_InputEmployeeLabel.TabIndex = 13
        Product_InputEmployeeLabel.Text = "Approver:"
        '
        'Product_ApprovedLabel
        '
        Product_ApprovedLabel.AutoSize = True
        Product_ApprovedLabel.Location = New System.Drawing.Point(30, 211)
        Product_ApprovedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_ApprovedLabel.Name = "Product_ApprovedLabel"
        Product_ApprovedLabel.Size = New System.Drawing.Size(104, 28)
        Product_ApprovedLabel.TabIndex = 15
        Product_ApprovedLabel.Text = "Approved:"
        '
        'Product_HazWasteLabel
        '
        Product_HazWasteLabel.AutoSize = True
        Product_HazWasteLabel.Location = New System.Drawing.Point(25, 253)
        Product_HazWasteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_HazWasteLabel.Name = "Product_HazWasteLabel"
        Product_HazWasteLabel.Size = New System.Drawing.Size(109, 28)
        Product_HazWasteLabel.TabIndex = 17
        Product_HazWasteLabel.Text = "Hazardous:"
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chemical_ProductBindingSource
        '
        Me.Chemical_ProductBindingSource.DataMember = "Chemical_Product"
        Me.Chemical_ProductBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Me.Chemical_ProductTableAdapter
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
        Me.TableAdapterManager.tlkpOfficeTableAdapter = Nothing
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
        Me.TableAdapterManager.WSCTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ProductBindingSource, "Product_ID", True))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(679, 52)
        Me.Product_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(47, 34)
        Me.Product_IDTextBox.TabIndex = 2
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ProductBindingSource, "Product_Name", True))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(142, 52)
        Me.Product_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(529, 34)
        Me.Product_NameTextBox.TabIndex = 4
        '
        'Product_IssueDateDateTimePicker
        '
        Me.Product_IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chemical_ProductBindingSource, "Product_IssueDate", True))
        Me.Product_IssueDateDateTimePicker.Location = New System.Drawing.Point(142, 101)
        Me.Product_IssueDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_IssueDateDateTimePicker.Name = "Product_IssueDateDateTimePicker"
        Me.Product_IssueDateDateTimePicker.Size = New System.Drawing.Size(212, 34)
        Me.Product_IssueDateDateTimePicker.TabIndex = 6
        '
        'Product_RevisedDateDateTimePicker
        '
        Me.Product_RevisedDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_RevisedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chemical_ProductBindingSource, "Product_RevisedDate", True))
        Me.Product_RevisedDateDateTimePicker.Location = New System.Drawing.Point(503, 161)
        Me.Product_RevisedDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_RevisedDateDateTimePicker.Name = "Product_RevisedDateDateTimePicker"
        Me.Product_RevisedDateDateTimePicker.Size = New System.Drawing.Size(223, 34)
        Me.Product_RevisedDateDateTimePicker.TabIndex = 8
        '
        'Product_VerifiedDateDateTimePicker
        '
        Me.Product_VerifiedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chemical_ProductBindingSource, "Product_VerifiedDate", True))
        Me.Product_VerifiedDateDateTimePicker.Location = New System.Drawing.Point(142, 161)
        Me.Product_VerifiedDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_VerifiedDateDateTimePicker.Name = "Product_VerifiedDateDateTimePicker"
        Me.Product_VerifiedDateDateTimePicker.Size = New System.Drawing.Size(212, 34)
        Me.Product_VerifiedDateDateTimePicker.TabIndex = 10
        '
        'Product_InputDateDateTimePicker
        '
        Me.Product_InputDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_InputDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Chemical_ProductBindingSource, "Product_InputDate", True))
        Me.Product_InputDateDateTimePicker.Location = New System.Drawing.Point(503, 101)
        Me.Product_InputDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_InputDateDateTimePicker.Name = "Product_InputDateDateTimePicker"
        Me.Product_InputDateDateTimePicker.Size = New System.Drawing.Size(223, 34)
        Me.Product_InputDateDateTimePicker.TabIndex = 12
        '
        'Product_InputEmployeeComboBox
        '
        Me.Product_InputEmployeeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_InputEmployeeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_ProductBindingSource, "Product_InputEmployee", True))
        Me.Product_InputEmployeeComboBox.DataSource = Me.ZtblEmployeeBindingSource
        Me.Product_InputEmployeeComboBox.DisplayMember = "Employee_FirstLastName"
        Me.Product_InputEmployeeComboBox.FormattingEnabled = True
        Me.Product_InputEmployeeComboBox.Location = New System.Drawing.Point(503, 211)
        Me.Product_InputEmployeeComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_InputEmployeeComboBox.Name = "Product_InputEmployeeComboBox"
        Me.Product_InputEmployeeComboBox.Size = New System.Drawing.Size(223, 36)
        Me.Product_InputEmployeeComboBox.TabIndex = 14
        Me.Product_InputEmployeeComboBox.ValueMember = "Employee_ID"
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Product_ApprovedCheckBox
        '
        Me.Product_ApprovedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Product_ApprovedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Chemical_ProductBindingSource, "Product_Approved", True))
        Me.Product_ApprovedCheckBox.Location = New System.Drawing.Point(142, 205)
        Me.Product_ApprovedCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_ApprovedCheckBox.Name = "Product_ApprovedCheckBox"
        Me.Product_ApprovedCheckBox.Size = New System.Drawing.Size(36, 42)
        Me.Product_ApprovedCheckBox.TabIndex = 16
        Me.Product_ApprovedCheckBox.UseVisualStyleBackColor = True
        '
        'Product_HazWasteCheckBox
        '
        Me.Product_HazWasteCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Product_HazWasteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Chemical_ProductBindingSource, "Product_HazWaste", True))
        Me.Product_HazWasteCheckBox.Location = New System.Drawing.Point(142, 247)
        Me.Product_HazWasteCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Product_HazWasteCheckBox.Name = "Product_HazWasteCheckBox"
        Me.Product_HazWasteCheckBox.Size = New System.Drawing.Size(36, 42)
        Me.Product_HazWasteCheckBox.TabIndex = 18
        Me.Product_HazWasteCheckBox.UseVisualStyleBackColor = True
        '
        'ChemicalManufacturerBindingSource
        '
        Me.ChemicalManufacturerBindingSource.DataMember = "Chemical_Manufacturer"
        Me.ChemicalManufacturerBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'ChemicalResponsiblePartyBindingSource
        '
        Me.ChemicalResponsiblePartyBindingSource.DataMember = "Chemical_ResponsibleParty"
        Me.ChemicalResponsiblePartyBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_ResponsiblePartyTableAdapter
        '
        Me.Chemical_ResponsiblePartyTableAdapter.ClearBeforeFill = True
        '
        'Chemical_ManufacturerTableAdapter
        '
        Me.Chemical_ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'TStrip_ProductDetail
        '
        Me.TStrip_ProductDetail.AutoSize = False
        Me.TStrip_ProductDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TStrip_ProductDetail.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStrip_ProductDetail.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TStrip_ProductDetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrip_btnPreviousForm, Me.TStrip_btnDelete, Me.tStrip_btnSave, Me.TStrip_lblPrevious, Me.ToolStripLabel1})
        Me.TStrip_ProductDetail.Location = New System.Drawing.Point(0, 0)
        Me.TStrip_ProductDetail.Name = "TStrip_ProductDetail"
        Me.TStrip_ProductDetail.Padding = New System.Windows.Forms.Padding(0)
        Me.TStrip_ProductDetail.Size = New System.Drawing.Size(739, 40)
        Me.TStrip_ProductDetail.TabIndex = 22
        Me.TStrip_ProductDetail.Text = "Product Detail Tool Strip"
        '
        'TStrip_btnPreviousForm
        '
        Me.TStrip_btnPreviousForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TStrip_btnPreviousForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TStrip_btnPreviousForm.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.TStrip_btnPreviousForm.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.TStrip_btnPreviousForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TStrip_btnPreviousForm.IconSize = 25
        Me.TStrip_btnPreviousForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TStrip_btnPreviousForm.Margin = New System.Windows.Forms.Padding(0)
        Me.TStrip_btnPreviousForm.Name = "TStrip_btnPreviousForm"
        Me.TStrip_btnPreviousForm.Rotation = 0R
        Me.TStrip_btnPreviousForm.Size = New System.Drawing.Size(29, 40)
        Me.TStrip_btnPreviousForm.Text = "Product Inventory"
        '
        'TStrip_btnDelete
        '
        Me.TStrip_btnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TStrip_btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TStrip_btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TStrip_btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.TStrip_btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.TStrip_btnDelete.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TStrip_btnDelete.IconSize = 25
        Me.TStrip_btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TStrip_btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.TStrip_btnDelete.Name = "TStrip_btnDelete"
        Me.TStrip_btnDelete.Rotation = 0R
        Me.TStrip_btnDelete.Size = New System.Drawing.Size(29, 40)
        Me.TStrip_btnDelete.Text = "Delete Button ToolStrip"
        '
        'tStrip_btnSave
        '
        Me.tStrip_btnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tStrip_btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tStrip_btnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.tStrip_btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.tStrip_btnSave.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tStrip_btnSave.IconSize = 25
        Me.tStrip_btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tStrip_btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.tStrip_btnSave.Name = "tStrip_btnSave"
        Me.tStrip_btnSave.Rotation = 0R
        Me.tStrip_btnSave.Size = New System.Drawing.Size(29, 40)
        Me.tStrip_btnSave.Text = "Save Button ToolStrip"
        '
        'TStrip_lblPrevious
        '
        Me.TStrip_lblPrevious.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip_lblPrevious.ForeColor = System.Drawing.Color.White
        Me.TStrip_lblPrevious.Name = "TStrip_lblPrevious"
        Me.TStrip_lblPrevious.Size = New System.Drawing.Size(81, 37)
        Me.TStrip_lblPrevious.Text = "Home <"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(130, 37)
        Me.ToolStripLabel1.Text = "Product Detail"
        '
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'btn_tabSDSCard
        '
        Me.btn_tabSDSCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_tabSDSCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tabSDSCard.FlatAppearance.BorderSize = 0
        Me.btn_tabSDSCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tabSDSCard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_tabSDSCard.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tabSDSCard.ForeColor = System.Drawing.Color.White
        Me.btn_tabSDSCard.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_tabSDSCard.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_tabSDSCard.IconSize = 25
        Me.btn_tabSDSCard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_tabSDSCard.Location = New System.Drawing.Point(11, 310)
        Me.btn_tabSDSCard.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_tabSDSCard.Name = "btn_tabSDSCard"
        Me.btn_tabSDSCard.Rotation = 0R
        Me.btn_tabSDSCard.Size = New System.Drawing.Size(140, 34)
        Me.btn_tabSDSCard.TabIndex = 21
        Me.btn_tabSDSCard.Text = "SDS Card"
        Me.btn_tabSDSCard.UseVisualStyleBackColor = False
        '
        'btn_tabLibraryCard
        '
        Me.btn_tabLibraryCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_tabLibraryCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tabLibraryCard.FlatAppearance.BorderSize = 0
        Me.btn_tabLibraryCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tabLibraryCard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_tabLibraryCard.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tabLibraryCard.ForeColor = System.Drawing.Color.White
        Me.btn_tabLibraryCard.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.btn_tabLibraryCard.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_tabLibraryCard.IconSize = 25
        Me.btn_tabLibraryCard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_tabLibraryCard.Location = New System.Drawing.Point(489, 310)
        Me.btn_tabLibraryCard.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_tabLibraryCard.Name = "btn_tabLibraryCard"
        Me.btn_tabLibraryCard.Rotation = 0R
        Me.btn_tabLibraryCard.Size = New System.Drawing.Size(168, 34)
        Me.btn_tabLibraryCard.TabIndex = 23
        Me.btn_tabLibraryCard.Text = "Library Card"
        Me.btn_tabLibraryCard.UseVisualStyleBackColor = False
        '
        'btn_tabCurrentLocation
        '
        Me.btn_tabCurrentLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_tabCurrentLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tabCurrentLocation.FlatAppearance.BorderSize = 0
        Me.btn_tabCurrentLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tabCurrentLocation.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_tabCurrentLocation.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tabCurrentLocation.ForeColor = System.Drawing.Color.White
        Me.btn_tabCurrentLocation.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.btn_tabCurrentLocation.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_tabCurrentLocation.IconSize = 25
        Me.btn_tabCurrentLocation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_tabCurrentLocation.Location = New System.Drawing.Point(306, 310)
        Me.btn_tabCurrentLocation.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_tabCurrentLocation.Name = "btn_tabCurrentLocation"
        Me.btn_tabCurrentLocation.Rotation = 0R
        Me.btn_tabCurrentLocation.Size = New System.Drawing.Size(181, 34)
        Me.btn_tabCurrentLocation.TabIndex = 24
        Me.btn_tabCurrentLocation.Text = "Current Location"
        Me.btn_tabCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tabCurrentLocation.UseVisualStyleBackColor = False
        '
        'btn_tabManufacturer
        '
        Me.btn_tabManufacturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_tabManufacturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tabManufacturer.FlatAppearance.BorderSize = 0
        Me.btn_tabManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tabManufacturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_tabManufacturer.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tabManufacturer.ForeColor = System.Drawing.Color.White
        Me.btn_tabManufacturer.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.btn_tabManufacturer.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_tabManufacturer.IconSize = 25
        Me.btn_tabManufacturer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_tabManufacturer.Location = New System.Drawing.Point(153, 310)
        Me.btn_tabManufacturer.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_tabManufacturer.Name = "btn_tabManufacturer"
        Me.btn_tabManufacturer.Rotation = 0R
        Me.btn_tabManufacturer.Size = New System.Drawing.Size(151, 34)
        Me.btn_tabManufacturer.TabIndex = 25
        Me.btn_tabManufacturer.Text = "Manufacturer"
        Me.btn_tabManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tabManufacturer.UseVisualStyleBackColor = False
        '
        'Panel_TabProductDetail
        '
        Me.Panel_TabProductDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_TabProductDetail.AutoScroll = True
        Me.Panel_TabProductDetail.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_TabProductDetail.Location = New System.Drawing.Point(11, 348)
        Me.Panel_TabProductDetail.Name = "Panel_TabProductDetail"
        Me.Panel_TabProductDetail.Size = New System.Drawing.Size(715, 201)
        Me.Panel_TabProductDetail.TabIndex = 26
        '
        'frmProduct_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 561)
        Me.Controls.Add(Me.Panel_TabProductDetail)
        Me.Controls.Add(Me.btn_tabManufacturer)
        Me.Controls.Add(Me.btn_tabCurrentLocation)
        Me.Controls.Add(Me.btn_tabLibraryCard)
        Me.Controls.Add(Me.TStrip_ProductDetail)
        Me.Controls.Add(Me.btn_tabSDSCard)
        Me.Controls.Add(Me.Product_IDTextBox)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(Product_IssueDateLabel)
        Me.Controls.Add(Me.Product_IssueDateDateTimePicker)
        Me.Controls.Add(Product_RevisedDateLabel)
        Me.Controls.Add(Me.Product_RevisedDateDateTimePicker)
        Me.Controls.Add(Product_VerifiedDateLabel)
        Me.Controls.Add(Me.Product_VerifiedDateDateTimePicker)
        Me.Controls.Add(Product_InputDateLabel)
        Me.Controls.Add(Me.Product_InputDateDateTimePicker)
        Me.Controls.Add(Product_InputEmployeeLabel)
        Me.Controls.Add(Me.Product_InputEmployeeComboBox)
        Me.Controls.Add(Product_ApprovedLabel)
        Me.Controls.Add(Me.Product_ApprovedCheckBox)
        Me.Controls.Add(Product_HazWasteLabel)
        Me.Controls.Add(Me.Product_HazWasteCheckBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmProduct_Detail"
        Me.Text = "Product"
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalResponsiblePartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TStrip_ProductDetail.ResumeLayout(False)
        Me.TStrip_ProductDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents Chemical_ProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents Product_IDTextBox As TextBox
    Friend WithEvents Product_NameTextBox As TextBox
    Friend WithEvents Product_IssueDateDateTimePicker As DateTimePicker
    Friend WithEvents Product_RevisedDateDateTimePicker As DateTimePicker
    Friend WithEvents Product_VerifiedDateDateTimePicker As DateTimePicker
    Friend WithEvents Product_InputDateDateTimePicker As DateTimePicker
    Friend WithEvents Product_InputEmployeeComboBox As ComboBox
    Friend WithEvents Product_ApprovedCheckBox As CheckBox
    Friend WithEvents Product_HazWasteCheckBox As CheckBox
    Friend WithEvents ChemicalResponsiblePartyBindingSource As BindingSource
    Friend WithEvents Chemical_ResponsiblePartyTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ResponsiblePartyTableAdapter
    Friend WithEvents ChemicalManufacturerBindingSource As BindingSource
    Friend WithEvents Chemical_ManufacturerTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter
    Friend WithEvents TStrip_ProductDetail As ToolStrip
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter
    Friend WithEvents TStrip_btnPreviousForm As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents TStrip_btnDelete As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_btnSave As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents TStrip_lblPrevious As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_tabSDSCard As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_tabLibraryCard As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_tabCurrentLocation As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_tabManufacturer As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_TabProductDetail As Panel
End Class
