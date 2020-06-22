<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWSC_WSD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWSC_WSD))
        Me.TStrip_WSCDetermination = New System.Windows.Forms.ToolStrip()
        Me.TStrip_lbl_HeaderText = New System.Windows.Forms.ToolStripLabel()
        Me.checkbox_UserKnowledge = New System.Windows.Forms.CheckBox()
        Me.WSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.lbl_Determination = New System.Windows.Forms.Label()
        Me.WSCWSDUserKnowledgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.checkbox_WasteAnalysis = New System.Windows.Forms.CheckBox()
        Me.Panel_WasteAnalysis = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.dgv_WasteAnalysis = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSC_WSD_WasteAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WSCTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSCTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.WSC_WSD_UserKnowledgeTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_WSD_UserKnowledgeTableAdapter()
        Me.Panel_UserKnowledge = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.dgv_UserKnowledge = New System.Windows.Forms.DataGridView()
        Me.UserKnowledgeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSCIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserKnowledgeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserKnowledgeDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WSC_WSD_WasteAnalysisTableAdapter = New EnviroHealthSafety_DataTableAdapters.WSC_WSD_WasteAnalysisTableAdapter()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TStrip_WSCDetermination.SuspendLayout()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCWSDUserKnowledgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_WasteAnalysis.SuspendLayout()
        CType(Me.dgv_WasteAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSC_WSD_WasteAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_UserKnowledge.SuspendLayout()
        CType(Me.dgv_UserKnowledge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TStrip_WSCDetermination
        '
        Me.TStrip_WSCDetermination.AutoSize = False
        Me.TStrip_WSCDetermination.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TStrip_WSCDetermination.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStrip_WSCDetermination.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TStrip_WSCDetermination.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TStrip_lbl_HeaderText, Me.ToolStripButton1})
        Me.TStrip_WSCDetermination.Location = New System.Drawing.Point(0, 0)
        Me.TStrip_WSCDetermination.Name = "TStrip_WSCDetermination"
        Me.TStrip_WSCDetermination.Size = New System.Drawing.Size(778, 40)
        Me.TStrip_WSCDetermination.TabIndex = 0
        Me.TStrip_WSCDetermination.Text = "ToolStrip1"
        '
        'TStrip_lbl_HeaderText
        '
        Me.TStrip_lbl_HeaderText.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip_lbl_HeaderText.ForeColor = System.Drawing.Color.White
        Me.TStrip_lbl_HeaderText.Name = "TStrip_lbl_HeaderText"
        Me.TStrip_lbl_HeaderText.Size = New System.Drawing.Size(134, 37)
        Me.TStrip_lbl_HeaderText.Text = "ToolStripLabel1"
        '
        'checkbox_UserKnowledge
        '
        Me.checkbox_UserKnowledge.AutoSize = True
        Me.checkbox_UserKnowledge.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.WSCBindingSource, "WSC_WDB_UKnowledge", True))
        Me.checkbox_UserKnowledge.Dock = System.Windows.Forms.DockStyle.Top
        Me.checkbox_UserKnowledge.Location = New System.Drawing.Point(0, 78)
        Me.checkbox_UserKnowledge.Name = "checkbox_UserKnowledge"
        Me.checkbox_UserKnowledge.Padding = New System.Windows.Forms.Padding(40, 10, 0, 5)
        Me.checkbox_UserKnowledge.Size = New System.Drawing.Size(778, 47)
        Me.checkbox_UserKnowledge.TabIndex = 3
        Me.checkbox_UserKnowledge.Text = "User Knowledge (Process evaluation, SDSs, and Interviews)"
        Me.checkbox_UserKnowledge.UseVisualStyleBackColor = True
        '
        'WSCBindingSource
        '
        Me.WSCBindingSource.DataMember = "WSC"
        Me.WSCBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_Determination
        '
        Me.lbl_Determination.AutoSize = True
        Me.lbl_Determination.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_Determination.Location = New System.Drawing.Point(0, 40)
        Me.lbl_Determination.Name = "lbl_Determination"
        Me.lbl_Determination.Padding = New System.Windows.Forms.Padding(15, 10, 0, 0)
        Me.lbl_Determination.Size = New System.Drawing.Size(298, 38)
        Me.lbl_Determination.TabIndex = 4
        Me.lbl_Determination.Text = "Waste determination based on:"
        '
        'WSCWSDUserKnowledgeBindingSource
        '
        Me.WSCWSDUserKnowledgeBindingSource.DataMember = "WSC_WSD_UserKnowledge"
        Me.WSCWSDUserKnowledgeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'checkbox_WasteAnalysis
        '
        Me.checkbox_WasteAnalysis.AutoSize = True
        Me.checkbox_WasteAnalysis.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.WSCBindingSource, "WSC_WDB_WAnalysis", True))
        Me.checkbox_WasteAnalysis.Dock = System.Windows.Forms.DockStyle.Top
        Me.checkbox_WasteAnalysis.Location = New System.Drawing.Point(0, 475)
        Me.checkbox_WasteAnalysis.Name = "checkbox_WasteAnalysis"
        Me.checkbox_WasteAnalysis.Padding = New System.Windows.Forms.Padding(40, 10, 0, 5)
        Me.checkbox_WasteAnalysis.Size = New System.Drawing.Size(778, 47)
        Me.checkbox_WasteAnalysis.TabIndex = 5
        Me.checkbox_WasteAnalysis.Text = "Waste Analysis (List all sampling dates and attach analytical results)"
        Me.checkbox_WasteAnalysis.UseVisualStyleBackColor = True
        '
        'Panel_WasteAnalysis
        '
        Me.Panel_WasteAnalysis.AutoScroll = True
        Me.Panel_WasteAnalysis.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_WasteAnalysis.Controls.Add(Me.IconButton2)
        Me.Panel_WasteAnalysis.Controls.Add(Me.dgv_WasteAnalysis)
        Me.Panel_WasteAnalysis.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_WasteAnalysis.Location = New System.Drawing.Point(0, 522)
        Me.Panel_WasteAnalysis.Name = "Panel_WasteAnalysis"
        Me.Panel_WasteAnalysis.Size = New System.Drawing.Size(778, 350)
        Me.Panel_WasteAnalysis.TabIndex = 3
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton2.IconSize = 16
        Me.IconButton2.Location = New System.Drawing.Point(626, 6)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(122, 40)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "IconButton2"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'dgv_WasteAnalysis
        '
        Me.dgv_WasteAnalysis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_WasteAnalysis.AutoGenerateColumns = False
        Me.dgv_WasteAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_WasteAnalysis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.dgv_WasteAnalysis.DataSource = Me.WSC_WSD_WasteAnalysisBindingSource
        Me.dgv_WasteAnalysis.Location = New System.Drawing.Point(12, 52)
        Me.dgv_WasteAnalysis.Name = "dgv_WasteAnalysis"
        Me.dgv_WasteAnalysis.RowHeadersWidth = 51
        Me.dgv_WasteAnalysis.RowTemplate.Height = 24
        Me.dgv_WasteAnalysis.Size = New System.Drawing.Size(736, 286)
        Me.dgv_WasteAnalysis.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WasteAnalysis_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WasteAnalysis_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WSC_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "WSC_ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WasteAnalysis_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Analysis Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WasteAnalysis_SamplingDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sampling Date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Library_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Library"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'WSC_WSD_WasteAnalysisBindingSource
        '
        Me.WSC_WSD_WasteAnalysisBindingSource.DataMember = "WSC_WSD_WasteAnalysis"
        Me.WSC_WSD_WasteAnalysisBindingSource.DataSource = Me.EnviroHealthSafety_Data
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
        Me.TableAdapterManager.WSC_WSD_UserKnowledgeTableAdapter = Me.WSC_WSD_UserKnowledgeTableAdapter
        Me.TableAdapterManager.WSC_WSD_WasteAnalysisTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTD_UHCListTableAdapter = Nothing
        Me.TableAdapterManager.WSC_WSTDTableAdapter = Nothing
        Me.TableAdapterManager.WSCTableAdapter = Me.WSCTableAdapter
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'WSC_WSD_UserKnowledgeTableAdapter
        '
        Me.WSC_WSD_UserKnowledgeTableAdapter.ClearBeforeFill = True
        '
        'Panel_UserKnowledge
        '
        Me.Panel_UserKnowledge.AutoScroll = True
        Me.Panel_UserKnowledge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_UserKnowledge.Controls.Add(Me.IconButton1)
        Me.Panel_UserKnowledge.Controls.Add(Me.dgv_UserKnowledge)
        Me.Panel_UserKnowledge.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_UserKnowledge.Location = New System.Drawing.Point(0, 125)
        Me.Panel_UserKnowledge.Name = "Panel_UserKnowledge"
        Me.Panel_UserKnowledge.Size = New System.Drawing.Size(778, 350)
        Me.Panel_UserKnowledge.TabIndex = 6
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(626, 6)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(122, 40)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'dgv_UserKnowledge
        '
        Me.dgv_UserKnowledge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_UserKnowledge.AutoGenerateColumns = False
        Me.dgv_UserKnowledge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_UserKnowledge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_UserKnowledge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UserKnowledge.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserKnowledgeIDDataGridViewTextBoxColumn, Me.WSCIDDataGridViewTextBoxColumn, Me.UserKnowledgeNameDataGridViewTextBoxColumn, Me.UserKnowledgeTypeDataGridViewTextBoxColumn, Me.UserKnowledgeDateDataGridViewTextBoxColumn, Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn})
        Me.dgv_UserKnowledge.DataSource = Me.WSCWSDUserKnowledgeBindingSource
        Me.dgv_UserKnowledge.Location = New System.Drawing.Point(12, 52)
        Me.dgv_UserKnowledge.Name = "dgv_UserKnowledge"
        Me.dgv_UserKnowledge.RowHeadersWidth = 51
        Me.dgv_UserKnowledge.RowTemplate.Height = 24
        Me.dgv_UserKnowledge.Size = New System.Drawing.Size(736, 292)
        Me.dgv_UserKnowledge.TabIndex = 0
        '
        'UserKnowledgeIDDataGridViewTextBoxColumn
        '
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.DataPropertyName = "UserKnowledge_ID"
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.HeaderText = "UserKnowledge_ID"
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.Name = "UserKnowledgeIDDataGridViewTextBoxColumn"
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.Visible = False
        Me.UserKnowledgeIDDataGridViewTextBoxColumn.Width = 125
        '
        'WSCIDDataGridViewTextBoxColumn
        '
        Me.WSCIDDataGridViewTextBoxColumn.DataPropertyName = "WSC_ID"
        Me.WSCIDDataGridViewTextBoxColumn.HeaderText = "WSC_ID"
        Me.WSCIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WSCIDDataGridViewTextBoxColumn.Name = "WSCIDDataGridViewTextBoxColumn"
        Me.WSCIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WSCIDDataGridViewTextBoxColumn.Visible = False
        Me.WSCIDDataGridViewTextBoxColumn.Width = 125
        '
        'UserKnowledgeNameDataGridViewTextBoxColumn
        '
        Me.UserKnowledgeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserKnowledgeNameDataGridViewTextBoxColumn.DataPropertyName = "UserKnowledge_Name"
        Me.UserKnowledgeNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.UserKnowledgeNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserKnowledgeNameDataGridViewTextBoxColumn.Name = "UserKnowledgeNameDataGridViewTextBoxColumn"
        '
        'UserKnowledgeTypeDataGridViewTextBoxColumn
        '
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.DataPropertyName = "UserKnowledge_Type"
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.Name = "UserKnowledgeTypeDataGridViewTextBoxColumn"
        Me.UserKnowledgeTypeDataGridViewTextBoxColumn.Width = 82
        '
        'UserKnowledgeDateDataGridViewTextBoxColumn
        '
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.DataPropertyName = "UserKnowledge_Date"
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.Name = "UserKnowledgeDateDataGridViewTextBoxColumn"
        Me.UserKnowledgeDateDataGridViewTextBoxColumn.Width = 82
        '
        'UserKnowledgeLibraryIDDataGridViewTextBoxColumn
        '
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.DataPropertyName = "UserKnowledge_Library_ID"
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.HeaderText = "Library"
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.Name = "UserKnowledgeLibraryIDDataGridViewTextBoxColumn"
        Me.UserKnowledgeLibraryIDDataGridViewTextBoxColumn.Width = 101
        '
        'WSC_WSD_WasteAnalysisTableAdapter
        '
        Me.WSC_WSD_WasteAnalysisTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 37)
        Me.ToolStripButton1.Text = "Identification"
        '
        'frmWSC_WSD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(799, 553)
        Me.Controls.Add(Me.Panel_WasteAnalysis)
        Me.Controls.Add(Me.checkbox_WasteAnalysis)
        Me.Controls.Add(Me.Panel_UserKnowledge)
        Me.Controls.Add(Me.checkbox_UserKnowledge)
        Me.Controls.Add(Me.lbl_Determination)
        Me.Controls.Add(Me.TStrip_WSCDetermination)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmWSC_WSD"
        Me.Text = "Form1"
        Me.TStrip_WSCDetermination.ResumeLayout(False)
        Me.TStrip_WSCDetermination.PerformLayout()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCWSDUserKnowledgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_WasteAnalysis.ResumeLayout(False)
        CType(Me.dgv_WasteAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSC_WSD_WasteAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_UserKnowledge.ResumeLayout(False)
        CType(Me.dgv_UserKnowledge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TStrip_WSCDetermination As ToolStrip
    Friend WithEvents TStrip_lbl_HeaderText As ToolStripLabel
    Friend WithEvents checkbox_UserKnowledge As CheckBox
    Friend WithEvents lbl_Determination As Label
    Friend WithEvents checkbox_WasteAnalysis As CheckBox
    Friend WithEvents Panel_WasteAnalysis As Panel
    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents WSCBindingSource As BindingSource
    Friend WithEvents WSCTableAdapter As EnviroHealthSafety_DataTableAdapters.WSCTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents WSC_WSD_UserKnowledgeTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_WSD_UserKnowledgeTableAdapter
    Friend WithEvents WSCWSDUserKnowledgeBindingSource As BindingSource
    Friend WithEvents Panel_UserKnowledge As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_UserKnowledge As DataGridView
    Friend WithEvents UserKnowledgeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WSCIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserKnowledgeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserKnowledgeTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserKnowledgeDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserKnowledgeLibraryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WSC_WSD_WasteAnalysisBindingSource As BindingSource
    Friend WithEvents WSC_WSD_WasteAnalysisTableAdapter As EnviroHealthSafety_DataTableAdapters.WSC_WSD_WasteAnalysisTableAdapter
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_WasteAnalysis As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
