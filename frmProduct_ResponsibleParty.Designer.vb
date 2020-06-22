<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct_ResponsibleParty
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
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim Manufacturer_IDLabel As System.Windows.Forms.Label
        Dim Manufacturer_DescriptionLabel As System.Windows.Forms.Label
        Dim Manufacturer_Address1Label As System.Windows.Forms.Label
        Dim Manufacturer_PhoneLabel As System.Windows.Forms.Label
        Dim Manufacturer_CityLabel As System.Windows.Forms.Label
        Dim Manufacturer_StateLabel As System.Windows.Forms.Label
        Dim Manufacturer_AreaCodeLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.Chemical_ResponsiblePartyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ResponsiblePartyTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ResponsiblePartyTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.Chemical_ManufacturerTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter()
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter()
        Me.ResponsibleParty_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Product_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.ChemicalProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Manufacturer_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.ChemicalManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel_ManufacturerDetails = New System.Windows.Forms.Panel()
        Me.btn_EditManufacturer = New FontAwesome.Sharp.IconButton()
        Me.Manufacturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_CityTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_StateTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_AreaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.btn_NewManufacturer = New FontAwesome.Sharp.IconButton()
        Me.TStrip_ResponsibleParty = New System.Windows.Forms.ToolStrip()
        Me.IconToolStripButton1 = New FontAwesome.Sharp.IconToolStripButton()
        Me.TStrip_lbl_HeaderTitle = New System.Windows.Forms.ToolStripLabel()
        Product_IDLabel = New System.Windows.Forms.Label()
        Manufacturer_IDLabel = New System.Windows.Forms.Label()
        Manufacturer_DescriptionLabel = New System.Windows.Forms.Label()
        Manufacturer_Address1Label = New System.Windows.Forms.Label()
        Manufacturer_PhoneLabel = New System.Windows.Forms.Label()
        Manufacturer_CityLabel = New System.Windows.Forms.Label()
        Manufacturer_StateLabel = New System.Windows.Forms.Label()
        Manufacturer_AreaCodeLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chemical_ResponsiblePartyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ManufacturerDetails.SuspendLayout()
        Me.TStrip_ResponsibleParty.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Location = New System.Drawing.Point(15, 49)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(85, 28)
        Product_IDLabel.TabIndex = 3
        Product_IDLabel.Text = "Product:"
        '
        'Manufacturer_IDLabel
        '
        Manufacturer_IDLabel.AutoSize = True
        Manufacturer_IDLabel.Location = New System.Drawing.Point(15, 119)
        Manufacturer_IDLabel.Name = "Manufacturer_IDLabel"
        Manufacturer_IDLabel.Size = New System.Drawing.Size(133, 28)
        Manufacturer_IDLabel.TabIndex = 5
        Manufacturer_IDLabel.Text = "Manufacturer:"
        '
        'Manufacturer_DescriptionLabel
        '
        Manufacturer_DescriptionLabel.AutoSize = True
        Manufacturer_DescriptionLabel.Location = New System.Drawing.Point(22, 235)
        Manufacturer_DescriptionLabel.Name = "Manufacturer_DescriptionLabel"
        Manufacturer_DescriptionLabel.Size = New System.Drawing.Size(68, 28)
        Manufacturer_DescriptionLabel.TabIndex = 4
        Manufacturer_DescriptionLabel.Text = "Notes:"
        '
        'Manufacturer_Address1Label
        '
        Manufacturer_Address1Label.AutoSize = True
        Manufacturer_Address1Label.Location = New System.Drawing.Point(22, 18)
        Manufacturer_Address1Label.Name = "Manufacturer_Address1Label"
        Manufacturer_Address1Label.Size = New System.Drawing.Size(86, 28)
        Manufacturer_Address1Label.TabIndex = 6
        Manufacturer_Address1Label.Text = "Address:"
        '
        'Manufacturer_PhoneLabel
        '
        Manufacturer_PhoneLabel.AutoSize = True
        Manufacturer_PhoneLabel.Location = New System.Drawing.Point(22, 163)
        Manufacturer_PhoneLabel.Name = "Manufacturer_PhoneLabel"
        Manufacturer_PhoneLabel.Size = New System.Drawing.Size(71, 28)
        Manufacturer_PhoneLabel.TabIndex = 10
        Manufacturer_PhoneLabel.Text = "Phone:"
        '
        'Manufacturer_CityLabel
        '
        Manufacturer_CityLabel.AutoSize = True
        Manufacturer_CityLabel.Location = New System.Drawing.Point(22, 89)
        Manufacturer_CityLabel.Name = "Manufacturer_CityLabel"
        Manufacturer_CityLabel.Size = New System.Drawing.Size(50, 28)
        Manufacturer_CityLabel.TabIndex = 14
        Manufacturer_CityLabel.Text = "City:"
        '
        'Manufacturer_StateLabel
        '
        Manufacturer_StateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Manufacturer_StateLabel.AutoSize = True
        Manufacturer_StateLabel.Location = New System.Drawing.Point(368, 86)
        Manufacturer_StateLabel.Name = "Manufacturer_StateLabel"
        Manufacturer_StateLabel.Size = New System.Drawing.Size(60, 28)
        Manufacturer_StateLabel.TabIndex = 16
        Manufacturer_StateLabel.Text = "State:"
        '
        'Manufacturer_AreaCodeLabel
        '
        Manufacturer_AreaCodeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Manufacturer_AreaCodeLabel.AutoSize = True
        Manufacturer_AreaCodeLabel.Location = New System.Drawing.Point(521, 86)
        Manufacturer_AreaCodeLabel.Name = "Manufacturer_AreaCodeLabel"
        Manufacturer_AreaCodeLabel.Size = New System.Drawing.Size(107, 28)
        Manufacturer_AreaCodeLabel.TabIndex = 18
        Manufacturer_AreaCodeLabel.Text = "Area Code:"
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chemical_ResponsiblePartyBindingSource
        '
        Me.Chemical_ResponsiblePartyBindingSource.DataMember = "Chemical_ResponsibleParty"
        Me.Chemical_ResponsiblePartyBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_ResponsiblePartyTableAdapter
        '
        Me.Chemical_ResponsiblePartyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Me.Chemical_ManufacturerTableAdapter
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Me.Chemical_ProductTableAdapter
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Me.Chemical_ResponsiblePartyTableAdapter
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
        'Chemical_ManufacturerTableAdapter
        '
        Me.Chemical_ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'ResponsibleParty_IDTextBox
        '
        Me.ResponsibleParty_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResponsibleParty_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ResponsiblePartyBindingSource, "ResponsibleParty_ID", True))
        Me.ResponsibleParty_IDTextBox.Location = New System.Drawing.Point(670, 43)
        Me.ResponsibleParty_IDTextBox.Name = "ResponsibleParty_IDTextBox"
        Me.ResponsibleParty_IDTextBox.Size = New System.Drawing.Size(39, 34)
        Me.ResponsibleParty_IDTextBox.TabIndex = 2
        Me.ResponsibleParty_IDTextBox.Visible = False
        '
        'Product_IDComboBox
        '
        Me.Product_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_ResponsiblePartyBindingSource, "Product_ID", True))
        Me.Product_IDComboBox.DataSource = Me.ChemicalProductBindingSource
        Me.Product_IDComboBox.DisplayMember = "Product_Name"
        Me.Product_IDComboBox.FormattingEnabled = True
        Me.Product_IDComboBox.Location = New System.Drawing.Point(20, 80)
        Me.Product_IDComboBox.Name = "Product_IDComboBox"
        Me.Product_IDComboBox.Size = New System.Drawing.Size(689, 36)
        Me.Product_IDComboBox.TabIndex = 4
        Me.Product_IDComboBox.ValueMember = "Product_ID"
        '
        'ChemicalProductBindingSource
        '
        Me.ChemicalProductBindingSource.DataMember = "Chemical_Product"
        Me.ChemicalProductBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Manufacturer_IDComboBox
        '
        Me.Manufacturer_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_ResponsiblePartyBindingSource, "Manufacturer_ID", True))
        Me.Manufacturer_IDComboBox.DataSource = Me.ChemicalManufacturerBindingSource
        Me.Manufacturer_IDComboBox.DisplayMember = "Manufacturer_Name"
        Me.Manufacturer_IDComboBox.FormattingEnabled = True
        Me.Manufacturer_IDComboBox.Location = New System.Drawing.Point(20, 150)
        Me.Manufacturer_IDComboBox.Name = "Manufacturer_IDComboBox"
        Me.Manufacturer_IDComboBox.Size = New System.Drawing.Size(611, 36)
        Me.Manufacturer_IDComboBox.TabIndex = 6
        Me.Manufacturer_IDComboBox.ValueMember = "Manufacturer_ID"
        '
        'ChemicalManufacturerBindingSource
        '
        Me.ChemicalManufacturerBindingSource.DataMember = "Chemical_Manufacturer"
        Me.ChemicalManufacturerBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Panel_ManufacturerDetails
        '
        Me.Panel_ManufacturerDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_ManufacturerDetails.AutoScroll = True
        Me.Panel_ManufacturerDetails.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_ManufacturerDetails.Controls.Add(Me.btn_EditManufacturer)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_IDTextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_DescriptionLabel)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_DescriptionTextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_Address1Label)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_Address1TextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_PhoneLabel)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_PhoneTextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_CityLabel)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_CityTextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_StateLabel)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_StateTextBox)
        Me.Panel_ManufacturerDetails.Controls.Add(Manufacturer_AreaCodeLabel)
        Me.Panel_ManufacturerDetails.Controls.Add(Me.Manufacturer_AreaCodeTextBox)
        Me.Panel_ManufacturerDetails.Enabled = False
        Me.Panel_ManufacturerDetails.Location = New System.Drawing.Point(20, 192)
        Me.Panel_ManufacturerDetails.Name = "Panel_ManufacturerDetails"
        Me.Panel_ManufacturerDetails.Size = New System.Drawing.Size(689, 334)
        Me.Panel_ManufacturerDetails.TabIndex = 7
        Me.Panel_ManufacturerDetails.Visible = False
        '
        'btn_EditManufacturer
        '
        Me.btn_EditManufacturer.AccessibleDescription = "Edit Manufacturer Details"
        Me.btn_EditManufacturer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_EditManufacturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_EditManufacturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_EditManufacturer.FlatAppearance.BorderSize = 0
        Me.btn_EditManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EditManufacturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_EditManufacturer.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_EditManufacturer.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_EditManufacturer.IconSize = 25
        Me.btn_EditManufacturer.Location = New System.Drawing.Point(617, 14)
        Me.btn_EditManufacturer.Name = "btn_EditManufacturer"
        Me.btn_EditManufacturer.Rotation = 0R
        Me.btn_EditManufacturer.Size = New System.Drawing.Size(50, 30)
        Me.btn_EditManufacturer.TabIndex = 10
        Me.btn_EditManufacturer.UseVisualStyleBackColor = False
        '
        'Manufacturer_IDTextBox
        '
        Me.Manufacturer_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_ID", True))
        Me.Manufacturer_IDTextBox.Location = New System.Drawing.Point(114, 12)
        Me.Manufacturer_IDTextBox.Name = "Manufacturer_IDTextBox"
        Me.Manufacturer_IDTextBox.Size = New System.Drawing.Size(35, 34)
        Me.Manufacturer_IDTextBox.TabIndex = 1
        Me.Manufacturer_IDTextBox.Visible = False
        '
        'Manufacturer_DescriptionTextBox
        '
        Me.Manufacturer_DescriptionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_Description", True))
        Me.Manufacturer_DescriptionTextBox.Location = New System.Drawing.Point(27, 266)
        Me.Manufacturer_DescriptionTextBox.Multiline = True
        Me.Manufacturer_DescriptionTextBox.Name = "Manufacturer_DescriptionTextBox"
        Me.Manufacturer_DescriptionTextBox.ReadOnly = True
        Me.Manufacturer_DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Manufacturer_DescriptionTextBox.Size = New System.Drawing.Size(640, 34)
        Me.Manufacturer_DescriptionTextBox.TabIndex = 5
        '
        'Manufacturer_Address1TextBox
        '
        Me.Manufacturer_Address1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_Address1", True))
        Me.Manufacturer_Address1TextBox.Location = New System.Drawing.Point(27, 52)
        Me.Manufacturer_Address1TextBox.Name = "Manufacturer_Address1TextBox"
        Me.Manufacturer_Address1TextBox.ReadOnly = True
        Me.Manufacturer_Address1TextBox.Size = New System.Drawing.Size(640, 34)
        Me.Manufacturer_Address1TextBox.TabIndex = 7
        '
        'Manufacturer_PhoneTextBox
        '
        Me.Manufacturer_PhoneTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_Phone", True))
        Me.Manufacturer_PhoneTextBox.Location = New System.Drawing.Point(27, 194)
        Me.Manufacturer_PhoneTextBox.Name = "Manufacturer_PhoneTextBox"
        Me.Manufacturer_PhoneTextBox.ReadOnly = True
        Me.Manufacturer_PhoneTextBox.Size = New System.Drawing.Size(640, 34)
        Me.Manufacturer_PhoneTextBox.TabIndex = 11
        '
        'Manufacturer_CityTextBox
        '
        Me.Manufacturer_CityTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_City", True))
        Me.Manufacturer_CityTextBox.Location = New System.Drawing.Point(27, 122)
        Me.Manufacturer_CityTextBox.Name = "Manufacturer_CityTextBox"
        Me.Manufacturer_CityTextBox.ReadOnly = True
        Me.Manufacturer_CityTextBox.Size = New System.Drawing.Size(339, 34)
        Me.Manufacturer_CityTextBox.TabIndex = 15
        '
        'Manufacturer_StateTextBox
        '
        Me.Manufacturer_StateTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_State", True))
        Me.Manufacturer_StateTextBox.Location = New System.Drawing.Point(373, 122)
        Me.Manufacturer_StateTextBox.Name = "Manufacturer_StateTextBox"
        Me.Manufacturer_StateTextBox.ReadOnly = True
        Me.Manufacturer_StateTextBox.Size = New System.Drawing.Size(143, 34)
        Me.Manufacturer_StateTextBox.TabIndex = 17
        '
        'Manufacturer_AreaCodeTextBox
        '
        Me.Manufacturer_AreaCodeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_AreaCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalManufacturerBindingSource, "Manufacturer_AreaCode", True))
        Me.Manufacturer_AreaCodeTextBox.Location = New System.Drawing.Point(526, 122)
        Me.Manufacturer_AreaCodeTextBox.Name = "Manufacturer_AreaCodeTextBox"
        Me.Manufacturer_AreaCodeTextBox.ReadOnly = True
        Me.Manufacturer_AreaCodeTextBox.Size = New System.Drawing.Size(141, 34)
        Me.Manufacturer_AreaCodeTextBox.TabIndex = 19
        '
        'btn_NewManufacturer
        '
        Me.btn_NewManufacturer.AccessibleDescription = "New Manufacturer"
        Me.btn_NewManufacturer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_NewManufacturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_NewManufacturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_NewManufacturer.FlatAppearance.BorderSize = 0
        Me.btn_NewManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewManufacturer.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_NewManufacturer.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.btn_NewManufacturer.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_NewManufacturer.IconSize = 35
        Me.btn_NewManufacturer.Location = New System.Drawing.Point(637, 148)
        Me.btn_NewManufacturer.Name = "btn_NewManufacturer"
        Me.btn_NewManufacturer.Rotation = 0R
        Me.btn_NewManufacturer.Size = New System.Drawing.Size(72, 38)
        Me.btn_NewManufacturer.TabIndex = 8
        Me.btn_NewManufacturer.UseVisualStyleBackColor = False
        '
        'TStrip_ResponsibleParty
        '
        Me.TStrip_ResponsibleParty.AutoSize = False
        Me.TStrip_ResponsibleParty.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.TStrip_ResponsibleParty.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip_ResponsibleParty.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStrip_ResponsibleParty.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TStrip_ResponsibleParty.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IconToolStripButton1, Me.TStrip_lbl_HeaderTitle})
        Me.TStrip_ResponsibleParty.Location = New System.Drawing.Point(0, 0)
        Me.TStrip_ResponsibleParty.Name = "TStrip_ResponsibleParty"
        Me.TStrip_ResponsibleParty.Size = New System.Drawing.Size(732, 40)
        Me.TStrip_ResponsibleParty.TabIndex = 9
        Me.TStrip_ResponsibleParty.Text = "Responsible Party ToolStrip"
        '
        'IconToolStripButton1
        '
        Me.IconToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.IconToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IconToolStripButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.IconToolStripButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconToolStripButton1.IconSize = 25
        Me.IconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IconToolStripButton1.Name = "IconToolStripButton1"
        Me.IconToolStripButton1.Rotation = 0R
        Me.IconToolStripButton1.Size = New System.Drawing.Size(29, 37)
        Me.IconToolStripButton1.Text = "IconToolStripButton1"
        '
        'TStrip_lbl_HeaderTitle
        '
        Me.TStrip_lbl_HeaderTitle.ForeColor = System.Drawing.Color.White
        Me.TStrip_lbl_HeaderTitle.Name = "TStrip_lbl_HeaderTitle"
        Me.TStrip_lbl_HeaderTitle.Size = New System.Drawing.Size(132, 37)
        Me.TStrip_lbl_HeaderTitle.Text = "Manufacturer:"
        '
        'frmProduct_ResponsibleParty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 553)
        Me.Controls.Add(Me.TStrip_ResponsibleParty)
        Me.Controls.Add(Me.btn_NewManufacturer)
        Me.Controls.Add(Me.Panel_ManufacturerDetails)
        Me.Controls.Add(Me.ResponsibleParty_IDTextBox)
        Me.Controls.Add(Product_IDLabel)
        Me.Controls.Add(Me.Product_IDComboBox)
        Me.Controls.Add(Manufacturer_IDLabel)
        Me.Controls.Add(Me.Manufacturer_IDComboBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frmProduct_ResponsibleParty"
        Me.Text = "Product Responsible Party "
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chemical_ResponsiblePartyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ManufacturerDetails.ResumeLayout(False)
        Me.Panel_ManufacturerDetails.PerformLayout()
        Me.TStrip_ResponsibleParty.ResumeLayout(False)
        Me.TStrip_ResponsibleParty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents Chemical_ResponsiblePartyBindingSource As BindingSource
    Friend WithEvents Chemical_ResponsiblePartyTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ResponsiblePartyTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents ResponsibleParty_IDTextBox As TextBox
    Friend WithEvents Product_IDComboBox As ComboBox
    Friend WithEvents Manufacturer_IDComboBox As ComboBox
    Friend WithEvents ChemicalProductBindingSource As BindingSource
    Friend WithEvents Chemical_ManufacturerTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter
    Friend WithEvents ChemicalManufacturerBindingSource As BindingSource
    Friend WithEvents Panel_ManufacturerDetails As Panel
    Friend WithEvents Manufacturer_IDTextBox As TextBox
    Friend WithEvents Manufacturer_DescriptionTextBox As TextBox
    Friend WithEvents Manufacturer_Address1TextBox As TextBox
    Friend WithEvents Manufacturer_PhoneTextBox As TextBox
    Friend WithEvents Manufacturer_CityTextBox As TextBox
    Friend WithEvents Manufacturer_StateTextBox As TextBox
    Friend WithEvents Manufacturer_AreaCodeTextBox As TextBox
    Friend WithEvents btn_NewManufacturer As FontAwesome.Sharp.IconButton
    Friend WithEvents TStrip_ResponsibleParty As ToolStrip
    Friend WithEvents IconToolStripButton1 As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents TStrip_lbl_HeaderTitle As ToolStripLabel
    Friend WithEvents btn_EditManufacturer As FontAwesome.Sharp.IconButton
End Class
