<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct_Manufacturer
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
        Dim Manufacturer_NameLabel As System.Windows.Forms.Label
        Dim Manufacturer_DescriptionLabel As System.Windows.Forms.Label
        Dim Manufacturer_Address1Label As System.Windows.Forms.Label
        Dim Manufacturer_Address2Label As System.Windows.Forms.Label
        Dim Manufacturer_PhoneLabel As System.Windows.Forms.Label
        Dim Manufacturer_WebsiteLabel As System.Windows.Forms.Label
        Dim Manufacturer_CityLabel As System.Windows.Forms.Label
        Dim Manufacturer_StateLabel As System.Windows.Forms.Label
        Dim Manufacturer_AreaCodeLabel As System.Windows.Forms.Label
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.Chemical_ManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ManufacturerTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.Manufacturer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_Address2TextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_CityTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_StateTextBox = New System.Windows.Forms.TextBox()
        Me.Manufacturer_AreaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TStrip_Manufacturer = New System.Windows.Forms.ToolStrip()
        Me.btn_Close = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Save = New FontAwesome.Sharp.IconToolStripButton()
        Me.btn_Undo = New FontAwesome.Sharp.IconToolStripButton()
        Me.TStrip_lbl_HeaderText = New System.Windows.Forms.ToolStripLabel()
        Manufacturer_NameLabel = New System.Windows.Forms.Label()
        Manufacturer_DescriptionLabel = New System.Windows.Forms.Label()
        Manufacturer_Address1Label = New System.Windows.Forms.Label()
        Manufacturer_Address2Label = New System.Windows.Forms.Label()
        Manufacturer_PhoneLabel = New System.Windows.Forms.Label()
        Manufacturer_WebsiteLabel = New System.Windows.Forms.Label()
        Manufacturer_CityLabel = New System.Windows.Forms.Label()
        Manufacturer_StateLabel = New System.Windows.Forms.Label()
        Manufacturer_AreaCodeLabel = New System.Windows.Forms.Label()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chemical_ManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TStrip_Manufacturer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Manufacturer_NameLabel
        '
        Manufacturer_NameLabel.AutoSize = True
        Manufacturer_NameLabel.Location = New System.Drawing.Point(13, 61)
        Manufacturer_NameLabel.Name = "Manufacturer_NameLabel"
        Manufacturer_NameLabel.Size = New System.Drawing.Size(133, 28)
        Manufacturer_NameLabel.TabIndex = 3
        Manufacturer_NameLabel.Text = "Manufacturer:"
        '
        'Manufacturer_DescriptionLabel
        '
        Manufacturer_DescriptionLabel.AutoSize = True
        Manufacturer_DescriptionLabel.Location = New System.Drawing.Point(78, 387)
        Manufacturer_DescriptionLabel.Name = "Manufacturer_DescriptionLabel"
        Manufacturer_DescriptionLabel.Size = New System.Drawing.Size(68, 28)
        Manufacturer_DescriptionLabel.TabIndex = 5
        Manufacturer_DescriptionLabel.Text = "Notes:"
        '
        'Manufacturer_Address1Label
        '
        Manufacturer_Address1Label.AutoSize = True
        Manufacturer_Address1Label.Location = New System.Drawing.Point(44, 101)
        Manufacturer_Address1Label.Name = "Manufacturer_Address1Label"
        Manufacturer_Address1Label.Size = New System.Drawing.Size(102, 28)
        Manufacturer_Address1Label.TabIndex = 7
        Manufacturer_Address1Label.Text = "Address 1:"
        '
        'Manufacturer_Address2Label
        '
        Manufacturer_Address2Label.AutoSize = True
        Manufacturer_Address2Label.Location = New System.Drawing.Point(44, 141)
        Manufacturer_Address2Label.Name = "Manufacturer_Address2Label"
        Manufacturer_Address2Label.Size = New System.Drawing.Size(102, 28)
        Manufacturer_Address2Label.TabIndex = 9
        Manufacturer_Address2Label.Text = "Address 2:"
        '
        'Manufacturer_PhoneLabel
        '
        Manufacturer_PhoneLabel.AutoSize = True
        Manufacturer_PhoneLabel.Location = New System.Drawing.Point(75, 305)
        Manufacturer_PhoneLabel.Name = "Manufacturer_PhoneLabel"
        Manufacturer_PhoneLabel.Size = New System.Drawing.Size(71, 28)
        Manufacturer_PhoneLabel.TabIndex = 11
        Manufacturer_PhoneLabel.Text = "Phone:"
        '
        'Manufacturer_WebsiteLabel
        '
        Manufacturer_WebsiteLabel.AutoSize = True
        Manufacturer_WebsiteLabel.Location = New System.Drawing.Point(60, 345)
        Manufacturer_WebsiteLabel.Name = "Manufacturer_WebsiteLabel"
        Manufacturer_WebsiteLabel.Size = New System.Drawing.Size(86, 28)
        Manufacturer_WebsiteLabel.TabIndex = 13
        Manufacturer_WebsiteLabel.Text = "Website:"
        '
        'Manufacturer_CityLabel
        '
        Manufacturer_CityLabel.AutoSize = True
        Manufacturer_CityLabel.Location = New System.Drawing.Point(96, 181)
        Manufacturer_CityLabel.Name = "Manufacturer_CityLabel"
        Manufacturer_CityLabel.Size = New System.Drawing.Size(50, 28)
        Manufacturer_CityLabel.TabIndex = 15
        Manufacturer_CityLabel.Text = "City:"
        '
        'Manufacturer_StateLabel
        '
        Manufacturer_StateLabel.AutoSize = True
        Manufacturer_StateLabel.Location = New System.Drawing.Point(86, 221)
        Manufacturer_StateLabel.Name = "Manufacturer_StateLabel"
        Manufacturer_StateLabel.Size = New System.Drawing.Size(60, 28)
        Manufacturer_StateLabel.TabIndex = 17
        Manufacturer_StateLabel.Text = "State:"
        '
        'Manufacturer_AreaCodeLabel
        '
        Manufacturer_AreaCodeLabel.AutoSize = True
        Manufacturer_AreaCodeLabel.Location = New System.Drawing.Point(39, 261)
        Manufacturer_AreaCodeLabel.Name = "Manufacturer_AreaCodeLabel"
        Manufacturer_AreaCodeLabel.Size = New System.Drawing.Size(107, 28)
        Manufacturer_AreaCodeLabel.TabIndex = 19
        Manufacturer_AreaCodeLabel.Text = "Area Code:"
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chemical_ManufacturerBindingSource
        '
        Me.Chemical_ManufacturerBindingSource.DataMember = "Chemical_Manufacturer"
        Me.Chemical_ManufacturerBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Chemical_ManufacturerTableAdapter
        '
        Me.Chemical_ManufacturerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Me.Chemical_ManufacturerTableAdapter
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
        'Manufacturer_IDTextBox
        '
        Me.Manufacturer_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_ID", True))
        Me.Manufacturer_IDTextBox.Location = New System.Drawing.Point(664, 61)
        Me.Manufacturer_IDTextBox.Name = "Manufacturer_IDTextBox"
        Me.Manufacturer_IDTextBox.Size = New System.Drawing.Size(50, 34)
        Me.Manufacturer_IDTextBox.TabIndex = 2
        '
        'Manufacturer_NameTextBox
        '
        Me.Manufacturer_NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Name", True))
        Me.Manufacturer_NameTextBox.Location = New System.Drawing.Point(152, 61)
        Me.Manufacturer_NameTextBox.Name = "Manufacturer_NameTextBox"
        Me.Manufacturer_NameTextBox.Size = New System.Drawing.Size(505, 34)
        Me.Manufacturer_NameTextBox.TabIndex = 4
        '
        'Manufacturer_DescriptionTextBox
        '
        Me.Manufacturer_DescriptionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Description", True))
        Me.Manufacturer_DescriptionTextBox.Location = New System.Drawing.Point(152, 387)
        Me.Manufacturer_DescriptionTextBox.Multiline = True
        Me.Manufacturer_DescriptionTextBox.Name = "Manufacturer_DescriptionTextBox"
        Me.Manufacturer_DescriptionTextBox.Size = New System.Drawing.Size(562, 54)
        Me.Manufacturer_DescriptionTextBox.TabIndex = 6
        '
        'Manufacturer_Address1TextBox
        '
        Me.Manufacturer_Address1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Address1", True))
        Me.Manufacturer_Address1TextBox.Location = New System.Drawing.Point(152, 101)
        Me.Manufacturer_Address1TextBox.Name = "Manufacturer_Address1TextBox"
        Me.Manufacturer_Address1TextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_Address1TextBox.TabIndex = 8
        '
        'Manufacturer_Address2TextBox
        '
        Me.Manufacturer_Address2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Address2", True))
        Me.Manufacturer_Address2TextBox.Location = New System.Drawing.Point(152, 141)
        Me.Manufacturer_Address2TextBox.Name = "Manufacturer_Address2TextBox"
        Me.Manufacturer_Address2TextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_Address2TextBox.TabIndex = 10
        '
        'Manufacturer_PhoneTextBox
        '
        Me.Manufacturer_PhoneTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Phone", True))
        Me.Manufacturer_PhoneTextBox.Location = New System.Drawing.Point(152, 305)
        Me.Manufacturer_PhoneTextBox.Name = "Manufacturer_PhoneTextBox"
        Me.Manufacturer_PhoneTextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_PhoneTextBox.TabIndex = 12
        '
        'Manufacturer_WebsiteTextBox
        '
        Me.Manufacturer_WebsiteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_Website", True))
        Me.Manufacturer_WebsiteTextBox.Location = New System.Drawing.Point(152, 345)
        Me.Manufacturer_WebsiteTextBox.Name = "Manufacturer_WebsiteTextBox"
        Me.Manufacturer_WebsiteTextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_WebsiteTextBox.TabIndex = 14
        '
        'Manufacturer_CityTextBox
        '
        Me.Manufacturer_CityTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_City", True))
        Me.Manufacturer_CityTextBox.Location = New System.Drawing.Point(152, 181)
        Me.Manufacturer_CityTextBox.Name = "Manufacturer_CityTextBox"
        Me.Manufacturer_CityTextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_CityTextBox.TabIndex = 16
        '
        'Manufacturer_StateTextBox
        '
        Me.Manufacturer_StateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_State", True))
        Me.Manufacturer_StateTextBox.Location = New System.Drawing.Point(152, 221)
        Me.Manufacturer_StateTextBox.Name = "Manufacturer_StateTextBox"
        Me.Manufacturer_StateTextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_StateTextBox.TabIndex = 18
        '
        'Manufacturer_AreaCodeTextBox
        '
        Me.Manufacturer_AreaCodeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufacturer_AreaCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_ManufacturerBindingSource, "Manufacturer_AreaCode", True))
        Me.Manufacturer_AreaCodeTextBox.Location = New System.Drawing.Point(152, 261)
        Me.Manufacturer_AreaCodeTextBox.Name = "Manufacturer_AreaCodeTextBox"
        Me.Manufacturer_AreaCodeTextBox.Size = New System.Drawing.Size(562, 34)
        Me.Manufacturer_AreaCodeTextBox.TabIndex = 20
        '
        'TStrip_Manufacturer
        '
        Me.TStrip_Manufacturer.AutoSize = False
        Me.TStrip_Manufacturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TStrip_Manufacturer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TStrip_Manufacturer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TStrip_Manufacturer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Close, Me.btn_Save, Me.btn_Undo, Me.TStrip_lbl_HeaderText})
        Me.TStrip_Manufacturer.Location = New System.Drawing.Point(0, 0)
        Me.TStrip_Manufacturer.Name = "TStrip_Manufacturer"
        Me.TStrip_Manufacturer.Size = New System.Drawing.Size(732, 40)
        Me.TStrip_Manufacturer.TabIndex = 21
        Me.TStrip_Manufacturer.Text = "ToolStrip1"
        '
        'btn_Close
        '
        Me.btn_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btn_Close.IconColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_Close.IconSize = 25
        Me.btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Rotation = 0R
        Me.btn_Close.Size = New System.Drawing.Size(29, 37)
        Me.btn_Close.Text = "IconToolStripButton2"
        '
        'btn_Save
        '
        Me.btn_Save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btn_Save.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_Save.IconSize = 25
        Me.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Rotation = 0R
        Me.btn_Save.Size = New System.Drawing.Size(29, 37)
        Me.btn_Save.Text = "IconToolStripButton1"
        '
        'btn_Undo
        '
        Me.btn_Undo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Undo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Undo.IconChar = FontAwesome.Sharp.IconChar.Undo
        Me.btn_Undo.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_Undo.IconSize = 25
        Me.btn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Rotation = 0R
        Me.btn_Undo.Size = New System.Drawing.Size(29, 37)
        Me.btn_Undo.Text = "IconToolStripButton1"
        '
        'TStrip_lbl_HeaderText
        '
        Me.TStrip_lbl_HeaderText.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TStrip_lbl_HeaderText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TStrip_lbl_HeaderText.Margin = New System.Windows.Forms.Padding(5, 1, 0, 2)
        Me.TStrip_lbl_HeaderText.Name = "TStrip_lbl_HeaderText"
        Me.TStrip_lbl_HeaderText.Size = New System.Drawing.Size(134, 37)
        Me.TStrip_lbl_HeaderText.Text = "ToolStripLabel1"
        '
        'frmProduct_Manufacturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.TStrip_Manufacturer)
        Me.Controls.Add(Me.Manufacturer_IDTextBox)
        Me.Controls.Add(Manufacturer_NameLabel)
        Me.Controls.Add(Me.Manufacturer_NameTextBox)
        Me.Controls.Add(Manufacturer_DescriptionLabel)
        Me.Controls.Add(Me.Manufacturer_DescriptionTextBox)
        Me.Controls.Add(Manufacturer_Address1Label)
        Me.Controls.Add(Me.Manufacturer_Address1TextBox)
        Me.Controls.Add(Manufacturer_Address2Label)
        Me.Controls.Add(Me.Manufacturer_Address2TextBox)
        Me.Controls.Add(Manufacturer_PhoneLabel)
        Me.Controls.Add(Me.Manufacturer_PhoneTextBox)
        Me.Controls.Add(Manufacturer_WebsiteLabel)
        Me.Controls.Add(Me.Manufacturer_WebsiteTextBox)
        Me.Controls.Add(Manufacturer_CityLabel)
        Me.Controls.Add(Me.Manufacturer_CityTextBox)
        Me.Controls.Add(Manufacturer_StateLabel)
        Me.Controls.Add(Me.Manufacturer_StateTextBox)
        Me.Controls.Add(Manufacturer_AreaCodeLabel)
        Me.Controls.Add(Me.Manufacturer_AreaCodeTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "frmProduct_Manufacturer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Manufacturer"
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chemical_ManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TStrip_Manufacturer.ResumeLayout(False)
        Me.TStrip_Manufacturer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents Chemical_ManufacturerBindingSource As BindingSource
    Friend WithEvents Chemical_ManufacturerTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ManufacturerTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents Manufacturer_IDTextBox As TextBox
    Friend WithEvents Manufacturer_NameTextBox As TextBox
    Friend WithEvents Manufacturer_DescriptionTextBox As TextBox
    Friend WithEvents Manufacturer_Address1TextBox As TextBox
    Friend WithEvents Manufacturer_Address2TextBox As TextBox
    Friend WithEvents Manufacturer_PhoneTextBox As TextBox
    Friend WithEvents Manufacturer_WebsiteTextBox As TextBox
    Friend WithEvents Manufacturer_CityTextBox As TextBox
    Friend WithEvents Manufacturer_StateTextBox As TextBox
    Friend WithEvents Manufacturer_AreaCodeTextBox As TextBox
    Friend WithEvents TStrip_Manufacturer As ToolStrip
    Friend WithEvents btn_Save As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Close As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents btn_Undo As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents TStrip_lbl_HeaderText As ToolStripLabel
End Class
