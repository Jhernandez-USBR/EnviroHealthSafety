<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ChemicalProduct_SDS
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
        Dim SDS_VersionLabel As System.Windows.Forms.Label
        Dim SDS_DescriptionLabel As System.Windows.Forms.Label
        Dim SDS_ProductCodeLabel As System.Windows.Forms.Label
        Dim SDS_NumberLabel As System.Windows.Forms.Label
        Dim SDS_LinkLabel As System.Windows.Forms.Label
        Dim SDS_EmergencyOverviewLabel As System.Windows.Forms.Label
        Dim SDS_ActiveLabel As System.Windows.Forms.Label
        Dim SDS_NotesLabel As System.Windows.Forms.Label
        Dim SDS_EmergencyPhoneLabel As System.Windows.Forms.Label
        Dim SDS_FirstAidLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChemicalProduct_SDS))
        Me.SDSTableAdapter = New EnviroHealthSafety_DataTableAdapters.SDSTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.SDS_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SDSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.SDS_VersionTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_LinkTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_EmergencyOverviewTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SDS_NotesTextBox = New System.Windows.Forms.TextBox()
        Me.FillByFilterProductIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btn_SDSLink = New FontAwesome.Sharp.IconButton()
        Me.Product_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.ChemicalProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter()
        Me.SDS_EmergencyPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.SDS_FirstAidTextBox = New System.Windows.Forms.TextBox()
        SDS_VersionLabel = New System.Windows.Forms.Label()
        SDS_DescriptionLabel = New System.Windows.Forms.Label()
        SDS_ProductCodeLabel = New System.Windows.Forms.Label()
        SDS_NumberLabel = New System.Windows.Forms.Label()
        SDS_LinkLabel = New System.Windows.Forms.Label()
        SDS_EmergencyOverviewLabel = New System.Windows.Forms.Label()
        SDS_ActiveLabel = New System.Windows.Forms.Label()
        SDS_NotesLabel = New System.Windows.Forms.Label()
        SDS_EmergencyPhoneLabel = New System.Windows.Forms.Label()
        SDS_FirstAidLabel = New System.Windows.Forms.Label()
        CType(Me.SDSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByFilterProductIDToolStrip.SuspendLayout()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SDS_VersionLabel
        '
        SDS_VersionLabel.AutoSize = True
        SDS_VersionLabel.Location = New System.Drawing.Point(120, 102)
        SDS_VersionLabel.Name = "SDS_VersionLabel"
        SDS_VersionLabel.Size = New System.Drawing.Size(121, 28)
        SDS_VersionLabel.TabIndex = 4
        SDS_VersionLabel.Text = "SDS Version:"
        '
        'SDS_DescriptionLabel
        '
        SDS_DescriptionLabel.AutoSize = True
        SDS_DescriptionLabel.Location = New System.Drawing.Point(84, 142)
        SDS_DescriptionLabel.Name = "SDS_DescriptionLabel"
        SDS_DescriptionLabel.Size = New System.Drawing.Size(157, 28)
        SDS_DescriptionLabel.TabIndex = 6
        SDS_DescriptionLabel.Text = "SDS Description:"
        '
        'SDS_ProductCodeLabel
        '
        SDS_ProductCodeLabel.AutoSize = True
        SDS_ProductCodeLabel.Location = New System.Drawing.Point(64, 223)
        SDS_ProductCodeLabel.Name = "SDS_ProductCodeLabel"
        SDS_ProductCodeLabel.Size = New System.Drawing.Size(177, 28)
        SDS_ProductCodeLabel.TabIndex = 8
        SDS_ProductCodeLabel.Text = "SDS Product Code:"
        '
        'SDS_NumberLabel
        '
        SDS_NumberLabel.AutoSize = True
        SDS_NumberLabel.Location = New System.Drawing.Point(112, 263)
        SDS_NumberLabel.Name = "SDS_NumberLabel"
        SDS_NumberLabel.Size = New System.Drawing.Size(129, 28)
        SDS_NumberLabel.TabIndex = 10
        SDS_NumberLabel.Text = "SDS Number:"
        '
        'SDS_LinkLabel
        '
        SDS_LinkLabel.AutoSize = True
        SDS_LinkLabel.Location = New System.Drawing.Point(114, 303)
        SDS_LinkLabel.Name = "SDS_LinkLabel"
        SDS_LinkLabel.Size = New System.Drawing.Size(127, 28)
        SDS_LinkLabel.TabIndex = 12
        SDS_LinkLabel.Text = "SDS Website:"
        '
        'SDS_EmergencyOverviewLabel
        '
        SDS_EmergencyOverviewLabel.AutoSize = True
        SDS_EmergencyOverviewLabel.Location = New System.Drawing.Point(21, 343)
        SDS_EmergencyOverviewLabel.Name = "SDS_EmergencyOverviewLabel"
        SDS_EmergencyOverviewLabel.Size = New System.Drawing.Size(220, 28)
        SDS_EmergencyOverviewLabel.TabIndex = 14
        SDS_EmergencyOverviewLabel.Text = "Emergency Information:"
        '
        'SDS_ActiveLabel
        '
        SDS_ActiveLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SDS_ActiveLabel.AutoSize = True
        SDS_ActiveLabel.Location = New System.Drawing.Point(489, 62)
        SDS_ActiveLabel.Name = "SDS_ActiveLabel"
        SDS_ActiveLabel.Size = New System.Drawing.Size(111, 28)
        SDS_ActiveLabel.TabIndex = 16
        SDS_ActiveLabel.Text = "SDS Active:"
        '
        'SDS_NotesLabel
        '
        SDS_NotesLabel.AutoSize = True
        SDS_NotesLabel.Location = New System.Drawing.Point(125, 491)
        SDS_NotesLabel.Name = "SDS_NotesLabel"
        SDS_NotesLabel.Size = New System.Drawing.Size(109, 28)
        SDS_NotesLabel.TabIndex = 18
        SDS_NotesLabel.Text = "SDS Notes:"
        '
        'SDS_EmergencyPhoneLabel
        '
        SDS_EmergencyPhoneLabel.AutoSize = True
        SDS_EmergencyPhoneLabel.Location = New System.Drawing.Point(21, 62)
        SDS_EmergencyPhoneLabel.Name = "SDS_EmergencyPhoneLabel"
        SDS_EmergencyPhoneLabel.Size = New System.Drawing.Size(213, 28)
        SDS_EmergencyPhoneLabel.TabIndex = 25
        SDS_EmergencyPhoneLabel.Text = "SDS Emergency Phone:"
        '
        'SDS_FirstAidLabel
        '
        SDS_FirstAidLabel.AutoSize = True
        SDS_FirstAidLabel.Location = New System.Drawing.Point(112, 424)
        SDS_FirstAidLabel.Name = "SDS_FirstAidLabel"
        SDS_FirstAidLabel.Size = New System.Drawing.Size(129, 28)
        SDS_FirstAidLabel.TabIndex = 26
        SDS_FirstAidLabel.Text = "SDS First Aid:"
        '
        'SDSTableAdapter
        '
        Me.SDSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.LibraryTableAdapter = Nothing
        Me.TableAdapterManager.SDSTableAdapter = Me.SDSTableAdapter
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
        'SDS_IDTextBox
        '
        Me.SDS_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_ID", True))
        Me.SDS_IDTextBox.Enabled = False
        Me.SDS_IDTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SDS_IDTextBox.Name = "SDS_IDTextBox"
        Me.SDS_IDTextBox.Size = New System.Drawing.Size(33, 34)
        Me.SDS_IDTextBox.TabIndex = 1
        '
        'SDSBindingSource1
        '
        Me.SDSBindingSource1.DataMember = "SDS"
        Me.SDSBindingSource1.DataSource = Me.EnviroHealthSafety_Data
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SDS_VersionTextBox
        '
        Me.SDS_VersionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_Version", True))
        Me.SDS_VersionTextBox.Location = New System.Drawing.Point(247, 102)
        Me.SDS_VersionTextBox.Name = "SDS_VersionTextBox"
        Me.SDS_VersionTextBox.Size = New System.Drawing.Size(450, 34)
        Me.SDS_VersionTextBox.TabIndex = 5
        '
        'SDS_DescriptionTextBox
        '
        Me.SDS_DescriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_Description", True))
        Me.SDS_DescriptionTextBox.Location = New System.Drawing.Point(247, 142)
        Me.SDS_DescriptionTextBox.Multiline = True
        Me.SDS_DescriptionTextBox.Name = "SDS_DescriptionTextBox"
        Me.SDS_DescriptionTextBox.Size = New System.Drawing.Size(450, 75)
        Me.SDS_DescriptionTextBox.TabIndex = 7
        '
        'SDS_ProductCodeTextBox
        '
        Me.SDS_ProductCodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_ProductCode", True))
        Me.SDS_ProductCodeTextBox.Location = New System.Drawing.Point(247, 223)
        Me.SDS_ProductCodeTextBox.Name = "SDS_ProductCodeTextBox"
        Me.SDS_ProductCodeTextBox.Size = New System.Drawing.Size(450, 34)
        Me.SDS_ProductCodeTextBox.TabIndex = 9
        '
        'SDS_NumberTextBox
        '
        Me.SDS_NumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_Number", True))
        Me.SDS_NumberTextBox.Location = New System.Drawing.Point(247, 263)
        Me.SDS_NumberTextBox.Name = "SDS_NumberTextBox"
        Me.SDS_NumberTextBox.Size = New System.Drawing.Size(450, 34)
        Me.SDS_NumberTextBox.TabIndex = 11
        '
        'SDS_LinkTextBox
        '
        Me.SDS_LinkTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_LinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_Link", True))
        Me.SDS_LinkTextBox.Location = New System.Drawing.Point(247, 303)
        Me.SDS_LinkTextBox.Name = "SDS_LinkTextBox"
        Me.SDS_LinkTextBox.Size = New System.Drawing.Size(396, 34)
        Me.SDS_LinkTextBox.TabIndex = 13
        '
        'SDS_EmergencyOverviewTextBox
        '
        Me.SDS_EmergencyOverviewTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_EmergencyOverviewTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_EmergencyOverview", True))
        Me.SDS_EmergencyOverviewTextBox.Location = New System.Drawing.Point(247, 343)
        Me.SDS_EmergencyOverviewTextBox.Multiline = True
        Me.SDS_EmergencyOverviewTextBox.Name = "SDS_EmergencyOverviewTextBox"
        Me.SDS_EmergencyOverviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SDS_EmergencyOverviewTextBox.Size = New System.Drawing.Size(450, 75)
        Me.SDS_EmergencyOverviewTextBox.TabIndex = 15
        '
        'SDS_ActiveCheckBox
        '
        Me.SDS_ActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_ActiveCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SDS_ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SDSBindingSource1, "SDS_Active", True))
        Me.SDS_ActiveCheckBox.Location = New System.Drawing.Point(606, 62)
        Me.SDS_ActiveCheckBox.Name = "SDS_ActiveCheckBox"
        Me.SDS_ActiveCheckBox.Size = New System.Drawing.Size(91, 34)
        Me.SDS_ActiveCheckBox.TabIndex = 17
        Me.SDS_ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'SDS_NotesTextBox
        '
        Me.SDS_NotesTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_Notes", True))
        Me.SDS_NotesTextBox.Location = New System.Drawing.Point(247, 491)
        Me.SDS_NotesTextBox.Multiline = True
        Me.SDS_NotesTextBox.Name = "SDS_NotesTextBox"
        Me.SDS_NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SDS_NotesTextBox.Size = New System.Drawing.Size(450, 50)
        Me.SDS_NotesTextBox.TabIndex = 19
        '
        'FillByFilterProductIDToolStrip
        '
        Me.FillByFilterProductIDToolStrip.AutoSize = False
        Me.FillByFilterProductIDToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FillByFilterProductIDToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByFilterProductIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByFilterProductIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.SaveToolStripButton})
        Me.FillByFilterProductIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByFilterProductIDToolStrip.Name = "FillByFilterProductIDToolStrip"
        Me.FillByFilterProductIDToolStrip.Size = New System.Drawing.Size(732, 40)
        Me.FillByFilterProductIDToolStrip.TabIndex = 22
        Me.FillByFilterProductIDToolStrip.Text = "FillByFilterProductIDToolStrip"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(94, 37)
        Me.ToolStripLabel1.Text = "SDS Card:"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(29, 37)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'btn_SDSLink
        '
        Me.btn_SDSLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SDSLink.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_SDSLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SDSLink.FlatAppearance.BorderSize = 0
        Me.btn_SDSLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SDSLink.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_SDSLink.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_SDSLink.IconChar = FontAwesome.Sharp.IconChar.Globe
        Me.btn_SDSLink.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_SDSLink.IconSize = 25
        Me.btn_SDSLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_SDSLink.Location = New System.Drawing.Point(649, 303)
        Me.btn_SDSLink.Name = "btn_SDSLink"
        Me.btn_SDSLink.Rotation = 0R
        Me.btn_SDSLink.Size = New System.Drawing.Size(48, 34)
        Me.btn_SDSLink.TabIndex = 24
        Me.btn_SDSLink.UseVisualStyleBackColor = False
        '
        'Product_IDComboBox
        '
        Me.Product_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SDSBindingSource1, "Product_ID", True))
        Me.Product_IDComboBox.DataSource = Me.ChemicalProductBindingSource
        Me.Product_IDComboBox.DisplayMember = "Product_Name"
        Me.Product_IDComboBox.Enabled = False
        Me.Product_IDComboBox.FormattingEnabled = True
        Me.Product_IDComboBox.Location = New System.Drawing.Point(0, 0)
        Me.Product_IDComboBox.Name = "Product_IDComboBox"
        Me.Product_IDComboBox.Size = New System.Drawing.Size(34, 36)
        Me.Product_IDComboBox.TabIndex = 25
        Me.Product_IDComboBox.ValueMember = "Product_ID"
        '
        'ChemicalProductBindingSource
        '
        Me.ChemicalProductBindingSource.DataMember = "Chemical_Product"
        Me.ChemicalProductBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'SDS_EmergencyPhoneTextBox
        '
        Me.SDS_EmergencyPhoneTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_EmergencyPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_EmergencyPhone", True))
        Me.SDS_EmergencyPhoneTextBox.Location = New System.Drawing.Point(247, 62)
        Me.SDS_EmergencyPhoneTextBox.Name = "SDS_EmergencyPhoneTextBox"
        Me.SDS_EmergencyPhoneTextBox.Size = New System.Drawing.Size(236, 34)
        Me.SDS_EmergencyPhoneTextBox.TabIndex = 26
        '
        'SDS_FirstAidTextBox
        '
        Me.SDS_FirstAidTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SDS_FirstAidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SDSBindingSource1, "SDS_FirstAid", True))
        Me.SDS_FirstAidTextBox.Location = New System.Drawing.Point(247, 424)
        Me.SDS_FirstAidTextBox.Multiline = True
        Me.SDS_FirstAidTextBox.Name = "SDS_FirstAidTextBox"
        Me.SDS_FirstAidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SDS_FirstAidTextBox.Size = New System.Drawing.Size(450, 61)
        Me.SDS_FirstAidTextBox.TabIndex = 27
        '
        'frm_ChemicalProduct_SDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 553)
        Me.Controls.Add(SDS_FirstAidLabel)
        Me.Controls.Add(Me.SDS_FirstAidTextBox)
        Me.Controls.Add(SDS_EmergencyPhoneLabel)
        Me.Controls.Add(Me.SDS_EmergencyPhoneTextBox)
        Me.Controls.Add(Me.btn_SDSLink)
        Me.Controls.Add(Me.FillByFilterProductIDToolStrip)
        Me.Controls.Add(SDS_NotesLabel)
        Me.Controls.Add(Me.SDS_NotesTextBox)
        Me.Controls.Add(SDS_ActiveLabel)
        Me.Controls.Add(Me.SDS_ActiveCheckBox)
        Me.Controls.Add(SDS_EmergencyOverviewLabel)
        Me.Controls.Add(Me.SDS_EmergencyOverviewTextBox)
        Me.Controls.Add(SDS_LinkLabel)
        Me.Controls.Add(Me.SDS_LinkTextBox)
        Me.Controls.Add(SDS_NumberLabel)
        Me.Controls.Add(Me.SDS_NumberTextBox)
        Me.Controls.Add(SDS_ProductCodeLabel)
        Me.Controls.Add(Me.SDS_ProductCodeTextBox)
        Me.Controls.Add(SDS_DescriptionLabel)
        Me.Controls.Add(Me.SDS_DescriptionTextBox)
        Me.Controls.Add(SDS_VersionLabel)
        Me.Controls.Add(Me.SDS_VersionTextBox)
        Me.Controls.Add(Me.SDS_IDTextBox)
        Me.Controls.Add(Me.Product_IDComboBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_ChemicalProduct_SDS"
        Me.Text = "SDS Card"
        CType(Me.SDSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByFilterProductIDToolStrip.ResumeLayout(False)
        Me.FillByFilterProductIDToolStrip.PerformLayout()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SDSTableAdapter As EnviroHealthSafety_DataTableAdapters.SDSTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents SDS_IDTextBox As TextBox
    Friend WithEvents SDS_VersionTextBox As TextBox
    Friend WithEvents SDS_DescriptionTextBox As TextBox
    Friend WithEvents SDS_ProductCodeTextBox As TextBox
    Friend WithEvents SDS_NumberTextBox As TextBox
    Friend WithEvents SDS_LinkTextBox As TextBox
    Friend WithEvents SDS_EmergencyOverviewTextBox As TextBox
    Friend WithEvents SDS_ActiveCheckBox As CheckBox
    Friend WithEvents SDS_NotesTextBox As TextBox
    Friend WithEvents FillByFilterProductIDToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btn_SDSLink As FontAwesome.Sharp.IconButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents Product_IDComboBox As ComboBox
    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents ChemicalProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents SDSBindingSource1 As BindingSource
    Friend WithEvents SDS_EmergencyPhoneTextBox As TextBox
    Friend WithEvents SDS_FirstAidTextBox As TextBox
End Class
