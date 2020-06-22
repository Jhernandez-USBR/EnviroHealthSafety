<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChemicalProduct_Library
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_DocumentActive = New System.Windows.Forms.TextBox()
        Me.LibraryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety_Data = New EnviroHealthSafety_Data()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Description = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_DocumentVersion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_DocumentName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Document_WebsiteLink = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_USBReRDMSLink = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_DocumentUploaodDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_DocumentNetworkLocation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_DocumentCreateDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_DocumentOwner = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_DocumentNote = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_LibraryID = New System.Windows.Forms.TextBox()
        Me.btn_ViewSDS = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.LibraryTableAdapter = New EnviroHealthSafety_DataTableAdapters.LibraryTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafety_DataTableAdapters.TableAdapterManager()
        Me.TlkpLibrary_DocumentTypeTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpLibrary_DocumentTypeTableAdapter()
        Me.TlkpOfficeTableAdapter = New EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter()
        Me.Office_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpOfficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Document_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.TlkpLibraryDocumentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TlkpLibraryDocumentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 195)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Is Document Active?"
        '
        'txt_DocumentActive
        '
        Me.txt_DocumentActive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentActive.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Active", True))
        Me.txt_DocumentActive.Location = New System.Drawing.Point(247, 195)
        Me.txt_DocumentActive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentActive.Name = "txt_DocumentActive"
        Me.txt_DocumentActive.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentActive.TabIndex = 1
        '
        'LibraryBindingSource
        '
        Me.LibraryBindingSource.DataMember = "Library"
        Me.LibraryBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'EnviroHealthSafety_Data
        '
        Me.EnviroHealthSafety_Data.DataSetName = "EnviroHealthSafety_Data"
        Me.EnviroHealthSafety_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Associate Office:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Document Type:"
        '
        'txt_Description
        '
        Me.txt_Description.AcceptsReturn = True
        Me.txt_Description.AcceptsTab = True
        Me.txt_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Description.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Description", True))
        Me.txt_Description.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Description.Location = New System.Drawing.Point(247, 284)
        Me.txt_Description.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(367, 75)
        Me.txt_Description.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 287)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Description"
        '
        'txt_DocumentVersion
        '
        Me.txt_DocumentVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentVersion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Version", True))
        Me.txt_DocumentVersion.Location = New System.Drawing.Point(247, 239)
        Me.txt_DocumentVersion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentVersion.Name = "txt_DocumentVersion"
        Me.txt_DocumentVersion.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentVersion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Document Version:"
        '
        'txt_DocumentName
        '
        Me.txt_DocumentName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Name", True))
        Me.txt_DocumentName.Location = New System.Drawing.Point(247, 58)
        Me.txt_DocumentName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentName.Name = "txt_DocumentName"
        Me.txt_DocumentName.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Document Name:"
        '
        'txt_Document_WebsiteLink
        '
        Me.txt_Document_WebsiteLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Document_WebsiteLink.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_WebsiteLink", True))
        Me.txt_Document_WebsiteLink.Location = New System.Drawing.Point(247, 595)
        Me.txt_Document_WebsiteLink.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Document_WebsiteLink.Name = "txt_Document_WebsiteLink"
        Me.txt_Document_WebsiteLink.Size = New System.Drawing.Size(310, 34)
        Me.txt_Document_WebsiteLink.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 595)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 28)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Website Link:"
        '
        'txt_USBReRDMSLink
        '
        Me.txt_USBReRDMSLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_USBReRDMSLink.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "USBR_ERDMS_Link", True))
        Me.txt_USBReRDMSLink.Location = New System.Drawing.Point(247, 550)
        Me.txt_USBReRDMSLink.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_USBReRDMSLink.Name = "txt_USBReRDMSLink"
        Me.txt_USBReRDMSLink.Size = New System.Drawing.Size(310, 34)
        Me.txt_USBReRDMSLink.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 550)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 28)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "eRDMS Link:"
        '
        'txt_DocumentUploaodDate
        '
        Me.txt_DocumentUploaodDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentUploaodDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_DateUpload", True))
        Me.txt_DocumentUploaodDate.Location = New System.Drawing.Point(247, 505)
        Me.txt_DocumentUploaodDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentUploaodDate.Name = "txt_DocumentUploaodDate"
        Me.txt_DocumentUploaodDate.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentUploaodDate.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 505)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 28)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Upload Date:"
        '
        'txt_DocumentNetworkLocation
        '
        Me.txt_DocumentNetworkLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentNetworkLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_NetworkLocation", True))
        Me.txt_DocumentNetworkLocation.Location = New System.Drawing.Point(247, 460)
        Me.txt_DocumentNetworkLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentNetworkLocation.Name = "txt_DocumentNetworkLocation"
        Me.txt_DocumentNetworkLocation.Size = New System.Drawing.Size(310, 34)
        Me.txt_DocumentNetworkLocation.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 460)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 28)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Network Location:"
        '
        'txt_DocumentCreateDate
        '
        Me.txt_DocumentCreateDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentCreateDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_DateCreate", True))
        Me.txt_DocumentCreateDate.Location = New System.Drawing.Point(247, 415)
        Me.txt_DocumentCreateDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentCreateDate.Name = "txt_DocumentCreateDate"
        Me.txt_DocumentCreateDate.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentCreateDate.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 415)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 28)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Document Create Date:"
        '
        'txt_DocumentOwner
        '
        Me.txt_DocumentOwner.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Owner", True))
        Me.txt_DocumentOwner.Location = New System.Drawing.Point(247, 370)
        Me.txt_DocumentOwner.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentOwner.Name = "txt_DocumentOwner"
        Me.txt_DocumentOwner.Size = New System.Drawing.Size(367, 34)
        Me.txt_DocumentOwner.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 370)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 28)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Document Submitter:"
        '
        'txt_DocumentNote
        '
        Me.txt_DocumentNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocumentNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Document_Notes", True))
        Me.txt_DocumentNote.Location = New System.Drawing.Point(247, 640)
        Me.txt_DocumentNote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DocumentNote.Multiline = True
        Me.txt_DocumentNote.Name = "txt_DocumentNote"
        Me.txt_DocumentNote.Size = New System.Drawing.Size(367, 61)
        Me.txt_DocumentNote.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(171, 652)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 28)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Notes:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(139, 14)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 28)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Library ID:"
        '
        'txt_LibraryID
        '
        Me.txt_LibraryID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_LibraryID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryBindingSource, "Library_ID", True))
        Me.txt_LibraryID.Location = New System.Drawing.Point(247, 14)
        Me.txt_LibraryID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_LibraryID.Name = "txt_LibraryID"
        Me.txt_LibraryID.Size = New System.Drawing.Size(367, 34)
        Me.txt_LibraryID.TabIndex = 27
        '
        'btn_ViewSDS
        '
        Me.btn_ViewSDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ViewSDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_ViewSDS.FlatAppearance.BorderSize = 0
        Me.btn_ViewSDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewSDS.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_ViewSDS.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewSDS.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btn_ViewSDS.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_ViewSDS.IconSize = 25
        Me.btn_ViewSDS.Location = New System.Drawing.Point(564, 461)
        Me.btn_ViewSDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ViewSDS.Name = "btn_ViewSDS"
        Me.btn_ViewSDS.Rotation = 0R
        Me.btn_ViewSDS.Size = New System.Drawing.Size(50, 34)
        Me.btn_ViewSDS.TabIndex = 31
        Me.btn_ViewSDS.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt
        Me.IconButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconButton2.IconSize = 25
        Me.IconButton2.Location = New System.Drawing.Point(564, 549)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(50, 34)
        Me.IconButton2.TabIndex = 32
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(564, 596)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(50, 34)
        Me.IconButton1.TabIndex = 33
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'LibraryTableAdapter
        '
        Me.LibraryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.LibraryTableAdapter = Me.LibraryTableAdapter
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
        Me.TableAdapterManager.tlkpLibrary_DocumentTypeTableAdapter = Me.TlkpLibrary_DocumentTypeTableAdapter
        Me.TableAdapterManager.tlkpOffice_BuildingTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_DivisionTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_GroupTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_PhysicalLocationTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOffice_TypeTableAdapter = Nothing
        Me.TableAdapterManager.tlkpOfficeTableAdapter = Me.TlkpOfficeTableAdapter
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
        'TlkpLibrary_DocumentTypeTableAdapter
        '
        Me.TlkpLibrary_DocumentTypeTableAdapter.ClearBeforeFill = True
        '
        'TlkpOfficeTableAdapter
        '
        Me.TlkpOfficeTableAdapter.ClearBeforeFill = True
        '
        'Office_IDComboBox
        '
        Me.Office_IDComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Office_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TlkpOfficeBindingSource, "Office_ID", True))
        Me.Office_IDComboBox.DataSource = Me.TlkpOfficeBindingSource
        Me.Office_IDComboBox.DisplayMember = "Office_Name"
        Me.Office_IDComboBox.FormattingEnabled = True
        Me.Office_IDComboBox.Location = New System.Drawing.Point(246, 104)
        Me.Office_IDComboBox.Name = "Office_IDComboBox"
        Me.Office_IDComboBox.Size = New System.Drawing.Size(368, 36)
        Me.Office_IDComboBox.TabIndex = 34
        Me.Office_IDComboBox.ValueMember = "Office_ID"
        '
        'TlkpOfficeBindingSource
        '
        Me.TlkpOfficeBindingSource.DataMember = "tlkpOffice"
        Me.TlkpOfficeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'Document_TypeComboBox
        '
        Me.Document_TypeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Document_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LibraryBindingSource, "Document_Type", True))
        Me.Document_TypeComboBox.DataSource = Me.TlkpLibraryDocumentTypeBindingSource
        Me.Document_TypeComboBox.DisplayMember = "DocumentType"
        Me.Document_TypeComboBox.FormattingEnabled = True
        Me.Document_TypeComboBox.Location = New System.Drawing.Point(247, 150)
        Me.Document_TypeComboBox.Name = "Document_TypeComboBox"
        Me.Document_TypeComboBox.Size = New System.Drawing.Size(367, 36)
        Me.Document_TypeComboBox.TabIndex = 35
        Me.Document_TypeComboBox.ValueMember = "DocumentType_ID"
        '
        'TlkpLibraryDocumentTypeBindingSource
        '
        Me.TlkpLibraryDocumentTypeBindingSource.DataMember = "tlkpLibrary_DocumentType"
        Me.TlkpLibraryDocumentTypeBindingSource.DataSource = Me.EnviroHealthSafety_Data
        '
        'frm_ChemicalProduct_Library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(732, 563)
        Me.Controls.Add(Me.Document_TypeComboBox)
        Me.Controls.Add(Me.Office_IDComboBox)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.btn_ViewSDS)
        Me.Controls.Add(Me.txt_LibraryID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_DocumentNote)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_Document_WebsiteLink)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_USBReRDMSLink)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_DocumentUploaodDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_DocumentNetworkLocation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_DocumentCreateDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_DocumentOwner)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_Description)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_DocumentVersion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_DocumentName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_DocumentActive)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_ChemicalProduct_Library"
        Me.Text = "Library Record"
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpOfficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TlkpLibraryDocumentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_DocumentActive As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Description As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_DocumentVersion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_DocumentName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Document_WebsiteLink As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_USBReRDMSLink As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_DocumentUploaodDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_DocumentNetworkLocation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_DocumentCreateDate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_DocumentOwner As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_DocumentNote As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_LibraryID As TextBox
    Friend WithEvents btn_ViewSDS As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents EnviroHealthSafety_Data As EnviroHealthSafety_Data
    Friend WithEvents LibraryBindingSource As BindingSource
    Friend WithEvents LibraryTableAdapter As EnviroHealthSafety_DataTableAdapters.LibraryTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafety_DataTableAdapters.TableAdapterManager
    Friend WithEvents TlkpLibrary_DocumentTypeTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpLibrary_DocumentTypeTableAdapter
    Friend WithEvents Office_IDComboBox As ComboBox
    Friend WithEvents Document_TypeComboBox As ComboBox
    Friend WithEvents TlkpLibraryDocumentTypeBindingSource As BindingSource
    Friend WithEvents TlkpOfficeTableAdapter As EnviroHealthSafety_DataTableAdapters.tlkpOfficeTableAdapter
    Friend WithEvents TlkpOfficeBindingSource As BindingSource
End Class
