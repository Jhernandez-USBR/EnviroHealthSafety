<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOffice
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
        Dim Region_IDLabel As System.Windows.Forms.Label
        Dim Office_TypeLabel As System.Windows.Forms.Label
        Dim Office_NameLabel As System.Windows.Forms.Label
        Dim Office_AbbrLabel As System.Windows.Forms.Label
        Dim Office_EmailLabel As System.Windows.Forms.Label
        Dim Office_WebsiteLabel As System.Windows.Forms.Label
        Dim Office_StateLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety = New EnviroHealthSafety
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.TlkpOffice_BuildingTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOffice_BuildingTableAdapter()
        Me.TlkpOffice_TypeTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOffice_TypeTableAdapter()
        Me.TlkpRegionTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpRegionTableAdapter()
        Me.txtOffice_ID = New System.Windows.Forms.TextBox()
        Me.Region_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpRegionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Office_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpOfficeTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Office_AbbrTextBox = New System.Windows.Forms.TextBox()
        Me.Office_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Office_WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.Office_StateTextBox = New System.Windows.Forms.TextBox()
        Me.dgv_OfficeBuilding = New System.Windows.Forms.DataGridView()
        Me.OfficeBuildingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingCreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingReviewDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TlkpOfficeBuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_OfficeName = New System.Windows.Forms.ComboBox()
        Me.btn_NewBuilding = New FontAwesome.Sharp.IconButton()
        Me.tStrip_Office = New System.Windows.Forms.ToolStrip()
        Me.btn_BackToRegion = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_FullPath = New System.Windows.Forms.ToolStripLabel()
        Me.btn_EditOfficeDetails = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_Office = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Region_IDLabel = New System.Windows.Forms.Label()
        Office_TypeLabel = New System.Windows.Forms.Label()
        Office_NameLabel = New System.Windows.Forms.Label()
        Office_AbbrLabel = New System.Windows.Forms.Label()
        Office_EmailLabel = New System.Windows.Forms.Label()
        Office_WebsiteLabel = New System.Windows.Forms.Label()
        Office_StateLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpRegionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_OfficeBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_Office.SuspendLayout()
        Me.SuspendLayout()
        '
        'Region_IDLabel
        '
        Region_IDLabel.AutoSize = True
        Region_IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Region_IDLabel.Location = New System.Drawing.Point(54, 97)
        Region_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Region_IDLabel.Name = "Region_IDLabel"
        Region_IDLabel.Size = New System.Drawing.Size(101, 28)
        Region_IDLabel.TabIndex = 3
        Region_IDLabel.Text = "Region ID:"
        '
        'Office_TypeLabel
        '
        Office_TypeLabel.AutoSize = True
        Office_TypeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_TypeLabel.Location = New System.Drawing.Point(42, 143)
        Office_TypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_TypeLabel.Name = "Office_TypeLabel"
        Office_TypeLabel.Size = New System.Drawing.Size(113, 28)
        Office_TypeLabel.TabIndex = 5
        Office_TypeLabel.Text = "Office Type:"
        '
        'Office_NameLabel
        '
        Office_NameLabel.AutoSize = True
        Office_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_NameLabel.Location = New System.Drawing.Point(31, 54)
        Office_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_NameLabel.Name = "Office_NameLabel"
        Office_NameLabel.Size = New System.Drawing.Size(124, 28)
        Office_NameLabel.TabIndex = 7
        Office_NameLabel.Text = "Office Name:"
        '
        'Office_AbbrLabel
        '
        Office_AbbrLabel.AutoSize = True
        Office_AbbrLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_AbbrLabel.Location = New System.Drawing.Point(39, 189)
        Office_AbbrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_AbbrLabel.Name = "Office_AbbrLabel"
        Office_AbbrLabel.Size = New System.Drawing.Size(116, 28)
        Office_AbbrLabel.TabIndex = 9
        Office_AbbrLabel.Text = "Office Abbr:"
        '
        'Office_EmailLabel
        '
        Office_EmailLabel.AutoSize = True
        Office_EmailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_EmailLabel.Location = New System.Drawing.Point(34, 233)
        Office_EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_EmailLabel.Name = "Office_EmailLabel"
        Office_EmailLabel.Size = New System.Drawing.Size(119, 28)
        Office_EmailLabel.TabIndex = 13
        Office_EmailLabel.Text = "Office Email:"
        '
        'Office_WebsiteLabel
        '
        Office_WebsiteLabel.AutoSize = True
        Office_WebsiteLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_WebsiteLabel.Location = New System.Drawing.Point(13, 277)
        Office_WebsiteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_WebsiteLabel.Name = "Office_WebsiteLabel"
        Office_WebsiteLabel.Size = New System.Drawing.Size(142, 28)
        Office_WebsiteLabel.TabIndex = 15
        Office_WebsiteLabel.Text = "Office Website:"
        '
        'Office_StateLabel
        '
        Office_StateLabel.AutoSize = True
        Office_StateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_StateLabel.Location = New System.Drawing.Point(39, 321)
        Office_StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_StateLabel.Name = "Office_StateLabel"
        Office_StateLabel.Size = New System.Drawing.Size(116, 28)
        Office_StateLabel.TabIndex = 17
        Office_StateLabel.Text = "Office State:"
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tlkpOffice_PhysicalLocationTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_TypeTableAdapter = Me.TlkpOffice_TypeTableAdapter
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
        'TlkpOffice_BuildingTableAdapter
        '
        Me.TlkpOffice_BuildingTableAdapter.ClearBeforeFill = True
        '
        'TlkpOffice_TypeTableAdapter
        '
        Me.TlkpOffice_TypeTableAdapter.ClearBeforeFill = True
        '
        'TlkpRegionTableAdapter
        '
        Me.TlkpRegionTableAdapter.ClearBeforeFill = True
        '
        'txtOffice_ID
        '
        Me.txtOffice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOffice_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOfficeBindingSource, "Office_ID", True))
        Me.txtOffice_ID.Enabled = False
        Me.txtOffice_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice_ID.Location = New System.Drawing.Point(650, 54)
        Me.txtOffice_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOffice_ID.Name = "txtOffice_ID"
        Me.txtOffice_ID.Size = New System.Drawing.Size(71, 34)
        Me.txtOffice_ID.TabIndex = 2
        '
        'Region_IDComboBox
        '
        Me.Region_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Region_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TlkpOfficeBindingSource, "Region_ID", True))
        Me.Region_IDComboBox.DataSource = Me.TlkpRegionBindingSource
        Me.Region_IDComboBox.DisplayMember = "Region_Name"
        Me.Region_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Region_IDComboBox.FormattingEnabled = True
        Me.Region_IDComboBox.Location = New System.Drawing.Point(161, 97)
        Me.Region_IDComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Region_IDComboBox.Name = "Region_IDComboBox"
        Me.Region_IDComboBox.Size = New System.Drawing.Size(560, 36)
        Me.Region_IDComboBox.TabIndex = 4
        Me.Region_IDComboBox.TabStop = False
        Me.Region_IDComboBox.ValueMember = "Region_ID"
        '
        'TlkpRegionBindingSource
        '
        Me.TlkpRegionBindingSource.DataMember = "tlkpRegion"
        Me.TlkpRegionBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Office_TypeComboBox
        '
        Me.Office_TypeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TlkpOfficeBindingSource, "Office_Type", True))
        Me.Office_TypeComboBox.DataSource = Me.TlkpOfficeTypeBindingSource
        Me.Office_TypeComboBox.DisplayMember = "OfficeType"
        Me.Office_TypeComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_TypeComboBox.FormattingEnabled = True
        Me.Office_TypeComboBox.Location = New System.Drawing.Point(161, 143)
        Me.Office_TypeComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_TypeComboBox.Name = "Office_TypeComboBox"
        Me.Office_TypeComboBox.Size = New System.Drawing.Size(560, 36)
        Me.Office_TypeComboBox.TabIndex = 6
        Me.Office_TypeComboBox.TabStop = False
        Me.Office_TypeComboBox.ValueMember = "OfficeType_ID"
        '
        'TlkpOfficeTypeBindingSource
        '
        Me.TlkpOfficeTypeBindingSource.DataMember = "tlkpOffice_Type"
        Me.TlkpOfficeTypeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Office_AbbrTextBox
        '
        Me.Office_AbbrTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_AbbrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOfficeBindingSource, "Office_Abbr", True))
        Me.Office_AbbrTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_AbbrTextBox.Location = New System.Drawing.Point(161, 189)
        Me.Office_AbbrTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_AbbrTextBox.Name = "Office_AbbrTextBox"
        Me.Office_AbbrTextBox.Size = New System.Drawing.Size(560, 34)
        Me.Office_AbbrTextBox.TabIndex = 10
        Me.Office_AbbrTextBox.TabStop = False
        '
        'Office_EmailTextBox
        '
        Me.Office_EmailTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOfficeBindingSource, "Office_Email", True))
        Me.Office_EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_EmailTextBox.Location = New System.Drawing.Point(161, 233)
        Me.Office_EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_EmailTextBox.Name = "Office_EmailTextBox"
        Me.Office_EmailTextBox.Size = New System.Drawing.Size(560, 34)
        Me.Office_EmailTextBox.TabIndex = 14
        Me.Office_EmailTextBox.TabStop = False
        '
        'Office_WebsiteTextBox
        '
        Me.Office_WebsiteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOfficeBindingSource, "Office_Website", True))
        Me.Office_WebsiteTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_WebsiteTextBox.Location = New System.Drawing.Point(161, 277)
        Me.Office_WebsiteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_WebsiteTextBox.Name = "Office_WebsiteTextBox"
        Me.Office_WebsiteTextBox.Size = New System.Drawing.Size(560, 34)
        Me.Office_WebsiteTextBox.TabIndex = 16
        Me.Office_WebsiteTextBox.TabStop = False
        '
        'Office_StateTextBox
        '
        Me.Office_StateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOfficeBindingSource, "Office_State", True))
        Me.Office_StateTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_StateTextBox.Location = New System.Drawing.Point(161, 321)
        Me.Office_StateTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_StateTextBox.Name = "Office_StateTextBox"
        Me.Office_StateTextBox.Size = New System.Drawing.Size(560, 34)
        Me.Office_StateTextBox.TabIndex = 18
        Me.Office_StateTextBox.TabStop = False
        '
        'dgv_OfficeBuilding
        '
        Me.dgv_OfficeBuilding.AllowUserToAddRows = False
        Me.dgv_OfficeBuilding.AllowUserToDeleteRows = False
        Me.dgv_OfficeBuilding.AllowUserToOrderColumns = True
        Me.dgv_OfficeBuilding.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_OfficeBuilding.AutoGenerateColumns = False
        Me.dgv_OfficeBuilding.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_OfficeBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_OfficeBuilding.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OfficeBuildingIDDataGridViewTextBoxColumn, Me.OfficeIDDataGridViewTextBoxColumn, Me.BuildingNameDataGridViewTextBoxColumn, Me.BuildingNumberDataGridViewTextBoxColumn, Me.BuildingCreateDateDataGridViewTextBoxColumn, Me.BuildingReviewDateDataGridViewTextBoxColumn})
        Me.dgv_OfficeBuilding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_OfficeBuilding.DataSource = Me.TlkpOfficeBuildingBindingSource
        Me.dgv_OfficeBuilding.Location = New System.Drawing.Point(18, 429)
        Me.dgv_OfficeBuilding.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_OfficeBuilding.Name = "dgv_OfficeBuilding"
        Me.dgv_OfficeBuilding.ReadOnly = True
        Me.dgv_OfficeBuilding.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_OfficeBuilding.RowTemplate.Height = 24
        Me.dgv_OfficeBuilding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_OfficeBuilding.Size = New System.Drawing.Size(703, 113)
        Me.dgv_OfficeBuilding.TabIndex = 19
        '
        'OfficeBuildingIDDataGridViewTextBoxColumn
        '
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.DataPropertyName = "OfficeBuilding_ID"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.HeaderText = "Office Building ID"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.Name = "OfficeBuildingIDDataGridViewTextBoxColumn"
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.Visible = False
        Me.OfficeBuildingIDDataGridViewTextBoxColumn.Width = 125
        '
        'OfficeIDDataGridViewTextBoxColumn
        '
        Me.OfficeIDDataGridViewTextBoxColumn.DataPropertyName = "Office_ID"
        Me.OfficeIDDataGridViewTextBoxColumn.HeaderText = "Office_ID"
        Me.OfficeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OfficeIDDataGridViewTextBoxColumn.Name = "OfficeIDDataGridViewTextBoxColumn"
        Me.OfficeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OfficeIDDataGridViewTextBoxColumn.Visible = False
        Me.OfficeIDDataGridViewTextBoxColumn.Width = 125
        '
        'BuildingNameDataGridViewTextBoxColumn
        '
        Me.BuildingNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BuildingNameDataGridViewTextBoxColumn.DataPropertyName = "Building_Name"
        Me.BuildingNameDataGridViewTextBoxColumn.HeaderText = "Building Name"
        Me.BuildingNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuildingNameDataGridViewTextBoxColumn.Name = "BuildingNameDataGridViewTextBoxColumn"
        Me.BuildingNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuildingNumberDataGridViewTextBoxColumn
        '
        Me.BuildingNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BuildingNumberDataGridViewTextBoxColumn.DataPropertyName = "Building_Number"
        Me.BuildingNumberDataGridViewTextBoxColumn.HeaderText = "Building Number"
        Me.BuildingNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BuildingNumberDataGridViewTextBoxColumn.Name = "BuildingNumberDataGridViewTextBoxColumn"
        Me.BuildingNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuildingNumberDataGridViewTextBoxColumn.Width = 190
        '
        'BuildingCreateDateDataGridViewTextBoxColumn
        '
        Me.BuildingCreateDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BuildingCreateDateDataGridViewTextBoxColumn.DataPropertyName = "Building_CreateDate"
        Me.BuildingCreateDateDataGridViewTextBoxColumn.HeaderText = "Create Date"
        Me.BuildingCreateDateDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.BuildingCreateDateDataGridViewTextBoxColumn.Name = "BuildingCreateDateDataGridViewTextBoxColumn"
        Me.BuildingCreateDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuildingCreateDateDataGridViewTextBoxColumn.Width = 150
        '
        'BuildingReviewDateDataGridViewTextBoxColumn
        '
        Me.BuildingReviewDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.BuildingReviewDateDataGridViewTextBoxColumn.DataPropertyName = "Building_ReviewDate"
        Me.BuildingReviewDateDataGridViewTextBoxColumn.HeaderText = "Review Date"
        Me.BuildingReviewDateDataGridViewTextBoxColumn.MinimumWidth = 150
        Me.BuildingReviewDateDataGridViewTextBoxColumn.Name = "BuildingReviewDateDataGridViewTextBoxColumn"
        Me.BuildingReviewDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuildingReviewDateDataGridViewTextBoxColumn.Width = 150
        '
        'TlkpOfficeBuildingBindingSource
        '
        Me.TlkpOfficeBuildingBindingSource.DataMember = "tlkpOffice_Building"
        Me.TlkpOfficeBuildingBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'cmb_OfficeName
        '
        Me.cmb_OfficeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_OfficeName.DataSource = Me.TlkpOfficeBindingSource
        Me.cmb_OfficeName.DisplayMember = "Office_Name"
        Me.cmb_OfficeName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_OfficeName.FormattingEnabled = True
        Me.cmb_OfficeName.Location = New System.Drawing.Point(161, 54)
        Me.cmb_OfficeName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_OfficeName.Name = "cmb_OfficeName"
        Me.cmb_OfficeName.Size = New System.Drawing.Size(483, 36)
        Me.cmb_OfficeName.TabIndex = 21
        Me.cmb_OfficeName.ValueMember = "Office_ID"
        '
        'btn_NewBuilding
        '
        Me.btn_NewBuilding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_NewBuilding.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_NewBuilding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewBuilding.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_NewBuilding.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewBuilding.ForeColor = System.Drawing.Color.White
        Me.btn_NewBuilding.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.btn_NewBuilding.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_NewBuilding.IconSize = 22
        Me.btn_NewBuilding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NewBuilding.Location = New System.Drawing.Point(552, 382)
        Me.btn_NewBuilding.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_NewBuilding.Name = "btn_NewBuilding"
        Me.btn_NewBuilding.Rotation = 0R
        Me.btn_NewBuilding.Size = New System.Drawing.Size(169, 43)
        Me.btn_NewBuilding.TabIndex = 22
        Me.btn_NewBuilding.Text = "New Building"
        Me.btn_NewBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NewBuilding.UseVisualStyleBackColor = False
        '
        'tStrip_Office
        '
        Me.tStrip_Office.AutoSize = False
        Me.tStrip_Office.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_Office.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_Office.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_Office.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_Office.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_BackToRegion, Me.tStrip_lbl_FullPath, Me.btn_EditOfficeDetails, Me.tStrip_lbl_Office, Me.ToolStripLabel2})
        Me.tStrip_Office.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_Office.Name = "tStrip_Office"
        Me.tStrip_Office.Padding = New System.Windows.Forms.Padding(0)
        Me.tStrip_Office.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tStrip_Office.Size = New System.Drawing.Size(734, 40)
        Me.tStrip_Office.TabIndex = 23
        Me.tStrip_Office.Text = "tStrip_Office"
        '
        'btn_BackToRegion
        '
        Me.btn_BackToRegion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_BackToRegion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_BackToRegion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_BackToRegion.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackToRegion.ForeColor = System.Drawing.Color.White
        Me.btn_BackToRegion.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btn_BackToRegion.IconColor = System.Drawing.Color.White
        Me.btn_BackToRegion.IconSize = 50
        Me.btn_BackToRegion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_BackToRegion.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BackToRegion.Name = "btn_BackToRegion"
        Me.btn_BackToRegion.Rotation = 0R
        Me.btn_BackToRegion.Size = New System.Drawing.Size(29, 40)
        Me.btn_BackToRegion.Text = "Region"
        Me.btn_BackToRegion.ToolTipText = " Back to Region Managment"
        '
        'tStrip_lbl_FullPath
        '
        Me.tStrip_lbl_FullPath.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_FullPath.Name = "tStrip_lbl_FullPath"
        Me.tStrip_lbl_FullPath.Size = New System.Drawing.Size(88, 37)
        Me.tStrip_lbl_FullPath.Text = "Region <"
        '
        'btn_EditOfficeDetails
        '
        Me.btn_EditOfficeDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_EditOfficeDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_EditOfficeDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_EditOfficeDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_EditOfficeDetails.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_EditOfficeDetails.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btn_EditOfficeDetails.IconSize = 50
        Me.btn_EditOfficeDetails.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btn_EditOfficeDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_EditOfficeDetails.Name = "btn_EditOfficeDetails"
        Me.btn_EditOfficeDetails.Rotation = 0R
        Me.btn_EditOfficeDetails.Size = New System.Drawing.Size(29, 40)
        Me.btn_EditOfficeDetails.Text = "Edit Office Details"
        '
        'tStrip_lbl_Office
        '
        Me.tStrip_lbl_Office.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_Office.Name = "tStrip_lbl_Office"
        Me.tStrip_lbl_Office.Size = New System.Drawing.Size(62, 37)
        Me.tStrip_lbl_Office.Text = "Office"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(158, 37)
        Me.ToolStripLabel2.Text = "Edit Office Details"
        '
        'frmOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.tStrip_Office)
        Me.Controls.Add(Me.btn_NewBuilding)
        Me.Controls.Add(Me.cmb_OfficeName)
        Me.Controls.Add(Me.dgv_OfficeBuilding)
        Me.Controls.Add(Me.txtOffice_ID)
        Me.Controls.Add(Region_IDLabel)
        Me.Controls.Add(Me.Region_IDComboBox)
        Me.Controls.Add(Office_TypeLabel)
        Me.Controls.Add(Me.Office_TypeComboBox)
        Me.Controls.Add(Office_NameLabel)
        Me.Controls.Add(Office_AbbrLabel)
        Me.Controls.Add(Me.Office_AbbrTextBox)
        Me.Controls.Add(Office_EmailLabel)
        Me.Controls.Add(Me.Office_EmailTextBox)
        Me.Controls.Add(Office_WebsiteLabel)
        Me.Controls.Add(Me.Office_WebsiteTextBox)
        Me.Controls.Add(Office_StateLabel)
        Me.Controls.Add(Me.Office_StateTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmOffice"
        Me.Text = "Office - Building Managment"
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpRegionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_OfficeBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_Office.ResumeLayout(False)
        Me.tStrip_Office.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents txtOffice_ID As TextBox
    Friend WithEvents Region_IDComboBox As ComboBox
    Friend WithEvents Office_TypeComboBox As ComboBox
    Friend WithEvents Office_AbbrTextBox As TextBox
    Friend WithEvents Office_EmailTextBox As TextBox
    Friend WithEvents Office_WebsiteTextBox As TextBox
    Friend WithEvents Office_StateTextBox As TextBox
    Friend WithEvents TlkpRegionTableAdapter As EnviroHealthSafetyTableAdapters.tlkpRegionTableAdapter
    Friend WithEvents TlkpRegionBindingSource As BindingSource
    Friend WithEvents TlkpOffice_TypeTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOffice_TypeTableAdapter
    Friend WithEvents TlkpOfficeTypeBindingSource As BindingSource
    Friend WithEvents TlkpOffice_BuildingTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOffice_BuildingTableAdapter
    Friend WithEvents dgv_OfficeBuilding As DataGridView
    Friend WithEvents TlkpOfficeBuildingBindingSource As BindingSource
    Friend WithEvents cmb_OfficeName As ComboBox
    Friend WithEvents btn_NewBuilding As FontAwesome.Sharp.IconButton
    Friend WithEvents OfficeBuildingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuildingNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuildingNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuildingCreateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuildingReviewDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tStrip_Office As ToolStrip
    Friend WithEvents btn_BackToRegion As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_FullPath As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btn_EditOfficeDetails As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_Office As ToolStripLabel
End Class
