<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWSC_Search
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
        Dim WSC_NameLabel As System.Windows.Forms.Label
        Dim WSC_ActiveLabel As System.Windows.Forms.Label
        Me.Office_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.WSC_NameTextBox = New System.Windows.Forms.TextBox()
        Me.WSC_ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.dgv_WSCSearchResult = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WSCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_NewWSC = New FontAwesome.Sharp.IconButton()
        Me.WSCTableAdapter = New EnviroHealthSafetyTableAdapters.WSCTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.btn_Search = New FontAwesome.Sharp.IconButton()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter()
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter()
        Me.TStrip_WSCSearch = New System.Windows.Forms.ToolStrip()
        Me.btn_ClearWSCSearch = New FontAwesome.Sharp.IconButton()
        Office_IDLabel = New System.Windows.Forms.Label()
        WSC_NameLabel = New System.Windows.Forms.Label()
        WSC_ActiveLabel = New System.Windows.Forms.Label()
        CType(Me.dgv_WSCSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Office_IDLabel
        '
        Office_IDLabel.AutoSize = True
        Office_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Office_IDLabel.Location = New System.Drawing.Point(5, 143)
        Office_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Office_IDLabel.Name = "Office_IDLabel"
        Office_IDLabel.Size = New System.Drawing.Size(136, 38)
        Office_IDLabel.TabIndex = 3
        Office_IDLabel.Text = "Office ID:"
        '
        'WSC_NameLabel
        '
        WSC_NameLabel.AutoSize = True
        WSC_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WSC_NameLabel.Location = New System.Drawing.Point(5, 51)
        WSC_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WSC_NameLabel.Name = "WSC_NameLabel"
        WSC_NameLabel.Size = New System.Drawing.Size(233, 38)
        WSC_NameLabel.TabIndex = 5
        WSC_NameLabel.Text = "Reference Name:"
        '
        'WSC_ActiveLabel
        '
        WSC_ActiveLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WSC_ActiveLabel.AutoSize = True
        WSC_ActiveLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WSC_ActiveLabel.Location = New System.Drawing.Point(620, 52)
        WSC_ActiveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WSC_ActiveLabel.Name = "WSC_ActiveLabel"
        WSC_ActiveLabel.Size = New System.Drawing.Size(107, 38)
        WSC_ActiveLabel.TabIndex = 7
        WSC_ActiveLabel.Text = "Active?"
        '
        'Office_IDComboBox
        '
        Me.Office_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Office_IDComboBox.FormattingEnabled = True
        Me.Office_IDComboBox.Location = New System.Drawing.Point(12, 186)
        Me.Office_IDComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Office_IDComboBox.Name = "Office_IDComboBox"
        Me.Office_IDComboBox.Size = New System.Drawing.Size(718, 45)
        Me.Office_IDComboBox.TabIndex = 4
        '
        'WSC_NameTextBox
        '
        Me.WSC_NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WSC_NameTextBox.Location = New System.Drawing.Point(12, 94)
        Me.WSC_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_NameTextBox.Name = "WSC_NameTextBox"
        Me.WSC_NameTextBox.Size = New System.Drawing.Size(595, 43)
        Me.WSC_NameTextBox.TabIndex = 6
        '
        'WSC_ActiveCheckBox
        '
        Me.WSC_ActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WSC_ActiveCheckBox.Location = New System.Drawing.Point(663, 95)
        Me.WSC_ActiveCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WSC_ActiveCheckBox.Name = "WSC_ActiveCheckBox"
        Me.WSC_ActiveCheckBox.Size = New System.Drawing.Size(20, 42)
        Me.WSC_ActiveCheckBox.TabIndex = 8
        Me.WSC_ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'dgv_WSCSearchResult
        '
        Me.dgv_WSCSearchResult.AllowUserToAddRows = False
        Me.dgv_WSCSearchResult.AllowUserToDeleteRows = False
        Me.dgv_WSCSearchResult.AllowUserToOrderColumns = True
        Me.dgv_WSCSearchResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_WSCSearchResult.AutoGenerateColumns = False
        Me.dgv_WSCSearchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_WSCSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_WSCSearchResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewComboBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.dgv_WSCSearchResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_WSCSearchResult.DataSource = Me.WSCBindingSource
        Me.dgv_WSCSearchResult.Location = New System.Drawing.Point(12, 295)
        Me.dgv_WSCSearchResult.Name = "dgv_WSCSearchResult"
        Me.dgv_WSCSearchResult.ReadOnly = True
        Me.dgv_WSCSearchResult.RowHeadersWidth = 51
        Me.dgv_WSCSearchResult.RowTemplate.Height = 24
        Me.dgv_WSCSearchResult.Size = New System.Drawing.Size(716, 254)
        Me.dgv_WSCSearchResult.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WSC_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WSC_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WSC_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Reference Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewComboBoxColumn4
        '
        Me.DataGridViewComboBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewComboBoxColumn4.DataPropertyName = "Office_ID"
        Me.DataGridViewComboBoxColumn4.DataSource = Me.TlkpOfficeBindingSource
        Me.DataGridViewComboBoxColumn4.DisplayMember = "Office_Name"
        Me.DataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn4.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewComboBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewComboBoxColumn4.HeaderText = "Office"
        Me.DataGridViewComboBoxColumn4.MinimumWidth = 6
        Me.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4"
        Me.DataGridViewComboBoxColumn4.ReadOnly = True
        Me.DataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn4.ValueMember = "Office_ID"
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "WSC_DateCreated"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date Created"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 155
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "WSC_DateLastReviewed"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Last Reviewed"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 162
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "WSC_Active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 72
        '
        'WSCBindingSource
        '
        Me.WSCBindingSource.DataMember = "WSC"
        Me.WSCBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'btn_NewWSC
        '
        Me.btn_NewWSC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_NewWSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_NewWSC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewWSC.FlatAppearance.BorderSize = 0
        Me.btn_NewWSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewWSC.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_NewWSC.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NewWSC.ForeColor = System.Drawing.Color.White
        Me.btn_NewWSC.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_NewWSC.IconColor = System.Drawing.Color.Black
        Me.btn_NewWSC.IconSize = 16
        Me.btn_NewWSC.Location = New System.Drawing.Point(424, 249)
        Me.btn_NewWSC.Name = "btn_NewWSC"
        Me.btn_NewWSC.Rotation = 0R
        Me.btn_NewWSC.Size = New System.Drawing.Size(150, 40)
        Me.btn_NewWSC.TabIndex = 10
        Me.btn_NewWSC.Text = "New WSC"
        Me.btn_NewWSC.UseVisualStyleBackColor = False
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
        Me.TableAdapterManager.WSCTableAdapter = Me.WSCTableAdapter
        Me.TableAdapterManager.ztbl_Dev_FEGeneralTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_IssuesTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_LoginHistoryTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_Dev_TableManagerTableAdapter = Nothing
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Nothing
        '
        'btn_Search
        '
        Me.btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Search.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.Color.White
        Me.btn_Search.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_Search.IconColor = System.Drawing.Color.Black
        Me.btn_Search.IconSize = 16
        Me.btn_Search.Location = New System.Drawing.Point(580, 249)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Rotation = 0R
        Me.btn_Search.Size = New System.Drawing.Size(150, 40)
        Me.btn_Search.TabIndex = 12
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
        '
        'TStrip_WSCSearch
        '
        Me.TStrip_WSCSearch.AutoSize = False
        Me.TStrip_WSCSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TStrip_WSCSearch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip_WSCSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStrip_WSCSearch.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TStrip_WSCSearch.Location = New System.Drawing.Point(0, 0)
        Me.TStrip_WSCSearch.Name = "TStrip_WSCSearch"
        Me.TStrip_WSCSearch.Size = New System.Drawing.Size(740, 40)
        Me.TStrip_WSCSearch.TabIndex = 13
        Me.TStrip_WSCSearch.Text = "Search Waste Stream Characterization Tool Strip"
        '
        'btn_ClearWSCSearch
        '
        Me.btn_ClearWSCSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_ClearWSCSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ClearWSCSearch.FlatAppearance.BorderSize = 0
        Me.btn_ClearWSCSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ClearWSCSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_ClearWSCSearch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClearWSCSearch.ForeColor = System.Drawing.Color.White
        Me.btn_ClearWSCSearch.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_ClearWSCSearch.IconColor = System.Drawing.Color.Black
        Me.btn_ClearWSCSearch.IconSize = 16
        Me.btn_ClearWSCSearch.Location = New System.Drawing.Point(12, 249)
        Me.btn_ClearWSCSearch.Name = "btn_ClearWSCSearch"
        Me.btn_ClearWSCSearch.Rotation = 0R
        Me.btn_ClearWSCSearch.Size = New System.Drawing.Size(150, 40)
        Me.btn_ClearWSCSearch.TabIndex = 14
        Me.btn_ClearWSCSearch.Text = "Clear"
        Me.btn_ClearWSCSearch.UseVisualStyleBackColor = False
        '
        'frmWSC_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 561)
        Me.Controls.Add(Me.btn_ClearWSCSearch)
        Me.Controls.Add(Me.TStrip_WSCSearch)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_NewWSC)
        Me.Controls.Add(Me.dgv_WSCSearchResult)
        Me.Controls.Add(Me.WSC_ActiveCheckBox)
        Me.Controls.Add(WSC_NameLabel)
        Me.Controls.Add(Me.WSC_NameTextBox)
        Me.Controls.Add(Office_IDLabel)
        Me.Controls.Add(Me.Office_IDComboBox)
        Me.Controls.Add(WSC_ActiveLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmWSC_Search"
        Me.Text = "Search Waste Stream Characterization Report"
        CType(Me.dgv_WSCSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WSCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents WSCBindingSource As BindingSource
    Friend WithEvents WSCTableAdapter As EnviroHealthSafetyTableAdapters.WSCTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents Office_IDComboBox As ComboBox
    Friend WithEvents WSC_NameTextBox As TextBox
    Friend WithEvents WSC_ActiveCheckBox As CheckBox
    Friend WithEvents dgv_WSCSearchResult As DataGridView
    Friend WithEvents btn_NewWSC As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Search As FontAwesome.Sharp.IconButton
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafetyTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents TStrip_WSCSearch As ToolStrip
    Friend WithEvents btn_ClearWSCSearch As FontAwesome.Sharp.IconButton
End Class
