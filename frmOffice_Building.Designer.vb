<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffice_Building
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
        Me.components = New System.ComponentModel.Container()
        Dim Office_IDLabel As System.Windows.Forms.Label
        Dim Building_NameLabel As System.Windows.Forms.Label
        Dim Building_NumberLabel As System.Windows.Forms.Label
        Dim Building_CreateDateLabel As System.Windows.Forms.Label
        Dim Building_ReviewDateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EnviroHealthSafety = New EnviroHealthSafety_Data()
        Me.TlkpOffice_BuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TlkpOffice_BuildingTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOffice_BuildingTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.TlkpOffice_PhysicalLocationTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter()
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter()
        Me.OfficeBuilding_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Office_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Building_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Building_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Building_CreateDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Building_ReviewDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.dgv_PhysicalLocation = New System.Windows.Forms.DataGridView()
        Me.PhysicalLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeBuildingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlkpOfficePhysicalLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tStrip_OfficeBuilding = New System.Windows.Forms.ToolStrip()
        Me.btn_BackToOffice = New FontAwesome.Sharp.IconToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btn_EditBuildingDetails = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_Building = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Office_IDLabel = New System.Windows.Forms.Label()
        Building_NameLabel = New System.Windows.Forms.Label()
        Building_NumberLabel = New System.Windows.Forms.Label()
        Building_CreateDateLabel = New System.Windows.Forms.Label()
        Building_ReviewDateLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOffice_BuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_PhysicalLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficePhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_OfficeBuilding.SuspendLayout()
        Me.SuspendLayout()
        '
        'Office_IDLabel
        '
        Office_IDLabel.AutoSize = True
        Office_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_IDLabel.Location = New System.Drawing.Point(116, 55)
        Office_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_IDLabel.Name = "Office_IDLabel"
        Office_IDLabel.Size = New System.Drawing.Size(71, 28)
        Office_IDLabel.TabIndex = 3
        Office_IDLabel.Text = "Office:"
        '
        'Building_NameLabel
        '
        Building_NameLabel.AutoSize = True
        Building_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Building_NameLabel.Location = New System.Drawing.Point(35, 99)
        Building_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Building_NameLabel.Name = "Building_NameLabel"
        Building_NameLabel.Size = New System.Drawing.Size(152, 28)
        Building_NameLabel.TabIndex = 5
        Building_NameLabel.Text = "Building Name:"
        '
        'Building_NumberLabel
        '
        Building_NumberLabel.AutoSize = True
        Building_NumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Building_NumberLabel.Location = New System.Drawing.Point(13, 143)
        Building_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Building_NumberLabel.Name = "Building_NumberLabel"
        Building_NumberLabel.Size = New System.Drawing.Size(174, 28)
        Building_NumberLabel.TabIndex = 7
        Building_NumberLabel.Text = "Building Number:"
        '
        'Building_CreateDateLabel
        '
        Building_CreateDateLabel.AutoSize = True
        Building_CreateDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Building_CreateDateLabel.Location = New System.Drawing.Point(64, 187)
        Building_CreateDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Building_CreateDateLabel.Name = "Building_CreateDateLabel"
        Building_CreateDateLabel.Size = New System.Drawing.Size(123, 28)
        Building_CreateDateLabel.TabIndex = 9
        Building_CreateDateLabel.Text = "Create Date:"
        '
        'Building_ReviewDateLabel
        '
        Building_ReviewDateLabel.AutoSize = True
        Building_ReviewDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Building_ReviewDateLabel.Location = New System.Drawing.Point(59, 231)
        Building_ReviewDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Building_ReviewDateLabel.Name = "Building_ReviewDateLabel"
        Building_ReviewDateLabel.Size = New System.Drawing.Size(128, 28)
        Building_ReviewDateLabel.TabIndex = 11
        Building_ReviewDateLabel.Text = "Review Date:"
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TlkpOffice_BuildingBindingSource
        '
        Me.TlkpOffice_BuildingBindingSource.DataMember = "tlkpOffice_Building"
        Me.TlkpOffice_BuildingBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'TlkpOffice_BuildingTableAdapter
        '
        Me.TlkpOffice_BuildingTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tlkpOffice_BuildingTableAdapter = Me.TlkpOffice_BuildingTableAdapter
        Me.TableAdapterManager.tlkpOffice_DivisionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_GroupTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_PhysicalLocationTableAdapter = Me.TlkpOffice_PhysicalLocationTableAdapter
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
        Me.TableAdapterManager.WSCTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'TlkpOffice_PhysicalLocationTableAdapter
        '
        Me.TlkpOffice_PhysicalLocationTableAdapter.ClearBeforeFill = True
        '
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
        '
        'OfficeBuilding_IDTextBox
        '
        Me.OfficeBuilding_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfficeBuilding_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_BuildingBindingSource, "OfficeBuilding_ID", True))
        Me.OfficeBuilding_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeBuilding_IDTextBox.Location = New System.Drawing.Point(638, 55)
        Me.OfficeBuilding_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OfficeBuilding_IDTextBox.Name = "OfficeBuilding_IDTextBox"
        Me.OfficeBuilding_IDTextBox.Size = New System.Drawing.Size(81, 34)
        Me.OfficeBuilding_IDTextBox.TabIndex = 2
        '
        'Office_IDComboBox
        '
        Me.Office_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TlkpOffice_BuildingBindingSource, "Office_ID", True))
        Me.Office_IDComboBox.DataSource = Me.TlkpOfficeBindingSource
        Me.Office_IDComboBox.DisplayMember = "Office_Name"
        Me.Office_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_IDComboBox.FormattingEnabled = True
        Me.Office_IDComboBox.Location = New System.Drawing.Point(195, 55)
        Me.Office_IDComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_IDComboBox.Name = "Office_IDComboBox"
        Me.Office_IDComboBox.Size = New System.Drawing.Size(435, 36)
        Me.Office_IDComboBox.TabIndex = 4
        Me.Office_IDComboBox.ValueMember = "Office_ID"
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Building_NameTextBox
        '
        Me.Building_NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Building_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_BuildingBindingSource, "Building_Name", True))
        Me.Building_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Building_NameTextBox.Location = New System.Drawing.Point(195, 99)
        Me.Building_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Building_NameTextBox.Name = "Building_NameTextBox"
        Me.Building_NameTextBox.Size = New System.Drawing.Size(524, 34)
        Me.Building_NameTextBox.TabIndex = 6
        '
        'Building_NumberTextBox
        '
        Me.Building_NumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Building_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_BuildingBindingSource, "Building_Number", True))
        Me.Building_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Building_NumberTextBox.Location = New System.Drawing.Point(195, 143)
        Me.Building_NumberTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Building_NumberTextBox.Name = "Building_NumberTextBox"
        Me.Building_NumberTextBox.Size = New System.Drawing.Size(524, 34)
        Me.Building_NumberTextBox.TabIndex = 8
        '
        'Building_CreateDateDateTimePicker
        '
        Me.Building_CreateDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Building_CreateDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TlkpOffice_BuildingBindingSource, "Building_CreateDate", True))
        Me.Building_CreateDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Building_CreateDateDateTimePicker.Location = New System.Drawing.Point(195, 187)
        Me.Building_CreateDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Building_CreateDateDateTimePicker.Name = "Building_CreateDateDateTimePicker"
        Me.Building_CreateDateDateTimePicker.Size = New System.Drawing.Size(524, 34)
        Me.Building_CreateDateDateTimePicker.TabIndex = 10
        '
        'Building_ReviewDateDateTimePicker
        '
        Me.Building_ReviewDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Building_ReviewDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TlkpOffice_BuildingBindingSource, "Building_ReviewDate", True))
        Me.Building_ReviewDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Building_ReviewDateDateTimePicker.Location = New System.Drawing.Point(195, 231)
        Me.Building_ReviewDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Building_ReviewDateDateTimePicker.Name = "Building_ReviewDateDateTimePicker"
        Me.Building_ReviewDateDateTimePicker.Size = New System.Drawing.Size(524, 34)
        Me.Building_ReviewDateDateTimePicker.TabIndex = 12
        '
        'dgv_PhysicalLocation
        '
        Me.dgv_PhysicalLocation.AllowUserToAddRows = False
        Me.dgv_PhysicalLocation.AllowUserToDeleteRows = False
        Me.dgv_PhysicalLocation.AllowUserToOrderColumns = True
        Me.dgv_PhysicalLocation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_PhysicalLocation.AutoGenerateColumns = False
        Me.dgv_PhysicalLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_PhysicalLocation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_PhysicalLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PhysicalLocation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhysicalLocationIDDataGridViewTextBoxColumn, Me.OfficeBuildingIDDataGridViewTextBoxColumn, Me.PhysicalLocationNameDataGridViewTextBoxColumn, Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn, Me.PhysicalLocationTypeDataGridViewTextBoxColumn, Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn, Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn})
        Me.dgv_PhysicalLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_PhysicalLocation.DataSource = Me.TlkpOfficePhysicalLocationBindingSource
        Me.dgv_PhysicalLocation.Location = New System.Drawing.Point(18, 334)
        Me.dgv_PhysicalLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_PhysicalLocation.Name = "dgv_PhysicalLocation"
        Me.dgv_PhysicalLocation.ReadOnly = True
        Me.dgv_PhysicalLocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_PhysicalLocation.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_PhysicalLocation.RowTemplate.Height = 24
        Me.dgv_PhysicalLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_PhysicalLocation.Size = New System.Drawing.Size(701, 206)
        Me.dgv_PhysicalLocation.TabIndex = 13
        '
        'PhysicalLocationIDDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_ID"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.HeaderText = "PhysicalLocation_ID"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.Name = "PhysicalLocationIDDataGridViewTextBoxColumn"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.Visible = False
        '
        'OfficeBuildingIDDataGridViewTextBoxColumn
        '
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.DataPropertyName = "OfficeBuilding_ID"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.HeaderText = "Office Building_ID"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.Name = "OfficeBuildingIDDataGridViewTextBoxColumn"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.Visible = False
        '
        'PhysicalLocationNameDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_Name"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.HeaderText = "Physical Location"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.Name = "PhysicalLocationNameDataGridViewTextBoxColumn"
        Me.PhysicalLocationNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhysicalLocationDescriptionDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_Description"
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.Name = "PhysicalLocationDescriptionDataGridViewTextBoxColumn"
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhysicalLocationDescriptionDataGridViewTextBoxColumn.Width = 141
        '
        'PhysicalLocationTypeDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_Type"
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.Name = "PhysicalLocationTypeDataGridViewTextBoxColumn"
        Me.PhysicalLocationTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhysicalLocationReviewDateDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_ReviewDate"
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.HeaderText = "Last Review Date"
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.Name = "PhysicalLocationReviewDateDataGridViewTextBoxColumn"
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhysicalLocationReviewDateDataGridViewTextBoxColumn.Width = 186
        '
        'PhysicalLocationCreateDateDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_CreateDate"
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.HeaderText = "Create Date"
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.Name = "PhysicalLocationCreateDateDataGridViewTextBoxColumn"
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhysicalLocationCreateDateDataGridViewTextBoxColumn.Width = 143
        '
        'TlkpOfficePhysicalLocationBindingSource
        '
        Me.TlkpOfficePhysicalLocationBindingSource.DataMember = "tlkpOffice_PhysicalLocation"
        Me.TlkpOfficePhysicalLocationBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'tStrip_OfficeBuilding
        '
        Me.tStrip_OfficeBuilding.AutoSize = False
        Me.tStrip_OfficeBuilding.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_OfficeBuilding.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_OfficeBuilding.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_OfficeBuilding.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_OfficeBuilding.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_BackToOffice, Me.ToolStripLabel1, Me.btn_EditBuildingDetails, Me.tStrip_lbl_Building, Me.ToolStripLabel2})
        Me.tStrip_OfficeBuilding.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_OfficeBuilding.Name = "tStrip_OfficeBuilding"
        Me.tStrip_OfficeBuilding.Padding = New System.Windows.Forms.Padding(0)
        Me.tStrip_OfficeBuilding.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tStrip_OfficeBuilding.Size = New System.Drawing.Size(734, 40)
        Me.tStrip_OfficeBuilding.TabIndex = 24
        Me.tStrip_OfficeBuilding.Text = "tstrip_Office"
        '
        'btn_BackToOffice
        '
        Me.btn_BackToOffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_BackToOffice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_BackToOffice.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_BackToOffice.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackToOffice.ForeColor = System.Drawing.Color.White
        Me.btn_BackToOffice.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btn_BackToOffice.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btn_BackToOffice.IconSize = 50
        Me.btn_BackToOffice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_BackToOffice.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BackToOffice.Name = "btn_BackToOffice"
        Me.btn_BackToOffice.Rotation = 0R
        Me.btn_BackToOffice.Size = New System.Drawing.Size(29, 40)
        Me.btn_BackToOffice.Text = "Region"
        Me.btn_BackToOffice.ToolTipText = " Back to Office Managment"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(161, 37)
        Me.ToolStripLabel1.Text = "Region < Office <"
        '
        'btn_EditBuildingDetails
        '
        Me.btn_EditBuildingDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_EditBuildingDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_EditBuildingDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_EditBuildingDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_EditBuildingDetails.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_EditBuildingDetails.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btn_EditBuildingDetails.IconSize = 50
        Me.btn_EditBuildingDetails.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btn_EditBuildingDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_EditBuildingDetails.Name = "btn_EditBuildingDetails"
        Me.btn_EditBuildingDetails.Rotation = 0R
        Me.btn_EditBuildingDetails.Size = New System.Drawing.Size(29, 40)
        Me.btn_EditBuildingDetails.Text = "Edit Building Details"
        '
        'tStrip_lbl_Building
        '
        Me.tStrip_lbl_Building.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_Building.Name = "tStrip_lbl_Building"
        Me.tStrip_lbl_Building.Size = New System.Drawing.Size(79, 37)
        Me.tStrip_lbl_Building.Text = "Building"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(175, 37)
        Me.ToolStripLabel2.Text = "Edit Building Details"
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconButton1.IconSize = 25
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(556, 283)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(163, 43)
        Me.IconButton1.TabIndex = 25
        Me.IconButton1.Text = "New Location"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'frmOffice_Building
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.tStrip_OfficeBuilding)
        Me.Controls.Add(Me.dgv_PhysicalLocation)
        Me.Controls.Add(Me.OfficeBuilding_IDTextBox)
        Me.Controls.Add(Office_IDLabel)
        Me.Controls.Add(Me.Office_IDComboBox)
        Me.Controls.Add(Building_NameLabel)
        Me.Controls.Add(Me.Building_NameTextBox)
        Me.Controls.Add(Building_NumberLabel)
        Me.Controls.Add(Me.Building_NumberTextBox)
        Me.Controls.Add(Building_CreateDateLabel)
        Me.Controls.Add(Me.Building_CreateDateDateTimePicker)
        Me.Controls.Add(Building_ReviewDateLabel)
        Me.Controls.Add(Me.Building_ReviewDateDateTimePicker)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmOffice_Building"
        Me.Text = "Office Building - Physical Location Maintenance"
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOffice_BuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_PhysicalLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficePhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_OfficeBuilding.ResumeLayout(False)
        Me.tStrip_OfficeBuilding.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety_Data
    Friend WithEvents TlkpOffice_BuildingBindingSource As BindingSource
    Friend WithEvents TlkpOffice_BuildingTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOffice_BuildingTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents OfficeBuilding_IDTextBox As TextBox
    Friend WithEvents Office_IDComboBox As ComboBox
    Friend WithEvents Building_NameTextBox As TextBox
    Friend WithEvents Building_NumberTextBox As TextBox
    Friend WithEvents Building_CreateDateDateTimePicker As DateTimePicker
    Friend WithEvents Building_ReviewDateDateTimePicker As DateTimePicker
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
    Friend WithEvents TlkpOffice_PhysicalLocationTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter
    Friend WithEvents dgv_PhysicalLocation As DataGridView
    Friend WithEvents TlkpOfficePhysicalLocationBindingSource As BindingSource
    Friend WithEvents PhysicalLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeBuildingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationReviewDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationCreateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tStrip_OfficeBuilding As ToolStrip
    Friend WithEvents btn_BackToOffice As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btn_EditBuildingDetails As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_Building As ToolStripLabel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
