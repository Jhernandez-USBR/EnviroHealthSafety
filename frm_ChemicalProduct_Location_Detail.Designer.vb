<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ChemicalProduct_Location_Detail
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
        Me.txt_PhysicalLocation = New System.Windows.Forms.ComboBox()
        Me.Chemical_LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.TlkpOfficePhysicalLocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Product = New System.Windows.Forms.ComboBox()
        Me.Chemical_ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_ActiveLocation = New System.Windows.Forms.ComboBox()
        Me.cmb_ApprovedBy = New System.Windows.Forms.ComboBox()
        Me.ZtblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Facility = New System.Windows.Forms.TextBox()
        Me.txt_Office = New System.Windows.Forms.TextBox()
        Me.txt_Region = New System.Windows.Forms.TextBox()
        Me.txt_DateDatabaseInput = New System.Windows.Forms.TextBox()
        Me.txt_DateApproved = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txt_DateLaseVerified = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tStrip_Office = New System.Windows.Forms.ToolStrip()
        Me.btn_BackSearchProduct = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_FullPath = New System.Windows.Forms.ToolStripLabel()
        Me.btn_EditProductDetails = New FontAwesome.Sharp.IconToolStripButton()
        Me.tStrip_lbl_Office = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Chemical_ProductTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.Chemical_LocationTableAdapter = New EnviroHealthSafety_DataTableAdapters.Chemical_LocationTableAdapter()
        Me.TlkpOffice_PhysicalLocationTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter()
        Me.Ztbl_EmployeeTableAdapter = New EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter()
        Me.ProductLocation_IDTextBox = New System.Windows.Forms.TextBox()
        CType(Me.Chemical_LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficePhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tStrip_Office.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_PhysicalLocation
        '
        Me.txt_PhysicalLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PhysicalLocation.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_LocationBindingSource, "PhysicalLocation_ID", True))
        Me.txt_PhysicalLocation.DataSource = Me.TlkpOfficePhysicalLocationBindingSource
        Me.txt_PhysicalLocation.DisplayMember = "PhysicalLocation_Name"
        Me.txt_PhysicalLocation.FormattingEnabled = True
        Me.txt_PhysicalLocation.Location = New System.Drawing.Point(234, 110)
        Me.txt_PhysicalLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_PhysicalLocation.Name = "txt_PhysicalLocation"
        Me.txt_PhysicalLocation.Size = New System.Drawing.Size(675, 36)
        Me.txt_PhysicalLocation.TabIndex = 0
        Me.txt_PhysicalLocation.ValueMember = "PhysicalLocation_ID"
        '
        'Chemical_LocationBindingSource
        '
        Me.Chemical_LocationBindingSource.DataMember = "Chemical_Location"
        Me.Chemical_LocationBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TlkpOfficePhysicalLocationBindingSource
        '
        Me.TlkpOfficePhysicalLocationBindingSource.DataMember = "tlkpOffice_PhysicalLocation"
        Me.TlkpOfficePhysicalLocationBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'cmb_Product
        '
        Me.cmb_Product.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Product.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_LocationBindingSource, "Product_ID", True))
        Me.cmb_Product.DataSource = Me.Chemical_ProductBindingSource
        Me.cmb_Product.DisplayMember = "Product_Name"
        Me.cmb_Product.FormattingEnabled = True
        Me.cmb_Product.Location = New System.Drawing.Point(234, 64)
        Me.cmb_Product.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_Product.Name = "cmb_Product"
        Me.cmb_Product.Size = New System.Drawing.Size(568, 36)
        Me.cmb_Product.TabIndex = 1
        Me.cmb_Product.ValueMember = "Product_ID"
        '
        'Chemical_ProductBindingSource
        '
        Me.Chemical_ProductBindingSource.DataMember = "Chemical_Product"
        Me.Chemical_ProductBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'txt_ActiveLocation
        '
        Me.txt_ActiveLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ActiveLocation.FormattingEnabled = True
        Me.txt_ActiveLocation.Location = New System.Drawing.Point(234, 313)
        Me.txt_ActiveLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_ActiveLocation.Name = "txt_ActiveLocation"
        Me.txt_ActiveLocation.Size = New System.Drawing.Size(675, 36)
        Me.txt_ActiveLocation.TabIndex = 2
        '
        'cmb_ApprovedBy
        '
        Me.cmb_ApprovedBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ApprovedBy.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Chemical_LocationBindingSource, "ProductLocation_ApprovedBy", True))
        Me.cmb_ApprovedBy.DataSource = Me.ZtblEmployeeBindingSource
        Me.cmb_ApprovedBy.DisplayMember = "Employee_FirstLastName"
        Me.cmb_ApprovedBy.FormattingEnabled = True
        Me.cmb_ApprovedBy.Location = New System.Drawing.Point(234, 414)
        Me.cmb_ApprovedBy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_ApprovedBy.Name = "cmb_ApprovedBy"
        Me.cmb_ApprovedBy.Size = New System.Drawing.Size(675, 36)
        Me.cmb_ApprovedBy.TabIndex = 3
        Me.cmb_ApprovedBy.ValueMember = "Employee_ID"
        '
        'ZtblEmployeeBindingSource
        '
        Me.ZtblEmployeeBindingSource.DataMember = "ztbl_Employee"
        Me.ZtblEmployeeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'txt_Facility
        '
        Me.txt_Facility.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Facility.Location = New System.Drawing.Point(234, 162)
        Me.txt_Facility.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Facility.Name = "txt_Facility"
        Me.txt_Facility.ReadOnly = True
        Me.txt_Facility.Size = New System.Drawing.Size(675, 34)
        Me.txt_Facility.TabIndex = 5
        '
        'txt_Office
        '
        Me.txt_Office.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Office.Location = New System.Drawing.Point(234, 211)
        Me.txt_Office.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Office.Name = "txt_Office"
        Me.txt_Office.ReadOnly = True
        Me.txt_Office.Size = New System.Drawing.Size(675, 34)
        Me.txt_Office.TabIndex = 6
        '
        'txt_Region
        '
        Me.txt_Region.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Region.Location = New System.Drawing.Point(234, 260)
        Me.txt_Region.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Region.Name = "txt_Region"
        Me.txt_Region.ReadOnly = True
        Me.txt_Region.Size = New System.Drawing.Size(675, 34)
        Me.txt_Region.TabIndex = 7
        '
        'txt_DateDatabaseInput
        '
        Me.txt_DateDatabaseInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DateDatabaseInput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_LocationBindingSource, "ProductLocation_InputDate", True))
        Me.txt_DateDatabaseInput.Location = New System.Drawing.Point(234, 365)
        Me.txt_DateDatabaseInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DateDatabaseInput.Name = "txt_DateDatabaseInput"
        Me.txt_DateDatabaseInput.Size = New System.Drawing.Size(675, 34)
        Me.txt_DateDatabaseInput.TabIndex = 8
        '
        'txt_DateApproved
        '
        Me.txt_DateApproved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DateApproved.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_LocationBindingSource, "ProductLocation_Approved", True))
        Me.txt_DateApproved.Location = New System.Drawing.Point(234, 465)
        Me.txt_DateApproved.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DateApproved.Name = "txt_DateApproved"
        Me.txt_DateApproved.Size = New System.Drawing.Size(675, 34)
        Me.txt_DateApproved.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_LocationBindingSource, "ProductLocation_Notes", True))
        Me.TextBox7.Location = New System.Drawing.Point(234, 563)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(675, 95)
        Me.TextBox7.TabIndex = 10
        '
        'txt_DateLaseVerified
        '
        Me.txt_DateLaseVerified.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DateLaseVerified.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_LocationBindingSource, "ProductLocation_VerifiedDate", True))
        Me.txt_DateLaseVerified.Location = New System.Drawing.Point(234, 514)
        Me.txt_DateLaseVerified.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DateLaseVerified.Name = "txt_DateLaseVerified"
        Me.txt_DateLaseVerified.Size = New System.Drawing.Size(675, 34)
        Me.txt_DateLaseVerified.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "*Physical Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 28)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Facility:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Office:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Region:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(134, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 28)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "*Product:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(71, 316)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 28)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Location Active:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 368)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 28)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Database Input Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(84, 417)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 28)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "*Approved By:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 468)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 28)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Approved Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 514)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 28)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Last Verified Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(160, 563)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 28)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Notes:"
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
        Me.tStrip_Office.Size = New System.Drawing.Size(932, 40)
        Me.tStrip_Office.TabIndex = 25
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
        'Chemical_ProductTableAdapter
        '
        Me.Chemical_ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Me.Chemical_LocationTableAdapter
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
        Me.TableAdapterManager.ztbl_EmployeeTableAdapter = Me.Ztbl_EmployeeTableAdapter
        '
        'Chemical_LocationTableAdapter
        '
        Me.Chemical_LocationTableAdapter.ClearBeforeFill = True
        '
        'TlkpOffice_PhysicalLocationTableAdapter
        '
        Me.TlkpOffice_PhysicalLocationTableAdapter.ClearBeforeFill = True
        '
        'Ztbl_EmployeeTableAdapter
        '
        Me.Ztbl_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'ProductLocation_IDTextBox
        '
        Me.ProductLocation_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductLocation_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Chemical_LocationBindingSource, "ProductLocation_ID", True))
        Me.ProductLocation_IDTextBox.Location = New System.Drawing.Point(809, 64)
        Me.ProductLocation_IDTextBox.Name = "ProductLocation_IDTextBox"
        Me.ProductLocation_IDTextBox.ReadOnly = True
        Me.ProductLocation_IDTextBox.Size = New System.Drawing.Size(100, 34)
        Me.ProductLocation_IDTextBox.TabIndex = 26
        '
        'frm_ChemicalProduct_Location_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 678)
        Me.Controls.Add(Me.ProductLocation_IDTextBox)
        Me.Controls.Add(Me.tStrip_Office)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_DateLaseVerified)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.txt_DateApproved)
        Me.Controls.Add(Me.txt_DateDatabaseInput)
        Me.Controls.Add(Me.txt_Region)
        Me.Controls.Add(Me.txt_Office)
        Me.Controls.Add(Me.txt_Facility)
        Me.Controls.Add(Me.cmb_ApprovedBy)
        Me.Controls.Add(Me.txt_ActiveLocation)
        Me.Controls.Add(Me.cmb_Product)
        Me.Controls.Add(Me.txt_PhysicalLocation)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(950, 725)
        Me.Name = "frm_ChemicalProduct_Location_Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Chemical_LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficePhysicalLocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chemical_ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZtblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tStrip_Office.ResumeLayout(False)
        Me.tStrip_Office.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_PhysicalLocation As ComboBox
    Friend WithEvents cmb_Product As ComboBox
    Friend WithEvents txt_ActiveLocation As ComboBox
    Friend WithEvents cmb_ApprovedBy As ComboBox
    Friend WithEvents txt_Facility As TextBox
    Friend WithEvents txt_Office As TextBox
    Friend WithEvents txt_Region As TextBox
    Friend WithEvents txt_DateDatabaseInput As TextBox
    Friend WithEvents txt_DateApproved As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txt_DateLaseVerified As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tStrip_Office As ToolStrip
    Friend WithEvents btn_BackSearchProduct As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_FullPath As ToolStripLabel
    Friend WithEvents btn_EditProductDetails As FontAwesome.Sharp.IconToolStripButton
    Friend WithEvents tStrip_lbl_Office As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents Chemical_ProductBindingSource As BindingSource
    Friend WithEvents Chemical_ProductTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_ProductTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents TlkpOffice_PhysicalLocationTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOffice_PhysicalLocationTableAdapter
    Friend WithEvents TlkpOfficePhysicalLocationBindingSource As BindingSource
    Friend WithEvents Chemical_LocationTableAdapter As EnviroHealthSafety_DataTableAdapters.Chemical_LocationTableAdapter
    Friend WithEvents Chemical_LocationBindingSource As BindingSource
    Friend WithEvents Ztbl_EmployeeTableAdapter As EnviroHealthSafety_DataTableAdapters.ztbl_EmployeeTableAdapter
    Friend WithEvents ProductLocation_IDTextBox As TextBox
    Friend WithEvents ZtblEmployeeBindingSource As BindingSource
End Class
