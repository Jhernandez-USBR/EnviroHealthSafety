<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChemicalProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ChemicalProduct))
        Me.txt_ProductID = New System.Windows.Forms.TextBox()
        Me.ChemicalProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.txt_ProductName = New System.Windows.Forms.TextBox()
        Me.lbl_ProductName = New System.Windows.Forms.Label()
        Me.lbl_HazardousWaste = New System.Windows.Forms.Label()
        Me.lbl_Approved = New System.Windows.Forms.Label()
        Me.txt_HazardousWaste = New System.Windows.Forms.TextBox()
        Me.txt_Approved = New System.Windows.Forms.TextBox()
        Me.lbl_Approver = New System.Windows.Forms.Label()
        Me.panel_ChemicalProductChild = New System.Windows.Forms.Panel()
        Me.btn_SDSGeneral = New System.Windows.Forms.Button()
        Me.btn_SDSOther = New System.Windows.Forms.Button()
        Me.btn_CurrentLocation = New System.Windows.Forms.Button()
        Me.btn_LibraryCard = New System.Windows.Forms.Button()
        Me.Product_InputEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter()
        Me.tStrip_Office = New System.Windows.Forms.ToolStrip()
        Me.btn_BackSearchProduct = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_FullPath = New System.Windows.Forms.ToolStripLabel()
        Me.btn_EditProductDetails = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_Office = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter()
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_Office.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_ProductID
        '
        Me.txt_ProductID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalProductBindingSource, "Product_ID", True))
        Me.txt_ProductID.Location = New System.Drawing.Point(694, 80)
        Me.txt_ProductID.Name = "txt_ProductID"
        Me.txt_ProductID.Size = New System.Drawing.Size(59, 34)
        Me.txt_ProductID.TabIndex = 0
        '
        'ChemicalProductBindingSource
        '
        Me.ChemicalProductBindingSource.DataMember = "Chemical_Product"
        Me.ChemicalProductBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_ProductName
        '
        Me.txt_ProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalProductBindingSource, "Product_Name", True))
        Me.txt_ProductName.Location = New System.Drawing.Point(134, 80)
        Me.txt_ProductName.Name = "txt_ProductName"
        Me.txt_ProductName.Size = New System.Drawing.Size(554, 34)
        Me.txt_ProductName.TabIndex = 1
        '
        'lbl_ProductName
        '
        Me.lbl_ProductName.AutoSize = True
        Me.lbl_ProductName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductName.Location = New System.Drawing.Point(57, 80)
        Me.lbl_ProductName.Name = "lbl_ProductName"
        Me.lbl_ProductName.Size = New System.Drawing.Size(71, 28)
        Me.lbl_ProductName.TabIndex = 3
        Me.lbl_ProductName.Text = "Name:"
        '
        'lbl_HazardousWaste
        '
        Me.lbl_HazardousWaste.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_HazardousWaste.AutoSize = True
        Me.lbl_HazardousWaste.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HazardousWaste.Location = New System.Drawing.Point(510, 120)
        Me.lbl_HazardousWaste.Name = "lbl_HazardousWaste"
        Me.lbl_HazardousWaste.Size = New System.Drawing.Size(178, 28)
        Me.lbl_HazardousWaste.TabIndex = 7
        Me.lbl_HazardousWaste.Text = "Hazardous Waste?"
        '
        'lbl_Approved
        '
        Me.lbl_Approved.AutoSize = True
        Me.lbl_Approved.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Approved.Location = New System.Drawing.Point(18, 120)
        Me.lbl_Approved.Name = "lbl_Approved"
        Me.lbl_Approved.Size = New System.Drawing.Size(110, 28)
        Me.lbl_Approved.TabIndex = 6
        Me.lbl_Approved.Text = "Approved?"
        '
        'txt_HazardousWaste
        '
        Me.txt_HazardousWaste.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_HazardousWaste.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalProductBindingSource, "Product_HazWaste", True))
        Me.txt_HazardousWaste.Location = New System.Drawing.Point(694, 120)
        Me.txt_HazardousWaste.Name = "txt_HazardousWaste"
        Me.txt_HazardousWaste.Size = New System.Drawing.Size(59, 34)
        Me.txt_HazardousWaste.TabIndex = 5
        '
        'txt_Approved
        '
        Me.txt_Approved.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChemicalProductBindingSource, "Product_Approved", True))
        Me.txt_Approved.Location = New System.Drawing.Point(134, 120)
        Me.txt_Approved.Name = "txt_Approved"
        Me.txt_Approved.Size = New System.Drawing.Size(71, 34)
        Me.txt_Approved.TabIndex = 4
        '
        'lbl_Approver
        '
        Me.lbl_Approver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Approver.AutoSize = True
        Me.lbl_Approver.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Approver.Location = New System.Drawing.Point(211, 120)
        Me.lbl_Approver.Name = "lbl_Approver"
        Me.lbl_Approver.Size = New System.Drawing.Size(102, 28)
        Me.lbl_Approver.TabIndex = 9
        Me.lbl_Approver.Text = "Approver:"
        '
        'panel_ChemicalProductChild
        '
        Me.panel_ChemicalProductChild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_ChemicalProductChild.AutoScroll = True
        Me.panel_ChemicalProductChild.AutoScrollMinSize = New System.Drawing.Size(0, 650)
        Me.panel_ChemicalProductChild.AutoSize = True
        Me.panel_ChemicalProductChild.BackColor = System.Drawing.Color.White
        Me.panel_ChemicalProductChild.Location = New System.Drawing.Point(35, 240)
        Me.panel_ChemicalProductChild.Name = "panel_ChemicalProductChild"
        Me.panel_ChemicalProductChild.Size = New System.Drawing.Size(718, 323)
        Me.panel_ChemicalProductChild.TabIndex = 10
        '
        'btn_SDSGeneral
        '
        Me.btn_SDSGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_SDSGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SDSGeneral.FlatAppearance.BorderSize = 0
        Me.btn_SDSGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SDSGeneral.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SDSGeneral.ForeColor = System.Drawing.Color.White
        Me.btn_SDSGeneral.Location = New System.Drawing.Point(35, 197)
        Me.btn_SDSGeneral.Name = "btn_SDSGeneral"
        Me.btn_SDSGeneral.Size = New System.Drawing.Size(175, 37)
        Me.btn_SDSGeneral.TabIndex = 11
        Me.btn_SDSGeneral.Text = "SDS General"
        Me.btn_SDSGeneral.UseVisualStyleBackColor = False
        '
        'btn_SDSOther
        '
        Me.btn_SDSOther.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_SDSOther.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SDSOther.FlatAppearance.BorderSize = 0
        Me.btn_SDSOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SDSOther.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SDSOther.ForeColor = System.Drawing.Color.White
        Me.btn_SDSOther.Location = New System.Drawing.Point(216, 197)
        Me.btn_SDSOther.Name = "btn_SDSOther"
        Me.btn_SDSOther.Size = New System.Drawing.Size(175, 37)
        Me.btn_SDSOther.TabIndex = 12
        Me.btn_SDSOther.Text = "SDS Other"
        Me.btn_SDSOther.UseVisualStyleBackColor = False
        '
        'btn_CurrentLocation
        '
        Me.btn_CurrentLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_CurrentLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CurrentLocation.FlatAppearance.BorderSize = 0
        Me.btn_CurrentLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CurrentLocation.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CurrentLocation.ForeColor = System.Drawing.Color.White
        Me.btn_CurrentLocation.Location = New System.Drawing.Point(397, 197)
        Me.btn_CurrentLocation.Name = "btn_CurrentLocation"
        Me.btn_CurrentLocation.Size = New System.Drawing.Size(175, 37)
        Me.btn_CurrentLocation.TabIndex = 13
        Me.btn_CurrentLocation.Text = "Current Location"
        Me.btn_CurrentLocation.UseVisualStyleBackColor = False
        '
        'btn_LibraryCard
        '
        Me.btn_LibraryCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_LibraryCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_LibraryCard.FlatAppearance.BorderSize = 0
        Me.btn_LibraryCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LibraryCard.Font = New System.Drawing.Font("Segoe UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LibraryCard.ForeColor = System.Drawing.Color.White
        Me.btn_LibraryCard.Location = New System.Drawing.Point(578, 197)
        Me.btn_LibraryCard.Name = "btn_LibraryCard"
        Me.btn_LibraryCard.Size = New System.Drawing.Size(175, 37)
        Me.btn_LibraryCard.TabIndex = 14
        Me.btn_LibraryCard.Text = "Library Card"
        Me.btn_LibraryCard.UseVisualStyleBackColor = False
        '
        'Product_InputEmployeeComboBox
        '
        Me.Product_InputEmployeeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_InputEmployeeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ChemicalProductBindingSource, "Product_InputEmployee", True))
        Me.Product_InputEmployeeComboBox.DataSource = Me.ZtblEmployeeBindingSource
        Me.Product_InputEmployeeComboBox.DisplayMember = "Employee_FirstLastName"
        Me.Product_InputEmployeeComboBox.FormattingEnabled = True
        Me.Product_InputEmployeeComboBox.Location = New System.Drawing.Point(319, 120)
        Me.Product_InputEmployeeComboBox.Name = "Product_InputEmployeeComboBox"
        Me.Product_InputEmployeeComboBox.Size = New System.Drawing.Size(185, 36)
        Me.Product_InputEmployeeComboBox.TabIndex = 17
        Me.Product_InputEmployeeComboBox.ValueMember = "Employee_ID"
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety
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
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'tStrip_Office
        '
        Me.tStrip_Office.AutoSize = False
        Me.tStrip_Office.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.tStrip_Office.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_Office.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_Office.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_Office.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_BackSearchProduct, Me.tStrip_lbl_FullPath, Me.btn_EditProductDetails, Me.tStrip_lbl_Office, Me.ToolStripLabel2})
        Me.tStrip_Office.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_Office.Name = "tStrip_Office"
        Me.tStrip_Office.Padding = New System.Windows.Forms.Padding(0)
        Me.tStrip_Office.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tStrip_Office.Size = New System.Drawing.Size(792, 40)
        Me.tStrip_Office.TabIndex = 24
        Me.tStrip_Office.Text = "tStrip_Office"
        '
        'btn_BackSearchProduct
        '
        Me.btn_BackSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_BackSearchProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_BackSearchProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_BackSearchProduct.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BackSearchProduct.ForeColor = System.Drawing.Color.White
        Me.btn_BackSearchProduct.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btn_BackSearchProduct.IconColor = System.Drawing.Color.White
        Me.btn_BackSearchProduct.IconSize = 50
        Me.btn_BackSearchProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_BackSearchProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_BackSearchProduct.Name = "btn_BackSearchProduct"
        Me.btn_BackSearchProduct.Rotation = 0R
        Me.btn_BackSearchProduct.Size = New System.Drawing.Size(29, 40)
        Me.btn_BackSearchProduct.Text = "Region"
        Me.btn_BackSearchProduct.ToolTipText = " Back to Region Managment"
        '
        'tStrip_lbl_FullPath
        '
        Me.tStrip_lbl_FullPath.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_FullPath.Name = "tStrip_lbl_FullPath"
        Me.tStrip_lbl_FullPath.Size = New System.Drawing.Size(158, 37)
        Me.tStrip_lbl_FullPath.Text = "Search Product <"
        '
        'btn_EditProductDetails
        '
        Me.btn_EditProductDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_EditProductDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_EditProductDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_EditProductDetails.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_EditProductDetails.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_EditProductDetails.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btn_EditProductDetails.IconSize = 50
        Me.btn_EditProductDetails.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btn_EditProductDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_EditProductDetails.Name = "btn_EditProductDetails"
        Me.btn_EditProductDetails.Rotation = 0R
        Me.btn_EditProductDetails.Size = New System.Drawing.Size(29, 40)
        Me.btn_EditProductDetails.Text = "Edit Office Details"
        '
        'tStrip_lbl_Office
        '
        Me.tStrip_lbl_Office.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tStrip_lbl_Office.Name = "tStrip_lbl_Office"
        Me.tStrip_lbl_Office.Size = New System.Drawing.Size(159, 37)
        Me.tStrip_lbl_Office.Text = "Chemical Product"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(174, 37)
        Me.ToolStripLabel2.Text = "Edit Product Details"
        '
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'frm_ChemicalProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(792, 600)
        Me.Controls.Add(Me.tStrip_Office)
        Me.Controls.Add(Me.Product_InputEmployeeComboBox)
        Me.Controls.Add(Me.btn_LibraryCard)
        Me.Controls.Add(Me.btn_CurrentLocation)
        Me.Controls.Add(Me.btn_SDSOther)
        Me.Controls.Add(Me.btn_SDSGeneral)
        Me.Controls.Add(Me.panel_ChemicalProductChild)
        Me.Controls.Add(Me.lbl_Approver)
        Me.Controls.Add(Me.lbl_HazardousWaste)
        Me.Controls.Add(Me.lbl_Approved)
        Me.Controls.Add(Me.txt_HazardousWaste)
        Me.Controls.Add(Me.txt_Approved)
        Me.Controls.Add(Me.lbl_ProductName)
        Me.Controls.Add(Me.txt_ProductName)
        Me.Controls.Add(Me.txt_ProductID)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_ChemicalProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chemical Product"
        CType(Me.ChemicalProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_Office.ResumeLayout(False)
        Me.tStrip_Office.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ProductID As TextBox
    Friend WithEvents txt_ProductName As TextBox
    Friend WithEvents lbl_ProductName As Label
    Friend WithEvents lbl_HazardousWaste As Label
    Friend WithEvents lbl_Approved As Label
    Friend WithEvents txt_HazardousWaste As TextBox
    Friend WithEvents txt_Approved As TextBox
    Friend WithEvents lbl_Approver As Label
    Friend WithEvents panel_ChemicalProductChild As Panel
    Friend WithEvents btn_SDSGeneral As Button
    Friend WithEvents btn_SDSOther As Button
    Friend WithEvents btn_CurrentLocation As Button
    Friend WithEvents btn_LibraryCard As Button
    Friend WithEvents Product_InputEmployeeComboBox As ComboBox
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents ChemicalProductBindingSource As BindingSource
    Friend WithEvents tStrip_Office As ToolStrip
    Friend WithEvents btn_BackSearchProduct As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_FullPath As ToolStripLabel
    Friend WithEvents btn_EditProductDetails As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_Office As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter
End Class
