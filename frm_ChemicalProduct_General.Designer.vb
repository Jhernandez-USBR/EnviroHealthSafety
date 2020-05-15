<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ChemicalProduct_General
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_SDSProductCode = New System.Windows.Forms.Label()
        Me.lbl_SDSFileName = New System.Windows.Forms.Label()
        Me.lbl_SDSNetworkPath = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Qry_ChemicalProduct_SDSGeneralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_SDSNumber = New System.Windows.Forms.TextBox()
        Me.txtSDS_ProductCode = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtSDS_NetworkPath = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.btn_ViewSDS = New FontAwesome.Sharp.IconButton()
        Me.btn_WebsiteOpen = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Qry_ChemicalProduct_SDSGeneralTableAdapter = New EnviroHealthSafetyTableAdapters.qry_ChemicalProduct_SDSGeneralTableAdapter()
        Me.TableAdapterManager = New EnviroHealthSafetyTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Qry_ChemicalProduct_SDSGeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SDS No.:"
        '
        'lbl_SDSProductCode
        '
        Me.lbl_SDSProductCode.AutoSize = True
        Me.lbl_SDSProductCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SDSProductCode.Location = New System.Drawing.Point(26, 93)
        Me.lbl_SDSProductCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SDSProductCode.Name = "lbl_SDSProductCode"
        Me.lbl_SDSProductCode.Size = New System.Drawing.Size(183, 28)
        Me.lbl_SDSProductCode.TabIndex = 1
        Me.lbl_SDSProductCode.Text = "SDS Product Code:"
        '
        'lbl_SDSFileName
        '
        Me.lbl_SDSFileName.AutoSize = True
        Me.lbl_SDSFileName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SDSFileName.Location = New System.Drawing.Point(64, 143)
        Me.lbl_SDSFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SDSFileName.Name = "lbl_SDSFileName"
        Me.lbl_SDSFileName.Size = New System.Drawing.Size(150, 28)
        Me.lbl_SDSFileName.TabIndex = 2
        Me.lbl_SDSFileName.Text = "SDS File Name:"
        '
        'lbl_SDSNetworkPath
        '
        Me.lbl_SDSNetworkPath.AutoSize = True
        Me.lbl_SDSNetworkPath.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SDSNetworkPath.Location = New System.Drawing.Point(37, 190)
        Me.lbl_SDSNetworkPath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SDSNetworkPath.Name = "lbl_SDSNetworkPath"
        Me.lbl_SDSNetworkPath.Size = New System.Drawing.Size(183, 28)
        Me.lbl_SDSNetworkPath.TabIndex = 3
        Me.lbl_SDSNetworkPath.Text = "SDS Network Path:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SDS Verified Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "SDS_Link", True))
        Me.Label6.Location = New System.Drawing.Point(440, 247)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 28)
        Me.Label6.TabIndex = 5
        '
        'Qry_ChemicalProduct_SDSGeneralBindingSource
        '
        Me.Qry_ChemicalProduct_SDSGeneralBindingSource.DataMember = "qry_ChemicalProduct_SDSGeneral"
        Me.Qry_ChemicalProduct_SDSGeneralBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(669, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "SDS Create Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(137, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 28)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 93)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Address 1:"
        '
        'txt_SDSNumber
        '
        Me.txt_SDSNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SDSNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "SDS_Number", True))
        Me.txt_SDSNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SDSNumber.Location = New System.Drawing.Point(221, 43)
        Me.txt_SDSNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_SDSNumber.Name = "txt_SDSNumber"
        Me.txt_SDSNumber.Size = New System.Drawing.Size(608, 34)
        Me.txt_SDSNumber.TabIndex = 11
        '
        'txtSDS_ProductCode
        '
        Me.txtSDS_ProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSDS_ProductCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "SDS_ProductCode", True))
        Me.txtSDS_ProductCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDS_ProductCode.Location = New System.Drawing.Point(221, 93)
        Me.txtSDS_ProductCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSDS_ProductCode.Name = "txtSDS_ProductCode"
        Me.txtSDS_ProductCode.Size = New System.Drawing.Size(609, 34)
        Me.txtSDS_ProductCode.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Document_Name", True))
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(221, 143)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(609, 34)
        Me.TextBox3.TabIndex = 13
        '
        'txtSDS_NetworkPath
        '
        Me.txtSDS_NetworkPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSDS_NetworkPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Document_NetworkLocation", True))
        Me.txtSDS_NetworkPath.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDS_NetworkPath.Location = New System.Drawing.Point(221, 193)
        Me.txtSDS_NetworkPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSDS_NetworkPath.Name = "txtSDS_NetworkPath"
        Me.txtSDS_NetworkPath.Size = New System.Drawing.Size(396, 34)
        Me.txtSDS_NetworkPath.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Product_VerifiedDate", True))
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(221, 280)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 34)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "SDS_DateLastReviewed", True))
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(445, 280)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(200, 34)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "SDS_DateCreated", True))
        Me.TextBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(668, 280)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(163, 34)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_Name", True))
        Me.TextBox8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(221, 44)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(608, 34)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_Address1", True))
        Me.TextBox9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(221, 93)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(608, 34)
        Me.TextBox9.TabIndex = 19
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_Address2", True))
        Me.TextBox10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(221, 137)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(608, 34)
        Me.TextBox10.TabIndex = 20
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_City", True))
        Me.TextBox11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(221, 219)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(150, 34)
        Me.TextBox11.TabIndex = 21
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_AreaCode", True))
        Me.TextBox12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(387, 219)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(150, 34)
        Me.TextBox12.TabIndex = 22
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_State", True))
        Me.TextBox13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(553, 219)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(150, 34)
        Me.TextBox13.TabIndex = 23
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Manufacturer_Phone", True))
        Me.TextBox14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(719, 219)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(110, 34)
        Me.TextBox14.TabIndex = 24
        '
        'btn_ViewSDS
        '
        Me.btn_ViewSDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ViewSDS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_ViewSDS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ViewSDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewSDS.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_ViewSDS.Font = New System.Drawing.Font("Segoe UI Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewSDS.ForeColor = System.Drawing.Color.White
        Me.btn_ViewSDS.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btn_ViewSDS.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_ViewSDS.IconSize = 25
        Me.btn_ViewSDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ViewSDS.Location = New System.Drawing.Point(627, 193)
        Me.btn_ViewSDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_ViewSDS.Name = "btn_ViewSDS"
        Me.btn_ViewSDS.Rotation = 0R
        Me.btn_ViewSDS.Size = New System.Drawing.Size(146, 34)
        Me.btn_ViewSDS.TabIndex = 27
        Me.btn_ViewSDS.Text = "View SDS"
        Me.btn_ViewSDS.UseVisualStyleBackColor = False
        '
        'btn_WebsiteOpen
        '
        Me.btn_WebsiteOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_WebsiteOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_WebsiteOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WebsiteOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WebsiteOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_WebsiteOpen.ForeColor = System.Drawing.Color.White
        Me.btn_WebsiteOpen.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt
        Me.btn_WebsiteOpen.IconColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btn_WebsiteOpen.IconSize = 25
        Me.btn_WebsiteOpen.Location = New System.Drawing.Point(781, 193)
        Me.btn_WebsiteOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_WebsiteOpen.Name = "btn_WebsiteOpen"
        Me.btn_WebsiteOpen.Rotation = 0R
        Me.btn_WebsiteOpen.Size = New System.Drawing.Size(50, 34)
        Me.btn_WebsiteOpen.TabIndex = 28
        Me.btn_WebsiteOpen.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(101, 136)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 28)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Address 2:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(217, 186)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 28)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(382, 186)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 28)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Zip Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(548, 186)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 28)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "State"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(714, 186)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 28)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Phone No."
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Product_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_SDSProductCode)
        Me.GroupBox1.Controls.Add(Me.txt_SDSNumber)
        Me.GroupBox1.Controls.Add(Me.txtSDS_ProductCode)
        Me.GroupBox1.Controls.Add(Me.lbl_SDSFileName)
        Me.GroupBox1.Controls.Add(Me.btn_WebsiteOpen)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.btn_ViewSDS)
        Me.GroupBox1.Controls.Add(Me.lbl_SDSNetworkPath)
        Me.GroupBox1.Controls.Add(Me.txtSDS_NetworkPath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 349)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Detail"
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Qry_ChemicalProduct_SDSGeneralBindingSource, "Product_ID", True))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(732, 1)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(100, 34)
        Me.Product_IDTextBox.TabIndex = 29
        Me.Product_IDTextBox.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(859, 279)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manufacturer"
        '
        'Qry_ChemicalProduct_SDSGeneralTableAdapter
        '
        Me.Qry_ChemicalProduct_SDSGeneralTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Chemical_LocationTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ManufacturerTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ProductTableAdapter = Nothing
        Me.TableAdapterManager.Chemical_ResponsiblePartyTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "SDS Last Review Date:"
        '
        'frm_ChemicalProduct_General
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.ClientSize = New System.Drawing.Size(859, 628)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "frm_ChemicalProduct_General"
        Me.Text = "Product Details"
        CType(Me.Qry_ChemicalProduct_SDSGeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_SDSProductCode As Label
    Friend WithEvents lbl_SDSFileName As Label
    Friend WithEvents lbl_SDSNetworkPath As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_SDSNumber As TextBox
    Friend WithEvents txtSDS_ProductCode As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtSDS_NetworkPath As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents btn_ViewSDS As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_WebsiteOpen As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents Qry_ChemicalProduct_SDSGeneralBindingSource As BindingSource
    Friend WithEvents Qry_ChemicalProduct_SDSGeneralTableAdapter As EnviroHealthSafetyTableAdapters.qry_ChemicalProduct_SDSGeneralTableAdapter
    Friend WithEvents TableAdapterManager As EnviroHealthSafetyTableAdapters.TableAdapterManager
    Friend WithEvents Product_IDTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
