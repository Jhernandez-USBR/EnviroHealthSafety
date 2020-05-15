<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SDSSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SDSSearch))
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.dgv_ProductListResult = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductHazWasteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SDSNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDSProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDSActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QrySearchProductManufacturerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnviroHealthSafety = New EnviroHealthSafety()
        Me.btn_SDSSearch = New System.Windows.Forms.Button()
        Me.lbl_SearchSubstance = New System.Windows.Forms.Label()
        Me.txt_SearchSubstance = New System.Windows.Forms.TextBox()
        Me.lbl_SearchSDSNo = New System.Windows.Forms.Label()
        Me.btn_SDSClear = New System.Windows.Forms.Button()
        Me.txt_SearchManufacturer = New System.Windows.Forms.TextBox()
        Me.txt_SearchSDSNo = New System.Windows.Forms.TextBox()
        Me.lbl_SearchManufacturer = New System.Windows.Forms.Label()
        Me.Qry_SearchProductManufacturerTableAdapter = New EnviroHealthSafetyTableAdapters.qry_SearchProductManufacturerTableAdapter()
        Me.Panel_Main.SuspendLayout()
        CType(Me.dgv_ProductListResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QrySearchProductManufacturerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.AutoScroll = True
        Me.Panel_Main.AutoSize = True
        Me.Panel_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_Main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Main.Controls.Add(Me.dgv_ProductListResult)
        Me.Panel_Main.Controls.Add(Me.btn_SDSSearch)
        Me.Panel_Main.Controls.Add(Me.lbl_SearchSubstance)
        Me.Panel_Main.Controls.Add(Me.txt_SearchSubstance)
        Me.Panel_Main.Controls.Add(Me.lbl_SearchSDSNo)
        Me.Panel_Main.Controls.Add(Me.btn_SDSClear)
        Me.Panel_Main.Controls.Add(Me.txt_SearchManufacturer)
        Me.Panel_Main.Controls.Add(Me.txt_SearchSDSNo)
        Me.Panel_Main.Controls.Add(Me.lbl_SearchManufacturer)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(1184, 616)
        Me.Panel_Main.TabIndex = 10
        '
        'dgv_ProductListResult
        '
        Me.dgv_ProductListResult.AllowUserToAddRows = False
        Me.dgv_ProductListResult.AllowUserToDeleteRows = False
        Me.dgv_ProductListResult.AllowUserToOrderColumns = True
        Me.dgv_ProductListResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ProductListResult.AutoGenerateColumns = False
        Me.dgv_ProductListResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_ProductListResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_ProductListResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ProductListResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ManufacturerNameDataGridViewTextBoxColumn, Me.ProductHazWasteDataGridViewCheckBoxColumn, Me.SDSNumberDataGridViewTextBoxColumn, Me.SDSProductCodeDataGridViewTextBoxColumn, Me.SDSActiveDataGridViewCheckBoxColumn})
        Me.dgv_ProductListResult.DataSource = Me.QrySearchProductManufacturerBindingSource
        Me.dgv_ProductListResult.Location = New System.Drawing.Point(25, 363)
        Me.dgv_ProductListResult.Name = "dgv_ProductListResult"
        Me.dgv_ProductListResult.ReadOnly = True
        Me.dgv_ProductListResult.RowHeadersWidth = 51
        Me.dgv_ProductListResult.RowTemplate.Height = 24
        Me.dgv_ProductListResult.Size = New System.Drawing.Size(1134, 241)
        Me.dgv_ProductListResult.TabIndex = 8
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Visible = False
        Me.ProductIDDataGridViewTextBoxColumn.Width = 107
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ManufacturerNameDataGridViewTextBoxColumn
        '
        Me.ManufacturerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ManufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer_Name"
        Me.ManufacturerNameDataGridViewTextBoxColumn.HeaderText = " Manufacturer"
        Me.ManufacturerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManufacturerNameDataGridViewTextBoxColumn.Name = "ManufacturerNameDataGridViewTextBoxColumn"
        Me.ManufacturerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductHazWasteDataGridViewCheckBoxColumn
        '
        Me.ProductHazWasteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductHazWasteDataGridViewCheckBoxColumn.DataPropertyName = "Product_HazWaste"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.HeaderText = "Hazardous Waste"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ProductHazWasteDataGridViewCheckBoxColumn.Name = "ProductHazWasteDataGridViewCheckBoxColumn"
        Me.ProductHazWasteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProductHazWasteDataGridViewCheckBoxColumn.Width = 165
        '
        'SDSNumberDataGridViewTextBoxColumn
        '
        Me.SDSNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SDSNumberDataGridViewTextBoxColumn.DataPropertyName = "SDS_Number"
        Me.SDSNumberDataGridViewTextBoxColumn.HeaderText = "SDS Number"
        Me.SDSNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SDSNumberDataGridViewTextBoxColumn.Name = "SDSNumberDataGridViewTextBoxColumn"
        Me.SDSNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.SDSNumberDataGridViewTextBoxColumn.Width = 151
        '
        'SDSProductCodeDataGridViewTextBoxColumn
        '
        Me.SDSProductCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SDSProductCodeDataGridViewTextBoxColumn.DataPropertyName = "SDS_ProductCode"
        Me.SDSProductCodeDataGridViewTextBoxColumn.HeaderText = "Product Code"
        Me.SDSProductCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SDSProductCodeDataGridViewTextBoxColumn.Name = "SDSProductCodeDataGridViewTextBoxColumn"
        Me.SDSProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SDSProductCodeDataGridViewTextBoxColumn.Width = 156
        '
        'SDSActiveDataGridViewCheckBoxColumn
        '
        Me.SDSActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SDSActiveDataGridViewCheckBoxColumn.DataPropertyName = "SDS_Active"
        Me.SDSActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.SDSActiveDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.SDSActiveDataGridViewCheckBoxColumn.Name = "SDSActiveDataGridViewCheckBoxColumn"
        Me.SDSActiveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SDSActiveDataGridViewCheckBoxColumn.Width = 69
        '
        'QrySearchProductManufacturerBindingSource
        '
        Me.QrySearchProductManufacturerBindingSource.DataMember = "qry_SearchProductManufacturer"
        Me.QrySearchProductManufacturerBindingSource.DataSource = Me.EnviroHealthSafety
        '
        'EnviroHealthSafety
        '
        Me.EnviroHealthSafety.DataSetName = "EnviroHealthSafety"
        Me.EnviroHealthSafety.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_SDSSearch
        '
        Me.btn_SDSSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SDSSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_SDSSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SDSSearch.FlatAppearance.BorderSize = 0
        Me.btn_SDSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SDSSearch.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SDSSearch.ForeColor = System.Drawing.Color.White
        Me.btn_SDSSearch.Location = New System.Drawing.Point(1009, 295)
        Me.btn_SDSSearch.Name = "btn_SDSSearch"
        Me.btn_SDSSearch.Size = New System.Drawing.Size(150, 50)
        Me.btn_SDSSearch.TabIndex = 7
        Me.btn_SDSSearch.Text = "Search"
        Me.btn_SDSSearch.UseVisualStyleBackColor = False
        '
        'lbl_SearchSubstance
        '
        Me.lbl_SearchSubstance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SearchSubstance.AutoSize = True
        Me.lbl_SearchSubstance.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SearchSubstance.Location = New System.Drawing.Point(18, 10)
        Me.lbl_SearchSubstance.Name = "lbl_SearchSubstance"
        Me.lbl_SearchSubstance.Size = New System.Drawing.Size(146, 38)
        Me.lbl_SearchSubstance.TabIndex = 1
        Me.lbl_SearchSubstance.Text = "Substance"
        '
        'txt_SearchSubstance
        '
        Me.txt_SearchSubstance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SearchSubstance.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SearchSubstance.Location = New System.Drawing.Point(25, 51)
        Me.txt_SearchSubstance.Name = "txt_SearchSubstance"
        Me.txt_SearchSubstance.Size = New System.Drawing.Size(1134, 43)
        Me.txt_SearchSubstance.TabIndex = 0
        '
        'lbl_SearchSDSNo
        '
        Me.lbl_SearchSDSNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SearchSDSNo.AutoSize = True
        Me.lbl_SearchSDSNo.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SearchSDSNo.Location = New System.Drawing.Point(18, 184)
        Me.lbl_SearchSDSNo.Name = "lbl_SearchSDSNo"
        Me.lbl_SearchSDSNo.Size = New System.Drawing.Size(279, 38)
        Me.lbl_SearchSDSNo.TabIndex = 5
        Me.lbl_SearchSDSNo.Text = "SDS No. | Product ID"
        '
        'btn_SDSClear
        '
        Me.btn_SDSClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btn_SDSClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SDSClear.FlatAppearance.BorderSize = 0
        Me.btn_SDSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SDSClear.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SDSClear.ForeColor = System.Drawing.Color.White
        Me.btn_SDSClear.Location = New System.Drawing.Point(25, 295)
        Me.btn_SDSClear.Name = "btn_SDSClear"
        Me.btn_SDSClear.Size = New System.Drawing.Size(150, 50)
        Me.btn_SDSClear.TabIndex = 6
        Me.btn_SDSClear.Text = "Clear"
        Me.btn_SDSClear.UseVisualStyleBackColor = False
        '
        'txt_SearchManufacturer
        '
        Me.txt_SearchManufacturer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SearchManufacturer.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SearchManufacturer.Location = New System.Drawing.Point(25, 138)
        Me.txt_SearchManufacturer.Name = "txt_SearchManufacturer"
        Me.txt_SearchManufacturer.Size = New System.Drawing.Size(1134, 43)
        Me.txt_SearchManufacturer.TabIndex = 2
        '
        'txt_SearchSDSNo
        '
        Me.txt_SearchSDSNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SearchSDSNo.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SearchSDSNo.Location = New System.Drawing.Point(25, 225)
        Me.txt_SearchSDSNo.Name = "txt_SearchSDSNo"
        Me.txt_SearchSDSNo.Size = New System.Drawing.Size(1134, 43)
        Me.txt_SearchSDSNo.TabIndex = 4
        '
        'lbl_SearchManufacturer
        '
        Me.lbl_SearchManufacturer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SearchManufacturer.AutoSize = True
        Me.lbl_SearchManufacturer.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SearchManufacturer.Location = New System.Drawing.Point(18, 97)
        Me.lbl_SearchManufacturer.Name = "lbl_SearchManufacturer"
        Me.lbl_SearchManufacturer.Size = New System.Drawing.Size(189, 38)
        Me.lbl_SearchManufacturer.TabIndex = 3
        Me.lbl_SearchManufacturer.Text = "Manufacturer"
        '
        'Qry_SearchProductManufacturerTableAdapter
        '
        Me.Qry_SearchProductManufacturerTableAdapter.ClearBeforeFill = True
        '
        'frm_SDSSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1184, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Main)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "frm_SDSSearch"
        Me.Text = "SDS Search"
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        CType(Me.dgv_ProductListResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QrySearchProductManufacturerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnviroHealthSafety, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents btn_SDSSearch As Button
    Friend WithEvents lbl_SearchSubstance As Label
    Friend WithEvents txt_SearchSubstance As TextBox
    Friend WithEvents lbl_SearchSDSNo As Label
    Friend WithEvents btn_SDSClear As Button
    Friend WithEvents txt_SearchManufacturer As TextBox
    Friend WithEvents txt_SearchSDSNo As TextBox
    Friend WithEvents lbl_SearchManufacturer As Label
    Friend WithEvents dgv_ProductListResult As DataGridView
    Friend WithEvents QrySearchProductManufacturerBindingSource As BindingSource
    Friend WithEvents EnviroHealthSafety As EnviroHealthSafety
    Friend WithEvents Qry_SearchProductManufacturerTableAdapter As EnviroHealthSafetyTableAdapters.qry_SearchProductManufacturerTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductHazWasteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SDSNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDSProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDSActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
