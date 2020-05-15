<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EHSMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EHSMain))
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Product = New System.Windows.Forms.Button()
        Me.Panel_ProductSubmenu = New System.Windows.Forms.Panel()
        Me.btn_Product_EditProduct = New System.Windows.Forms.Button()
        Me.btn_Product_NewProduct = New System.Windows.Forms.Button()
        Me.btn_Product_ChemicalInventory = New System.Windows.Forms.Button()
        Me.btn_Product_SDSSearch = New System.Windows.Forms.Button()
        Me.btn_WasteStream = New System.Windows.Forms.Button()
        Me.Panel_WasteStreamSubMenu = New System.Windows.Forms.Panel()
        Me.btn_WasteStream_4 = New System.Windows.Forms.Button()
        Me.btn_WasteStream_3 = New System.Windows.Forms.Button()
        Me.btn_WasteStream_2 = New System.Windows.Forms.Button()
        Me.btn_WasteStream_1 = New System.Windows.Forms.Button()
        Me.btn_Report = New System.Windows.Forms.Button()
        Me.Panel_SideMenu = New System.Windows.Forms.Panel()
        Me.Panel_MainBtmSubmenu = New System.Windows.Forms.Panel()
        Me.txt_Date = New System.Windows.Forms.TextBox()
        Me.txt_Version = New System.Windows.Forms.TextBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.Panel_AdministrativeSubMenu = New System.Windows.Forms.Panel()
        Me.btn_Administrative4 = New System.Windows.Forms.Button()
        Me.btn_Administrative3 = New System.Windows.Forms.Button()
        Me.btn_Administrative2 = New System.Windows.Forms.Button()
        Me.btn_Administrative1 = New System.Windows.Forms.Button()
        Me.btn_Administrative = New System.Windows.Forms.Button()
        Me.Panel_EHSMain_Child = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel_EHSMain_Header = New System.Windows.Forms.Panel()
        Me.btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_CloseDatabase = New FontAwesome.Sharp.IconButton()
        Me.btn_Home = New FontAwesome.Sharp.IconButton()
        Me.lbl_HeaderText = New System.Windows.Forms.Label()
        Me.Panel_Logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ProductSubmenu.SuspendLayout()
        Me.Panel_WasteStreamSubMenu.SuspendLayout()
        Me.Panel_SideMenu.SuspendLayout()
        Me.Panel_MainBtmSubmenu.SuspendLayout()
        Me.Panel_AdministrativeSubMenu.SuspendLayout()
        Me.Panel_EHSMain_Child.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_EHSMain_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Logo
        '
        Me.Panel_Logo.Controls.Add(Me.PictureBox1)
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel_Logo.Size = New System.Drawing.Size(275, 150)
        Me.Panel_Logo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.EnviroHealthSafety.My.Resources.Resources.BofR_horiz_pms_white_type
        Me.PictureBox1.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(15)
        Me.PictureBox1.Size = New System.Drawing.Size(245, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_Product
        '
        Me.btn_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product.FlatAppearance.BorderSize = 0
        Me.btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product.ForeColor = System.Drawing.Color.White
        Me.btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product.Location = New System.Drawing.Point(0, 150)
        Me.btn_Product.Name = "btn_Product"
        Me.btn_Product.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Product.Size = New System.Drawing.Size(275, 45)
        Me.btn_Product.TabIndex = 0
        Me.btn_Product.Text = "Products"
        Me.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product.UseMnemonic = False
        Me.btn_Product.UseVisualStyleBackColor = True
        '
        'Panel_ProductSubmenu
        '
        Me.Panel_ProductSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel_ProductSubmenu.Controls.Add(Me.btn_Product_EditProduct)
        Me.Panel_ProductSubmenu.Controls.Add(Me.btn_Product_NewProduct)
        Me.Panel_ProductSubmenu.Controls.Add(Me.btn_Product_ChemicalInventory)
        Me.Panel_ProductSubmenu.Controls.Add(Me.btn_Product_SDSSearch)
        Me.Panel_ProductSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ProductSubmenu.ForeColor = System.Drawing.Color.White
        Me.Panel_ProductSubmenu.Location = New System.Drawing.Point(0, 195)
        Me.Panel_ProductSubmenu.Name = "Panel_ProductSubmenu"
        Me.Panel_ProductSubmenu.Size = New System.Drawing.Size(275, 173)
        Me.Panel_ProductSubmenu.TabIndex = 1
        Me.Panel_ProductSubmenu.Visible = False
        '
        'btn_Product_EditProduct
        '
        Me.btn_Product_EditProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Product_EditProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product_EditProduct.FlatAppearance.BorderSize = 0
        Me.btn_Product_EditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product_EditProduct.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product_EditProduct.ForeColor = System.Drawing.Color.White
        Me.btn_Product_EditProduct.Location = New System.Drawing.Point(0, 120)
        Me.btn_Product_EditProduct.Name = "btn_Product_EditProduct"
        Me.btn_Product_EditProduct.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Product_EditProduct.Size = New System.Drawing.Size(275, 40)
        Me.btn_Product_EditProduct.TabIndex = 3
        Me.btn_Product_EditProduct.Text = "Edit Product Details"
        Me.btn_Product_EditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product_EditProduct.UseVisualStyleBackColor = True
        '
        'btn_Product_NewProduct
        '
        Me.btn_Product_NewProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Product_NewProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product_NewProduct.FlatAppearance.BorderSize = 0
        Me.btn_Product_NewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product_NewProduct.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product_NewProduct.ForeColor = System.Drawing.Color.White
        Me.btn_Product_NewProduct.Location = New System.Drawing.Point(0, 80)
        Me.btn_Product_NewProduct.Name = "btn_Product_NewProduct"
        Me.btn_Product_NewProduct.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Product_NewProduct.Size = New System.Drawing.Size(275, 40)
        Me.btn_Product_NewProduct.TabIndex = 2
        Me.btn_Product_NewProduct.Text = "New Product"
        Me.btn_Product_NewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product_NewProduct.UseVisualStyleBackColor = True
        '
        'btn_Product_ChemicalInventory
        '
        Me.btn_Product_ChemicalInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Product_ChemicalInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product_ChemicalInventory.FlatAppearance.BorderSize = 0
        Me.btn_Product_ChemicalInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product_ChemicalInventory.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product_ChemicalInventory.ForeColor = System.Drawing.Color.White
        Me.btn_Product_ChemicalInventory.Location = New System.Drawing.Point(0, 40)
        Me.btn_Product_ChemicalInventory.Name = "btn_Product_ChemicalInventory"
        Me.btn_Product_ChemicalInventory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Product_ChemicalInventory.Size = New System.Drawing.Size(275, 40)
        Me.btn_Product_ChemicalInventory.TabIndex = 1
        Me.btn_Product_ChemicalInventory.Text = "Chemical Inventory"
        Me.btn_Product_ChemicalInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product_ChemicalInventory.UseVisualStyleBackColor = True
        '
        'btn_Product_SDSSearch
        '
        Me.btn_Product_SDSSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Product_SDSSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Product_SDSSearch.FlatAppearance.BorderSize = 0
        Me.btn_Product_SDSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Product_SDSSearch.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Product_SDSSearch.ForeColor = System.Drawing.Color.White
        Me.btn_Product_SDSSearch.Location = New System.Drawing.Point(0, 0)
        Me.btn_Product_SDSSearch.Name = "btn_Product_SDSSearch"
        Me.btn_Product_SDSSearch.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Product_SDSSearch.Size = New System.Drawing.Size(275, 40)
        Me.btn_Product_SDSSearch.TabIndex = 0
        Me.btn_Product_SDSSearch.Text = "SDS Search"
        Me.btn_Product_SDSSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Product_SDSSearch.UseVisualStyleBackColor = True
        '
        'btn_WasteStream
        '
        Me.btn_WasteStream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WasteStream.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_WasteStream.FlatAppearance.BorderSize = 0
        Me.btn_WasteStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WasteStream.ForeColor = System.Drawing.Color.White
        Me.btn_WasteStream.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream.Location = New System.Drawing.Point(0, 368)
        Me.btn_WasteStream.Name = "btn_WasteStream"
        Me.btn_WasteStream.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_WasteStream.Size = New System.Drawing.Size(275, 45)
        Me.btn_WasteStream.TabIndex = 2
        Me.btn_WasteStream.Text = "Waste Stream"
        Me.btn_WasteStream.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream.UseMnemonic = False
        Me.btn_WasteStream.UseVisualStyleBackColor = True
        '
        'Panel_WasteStreamSubMenu
        '
        Me.Panel_WasteStreamSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel_WasteStreamSubMenu.Controls.Add(Me.btn_WasteStream_4)
        Me.Panel_WasteStreamSubMenu.Controls.Add(Me.btn_WasteStream_3)
        Me.Panel_WasteStreamSubMenu.Controls.Add(Me.btn_WasteStream_2)
        Me.Panel_WasteStreamSubMenu.Controls.Add(Me.btn_WasteStream_1)
        Me.Panel_WasteStreamSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_WasteStreamSubMenu.ForeColor = System.Drawing.Color.White
        Me.Panel_WasteStreamSubMenu.Location = New System.Drawing.Point(0, 413)
        Me.Panel_WasteStreamSubMenu.Name = "Panel_WasteStreamSubMenu"
        Me.Panel_WasteStreamSubMenu.Size = New System.Drawing.Size(275, 165)
        Me.Panel_WasteStreamSubMenu.TabIndex = 3
        Me.Panel_WasteStreamSubMenu.Visible = False
        '
        'btn_WasteStream_4
        '
        Me.btn_WasteStream_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WasteStream_4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_WasteStream_4.FlatAppearance.BorderSize = 0
        Me.btn_WasteStream_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WasteStream_4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WasteStream_4.ForeColor = System.Drawing.Color.White
        Me.btn_WasteStream_4.Location = New System.Drawing.Point(0, 120)
        Me.btn_WasteStream_4.Name = "btn_WasteStream_4"
        Me.btn_WasteStream_4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_WasteStream_4.Size = New System.Drawing.Size(275, 40)
        Me.btn_WasteStream_4.TabIndex = 3
        Me.btn_WasteStream_4.Text = "Edit Waste Stream Report"
        Me.btn_WasteStream_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream_4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_WasteStream_4.UseVisualStyleBackColor = True
        '
        'btn_WasteStream_3
        '
        Me.btn_WasteStream_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WasteStream_3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_WasteStream_3.FlatAppearance.BorderSize = 0
        Me.btn_WasteStream_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WasteStream_3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WasteStream_3.ForeColor = System.Drawing.Color.White
        Me.btn_WasteStream_3.Location = New System.Drawing.Point(0, 80)
        Me.btn_WasteStream_3.Name = "btn_WasteStream_3"
        Me.btn_WasteStream_3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_WasteStream_3.Size = New System.Drawing.Size(275, 40)
        Me.btn_WasteStream_3.TabIndex = 2
        Me.btn_WasteStream_3.Text = "New Waste Stream"
        Me.btn_WasteStream_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream_3.UseVisualStyleBackColor = True
        '
        'btn_WasteStream_2
        '
        Me.btn_WasteStream_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WasteStream_2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_WasteStream_2.FlatAppearance.BorderSize = 0
        Me.btn_WasteStream_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WasteStream_2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WasteStream_2.ForeColor = System.Drawing.Color.White
        Me.btn_WasteStream_2.Location = New System.Drawing.Point(0, 40)
        Me.btn_WasteStream_2.Name = "btn_WasteStream_2"
        Me.btn_WasteStream_2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_WasteStream_2.Size = New System.Drawing.Size(275, 40)
        Me.btn_WasteStream_2.TabIndex = 1
        Me.btn_WasteStream_2.Text = "New Waste Generation"
        Me.btn_WasteStream_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream_2.UseVisualStyleBackColor = True
        '
        'btn_WasteStream_1
        '
        Me.btn_WasteStream_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_WasteStream_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_WasteStream_1.FlatAppearance.BorderSize = 0
        Me.btn_WasteStream_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_WasteStream_1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_WasteStream_1.ForeColor = System.Drawing.Color.White
        Me.btn_WasteStream_1.Location = New System.Drawing.Point(0, 0)
        Me.btn_WasteStream_1.Name = "btn_WasteStream_1"
        Me.btn_WasteStream_1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_WasteStream_1.Size = New System.Drawing.Size(275, 40)
        Me.btn_WasteStream_1.TabIndex = 0
        Me.btn_WasteStream_1.Text = "Search Waste Stream"
        Me.btn_WasteStream_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_WasteStream_1.UseVisualStyleBackColor = True
        '
        'btn_Report
        '
        Me.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Report.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Report.FlatAppearance.BorderSize = 0
        Me.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Report.ForeColor = System.Drawing.Color.White
        Me.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Report.Location = New System.Drawing.Point(0, 578)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Report.Size = New System.Drawing.Size(275, 45)
        Me.btn_Report.TabIndex = 6
        Me.btn_Report.Text = "Reports"
        Me.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Report.UseMnemonic = False
        Me.btn_Report.UseVisualStyleBackColor = True
        '
        'Panel_SideMenu
        '
        Me.Panel_SideMenu.AutoScroll = True
        Me.Panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel_SideMenu.Controls.Add(Me.Panel_MainBtmSubmenu)
        Me.Panel_SideMenu.Controls.Add(Me.btn_Help)
        Me.Panel_SideMenu.Controls.Add(Me.Panel_AdministrativeSubMenu)
        Me.Panel_SideMenu.Controls.Add(Me.btn_Administrative)
        Me.Panel_SideMenu.Controls.Add(Me.btn_Report)
        Me.Panel_SideMenu.Controls.Add(Me.Panel_WasteStreamSubMenu)
        Me.Panel_SideMenu.Controls.Add(Me.btn_WasteStream)
        Me.Panel_SideMenu.Controls.Add(Me.Panel_ProductSubmenu)
        Me.Panel_SideMenu.Controls.Add(Me.btn_Product)
        Me.Panel_SideMenu.Controls.Add(Me.Panel_Logo)
        Me.Panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_SideMenu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_SideMenu.Name = "Panel_SideMenu"
        Me.Panel_SideMenu.Size = New System.Drawing.Size(275, 982)
        Me.Panel_SideMenu.TabIndex = 0
        '
        'Panel_MainBtmSubmenu
        '
        Me.Panel_MainBtmSubmenu.Controls.Add(Me.txt_Date)
        Me.Panel_MainBtmSubmenu.Controls.Add(Me.txt_Version)
        Me.Panel_MainBtmSubmenu.Controls.Add(Me.txt_UserName)
        Me.Panel_MainBtmSubmenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_MainBtmSubmenu.Location = New System.Drawing.Point(0, 888)
        Me.Panel_MainBtmSubmenu.Name = "Panel_MainBtmSubmenu"
        Me.Panel_MainBtmSubmenu.Padding = New System.Windows.Forms.Padding(35, 0, 25, 0)
        Me.Panel_MainBtmSubmenu.Size = New System.Drawing.Size(275, 94)
        Me.Panel_MainBtmSubmenu.TabIndex = 10
        '
        'txt_Date
        '
        Me.txt_Date.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Date.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_Date.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Date.ForeColor = System.Drawing.Color.White
        Me.txt_Date.Location = New System.Drawing.Point(35, 54)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.ReadOnly = True
        Me.txt_Date.Size = New System.Drawing.Size(215, 27)
        Me.txt_Date.TabIndex = 0
        Me.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Version
        '
        Me.txt_Version.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_Version.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Version.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_Version.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Version.ForeColor = System.Drawing.Color.White
        Me.txt_Version.Location = New System.Drawing.Point(35, 27)
        Me.txt_Version.Name = "txt_Version"
        Me.txt_Version.ReadOnly = True
        Me.txt_Version.Size = New System.Drawing.Size(215, 27)
        Me.txt_Version.TabIndex = 0
        Me.txt_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_UserName
        '
        Me.txt_UserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_UserName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_UserName.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UserName.ForeColor = System.Drawing.Color.White
        Me.txt_UserName.Location = New System.Drawing.Point(35, 0)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.ReadOnly = True
        Me.txt_UserName.Size = New System.Drawing.Size(215, 27)
        Me.txt_UserName.TabIndex = 1
        Me.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Help
        '
        Me.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Help.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Help.FlatAppearance.BorderSize = 0
        Me.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Help.ForeColor = System.Drawing.Color.White
        Me.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Help.Location = New System.Drawing.Point(0, 833)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Help.Size = New System.Drawing.Size(275, 45)
        Me.btn_Help.TabIndex = 9
        Me.btn_Help.Text = "Help"
        Me.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Help.UseMnemonic = False
        Me.btn_Help.UseVisualStyleBackColor = True
        '
        'Panel_AdministrativeSubMenu
        '
        Me.Panel_AdministrativeSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel_AdministrativeSubMenu.Controls.Add(Me.btn_Administrative4)
        Me.Panel_AdministrativeSubMenu.Controls.Add(Me.btn_Administrative3)
        Me.Panel_AdministrativeSubMenu.Controls.Add(Me.btn_Administrative2)
        Me.Panel_AdministrativeSubMenu.Controls.Add(Me.btn_Administrative1)
        Me.Panel_AdministrativeSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_AdministrativeSubMenu.ForeColor = System.Drawing.Color.White
        Me.Panel_AdministrativeSubMenu.Location = New System.Drawing.Point(0, 668)
        Me.Panel_AdministrativeSubMenu.Name = "Panel_AdministrativeSubMenu"
        Me.Panel_AdministrativeSubMenu.Size = New System.Drawing.Size(275, 165)
        Me.Panel_AdministrativeSubMenu.TabIndex = 8
        Me.Panel_AdministrativeSubMenu.Visible = False
        '
        'btn_Administrative4
        '
        Me.btn_Administrative4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Administrative4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Administrative4.FlatAppearance.BorderSize = 0
        Me.btn_Administrative4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrative4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administrative4.ForeColor = System.Drawing.Color.White
        Me.btn_Administrative4.Location = New System.Drawing.Point(0, 120)
        Me.btn_Administrative4.Name = "btn_Administrative4"
        Me.btn_Administrative4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Administrative4.Size = New System.Drawing.Size(275, 40)
        Me.btn_Administrative4.TabIndex = 3
        Me.btn_Administrative4.Text = "btn_Administrative4"
        Me.btn_Administrative4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative4.UseVisualStyleBackColor = True
        '
        'btn_Administrative3
        '
        Me.btn_Administrative3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Administrative3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Administrative3.FlatAppearance.BorderSize = 0
        Me.btn_Administrative3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrative3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administrative3.ForeColor = System.Drawing.Color.White
        Me.btn_Administrative3.Location = New System.Drawing.Point(0, 80)
        Me.btn_Administrative3.Name = "btn_Administrative3"
        Me.btn_Administrative3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Administrative3.Size = New System.Drawing.Size(275, 40)
        Me.btn_Administrative3.TabIndex = 2
        Me.btn_Administrative3.Text = "btn_Administrative3"
        Me.btn_Administrative3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative3.UseVisualStyleBackColor = True
        '
        'btn_Administrative2
        '
        Me.btn_Administrative2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Administrative2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Administrative2.FlatAppearance.BorderSize = 0
        Me.btn_Administrative2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrative2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administrative2.ForeColor = System.Drawing.Color.White
        Me.btn_Administrative2.Location = New System.Drawing.Point(0, 40)
        Me.btn_Administrative2.Name = "btn_Administrative2"
        Me.btn_Administrative2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Administrative2.Size = New System.Drawing.Size(275, 40)
        Me.btn_Administrative2.TabIndex = 1
        Me.btn_Administrative2.Text = "btn_Administrative2"
        Me.btn_Administrative2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative2.UseVisualStyleBackColor = True
        '
        'btn_Administrative1
        '
        Me.btn_Administrative1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Administrative1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Administrative1.FlatAppearance.BorderSize = 0
        Me.btn_Administrative1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrative1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Administrative1.ForeColor = System.Drawing.Color.White
        Me.btn_Administrative1.Location = New System.Drawing.Point(0, 0)
        Me.btn_Administrative1.Name = "btn_Administrative1"
        Me.btn_Administrative1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btn_Administrative1.Size = New System.Drawing.Size(275, 40)
        Me.btn_Administrative1.TabIndex = 0
        Me.btn_Administrative1.Text = "Office Management"
        Me.btn_Administrative1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative1.UseVisualStyleBackColor = True
        '
        'btn_Administrative
        '
        Me.btn_Administrative.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Administrative.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Administrative.FlatAppearance.BorderSize = 0
        Me.btn_Administrative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Administrative.ForeColor = System.Drawing.Color.White
        Me.btn_Administrative.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative.Location = New System.Drawing.Point(0, 623)
        Me.btn_Administrative.Name = "btn_Administrative"
        Me.btn_Administrative.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_Administrative.Size = New System.Drawing.Size(275, 45)
        Me.btn_Administrative.TabIndex = 7
        Me.btn_Administrative.Text = "Administrative"
        Me.btn_Administrative.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Administrative.UseMnemonic = False
        Me.btn_Administrative.UseVisualStyleBackColor = True
        '
        'Panel_EHSMain_Child
        '
        Me.Panel_EHSMain_Child.AutoSize = True
        Me.Panel_EHSMain_Child.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel_EHSMain_Child.Controls.Add(Me.PictureBox2)
        Me.Panel_EHSMain_Child.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_EHSMain_Child.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_EHSMain_Child.Location = New System.Drawing.Point(275, 65)
        Me.Panel_EHSMain_Child.Name = "Panel_EHSMain_Child"
        Me.Panel_EHSMain_Child.Size = New System.Drawing.Size(1207, 917)
        Me.Panel_EHSMain_Child.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.EnviroHealthSafety.My.Resources.Resources.BofR_shield_cmyk
        Me.PictureBox2.Location = New System.Drawing.Point(453, 289)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel_EHSMain_Header
        '
        Me.Panel_EHSMain_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel_EHSMain_Header.Controls.Add(Me.btn_Minimize)
        Me.Panel_EHSMain_Header.Controls.Add(Me.btn_Maximize)
        Me.Panel_EHSMain_Header.Controls.Add(Me.btn_CloseDatabase)
        Me.Panel_EHSMain_Header.Controls.Add(Me.btn_Home)
        Me.Panel_EHSMain_Header.Controls.Add(Me.lbl_HeaderText)
        Me.Panel_EHSMain_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_EHSMain_Header.ForeColor = System.Drawing.Color.Black
        Me.Panel_EHSMain_Header.Location = New System.Drawing.Point(275, 0)
        Me.Panel_EHSMain_Header.Name = "Panel_EHSMain_Header"
        Me.Panel_EHSMain_Header.Size = New System.Drawing.Size(1207, 65)
        Me.Panel_EHSMain_Header.TabIndex = 2
        '
        'btn_Minimize
        '
        Me.btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btn_Minimize.IconColor = System.Drawing.Color.White
        Me.btn_Minimize.IconSize = 25
        Me.btn_Minimize.Location = New System.Drawing.Point(1057, 3)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Rotation = 0R
        Me.btn_Minimize.Size = New System.Drawing.Size(45, 25)
        Me.btn_Minimize.TabIndex = 4
        Me.btn_Minimize.UseVisualStyleBackColor = True
        '
        'btn_Maximize
        '
        Me.btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maximize.FlatAppearance.BorderSize = 0
        Me.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btn_Maximize.IconColor = System.Drawing.Color.White
        Me.btn_Maximize.IconSize = 25
        Me.btn_Maximize.Location = New System.Drawing.Point(1108, 3)
        Me.btn_Maximize.Name = "btn_Maximize"
        Me.btn_Maximize.Rotation = 0R
        Me.btn_Maximize.Size = New System.Drawing.Size(45, 25)
        Me.btn_Maximize.TabIndex = 3
        Me.btn_Maximize.UseVisualStyleBackColor = True
        '
        'btn_CloseDatabase
        '
        Me.btn_CloseDatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_CloseDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CloseDatabase.FlatAppearance.BorderSize = 0
        Me.btn_CloseDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CloseDatabase.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_CloseDatabase.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btn_CloseDatabase.IconColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_CloseDatabase.IconSize = 25
        Me.btn_CloseDatabase.Location = New System.Drawing.Point(1159, 3)
        Me.btn_CloseDatabase.Name = "btn_CloseDatabase"
        Me.btn_CloseDatabase.Rotation = 0R
        Me.btn_CloseDatabase.Size = New System.Drawing.Size(45, 25)
        Me.btn_CloseDatabase.TabIndex = 2
        Me.btn_CloseDatabase.UseVisualStyleBackColor = True
        '
        'btn_Home
        '
        Me.btn_Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Home.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Home.FlatAppearance.BorderSize = 0
        Me.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_Home.ForeColor = System.Drawing.Color.Transparent
        Me.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_Home.IconColor = System.Drawing.Color.White
        Me.btn_Home.IconSize = 35
        Me.btn_Home.Location = New System.Drawing.Point(0, 0)
        Me.btn_Home.Name = "btn_Home"
        Me.btn_Home.Rotation = 0R
        Me.btn_Home.Size = New System.Drawing.Size(50, 65)
        Me.btn_Home.TabIndex = 1
        Me.btn_Home.UseVisualStyleBackColor = False
        '
        'lbl_HeaderText
        '
        Me.lbl_HeaderText.AutoSize = True
        Me.lbl_HeaderText.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HeaderText.ForeColor = System.Drawing.Color.White
        Me.lbl_HeaderText.Location = New System.Drawing.Point(56, 9)
        Me.lbl_HeaderText.Name = "lbl_HeaderText"
        Me.lbl_HeaderText.Size = New System.Drawing.Size(96, 41)
        Me.lbl_HeaderText.TabIndex = 0
        Me.lbl_HeaderText.Text = "Home"
        '
        'frm_EHSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1482, 982)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_EHSMain_Child)
        Me.Controls.Add(Me.Panel_EHSMain_Header)
        Me.Controls.Add(Me.Panel_SideMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1500, 1000)
        Me.Name = "frm_EHSMain"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Environmental Health & Safety"
        Me.Panel_Logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ProductSubmenu.ResumeLayout(False)
        Me.Panel_WasteStreamSubMenu.ResumeLayout(False)
        Me.Panel_SideMenu.ResumeLayout(False)
        Me.Panel_MainBtmSubmenu.ResumeLayout(False)
        Me.Panel_MainBtmSubmenu.PerformLayout()
        Me.Panel_AdministrativeSubMenu.ResumeLayout(False)
        Me.Panel_EHSMain_Child.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_EHSMain_Header.ResumeLayout(False)
        Me.Panel_EHSMain_Header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Product As Button
    Friend WithEvents Panel_ProductSubmenu As Panel
    Friend WithEvents btn_Product_EditProduct As Button
    Friend WithEvents btn_Product_NewProduct As Button
    Friend WithEvents btn_Product_ChemicalInventory As Button
    Friend WithEvents btn_Product_SDSSearch As Button
    Friend WithEvents btn_WasteStream As Button
    Friend WithEvents Panel_WasteStreamSubMenu As Panel
    Friend WithEvents btn_WasteStream_4 As Button
    Friend WithEvents btn_WasteStream_3 As Button
    Friend WithEvents btn_WasteStream_2 As Button
    Friend WithEvents btn_WasteStream_1 As Button
    Friend WithEvents btn_Report As Button
    Friend WithEvents Panel_SideMenu As Panel
    Friend WithEvents Panel_MainBtmSubmenu As Panel
    Friend WithEvents btn_Help As Button
    Friend WithEvents Panel_AdministrativeSubMenu As Panel
    Friend WithEvents btn_Administrative4 As Button
    Friend WithEvents btn_Administrative3 As Button
    Friend WithEvents btn_Administrative2 As Button
    Friend WithEvents btn_Administrative1 As Button
    Friend WithEvents btn_Administrative As Button
    Friend WithEvents Panel_EHSMain_Child As Panel
    Friend WithEvents Panel_EHSMain_Header As Panel
    Friend WithEvents txt_Date As TextBox
    Friend WithEvents txt_Version As TextBox
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents lbl_HeaderText As Label
    Friend WithEvents btn_Home As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_CloseDatabase As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
