<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffice_PhysicalLocation
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
        Dim OfficeBuilding_IDLabel As System.Windows.Forms.Label
        Dim PhysicalLocation_NameLabel As System.Windows.Forms.Label
        Dim PhysicalLocation_DescriptionLabel As System.Windows.Forms.Label
        Dim PhysicalLocation_TypeLabel As System.Windows.Forms.Label
        Dim PhysicalLocation_ReviewDateLabel As System.Windows.Forms.Label
        Dim PhysicalLocation_CreateDateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.TlkpOffice_PhysicalLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TlkpOffice_PhysicalLocationTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.TlkpOffice_BuildingTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOffice_BuildingTableAdapter()
        Me.txtPhysicalLocation_ID = New System.Windows.Forms.TextBox()
        Me.OfficeBuilding_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpOfficeBuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhysicalLocation_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicalLocation_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicalLocation_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicalLocation_ReviewDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PhysicalLocation_CreateDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ChemicalProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChemicalLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_LocationTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_LocationTableAdapter()
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter()
        Me.lbl_ChemicalDataGridView = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.IconToolStripButton2 = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Save = New FontAwesome.Sharp.IconToolStripButton()
        Me.TlkpOffice_PhysicalLocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btn_BackToOffice = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_FullPath = New System.Windows.Forms.ToolStripLabel()
        Me.btn_AddChemicalProduct = New FontAwesome.Sharp.IconButton()
        Me.ProductLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductLocationInputDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductLocationNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationApprovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        OfficeBuilding_IDLabel = New System.Windows.Forms.Label()
        PhysicalLocation_NameLabel = New System.Windows.Forms.Label()
        PhysicalLocation_DescriptionLabel = New System.Windows.Forms.Label()
        PhysicalLocation_TypeLabel = New System.Windows.Forms.Label()
        PhysicalLocation_ReviewDateLabel = New System.Windows.Forms.Label()
        PhysicalLocation_CreateDateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOffice_PhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOffice_PhysicalLocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlkpOffice_PhysicalLocationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OfficeBuilding_IDLabel
        '
        OfficeBuilding_IDLabel.AutoSize = True
        OfficeBuilding_IDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OfficeBuilding_IDLabel.Location = New System.Drawing.Point(13, 143)
        OfficeBuilding_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OfficeBuilding_IDLabel.Name = "OfficeBuilding_IDLabel"
        OfficeBuilding_IDLabel.Size = New System.Drawing.Size(152, 28)
        OfficeBuilding_IDLabel.TabIndex = 3
        OfficeBuilding_IDLabel.Text = "Office Building:"
        '
        'PhysicalLocation_NameLabel
        '
        PhysicalLocation_NameLabel.AutoSize = True
        PhysicalLocation_NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicalLocation_NameLabel.Location = New System.Drawing.Point(13, 189)
        PhysicalLocation_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicalLocation_NameLabel.Name = "PhysicalLocation_NameLabel"
        PhysicalLocation_NameLabel.Size = New System.Drawing.Size(154, 28)
        PhysicalLocation_NameLabel.TabIndex = 5
        PhysicalLocation_NameLabel.Text = "Location Name:"
        '
        'PhysicalLocation_DescriptionLabel
        '
        PhysicalLocation_DescriptionLabel.AutoSize = True
        PhysicalLocation_DescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicalLocation_DescriptionLabel.Location = New System.Drawing.Point(45, 233)
        PhysicalLocation_DescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicalLocation_DescriptionLabel.Name = "PhysicalLocation_DescriptionLabel"
        PhysicalLocation_DescriptionLabel.Size = New System.Drawing.Size(120, 28)
        PhysicalLocation_DescriptionLabel.TabIndex = 7
        PhysicalLocation_DescriptionLabel.Text = "Description:"
        '
        'PhysicalLocation_TypeLabel
        '
        PhysicalLocation_TypeLabel.AutoSize = True
        PhysicalLocation_TypeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicalLocation_TypeLabel.Location = New System.Drawing.Point(105, 292)
        PhysicalLocation_TypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicalLocation_TypeLabel.Name = "PhysicalLocation_TypeLabel"
        PhysicalLocation_TypeLabel.Size = New System.Drawing.Size(60, 28)
        PhysicalLocation_TypeLabel.TabIndex = 9
        PhysicalLocation_TypeLabel.Text = "Type:"
        '
        'PhysicalLocation_ReviewDateLabel
        '
        PhysicalLocation_ReviewDateLabel.AutoSize = True
        PhysicalLocation_ReviewDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicalLocation_ReviewDateLabel.Location = New System.Drawing.Point(37, 336)
        PhysicalLocation_ReviewDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicalLocation_ReviewDateLabel.Name = "PhysicalLocation_ReviewDateLabel"
        PhysicalLocation_ReviewDateLabel.Size = New System.Drawing.Size(128, 28)
        PhysicalLocation_ReviewDateLabel.TabIndex = 11
        PhysicalLocation_ReviewDateLabel.Text = "Review Date:"
        '
        'PhysicalLocation_CreateDateLabel
        '
        PhysicalLocation_CreateDateLabel.AutoSize = True
        PhysicalLocation_CreateDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicalLocation_CreateDateLabel.Location = New System.Drawing.Point(37, 380)
        PhysicalLocation_CreateDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhysicalLocation_CreateDateLabel.Name = "PhysicalLocation_CreateDateLabel"
        PhysicalLocation_CreateDateLabel.Size = New System.Drawing.Size(123, 28)
        PhysicalLocation_CreateDateLabel.TabIndex = 13
        PhysicalLocation_CreateDateLabel.Text = "Create Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(85, 55)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 28)
        Label1.TabIndex = 15
        Label1.Text = "Region:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(94, 99)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 28)
        Label2.TabIndex = 17
        Label2.Text = "Office:"
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TlkpOffice_PhysicalLocationBindingSource
        '
        Me.TlkpOffice_PhysicalLocationBindingSource.DataMember = "tlkpOffice_PhysicalLocation"
        Me.TlkpOffice_PhysicalLocationBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'TlkpOffice_PhysicalLocationTableAdapter
        '
        Me.TlkpOffice_PhysicalLocationTableAdapter.ClearBeforeFill = True
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
        'TlkpOffice_BuildingTableAdapter
        '
        Me.TlkpOffice_BuildingTableAdapter.ClearBeforeFill = True
        '
        'txtPhysicalLocation_ID
        '
        Me.txtPhysicalLocation_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhysicalLocation_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_ID", True))
        Me.txtPhysicalLocation_ID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicalLocation_ID.Location = New System.Drawing.Point(660, 55)
        Me.txtPhysicalLocation_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhysicalLocation_ID.Name = "txtPhysicalLocation_ID"
        Me.txtPhysicalLocation_ID.Size = New System.Drawing.Size(59, 30)
        Me.txtPhysicalLocation_ID.TabIndex = 2
        '
        'OfficeBuilding_IDComboBox
        '
        Me.OfficeBuilding_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OfficeBuilding_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TlkpOfficeBuildingBindingSource, "OfficeBuilding_ID", True))
        Me.OfficeBuilding_IDComboBox.DataSource = Me.TlkpOfficeBuildingBindingSource
        Me.OfficeBuilding_IDComboBox.DisplayMember = "Building_Name"
        Me.OfficeBuilding_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeBuilding_IDComboBox.FormattingEnabled = True
        Me.OfficeBuilding_IDComboBox.Location = New System.Drawing.Point(168, 143)
        Me.OfficeBuilding_IDComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OfficeBuilding_IDComboBox.Name = "OfficeBuilding_IDComboBox"
        Me.OfficeBuilding_IDComboBox.Size = New System.Drawing.Size(551, 36)
        Me.OfficeBuilding_IDComboBox.TabIndex = 4
        Me.OfficeBuilding_IDComboBox.ValueMember = "OfficeBuilding_ID"
        '
        'TlkpOfficeBuildingBindingSource
        '
        Me.TlkpOfficeBuildingBindingSource.DataMember = "tlkpOffice_Building"
        Me.TlkpOfficeBuildingBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'PhysicalLocation_NameTextBox
        '
        Me.PhysicalLocation_NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhysicalLocation_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_Name", True))
        Me.PhysicalLocation_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalLocation_NameTextBox.Location = New System.Drawing.Point(168, 189)
        Me.PhysicalLocation_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhysicalLocation_NameTextBox.Name = "PhysicalLocation_NameTextBox"
        Me.PhysicalLocation_NameTextBox.Size = New System.Drawing.Size(551, 34)
        Me.PhysicalLocation_NameTextBox.TabIndex = 6
        '
        'PhysicalLocation_DescriptionTextBox
        '
        Me.PhysicalLocation_DescriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhysicalLocation_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_Description", True))
        Me.PhysicalLocation_DescriptionTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalLocation_DescriptionTextBox.Location = New System.Drawing.Point(168, 233)
        Me.PhysicalLocation_DescriptionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhysicalLocation_DescriptionTextBox.Multiline = True
        Me.PhysicalLocation_DescriptionTextBox.Name = "PhysicalLocation_DescriptionTextBox"
        Me.PhysicalLocation_DescriptionTextBox.Size = New System.Drawing.Size(551, 50)
        Me.PhysicalLocation_DescriptionTextBox.TabIndex = 8
        '
        'PhysicalLocation_TypeTextBox
        '
        Me.PhysicalLocation_TypeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhysicalLocation_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_Type", True))
        Me.PhysicalLocation_TypeTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalLocation_TypeTextBox.Location = New System.Drawing.Point(168, 293)
        Me.PhysicalLocation_TypeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhysicalLocation_TypeTextBox.Name = "PhysicalLocation_TypeTextBox"
        Me.PhysicalLocation_TypeTextBox.Size = New System.Drawing.Size(551, 34)
        Me.PhysicalLocation_TypeTextBox.TabIndex = 10
        '
        'PhysicalLocation_ReviewDateDateTimePicker
        '
        Me.PhysicalLocation_ReviewDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhysicalLocation_ReviewDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_ReviewDate", True))
        Me.PhysicalLocation_ReviewDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalLocation_ReviewDateDateTimePicker.Location = New System.Drawing.Point(168, 337)
        Me.PhysicalLocation_ReviewDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhysicalLocation_ReviewDateDateTimePicker.Name = "PhysicalLocation_ReviewDateDateTimePicker"
        Me.PhysicalLocation_ReviewDateDateTimePicker.Size = New System.Drawing.Size(551, 34)
        Me.PhysicalLocation_ReviewDateDateTimePicker.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_Name", True))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(168, 99)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(551, 34)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_Name", True))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(168, 55)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(484, 34)
        Me.TextBox2.TabIndex = 18
        '
        'PhysicalLocation_CreateDateDateTimePicker
        '
        Me.PhysicalLocation_CreateDateDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhysicalLocation_CreateDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TlkpOffice_PhysicalLocationBindingSource, "PhysicalLocation_CreateDate", True))
        Me.PhysicalLocation_CreateDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalLocation_CreateDateDateTimePicker.Location = New System.Drawing.Point(168, 381)
        Me.PhysicalLocation_CreateDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PhysicalLocation_CreateDateDateTimePicker.Name = "PhysicalLocation_CreateDateDateTimePicker"
        Me.PhysicalLocation_CreateDateDateTimePicker.Size = New System.Drawing.Size(551, 34)
        Me.PhysicalLocation_CreateDateDateTimePicker.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductLocationIDDataGridViewTextBoxColumn, Me.PhysicalLocationIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewComboBoxColumn, Me.ProductLocationInputDateDataGridViewTextBoxColumn, Me.ProductLocationActiveDataGridViewCheckBoxColumn, Me.ProductLocationNotesDataGridViewTextBoxColumn, Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn, Me.ProductLocationApprovedDataGridViewTextBoxColumn, Me.ProductLocationApprovedByDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ChemicalLocationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 486)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(703, 106)
        Me.DataGridView1.TabIndex = 19
        '
        'ChemicalProductBindingSource
        '
        Me.ChemicalProductBindingSource.DataMember = "Chemical_Product"
        Me.ChemicalProductBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'ChemicalLocationBindingSource
        '
        Me.ChemicalLocationBindingSource.DataMember = "Chemical_Location"
        Me.ChemicalLocationBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_LocationTableAdapter
        '
        Me.Chemical_LocationTableAdapter.ClearBeforeFill = True
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'lbl_ChemicalDataGridView
        '
        Me.lbl_ChemicalDataGridView.AutoSize = True
        Me.lbl_ChemicalDataGridView.Location = New System.Drawing.Point(22, 451)
        Me.lbl_ChemicalDataGridView.Name = "lbl_ChemicalDataGridView"
        Me.lbl_ChemicalDataGridView.Size = New System.Drawing.Size(348, 28)
        Me.lbl_ChemicalDataGridView.TabIndex = 20
        Me.lbl_ChemicalDataGridView.Text = "Chemical Product(s) stored at Location"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(154, 37)
        Me.ToolStripLabel1.Text = "Physical Location"
        '
        'IconToolStripButton2
        '
        Me.IconToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.IconToolStripButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IconToolStripButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.UndoAlt
        Me.IconToolStripButton2.IconColor = System.Drawing.Color.White
        Me.IconToolStripButton2.IconSize = 16
        Me.IconToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IconToolStripButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.IconToolStripButton2.Name = "IconToolStripButton2"
        Me.IconToolStripButton2.Rotation = 0R
        Me.IconToolStripButton2.Size = New System.Drawing.Size(29, 40)
        Me.IconToolStripButton2.Text = "IconToolStripButton2"
        '
        'btn_Save
        '
        Me.btn_Save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_Save.IconColor = System.Drawing.Color.White
        Me.btn_Save.IconSize = 2550
        Me.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Rotation = 0R
        Me.btn_Save.Size = New System.Drawing.Size(29, 40)
        Me.btn_Save.Text = "IconToolStripButton1"
        '
        'TlkpOffice_PhysicalLocationBindingNavigator
        '
        Me.TlkpOffice_PhysicalLocationBindingNavigator.AddNewItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.AutoSize = False
        Me.TlkpOffice_PhysicalLocationBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TlkpOffice_PhysicalLocationBindingNavigator.BindingSource = Me.TlkpOffice_PhysicalLocationBindingSource
        Me.TlkpOffice_PhysicalLocationBindingNavigator.CountItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.DeleteItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TlkpOffice_PhysicalLocationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_BackToOffice, Me.tStrip_lbl_FullPath, Me.ToolStripLabel1, Me.IconToolStripButton2, Me.btn_Save})
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TlkpOffice_PhysicalLocationBindingNavigator.MoveFirstItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.MoveLastItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.MoveNextItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.MovePreviousItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Name = "TlkpOffice_PhysicalLocationBindingNavigator"
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Padding = New System.Windows.Forms.Padding(0)
        Me.TlkpOffice_PhysicalLocationBindingNavigator.PositionItem = Nothing
        Me.TlkpOffice_PhysicalLocationBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Size = New System.Drawing.Size(734, 40)
        Me.TlkpOffice_PhysicalLocationBindingNavigator.TabIndex = 0
        Me.TlkpOffice_PhysicalLocationBindingNavigator.Text = "BindingNavigator1"
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
        'tStrip_lbl_FullPath
        '
        Me.tStrip_lbl_FullPath.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_FullPath.Name = "tStrip_lbl_FullPath"
        Me.tStrip_lbl_FullPath.Size = New System.Drawing.Size(251, 37)
        Me.tStrip_lbl_FullPath.Text = "Region < Office < Building <"
        '
        'btn_AddChemicalProduct
        '
        Me.btn_AddChemicalProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AddChemicalProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_AddChemicalProduct.FlatAppearance.BorderSize = 0
        Me.btn_AddChemicalProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddChemicalProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_AddChemicalProduct.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddChemicalProduct.ForeColor = System.Drawing.Color.White
        Me.btn_AddChemicalProduct.IconChar = FontAwesome.Sharp.IconChar.Burn
        Me.btn_AddChemicalProduct.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_AddChemicalProduct.IconSize = 30
        Me.btn_AddChemicalProduct.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_AddChemicalProduct.Location = New System.Drawing.Point(565, 443)
        Me.btn_AddChemicalProduct.Name = "btn_AddChemicalProduct"
        Me.btn_AddChemicalProduct.Rotation = 0R
        Me.btn_AddChemicalProduct.Size = New System.Drawing.Size(155, 36)
        Me.btn_AddChemicalProduct.TabIndex = 21
        Me.btn_AddChemicalProduct.Text = "Add Product"
        Me.btn_AddChemicalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AddChemicalProduct.UseVisualStyleBackColor = False
        '
        'ProductLocationIDDataGridViewTextBoxColumn
        '
        Me.ProductLocationIDDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_ID"
        Me.ProductLocationIDDataGridViewTextBoxColumn.HeaderText = "ProductLocation_ID"
        Me.ProductLocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationIDDataGridViewTextBoxColumn.Name = "ProductLocationIDDataGridViewTextBoxColumn"
        Me.ProductLocationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductLocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'PhysicalLocationIDDataGridViewTextBoxColumn
        '
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.DataPropertyName = "PhysicalLocation_ID"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.HeaderText = "PhysicalLocation_ID"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.Name = "PhysicalLocationIDDataGridViewTextBoxColumn"
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.Visible = False
        Me.PhysicalLocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductIDDataGridViewComboBoxColumn
        '
        Me.ProductIDDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewComboBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewComboBoxColumn.DataSource = Me.ChemicalProductBindingSource
        Me.ProductIDDataGridViewComboBoxColumn.DisplayMember = "Product_Name"
        Me.ProductIDDataGridViewComboBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.ProductIDDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductIDDataGridViewComboBoxColumn.HeaderText = "Product Name"
        Me.ProductIDDataGridViewComboBoxColumn.MaxDropDownItems = 1
        Me.ProductIDDataGridViewComboBoxColumn.MinimumWidth = 125
        Me.ProductIDDataGridViewComboBoxColumn.Name = "ProductIDDataGridViewComboBoxColumn"
        Me.ProductIDDataGridViewComboBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductIDDataGridViewComboBoxColumn.ValueMember = "Product_ID"
        '
        'ProductLocationInputDateDataGridViewTextBoxColumn
        '
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_InputDate"
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.HeaderText = "Input"
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.Name = "ProductLocationInputDateDataGridViewTextBoxColumn"
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationInputDateDataGridViewTextBoxColumn.Width = 125
        '
        'ProductLocationActiveDataGridViewCheckBoxColumn
        '
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.DataPropertyName = "ProductLocation_Active"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.HeaderText = "Active?"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.Name = "ProductLocationActiveDataGridViewCheckBoxColumn"
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProductLocationActiveDataGridViewCheckBoxColumn.Width = 81
        '
        'ProductLocationNotesDataGridViewTextBoxColumn
        '
        Me.ProductLocationNotesDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_Notes"
        Me.ProductLocationNotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.ProductLocationNotesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationNotesDataGridViewTextBoxColumn.Name = "ProductLocationNotesDataGridViewTextBoxColumn"
        Me.ProductLocationNotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationNotesDataGridViewTextBoxColumn.Visible = False
        Me.ProductLocationNotesDataGridViewTextBoxColumn.Width = 125
        '
        'ProductLocationVerifiedDateDataGridViewTextBoxColumn
        '
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_VerifiedDate"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.HeaderText = "Verified"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.Name = "ProductLocationVerifiedDateDataGridViewTextBoxColumn"
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationVerifiedDateDataGridViewTextBoxColumn.Width = 125
        '
        'ProductLocationApprovedDataGridViewTextBoxColumn
        '
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_Approved"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.HeaderText = "Approved"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.Name = "ProductLocationApprovedDataGridViewTextBoxColumn"
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationApprovedDataGridViewTextBoxColumn.Width = 129
        '
        'ProductLocationApprovedByDataGridViewTextBoxColumn
        '
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.DataPropertyName = "ProductLocation_ApprovedBy"
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.HeaderText = "Approved By"
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.Name = "ProductLocationApprovedByDataGridViewTextBoxColumn"
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.Visible = False
        Me.ProductLocationApprovedByDataGridViewTextBoxColumn.Width = 125
        '
        'frmOffice_PhysicalLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(734, 605)
        Me.Controls.Add(Me.btn_AddChemicalProduct)
        Me.Controls.Add(Me.lbl_ChemicalDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtPhysicalLocation_ID)
        Me.Controls.Add(OfficeBuilding_IDLabel)
        Me.Controls.Add(Me.OfficeBuilding_IDComboBox)
        Me.Controls.Add(PhysicalLocation_NameLabel)
        Me.Controls.Add(Me.PhysicalLocation_NameTextBox)
        Me.Controls.Add(PhysicalLocation_DescriptionLabel)
        Me.Controls.Add(Me.PhysicalLocation_DescriptionTextBox)
        Me.Controls.Add(PhysicalLocation_TypeLabel)
        Me.Controls.Add(Me.PhysicalLocation_TypeTextBox)
        Me.Controls.Add(PhysicalLocation_ReviewDateLabel)
        Me.Controls.Add(Me.PhysicalLocation_ReviewDateDateTimePicker)
        Me.Controls.Add(PhysicalLocation_CreateDateLabel)
        Me.Controls.Add(Me.PhysicalLocation_CreateDateDateTimePicker)
        Me.Controls.Add(Me.TlkpOffice_PhysicalLocationBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmOffice_PhysicalLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physical Location"
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOffice_PhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOffice_PhysicalLocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlkpOffice_PhysicalLocationBindingNavigator.ResumeLayout(False)
        Me.TlkpOffice_PhysicalLocationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents TlkpOffice_PhysicalLocationBindingSource As BindingSource
    Friend WithEvents TlkpOffice_PhysicalLocationTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents TlkpOffice_BuildingTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOffice_BuildingTableAdapter
    Friend WithEvents txtPhysicalLocation_ID As TextBox
    Friend WithEvents OfficeBuilding_IDComboBox As ComboBox
    Friend WithEvents PhysicalLocation_NameTextBox As TextBox
    Friend WithEvents PhysicalLocation_DescriptionTextBox As TextBox
    Friend WithEvents PhysicalLocation_TypeTextBox As TextBox
    Friend WithEvents PhysicalLocation_ReviewDateDateTimePicker As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TlkpOfficeBuildingBindingSource As BindingSource
    Friend WithEvents PhysicalLocation_CreateDateDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ChemicalLocationBindingSource As BindingSource
    Friend WithEvents Chemical_LocationTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_LocationTableAdapter
    Friend WithEvents ChemicalProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents lbl_ChemicalDataGridView As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents IconToolStripButton2 As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Save As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents TlkpOffice_PhysicalLocationBindingNavigator As BindingNavigator
    Friend WithEvents btn_AddChemicalProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_BackToOffice As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_FullPath As ToolStripLabel
    Friend WithEvents ProductLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewComboBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ProductLocationInputDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProductLocationNotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationVerifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationApprovedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductLocationApprovedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
