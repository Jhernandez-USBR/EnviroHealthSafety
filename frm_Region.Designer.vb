<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Region
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
        Dim Region_NumberLabel As System.Windows.Forms.Label
        Dim Region_AbbrLabel As System.Windows.Forms.Label
        Dim Region_NameLabel As System.Windows.Forms.Label
        Dim Region_EmailLabel As System.Windows.Forms.Label
        Dim Region_WebsiteLabel As System.Windows.Forms.Label
        Me.TlkpRegionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.txt_Region_ID = New System.Windows.Forms.TextBox()
        Me.Region_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Region_AbbrTextBox = New System.Windows.Forms.TextBox()
        Me.Region_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Region_WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.dgv_AssociatedOffice = New System.Windows.Forms.DataGridView()
        Me.TlkpOfficeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety1 = New EnviroHealthSafety()
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TlkpRegionTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpRegionTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter()
        Me.TlkpOffice_TypeTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOffice_TypeTableAdapter()
        Me.btn_NewOffice = New FontAwesome.Sharp.IconButton()
        Me.cmb_RegionName = New System.Windows.Forms.ComboBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.OfficeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeTypeDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OfficeAbbrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeReportsToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OfficeEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeWebsiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Region_NumberLabel = New System.Windows.Forms.Label()
        Region_AbbrLabel = New System.Windows.Forms.Label()
        Region_NameLabel = New System.Windows.Forms.Label()
        Region_EmailLabel = New System.Windows.Forms.Label()
        Region_WebsiteLabel = New System.Windows.Forms.Label()
        CType(Me.TlkpRegionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_AssociatedOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Region_NumberLabel
        '
        Region_NumberLabel.AutoSize = True
        Region_NumberLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_NumberLabel.Location = New System.Drawing.Point(95, 65)
        Region_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_NumberLabel.Name = "Region_NumberLabel"
        Region_NumberLabel.Size = New System.Drawing.Size(88, 28)
        Region_NumberLabel.TabIndex = 3
        Region_NumberLabel.Text = "Number:"
        '
        'Region_AbbrLabel
        '
        Region_AbbrLabel.AutoSize = True
        Region_AbbrLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_AbbrLabel.Location = New System.Drawing.Point(48, 106)
        Region_AbbrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_AbbrLabel.Name = "Region_AbbrLabel"
        Region_AbbrLabel.Size = New System.Drawing.Size(130, 28)
        Region_AbbrLabel.TabIndex = 5
        Region_AbbrLabel.Text = "Abbreviation:"
        '
        'Region_NameLabel
        '
        Region_NameLabel.AutoSize = True
        Region_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_NameLabel.Location = New System.Drawing.Point(49, 18)
        Region_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_NameLabel.Name = "Region_NameLabel"
        Region_NameLabel.Size = New System.Drawing.Size(134, 28)
        Region_NameLabel.TabIndex = 7
        Region_NameLabel.Text = "Region Name:"
        '
        'Region_EmailLabel
        '
        Region_EmailLabel.AutoSize = True
        Region_EmailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_EmailLabel.Location = New System.Drawing.Point(49, 150)
        Region_EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_EmailLabel.Name = "Region_EmailLabel"
        Region_EmailLabel.Size = New System.Drawing.Size(129, 28)
        Region_EmailLabel.TabIndex = 9
        Region_EmailLabel.Text = "Region Email:"
        '
        'Region_WebsiteLabel
        '
        Region_WebsiteLabel.AutoSize = True
        Region_WebsiteLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_WebsiteLabel.Location = New System.Drawing.Point(26, 194)
        Region_WebsiteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_WebsiteLabel.Name = "Region_WebsiteLabel"
        Region_WebsiteLabel.Size = New System.Drawing.Size(152, 28)
        Region_WebsiteLabel.TabIndex = 11
        Region_WebsiteLabel.Text = "Region Website:"
        '
        'TlkpRegionBindingSource
        '
        Me.TlkpRegionBindingSource.DataMember = "tlkpRegion"
        Me.TlkpRegionBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_Region_ID
        '
        Me.txt_Region_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Region_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpRegionBindingSource, "Region_ID", True))
        Me.txt_Region_ID.Enabled = False
        Me.txt_Region_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Region_ID.Location = New System.Drawing.Point(628, 15)
        Me.txt_Region_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Region_ID.Name = "txt_Region_ID"
        Me.txt_Region_ID.Size = New System.Drawing.Size(91, 34)
        Me.txt_Region_ID.TabIndex = 2
        '
        'Region_NumberTextBox
        '
        Me.Region_NumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Region_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpRegionBindingSource, "Region_Number", True))
        Me.Region_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region_NumberTextBox.Location = New System.Drawing.Point(190, 62)
        Me.Region_NumberTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Region_NumberTextBox.Name = "Region_NumberTextBox"
        Me.Region_NumberTextBox.Size = New System.Drawing.Size(529, 34)
        Me.Region_NumberTextBox.TabIndex = 4
        '
        'Region_AbbrTextBox
        '
        Me.Region_AbbrTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Region_AbbrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpRegionBindingSource, "Region_Abbr", True))
        Me.Region_AbbrTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region_AbbrTextBox.Location = New System.Drawing.Point(190, 106)
        Me.Region_AbbrTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Region_AbbrTextBox.Name = "Region_AbbrTextBox"
        Me.Region_AbbrTextBox.Size = New System.Drawing.Size(529, 34)
        Me.Region_AbbrTextBox.TabIndex = 6
        '
        'Region_EmailTextBox
        '
        Me.Region_EmailTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Region_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpRegionBindingSource, "Region_Email", True))
        Me.Region_EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region_EmailTextBox.Location = New System.Drawing.Point(190, 150)
        Me.Region_EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Region_EmailTextBox.Name = "Region_EmailTextBox"
        Me.Region_EmailTextBox.Size = New System.Drawing.Size(475, 34)
        Me.Region_EmailTextBox.TabIndex = 10
        '
        'Region_WebsiteTextBox
        '
        Me.Region_WebsiteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Region_WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpRegionBindingSource, "Region_Website", True))
        Me.Region_WebsiteTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region_WebsiteTextBox.Location = New System.Drawing.Point(190, 194)
        Me.Region_WebsiteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Region_WebsiteTextBox.Name = "Region_WebsiteTextBox"
        Me.Region_WebsiteTextBox.Size = New System.Drawing.Size(475, 34)
        Me.Region_WebsiteTextBox.TabIndex = 12
        '
        'dgv_AssociatedOffice
        '
        Me.dgv_AssociatedOffice.AllowUserToAddRows = False
        Me.dgv_AssociatedOffice.AllowUserToDeleteRows = False
        Me.dgv_AssociatedOffice.AllowUserToOrderColumns = True
        Me.dgv_AssociatedOffice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_AssociatedOffice.AutoGenerateColumns = False
        Me.dgv_AssociatedOffice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_AssociatedOffice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_AssociatedOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_AssociatedOffice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OfficeIDDataGridViewTextBoxColumn, Me.RegionIDDataGridViewTextBoxColumn, Me.OfficeNameDataGridViewTextBoxColumn, Me.OfficeTypeDataGridViewComboBoxColumn, Me.OfficeAbbrDataGridViewTextBoxColumn, Me.OfficeReportsToDataGridViewTextBoxColumn, Me.OfficeEmailDataGridViewTextBoxColumn, Me.OfficeWebsiteDataGridViewTextBoxColumn, Me.OfficeStateDataGridViewTextBoxColumn})
        Me.dgv_AssociatedOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_AssociatedOffice.DataSource = Me.TlkpOfficeBindingSource
        Me.dgv_AssociatedOffice.Location = New System.Drawing.Point(13, 281)
        Me.dgv_AssociatedOffice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_AssociatedOffice.Name = "dgv_AssociatedOffice"
        Me.dgv_AssociatedOffice.ReadOnly = True
        Me.dgv_AssociatedOffice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_AssociatedOffice.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_AssociatedOffice.RowTemplate.Height = 30
        Me.dgv_AssociatedOffice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_AssociatedOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_AssociatedOffice.Size = New System.Drawing.Size(706, 258)
        Me.dgv_AssociatedOffice.TabIndex = 13
        '
        'TlkpOfficeTypeBindingSource
        '
        Me.TlkpOfficeTypeBindingSource.DataMember = "tlkpOffice_Type"
        Me.TlkpOfficeTypeBindingSource.DataSource = Me.EnviroHealthSafety1
        '
        'EnviroHealthSafety1
        '
        Me.EnviroHealthSafety1.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'TlkpRegionTableAdapter
        '
        Me.TlkpRegionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tlkpRegionTableAdapter = Me.TlkpRegionTableAdapter
        Me.TableAdapterManager.tlkpUTS_ConstituentTableAdapter = Nothing
        Me.TableAdapterManager.trace_xe_action_mapTableAdapter = Nothing
        Me.TableAdapterManager.trace_xe_event_mapTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnviroHealthSafetyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
        '
        'TlkpOffice_TypeTableAdapter
        '
        Me.TlkpOffice_TypeTableAdapter.ClearBeforeFill = True
        '
        'btn_NewOffice
        '
        Me.btn_NewOffice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_NewOffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_NewOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewOffice.FlatAppearance.BorderSize = 0
        Me.btn_NewOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewOffice.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_NewOffice.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewOffice.ForeColor = System.Drawing.Color.White
        Me.btn_NewOffice.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.btn_NewOffice.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_NewOffice.IconSize = 25
        Me.btn_NewOffice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_NewOffice.Location = New System.Drawing.Point(569, 236)
        Me.btn_NewOffice.Name = "btn_NewOffice"
        Me.btn_NewOffice.Rotation = 0R
        Me.btn_NewOffice.Size = New System.Drawing.Size(150, 37)
        Me.btn_NewOffice.TabIndex = 14
        Me.btn_NewOffice.Text = "New Office"
        Me.btn_NewOffice.UseVisualStyleBackColor = False
        '
        'cmb_RegionName
        '
        Me.cmb_RegionName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_RegionName.DataSource = Me.TlkpRegionBindingSource
        Me.cmb_RegionName.DisplayMember = "Region_Name"
        Me.cmb_RegionName.FormattingEnabled = True
        Me.cmb_RegionName.Location = New System.Drawing.Point(190, 15)
        Me.cmb_RegionName.Name = "cmb_RegionName"
        Me.cmb_RegionName.Size = New System.Drawing.Size(431, 36)
        Me.cmb_RegionName.TabIndex = 15
        Me.cmb_RegionName.ValueMember = "Region_ID"
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconButton1.IconSize = 22
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton1.Location = New System.Drawing.Point(669, 194)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(50, 32)
        Me.IconButton1.TabIndex = 18
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconButton3.IconSize = 22
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton3.Location = New System.Drawing.Point(669, 150)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(50, 32)
        Me.IconButton3.TabIndex = 19
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'OfficeIDDataGridViewTextBoxColumn
        '
        Me.OfficeIDDataGridViewTextBoxColumn.DataPropertyName = "Office_ID"
        Me.OfficeIDDataGridViewTextBoxColumn.HeaderText = "Office_ID"
        Me.OfficeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeIDDataGridViewTextBoxColumn.Name = "OfficeIDDataGridViewTextBoxColumn"
        Me.OfficeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeIDDataGridViewTextBoxColumn.Visible = False
        Me.OfficeIDDataGridViewTextBoxColumn.Width = 119
        '
        'RegionIDDataGridViewTextBoxColumn
        '
        Me.RegionIDDataGridViewTextBoxColumn.DataPropertyName = "Region_ID"
        Me.RegionIDDataGridViewTextBoxColumn.HeaderText = "Region_ID"
        Me.RegionIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegionIDDataGridViewTextBoxColumn.Name = "RegionIDDataGridViewTextBoxColumn"
        Me.RegionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RegionIDDataGridViewTextBoxColumn.Visible = False
        Me.RegionIDDataGridViewTextBoxColumn.Width = 129
        '
        'OfficeNameDataGridViewTextBoxColumn
        '
        Me.OfficeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OfficeNameDataGridViewTextBoxColumn.DataPropertyName = "Office_Name"
        Me.OfficeNameDataGridViewTextBoxColumn.HeaderText = "Office"
        Me.OfficeNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeNameDataGridViewTextBoxColumn.Name = "OfficeNameDataGridViewTextBoxColumn"
        Me.OfficeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OfficeTypeDataGridViewComboBoxColumn
        '
        Me.OfficeTypeDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OfficeTypeDataGridViewComboBoxColumn.DataPropertyName = "Office_Type"
        Me.OfficeTypeDataGridViewComboBoxColumn.DataSource = Me.TlkpOfficeTypeBindingSource
        Me.OfficeTypeDataGridViewComboBoxColumn.DisplayMember = "OfficeType"
        Me.OfficeTypeDataGridViewComboBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.OfficeTypeDataGridViewComboBoxColumn.HeaderText = "Type"
        Me.OfficeTypeDataGridViewComboBoxColumn.MinimumWidth = 75
        Me.OfficeTypeDataGridViewComboBoxColumn.Name = "OfficeTypeDataGridViewComboBoxColumn"
        Me.OfficeTypeDataGridViewComboBoxColumn.ReadOnly = True
        Me.OfficeTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OfficeTypeDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OfficeTypeDataGridViewComboBoxColumn.ValueMember = "OfficeType_ID"
        Me.OfficeTypeDataGridViewComboBoxColumn.Width = 82
        '
        'OfficeAbbrDataGridViewTextBoxColumn
        '
        Me.OfficeAbbrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.OfficeAbbrDataGridViewTextBoxColumn.DataPropertyName = "Office_Abbr"
        Me.OfficeAbbrDataGridViewTextBoxColumn.HeaderText = "Abbreviation"
        Me.OfficeAbbrDataGridViewTextBoxColumn.MinimumWidth = 75
        Me.OfficeAbbrDataGridViewTextBoxColumn.Name = "OfficeAbbrDataGridViewTextBoxColumn"
        Me.OfficeAbbrDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeAbbrDataGridViewTextBoxColumn.Width = 155
        '
        'OfficeReportsToDataGridViewTextBoxColumn
        '
        Me.OfficeReportsToDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OfficeReportsToDataGridViewTextBoxColumn.DataPropertyName = "Office_ReportsTo"
        Me.OfficeReportsToDataGridViewTextBoxColumn.DataSource = Me.TlkpOfficeBindingSource
        Me.OfficeReportsToDataGridViewTextBoxColumn.DisplayMember = "Office_Name"
        Me.OfficeReportsToDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.OfficeReportsToDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OfficeReportsToDataGridViewTextBoxColumn.HeaderText = "Reports To"
        Me.OfficeReportsToDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.OfficeReportsToDataGridViewTextBoxColumn.Name = "OfficeReportsToDataGridViewTextBoxColumn"
        Me.OfficeReportsToDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeReportsToDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OfficeReportsToDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OfficeReportsToDataGridViewTextBoxColumn.ValueMember = "Office_ID"
        '
        'OfficeEmailDataGridViewTextBoxColumn
        '
        Me.OfficeEmailDataGridViewTextBoxColumn.DataPropertyName = "Office_Email"
        Me.OfficeEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.OfficeEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeEmailDataGridViewTextBoxColumn.Name = "OfficeEmailDataGridViewTextBoxColumn"
        Me.OfficeEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeEmailDataGridViewTextBoxColumn.Width = 88
        '
        'OfficeWebsiteDataGridViewTextBoxColumn
        '
        Me.OfficeWebsiteDataGridViewTextBoxColumn.DataPropertyName = "Office_Website"
        Me.OfficeWebsiteDataGridViewTextBoxColumn.HeaderText = "Website"
        Me.OfficeWebsiteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeWebsiteDataGridViewTextBoxColumn.Name = "OfficeWebsiteDataGridViewTextBoxColumn"
        Me.OfficeWebsiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeWebsiteDataGridViewTextBoxColumn.Width = 111
        '
        'OfficeStateDataGridViewTextBoxColumn
        '
        Me.OfficeStateDataGridViewTextBoxColumn.DataPropertyName = "Office_State"
        Me.OfficeStateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.OfficeStateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeStateDataGridViewTextBoxColumn.Name = "OfficeStateDataGridViewTextBoxColumn"
        Me.OfficeStateDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeStateDataGridViewTextBoxColumn.Width = 85
        '
        'frm_Region
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(732, 553)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.cmb_RegionName)
        Me.Controls.Add(Me.btn_NewOffice)
        Me.Controls.Add(Me.dgv_AssociatedOffice)
        Me.Controls.Add(Me.txt_Region_ID)
        Me.Controls.Add(Region_NumberLabel)
        Me.Controls.Add(Me.Region_NumberTextBox)
        Me.Controls.Add(Region_AbbrLabel)
        Me.Controls.Add(Me.Region_AbbrTextBox)
        Me.Controls.Add(Region_NameLabel)
        Me.Controls.Add(Region_EmailLabel)
        Me.Controls.Add(Me.Region_EmailTextBox)
        Me.Controls.Add(Region_WebsiteLabel)
        Me.Controls.Add(Me.Region_WebsiteTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_Region"
        Me.Text = "Region - Office Management"
        CType(Me.TlkpRegionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_AssociatedOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents TlkpRegionBindingSource As BindingSource
    Friend WithEvents TlkpRegionTableAdapter As EnviroHealthSafetyTableAdapters.tlkpRegionTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents txt_Region_ID As TextBox
    Friend WithEvents Region_NumberTextBox As TextBox
    Friend WithEvents Region_AbbrTextBox As TextBox
    Friend WithEvents Region_EmailTextBox As TextBox
    Friend WithEvents Region_WebsiteTextBox As TextBox
    Friend WithEvents dgv_AssociatedOffice As DataGridView
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
    Friend WithEvents EnviroHealthSafety1 As EnviroHealthSafety
    Friend WithEvents TlkpOfficeTypeBindingSource As BindingSource
    Friend WithEvents TlkpOffice_TypeTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOffice_TypeTableAdapter
    Friend WithEvents btn_NewOffice As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_RegionName As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents OfficeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeTypeDataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents OfficeAbbrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeReportsToDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents OfficeEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeWebsiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
