<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ProductInventory
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
        Dim Product_NameLabel As System.Windows.Forms.Label
        Me.txt_SearchProductName = New System.Windows.Forms.TextBox()
        Me.btn_SearchProduct = New FontAwesome.Sharp.IconButton()
        Me.dgv_ProudtcList = New System.Windows.Forms.DataGridView()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.Chemical_ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter()
        Me.tStrip_ProductInventory = New System.Windows.Forms.ToolStrip()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductRevisedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductVerifiedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductInputDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductInputEmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductApprovedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductHazWasteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Product_NameLabel = New System.Windows.Forms.Label()
        CType(Me.dgv_ProudtcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Location = New System.Drawing.Point(20, 77)
        Product_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(142, 28)
        Product_NameLabel.TabIndex = 19
        Product_NameLabel.Text = "Product Name:"
        '
        'txt_SearchProductName
        '
        Me.txt_SearchProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SearchProductName.Location = New System.Drawing.Point(170, 77)
        Me.txt_SearchProductName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_SearchProductName.Name = "txt_SearchProductName"
        Me.txt_SearchProductName.Size = New System.Drawing.Size(382, 34)
        Me.txt_SearchProductName.TabIndex = 20
        '
        'btn_SearchProduct
        '
        Me.btn_SearchProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_SearchProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SearchProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_SearchProduct.ForeColor = System.Drawing.Color.White
        Me.btn_SearchProduct.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_SearchProduct.IconColor = System.Drawing.Color.Black
        Me.btn_SearchProduct.IconSize = 16
        Me.btn_SearchProduct.Location = New System.Drawing.Point(560, 71)
        Me.btn_SearchProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_SearchProduct.Name = "btn_SearchProduct"
        Me.btn_SearchProduct.Rotation = 0R
        Me.btn_SearchProduct.Size = New System.Drawing.Size(150, 40)
        Me.btn_SearchProduct.TabIndex = 21
        Me.btn_SearchProduct.Text = "Search"
        Me.btn_SearchProduct.UseVisualStyleBackColor = False
        '
        'dgv_ProudtcList
        '
        Me.dgv_ProudtcList.AllowUserToAddRows = False
        Me.dgv_ProudtcList.AllowUserToDeleteRows = False
        Me.dgv_ProudtcList.AllowUserToOrderColumns = True
        Me.dgv_ProudtcList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ProudtcList.AutoGenerateColumns = False
        Me.dgv_ProudtcList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_ProudtcList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_ProudtcList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProudtcList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductIssueDateDataGridViewTextBoxColumn, Me.ProductRevisedDateDataGridViewTextBoxColumn, Me.ProductVerifiedDateDataGridViewTextBoxColumn, Me.ProductInputDateDataGridViewTextBoxColumn, Me.ProductInputEmployeeDataGridViewTextBoxColumn, Me.ProductApprovedDataGridViewCheckBoxColumn, Me.ProductHazWasteDataGridViewCheckBoxColumn})
        Me.dgv_ProudtcList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_ProudtcList.DataSource = Me.Chemical_ProductBindingSource
        Me.dgv_ProudtcList.Location = New System.Drawing.Point(25, 122)
        Me.dgv_ProudtcList.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv_ProudtcList.Name = "dgv_ProudtcList"
        Me.dgv_ProudtcList.ReadOnly = True
        Me.dgv_ProudtcList.RowHeadersWidth = 51
        Me.dgv_ProudtcList.RowTemplate.Height = 24
        Me.dgv_ProudtcList.Size = New System.Drawing.Size(685, 405)
        Me.dgv_ProudtcList.TabIndex = 22
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Chemical_ProductBindingSource
        '
        Me.Chemical_ProductBindingSource.DataMember = "Chemical_Product"
        Me.Chemical_ProductBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
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
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'tStrip_ProductInventory
        '
        Me.tStrip_ProductInventory.AutoSize = False
        Me.tStrip_ProductInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.tStrip_ProductInventory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tStrip_ProductInventory.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tStrip_ProductInventory.Location = New System.Drawing.Point(0, 0)
        Me.tStrip_ProductInventory.Name = "tStrip_ProductInventory"
        Me.tStrip_ProductInventory.Size = New System.Drawing.Size(732, 40)
        Me.tStrip_ProductInventory.TabIndex = 23
        Me.tStrip_ProductInventory.Text = "Product Inventory ToolStrip"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductIDDataGridViewTextBoxColumn.Width = 137
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductIssueDateDataGridViewTextBoxColumn
        '
        Me.ProductIssueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductIssueDateDataGridViewTextBoxColumn.DataPropertyName = "Product_IssueDate"
        Me.ProductIssueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date"
        Me.ProductIssueDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIssueDateDataGridViewTextBoxColumn.Name = "ProductIssueDateDataGridViewTextBoxColumn"
        Me.ProductIssueDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIssueDateDataGridViewTextBoxColumn.Visible = False
        Me.ProductIssueDateDataGridViewTextBoxColumn.Width = 129
        '
        'ProductRevisedDateDataGridViewTextBoxColumn
        '
        Me.ProductRevisedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductRevisedDateDataGridViewTextBoxColumn.DataPropertyName = "Product_RevisedDate"
        Me.ProductRevisedDateDataGridViewTextBoxColumn.HeaderText = "Revised Date"
        Me.ProductRevisedDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductRevisedDateDataGridViewTextBoxColumn.Name = "ProductRevisedDateDataGridViewTextBoxColumn"
        Me.ProductRevisedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductRevisedDateDataGridViewTextBoxColumn.Visible = False
        Me.ProductRevisedDateDataGridViewTextBoxColumn.Width = 153
        '
        'ProductVerifiedDateDataGridViewTextBoxColumn
        '
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.DataPropertyName = "Product_VerifiedDate"
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.HeaderText = "Verified Date"
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.Name = "ProductVerifiedDateDataGridViewTextBoxColumn"
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductVerifiedDateDataGridViewTextBoxColumn.Width = 153
        '
        'ProductInputDateDataGridViewTextBoxColumn
        '
        Me.ProductInputDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductInputDateDataGridViewTextBoxColumn.DataPropertyName = "Product_InputDate"
        Me.ProductInputDateDataGridViewTextBoxColumn.HeaderText = "Input Date"
        Me.ProductInputDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductInputDateDataGridViewTextBoxColumn.Name = "ProductInputDateDataGridViewTextBoxColumn"
        Me.ProductInputDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductInputDateDataGridViewTextBoxColumn.Width = 133
        '
        'ProductInputEmployeeDataGridViewTextBoxColumn
        '
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.DataPropertyName = "Product_InputEmployee"
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.DataSource = Me.ZtblEmployeeBindingSource
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.DisplayMember = "Employee_FirstLastName"
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = True
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.HeaderText = "Approver"
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.Name = "ProductInputEmployeeDataGridViewTextBoxColumn"
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.ValueMember = "Employee_ID"
        Me.ProductInputEmployeeDataGridViewTextBoxColumn.Width = 124
        '
        'ProductApprovedDataGridViewCheckBoxColumn
        '
        Me.ProductApprovedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductApprovedDataGridViewCheckBoxColumn.DataPropertyName = "Product_Approved"
        Me.ProductApprovedDataGridViewCheckBoxColumn.HeaderText = "Approved"
        Me.ProductApprovedDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ProductApprovedDataGridViewCheckBoxColumn.Name = "ProductApprovedDataGridViewCheckBoxColumn"
        Me.ProductApprovedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProductApprovedDataGridViewCheckBoxColumn.Width = 106
        '
        'ProductHazWasteDataGridViewCheckBoxColumn
        '
        Me.ProductHazWasteDataGridViewCheckBoxColumn.DataPropertyName = "Product_HazWaste"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.HeaderText = "Hazardous"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ProductHazWasteDataGridViewCheckBoxColumn.Name = "ProductHazWasteDataGridViewCheckBoxColumn"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProductHazWasteDataGridViewCheckBoxColumn.Width = 111
        '
        'frm_ProductInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 553)
        Me.Controls.Add(Me.tStrip_ProductInventory)
        Me.Controls.Add(Me.dgv_ProudtcList)
        Me.Controls.Add(Me.btn_SearchProduct)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.txt_SearchProductName)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_ProductInventory"
        Me.Text = "Chemical Product Inventory"
        CType(Me.dgv_ProudtcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents Chemical_ProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafetyTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents txt_SearchProductName As TextBox
    Friend WithEvents btn_SearchProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents dgv_ProudtcList As DataGridView
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafetyTableAdapters.ztbl_EmployeeTableAdapter
    Friend WithEvents tStrip_ProductInventory As ToolStrip
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductRevisedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductVerifiedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductInputDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductInputEmployeeDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ProductApprovedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProductHazWasteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
